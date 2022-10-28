using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
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
using ns7;
using ns8;
using ns9;

namespace ns6;

public class GClass1
{
	internal static int smethod_0(int int_0, int int_1)
	{
		return checked(int_0 + 110 + int_1 * 5);
	}

	internal static byte[] smethod_1(string[] string_0, int int_0)
	{
		checked
		{
			byte[] array = new byte[int_0 + 1];
			int num = 0;
			foreach (string value in string_0)
			{
				array[num] = (byte)Convert.ToInt32(value);
				num++;
			}
			return array;
		}
	}

	unsafe static void smethod_2()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object[] reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] array2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object reference2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] array3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string[] array4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out FieldInfo[] array5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class7 @class);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class4 class7);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass3 gClass);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct1 struct2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class6 class8);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct2 @struct);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags);
		while (obj != null)
		{
			try
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					bindingFlags = default(BindingFlags);
					bindingFlags = bindingFlags;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_ = bindingFlags;
					array = null;
					MethodBase[] methodBase_ = array;
					obj = Class5.Default;
					ref object[] object_ = ref *(object[]*)((Class7)null).t(obj, (Type)null, (CultureInfo)(object)Class5.Default);
					@class = (Class7)(object)Class5.Default;
					Class7 class2 = @class;
					BindingFlags bindingFlags_2 = bindingFlags;
					MethodBase[] methodBase_2 = array;
					reference = ref reference;
					ref object[] object_2 = ref reference;
					Class7 class3 = @class;
					Class7 class4 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_3 = bindingFlags;
					MethodBase[] methodBase_3 = array;
					array2 = null;
					BindingFlags bindingFlags_4 = (BindingFlags)class4.e(bindingFlags_3, methodBase_3, array2, null);
					MethodBase[] methodBase_4 = (MethodBase[])(object)Class5.Default;
					Class7 class5 = @class;
					BindingFlags bindingFlags_5 = bindingFlags;
					MethodBase[] methodBase_5 = array;
					BindingFlags bindingFlags_6 = bindingFlags;
					cultureInfo = (CultureInfo)(object)Class5.Default;
					ParameterModifier[] parameterModifier_ = (ParameterModifier[])(object)((Class7)null).t(bindingFlags_6, (FieldInfo[])null, (object)null, cultureInfo);
					CultureInfo cultureInfo_ = cultureInfo;
					string[] string_ = (string[])(object)Class5.Default;
					reference2 = ref reference2;
					array3 = (ParameterModifier[])(object)class3.j(bindingFlags_4, methodBase_4, ref *(object[]*)null, (ParameterModifier[])(object)class5.j(bindingFlags_5, methodBase_5, ref *(object[]*)null, parameterModifier_, cultureInfo_, string_, out reference2), (CultureInfo)(object)Class5.Default, null, out reference2);
					ParameterModifier[] parameterModifier_2 = array3;
					CultureInfo cultureInfo_2 = (CultureInfo)(object)Class5.Default;
					Class7 class6 = @class;
					BindingFlags bindingFlags_7 = bindingFlags;
					MethodBase[] methodBase_6 = array;
					ref object[] object_3 = ref reference;
					CultureInfo cultureInfo_3 = cultureInfo;
					array4 = null;
					ParameterModifier[] parameterModifier_3 = (ParameterModifier[])(object)class2.j(bindingFlags_2, methodBase_2, ref object_2, parameterModifier_2, cultureInfo_2, null, out *(object*)class6.j(bindingFlags_7, methodBase_6, ref object_3, null, cultureInfo_3, array4, out *(object*)null));
					string[] string_2 = array4;
					Class7 obj2 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_8 = bindingFlags;
					array5 = (FieldInfo[])(object)Class5.Default;
					_ = (Class0)(object)((Class7)null).j(bindingFlags_, methodBase_, ref object_, parameterModifier_3, (CultureInfo)null, string_2, out *(object*)((Class7)(object)obj2.t(bindingFlags_8, array5, null, cultureInfo)).e(bindingFlags, null, array2, array3));
					class7 = class7;
					class7 = null;
				}
				else
				{
					class8 = (Class6)(object)((Class7)(object)Class5.Default).t(bindingFlags, null, obj, cultureInfo);
					class8 = class8;
				}
			}
			catch
			{
				try
				{
					@struct = @struct;
					@struct = @struct;
					_003CModule_003E = _003CModule_003E;
					_003CModule_003E = _003CModule_003E;
					_ = (Class8)(object)Class5.Default;
				}
				catch
				{
					_ = (Class0)(object)Class5.Default;
					gClass = null;
					gClass = null;
					Struct1 obj3 = (Struct1)Class5.Default;
					struct2 = struct2;
					struct2 = obj3;
				}
			}
		}
		struct2 = default(Struct1);
		GClass0 gClass2 = null;
		gClass2 = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass2 gClass3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class5 class9);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out UIntPtr num2);
		checked
		{
			nuint num = unchecked((nuint)(UIntPtr)@class.t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, null, cultureInfo)) - unchecked((nuint)(UIntPtr)Class5.Default);
			num2 = num2 + num2 + unchecked((nuint)default(UIntPtr));
			nuint num3 = num * ((unchecked((nuint)default(UIntPtr)) + unchecked((nuint)(UIntPtr)Class5.Default)) * (unchecked((nuint)default(UIntPtr)) * unchecked((nuint)(UIntPtr)Class5.Default)));
			num2 = default(UIntPtr);
			if (num3 * (num2 - num2) == 0)
			{
				_ = (Class8)(object)@class.e(unchecked((BindingFlags)@class.j((BindingFlags)Class5.Default, null, ref reference, array3, cultureInfo, null, out reference2)), (MethodBase[])(object)Class5.Default, null, array3);
			}
			else
			{
				class9 = null;
				class9 = class9;
			}
			gClass3 = gClass3;
			gClass3 = gClass3;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type);
		while (obj != null)
		{
			do
			{
				if (num2 != 0)
				{
					Class7 class10 = @class;
					object object_4 = Class5.Default;
					Class7 class11 = @class;
					object object_5 = Class5.Default;
					type = null;
					_ = (Class7)(object)((Class7)null).t((BindingFlags)class10.t(object_4, (Type)class11.t(object_5, type, null), (CultureInfo)(object)@class.t((BindingFlags)Class5.Default, null, null, cultureInfo)), array5, obj, (CultureInfo)null);
				}
				else
				{
					_ = (_003CModule_003E)(object)((Class7)(object)Class5.Default).j(default(BindingFlags), array, ref reference, array3, null, array4, out reference2);
				}
			}
			while (obj != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] array6);
		do
		{
			_ = (GClass0)(object)Class5.Default;
			Class7 class12 = @class;
			Class7 class13 = @class;
			bindingFlags = default(BindingFlags);
			Class7 obj6 = (Class7)(object)class13.t(bindingFlags, null, obj, (CultureInfo)(object)Class5.Default);
			Class7 class14 = @class;
			BindingFlags bindingFlags_9 = (BindingFlags)Class5.Default;
			MethodBase[] methodBase_7 = (MethodBase[])(object)Class5.Default;
			ref object[] object_6 = ref reference;
			Class7 class15 = @class;
			Class7 obj7 = (Class7)(object)Class5.Default;
			Class7 obj8 = (Class7)(object)@class.e(bindingFlags, array, array2, (ParameterModifier[])(object)((Class7)(object)@class.t((BindingFlags)((Class7)(object)Class5.Default).e(bindingFlags, array, array2, array3), array5, obj, cultureInfo)).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, null, cultureInfo, (string[])(object)@class.e(bindingFlags, array, null, null), out *(object*)null));
			BindingFlags bindingFlags_10 = (BindingFlags)Class5.Default;
			MethodBase[] methodBase_8 = array;
			Class7 class16 = @class;
			BindingFlags bindingFlags_11 = bindingFlags;
			array6 = array6;
			_ = (Struct1)class12.j((BindingFlags)((Class7)null).t((object)null, (Type)(object)obj6.t((BindingFlags)class14.j(bindingFlags_9, methodBase_7, ref object_6, null, (CultureInfo)(object)class15.t((BindingFlags)obj7.e((BindingFlags)((Class7)(object)obj8.j(bindingFlags_10, methodBase_8, ref *(object[]*)class16.W(bindingFlags_11, array6, type, array2, null), null, cultureInfo, (string[])(object)@class.W((BindingFlags)((Class7)@class.t(obj, (Type)(object)Class5.Default, cultureInfo)).t(((Class7)(object)((Class7)null).j((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, (ParameterModifier[])null, cultureInfo, (string[])(object)Class5.Default, out *(object*)@class.W((BindingFlags)Class5.Default, (PropertyInfo[])(object)Class5.Default, type, (Type[])(object)Class5.Default, null))).t(null, null, cultureInfo), null, null), array6, type, array2, array3), out *(object*)null)).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, null), array, array2, array3), (FieldInfo[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, (CultureInfo)(object)Class5.Default), ((Class7)(object)Class5.Default).j(bindingFlags, (MethodBase[])@class.t(Class5.Default, type, (CultureInfo)(object)Class5.Default), ref reference, array3, (CultureInfo)(object)Class5.Default, null, out *(object*)((Class7)(object)Class5.Default).t(null, type, cultureInfo)), cultureInfo), null, out reference2), array5, Class5.Default, null), cultureInfo), array, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, array4, out reference2);
		}
		while (obj != null);
		num2 = default(UIntPtr);
		if (num2 != (UIntPtr)(nuint)0u && num2 == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (GClass2)(object)Class5.Default;
			}
			finally
			{
				class8 = class8;
				goto IL_07af;
			}
		}
		goto IL_07af;
		IL_262e:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass1 gClass4);
		checked
		{
			if (num2 - unchecked((nuint)(UIntPtr)Class5.Default) == 0)
			{
				num2 = default(UIntPtr);
				if (unchecked(unchecked((nuint)default(UIntPtr)) / num2) + (num2 - num2) == 0)
				{
					num2 = default(UIntPtr);
					if (num2 * unchecked((nuint)(UIntPtr)Class5.Default) == 0)
					{
						Class7 class17 = @class;
						MethodBase[] methodBase_9 = (MethodBase[])(object)Class5.Default;
						ParameterModifier[] parameterModifier_4 = array3;
						CultureInfo cultureInfo_4 = cultureInfo;
						bindingFlags = default(BindingFlags);
						_ = (Class0)(object)unchecked(class17.j(default(BindingFlags), methodBase_9, ref *(object[]*)null, parameterModifier_4, cultureInfo_4, (string[])(object)((Class7)null).t((BindingFlags)((Class7)(object)((Class7)null).t(bindingFlags, array5, obj, (CultureInfo)null)).j(bindingFlags, array, ref reference, array3, null, array4, out reference2), array5, obj, cultureInfo), out *(object*)null));
					}
					else
					{
						gClass4 = (GClass1)(object)Class5.Default;
					}
				}
			}
			_ = (GClass0)(object)Class5.Default;
			class9 = null;
			_ = (Struct1)Class5.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class8 class18);
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			class18 = class18;
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			gClass2 = (GClass0)@class.t(obj, null, cultureInfo);
		}
		else
		{
			nuint num4 = num2;
			bindingFlags = default(BindingFlags);
			checked
			{
				if (num4 + unchecked((nuint)(UIntPtr)((Class7)null).e(bindingFlags, array, array2, array3)) * num2 == 0)
				{
					_ = (Class7)((Class7)(object)Class5.Default).t(obj, (Type)(object)Class5.Default, null);
				}
				else
				{
					try
					{
						gClass = null;
						struct2 = default(Struct1);
						struct2 = struct2;
						Class7 obj9 = (Class7)(object)Class5.Default;
						BindingFlags bindingFlags_12 = bindingFlags;
						Type[] type_ = array2;
						Class7 class19 = @class;
						bindingFlags = default(BindingFlags);
						_ = (_003CModule_003E)((Class7)(object)obj9.e(bindingFlags_12, null, type_, (ParameterModifier[])((Class7)(object)class19.W(bindingFlags, null, type, null, array3)).t(null, type, cultureInfo))).t(obj, type, cultureInfo);
					}
					catch
					{
						@class = null;
					}
				}
			}
		}
		num2 = default(UIntPtr);
		if (num2 == 0)
		{
			gClass = gClass;
			goto IL_28ce;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qk7 qk);
		try
		{
			@class = null;
			qk = qk;
		}
		finally
		{
			do
			{
				_ = (Class6)((Class7)@class.t(null, (Type)(object)Class5.Default, null)).t(obj, type, null);
			}
			while (obj != null);
			goto IL_28ce;
		}
		IL_180f:
		num2 = default(UIntPtr);
		if (num2 == 0)
		{
			_ = (GClass3)(object)Class5.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class10 class21);
		if (num2 == 0)
		{
			Class7 obj11 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_13 = bindingFlags;
			Class7 class20 = @class;
			BindingFlags bindingFlags_14 = bindingFlags;
			BindingFlags bindingFlags_15 = (BindingFlags)@class.t(obj, type, null);
			bindingFlags = default(BindingFlags);
			if ((nuint)(UIntPtr)obj11.t(bindingFlags_13, null, null, (CultureInfo)(object)class20.W(bindingFlags_14, (PropertyInfo[])(object)((Class7)null).e(bindingFlags_15, (MethodBase[])null, (Type[])(object)((Class7)null).e(bindingFlags, array, (Type[])null, array3), (ParameterModifier[])(object)Class5.Default), type, (Type[])(object)Class5.Default, array3)) / checked(unchecked((nuint)(UIntPtr)((Class7)((Class7)@class.t(@class.t(bindingFlags, array5, obj, (CultureInfo)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)@class.e(bindingFlags, array, (Type[])(object)Class5.Default, null), cultureInfo, array4, out *(object*)null)), type, cultureInfo)).t(null, (Type)(object)Class5.Default, null)).W(bindingFlags, (PropertyInfo[])((Class7)null).t((object)null, type, cultureInfo), type, null, array3)) - unchecked((nuint)(UIntPtr)Class5.Default) + unchecked((nuint)(UIntPtr)Class5.Default)) == 0)
			{
				do
				{
					class21 = (Class10)(object)Class5.Default;
				}
				while ((object)Class5.Default != null);
			}
			else
			{
				do
				{
					_ = (Class8)(object)Class5.Default;
				}
				while (obj != null);
			}
		}
		else
		{
			do
			{
				class18 = (Class8)(object)Class5.Default;
			}
			while ((object)Class5.Default != null);
		}
		gClass4 = (GClass1)@class.t(obj, null, (CultureInfo)(object)Class5.Default);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class2 class22);
		try
		{
			try
			{
				class22 = (Class2)(object)((Class7)null).j((BindingFlags)Class5.Default, array, ref reference, array3, (CultureInfo)null, (string[])(object)Class5.Default, out *(object*)Class5.Default);
				@struct = default(Struct2);
				_003CModule_003E = null;
				class9 = class9;
			}
			finally
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					Class7 class23 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class5)(object)class23.t(bindingFlags, array5, null, cultureInfo);
				}
				else
				{
					_ = (Qk7)(object)Class5.Default;
				}
				goto end_IL_19f8;
			}
			end_IL_19f8:;
		}
		catch
		{
			checked
			{
				if (unchecked((nuint)(UIntPtr)Class5.Default) + num2 == 0)
				{
					_ = (Class9)((Class7)null).t(obj, (Type)null, cultureInfo);
					_ = (Struct1)Class5.Default;
				}
			}
		}
		try
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Class5)(object)((Class7)null).t((BindingFlags)Class5.Default, array5, (object)null, cultureInfo);
			}
		}
		finally
		{
			while ((object)@class.j((BindingFlags)((Class7)null).t(obj, type, (CultureInfo)null), (MethodBase[])(object)Class5.Default, ref reference, null, cultureInfo, null, out reference2) != null)
			{
				do
				{
					Class7 class24 = @class;
					BindingFlags bindingFlags_16 = bindingFlags;
					Class7 obj13 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Struct2)class24.W(bindingFlags_16, null, (Type)(object)obj13.j((BindingFlags)((Class7)null).j(bindingFlags, (MethodBase[])(object)@class.j((BindingFlags)Class5.Default, array, ref *(object[]*)null, array3, cultureInfo, (string[])(object)Class5.Default, out reference2), ref *(object[]*)null, array3, cultureInfo, array4, out reference2), null, ref *(object[]*)null, null, null, array4, out reference2), array2, array3);
					qk = (Qk7)(object)@class.j(bindingFlags, array, ref reference, null, cultureInfo, null, out reference2);
					_ = (Struct2)@class.j(bindingFlags, array, ref reference, array3, null, array4, out *(object*)((Class7)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)(object)Class5.Default, (Type[])null, (ParameterModifier[])null)).t((BindingFlags)((Class7)null).t(default(BindingFlags), (FieldInfo[])null, obj, (CultureInfo)(object)Class5.Default), array5, null, cultureInfo));
					bindingFlags = default(BindingFlags);
					_ = (GClass2)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, array3);
				}
				while (obj != null);
			}
			goto IL_1cba;
		}
		IL_42d9:
		if ((UIntPtr)@class.t(obj, type, null) == (UIntPtr)(nuint)0u)
		{
			_ = (GClass2)@class.t(obj, type, cultureInfo);
		}
		else
		{
			try
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					gClass3 = gClass3;
				}
			}
			catch
			{
				_ = (Class10)(object)Class5.Default;
			}
		}
		_ = (GClass1)(object)((Class7)null).t(bindingFlags, (FieldInfo[])@class.t(obj, null, cultureInfo), obj, cultureInfo);
		nuint num5 = num2;
		nuint num6 = num2;
		num2 = default(UIntPtr);
		checked
		{
			nuint num7 = num5 * (unchecked(num6 / num2) - unchecked(checked(num2 * num2) / (nuint)(UIntPtr)@class.j(bindingFlags, array, ref reference, null, cultureInfo, null, out reference2)));
			num2 = default(UIntPtr);
			if (num7 - num2 == 0)
			{
				@struct = default(Struct2);
			}
		}
		if (num2 == 0)
		{
			try
			{
				_ = (Struct1)@class.j((BindingFlags)((Class7)null).e((BindingFlags)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, array5, obj, cultureInfo), (MethodBase[])(object)((Class7)(object)Class5.Default).t(bindingFlags, array5, null, null), array2, array3), array, ref *(object[]*)Class5.Default, null, cultureInfo, array4, out *(object*)null);
			}
			catch
			{
				_ = (Class10)(object)@class.j(bindingFlags, array, ref reference, array3, (CultureInfo)(object)@class.W(bindingFlags, null, type, (Type[])(object)Class5.Default, array3), array4, out reference2);
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class0 class25);
		try
		{
			try
			{
				while ((object)@class.W(default(BindingFlags), null, null, null, null) != null)
				{
					_ = (Qk7)(object)Class5.Default;
				}
			}
			finally
			{
				while (obj != null)
				{
					class18 = class18;
				}
				goto end_IL_44ab;
			}
			end_IL_44ab:;
		}
		finally
		{
			do
			{
				try
				{
					class25 = class25;
				}
				finally
				{
					_ = (GClass2)(object)Class5.Default;
					continue;
				}
			}
			while ((object)Class5.Default != null);
			goto IL_451a;
		}
		IL_0ddc:
		num2 = default(UIntPtr);
		if (num2 == 0)
		{
			while (obj != null)
			{
				do
				{
					class22 = (Class2)(object)Class5.Default;
					class22 = null;
					_ = (Struct2)Class5.Default;
				}
				while (obj != null);
			}
		}
		do
		{
			try
			{
				nuint num8 = num2;
				UIntPtr num9 = (UIntPtr)Class5.Default;
				num2 = default(UIntPtr);
				checked
				{
					if (num8 * unchecked((nuint)num9 / num2) == 0)
					{
						_ = (Class0)(object)Class5.Default;
						continue;
					}
					@struct = @struct;
					class21 = class21;
				}
				gClass = (GClass3)(object)@class.W((BindingFlags)Class5.Default, (PropertyInfo[])(object)Class5.Default, type, null, array3);
			}
			catch
			{
				_ = (Class2)(object)Class5.Default;
			}
		}
		while (obj != null);
		while (true)
		{
			if (obj != null)
			{
				_ = (GClass3)(object)Class5.Default;
			}
			else if ((object)Class5.Default == null)
			{
				break;
			}
		}
		class8 = class8;
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			Class7 class26 = @class;
			bindingFlags = default(BindingFlags);
			struct2 = (Struct1)class26.e(bindingFlags, (MethodBase[])@class.t(((Class7)@class.t(obj, null, (CultureInfo)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference, array3, cultureInfo, (string[])null, out *(object*)null))).j(bindingFlags, null, ref reference, array3, cultureInfo, (string[])(object)@class.t((BindingFlags)Class5.Default, (FieldInfo[])(object)((Class7)null).e(default(BindingFlags), array, array2, array3), null, cultureInfo), out reference2), null, null), array2, array3);
		}
		else
		{
			try
			{
				_ = (GClass2)(object)Class5.Default;
			}
			catch
			{
				num2 = default(UIntPtr);
				if (num2 == 0)
				{
					_ = (GClass3)(object)Class5.Default;
				}
			}
		}
		do
		{
			try
			{
				try
				{
					class18 = class18;
				}
				finally
				{
					_ = (Class9)(object)Class5.Default;
					goto end_IL_0fd8;
				}
				end_IL_0fd8:;
			}
			catch
			{
				try
				{
					gClass4 = (GClass1)(object)Class5.Default;
				}
				finally
				{
					_ = (Class7)(object)Class5.Default;
					goto end_IL_0ff2;
				}
				end_IL_0ff2:;
			}
		}
		while (obj != null);
		Class7 obj19 = (Class7)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		if ((UIntPtr)obj19.W(bindingFlags, null, (Type)(object)Class5.Default, array2, null) == (UIntPtr)(nuint)0u)
		{
			_ = (Struct1)Class5.Default;
		}
		Class7 class27 = @class;
		BindingFlags bindingFlags_17 = bindingFlags;
		Class7 class28 = @class;
		BindingFlags bindingFlags_18 = bindingFlags;
		Class7 class29 = @class;
		BindingFlags bindingFlags_19 = (BindingFlags)@class.j(default(BindingFlags), null, ref *(object[]*)Class5.Default, array3, cultureInfo, array4, out *(object*)null);
		Class7 obj20 = (Class7)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		MethodBase[] methodBase_10 = (MethodBase[])(object)obj20.e(bindingFlags, (MethodBase[])(object)@class.j(bindingFlags, null, ref *(object[]*)@class.j(bindingFlags, (MethodBase[])(object)((Class7)null).W(bindingFlags, array6, type, (Type[])null, array3), ref *(object[]*)null, (ParameterModifier[])@class.t(obj, type, null), cultureInfo, array4, out reference2), null, null, array4, out *(object*)null), array2, null);
		Class7 class30 = @class;
		bindingFlags = default(BindingFlags);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class9 class36);
		if (checked(unchecked(checked(unchecked((nuint)(UIntPtr)class27.W(bindingFlags_17, null, (Type)(object)class28.W(bindingFlags_18, (PropertyInfo[])(object)class29.t(bindingFlags_19, null, null, (CultureInfo)(object)((Class7)null).e(default(BindingFlags), methodBase_10, (Type[])(object)class30.t(bindingFlags, null, Class5.Default, cultureInfo), array3)), (Type)(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, null, array3), array2, array3), null, array3)) - num2) / (nuint)(UIntPtr)@class.e((BindingFlags)@class.e(bindingFlags, array, null, array3), array, array2, null)) - unchecked((nuint)(UIntPtr)@class.e(bindingFlags, array, array2, null))) == 0)
		{
			try
			{
				while (obj != null)
				{
					_ = (Class6)(object)@class.W(bindingFlags, null, null, array2, null);
				}
			}
			catch
			{
				bindingFlags = default(BindingFlags);
				if ((UIntPtr)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, (object)null, (CultureInfo)(object)@class.e(bindingFlags, array, null, null)) == (UIntPtr)(nuint)0u)
				{
					Class7 class31 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_20 = bindingFlags;
					MethodBase[] methodBase_11 = array;
					Class7 class32 = @class;
					BindingFlags bindingFlags_21 = bindingFlags;
					FieldInfo[] fieldInfo_ = array5;
					Class7 class33 = @class;
					MethodBase[] methodBase_12 = array;
					Class7 obj21 = (Class7)(object)Class5.Default;
					PropertyInfo[] propertyInfo_ = array6;
					Class7 obj22 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					Type type_2 = (Type)(object)obj22.j(bindingFlags, array, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo, null, out *(object*)null);
					Class7 class34 = @class;
					BindingFlags bindingFlags_22 = bindingFlags;
					MethodBase[] methodBase_13 = (MethodBase[])(object)@class.e((BindingFlags)@class.t(obj, type, null), null, array2, array3);
					ref object[] object_7 = ref *(object[]*)Class5.Default;
					ParameterModifier[] parameterModifier_5 = array3;
					CultureInfo cultureInfo_5 = (CultureInfo)(object)((Class7)null).e(bindingFlags, array, array2, (ParameterModifier[])null);
					Class7 obj23 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					ParameterModifier[] parameterModifier_6 = (ParameterModifier[])(object)class32.t(bindingFlags_21, fieldInfo_, class33.e(default(BindingFlags), methodBase_12, (Type[])(object)obj21.W(default(BindingFlags), propertyInfo_, type_2, (Type[])(object)((Class7)(object)class34.j(bindingFlags_22, methodBase_13, ref object_7, parameterModifier_5, cultureInfo_5, (string[])(object)obj23.j(bindingFlags, array, ref *(object[]*)null, array3, (CultureInfo)((Class7)null).t((object)null, (Type)null, cultureInfo), (string[])((Class7)((Class7)(object)Class5.Default).t(null, type, cultureInfo)).t(Class5.Default, type, cultureInfo), out reference2), out reference2)).j(bindingFlags, null, ref reference, array3, (CultureInfo)(object)Class5.Default, array4, out *(object*)null), (ParameterModifier[])(object)Class5.Default), array3), null);
					Class7 class35 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_23 = bindingFlags;
					MethodBase[] methodBase_14 = array;
					ParameterModifier[] parameterModifier_7 = (ParameterModifier[])(object)((Class7)null).e(bindingFlags, array, array2, array3);
					CultureInfo cultureInfo_6 = cultureInfo;
					Class7 obj24 = (Class7)@class.t(obj, (Type)(object)Class5.Default, cultureInfo);
					bindingFlags = default(BindingFlags);
					_ = (Class8)(object)class31.j(bindingFlags_20, methodBase_11, ref *(object[]*)null, parameterModifier_6, (CultureInfo)(object)class35.j(bindingFlags_23, methodBase_14, ref *(object[]*)null, parameterModifier_7, cultureInfo_6, (string[])(object)obj24.j(bindingFlags, null, ref *(object[]*)Class5.Default, array3, cultureInfo, null, out reference2), out reference2), null, out reference2);
				}
				else
				{
					_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
					gClass3 = gClass3;
				}
			}
		}
		else
		{
			while ((object)Class5.Default != null)
			{
				if ((nuint)(UIntPtr)((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])(object)Class5.Default, null, (ParameterModifier[])(object)Class5.Default) / num2 == 0)
				{
					struct2 = default(Struct1);
					class36 = class36;
					class36 = class36;
					_ = (Class4)(object)@class.j((BindingFlags)Class5.Default, array, ref reference, array3, cultureInfo, array4, out *(object*)((Class7)(object)Class5.Default).e(bindingFlags, array, array2, null));
					class22 = class22;
				}
			}
		}
		try
		{
			try
			{
				while (obj != null)
				{
					gClass = gClass;
					_ = (GClass2)(object)Class5.Default;
					_ = (GClass1)(object)Class5.Default;
				}
			}
			finally
			{
				_ = (_003CModule_003E)(object)Class5.Default;
				@class = null;
				Class7 obj26 = (Class7)(object)((Class7)null).e(bindingFlags, array, (Type[])(object)Class5.Default, array3);
				bindingFlags = default(BindingFlags);
				class21 = (Class10)(object)obj26.W(bindingFlags, array6, (Type)(object)@class.t(bindingFlags, array5, Class5.Default, cultureInfo), (Type[])(object)@class.W((BindingFlags)Class5.Default, null, type, array2, null), array3);
				goto end_IL_15cf;
			}
			end_IL_15cf:;
		}
		catch
		{
			Class7 obj27 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			gClass3 = (GClass2)(object)obj27.e(bindingFlags, array, array2, null);
		}
		do
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				class18 = class18;
				gClass4 = gClass4;
			}
		}
		while (obj != null);
		_ = (Qk7)(object)Class5.Default;
		do
		{
			class9 = class9;
		}
		while ((object)Class5.Default != null);
		do
		{
			try
			{
				gClass4 = null;
			}
			catch
			{
				Class7 class37;
				do
				{
					_ = Class5.Default;
					_ = (Class6)@class.t(null, null, (CultureInfo)(object)Class5.Default);
					class25 = null;
					class8 = class8;
					class37 = @class;
					bindingFlags = default(BindingFlags);
				}
				while ((object)class37.j(bindingFlags, array, ref reference, array3, cultureInfo, null, out *(object*)null) != null);
			}
		}
		while (obj != null);
		try
		{
			_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
		}
		finally
		{
			goto IL_179e;
		}
		IL_3a2f:
		try
		{
			try
			{
				_ = (GClass0)(object)Class5.Default;
			}
			catch
			{
				Class7 obj30 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				_ = (Class4)(object)((Class7)(object)obj30.j(bindingFlags, array, ref *(object[]*)Class5.Default, array3, null, array4, out reference2)).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, (Type[])(object)Class5.Default, array3);
			}
		}
		catch
		{
			gClass = null;
		}
		finally
		{
			try
			{
				try
				{
					_ = (GClass1)(object)Class5.Default;
				}
				finally
				{
					_003CModule_003E = (_003CModule_003E)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, array2, array3);
					goto end_IL_3ab7;
				}
				end_IL_3ab7:;
			}
			catch
			{
				while (obj != null)
				{
					gClass2 = (GClass0)(object)Class5.Default;
					class21 = class21;
					_ = (GClass2)(object)Class5.Default;
				}
			}
			goto IL_3b13;
		}
		IL_451a:
		gClass3 = (GClass2)(object)Class5.Default;
		gClass4 = null;
		return;
		IL_3494:
		qk = qk;
		class21 = (Class10)(object)Class5.Default;
		_ = (Class2)(object)Class5.Default;
		try
		{
			Class7 class38 = @class;
			Class7 class39 = @class;
			bindingFlags = default(BindingFlags);
			_ = (GClass2)(object)class38.t((BindingFlags)class39.W(bindingFlags, array6, null, null, null), array5, obj, null);
		}
		finally
		{
			checked
			{
				try
				{
					if (unchecked((nuint)(UIntPtr)((Class7)@class.t(obj, null, null)).W((BindingFlags)Class5.Default, array6, type, array2, array3)) - unchecked((nuint)default(UIntPtr)) == 0)
					{
						_ = (Class8)(object)Class5.Default;
					}
				}
				catch
				{
				}
				goto IL_354e;
			}
		}
		IL_2597:
		checked
		{
			if (num2 - unchecked((nuint)(UIntPtr)Class5.Default) == 0)
			{
				try
				{
					num2 = default(UIntPtr);
					nuint num10 = num2;
					num2 = default(UIntPtr);
					if (num10 - (num2 + num2) == 0)
					{
						class36 = class36;
					}
				}
				finally
				{
					try
					{
						class8 = (Class6)(object)@class.t(bindingFlags, null, unchecked(((Class7)null).j((BindingFlags)Class5.Default, array, ref reference, (ParameterModifier[])null, (CultureInfo)(object)Class5.Default, (string[])null, out *(object*)null)), cultureInfo);
					}
					catch
					{
						@struct = @struct;
					}
					goto IL_262e;
				}
			}
			goto IL_262e;
		}
		IL_354e:
		try
		{
			if ((UIntPtr)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)null, array3, (CultureInfo)(object)@class.t(bindingFlags, array5, obj, cultureInfo), array4, out reference2) == (UIntPtr)(nuint)0u)
			{
				Class7 class40 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class4)(object)class40.t(bindingFlags, array5, obj, null);
			}
		}
		catch
		{
			class21 = class21;
			_ = (GClass0)(object)Class5.Default;
			_ = (_003CModule_003E)(object)@class.W((BindingFlags)@class.j(bindingFlags, null, ref *(object[]*)null, null, cultureInfo, array4, out *(object*)null), array6, null, array2, null);
		}
		finally
		{
			do
			{
				_ = (Class9)(object)Class5.Default;
				class9 = (Class5)(object)@class.t(default(BindingFlags), array5, obj, (CultureInfo)(object)Class5.Default);
				Class7 class41 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class10)(object)class41.W(bindingFlags, array6, (Type)(object)Class5.Default, null, array3);
				_ = (GClass0)(object)Class5.Default;
			}
			while (obj != null);
			goto IL_3688;
		}
		IL_1eac:
		try
		{
			while (obj != null)
			{
				num2 = default(UIntPtr);
				if (num2 == 0)
				{
					_ = (Class9)(object)((Class7)(object)Class5.Default).W(default(BindingFlags), null, type, array2, (ParameterModifier[])(object)@class.t((BindingFlags)((Class7)null).W((BindingFlags)@class.t(default(BindingFlags), array5, ((Class7)(object)Class5.Default).e(default(BindingFlags), array, array2, array3), (CultureInfo)(object)Class5.Default), (PropertyInfo[])null, type, (Type[])null, (ParameterModifier[])null), (FieldInfo[])(object)Class5.Default, null, cultureInfo));
				}
			}
		}
		finally
		{
			try
			{
				do
				{
					gClass3 = null;
				}
				while (obj != null);
			}
			finally
			{
				bindingFlags = default(BindingFlags);
				if ((UIntPtr)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, array2, array3) == (UIntPtr)(nuint)0u)
				{
					_ = (GClass0)(object)Class5.Default;
				}
				else
				{
					class36 = class36;
				}
				goto IL_1fd4;
			}
		}
		IL_07af:
		try
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					Class7 class42 = @class;
					Class7 obj37 = (Class7)(object)Class5.Default;
					object object_8 = Class5.Default;
					Type type_3 = type;
					Class7 class43 = @class;
					Type type_4 = (Type)(object)@class.t(bindingFlags, null, obj, (CultureInfo)(object)Class5.Default);
					bindingFlags = default(BindingFlags);
					_ = (Class7)class42.t(obj37.t(object_8, type_3, (CultureInfo)class43.t(null, type_4, (CultureInfo)(object)((Class7)null).e(bindingFlags, array, (Type[])(object)Class5.Default, (ParameterModifier[])@class.t(obj, type, (CultureInfo)(object)Class5.Default)))), type, cultureInfo);
				}
				catch
				{
					Class7 class44 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class10)(object)class44.t(bindingFlags, null, Class5.Default, null);
				}
			}
		}
		finally
		{
			num2 = default(UIntPtr);
			if (num2 == (UIntPtr)(nuint)0u)
			{
				num2 = default(UIntPtr);
				if (num2 == (UIntPtr)(nuint)0u)
				{
					@struct = @struct;
					Class10 obj39 = (Class10)(object)Class5.Default;
					class21 = null;
					class21 = obj39;
				}
			}
			else
			{
				try
				{
					_ = (Class0)(object)Class5.Default;
				}
				catch
				{
					gClass3 = gClass3;
					class18 = class18;
					class18 = class18;
					GClass1 obj40 = (GClass1)(object)Class5.Default;
					gClass4 = (GClass1)(object)Class5.Default;
					gClass4 = obj40;
				}
			}
			goto IL_0926;
		}
		IL_0926:
		if ((UIntPtr)@class.e(bindingFlags, array, array2, array3) == (UIntPtr)(nuint)0u)
		{
			try
			{
				do
				{
					class18 = class18;
				}
				while (((Class7)(object)@class.W((BindingFlags)Class5.Default, null, type, array2, null)).t(((Class7)null).t((object)Class5.Default, type, cultureInfo), type, cultureInfo) != null);
			}
			finally
			{
				while (obj != null)
				{
					_ = (Struct1)((Class7)@class.t(null, type, null)).W(bindingFlags, array6, type, null, null);
					_ = (Class6)(object)Class5.Default;
				}
				goto IL_09ea;
			}
		}
		goto IL_09ea;
		IL_3b13:
		do
		{
			_ = (Class4)(object)Class5.Default;
			class21 = null;
		}
		while (obj != null);
		_ = (Class2)(object)((Class7)(object)((Class7)null).W((BindingFlags)@class.W(bindingFlags, array6, (Type)(object)Class5.Default, (Type[])(object)((Class7)null).e((BindingFlags)Class5.Default, (MethodBase[])null, (Type[])(object)@class.j(bindingFlags, array, ref *(object[]*)Class5.Default, null, (CultureInfo)(object)Class5.Default, null, out *(object*)Class5.Default), array3), (ParameterModifier[])(object)Class5.Default), (PropertyInfo[])null, type, array2, (ParameterModifier[])null)).j(default(BindingFlags), null, ref *(object[]*)null, (ParameterModifier[])@class.t(obj, (Type)((Class7)((Class7)(object)Class5.Default).t(null, type, cultureInfo)).t(obj, (Type)@class.t(obj, (Type)(object)Class5.Default, cultureInfo), cultureInfo), null), null, array4, out *(object*)null);
		while (true)
		{
			Class7 class45 = @class;
			Class7 class46 = @class;
			bindingFlags = default(BindingFlags);
			if ((object)class45.j((BindingFlags)class46.e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)@class.e((BindingFlags)((Class7)(object)Class5.Default).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, cultureInfo), null, (Type[])(object)Class5.Default, array3), (ParameterModifier[])(object)Class5.Default), array, ref *(object[]*)Class5.Default, array3, null, null, out reference2) == null)
			{
				break;
			}
			class21 = null;
		}
		_ = (Class8)(object)@class.e(bindingFlags, array, array2, array3);
		Class7 class47 = @class;
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_24 = bindingFlags;
		MethodBase[] methodBase_15 = array;
		ref object[] object_9 = ref reference;
		Class7 obj42 = (Class7)(object)@class.W(bindingFlags, null, type, array2, (ParameterModifier[])(object)Class5.Default);
		bindingFlags = default(BindingFlags);
		if ((UIntPtr)class47.j(bindingFlags_24, methodBase_15, ref object_9, (ParameterModifier[])(object)obj42.t(bindingFlags, array5, obj, cultureInfo), cultureInfo, null, out *(object*)@class.j(bindingFlags, array, ref *(object[]*)Class5.Default, null, null, (string[])(object)((Class7)null).j((BindingFlags)Class5.Default, array, ref reference, array3, (CultureInfo)null, (string[])@class.t(null, type, (CultureInfo)(object)Class5.Default), out reference2), out *(object*)null)) == (UIntPtr)(nuint)0u)
		{
			while (true)
			{
				if ((object)@class.j((BindingFlags)Class5.Default, array, ref reference, array3, null, array4, out reference2) != null)
				{
					class9 = class9;
				}
				else if ((object)Class5.Default == null)
				{
					break;
				}
			}
		}
		if ((UIntPtr)@class.t(obj, (Type)(object)Class5.Default, cultureInfo) == (UIntPtr)(nuint)0u)
		{
			try
			{
				while (true)
				{
					Class7 class48 = @class;
					BindingFlags bindingFlags_25 = bindingFlags;
					BindingFlags bindingFlags_26 = (BindingFlags)Class5.Default;
					PropertyInfo[] propertyInfo_2 = array6;
					Type type_5 = type;
					Type[] type_6 = array2;
					Class7 class49 = @class;
					bindingFlags = default(BindingFlags);
					Class7 obj43 = (Class7)(object)((Class7)null).t(bindingFlags_25, (FieldInfo[])(object)((Class7)null).W(bindingFlags_26, propertyInfo_2, type_5, type_6, (ParameterModifier[])(object)class49.W(bindingFlags, array6, null, (Type[])(object)Class5.Default, array3)), (object)null, cultureInfo);
					bindingFlags = default(BindingFlags);
					if (class48.t(obj43.t(bindingFlags, array5, obj, cultureInfo), (Type)(object)((Class7)(object)Class5.Default).t(bindingFlags, null, obj, (CultureInfo)(object)Class5.Default), null) != null)
					{
						_ = (Class2)(object)Class5.Default;
						continue;
					}
					break;
				}
			}
			catch
			{
				if (num2 == 0)
				{
					gClass = null;
				}
			}
		}
		_ = (GClass1)(object)Class5.Default;
		_ = (Class2)(object)Class5.Default;
		BindingFlags bindingFlags_27 = (BindingFlags)Class5.Default;
		FieldInfo[] fieldInfo_2 = array5;
		Class7 obj45 = (Class7)(object)Class5.Default;
		object object_10 = obj;
		Type type_7 = type;
		Class7 class50 = @class;
		object object_11 = obj;
		Class7 class51 = @class;
		object object_12 = @class.t(bindingFlags, array5, obj, (CultureInfo)@class.t(obj, null, (CultureInfo)(object)((Class7)(object)Class5.Default).W(bindingFlags, array6, type, array2, array3)));
		Class7 obj46 = (Class7)(object)Class5.Default;
		BindingFlags bindingFlags_28 = (BindingFlags)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, cultureInfo);
		MethodBase[] methodBase_16 = (MethodBase[])((Class7)(object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array3, null, null, out reference2)).t(Class5.Default, null, cultureInfo);
		ref object[] object_13 = ref reference;
		ParameterModifier[] parameterModifier_8 = array3;
		Class7 obj47 = (Class7)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		_ = (_003CModule_003E)(object)((Class7)null).t(bindingFlags_27, fieldInfo_2, obj45.t(object_10, type_7, (CultureInfo)class50.t(object_11, (Type)class51.t(object_12, null, (CultureInfo)(object)obj46.j(bindingFlags_28, methodBase_16, ref object_13, parameterModifier_8, (CultureInfo)(object)obj47.j(bindingFlags, array, ref *(object[]*)@class.e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, array3), array3, cultureInfo, array4, out *(object*)((Class7)(object)Class5.Default).j(bindingFlags, array, ref *(object[]*)@class.t(null, null, (CultureInfo)((Class7)null).t((object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array3, (CultureInfo)(object)Class5.Default, array4, out reference2), (Type)(object)@class.W(bindingFlags, array6, (Type)(object)((Class7)(object)@class.t((BindingFlags)Class5.Default, array5, obj, null)).W(bindingFlags, null, null, array2, array3), array2, array3), cultureInfo)), (ParameterModifier[])(object)Class5.Default, null, array4, out *(object*)null)), (string[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, cultureInfo), out *(object*)null)), cultureInfo)), cultureInfo);
		try
		{
			nuint num11 = checked(num2 * num2);
			nuint num12 = num2;
			num2 = default(UIntPtr);
			if (num11 / checked(num12 + num2) == 0)
			{
				try
				{
					class22 = class22;
				}
				catch
				{
					class36 = null;
				}
			}
			else
			{
				num2 = default(UIntPtr);
				nuint num13 = num2;
				UIntPtr num14 = (UIntPtr)Class5.Default;
				num2 = default(UIntPtr);
				checked
				{
					if (unchecked(num13 / checked(unchecked((nuint)num14 / num2) + unchecked((nuint)(UIntPtr)Class5.Default))) + num2 == 0)
					{
						class22 = (Class2)(object)Class5.Default;
					}
				}
			}
		}
		finally
		{
			if (num2 == 0)
			{
				if ((UIntPtr)((Class7)null).t(obj, (Type)null, (CultureInfo)null) == (UIntPtr)(nuint)0u)
				{
					bindingFlags = default(BindingFlags);
					_ = (GClass3)(object)((Class7)null).W(bindingFlags, array6, (Type)null, array2, (ParameterModifier[])null);
				}
			}
			else
			{
				Class7 obj49 = (Class7)@class.t(null, type, cultureInfo);
				bindingFlags = default(BindingFlags);
				_ = (Class7)(object)obj49.e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
			}
			goto IL_42d9;
		}
		IL_09ea:
		bindingFlags = default(BindingFlags);
		if ((UIntPtr)((Class7)null).e(bindingFlags, (MethodBase[])(object)@class.W(bindingFlags, array6, type, null, null), (Type[])null, (ParameterModifier[])(object)Class5.Default) == (UIntPtr)(nuint)0u)
		{
			try
			{
				num2 = default(UIntPtr);
				if (num2 == (UIntPtr)(nuint)0u)
				{
					_ = (Struct1)Class5.Default;
				}
			}
			finally
			{
				class21 = null;
				_ = (GClass1)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				_ = (Struct1)((Class7)null).t(bindingFlags, array5, @class.t(obj, type, cultureInfo), (CultureInfo)null);
				goto IL_0a94;
			}
		}
		goto IL_0a94;
		IL_1cba:
		if (default(UIntPtr) != (UIntPtr)(nuint)0u)
		{
		}
		Class7 class52;
		Class7 class53;
		do
		{
			_ = (Class4)(object)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, array, (Type[])(object)@class.W(bindingFlags, (PropertyInfo[])(object)@class.e((BindingFlags)((Class7)(object)Class5.Default).t(bindingFlags, array5, obj, cultureInfo), null, array2, null), null, (Type[])(object)((Class7)null).e((BindingFlags)((Class7)(object)((Class7)(object)((Class7)(object)Class5.Default).j(default(BindingFlags), (MethodBase[])(object)Class5.Default, ref *(object[]*)null, array3, (CultureInfo)(object)Class5.Default, array4, out reference2)).W(default(BindingFlags), array6, null, null, array3)).t(null, type, (CultureInfo)(object)Class5.Default), array, array2, array3), array3), array3);
			class52 = @class;
			class53 = @class;
			bindingFlags = default(BindingFlags);
		}
		while ((object)class52.e((BindingFlags)class53.j(bindingFlags, null, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, null, out reference2), null, array2, array3) != null);
		try
		{
			do
			{
				try
				{
					_ = (Class2)(object)Class5.Default;
				}
				finally
				{
					@class = @class;
					continue;
				}
			}
			while (obj != null);
		}
		finally
		{
			class7 = class7;
			goto IL_1e50;
		}
		IL_0a94:
		@class = null;
		if (num2 == (UIntPtr)(nuint)0u)
		{
			_ = (Class9)(object)Class5.Default;
		}
		else
		{
			do
			{
				@class = @class;
				_ = (GClass0)(object)Class5.Default;
				_ = (Struct1)Class5.Default;
			}
			while (obj != null);
		}
		while ((object)Class5.Default != null)
		{
			class21 = (Class10)(object)Class5.Default;
			_ = (GClass3)((Class7)(object)Class5.Default).t(null, type, (CultureInfo)(object)Class5.Default);
			_ = (Class2)((Class7)(object)Class5.Default).t(((Class7)(object)Class5.Default).t(Class5.Default, type, cultureInfo), type, cultureInfo);
		}
		if (num2 == (UIntPtr)(nuint)0u)
		{
			if (num2 == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)((Class7)@class.t(obj, type, (CultureInfo)(object)@class.t(bindingFlags, null, Class5.Default, (CultureInfo)(object)Class5.Default))).j(bindingFlags, (MethodBase[])(object)((Class7)(object)Class5.Default).j(bindingFlags, array, ref *(object[]*)null, array3, (CultureInfo)(object)Class5.Default, (string[])(object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)Class5.Default, null, out *(object*)((Class7)null).t(obj, type, cultureInfo)), out reference2), ref *(object[]*)((Class7)null).t((BindingFlags)Class5.Default, array5, (object)null, cultureInfo), array3, (CultureInfo)(object)Class5.Default, array4, out *(object*)Class5.Default) == (UIntPtr)(nuint)0u)
				{
					@struct = @struct;
				}
				else
				{
					_ = (Class8)((Class7)null).t((object)null, (Type)null, cultureInfo);
					_ = (Struct1)Class5.Default;
					gClass = gClass;
				}
			}
			else
			{
				while (true)
				{
					bindingFlags = default(BindingFlags);
					if ((object)((Class7)null).j(bindingFlags, array, ref reference, (ParameterModifier[])null, cultureInfo, array4, out *(object*)Class5.Default) == null)
					{
						break;
					}
					_ = (Class7)(object)((Class7)(object)Class5.Default).e(bindingFlags, array, null, array3);
				}
			}
		}
		qk = qk;
		qk = qk;
		_ = (Struct2)Class5.Default;
		struct2 = default(Struct1);
		class25 = class25;
		class25 = class25;
		while (obj != null)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				do
				{
					_ = (Class8)(object)((Class7)(object)Class5.Default).j(default(BindingFlags), null, ref reference, array3, (CultureInfo)(object)Class5.Default, array4, out *(object*)null);
				}
				while (obj != null);
			}
			else
			{
				do
				{
					class8 = class8;
				}
				while (obj != null);
			}
		}
		try
		{
			while (obj != null)
			{
				_ = (GClass2)(object)Class5.Default;
			}
		}
		catch
		{
			do
			{
				_ = (Struct2)Class5.Default;
			}
			while (obj != null);
		}
		finally
		{
			_ = (GClass3)(object)Class5.Default;
			goto IL_0ddc;
		}
		IL_179e:
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				while (obj != null)
				{
					_ = (_003CModule_003E)(object)Class5.Default;
				}
			}
		}
		finally
		{
			while (obj != null)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					class22 = (Class2)(object)Class5.Default;
				}
				else
				{
					@struct = (Struct2)((Class7)null).W(bindingFlags, array6, type, array2, (ParameterModifier[])null);
				}
			}
			goto IL_180f;
		}
		IL_3760:
		while (obj != null)
		{
			if (num2 == 0)
			{
				_ = (Class2)(object)Class5.Default;
				continue;
			}
			try
			{
				_ = (GClass2)(object)Class5.Default;
			}
			catch
			{
				_ = (GClass3)(object)((Class7)(object)Class5.Default).W(bindingFlags, array6, null, array2, (ParameterModifier[])(object)Class5.Default);
			}
		}
		if (num2 == 0)
		{
			gClass3 = null;
		}
		_ = (Class5)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, array2, (ParameterModifier[])(object)Class5.Default);
		class18 = class18;
		gClass4 = gClass4;
		try
		{
			num2 = default(UIntPtr);
			if (checked(unchecked((nuint)default(UIntPtr)) - num2) / checked(num2 * num2) == 0)
			{
				if ((UIntPtr)((Class7)null).t(bindingFlags, array5, obj, cultureInfo) == (UIntPtr)(nuint)0u)
				{
					_ = (_003CModule_003E)(object)Class5.Default;
					_ = (Struct2)Class5.Default;
				}
				else
				{
					gClass = null;
				}
			}
		}
		finally
		{
			gClass = null;
			goto IL_387e;
		}
		IL_1fd4:
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			_ = (GClass2)(object)Class5.Default;
		}
		try
		{
			Class7 class54 = @class;
			BindingFlags bindingFlags_29 = (BindingFlags)Class5.Default;
			MethodBase[] methodBase_17 = array;
			ref object[] object_14 = ref *(object[]*)@class.j(bindingFlags, array, ref reference, (ParameterModifier[])(object)@class.e(bindingFlags, null, array2, array3), null, (string[])(object)Class5.Default, out reference2);
			ParameterModifier[] parameterModifier_9 = (ParameterModifier[])(object)Class5.Default;
			CultureInfo cultureInfo_7 = cultureInfo;
			string[] string_3 = array4;
			bindingFlags = default(BindingFlags);
			_ = (Struct1)class54.j(bindingFlags_29, methodBase_17, ref object_14, parameterModifier_9, cultureInfo_7, string_3, out *(object*)((Class7)null).e(bindingFlags, (MethodBase[])null, array2, (ParameterModifier[])@class.t(obj, type, cultureInfo)));
			gClass3 = (GClass2)(object)Class5.Default;
		}
		finally
		{
			try
			{
				class21 = (Class10)(object)Class5.Default;
			}
			catch
			{
				try
				{
					_ = (Class9)((Class7)(object)@class.W(bindingFlags, array6, null, (Type[])(object)((Class7)null).W(default(BindingFlags), (PropertyInfo[])null, (Type)null, array2, (ParameterModifier[])null), array3)).t(obj, (Type)(object)Class5.Default, cultureInfo);
				}
				finally
				{
					_ = (Class8)(object)Class5.Default;
					goto end_IL_20b8;
				}
				end_IL_20b8:;
			}
			goto IL_2124;
		}
		IL_3688:
		num2 = default(UIntPtr);
		if (num2 == 0)
		{
			try
			{
				@class = @class;
			}
			finally
			{
				qk = qk;
				goto IL_3760;
			}
		}
		num2 = default(UIntPtr);
		checked
		{
			if (num2 == 0 && num2 * unchecked((nuint)(UIntPtr)((Class7)(object)Class5.Default).W(bindingFlags, array6, type, (Type[])(object)Class5.Default, null) / (nuint)(UIntPtr)Class5.Default) == 0)
			{
				_ = (Struct1)Class5.Default;
			}
			goto IL_3760;
		}
		IL_2249:
		class18 = (Class8)((Class7)null).t(obj, (Type)(object)Class5.Default, (CultureInfo)null);
		_ = (Struct2)((Class7)(object)Class5.Default).t(obj, (Type)(object)Class5.Default, null);
		_ = Class5.Default;
		_ = (Class6)(object)@class.e(default(BindingFlags), array, array2, null);
		class7 = null;
		_ = (GClass1)(object)Class5.Default;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				class8 = class8;
			}
		}
		class9 = class9;
		while (true)
		{
			Class7 class55 = @class;
			bindingFlags = default(BindingFlags);
			if ((object)class55.e(bindingFlags, array, null, array3) == null)
			{
				break;
			}
			_ = (Qk7)(object)@class.e((BindingFlags)Class5.Default, array, array2, array3);
		}
		_ = (Qk7)(object)Class5.Default;
		num2 = default(UIntPtr);
		if (num2 == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				do
				{
					class21 = (Class10)(object)Class5.Default;
				}
				while (obj != null);
			}
		}
		else if (num2 == (UIntPtr)(nuint)0u)
		{
			gClass = (GClass3)((Class7)null).t(obj, (Type)(object)Class5.Default, cultureInfo);
			@struct = (Struct2)Class5.Default;
		}
		try
		{
		}
		catch
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)null, (Type[])null, array3) == (UIntPtr)(nuint)0u)
				{
					class9 = null;
				}
			}
			else
			{
				class8 = null;
			}
		}
		num2 = default(UIntPtr);
		if (num2 == 0)
		{
			while (obj != null)
			{
			}
		}
		while (true)
		{
			if ((object)((Class7)(object)((Class7)null).W(bindingFlags, array6, (Type)(object)Class5.Default, array2, (ParameterModifier[])null)).t(bindingFlags, null, ((Class7)null).t(bindingFlags, array5, obj, (CultureInfo)null), cultureInfo) != null)
			{
				class36 = (Class9)(object)Class5.Default;
			}
			else if (obj == null && (object)Class5.Default == null)
			{
				break;
			}
		}
		try
		{
			num2 = default(UIntPtr);
			nuint num15 = num2;
			num2 = default(UIntPtr);
			if (checked(num15 * num2 * unchecked((nuint)(UIntPtr)Class5.Default)) == 0)
			{
				if (num2 == 0)
				{
					_ = Class5.Default;
				}
			}
			else
			{
				try
				{
					_ = (Class9)(object)@class.j((BindingFlags)@class.W((BindingFlags)Class5.Default, array6, type, null, array3), array, ref reference, array3, (CultureInfo)(object)Class5.Default, array4, out reference2);
					struct2 = struct2;
					_ = (GClass1)(object)Class5.Default;
					qk = qk;
				}
				catch
				{
					_ = (Class0)(object)Class5.Default;
				}
			}
		}
		catch
		{
		}
		try
		{
			while (obj != null)
			{
				_ = (Qk7)(object)((Class7)(object)Class5.Default).j((BindingFlags)Class5.Default, null, ref *(object[]*)null, array3, cultureInfo, (string[])(object)Class5.Default, out *(object*)null);
			}
		}
		catch
		{
			do
			{
				@class = @class;
			}
			while (obj != null);
		}
		finally
		{
			goto IL_2597;
		}
		IL_1e50:
		num2 = default(UIntPtr);
		if (num2 == 0)
		{
			if (num2 == 0)
			{
				try
				{
					gClass4 = gClass4;
				}
				finally
				{
					struct2 = default(Struct1);
					goto IL_1eac;
				}
			}
			class9 = class9;
			_ = (Class6)(object)Class5.Default;
		}
		else
		{
			do
			{
				class8 = null;
			}
			while (obj != null || obj != null);
		}
		goto IL_1eac;
		IL_28ce:
		try
		{
			if ((UIntPtr)@class.j(bindingFlags, array, ref *(object[]*)Class5.Default, array3, cultureInfo, (string[])(object)((Class7)(object)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])null, (Type)(object)((Class7)(object)((Class7)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)@class.W(bindingFlags, array6, (Type)(object)Class5.Default, array2, array3), (Type)null, (Type[])(object)Class5.Default, array3)).W(bindingFlags, array6, (Type)(object)Class5.Default, array2, null)).t(bindingFlags, array5, Class5.Default, cultureInfo), (Type[])null, (ParameterModifier[])null)).t(bindingFlags, null, Class5.Default, cultureInfo), out *(object*)@class.t(Class5.Default, null, null)) == (UIntPtr)(nuint)0u)
			{
				nuint num16 = num2;
				num2 = default(UIntPtr);
				if (checked(num16 - num2) == 0)
				{
					bindingFlags = default(BindingFlags);
					@class = (Class7)(object)((Class7)null).t(bindingFlags, array5, obj, cultureInfo);
				}
				else
				{
					gClass2 = (GClass0)(object)Class5.Default;
				}
			}
		}
		catch
		{
			num2 = default(UIntPtr);
			if (num2 != 0)
			{
				try
				{
					class25 = class25;
					class36 = class36;
				}
				finally
				{
					_ = (GClass1)(object)@class.W((BindingFlags)((Class7)(object)Class5.Default).e(bindingFlags, array, null, array3), (PropertyInfo[])(object)Class5.Default, type, null, null);
					goto end_IL_2a22;
				}
			}
			if (num2 == 0)
			{
				Class7 class56 = @class;
				BindingFlags bindingFlags_30 = bindingFlags;
				MethodBase[] methodBase_18 = array;
				ref object[] object_15 = ref reference;
				ParameterModifier[] parameterModifier_10 = array3;
				CultureInfo cultureInfo_8 = cultureInfo;
				Class7 class57 = @class;
				bindingFlags = default(BindingFlags);
				Class7 obj57 = (Class7)(object)class57.t(bindingFlags, array5, obj, null);
				BindingFlags bindingFlags_31 = bindingFlags;
				Type[] type_8 = array2;
				Class7 class58 = @class;
				BindingFlags bindingFlags_32 = (BindingFlags)@class.e(default(BindingFlags), array, null, array3);
				MethodBase[] methodBase_19 = array;
				ref object[] object_16 = ref reference;
				ParameterModifier[] parameterModifier_11 = array3;
				CultureInfo cultureInfo_9 = cultureInfo;
				Class7 class59 = @class;
				Class7 class60 = @class;
				bindingFlags = default(BindingFlags);
				object object_17 = ((Class7)(object)class60.j(bindingFlags, array, ref *(object[]*)Class5.Default, array3, cultureInfo, null, out reference2)).t((BindingFlags)((Class7)(object)Class5.Default).t(bindingFlags, array5, null, cultureInfo), array5, obj, null);
				Class7 obj58 = (Class7)(object)Class5.Default;
				Class7 class61 = @class;
				bindingFlags = default(BindingFlags);
				Class7 obj59 = (Class7)(object)class61.j(bindingFlags, array, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)Class5.Default, array4, out *(object*)Class5.Default);
				BindingFlags bindingFlags_33 = bindingFlags;
				MethodBase[] methodBase_20 = array;
				Class7 class62 = @class;
				BindingFlags bindingFlags_34 = bindingFlags;
				MethodBase[] methodBase_21 = array;
				BindingFlags bindingFlags_35 = (BindingFlags)Class5.Default;
				FieldInfo[] fieldInfo_3 = (FieldInfo[])(object)Class5.Default;
				BindingFlags bindingFlags_36 = (BindingFlags)((Class7)(object)Class5.Default).e(bindingFlags, array, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
				PropertyInfo[] propertyInfo_3 = (PropertyInfo[])(object)Class5.Default;
				Type[] type_9 = (Type[])(object)Class5.Default;
				Class7 obj60 = (Class7)((Class7)null).t(obj, (Type)(object)Class5.Default, (CultureInfo)null);
				bindingFlags = default(BindingFlags);
				Class7 obj61 = (Class7)(object)obj58.j(default(BindingFlags), null, ref *(object[]*)obj59.e(bindingFlags_33, methodBase_20, (Type[])(object)class62.j(bindingFlags_34, methodBase_21, ref *(object[]*)((Class7)null).t(bindingFlags_35, fieldInfo_3, (object)((Class7)null).W(bindingFlags_36, propertyInfo_3, (Type)null, type_9, (ParameterModifier[])((Class7)(object)obj60.j(bindingFlags, (MethodBase[])((Class7)null).t(obj, (Type)(object)Class5.Default, cultureInfo), ref *(object[]*)null, array3, cultureInfo, (string[])(object)@class.W((BindingFlags)@class.W((BindingFlags)((Class7)((Class7)null).t((object)@class.t(bindingFlags, (FieldInfo[])(object)@class.j(bindingFlags, null, ref reference, array3, cultureInfo, null, out *(object*)null), obj, cultureInfo), (Type)null, cultureInfo)).j(bindingFlags, array, ref *(object[]*)Class5.Default, null, cultureInfo, array4, out reference2), array6, type, array2, null), null, type, null, array3), out *(object*)null)).t(@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, array3), type, cultureInfo)), (CultureInfo)null), array3, cultureInfo, array4, out *(object*)@class.j((BindingFlags)((Class7)(object)Class5.Default).j(bindingFlags, array, ref *(object[]*)null, array3, null, array4, out reference2), array, ref *(object[]*)@class.t(bindingFlags, (FieldInfo[])@class.t(Class5.Default, type, cultureInfo), Class5.Default, (CultureInfo)(object)Class5.Default), null, (CultureInfo)(object)@class.W((BindingFlags)Class5.Default, array6, null, array2, array3), array4, out reference2)), array3), array3, null, array4, out reference2);
				bindingFlags = default(BindingFlags);
				_ = (Class8)(object)class56.j(bindingFlags_30, methodBase_18, ref object_15, parameterModifier_10, cultureInfo_8, null, out *(object*)obj57.W(bindingFlags_31, null, null, type_8, (ParameterModifier[])(object)class58.j(bindingFlags_32, methodBase_19, ref object_16, parameterModifier_11, cultureInfo_9, null, out *(object*)class59.t(object_17, (Type)(object)obj61.e(bindingFlags, null, (Type[])(object)Class5.Default, array3), cultureInfo))));
			}
			end_IL_2a22:;
		}
		do
		{
			if (num2 != 0)
			{
				do
				{
					_ = (Class9)(object)Class5.Default;
				}
				while (obj != null);
			}
			else
			{
				do
				{
					class21 = (Class10)(object)@class.e(bindingFlags, null, (Type[])(object)Class5.Default, null);
				}
				while (obj != null);
			}
		}
		while (obj != null);
		num2 = default(UIntPtr);
		if (num2 == (UIntPtr)(nuint)0u)
		{
			do
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					gClass2 = null;
				}
			}
			while ((object)((Class7)null).j((BindingFlags)@class.W((BindingFlags)Class5.Default, array6, null, (Type[])(object)Class5.Default, array3), (MethodBase[])null, ref *(object[]*)((Class7)null).t((BindingFlags)Class5.Default, array5, obj, (CultureInfo)(object)@class.e(bindingFlags, array, (Type[])(object)Class5.Default, array3)), array3, cultureInfo, array4, out reference2) != null);
		}
		while (true)
		{
			BindingFlags bindingFlags_37 = bindingFlags;
			bindingFlags = default(BindingFlags);
			if ((object)((Class7)null).e(bindingFlags_37, (MethodBase[])null, (Type[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, (Type[])(object)@class.e((BindingFlags)Class5.Default, null, null, array3), array3), (ParameterModifier[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, cultureInfo)) == null)
			{
				break;
			}
			try
			{
				num2 = default(UIntPtr);
				if (num2 == (UIntPtr)(nuint)0u)
				{
					gClass4 = gClass4;
				}
				else
				{
					class18 = class18;
				}
			}
			catch
			{
				while ((object)Class5.Default != null)
				{
					class25 = null;
				}
			}
		}
		try
		{
			num2 = default(UIntPtr);
			if (num2 == (UIntPtr)(nuint)0u)
			{
				while (obj != null)
				{
					class18 = class18;
					class36 = (Class9)(object)((Class7)null).j(bindingFlags, array, ref reference, array3, cultureInfo, array4, out *(object*)null);
					@class = @class;
				}
			}
		}
		catch
		{
			try
			{
				while (obj != null)
				{
					gClass = null;
				}
			}
			finally
			{
				while (obj != null)
				{
					_ = (Class4)(object)Class5.Default;
					_ = (Struct2)Class5.Default;
				}
				goto end_IL_30e5;
			}
			end_IL_30e5:;
		}
		while (((Class7)null).t(obj, (Type)null, cultureInfo) != null)
		{
			Class7 class63 = @class;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)((Class7)(object)((Class7)(object)class63.e(bindingFlags, null, null, (ParameterModifier[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)(object)Class5.Default, (Type[])null, (ParameterModifier[])(object)Class5.Default))).W(bindingFlags, null, type, array2, array3)).j((BindingFlags)Class5.Default, null, ref *(object[]*)((Class7)null).t((object)null, type, cultureInfo), (ParameterModifier[])(object)@class.t(bindingFlags, null, obj, null), cultureInfo, array4, out *(object*)Class5.Default) == (UIntPtr)(nuint)0u)
			{
				Class7 class64 = @class;
				BindingFlags bindingFlags_38 = bindingFlags;
				Class7 class65 = @class;
				bindingFlags = default(BindingFlags);
				ParameterModifier[] parameterModifier_12 = (ParameterModifier[])(object)class65.t(bindingFlags, null, @class.t(obj, type, null), (CultureInfo)(object)((Class7)(object)Class5.Default).j(bindingFlags, null, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)Class5.Default, cultureInfo, null, out reference2));
				bindingFlags = default(BindingFlags);
				CultureInfo cultureInfo_10 = (CultureInfo)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)@class.e(bindingFlags, array, array2, array3), type, array2, array3);
				string[] string_4 = (string[])(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				if ((UIntPtr)class64.j(bindingFlags_38, null, ref *(object[]*)null, parameterModifier_12, cultureInfo_10, string_4, out *(object*)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)null, array3, (CultureInfo)null, array4, out *(object*)null)) == (UIntPtr)(nuint)0u)
				{
					_ = (_003CModule_003E)(object)Class5.Default;
				}
			}
		}
		try
		{
			if (num2 == (UIntPtr)(nuint)0u)
			{
				Class7 obj65 = (Class7)@class.t(null, null, cultureInfo);
				BindingFlags bindingFlags_39 = (BindingFlags)((Class7)(object)Class5.Default).j(bindingFlags, array, ref *(object[]*)null, (ParameterModifier[])(object)@class.t(bindingFlags, array5, obj, null), cultureInfo, null, out *(object*)null);
				MethodBase[] methodBase_22 = array;
				bindingFlags = default(BindingFlags);
				class22 = (Class2)(object)((Class7)(object)obj65.j(bindingFlags_39, methodBase_22, ref *(object[]*)((Class7)null).t(bindingFlags, (FieldInfo[])@class.t(null, null, null), (object)null, cultureInfo), (ParameterModifier[])(object)Class5.Default, cultureInfo, null, out reference2)).j((BindingFlags)Class5.Default, array, ref *(object[]*)null, array3, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out *(object*)Class5.Default);
			}
			else
			{
				_ = (Class8)(object)Class5.Default;
			}
		}
		catch
		{
			try
			{
				if (num2 == (UIntPtr)(nuint)0u)
				{
					gClass2 = gClass2;
				}
			}
			catch
			{
				try
				{
					@class = null;
					goto end_IL_33f2;
				}
				finally
				{
					_ = (Qk7)(object)((Class7)(object)Class5.Default).j(bindingFlags, null, ref *(object[]*)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, (object)null, cultureInfo), null, null, array4, out reference2);
					goto end_IL_33f2;
				}
				end_IL_33f2:;
			}
		}
		class22 = class22;
		do
		{
			try
			{
				_ = (_003CModule_003E)(object)Class5.Default;
			}
			finally
			{
				do
				{
					class8 = class8;
				}
				while (obj != null);
				continue;
			}
		}
		while (obj != null);
		if (num2 == (UIntPtr)(nuint)0u)
		{
			try
			{
				class8 = null;
			}
			finally
			{
				struct2 = struct2;
				goto IL_3494;
			}
		}
		while (obj != null)
		{
			class21 = class21;
		}
		goto IL_3494;
		IL_387e:
		do
		{
			num2 = default(UIntPtr);
			if (num2 == 0)
			{
				class8 = null;
				_ = (Class8)(object)@class.W((BindingFlags)Class5.Default, null, (Type)(object)Class5.Default, array2, (ParameterModifier[])(object)Class5.Default);
				_ = (Class7)(object)Class5.Default;
			}
		}
		while (@class.t(obj, type, (CultureInfo)(object)Class5.Default) != null || obj != null);
		try
		{
			do
			{
				_ = (Class5)(object)@class.j(bindingFlags, array, ref reference, null, cultureInfo, null, out reference2);
			}
			while (((Class7)null).t((object)null, (Type)null, cultureInfo) != null || obj != null);
		}
		catch
		{
			while ((object)@class.e(bindingFlags, array, null, (ParameterModifier[])(object)((Class7)null).t(bindingFlags, array5, obj, (CultureInfo)null)) != null)
			{
				try
				{
					@class = @class;
				}
				catch
				{
					Class7 obj68 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_40 = bindingFlags;
					Class7 obj69 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					@struct = (Struct2)obj68.t(bindingFlags_40, (FieldInfo[])(object)obj69.t(bindingFlags, array5, obj, null), obj, cultureInfo);
				}
			}
		}
		Class7 class66 = @class;
		bindingFlags = default(BindingFlags);
		_ = (Struct1)class66.e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, (ParameterModifier[])((Class7)null).t((object)null, (Type)null, (CultureInfo)null));
		try
		{
			while (true)
			{
				if (obj != null)
				{
					@class = null;
				}
				else if (obj == null)
				{
					break;
				}
			}
		}
		finally
		{
			if (num2 == 0)
			{
				_ = (GClass2)(object)@class.W(bindingFlags, array6, type, array2, (ParameterModifier[])((Class7)null).t(obj, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default));
			}
			else
			{
				while ((object)Class5.Default != null)
				{
					qk = qk;
					_ = (GClass2)(object)Class5.Default;
					class21 = null;
				}
			}
			goto IL_3a2f;
		}
		IL_2124:
		if (num2 / num2 == 0)
		{
			_ = (Class9)((Class7)null).t(obj, (Type)null, (CultureInfo)null);
		}
		@struct = default(Struct2);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				Class7 class67 = @class;
				object object_18 = obj;
				Type type_10 = type;
				Class7 class68 = @class;
				bindingFlags = default(BindingFlags);
				if ((UIntPtr)((Class7)class67.t(object_18, type_10, (CultureInfo)class68.t(((Class7)null).W(bindingFlags, array6, type, (Type[])(object)@class.W(bindingFlags, array6, type, array2, (ParameterModifier[])(object)((Class7)null).j(bindingFlags, array, ref reference, array3, cultureInfo, (string[])null, out reference2)), (ParameterModifier[])(object)Class5.Default), type, null))).e(default(BindingFlags), null, (Type[])(object)Class5.Default, array3) == (UIntPtr)(nuint)0u)
				{
					@class = @class;
				}
			}
			finally
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					class22 = class22;
				}
				goto IL_2249;
			}
		}
		goto IL_2249;
	}

	unsafe static void m_00242G()
	{
		nuint uIntPtr = uIntPtr;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct2 @struct);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			do
			{
				_ = (GClass2)(object)Class5.Default;
				obj = obj;
			}
			while (obj != null);
		}
		else
		{
			while (obj != null)
			{
				do
				{
					@struct = (Struct2)Class5.Default;
					@struct = @struct;
				}
				while (obj != null);
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] array2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string[] array3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u && default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			Class7 obj2 = (Class7)(object)Class5.Default;
			bindingFlags = bindingFlags;
			BindingFlags bindingFlags_ = bindingFlags;
			array = null;
			MethodBase[] methodBase_ = array;
			array2 = array2;
			ParameterModifier[] parameterModifier_ = array2;
			cultureInfo = cultureInfo;
			CultureInfo cultureInfo_ = cultureInfo;
			array3 = array3;
			_ = (Class9)obj2.t(((Class7)null).j(bindingFlags_, methodBase_, ref *(object[]*)null, parameterModifier_, cultureInfo_, array3, out *(object*)Class5.Default), (Type)(object)Class5.Default, null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class7 @class);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] array4);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			while (true)
			{
				if ((object)Class5.Default != null)
				{
					@class = @class;
					Class7 class2 = @class;
					BindingFlags bindingFlags_2 = bindingFlags;
					type = type;
					Type type_ = type;
					array4 = null;
					_ = (_003CModule_003E)(object)class2.W(bindingFlags_2, null, type_, array4, null);
				}
				else if (obj == null)
				{
					break;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] array5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out FieldInfo[] array6);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class5 class3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class6 class7);
		try
		{
			class3 = class3;
			class3 = class3;
		}
		catch
		{
			do
			{
				BindingFlags bindingFlags_3 = bindingFlags;
				Type type_2 = type;
				Type[] type_3 = array4;
				BindingFlags bindingFlags_4 = bindingFlags;
				Class7 class4 = @class;
				Class7 obj3 = (Class7)((Class7)(object)Class5.Default).t(obj, type, (CultureInfo)(object)Class5.Default);
				Type type_4 = (Type)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_5 = bindingFlags;
				BindingFlags bindingFlags_6 = bindingFlags;
				array5 = (PropertyInfo[])(object)Class5.Default;
				PropertyInfo[] propertyInfo_ = array5;
				Class7 class5 = @class;
				Class7 class6 = @class;
				object object_ = obj;
				BindingFlags bindingFlags_7 = bindingFlags;
				array6 = array6;
				MethodBase[] methodBase_2 = (MethodBase[])((Class7)(object)((Class7)null).W(bindingFlags_6, propertyInfo_, (Type)null, (Type[])(object)class5.e((BindingFlags)class6.t(object_, (Type)(object)((Class7)null).t(bindingFlags_7, array6, obj, (CultureInfo)(object)Class5.Default), cultureInfo), null, (Type[])(object)Class5.Default, array2), array2)).t(null, null, cultureInfo);
				bindingFlags = default(BindingFlags);
				Class6 obj4 = (Class6)(object)((Class7)null).W(bindingFlags_3, (PropertyInfo[])null, type_2, type_3, (ParameterModifier[])(object)((Class7)null).e(bindingFlags_4, (MethodBase[])null, (Type[])class4.t(null, (Type)obj3.t(null, type_4, (CultureInfo)(object)((Class7)null).j(bindingFlags_5, methodBase_2, ref *(object[]*)null, (ParameterModifier[])(object)((Class7)null).W((BindingFlags)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array4, array2), (PropertyInfo[])(object)Class5.Default, type, array4, (ParameterModifier[])null), cultureInfo, array3, out *(object*)null)), null), array2));
				class7 = class7;
				class7 = obj4;
			}
			while (obj != null || obj != null);
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				while (obj != null)
				{
					_ = (Struct1)((Class7)((Class7)(object)@class.t(bindingFlags, array6, obj, cultureInfo)).t(obj, type, (CultureInfo)(object)Class5.Default)).W((BindingFlags)@class.t(obj, (Type)(object)Class5.Default, null), array5, null, null, array2);
				}
			}
			catch
			{
				@class = @class;
			}
		}
		do
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				_ = (GClass3)(object)Class5.Default;
			}
		}
		while (obj != null);
		while (obj != null)
		{
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct1 struct2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass1 gClass2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class2 class10);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass0 gClass);
		try
		{
			try
			{
				try
				{
					struct2 = default(Struct1);
					struct2 = struct2;
					struct2 = struct2;
				}
				finally
				{
					_003CModule_003E = null;
					_003CModule_003E = _003CModule_003E;
					goto end_IL_03a5;
				}
				end_IL_03a5:;
			}
			catch
			{
				try
				{
					_ = (Class8)(object)Class5.Default;
					_003CModule_003E = null;
					object object_2 = obj;
					Type type_5 = type;
					Class7 class8 = @class;
					bindingFlags = default(BindingFlags);
					Class7 obj7 = (Class7)((Class7)null).t(object_2, type_5, (CultureInfo)(object)class8.W(bindingFlags, array5, type, array4, array2));
					BindingFlags bindingFlags_8 = bindingFlags;
					MethodBase[] methodBase_3 = array;
					ref object[] object_3 = ref *(object[]*)Class5.Default;
					object object_4 = @class.t(null, type, (CultureInfo)@class.t(null, null, null));
					Type type_6 = type;
					bindingFlags = default(BindingFlags);
					_ = (GClass3)(object)obj7.j(bindingFlags_8, methodBase_3, ref object_3, (ParameterModifier[])(object)((Class7)((Class7)null).t(object_4, type_6, (CultureInfo)(object)((Class7)null).e(bindingFlags, array, (Type[])((Class7)null).t(obj, type, (CultureInfo)(object)Class5.Default), array2))).W(bindingFlags, null, null, array4, (ParameterModifier[])(object)@class.e(bindingFlags, (MethodBase[])(object)((Class7)null).t(bindingFlags, array6, (object)null, cultureInfo), array4, (ParameterModifier[])(object)Class5.Default)), (CultureInfo)(object)Class5.Default, array3, out *(object*)null);
				}
				catch
				{
					Class7 class9 = @class;
					bindingFlags = default(BindingFlags);
					class10 = (Class2)(object)class9.e(bindingFlags, array, null, null);
					class10 = class10;
				}
			}
		}
		catch
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					gClass = gClass;
					gClass = null;
				}
				catch
				{
					_ = (_003CModule_003E)(object)Class5.Default;
				}
			}
			else if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				gClass2 = gClass2;
				gClass2 = null;
			}
			else
			{
				_ = (Class9)(object)@class.W((BindingFlags)Class5.Default, (PropertyInfo[])(object)Class5.Default, type, array4, (ParameterModifier[])(object)Class5.Default);
			}
		}
		_ = (Class8)@class.t(obj, (Type)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, cultureInfo), null);
		try
		{
			_ = (GClass3)(object)Class5.Default;
		}
		finally
		{
			_ = (_003CModule_003E)(object)Class5.Default;
			goto IL_060f;
		}
		IL_449b:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qk7 qk);
		while (obj != null)
		{
			try
			{
				while (obj != null)
				{
					gClass2 = gClass2;
				}
			}
			catch
			{
				try
				{
					_ = (Class2)(object)@class.e((BindingFlags)@class.t(bindingFlags, array6, null, cultureInfo), null, (Type[])(object)Class5.Default, array2);
				}
				catch
				{
					qk = null;
					_ = (Class7)(object)@class.W(bindingFlags, array5, type, array4, array2);
					_ = (Class10)(object)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, (object)Class5.Default, cultureInfo);
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object[] reference);
		Class7 class12;
		do
		{
			try
			{
				while ((object)Class5.Default != null)
				{
					Class7 class11 = @class;
					BindingFlags bindingFlags_9 = bindingFlags;
					FieldInfo[] fieldInfo_ = (FieldInfo[])(object)@class.W((BindingFlags)Class5.Default, null, null, array4, array2);
					object object_5 = obj;
					bindingFlags = default(BindingFlags);
					_ = (GClass0)(object)((Class7)(object)class11.t(bindingFlags_9, fieldInfo_, object_5, (CultureInfo)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, array4, (ParameterModifier[])null))).W(bindingFlags, array5, type, array4, null);
				}
			}
			catch
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (Class6)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, (Type[])(object)Class5.Default, (ParameterModifier[])null);
				}
				else
				{
					_ = (Struct1)((Class7)null).t(obj, (Type)(object)Class5.Default, (CultureInfo)(object)((Class7)(object)Class5.Default).j(bindingFlags, array, ref reference, null, (CultureInfo)(object)Class5.Default, array3, out *(object*)Class5.Default));
				}
			}
			class12 = @class;
			bindingFlags = default(BindingFlags);
		}
		while ((object)class12.t(bindingFlags, null, obj, null) != null);
		try
		{
			_ = (GClass1)(object)Class5.Default;
		}
		catch
		{
			while ((object)@class.t((BindingFlags)Class5.Default, (FieldInfo[])(object)@class.e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, array4, array2), obj, cultureInfo) != null)
			{
				checked
				{
					if (unchecked((nuint)(UIntPtr)((Class7)null).e(bindingFlags, (MethodBase[])(object)@class.t(bindingFlags, null, obj, null), (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default)) * uIntPtr == 0)
					{
						_ = (GClass0)(object)Class5.Default;
					}
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object reference2);
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					Class7 obj16 = (Class7)(object)((Class7)(object)Class5.Default).W(bindingFlags, (PropertyInfo[])(object)@class.e(bindingFlags, null, null, array2), null, null, null);
					Class7 obj17 = (Class7)(object)@class.W(bindingFlags, (PropertyInfo[])@class.t(obj, type, cultureInfo), type, array4, null);
					BindingFlags bindingFlags_10 = bindingFlags;
					ref object[] object_6 = ref reference;
					Class7 class13 = @class;
					bindingFlags = default(BindingFlags);
					CultureInfo cultureInfo_2 = (CultureInfo)(object)((Class7)null).W((BindingFlags)((Class7)(object)((Class7)null).t((BindingFlags)class13.j(bindingFlags, (MethodBase[])((Class7)null).t(obj, type, cultureInfo), ref *(object[]*)Class5.Default, array2, cultureInfo, (string[])(object)((Class7)null).t(bindingFlags, array6, obj, (CultureInfo)(object)((Class7)null).e((BindingFlags)((Class7)(object)Class5.Default).e(bindingFlags, array, array4, array2), (MethodBase[])null, array4, (ParameterModifier[])(object)Class5.Default)), out reference2), array6, ((Class7)(object)Class5.Default).t(obj, null, cultureInfo), (CultureInfo)null)).e((BindingFlags)@class.e(bindingFlags, array, array4, array2), array, array4, (ParameterModifier[])(object)((Class7)(object)Class5.Default).W(bindingFlags, array5, type, null, array2)), array5, (Type)null, (Type[])null, (ParameterModifier[])null);
					string[] string_ = array3;
					BindingFlags bindingFlags_11 = (BindingFlags)Class5.Default;
					MethodBase[] methodBase_4 = array;
					Type[] type_7 = array4;
					BindingFlags bindingFlags_12 = (BindingFlags)Class5.Default;
					MethodBase[] methodBase_5 = array;
					Class7 class14 = @class;
					Class7 class15 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_13 = (BindingFlags)class15.e(bindingFlags, array, (Type[])(object)Class5.Default, null);
					PropertyInfo[] propertyInfo_2 = array5;
					Class7 class16 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_14 = (BindingFlags)((Class7)null).W(bindingFlags_13, propertyInfo_2, (Type)(object)class16.W(bindingFlags, null, type, null, array2), array4, (ParameterModifier[])null);
					FieldInfo[] fieldInfo_2 = (FieldInfo[])(object)Class5.Default;
					object object_7 = obj;
					Type type_8 = type;
					Class7 class17 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class7)(object)obj16.t((BindingFlags)obj17.j(bindingFlags_10, null, ref object_6, null, cultureInfo_2, string_, out *(object*)((Class7)null).e(bindingFlags_11, methodBase_4, type_7, (ParameterModifier[])(object)((Class7)null).e(bindingFlags_12, methodBase_5, (Type[])((Class7)((Class7)null).t((object)class14.t(bindingFlags_14, fieldInfo_2, null, (CultureInfo)((Class7)null).t(object_7, type_8, (CultureInfo)(object)class17.t(bindingFlags, null, obj, cultureInfo))), type, cultureInfo)).t(obj, null, cultureInfo), array2))), (FieldInfo[])(object)Class5.Default, null, null);
				}
			}
			finally
			{
				_ = (GClass1)@class.t(obj, (Type)(object)Class5.Default, cultureInfo);
				goto IL_49d7;
			}
		}
		while (obj != null)
		{
			do
			{
				class7 = class7;
			}
			while ((object)Class5.Default != null);
		}
		goto IL_49d7;
		IL_2145:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class10 class18);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass3 gClass3);
		try
		{
		}
		catch
		{
			try
			{
				gClass3 = null;
				Class7 obj18 = (Class7)(object)Class5.Default;
				Class7 obj19 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_15 = bindingFlags;
				PropertyInfo[] propertyInfo_3 = array5;
				Class7 obj20 = (Class7)((Class7)null).t(obj, (Type)(object)Class5.Default, cultureInfo);
				bindingFlags = default(BindingFlags);
				_ = (Class6)(object)obj18.t((BindingFlags)obj19.W(bindingFlags_15, propertyInfo_3, (Type)(object)obj20.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array2, null, (string[])(object)Class5.Default, out *(object*)null), null, array2), array6, obj, cultureInfo);
				Class7 obj21 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				_ = (GClass3)(object)((Class7)(object)obj21.W(bindingFlags, array5, type, null, array2)).j(bindingFlags, null, ref reference, array2, (CultureInfo)(object)Class5.Default, null, out reference2);
			}
			catch
			{
				class18 = null;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class8 class31);
		try
		{
			Class7 class19 = @class;
			BindingFlags bindingFlags_16 = bindingFlags;
			ref object[] object_8 = ref reference;
			Class7 class20 = @class;
			BindingFlags bindingFlags_17 = bindingFlags;
			Class7 class21 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_18 = bindingFlags;
			FieldInfo[] fieldInfo_3 = array6;
			object object_9 = Class5.Default;
			Class7 class22 = @class;
			Class7 class23 = @class;
			object object_10 = obj;
			Type type_9 = type;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_19 = bindingFlags;
			Class7 class24 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_20 = (BindingFlags)class23.t(object_10, type_9, (CultureInfo)(object)((Class7)null).e(bindingFlags_19, (MethodBase[])(object)class24.e(bindingFlags, null, array4, null), (Type[])(object)Class5.Default, array2));
			Class7 class25 = @class;
			BindingFlags bindingFlags_21 = bindingFlags;
			Class7 class26 = @class;
			BindingFlags bindingFlags_22 = bindingFlags;
			Class7 class27 = @class;
			bindingFlags = default(BindingFlags);
			ParameterModifier[] parameterModifier_2 = (ParameterModifier[])(object)((Class7)(object)class20.t(bindingFlags_17, (FieldInfo[])(object)class21.t(bindingFlags_18, fieldInfo_3, object_9, (CultureInfo)(object)class22.j(bindingFlags_20, null, ref *(object[]*)null, (ParameterModifier[])(object)class25.t(bindingFlags_21, (FieldInfo[])(object)class26.t(bindingFlags_22, (FieldInfo[])(object)class27.j(bindingFlags, null, ref reference, array2, cultureInfo, (string[])(object)@class.e(bindingFlags, array, array4, array2), out reference2), @class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, null, cultureInfo, array3, out *(object*)null), cultureInfo), obj, cultureInfo), cultureInfo, array3, out reference2)), @class.e((BindingFlags)Class5.Default, null, array4, array2), null)).t((BindingFlags)Class5.Default, array6, null, (CultureInfo)(object)Class5.Default);
			CultureInfo cultureInfo_3 = (CultureInfo)((Class7)(object)@class.t(bindingFlags, (FieldInfo[])(object)@class.W((BindingFlags)@class.t((BindingFlags)Class5.Default, array6, obj, cultureInfo), null, (Type)(object)Class5.Default, array4, array2), null, (CultureInfo)(object)Class5.Default)).t(obj, (Type)(object)Class5.Default, cultureInfo);
			string[] string_2 = array3;
			Class7 class28 = @class;
			BindingFlags bindingFlags_23 = bindingFlags;
			MethodBase[] methodBase_6 = (MethodBase[])(object)Class5.Default;
			ref object[] object_11 = ref reference;
			ParameterModifier[] parameterModifier_3 = (ParameterModifier[])(object)Class5.Default;
			Class7 class29 = @class;
			Class7 class30 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Class5)(object)((Class7)(object)class19.j(bindingFlags_16, null, ref object_8, parameterModifier_2, cultureInfo_3, string_2, out *(object*)class28.j(bindingFlags_23, methodBase_6, ref object_11, parameterModifier_3, null, (string[])(object)class29.e((BindingFlags)class30.j(bindingFlags, (MethodBase[])(object)@class.t((BindingFlags)Class5.Default, (FieldInfo[])(object)@class.t((BindingFlags)Class5.Default, array6, null, cultureInfo), null, (CultureInfo)(object)Class5.Default), ref reference, array2, (CultureInfo)(object)((Class7)null).e(bindingFlags, array, array4, (ParameterModifier[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)null, array4, array2)), array3, out *(object*)null), array, array4, null), out reference2))).t(bindingFlags, array6, Class5.Default, cultureInfo);
		}
		catch
		{
			if (uIntPtr == 0)
			{
				class7 = class7;
				_ = (Class7)(object)@class.t(bindingFlags, array6, obj, (CultureInfo)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)null, array4, (ParameterModifier[])(object)Class5.Default));
				class3 = class3;
				@struct = @struct;
			}
			else
			{
				class31 = (Class8)@class.t(null, null, (CultureInfo)(object)Class5.Default);
			}
		}
		finally
		{
			Class7 class32 = @class;
			object object_12 = obj;
			Type type_10 = type;
			Class7 class33 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_24 = (BindingFlags)class33.W(bindingFlags, null, (Type)(object)Class5.Default, array4, null);
			FieldInfo[] fieldInfo_4 = array6;
			BindingFlags bindingFlags_25 = bindingFlags;
			BindingFlags bindingFlags_26 = bindingFlags;
			MethodBase[] methodBase_7 = array;
			ref object[] object_13 = ref reference;
			BindingFlags bindingFlags_27 = (BindingFlags)Class5.Default;
			Class7 obj25 = (Class7)(object)Class5.Default;
			object object_14 = obj;
			Class7 class34 = @class;
			Class7 class35 = @class;
			Class7 obj26 = (Class7)(object)@class.W((BindingFlags)@class.W(bindingFlags, array5, null, (Type[])(object)Class5.Default, null), (PropertyInfo[])(object)Class5.Default, (Type)(object)((Class7)null).W((BindingFlags)Class5.Default, array5, (Type)null, array4, array2), (Type[])(object)Class5.Default, (ParameterModifier[])(object)((Class7)(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, (CultureInfo)(object)Class5.Default)).t((BindingFlags)Class5.Default, array6, null, cultureInfo));
			Class7 class36 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_28 = bindingFlags;
			MethodBase[] methodBase_8 = array;
			ref object[] object_15 = ref *(object[]*)Class5.Default;
			ParameterModifier[] parameterModifier_4 = array2;
			Class7 obj27 = (Class7)(object)((Class7)null).W(bindingFlags, array5, (Type)(object)Class5.Default, array4, (ParameterModifier[])(object)@class.j(bindingFlags, null, ref reference, null, cultureInfo, array3, out *(object*)null));
			Type type_11 = (Type)(object)Class5.Default;
			Class7 class37 = @class;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)class32.t(object_12, type_10, (CultureInfo)(object)((Class7)null).t(bindingFlags_24, fieldInfo_4, (object)((Class7)null).t(bindingFlags_25, (FieldInfo[])(object)((Class7)null).j(bindingFlags_26, methodBase_7, ref object_13, (ParameterModifier[])(object)((Class7)null).e(bindingFlags_27, (MethodBase[])obj25.t(object_14, (Type)(object)class34.j((BindingFlags)((Class7)(object)((Class7)(object)class35.t((BindingFlags)obj26.W((BindingFlags)class36.j(bindingFlags_28, methodBase_8, ref object_15, parameterModifier_4, (CultureInfo)obj27.t(null, type_11, (CultureInfo)(object)class37.W(bindingFlags, (PropertyInfo[])(object)@class.j((BindingFlags)Class5.Default, array, ref reference, (ParameterModifier[])(object)Class5.Default, (CultureInfo)@class.t(null, type, null), (string[])(object)@class.t((BindingFlags)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)null, array2, cultureInfo, array3, out reference2), array6, null, null), out reference2), (Type)(object)@class.W(bindingFlags, null, null, array4, array2), (Type[])(object)Class5.Default, array2)), array3, out reference2), array5, type, null, array2), null, @class.t(obj, type, null), null)).j(bindingFlags, array, ref reference, array2, cultureInfo, array3, out *(object*)null)).e((BindingFlags)Class5.Default, null, array4, null), array, ref reference, array2, cultureInfo, null, out reference2), cultureInfo), array4, array2), cultureInfo, (string[])(object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, array2, null, null, out reference2), out *(object*)null), (object)null, (CultureInfo)(object)((Class7)null).e((BindingFlags)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, (Type[])@class.t(null, type, cultureInfo), (ParameterModifier[])(object)Class5.Default), array, (Type[])null, array2)), cultureInfo)) == (UIntPtr)(nuint)0u)
			{
				Class7 class38 = @class;
				bindingFlags = default(BindingFlags);
				if ((UIntPtr)class38.j(bindingFlags, array, ref *(object[]*)null, null, null, array3, out *(object*)null) == (UIntPtr)(nuint)0u)
				{
					class3 = class3;
					_ = (Class5)@class.t(obj, (Type)(object)Class5.Default, cultureInfo);
				}
				else
				{
					@class = (Class7)(object)Class5.Default;
				}
			}
			goto IL_2a55;
		}
		IL_399a:
		if ((UIntPtr)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, null, (ParameterModifier[])(object)Class5.Default) == (UIntPtr)(nuint)0u)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				do
				{
					_ = (Class9)(object)@class.W(bindingFlags, array5, type, array4, array2);
				}
				while (obj != null);
			}
		}
		do
		{
			if (uIntPtr == 0 && uIntPtr == 0)
			{
				_ = (GClass3)(object)Class5.Default;
			}
		}
		while (obj != null);
		class18 = class18;
		class7 = class7;
		class18 = class18;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class4 class39);
		if (default(UIntPtr) != (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				_ = (GClass3)(object)Class5.Default;
			}
			else
			{
				class39 = null;
			}
		}
		try
		{
			while (obj != null)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					Class7 class40 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class6)(object)class40.t(bindingFlags, (FieldInfo[])(object)((Class7)(object)Class5.Default).t((BindingFlags)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)Class5.Default, cultureInfo, null, out *(object*)Class5.Default), (FieldInfo[])(object)Class5.Default, Class5.Default, cultureInfo), obj, cultureInfo);
				}
			}
		}
		catch
		{
			try
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Class6)(object)@class.W(bindingFlags, null, null, (Type[])(object)Class5.Default, array2);
				}
				else
				{
					gClass3 = gClass3;
					_ = (Class9)(object)Class5.Default;
				}
			}
			finally
			{
				_ = (Struct2)((Class7)null).e(bindingFlags, array, (Type[])null, (ParameterModifier[])null);
				goto end_IL_3b1d;
			}
			end_IL_3b1d:;
		}
		try
		{
			Class7 obj29 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			_ = (Struct2)obj29.e(bindingFlags, null, array4, array2);
			_ = (Class0)(object)Class5.Default;
			_ = (Class7)(object)Class5.Default;
		}
		catch
		{
			try
			{
				_ = (Class5)(object)((Class7)null).j((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, ref reference, (ParameterModifier[])(object)@class.j(bindingFlags, array, ref reference, null, cultureInfo, (string[])(object)Class5.Default, out reference2), cultureInfo, (string[])null, out reference2);
			}
			finally
			{
				do
				{
					_ = (GClass1)(object)Class5.Default;
				}
				while (obj != null);
				goto end_IL_3bc3;
			}
			end_IL_3bc3:;
		}
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class9 class41);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				qk = qk;
			}
			catch
			{
				while (obj != null)
				{
					class41 = null;
				}
			}
		}
		else
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				do
				{
					struct2 = struct2;
				}
				while (obj != null);
			}
			else
			{
				class31 = class31;
			}
		}
		do
		{
			if (uIntPtr == (UIntPtr)(nuint)0u && (UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				Class7 class42 = @class;
				BindingFlags bindingFlags_29 = bindingFlags;
				MethodBase[] methodBase_9 = array;
				ParameterModifier[] parameterModifier_5 = array2;
				CultureInfo cultureInfo_4 = (CultureInfo)(object)Class5.Default;
				Class7 obj32 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_30 = bindingFlags;
				Type[] type_12 = array4;
				Class7 class43 = @class;
				bindingFlags = default(BindingFlags);
				_ = (GClass1)(object)class42.j(bindingFlags_29, methodBase_9, ref *(object[]*)null, parameterModifier_5, cultureInfo_4, (string[])(object)obj32.e(bindingFlags_30, null, type_12, (ParameterModifier[])(object)class43.j((BindingFlags)((Class7)null).e(bindingFlags, array, (Type[])null, (ParameterModifier[])(object)Class5.Default), array, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, (string[])(object)Class5.Default, out reference2)), out *(object*)null);
			}
		}
		while (obj != null);
		struct2 = struct2;
		uIntPtr = default(UIntPtr);
		if (checked(unchecked(uIntPtr / (nuint)(UIntPtr)((Class7)null).e(bindingFlags, (MethodBase[])(object)((Class7)(object)Class5.Default).e(bindingFlags, array, null, array2), array4, array2)) * uIntPtr) == 0)
		{
			class7 = (Class6)@class.t(obj, null, cultureInfo);
			_ = (Struct2)Class5.Default;
			Class7 obj33 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_31 = bindingFlags;
			Class7 class44 = @class;
			bindingFlags = default(BindingFlags);
			class7 = (Class6)(object)obj33.e(bindingFlags_31, (MethodBase[])(object)class44.e(bindingFlags, (MethodBase[])(object)@class.j(bindingFlags, (MethodBase[])(object)@class.t((BindingFlags)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, (Type[])(object)((Class7)null).j((BindingFlags)Class5.Default, array, ref reference, array2, cultureInfo, array3, out reference2), array2), array6, Class5.Default, cultureInfo), ref reference, array2, cultureInfo, (string[])(object)Class5.Default, out *(object*)@class.e(bindingFlags, (MethodBase[])@class.t(obj, (Type)(object)Class5.Default, cultureInfo), array4, null)), (Type[])(object)@class.e(bindingFlags, array, array4, array2), null), array4, null);
		}
		try
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					class39 = null;
				}
			}
			finally
			{
				try
				{
					gClass3 = (GClass3)((Class7)(object)Class5.Default).t(null, type, cultureInfo);
				}
				catch
				{
					class41 = class41;
				}
				goto end_IL_3f0a;
			}
			end_IL_3f0a:;
		}
		finally
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (GClass2)@class.t(null, null, (CultureInfo)(object)Class5.Default);
					_ = (Class6)@class.t(obj, null, null);
				}
			}
			catch
			{
				if ((nuint)(UIntPtr)Class5.Default / (checked(unchecked((nuint)(UIntPtr)((Class7)(object)Class5.Default).j(bindingFlags, (MethodBase[])(object)((Class7)null).e((BindingFlags)@class.W((BindingFlags)@class.W(bindingFlags, array5, null, null, (ParameterModifier[])((Class7)(object)Class5.Default).t(obj, (Type)(object)((Class7)(object)Class5.Default).e(bindingFlags, null, array4, array2), (CultureInfo)(object)Class5.Default)), (PropertyInfo[])(object)@class.t((BindingFlags)Class5.Default, (FieldInfo[])((Class7)null).t((object)Class5.Default, (Type)null, cultureInfo), obj, cultureInfo), type, array4, array2), array, array4, (ParameterModifier[])null), ref reference, null, null, null, out reference2)) + (uIntPtr + uIntPtr)) / uIntPtr) == 0)
				{
					_ = (GClass3)(object)Class5.Default;
				}
			}
			goto IL_40b0;
		}
		IL_1de0:
		GClass2 gClass4;
		try
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = Class5.Default;
					_ = (Struct2)@class.j((BindingFlags)Class5.Default, array, ref reference, array2, null, null, out reference2);
					gClass3 = (GClass3)(object)Class5.Default;
				}
			}
			finally
			{
				gClass4 = gClass4;
				goto end_IL_1de1;
			}
			end_IL_1de1:;
		}
		catch
		{
			class18 = class18;
			bindingFlags = default(BindingFlags);
			_ = (Class5)(object)((Class7)null).j((BindingFlags)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, cultureInfo), array, ref reference, array2, cultureInfo, array3, out *(object*)Class5.Default);
			_ = (Class9)(object)Class5.Default;
		}
		if (uIntPtr == 0)
		{
			try
			{
				Class7 obj37 = (Class7)@class.t(null, null, cultureInfo);
				Class7 obj38 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				_ = (Class6)(object)obj37.t((BindingFlags)((Class7)(object)obj38.t(bindingFlags, null, null, (CultureInfo)(object)Class5.Default)).t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, ((Class7)null).e(bindingFlags, (MethodBase[])(object)@class.W(bindingFlags, array5, (Type)(object)((Class7)(object)Class5.Default).e(bindingFlags, array, null, array2), array4, array2), (Type[])null, array2), cultureInfo), array6, null, (CultureInfo)(object)Class5.Default);
			}
			catch
			{
				gClass2 = (GClass1)(object)Class5.Default;
			}
			finally
			{
				goto IL_2145;
			}
		}
		nuint num = uIntPtr;
		bindingFlags = default(BindingFlags);
		nuint num2;
		checked
		{
			num2 = unchecked((nuint)(UIntPtr)((Class7)null).e(bindingFlags, array, array4, array2)) - unchecked((nuint)(UIntPtr)@class.t(obj, (Type)@class.t(obj, null, null), null));
			uIntPtr = default(UIntPtr);
		}
		if (num / checked(num2 + uIntPtr - (uIntPtr + uIntPtr)) == 0)
		{
			_ = (Qk7)(object)Class5.Default;
			goto IL_2145;
		}
		try
		{
			Class7 obj40 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_32 = (BindingFlags)Class5.Default;
			MethodBase[] methodBase_10 = (MethodBase[])(object)Class5.Default;
			Class7 class45 = @class;
			object object_16 = obj;
			Type type_13 = (Type)(object)Class5.Default;
			Class7 class46 = @class;
			BindingFlags bindingFlags_33 = bindingFlags;
			Class7 class47 = @class;
			bindingFlags = default(BindingFlags);
			class18 = (Class10)(object)((Class7)(object)obj40.j(bindingFlags_32, methodBase_10, ref *(object[]*)null, (ParameterModifier[])(object)((Class7)null).t((BindingFlags)class45.t(object_16, type_13, (CultureInfo)(object)class46.e(bindingFlags_33, (MethodBase[])(object)class47.W(bindingFlags, array5, (Type)(object)Class5.Default, array4, (ParameterModifier[])(object)Class5.Default), null, array2)), (FieldInfo[])(object)@class.t(bindingFlags, null, ((Class7)null).t(bindingFlags, array6, (object)null, (CultureInfo)null), null), obj, (CultureInfo)null), cultureInfo, null, out reference2)).j(bindingFlags, null, ref reference, null, (CultureInfo)(object)Class5.Default, null, out *(object*)null);
			_ = (Class2)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, (Type[])(object)Class5.Default, array2);
		}
		finally
		{
			struct2 = struct2;
			goto IL_2145;
		}
		IL_101b:
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			while ((object)Class5.Default != null)
			{
				_ = (GClass0)(object)@class.t(bindingFlags, array6, null, cultureInfo);
			}
		}
		try
		{
			class10 = class10;
		}
		catch
		{
			nuint num3 = uIntPtr;
			uIntPtr = default(UIntPtr);
			if (num3 / uIntPtr == 0)
			{
				try
				{
					class3 = null;
				}
				catch
				{
					struct2 = (Struct1)Class5.Default;
					gClass = gClass;
				}
			}
		}
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
			BindingFlags bindingFlags_34;
			object object_17;
			Class7 class48;
			BindingFlags bindingFlags_35;
			MethodBase[] methodBase_11;
			ref object[] object_18;
			Class7 class49;
			BindingFlags bindingFlags_49;
			PropertyInfo[] propertyInfo_4;
			Class7 class60;
			do
			{
				try
				{
					gClass4 = (GClass2)(object)@class.t(bindingFlags, null, null, null);
				}
				finally
				{
					_003CModule_003E = _003CModule_003E;
					goto IL_10d1;
				}
				IL_10d1:
				bindingFlags = default(BindingFlags);
				bindingFlags_34 = bindingFlags;
				object_17 = obj;
				class48 = @class;
				bindingFlags_35 = (BindingFlags)@class.t(bindingFlags, null, obj, cultureInfo);
				methodBase_11 = array;
				object_18 = ref reference;
				class49 = @class;
				Class7 class50 = @class;
				BindingFlags bindingFlags_36 = bindingFlags;
				MethodBase[] methodBase_12 = array;
				ref object[] object_19 = ref reference;
				ParameterModifier[] parameterModifier_6 = array2;
				CultureInfo cultureInfo_5 = (CultureInfo)(object)Class5.Default;
				string[] string_3 = array3;
				Class7 obj43 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_37 = bindingFlags;
				BindingFlags bindingFlags_38 = (BindingFlags)Class5.Default;
				Class7 obj44 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_39 = bindingFlags;
				Class7 class51 = @class;
				BindingFlags bindingFlags_40 = bindingFlags;
				Class7 class52 = @class;
				Type type_14 = type;
				BindingFlags bindingFlags_41 = bindingFlags;
				MethodBase[] methodBase_13 = (MethodBase[])(object)Class5.Default;
				Class7 class53 = @class;
				object object_20 = obj;
				BindingFlags bindingFlags_42 = bindingFlags;
				Class7 class54 = @class;
				bindingFlags = default(BindingFlags);
				Class7 obj45 = (Class7)class53.t(object_20, (Type)(object)((Class7)null).j(bindingFlags_42, (MethodBase[])(object)class54.e(bindingFlags, array, array4, (ParameterModifier[])(object)@class.j((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, array2, cultureInfo, null, out reference2)), ref *(object[]*)null, array2, (CultureInfo)null, array3, out *(object*)null), null);
				BindingFlags bindingFlags_43 = bindingFlags;
				MethodBase[] methodBase_14 = array;
				bindingFlags = default(BindingFlags);
				Class7 obj46 = (Class7)(object)((Class7)(object)class51.W(bindingFlags_40, (PropertyInfo[])(object)((Class7)null).t((BindingFlags)class52.t(null, type_14, (CultureInfo)(object)((Class7)null).j(bindingFlags_41, methodBase_13, ref *(object[]*)obj45.j(bindingFlags_43, methodBase_14, ref *(object[]*)((Class7)null).e(bindingFlags, array, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default), null, (CultureInfo)(object)@class.W((BindingFlags)@class.W(bindingFlags, null, type, null, array2), array5, null, null, array2), null, out *(object*)@class.t(bindingFlags, null, obj, cultureInfo)), (ParameterModifier[])(object)Class5.Default, cultureInfo, (string[])null, out *(object*)Class5.Default)), array6, obj, (CultureInfo)(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, (CultureInfo)((Class7)null).t(obj, type, cultureInfo))), (Type)(object)Class5.Default, (Type[])(object)Class5.Default, array2)).W(bindingFlags, array5, type, null, (ParameterModifier[])(object)Class5.Default);
				Class7 class55 = @class;
				BindingFlags bindingFlags_44 = (BindingFlags)@class.t((BindingFlags)@class.e(bindingFlags, array, array4, (ParameterModifier[])(object)((Class7)null).W(bindingFlags, array5, (Type)null, array4, array2)), array6, obj, (CultureInfo)(object)Class5.Default);
				Class7 class56 = @class;
				Class7 class57 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_45 = (BindingFlags)((Class7)(object)class57.j(bindingFlags, null, ref reference, array2, null, array3, out reference2)).e(bindingFlags, array, array4, (ParameterModifier[])(object)@class.t(bindingFlags, array6, null, null));
				ref object[] object_21 = ref reference;
				Class7 obj47 = (Class7)(object)((Class7)null).t(bindingFlags, array6, (object)Class5.Default, cultureInfo);
				BindingFlags bindingFlags_46 = bindingFlags;
				Class7 obj48 = (Class7)(object)@class.W(bindingFlags, array5, null, null, (ParameterModifier[])(object)Class5.Default);
				BindingFlags bindingFlags_47 = bindingFlags;
				Class7 class58 = @class;
				BindingFlags bindingFlags_48 = (BindingFlags)Class5.Default;
				Class7 class59 = @class;
				Class7 obj49 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				bindingFlags_49 = (BindingFlags)class50.j(bindingFlags_36, methodBase_12, ref object_19, parameterModifier_6, cultureInfo_5, string_3, out *(object*)obj43.t(bindingFlags_37, (FieldInfo[])(object)((Class7)null).j(bindingFlags_38, (MethodBase[])(object)((Class7)null).e((BindingFlags)obj44.j(bindingFlags_39, (MethodBase[])(object)obj46.t((BindingFlags)class55.W(bindingFlags_44, (PropertyInfo[])(object)class56.j(bindingFlags_45, null, ref object_21, (ParameterModifier[])(object)obj47.t((BindingFlags)((Class7)null).W(bindingFlags_46, (PropertyInfo[])(object)obj48.t(bindingFlags_47, (FieldInfo[])(object)class58.W(bindingFlags_48, (PropertyInfo[])class59.t(obj49.W(bindingFlags, array5, type, (Type[])(object)((Class7)(object)@class.W(bindingFlags, array5, (Type)(object)((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])(object)Class5.Default, array4, null), null, array2)).e((BindingFlags)@class.t(obj, (Type)(object)Class5.Default, null), array, array4, array2), null), type, cultureInfo), null, array4, null), obj, cultureInfo), type, array4, array2), (FieldInfo[])(object)Class5.Default, obj, cultureInfo), cultureInfo, null, out reference2), type, null, (ParameterModifier[])(object)Class5.Default), array6, obj, (CultureInfo)(object)((Class7)(object)@class.t((BindingFlags)((Class7)null).j((BindingFlags)Class5.Default, array, ref *(object[]*)Class5.Default, array2, cultureInfo, (string[])null, out *(object*)Class5.Default), array6, null, (CultureInfo)(object)Class5.Default)).j(bindingFlags, array, ref *(object[]*)Class5.Default, null, cultureInfo, null, out *(object*)null)), ref *(object[]*)null, null, cultureInfo, array3, out *(object*)Class5.Default), array, (Type[])null, array2), ref *(object[]*)null, array2, (CultureInfo)(object)Class5.Default, array3, out *(object*)Class5.Default), obj, null));
				propertyInfo_4 = array5;
				class60 = @class;
				bindingFlags = default(BindingFlags);
			}
			while ((object)((Class7)null).t((BindingFlags)((Class7)null).t(bindingFlags_34, (FieldInfo[])null, object_17, (CultureInfo)(object)class48.j(bindingFlags_35, methodBase_11, ref object_18, (ParameterModifier[])(object)class49.W(bindingFlags_49, propertyInfo_4, (Type)(object)class60.W(bindingFlags, null, null, (Type[])(object)Class5.Default, array2), (Type[])(object)Class5.Default, array2), cultureInfo, array3, out *(object*)null)), array6, obj, cultureInfo) != null);
		}
		_ = (Class0)(object)Class5.Default;
		while (obj != null)
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				_ = (GClass1)(object)Class5.Default;
				gClass2 = (GClass1)(object)@class.W((BindingFlags)Class5.Default, (PropertyInfo[])(object)((Class7)(object)Class5.Default).t(bindingFlags, null, Class5.Default, (CultureInfo)(object)Class5.Default), type, (Type[])(object)Class5.Default, (ParameterModifier[])(object)((Class7)null).W((BindingFlags)Class5.Default, array5, (Type)null, array4, (ParameterModifier[])null));
				_ = (Qk7)(object)Class5.Default;
				Class7 class61 = @class;
				BindingFlags bindingFlags_50 = bindingFlags;
				Class7 class62 = @class;
				Class7 class63 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_51 = (BindingFlags)class63.j(bindingFlags, array, ref *(object[]*)((Class7)null).t(bindingFlags, array6, (object)null, cultureInfo), array2, null, (string[])(object)((Class7)null).e(default(BindingFlags), array, array4, array2), out *(object*)null);
				BindingFlags bindingFlags_52 = (BindingFlags)Class5.Default;
				Class7 obj51 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				@class = (Class7)(object)class61.W(bindingFlags_50, (PropertyInfo[])(object)class62.t(bindingFlags_51, (FieldInfo[])(object)((Class7)null).t(bindingFlags_52, (FieldInfo[])null, (object)obj51.W(bindingFlags, (PropertyInfo[])((Class7)(object)@class.e(bindingFlags, array, array4, null)).t(obj, type, null), null, array4, array2), (CultureInfo)null), obj, null), type, array4, null);
			}
			else if ((UIntPtr)((Class7)null).W((BindingFlags)Class5.Default, array5, type, array4, (ParameterModifier[])null) == (UIntPtr)(nuint)0u)
			{
				class3 = Class5.Default;
				_ = (Qk7)(object)Class5.Default;
			}
			else
			{
				BindingFlags bindingFlags_53 = (BindingFlags)Class5.Default;
				ParameterModifier[] parameterModifier_7 = array2;
				Class7 class64 = @class;
				BindingFlags bindingFlags_54 = (BindingFlags)Class5.Default;
				MethodBase[] methodBase_15 = array;
				ParameterModifier[] parameterModifier_8 = (ParameterModifier[])(object)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, null, array4, array2);
				CultureInfo cultureInfo_6 = cultureInfo;
				string[] string_4 = array3;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_55 = bindingFlags;
				Class7 obj52 = (Class7)(object)@class.e(bindingFlags, array, array4, null);
				MethodBase[] methodBase_16 = array;
				ParameterModifier[] parameterModifier_9 = array2;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_56 = (BindingFlags)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, array4, (ParameterModifier[])@class.t(obj, type, cultureInfo));
				BindingFlags bindingFlags_57 = (BindingFlags)Class5.Default;
				Class7 class65 = @class;
				BindingFlags bindingFlags_58 = bindingFlags;
				Type type_15 = type;
				bindingFlags = default(BindingFlags);
				Class7 obj53 = (Class7)(object)((Class7)null).j(bindingFlags_53, (MethodBase[])null, ref *(object[]*)null, parameterModifier_7, (CultureInfo)null, (string[])null, out *(object*)class64.j(bindingFlags_54, methodBase_15, ref *(object[]*)null, parameterModifier_8, cultureInfo_6, string_4, out *(object*)((Class7)null).W(bindingFlags_55, (PropertyInfo[])null, (Type)(object)obj52.j(default(BindingFlags), methodBase_16, ref *(object[]*)null, parameterModifier_9, (CultureInfo)(object)((Class7)null).t((BindingFlags)((Class7)null).W(bindingFlags_56, (PropertyInfo[])(object)((Class7)null).j(bindingFlags_57, (MethodBase[])(object)class65.W(bindingFlags_58, null, type_15, (Type[])(object)((Class7)null).e((BindingFlags)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)Class5.Default, cultureInfo), array, (Type[])null, (ParameterModifier[])null), null), ref reference, array2, (CultureInfo)(object)((Class7)(object)Class5.Default).j((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, ref reference, array2, null, (string[])(object)Class5.Default, out reference2), (string[])null, out reference2), (Type)null, (Type[])null, (ParameterModifier[])(object)@class.t(bindingFlags, array6, obj, (CultureInfo)((Class7)((Class7)null).t(obj, (Type)null, cultureInfo)).t(obj, null, cultureInfo))), (FieldInfo[])null, (object)null, (CultureInfo)null), (string[])(object)@class.e(bindingFlags, array, array4, (ParameterModifier[])(object)@class.t(bindingFlags, array6, obj, cultureInfo)), out reference2), array4, array2)));
				bindingFlags = default(BindingFlags);
				_ = (Class7)(object)obj53.e(bindingFlags, array, null, (ParameterModifier[])(object)Class5.Default);
			}
		}
		try
		{
			try
			{
				class10 = null;
				_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
				_ = (GClass0)(object)Class5.Default;
				@struct = @struct;
			}
			catch
			{
				class31 = class31;
			}
			finally
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					Class7 class66 = @class;
					BindingFlags bindingFlags_59 = bindingFlags;
					Class7 class67 = @class;
					BindingFlags bindingFlags_60 = (BindingFlags)((Class7)(object)Class5.Default).t(obj, (Type)@class.t(((Class7)null).t(obj, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default), (Type)(object)Class5.Default, null), null);
					MethodBase[] methodBase_17 = array;
					ref object[] object_22 = ref reference;
					Class7 class68 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_61 = bindingFlags;
					ref object[] object_23 = ref reference;
					Class7 class69 = @class;
					bindingFlags = default(BindingFlags);
					Class7 obj55 = (Class7)(object)class68.j(bindingFlags_61, null, ref object_23, (ParameterModifier[])(object)class69.t(bindingFlags, array6, ((Class7)null).t(obj, type, cultureInfo), null), (CultureInfo)(object)Class5.Default, null, out reference2);
					BindingFlags bindingFlags_62 = (BindingFlags)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Class10)(object)class66.W(bindingFlags_59, (PropertyInfo[])(object)class67.j(bindingFlags_60, methodBase_17, ref object_22, (ParameterModifier[])(object)obj55.e(bindingFlags_62, (MethodBase[])((Class7)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])null, (ParameterModifier[])(object)Class5.Default)).t(obj, null, (CultureInfo)@class.t(obj, type, null)), (Type[])(object)Class5.Default, null), cultureInfo, null, out *(object*)Class5.Default), type, array4, array2);
				}
				goto end_IL_1b8b;
			}
			end_IL_1b8b:;
		}
		finally
		{
			goto IL_1d52;
		}
		IL_49d7:
		try
		{
			nuint num4 = uIntPtr;
			nuint num5 = uIntPtr / uIntPtr;
			uIntPtr = default(UIntPtr);
			if (num4 / checked(num5 * uIntPtr) != 0)
			{
				try
				{
					Class7 class70 = @class;
					BindingFlags bindingFlags_63 = (BindingFlags)Class5.Default;
					Class7 class71 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class8)(object)class70.W(bindingFlags_63, (PropertyInfo[])(object)class71.W(bindingFlags, null, null, array4, array2), (Type)(object)@class.j(bindingFlags, array, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, null, array3, out *(object*)@class.t(obj, type, (CultureInfo)((Class7)(object)Class5.Default).t(obj, null, (CultureInfo)(object)@class.e(bindingFlags, array, array4, null)))), null, (ParameterModifier[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, (object)@class.W(bindingFlags, (PropertyInfo[])(object)((Class7)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, cultureInfo)).W(bindingFlags, array5, (Type)(object)Class5.Default, (Type[])(object)Class5.Default, array2), (Type)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference, (ParameterModifier[])null, (CultureInfo)(object)@class.t(bindingFlags, array6, obj, cultureInfo), (string[])@class.t(obj, type, cultureInfo), out reference2), array4, null), (CultureInfo)(object)@class.j(bindingFlags, (MethodBase[])(object)((Class7)null).t((BindingFlags)((Class7)null).t((object)null, type, (CultureInfo)null), array6, (object)Class5.Default, (CultureInfo)null), ref *(object[]*)null, null, null, null, out reference2)));
				}
				finally
				{
					_ = (GClass1)(object)((Class7)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, array4, array2)).t(bindingFlags, array6, null, null);
					Class7 class72 = @class;
					BindingFlags bindingFlags_64 = (BindingFlags)Class5.Default;
					Class7 class73 = @class;
					BindingFlags bindingFlags_65 = bindingFlags;
					Class7 class74 = @class;
					BindingFlags bindingFlags_66 = bindingFlags;
					MethodBase[] methodBase_18 = array;
					Class7 class75 = @class;
					BindingFlags bindingFlags_67 = bindingFlags;
					PropertyInfo[] propertyInfo_5 = (PropertyInfo[])(object)Class5.Default;
					Class7 class76 = @class;
					bindingFlags = default(BindingFlags);
					Class7 obj56 = (Class7)(object)class75.W(bindingFlags_67, propertyInfo_5, (Type)(object)class76.j(bindingFlags, null, ref *(object[]*)null, null, cultureInfo, array3, out reference2), array4, array2);
					bindingFlags = default(BindingFlags);
					Type[] type_16 = (Type[])(object)obj56.W(bindingFlags, null, type, null, null);
					Class7 class77 = @class;
					BindingFlags bindingFlags_68 = (BindingFlags)((Class7)(object)Class5.Default).e(bindingFlags, array, array4, array2);
					MethodBase[] methodBase_19 = array;
					ref object[] object_24 = ref reference;
					ParameterModifier[] parameterModifier_10 = array2;
					Class7 class78 = @class;
					object object_25 = obj;
					Type type_17 = type;
					Class7 class79 = @class;
					BindingFlags bindingFlags_69 = bindingFlags;
					Class7 class80 = @class;
					BindingFlags bindingFlags_70 = (BindingFlags)Class5.Default;
					Class7 class81 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass1)(object)class72.t(bindingFlags_64, null, ((Class7)(object)class73.W(bindingFlags_65, (PropertyInfo[])(object)class74.e(bindingFlags_66, methodBase_18, type_16, (ParameterModifier[])(object)class77.j(bindingFlags_68, methodBase_19, ref object_24, parameterModifier_10, (CultureInfo)class78.t(object_25, type_17, (CultureInfo)(object)class79.t(bindingFlags_69, (FieldInfo[])(object)class80.e(bindingFlags_70, null, null, (ParameterModifier[])(object)class81.W(bindingFlags, array5, null, array4, array2)), obj, (CultureInfo)(object)Class5.Default)), (string[])(object)Class5.Default, out reference2)), type, null, array2)).e(bindingFlags, (MethodBase[])(object)Class5.Default, array4, array2), (CultureInfo)(object)@class.e(bindingFlags, array, array4, array2));
					class41 = null;
					goto end_IL_49d8;
				}
			}
			try
			{
				class3 = class3;
			}
			catch
			{
				gClass4 = gClass4;
			}
			end_IL_49d8:;
		}
		finally
		{
			_ = (GClass0)@class.t(null, (Type)(object)((Class7)(object)Class5.Default).e(bindingFlags, array, array4, array2), null);
			class3 = null;
			gClass = gClass;
			goto IL_4e06;
		}
		IL_5997:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class0 class82);
		if (uIntPtr == 0 && uIntPtr == 0)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				@struct = @struct;
				_ = (Class0)(object)@class.t(bindingFlags, array6, null, (CultureInfo)(object)Class5.Default);
				_ = (Class10)(object)Class5.Default;
			}
			else
			{
				class82 = class82;
			}
		}
		do
		{
			_ = (_003CModule_003E)(object)Class5.Default;
		}
		while ((object)Class5.Default != null || (object)Class5.Default != null);
		_ = (Qk7)(object)((Class7)null).t(bindingFlags, array6, obj, cultureInfo);
		BindingFlags bindingFlags_71 = bindingFlags;
		Class7 class83 = @class;
		bindingFlags = default(BindingFlags);
		_ = (Class6)(object)((Class7)null).e(bindingFlags_71, (MethodBase[])((Class7)(object)class83.e(bindingFlags, array, array4, (ParameterModifier[])(object)Class5.Default)).t(@class.t((BindingFlags)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)null, cultureInfo), array6, obj, null), null, null), array4, array2);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					class82 = class82;
				}
				finally
				{
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_72 = bindingFlags;
					Class7 class84 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Qk7)(object)((Class7)null).e(bindingFlags_72, (MethodBase[])null, (Type[])(object)class84.t(bindingFlags, null, obj, null), (ParameterModifier[])(object)((Class7)null).e(bindingFlags, array, array4, array2));
					goto end_IL_5ac6;
				}
				end_IL_5ac6:;
			}
			catch
			{
				try
				{
					_ = (Qk7)(object)Class5.Default;
				}
				finally
				{
					_ = (_003CModule_003E)(object)((Class7)(object)Class5.Default).j((BindingFlags)((Class7)null).e((BindingFlags)Class5.Default, array, array4, (ParameterModifier[])(object)Class5.Default), null, ref reference, array2, null, null, out reference2);
					class41 = (Class9)(object)Class5.Default;
					_ = (Class10)(object)((Class7)@class.t(obj, (Type)(object)((Class7)(object)((Class7)(object)Class5.Default).W((BindingFlags)((Class7)(object)Class5.Default).j(bindingFlags, (MethodBase[])@class.t(obj, (Type)(object)Class5.Default, cultureInfo), ref *(object[]*)null, array2, null, array3, out reference2), (PropertyInfo[])(object)Class5.Default, (Type)(object)Class5.Default, array4, null)).e((BindingFlags)Class5.Default, array, (Type[])(object)((Class7)null).t(bindingFlags, array6, obj, (CultureInfo)(object)Class5.Default), null), (CultureInfo)(object)Class5.Default)).e(bindingFlags, (MethodBase[])(object)@class.e(bindingFlags, array, (Type[])((Class7)null).t((object)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)null, cultureInfo), type, cultureInfo), null), array4, array2);
					_ = (Qk7)(object)((Class7)null).W(bindingFlags, array5, type, array4, array2);
					goto end_IL_5b30;
				}
				end_IL_5b30:;
			}
		}
		uIntPtr = default(UIntPtr);
		checked
		{
			if (uIntPtr * uIntPtr == 0)
			{
				struct2 = (Struct1)Class5.Default;
				@class = @class;
			}
			else
			{
				try
				{
					_ = (Class0)(object)@class.W(bindingFlags, array5, null, array4, (ParameterModifier[])(object)@class.e(bindingFlags, array, array4, (ParameterModifier[])(object)@class.W(bindingFlags, null, null, null, array2)));
				}
				catch
				{
					UIntPtr num6 = unchecked((UIntPtr)Class5.Default);
					uIntPtr = default(UIntPtr);
					if (unchecked((nuint)num6) * uIntPtr == 0)
					{
						class41 = class41;
					}
				}
			}
		}
		try
		{
			bindingFlags = default(BindingFlags);
			_ = (Class5)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)null, cultureInfo);
		}
		catch
		{
			try
			{
				Class7 class85 = @class;
				BindingFlags bindingFlags_73 = bindingFlags;
				FieldInfo[] fieldInfo_5 = array6;
				object object_26 = @class.t(obj, null, cultureInfo);
				BindingFlags bindingFlags_74 = (BindingFlags)((Class7)null).j((BindingFlags)Class5.Default, (MethodBase[])null, ref reference, array2, cultureInfo, array3, out reference2);
				bindingFlags = default(BindingFlags);
				_ = (Class9)(object)class85.t(bindingFlags_73, fieldInfo_5, object_26, (CultureInfo)(object)((Class7)null).W(bindingFlags_74, (PropertyInfo[])(object)((Class7)null).j(bindingFlags, array, ref reference, (ParameterModifier[])null, cultureInfo, array3, out reference2), type, (Type[])(object)((Class7)((Class7)(object)@class.W(bindingFlags, array5, type, (Type[])(object)Class5.Default, null)).t(obj, type, (CultureInfo)(object)Class5.Default)).t(bindingFlags, array6, Class5.Default, cultureInfo), array2));
			}
			finally
			{
				try
				{
					class82 = (Class0)(object)Class5.Default;
					Class7 class86 = @class;
					BindingFlags bindingFlags_75 = bindingFlags;
					BindingFlags bindingFlags_76 = (BindingFlags)((Class7)(object)Class5.Default).t(obj, type, cultureInfo);
					PropertyInfo[] propertyInfo_6 = (PropertyInfo[])(object)Class5.Default;
					Type type_18 = (Type)(object)Class5.Default;
					Class7 class87 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class4)(object)class86.e(bindingFlags_75, (MethodBase[])(object)((Class7)null).W(bindingFlags_76, propertyInfo_6, type_18, (Type[])(object)class87.W(default(BindingFlags), null, (Type)(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array2, cultureInfo, array3, out reference2), (Type[])(object)((Class7)(object)@class.j((BindingFlags)Class5.Default, array, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, array3, out reference2)).W((BindingFlags)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])null, (Type)(object)Class5.Default, (Type[])null, array2), array5, type, array4, array2), array2), (ParameterModifier[])(object)@class.j((BindingFlags)((Class7)(object)@class.t((BindingFlags)@class.t((BindingFlags)((Class7)(object)((Class7)(object)Class5.Default).e(bindingFlags, array, array4, null)).W(bindingFlags, array5, type, null, null), (FieldInfo[])(object)Class5.Default, obj, null), (FieldInfo[])(object)@class.j(bindingFlags, null, ref *(object[]*)((Class7)(object)Class5.Default).e(bindingFlags, null, (Type[])(object)Class5.Default, null), null, (CultureInfo)(object)Class5.Default, array3, out reference2), null, null)).t(bindingFlags, array6, Class5.Default, (CultureInfo)((Class7)(object)@class.e(bindingFlags, array, array4, null)).t(obj, null, cultureInfo)), array, ref *(object[]*)@class.j(bindingFlags, null, ref reference, null, cultureInfo, null, out *(object*)Class5.Default), null, cultureInfo, array3, out *(object*)null)), (Type[])(object)Class5.Default, array2);
				}
				catch
				{
					class18 = class18;
				}
				goto end_IL_5da8;
			}
			end_IL_5da8:;
		}
		Class7 obj62 = (Class7)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		Class7 obj63 = (Class7)(object)obj62.t(bindingFlags, array6, obj, (CultureInfo)(object)Class5.Default);
		BindingFlags bindingFlags_77 = (BindingFlags)Class5.Default;
		Class7 class88 = @class;
		BindingFlags bindingFlags_78 = bindingFlags;
		MethodBase[] methodBase_20 = array;
		ref object[] object_27 = ref *(object[]*)Class5.Default;
		ParameterModifier[] parameterModifier_11 = array2;
		CultureInfo cultureInfo_7 = cultureInfo;
		string[] string_5 = array3;
		Class7 class89 = @class;
		BindingFlags bindingFlags_79 = (BindingFlags)@class.t(obj, type, null);
		ref object[] object_28 = ref *(object[]*)Class5.Default;
		ParameterModifier[] parameterModifier_12 = array2;
		CultureInfo cultureInfo_8 = cultureInfo;
		Class7 class90 = @class;
		BindingFlags bindingFlags_80 = (BindingFlags)Class5.Default;
		MethodBase[] methodBase_21 = array;
		ref object[] object_29 = ref *(object[]*)@class.e((BindingFlags)Class5.Default, array, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
		ParameterModifier[] parameterModifier_13 = array2;
		Class7 class91 = @class;
		BindingFlags bindingFlags_81 = (BindingFlags)Class5.Default;
		bindingFlags = default(BindingFlags);
		string[] string_6 = (string[])(object)class90.j(bindingFlags_80, methodBase_21, ref object_29, parameterModifier_13, (CultureInfo)(object)class91.W(bindingFlags_81, (PropertyInfo[])(object)((Class7)null).j(bindingFlags, array, ref *(object[]*)((Class7)null).t(bindingFlags, array6, ((Class7)(object)Class5.Default).t(obj, type, (CultureInfo)(object)Class5.Default), cultureInfo), (ParameterModifier[])null, cultureInfo, (string[])(object)Class5.Default, out reference2), type, (Type[])(object)Class5.Default, (ParameterModifier[])(object)@class.e(bindingFlags, array, array4, array2)), array3, out reference2);
		Class7 obj64 = (Class7)(object)@class.W(default(BindingFlags), array5, type, array4, array2);
		bindingFlags = default(BindingFlags);
		MethodBase[] methodBase_22 = (MethodBase[])(object)class88.j(bindingFlags_78, methodBase_20, ref object_27, parameterModifier_11, cultureInfo_7, string_5, out *(object*)class89.j(bindingFlags_79, null, ref object_28, parameterModifier_12, cultureInfo_8, string_6, out *(object*)obj64.t(bindingFlags, array6, null, null)));
		Type[] type_19 = array4;
		Class7 class92 = @class;
		BindingFlags bindingFlags_82 = bindingFlags;
		PropertyInfo[] propertyInfo_7 = array5;
		Type type_20 = type;
		Class7 class93 = @class;
		BindingFlags bindingFlags_83 = bindingFlags;
		FieldInfo[] fieldInfo_6 = array6;
		Class7 obj65 = (Class7)@class.t(obj, type, null);
		Class7 class94 = @class;
		bindingFlags = default(BindingFlags);
		Class7 obj66 = (Class7)(object)class93.t(bindingFlags_83, fieldInfo_6, obj65.e(default(BindingFlags), (MethodBase[])(object)class94.W(bindingFlags, array5, type, array4, null), array4, null), (CultureInfo)@class.t(null, type, cultureInfo));
		Class7 class95 = @class;
		BindingFlags bindingFlags_84 = bindingFlags;
		MethodBase[] methodBase_23 = (MethodBase[])(object)Class5.Default;
		Class7 class96 = @class;
		Class7 class97 = @class;
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_85 = (BindingFlags)((Class7)null).t((BindingFlags)class95.j(bindingFlags_84, methodBase_23, ref *(object[]*)null, (ParameterModifier[])(object)((Class7)(object)class96.t((BindingFlags)class97.t(bindingFlags, array6, null, cultureInfo), array6, obj, cultureInfo)).W((BindingFlags)Class5.Default, array5, (Type)(object)Class5.Default, null, array2), cultureInfo, (string[])(object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo, array3, out reference2), out reference2), array6, (object)null, cultureInfo);
		MethodBase[] methodBase_24 = array;
		Class7 class98 = @class;
		MethodBase[] methodBase_25 = array;
		ref object[] object_30 = ref reference;
		CultureInfo cultureInfo_9 = cultureInfo;
		string[] string_7 = array3;
		Class7 obj67 = (Class7)((Class7)(object)((Class7)null).e(default(BindingFlags), (MethodBase[])@class.t(obj, type, null), (Type[])null, array2)).t(Class5.Default, null, null);
		bindingFlags = default(BindingFlags);
		class3 = (Class5)(object)((Class7)null).j((BindingFlags)obj63.e(bindingFlags_77, methodBase_22, type_19, (ParameterModifier[])(object)class92.W((BindingFlags)((Class7)null).W(bindingFlags_82, propertyInfo_7, type_20, (Type[])(object)obj66.j(bindingFlags_85, methodBase_24, ref *(object[]*)class98.j(default(BindingFlags), methodBase_25, ref object_30, null, cultureInfo_9, string_7, out *(object*)obj67.W(bindingFlags, array5, type, null, null)), (ParameterModifier[])(object)((Class7)null).j((BindingFlags)Class5.Default, array, ref *(object[]*)null, array2, (CultureInfo)null, (string[])(object)Class5.Default, out reference2), (CultureInfo)(object)Class5.Default, null, out *(object*)Class5.Default), array2), null, (Type)@class.t(null, null, (CultureInfo)(object)Class5.Default), array4, (ParameterModifier[])(object)Class5.Default)), (MethodBase[])null, ref reference, (ParameterModifier[])null, (CultureInfo)(object)Class5.Default, array3, out reference2);
		Class7 obj69;
		BindingFlags bindingFlags_88;
		MethodBase[] methodBase_27;
		Type[] type_23;
		BindingFlags bindingFlags_89;
		MethodBase[] methodBase_28;
		Class7 class101;
		do
		{
			Class7 obj68 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_86 = (BindingFlags)Class5.Default;
			PropertyInfo[] propertyInfo_8 = (PropertyInfo[])(object)((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])(object)((Class7)null).W(default(BindingFlags), (PropertyInfo[])(object)Class5.Default, (Type)(object)Class5.Default, array4, array2), array4, array2);
			Type type_21 = type;
			MethodBase[] methodBase_26 = array;
			Class7 class99 = @class;
			bindingFlags = default(BindingFlags);
			ref object[] object_31 = ref *(object[]*)class99.W(bindingFlags, null, null, array4, null);
			BindingFlags bindingFlags_87 = bindingFlags;
			Class7 class100 = @class;
			bindingFlags = default(BindingFlags);
			Type[] type_22 = (Type[])(object)((Class7)null).j(default(BindingFlags), methodBase_26, ref object_31, (ParameterModifier[])(object)((Class7)null).W(bindingFlags_87, (PropertyInfo[])(object)class100.e(bindingFlags, array, null, null), type, array4, (ParameterModifier[])null), cultureInfo, (string[])(object)@class.j((BindingFlags)Class5.Default, array, ref reference, array2, cultureInfo, (string[])(object)@class.e(bindingFlags, null, array4, null), out *(object*)Class5.Default), out *(object*)null);
			bindingFlags = default(BindingFlags);
			_ = (Struct1)obj68.W(bindingFlags_86, propertyInfo_8, type_21, type_22, (ParameterModifier[])(object)((Class7)null).j(bindingFlags, array, ref reference, (ParameterModifier[])null, cultureInfo, array3, out *(object*)null));
			obj69 = (Class7)(object)@class.W((BindingFlags)((Class7)null).t(bindingFlags, array6, obj, (CultureInfo)null), array5, type, null, null);
			bindingFlags_88 = bindingFlags;
			methodBase_27 = array;
			type_23 = (Type[])(object)@class.j(bindingFlags, array, ref reference, null, cultureInfo, array3, out reference2);
			bindingFlags_89 = (BindingFlags)((Class7)null).e((BindingFlags)Class5.Default, array, (Type[])null, (ParameterModifier[])null);
			methodBase_28 = array;
			class101 = @class;
			bindingFlags = default(BindingFlags);
		}
		while ((object)obj69.e(bindingFlags_88, methodBase_27, type_23, (ParameterModifier[])(object)((Class7)null).e(bindingFlags_89, methodBase_28, (Type[])(object)class101.W(bindingFlags, array5, (Type)(object)Class5.Default, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default), (ParameterModifier[])(object)((Class7)(object)Class5.Default).t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, cultureInfo))) != null);
		try
		{
			if (uIntPtr == 0)
			{
				try
				{
					_ = (Qk7)(object)Class5.Default;
				}
				catch
				{
					_ = (GClass1)(object)Class5.Default;
					class3 = null;
					@class = @class;
				}
			}
			else if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (Struct2)@class.t((BindingFlags)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])((Class7)null).t((object)null, type, cultureInfo), obj, (CultureInfo)null), (FieldInfo[])(object)((Class7)(object)Class5.Default).t(bindingFlags, null, Class5.Default, cultureInfo), obj, cultureInfo);
			}
			else
			{
				Class7 class102 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_90 = bindingFlags;
				MethodBase[] methodBase_29 = (MethodBase[])(object)Class5.Default;
				ParameterModifier[] parameterModifier_14 = array2;
				string[] string_8 = array3;
				BindingFlags bindingFlags_91 = bindingFlags;
				Type[] type_24 = (Type[])(object)Class5.Default;
				Class7 obj71 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				Class7 obj72 = (Class7)(object)((Class7)null).e(bindingFlags_91, (MethodBase[])null, type_24, (ParameterModifier[])(object)obj71.j(bindingFlags, array, ref *(object[]*)null, null, (CultureInfo)(object)@class.t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, obj, cultureInfo), (string[])(object)Class5.Default, out *(object*)null));
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_92 = bindingFlags;
				PropertyInfo[] propertyInfo_9 = (PropertyInfo[])(object)Class5.Default;
				Class7 obj73 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				_ = (Class6)(object)class102.j(bindingFlags_90, methodBase_29, ref *(object[]*)null, parameterModifier_14, null, string_8, out *(object*)obj72.W(bindingFlags_92, propertyInfo_9, (Type)(object)obj73.e(bindingFlags, array, array4, null), array4, null));
			}
		}
		finally
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				while (obj != null)
				{
					_ = (Class7)(object)@class.W((BindingFlags)Class5.Default, array5, (Type)(object)Class5.Default, (Type[])(object)@class.W((BindingFlags)@class.t(obj, type, cultureInfo), null, type, (Type[])(object)Class5.Default, null), array2);
					gClass2 = null;
					_ = (Qk7)(object)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, (object)Class5.Default, cultureInfo);
					struct2 = struct2;
				}
			}
			goto IL_6ad2;
		}
		IL_73b8:
		while ((object)Class5.Default != null)
		{
			do
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					Class7 obj74 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (GClass1)(object)obj74.t(bindingFlags, null, obj, null);
					_ = (_003CModule_003E)(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)(object)Class5.Default, array4, array2);
					gClass3 = gClass3;
					class31 = null;
				}
			}
			while (obj != null);
		}
		class7 = (Class6)(object)Class5.Default;
		class31 = class31;
		return;
		IL_4e06:
		class41 = (Class9)(object)Class5.Default;
		while (obj != null)
		{
			try
			{
				gClass4 = (GClass2)(object)Class5.Default;
			}
			catch
			{
				Class7 class103 = @class;
				BindingFlags bindingFlags_93 = bindingFlags;
				Class7 class104 = @class;
				bindingFlags = default(BindingFlags);
				@struct = (Struct2)class103.j(bindingFlags_93, (MethodBase[])(object)class104.W(bindingFlags, array5, type, (Type[])(object)Class5.Default, null), ref reference, array2, (CultureInfo)(object)Class5.Default, array3, out *(object*)null);
			}
			finally
			{
				_ = (Class6)(object)((Class7)(object)((Class7)null).e(bindingFlags, array, array4, (ParameterModifier[])null)).W(bindingFlags, null, type, null, null);
				continue;
			}
		}
		Class7 class105 = @class;
		Class7 class106 = @class;
		bindingFlags = default(BindingFlags);
		_ = (GClass0)(object)class105.e(default(BindingFlags), (MethodBase[])(object)class106.W(bindingFlags, array5, type, (Type[])(object)Class5.Default, (ParameterModifier[])(object)@class.W(bindingFlags, array5, type, null, (ParameterModifier[])(object)Class5.Default)), array4, array2);
		try
		{
			while ((object)Class5.Default != null)
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Class5)(object)@class.t(bindingFlags, null, null, null);
				}
				else
				{
					class82 = class82;
				}
			}
		}
		finally
		{
			if (uIntPtr == 0)
			{
				do
				{
					gClass4 = gClass4;
				}
				while ((object)Class5.Default != null);
			}
			goto IL_4f96;
		}
		IL_0e2e:
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				Class7 class107 = @class;
				bindingFlags = default(BindingFlags);
				_ = (GClass3)(object)((Class7)(object)class107.e(bindingFlags, (MethodBase[])((Class7)null).t((object)null, (Type)null, cultureInfo), null, (ParameterModifier[])(object)Class5.Default)).t(bindingFlags, array6, obj, cultureInfo);
			}
			else
			{
				Class7 obj76 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_94 = bindingFlags;
				Class7 obj77 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				_ = (GClass0)(object)obj76.j(bindingFlags_94, (MethodBase[])(object)obj77.t(bindingFlags, array6, null, cultureInfo), ref *(object[]*)Class5.Default, array2, null, (string[])(object)Class5.Default, out reference2);
			}
		}
		catch
		{
			do
			{
				_ = (Struct1)Class5.Default;
			}
			while (obj != null);
		}
		Class7 class108;
		BindingFlags bindingFlags_95;
		FieldInfo[] fieldInfo_7;
		object object_32;
		do
		{
			try
			{
				while (obj != null)
				{
					class39 = null;
				}
			}
			catch
			{
				while ((object)Class5.Default != null)
				{
					_003CModule_003E = null;
					_003CModule_003E = null;
					class7 = null;
				}
			}
			class108 = @class;
			bindingFlags_95 = bindingFlags;
			fieldInfo_7 = array6;
			object_32 = obj;
			bindingFlags = default(BindingFlags);
		}
		while ((object)((Class7)null).j((BindingFlags)class108.t(bindingFlags_95, fieldInfo_7, object_32, (CultureInfo)(object)((Class7)null).W(bindingFlags, array5, type, (Type[])null, (ParameterModifier[])null)), array, ref reference, array2, cultureInfo, (string[])((Class7)@class.t(Class5.Default, type, null)).t(null, null, null), out reference2) != null);
		try
		{
			try
			{
				struct2 = struct2;
			}
			finally
			{
				try
				{
					class3 = class3;
				}
				finally
				{
					_ = (Class4)(object)Class5.Default;
					goto end_IL_0fcf;
				}
			}
			end_IL_0fcf:;
		}
		finally
		{
			while ((object)Class5.Default != null)
			{
				do
				{
					class41 = (Class9)(object)Class5.Default;
				}
				while (obj != null);
			}
			goto IL_101b;
		}
		IL_6ad2:
		_ = (Class2)(object)Class5.Default;
		_ = (Class5)(object)@class.j((BindingFlags)Class5.Default, null, ref reference, (ParameterModifier[])(object)Class5.Default, null, null, out reference2);
		_ = (GClass0)(object)((Class7)(object)Class5.Default).W(bindingFlags, array5, null, (Type[])(object)Class5.Default, array2);
		_ = (Class9)(object)Class5.Default;
		while (obj != null)
		{
			try
			{
				gClass4 = gClass4;
			}
			finally
			{
				do
				{
					_ = (Struct2)Class5.Default;
				}
				while (obj != null);
				continue;
			}
		}
		try
		{
			do
			{
				_ = (Class8)(object)Class5.Default;
			}
			while (obj != null || obj != null);
		}
		finally
		{
			if ((UIntPtr)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, null, (CultureInfo)(object)Class5.Default) == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					@struct = default(Struct2);
				}
				else
				{
					_ = (Qk7)(object)((Class7)(object)Class5.Default).t(bindingFlags, array6, ((Class7)null).j((BindingFlags)Class5.Default, (MethodBase[])null, ref reference, array2, cultureInfo, (string[])(object)@class.W(bindingFlags, (PropertyInfo[])(object)@class.W((BindingFlags)Class5.Default, array5, type, null, array2), null, null, (ParameterModifier[])(object)Class5.Default), out *(object*)null), cultureInfo);
				}
			}
			goto IL_6c6f;
		}
		IL_2c5d:
		class39 = null;
		if (uIntPtr != 0)
		{
			while (true)
			{
				if (obj != null)
				{
					gClass2 = gClass2;
				}
				else if (obj == null)
				{
					break;
				}
			}
		}
		if (checked(uIntPtr * unchecked((nuint)default(UIntPtr))) == 0)
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Class5)(object)@class.j(bindingFlags, null, ref reference, array2, null, null, out *(object*)null);
				}
				else
				{
					_ = (GClass3)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)Class5.Default, (CultureInfo)null);
				}
			}
			catch
			{
				while (true)
				{
					Class7 class109 = @class;
					bindingFlags = default(BindingFlags);
					Class7 obj80 = (Class7)(object)class109.W(bindingFlags, array5, null, array4, (ParameterModifier[])(object)@class.t(bindingFlags, null, null, cultureInfo));
					BindingFlags bindingFlags_96 = bindingFlags;
					FieldInfo[] fieldInfo_8 = (FieldInfo[])(object)Class5.Default;
					object object_33 = obj;
					Class7 class110 = @class;
					BindingFlags bindingFlags_97 = (BindingFlags)Class5.Default;
					MethodBase[] methodBase_30 = array;
					ref object[] object_34 = ref reference;
					Class7 obj81 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					if ((object)obj80.t(bindingFlags_96, fieldInfo_8, object_33, (CultureInfo)(object)((Class7)((Class7)(object)class110.j(bindingFlags_97, methodBase_30, ref object_34, (ParameterModifier[])(object)obj81.e(bindingFlags, array, (Type[])((Class7)(object)@class.j(bindingFlags, array, ref reference, array2, null, array3, out reference2)).t(obj, null, null), null), (CultureInfo)(object)Class5.Default, array3, out reference2)).t(null, type, cultureInfo)).e(bindingFlags, (MethodBase[])@class.t(null, (Type)(object)Class5.Default, cultureInfo), array4, null)) != null)
					{
						gClass4 = gClass4;
						continue;
					}
					break;
				}
			}
		}
		try
		{
			try
			{
				while (obj != null)
				{
					_ = (GClass1)@class.t(obj, (Type)(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, (CultureInfo)(object)Class5.Default), (CultureInfo)(object)@class.j(bindingFlags, array, ref reference, array2, cultureInfo, (string[])(object)((Class7)(object)Class5.Default).j(bindingFlags, array, ref *(object[]*)null, null, cultureInfo, array3, out reference2), out reference2));
					_ = (Struct2)Class5.Default;
				}
			}
			catch
			{
				while (obj != null)
				{
					gClass3 = null;
				}
			}
		}
		catch
		{
			try
			{
				try
				{
					BindingFlags bindingFlags_98 = (BindingFlags)Class5.Default;
					MethodBase[] methodBase_31 = (MethodBase[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, cultureInfo);
					Class7 obj84 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					Class7 obj85 = (Class7)(object)obj84.t(bindingFlags, null, Class5.Default, (CultureInfo)(object)((Class7)null).t(bindingFlags, array6, obj, cultureInfo));
					BindingFlags bindingFlags_99 = bindingFlags;
					Class7 obj86 = (Class7)(object)Class5.Default;
					Class7 class111 = @class;
					BindingFlags bindingFlags_100 = bindingFlags;
					Class7 class112 = @class;
					bindingFlags = default(BindingFlags);
					gClass4 = (GClass2)(object)((Class7)null).e(bindingFlags_98, methodBase_31, (Type[])(object)((Class7)null).e((BindingFlags)obj85.t(bindingFlags_99, (FieldInfo[])(object)((Class7)null).t((BindingFlags)obj86.t(((Class7)(object)class111.j(bindingFlags_100, (MethodBase[])(object)class112.e(bindingFlags, null, array4, (ParameterModifier[])(object)((Class7)null).j(bindingFlags, array, ref *(object[]*)null, (ParameterModifier[])null, cultureInfo, array3, out reference2)), ref *(object[]*)null, array2, cultureInfo, array3, out reference2)).t(obj, type, (CultureInfo)(object)Class5.Default), type, cultureInfo), array6, obj, cultureInfo), obj, cultureInfo), array, array4, (ParameterModifier[])(object)Class5.Default), array2);
				}
				finally
				{
					_ = (Struct2)Class5.Default;
					goto end_IL_2ee8;
				}
				end_IL_2ee8:;
			}
			catch
			{
				class82 = null;
			}
		}
		_ = (Struct1)Class5.Default;
		do
		{
			try
			{
				Class7 class113 = @class;
				object object_35 = obj;
				Class7 class114 = @class;
				BindingFlags bindingFlags_101 = (BindingFlags)((Class7)null).t(bindingFlags, array6, (object)null, (CultureInfo)null);
				MethodBase[] methodBase_32 = (MethodBase[])(object)Class5.Default;
				Type[] type_25 = (Type[])(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_102 = bindingFlags;
				PropertyInfo[] propertyInfo_10 = array5;
				Type type_26 = type;
				Class7 obj89 = (Class7)(object)Class5.Default;
				Class7 class115 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Struct2)class113.t(object_35, null, (CultureInfo)(object)class114.e(bindingFlags_101, methodBase_32, type_25, (ParameterModifier[])(object)((Class7)null).W(bindingFlags_102, propertyInfo_10, type_26, (Type[])null, (ParameterModifier[])(object)obj89.e((BindingFlags)((Class7)(object)class115.t(bindingFlags, array6, null, null)).j((BindingFlags)Class5.Default, (MethodBase[])(object)@class.j(bindingFlags, array, ref reference, array2, null, array3, out *(object*)null), ref *(object[]*)Class5.Default, null, cultureInfo, array3, out reference2), (MethodBase[])(object)((Class7)null).e(bindingFlags, array, array4, array2), array4, array2))));
			}
			catch
			{
				@struct = @struct;
			}
		}
		while (obj != null || (object)Class5.Default != null);
		try
		{
			while (obj != null)
			{
			}
		}
		catch
		{
			try
			{
				try
				{
					_ = (Qk7)(object)Class5.Default;
				}
				finally
				{
					class39 = class39;
					goto end_IL_31bf;
				}
				end_IL_31bf:;
			}
			finally
			{
				Class7 obj91 = (Class7)(object)@class.t((BindingFlags)((Class7)null).W(bindingFlags, array5, type, (Type[])(object)Class5.Default, array2), array6, obj, cultureInfo);
				bindingFlags = default(BindingFlags);
				Class7 obj92 = (Class7)(object)obj91.W(bindingFlags, array5, type, (Type[])(object)@class.t(bindingFlags, array6, ((Class7)(object)Class5.Default).e(bindingFlags, array, (Type[])(object)@class.t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, ((Class7)(object)Class5.Default).t(default(BindingFlags), null, null, cultureInfo), cultureInfo), array2), null), array2);
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_103 = bindingFlags;
				MethodBase[] methodBase_33 = array;
				ParameterModifier[] parameterModifier_15 = (ParameterModifier[])((Class7)null).t((object)null, type, cultureInfo);
				CultureInfo cultureInfo_10 = cultureInfo;
				Class7 obj93 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_104 = (BindingFlags)Class5.Default;
				FieldInfo[] fieldInfo_9 = array6;
				Class7 class116 = @class;
				BindingFlags bindingFlags_105 = bindingFlags;
				Class7 class117 = @class;
				Class7 class118 = @class;
				BindingFlags bindingFlags_106 = bindingFlags;
				MethodBase[] methodBase_34 = (MethodBase[])(object)Class5.Default;
				Class7 class119 = @class;
				bindingFlags = default(BindingFlags);
				ref object[] object_36 = ref *(object[]*)class119.W(bindingFlags, array5, (Type)(object)@class.W(bindingFlags, array5, type, array4, array2), null, array2);
				ParameterModifier[] parameterModifier_16 = array2;
				string[] string_9 = (string[])(object)@class.j(default(BindingFlags), null, ref reference, array2, null, null, out *(object*)Class5.Default);
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_107 = bindingFlags;
				FieldInfo[] fieldInfo_10 = array6;
				object object_37 = obj;
				Class7 obj94 = (Class7)(object)((Class7)(object)Class5.Default).e((BindingFlags)((Class7)null).e((BindingFlags)((Class7)(object)((Class7)(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, null)).j((BindingFlags)((Class7)null).t(bindingFlags, array6, obj, (CultureInfo)(object)Class5.Default), array, ref *(object[]*)null, array2, null, (string[])(object)Class5.Default, out *(object*)null)).t(bindingFlags, array6, obj, null), array, (Type[])null, (ParameterModifier[])null), array, null, array2);
				bindingFlags = default(BindingFlags);
				checked
				{
					if (unchecked((nuint)default(UIntPtr)) + unchecked((nuint)(UIntPtr)obj92.j(bindingFlags_103, methodBase_33, ref *(object[]*)null, parameterModifier_15, cultureInfo_10, (string[])(object)((Class7)(object)((Class7)(object)obj93.t(bindingFlags_104, fieldInfo_9, class116.W(bindingFlags_105, null, (Type)(object)class117.t((BindingFlags)class118.j(bindingFlags_106, methodBase_34, ref object_36, parameterModifier_16, null, string_9, out *(object*)((Class7)null).t(bindingFlags_107, fieldInfo_10, object_37, (CultureInfo)((Class7)(object)obj94.t(bindingFlags, array6, Class5.Default, cultureInfo)).t(null, (Type)(object)@class.t(bindingFlags, array6, obj, cultureInfo), cultureInfo))), array6, obj, null), array4, array2), cultureInfo)).t(bindingFlags, array6, null, (CultureInfo)(object)Class5.Default)).e((BindingFlags)@class.j((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, ref reference, array2, null, array3, out *(object*)Class5.Default), array, (Type[])(object)@class.W((BindingFlags)Class5.Default, null, (Type)(object)Class5.Default, array4, null), array2), out reference2)) == 0)
					{
						_ = (_003CModule_003E)(object)Class5.Default;
					}
					else
					{
						class7 = (Class6)(object)((Class7)(object)Class5.Default).t(bindingFlags, null, null, (CultureInfo)(object)Class5.Default);
						class31 = class31;
						class3 = class3;
					}
					goto end_IL_31be;
				}
			}
			end_IL_31be:;
		}
		try
		{
			while ((object)((Class7)null).j(bindingFlags, array, ref *(object[]*)null, (ParameterModifier[])null, (CultureInfo)null, array3, out *(object*)null) != null)
			{
				try
				{
					class3 = Class5.Default;
				}
				finally
				{
					gClass = null;
					continue;
				}
			}
		}
		catch
		{
			if ((UIntPtr)@class.j(bindingFlags, null, ref reference, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)Class5.Default, array3, out reference2) == (UIntPtr)(nuint)0u)
			{
				do
				{
					_ = (Class0)(object)((Class7)null).e((BindingFlags)((Class7)null).t(obj, (Type)(object)((Class7)null).j(bindingFlags, array, ref *(object[]*)Class5.Default, array2, (CultureInfo)null, array3, out reference2), (CultureInfo)@class.t(null, null, null)), array, (Type[])(object)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, null, array4, null), array2);
				}
				while (obj != null);
			}
		}
		uIntPtr = default(UIntPtr);
		if (checked(uIntPtr + unchecked((nuint)(UIntPtr)Class5.Default)) == 0)
		{
			if (uIntPtr == 0)
			{
				try
				{
					BindingFlags bindingFlags_108 = (BindingFlags)Class5.Default;
					Class7 class120 = @class;
					Class7 class121 = @class;
					bindingFlags = default(BindingFlags);
					Class7 obj97 = (Class7)(object)class120.W((BindingFlags)class121.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, (Type[])(object)Class5.Default, array2), (PropertyInfo[])(object)@class.W(bindingFlags, null, type, array4, array2), (Type)(object)Class5.Default, array4, array2);
					BindingFlags bindingFlags_109 = (BindingFlags)@class.W(bindingFlags, (PropertyInfo[])((Class7)null).t((object)null, (Type)null, cultureInfo), null, array4, array2);
					FieldInfo[] fieldInfo_11 = array6;
					Class7 class122 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class4)(object)((Class7)null).e((BindingFlags)((Class7)null).e(bindingFlags_108, (MethodBase[])(object)obj97.t(bindingFlags_109, fieldInfo_11, class122.t(bindingFlags, (FieldInfo[])(object)@class.e(bindingFlags, array, array4, array2), Class5.Default, cultureInfo), cultureInfo), (Type[])null, (ParameterModifier[])null), array, (Type[])null, array2);
				}
				finally
				{
					_ = (GClass2)(object)((Class7)(object)Class5.Default).t(bindingFlags, array6, obj, null);
					_ = (GClass1)(object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, array2, (CultureInfo)(object)@class.j(bindingFlags, null, ref reference, array2, cultureInfo, array3, out *(object*)null), array3, out reference2);
					class82 = class82;
					goto IL_399a;
				}
			}
			class3 = (Class5)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])null, array2);
			_ = (Class7)(object)Class5.Default;
			_ = (Struct1)Class5.Default;
			_ = (GClass2)(object)((Class7)(object)Class5.Default).t((BindingFlags)@class.W((BindingFlags)Class5.Default, array5, (Type)((Class7)null).t(obj, type, (CultureInfo)null), (Type[])(object)Class5.Default, null), null, Class5.Default, cultureInfo);
		}
		else
		{
			bindingFlags = default(BindingFlags);
			_ = (Class7)(object)((Class7)null).j(bindingFlags, array, ref *(object[]*)Class5.Default, array2, cultureInfo, array3, out reference2);
		}
		goto IL_399a;
		IL_71ac:
		_ = (Class9)(object)Class5.Default;
		do
		{
			gClass3 = gClass3;
		}
		while ((object)Class5.Default != null);
		nuint num7 = unchecked((nuint)default(UIntPtr)) / (nuint)(UIntPtr)Class5.Default;
		uIntPtr = default(UIntPtr);
		if (num7 / uIntPtr == 0)
		{
			gClass = gClass;
		}
		_ = (Class7)((Class7)(object)Class5.Default).t(null, type, null);
		_ = (Class4)(object)Class5.Default;
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			while (@class.t(obj, (Type)(object)@class.t((BindingFlags)((Class7)null).t((object)@class.W(bindingFlags, array5, type, array4, null), type, (CultureInfo)(object)Class5.Default), (FieldInfo[])(object)Class5.Default, obj, null), cultureInfo) != null)
			{
				try
				{
					class7 = class7;
				}
				catch
				{
					_ = (Class7)(object)Class5.Default;
				}
			}
			goto IL_72e4;
		}
		try
		{
			_ = (Class7)@class.t(obj, type, cultureInfo);
		}
		finally
		{
			gClass3 = null;
			goto IL_72e4;
		}
		IL_42b1:
		_ = (Class2)(object)Class5.Default;
		class39 = (Class4)(object)((Class7)null).j((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, array2, cultureInfo, (string[])null, out *(object*)Class5.Default);
		_ = (Class0)(object)Class5.Default;
		checked
		{
			do
			{
				uIntPtr = default(UIntPtr);
				if (unchecked((nuint)default(UIntPtr)) + uIntPtr == 0)
				{
					uIntPtr = default(UIntPtr);
					if (uIntPtr == 0)
					{
						class10 = class10;
					}
				}
			}
			while (obj != null);
			if (uIntPtr == 0)
			{
				try
				{
					do
					{
						_ = (_003CModule_003E)(object)Class5.Default;
					}
					while ((object)Class5.Default != null);
				}
				catch
				{
					while (obj != null)
					{
						Class7 class123 = @class;
						bindingFlags = default(BindingFlags);
						_ = (GClass1)(object)class123.t(bindingFlags, null, Class5.Default, null);
					}
				}
				goto IL_449b;
			}
		}
		try
		{
			_ = (GClass1)(object)@class.j(bindingFlags, array, ref *(object[]*)null, array2, cultureInfo, (string[])(object)Class5.Default, out *(object*)Class5.Default);
		}
		finally
		{
			@class = @class;
			goto IL_449b;
		}
		IL_40b0:
		if (uIntPtr == 0)
		{
			_ = (GClass3)(object)@class.e(bindingFlags, null, array4, array2);
		}
		class10 = null;
		try
		{
			if (uIntPtr == 0)
			{
				_ = (GClass3)(object)Class5.Default;
			}
			else
			{
				_ = (Class2)((Class7)null).t((object)null, type, (CultureInfo)((Class7)(object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, array2, cultureInfo, array3, out *(object*)null)).t(@class.j(bindingFlags, array, ref reference, null, null, array3, out reference2), null, cultureInfo));
			}
		}
		catch
		{
			do
			{
				_ = (Class8)(object)Class5.Default;
			}
			while (obj != null || (object)Class5.Default != null);
		}
		try
		{
			try
			{
				_ = (GClass1)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)@class.t(bindingFlags, array6, Class5.Default, (CultureInfo)(object)Class5.Default), (Type[])(object)Class5.Default, array2);
			}
			finally
			{
				_ = (Class8)(object)Class5.Default;
				goto end_IL_4185;
			}
			end_IL_4185:;
		}
		catch
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr / checked(unchecked((nuint)(UIntPtr)((Class7)null).e(bindingFlags, array, array4, (ParameterModifier[])@class.t(obj, (Type)(object)Class5.Default, cultureInfo))) - uIntPtr) == 0)
			{
				_ = (GClass3)(object)Class5.Default;
			}
			else
			{
				class31 = class31;
				_ = Class5.Default;
			}
		}
		finally
		{
			do
			{
				if (uIntPtr / (nuint)(UIntPtr)@class.t((BindingFlags)@class.t(bindingFlags, array6, obj, cultureInfo), array6, null, cultureInfo) != 0)
				{
					class3 = class3;
				}
				else
				{
					_ = (Class8)(object)Class5.Default;
				}
			}
			while (obj != null);
			goto IL_42b1;
		}
		IL_53cb:
		try
		{
			while (true)
			{
				if (obj != null)
				{
					qk = qk;
				}
				else if (obj == null)
				{
					break;
				}
			}
		}
		finally
		{
			if (uIntPtr == 0)
			{
				try
				{
					_ = (Class10)(object)Class5.Default;
				}
				finally
				{
					_ = (GClass0)(object)Class5.Default;
					class31 = (Class8)(object)((Class7)((Class7)(object)Class5.Default).t(obj, null, cultureInfo)).e(bindingFlags, (MethodBase[])(object)((Class7)null).W(bindingFlags, array5, type, (Type[])(object)Class5.Default, (ParameterModifier[])@class.t(((Class7)(object)Class5.Default).e(bindingFlags, null, array4, null), type, cultureInfo)), array4, (ParameterModifier[])@class.t(null, null, (CultureInfo)((Class7)(object)Class5.Default).t(Class5.Default, (Type)((Class7)null).t(obj, (Type)null, cultureInfo), (CultureInfo)(object)((Class7)(object)Class5.Default).W(bindingFlags, array5, null, null, (ParameterModifier[])(object)((Class7)null).t(bindingFlags, array6, (object)@class.j(bindingFlags, null, ref *(object[]*)@class.t((BindingFlags)Class5.Default, null, obj, cultureInfo), (ParameterModifier[])(object)Class5.Default, null, (string[])(object)Class5.Default, out *(object*)null), cultureInfo)))));
					gClass3 = gClass3;
					goto IL_5565;
				}
			}
			goto IL_5565;
		}
		IL_2a55:
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			if (checked(uIntPtr - uIntPtr - uIntPtr) / checked(unchecked(uIntPtr / uIntPtr) * uIntPtr) == 0)
			{
				try
				{
					_ = (Qk7)(object)Class5.Default;
				}
				catch
				{
					Qk7 obj102 = (Qk7)((Class7)null).t((object)Class5.Default, (Type)null, (CultureInfo)(object)Class5.Default);
					qk = qk;
					qk = obj102;
					class7 = null;
					_ = (Class7)(object)Class5.Default;
				}
			}
			else
			{
				gClass = gClass;
			}
		}
		checked
		{
			if (uIntPtr * unchecked((nuint)default(UIntPtr)) == 0)
			{
				gClass3 = null;
			}
		}
		try
		{
			while ((object)Class5.Default != null)
			{
				try
				{
					class7 = null;
				}
				finally
				{
					class3 = Class5.Default;
					Class7 class124 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_110 = bindingFlags;
					bindingFlags = default(BindingFlags);
					Class7 obj104 = (Class7)(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, (object)null, cultureInfo);
					bindingFlags = default(BindingFlags);
					class41 = (Class9)(object)class124.j(bindingFlags_110, (MethodBase[])(object)obj104.e(bindingFlags, array, (Type[])(object)Class5.Default, null), ref *(object[]*)null, null, cultureInfo, null, out *(object*)Class5.Default);
					class31 = null;
					continue;
				}
			}
		}
		finally
		{
			uIntPtr = default(UIntPtr);
			if (checked(uIntPtr - unchecked((nuint)(UIntPtr)Class5.Default) + uIntPtr) == 0)
			{
				Class7 obj105;
				do
				{
					@struct = @struct;
					obj105 = (Class7)(object)((Class7)null).e((BindingFlags)Class5.Default, array, array4, array2);
					bindingFlags = default(BindingFlags);
				}
				while ((object)obj105.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, null, (CultureInfo)(object)Class5.Default, array3, out *(object*)null) != null);
			}
			else
			{
				_ = (Class0)(object)((Class7)(object)Class5.Default).e(bindingFlags, array, array4, array2);
			}
			goto IL_2c5d;
		}
		IL_0a86:
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			while (true)
			{
				Class7 class125 = @class;
				bindingFlags = default(BindingFlags);
				if ((object)class125.j(bindingFlags, (MethodBase[])(object)@class.W((BindingFlags)Class5.Default, (PropertyInfo[])(object)Class5.Default, type, null, array2), ref *(object[]*)Class5.Default, null, null, (string[])(object)Class5.Default, out reference2) != null)
				{
					if ((UIntPtr)@class.t((BindingFlags)Class5.Default, null, obj, cultureInfo) == (UIntPtr)(nuint)0u)
					{
						_ = (Class2)(object)Class5.Default;
					}
					else
					{
						_ = (Qk7)(object)@class.j(bindingFlags, array, ref *(object[]*)null, array2, (CultureInfo)(object)Class5.Default, array3, out reference2);
					}
					continue;
				}
				break;
			}
		}
		else
		{
			_ = (Class5)@class.t(obj, type, cultureInfo);
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				try
				{
					@class = @class;
				}
				finally
				{
					Class7 class126 = @class;
					Class7 obj106 = (Class7)((Class7)(object)Class5.Default).t(@class.j(default(BindingFlags), array, ref *(object[]*)null, null, (CultureInfo)(object)Class5.Default, array3, out reference2), (Type)(object)Class5.Default, null);
					Class7 class127 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_111 = (BindingFlags)((Class7)null).j(default(BindingFlags), (MethodBase[])null, ref *(object[]*)null, (ParameterModifier[])(object)((Class7)(object)obj106.j((BindingFlags)class127.W(bindingFlags, null, null, array4, array2), array, ref reference, array2, cultureInfo, array3, out reference2)).t((BindingFlags)((Class7)null).t((object)null, (Type)(object)Class5.Default, (CultureInfo)@class.t(@class.t(bindingFlags, null, obj, cultureInfo), type, cultureInfo)), null, obj, null), (CultureInfo)(object)@class.e(bindingFlags, array, array4, array2), (string[])null, out reference2);
					MethodBase[] methodBase_35 = array;
					Type[] type_27 = (Type[])@class.t(obj, null, (CultureInfo)(object)Class5.Default);
					Class7 class128 = @class;
					BindingFlags bindingFlags_112 = bindingFlags;
					MethodBase[] methodBase_36 = (MethodBase[])(object)Class5.Default;
					BindingFlags bindingFlags_113 = (BindingFlags)((Class7)(object)@class.W(bindingFlags, array5, type, null, array2)).t(obj, type, (CultureInfo)(object)Class5.Default);
					FieldInfo[] fieldInfo_12 = array6;
					object object_38 = obj;
					bindingFlags = default(BindingFlags);
					_ = (Qk7)(object)class126.e(bindingFlags_111, methodBase_35, type_27, (ParameterModifier[])(object)class128.e(bindingFlags_112, methodBase_36, (Type[])(object)((Class7)null).t(bindingFlags_113, fieldInfo_12, object_38, (CultureInfo)(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)Class5.Default, array3, out *(object*)null)), array2));
					continue;
				}
			}
			goto IL_0e2e;
		}
		try
		{
			if ((UIntPtr)@class.t(obj, type, cultureInfo) == (UIntPtr)(nuint)0u)
			{
				_ = (GClass3)(object)Class5.Default;
			}
			else
			{
				_ = (Class10)(object)Class5.Default;
				gClass3 = (GClass3)(object)((Class7)null).t(bindingFlags, array6, (object)null, cultureInfo);
				class82 = class82;
			}
		}
		finally
		{
			try
			{
				gClass2 = null;
				@struct = @struct;
			}
			catch
			{
				_ = (Struct1)Class5.Default;
			}
			goto IL_0e2e;
		}
		IL_060f:
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			do
			{
				uIntPtr = default(UIntPtr);
				if (unchecked((nuint)default(UIntPtr)) / uIntPtr != 0)
				{
					Class7 obj108 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_114 = bindingFlags;
					bindingFlags = default(BindingFlags);
					ParameterModifier[] parameterModifier_17 = (ParameterModifier[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, array4, array2);
					CultureInfo cultureInfo_11 = cultureInfo;
					string[] string_10 = array3;
					reference2 = ref reference2;
					_ = (GClass3)(object)obj108.j(bindingFlags_114, null, ref *(object[]*)null, parameterModifier_17, cultureInfo_11, string_10, out reference2);
					class41 = class41;
					class41 = class41;
					_ = (GClass0)(object)Class5.Default;
					_ = (_003CModule_003E)(object)Class5.Default;
				}
				else
				{
					Class7 class129 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class10)(object)class129.W(bindingFlags, array5, (Type)(object)Class5.Default, array4, null);
					GClass3 obj109 = (GClass3)(object)Class5.Default;
					gClass3 = null;
					gClass3 = obj109;
					class3 = class3;
					struct2 = struct2;
				}
			}
			while (obj != null);
		}
		else
		{
			while (obj != null)
			{
				try
				{
					_ = (Class6)(object)Class5.Default;
				}
				finally
				{
					class3 = null;
					continue;
				}
			}
		}
		try
		{
			try
			{
				try
				{
					struct2 = struct2;
				}
				finally
				{
					_ = (Class6)@class.t(obj, (Type)(object)Class5.Default, cultureInfo);
					gClass2 = gClass2;
					goto end_IL_0743;
				}
				end_IL_0743:;
			}
			finally
			{
				try
				{
					_ = (_003CModule_003E)(object)Class5.Default;
				}
				finally
				{
					struct2 = default(Struct1);
					struct2 = struct2;
					class18 = class18;
					class18 = class18;
					class31 = class31;
					class31 = class31;
					_ = (GClass1)((Class7)(object)Class5.Default).t(null, type, cultureInfo);
					goto end_IL_0742;
				}
			}
			end_IL_0742:;
		}
		catch
		{
			try
			{
				do
				{
					Class4 obj110 = (Class4)(object)Class5.Default;
					Class7 class130 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_115 = bindingFlags;
					Type type_28 = type;
					Type[] type_29 = array4;
					Class7 class131 = @class;
					BindingFlags bindingFlags_116 = bindingFlags;
					Class7 class132 = @class;
					bindingFlags = default(BindingFlags);
					MethodBase[] methodBase_37 = (MethodBase[])(object)class132.t(bindingFlags, array6, obj, cultureInfo);
					reference = ref *(object[]*)null;
					class39 = (Class4)(object)class130.W(bindingFlags_115, null, type_28, type_29, (ParameterModifier[])((Class7)(object)class131.j(bindingFlags_116, methodBase_37, ref reference, array2, cultureInfo, array3, out *(object*)null)).t(@class.t(obj, null, null), (Type)(object)Class5.Default, cultureInfo));
					class39 = obj110;
				}
				while ((object)Class5.Default != null);
			}
			catch
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_003CModule_003E = null;
					_ = (Class7)(object)@class.t((BindingFlags)Class5.Default, null, null, cultureInfo);
					_003CModule_003E = _003CModule_003E;
				}
			}
		}
		try
		{
			gClass = gClass;
		}
		catch
		{
			class41 = (Class9)(object)Class5.Default;
		}
		if (uIntPtr == 0)
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				do
				{
					@struct = @struct;
				}
				while (@class.t(obj, type, cultureInfo) != null);
			}
			else
			{
				_ = (Qk7)@class.t(null, type, null);
			}
		}
		gClass4 = null;
		gClass4 = null;
		do
		{
			if (checked(unchecked((nuint)(UIntPtr)@class.e(bindingFlags, null, null, array2)) * unchecked((nuint)default(UIntPtr))) / checked(unchecked((nuint)default(UIntPtr)) + unchecked(unchecked((nuint)default(UIntPtr)) / (nuint)(UIntPtr)Class5.Default)) != 0)
			{
				do
				{
					_ = (GClass3)(object)Class5.Default;
				}
				while ((object)Class5.Default != null);
			}
			else
			{
				do
				{
					_ = (Struct2)Class5.Default;
				}
				while (obj != null);
			}
		}
		while (obj != null);
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					class39 = class39;
				}
				finally
				{
					_ = (Class2)(object)Class5.Default;
					goto end_IL_09f7;
				}
				end_IL_09f7:;
			}
			finally
			{
				try
				{
					class82 = (Class0)(object)@class.W(bindingFlags, null, null, (Type[])(object)Class5.Default, array2);
				}
				finally
				{
					bindingFlags = default(BindingFlags);
					_ = (Struct1)((Class7)null).t(bindingFlags, array6, obj, (CultureInfo)null);
					goto IL_0a86;
				}
			}
		}
		try
		{
			try
			{
				_ = (Qk7)(object)Class5.Default;
			}
			finally
			{
				class10 = null;
				goto end_IL_0a62;
			}
			end_IL_0a62:;
		}
		finally
		{
			_ = (Qk7)(object)Class5.Default;
			goto IL_0a86;
		}
		IL_5565:
		nuint num8 = uIntPtr;
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_117 = bindingFlags;
		Class7 class133 = @class;
		BindingFlags bindingFlags_118 = bindingFlags;
		MethodBase[] methodBase_38 = array;
		ref object[] object_39 = ref reference;
		Class7 class134 = @class;
		bindingFlags = default(BindingFlags);
		UIntPtr num9 = (UIntPtr)((Class7)null).W(bindingFlags_117, (PropertyInfo[])(object)class133.j(bindingFlags_118, methodBase_38, ref object_39, (ParameterModifier[])(object)class134.e(bindingFlags, (MethodBase[])(object)Class5.Default, array4, array2), (CultureInfo)@class.t(null, null, cultureInfo), (string[])(object)Class5.Default, out reference2), (Type)(object)Class5.Default, array4, (ParameterModifier[])@class.t(obj, null, cultureInfo));
		nuint num10 = uIntPtr;
		uIntPtr = default(UIntPtr);
		nuint num11;
		nuint num12;
		Class7 class135;
		checked
		{
			num11 = num10 * (unchecked((nuint)default(UIntPtr)) + uIntPtr);
			num12 = uIntPtr;
			class135 = @class;
		}
		BindingFlags bindingFlags_119 = (BindingFlags)@class.W(bindingFlags, array5, type, array4, array2);
		ref object[] object_40 = ref *(object[]*)Class5.Default;
		CultureInfo cultureInfo_12 = (CultureInfo)(object)Class5.Default;
		string[] string_11 = array3;
		Class7 obj114 = (Class7)(object)@class.j(bindingFlags, array, ref reference, array2, cultureInfo, array3, out reference2);
		BindingFlags bindingFlags_120 = bindingFlags;
		PropertyInfo[] propertyInfo_11 = (PropertyInfo[])(object)Class5.Default;
		Type type_30 = type;
		Type[] type_31 = (Type[])(object)Class5.Default;
		Class7 class136 = @class;
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_121 = bindingFlags;
		MethodBase[] methodBase_39 = (MethodBase[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, (Type[])null, array2);
		string[] string_12 = array3;
		Class7 class137 = @class;
		Class7 class138 = @class;
		bindingFlags = default(BindingFlags);
		nuint num13;
		checked
		{
			num13 = (num11 + (num12 + unchecked((nuint)(UIntPtr)class135.j(bindingFlags_119, null, ref object_40, null, cultureInfo_12, string_11, out *(object*)obj114.W(bindingFlags_120, propertyInfo_11, type_30, type_31, (ParameterModifier[])(object)class136.j(bindingFlags_121, methodBase_39, ref *(object[]*)null, null, null, string_12, out *(object*)class137.W((BindingFlags)((Class7)(object)class138.t(bindingFlags, (FieldInfo[])(object)((Class7)(object)Class5.Default).e(bindingFlags, array, (Type[])(object)@class.t((BindingFlags)Class5.Default, array6, obj, cultureInfo), array2), @class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array2, cultureInfo, array3, out reference2), (CultureInfo)((Class7)null).t(((Class7)null).t((object)null, type, cultureInfo), (Type)(object)@class.W(bindingFlags, array5, type, array4, (ParameterModifier[])(object)Class5.Default), cultureInfo))).t(Class5.Default, type, cultureInfo), array5, null, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default))))) * unchecked((nuint)(UIntPtr)((Class7)(object)Class5.Default).t((BindingFlags)@class.e(bindingFlags, null, (Type[])(object)@class.W(bindingFlags, array5, type, null, null), array2), (FieldInfo[])(object)Class5.Default, obj, null)))) * unchecked((nuint)(UIntPtr)@class.t((BindingFlags)Class5.Default, array6, null, cultureInfo));
			uIntPtr = default(UIntPtr);
		}
		if (num8 / ((nuint)num9 / checked(num13 + uIntPtr)) == 0)
		{
			if (uIntPtr == 0)
			{
				while ((object)@class.e(bindingFlags, (MethodBase[])(object)@class.t((BindingFlags)Class5.Default, array6, null, cultureInfo), array4, null) != null)
				{
					class39 = class39;
					_ = Class5.Default;
				}
			}
			else
			{
				_ = (GClass3)(object)Class5.Default;
			}
		}
		while (obj != null)
		{
			@struct = @struct;
		}
		try
		{
			class18 = class18;
		}
		catch
		{
			while (obj != null)
			{
				_ = (Class6)((Class7)(object)Class5.Default).t(null, null, cultureInfo);
			}
		}
		try
		{
			_003CModule_003E = _003CModule_003E;
		}
		finally
		{
			do
			{
				try
				{
					qk = null;
				}
				catch
				{
					class7 = class7;
					gClass = gClass;
					gClass = null;
					@class = @class;
				}
			}
			while (obj != null);
			goto IL_5997;
		}
		IL_72e4:
		if (uIntPtr == 0)
		{
			while ((object)@class.e(bindingFlags, array, (Type[])(object)Class5.Default, array2) != null)
			{
				gClass = gClass;
			}
		}
		gClass3 = gClass3;
		try
		{
			while (obj != null)
			{
			}
		}
		finally
		{
			class31 = class31;
			goto IL_73b8;
		}
		IL_4f96:
		try
		{
			do
			{
				try
				{
					_ = Class5.Default;
				}
				finally
				{
					_ = (Struct1)Class5.Default;
					continue;
				}
			}
			while (obj != null);
		}
		catch
		{
			if (uIntPtr == 0)
			{
				while (obj != null)
				{
					class3 = class3;
					@class = null;
					class31 = null;
				}
			}
			else
			{
				_ = (_003CModule_003E)(object)Class5.Default;
			}
		}
		try
		{
			try
			{
				while ((object)Class5.Default != null)
				{
					class3 = class3;
				}
			}
			finally
			{
				goto end_IL_4fea;
			}
			end_IL_4fea:;
		}
		finally
		{
			do
			{
				nuint num14 = uIntPtr / unchecked((nuint)default(UIntPtr));
				uIntPtr = default(UIntPtr);
				if (checked(num14 + uIntPtr) == 0)
				{
					Class7 obj118 = (Class7)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])(object)Class5.Default, array2);
					Class7 class139 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class9)(object)obj118.W((BindingFlags)class139.j(bindingFlags, array, ref *(object[]*)((Class7)null).j(bindingFlags, (MethodBase[])(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, array4, array2), ref reference, array2, cultureInfo, (string[])null, out *(object*)null), null, (CultureInfo)(object)Class5.Default, null, out reference2), null, (Type)(object)((Class7)((Class7)null).t(obj, type, cultureInfo)).j((BindingFlags)Class5.Default, array, ref *(object[]*)null, array2, (CultureInfo)(object)Class5.Default, array3, out *(object*)null), array4, (ParameterModifier[])((Class7)(object)Class5.Default).t(obj, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default));
				}
			}
			while ((object)@class.W(bindingFlags, array5, type, null, (ParameterModifier[])(object)Class5.Default) != null);
			goto IL_517e;
		}
		IL_517e:
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			if (checked(unchecked((nuint)default(UIntPtr)) - unchecked((nuint)(UIntPtr)Class5.Default / checked(unchecked((nuint)default(UIntPtr)) + unchecked((nuint)default(UIntPtr))))) == 0)
			{
				while ((object)((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])(object)@class.e(bindingFlags, array, (Type[])(object)@class.j(bindingFlags, array, ref reference, array2, (CultureInfo)(object)@class.e(bindingFlags, null, array4, array2), array3, out reference2), (ParameterModifier[])(object)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, null, obj, null)), (Type[])(object)Class5.Default, array2) != null)
				{
					class41 = (Class9)(object)Class5.Default;
				}
			}
		}
		else
		{
			while (obj != null)
			{
				do
				{
					struct2 = (Struct1)Class5.Default;
				}
				while (obj != null);
			}
		}
		try
		{
			do
			{
				class41 = null;
			}
			while (obj != null);
		}
		catch
		{
			try
			{
				_ = (Class6)(object)Class5.Default;
			}
			catch
			{
				_ = (GClass3)((Class7)null).t(obj, (Type)null, cultureInfo);
			}
		}
		finally
		{
			uIntPtr = default(UIntPtr);
			nuint num15 = uIntPtr / (uIntPtr / (nuint)(UIntPtr)Class5.Default);
			Class7 class140 = @class;
			bindingFlags = default(BindingFlags);
			checked
			{
				if (num15 - unchecked((nuint)(UIntPtr)class140.t(bindingFlags, array6, ((Class7)(object)Class5.Default).e(bindingFlags, array, (Type[])(object)Class5.Default, array2), null)) == 0)
				{
					try
					{
						_ = (GClass0)(object)Class5.Default;
					}
					finally
					{
						_ = (Class6)(object)((Class7)(object)Class5.Default).e(bindingFlags, array, (Type[])(object)Class5.Default, array2);
						gClass3 = gClass3;
						gClass = gClass;
						goto IL_53cb;
					}
				}
				while ((object)Class5.Default != null)
				{
					_ = (Class7)(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, (CultureInfo)(object)Class5.Default);
				}
				goto IL_53cb;
			}
		}
		IL_6c6f:
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			_ = (Class9)(object)Class5.Default;
		}
		else
		{
			_ = (GClass1)(object)Class5.Default;
		}
		checked
		{
			while (obj != null)
			{
				nuint num16 = uIntPtr;
				uIntPtr = default(UIntPtr);
				nuint num17 = unchecked((nuint)default(UIntPtr)) - uIntPtr;
				BindingFlags bindingFlags_122 = bindingFlags;
				MethodBase[] methodBase_40 = (MethodBase[])(object)@class.W(bindingFlags, array5, (Type)(object)Class5.Default, (Type[])(object)Class5.Default, array2);
				ParameterModifier[] parameterModifier_18 = array2;
				Class7 class141 = @class;
				object object_41 = @class.t(Class5.Default, (Type)(object)@class.e(bindingFlags, null, (Type[])(object)Class5.Default, (ParameterModifier[])((Class7)(object)Class5.Default).t(obj, type, cultureInfo)), cultureInfo);
				Class7 obj121;
				unchecked
				{
					BindingFlags bindingFlags_123 = (BindingFlags)@class.t(obj, null, cultureInfo);
					MethodBase[] methodBase_41 = array;
					ref object[] object_42 = ref *(object[]*)Class5.Default;
					Class7 class142 = @class;
					object object_43 = obj;
					Type type_32 = type;
					Class7 class143 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_124 = bindingFlags;
					MethodBase[] methodBase_42 = (MethodBase[])(object)((Class7)(object)Class5.Default).t(bindingFlags, array6, Class5.Default, null);
					ref object[] object_44 = ref reference;
					ParameterModifier[] parameterModifier_19 = (ParameterModifier[])(object)@class.W(bindingFlags, null, type, array4, (ParameterModifier[])(object)Class5.Default);
					CultureInfo cultureInfo_13 = (CultureInfo)(object)((Class7)null).e(default(BindingFlags), array, (Type[])null, array2);
					string[] string_13 = array3;
					Class7 class144 = @class;
					bindingFlags = default(BindingFlags);
					obj121 = (Class7)class141.t(object_41, (Type)(object)((Class7)null).j(bindingFlags_123, methodBase_41, ref object_42, (ParameterModifier[])class142.t(object_43, type_32, (CultureInfo)(object)((Class7)(object)class143.j(bindingFlags_124, methodBase_42, ref object_44, parameterModifier_19, cultureInfo_13, string_13, out *(object*)((Class7)null).j((BindingFlags)class144.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, array4, array2), (MethodBase[])(object)Class5.Default, ref reference, array2, cultureInfo, (string[])((Class7)null).t((object)Class5.Default, (Type)(object)@class.e(bindingFlags, array, null, null), cultureInfo), out reference2))).t(default(BindingFlags), array6, obj, cultureInfo)), (CultureInfo)(object)Class5.Default, array3, out *(object*)null), null);
					bindingFlags = default(BindingFlags);
				}
				if (num16 * (num17 * unchecked((nuint)(UIntPtr)((Class7)null).j(bindingFlags_122, methodBase_40, ref *(object[]*)null, parameterModifier_18, (CultureInfo)null, (string[])(object)obj121.t(bindingFlags, array6, Class5.Default, (CultureInfo)(object)Class5.Default), out reference2))) == 0)
				{
					_ = (Struct2)((Class7)null).t(obj, (Type)null, (CultureInfo)(object)Class5.Default);
				}
			}
		}
		while (obj != null)
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Class2)(object)Class5.Default;
				}
			}
			catch
			{
				try
				{
					Class7 class145 = @class;
					BindingFlags bindingFlags_125 = (BindingFlags)@class.t(obj, (Type)(object)((Class7)null).t(bindingFlags, array6, obj, (CultureInfo)null), cultureInfo);
					Class7 obj122 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Class2)(object)class145.t((BindingFlags)((Class7)null).t(bindingFlags_125, (FieldInfo[])null, (object)null, (CultureInfo)(object)obj122.j(bindingFlags, (MethodBase[])(object)((Class7)null).W((BindingFlags)Class5.Default, array5, (Type)(object)@class.W(bindingFlags, array5, type, array4, null), (Type[])(object)Class5.Default, array2), ref *(object[]*)null, array2, cultureInfo, array3, out reference2)), (FieldInfo[])(object)Class5.Default, Class5.Default, cultureInfo);
				}
				catch
				{
					_ = (Struct2)Class5.Default;
					_ = (Class6)@class.t(null, (Type)(object)Class5.Default, (CultureInfo)(object)@class.e((BindingFlags)@class.W(bindingFlags, array5, type, (Type[])(object)@class.W(bindingFlags, array5, (Type)(object)@class.t((BindingFlags)@class.t(bindingFlags, null, null, cultureInfo), array6, obj, null), array4, (ParameterModifier[])(object)Class5.Default), array2), null, (Type[])(object)Class5.Default, null));
				}
			}
		}
		do
		{
			_ = (Class0)(object)Class5.Default;
		}
		while (obj != null);
		try
		{
			while (obj != null)
			{
				class82 = ((default(UIntPtr) != (UIntPtr)(nuint)0u) ? class82 : class82);
			}
		}
		finally
		{
			if (checked(unchecked((nuint)default(UIntPtr)) * unchecked((nuint)default(UIntPtr))) == 0)
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					_ = (_003CModule_003E)(object)Class5.Default;
				}
				else
				{
					_ = Class5.Default;
				}
			}
			else
			{
				_ = (GClass0)(object)Class5.Default;
			}
			goto IL_71ac;
		}
		IL_1d52:
		checked
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					try
					{
						_ = Class5.Default;
					}
					finally
					{
						_ = (GClass3)(object)Class5.Default;
						goto end_IL_1d53;
					}
				}
				end_IL_1d53:;
			}
			finally
			{
				try
				{
					class31 = (Class8)@class.t(Class5.Default, null, null);
				}
				catch
				{
					if (unchecked((nuint)(UIntPtr)Class5.Default) - uIntPtr == 0)
					{
						bindingFlags = default(BindingFlags);
						_ = (GClass3)(object)((Class7)null).e(bindingFlags, array, (Type[])null, array2);
					}
					else
					{
						_003CModule_003E = null;
					}
				}
				goto IL_1de0;
			}
		}
	}

	unsafe static void smethod_3()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class7 @class);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] array2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] array3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out FieldInfo[] array4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string[] array5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object[] reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] array6);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object object_4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class5 class6);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags);
		try
		{
			while (obj != null)
			{
				try
				{
					@class = @class;
					Class7 class2 = @class;
					bindingFlags = bindingFlags;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_ = bindingFlags;
					array = (MethodBase[])(object)Class5.Default;
					MethodBase[] methodBase_ = array;
					Class7 obj2 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_2 = bindingFlags;
					array2 = array2;
					PropertyInfo[] propertyInfo_ = array2;
					Type[] type_ = (Type[])(object)Class5.Default;
					array3 = array3;
					BindingFlags bindingFlags_3 = (BindingFlags)obj2.W(bindingFlags_2, propertyInfo_, null, type_, array3);
					PropertyInfo[] propertyInfo_2 = array2;
					Class7 class3 = @class;
					BindingFlags bindingFlags_4 = bindingFlags;
					array4 = array4;
					ref object[] object_ = ref *(object[]*)((Class7)null).W(bindingFlags_3, propertyInfo_2, (Type)(object)class3.t(bindingFlags_4, array4, null, null), (Type[])null, array3);
					ParameterModifier[] parameterModifier_ = array3;
					array5 = array5;
					_ = (Class4)(object)class2.j(bindingFlags_, methodBase_, ref object_, parameterModifier_, null, array5, out *(object*)null);
				}
				finally
				{
					BindingFlags bindingFlags_5 = bindingFlags;
					PropertyInfo[] propertyInfo_3 = array2;
					Class7 class4 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_6 = bindingFlags;
					MethodBase[] methodBase_2 = array;
					reference = ref reference;
					ref object[] object_2 = ref reference;
					cultureInfo = cultureInfo;
					CultureInfo cultureInfo_ = cultureInfo;
					Class7 class5 = @class;
					BindingFlags bindingFlags_7 = bindingFlags;
					FieldInfo[] fieldInfo_ = array4;
					obj = obj;
					object object_3 = obj;
					BindingFlags bindingFlags_8 = (BindingFlags)Class5.Default;
					PropertyInfo[] propertyInfo_4 = array2;
					type = null;
					Type type_2 = type;
					array6 = array6;
					string[] string_ = (string[])(object)class5.t(bindingFlags_7, fieldInfo_, object_3, (CultureInfo)((Class7)null).t((object)((Class7)null).W(bindingFlags_8, propertyInfo_4, type_2, array6, (ParameterModifier[])null), (Type)null, (CultureInfo)null));
					object_4 = ref *(object*)@class.e(bindingFlags, array, array6, array3);
					_ = (Qk7)((Class7)(object)((Class7)null).W(bindingFlags_5, propertyInfo_3, (Type)(object)class4.j(bindingFlags_6, methodBase_2, ref object_2, null, cultureInfo_, string_, out object_4), (Type[])(object)Class5.Default, (ParameterModifier[])(object)((Class7)null).t(bindingFlags, array4, obj, cultureInfo))).t(obj, type, cultureInfo);
					continue;
				}
			}
		}
		catch
		{
			if ((UIntPtr)((Class7)(object)Class5.Default).t(obj, null, (CultureInfo)(object)Class5.Default) == (UIntPtr)(nuint)0u)
			{
				Class5 obj3 = (Class5)(object)@class.t(bindingFlags, array4, ((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, cultureInfo), null);
				class6 = null;
				class6 = obj3;
			}
		}
		UIntPtr num = (UIntPtr)((Class7)(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, null, null)).t(bindingFlags, array4, obj, null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class2 class9);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class0 class8);
		checked
		{
			num2 *= unchecked((nuint)(UIntPtr)Class5.Default) + num2;
			if (unchecked(checked(unchecked((nuint)num) - unchecked((nuint)default(UIntPtr))) / unchecked((nuint)default(UIntPtr))) + unchecked((nuint)default(UIntPtr)) == 0)
			{
				class6 = class6;
				Class7 class7 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class0)class7.t(((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, (CultureInfo)null), null, cultureInfo);
			}
			Class0 obj5 = (Class0)(object)Class5.Default;
			class8 = class8;
			class8 = obj5;
			if (unchecked((nuint)(UIntPtr)((Class7)@class.t(obj, type, (CultureInfo)(object)Class5.Default)).t(null, type, cultureInfo)) + unchecked((nuint)default(UIntPtr)) == 0)
			{
				do
				{
					num2 = default(UIntPtr);
					if (num2 * num2 == 0)
					{
						class9 = class9;
						class9 = null;
					}
				}
				while (obj != null);
			}
			else
			{
				do
				{
					class9 = class9;
					_ = (Class10)(object)Class5.Default;
					_ = (GClass0)(object)Class5.Default;
				}
				while (obj != null || obj != null);
			}
			_ = (Qk7)(object)Class5.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass0 gClass);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					class9 = null;
					Class4 class10 = null;
					class10 = class10;
					class8 = class8;
				}
				finally
				{
					_ = (Class7)(object)Class5.Default;
					goto end_IL_03cd;
				}
				end_IL_03cd:;
			}
			finally
			{
				if ((UIntPtr)((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])(object)Class5.Default, null, null) == (UIntPtr)(nuint)0u)
				{
					GClass0 obj6 = (GClass0)(object)Class5.Default;
					gClass = (GClass0)(object)Class5.Default;
					gClass = obj6;
				}
				goto IL_043d;
			}
		}
		goto IL_043d;
		IL_1db1:
		nuint num3 = num2;
		num2 = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass2 gClass3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass3 gClass2);
		if (num3 / num2 == 0)
		{
			do
			{
				_ = (GClass3)(object)Class5.Default;
				_ = (GClass3)(object)@class.j(bindingFlags, array, ref reference, (ParameterModifier[])(object)@class.j((BindingFlags)Class5.Default, array, ref reference, null, cultureInfo, array5, out object_4), null, array5, out object_4);
				_ = (Class10)(object)@class.W(bindingFlags, null, type, null, null);
				bindingFlags = default(BindingFlags);
				_ = (GClass1)(object)((Class7)null).W(bindingFlags, array2, type, array6, array3);
			}
			while (obj != null);
		}
		else
		{
			try
			{
				do
				{
					bindingFlags = default(BindingFlags);
					gClass2 = (GClass3)(object)((Class7)null).j(bindingFlags, array, ref reference, (ParameterModifier[])null, cultureInfo, (string[])null, out *(object*)null);
				}
				while ((object)Class5.Default != null);
			}
			catch
			{
				gClass3 = null;
			}
		}
		try
		{
			num2 = default(UIntPtr);
			if (num2 == 0)
			{
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_9 = bindingFlags;
				ref object[] object_5 = ref reference;
				Class7 class11 = @class;
				BindingFlags bindingFlags_10 = bindingFlags;
				Class7 obj8 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_11 = bindingFlags;
				PropertyInfo[] propertyInfo_5 = array2;
				Type type_3 = type;
				bindingFlags = default(BindingFlags);
				_ = (Class7)(object)((Class7)null).j(bindingFlags_9, (MethodBase[])null, ref object_5, (ParameterModifier[])(object)class11.t(bindingFlags_10, (FieldInfo[])(object)obj8.W(bindingFlags_11, propertyInfo_5, type_3, (Type[])(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, (ParameterModifier[])null, (CultureInfo)(object)Class5.Default, array5, out *(object*)null), (ParameterModifier[])(object)Class5.Default), obj, cultureInfo), cultureInfo, (string[])null, out object_4);
			}
		}
		catch
		{
			while (obj != null)
			{
				while (obj != null)
				{
					class9 = class9;
				}
			}
		}
		Struct1 @struct = @struct;
		Class9 class12 = class12;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class6 class13);
		try
		{
			do
			{
				try
				{
					class13 = null;
				}
				catch
				{
					_ = (GClass2)(object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)((Class7)(object)Class5.Default).j((BindingFlags)Class5.Default, array, ref *(object[]*)null, array3, cultureInfo, array5, out object_4), array3, cultureInfo, array5, out *(object*)Class5.Default);
				}
			}
			while (obj != null);
		}
		finally
		{
			if (num2 == 0)
			{
				while (obj != null)
				{
					@class = (Class7)(object)((Class7)(object)@class.e(bindingFlags, array, (Type[])(object)Class5.Default, null)).j(bindingFlags, null, ref *(object[]*)null, array3, cultureInfo, (string[])(object)((Class7)@class.t(obj, null, (CultureInfo)((Class7)(object)@class.j(bindingFlags, array, ref reference, array3, cultureInfo, array5, out *(object*)Class5.Default)).t(null, type, (CultureInfo)(object)((Class7)(object)Class5.Default).j((BindingFlags)Class5.Default, array, ref reference, null, null, null, out *(object*)null)))).j(bindingFlags, (MethodBase[])@class.t(Class5.Default, null, cultureInfo), ref reference, null, null, array5, out *(object*)null), out *(object*)Class5.Default);
				}
			}
			goto IL_2126;
		}
		IL_3882:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass1 gClass4);
		if (num2 == 0)
		{
			nuint num4 = num2;
			UIntPtr num5 = (UIntPtr)Class5.Default;
			num2 = default(UIntPtr);
			checked
			{
				if (num4 + unchecked((nuint)num5) * num2 == 0)
				{
					do
					{
						_ = (Class9)(object)Class5.Default;
					}
					while (obj != null);
				}
				else
				{
					_ = (Struct1)Class5.Default;
				}
			}
		}
		else if (num2 == 0)
		{
			if ((nuint)(UIntPtr)Class5.Default / (nuint)(UIntPtr)Class5.Default == 0)
			{
				@struct = @struct;
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
				Class7 obj11 = (Class7)(object)Class5.Default;
				Class7 class14 = @class;
				bindingFlags = default(BindingFlags);
				_ = (GClass1)obj11.t(class14.e(bindingFlags, array, array6, array3), type, null);
			}
		}
		if ((UIntPtr)((Class7)null).t((object)null, type, cultureInfo) == (UIntPtr)(nuint)0u)
		{
			while (true)
			{
				Class7 obj13 = (Class7)((Class7)null).t(obj, (Type)null, cultureInfo);
				BindingFlags bindingFlags_12 = (BindingFlags)Class5.Default;
				PropertyInfo[] propertyInfo_6 = (PropertyInfo[])(object)Class5.Default;
				Type type_4 = (Type)(object)Class5.Default;
				BindingFlags bindingFlags_13 = bindingFlags;
				FieldInfo[] fieldInfo_2 = array4;
				BindingFlags bindingFlags_14 = bindingFlags;
				PropertyInfo[] propertyInfo_7 = array2;
				Class7 obj14 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				if ((object)((Class7)null).e((BindingFlags)obj13.W(bindingFlags_12, propertyInfo_6, type_4, (Type[])(object)((Class7)null).t(bindingFlags_13, fieldInfo_2, (object)((Class7)null).W(bindingFlags_14, propertyInfo_7, (Type)null, (Type[])(object)obj14.j(bindingFlags, array, ref *(object[]*)null, null, null, array5, out object_4), array3), cultureInfo), array3), (MethodBase[])null, array6, array3) == null)
				{
					break;
				}
				try
				{
					_ = (GClass3)(object)@class.e(bindingFlags, array, array6, array3);
					gClass2 = null;
				}
				catch
				{
					class8 = class8;
				}
			}
		}
		Qk7 qk;
		try
		{
			num2 = default(UIntPtr);
			if (num2 == 0)
			{
				gClass3 = null;
				_ = (Class2)(object)Class5.Default;
				_ = (Class9)(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, (Type[])(object)@class.W((BindingFlags)Class5.Default, array2, null, null, array3), array3);
				qk = qk;
			}
		}
		catch
		{
			_ = (Qk7)(object)Class5.Default;
		}
		finally
		{
			gClass3 = gClass3;
			Class7 obj17 = (Class7)(object)@class.e(bindingFlags, array, null, array3);
			Class7 obj18 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_15 = bindingFlags;
			Class7 class15 = @class;
			Class7 class16 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_16 = (BindingFlags)obj18.j(bindingFlags_15, (MethodBase[])class15.t(null, null, (CultureInfo)(object)class16.W(bindingFlags, null, null, null, null)), ref reference, array3, null, null, out object_4);
			Class7 class17 = @class;
			BindingFlags bindingFlags_17 = bindingFlags;
			FieldInfo[] fieldInfo_3 = array4;
			object object_6 = obj;
			bindingFlags = default(BindingFlags);
			MethodBase[] methodBase_3 = (MethodBase[])(object)class17.t(bindingFlags_17, fieldInfo_3, object_6, (CultureInfo)(object)((Class7)null).W(bindingFlags, array2, type, array6, (ParameterModifier[])(object)Class5.Default));
			Class7 class18 = @class;
			BindingFlags bindingFlags_18 = (BindingFlags)((Class7)(object)Class5.Default).W(bindingFlags, (PropertyInfo[])(object)((Class7)(object)Class5.Default).t((BindingFlags)((Class7)(object)Class5.Default).t(bindingFlags, array4, null, null), array4, Class5.Default, null), (Type)(object)Class5.Default, array6, (ParameterModifier[])(object)Class5.Default);
			Type[] type_5 = (Type[])(object)Class5.Default;
			Class7 class19 = @class;
			BindingFlags bindingFlags_19 = bindingFlags;
			MethodBase[] methodBase_4 = array;
			Type[] type_6 = (Type[])(object)((Class7)(object)((Class7)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)((Class7)@class.t(Class5.Default, null, null)).W(bindingFlags, null, null, array6, null), (Type)null, array6, (ParameterModifier[])null)).t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, cultureInfo)).e(bindingFlags, null, null, array3);
			Class7 obj19 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_20 = bindingFlags;
			FieldInfo[] fieldInfo_4 = (FieldInfo[])(object)Class5.Default;
			object object_7 = obj;
			Class7 class20 = @class;
			Class7 class21 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_21 = bindingFlags;
			MethodBase[] methodBase_5 = array;
			ref object[] object_8 = ref *(object[]*)Class5.Default;
			ParameterModifier[] parameterModifier_2 = (ParameterModifier[])(object)((Class7)null).j((BindingFlags)((Class7)null).t(obj, (Type)(object)@class.e(bindingFlags, array, null, array3), cultureInfo), (MethodBase[])(object)((Class7)(object)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])null, (Type)null, (Type[])(object)@class.e(bindingFlags, null, (Type[])@class.t(obj, (Type)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)@class.t((BindingFlags)Class5.Default, array4, null, cultureInfo), cultureInfo), cultureInfo), null), array3)).W(bindingFlags, array2, type, null, array3), ref *(object[]*)Class5.Default, (ParameterModifier[])null, cultureInfo, (string[])null, out *(object*)null);
			CultureInfo cultureInfo_2 = (CultureInfo)(object)Class5.Default;
			string[] string_2 = array5;
			Class7 class22 = @class;
			BindingFlags bindingFlags_22 = bindingFlags;
			PropertyInfo[] propertyInfo_8 = array2;
			Type type_7 = type;
			Type[] type_8 = (Type[])(object)Class5.Default;
			Class7 class23 = @class;
			BindingFlags bindingFlags_23 = (BindingFlags)((Class7)(object)Class5.Default).t(@class.t((BindingFlags)Class5.Default, array4, null, null), type, cultureInfo);
			BindingFlags bindingFlags_24 = bindingFlags;
			Class7 obj20 = (Class7)(object)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])null, type, (Type[])null, (ParameterModifier[])(object)((Class7)(object)Class5.Default).t(bindingFlags, array4, obj, cultureInfo));
			bindingFlags = default(BindingFlags);
			_ = (Class10)(object)obj17.e(bindingFlags_16, methodBase_3, (Type[])(object)class18.W(bindingFlags_18, null, null, type_5, (ParameterModifier[])(object)class19.e(bindingFlags_19, methodBase_4, type_6, (ParameterModifier[])(object)obj19.t(bindingFlags_20, fieldInfo_4, object_7, (CultureInfo)(object)class20.t(default(BindingFlags), (FieldInfo[])(object)class21.j(bindingFlags_21, methodBase_5, ref object_8, parameterModifier_2, cultureInfo_2, string_2, out *(object*)class22.W(bindingFlags_22, propertyInfo_8, type_7, type_8, (ParameterModifier[])(object)class23.j(bindingFlags_23, null, ref *(object[]*)((Class7)null).t(bindingFlags_24, (FieldInfo[])(object)obj20.t(bindingFlags, null, obj, cultureInfo), (object)null, cultureInfo), null, cultureInfo, (string[])(object)Class5.Default, out *(object*)Class5.Default))), obj, (CultureInfo)(object)@class.W(bindingFlags, null, (Type)(object)Class5.Default, null, (ParameterModifier[])(object)Class5.Default))))), array3);
			goto IL_3f33;
		}
		IL_234a:
		while ((object)Class5.Default != null)
		{
		}
		Class7 obj22;
		do
		{
			try
			{
				@class = @class;
				_ = (Class7)(object)Class5.Default;
				class6 = null;
			}
			catch
			{
				do
				{
					_ = (GClass1)(object)Class5.Default;
				}
				while (obj != null);
			}
			obj22 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
		}
		while ((object)obj22.W(bindingFlags, array2, (Type)(object)Class5.Default, null, array3) != null);
		do
		{
			_ = (Class9)(object)((Class7)null).e(bindingFlags, array, array6, (ParameterModifier[])null);
		}
		while (obj != null);
		_ = (_003CModule_003E)(object)Class5.Default;
		Class7 class24 = @class;
		bindingFlags = default(BindingFlags);
		_ = (Class8)(object)class24.e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, array2, type, array6, array3), array3);
		_ = (GClass0)(object)@class.t(bindingFlags, array4, obj, (CultureInfo)(object)Class5.Default);
		gClass3 = gClass3;
		gClass = null;
		Class10 class25 = class25;
		checked
		{
			if (unchecked((nuint)(UIntPtr)Class5.Default) * num2 == 0)
			{
				do
				{
					@struct = @struct;
				}
				while (obj != null || obj != null);
			}
		}
		try
		{
			try
			{
				_ = (Class4)((Class7)null).t((object)Class5.Default, (Type)null, cultureInfo);
			}
			catch
			{
				num2 = default(UIntPtr);
				if (num2 == 0)
				{
					class9 = class9;
				}
			}
		}
		catch
		{
			bindingFlags = default(BindingFlags);
			_ = (Class10)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)@class.W(bindingFlags, null, type, null, array3), array3, (CultureInfo)null, (string[])null, out *(object*)null);
		}
		try
		{
			try
			{
				do
				{
					_ = Class5.Default;
				}
				while ((object)Class5.Default != null);
			}
			catch
			{
				while (obj != null)
				{
					Class7 class26 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass3)(object)((Class7)(object)class26.e(bindingFlags, array, null, array3)).e(bindingFlags, (MethodBase[])(object)Class5.Default, array6, null);
				}
			}
		}
		catch
		{
			if (num2 == 0)
			{
				_ = (Class4)(object)Class5.Default;
			}
		}
		if (num2 == 0)
		{
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)((Class7)null).W(bindingFlags, array2, type, array6, (ParameterModifier[])(object)Class5.Default) == (UIntPtr)(nuint)0u)
			{
				BindingFlags bindingFlags_25 = bindingFlags;
				ref object[] object_9 = ref reference;
				Class7 class27 = @class;
				bindingFlags = default(BindingFlags);
				gClass = (GClass0)(object)((Class7)null).j(bindingFlags_25, (MethodBase[])null, ref object_9, (ParameterModifier[])(object)class27.W(bindingFlags, array2, null, array6, (ParameterModifier[])(object)@class.t(bindingFlags, array4, Class5.Default, null)), cultureInfo, (string[])(object)Class5.Default, out object_4);
			}
		}
		try
		{
		}
		finally
		{
			num2 = default(UIntPtr);
			if (checked(num2 * num2) == 0)
			{
				while (obj != null)
				{
					_ = (Class2)(object)Class5.Default;
				}
			}
			goto IL_2676;
		}
		IL_1c14:
		while (obj != null)
		{
			try
			{
				if (checked(unchecked((nuint)(UIntPtr)((Class7)(object)Class5.Default).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, (CultureInfo)(object)((Class7)null).W((BindingFlags)@class.W((BindingFlags)Class5.Default, array2, null, (Type[])(object)((Class7)(object)Class5.Default).t(bindingFlags, null, null, cultureInfo), array3), array2, (Type)null, array6, array3))) * unchecked((nuint)(UIntPtr)Class5.Default) * (unchecked((nuint)(UIntPtr)Class5.Default) - unchecked((nuint)default(UIntPtr)))) == 0)
				{
					_ = (Struct1)Class5.Default;
					class12 = null;
					_ = (Class2)@class.t(Class5.Default, (Type)((Class7)null).t((object)Class5.Default, type, (CultureInfo)null), cultureInfo);
					_ = (Qk7)@class.t(obj, type, null);
				}
				else
				{
					_ = (Class8)(object)@class.j(bindingFlags, array, ref *(object[]*)null, null, cultureInfo, array5, out *(object*)Class5.Default);
				}
			}
			finally
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					gClass4 = gClass4;
				}
				else
				{
					_ = (Class0)(object)Class5.Default;
				}
				continue;
			}
		}
		checked
		{
			nuint num6 = unchecked((nuint)(UIntPtr)@class.e((BindingFlags)Class5.Default, array, null, (ParameterModifier[])(object)((Class7)(object)Class5.Default).W(bindingFlags, null, type, null, array3))) * unchecked((nuint)(UIntPtr)Class5.Default);
			num2 = default(UIntPtr);
			if (num6 * num2 != 0)
			{
			}
			_ = (_003CModule_003E)((Class7)(object)Class5.Default).t(obj, type, cultureInfo);
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			do
			{
				try
				{
					gClass2 = gClass2;
				}
				catch
				{
					gClass2 = gClass2;
				}
			}
			while ((object)Class5.Default != null);
		}
		qk = (Qk7)(object)Class5.Default;
		try
		{
			try
			{
				@class = @class;
			}
			catch
			{
				gClass = gClass;
			}
			finally
			{
				do
				{
					gClass4 = gClass4;
					gClass = gClass;
					_ = (Qk7)(object)Class5.Default;
					_ = (Class8)(object)Class5.Default;
				}
				while ((object)((Class7)(object)@class.e(bindingFlags, array, null, null)).e(bindingFlags, null, null, null) != null);
				goto end_IL_1cd5;
			}
			end_IL_1cd5:;
		}
		finally
		{
			class25 = class25;
			goto IL_1d4e;
		}
		IL_350f:
		gClass = gClass;
		while ((object)@class.W((BindingFlags)Class5.Default, array2, type, null, array3) != null)
		{
			class6 = class6;
		}
		_ = (Struct2)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)(object)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, array, (Type[])(object)Class5.Default, array3), array6, (ParameterModifier[])(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array6, null));
		_ = (GClass2)(object)((Class7)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)null, array6, (ParameterModifier[])null)).e(bindingFlags, array, array6, array3);
		Class7 class28 = @class;
		BindingFlags bindingFlags_26 = bindingFlags;
		Class7 class29 = @class;
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_27 = bindingFlags;
		MethodBase[] methodBase_6 = array;
		ParameterModifier[] parameterModifier_3 = array3;
		Class7 class30 = @class;
		BindingFlags bindingFlags_28 = bindingFlags;
		Class7 obj29 = (Class7)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		_ = (Class5)(object)class28.e(bindingFlags_26, null, (Type[])(object)class29.j(bindingFlags_27, methodBase_6, ref *(object[]*)null, parameterModifier_3, (CultureInfo)(object)class30.e(bindingFlags_28, (MethodBase[])(object)obj29.W(bindingFlags, array2, type, null, null), null, (ParameterModifier[])(object)((Class7)null).e((BindingFlags)Class5.Default, array, array6, (ParameterModifier[])(object)Class5.Default)), array5, out *(object*)null), null);
		gClass4 = (GClass1)(object)Class5.Default;
		_ = (Class10)(object)Class5.Default;
		try
		{
			_ = (Struct2)Class5.Default;
			class9 = class9;
		}
		catch
		{
			_ = (GClass1)(object)Class5.Default;
		}
		try
		{
			try
			{
			}
			finally
			{
				_ = (Class0)(object)@class.t(bindingFlags, array4, null, cultureInfo);
				goto end_IL_36ca;
			}
			end_IL_36ca:;
		}
		finally
		{
			class13 = class13;
			goto IL_3728;
		}
		IL_4643:
		_ = (Class4)(object)Class5.Default;
		Class8 class31 = class31;
		gClass3 = gClass3;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = (Struct2)Class5.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				while ((object)Class5.Default != null)
				{
					_ = (Class10)(object)Class5.Default;
				}
			}
			return;
		}
		finally
		{
			_003CModule_003E = _003CModule_003E;
			return;
		}
		IL_2126:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct2 struct2);
		if (num2 == 0)
		{
			try
			{
				try
				{
					@class = @class;
				}
				catch
				{
					_ = (GClass0)(object)Class5.Default;
					_ = (Class6)(object)@class.j(bindingFlags, array, ref *(object[]*)((Class7)null).j(bindingFlags, array, ref reference, array3, cultureInfo, array5, out object_4), (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)Class5.Default, array5, out object_4);
					Class7 class32 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_29 = bindingFlags;
					MethodBase[] methodBase_7 = array;
					ref object[] object_10 = ref *(object[]*)Class5.Default;
					Class7 class33 = @class;
					Class7 obj31 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_30 = bindingFlags;
					MethodBase[] methodBase_8 = (MethodBase[])(object)Class5.Default;
					Class7 obj32 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					gClass = (GClass0)(object)class32.j(bindingFlags_29, methodBase_7, ref object_10, (ParameterModifier[])(object)class33.W((BindingFlags)obj31.j(bindingFlags_30, methodBase_8, ref *(object[]*)obj32.W(bindingFlags, array2, (Type)(object)Class5.Default, array6, array3), null, cultureInfo, array5, out object_4), array2, (Type)(object)Class5.Default, (Type[])(object)Class5.Default, array3), cultureInfo, (string[])(object)Class5.Default, out object_4);
				}
			}
			catch
			{
				if ((UIntPtr)((Class7)null).e(bindingFlags, array, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default) == (UIntPtr)(nuint)0u)
				{
					_ = (Class8)(object)Class5.Default;
					class13 = class13;
					_ = (Class9)@class.t(Class5.Default, type, null);
					struct2 = struct2;
				}
				else
				{
					class9 = null;
				}
			}
		}
		try
		{
			_ = (Qk7)(object)Class5.Default;
		}
		finally
		{
			if ((UIntPtr)((Class7)null).e(bindingFlags, (MethodBase[])((Class7)null).t(obj, (Type)null, cultureInfo), array6, array3) == (UIntPtr)(nuint)0u)
			{
				_ = (GClass0)((Class7)(object)Class5.Default).t(null, type, cultureInfo);
			}
			goto IL_234a;
		}
		IL_2676:
		try
		{
			_ = (GClass2)(object)((Class7)(object)Class5.Default).j(bindingFlags, (MethodBase[])(object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array3, cultureInfo, array5, out *(object*)null), ref reference, array3, cultureInfo, null, out *(object*)Class5.Default);
		}
		catch
		{
			gClass = gClass;
		}
		while ((object)Class5.Default != null)
		{
			try
			{
				if (num2 == 0)
				{
					gClass3 = gClass3;
				}
			}
			catch
			{
				gClass2 = gClass2;
			}
		}
		if ((UIntPtr)@class.W((BindingFlags)Class5.Default, null, type, (Type[])(object)((Class7)null).e(bindingFlags, array, array6, (ParameterModifier[])(object)Class5.Default), array3) == (UIntPtr)(nuint)0u)
		{
			if (num2 == 0)
			{
				gClass4 = (GClass1)(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, null, array3);
				_ = (Class10)(object)((Class7)null).t(bindingFlags, array4, (object)Class5.Default, (CultureInfo)null);
				gClass = gClass;
				qk = null;
			}
			else
			{
				Class7 class34 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_31 = bindingFlags;
				Type[] type_9 = array6;
				BindingFlags bindingFlags_32 = (BindingFlags)Class5.Default;
				Class7 class35 = @class;
				BindingFlags bindingFlags_33 = bindingFlags;
				Class7 obj37 = (Class7)(object)((Class7)null).e(bindingFlags, array, (Type[])@class.t(obj, type, (CultureInfo)(object)Class5.Default), array3);
				Class7 obj38 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				UIntPtr num7 = (UIntPtr)((Class7)null).j((BindingFlags)class34.e(bindingFlags_31, null, type_9, (ParameterModifier[])(object)((Class7)null).W(bindingFlags_32, (PropertyInfo[])(object)class35.W(bindingFlags_33, (PropertyInfo[])(object)obj37.j((BindingFlags)obj38.W(bindingFlags, array2, type, null, (ParameterModifier[])(object)((Class7)null).j((BindingFlags)((Class7)null).j(bindingFlags, array, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, (string[])(object)@class.t(bindingFlags, array4, @class.t(Class5.Default, (Type)((Class7)null).t(obj, type, cultureInfo), cultureInfo), cultureInfo), out object_4), (MethodBase[])null, ref reference, (ParameterModifier[])null, cultureInfo, array5, out object_4)), array, ref reference, array3, null, array5, out *(object*)Class5.Default), type, array6, (ParameterModifier[])@class.t(null, (Type)(object)Class5.Default, cultureInfo)), type, array6, array3)), array, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)Class5.Default, cultureInfo, (string[])(object)Class5.Default, out object_4);
				Class7 class36 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_34 = bindingFlags;
				PropertyInfo[] propertyInfo_9 = array2;
				Type type_10 = type;
				Type[] type_11 = array6;
				BindingFlags bindingFlags_35 = bindingFlags;
				FieldInfo[] fieldInfo_5 = array4;
				Class7 class37 = @class;
				bindingFlags = default(BindingFlags);
				UIntPtr num8 = (UIntPtr)class36.W(bindingFlags_34, propertyInfo_9, type_10, type_11, (ParameterModifier[])(object)((Class7)null).t(bindingFlags_35, fieldInfo_5, (object)class37.W(bindingFlags, array2, type, (Type[])(object)@class.W(bindingFlags, array2, type, null, array3), array3), (CultureInfo)(object)Class5.Default));
				num2 = default(UIntPtr);
				checked
				{
					if (unchecked((nuint)num7) - unchecked((nuint)num8 / num2) == 0)
					{
						class25 = (Class10)(object)((Class7)(object)Class5.Default).t(default(BindingFlags), (FieldInfo[])(object)Class5.Default, obj, (CultureInfo)(object)Class5.Default);
					}
					else
					{
						_ = (_003CModule_003E)(object)Class5.Default;
					}
				}
			}
		}
		nuint num9 = num2;
		nuint num10 = num2;
		Class7 obj39 = (Class7)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		if (checked(num9 - unchecked(num10 / (nuint)(UIntPtr)obj39.t(bindingFlags, array4, ((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array3, cultureInfo, (string[])null, out object_4), cultureInfo))) == 0)
		{
			class8 = class8;
			gClass3 = null;
		}
		else
		{
			_003CModule_003E = null;
			_ = (Class10)(object)Class5.Default;
			gClass2 = gClass2;
			Class7 obj40 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_36 = bindingFlags;
			FieldInfo[] fieldInfo_6 = array4;
			object object_11 = obj;
			Class7 class38 = @class;
			object object_12 = Class5.Default;
			Type type_12 = (Type)(object)@class.e((BindingFlags)Class5.Default, array, array6, array3);
			bindingFlags = default(BindingFlags);
			_ = (Class9)(object)obj40.t(bindingFlags_36, fieldInfo_6, object_11, (CultureInfo)class38.t(object_12, type_12, (CultureInfo)(object)((Class7)null).t(bindingFlags, array4, obj, cultureInfo)));
		}
		_ = (Class6)(object)@class.e(bindingFlags, (MethodBase[])(object)@class.t(bindingFlags, null, obj, null), (Type[])(object)Class5.Default, array3);
		_ = (GClass0)(object)Class5.Default;
		class9 = null;
		_ = (Class0)(object)((Class7)null).W(bindingFlags, array2, type, array6, (ParameterModifier[])((Class7)(object)Class5.Default).t(null, type, null));
		try
		{
			do
			{
				_003CModule_003E = _003CModule_003E;
			}
			while (obj != null);
		}
		catch
		{
			while (obj != null)
			{
			}
		}
		while (obj != null)
		{
			try
			{
				try
				{
					_ = (Class0)(object)Class5.Default;
					class13 = null;
					struct2 = struct2;
				}
				catch
				{
					gClass4 = (GClass1)(object)@class.W(bindingFlags, array2, (Type)(object)((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])(object)Class5.Default, array6, null), array6, array3);
					gClass2 = gClass2;
					_ = (Class0)(object)Class5.Default;
				}
			}
			catch
			{
				try
				{
					Class7 class39 = @class;
					object object_13 = obj;
					Class7 class40 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass2)class39.t(object_13, (Type)(object)class40.W(bindingFlags, array2, null, null, array3), (CultureInfo)(object)Class5.Default);
				}
				catch
				{
					_ = (Class9)(object)Class5.Default;
				}
			}
		}
		_ = (GClass1)(object)@class.t(bindingFlags, array4, obj, (CultureInfo)(object)Class5.Default);
		if ((nuint)(UIntPtr)@class.t(null, null, cultureInfo) / (nuint)(UIntPtr)Class5.Default == 0)
		{
			_003CModule_003E = (_003CModule_003E)(object)@class.e(bindingFlags, array, (Type[])(object)Class5.Default, array3);
		}
		checked
		{
			try
			{
				num2 = default(UIntPtr);
				if (num2 == 0)
				{
					try
					{
						_ = (Class5)(object)((Class7)(object)Class5.Default).W(bindingFlags, null, type, null, (ParameterModifier[])(object)Class5.Default);
					}
					finally
					{
						_ = (GClass2)(object)Class5.Default;
						goto end_IL_2d56;
					}
				}
				_ = (Class2)(object)Class5.Default;
				end_IL_2d56:;
			}
			catch
			{
				if (num2 == 0)
				{
					do
					{
						class12 = (Class9)(object)Class5.Default;
					}
					while (obj != null);
				}
				else
				{
					nuint num11 = unchecked((nuint)(UIntPtr)Class5.Default) + unchecked((nuint)(UIntPtr)((Class7)@class.t(obj, null, (CultureInfo)(object)Class5.Default)).e(bindingFlags, null, array6, array3)) - (num2 + unchecked((nuint)(UIntPtr)@class.t(bindingFlags, array4, obj, cultureInfo)));
					num2 = default(UIntPtr);
					if (unchecked(num11 / num2 / checked(num2 * unchecked((nuint)default(UIntPtr)))) * unchecked((nuint)default(UIntPtr)) == 0)
					{
						class12 = class12;
					}
					else
					{
						_ = (Class9)(object)unchecked(@class.j((BindingFlags)@class.t(bindingFlags, (FieldInfo[])@class.t(obj, type, null), obj, null), null, ref *(object[]*)null, null, cultureInfo, null, out object_4));
					}
				}
			}
		}
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					BindingFlags bindingFlags_37 = bindingFlags;
					bindingFlags = default(BindingFlags);
					Class7 obj46 = (Class7)(object)((Class7)(object)((Class7)null).t(bindingFlags_37, (FieldInfo[])(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference, array3, cultureInfo, array5, out object_4), obj, cultureInfo)).e(bindingFlags, array, null, (ParameterModifier[])(object)Class5.Default);
					bindingFlags = default(BindingFlags);
					class25 = (Class10)(object)obj46.e(bindingFlags, null, (Type[])(object)Class5.Default, null);
				}
				finally
				{
					class13 = (Class6)(object)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])null, (Type)null, array6, (ParameterModifier[])(object)((Class7)null).t(bindingFlags, array4, obj, cultureInfo));
					goto end_IL_2ebb;
				}
			}
			while ((object)((Class7)(object)Class5.Default).W(bindingFlags, array2, type, (Type[])(object)Class5.Default, null) != null)
			{
				_ = (Class7)(object)@class.W((BindingFlags)Class5.Default, array2, type, array6, array3);
			}
			end_IL_2ebb:;
		}
		catch
		{
			try
			{
				try
				{
					qk = null;
					_ = (_003CModule_003E)(object)Class5.Default;
				}
				catch
				{
					_ = (Class6)(object)Class5.Default;
				}
			}
			catch
			{
				_ = (Class0)(object)Class5.Default;
			}
		}
		num2 = default(UIntPtr);
		if (num2 == 0)
		{
			num2 = default(UIntPtr);
			if (checked(unchecked((nuint)default(UIntPtr)) + num2) == 0)
			{
				_ = (Class2)(object)@class.W((BindingFlags)((Class7)(object)@class.t(bindingFlags, array4, null, null)).t(obj, type, (CultureInfo)(object)Class5.Default), array2, type, array6, null);
			}
		}
		else
		{
			class8 = class8;
		}
		try
		{
			_ = (GClass0)(object)Class5.Default;
		}
		finally
		{
			try
			{
				_ = (Class4)(object)Class5.Default;
			}
			catch
			{
				@struct = @struct;
				_ = (Class0)(object)Class5.Default;
			}
			goto IL_30e2;
		}
		IL_195c:
		_ = (Class7)(object)Class5.Default;
		try
		{
			_ = (Class9)(object)@class.t(bindingFlags, array4, Class5.Default, cultureInfo);
		}
		catch
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				class6 = class6;
			}
			else
			{
				_ = (Class9)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference, (ParameterModifier[])null, cultureInfo, array5, out object_4);
			}
		}
		try
		{
			while ((object)@class.e((BindingFlags)@class.W((BindingFlags)Class5.Default, array2, null, array6, null), null, null, null) != null)
			{
				try
				{
					_ = (Class5)(object)@class.e(bindingFlags, null, (Type[])((Class7)(object)Class5.Default).t(obj, type, cultureInfo), array3);
					Class4 class10 = (Class4)(object)Class5.Default;
				}
				finally
				{
					gClass2 = null;
					continue;
				}
			}
		}
		finally
		{
			try
			{
				class13 = class13;
			}
			catch
			{
				try
				{
					class12 = class12;
				}
				finally
				{
					Class7 obj52 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					gClass2 = (GClass3)(object)obj52.j(bindingFlags, array, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, array5, out *(object*)null);
					goto end_IL_1a65;
				}
				end_IL_1a65:;
			}
			goto IL_1c14;
		}
		IL_0b8f:
		if ((UIntPtr)@class.t((BindingFlags)((Class7)null).t(obj, type, cultureInfo), array4, null, cultureInfo) == (UIntPtr)(nuint)0u)
		{
			num2 = default(UIntPtr);
			UIntPtr num12 = num2;
			UIntPtr num13 = num2;
			num2 = default(UIntPtr);
			checked
			{
				if (unchecked((nuint)num12) * ((unchecked((nuint)num13) + num2) * unchecked((nuint)(UIntPtr)Class5.Default)) == 0)
				{
					while (obj != null)
					{
						gClass = gClass;
					}
				}
			}
		}
		try
		{
			do
			{
				_ = (Qk7)(object)Class5.Default;
			}
			while (obj != null || obj != null);
		}
		catch
		{
			class12 = class12;
		}
		Class7 obj55 = (Class7)(object)@class.t((BindingFlags)((Class7)(object)((Class7)(object)@class.j(bindingFlags, array, ref reference, array3, cultureInfo, array5, out *(object*)Class5.Default)).e(default(BindingFlags), null, array6, array3)).t(null, type, (CultureInfo)(object)Class5.Default), array4, obj, null);
		MethodBase[] methodBase_9 = array;
		Type[] type_13 = (Type[])((Class7)(object)Class5.Default).t(((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, null, null, cultureInfo), type, cultureInfo);
		Class7 class41 = @class;
		bindingFlags = default(BindingFlags);
		_ = (Class5)(object)obj55.e(default(BindingFlags), methodBase_9, type_13, (ParameterModifier[])(object)class41.t(bindingFlags, array4, obj, cultureInfo));
		@struct = @struct;
		class8 = null;
		_ = (_003CModule_003E)(object)@class.e(bindingFlags, array, null, null);
		if (num2 == 0 && (UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (Class7)(object)Class5.Default;
				_ = (Qk7)(object)Class5.Default;
				class8 = (Class0)(object)Class5.Default;
				Class7 class42 = @class;
				BindingFlags bindingFlags_38 = bindingFlags;
				Class7 class43 = @class;
				Class7 class44 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class8)(object)class42.j(bindingFlags_38, (MethodBase[])(object)class43.j((BindingFlags)class44.e(bindingFlags, null, array6, null), array, ref *(object[]*)null, array3, cultureInfo, null, out object_4), ref *(object[]*)null, array3, cultureInfo, null, out object_4);
			}
			else
			{
				Class4 class10 = null;
			}
		}
		_ = (Class7)(object)Class5.Default;
		_ = (Class4)(object)Class5.Default;
		Class7 obj56 = (Class7)@class.t(null, (Type)(object)((Class7)(object)Class5.Default).j(bindingFlags, array, ref *(object[]*)Class5.Default, null, cultureInfo, (string[])(object)Class5.Default, out object_4), cultureInfo);
		BindingFlags bindingFlags_39 = bindingFlags;
		object object_14 = obj;
		Class7 class45 = @class;
		BindingFlags bindingFlags_40 = (BindingFlags)((Class7)null).W(bindingFlags, array2, type, array6, (ParameterModifier[])null);
		MethodBase[] methodBase_10 = array;
		ref object[] object_15 = ref reference;
		Class7 obj57 = (Class7)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		class31 = (Class8)(object)obj56.t(bindingFlags_39, null, object_14, (CultureInfo)(object)((Class7)(object)class45.j(bindingFlags_40, methodBase_10, ref object_15, (ParameterModifier[])(object)obj57.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)(object)@class.W(bindingFlags, null, null, null, array3), array6, array3), (CultureInfo)(object)Class5.Default, null, out object_4)).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, null, cultureInfo, null, out object_4));
		if ((UIntPtr)@class.t(Class5.Default, (Type)@class.t(obj, type, cultureInfo), cultureInfo) == (UIntPtr)(nuint)0u)
		{
			_ = (Class2)(object)Class5.Default;
		}
		else
		{
			Class7 class46 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_41 = (BindingFlags)class46.e(bindingFlags, (MethodBase[])(object)((Class7)((Class7)(object)Class5.Default).t(((Class7)null).e(bindingFlags, array, array6, array3), type, (CultureInfo)(object)Class5.Default)).e((BindingFlags)@class.e((BindingFlags)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo, (string[])(object)Class5.Default, out *(object*)Class5.Default), array, null, array3), (MethodBase[])(object)@class.j(bindingFlags, array, ref reference, null, null, (string[])(object)Class5.Default, out *(object*)((Class7)null).t(obj, type, (CultureInfo)null)), null, null), null, (ParameterModifier[])(object)Class5.Default);
			MethodBase[] methodBase_11 = (MethodBase[])(object)((Class7)(object)Class5.Default).W(bindingFlags, null, (Type)(object)Class5.Default, array6, null);
			Class7 class47 = @class;
			bindingFlags = default(BindingFlags);
			_ = (GClass1)(object)((Class7)null).e(bindingFlags_41, methodBase_11, (Type[])null, (ParameterModifier[])(object)class47.t(bindingFlags, null, ((Class7)@class.t(obj, type, cultureInfo)).e(bindingFlags, array, (Type[])(object)((Class7)null).W((BindingFlags)@class.j(bindingFlags, (MethodBase[])(object)((Class7)null).t(bindingFlags, array4, (object)null, (CultureInfo)(object)Class5.Default), ref reference, null, null, (string[])(object)Class5.Default, out *(object*)Class5.Default), (PropertyInfo[])null, type, array6, array3), null), (CultureInfo)(object)@class.W(bindingFlags, (PropertyInfo[])(object)((Class7)(object)Class5.Default).e((BindingFlags)((Class7)null).t(bindingFlags, array4, obj, (CultureInfo)null), array, null, (ParameterModifier[])(object)Class5.Default), type, null, null)));
			_ = (_003CModule_003E)(object)Class5.Default;
			_ = (Qk7)(object)Class5.Default;
		}
		checked
		{
			try
			{
				while (obj != null)
				{
					do
					{
						_003CModule_003E = (_003CModule_003E)(object)@class.e(bindingFlags, null, null, array3);
					}
					while ((object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array6, array3) != null);
				}
			}
			finally
			{
				num2 = default(UIntPtr);
				nuint num14 = num2;
				Class7 class48 = @class;
				bindingFlags = default(BindingFlags);
				if (num14 * unchecked((nuint)(UIntPtr)class48.t(bindingFlags, array4, Class5.Default, null)) == 0)
				{
				}
				goto IL_124c;
			}
		}
		IL_043d:
		num2 = default(UIntPtr);
		if (num2 != (UIntPtr)(nuint)0u)
		{
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			if (num2 == (UIntPtr)(nuint)0u)
			{
				try
				{
					class6 = class6;
					struct2 = struct2;
					struct2 = struct2;
				}
				catch
				{
					_ = (GClass3)@class.t(Class5.Default, type, cultureInfo);
				}
			}
			else if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				@struct = (Struct1)Class5.Default;
				@struct = @struct;
			}
		}
		else
		{
			do
			{
				gClass2 = gClass2;
				gClass2 = gClass2;
			}
			while (obj != null);
		}
		try
		{
			while (obj != null)
			{
				if (num2 == (UIntPtr)(nuint)0u)
				{
					_ = (Class9)(object)Class5.Default;
					continue;
				}
				struct2 = default(Struct2);
				struct2 = struct2;
			}
		}
		catch
		{
			while ((object)Class5.Default != null)
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					_ = (GClass1)(object)Class5.Default;
					continue;
				}
				qk = (Qk7)(object)((Class7)(object)Class5.Default).e(bindingFlags, array, null, array3);
				qk = qk;
			}
		}
		_ = (GClass0)(object)Class5.Default;
		try
		{
			if (num2 == (UIntPtr)(nuint)0u)
			{
				class25 = (Class10)((Class7)null).t(obj, type, (CultureInfo)null);
				class25 = null;
			}
		}
		catch
		{
			checked
			{
				if (unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr)) * unchecked((nuint)(UIntPtr)@class.t(obj, type, null)) == 0)
				{
					try
					{
						_003CModule_003E = _003CModule_003E;
						_003CModule_003E = _003CModule_003E;
					}
					catch
					{
						_ = (Struct1)@class.e(bindingFlags, array, array6, (ParameterModifier[])(object)Class5.Default);
					}
				}
				else
				{
					while (obj != null)
					{
						_ = (GClass1)(object)Class5.Default;
					}
				}
			}
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			struct2 = struct2;
		}
		num2 = default(UIntPtr);
		nuint num15 = num2;
		UIntPtr num16 = (UIntPtr)((Class7)((Class7)(object)Class5.Default).t(((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference, array3, cultureInfo, array5, out object_4), type, cultureInfo)).W(default(BindingFlags), null, type, array6, (ParameterModifier[])(object)Class5.Default);
		nuint num17 = num2;
		Class7 class49 = @class;
		Class7 class50 = @class;
		bindingFlags = default(BindingFlags);
		checked
		{
			if (num15 + unchecked((nuint)num16) * (num17 + unchecked((nuint)(UIntPtr)class49.W((BindingFlags)class50.t(bindingFlags, null, obj, null), null, null, array6, null))) == 0)
			{
				_ = (Class6)(object)Class5.Default;
				goto IL_0725;
			}
			try
			{
				_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
			}
			finally
			{
				num2 = default(UIntPtr);
				if (num2 == 0)
				{
					_ = (GClass3)(object)Class5.Default;
				}
				goto IL_0725;
			}
		}
		IL_0725:
		try
		{
			Class7 class51 = @class;
			BindingFlags bindingFlags_42 = bindingFlags;
			BindingFlags bindingFlags_43 = bindingFlags;
			MethodBase[] methodBase_12 = array;
			ref object[] object_16 = ref *(object[]*)Class5.Default;
			BindingFlags bindingFlags_44 = bindingFlags;
			MethodBase[] methodBase_13 = array;
			bindingFlags = default(BindingFlags);
			_ = (GClass1)(object)class51.t(bindingFlags_42, (FieldInfo[])(object)((Class7)null).j(bindingFlags_43, methodBase_12, ref object_16, (ParameterModifier[])(object)((Class7)null).e(bindingFlags_44, methodBase_13, (Type[])(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference, (ParameterModifier[])null, (CultureInfo)(object)Class5.Default, array5, out object_4), array3), (CultureInfo)null, array5, out *(object*)null), null, cultureInfo);
		}
		catch
		{
			_ = (Class4)(object)Class5.Default;
		}
		do
		{
			_ = (Class4)((Class7)@class.t(obj, (Type)(object)Class5.Default, cultureInfo)).t(null, type, cultureInfo);
			Class7 obj63 = (Class7)(object)Class5.Default;
			object object_17 = Class5.Default;
			BindingFlags bindingFlags_45 = bindingFlags;
			FieldInfo[] fieldInfo_7 = (FieldInfo[])(object)@class.e((BindingFlags)@class.W((BindingFlags)Class5.Default, array2, type, null, array3), null, (Type[])(object)((Class7)null).W(bindingFlags, array2, type, array6, array3), array3);
			object object_18 = Class5.Default;
			Class7 class52 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Class4)((Class7)obj63.t(object_17, (Type)(object)((Class7)null).t(bindingFlags_45, fieldInfo_7, object_18, (CultureInfo)(object)class52.t(bindingFlags, array4, null, cultureInfo)), cultureInfo)).t(null, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default);
			class12 = null;
			class12 = class12;
			_ = (_003CModule_003E)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference, array3, cultureInfo, array5, out object_4);
		}
		while (obj != null);
		if (num2 / unchecked((nuint)default(UIntPtr)) == 0)
		{
			class6 = class6;
			_003CModule_003E = _003CModule_003E;
		}
		try
		{
			Class7 class53 = @class;
			BindingFlags bindingFlags_46 = (BindingFlags)Class5.Default;
			MethodBase[] methodBase_14 = array;
			ref object[] object_19 = ref *(object[]*)Class5.Default;
			BindingFlags bindingFlags_47 = (BindingFlags)Class5.Default;
			Class7 obj64 = (Class7)@class.t(obj, null, null);
			Class7 class54 = @class;
			BindingFlags bindingFlags_48 = bindingFlags;
			BindingFlags bindingFlags_49 = (BindingFlags)Class5.Default;
			Type[] type_14 = (Type[])(object)@class.e((BindingFlags)Class5.Default, array, array6, null);
			Class7 class55 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Class10)(object)class53.j(bindingFlags_46, methodBase_14, ref object_19, null, (CultureInfo)(object)((Class7)null).W(bindingFlags_47, (PropertyInfo[])obj64.t(null, (Type)(object)class54.j(bindingFlags_48, (MethodBase[])(object)((Class7)null).e(bindingFlags_49, (MethodBase[])null, type_14, (ParameterModifier[])(object)((Class7)(object)class55.W(bindingFlags, null, (Type)(object)Class5.Default, null, null)).W(bindingFlags, null, null, array6, array3)), ref *(object[]*)Class5.Default, array3, null, array5, out *(object*)@class.e(bindingFlags, array, null, null)), cultureInfo), (Type)(object)Class5.Default, array6, array3), null, out *(object*)null);
		}
		catch
		{
			struct2 = default(Struct2);
			class12 = null;
			class31 = null;
			class31 = null;
		}
		_ = (Class7)(object)Class5.Default;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			class8 = class8;
		}
		do
		{
			struct2 = struct2;
		}
		while (obj != null);
		gClass2 = gClass2;
		_ = Class5.Default;
		num2 = default(UIntPtr);
		if (checked(unchecked((nuint)default(UIntPtr)) - (num2 - unchecked((nuint)(UIntPtr)Class5.Default))) == 0)
		{
			try
			{
				if (num2 == 0)
				{
					_ = (Class8)(object)((Class7)(object)Class5.Default).W(default(BindingFlags), array2, type, array6, array3);
				}
				else
				{
					_003CModule_003E = _003CModule_003E;
				}
			}
			finally
			{
				Class7 class56 = @class;
				bindingFlags = default(BindingFlags);
				_ = (GClass2)(object)class56.j(bindingFlags, (MethodBase[])((Class7)null).t(obj, (Type)(object)Class5.Default, cultureInfo), ref *(object[]*)null, array3, cultureInfo, null, out *(object*)null);
				goto IL_0b8f;
			}
		}
		num2 = default(UIntPtr);
		if (num2 == 0)
		{
			gClass4 = (GClass1)(object)Class5.Default;
		}
		goto IL_0b8f;
		IL_124c:
		try
		{
			if ((UIntPtr)((Class7)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)((Class7)null).j(bindingFlags, array, ref *(object[]*)null, array3, cultureInfo, (string[])null, out *(object*)null), (ParameterModifier[])null)).t(obj, type, cultureInfo) != (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Class8)(object)Class5.Default;
				}
				finally
				{
					Class7 class57 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class2)(object)class57.t(bindingFlags, array4, null, cultureInfo);
					goto end_IL_124d;
				}
			}
			nuint num18 = num2;
			num2 = default(UIntPtr);
			if (num18 / (num2 / (checked(unchecked(checked(unchecked((nuint)(UIntPtr)Class5.Default) + unchecked((nuint)(UIntPtr)((Class7)null).e(bindingFlags, array, (Type[])(object)Class5.Default, array3) / num2)) / (nuint)(UIntPtr)Class5.Default) - num2) / (nuint)(UIntPtr)@class.W((BindingFlags)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, null, null), array2, (Type)(object)Class5.Default, array6, null))) == 0)
			{
				class25 = (Class10)(object)Class5.Default;
			}
			else
			{
				_ = Class5.Default;
				gClass4 = gClass4;
				_ = (GClass1)(object)((Class7)null).j((BindingFlags)@class.t(bindingFlags, array4, null, cultureInfo), array, ref reference, array3, (CultureInfo)(object)((Class7)(object)Class5.Default).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, cultureInfo), array5, out object_4);
			}
			end_IL_124d:;
		}
		catch
		{
			if (checked(num2 * num2) == 0)
			{
				_ = (Qk7)(object)Class5.Default;
			}
			else
			{
				class12 = class12;
			}
		}
		_ = (_003CModule_003E)(object)((Class7)null).t((BindingFlags)Class5.Default, array4, (object)null, cultureInfo);
		while (obj != null)
		{
			if (num2 == 0)
			{
				struct2 = (Struct2)Class5.Default;
			}
		}
		while (obj != null)
		{
			do
			{
				try
				{
					_ = (Class7)(object)Class5.Default;
				}
				catch
				{
					_003CModule_003E = _003CModule_003E;
					@struct = @struct;
					_ = (_003CModule_003E)((Class7)(object)Class5.Default).t(obj, type, (CultureInfo)(object)Class5.Default);
				}
			}
			while ((object)Class5.Default != null);
		}
		if (num2 == 0)
		{
			try
			{
				try
				{
					class13 = class13;
					class13 = class13;
					class8 = class8;
					_ = (Class4)(object)Class5.Default;
					_ = (Class9)(object)@class.j((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, ref reference, array3, null, array5, out object_4);
				}
				catch
				{
					GClass2 obj68 = (GClass2)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					gClass3 = (GClass2)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)Class5.Default, array3, cultureInfo, (string[])null, out object_4);
					gClass3 = obj68;
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
					struct2 = struct2;
					goto end_IL_1564;
				}
				end_IL_1564:;
			}
		}
		else
		{
			try
			{
				_ = (Struct2)((Class7)((Class7)(object)Class5.Default).t(null, null, (CultureInfo)(object)Class5.Default)).t(null, type, null);
			}
			catch
			{
				if (checked(num2 - (num2 - (num2 + num2) * unchecked((nuint)default(UIntPtr)))) == 0)
				{
					_ = (Class5)(object)@class.e(bindingFlags, array, array6, null);
					Class7 class58 = @class;
					BindingFlags bindingFlags_50 = bindingFlags;
					ref object[] object_20 = ref *(object[]*)@class.e(default(BindingFlags), array, array6, (ParameterModifier[])(object)Class5.Default);
					bindingFlags = default(BindingFlags);
					_ = (Class8)(object)class58.t((BindingFlags)((Class7)null).j(bindingFlags_50, (MethodBase[])null, ref object_20, (ParameterModifier[])(object)((Class7)null).j(bindingFlags, array, ref reference, (ParameterModifier[])@class.t(null, type, null), cultureInfo, array5, out *(object*)Class5.Default), (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out object_4), array4, Class5.Default, cultureInfo);
					_ = Class5.Default;
					_ = (Class0)(object)((Class7)(object)Class5.Default).e((BindingFlags)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, array3, (CultureInfo)(object)Class5.Default, array5, out *(object*)Class5.Default), (MethodBase[])(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)Class5.Default, (CultureInfo)null, array5, out object_4), null, array3);
				}
				else
				{
					gClass3 = null;
				}
			}
		}
		try
		{
			try
			{
				try
				{
					_ = (GClass0)(object)Class5.Default;
				}
				finally
				{
					gClass = (GClass0)(object)Class5.Default;
					goto end_IL_1756;
				}
				end_IL_1756:;
			}
			finally
			{
				try
				{
					class12 = class12;
				}
				finally
				{
					class13 = null;
					_ = (Struct2)@class.t(obj, type, cultureInfo);
					goto end_IL_1755;
				}
			}
			end_IL_1755:;
		}
		catch
		{
			class9 = class9;
		}
		try
		{
			class13 = class13;
		}
		finally
		{
			try
			{
				@struct = (Struct1)Class5.Default;
				_ = (GClass0)(object)Class5.Default;
				Class7 class59 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class8)(object)class59.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, null);
				Class7 obj73 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				_ = (Class0)(object)((Class7)(object)((Class7)null).j((BindingFlags)obj73.j(bindingFlags, (MethodBase[])(object)((Class7)null).e(bindingFlags, (MethodBase[])null, array6, (ParameterModifier[])null), ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, (string[])(object)Class5.Default, out *(object*)null), (MethodBase[])null, ref *(object[]*)null, array3, (CultureInfo)(object)@class.e((BindingFlags)Class5.Default, array, array6, array3), array5, out *(object*)((Class7)null).t(obj, type, cultureInfo))).t(bindingFlags, null, obj, null);
			}
			finally
			{
				_ = (Struct2)((Class7)null).j(bindingFlags, array, ref *(object[]*)((Class7)(object)@class.t((BindingFlags)@class.t(obj, (Type)(object)((Class7)(object)@class.e(bindingFlags, null, null, null)).W(bindingFlags, null, (Type)(object)Class5.Default, null, array3), cultureInfo), null, obj, cultureInfo)).t(obj, type, null), array3, (CultureInfo)null, array5, out object_4);
				goto IL_195c;
			}
		}
		IL_3f33:
		if ((UIntPtr)@class.j((BindingFlags)Class5.Default, array, ref reference, array3, (CultureInfo)(object)Class5.Default, array5, out object_4) == (UIntPtr)(nuint)0u)
		{
		}
		while (obj != null)
		{
			if (num2 == 0)
			{
				try
				{
					class25 = null;
					_ = (Class6)((Class7)null).t((object)null, type, cultureInfo);
				}
				catch
				{
					gClass4 = gClass4;
				}
				continue;
			}
			try
			{
				class13 = class13;
				_ = (Class10)((Class7)null).t((object)Class5.Default, type, (CultureInfo)null);
				bindingFlags = default(BindingFlags);
				Class7 obj75 = (Class7)(object)((Class7)null).e(bindingFlags, array, array6, array3);
				bindingFlags = default(BindingFlags);
				_ = (Class5)(object)obj75.j(bindingFlags, null, ref reference, array3, cultureInfo, null, out object_4);
				_ = (GClass0)(object)Class5.Default;
			}
			catch
			{
				_ = (Class4)(object)@class.t(bindingFlags, array4, null, null);
				_ = (Class9)(object)Class5.Default;
				_ = Class5.Default;
			}
		}
		if (checked(num2 + num2) == 0)
		{
			nuint num19 = num2;
			UIntPtr num20 = (UIntPtr)Class5.Default;
			Class7 class60 = @class;
			BindingFlags bindingFlags_51 = (BindingFlags)@class.j(bindingFlags, null, ref reference, array3, cultureInfo, array5, out *(object*)null);
			FieldInfo[] fieldInfo_8 = (FieldInfo[])((Class7)(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, (Type[])((Class7)null).t(obj, type, cultureInfo), (ParameterModifier[])(object)Class5.Default)).t(@class.t(obj, (Type)(object)((Class7)null).W(default(BindingFlags), array2, type, (Type[])(object)Class5.Default, (ParameterModifier[])null), cultureInfo), type, null);
			object object_21 = obj;
			Class7 class61 = @class;
			bindingFlags = default(BindingFlags);
			Class7 obj77 = (Class7)(object)class61.t(bindingFlags, array4, obj, null);
			BindingFlags bindingFlags_52 = (BindingFlags)((Class7)null).t(bindingFlags, (FieldInfo[])(object)((Class7)(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo, array5, out *(object*)((Class7)(object)Class5.Default).j((BindingFlags)Class5.Default, array, ref reference, array3, null, array5, out *(object*)null))).W((BindingFlags)((Class7)null).t(obj, type, cultureInfo), null, type, array6, array3), (object)null, (CultureInfo)(object)Class5.Default);
			PropertyInfo[] propertyInfo_10 = array2;
			Class7 obj78 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_53 = bindingFlags;
			Class7 class62 = @class;
			bindingFlags = default(BindingFlags);
			MethodBase[] methodBase_15 = (MethodBase[])(object)((Class7)((Class7)(object)class62.e((BindingFlags)((Class7)null).j(bindingFlags, array, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo, array5, out *(object*)null), null, null, array3)).t(obj, (Type)@class.t(obj, type, (CultureInfo)(object)@class.W(bindingFlags, null, type, null, array3)), cultureInfo)).e(default(BindingFlags), null, array6, (ParameterModifier[])(object)@class.W(default(BindingFlags), (PropertyInfo[])(object)Class5.Default, type, null, array3));
			ref object[] object_22 = ref reference;
			ParameterModifier[] parameterModifier_4 = array3;
			CultureInfo cultureInfo_3 = cultureInfo;
			Class7 class63 = @class;
			bindingFlags = default(BindingFlags);
			checked
			{
				if (num19 * unchecked((nuint)num20 / (nuint)(UIntPtr)class60.t(bindingFlags_51, fieldInfo_8, object_21, (CultureInfo)(object)obj77.W(bindingFlags_52, propertyInfo_10, (Type)(object)obj78.j(bindingFlags_53, methodBase_15, ref object_22, parameterModifier_4, cultureInfo_3, (string[])(object)class63.W(bindingFlags, array2, (Type)(object)@class.e(bindingFlags, null, (Type[])(object)Class5.Default, array3), array6, array3), out *(object*)@class.W(bindingFlags, null, type, null, (ParameterModifier[])(object)Class5.Default)), (Type[])(object)@class.e(bindingFlags, array, array6, null), null))) == 0)
				{
					_ = (Class4)(object)Class5.Default;
				}
				else
				{
					_003CModule_003E = null;
					gClass3 = gClass3;
					class9 = class9;
					class12 = null;
				}
			}
		}
		else
		{
			_ = (Class2)((Class7)(object)Class5.Default).t(null, type, cultureInfo);
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u && (UIntPtr)@class.W((BindingFlags)Class5.Default, null, null, null, array3) == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (GClass3)(object)Class5.Default;
			}
			catch
			{
				Class4 class10 = (Class4)(object)Class5.Default;
			}
		}
		if ((nuint)(UIntPtr)Class5.Default / checked(unchecked((nuint)(UIntPtr)Class5.Default) * unchecked(num2 / num2)) == 0)
		{
			do
			{
				class9 = class9;
				gClass4 = (GClass1)(object)Class5.Default;
				_ = (_003CModule_003E)(object)Class5.Default;
			}
			while (obj != null);
		}
		if ((UIntPtr)Class5.Default != (UIntPtr)(nuint)0u)
		{
		}
		Class7 class64 = @class;
		bindingFlags = default(BindingFlags);
		_ = (Class4)(object)class64.e(bindingFlags, null, array6, (ParameterModifier[])(object)Class5.Default);
		gClass2 = (GClass3)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)@class.t((BindingFlags)Class5.Default, array4, obj, cultureInfo), type, array6, (ParameterModifier[])null);
		_ = (Class9)(object)Class5.Default;
		_ = (Class2)(object)Class5.Default;
		@struct = @struct;
		try
		{
			Class7 class65 = @class;
			bindingFlags = default(BindingFlags);
			Class7 obj80 = (Class7)(object)((Class7)(object)class65.t(bindingFlags, array4, obj, null)).W((BindingFlags)Class5.Default, (PropertyInfo[])(object)Class5.Default, null, null, null);
			bindingFlags = default(BindingFlags);
			_ = (Class5)(object)obj80.W(bindingFlags, array2, type, (Type[])((Class7)null).t((object)null, type, cultureInfo), null);
		}
		finally
		{
			do
			{
				_ = (Class6)@class.t(@class.j(bindingFlags, null, ref *(object[]*)((Class7)null).e(bindingFlags, array, (Type[])null, array3), (ParameterModifier[])(object)@class.t(bindingFlags, array4, obj, null), cultureInfo, (string[])@class.t(null, (Type)(object)@class.t((BindingFlags)Class5.Default, array4, Class5.Default, null), cultureInfo), out object_4), type, cultureInfo);
			}
			while ((object)Class5.Default != null);
			goto IL_4643;
		}
		IL_30e2:
		try
		{
			if (num2 == 0)
			{
				do
				{
					class12 = class12;
				}
				while ((object)Class5.Default != null);
			}
		}
		catch
		{
			try
			{
				gClass3 = (GClass2)(object)((Class7)(object)Class5.Default).t(bindingFlags, array4, obj, cultureInfo);
			}
			finally
			{
				try
				{
					class9 = null;
					_ = (GClass0)(object)@class.j(bindingFlags, null, ref *(object[]*)null, null, null, (string[])(object)Class5.Default, out object_4);
				}
				finally
				{
					Class7 class66 = @class;
					BindingFlags bindingFlags_54 = bindingFlags;
					PropertyInfo[] propertyInfo_11 = (PropertyInfo[])(object)((Class7)(object)@class.W((BindingFlags)Class5.Default, array2, type, array6, null)).t(default(BindingFlags), array4, obj, cultureInfo);
					Class7 obj81 = (Class7)(object)Class5.Default;
					PropertyInfo[] propertyInfo_12 = array2;
					Type type_15 = (Type)(object)Class5.Default;
					Class7 class67 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class9)(object)class66.W(bindingFlags_54, propertyInfo_11, (Type)(object)obj81.W(default(BindingFlags), propertyInfo_12, type_15, null, (ParameterModifier[])(object)class67.t(bindingFlags, (FieldInfo[])(object)((Class7)null).e(bindingFlags, array, (Type[])(object)Class5.Default, (ParameterModifier[])((Class7)(object)@class.W(bindingFlags, null, (Type)(object)Class5.Default, array6, array3)).t(obj, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default)), null, cultureInfo)), array6, null);
					goto end_IL_3102;
				}
			}
			end_IL_3102:;
		}
		while (true)
		{
			if (obj != null)
			{
				_ = (Class4)(object)Class5.Default;
			}
			else if (obj == null)
			{
				break;
			}
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u && default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (GClass2)(object)Class5.Default;
			}
		}
		else
		{
			try
			{
				_ = (Class2)(object)Class5.Default;
			}
			catch
			{
				if (num2 == 0)
				{
					_ = (Class8)(object)Class5.Default;
				}
				else
				{
					_ = (GClass3)(object)((Class7)(object)Class5.Default).j(bindingFlags, array, ref reference, null, (CultureInfo)(object)Class5.Default, null, out object_4);
				}
			}
		}
		num2 = default(UIntPtr);
		if (num2 == 0)
		{
			num2 = default(UIntPtr);
			if (checked(num2 * unchecked((nuint)(UIntPtr)@class.t(bindingFlags, null, obj, (CultureInfo)(object)Class5.Default))) == 0)
			{
				try
				{
					Class4 class10 = null;
				}
				finally
				{
					Class4 class10 = null;
					Class7 class68 = @class;
					BindingFlags bindingFlags_55 = bindingFlags;
					MethodBase[] methodBase_16 = (MethodBase[])(object)Class5.Default;
					ref object[] object_23 = ref reference;
					ParameterModifier[] parameterModifier_5 = (ParameterModifier[])(object)Class5.Default;
					Class7 obj84 = (Class7)(object)@class.j((BindingFlags)Class5.Default, array, ref *(object[]*)null, null, cultureInfo, (string[])(object)Class5.Default, out *(object*)null);
					MethodBase[] methodBase_17 = array;
					ref object[] object_24 = ref reference;
					ParameterModifier[] parameterModifier_6 = array3;
					CultureInfo cultureInfo_4 = cultureInfo;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_56 = bindingFlags;
					MethodBase[] methodBase_18 = array;
					ref object[] object_25 = ref *(object[]*)((Class7)null).W(bindingFlags, array2, type, (Type[])null, array3);
					ParameterModifier[] parameterModifier_7 = (ParameterModifier[])(object)@class.t(default(BindingFlags), (FieldInfo[])@class.t(null, type, cultureInfo), obj, cultureInfo);
					string[] string_3 = array5;
					Class7 class69 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class6)(object)class68.j(bindingFlags_55, methodBase_16, ref object_23, parameterModifier_5, null, null, out *(object*)obj84.j(default(BindingFlags), methodBase_17, ref object_24, parameterModifier_6, cultureInfo_4, (string[])(object)((Class7)null).j(bindingFlags_56, methodBase_18, ref object_25, parameterModifier_7, (CultureInfo)null, string_3, out *(object*)class69.j(bindingFlags, array, ref *(object[]*)null, array3, null, array5, out *(object*)((Class7)(object)((Class7)((Class7)null).t(obj, (Type)null, (CultureInfo)null)).W(bindingFlags, null, type, array6, array3)).e(bindingFlags, array, array6, null))), out object_4));
					goto IL_350f;
				}
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
				while (obj != null)
				{
					_ = (_003CModule_003E)(object)Class5.Default;
				}
			}
		}
		goto IL_350f;
		IL_3728:
		while ((object)Class5.Default != null)
		{
			while (obj != null)
			{
				num2 = default(UIntPtr);
				if (num2 == 0)
				{
					gClass3 = (GClass2)(object)Class5.Default;
				}
				else
				{
					_ = (_003CModule_003E)(object)Class5.Default;
				}
			}
		}
		if (num2 == 0)
		{
			try
			{
				Class7 obj86;
				object object_26;
				Type type_16;
				BindingFlags bindingFlags_57;
				Class7 class72;
				do
				{
					_ = (GClass1)(object)Class5.Default;
					class25 = class25;
					_ = (GClass3)(object)@class.e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, null, array3);
					Class7 class70 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass3)(object)class70.t(bindingFlags, array4, null, cultureInfo);
					obj86 = (Class7)(object)Class5.Default;
					object_26 = @class.e(bindingFlags, array, (Type[])(object)@class.e(bindingFlags, array, array6, array3), null);
					type_16 = type;
					Class7 class71 = @class;
					bindingFlags = default(BindingFlags);
					bindingFlags_57 = (BindingFlags)class71.W(bindingFlags, array2, null, null, (ParameterModifier[])(object)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, null, array3));
					class72 = @class;
					bindingFlags = default(BindingFlags);
				}
				while (obj86.t(object_26, type_16, (CultureInfo)(object)((Class7)null).t(bindingFlags_57, (FieldInfo[])null, (object)class72.W(bindingFlags, null, type, array6, array3), (CultureInfo)null)) != null);
			}
			finally
			{
				class25 = class25;
				goto IL_3882;
			}
		}
		goto IL_3882;
		IL_1d4e:
		try
		{
			while (obj != null)
			{
				_ = (Class8)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, cultureInfo);
			}
		}
		catch
		{
			while (obj != null)
			{
				_ = (GClass1)((Class7)(object)Class5.Default).t(null, null, (CultureInfo)(object)Class5.Default);
				@class = @class;
			}
		}
		finally
		{
			class25 = null;
			goto IL_1db1;
		}
	}

	unsafe static void smethod_4()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] array2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] array3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object[] reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string[] array4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] array5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object reference2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class7 class2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class4 @class);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class8 class4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out UIntPtr num);
		GClass2 gClass;
		while (obj != null)
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Class10)(object)Class5.Default;
					@class = @class;
					@class = null;
					Class7 obj2 = (Class7)(object)Class5.Default;
					obj = obj;
					bindingFlags = (BindingFlags)obj2.t(obj, null, null);
					BindingFlags bindingFlags_ = bindingFlags;
					class2 = null;
					Class7 class3 = class2;
					BindingFlags bindingFlags_2 = bindingFlags;
					PropertyInfo[] propertyInfo_ = array;
					type = (Type)(object)Class5.Default;
					Type type_ = type;
					array2 = array2;
					Type[] type_2 = array2;
					array3 = array3;
					array = (PropertyInfo[])(object)class3.W(bindingFlags_2, propertyInfo_, type_, type_2, array3);
					_ = (Class0)(object)((Class7)null).W(bindingFlags_, array, type, (Type[])(object)Class5.Default, array3);
				}
				else
				{
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_3 = bindingFlags;
					MethodBase[] methodBase_ = (MethodBase[])(object)Class5.Default;
					reference = ref reference;
					ref object[] object_ = ref reference;
					ParameterModifier[] parameterModifier_ = array3;
					cultureInfo = cultureInfo;
					CultureInfo cultureInfo_ = cultureInfo;
					array4 = (string[])(object)Class5.Default;
					_ = (Class9)(object)((Class7)null).j(bindingFlags_3, methodBase_, ref object_, parameterModifier_, cultureInfo_, array4, out *(object*)null);
					class4 = null;
					class4 = class4;
					_ = (_003CModule_003E)(object)Class5.Default;
				}
			}
			else
			{
				nuint num2 = num;
				Class7 obj3 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_4 = bindingFlags;
				array5 = (MethodBase[])(object)Class5.Default;
				MethodBase[] methodBase_2 = array5;
				ref object[] object_2 = ref *(object[]*)Class5.Default;
				ParameterModifier[] parameterModifier_2 = (ParameterModifier[])(object)Class5.Default;
				string[] string_ = array4;
				reference2 = ref reference2;
				checked
				{
					num = num2 + unchecked((nuint)(UIntPtr)obj3.j(bindingFlags_4, methodBase_2, ref object_2, parameterModifier_2, null, string_, out reference2)) + unchecked((nuint)(UIntPtr)Class5.Default);
					num = default(UIntPtr);
					if (num == 0)
					{
						gClass = (GClass2)(object)Class5.Default;
						gClass = gClass;
					}
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct2 @struct);
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			_ = (Struct2)Class5.Default;
			class4 = class4;
			@struct = @struct;
			@struct = @struct;
		}
		_ = (GClass2)((Class7)null).t(obj, type, (CultureInfo)null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass3 gClass2);
		while (obj != null)
		{
			try
			{
				gClass2 = (GClass3)(object)((Class7)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, array3)).t(bindingFlags, null, obj, (CultureInfo)(object)Class5.Default);
				gClass2 = null;
			}
			finally
			{
				@class = @class;
				continue;
			}
		}
		_ = (GClass3)(object)class2.W((BindingFlags)class2.j(bindingFlags, array5, ref *(object[]*)null, (ParameterModifier[])(object)((Class7)null).W(bindingFlags, array, type, array2, array3), cultureInfo, (string[])class2.t(obj, type, cultureInfo), out reference2), array, null, null, array3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out FieldInfo[] array6);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass1 gClass3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class9 class10);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qk7 qk);
		while (obj != null)
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				try
				{
					Class7 obj4 = (Class7)(object)Class5.Default;
					Class7 class5 = class2;
					Class7 class6 = class2;
					bindingFlags = default(BindingFlags);
					Class7 obj5 = (Class7)(object)obj4.j((BindingFlags)class5.W((BindingFlags)class6.j(bindingFlags, array5, ref *(object[]*)null, array3, cultureInfo, (string[])class2.t(obj, (Type)(object)class2.j((BindingFlags)Class5.Default, array5, ref reference, (ParameterModifier[])(object)class2.W(bindingFlags, array, type, (Type[])(object)class2.j((BindingFlags)Class5.Default, null, ref reference, array3, cultureInfo, array4, out *(object*)null), array3), cultureInfo, (string[])(object)Class5.Default, out reference2), (CultureInfo)(object)Class5.Default), out *(object*)Class5.Default), array, type, array2, null), array5, ref *(object[]*)null, null, (CultureInfo)(object)((Class7)null).e(bindingFlags, array5, array2, (ParameterModifier[])null), null, out *(object*)class2.j(bindingFlags, array5, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, null, array4, out *(object*)null));
					Class7 obj6 = (Class7)(object)Class5.Default;
					Class7 class7 = class2;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_5 = bindingFlags;
					PropertyInfo[] propertyInfo_2 = (PropertyInfo[])(object)Class5.Default;
					Class7 class8 = class2;
					Class7 obj7 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_6 = bindingFlags;
					PropertyInfo[] propertyInfo_3 = array;
					Type type_3 = type;
					Class7 class9 = class2;
					BindingFlags bindingFlags_7 = bindingFlags;
					MethodBase[] methodBase_3 = (MethodBase[])class2.t(obj, (Type)(object)Class5.Default, cultureInfo);
					ref object[] object_3 = ref reference;
					Class7 obj8 = (Class7)class2.t(null, (Type)(object)Class5.Default, null);
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_8 = (BindingFlags)((Class7)null).e((BindingFlags)((Class7)null).t((object)class7.W(bindingFlags_5, propertyInfo_2, (Type)(object)class8.j((BindingFlags)obj7.W(bindingFlags_6, propertyInfo_3, type_3, (Type[])(object)class9.j(bindingFlags_7, methodBase_3, ref object_3, (ParameterModifier[])(object)obj8.e(bindingFlags, array5, array2, array3), cultureInfo, null, out reference2), array3), array5, ref reference, array3, null, array4, out *(object*)Class5.Default), (Type[])((Class7)(object)class2.W(bindingFlags, null, null, null, (ParameterModifier[])(object)Class5.Default)).t(Class5.Default, type, cultureInfo), array3), (Type)null, cultureInfo), array5, (Type[])(object)Class5.Default, array3);
					BindingFlags bindingFlags_9 = bindingFlags;
					PropertyInfo[] propertyInfo_4 = array;
					Type type_4 = type;
					Type[] type_5 = array2;
					Class7 obj9 = (Class7)((Class7)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, array2, (ParameterModifier[])null)).t(obj, null, cultureInfo);
					BindingFlags bindingFlags_10 = bindingFlags;
					Class7 obj10 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					array6 = (FieldInfo[])(object)obj10.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, array2, array3);
					qk = (Qk7)obj5.t(obj6.e(bindingFlags_8, (MethodBase[])(object)((Class7)null).W(bindingFlags_9, propertyInfo_4, type_4, type_5, (ParameterModifier[])(object)obj9.t(bindingFlags_10, array6, obj, null)), (Type[])(object)((Class7)null).t((BindingFlags)Class5.Default, array6, (object)Class5.Default, cultureInfo), null), (Type)(object)Class5.Default, cultureInfo);
					qk = qk;
				}
				finally
				{
					_ = (Struct2)class2.j((BindingFlags)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, array5, null, array3), null, ref *(object[]*)null, array3, (CultureInfo)((Class7)null).t(obj, type, cultureInfo), (string[])(object)Class5.Default, out *(object*)null);
					continue;
				}
			}
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				class10 = class10;
				class10 = class10;
				_ = (Struct2)Class5.Default;
				gClass3 = gClass3;
				gClass3 = gClass3;
			}
			else
			{
				qk = qk;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class0 class11);
		if (checked(unchecked((nuint)(UIntPtr)((Class7)null).W((BindingFlags)((Class7)null).t(obj, (Type)(object)Class5.Default, cultureInfo), array, type, (Type[])(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, array, null, array2, null), array2, (ParameterModifier[])(object)Class5.Default), array3)) - (num + unchecked(checked(num * unchecked((nuint)(UIntPtr)Class5.Default)) / unchecked((nuint)default(UIntPtr))))) == 0)
		{
			class11 = (Class0)(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)class2.t(bindingFlags, array6, Class5.Default, cultureInfo), array4, out *(object*)null);
			class11 = class11;
		}
		@class = @class;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass0 gClass4);
		while (obj != null)
		{
			do
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					gClass4 = null;
				}
			}
			while ((object)Class5.Default != null);
		}
		num = default(UIntPtr);
		checked
		{
			if (num == 0)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					nuint num3 = num;
					num = default(UIntPtr);
					if (unchecked(num3 / num) == 0)
					{
						gClass4 = (GClass0)(object)Class5.Default;
					}
				}
			}
			else
			{
				nuint num4 = num * unchecked(num / (nuint)(UIntPtr)Class5.Default);
				num = default(UIntPtr);
				if ((num4 + unchecked(unchecked((nuint)default(UIntPtr)) / num) - unchecked((nuint)(UIntPtr)Class5.Default)) * unchecked(num / num) == 0)
				{
					_ = (Class9)(object)Class5.Default;
				}
				else
				{
					do
					{
						_ = (Class6)(object)class2.e(bindingFlags, array5, array2, array3);
					}
					while (obj != null);
				}
			}
			try
			{
				if (num - unchecked((nuint)default(UIntPtr)) == 0 && unchecked((UIntPtr)class2.W((BindingFlags)((Class7)null).W((BindingFlags)Class5.Default, array, type, array2, (ParameterModifier[])null), array, null, array2, (ParameterModifier[])(object)Class5.Default) == (UIntPtr)(nuint)0u))
				{
					_ = (Class2)(object)Class5.Default;
				}
			}
			finally
			{
				while ((object)Class5.Default != null)
				{
					_ = (Class7)(object)Class5.Default;
				}
				goto IL_09c5;
			}
		}
		IL_0cf6:
		nuint num5 = num;
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class2 class12);
		if (checked(num5 * num - num * num) == 0)
		{
			class12 = (Class2)(object)Class5.Default;
		}
		try
		{
		}
		finally
		{
			goto IL_0fa6;
		}
		IL_1f80:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class6 class13);
		checked
		{
			if (num == 0)
			{
				if (num - unchecked((nuint)(UIntPtr)((Class7)null).W(bindingFlags, array, type, array2, (ParameterModifier[])null)) == 0)
				{
					do
					{
						_ = (_003CModule_003E)(object)Class5.Default;
					}
					while (obj != null);
				}
				else
				{
					try
					{
						_ = (Class6)(object)Class5.Default;
					}
					catch
					{
						class13 = (Class6)(object)Class5.Default;
						class2 = class2;
					}
				}
			}
			else
			{
				while (obj != null)
				{
					while (class2.t(obj, (Type)(object)Class5.Default, null) != null)
					{
						_ = (Class4)(object)Class5.Default;
					}
				}
			}
			do
			{
				_ = (Class9)(object)Class5.Default;
			}
			while (obj != null);
			num = default(UIntPtr);
		}
		if (num == (UIntPtr)(nuint)0u)
		{
			_ = (GClass0)(object)Class5.Default;
		}
		UIntPtr num6 = num;
		num = default(UIntPtr);
		if (checked(unchecked((nuint)num6) + num - (num + num)) / unchecked((nuint)default(UIntPtr)) == 0)
		{
			_ = (Qk7)(object)Class5.Default;
			goto IL_2197;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class10 class14);
		try
		{
			_ = (GClass1)(object)Class5.Default;
		}
		finally
		{
			try
			{
				_ = (Struct2)class2.t(null, type, cultureInfo);
				class14 = class14;
				_ = (GClass3)(object)Class5.Default;
				qk = qk;
			}
			finally
			{
				_ = (Class0)(object)Class5.Default;
				goto IL_2197;
			}
		}
		IL_0fa6:
		while ((object)((Class7)((Class7)null).t((object)null, (Type)null, (CultureInfo)null)).e(bindingFlags, (MethodBase[])(object)Class5.Default, null, null) != null)
		{
			num = default(UIntPtr);
			if (checked(unchecked(unchecked((nuint)default(UIntPtr)) / num) - num) == 0)
			{
				nuint num7 = num;
				num = default(UIntPtr);
				if (num7 / num == 0)
				{
					_ = (Class9)(object)Class5.Default;
				}
				continue;
			}
			while (true)
			{
				object object_4 = obj;
				Class7 class15 = class2;
				Class7 class16 = class2;
				bindingFlags = default(BindingFlags);
				Class7 obj12 = (Class7)(object)class16.j(bindingFlags, null, ref *(object[]*)null, array3, cultureInfo, array4, out reference2);
				BindingFlags bindingFlags_11 = (BindingFlags)((Class7)null).e((BindingFlags)((Class7)(object)Class5.Default).t(bindingFlags, array6, class2.t(bindingFlags, (FieldInfo[])(object)((Class7)(object)Class5.Default).e(bindingFlags, array5, null, array3), Class5.Default, cultureInfo), cultureInfo), (MethodBase[])null, array2, (ParameterModifier[])null);
				MethodBase[] methodBase_4 = array5;
				ref object[] object_5 = ref *(object[]*)((Class7)(object)((Class7)null).t(bindingFlags, array6, (object)class2.e((BindingFlags)Class5.Default, null, array2, null), cultureInfo)).e((BindingFlags)Class5.Default, null, array2, array3);
				ParameterModifier[] parameterModifier_3 = array3;
				CultureInfo cultureInfo_2 = cultureInfo;
				string[] string_2 = array4;
				Class7 class17 = class2;
				MethodBase[] methodBase_5 = (MethodBase[])(object)class2.t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, null, null);
				ref object[] object_6 = ref reference;
				ParameterModifier[] parameterModifier_4 = (ParameterModifier[])(object)Class5.Default;
				Class7 obj13 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				if ((object)((Class7)null).t(default(BindingFlags), (FieldInfo[])null, object_4, (CultureInfo)class15.t(obj12.j(bindingFlags_11, methodBase_4, ref object_5, parameterModifier_3, cultureInfo_2, string_2, out *(object*)((Class7)null).t((BindingFlags)class17.j(default(BindingFlags), methodBase_5, ref object_6, parameterModifier_4, (CultureInfo)(object)obj13.e(bindingFlags, array5, array2, null), (string[])(object)Class5.Default, out reference2), array6, (object)Class5.Default, (CultureInfo)null)), type, (CultureInfo)(object)class2.W(bindingFlags, null, type, (Type[])(object)((Class7)(object)Class5.Default).t(bindingFlags, null, Class5.Default, null), array3))) == null)
				{
					break;
				}
				_ = (Class6)(object)Class5.Default;
			}
		}
		while (obj != null)
		{
			try
			{
				while (obj != null)
				{
					_ = (Class7)(object)class2.W(bindingFlags, array, type, null, array3);
				}
			}
			finally
			{
				try
				{
					_ = (_003CModule_003E)(object)((Class7)(object)Class5.Default).t(bindingFlags, null, Class5.Default, cultureInfo);
				}
				finally
				{
					_ = (GClass2)class2.t(null, type, (CultureInfo)(object)Class5.Default);
					continue;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class5 class21);
		_003CModule_003E _003CModule_003E;
		do
		{
			Class7 class18 = class2;
			BindingFlags bindingFlags_12 = bindingFlags;
			MethodBase[] methodBase_6 = (MethodBase[])(object)Class5.Default;
			Class7 class19 = class2;
			BindingFlags bindingFlags_13 = (BindingFlags)Class5.Default;
			MethodBase[] methodBase_7 = (MethodBase[])(object)Class5.Default;
			ref object[] object_7 = ref reference;
			Class7 class20 = class2;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)class18.j(bindingFlags_12, methodBase_6, ref *(object[]*)null, null, null, (string[])(object)class19.j(bindingFlags_13, methodBase_7, ref object_7, null, (CultureInfo)(object)((Class7)(object)class20.t(bindingFlags, array6, obj, cultureInfo)).e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, array3), (string[])(object)Class5.Default, out reference2), out *(object*)null) != (UIntPtr)(nuint)0u)
			{
				do
				{
					@class = @class;
					class10 = class10;
					_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
					gClass2 = gClass2;
				}
				while (obj != null);
			}
			else if (checked(unchecked((nuint)(UIntPtr)class2.t(obj, type, null)) - num) == 0)
			{
				gClass4 = (GClass0)((Class7)(object)Class5.Default).t(Class5.Default, type, cultureInfo);
				class21 = class21;
			}
		}
		while (obj != null);
		try
		{
			try
			{
				num = default(UIntPtr);
				UIntPtr num8 = num;
				UIntPtr num9 = num;
				num = default(UIntPtr);
				if (checked(unchecked((nuint)num8) - (unchecked((nuint)num9) + (unchecked((nuint)default(UIntPtr)) - num - num)) - unchecked((nuint)(UIntPtr)Class5.Default)) == 0)
				{
					class11 = class11;
					_003CModule_003E = null;
					_ = (Class7)(object)Class5.Default;
					_003CModule_003E = (_003CModule_003E)(object)class2.t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, obj, (CultureInfo)(object)Class5.Default);
				}
			}
			finally
			{
				try
				{
					class2 = (Class7)(object)Class5.Default;
					class4 = (Class8)(object)Class5.Default;
					qk = qk;
					_ = (Class8)(object)class2.e((BindingFlags)class2.e((BindingFlags)Class5.Default, array5, null, array3), array5, (Type[])class2.t(obj, null, null), null);
				}
				finally
				{
					class21 = class21;
					goto end_IL_1189;
				}
			}
			end_IL_1189:;
		}
		finally
		{
			do
			{
				gClass4 = gClass4;
			}
			while (obj != null || (object)Class5.Default != null);
			goto IL_12bd;
		}
		IL_22cb:
		try
		{
			_ = (GClass1)(object)Class5.Default;
		}
		catch
		{
			class4 = class4;
		}
		_ = (GClass2)(object)Class5.Default;
		checked
		{
			while (obj != null)
			{
				Class7 class22 = class2;
				bindingFlags = default(BindingFlags);
				if (unchecked((nuint)(UIntPtr)class22.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo, array4, out *(object*)Class5.Default)) + unchecked((nuint)(UIntPtr)class2.t(obj, (Type)(object)Class5.Default, null)) == 0)
				{
					_ = (Class2)(object)Class5.Default;
					continue;
				}
				while (obj != null)
				{
					_ = (GClass2)(object)((Class7)(object)Class5.Default).W(bindingFlags, array, type, array2, null);
				}
			}
			class2 = null;
			while (obj != null)
			{
				while (obj != null)
				{
					if (num == 0)
					{
						_ = (GClass1)(object)Class5.Default;
					}
				}
			}
		}
		try
		{
			qk = (Qk7)(object)Class5.Default;
		}
		finally
		{
			try
			{
				try
				{
					Class7 class23 = class2;
					BindingFlags bindingFlags_14 = (BindingFlags)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])null, (ParameterModifier[])(object)class2.j(bindingFlags, (MethodBase[])((Class7)((Class7)(object)Class5.Default).t(null, (Type)(object)Class5.Default, null)).t(obj, type, (CultureInfo)class2.t(class2.t(obj, type, cultureInfo), null, cultureInfo)), ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, array4, out *(object*)class2.t(bindingFlags, (FieldInfo[])(object)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, (PropertyInfo[])(object)Class5.Default, type, (Type[])(object)Class5.Default, array3), null, cultureInfo)));
					MethodBase[] methodBase_8 = array5;
					ref object[] object_8 = ref reference;
					BindingFlags bindingFlags_15 = (BindingFlags)Class5.Default;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_16 = bindingFlags;
					Type type_6 = (Type)(object)class2.t((BindingFlags)((Class7)null).t(obj, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default), null, obj, cultureInfo);
					Class7 class24 = class2;
					bindingFlags = default(BindingFlags);
					_ = (Class2)(object)class23.j(bindingFlags_14, methodBase_8, ref object_8, null, (CultureInfo)(object)((Class7)null).j(bindingFlags_15, (MethodBase[])null, ref *(object[]*)((Class7)null).W(bindingFlags_16, (PropertyInfo[])null, type_6, (Type[])null, (ParameterModifier[])(object)((Class7)(object)class24.e(bindingFlags, null, null, array3)).t((BindingFlags)class2.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, (CultureInfo)(object)Class5.Default), array6, obj, null)), array3, cultureInfo, array4, out reference2), null, out *(object*)null);
				}
				finally
				{
					_003CModule_003E = null;
					goto end_IL_23d1;
				}
				end_IL_23d1:;
			}
			finally
			{
				while (obj != null)
				{
					_ = Class5.Default;
					class14 = (Class10)(object)Class5.Default;
					gClass3 = gClass3;
				}
				goto IL_26ba;
			}
		}
		IL_284b:
		try
		{
			try
			{
				while (obj != null)
				{
					class4 = class4;
				}
			}
			finally
			{
				try
				{
					_ = (GClass1)(object)((Class7)(object)class2.j((BindingFlags)Class5.Default, array5, ref *(object[]*)null, array3, cultureInfo, (string[])(object)Class5.Default, out *(object*)Class5.Default)).j(bindingFlags, array5, ref *(object[]*)class2.t(bindingFlags, array6, null, cultureInfo), (ParameterModifier[])(object)Class5.Default, cultureInfo, array4, out reference2);
				}
				finally
				{
					_ = (Class6)(object)class2.j((BindingFlags)class2.t(null, type, cultureInfo), null, ref *(object[]*)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, (Type[])null, array3), array3, cultureInfo, array4, out reference2);
					Class7 obj15 = (Class7)(object)class2.e(bindingFlags, (MethodBase[])(object)((Class7)(object)Class5.Default).j((BindingFlags)Class5.Default, array5, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, array4, out reference2), null, null);
					bindingFlags = default(BindingFlags);
					_ = (Qk7)(object)obj15.W(bindingFlags, array, null, array2, null);
					_ = (Class6)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])(object)Class5.Default, (ParameterModifier[])null);
					goto end_IL_284c;
				}
			}
			end_IL_284c:;
		}
		catch
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				while (obj != null)
				{
					_ = (Class7)(object)Class5.Default;
				}
			}
			else
			{
				Class7 obj16 = (Class7)(object)Class5.Default;
				Class7 class25 = class2;
				bindingFlags = default(BindingFlags);
				_ = (Class9)(object)obj16.j((BindingFlags)class25.t(bindingFlags, array6, obj, (CultureInfo)(object)Class5.Default), array5, ref *(object[]*)null, array3, cultureInfo, (string[])(object)Class5.Default, out *(object*)null);
			}
		}
		try
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				nuint num10 = num;
				num = default(UIntPtr);
				if (checked(num10 - num + num) == 0)
				{
					class11 = class11;
				}
				else
				{
					gClass = null;
				}
			}
			else
			{
				do
				{
					class4 = class4;
				}
				while ((object)Class5.Default != null);
			}
		}
		finally
		{
			if ((UIntPtr)((Class7)(object)class2.e(bindingFlags, null, null, null)).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, array3, (CultureInfo)(object)class2.W(bindingFlags, array, (Type)(object)Class5.Default, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default), null, out *(object*)null) == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Class2)(object)class2.j((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, array3, cultureInfo, array4, out *(object*)null);
				}
				finally
				{
					_003CModule_003E = null;
					goto IL_2b4a;
				}
			}
			goto IL_2b4a;
		}
		IL_2197:
		Class7 class26;
		Class7 class27;
		do
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Struct1)((Class7)(object)Class5.Default).j(bindingFlags, (MethodBase[])(object)class2.t((BindingFlags)Class5.Default, array6, obj, (CultureInfo)(object)Class5.Default), ref reference, null, (CultureInfo)((Class7)(object)Class5.Default).t(obj, null, cultureInfo), array4, out reference2);
			}
			class26 = class2;
			class27 = class2;
			bindingFlags = default(BindingFlags);
		}
		while ((object)class26.t((BindingFlags)class27.e(bindingFlags, null, array2, array3), array6, Class5.Default, cultureInfo) != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct1 struct2);
		checked
		{
			try
			{
				while (obj != null)
				{
					gClass4 = gClass4;
					struct2 = (Struct1)Class5.Default;
					_ = (Qk7)(object)Class5.Default;
				}
			}
			finally
			{
				num = default(UIntPtr);
				if (unchecked(unchecked((nuint)default(UIntPtr)) / checked(num * (unchecked((nuint)(UIntPtr)Class5.Default) * (unchecked((nuint)(UIntPtr)Class5.Default / num) * num)))) - (num * num - num) == 0)
				{
					while (obj != null)
					{
						class10 = class10;
						class2 = (Class7)(object)class2.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)class2.t(Class5.Default, type, cultureInfo), array2, (ParameterModifier[])((Class7)null).t((object)null, type, (CultureInfo)(object)Class5.Default));
						gClass2 = (GClass3)(object)Class5.Default;
					}
				}
				else
				{
					num = default(UIntPtr);
					if (num + unchecked((nuint)(UIntPtr)Class5.Default) == 0)
					{
						@struct = @struct;
					}
				}
				goto IL_22cb;
			}
		}
		IL_2e17:
		while (obj != null)
		{
			try
			{
				while (obj != null)
				{
					class12 = null;
				}
			}
			catch
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					class21 = null;
					class13 = null;
					_ = (Class7)(object)((Class7)(object)Class5.Default).W(bindingFlags, array, null, array2, array3);
					gClass2 = null;
				}
			}
		}
		_ = (Struct2)Class5.Default;
		while (class2.t(obj, (Type)((Class7)null).t(obj, type, (CultureInfo)null), null) != null)
		{
			try
			{
				if (checked(num * num) == 0)
				{
					BindingFlags bindingFlags_17 = (BindingFlags)Class5.Default;
					object object_9 = ((Class7)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, (CultureInfo)null, array4, out reference2)).t(obj, type, cultureInfo);
					Class7 class28 = class2;
					bindingFlags = default(BindingFlags);
					_ = (Class8)(object)((Class7)null).t(bindingFlags_17, (FieldInfo[])null, ((Class7)null).t(object_9, (Type)(object)class28.t(bindingFlags, array6, null, (CultureInfo)(object)class2.t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, obj, cultureInfo)), (CultureInfo)null), (CultureInfo)null);
				}
			}
			finally
			{
				_ = (Class0)(object)((Class7)null).j((BindingFlags)Class5.Default, array5, ref *(object[]*)class2.j(bindingFlags, null, ref *(object[]*)Class5.Default, null, cultureInfo, array4, out *(object*)null), array3, cultureInfo, array4, out *(object*)null);
				continue;
			}
		}
		if ((UIntPtr)((Class7)null).e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, (Type[])null, array3) == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				BindingFlags bindingFlags_18 = bindingFlags;
				PropertyInfo[] propertyInfo_5 = array;
				Type type_7 = type;
				Type[] type_8 = (Type[])(object)((Class7)(object)class2.e(bindingFlags, null, null, array3)).t(default(BindingFlags), (FieldInfo[])(object)Class5.Default, obj, cultureInfo);
				Class7 class29 = class2;
				Class7 class30 = class2;
				bindingFlags = default(BindingFlags);
				if ((UIntPtr)((Class7)null).W(bindingFlags_18, propertyInfo_5, type_7, type_8, (ParameterModifier[])(object)class29.W((BindingFlags)((Class7)null).t(default(BindingFlags), (FieldInfo[])null, (object)class30.t(bindingFlags, array6, obj, cultureInfo), (CultureInfo)(object)Class5.Default), (PropertyInfo[])(object)Class5.Default, type, array2, array3)) == (UIntPtr)(nuint)0u)
				{
					class4 = class4;
					continue;
				}
				Class7 class31 = class2;
				BindingFlags bindingFlags_19 = bindingFlags;
				Class7 class32 = class2;
				bindingFlags = default(BindingFlags);
				MethodBase[] methodBase_9 = (MethodBase[])(object)class32.e(bindingFlags, null, array2, (ParameterModifier[])(object)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, array5, null, array3));
				Class7 class33 = class2;
				BindingFlags bindingFlags_20 = bindingFlags;
				MethodBase[] methodBase_10 = array5;
				ref object[] object_10 = ref reference;
				Class7 class34 = class2;
				object object_11 = Class5.Default;
				Class7 class35 = class2;
				bindingFlags = default(BindingFlags);
				ref object[] object_12 = ref *(object[]*)class33.j(bindingFlags_20, methodBase_10, ref object_10, null, (CultureInfo)class34.t(object_11, (Type)(object)class35.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array3, (CultureInfo)(object)Class5.Default, array4, out *(object*)null), null), null, out *(object*)class2.t((BindingFlags)Class5.Default, array6, class2.e((BindingFlags)Class5.Default, null, null, null), (CultureInfo)(object)class2.t((BindingFlags)class2.e((BindingFlags)class2.W(bindingFlags, null, null, array2, array3), array5, (Type[])(object)Class5.Default, array3), null, obj, cultureInfo)));
				CultureInfo cultureInfo_3 = cultureInfo;
				Class7 class36 = class2;
				bindingFlags = default(BindingFlags);
				class13 = (Class6)(object)class31.j(bindingFlags_19, methodBase_9, ref object_12, null, cultureInfo_3, (string[])(object)class36.e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, null), out reference2);
			}
		}
		else
		{
			nuint num11 = num;
			num = default(UIntPtr);
			if (checked(num11 + num) == 0)
			{
				while (obj != null)
				{
					_ = (Class0)(object)Class5.Default;
				}
			}
		}
		Class7 class37 = class2;
		BindingFlags bindingFlags_21 = bindingFlags;
		MethodBase[] methodBase_11 = array5;
		Type[] type_9 = (Type[])(object)class2.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array2, array3);
		Class7 class38 = class2;
		bindingFlags = default(BindingFlags);
		if (checked(unchecked((nuint)(UIntPtr)((Class7)(object)class37.e(bindingFlags_21, methodBase_11, type_9, (ParameterModifier[])(object)class38.e(bindingFlags, array5, null, null))).W(bindingFlags, array, (Type)(object)Class5.Default, array2, array3)) - num) == 0)
		{
			try
			{
				try
				{
					@class = @class;
					Class7 class39 = class2;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_22 = bindingFlags;
					Class7 obj19 = (Class7)(object)Class5.Default;
					object object_13 = obj;
					Class7 obj20 = (Class7)(object)Class5.Default;
					object object_14 = Class5.Default;
					Class7 class40 = class2;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_23 = bindingFlags;
					MethodBase[] methodBase_12 = array5;
					Class7 obj21 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					class11 = (Class0)((Class7)(object)class39.e(bindingFlags_22, null, null, (ParameterModifier[])obj19.t(object_13, null, (CultureInfo)obj20.t(object_14, (Type)(object)class40.j(bindingFlags_23, methodBase_12, ref *(object[]*)obj21.t(bindingFlags, array6, null, cultureInfo), array3, cultureInfo, (string[])(object)Class5.Default, out reference2), null)))).t(obj, (Type)(object)Class5.Default, cultureInfo);
					gClass2 = null;
					_ = (Class10)(object)Class5.Default;
				}
				catch
				{
					class4 = class4;
					class10 = class10;
				}
			}
			catch
			{
				while (true)
				{
					Class7 obj23 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					if ((object)obj23.t(bindingFlags, null, obj, (CultureInfo)(object)Class5.Default) != null)
					{
						Class7 obj24 = (Class7)(object)Class5.Default;
						Class7 class41 = class2;
						bindingFlags = default(BindingFlags);
						_003CModule_003E = (_003CModule_003E)(object)((Class7)(object)obj24.t((BindingFlags)class41.j(bindingFlags, array5, ref reference, null, cultureInfo, (string[])(object)class2.j((BindingFlags)Class5.Default, array5, ref reference, array3, cultureInfo, null, out reference2), out reference2), null, null, (CultureInfo)(object)class2.e(bindingFlags, array5, null, array3))).t(default(BindingFlags), null, null, cultureInfo);
						continue;
					}
					break;
				}
			}
		}
		while (obj != null)
		{
			if ((UIntPtr)((Class7)null).e(bindingFlags, array5, array2, (ParameterModifier[])(object)Class5.Default) == (UIntPtr)(nuint)0u)
			{
				qk = qk;
				_ = (Qk7)(object)class2.j(bindingFlags, (MethodBase[])(object)class2.j(bindingFlags, null, ref *(object[]*)null, array3, (CultureInfo)(object)class2.W(bindingFlags, array, null, array2, (ParameterModifier[])(object)Class5.Default), (string[])(object)((Class7)(object)Class5.Default).e((BindingFlags)class2.W(bindingFlags, (PropertyInfo[])((Class7)null).t(obj, (Type)(object)Class5.Default, cultureInfo), type, array2, array3), array5, (Type[])(object)Class5.Default, array3), out *(object*)class2.t(null, type, (CultureInfo)(object)Class5.Default)), ref reference, null, cultureInfo, null, out *(object*)null);
				_ = (Class9)(object)Class5.Default;
			}
		}
		Class7 class42 = class2;
		BindingFlags bindingFlags_24 = bindingFlags;
		MethodBase[] methodBase_13 = array5;
		bindingFlags = default(BindingFlags);
		_ = (Class9)((Class7)(object)class42.e(bindingFlags_24, methodBase_13, null, (ParameterModifier[])(object)((Class7)null).W(bindingFlags, array, type, array2, (ParameterModifier[])null))).t(obj, (Type)(object)Class5.Default, cultureInfo);
		if (num == 0)
		{
			try
			{
				try
				{
					Class7 class43 = class2;
					bindingFlags = default(BindingFlags);
					gClass3 = (GClass1)(object)class43.t(bindingFlags, null, null, cultureInfo);
					@class = (Class4)(object)Class5.Default;
					_ = Class5.Default;
				}
				finally
				{
					_ = (Class4)class2.t(obj, type, cultureInfo);
					class4 = (Class8)(object)Class5.Default;
					goto end_IL_362b;
				}
				end_IL_362b:;
			}
			catch
			{
				_ = (Class2)(object)Class5.Default;
			}
		}
		if (checked(num * num) == 0)
		{
			@struct = @struct;
		}
		else
		{
			while (obj != null)
			{
				gClass4 = null;
				_ = (GClass1)(object)Class5.Default;
			}
		}
		try
		{
			try
			{
			}
			finally
			{
				if (checked(num - num) == 0)
				{
					_ = (Class0)(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, (object)null, cultureInfo);
				}
				else
				{
					gClass = null;
				}
				goto end_IL_36d4;
			}
			end_IL_36d4:;
		}
		finally
		{
			do
			{
				num = default(UIntPtr);
				if (num == (UIntPtr)(nuint)0u)
				{
					_ = (GClass0)(object)Class5.Default;
				}
			}
			while (obj != null);
			goto IL_3738;
		}
		IL_2b4a:
		class13 = (Class6)(object)class2.e(default(BindingFlags), array5, array2, array3);
		_ = (Class4)(object)Class5.Default;
		_003CModule_003E = _003CModule_003E;
		Class7 obj27 = (Class7)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		class2 = (Class7)((Class7)(object)obj27.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, array2, (ParameterModifier[])(object)((Class7)null).e(bindingFlags, array5, array2, array3))).t(null, (Type)(object)Class5.Default, cultureInfo);
		try
		{
			UIntPtr num12 = (UIntPtr)class2.e(bindingFlags, null, (Type[])(object)Class5.Default, array3);
			Class7 class44 = class2;
			BindingFlags bindingFlags_25 = bindingFlags;
			MethodBase[] methodBase_14 = array5;
			ref object[] object_15 = ref reference;
			ParameterModifier[] parameterModifier_5 = array3;
			bindingFlags = default(BindingFlags);
			checked
			{
				if (unchecked((nuint)num12) - (unchecked((nuint)(UIntPtr)class44.j(bindingFlags_25, methodBase_14, ref object_15, parameterModifier_5, (CultureInfo)(object)((Class7)(object)((Class7)null).t(bindingFlags, array6, obj, (CultureInfo)null)).e((BindingFlags)Class5.Default, null, null, array3), array4, out *(object*)Class5.Default)) - unchecked((nuint)(UIntPtr)Class5.Default / num)) == 0)
				{
					try
					{
						class12 = null;
					}
					catch
					{
						_ = (Class7)(object)Class5.Default;
						_003CModule_003E = _003CModule_003E;
					}
				}
			}
		}
		finally
		{
			class10 = class10;
			goto IL_2cc2;
		}
		IL_4c78:
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			while ((object)Class5.Default != null)
			{
				if ((UIntPtr)((Class7)(object)Class5.Default).t(obj, type, null) == (UIntPtr)(nuint)0u)
				{
					Class7 class45 = class2;
					BindingFlags bindingFlags_26 = bindingFlags;
					Class7 class46 = class2;
					FieldInfo[] fieldInfo_ = (FieldInfo[])(object)Class5.Default;
					object object_16 = obj;
					Class7 class47 = class2;
					bindingFlags = default(BindingFlags);
					_ = (GClass3)(object)class45.t((BindingFlags)((Class7)null).j(bindingFlags_26, (MethodBase[])(object)class46.t(default(BindingFlags), fieldInfo_, object_16, (CultureInfo)(object)class47.j(bindingFlags, array5, ref reference, array3, (CultureInfo)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)null, (ParameterModifier[])null, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out *(object*)null), array4, out reference2)), ref reference, array3, (CultureInfo)(object)Class5.Default, (string[])null, out reference2), array6, Class5.Default, cultureInfo);
				}
			}
		}
		else if (num == (UIntPtr)(nuint)0u)
		{
			do
			{
				_ = (Class8)(object)class2.W(bindingFlags, array, (Type)(object)Class5.Default, array2, array3);
			}
			while (obj != null);
		}
		num = default(UIntPtr);
		if (num == 0 && (UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			class10 = class10;
		}
		class21 = class21;
		try
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				do
				{
					gClass4 = null;
				}
				while ((object)Class5.Default != null);
			}
		}
		finally
		{
			Class7 class48 = class2;
			BindingFlags bindingFlags_27 = bindingFlags;
			MethodBase[] methodBase_15 = (MethodBase[])(object)class2.j(bindingFlags, array5, ref reference, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)class2.W(default(BindingFlags), array, null, array2, array3), array4, out reference2);
			ref object[] object_17 = ref reference;
			ParameterModifier[] parameterModifier_6 = array3;
			Class7 class49 = class2;
			bindingFlags = default(BindingFlags);
			Class7 obj29 = (Class7)(object)class49.t(bindingFlags, array6, class2.e(bindingFlags, (MethodBase[])(object)((Class7)(object)((Class7)null).j((BindingFlags)class2.t(obj, type, cultureInfo), (MethodBase[])null, ref *(object[]*)Class5.Default, array3, (CultureInfo)null, (string[])null, out *(object*)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)null, cultureInfo))).t(bindingFlags, array6, Class5.Default, null), array2, array3), null);
			bindingFlags = default(BindingFlags);
			_ = (_003CModule_003E)(object)class48.j(bindingFlags_27, methodBase_15, ref object_17, parameterModifier_6, (CultureInfo)(object)obj29.t(bindingFlags, null, Class5.Default, cultureInfo), (string[])(object)Class5.Default, out reference2);
			class4 = class4;
			_ = (Struct1)class2.t(bindingFlags, array6, Class5.Default, cultureInfo);
			goto IL_4f85;
		}
		IL_3738:
		if (num == (UIntPtr)(nuint)0u)
		{
			while ((object)Class5.Default != null)
			{
				Class7 obj30 = (Class7)(object)class2.t(default(BindingFlags), null, obj, cultureInfo);
				BindingFlags bindingFlags_28 = (BindingFlags)Class5.Default;
				Class7 class50 = class2;
				bindingFlags = default(BindingFlags);
				_ = (Class6)(object)obj30.e(bindingFlags_28, null, (Type[])(object)class50.e(bindingFlags, null, array2, array3), (ParameterModifier[])class2.t(null, type, (CultureInfo)(object)Class5.Default));
				class2 = class2;
				class13 = (Class6)(object)Class5.Default;
			}
		}
		while (obj != null)
		{
			while (obj != null)
			{
				while (obj != null)
				{
					_ = (Qk7)(object)Class5.Default;
					_ = (_003CModule_003E)(object)Class5.Default;
				}
			}
		}
		while ((object)Class5.Default != null)
		{
			try
			{
				try
				{
					_ = (GClass2)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)class2.j((BindingFlags)Class5.Default, null, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, null, out *(object*)Class5.Default), (Type[])null, array3);
				}
				finally
				{
					_ = (_003CModule_003E)(object)class2.j((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, array3, cultureInfo, array4, out reference2);
					class13 = null;
					_ = (_003CModule_003E)(object)class2.e(bindingFlags, array5, null, null);
					_003CModule_003E = _003CModule_003E;
					goto end_IL_3818;
				}
				end_IL_3818:;
			}
			finally
			{
				try
				{
					Class7 class51 = class2;
					bindingFlags = default(BindingFlags);
					class4 = (Class8)(object)class51.t(bindingFlags, null, obj, null);
				}
				catch
				{
					bindingFlags = default(BindingFlags);
					gClass3 = (GClass1)(object)((Class7)null).t(bindingFlags, array6, obj, (CultureInfo)null);
					_ = (_003CModule_003E)(object)Class5.Default;
					gClass4 = gClass4;
				}
				continue;
			}
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = (GClass1)(object)class2.j(bindingFlags, array5, ref reference, array3, null, array4, out reference2);
		}
		else
		{
			try
			{
				while ((object)((Class7)null).t((BindingFlags)((Class7)(object)Class5.Default).j(bindingFlags, (MethodBase[])(object)((Class7)null).t((BindingFlags)class2.t(null, null, cultureInfo), array6, (object)null, cultureInfo), ref *(object[]*)class2.t(bindingFlags, array6, obj, cultureInfo), array3, null, null, out *(object*)((Class7)null).j(bindingFlags, array5, ref reference, (ParameterModifier[])null, (CultureInfo)null, (string[])null, out *(object*)null)), (FieldInfo[])null, obj, cultureInfo) != null)
				{
					qk = qk;
				}
			}
			catch
			{
				try
				{
					class14 = class14;
					_ = (Class10)(object)Class5.Default;
				}
				catch
				{
					class21 = class21;
				}
			}
		}
		UIntPtr num13 = (UIntPtr)Class5.Default;
		num = default(UIntPtr);
		checked
		{
			if (unchecked((nuint)num13) + num == 0)
			{
				while (obj != null)
				{
					try
					{
						_003CModule_003E = _003CModule_003E;
					}
					finally
					{
						_ = (GClass0)(object)((Class7)null).W(bindingFlags, array, type, array2, array3);
						continue;
					}
				}
			}
		}
		try
		{
			try
			{
				do
				{
					Class7 class52 = class2;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_29 = bindingFlags;
					MethodBase[] methodBase_16 = array5;
					Class7 obj34 = (Class7)((Class7)(object)class2.t((BindingFlags)Class5.Default, (FieldInfo[])(object)class2.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, (CultureInfo)(object)Class5.Default), ((Class7)(object)Class5.Default).W(bindingFlags, null, null, (Type[])(object)Class5.Default, array3), null)).t(null, (Type)(object)Class5.Default, null);
					bindingFlags = default(BindingFlags);
					class13 = (Class6)(object)class52.j(bindingFlags_29, methodBase_16, ref *(object[]*)obj34.e(bindingFlags, array5, (Type[])(object)class2.W((BindingFlags)Class5.Default, (PropertyInfo[])(object)Class5.Default, type, array2, (ParameterModifier[])(object)Class5.Default), (ParameterModifier[])(object)Class5.Default), null, cultureInfo, array4, out reference2);
				}
				while ((object)Class5.Default != null);
			}
			finally
			{
				Class7 class53 = class2;
				BindingFlags bindingFlags_30 = bindingFlags;
				MethodBase[] methodBase_17 = array5;
				BindingFlags bindingFlags_31 = bindingFlags;
				Class7 obj35 = (Class7)(object)((Class7)(object)((Class7)null).W(bindingFlags, array, type, array2, (ParameterModifier[])(object)Class5.Default)).W(bindingFlags, null, type, null, array3);
				Class7 obj36 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_32 = bindingFlags;
				MethodBase[] methodBase_18 = (MethodBase[])(object)Class5.Default;
				Class7 class54 = class2;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_33 = bindingFlags;
				PropertyInfo[] propertyInfo_6 = array;
				Type type_10 = (Type)(object)Class5.Default;
				Class7 class55 = class2;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_34 = (BindingFlags)obj36.e(bindingFlags_32, methodBase_18, (Type[])(object)class54.W(bindingFlags_33, propertyInfo_6, type_10, null, (ParameterModifier[])(object)class55.e(bindingFlags, array5, array2, (ParameterModifier[])(object)((Class7)((Class7)(object)Class5.Default).t(obj, type, cultureInfo)).e(bindingFlags, array5, null, array3))), array3);
				Class7 class56 = class2;
				BindingFlags bindingFlags_35 = bindingFlags;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_36 = bindingFlags;
				Class7 class57 = class2;
				Class7 class58 = class2;
				bindingFlags = default(BindingFlags);
				ref object[] object_18 = ref *(object[]*)((Class7)null).t(bindingFlags_31, (FieldInfo[])(object)obj35.W(bindingFlags_34, (PropertyInfo[])(object)class56.j(bindingFlags_35, (MethodBase[])(object)((Class7)null).t(bindingFlags_36, (FieldInfo[])class57.t(class58.t(bindingFlags, array6, obj, null), null, cultureInfo), (object)Class5.Default, cultureInfo), ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, null, array4, out reference2), (Type)(object)Class5.Default, null, array3), obj, cultureInfo);
				Class7 obj37 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				_ = (Struct1)((Class7)(object)class53.j(bindingFlags_30, methodBase_17, ref object_18, (ParameterModifier[])(object)obj37.t(bindingFlags, null, obj, null), (CultureInfo)(object)Class5.Default, array4, out *(object*)null)).W((BindingFlags)Class5.Default, null, null, array2, (ParameterModifier[])((Class7)null).t((object)Class5.Default, type, cultureInfo));
				goto end_IL_3a9a;
			}
			end_IL_3a9a:;
		}
		catch
		{
			try
			{
				_ = (Class0)(object)Class5.Default;
			}
			finally
			{
				do
				{
					_ = (Class9)((Class7)null).t((object)null, type, (CultureInfo)(object)Class5.Default);
				}
				while (obj != null);
				goto end_IL_3de6;
			}
			end_IL_3de6:;
		}
		do
		{
			try
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					gClass4 = gClass4;
				}
			}
			catch
			{
				num = default(UIntPtr);
				if (checked(num + num) == 0)
				{
					class4 = class4;
					continue;
				}
				BindingFlags bindingFlags_37 = (BindingFlags)((Class7)(object)Class5.Default).t(default(BindingFlags), null, obj, cultureInfo);
				Class7 class59 = class2;
				PropertyInfo[] propertyInfo_7 = array;
				Type type_11 = type;
				Type[] type_12 = array2;
				bindingFlags = default(BindingFlags);
				gClass = (GClass2)(object)((Class7)null).t(bindingFlags_37, (FieldInfo[])(object)class59.W(default(BindingFlags), propertyInfo_7, type_11, type_12, (ParameterModifier[])(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])null, (ParameterModifier[])null)), obj, (CultureInfo)null);
			}
		}
		while ((object)class2.W(bindingFlags, null, null, null, (ParameterModifier[])(object)class2.t(bindingFlags, null, obj, cultureInfo)) != null);
		Class7 class60 = class2;
		bindingFlags = default(BindingFlags);
		_ = (Struct1)class60.t(bindingFlags, (FieldInfo[])(object)Class5.Default, class2.j((BindingFlags)Class5.Default, array5, ref *(object[]*)null, array3, cultureInfo, array4, out reference2), cultureInfo);
		do
		{
			if (num == 0)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					class14 = class14;
					continue;
				}
				Class7 class61 = class2;
				Class7 class62 = class2;
				BindingFlags bindingFlags_38 = bindingFlags;
				Class7 obj40 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_39 = bindingFlags;
				Type type_13 = type;
				Type[] type_14 = array2;
				BindingFlags bindingFlags_40 = (BindingFlags)class2.j((BindingFlags)class2.j(bindingFlags, (MethodBase[])(object)((Class7)null).e(bindingFlags, array5, array2, array3), ref *(object[]*)null, array3, cultureInfo, null, out *(object*)null), (MethodBase[])(object)((Class7)(object)((Class7)(object)Class5.Default).t(bindingFlags, array6, obj, (CultureInfo)(object)Class5.Default)).j(bindingFlags, array5, ref *(object[]*)null, array3, null, null, out *(object*)null), ref *(object[]*)null, array3, (CultureInfo)(object)((Class7)null).W(default(BindingFlags), array, (Type)null, (Type[])null, array3), array4, out reference2);
				MethodBase[] methodBase_19 = (MethodBase[])(object)Class5.Default;
				Class7 obj41 = (Class7)(object)((Class7)null).e(default(BindingFlags), array5, (Type[])null, array3);
				Class7 obj42 = (Class7)(object)class2.t(default(BindingFlags), null, obj, cultureInfo);
				bindingFlags = default(BindingFlags);
				ref object[] object_19 = ref *(object[]*)obj41.j((BindingFlags)obj42.e(bindingFlags, null, null, (ParameterModifier[])(object)Class5.Default), array5, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, array4, out reference2);
				string[] string_3 = array4;
				Class7 obj43 = (Class7)class2.t(obj, type, cultureInfo);
				Class7 obj44 = (Class7)(object)class2.t(bindingFlags, null, null, null);
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_41 = bindingFlags;
				Class7 class63 = class2;
				BindingFlags bindingFlags_42 = bindingFlags;
				FieldInfo[] fieldInfo_2 = array6;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_43 = (BindingFlags)obj44.W(bindingFlags_41, (PropertyInfo[])(object)class63.t(bindingFlags_42, fieldInfo_2, ((Class7)null).W(bindingFlags, array, type, (Type[])(object)class2.W(bindingFlags, array, null, array2, array3), array3), (CultureInfo)(object)((Class7)(object)Class5.Default).W(bindingFlags, array, type, array2, array3)), (Type)(object)Class5.Default, null, array3);
				PropertyInfo[] propertyInfo_8 = array;
				Class7 obj45 = (Class7)(object)class2.j(bindingFlags, null, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, array4, out *(object*)class2.e(bindingFlags, array5, null, (ParameterModifier[])(object)class2.W(bindingFlags, array, type, array2, array3)));
				BindingFlags bindingFlags_44 = bindingFlags;
				MethodBase[] methodBase_20 = array5;
				Class7 class64 = class2;
				BindingFlags bindingFlags_45 = bindingFlags;
				FieldInfo[] fieldInfo_3 = array6;
				object object_20 = obj;
				bindingFlags = default(BindingFlags);
				PropertyInfo[] propertyInfo_9 = (PropertyInfo[])(object)obj40.W(bindingFlags_39, null, type_13, type_14, (ParameterModifier[])(object)((Class7)null).j(bindingFlags_40, methodBase_19, ref object_19, (ParameterModifier[])null, (CultureInfo)null, string_3, out *(object*)obj43.W(bindingFlags_43, propertyInfo_8, (Type)(object)obj45.e(bindingFlags_44, methodBase_20, (Type[])class64.t(((Class7)null).t(bindingFlags_45, fieldInfo_3, object_20, (CultureInfo)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)null, cultureInfo)), null, null), array3), array2, (ParameterModifier[])(object)((Class7)null).e(bindingFlags, (MethodBase[])null, array2, (ParameterModifier[])null))));
				Type type_15 = type;
				Class7 class65 = class2;
				Class7 class66 = class2;
				FieldInfo[] fieldInfo_4 = array6;
				Class7 class67 = class2;
				Class7 class68 = class2;
				bindingFlags = default(BindingFlags);
				_ = (GClass0)(object)class61.W((BindingFlags)class62.W(bindingFlags_38, propertyInfo_9, type_15, (Type[])(object)((Class7)null).j((BindingFlags)((Class7)(object)((Class7)(object)class65.t(default(BindingFlags), (FieldInfo[])(object)class66.t(default(BindingFlags), fieldInfo_4, class67.t(null, (Type)(object)class68.W(bindingFlags, array, type, array2, null), cultureInfo), null), obj, (CultureInfo)(object)((Class7)(object)Class5.Default).t(bindingFlags, array6, obj, cultureInfo))).e(bindingFlags, null, array2, array3)).j((BindingFlags)class2.j(bindingFlags, array5, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo, array4, out reference2), (MethodBase[])(object)class2.W(bindingFlags, array, type, array2, array3), ref *(object[]*)null, array3, cultureInfo, array4, out *(object*)Class5.Default), array5, ref *(object[]*)class2.t(bindingFlags, null, null, cultureInfo), (ParameterModifier[])null, (CultureInfo)(object)Class5.Default, (string[])((Class7)null).t((object)((Class7)null).j(bindingFlags, array5, ref reference, (ParameterModifier[])null, (CultureInfo)(object)class2.e(bindingFlags, null, array2, array3), array4, out reference2), type, (CultureInfo)null), out *(object*)Class5.Default), null), null, (Type)(object)Class5.Default, null, (ParameterModifier[])(object)Class5.Default);
			}
		}
		while (obj != null);
		while (obj != null)
		{
			_ = (GClass1)(object)Class5.Default;
			class11 = class11;
		}
		try
		{
			while (true)
			{
				Class7 class69 = class2;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_46 = bindingFlags;
				MethodBase[] methodBase_21 = array5;
				ref object[] object_21 = ref reference;
				CultureInfo cultureInfo_4 = cultureInfo;
				Class7 class70 = class2;
				BindingFlags bindingFlags_47 = bindingFlags;
				PropertyInfo[] propertyInfo_10 = (PropertyInfo[])(object)Class5.Default;
				Type type_16 = type;
				Type[] type_17 = array2;
				Class7 class71 = class2;
				bindingFlags = default(BindingFlags);
				if ((object)class69.j(bindingFlags_46, methodBase_21, ref object_21, null, cultureInfo_4, (string[])(object)class70.W(bindingFlags_47, propertyInfo_10, type_16, type_17, (ParameterModifier[])(object)class71.e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, array3)), out *(object*)null) != null)
				{
					try
					{
						_ = (Class4)class2.t(obj, null, (CultureInfo)(object)class2.j((BindingFlags)Class5.Default, null, ref *(object[]*)null, array3, (CultureInfo)(object)Class5.Default, array4, out *(object*)class2.t(obj, type, null)));
					}
					finally
					{
						Class7 class72 = class2;
						Class7 class73 = class2;
						bindingFlags = default(BindingFlags);
						_ = (Class0)(object)class72.W((BindingFlags)class73.e(bindingFlags, array5, null, null), null, type, null, (ParameterModifier[])class2.t(null, (Type)(object)class2.j(bindingFlags, null, ref *(object[]*)null, null, (CultureInfo)(object)class2.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)(object)class2.W(bindingFlags, array, type, null, null), array2, (ParameterModifier[])(object)class2.e((BindingFlags)Class5.Default, array5, array2, null)), array4, out reference2), cultureInfo));
						continue;
					}
				}
				break;
			}
		}
		catch
		{
			checked
			{
				if (unchecked((nuint)(UIntPtr)class2.e(bindingFlags, array5, null, array3)) - num == 0)
				{
					do
					{
						gClass4 = (GClass0)(object)Class5.Default;
					}
					while (obj != null);
				}
				else
				{
					_ = (Class2)(object)Class5.Default;
				}
			}
		}
		if (num == 0)
		{
			try
			{
				do
				{
					_ = (_003CModule_003E)(object)Class5.Default;
					_ = (_003CModule_003E)(object)((Class7)class2.t(obj, null, null)).j((BindingFlags)((Class7)null).t((object)null, (Type)null, (CultureInfo)null), array5, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, null, out reference2);
					class11 = class11;
					class12 = class12;
				}
				while ((object)((Class7)(object)((Class7)(object)Class5.Default).W(default(BindingFlags), (PropertyInfo[])class2.t(Class5.Default, null, (CultureInfo)(object)Class5.Default), null, (Type[])(object)((Class7)(object)Class5.Default).j((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, ref reference, array3, cultureInfo, array4, out *(object*)class2.t(obj, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default)), null)).t(default(BindingFlags), array6, null, cultureInfo) != null);
			}
			catch
			{
				_ = (Class7)(object)Class5.Default;
			}
		}
		else
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				_ = (GClass2)(object)Class5.Default;
			}
		}
		Class7 class74 = class2;
		bindingFlags = default(BindingFlags);
		_ = (Qk7)(object)class74.W(bindingFlags, array, type, array2, array3);
		_ = (GClass2)(object)Class5.Default;
		class14 = class14;
		_ = (Class10)(object)Class5.Default;
		_ = (Struct1)Class5.Default;
		if (checked(unchecked((nuint)(UIntPtr)((Class7)(object)Class5.Default).W(bindingFlags, null, null, null, null)) - num) == 0 && (UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			struct2 = struct2;
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
				class11 = class11;
			}
			finally
			{
				while (true)
				{
					bindingFlags = default(BindingFlags);
					if ((object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])null, obj, cultureInfo), (Type)null, array2, (ParameterModifier[])null) != null)
					{
						_ = (GClass3)(object)((Class7)(object)((Class7)(object)class2.W((BindingFlags)Class5.Default, (PropertyInfo[])(object)Class5.Default, type, null, array3)).t((BindingFlags)Class5.Default, array6, obj, null)).j(bindingFlags, null, ref reference, null, (CultureInfo)(object)Class5.Default, (string[])class2.t(class2.t(default(BindingFlags), null, obj, cultureInfo), type, null), out *(object*)((Class7)null).t(obj, type, cultureInfo));
						continue;
					}
					break;
				}
				goto end_IL_48fa;
			}
			end_IL_48fa:;
		}
		try
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				nuint num14 = num;
				num = default(UIntPtr);
				if (num14 / num == 0)
				{
					_003CModule_003E = _003CModule_003E;
				}
			}
		}
		finally
		{
			if (checked(unchecked((nuint)(UIntPtr)Class5.Default) * num) == 0)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					Class7 obj50 = (Class7)(object)((Class7)(object)Class5.Default).j((BindingFlags)Class5.Default, array5, ref reference, (ParameterModifier[])(object)class2.j(bindingFlags, array5, ref reference, null, (CultureInfo)(object)Class5.Default, array4, out reference2), (CultureInfo)(object)class2.e(bindingFlags, array5, array2, (ParameterModifier[])(object)Class5.Default), array4, out reference2);
					bindingFlags = default(BindingFlags);
					qk = (Qk7)(object)obj50.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array2, (ParameterModifier[])(object)class2.W((BindingFlags)class2.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)((Class7)null).t(obj, (Type)null, cultureInfo), array3, null, array4, out reference2), array, null, array2, array3));
					_ = (Class10)(object)Class5.Default;
					_ = (_003CModule_003E)(object)Class5.Default;
				}
			}
			else
			{
				while ((object)Class5.Default != null)
				{
					_ = (GClass0)(object)Class5.Default;
				}
			}
			goto IL_4bab;
		}
		IL_4bab:
		_ = (Struct1)Class5.Default;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			qk = null;
		}
		if (checked(unchecked(unchecked((nuint)default(UIntPtr)) / (nuint)(UIntPtr)Class5.Default) - unchecked((nuint)(UIntPtr)Class5.Default) + unchecked((nuint)default(UIntPtr))) == 0)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					qk = qk;
				}
				finally
				{
					class10 = class10;
					goto IL_4c78;
				}
			}
			try
			{
				_ = (Class10)(object)Class5.Default;
			}
			catch
			{
				_ = (Class2)(object)Class5.Default;
			}
		}
		else
		{
			while ((object)Class5.Default != null)
			{
				bindingFlags = default(BindingFlags);
				if ((UIntPtr)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, cultureInfo) == (UIntPtr)(nuint)0u)
				{
					class14 = class14;
				}
			}
		}
		goto IL_4c78;
		IL_12bd:
		Class7 obj53;
		Class7 class75;
		do
		{
			try
			{
				class13 = class13;
				class13 = class13;
			}
			catch
			{
				class4 = class4;
			}
			obj53 = (Class7)(object)((Class7)null).e((BindingFlags)Class5.Default, (MethodBase[])null, (Type[])null, array3);
			class75 = class2;
			bindingFlags = default(BindingFlags);
		}
		while (obj53.t(class75.t(bindingFlags, null, obj, cultureInfo), type, null) != null || obj != null);
		class10 = (Class9)(object)Class5.Default;
		_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
		_ = (GClass0)class2.t(null, type, (CultureInfo)(object)Class5.Default);
		class4 = class4;
		try
		{
			_ = (Qk7)(object)Class5.Default;
		}
		finally
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				UIntPtr num15 = (UIntPtr)class2.e(bindingFlags, null, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
				num = default(UIntPtr);
				checked
				{
					if (unchecked((nuint)num15) - unchecked((nuint)default(UIntPtr)) * num == 0)
					{
						class14 = null;
						class14 = class14;
					}
					else
					{
						Class7 class76 = class2;
						bindingFlags = default(BindingFlags);
						_ = (Class4)(object)class76.j(bindingFlags, null, ref reference, null, cultureInfo, array4, out reference2);
					}
					goto IL_14a2;
				}
			}
			try
			{
				_ = (Struct2)Class5.Default;
				Class7 class77 = class2;
				bindingFlags = default(BindingFlags);
				class11 = (Class0)(object)class77.e(bindingFlags, array5, array2, null);
				_ = (Class9)(object)class2.W((BindingFlags)Class5.Default, array, type, (Type[])((Class7)null).t(obj, type, cultureInfo), array3);
			}
			finally
			{
				@class = @class;
				goto IL_14a2;
			}
		}
		IL_4f85:
		try
		{
			try
			{
				Class7 class78 = class2;
				bindingFlags = default(BindingFlags);
				_ = (Class2)(object)class78.W(bindingFlags, null, type, null, array3);
			}
			catch
			{
				Class7 class79 = class2;
				bindingFlags = default(BindingFlags);
				gClass4 = (GClass0)(object)class79.j(bindingFlags, null, ref reference, array3, null, array4, out reference2);
				_ = (Class0)(object)((Class7)null).j(bindingFlags, array5, ref *(object[]*)Class5.Default, array3, (CultureInfo)null, (string[])null, out *(object*)((Class7)null).W(bindingFlags, array, type, array2, (ParameterModifier[])null));
				_ = (Struct1)class2.W(bindingFlags, array, null, array2, array3);
			}
		}
		catch
		{
			BindingFlags bindingFlags_48 = bindingFlags;
			ref object[] object_22 = ref reference;
			ParameterModifier[] parameterModifier_7 = array3;
			CultureInfo cultureInfo_5 = (CultureInfo)(object)Class5.Default;
			string[] string_4 = array4;
			Class7 class80 = class2;
			BindingFlags bindingFlags_49 = bindingFlags;
			Class7 obj55 = (Class7)(object)class2.W((BindingFlags)Class5.Default, array, null, (Type[])class2.t(null, type, cultureInfo), null);
			bindingFlags = default(BindingFlags);
			_ = (Class2)(object)((Class7)(object)((Class7)null).j(bindingFlags_48, (MethodBase[])null, ref object_22, parameterModifier_7, cultureInfo_5, string_4, out *(object*)class80.e((BindingFlags)((Class7)null).W(bindingFlags_49, (PropertyInfo[])(object)obj55.e(bindingFlags, null, null, array3), (Type)null, (Type[])null, (ParameterModifier[])null), (MethodBase[])(object)Class5.Default, (Type[])(object)class2.W(bindingFlags, null, null, array2, null), null))).t((BindingFlags)((Class7)class2.t(Class5.Default, type, (CultureInfo)(object)Class5.Default)).e(bindingFlags, array5, (Type[])(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)((Class7)null).e(bindingFlags, array5, (Type[])null, array3), ref reference, array3, (CultureInfo)null, array4, out reference2), (ParameterModifier[])(object)Class5.Default), null, obj, cultureInfo);
		}
		finally
		{
			if ((UIntPtr)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, (object)class2.W(bindingFlags, null, type, array2, null), cultureInfo) == (UIntPtr)(nuint)0u)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (GClass3)(object)Class5.Default;
				}
				else
				{
					_ = (Class0)(object)Class5.Default;
				}
			}
			goto IL_5203;
		}
		IL_14a2:
		_ = (Class9)(object)Class5.Default;
		try
		{
			class21 = class21;
		}
		finally
		{
			if (num == 0)
			{
				if (num == 0)
				{
					Class7 class81 = class2;
					BindingFlags bindingFlags_50 = (BindingFlags)Class5.Default;
					MethodBase[] methodBase_22 = (MethodBase[])(object)Class5.Default;
					ParameterModifier[] parameterModifier_8 = array3;
					string[] string_5 = (string[])(object)Class5.Default;
					Class7 class82 = class2;
					BindingFlags bindingFlags_51 = (BindingFlags)Class5.Default;
					Class7 class83 = class2;
					BindingFlags bindingFlags_52 = bindingFlags;
					MethodBase[] methodBase_23 = array5;
					Class7 class84 = class2;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_53 = bindingFlags;
					Class7 class85 = class2;
					BindingFlags bindingFlags_54 = (BindingFlags)Class5.Default;
					FieldInfo[] fieldInfo_5 = (FieldInfo[])(object)Class5.Default;
					Class7 obj57 = (Class7)(object)((Class7)(object)Class5.Default).e(bindingFlags, array5, null, array3);
					Class7 class86 = class2;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_55 = bindingFlags;
					PropertyInfo[] propertyInfo_11 = (PropertyInfo[])(object)class2.t(bindingFlags, array6, obj, null);
					Type type_18 = (Type)(object)((Class7)(object)Class5.Default).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, null);
					Class7 obj58 = (Class7)(object)class2.j(default(BindingFlags), null, ref reference, null, cultureInfo, (string[])(object)Class5.Default, out *(object*)Class5.Default);
					bindingFlags = default(BindingFlags);
					_ = (Class4)(object)class81.j(bindingFlags_50, methodBase_22, ref *(object[]*)null, parameterModifier_8, null, string_5, out *(object*)class82.W(bindingFlags_51, (PropertyInfo[])(object)class83.j(bindingFlags_52, methodBase_23, ref *(object[]*)class84.e(bindingFlags_53, (MethodBase[])(object)class85.t(bindingFlags_54, fieldInfo_5, obj57.t((BindingFlags)class86.W(bindingFlags_55, propertyInfo_11, type_18, (Type[])(object)obj58.j(bindingFlags, null, ref *(object[]*)null, array3, null, array4, out *(object*)Class5.Default), array3), (FieldInfo[])class2.t(obj, (Type)(object)Class5.Default, null), obj, cultureInfo), null), (Type[])(object)Class5.Default, null), array3, cultureInfo, array4, out *(object*)null), type, (Type[])(object)class2.e(bindingFlags, (MethodBase[])(object)((Class7)(object)Class5.Default).t((BindingFlags)((Class7)(object)((Class7)(object)((Class7)null).t(bindingFlags, array6, (object)null, cultureInfo)).t(bindingFlags, null, obj, cultureInfo)).j((BindingFlags)Class5.Default, array5, ref *(object[]*)Class5.Default, array3, cultureInfo, array4, out *(object*)((Class7)(object)Class5.Default).t(obj, null, null)), array6, obj, null), null, null), null));
				}
			}
			else
			{
				_ = (Struct2)Class5.Default;
			}
			goto IL_1759;
		}
		IL_1759:
		try
		{
			while (obj != null)
			{
				while (obj != null)
				{
					Class7 class87 = class2;
					bindingFlags = default(BindingFlags);
					_ = (Class5)(object)class87.j(bindingFlags, array5, ref *(object[]*)class2.e((BindingFlags)Class5.Default, array5, null, array3), (ParameterModifier[])((Class7)null).t(obj, type, (CultureInfo)null), null, array4, out *(object*)null);
				}
			}
		}
		finally
		{
			while (obj != null)
			{
				while ((object)Class5.Default != null)
				{
					class12 = class12;
				}
			}
			goto IL_17e6;
		}
		IL_2814:
		try
		{
			num = default(UIntPtr);
			nuint num16 = num;
			num = default(UIntPtr);
			if (checked(num16 * num) == 0)
			{
				_ = Class5.Default;
			}
		}
		finally
		{
			struct2 = struct2;
			goto IL_284b;
		}
		IL_17e6:
		try
		{
			try
			{
				class4 = (Class8)(object)class2.e(bindingFlags, (MethodBase[])(object)class2.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, null, null), null, array3);
			}
			catch
			{
				Class7 obj59 = (Class7)class2.t(null, type, cultureInfo);
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_56 = bindingFlags;
				MethodBase[] methodBase_24 = array5;
				Class7 class88 = class2;
				BindingFlags bindingFlags_57 = bindingFlags;
				MethodBase[] methodBase_25 = array5;
				Class7 class89 = class2;
				bindingFlags = default(BindingFlags);
				ref object[] object_23 = ref *(object[]*)class88.j(bindingFlags_57, methodBase_25, ref *(object[]*)class89.t(bindingFlags, array6, obj, cultureInfo), null, null, array4, out *(object*)Class5.Default);
				CultureInfo cultureInfo_6 = (CultureInfo)((Class7)(object)class2.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)(object)Class5.Default, array2, (ParameterModifier[])(object)class2.e(bindingFlags, array5, null, (ParameterModifier[])(object)class2.e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, (ParameterModifier[])(object)Class5.Default)))).t(obj, null, cultureInfo);
				Class7 class90 = class2;
				bindingFlags = default(BindingFlags);
				@class = (Class4)(object)obj59.j(bindingFlags_56, methodBase_24, ref object_23, null, cultureInfo_6, (string[])(object)class90.t(bindingFlags, null, obj, null), out reference2);
			}
			finally
			{
				try
				{
					_ = (Class4)(object)((Class7)null).j(bindingFlags, array5, ref reference, array3, (CultureInfo)(object)Class5.Default, array4, out reference2);
				}
				catch
				{
					_ = (Class7)(object)((Class7)null).e(bindingFlags, array5, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
				}
				goto end_IL_17e7;
			}
			end_IL_17e7:;
		}
		finally
		{
			try
			{
				try
				{
					gClass2 = null;
					Class7 class91 = class2;
					bindingFlags = default(BindingFlags);
					_ = (GClass2)((Class7)(object)((Class7)(object)class91.e(bindingFlags, null, array2, (ParameterModifier[])(object)Class5.Default)).W(bindingFlags, array, (Type)(object)Class5.Default, (Type[])(object)class2.W(bindingFlags, array, (Type)(object)Class5.Default, null, array3), array3)).t(Class5.Default, type, cultureInfo);
				}
				catch
				{
					_ = (Class6)(object)Class5.Default;
				}
			}
			catch
			{
				struct2 = (Struct1)Class5.Default;
				_ = (Qk7)(object)class2.e((BindingFlags)class2.j(default(BindingFlags), (MethodBase[])(object)class2.e(default(BindingFlags), array5, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default), ref reference, array3, cultureInfo, null, out *(object*)Class5.Default), array5, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
				_ = (Struct1)Class5.Default;
			}
			goto IL_1b12;
		}
		IL_1b12:
		try
		{
			try
			{
				class14 = class14;
			}
			finally
			{
				if (num == 0)
				{
					_ = (GClass0)(object)Class5.Default;
				}
				else
				{
					class13 = null;
					_ = (Class10)(object)Class5.Default;
				}
				goto end_IL_1b13;
			}
			end_IL_1b13:;
		}
		finally
		{
			if ((UIntPtr)class2.j(default(BindingFlags), array5, ref reference, array3, (CultureInfo)(object)Class5.Default, null, out *(object*)null) == (UIntPtr)(nuint)0u)
			{
				_ = (Class2)(object)Class5.Default;
			}
			goto IL_1b88;
		}
		IL_5203:
		_ = (Class6)(object)class2.e((BindingFlags)Class5.Default, null, (Type[])(object)Class5.Default, (ParameterModifier[])(object)((Class7)(object)Class5.Default).t((BindingFlags)class2.j(bindingFlags, null, ref *(object[]*)null, (ParameterModifier[])(object)((Class7)(object)class2.e(bindingFlags, array5, array2, array3)).e(default(BindingFlags), null, array2, array3), cultureInfo, (string[])(object)Class5.Default, out reference2), array6, Class5.Default, null));
		Class7 class92 = class2;
		bindingFlags = default(BindingFlags);
		_ = (Struct1)class92.e(bindingFlags, null, array2, array3);
		gClass4 = (GClass0)(object)class2.t(bindingFlags, null, null, null);
		qk = null;
		if (num / num == 0)
		{
			try
			{
				if ((UIntPtr)((Class7)null).e((BindingFlags)Class5.Default, (MethodBase[])null, array2, array3) == (UIntPtr)(nuint)0u)
				{
					class11 = class11;
				}
			}
			catch
			{
				_ = (Class0)(object)class2.t(bindingFlags, (FieldInfo[])(object)class2.t(bindingFlags, array6, null, cultureInfo), Class5.Default, (CultureInfo)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])(object)Class5.Default, (ParameterModifier[])null));
			}
		}
		else
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				Class7 class93 = class2;
				bindingFlags = default(BindingFlags);
				if ((UIntPtr)class93.e(bindingFlags, array5, null, array3) == (UIntPtr)(nuint)0u)
				{
					_ = Class5.Default;
				}
			}
		}
		class11 = class11;
		Class7 class94 = class2;
		BindingFlags bindingFlags_58 = bindingFlags;
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_59 = bindingFlags;
		PropertyInfo[] propertyInfo_12 = array;
		Type type_19 = (Type)(object)Class5.Default;
		Type[] type_20 = array2;
		Class7 class95 = class2;
		BindingFlags bindingFlags_60 = (BindingFlags)Class5.Default;
		PropertyInfo[] propertyInfo_13 = array;
		BindingFlags bindingFlags_61 = (BindingFlags)((Class7)(object)class2.t((BindingFlags)class2.t(bindingFlags, (FieldInfo[])(object)((Class7)(object)class2.j((BindingFlags)Class5.Default, null, ref *(object[]*)null, array3, cultureInfo, (string[])(object)Class5.Default, out reference2)).e(bindingFlags, array5, (Type[])(object)Class5.Default, array3), null, null), array6, obj, cultureInfo)).e((BindingFlags)((Class7)null).W(bindingFlags, (PropertyInfo[])((Class7)null).t((object)null, (Type)(object)Class5.Default, cultureInfo), type, (Type[])null, array3), (MethodBase[])(object)Class5.Default, array2, array3);
		MethodBase[] methodBase_26 = array5;
		ParameterModifier[] parameterModifier_9 = array3;
		Class7 obj65 = (Class7)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		_ = (GClass0)(object)((Class7)null).W((BindingFlags)class94.W(bindingFlags_58, (PropertyInfo[])(object)((Class7)null).W(bindingFlags_59, propertyInfo_12, type_19, type_20, (ParameterModifier[])(object)class95.W(bindingFlags_60, propertyInfo_13, (Type)(object)((Class7)null).j(bindingFlags_61, methodBase_26, ref *(object[]*)null, parameterModifier_9, (CultureInfo)(object)obj65.e(bindingFlags, array5, array2, null), (string[])(object)Class5.Default, out reference2), null, array3)), type, null, array3), array, type, (Type[])null, (ParameterModifier[])(object)Class5.Default);
		@class = @class;
		try
		{
			if (checked(unchecked((nuint)(UIntPtr)Class5.Default) * num) == 0)
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Class2)(object)Class5.Default;
				}
			}
			else
			{
				_ = (Qk7)(object)Class5.Default;
			}
		}
		catch
		{
			_ = (GClass0)(object)Class5.Default;
		}
		if (num == 0)
		{
			while (obj != null)
			{
				BindingFlags bindingFlags_62 = bindingFlags;
				ref object[] object_24 = ref *(object[]*)class2.e((BindingFlags)class2.W((BindingFlags)((Class7)null).t((BindingFlags)Class5.Default, array6, (object)class2.e((BindingFlags)class2.e(default(BindingFlags), array5, (Type[])(object)Class5.Default, array3), array5, array2, (ParameterModifier[])(object)Class5.Default), cultureInfo), array, type, (Type[])(object)Class5.Default, (ParameterModifier[])((Class7)null).t((object)null, (Type)null, (CultureInfo)null)), (MethodBase[])(object)Class5.Default, null, null);
				ParameterModifier[] parameterModifier_10 = array3;
				Class7 class96 = class2;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_63 = bindingFlags;
				BindingFlags bindingFlags_64 = bindingFlags;
				FieldInfo[] fieldInfo_6 = array6;
				Class7 obj67 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_65 = (BindingFlags)Class5.Default;
				Class7 class97 = class2;
				bindingFlags = default(BindingFlags);
				if ((UIntPtr)((Class7)null).j(bindingFlags_62, (MethodBase[])null, ref object_24, parameterModifier_10, (CultureInfo)(object)class96.j(bindingFlags_63, (MethodBase[])(object)((Class7)null).t(bindingFlags_64, fieldInfo_6, (object)obj67.e(bindingFlags_65, (MethodBase[])(object)class97.W(bindingFlags, null, type, array2, array3), array2, array3), cultureInfo), ref *(object[]*)Class5.Default, null, cultureInfo, null, out *(object*)null), (string[])null, out *(object*)null) == (UIntPtr)(nuint)0u)
				{
					bindingFlags = default(BindingFlags);
					_ = (Class7)(object)((Class7)null).j(bindingFlags, array5, ref reference, array3, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out reference2);
					gClass2 = gClass2;
					_ = (GClass1)(object)Class5.Default;
					class21 = class21;
				}
			}
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				BindingFlags bindingFlags_66 = (BindingFlags)class2.j((BindingFlags)class2.t(bindingFlags, null, obj, null), array5, ref reference, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)class2.t(bindingFlags, array6, obj, cultureInfo), array4, out *(object*)class2.t(bindingFlags, array6, null, cultureInfo));
				Type type_21 = type;
				Class7 class98 = class2;
				BindingFlags bindingFlags_67 = bindingFlags;
				Class7 class99 = class2;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_68 = bindingFlags;
				PropertyInfo[] propertyInfo_14 = array;
				Class7 class100 = class2;
				bindingFlags = default(BindingFlags);
				class14 = (Class10)(object)((Class7)null).W(bindingFlags_66, (PropertyInfo[])null, type_21, (Type[])(object)class98.W(bindingFlags_67, null, null, (Type[])(object)class99.W(bindingFlags_68, propertyInfo_14, (Type)(object)class100.t(bindingFlags, array6, obj, null), array2, array3), (ParameterModifier[])(object)Class5.Default), array3);
			}
			finally
			{
				_ = (Class2)(object)Class5.Default;
				_ = (Struct1)class2.W(bindingFlags, (PropertyInfo[])(object)class2.j(bindingFlags, null, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo, array4, out *(object*)null), type, (Type[])(object)class2.t(bindingFlags, array6, obj, cultureInfo), array3);
				gClass4 = (GClass0)(object)Class5.Default;
				_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
				goto IL_593c;
			}
		}
		class2 = class2;
		goto IL_593c;
		IL_09c5:
		Class7 obj69;
		BindingFlags bindingFlags_69;
		Class7 class101;
		do
		{
			try
			{
				_ = (GClass3)(object)((Class7)null).e(default(BindingFlags), (MethodBase[])null, array2, array3);
			}
			catch
			{
				_003CModule_003E = (_003CModule_003E)((Class7)null).t((object)null, (Type)null, (CultureInfo)(object)Class5.Default);
				_003CModule_003E = null;
			}
			finally
			{
				gClass = (GClass2)(object)Class5.Default;
				goto IL_0a20;
			}
			IL_0a20:
			obj69 = (Class7)(object)Class5.Default;
			bindingFlags_69 = (BindingFlags)Class5.Default;
			class101 = class2;
			bindingFlags = default(BindingFlags);
		}
		while ((object)obj69.e(bindingFlags_69, (MethodBase[])(object)class101.j(bindingFlags, array5, ref *(object[]*)null, array3, cultureInfo, (string[])class2.t(((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)(object)Class5.Default, (Type[])(object)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, array, type, (Type[])(object)Class5.Default, null), (ParameterModifier[])null), null, (CultureInfo)(object)Class5.Default), out reference2), (Type[])(object)Class5.Default, array3) != null);
		try
		{
			class2 = null;
		}
		catch
		{
			class12 = class12;
			class12 = null;
		}
		num = default(UIntPtr);
		nuint num17 = checked(num + num);
		UIntPtr num18 = (UIntPtr)class2.j(bindingFlags, array5, ref reference, null, cultureInfo, null, out *(object*)null);
		checked
		{
			nuint num19 = (unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr))) * unchecked((nuint)default(UIntPtr));
			UIntPtr num20 = unchecked((UIntPtr)class2.e((BindingFlags)Class5.Default, array5, null, array3));
			num = default(UIntPtr);
			if (num17 - unchecked((nuint)num18 / checked(unchecked((nuint)default(UIntPtr)) * (num19 - unchecked((nuint)num20) * (unchecked((nuint)default(UIntPtr)) - (num + num) * unchecked((nuint)default(UIntPtr))) + unchecked((nuint)default(UIntPtr))))) == 0)
			{
				_ = (GClass2)(object)class2.t(bindingFlags, null, obj, null);
			}
			else
			{
				num = default(UIntPtr);
				if (unchecked(unchecked((nuint)default(UIntPtr)) / num) - num * num == 0)
				{
					class21 = null;
					class21 = class21;
				}
				else
				{
					class10 = class10;
				}
			}
		}
		try
		{
			if ((UIntPtr)Class5.Default != (UIntPtr)(nuint)0u)
			{
				@class = @class;
			}
		}
		finally
		{
			num = default(UIntPtr);
			if (checked(num + num) == 0)
			{
				try
				{
					qk = qk;
					_ = (GClass2)((Class7)(object)((Class7)(object)Class5.Default).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array2, null)).t(obj, type, (CultureInfo)(object)((Class7)null).j(bindingFlags, array5, ref reference, array3, cultureInfo, (string[])null, out *(object*)null));
					gClass = gClass;
				}
				catch
				{
					struct2 = (Struct1)Class5.Default;
					struct2 = default(Struct1);
				}
			}
			goto IL_0cf6;
		}
		IL_2cc2:
		while (obj != null)
		{
			_ = (Class7)(object)Class5.Default;
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			@struct = default(Struct2);
		}
		num = default(UIntPtr);
		if (num == 0)
		{
			_ = (Class5)((Class7)class2.t(null, type, (CultureInfo)(object)Class5.Default)).t(obj, (Type)(object)class2.e(bindingFlags, array5, array2, null), (CultureInfo)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference, (ParameterModifier[])null, cultureInfo, (string[])(object)Class5.Default, out *(object*)null));
			goto IL_2e17;
		}
		try
		{
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)((Class7)null).W(bindingFlags, array, type, array2, array3) == (UIntPtr)(nuint)0u)
			{
				@struct = (Struct2)class2.t(Class5.Default, type, null);
			}
		}
		finally
		{
			_ = (Class2)(object)Class5.Default;
			goto IL_2e17;
		}
		IL_1b88:
		Class7 obj72 = (Class7)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		_ = (Struct1)obj72.W(bindingFlags, array, type, array2, null);
		_ = (_003CModule_003E)(object)Class5.Default;
		try
		{
			if ((UIntPtr)((Class7)(object)Class5.Default).t(null, null, cultureInfo) == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					class14 = class14;
				}
				else
				{
					Class7 class102 = class2;
					bindingFlags = default(BindingFlags);
					_ = (GClass1)(object)class102.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, cultureInfo);
				}
			}
			else
			{
				try
				{
					class2 = class2;
				}
				catch
				{
					class13 = class13;
				}
			}
		}
		finally
		{
			do
			{
				_ = (GClass2)(object)Class5.Default;
			}
			while (obj != null);
			goto IL_1c52;
		}
		IL_1c52:
		try
		{
			gClass4 = gClass4;
		}
		finally
		{
			class10 = (Class9)(object)Class5.Default;
			goto IL_1c6d;
		}
		IL_26ba:
		while (obj != null)
		{
			try
			{
				gClass2 = gClass2;
			}
			catch
			{
				if (num == 0)
				{
					Class7 class103 = class2;
					Class7 obj74 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_70 = bindingFlags;
					MethodBase[] methodBase_27 = (MethodBase[])(object)Class5.Default;
					ref object[] object_25 = ref *(object[]*)Class5.Default;
					ParameterModifier[] parameterModifier_11 = (ParameterModifier[])(object)Class5.Default;
					Class7 class104 = class2;
					object object_26 = obj;
					bindingFlags = default(BindingFlags);
					_ = (Class10)(object)class103.e((BindingFlags)obj74.j(bindingFlags_70, methodBase_27, ref object_25, parameterModifier_11, (CultureInfo)(object)class104.t(default(BindingFlags), null, object_26, (CultureInfo)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference, (ParameterModifier[])null, cultureInfo, (string[])null, out reference2)), array4, out *(object*)null), (MethodBase[])((Class7)null).t(obj, type, (CultureInfo)(object)Class5.Default), null, array3);
				}
			}
		}
		gClass2 = (GClass3)(object)class2.j(bindingFlags, (MethodBase[])(object)class2.e(bindingFlags, array5, array2, null), ref *(object[]*)null, array3, null, array4, out reference2);
		num = default(UIntPtr);
		if (num == 0)
		{
			num = default(UIntPtr);
			if (num != 0)
			{
				do
				{
					_ = (Class8)(object)Class5.Default;
				}
				while (obj != null);
			}
			goto IL_2814;
		}
		checked
		{
			try
			{
				Class7 class105 = class2;
				bindingFlags = default(BindingFlags);
				if (unchecked((nuint)(UIntPtr)class105.t(bindingFlags, array6, class2.j(bindingFlags, array5, ref *(object[]*)class2.t(obj, (Type)(object)class2.e((BindingFlags)Class5.Default, array5, null, null), cultureInfo), null, null, array4, out *(object*)class2.W(bindingFlags, null, type, array2, array3)), cultureInfo)) + unchecked((nuint)(UIntPtr)Class5.Default) == 0)
				{
					@class = null;
				}
				else
				{
					_003CModule_003E = _003CModule_003E;
					_ = (GClass2)(object)Class5.Default;
					_ = (Class7)((Class7)null).t((object)null, type, cultureInfo);
				}
			}
			finally
			{
				_003CModule_003E = null;
				goto IL_2814;
			}
		}
		IL_1caf:
		num = default(UIntPtr);
		if (num == 0)
		{
			try
			{
				gClass = gClass;
			}
			finally
			{
				_ = (Class4)(object)((Class7)(object)Class5.Default).j((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, array3, null, null, out reference2);
				_ = (Class4)(object)((Class7)(object)Class5.Default).j((BindingFlags)class2.t((BindingFlags)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, null, array2, array3), (FieldInfo[])(object)Class5.Default, obj, cultureInfo), array5, ref reference, null, cultureInfo, null, out *(object*)null);
				_ = (Class7)(object)Class5.Default;
				goto IL_1d7b;
			}
		}
		goto IL_1d7b;
		IL_593c:
		while (obj != null)
		{
			do
			{
				class2 = class2;
			}
			while ((object)Class5.Default != null);
		}
		_ = (Class7)(object)Class5.Default;
		qk = qk;
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (Class0)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, array2, (ParameterModifier[])(object)Class5.Default);
			}
			catch
			{
				while (obj != null)
				{
					_ = (Struct2)class2.W(bindingFlags, array, null, array2, null);
				}
			}
		}
		Class7 class106 = class2;
		Class7 class107 = class2;
		bindingFlags = default(BindingFlags);
		if ((UIntPtr)class106.e((BindingFlags)class107.j(bindingFlags, array5, ref *(object[]*)null, array3, (CultureInfo)(object)Class5.Default, array4, out reference2), array5, null, array3) == (UIntPtr)(nuint)0u)
		{
			do
			{
				if ((UIntPtr)Class5.Default != (UIntPtr)(nuint)0u)
				{
					_003CModule_003E = null;
					class10 = class10;
					_ = (Class6)(object)Class5.Default;
					@struct = @struct;
				}
				else
				{
					_ = (Struct1)Class5.Default;
				}
			}
			while (obj != null);
		}
		else
		{
			_ = (Struct2)Class5.Default;
		}
		if (num == (UIntPtr)(nuint)0u)
		{
			try
			{
				class4 = class4;
			}
			catch
			{
				class13 = class13;
			}
		}
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			Class7 class108 = class2;
			bindingFlags = default(BindingFlags);
			_ = (Class10)(object)class108.t(bindingFlags, array6, null, (CultureInfo)(object)((Class7)null).j(bindingFlags, array5, ref *(object[]*)class2.t(bindingFlags, null, obj, cultureInfo), array3, (CultureInfo)((Class7)(object)((Class7)(object)Class5.Default).W(bindingFlags, array, type, array2, array3)).t(obj, (Type)class2.t(obj, null, cultureInfo), cultureInfo), array4, out reference2));
		}
		else
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
				try
				{
					gClass = gClass;
				}
				catch
				{
					_ = (Class2)(object)Class5.Default;
					_ = (Class2)(object)Class5.Default;
					class11 = null;
				}
			}
		}
		try
		{
			if (num == (UIntPtr)(nuint)0u && num == (UIntPtr)(nuint)0u)
			{
				Class7 class109 = class2;
				BindingFlags bindingFlags_71 = bindingFlags;
				BindingFlags bindingFlags_72 = bindingFlags;
				Class7 class110 = class2;
				bindingFlags = default(BindingFlags);
				qk = (Qk7)(object)class109.e(bindingFlags_71, null, (Type[])((Class7)(object)((Class7)null).e(bindingFlags_72, (MethodBase[])null, (Type[])null, (ParameterModifier[])(object)class110.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array2, array3))).t(obj, type, null), array3);
			}
			return;
		}
		finally
		{
			try
			{
				struct2 = struct2;
				return;
			}
			catch
			{
				_ = (GClass3)(object)Class5.Default;
				_ = (Class9)((Class7)((Class7)(object)class2.t(bindingFlags, null, obj, (CultureInfo)(object)Class5.Default)).t(obj, type, cultureInfo)).t(null, type, (CultureInfo)(object)Class5.Default);
				_ = (Class7)(object)Class5.Default;
				return;
			}
			finally
			{
				@struct = @struct;
				return;
			}
		}
		IL_1d7b:
		try
		{
			try
			{
				_ = (GClass0)(object)((Class7)(object)class2.e((BindingFlags)Class5.Default, array5, (Type[])(object)Class5.Default, array3)).e(bindingFlags, null, array2, (ParameterModifier[])(object)((Class7)(object)class2.e(bindingFlags, array5, (Type[])(object)Class5.Default, null)).t(bindingFlags, array6, obj, cultureInfo));
			}
			finally
			{
				qk = qk;
				goto end_IL_1d7c;
			}
			end_IL_1d7c:;
		}
		catch
		{
			if (checked(unchecked((nuint)(UIntPtr)class2.t(obj, null, null)) * num) == 0)
			{
				try
				{
					_ = (Class6)(object)((Class7)(object)Class5.Default).e(bindingFlags, array5, array2, (ParameterModifier[])(object)Class5.Default);
				}
				catch
				{
					class14 = (Class10)(object)Class5.Default;
				}
			}
			else if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				class21 = class21;
			}
		}
		try
		{
			_ = (_003CModule_003E)(object)((Class7)null).t(bindingFlags, array6, obj, cultureInfo);
		}
		finally
		{
			do
			{
				try
				{
					class4 = class4;
					class13 = class13;
					_ = (GClass3)(object)((Class7)null).j((BindingFlags)class2.t(bindingFlags, (FieldInfo[])(object)((Class7)(object)Class5.Default).j((BindingFlags)Class5.Default, array5, ref reference, null, (CultureInfo)(object)class2.e(bindingFlags, (MethodBase[])(object)((Class7)(object)class2.e(bindingFlags, null, (Type[])(object)Class5.Default, null)).t((BindingFlags)Class5.Default, array6, null, cultureInfo), array2, array3), array4, out reference2), null, null), array5, ref reference, array3, cultureInfo, array4, out *(object*)null);
					_ = (Class8)(object)Class5.Default;
				}
				finally
				{
					gClass2 = null;
					continue;
				}
			}
			while (obj != null);
			goto IL_1f80;
		}
		IL_1c6d:
		if (num == 0)
		{
			try
			{
				if (num == 0)
				{
					_ = (GClass1)((Class7)(object)Class5.Default).t(obj, type, null);
				}
			}
			finally
			{
				while (obj != null)
				{
					_ = (_003CModule_003E)(object)Class5.Default;
				}
				goto IL_1caf;
			}
		}
		goto IL_1caf;
	}

	unsafe static void smethod_5()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] array2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] array3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object[] reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string[] array4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class7 @class);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags);
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					Class7 class2 = @class;
					bindingFlags = (BindingFlags)Class5.Default;
					array = array;
					PropertyInfo[] propertyInfo_ = array;
					type = type;
					Type type_ = type;
					Class7 class3 = @class;
					obj = obj;
					array2 = (Type[])class3.t(obj, type, null);
					Type[] type_2 = array2;
					array3 = array3;
					@class = (Class7)(object)class2.W(default(BindingFlags), propertyInfo_, type_, type_2, array3);
					Class7 class4 = @class;
					object object_ = Class5.Default;
					cultureInfo = cultureInfo;
					Class7 obj2 = (Class7)class4.t(object_, null, cultureInfo);
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_ = bindingFlags;
					MethodBase[] methodBase_ = (MethodBase[])(object)Class5.Default;
					reference = ref *(object[]*)null;
					ref object[] object_2 = ref reference;
					ParameterModifier[] parameterModifier_ = array3;
					CultureInfo cultureInfo_ = (CultureInfo)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, array2, array3);
					array4 = (string[])(object)Class5.Default;
					_ = (Class4)(object)obj2.j(bindingFlags_, methodBase_, ref object_2, parameterModifier_, cultureInfo_, array4, out *(object*)null);
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out FieldInfo[] array5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass1 gClass);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class4 class7);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		Class0 class5;
		while (obj != null)
		{
			try
			{
				try
				{
					_ = (Class0)(object)Class5.Default;
				}
				catch
				{
					class5 = null;
					class5 = class5;
					Class7 class6 = @class;
					BindingFlags bindingFlags_2 = bindingFlags;
					array5 = array5;
					_ = (GClass0)(object)class6.t(bindingFlags_2, array5, obj, cultureInfo);
					_ = (Struct2)Class5.Default;
					class7 = class7;
					class7 = class7;
				}
			}
			catch
			{
				_003CModule_003E = _003CModule_003E;
				_003CModule_003E = null;
				_ = (Class2)@class.t(obj, type, cultureInfo);
				gClass = null;
				gClass = gClass;
			}
		}
		_ = (Class9)(object)Class5.Default;
		_ = (Class4)(object)Class5.Default;
		gClass = gClass;
		Qk7 qk = (Qk7)(object)Class5.Default;
		qk = null;
		nuint num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] array6);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object reference2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class8 class9);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct1 @struct);
		if (num == 0)
		{
			if ((UIntPtr)@class.W((BindingFlags)Class5.Default, array, type, (Type[])@class.t(Class5.Default, null, cultureInfo), array3) == (UIntPtr)(nuint)0u)
			{
				while (obj != null)
				{
					@struct = (Struct1)Class5.Default;
					@struct = default(Struct1);
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
					_ = (Class0)(object)Class5.Default;
					Class7 class8 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_3 = bindingFlags;
					BindingFlags bindingFlags_4 = bindingFlags;
					array6 = null;
					MethodBase[] methodBase_2 = array6;
					ref object[] object_3 = ref reference;
					ParameterModifier[] parameterModifier_2 = (ParameterModifier[])(object)Class5.Default;
					CultureInfo cultureInfo_2 = (CultureInfo)@class.t(@class.e(bindingFlags, null, array2, (ParameterModifier[])(object)Class5.Default), type, null);
					string[] string_ = array4;
					reference2 = ref reference2;
					_ = (GClass3)(object)class8.e(bindingFlags_3, null, null, (ParameterModifier[])(object)((Class7)null).j(bindingFlags_4, methodBase_2, ref object_3, parameterModifier_2, cultureInfo_2, string_, out reference2));
					Class8 obj5 = (Class8)@class.t(((Class7)null).W((BindingFlags)((Class7)(object)@class.e(bindingFlags, array6, null, null)).e(bindingFlags, null, null, array3), array, (Type)(object)Class5.Default, (Type[])null, (ParameterModifier[])(object)Class5.Default), type, cultureInfo);
					class9 = class9;
					class9 = obj5;
					Class7 class10 = @class;
					BindingFlags bindingFlags_5 = bindingFlags;
					Class7 class11 = @class;
					Class7 class12 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass0)(object)class10.e(bindingFlags_5, null, (Type[])(object)class11.t((BindingFlags)class12.e(bindingFlags, null, null, array3), array5, obj, (CultureInfo)(object)@class.t(bindingFlags, array5, obj, null)), array3);
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass0 gClass2);
		while (obj != null)
		{
			Class7 obj7 = (Class7)(object)Class5.Default;
			Type type_3 = (Type)(object)Class5.Default;
			Class7 class13 = @class;
			bindingFlags = default(BindingFlags);
			gClass2 = (GClass0)obj7.t(null, type_3, (CultureInfo)(object)class13.t(bindingFlags, array5, null, cultureInfo));
			gClass2 = null;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class6 class14);
		while (obj != null)
		{
			do
			{
				try
				{
					_ = (GClass3)(object)((Class7)(object)Class5.Default).e(bindingFlags, array6, null, (ParameterModifier[])(object)Class5.Default);
				}
				finally
				{
					class9 = (Class8)(object)@class.W((BindingFlags)@class.t(obj, type, (CultureInfo)@class.t(obj, type, null)), array, null, (Type[])(object)Class5.Default, null);
					qk = (Qk7)(object)Class5.Default;
					_ = Class5.Default;
					class14 = class14;
					class14 = null;
					continue;
				}
			}
			while (obj != null);
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u && num == 0)
		{
			if ((UIntPtr)@class.e(bindingFlags, null, (Type[])(object)Class5.Default, array3) == (UIntPtr)(nuint)0u)
			{
				class5 = (Class0)(object)Class5.Default;
				gClass = gClass;
				_ = (Class10)(object)Class5.Default;
				_ = (GClass0)(object)Class5.Default;
			}
			else
			{
				gClass2 = gClass2;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class5 class19);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass2 gClass3);
		try
		{
			if (num == 0)
			{
				if (checked(num + unchecked((nuint)default(UIntPtr))) == 0)
				{
					qk = null;
				}
				else
				{
					_ = (Struct2)((Class7)null).t((BindingFlags)((Class7)null).e((BindingFlags)((Class7)null).t((BindingFlags)@class.W(bindingFlags, array, null, (Type[])(object)Class5.Default, null), array5, obj, cultureInfo), array6, array2, (ParameterModifier[])null), (FieldInfo[])(object)Class5.Default, (object)Class5.Default, cultureInfo);
					_ = (Class9)(object)Class5.Default;
				}
			}
			else if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				gClass3 = gClass3;
				gClass3 = gClass3;
			}
		}
		catch
		{
			while (obj != null)
			{
				try
				{
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_6 = bindingFlags;
					ref object[] object_4 = ref *(object[]*)Class5.Default;
					Class7 obj8 = (Class7)(object)((Class7)null).t(bindingFlags, array5, obj, (CultureInfo)(object)@class.W((BindingFlags)@class.t(obj, null, null), (PropertyInfo[])(object)Class5.Default, type, null, array3));
					Class7 class15 = @class;
					BindingFlags bindingFlags_7 = (BindingFlags)((Class7)null).e(bindingFlags, (MethodBase[])null, array2, array3);
					BindingFlags bindingFlags_8 = bindingFlags;
					Class7 class16 = @class;
					bindingFlags = default(BindingFlags);
					PropertyInfo[] propertyInfo_2 = (PropertyInfo[])(object)class16.e(bindingFlags, array6, array2, null);
					Class7 class17 = @class;
					BindingFlags bindingFlags_9 = bindingFlags;
					BindingFlags bindingFlags_10 = (BindingFlags)((Class7)(object)@class.t((BindingFlags)Class5.Default, array5, obj, cultureInfo)).t(Class5.Default, type, null);
					Class7 class18 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class6)(object)((Class7)(object)((Class7)null).j(bindingFlags_6, (MethodBase[])null, ref object_4, (ParameterModifier[])(object)obj8.t((BindingFlags)class15.e(bindingFlags_7, (MethodBase[])(object)((Class7)null).W(bindingFlags_8, propertyInfo_2, (Type)(object)class17.W(bindingFlags_9, (PropertyInfo[])(object)((Class7)null).W(bindingFlags_10, (PropertyInfo[])null, (Type)(object)((Class7)(object)class18.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array2, null)).e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, (ParameterModifier[])(object)((Class7)(object)Class5.Default).j(bindingFlags, (MethodBase[])(object)((Class7)(object)Class5.Default).j(bindingFlags, null, ref reference, array3, (CultureInfo)(object)Class5.Default, null, out reference2), ref reference, null, cultureInfo, null, out *(object*)Class5.Default)), array2, array3), (Type)(object)Class5.Default, null, array3), array2, array3), array2, null), null, obj, (CultureInfo)(object)((Class7)null).t((BindingFlags)((Class7)(object)((Class7)(object)@class.j(bindingFlags, array6, ref *(object[]*)@class.e(bindingFlags, null, array2, array3), array3, null, null, out reference2)).W(bindingFlags, null, type, (Type[])(object)Class5.Default, null)).t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, cultureInfo), (FieldInfo[])null, (object)((Class7)null).t((BindingFlags)((Class7)(object)@class.W(bindingFlags, null, type, array2, array3)).t(bindingFlags, array5, obj, cultureInfo), array5, obj, (CultureInfo)null), (CultureInfo)(object)((Class7)null).W(bindingFlags, array, (Type)null, array2, array3))), cultureInfo, array4, out *(object*)((Class7)(object)Class5.Default).W(bindingFlags, array, type, null, (ParameterModifier[])@class.t(Class5.Default, (Type)(object)Class5.Default, cultureInfo)))).j(bindingFlags, (MethodBase[])(object)((Class7)null).j((BindingFlags)((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])(object)((Class7)(object)((Class7)(object)Class5.Default).e(bindingFlags, array6, null, array3)).t((BindingFlags)((Class7)null).W(bindingFlags, array, type, array2, array3), array5, obj, (CultureInfo)(object)Class5.Default), null, array3), array6, ref *(object[]*)null, (ParameterModifier[])null, (CultureInfo)null, (string[])null, out reference2), ref *(object[]*)Class5.Default, array3, null, (string[])(object)Class5.Default, out *(object*)null);
				}
				finally
				{
					class19 = class19;
					class19 = class19;
					continue;
				}
			}
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			class7 = (Class4)(object)@class.e(bindingFlags, (MethodBase[])(object)@class.W(bindingFlags, null, type, null, null), array2, array3);
			goto IL_0fbd;
		}
		try
		{
			class9 = class9;
		}
		finally
		{
			do
			{
				object object_5 = obj;
				Class7 class20 = @class;
				BindingFlags bindingFlags_11 = (BindingFlags)Class5.Default;
				Class7 obj10 = (Class7)(object)@class.t((BindingFlags)((Class7)null).e(bindingFlags, (MethodBase[])(object)@class.e(bindingFlags, array6, array2, null), array2, array3), array5, obj, cultureInfo);
				BindingFlags bindingFlags_12 = bindingFlags;
				Class7 class21 = @class;
				BindingFlags bindingFlags_13 = (BindingFlags)Class5.Default;
				MethodBase[] methodBase_3 = array6;
				ref object[] object_6 = ref reference;
				CultureInfo cultureInfo_3 = cultureInfo;
				string[] string_2 = array4;
				bindingFlags = default(BindingFlags);
				MethodBase[] methodBase_4 = (MethodBase[])(object)((Class7)(object)obj10.W(bindingFlags_12, null, (Type)(object)class21.j(bindingFlags_13, methodBase_3, ref object_6, null, cultureInfo_3, string_2, out *(object*)((Class7)null).t((BindingFlags)((Class7)null).j(bindingFlags, array6, ref *(object[]*)null, (ParameterModifier[])null, (CultureInfo)(object)((Class7)(object)((Class7)(object)Class5.Default).W(bindingFlags, null, (Type)(object)Class5.Default, array2, null)).j(bindingFlags, null, ref reference, null, null, null, out reference2), array4, out reference2), (FieldInfo[])null, @class.t(obj, (Type)(object)Class5.Default, null), (CultureInfo)(object)((Class7)null).e(bindingFlags, array6, array2, (ParameterModifier[])null))), array2, array3)).t(bindingFlags, null, obj, cultureInfo);
				Class7 obj11 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_14 = bindingFlags;
				MethodBase[] methodBase_5 = (MethodBase[])(object)((Class7)(object)@class.e((BindingFlags)Class5.Default, array6, null, array3)).j(bindingFlags, array6, ref reference, array3, cultureInfo, array4, out reference2);
				ref object[] object_7 = ref reference;
				ParameterModifier[] parameterModifier_3 = (ParameterModifier[])(object)Class5.Default;
				Class7 obj12 = (Class7)(object)((Class7)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference, array3, (CultureInfo)(object)Class5.Default, array4, out reference2)).e(default(BindingFlags), array6, array2, array3);
				BindingFlags bindingFlags_15 = (BindingFlags)Class5.Default;
				ref object[] object_8 = ref reference;
				ParameterModifier[] parameterModifier_4 = array3;
				CultureInfo cultureInfo_4 = cultureInfo;
				string[] string_3 = array4;
				Class7 class22 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_16 = bindingFlags;
				MethodBase[] methodBase_6 = array6;
				ParameterModifier[] parameterModifier_5 = array3;
				CultureInfo cultureInfo_5 = cultureInfo;
				Class7 class23 = @class;
				BindingFlags bindingFlags_17 = bindingFlags;
				MethodBase[] methodBase_7 = array6;
				Class7 class24 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class2)((Class7)null).t(object_5, (Type)null, (CultureInfo)(object)class20.j(bindingFlags_11, methodBase_4, ref *(object[]*)null, (ParameterModifier[])(object)obj11.j(bindingFlags_14, methodBase_5, ref object_7, parameterModifier_3, (CultureInfo)(object)obj12.j(default(BindingFlags), (MethodBase[])(object)((Class7)null).j(bindingFlags_15, (MethodBase[])null, ref object_8, parameterModifier_4, cultureInfo_4, string_3, out *(object*)class22.j(bindingFlags_16, methodBase_6, ref *(object[]*)null, parameterModifier_5, cultureInfo_5, (string[])(object)class23.j(bindingFlags_17, methodBase_7, ref *(object[]*)class24.j(bindingFlags, array6, ref reference, null, (CultureInfo)(object)Class5.Default, array4, out *(object*)@class.j((BindingFlags)@class.t(bindingFlags, null, ((Class7)null).t((object)null, type, cultureInfo), cultureInfo), (MethodBase[])(object)((Class7)null).e(bindingFlags, array6, array2, (ParameterModifier[])null), ref *(object[]*)Class5.Default, (ParameterModifier[])(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, null, array3), cultureInfo, array4, out *(object*)Class5.Default)), null, (CultureInfo)(object)Class5.Default, array4, out *(object*)null), out *(object*)Class5.Default)), ref *(object[]*)null, null, null, array4, out *(object*)@class.j(bindingFlags, array6, ref reference, null, cultureInfo, null, out reference2)), array4, out *(object*)((Class7)(object)Class5.Default).j(bindingFlags, array6, ref reference, (ParameterModifier[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, array2, array3), (CultureInfo)(object)Class5.Default, (string[])(object)@class.e((BindingFlags)((Class7)(object)Class5.Default).W((BindingFlags)@class.W((BindingFlags)Class5.Default, null, type, array2, array3), array, (Type)((Class7)@class.t(Class5.Default, type, (CultureInfo)(object)((Class7)null).W(bindingFlags, array, type, array2, (ParameterModifier[])null))).t(obj, type, cultureInfo), array2, array3), array6, array2, array3), out reference2)), null, array4, out *(object*)((Class7)((Class7)(object)Class5.Default).t(null, type, cultureInfo)).e(bindingFlags, array6, array2, null)));
			}
			while (obj != null);
			goto IL_0fbd;
		}
		IL_189d:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct2 struct2);
		if ((nuint)(UIntPtr)Class5.Default / num == 0)
		{
			try
			{
				_ = (Class2)(object)Class5.Default;
			}
			finally
			{
				nuint num2 = num;
				Class7 class25 = @class;
				BindingFlags bindingFlags_18 = (BindingFlags)Class5.Default;
				MethodBase[] methodBase_8 = array6;
				Class7 obj13 = (Class7)(object)@class.W(bindingFlags, array, null, array2, null);
				BindingFlags bindingFlags_19 = bindingFlags;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_20 = bindingFlags;
				BindingFlags bindingFlags_21 = bindingFlags;
				MethodBase[] methodBase_9 = (MethodBase[])(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
				Class7 class26 = @class;
				bindingFlags = default(BindingFlags);
				if (checked(num2 * unchecked((nuint)(UIntPtr)class25.j(bindingFlags_18, methodBase_8, ref *(object[]*)obj13.W(bindingFlags_19, null, (Type)(object)((Class7)(object)((Class7)null).t(bindingFlags_20, (FieldInfo[])(object)((Class7)null).e(bindingFlags_21, methodBase_9, (Type[])(object)class26.t(bindingFlags, array5, null, null), array3), obj, (CultureInfo)(object)Class5.Default)).e((BindingFlags)@class.W((BindingFlags)Class5.Default, null, type, (Type[])(object)Class5.Default, array3), (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, null), null, null), array3, (CultureInfo)(object)@class.W(bindingFlags, array, type, array2, null), (string[])(object)((Class7)(object)@class.j((BindingFlags)((Class7)null).j((BindingFlags)Class5.Default, array6, ref reference, array3, cultureInfo, (string[])null, out *(object*)Class5.Default), array6, ref *(object[]*)null, array3, cultureInfo, null, out reference2)).j(bindingFlags, array6, ref reference, null, (CultureInfo)@class.t(obj, type, null), (string[])(object)Class5.Default, out *(object*)null), out *(object*)Class5.Default)) - unchecked((nuint)(UIntPtr)Class5.Default)) == 0)
				{
					_ = (GClass1)(object)Class5.Default;
					Class7 obj14 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_22 = bindingFlags;
					BindingFlags bindingFlags_23 = bindingFlags;
					PropertyInfo[] propertyInfo_3 = (PropertyInfo[])(object)Class5.Default;
					Class7 obj15 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_24 = bindingFlags;
					MethodBase[] methodBase_10 = array6;
					Class7 class27 = @class;
					BindingFlags bindingFlags_25 = (BindingFlags)Class5.Default;
					MethodBase[] methodBase_11 = array6;
					Class7 class28 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class2)(object)obj14.e(bindingFlags_22, null, (Type[])(object)((Class7)null).W(bindingFlags_23, propertyInfo_3, (Type)(object)((Class7)null).t((BindingFlags)obj15.e(bindingFlags_24, methodBase_10, (Type[])(object)class27.j(bindingFlags_25, methodBase_11, ref *(object[]*)class28.t(bindingFlags, array5, Class5.Default, cultureInfo), array3, (CultureInfo)(object)Class5.Default, array4, out *(object*)null), array3), (FieldInfo[])null, obj, (CultureInfo)null), array2, (ParameterModifier[])null), array3);
					_ = (GClass1)(object)Class5.Default;
					struct2 = default(Struct2);
				}
				goto IL_1b9f;
			}
		}
		goto IL_1b9f;
		IL_5064:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class9 class32);
		try
		{
			try
			{
				if (checked(unchecked((nuint)(UIntPtr)Class5.Default) + num) == 0)
				{
					struct2 = struct2;
				}
				else
				{
					class9 = class9;
					bindingFlags = default(BindingFlags);
					_ = (Struct2)((Class7)null).e(bindingFlags, (MethodBase[])(object)((Class7)null).t((BindingFlags)@class.t((BindingFlags)@class.j(bindingFlags, null, ref *(object[]*)((Class7)(object)Class5.Default).t(bindingFlags, array5, @class.e((BindingFlags)@class.t((BindingFlags)Class5.Default, array5, null, cultureInfo), array6, null, null), cultureInfo), array3, (CultureInfo)(object)Class5.Default, (string[])(object)@class.e(bindingFlags, (MethodBase[])(object)((Class7)(object)Class5.Default).t(bindingFlags, array5, obj, cultureInfo), array2, array3), out reference2), array5, ((Class7)null).t((object)null, (Type)null, (CultureInfo)(object)Class5.Default), (CultureInfo)(object)Class5.Default), array5, (object)((Class7)(object)Class5.Default).t(bindingFlags, array5, null, (CultureInfo)(object)((Class7)null).W(bindingFlags, array, (Type)null, (Type[])null, array3)), (CultureInfo)(object)@class.t(bindingFlags, array5, null, null)), array2, (ParameterModifier[])(object)Class5.Default);
					_ = (_003CModule_003E)(object)Class5.Default;
					Class7 obj16 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_26 = bindingFlags;
					MethodBase[] methodBase_12 = (MethodBase[])(object)Class5.Default;
					ref object[] object_9 = ref reference;
					Class7 class29 = @class;
					Class7 class30 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_27 = (BindingFlags)class30.W(bindingFlags, array, (Type)(object)Class5.Default, null, array3);
					Type type_4 = type;
					Class7 obj17 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_28 = bindingFlags;
					MethodBase[] methodBase_13 = (MethodBase[])(object)Class5.Default;
					ref object[] object_10 = ref reference;
					ParameterModifier[] parameterModifier_6 = array3;
					Class7 class31 = @class;
					bindingFlags = default(BindingFlags);
					gClass = (GClass1)(object)obj16.j(bindingFlags_26, methodBase_12, ref object_9, null, (CultureInfo)(object)class29.W(bindingFlags_27, null, type_4, (Type[])(object)obj17.j(bindingFlags_28, methodBase_13, ref object_10, parameterModifier_6, null, (string[])(object)class31.j(bindingFlags, array6, ref *(object[]*)null, (ParameterModifier[])(object)@class.t(bindingFlags, array5, null, null), (CultureInfo)((Class7)@class.t(obj, type, cultureInfo)).t(null, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default), array4, out *(object*)null), out reference2), array3), array4, out *(object*)Class5.Default);
				}
			}
			finally
			{
				goto end_IL_5065;
			}
			end_IL_5065:;
		}
		finally
		{
			if (num == 0)
			{
				try
				{
					class32 = (Class9)(object)Class5.Default;
				}
				finally
				{
					@class = null;
					goto IL_535b;
				}
			}
			goto IL_535b;
		}
		IL_3bc0:
		_003CModule_003E = _003CModule_003E;
		class9 = class9;
		num = default(UIntPtr);
		if (num == 0)
		{
			gClass3 = gClass3;
			goto IL_3c8e;
		}
		try
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Class7)(object)((Class7)null).W((BindingFlags)Class5.Default, array, type, (Type[])(object)Class5.Default, (ParameterModifier[])null);
			}
		}
		finally
		{
			if (num / (nuint)(UIntPtr)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, cultureInfo) == 0)
			{
				_ = (Class2)@class.t(obj, type, cultureInfo);
			}
			else
			{
				_ = (Class6)(object)@class.e(bindingFlags, array6, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
			}
			goto IL_3c8e;
		}
		IL_1b9f:
		_ = (GClass1)(object)@class.W(bindingFlags, null, null, array2, array3);
		while (obj != null)
		{
			Class7 class33 = @class;
			Class7 class34 = @class;
			bindingFlags = default(BindingFlags);
			Class7 obj18 = (Class7)(object)((Class7)null).e(bindingFlags, array6, (Type[])(object)((Class7)null).W(bindingFlags, array, type, array2, (ParameterModifier[])(object)((Class7)(object)Class5.Default).t(bindingFlags, array5, obj, (CultureInfo)(object)((Class7)null).W(bindingFlags, array, (Type)null, (Type[])@class.t(obj, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default), array3))), (ParameterModifier[])null);
			bindingFlags = default(BindingFlags);
			_ = (Qk7)class33.t(class34.t((BindingFlags)obj18.W(bindingFlags, null, type, (Type[])(object)Class5.Default, array3), array5, ((Class7)(object)Class5.Default).t(obj, null, (CultureInfo)(object)@class.W((BindingFlags)((Class7)null).e((BindingFlags)Class5.Default, (MethodBase[])(object)@class.t(bindingFlags, array5, null, null), (Type[])(object)Class5.Default, (ParameterModifier[])@class.t(obj, null, null)), array, (Type)(object)@class.t(bindingFlags, array5, ((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)null, (CultureInfo)null), null), null, array3)), null), null, cultureInfo);
			gClass2 = null;
		}
		if (num == 0)
		{
			_ = (Class8)(object)Class5.Default;
		}
		_ = Class5.Default;
		while ((object)Class5.Default != null)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				while ((object)((Class7)(object)Class5.Default).j(bindingFlags, array6, ref reference, null, null, array4, out *(object*)Class5.Default) != null)
				{
					_ = (GClass3)(object)Class5.Default;
				}
			}
		}
		_ = (Class7)@class.t(Class5.Default, type, (CultureInfo)(object)@class.j(bindingFlags, null, ref *(object[]*)Class5.Default, null, cultureInfo, (string[])(object)Class5.Default, out *(object*)Class5.Default));
		_ = (Qk7)(object)((Class7)null).t((BindingFlags)Class5.Default, array5, (object)null, (CultureInfo)null);
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class2 class38);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class10 class37);
		checked
		{
			if (num != 0)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					Class7 class35 = @class;
					bindingFlags = default(BindingFlags);
					nuint num3 = unchecked(unchecked((nuint)default(UIntPtr)) / (nuint)(UIntPtr)class35.t(bindingFlags, array5, null, (CultureInfo)(object)Class5.Default)) - unchecked((nuint)default(UIntPtr));
					num = default(UIntPtr);
					if (num3 * num == 0)
					{
						@class = (Class7)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)(object)Class5.Default, (Type[])null, (ParameterModifier[])(object)Class5.Default);
					}
				}
			}
			try
			{
			}
			catch
			{
				try
				{
					num = default(UIntPtr);
					if (num == 0)
					{
						gClass2 = null;
					}
				}
				finally
				{
					try
					{
						_ = (Class8)(object)Class5.Default;
						class14 = null;
						_ = Class5.Default;
						Class7 class36 = @class;
						BindingFlags bindingFlags_29 = bindingFlags;
						bindingFlags = default(BindingFlags);
						class37 = (Class10)(object)class36.t(bindingFlags_29, null, null, (CultureInfo)(object)((Class7)null).t(bindingFlags, array5, (object)null, (CultureInfo)(object)Class5.Default));
						class37 = class37;
					}
					finally
					{
						_ = (Class4)((Class7)(object)Class5.Default).t(obj, type, cultureInfo);
						goto end_IL_1ef3;
					}
				}
				end_IL_1ef3:;
			}
			if (unchecked((nuint)(UIntPtr)Class5.Default) + (num - num) == 0)
			{
				class38 = class38;
			}
			_ = (Class2)(object)Class5.Default;
			while (obj != null)
			{
				qk = null;
			}
		}
		while (obj != null)
		{
			while (obj != null)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					struct2 = struct2;
				}
				else
				{
					_ = (Struct2)@class.e(bindingFlags, (MethodBase[])((Class7)null).t(obj, (Type)(object)((Class7)(object)Class5.Default).j(bindingFlags, array6, ref *(object[]*)null, array3, (CultureInfo)(object)Class5.Default, null, out *(object*)null), (CultureInfo)(object)@class.t(bindingFlags, array5, Class5.Default, cultureInfo)), array2, null);
				}
			}
		}
		_ = (GClass0)(object)Class5.Default;
		try
		{
			qk = qk;
		}
		finally
		{
			_ = (_003CModule_003E)(object)Class5.Default;
			goto IL_20e6;
		}
		IL_535b:
		_ = (Class7)(object)Class5.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass3 gClass4);
		try
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					gClass4 = gClass4;
				}
				finally
				{
					_ = (Struct1)Class5.Default;
					_ = (Class4)(object)((Class7)(object)@class.t(bindingFlags, array5, obj, cultureInfo)).t(bindingFlags, null, obj, null);
					goto end_IL_5366;
				}
			}
			end_IL_5366:;
		}
		catch
		{
			class9 = null;
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				qk = qk;
				_ = (Class4)(object)Class5.Default;
				MethodBase[] methodBase_14 = array6;
				Class7 class39 = @class;
				PropertyInfo[] propertyInfo_4 = array;
				Type type_5 = (Type)(object)((Class7)null).t(default(BindingFlags), (FieldInfo[])(object)((Class7)null).e(default(BindingFlags), (MethodBase[])null, array2, (ParameterModifier[])null), obj, cultureInfo);
				Type[] type_6 = array2;
				Class7 class40 = @class;
				bindingFlags = default(BindingFlags);
				_ = (GClass2)(object)((Class7)null).j(default(BindingFlags), methodBase_14, ref *(object[]*)null, (ParameterModifier[])(object)class39.W(default(BindingFlags), propertyInfo_4, type_5, type_6, (ParameterModifier[])(object)class40.e(bindingFlags, array6, array2, array3)), (CultureInfo)null, (string[])(object)Class5.Default, out *(object*)null);
			}
			else
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (Class7)(object)Class5.Default;
					gClass2 = gClass2;
				}
				else
				{
					class38 = (Class2)((Class7)null).t((object)@class.e(bindingFlags, null, null, null), (Type)null, cultureInfo);
					class9 = class9;
					gClass3 = gClass3;
					qk = qk;
				}
			}
			goto IL_555d;
		}
		try
		{
		}
		finally
		{
			try
			{
				_ = (_003CModule_003E)(object)Class5.Default;
			}
			catch
			{
				_ = (_003CModule_003E)(object)Class5.Default;
				_ = (GClass1)(object)Class5.Default;
				@class = @class;
				_ = (Class8)(object)Class5.Default;
			}
			goto IL_555d;
		}
		IL_214c:
		do
		{
			try
			{
				_ = (Struct1)Class5.Default;
				_ = (Class6)(object)Class5.Default;
			}
			finally
			{
				class37 = null;
				continue;
			}
		}
		while (obj != null || obj != null);
		while ((object)@class.t((BindingFlags)((Class7)(object)Class5.Default).e(bindingFlags, array6, (Type[])(object)@class.j((BindingFlags)Class5.Default, null, ref *(object[]*)Class5.Default, null, cultureInfo, (string[])(object)@class.e(bindingFlags, array6, null, (ParameterModifier[])(object)Class5.Default), out *(object*)Class5.Default), (ParameterModifier[])(object)Class5.Default), null, null, (CultureInfo)(object)Class5.Default) != null)
		{
			Class7 obj22 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_30 = bindingFlags;
			ref object[] object_11 = ref reference;
			ParameterModifier[] parameterModifier_7 = array3;
			CultureInfo cultureInfo_6 = (CultureInfo)@class.t(null, type, null);
			Class7 class41 = @class;
			BindingFlags bindingFlags_31 = (BindingFlags)@class.e(bindingFlags, array6, null, array3);
			Class7 class42 = @class;
			BindingFlags bindingFlags_32 = bindingFlags;
			Class7 class43 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_33 = bindingFlags;
			Class7 obj23 = (Class7)(object)@class.e((BindingFlags)((Class7)(object)Class5.Default).e((BindingFlags)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, (CultureInfo)@class.t(obj, type, cultureInfo)), array6, array2, null), (MethodBase[])(object)@class.e(bindingFlags, (MethodBase[])((Class7)(object)Class5.Default).t(Class5.Default, type, cultureInfo), (Type[])@class.t(Class5.Default, type, cultureInfo), null), array2, (ParameterModifier[])(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, (Type[])(object)Class5.Default, null));
			Class7 obj24 = (Class7)(object)@class.t((BindingFlags)@class.W(bindingFlags, array, (Type)(object)Class5.Default, array2, array3), (FieldInfo[])(object)((Class7)(object)Class5.Default).e(bindingFlags, null, array2, null), obj, cultureInfo);
			MethodBase[] methodBase_15 = array6;
			Class7 class44 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Class0)(object)obj22.j(bindingFlags_30, null, ref object_11, parameterModifier_7, cultureInfo_6, (string[])(object)class41.t(bindingFlags_31, null, null, (CultureInfo)(object)class42.t(bindingFlags_32, (FieldInfo[])(object)class43.t(bindingFlags_33, (FieldInfo[])obj23.t(((Class7)((Class7)(object)obj24.e(default(BindingFlags), methodBase_15, (Type[])(object)class44.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, null), array3)).t(null, type, cultureInfo)).t((BindingFlags)((Class7)null).t((BindingFlags)Class5.Default, array5, (object)Class5.Default, cultureInfo), null, obj, cultureInfo), type, cultureInfo), Class5.Default, cultureInfo), obj, null)), out *(object*)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)null, array2, (ParameterModifier[])null));
		}
		try
		{
			bindingFlags = default(BindingFlags);
			_ = (Class4)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, (CultureInfo)(object)Class5.Default);
		}
		catch
		{
			_ = (Class10)(object)Class5.Default;
		}
		try
		{
			while (true)
			{
				if (obj != null)
				{
					class32 = (Class9)(object)Class5.Default;
				}
				else if ((object)Class5.Default == null)
				{
					break;
				}
			}
		}
		catch
		{
			while (true)
			{
				Class7 class45 = @class;
				bindingFlags = default(BindingFlags);
				if ((object)class45.W(bindingFlags, null, null, array2, (ParameterModifier[])(object)Class5.Default) != null)
				{
					_ = (GClass0)(object)Class5.Default;
					continue;
				}
				break;
			}
		}
		try
		{
			class9 = class9;
		}
		finally
		{
			goto IL_256b;
		}
		IL_161a:
		try
		{
			Class7 class46;
			BindingFlags bindingFlags_34;
			Class7 class47;
			do
			{
				try
				{
					_003CModule_003E = _003CModule_003E;
				}
				catch
				{
					_ = (Qk7)(object)Class5.Default;
				}
				class46 = @class;
				bindingFlags_34 = bindingFlags;
				class47 = @class;
				bindingFlags = default(BindingFlags);
			}
			while ((object)class46.W(bindingFlags_34, (PropertyInfo[])(object)class47.e(bindingFlags, null, array2, array3), (Type)(object)((Class7)null).W(bindingFlags, array, type, array2, (ParameterModifier[])null), (Type[])(object)Class5.Default, null) != null);
		}
		finally
		{
			Class7 class48 = @class;
			BindingFlags bindingFlags_35 = bindingFlags;
			PropertyInfo[] propertyInfo_5 = (PropertyInfo[])(object)Class5.Default;
			Type type_7 = type;
			Type[] type_8 = (Type[])(object)Class5.Default;
			Class7 class49 = @class;
			BindingFlags bindingFlags_36 = (BindingFlags)((Class7)(object)Class5.Default).W(bindingFlags, array, type, array2, array3);
			FieldInfo[] fieldInfo_ = array5;
			BindingFlags bindingFlags_37 = (BindingFlags)@class.t(bindingFlags, null, ((Class7)null).W(default(BindingFlags), (PropertyInfo[])null, type, array2, (ParameterModifier[])null), cultureInfo);
			bindingFlags = default(BindingFlags);
			_ = (Class10)(object)class48.W(bindingFlags_35, propertyInfo_5, type_7, type_8, (ParameterModifier[])(object)class49.j((BindingFlags)((Class7)null).t(bindingFlags_36, fieldInfo_, (object)null, (CultureInfo)((Class7)(object)((Class7)null).t(bindingFlags_37, (FieldInfo[])(object)((Class7)null).t(bindingFlags, array5, obj, (CultureInfo)null), obj, cultureInfo)).t(null, type, cultureInfo)), array6, ref *(object[]*)null, array3, cultureInfo, (string[])(object)Class5.Default, out *(object*)Class5.Default));
			_003CModule_003E = (_003CModule_003E)(object)((Class7)(object)((Class7)null).e(bindingFlags, (MethodBase[])@class.t(null, (Type)(object)((Class7)null).j((BindingFlags)Class5.Default, (MethodBase[])null, ref *(object[]*)Class5.Default, array3, cultureInfo, (string[])null, out *(object*)@class.e(bindingFlags, array6, (Type[])(object)Class5.Default, null)), (CultureInfo)(object)Class5.Default), (Type[])@class.t(obj, type, cultureInfo), (ParameterModifier[])null)).j(bindingFlags, array6, ref *(object[]*)null, array3, (CultureInfo)(object)@class.e(bindingFlags, array6, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default), null, out reference2);
			_ = (Class4)(object)Class5.Default;
			_ = (Struct1)Class5.Default;
			goto IL_189d;
		}
		IL_3c8e:
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			gClass4 = gClass4;
		}
		try
		{
			try
			{
				try
				{
					gClass = (GClass1)(object)Class5.Default;
				}
				finally
				{
					gClass = (GClass1)(object)@class.W((BindingFlags)@class.t(obj, null, null), null, type, array2, (ParameterModifier[])(object)Class5.Default);
					goto end_IL_3ca8;
				}
				end_IL_3ca8:;
			}
			finally
			{
				_ = (Struct1)Class5.Default;
				goto end_IL_3ca7;
			}
			end_IL_3ca7:;
		}
		catch
		{
			try
			{
				while (true)
				{
					Class7 obj28 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					if ((object)obj28.t((BindingFlags)((Class7)null).t(bindingFlags, array5, (object)Class5.Default, cultureInfo), array5, obj, cultureInfo) != null)
					{
						_ = (Qk7)(object)Class5.Default;
						continue;
					}
					break;
				}
			}
			catch
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					class19 = Class5.Default;
				}
				else
				{
					gClass2 = (GClass0)(object)@class.e(bindingFlags, array6, array2, array3);
				}
			}
		}
		while ((object)@class.j((BindingFlags)((Class7)(object)Class5.Default).t(@class.t((BindingFlags)Class5.Default, null, Class5.Default, (CultureInfo)(object)Class5.Default), type, cultureInfo), (MethodBase[])(object)Class5.Default, ref *(object[]*)null, null, (CultureInfo)(object)((Class7)(object)((Class7)null).W(bindingFlags, array, type, (Type[])null, (ParameterModifier[])(object)Class5.Default)).j((BindingFlags)Class5.Default, null, ref *(object[]*)Class5.Default, null, cultureInfo, array4, out *(object*)Class5.Default), array4, out *(object*)Class5.Default) != null)
		{
			try
			{
				do
				{
					_003CModule_003E = null;
				}
				while (obj != null);
			}
			catch
			{
				try
				{
					_ = (Class7)(object)Class5.Default;
					Class7 obj31 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Class8)(object)obj31.W(bindingFlags, array, null, array2, (ParameterModifier[])(object)Class5.Default);
				}
				catch
				{
					class7 = class7;
					_ = (GClass1)(object)Class5.Default;
					Class7 class50 = @class;
					ref object[] object_12 = ref reference;
					Class7 class51 = @class;
					bindingFlags = default(BindingFlags);
					ParameterModifier[] parameterModifier_8 = (ParameterModifier[])(object)class51.W(bindingFlags, array, type, null, array3);
					CultureInfo cultureInfo_7 = cultureInfo;
					string[] string_4 = (string[])(object)((Class7)@class.t(@class.W(bindingFlags, array, type, (Type[])(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, (ParameterModifier[])null), array3), (Type)(object)((Class7)null).t(bindingFlags, array5, (object)null, cultureInfo), (CultureInfo)(object)Class5.Default)).e((BindingFlags)@class.j((BindingFlags)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, (ParameterModifier[])null), null, ref reference, array3, null, (string[])(object)Class5.Default, out reference2), null, null, array3);
					Class7 class52 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass0)(object)class50.j(default(BindingFlags), null, ref object_12, parameterModifier_8, cultureInfo_7, string_4, out *(object*)((Class7)null).W((BindingFlags)class52.t(bindingFlags, array5, obj, (CultureInfo)(object)Class5.Default), array, (Type)((Class7)null).t(obj, type, (CultureInfo)(object)Class5.Default), array2, array3));
					_003CModule_003E = null;
				}
			}
		}
		try
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Struct1)Class5.Default;
				}
				finally
				{
					_ = (_003CModule_003E)(object)@class.t(bindingFlags, array5, obj, cultureInfo);
					goto end_IL_4057;
				}
			}
			end_IL_4057:;
		}
		catch
		{
			while (obj != null)
			{
				@struct = default(Struct1);
			}
		}
		class14 = class14;
		Class7 obj36;
		do
		{
			if ((UIntPtr)((Class7)null).t(obj, type, cultureInfo) == (UIntPtr)(nuint)0u)
			{
				try
				{
					class14 = null;
				}
				catch
				{
					gClass3 = gClass3;
					class14 = (Class6)@class.t(obj, (Type)(object)Class5.Default, null);
					class37 = class37;
					_003CModule_003E = _003CModule_003E;
				}
			}
			obj36 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
		}
		while ((object)obj36.e(bindingFlags, array6, null, (ParameterModifier[])(object)Class5.Default) != null);
		try
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Class2)(object)Class5.Default;
				}
				catch
				{
					class9 = class9;
					_ = (Struct1)Class5.Default;
					gClass4 = gClass4;
					class9 = (Class8)(object)Class5.Default;
				}
			}
		}
		catch
		{
			struct2 = struct2;
			_003CModule_003E = null;
			_ = (Class9)@class.t(null, type, cultureInfo);
			@class = (Class7)(object)Class5.Default;
		}
		num = default(UIntPtr);
		checked
		{
			if (unchecked((nuint)default(UIntPtr)) - num == 0 && num == 0)
			{
				try
				{
					class9 = null;
				}
				finally
				{
					_ = (Struct2)@class.e(bindingFlags, array6, null, array3);
					goto IL_420b;
				}
			}
			goto IL_420b;
		}
		IL_0fbd:
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				num = default(UIntPtr);
				if (checked(num - unchecked((nuint)(UIntPtr)Class5.Default / num)) == 0)
				{
					_ = (GClass2)(object)((Class7)null).W(bindingFlags, array, type, array2, array3);
				}
				else
				{
					class19 = (Class5)(object)@class.j(bindingFlags, array6, ref reference, null, cultureInfo, (string[])(object)Class5.Default, out *(object*)Class5.Default);
					_ = (GClass1)(object)@class.j((BindingFlags)Class5.Default, array6, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo, array4, out *(object*)null);
					object object_13 = obj;
					Type type_9 = type;
					Class7 obj39 = (Class7)(object)((Class7)(object)Class5.Default).t(bindingFlags, null, obj, cultureInfo);
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_38 = bindingFlags;
					Class7 obj40 = (Class7)(object)@class.e(bindingFlags, null, array2, array3);
					bindingFlags = default(BindingFlags);
					Class7 obj41 = (Class7)(object)obj40.W(bindingFlags, array, type, array2, (ParameterModifier[])(object)Class5.Default);
					Class7 class53 = @class;
					BindingFlags bindingFlags_39 = (BindingFlags)@class.W(bindingFlags, array, null, array2, (ParameterModifier[])(object)Class5.Default);
					MethodBase[] methodBase_16 = array6;
					ref object[] object_14 = ref reference;
					ParameterModifier[] parameterModifier_9 = (ParameterModifier[])(object)@class.j((BindingFlags)((Class7)null).t(bindingFlags, array5, obj, (CultureInfo)null), array6, ref reference, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)Class5.Default, array4, out *(object*)null);
					CultureInfo cultureInfo_8 = cultureInfo;
					string[] string_5 = array4;
					Class7 class54 = @class;
					bindingFlags = default(BindingFlags);
					MethodBase[] methodBase_17 = (MethodBase[])(object)((Class7)null).j(bindingFlags_38, (MethodBase[])(object)obj41.t((BindingFlags)class53.j(bindingFlags_39, methodBase_16, ref object_14, parameterModifier_9, cultureInfo_8, string_5, out *(object*)class54.t(bindingFlags, array5, null, (CultureInfo)(object)Class5.Default)), array5, obj, (CultureInfo)(object)@class.e(bindingFlags, null, (Type[])(object)Class5.Default, (ParameterModifier[])(object)@class.e(bindingFlags, array6, array2, array3))), ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, (CultureInfo)null, (string[])null, out reference2);
					Class7 obj42 = (Class7)(object)Class5.Default;
					Class7 class55 = @class;
					bindingFlags = default(BindingFlags);
					Class7 obj43 = (Class7)(object)obj39.j(default(BindingFlags), methodBase_17, ref *(object[]*)obj42.j(default(BindingFlags), (MethodBase[])(object)((Class7)null).t(default(BindingFlags), (FieldInfo[])(object)class55.j(bindingFlags, array6, ref reference, (ParameterModifier[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, (Type[])((Class7)null).t(obj, type, cultureInfo), array3), cultureInfo, array4, out *(object*)null), (object)null, cultureInfo), ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, array4, out reference2), (ParameterModifier[])(object)((Class7)null).W(bindingFlags, array, type, array2, (ParameterModifier[])null), (CultureInfo)(object)Class5.Default, (string[])(object)@class.j(bindingFlags, (MethodBase[])@class.t(obj, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default), ref *(object[]*)Class5.Default, null, (CultureInfo)((Class7)null).t((object)null, (Type)null, cultureInfo), (string[])(object)Class5.Default, out *(object*)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, null, (CultureInfo)(object)Class5.Default, (string[])(object)((Class7)(object)@class.e(default(BindingFlags), array6, array2, null)).t(default(BindingFlags), array5, null, cultureInfo), out reference2)), out *(object*)null);
					bindingFlags = default(BindingFlags);
					_ = (Class9)((Class7)null).t(object_13, type_9, (CultureInfo)(object)obj43.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, array2, (ParameterModifier[])(object)Class5.Default));
					_ = (Class10)((Class7)(object)Class5.Default).t(null, type, cultureInfo);
				}
			}
			else
			{
				try
				{
					class14 = class14;
				}
				catch
				{
					_ = (GClass3)(object)@class.j(bindingFlags, null, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)Class5.Default, array4, out reference2);
				}
			}
		}
		else
		{
			class38 = (Class2)(object)Class5.Default;
			class38 = class38;
		}
		num = default(UIntPtr);
		if (checked(unchecked((nuint)default(UIntPtr)) + num) == 0)
		{
			try
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (Class7)(object)((Class7)(object)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, null, cultureInfo)).e(bindingFlags, null, array2, (ParameterModifier[])(object)Class5.Default);
				}
				else
				{
					Class7 obj45 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Struct2)((Class7)(object)obj45.j(bindingFlags, array6, ref *(object[]*)null, array3, cultureInfo, array4, out reference2)).t(Class5.Default, null, cultureInfo);
				}
			}
			finally
			{
				if (num == 0)
				{
					_ = (Class2)(object)Class5.Default;
				}
				else
				{
					class9 = null;
				}
				goto IL_161a;
			}
		}
		while (obj != null)
		{
			try
			{
				_ = (Struct2)Class5.Default;
				_003CModule_003E = (_003CModule_003E)@class.t(null, null, null);
				_003CModule_003E = _003CModule_003E;
				_ = (Class6)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)null, (Type[])null, (ParameterModifier[])null);
			}
			finally
			{
				Struct2 obj46 = (Struct2)((Class7)(object)Class5.Default).W(bindingFlags, null, (Type)(object)Class5.Default, null, (ParameterModifier[])(object)Class5.Default);
				struct2 = struct2;
				struct2 = obj46;
				continue;
			}
		}
		goto IL_161a;
		IL_376c:
		while (obj != null)
		{
			nuint num4 = num;
			num = default(UIntPtr);
			if (num4 / num == 0)
			{
				Class7 obj47 = (Class7)(object)Class5.Default;
				Class7 class56 = @class;
				BindingFlags bindingFlags_40 = (BindingFlags)Class5.Default;
				Class7 obj48 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				if ((UIntPtr)((Class7)(object)obj47.e((BindingFlags)class56.e(bindingFlags_40, (MethodBase[])(object)obj48.j(bindingFlags, array6, ref reference, null, null, array4, out reference2), array2, array3), array6, array2, (ParameterModifier[])((Class7)(object)Class5.Default).t(obj, type, null))).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, (Type[])(object)Class5.Default, array3) == (UIntPtr)(nuint)0u)
				{
					gClass = (GClass1)(object)Class5.Default;
				}
				else
				{
					_ = (Class8)(object)((Class7)(object)Class5.Default).t(default(BindingFlags), array5, null, cultureInfo);
				}
			}
			else
			{
				do
				{
					_ = (Struct2)@class.t(obj, type, cultureInfo);
				}
				while ((object)@class.t((BindingFlags)((Class7)(object)Class5.Default).t(null, type, cultureInfo), (FieldInfo[])(object)Class5.Default, null, (CultureInfo)(object)Class5.Default) != null);
			}
		}
		gClass = gClass;
		Class7 class57 = @class;
		bindingFlags = default(BindingFlags);
		if (checked(unchecked((nuint)(UIntPtr)class57.e(bindingFlags, array6, (Type[])(object)@class.t(bindingFlags, null, obj, cultureInfo), array3) / (nuint)(UIntPtr)Class5.Default) - num) / num == 0)
		{
			try
			{
				_ = Class5.Default;
			}
			catch
			{
				while ((object)@class.j(bindingFlags, null, ref reference, array3, (CultureInfo)((Class7)null).t(obj, (Type)(object)Class5.Default, (CultureInfo)null), array4, out reference2) != null)
				{
					class14 = null;
				}
			}
		}
		try
		{
			while (obj != null)
			{
				try
				{
					_ = Class5.Default;
				}
				catch
				{
					qk = null;
				}
			}
		}
		finally
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				BindingFlags bindingFlags_41 = (BindingFlags)Class5.Default;
				bindingFlags = default(BindingFlags);
				Class7 obj51 = (Class7)(object)((Class7)null).j(bindingFlags, array6, ref reference, array3, cultureInfo, array4, out reference2);
				BindingFlags bindingFlags_42 = bindingFlags;
				Class7 class58 = @class;
				bindingFlags = default(BindingFlags);
				if ((UIntPtr)((Class7)null).t(bindingFlags_41, (FieldInfo[])(object)obj51.e(bindingFlags_42, (MethodBase[])(object)class58.j(bindingFlags, array6, ref *(object[]*)@class.t(null, type, cultureInfo), array3, cultureInfo, array4, out *(object*)null), null, array3), (object)null, cultureInfo) == (UIntPtr)(nuint)0u)
				{
					struct2 = struct2;
				}
			}
			goto IL_390f;
		}
		IL_420b:
		gClass4 = gClass4;
		qk = null;
		_ = (Class6)(object)@class.W(bindingFlags, null, type, null, array3);
		_003CModule_003E = _003CModule_003E;
		if (num == 0)
		{
			class38 = class38;
		}
		try
		{
			try
			{
				_ = (Class0)(object)@class.t(bindingFlags, array5, @class.e(bindingFlags, (MethodBase[])((Class7)((Class7)null).t((object)null, type, (CultureInfo)null)).t(obj, type, cultureInfo), null, array3), null);
				_ = (GClass2)(object)((Class7)null).e(bindingFlags, array6, (Type[])null, array3);
				_ = (Struct2)Class5.Default;
				class14 = null;
			}
			catch
			{
				do
				{
					gClass4 = gClass4;
				}
				while (obj != null);
			}
		}
		catch
		{
			if (num == 0)
			{
				if (checked((num + num) * num) == 0)
				{
					_ = (GClass0)(object)Class5.Default;
				}
			}
			else
			{
				nuint num5 = num;
				UIntPtr num6 = (UIntPtr)Class5.Default;
				Class7 class59 = @class;
				BindingFlags bindingFlags_43 = (BindingFlags)@class.e(bindingFlags, null, array2, array3);
				PropertyInfo[] propertyInfo_6 = (PropertyInfo[])(object)((Class7)(object)Class5.Default).t(default(BindingFlags), array5, null, cultureInfo);
				Class7 class60 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_44 = bindingFlags;
				MethodBase[] methodBase_18 = (MethodBase[])(object)((Class7)null).j(bindingFlags, array6, ref reference, array3, cultureInfo, (string[])(object)((Class7)(object)Class5.Default).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, array2, array3), out reference2);
				Class7 obj53 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_45 = bindingFlags;
				BindingFlags bindingFlags_46 = bindingFlags;
				PropertyInfo[] propertyInfo_7 = array;
				BindingFlags bindingFlags_47 = bindingFlags;
				MethodBase[] methodBase_19 = array6;
				BindingFlags bindingFlags_48 = bindingFlags;
				BindingFlags bindingFlags_49 = bindingFlags;
				Class7 obj54 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				Class7 obj55 = (Class7)(object)((Class7)null).W(bindingFlags_48, (PropertyInfo[])(object)((Class7)null).j(bindingFlags_49, (MethodBase[])(object)obj54.W(bindingFlags, array, (Type)(object)@class.j(bindingFlags, array6, ref reference, array3, cultureInfo, null, out *(object*)((Class7)(object)Class5.Default).t(null, type, null)), (Type[])(object)Class5.Default, array3), ref reference, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)((Class7)(object)((Class7)(object)@class.e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, array2, array3)).t(bindingFlags, array5, obj, cultureInfo)).W((BindingFlags)Class5.Default, array, (Type)(object)@class.e(bindingFlags, array6, (Type[])(object)Class5.Default, array3), array2, array3), array4, out reference2), (Type)@class.t(@class.t(((Class7)null).e(bindingFlags, array6, array2, (ParameterModifier[])null), type, cultureInfo), (Type)(object)((Class7)(object)Class5.Default).W(bindingFlags, array, type, null, array3), null), array2, (ParameterModifier[])(object)Class5.Default);
				bindingFlags = default(BindingFlags);
				Class7 obj56 = (Class7)(object)obj53.j(bindingFlags_45, (MethodBase[])(object)((Class7)(object)((Class7)null).W(bindingFlags_46, propertyInfo_7, (Type)(object)((Class7)null).e(bindingFlags_47, methodBase_19, (Type[])(object)obj55.W(bindingFlags, array, (Type)(object)Class5.Default, null, array3), array3), array2, array3)).e((BindingFlags)((Class7)null).e(bindingFlags, array6, array2, array3), array6, (Type[])(object)Class5.Default, array3), ref *(object[]*)@class.t((BindingFlags)Class5.Default, array5, obj, cultureInfo), null, null, (string[])(object)((Class7)null).W((BindingFlags)((Class7)null).t(default(BindingFlags), (FieldInfo[])(object)Class5.Default, obj, (CultureInfo)null), array, (Type)null, (Type[])null, (ParameterModifier[])null), out *(object*)null);
				bindingFlags = default(BindingFlags);
				Type type_10 = (Type)(object)class60.j(bindingFlags_44, methodBase_18, ref *(object[]*)obj56.j(bindingFlags, (MethodBase[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, cultureInfo), ref *(object[]*)null, array3, cultureInfo, (string[])(object)@class.W((BindingFlags)Class5.Default, array, (Type)(object)Class5.Default, (Type[])(object)Class5.Default, array3), out *(object*)Class5.Default), array3, null, (string[])(object)((Class7)null).t(bindingFlags, array5, obj, (CultureInfo)null), out reference2);
				Class7 class61 = @class;
				BindingFlags bindingFlags_50 = bindingFlags;
				MethodBase[] methodBase_20 = array6;
				Class7 class62 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_51 = (BindingFlags)class61.e(bindingFlags_50, methodBase_20, (Type[])(object)class62.j(bindingFlags, array6, ref *(object[]*)Class5.Default, array3, cultureInfo, (string[])(object)Class5.Default, out reference2), (ParameterModifier[])(object)Class5.Default);
				Type type_11 = (Type)(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, cultureInfo);
				Class7 class63 = @class;
				bindingFlags = default(BindingFlags);
				Class7 obj57 = (Class7)(object)((Class7)null).W(bindingFlags_51, (PropertyInfo[])null, type_11, (Type[])(object)class63.j(bindingFlags, array6, ref reference, array3, (CultureInfo)(object)Class5.Default, array4, out *(object*)@class.t(bindingFlags, array5, obj, cultureInfo)), (ParameterModifier[])null);
				bindingFlags = default(BindingFlags);
				checked
				{
					nuint num7 = unchecked((nuint)num6) + unchecked((nuint)(UIntPtr)class59.W(bindingFlags_43, propertyInfo_6, type_10, (Type[])((Class7)(object)((Class7)null).t((BindingFlags)obj57.j(bindingFlags, (MethodBase[])(object)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])null, obj, (CultureInfo)null), ref reference, array3, cultureInfo, (string[])(object)@class.j((BindingFlags)Class5.Default, (MethodBase[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)(object)@class.W(bindingFlags, array, type, null, (ParameterModifier[])@class.t(((Class7)null).t(bindingFlags, array5, (object)Class5.Default, (CultureInfo)(object)Class5.Default), (Type)(object)Class5.Default, cultureInfo)), (Type[])null, array3), ref *(object[]*)null, null, (CultureInfo)((Class7)null).t((object)@class.e(bindingFlags, array6, array2, null), type, cultureInfo), array4, out reference2), out *(object*)null), (FieldInfo[])(object)((Class7)(object)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])null, type, (Type[])null, (ParameterModifier[])(object)Class5.Default)).e(default(BindingFlags), (MethodBase[])(object)Class5.Default, array2, null), (object)Class5.Default, (CultureInfo)(object)Class5.Default)).t(obj, null, cultureInfo), (ParameterModifier[])(object)Class5.Default));
					nuint num8 = num;
					Class7 class64 = @class;
					Class7 class65 = @class;
					bindingFlags = default(BindingFlags);
					if (num5 * (num7 - unchecked(num8 / (nuint)(UIntPtr)class64.W((BindingFlags)class65.j((BindingFlags)((Class7)null).j(bindingFlags, array6, ref *(object[]*)Class5.Default, (ParameterModifier[])null, cultureInfo, array4, out reference2), null, ref reference, null, cultureInfo, array4, out reference2), (PropertyInfo[])(object)Class5.Default, (Type)(object)Class5.Default, array2, (ParameterModifier[])((Class7)null).t((object)null, type, cultureInfo)) / num)) == 0)
					{
						_ = (Qk7)(object)@class.W(unchecked((BindingFlags)@class.W(bindingFlags, array, type, array2, array3)), (PropertyInfo[])(object)((Class7)null).t(bindingFlags, array5, (object)((Class7)null).e(bindingFlags, array6, (Type[])null, (ParameterModifier[])(object)Class5.Default), (CultureInfo)(object)Class5.Default), (Type)@class.t(null, null, (CultureInfo)(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, array3)), array2, null);
					}
					else
					{
						_ = (Class6)(object)unchecked(((Class7)null).W((BindingFlags)((Class7)null).t(obj, type, (CultureInfo)null), (PropertyInfo[])(object)Class5.Default, (Type)(object)((Class7)(object)Class5.Default).j((BindingFlags)@class.t(null, null, null), array6, ref reference, (ParameterModifier[])(object)@class.j(bindingFlags, null, ref *(object[]*)null, null, cultureInfo, array4, out *(object*)@class.t(((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])null, type, (Type[])null, (ParameterModifier[])null), (Type)(object)((Class7)@class.t(obj, type, null)).W(bindingFlags, null, (Type)(object)Class5.Default, null, array3), (CultureInfo)@class.t(obj, type, cultureInfo))), (CultureInfo)(object)Class5.Default, array4, out reference2), (Type[])null, array3));
					}
				}
			}
		}
		do
		{
			num = default(UIntPtr);
			if (num != 0)
			{
				Class7 class66 = @class;
				Type type_12 = type;
				Class7 class67 = @class;
				bindingFlags = default(BindingFlags);
				Class7 obj59 = (Class7)class66.t(null, type_12, (CultureInfo)(object)class67.W(bindingFlags, array, null, array2, array3));
				BindingFlags bindingFlags_52 = bindingFlags;
				FieldInfo[] fieldInfo_2 = array5;
				object object_15 = Class5.Default;
				Class7 class68 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_53 = bindingFlags;
				MethodBase[] methodBase_21 = (MethodBase[])(object)((Class7)(object)Class5.Default).e(bindingFlags, array6, array2, array3);
				ref object[] object_16 = ref *(object[]*)@class.t(obj, null, (CultureInfo)(object)Class5.Default);
				ParameterModifier[] parameterModifier_10 = (ParameterModifier[])(object)Class5.Default;
				string[] string_6 = (string[])(object)@class.e(default(BindingFlags), array6, (Type[])(object)Class5.Default, null);
				bindingFlags = default(BindingFlags);
				_ = (Qk7)(object)obj59.t(bindingFlags_52, fieldInfo_2, object_15, (CultureInfo)(object)class68.j(bindingFlags_53, methodBase_21, ref object_16, parameterModifier_10, null, string_6, out *(object*)((Class7)null).j(bindingFlags, array6, ref *(object[]*)null, array3, cultureInfo, (string[])(object)((Class7)null).j(bindingFlags, array6, ref reference, array3, (CultureInfo)null, array4, out reference2), out *(object*)null)));
			}
			else
			{
				class37 = (Class10)(object)Class5.Default;
			}
		}
		while ((object)Class5.Default != null);
		try
		{
			gClass = gClass;
		}
		finally
		{
			try
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					class14 = class14;
				}
			}
			catch
			{
				try
				{
					_ = (Struct2)((Class7)null).e(bindingFlags, (MethodBase[])(object)((Class7)(object)Class5.Default).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)(object)((Class7)(object)Class5.Default).W(bindingFlags, null, null, array2, null), array2, null), array2, (ParameterModifier[])@class.t(Class5.Default, type, cultureInfo));
				}
				finally
				{
					_ = (Class0)(object)((Class7)(object)Class5.Default).j(bindingFlags, array6, ref reference, (ParameterModifier[])@class.t(Class5.Default, type, cultureInfo), null, array4, out reference2);
					gClass2 = gClass2;
					Class7 class69 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_54 = bindingFlags;
					Class7 class70 = @class;
					BindingFlags bindingFlags_55 = bindingFlags;
					FieldInfo[] fieldInfo_3 = array5;
					object object_17 = Class5.Default;
					BindingFlags bindingFlags_56 = bindingFlags;
					MethodBase[] methodBase_22 = (MethodBase[])(object)Class5.Default;
					ParameterModifier[] parameterModifier_11 = (ParameterModifier[])(object)((Class7)null).W((BindingFlags)((Class7)@class.t(Class5.Default, (Type)(object)Class5.Default, (CultureInfo)(object)@class.e(bindingFlags, (MethodBase[])(object)((Class7)(object)((Class7)(object)Class5.Default).j(bindingFlags, null, ref reference, null, cultureInfo, (string[])(object)@class.j((BindingFlags)Class5.Default, array6, ref reference, null, cultureInfo, array4, out *(object*)Class5.Default), out *(object*)null)).t((BindingFlags)((Class7)null).t(obj, type, (CultureInfo)null), array5, obj, cultureInfo), (Type[])@class.t(obj, type, (CultureInfo)(object)Class5.Default), (ParameterModifier[])((Class7)(object)Class5.Default).t(obj, type, (CultureInfo)(object)Class5.Default)))).t(Class5.Default, null, cultureInfo), (PropertyInfo[])null, (Type)(object)Class5.Default, (Type[])null, (ParameterModifier[])((Class7)@class.t(obj, type, cultureInfo)).t(obj, null, cultureInfo));
					Class7 obj60 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (GClass1)(object)class69.j(bindingFlags_54, (MethodBase[])(object)((Class7)null).t((BindingFlags)class70.t(bindingFlags_55, fieldInfo_3, object_17, (CultureInfo)((Class7)null).t((object)null, (Type)(object)((Class7)null).j(bindingFlags_56, methodBase_22, ref *(object[]*)null, parameterModifier_11, (CultureInfo)(object)obj60.t(bindingFlags, array5, obj, cultureInfo), (string[])null, out *(object*)null), (CultureInfo)null)), array5, (object)null, (CultureInfo)null), ref *(object[]*)null, array3, null, null, out reference2);
					_ = (GClass0)(object)Class5.Default;
					goto end_IL_4d7a;
				}
				end_IL_4d7a:;
			}
			goto IL_5064;
		}
		IL_555d:
		checked
		{
			if (num == 0)
			{
				while (obj != null)
				{
					if (unchecked((nuint)(UIntPtr)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, array3)) + num == 0)
					{
						class9 = class9;
					}
				}
			}
			if (unchecked((nuint)(UIntPtr)Class5.Default) * unchecked((nuint)(UIntPtr)Class5.Default) == 0)
			{
				_ = (GClass2)(object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, null, null, array4, out reference2);
			}
			while (obj != null)
			{
				_003CModule_003E = _003CModule_003E;
			}
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				Class7 obj62 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_57 = bindingFlags;
				Class7 class71 = @class;
				BindingFlags bindingFlags_58 = bindingFlags;
				FieldInfo[] fieldInfo_4 = (FieldInfo[])(object)Class5.Default;
				object object_18 = Class5.Default;
				BindingFlags bindingFlags_59 = bindingFlags;
				MethodBase[] methodBase_23 = (MethodBase[])(object)Class5.Default;
				ref object[] object_19 = ref reference;
				ParameterModifier[] parameterModifier_12 = (ParameterModifier[])(object)Class5.Default;
				CultureInfo cultureInfo_9 = cultureInfo;
				Class7 obj63 = (Class7)(object)@class.W(bindingFlags, null, type, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
				BindingFlags bindingFlags_60 = bindingFlags;
				MethodBase[] methodBase_24 = array6;
				ref object[] object_20 = ref reference;
				BindingFlags bindingFlags_61 = (BindingFlags)Class5.Default;
				MethodBase[] methodBase_25 = array6;
				ref object[] object_21 = ref *(object[]*)Class5.Default;
				Class7 obj64 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_62 = bindingFlags;
				BindingFlags bindingFlags_63 = (BindingFlags)@class.t(obj, null, cultureInfo);
				PropertyInfo[] propertyInfo_8 = array;
				Type type_13 = (Type)(object)Class5.Default;
				Class7 class72 = @class;
				Class7 class73 = @class;
				BindingFlags bindingFlags_64 = bindingFlags;
				Type[] type_14 = array2;
				Class7 class74 = @class;
				BindingFlags bindingFlags_65 = bindingFlags;
				MethodBase[] methodBase_26 = (MethodBase[])(object)@class.e(bindingFlags, array6, array2, (ParameterModifier[])(object)Class5.Default);
				Class7 class75 = @class;
				BindingFlags bindingFlags_66 = bindingFlags;
				FieldInfo[] fieldInfo_5 = (FieldInfo[])(object)Class5.Default;
				object object_22 = Class5.Default;
				bindingFlags = default(BindingFlags);
				if ((UIntPtr)((Class7)(object)obj62.j(bindingFlags_57, null, ref *(object[]*)null, (ParameterModifier[])(object)((Class7)null).e((BindingFlags)((Class7)(object)((Class7)(object)class71.t(bindingFlags_58, fieldInfo_4, object_18, (CultureInfo)(object)((Class7)null).j(bindingFlags_59, methodBase_23, ref object_19, parameterModifier_12, cultureInfo_9, (string[])(object)obj63.j(bindingFlags_60, methodBase_24, ref object_20, (ParameterModifier[])(object)((Class7)null).e((BindingFlags)((Class7)null).j(bindingFlags_61, methodBase_25, ref object_21, (ParameterModifier[])null, (CultureInfo)(object)obj64.e(bindingFlags_62, (MethodBase[])(object)((Class7)null).W(bindingFlags_63, propertyInfo_8, type_13, (Type[])class72.t(null, (Type)(object)class73.e(bindingFlags_64, null, type_14, (ParameterModifier[])(object)class74.e(bindingFlags_65, methodBase_26, (Type[])(object)class75.t(bindingFlags_66, fieldInfo_5, object_22, (CultureInfo)(object)((Class7)null).j(bindingFlags, array6, ref reference, array3, (CultureInfo)null, array4, out *(object*)@class.W((BindingFlags)Class5.Default, (PropertyInfo[])(object)Class5.Default, null, array2, null))), array3)), (CultureInfo)(object)Class5.Default), array3), null, (ParameterModifier[])(object)Class5.Default), array4, out reference2), array6, array2, array3), (CultureInfo)(object)Class5.Default, (string[])(object)((Class7)(object)@class.j((BindingFlags)Class5.Default, null, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, array4, out *(object*)Class5.Default)).W((BindingFlags)Class5.Default, array, type, (Type[])(object)@class.j(bindingFlags, array6, ref reference, array3, null, (string[])(object)Class5.Default, out *(object*)null), array3), out reference2), out *(object*)null))).e(bindingFlags, null, array2, null)).t(obj, type, cultureInfo), array6, (Type[])(object)Class5.Default, array3), null, null, out *(object*)null)).e(bindingFlags, null, (Type[])(object)Class5.Default, null) == (UIntPtr)(nuint)0u)
				{
					gClass = null;
				}
				else
				{
					_ = (Class5)(object)@class.e((BindingFlags)Class5.Default, null, null, array3);
				}
			}
		}
		else
		{
			try
			{
			}
			catch
			{
				gClass4 = null;
			}
		}
		checked
		{
			try
			{
				try
				{
					do
					{
						struct2 = default(Struct2);
					}
					while (obj != null);
				}
				finally
				{
					num = default(UIntPtr);
					if (num * num - unchecked((nuint)(UIntPtr)Class5.Default) == 0)
					{
						_ = Class5.Default;
					}
					goto end_IL_5979;
				}
				end_IL_5979:;
			}
			catch
			{
				while (obj != null)
				{
					try
					{
						Class7 class76 = @class;
						bindingFlags = default(BindingFlags);
						_ = (Struct2)class76.W(unchecked((BindingFlags)((Class7)null).W(bindingFlags, array, type, array2, (ParameterModifier[])(object)Class5.Default)), null, type, null, null);
					}
					finally
					{
						_ = (Class2)(object)Class5.Default;
						continue;
					}
				}
			}
			num = default(UIntPtr);
			if (unchecked((nuint)default(UIntPtr)) + num == 0)
			{
				_ = (Struct2)Class5.Default;
			}
			else
			{
				try
				{
					_ = (GClass3)@class.t(obj, (Type)(object)Class5.Default, null);
				}
				catch
				{
					if (num == 0)
					{
						class7 = class7;
					}
				}
			}
		}
		while (true)
		{
			if ((object)Class5.Default != null)
			{
				Class7 obj68 = (Class7)(object)((Class7)null).e(bindingFlags, array6, (Type[])null, array3);
				bindingFlags = default(BindingFlags);
				class38 = (Class2)(object)((Class7)(object)obj68.e(bindingFlags, array6, array2, (ParameterModifier[])(object)Class5.Default)).j(bindingFlags, null, ref *(object[]*)null, (ParameterModifier[])(object)((Class7)(object)Class5.Default).W(bindingFlags, array, type, array2, array3), cultureInfo, array4, out *(object*)null);
				_ = (GClass0)(object)@class.W((BindingFlags)@class.t(null, (Type)(object)Class5.Default, cultureInfo), array, (Type)(object)Class5.Default, null, array3);
				gClass4 = gClass4;
			}
			else if (obj == null)
			{
				break;
			}
		}
		_ = (Class0)(object)Class5.Default;
		_003CModule_003E = _003CModule_003E;
		_ = (Struct2)Class5.Default;
		_003CModule_003E = _003CModule_003E;
		return;
		IL_312b:
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			do
			{
				try
				{
					class37 = null;
				}
				finally
				{
					gClass4 = gClass4;
					continue;
				}
			}
			while ((object)@class.e(bindingFlags, array6, array2, (ParameterModifier[])(object)Class5.Default) != null);
		}
		do
		{
			class7 = class7;
		}
		while (obj != null);
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			if (unchecked((nuint)default(UIntPtr)) / unchecked((nuint)default(UIntPtr)) == 0)
			{
				_ = (Class7)(object)Class5.Default;
			}
		}
		else if (num == (UIntPtr)(nuint)0u)
		{
			_ = (GClass2)((Class7)(object)@class.e(bindingFlags, array6, array2, (ParameterModifier[])(object)Class5.Default)).t(Class5.Default, type, (CultureInfo)(object)Class5.Default);
		}
		num = default(UIntPtr);
		if (num == 0)
		{
			while (obj != null)
			{
				do
				{
					_ = (GClass0)(object)Class5.Default;
				}
				while ((object)Class5.Default != null);
			}
		}
		class9 = class9;
		while (((Class7)null).t(obj, (Type)@class.t(obj, type, cultureInfo), cultureInfo) != null)
		{
			class9 = (Class8)(object)((Class7)(object)@class.t((BindingFlags)@class.e(bindingFlags, array6, array2, array3), array5, null, (CultureInfo)(object)@class.e(bindingFlags, null, null, array3))).t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, obj, cultureInfo);
			qk = null;
		}
		if (num == 0)
		{
			Class7 class77 = @class;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)class77.t(bindingFlags, array5, obj, null) == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Class6)(object)Class5.Default;
					_ = (GClass2)(object)Class5.Default;
				}
				else
				{
					@class = @class;
				}
			}
		}
		else
		{
			while (obj != null)
			{
				struct2 = struct2;
			}
		}
		class37 = (Class10)(object)@class.e(bindingFlags, null, (Type[])(object)Class5.Default, array3);
		try
		{
			Class7 class78 = @class;
			BindingFlags bindingFlags_67 = bindingFlags;
			MethodBase[] methodBase_27 = (MethodBase[])(object)Class5.Default;
			ref object[] object_23 = ref *(object[]*)Class5.Default;
			ParameterModifier[] parameterModifier_13 = array3;
			Class7 class79 = @class;
			BindingFlags bindingFlags_68 = bindingFlags;
			Class7 class80 = @class;
			BindingFlags bindingFlags_69 = bindingFlags;
			PropertyInfo[] propertyInfo_9 = (PropertyInfo[])(object)Class5.Default;
			Class7 obj69 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			PropertyInfo[] propertyInfo_10 = (PropertyInfo[])(object)class80.W(bindingFlags_69, propertyInfo_9, null, (Type[])(object)obj69.j(bindingFlags, null, ref reference, null, cultureInfo, array4, out *(object*)Class5.Default), null);
			Type[] type_15 = (Type[])(object)@class.W(bindingFlags, array, (Type)(object)Class5.Default, array2, array3);
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_70 = bindingFlags;
			FieldInfo[] fieldInfo_6 = (FieldInfo[])(object)Class5.Default;
			Class7 class81 = @class;
			bindingFlags = default(BindingFlags);
			checked
			{
				if (unchecked((nuint)(UIntPtr)((Class7)(object)class78.j(bindingFlags_67, methodBase_27, ref object_23, parameterModifier_13, null, (string[])(object)class79.W(bindingFlags_68, propertyInfo_10, null, type_15, (ParameterModifier[])(object)((Class7)null).t(bindingFlags_70, fieldInfo_6, (object)((Class7)(object)class81.t(bindingFlags, array5, Class5.Default, (CultureInfo)(object)@class.W((BindingFlags)Class5.Default, (PropertyInfo[])(object)@class.j((BindingFlags)((Class7)null).t(obj, type, cultureInfo), (MethodBase[])(object)Class5.Default, ref reference, (ParameterModifier[])(object)@class.W(bindingFlags, array, type, null, array3), (CultureInfo)(object)Class5.Default, array4, out reference2), null, array2, array3))).t(bindingFlags, array5, obj, (CultureInfo)(object)((Class7)null).e(bindingFlags, array6, array2, array3)), (CultureInfo)(object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array3, cultureInfo, null, out *(object*)null))), out reference2)).t(obj, (Type)(object)Class5.Default, cultureInfo)) + (unchecked((nuint)(UIntPtr)Class5.Default) + unchecked((nuint)(UIntPtr)Class5.Default)) == 0)
				{
					if (num == 0)
					{
						_ = (Class2)(object)Class5.Default;
					}
					else
					{
						@struct = @struct;
					}
				}
			}
		}
		finally
		{
			try
			{
				class5 = null;
				_ = (GClass0)(object)Class5.Default;
			}
			catch
			{
				_ = (Class6)(object)@class.j(bindingFlags, array6, ref reference, array3, cultureInfo, array4, out reference2);
			}
			goto IL_376c;
		}
		IL_256b:
		try
		{
			_ = (Struct2)Class5.Default;
		}
		catch
		{
			class37 = null;
		}
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					Class7 class82 = @class;
					Class7 class83 = @class;
					bindingFlags = default(BindingFlags);
					Class7 obj72 = (Class7)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, array3);
					Class7 class84 = @class;
					BindingFlags bindingFlags_71 = bindingFlags;
					Class7 obj73 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					Class7 obj74 = (Class7)(object)obj73.t(bindingFlags, null, null, (CultureInfo)(object)@class.t((BindingFlags)((Class7)null).t(bindingFlags, array5, obj, cultureInfo), array5, obj, cultureInfo));
					Class7 class85 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class4)(object)class82.t((BindingFlags)class83.e((BindingFlags)obj72.j((BindingFlags)class84.t(bindingFlags_71, (FieldInfo[])(object)obj74.j((BindingFlags)class85.W(bindingFlags, null, type, (Type[])(object)Class5.Default, null), array6, ref reference, array3, null, array4, out reference2), obj, cultureInfo), array6, ref *(object[]*)@class.t(obj, type, cultureInfo), array3, cultureInfo, null, out *(object*)null), null, array2, array3), (FieldInfo[])(object)((Class7)null).j(bindingFlags, array6, ref *(object[]*)null, array3, (CultureInfo)null, array4, out *(object*)null), null, cultureInfo);
				}
			}
			else
			{
				while ((object)Class5.Default != null)
				{
					_ = (Class10)((Class7)(object)Class5.Default).t(obj, (Type)(object)Class5.Default, cultureInfo);
				}
			}
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u && num == (UIntPtr)(nuint)0u)
		{
			gClass = null;
			class19 = class19;
			_ = (GClass1)(object)Class5.Default;
			class32 = (Class9)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)(object)Class5.Default, (Type[])null, array3);
		}
		if ((UIntPtr)@class.t(obj, type, null) == (UIntPtr)(nuint)0u)
		{
			class14 = null;
		}
		num = default(UIntPtr);
		if (num == 0)
		{
			do
			{
				gClass4 = gClass4;
				gClass4 = gClass4;
			}
			while (obj != null);
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			num = default(UIntPtr);
			checked
			{
				if (unchecked((nuint)default(UIntPtr)) + num == 0)
				{
					do
					{
						class32 = class32;
					}
					while (obj != null);
				}
				else
				{
					try
					{
						class7 = class7;
						gClass2 = gClass2;
					}
					catch
					{
						gClass = null;
					}
				}
			}
		}
		else
		{
			_ = (Class4)(object)Class5.Default;
		}
		_ = (GClass1)(object)Class5.Default;
		do
		{
			try
			{
				@class = null;
			}
			finally
			{
				class5 = null;
				continue;
			}
		}
		while (obj != null);
		try
		{
			try
			{
				Class7 class86 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class6)(object)class86.t(bindingFlags, null, obj, null);
			}
			finally
			{
				class5 = class5;
				goto end_IL_285a;
			}
			end_IL_285a:;
		}
		catch
		{
			Class7 class87 = @class;
			Class7 class88 = @class;
			BindingFlags bindingFlags_72 = bindingFlags;
			FieldInfo[] fieldInfo_7 = array5;
			Class7 obj76 = (Class7)((Class7)(object)Class5.Default).t(obj, type, cultureInfo);
			BindingFlags bindingFlags_73 = bindingFlags;
			Class7 class89 = @class;
			BindingFlags bindingFlags_74 = bindingFlags;
			Class7 class90 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_75 = (BindingFlags)class88.t(bindingFlags_72, fieldInfo_7, null, (CultureInfo)(object)((Class7)(object)obj76.t(bindingFlags_73, null, class89.t(bindingFlags_74, null, class90.j(bindingFlags, array6, ref *(object[]*)null, array3, cultureInfo, array4, out *(object*)null), cultureInfo), null)).t(bindingFlags, (FieldInfo[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])@class.t(Class5.Default, type, cultureInfo), (object)null, cultureInfo), obj, cultureInfo));
			PropertyInfo[] propertyInfo_11 = array;
			Type type_16 = type;
			Type[] type_17 = (Type[])(object)Class5.Default;
			Class7 class91 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Qk7)(object)class87.W(bindingFlags_75, propertyInfo_11, type_16, type_17, (ParameterModifier[])(object)class91.j(bindingFlags, array6, ref reference, null, cultureInfo, array4, out *(object*)@class.W(bindingFlags, null, type, null, null)));
		}
		try
		{
			_ = (Class9)(object)@class.e(bindingFlags, null, array2, array3);
		}
		catch
		{
			if (num != 0)
			{
				try
				{
					_ = (Class8)(object)@class.W(bindingFlags, array, null, array2, null);
				}
				finally
				{
					class9 = null;
					goto end_IL_29f1;
				}
			}
			while (obj != null)
			{
				class38 = class38;
				@class = @class;
				class14 = (Class6)(object)Class5.Default;
				_ = (Struct2)Class5.Default;
			}
			end_IL_29f1:;
		}
		do
		{
			if (num == 0)
			{
				_ = (Class9)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, cultureInfo);
			}
		}
		while (obj != null);
		if ((UIntPtr)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, null, cultureInfo, array4, out reference2) == (UIntPtr)(nuint)0u)
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				_ = (Qk7)(object)@class.t(bindingFlags, array5, Class5.Default, cultureInfo);
				class32 = class32;
				class38 = class38;
			}
		}
		Class7 class92 = @class;
		bindingFlags = default(BindingFlags);
		_ = (_003CModule_003E)(object)class92.W(bindingFlags, array, null, (Type[])(object)((Class7)(object)Class5.Default).j(bindingFlags, null, ref *(object[]*)Class5.Default, array3, cultureInfo, (string[])(object)Class5.Default, out reference2), array3);
		@class = null;
		while ((object)@class.t((BindingFlags)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)null, (CultureInfo)null), array5, null, cultureInfo) != null)
		{
			do
			{
				try
				{
					_ = (Class9)(object)@class.e((BindingFlags)Class5.Default, (MethodBase[])(object)@class.e(bindingFlags, null, null, (ParameterModifier[])(object)@class.j(bindingFlags, null, ref *(object[]*)Class5.Default, null, cultureInfo, null, out *(object*)Class5.Default)), null, array3);
				}
				finally
				{
					_ = (Class8)(object)@class.W(bindingFlags, (PropertyInfo[])(object)@class.W((BindingFlags)((Class7)(object)@class.j(bindingFlags, null, ref reference, array3, null, (string[])(object)Class5.Default, out reference2)).e(bindingFlags, array6, null, null), array, (Type)(object)((Class7)(object)Class5.Default).t(bindingFlags, (FieldInfo[])(object)Class5.Default, @class.e(bindingFlags, array6, null, array3), null), array2, array3), null, (Type[])(object)Class5.Default, array3);
					_ = (Class7)(object)Class5.Default;
					continue;
				}
			}
			while (obj != null);
		}
		_ = (GClass0)(object)Class5.Default;
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			_ = (Struct2)Class5.Default;
		}
		else
		{
			_ = (GClass1)(object)((Class7)(object)Class5.Default).j((BindingFlags)@class.j((BindingFlags)@class.t(bindingFlags, null, obj, cultureInfo), null, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo, array4, out reference2), array6, ref *(object[]*)null, null, null, (string[])(object)Class5.Default, out *(object*)Class5.Default);
		}
		_ = (Struct1)Class5.Default;
		if ((UIntPtr)@class.t(null, type, (CultureInfo)(object)Class5.Default) == (UIntPtr)(nuint)0u)
		{
			class14 = (Class6)(object)((Class7)(object)@class.W(bindingFlags, array, type, (Type[])(object)Class5.Default, (ParameterModifier[])(object)((Class7)null).j((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, ref reference, (ParameterModifier[])null, cultureInfo, array4, out *(object*)null))).t(bindingFlags, array5, null, null);
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			@class = @class;
		}
		else
		{
			_ = (Class4)(object)((Class7)(object)Class5.Default).j(bindingFlags, null, ref reference, (ParameterModifier[])(object)((Class7)(object)Class5.Default).W(bindingFlags, array, null, array2, array3), cultureInfo, array4, out reference2);
			_ = (GClass2)(object)Class5.Default;
		}
		if (num == 0)
		{
			while (obj != null)
			{
				if (num == 0)
				{
					class14 = class14;
					continue;
				}
				_ = (GClass1)(object)@class.j(bindingFlags, array6, ref reference, array3, (CultureInfo)(object)Class5.Default, array4, out *(object*)null);
				class38 = (Class2)(object)Class5.Default;
				class19 = class19;
			}
		}
		while (obj != null)
		{
		}
		gClass3 = (GClass2)(object)Class5.Default;
		if ((nuint)(UIntPtr)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, cultureInfo) / (nuint)(UIntPtr)Class5.Default == 0)
		{
			while ((object)Class5.Default != null)
			{
				_ = (_003CModule_003E)(object)Class5.Default;
			}
		}
		else if (unchecked((nuint)default(UIntPtr)) / unchecked((nuint)default(UIntPtr)) == 0)
		{
			_ = (Class7)(object)Class5.Default;
		}
		gClass3 = (GClass2)(object)@class.W(bindingFlags, array, type, array2, array3);
		checked
		{
			try
			{
				if (unchecked((nuint)(UIntPtr)Class5.Default / (nuint)(UIntPtr)Class5.Default) + unchecked((nuint)(UIntPtr)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, (Type[])(object)Class5.Default, array3)) == 0)
				{
					while (obj != null)
					{
						gClass2 = null;
					}
				}
			}
			finally
			{
				do
				{
					if (unchecked((nuint)(UIntPtr)@class.W(bindingFlags, null, null, null, array3)) - unchecked((nuint)default(UIntPtr)) != 0)
					{
						Class7 class93 = @class;
						unchecked
						{
							BindingFlags bindingFlags_76 = (BindingFlags)Class5.Default;
							ParameterModifier[] parameterModifier_14 = array3;
							CultureInfo cultureInfo_10 = cultureInfo;
							Class7 obj79 = (Class7)(object)Class5.Default;
							Class7 obj80 = (Class7)(object)Class5.Default;
							bindingFlags = default(BindingFlags);
							_ = (Class10)(object)class93.j(bindingFlags_76, null, ref *(object[]*)null, parameterModifier_14, cultureInfo_10, (string[])(object)obj79.W((BindingFlags)obj80.e(bindingFlags, (MethodBase[])(object)((Class7)null).e(bindingFlags, (MethodBase[])null, array2, (ParameterModifier[])(object)Class5.Default), array2, array3), (PropertyInfo[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, cultureInfo), type, (Type[])(object)Class5.Default, (ParameterModifier[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)@class.W(bindingFlags, null, (Type)(object)@class.e(bindingFlags, (MethodBase[])(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, null), array2, array3), null, null), type, array2, (ParameterModifier[])null)), out reference2);
							_ = (GClass0)(object)Class5.Default;
						}
					}
					else
					{
						class38 = class38;
					}
				}
				while (obj != null);
				goto IL_312b;
			}
		}
		IL_390f:
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			do
			{
				_ = (GClass2)(object)Class5.Default;
				_ = (Class0)(object)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, array5, null, null);
			}
			while ((object)Class5.Default != null);
		}
		else
		{
			while (((Class7)null).t(obj, (Type)(object)Class5.Default, cultureInfo) != null)
			{
				struct2 = struct2;
			}
		}
		gClass4 = (GClass3)(object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array3, (CultureInfo)(object)Class5.Default, array4, out *(object*)Class5.Default);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					Class7 class94 = @class;
					BindingFlags bindingFlags_77 = (BindingFlags)Class5.Default;
					FieldInfo[] fieldInfo_8 = (FieldInfo[])(object)Class5.Default;
					Class7 class95 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class0)(object)((Class7)(object)class94.t(bindingFlags_77, fieldInfo_8, class95.j(bindingFlags, (MethodBase[])((Class7)(object)Class5.Default).t(null, type, cultureInfo), ref reference, null, (CultureInfo)(object)Class5.Default, array4, out reference2), null)).W(bindingFlags, null, (Type)(object)((Class7)(object)((Class7)(object)Class5.Default).e(bindingFlags, array6, null, array3)).j((BindingFlags)((Class7)null).j((BindingFlags)Class5.Default, array6, ref reference, array3, (CultureInfo)null, array4, out reference2), array6, ref *(object[]*)Class5.Default, array3, cultureInfo, array4, out *(object*)Class5.Default), array2, array3);
					gClass3 = gClass3;
					Class7 class96 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Struct2)class96.t(bindingFlags, array5, null, cultureInfo);
				}
				finally
				{
					struct2 = default(Struct2);
					struct2 = struct2;
					goto end_IL_39d7;
				}
				end_IL_39d7:;
			}
			finally
			{
				_ = (Class5)(object)@class.t(bindingFlags, null, Class5.Default, cultureInfo);
				goto IL_3bc0;
			}
		}
		try
		{
			while ((object)Class5.Default != null)
			{
				BindingFlags bindingFlags_78 = bindingFlags;
				bindingFlags = default(BindingFlags);
				gClass2 = (GClass0)(object)((Class7)null).j(bindingFlags_78, (MethodBase[])(object)((Class7)null).e(bindingFlags, array6, array2, (ParameterModifier[])(object)Class5.Default), ref *(object[]*)Class5.Default, array3, cultureInfo, array4, out reference2);
			}
		}
		finally
		{
			_ = (Class8)(object)Class5.Default;
			goto IL_3bc0;
		}
		IL_20e6:
		while (obj != null)
		{
			try
			{
				_003CModule_003E = null;
				class37 = class37;
				@class = @class;
			}
			catch
			{
				num = default(UIntPtr);
				if (num / num == 0)
				{
					class32 = null;
					class32 = class32;
				}
				else
				{
					class14 = (Class6)(object)Class5.Default;
				}
			}
		}
		try
		{
			do
			{
				_ = (GClass0)(object)@class.t(bindingFlags, array5, obj, cultureInfo);
			}
			while (obj != null || obj != null);
		}
		finally
		{
			do
			{
				_ = (Class7)(object)Class5.Default;
			}
			while (obj != null || ((Class7)null).t((object)null, type, cultureInfo) != null);
			goto IL_214c;
		}
	}

	unsafe static void smethod_6()
	{
		_003CModule_003E _003CModule_003E = _003CModule_003E;
		_003CModule_003E = _003CModule_003E;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type);
		object obj2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] array2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] array3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] array4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class7 class2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class4 @class);
		BindingFlags bindingFlags;
		while (true)
		{
			@class = @class;
			@class = @class;
			Class7 obj = (Class7)(object)Class5.Default;
			object object_ = Class5.Default;
			type = type;
			obj2 = obj.t(object_, type, (CultureInfo)(object)Class5.Default);
			if (obj2 == null)
			{
				class2 = class2;
				Class7 class3 = class2;
				bindingFlags = default(BindingFlags);
				array = array;
				MethodBase[] methodBase_ = array;
				Class7 class4 = class2;
				Class7 class5 = class2;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_ = bindingFlags;
				array2 = array2;
				PropertyInfo[] propertyInfo_ = array2;
				Type type_ = type;
				Type[] type_2 = (Type[])(object)Class5.Default;
				array3 = array3;
				array4 = (Type[])(object)class4.e(default(BindingFlags), (MethodBase[])(object)class5.W(bindingFlags_, propertyInfo_, type_, type_2, array3), array4, array3);
				if ((object)class3.e(default(BindingFlags), methodBase_, array4, null) == null)
				{
					break;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object[] reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string[] array5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class6 class9);
		try
		{
			Class7 class6 = class2;
			Type type_3 = type;
			Class7 obj3 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_2 = bindingFlags;
			MethodBase[] methodBase_2 = (MethodBase[])(object)Class5.Default;
			Class7 class7 = class2;
			BindingFlags bindingFlags_3 = bindingFlags;
			Class7 class8 = class2;
			bindingFlags = default(BindingFlags);
			reference = ref *(object[]*)class8.t(bindingFlags, null, null, (CultureInfo)(object)class2.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, (CultureInfo)(object)Class5.Default));
			ref object[] object_2 = ref reference;
			ParameterModifier[] parameterModifier_ = array3;
			cultureInfo = cultureInfo;
			CultureInfo cultureInfo_ = cultureInfo;
			array5 = array5;
			_ = (Struct1)class6.t(obj2, type_3, (CultureInfo)(object)obj3.j(bindingFlags_2, methodBase_2, ref *(object[]*)class7.j(bindingFlags_3, null, ref object_2, parameterModifier_, cultureInfo_, array5, out *(object*)null), (ParameterModifier[])(object)Class5.Default, null, (string[])(object)Class5.Default, out *(object*)null));
		}
		catch
		{
			while (obj2 != null)
			{
				Class6 obj4 = (Class6)(object)Class5.Default;
				class9 = (Class6)(object)Class5.Default;
				class9 = obj4;
			}
		}
		nuint uIntPtr = (UIntPtr)Class5.Default;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object object_4);
		GClass1 gClass;
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			do
			{
				try
				{
					_ = (Qk7)((Class7)null).t((object)null, type, (CultureInfo)null);
					Class7 class10 = class2;
					BindingFlags bindingFlags_4 = bindingFlags;
					MethodBase[] methodBase_3 = array;
					ref object[] object_3 = ref *(object[]*)((Class7)(object)Class5.Default).t(null, type, cultureInfo);
					ParameterModifier[] parameterModifier_2 = array3;
					CultureInfo cultureInfo_2 = cultureInfo;
					string[] string_ = array5;
					object_4 = ref *(object*)Class5.Default;
					_ = (Class7)(object)((Class7)null).W((BindingFlags)class10.j(bindingFlags_4, methodBase_3, ref object_3, parameterModifier_2, cultureInfo_2, string_, out object_4), array2, type, array4, array3);
					_ = Class5.Default;
				}
				finally
				{
					Class7 class11 = class2;
					bindingFlags = default(BindingFlags);
					_ = (Class2)(object)class11.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, (Type[])(object)class2.t(bindingFlags, null, obj2, null), array3);
					continue;
				}
			}
			while (obj2 != null);
		}
		else
		{
			while ((object)Class5.Default != null)
			{
				gClass = null;
				gClass = gClass;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qk7 qk);
		do
		{
			if (uIntPtr != (UIntPtr)(nuint)0u)
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					qk = qk;
					qk = qk;
				}
				else
				{
					class2 = (Class7)(object)Class5.Default;
				}
			}
			else if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Class8)(object)Class5.Default;
			}
		}
		while (obj2 != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out FieldInfo[] array6);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct2 @struct);
		Class8 class13;
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				try
				{
					Class7 class12 = class2;
					array6 = (FieldInfo[])(object)Class5.Default;
					Class7 obj6 = (Class7)(object)class12.t(default(BindingFlags), array6, obj2, (CultureInfo)(object)((Class7)(object)Class5.Default).j((BindingFlags)Class5.Default, array, ref reference, null, cultureInfo, array5, out *(object*)null));
					bindingFlags = default(BindingFlags);
					Class7 obj7 = (Class7)(object)((Class7)(object)obj6.j(bindingFlags, array, ref reference, null, (CultureInfo)(object)((Class7)(object)Class5.Default).j(bindingFlags, array, ref reference, array3, cultureInfo, (string[])(object)Class5.Default, out object_4), array5, out *(object*)((Class7)null).t(bindingFlags, array6, obj2, cultureInfo))).j(default(BindingFlags), array, ref *(object[]*)class2.t(class2.t(default(BindingFlags), null, obj2, null), null, (CultureInfo)(object)Class5.Default), array3, cultureInfo, (string[])(object)Class5.Default, out *(object*)null);
					bindingFlags = default(BindingFlags);
					_ = (GClass0)(object)obj7.j(bindingFlags, (MethodBase[])(object)class2.t(bindingFlags, array6, null, cultureInfo), ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)class2.e((BindingFlags)Class5.Default, array, null, array3), null, out *(object*)null);
				}
				finally
				{
					class13 = null;
					goto end_IL_0386;
				}
			}
			end_IL_0386:;
		}
		catch
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					@struct = default(Struct2);
				}
				else
				{
					Class7 class14 = class2;
					bindingFlags = default(BindingFlags);
					_ = (Class8)(object)((Class7)null).t(default(BindingFlags), (FieldInfo[])null, ((Class7)null).t(obj2, (Type)(object)class14.e(default(BindingFlags), (MethodBase[])(object)((Class7)null).e(bindingFlags, array, array4, array3), null, (ParameterModifier[])(object)class2.t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, (CultureInfo)(object)class2.e(bindingFlags, array, null, (ParameterModifier[])(object)Class5.Default))), (CultureInfo)(object)class2.t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, null)), cultureInfo);
				}
			}
			else
			{
				gClass = null;
			}
		}
		_ = (Class6)(object)Class5.Default;
		GClass3 obj9 = (GClass3)(object)class2.e((BindingFlags)Class5.Default, array, null, array3);
		GClass3 gClass2 = null;
		gClass2 = obj9;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class2 class15);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass2 gClass3);
		try
		{
			try
			{
				gClass3 = null;
				gClass3 = gClass3;
			}
			finally
			{
				gClass2 = null;
				goto end_IL_068b;
			}
			end_IL_068b:;
		}
		catch
		{
			try
			{
				Class2 obj10 = (Class2)(object)((Class7)((Class7)(object)Class5.Default).t(null, null, (CultureInfo)class2.t(obj2, type, null))).e((BindingFlags)Class5.Default, null, array4, array3);
				class15 = class15;
				class15 = obj10;
			}
			finally
			{
				_ = (GClass2)(object)Class5.Default;
				goto end_IL_06a4;
			}
			end_IL_06a4:;
		}
		finally
		{
			goto IL_0710;
		}
		IL_2c86:
		while ((object)Class5.Default != null)
		{
		}
		Class5 class16 = (Class5)(object)((Class7)null).j(bindingFlags, array, ref reference, array3, cultureInfo, array5, out *(object*)null);
		while (obj2 != null)
		{
			class15 = null;
		}
		_ = (Class4)(object)Class5.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass0 gClass4);
		do
		{
			UIntPtr num = (UIntPtr)Class5.Default;
			uIntPtr = default(UIntPtr);
			if ((nuint)num / uIntPtr != 0)
			{
				while (obj2 != null)
				{
					_ = (Qk7)(object)class2.e(bindingFlags, null, array4, array3);
					gClass4 = gClass4;
					_ = (Class4)(object)class2.t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, cultureInfo);
				}
			}
			else if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				gClass3 = gClass3;
			}
			else
			{
				class2 = (Class7)(object)Class5.Default;
			}
		}
		while (obj2 != null);
		if ((UIntPtr)class2.t(obj2, null, cultureInfo) == (UIntPtr)(nuint)0u)
		{
			checked
			{
				do
				{
					FieldInfo[] fieldInfo_ = (FieldInfo[])(object)Class5.Default;
					Class7 obj12 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					if (unchecked((nuint)(UIntPtr)((Class7)null).t(default(BindingFlags), fieldInfo_, (object)obj12.t(bindingFlags, array6, obj2, null), (CultureInfo)null)) * uIntPtr != 0)
					{
						gClass = gClass;
					}
					else
					{
						_ = (Class9)((Class7)null).t(obj2, type, (CultureInfo)(object)Class5.Default);
					}
				}
				while ((object)Class5.Default != null);
			}
		}
		else
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					Class7 class17 = class2;
					bindingFlags = default(BindingFlags);
					_ = (Class4)(object)class17.W(bindingFlags, array2, type, array4, array3);
				}
				else
				{
					@struct = default(Struct2);
				}
			}
			else
			{
				try
				{
					@class = (Class4)(object)Class5.Default;
				}
				catch
				{
					_ = (Class6)(object)class2.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, cultureInfo);
				}
			}
		}
		try
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
					object object_5 = Class5.Default;
					Class7 class18 = class2;
					BindingFlags bindingFlags_5 = bindingFlags;
					MethodBase[] methodBase_4 = (MethodBase[])(object)class2.j(bindingFlags, array, ref reference, (ParameterModifier[])class2.t(null, null, null), (CultureInfo)class2.t(obj2, type, cultureInfo), (string[])(object)Class5.Default, out *(object*)null);
					Type[] type_4 = array4;
					Class7 class19 = class2;
					bindingFlags = default(BindingFlags);
					class9 = (Class6)((Class7)null).t(object_5, (Type)(object)class18.e(bindingFlags_5, methodBase_4, type_4, (ParameterModifier[])(object)class19.t(bindingFlags, array6, null, (CultureInfo)(object)class2.e(bindingFlags, (MethodBase[])(object)class2.t(bindingFlags, array6, null, cultureInfo), array4, array3))), cultureInfo);
					Class7 class20 = class2;
					BindingFlags bindingFlags_6 = (BindingFlags)Class5.Default;
					MethodBase[] methodBase_5 = array;
					ref object[] object_6 = ref reference;
					BindingFlags bindingFlags_7 = (BindingFlags)((Class7)(object)Class5.Default).W(bindingFlags, (PropertyInfo[])(object)((Class7)null).t((BindingFlags)Class5.Default, array6, obj2, (CultureInfo)null), (Type)(object)Class5.Default, array4, (ParameterModifier[])(object)Class5.Default);
					Class7 class21 = class2;
					bindingFlags = default(BindingFlags);
					_ = (Struct2)class20.j(bindingFlags_6, methodBase_5, ref object_6, (ParameterModifier[])(object)((Class7)null).t(bindingFlags_7, (FieldInfo[])(object)class21.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, cultureInfo), (object)null, (CultureInfo)null), (CultureInfo)(object)Class5.Default, array5, out object_4);
					class9 = class9;
					goto end_IL_2eb1;
				}
				end_IL_2eb1:;
			}
			finally
			{
				try
				{
					_ = (Class6)(object)Class5.Default;
				}
				finally
				{
					_ = (Class6)(object)Class5.Default;
					Class7 class22 = class2;
					BindingFlags bindingFlags_8 = bindingFlags;
					MethodBase[] methodBase_6 = (MethodBase[])(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Class6)(object)class22.j(bindingFlags_8, methodBase_6, ref *(object[]*)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, array3, cultureInfo, array5, out object_4), (ParameterModifier[])(object)((Class7)null).t(bindingFlags, array6, (object)null, cultureInfo), null, array5, out *(object*)Class5.Default);
					goto end_IL_2eb0;
				}
			}
			end_IL_2eb0:;
		}
		finally
		{
			class9 = null;
			goto IL_310e;
		}
		IL_46ea:
		uIntPtr = default(UIntPtr);
		Class10 class23;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class0 class24);
		if (uIntPtr == 0)
		{
			if ((nuint)(UIntPtr)class2.W(bindingFlags, null, type, array4, array3) / uIntPtr == 0)
			{
				do
				{
					@struct = (Struct2)Class5.Default;
				}
				while (obj2 != null);
			}
			else
			{
				while (obj2 != null)
				{
					bindingFlags = default(BindingFlags);
					_ = (Struct2)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])(object)((Class7)(object)Class5.Default).t(bindingFlags, array6, obj2, null), (ParameterModifier[])null);
				}
			}
		}
		else
		{
			try
			{
				try
				{
					class23 = class23;
					_ = (Qk7)(object)Class5.Default;
					_ = (Class6)(object)((Class7)(object)Class5.Default).j(bindingFlags, array, ref reference, array3, cultureInfo, null, out *(object*)Class5.Default);
				}
				catch
				{
					@struct = @struct;
				}
			}
			catch
			{
				if (uIntPtr == 0)
				{
					_ = (Struct2)Class5.Default;
					class24 = class24;
					_ = (Struct1)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, array2, type, array4, array3);
					_ = (Class7)(object)Class5.Default;
				}
				else
				{
					class15 = class15;
				}
			}
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				Class7 class25 = class2;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_9 = (BindingFlags)class25.t(bindingFlags, array6, obj2, cultureInfo);
				MethodBase[] methodBase_7 = (MethodBase[])(object)Class5.Default;
				ref object[] object_7 = ref reference;
				bindingFlags = default(BindingFlags);
				_ = (GClass1)(object)((Class7)null).j(bindingFlags_9, methodBase_7, ref object_7, (ParameterModifier[])(object)((Class7)null).e(bindingFlags, array, (Type[])((Class7)(object)Class5.Default).t(obj2, type, null), array3), cultureInfo, (string[])(object)Class5.Default, out object_4);
			}
			catch
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					class15 = class15;
					_ = (Class10)((Class7)(object)Class5.Default).t(obj2, (Type)(object)((Class7)(object)((Class7)(object)Class5.Default).j(bindingFlags, array, ref reference, (ParameterModifier[])(object)class2.t(bindingFlags, array6, null, null), (CultureInfo)(object)Class5.Default, array5, out *(object*)null)).W(default(BindingFlags), array2, type, array4, null), null);
					gClass2 = null;
					Class7 obj16 = (Class7)class2.t(null, null, cultureInfo);
					bindingFlags = default(BindingFlags);
					class16 = (Class5)(object)obj16.t(bindingFlags, null, Class5.Default, cultureInfo);
				}
			}
			goto IL_4a55;
		}
		try
		{
			_ = (Struct2)Class5.Default;
		}
		finally
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				bindingFlags = default(BindingFlags);
				class13 = (Class8)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, array4, (ParameterModifier[])(object)Class5.Default);
			}
			else
			{
				bindingFlags = default(BindingFlags);
				class24 = (Class0)(object)((Class7)null).j(bindingFlags, array, ref reference, array3, (CultureInfo)(object)Class5.Default, array5, out object_4);
			}
			goto IL_4a55;
		}
		IL_4f40:
		UIntPtr num2 = (UIntPtr)class2.t(obj2, type, cultureInfo);
		Class7 class26 = class2;
		bindingFlags = default(BindingFlags);
		if ((nuint)num2 / (nuint)(UIntPtr)class26.e(bindingFlags, null, (Type[])(object)Class5.Default, array3) == 0)
		{
			class15 = class15;
		}
		_ = (Struct1)Class5.Default;
		while (obj2 != null)
		{
			do
			{
				try
				{
					class24 = (Class0)(object)((Class7)null).e(bindingFlags, array, array4, (ParameterModifier[])(object)Class5.Default);
				}
				finally
				{
					_ = (Class5)(object)class2.t(bindingFlags, array6, obj2, (CultureInfo)(object)Class5.Default);
					continue;
				}
			}
			while (obj2 != null);
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (GClass2)(object)class2.j(default(BindingFlags), (MethodBase[])(object)Class5.Default, ref *(object[]*)null, null, cultureInfo, array5, out object_4);
					_ = (Qk7)((Class7)null).t(obj2, (Type)null, (CultureInfo)(object)class2.e((BindingFlags)class2.j((BindingFlags)class2.t(((Class7)null).t(obj2, type, cultureInfo), type, cultureInfo), array, ref reference, array3, cultureInfo, array5, out object_4), array, null, null));
					_ = (Class8)(object)Class5.Default;
				}
				finally
				{
					_ = (Struct1)class2.e(default(BindingFlags), null, array4, null);
					goto IL_51fa;
				}
			}
			try
			{
				class13 = class13;
				gClass = gClass;
			}
			catch
			{
				class24 = class24;
				_ = (Qk7)(object)class2.W(bindingFlags, array2, type, (Type[])((Class7)(object)((Class7)null).W((BindingFlags)class2.W(bindingFlags, array2, type, array4, (ParameterModifier[])(object)((Class7)null).j(bindingFlags, array, ref reference, array3, cultureInfo, (string[])(object)Class5.Default, out object_4)), array2, (Type)null, array4, array3)).t(Class5.Default, null, cultureInfo), null);
				class23 = (Class10)(object)class2.e(bindingFlags, null, null, (ParameterModifier[])(object)Class5.Default);
				class23 = class23;
			}
		}
		else if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			gClass2 = (GClass3)(object)Class5.Default;
		}
		goto IL_51fa;
		IL_51fa:
		class15 = class15;
		do
		{
			_ = (Class4)(object)Class5.Default;
		}
		while (obj2 != null || (object)Class5.Default != null);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				do
				{
					_ = (Qk7)(object)Class5.Default;
				}
				while (obj2 != null);
				return;
			}
			catch
			{
				while (obj2 != null)
				{
					gClass4 = null;
				}
				return;
			}
		}
		gClass2 = gClass2;
		return;
		IL_3d45:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct1 struct2);
		try
		{
			_ = (Class6)(object)Class5.Default;
		}
		catch
		{
			try
			{
				gClass3 = (GClass2)(object)Class5.Default;
			}
			catch
			{
				gClass2 = gClass2;
				@class = @class;
				class24 = null;
				class16 = null;
			}
		}
		finally
		{
			struct2 = default(Struct1);
			goto IL_3d9a;
		}
		IL_23fb:
		_ = (Struct2)Class5.Default;
		while (obj2 != null)
		{
			class15 = (Class2)(object)Class5.Default;
		}
		_ = (Class7)(object)class2.j((BindingFlags)Class5.Default, array, ref reference, null, null, array5, out *(object*)null);
		Class7 class27 = class2;
		bindingFlags = default(BindingFlags);
		UIntPtr num3 = (UIntPtr)class27.e(bindingFlags, array, array4, array3);
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class9 class28);
		if ((nuint)num3 / uIntPtr == 0)
		{
			uIntPtr = default(UIntPtr);
			if (unchecked((nuint)default(UIntPtr)) / uIntPtr == 0)
			{
				try
				{
					_ = (Class5)(object)class2.t(bindingFlags, null, Class5.Default, cultureInfo);
				}
				catch
				{
					class28 = class28;
				}
			}
			else
			{
				do
				{
					class24 = class24;
					gClass4 = null;
				}
				while ((object)Class5.Default != null);
			}
		}
		else
		{
			_ = (Class8)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])null, (ParameterModifier[])null);
		}
		while (true)
		{
			Class7 class29 = class2;
			bindingFlags = default(BindingFlags);
			if ((object)class29.j(bindingFlags, array, ref reference, null, cultureInfo, null, out object_4) == null)
			{
				break;
			}
			try
			{
				_ = (Class7)(object)class2.t(default(BindingFlags), array6, null, null);
			}
			catch
			{
				do
				{
					_ = (Class7)class2.t(obj2, (Type)(object)Class5.Default, null);
				}
				while (obj2 != null);
			}
		}
		_ = (Struct1)class2.j(bindingFlags, (MethodBase[])(object)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, null, array4, array3), ref reference, array3, cultureInfo, (string[])(object)Class5.Default, out *(object*)Class5.Default);
		try
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Class0)(object)Class5.Default;
				}
				finally
				{
					_ = (Class4)(object)Class5.Default;
					goto end_IL_25d5;
				}
			}
			end_IL_25d5:;
		}
		catch
		{
			if (uIntPtr == 0)
			{
				do
				{
					struct2 = (Struct1)Class5.Default;
					_ = (Struct2)Class5.Default;
					class23 = class23;
				}
				while (obj2 != null);
			}
			else
			{
				while (obj2 != null)
				{
					Class7 obj24 = (Class7)(object)class2.t(bindingFlags, null, null, null);
					bindingFlags = default(BindingFlags);
					_ = (Class4)(object)obj24.W(bindingFlags, null, (Type)(object)Class5.Default, null, null);
				}
			}
		}
		_ = (Class2)(object)Class5.Default;
		if ((nuint)(UIntPtr)Class5.Default / uIntPtr == 0)
		{
			try
			{
				if (uIntPtr == 0)
				{
					class15 = class15;
				}
				else
				{
					Class7 obj26 = (Class7)(object)((Class7)null).e((BindingFlags)Class5.Default, array, (Type[])null, (ParameterModifier[])(object)Class5.Default);
					BindingFlags bindingFlags_10 = bindingFlags;
					Class7 obj27 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (GClass3)(object)obj26.t(bindingFlags_10, (FieldInfo[])(object)obj27.W(bindingFlags, array2, type, null, null), Class5.Default, (CultureInfo)(object)Class5.Default);
					@struct = (Struct2)Class5.Default;
				}
			}
			catch
			{
				try
				{
					class23 = class23;
					@struct = (Struct2)class2.t(bindingFlags, array6, obj2, cultureInfo);
					gClass = null;
					class16 = null;
				}
				catch
				{
					class15 = (Class2)(object)Class5.Default;
				}
			}
		}
		while (obj2 != null)
		{
		}
		if ((UIntPtr)((Class7)(object)class2.j(default(BindingFlags), array, ref *(object[]*)null, null, cultureInfo, array5, out object_4)).t(obj2, type, cultureInfo) == (UIntPtr)(nuint)0u)
		{
			_ = (GClass0)(object)Class5.Default;
		}
		gClass3 = gClass3;
		class24 = class24;
		_ = (Struct2)Class5.Default;
		Class7 class30 = class2;
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_11 = bindingFlags;
		MethodBase[] methodBase_8 = (MethodBase[])(object)class2.W(bindingFlags, null, (Type)(object)((Class7)null).W(default(BindingFlags), (PropertyInfo[])(object)Class5.Default, (Type)(object)Class5.Default, (Type[])(object)class2.W((BindingFlags)Class5.Default, (PropertyInfo[])(object)((Class7)null).e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, (Type[])null, (ParameterModifier[])(object)Class5.Default), null, (Type[])(object)Class5.Default, (ParameterModifier[])(object)((Class7)null).t(default(BindingFlags), array6, (object)null, (CultureInfo)null)), (ParameterModifier[])null), array4, null);
		ref object[] object_8 = ref reference;
		Class7 class31 = class2;
		bindingFlags = default(BindingFlags);
		_ = (GClass3)(object)class30.j(bindingFlags_11, methodBase_8, ref object_8, null, (CultureInfo)(object)class31.e(bindingFlags, array, array4, array3), null, out *(object*)null);
		Class7 class32 = class2;
		BindingFlags bindingFlags_12 = bindingFlags;
		Class7 class33 = class2;
		BindingFlags bindingFlags_13 = bindingFlags;
		PropertyInfo[] propertyInfo_2 = (PropertyInfo[])(object)Class5.Default;
		Type[] type_5 = array4;
		Class7 class34 = class2;
		FieldInfo[] fieldInfo_2 = (FieldInfo[])(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		class24 = (Class0)(object)class32.j(bindingFlags_12, null, ref *(object[]*)class33.W(bindingFlags_13, propertyInfo_2, null, type_5, (ParameterModifier[])(object)class34.t(default(BindingFlags), fieldInfo_2, obj2, (CultureInfo)(object)((Class7)null).j(bindingFlags, array, ref reference, array3, cultureInfo, array5, out object_4))), null, cultureInfo, (string[])(object)Class5.Default, out object_4);
		try
		{
			try
			{
				try
				{
					_ = (GClass0)(object)Class5.Default;
				}
				finally
				{
					@class = @class;
					goto end_IL_2988;
				}
				end_IL_2988:;
			}
			finally
			{
				try
				{
					Class7 class35 = class2;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_14 = bindingFlags;
					PropertyInfo[] propertyInfo_3 = (PropertyInfo[])(object)((Class7)(object)Class5.Default).j((BindingFlags)Class5.Default, null, ref reference, (ParameterModifier[])(object)((Class7)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, array4, (ParameterModifier[])null)).e(bindingFlags, array, null, null), (CultureInfo)(object)Class5.Default, array5, out *(object*)Class5.Default);
					Type type_6 = (Type)(object)Class5.Default;
					Class7 class36 = class2;
					bindingFlags = default(BindingFlags);
					Class7 obj30 = (Class7)(object)class36.e(bindingFlags, array, array4, (ParameterModifier[])(object)class2.t(bindingFlags, array6, obj2, null));
					bindingFlags = default(BindingFlags);
					class23 = (Class10)(object)((Class7)(object)class35.W(bindingFlags_14, propertyInfo_3, type_6, (Type[])(object)obj30.W(bindingFlags, null, null, array4, array3), array3)).e((BindingFlags)Class5.Default, null, array4, null);
				}
				catch
				{
					Class7 obj31 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_15 = bindingFlags;
					MethodBase[] methodBase_9 = (MethodBase[])(object)Class5.Default;
					CultureInfo cultureInfo_3 = (CultureInfo)(object)((Class7)null).t((BindingFlags)((Class7)null).e((BindingFlags)Class5.Default, (MethodBase[])(object)class2.W(bindingFlags, array2, null, array4, null), (Type[])null, array3), array6, (object)null, cultureInfo);
					string[] string_2 = array5;
					Class7 obj32 = (Class7)((Class7)(object)((Class7)(object)class2.W(bindingFlags, array2, type, array4, array3)).e((BindingFlags)Class5.Default, array, array4, null)).t(Class5.Default, type, cultureInfo);
					BindingFlags bindingFlags_16 = bindingFlags;
					MethodBase[] methodBase_10 = (MethodBase[])(object)((Class7)null).W(bindingFlags, array2, type, array4, (ParameterModifier[])null);
					Class7 class37 = class2;
					bindingFlags = default(BindingFlags);
					_ = (GClass3)(object)obj31.j(bindingFlags_15, methodBase_9, ref *(object[]*)null, null, cultureInfo_3, string_2, out *(object*)obj32.e(bindingFlags_16, methodBase_10, (Type[])(object)class37.t(bindingFlags, null, obj2, null), null));
				}
				goto end_IL_2987;
			}
			end_IL_2987:;
		}
		catch
		{
			while (obj2 != null)
			{
				try
				{
					gClass2 = gClass2;
				}
				catch
				{
					_ = (Struct2)Class5.Default;
				}
			}
		}
		try
		{
			if (uIntPtr == 0)
			{
				_ = (GClass0)(object)Class5.Default;
			}
		}
		catch
		{
			while ((object)Class5.Default != null)
			{
				Class7 class38 = class2;
				bindingFlags = default(BindingFlags);
				_ = (GClass2)(object)class38.W(bindingFlags, null, type, null, (ParameterModifier[])(object)class2.W(bindingFlags, array2, (Type)(object)Class5.Default, array4, array3));
			}
		}
		finally
		{
			_ = (Class4)(object)Class5.Default;
			goto IL_2c86;
		}
		IL_310e:
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			_ = (GClass3)(object)Class5.Default;
		}
		else
		{
			try
			{
				_ = (Class9)(object)Class5.Default;
			}
			catch
			{
				class16 = null;
			}
		}
		try
		{
			class16 = class16;
		}
		catch
		{
			Class7 obj38 = (Class7)class2.t(obj2, type, cultureInfo);
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)obj38.t(bindingFlags, array6, obj2, cultureInfo) != (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Class7)(object)Class5.Default;
				}
				finally
				{
					_ = (Class7)(object)class2.W((BindingFlags)class2.j(bindingFlags, array, ref reference, array3, null, null, out object_4), null, null, array4, null);
					goto end_IL_314b;
				}
			}
			_ = (GClass2)(object)class2.t((BindingFlags)Class5.Default, null, obj2, null);
			end_IL_314b:;
		}
		struct2 = struct2;
		Class7 obj40 = (Class7)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		Class7 obj41 = (Class7)(object)((Class7)null).t((BindingFlags)obj40.e(bindingFlags, array, null, (ParameterModifier[])(object)Class5.Default), (FieldInfo[])null, (object)null, (CultureInfo)null);
		BindingFlags bindingFlags_17 = bindingFlags;
		MethodBase[] methodBase_11 = array;
		Class7 class39 = class2;
		bindingFlags = default(BindingFlags);
		_ = (_003CModule_003E)(object)obj41.j(bindingFlags_17, methodBase_11, ref *(object[]*)class39.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)(object)Class5.Default, array4, array3), array3, cultureInfo, array5, out object_4);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = (Class4)(object)Class5.Default;
		}
		_ = (GClass1)(object)Class5.Default;
		gClass = null;
		@struct = @struct;
		class13 = null;
		_ = (Class2)(object)((Class7)(object)Class5.Default).j(bindingFlags, array, ref reference, null, cultureInfo, (string[])class2.t(obj2, (Type)((Class7)null).t(obj2, (Type)(object)Class5.Default, cultureInfo), cultureInfo), out object_4);
		while (obj2 != null)
		{
			try
			{
				try
				{
					_ = (Class8)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)(object)class2.e(bindingFlags, (MethodBase[])(object)((Class7)null).t(bindingFlags, array6, obj2, (CultureInfo)null), array4, (ParameterModifier[])class2.t(obj2, null, (CultureInfo)((Class7)(object)Class5.Default).t(null, (Type)((Class7)(object)Class5.Default).t(obj2, (Type)(object)Class5.Default, null), cultureInfo))), array4, array3);
					_ = (Class4)(object)Class5.Default;
				}
				finally
				{
					_ = (GClass3)(object)Class5.Default;
					goto end_IL_3336;
				}
				end_IL_3336:;
			}
			finally
			{
				try
				{
					Class7 obj42 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Class9)(object)obj42.j(bindingFlags, null, ref *(object[]*)Class5.Default, null, (CultureInfo)(object)Class5.Default, null, out object_4);
					class13 = (Class8)(object)Class5.Default;
					gClass = gClass;
				}
				catch
				{
					class16 = null;
					_ = (_003CModule_003E)(object)Class5.Default;
				}
				continue;
			}
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (Class8)(object)class2.j((BindingFlags)class2.W(bindingFlags, (PropertyInfo[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)class2.W(bindingFlags, array2, type, array4, array3), obj2, cultureInfo), type, array4, array3), (MethodBase[])(object)Class5.Default, ref *(object[]*)null, array3, cultureInfo, (string[])(object)Class5.Default, out object_4);
			}
			catch
			{
				gClass3 = (GClass2)(object)Class5.Default;
			}
			finally
			{
				while (obj2 != null)
				{
					Class7 class40 = class2;
					bindingFlags = default(BindingFlags);
					_ = (Class5)(object)class40.j(bindingFlags, array, ref reference, (ParameterModifier[])(object)Class5.Default, null, null, out *(object*)((Class7)null).t(obj2, type, cultureInfo));
				}
				goto IL_356c;
			}
		}
		_ = (Struct2)Class5.Default;
		goto IL_356c;
		IL_1892:
		gClass2 = gClass2;
		while ((object)class2.t((BindingFlags)class2.j(bindingFlags, array, ref reference, array3, cultureInfo, (string[])((Class7)null).t(obj2, (Type)null, (CultureInfo)(object)class2.W((BindingFlags)Class5.Default, array2, type, (Type[])(object)class2.e(bindingFlags, null, null, array3), (ParameterModifier[])(object)Class5.Default)), out object_4), array6, obj2, null) != null)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_18 = bindingFlags;
				Class7 obj45 = (Class7)(object)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, array6, obj2, null);
				BindingFlags bindingFlags_19 = bindingFlags;
				MethodBase[] methodBase_12 = array;
				ref object[] object_9 = ref reference;
				ParameterModifier[] parameterModifier_3 = array3;
				CultureInfo cultureInfo_4 = (CultureInfo)(object)class2.W((BindingFlags)Class5.Default, null, type, array4, array3);
				Class7 class41 = class2;
				Type type_7 = type;
				Class7 obj46 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				_ = (Class2)(object)((Class7)null).t(bindingFlags_18, (FieldInfo[])null, (object)obj45.j(bindingFlags_19, methodBase_12, ref object_9, parameterModifier_3, cultureInfo_4, (string[])class41.t(obj2, type_7, (CultureInfo)(object)obj46.e(bindingFlags, array, array4, array3)), out *(object*)null), cultureInfo);
				_ = (Class7)(object)class2.j((BindingFlags)Class5.Default, null, ref reference, null, cultureInfo, null, out object_4);
				class28 = class28;
				class28 = class28;
			}
			else
			{
				do
				{
					_003CModule_003E = null;
					_ = (_003CModule_003E)(object)Class5.Default;
					Class7 class42 = class2;
					bindingFlags = default(BindingFlags);
					_ = (Class5)(object)class42.t(bindingFlags, (FieldInfo[])(object)Class5.Default, ((Class7)(object)Class5.Default).e(bindingFlags, array, array4, array3), cultureInfo);
				}
				while ((object)Class5.Default != null);
			}
		}
		while (obj2 != null)
		{
			do
			{
				try
				{
					class13 = null;
				}
				finally
				{
					_ = (Class9)(object)Class5.Default;
					continue;
				}
			}
			while (obj2 != null);
		}
		checked
		{
			while ((object)Class5.Default != null)
			{
				while (true)
				{
					Class7 class43 = class2;
					bindingFlags = default(BindingFlags);
					if ((object)class43.W(bindingFlags, array2, type, array4, array3) == null)
					{
						break;
					}
					uIntPtr = default(UIntPtr);
					if (unchecked(uIntPtr / uIntPtr) + unchecked((nuint)default(UIntPtr)) == 0)
					{
						_ = (Struct2)class2.t(bindingFlags, (FieldInfo[])(object)class2.t(default(BindingFlags), array6, Class5.Default, null), null, cultureInfo);
					}
					else
					{
						_ = (Class6)(object)unchecked(((Class7)((Class7)null).t((object)Class5.Default, (Type)null, (CultureInfo)null)).j(bindingFlags, array, ref *(object[]*)null, array3, null, null, out *(object*)null));
					}
				}
			}
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				while (obj2 != null)
				{
				}
			}
			while ((object)Class5.Default != null)
			{
				try
				{
					if (uIntPtr == 0)
					{
						_ = (GClass1)(object)Class5.Default;
					}
				}
				catch
				{
					qk = (Qk7)(object)Class5.Default;
				}
			}
			nuint num4 = uIntPtr;
			Class7 class44 = class2;
			bindingFlags = default(BindingFlags);
			if (num4 * unchecked((nuint)(UIntPtr)class44.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, null)) == 0)
			{
				unchecked
				{
					nuint num5 = unchecked((nuint)default(UIntPtr)) / unchecked((nuint)default(UIntPtr));
					uIntPtr = default(UIntPtr);
					if (checked(num5 + uIntPtr) == 0)
					{
						class15 = class15;
						@struct = @struct;
						_ = (GClass1)(object)class2.e(default(BindingFlags), null, array4, null);
						qk = qk;
					}
					else
					{
						_ = (GClass3)(object)((Class7)(object)((Class7)(object)Class5.Default).e(bindingFlags, array, array4, null)).W((BindingFlags)((Class7)(object)((Class7)(object)Class5.Default).W((BindingFlags)class2.t(bindingFlags, null, obj2, null), array2, type, array4, (ParameterModifier[])(object)class2.j(default(BindingFlags), array, ref reference, array3, cultureInfo, array5, out object_4))).e(default(BindingFlags), array, null, array3), array2, null, array4, array3);
					}
					goto IL_1dee;
				}
			}
		}
		try
		{
			try
			{
				gClass = null;
			}
			finally
			{
				_003CModule_003E = _003CModule_003E;
				_ = (Class5)(object)class2.j(bindingFlags, null, ref *(object[]*)null, array3, null, array5, out object_4);
				class24 = (Class0)(object)Class5.Default;
				_ = (GClass0)(object)class2.e(bindingFlags, array, (Type[])(object)Class5.Default, null);
				goto end_IL_1d6e;
			}
			end_IL_1d6e:;
		}
		finally
		{
			try
			{
				_ = (GClass2)(object)Class5.Default;
			}
			finally
			{
				_003CModule_003E = _003CModule_003E;
				goto IL_1dee;
			}
		}
		IL_3d9a:
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			BindingFlags bindingFlags_20 = bindingFlags;
			Class7 class45 = class2;
			BindingFlags bindingFlags_21 = (BindingFlags)Class5.Default;
			BindingFlags bindingFlags_22 = bindingFlags;
			bindingFlags = default(BindingFlags);
			if (checked(unchecked((nuint)(UIntPtr)((Class7)null).j(bindingFlags_20, (MethodBase[])(object)class45.t(bindingFlags_21, (FieldInfo[])(object)((Class7)null).e(bindingFlags_22, (MethodBase[])((Class7)null).t((object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, (object)Class5.Default, cultureInfo), type, cultureInfo), array4, (ParameterModifier[])null), obj2, cultureInfo), ref reference, array3, cultureInfo, (string[])null, out object_4)) * uIntPtr) == 0)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = Class5.Default;
				}
			}
			else
			{
				Class7 class46 = class2;
				Class7 class47 = class2;
				bindingFlags = default(BindingFlags);
				_ = (Struct2)class46.j((BindingFlags)class47.e(bindingFlags, array, null, array3), (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)Class5.Default, cultureInfo, array5, out *(object*)null);
			}
		}
		_ = (Class6)(object)Class5.Default;
		class9 = class9;
		_ = (Class2)(object)Class5.Default;
		class13 = (Class8)(object)Class5.Default;
		_ = (GClass0)((Class7)(object)class2.W((BindingFlags)Class5.Default, array2, type, array4, array3)).t(null, type, cultureInfo);
		try
		{
			_ = (Class7)(object)Class5.Default;
		}
		catch
		{
			try
			{
				gClass3 = (GClass2)(object)Class5.Default;
			}
			finally
			{
				gClass = (GClass1)(object)Class5.Default;
				goto end_IL_3f3a;
			}
			end_IL_3f3a:;
		}
		finally
		{
			if (uIntPtr == 0)
			{
				try
				{
					qk = qk;
				}
				catch
				{
					_003CModule_003E = null;
				}
			}
			else
			{
				Class7 obj50 = (Class7)(object)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, array2, null, array4, array3);
				BindingFlags bindingFlags_23 = (BindingFlags)Class5.Default;
				MethodBase[] methodBase_13 = array;
				Class7 class48 = class2;
				PropertyInfo[] propertyInfo_4 = array2;
				Class7 obj51 = (Class7)(object)class2.e(default(BindingFlags), array, null, null);
				bindingFlags = default(BindingFlags);
				if ((UIntPtr)((Class7)(object)obj50.e(bindingFlags_23, methodBase_13, (Type[])(object)class48.W(default(BindingFlags), propertyInfo_4, (Type)(object)obj51.e(bindingFlags, (MethodBase[])(object)Class5.Default, array4, null), array4, array3), array3)).j((BindingFlags)((Class7)null).t((BindingFlags)class2.t(obj2, type, cultureInfo), (FieldInfo[])null, obj2, cultureInfo), array, ref *(object[]*)((Class7)(object)Class5.Default).t(null, null, (CultureInfo)(object)class2.j(bindingFlags, array, ref *(object[]*)null, array3, null, array5, out *(object*)Class5.Default)), null, cultureInfo, array5, out *(object*)null) == (UIntPtr)(nuint)0u)
				{
					_ = (Class9)class2.t(null, null, cultureInfo);
					_ = (Class8)(object)Class5.Default;
					_ = (Class8)(object)Class5.Default;
				}
				else
				{
					gClass = (GClass1)(object)class2.t(bindingFlags, array6, null, null);
				}
			}
			goto IL_410b;
		}
		IL_3636:
		do
		{
			_ = (GClass1)(object)Class5.Default;
		}
		while (obj2 != null);
		try
		{
			_ = (Class8)(object)Class5.Default;
		}
		finally
		{
			Class7 class49 = class2;
			Class7 class50 = class2;
			Class7 class51 = class2;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_24 = (BindingFlags)class51.W(bindingFlags, array2, type, (Type[])(object)Class5.Default, (ParameterModifier[])(object)((Class7)(object)Class5.Default).t((BindingFlags)class2.W(bindingFlags, null, type, null, null), array6, class2.t(obj2, type, cultureInfo), null));
			FieldInfo[] fieldInfo_3 = array6;
			BindingFlags bindingFlags_25 = (BindingFlags)Class5.Default;
			MethodBase[] methodBase_14 = (MethodBase[])(object)class2.t(bindingFlags, (FieldInfo[])(object)class2.t((BindingFlags)((Class7)(object)Class5.Default).W(bindingFlags, array2, type, array4, (ParameterModifier[])(object)Class5.Default), array6, Class5.Default, (CultureInfo)(object)class2.t((BindingFlags)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)null, array3, (CultureInfo)null, array5, out object_4), (FieldInfo[])(object)class2.j((BindingFlags)Class5.Default, array, ref *(object[]*)class2.e(bindingFlags, array, array4, array3), array3, (CultureInfo)(object)Class5.Default, (string[])((Class7)null).t((object)null, type, (CultureInfo)class2.t(obj2, type, null)), out object_4), class2.t(obj2, (Type)(object)class2.W(bindingFlags, array2, type, (Type[])(object)Class5.Default, null), cultureInfo), null)), obj2, cultureInfo);
			ref object[] object_10 = ref reference;
			CultureInfo cultureInfo_5 = cultureInfo;
			Class7 obj52 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			_ = (GClass3)class49.t(obj2, (Type)(object)((Class7)null).j(default(BindingFlags), (MethodBase[])(object)class50.t(bindingFlags_24, fieldInfo_3, ((Class7)null).j(bindingFlags_25, methodBase_14, ref object_10, (ParameterModifier[])null, cultureInfo_5, (string[])(object)obj52.e(bindingFlags, array, array4, array3), out *(object*)((Class7)(object)Class5.Default).j(bindingFlags, (MethodBase[])(object)((Class7)(object)Class5.Default).t(bindingFlags, array6, obj2, (CultureInfo)(object)class2.e(bindingFlags, array, array4, array3)), ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, null, out object_4)), null), ref reference, array3, cultureInfo, (string[])null, out *(object*)null), cultureInfo);
			goto IL_391c;
		}
		IL_391c:
		class9 = class9;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			do
			{
				try
				{
					_ = (Class9)(object)class2.e(bindingFlags, (MethodBase[])(object)class2.t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, obj2, null), array4, array3);
				}
				finally
				{
					class2 = class2;
					continue;
				}
			}
			while (obj2 != null);
			goto IL_3ad3;
		}
		try
		{
			Class7 obj53 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_26 = bindingFlags;
			Class7 class52 = class2;
			bindingFlags = default(BindingFlags);
			_ = (Class2)(object)obj53.t(bindingFlags_26, (FieldInfo[])(object)((Class7)null).e((BindingFlags)((Class7)(object)class52.e(bindingFlags, array, array4, (ParameterModifier[])(object)Class5.Default)).j(bindingFlags, array, ref *(object[]*)null, array3, (CultureInfo)((Class7)(object)Class5.Default).t(obj2, type, cultureInfo), array5, out object_4), array, (Type[])null, array3), Class5.Default, null);
		}
		finally
		{
			do
			{
				_ = (GClass1)(object)((Class7)null).t((BindingFlags)Class5.Default, array6, (object)null, cultureInfo);
			}
			while (obj2 != null);
			goto IL_3ad3;
		}
		IL_1e84:
		checked
		{
			if (uIntPtr - unchecked((nuint)(UIntPtr)class2.e(bindingFlags, array, array4, (ParameterModifier[])(object)Class5.Default)) == 0)
			{
				try
				{
					try
					{
						_ = (GClass1)(object)Class5.Default;
					}
					finally
					{
						_ = (Class9)(object)Class5.Default;
						goto end_IL_1eb2;
					}
					end_IL_1eb2:;
				}
				catch
				{
					try
					{
						bindingFlags = default(BindingFlags);
						Class7 obj54 = (Class7)(object)unchecked(((Class7)null).j(bindingFlags, array, ref *(object[]*)Class5.Default, (ParameterModifier[])null, cultureInfo, (string[])(object)((Class7)null).e(bindingFlags, array, array4, array3), out *(object*)null));
						bindingFlags = default(BindingFlags);
						_ = (Class5)(object)obj54.e(bindingFlags, array, array4, array3);
					}
					finally
					{
						_ = (Class7)(object)Class5.Default;
						goto end_IL_1ed2;
					}
					end_IL_1ed2:;
				}
			}
			else
			{
				_ = (GClass2)((Class7)(object)class2.e(bindingFlags, (MethodBase[])(object)Class5.Default, array4, array3)).t(null, type, cultureInfo);
			}
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					class23 = class23;
				}
			}
			catch
			{
				try
				{
					if (unchecked((nuint)(UIntPtr)Class5.Default) * uIntPtr == 0)
					{
						_ = (GClass0)(object)Class5.Default;
						_ = (GClass2)((Class7)(object)Class5.Default).t(obj2, type, cultureInfo);
						class9 = class9;
						class16 = Class5.Default;
					}
					else
					{
						class23 = class23;
					}
				}
				finally
				{
					Class7 class53 = class2;
					Class7 class54 = class2;
					bindingFlags = default(BindingFlags);
					_ = (Qk7)(object)((Class7)class53.t(class54.t(bindingFlags, array6, Class5.Default, cultureInfo), type, cultureInfo)).e(bindingFlags, array, array4, (ParameterModifier[])(object)class2.t(bindingFlags, array6, obj2, cultureInfo));
					goto end_IL_1fa7;
				}
				end_IL_1fa7:;
			}
			do
			{
				_ = (Struct2)Class5.Default;
			}
			while (obj2 != null);
			try
			{
				class9 = class9;
				qk = null;
				_ = (Class6)(object)class2.W(bindingFlags, array2, type, null, null);
				_ = (GClass1)(object)Class5.Default;
			}
			catch
			{
				class9 = (Class6)(object)Class5.Default;
			}
		}
		try
		{
			try
			{
				_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
			}
			finally
			{
				while ((object)Class5.Default != null)
				{
					_ = (Class2)(object)Class5.Default;
				}
				goto end_IL_20de;
			}
			end_IL_20de:;
		}
		catch
		{
			if ((UIntPtr)class2.W(bindingFlags, null, type, array4, (ParameterModifier[])(object)class2.e(bindingFlags, array, array4, null)) == (UIntPtr)(nuint)0u)
			{
				try
				{
					Class7 class55 = class2;
					BindingFlags bindingFlags_27 = bindingFlags;
					Class7 class56 = class2;
					bindingFlags = default(BindingFlags);
					_ = (_003CModule_003E)(object)class55.W(bindingFlags_27, null, null, (Type[])(object)((Class7)(object)class56.t(bindingFlags, null, obj2, cultureInfo)).W(bindingFlags, array2, null, array4, array3), null);
				}
				catch
				{
					@struct = @struct;
				}
			}
		}
		Class7 class57 = class2;
		Class7 class58 = class2;
		Class7 class59 = class2;
		bindingFlags = default(BindingFlags);
		_ = (Class4)((Class7)null).t(obj2, (Type)null, (CultureInfo)(object)class57.W((BindingFlags)class58.W((BindingFlags)class59.e(bindingFlags, array, array4, array3), (PropertyInfo[])(object)Class5.Default, (Type)(object)class2.j(bindingFlags, null, ref reference, null, null, null, out object_4), array4, null), (PropertyInfo[])(object)Class5.Default, null, array4, null));
		while (obj2 != null)
		{
			do
			{
				try
				{
					@struct = default(Struct2);
					@struct = @struct;
					_ = (GClass3)(object)Class5.Default;
					_ = (Class2)(object)Class5.Default;
				}
				catch
				{
					class28 = null;
				}
			}
			while ((object)class2.e((BindingFlags)class2.t(bindingFlags, array6, obj2, null), null, array4, array3) != null);
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (_003CModule_003E)(object)class2.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, array3, cultureInfo, array5, out object_4);
			}
			catch
			{
				do
				{
					_ = (Class7)(object)((Class7)(object)Class5.Default).j(bindingFlags, array, ref *(object[]*)null, null, null, array5, out *(object*)null);
				}
				while (obj2 != null);
			}
		}
		try
		{
			do
			{
				class15 = class15;
				_ = (Struct2)((Class7)null).t((object)null, (Type)(object)class2.t(bindingFlags, (FieldInfo[])(object)class2.W(bindingFlags, array2, (Type)(object)Class5.Default, (Type[])(object)Class5.Default, null), null, null), cultureInfo);
				struct2 = struct2;
				_ = (Qk7)(object)Class5.Default;
			}
			while (obj2 != null || obj2 != null);
		}
		finally
		{
			while ((object)Class5.Default != null)
			{
				try
				{
					bindingFlags = default(BindingFlags);
					_ = (GClass3)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)((Class7)null).W(bindingFlags, array2, type, array4, (ParameterModifier[])null), type, array4, array3);
				}
				finally
				{
					_ = Class5.Default;
					continue;
				}
			}
			goto IL_23fb;
		}
		IL_3ad3:
		while ((object)Class5.Default != null)
		{
			bindingFlags = default(BindingFlags);
			class24 = (Class0)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)null, array3, cultureInfo, (string[])null, out *(object*)class2.j(bindingFlags, null, ref reference, (ParameterModifier[])(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, array3), cultureInfo, array5, out object_4));
		}
		_ = (Class9)(object)class2.t(bindingFlags, null, obj2, cultureInfo);
		try
		{
			_ = (Class4)(object)Class5.Default;
			class2 = class2;
		}
		catch
		{
			try
			{
				do
				{
					_ = (Class6)(object)class2.e(bindingFlags, array, null, array3);
				}
				while (obj2 != null);
			}
			finally
			{
				_ = (_003CModule_003E)class2.t(obj2, type, cultureInfo);
				goto end_IL_3b10;
			}
			end_IL_3b10:;
		}
		try
		{
			_ = (Class8)(object)Class5.Default;
			Class7 class60 = class2;
			bindingFlags = default(BindingFlags);
			@class = (Class4)(object)class60.t(bindingFlags, null, obj2, (CultureInfo)(object)Class5.Default);
			gClass4 = gClass4;
		}
		finally
		{
			while (obj2 != null)
			{
				try
				{
					qk = qk;
				}
				catch
				{
					Class7 obj63 = (Class7)(object)Class5.Default;
					Class7 obj64 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_28 = bindingFlags;
					MethodBase[] methodBase_15 = array;
					ref object[] object_11 = ref *(object[]*)class2.t(((Class7)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])null, array3)).e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default), null, cultureInfo);
					Class7 class61 = class2;
					BindingFlags bindingFlags_29 = bindingFlags;
					BindingFlags bindingFlags_30 = bindingFlags;
					MethodBase[] methodBase_16 = array;
					ref object[] object_12 = ref *(object[]*)Class5.Default;
					CultureInfo cultureInfo_6 = cultureInfo;
					Class7 obj65 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Qk7)(object)obj63.W((BindingFlags)obj64.e((BindingFlags)((Class7)null).j(bindingFlags_28, methodBase_15, ref object_11, (ParameterModifier[])(object)class61.t(bindingFlags_29, (FieldInfo[])(object)((Class7)null).j(bindingFlags_30, methodBase_16, ref object_12, (ParameterModifier[])null, cultureInfo_6, (string[])(object)obj65.j(bindingFlags, array, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, null, out *(object*)null), out object_4), class2.j((BindingFlags)Class5.Default, array, ref reference, (ParameterModifier[])(object)Class5.Default, null, null, out *(object*)class2.W(bindingFlags, null, (Type)(object)Class5.Default, array4, null)), null), (CultureInfo)null, array5, out *(object*)null), null, (Type[])(object)Class5.Default, null), (PropertyInfo[])(object)Class5.Default, type, null, array3);
				}
			}
			goto IL_3d45;
		}
		IL_356c:
		try
		{
			if (checked(unchecked(unchecked((nuint)default(UIntPtr)) / (nuint)(UIntPtr)Class5.Default) - unchecked((nuint)(UIntPtr)((Class7)((Class7)null).t((object)null, type, cultureInfo)).W(bindingFlags, null, type, array4, (ParameterModifier[])((Class7)(object)Class5.Default).t(obj2, (Type)((Class7)null).t(obj2, type, (CultureInfo)null), null)))) == 0)
			{
				_ = (GClass2)(object)((Class7)(object)Class5.Default).j(bindingFlags, null, ref *(object[]*)null, array3, null, array5, out object_4);
			}
		}
		catch
		{
			class15 = class15;
		}
		finally
		{
			_ = (Class8)class2.t(obj2, type, cultureInfo);
			goto IL_3636;
		}
		IL_0f9a:
		Class7 obj68 = (Class7)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		class2 = (Class7)(object)obj68.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array3, null, array5, out *(object*)null);
		_ = (Class0)(object)Class5.Default;
		try
		{
			if ((UIntPtr)class2.e(bindingFlags, array, array4, array3) == (UIntPtr)(nuint)0u)
			{
				do
				{
					class16 = null;
				}
				while (obj2 != null);
			}
		}
		catch
		{
			if (uIntPtr == 0 && uIntPtr == 0)
			{
				Class7 class62 = class2;
				bindingFlags = default(BindingFlags);
				Class0 obj69 = (Class0)(object)class62.t(bindingFlags, array6, class2.e((BindingFlags)Class5.Default, array, array4, null), null);
				class24 = null;
				class24 = obj69;
			}
		}
		try
		{
		}
		catch
		{
			if (uIntPtr == 0)
			{
				try
				{
					_ = (GClass2)(object)Class5.Default;
				}
				catch
				{
					_003CModule_003E = _003CModule_003E;
				}
			}
		}
		try
		{
			try
			{
				try
				{
					_ = (Class6)(object)Class5.Default;
				}
				catch
				{
					struct2 = (Struct1)((Class7)(object)class2.W(bindingFlags, (PropertyInfo[])(object)class2.t(bindingFlags, (FieldInfo[])(object)class2.j(bindingFlags, array, ref reference, array3, cultureInfo, array5, out object_4), obj2, null), null, (Type[])(object)Class5.Default, array3)).e(bindingFlags, null, (Type[])(object)Class5.Default, array3);
				}
			}
			catch
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					class2 = null;
				}
				else
				{
					struct2 = struct2;
				}
			}
		}
		catch
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					struct2 = struct2;
				}
				finally
				{
					class24 = class24;
					goto end_IL_114c;
				}
			}
			end_IL_114c:;
		}
		while (true)
		{
			if (((Class7)null).t(obj2, (Type)(object)Class5.Default, cultureInfo) != null)
			{
				gClass3 = gClass3;
				class16 = null;
				_ = (Qk7)((Class7)(object)Class5.Default).t(class2.j(bindingFlags, array, ref *(object[]*)null, array3, cultureInfo, array5, out *(object*)null), null, cultureInfo);
				gClass = (GClass1)class2.t(obj2, null, cultureInfo);
			}
			else if (obj2 == null)
			{
				break;
			}
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			while (obj2 != null)
			{
				do
				{
					class16 = class16;
				}
				while (obj2 != null);
			}
		}
		if (uIntPtr == 0)
		{
			while (obj2 != null)
			{
				_ = (Class8)((Class7)null).t((object)null, type, cultureInfo);
			}
			goto IL_12af;
		}
		try
		{
			gClass3 = (GClass2)(object)Class5.Default;
			gClass3 = (GClass2)(object)((Class7)(object)Class5.Default).e(default(BindingFlags), null, null, array3);
			gClass4 = gClass4;
			gClass4 = gClass4;
		}
		finally
		{
			while (obj2 != null)
			{
				_ = (GClass3)(object)Class5.Default;
			}
			goto IL_12af;
		}
		IL_4b75:
		_ = (Class2)(object)Class5.Default;
		try
		{
			try
			{
				Class7 obj76 = (Class7)(object)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, array, null, array3);
				bindingFlags = default(BindingFlags);
				_ = (GClass2)(object)obj76.W(bindingFlags, array2, type, null, array3);
				_ = (Class4)(object)Class5.Default;
				_ = (Class4)(object)Class5.Default;
				@class = @class;
			}
			finally
			{
				do
				{
					gClass2 = null;
				}
				while (obj2 != null);
				goto end_IL_4b80;
			}
			end_IL_4b80:;
		}
		finally
		{
			try
			{
				try
				{
					_ = (Qk7)(object)((Class7)null).t((BindingFlags)((Class7)(object)Class5.Default).j((BindingFlags)class2.t(null, null, cultureInfo), array, ref *(object[]*)null, array3, null, (string[])class2.t(null, type, cultureInfo), out *(object*)null), (FieldInfo[])null, obj2, cultureInfo);
				}
				catch
				{
					bindingFlags = default(BindingFlags);
					_ = (Class10)(object)((Class7)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference, (ParameterModifier[])(object)Class5.Default, (CultureInfo)null, array5, out object_4)).j(bindingFlags, array, ref *(object[]*)null, (ParameterModifier[])(object)((Class7)null).j((BindingFlags)Class5.Default, array, ref reference, (ParameterModifier[])null, (CultureInfo)(object)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, array6, Class5.Default, cultureInfo), array5, out object_4), cultureInfo, array5, out *(object*)Class5.Default);
				}
			}
			catch
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					@class = null;
				}
				else
				{
					gClass3 = gClass3;
					BindingFlags bindingFlags_31 = bindingFlags;
					Class7 obj78 = (Class7)(object)class2.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, array4, array3);
					BindingFlags bindingFlags_32 = bindingFlags;
					BindingFlags bindingFlags_33 = bindingFlags;
					Type[] type_8 = (Type[])(object)Class5.Default;
					BindingFlags bindingFlags_34 = bindingFlags;
					MethodBase[] methodBase_17 = (MethodBase[])(object)Class5.Default;
					Class7 class63 = class2;
					Class7 class64 = class2;
					BindingFlags bindingFlags_35 = bindingFlags;
					MethodBase[] methodBase_18 = (MethodBase[])(object)Class5.Default;
					Class7 class65 = class2;
					bindingFlags = default(BindingFlags);
					_ = (Class9)(object)((Class7)null).W(bindingFlags_31, (PropertyInfo[])(object)obj78.j(bindingFlags_32, (MethodBase[])(object)((Class7)null).e(bindingFlags_33, (MethodBase[])null, type_8, (ParameterModifier[])(object)((Class7)null).j(bindingFlags_34, methodBase_17, ref *(object[]*)class63.W((BindingFlags)class64.e(bindingFlags_35, methodBase_18, (Type[])(object)((Class7)(object)class65.W(bindingFlags, array2, type, null, array3)).j(bindingFlags, array, ref reference, array3, cultureInfo, array5, out object_4), array3), array2, null, array4, array3), (ParameterModifier[])(object)Class5.Default, (CultureInfo)null, array5, out object_4)), ref *(object[]*)class2.W(bindingFlags, array2, (Type)(object)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, null, Class5.Default, cultureInfo), array4, array3), array3, (CultureInfo)(object)((Class7)(object)Class5.Default).e(default(BindingFlags), array, array4, null), array5, out object_4), (Type)null, array4, (ParameterModifier[])null);
					qk = qk;
					Class7 obj79 = (Class7)class2.t(null, (Type)(object)Class5.Default, null);
					bindingFlags = default(BindingFlags);
					_ = (Class0)(object)obj79.W(bindingFlags, array2, type, array4, (ParameterModifier[])(object)((Class7)(object)Class5.Default).e(bindingFlags, null, null, null));
				}
			}
			goto IL_4f40;
		}
		IL_0710:
		object object_13 = Class5.Default;
		Class7 class66 = class2;
		BindingFlags bindingFlags_36 = (BindingFlags)Class5.Default;
		Class7 class67 = class2;
		Class7 class68 = class2;
		bindingFlags = default(BindingFlags);
		class15 = (Class2)((Class7)null).t(object_13, (Type)(object)((Class7)null).t((BindingFlags)class66.t(bindingFlags_36, (FieldInfo[])(object)class67.W(default(BindingFlags), (PropertyInfo[])(object)class68.t(bindingFlags, (FieldInfo[])(object)class2.W(bindingFlags, array2, null, array4, (ParameterModifier[])(object)Class5.Default), obj2, cultureInfo), type, array4, null), Class5.Default, cultureInfo), array6, (object)Class5.Default, (CultureInfo)null), (CultureInfo)null);
		try
		{
			while (true)
			{
				if (obj2 != null)
				{
					_ = (GClass0)(object)Class5.Default;
				}
				else if (obj2 == null)
				{
					break;
				}
			}
		}
		catch
		{
			uIntPtr = default(UIntPtr);
			if (checked(uIntPtr + unchecked((nuint)(UIntPtr)Class5.Default) * uIntPtr * (unchecked((nuint)(UIntPtr)Class5.Default) + unchecked((nuint)(UIntPtr)Class5.Default))) == 0)
			{
				while (obj2 != null)
				{
					bindingFlags = default(BindingFlags);
					_ = (Class10)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)null, (CultureInfo)null);
					_ = (Struct2)Class5.Default;
					_ = (Struct1)Class5.Default;
				}
			}
			else
			{
				while (obj2 != null)
				{
					bindingFlags = default(BindingFlags);
					class9 = (Class6)(object)((Class7)null).j(bindingFlags, array, ref reference, array3, (CultureInfo)null, (string[])null, out *(object*)null);
				}
			}
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			do
			{
				try
				{
					_ = (Class7)(object)Class5.Default;
				}
				catch
				{
					struct2 = default(Struct1);
					struct2 = default(Struct1);
				}
			}
			while ((object)class2.t(bindingFlags, array6, Class5.Default, cultureInfo) != null);
		}
		else
		{
			while (obj2 != null)
			{
				Class7 obj83 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				_ = (Class4)(object)obj83.W(bindingFlags, null, type, array4, null);
			}
		}
		_ = (Class2)class2.t(null, (Type)(object)Class5.Default, cultureInfo);
		while (obj2 != null)
		{
			Class7 class69 = class2;
			PropertyInfo[] propertyInfo_5 = array2;
			Type type_9 = type;
			Class7 class70 = class2;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)class69.W(default(BindingFlags), propertyInfo_5, type_9, null, (ParameterModifier[])(object)class70.W(bindingFlags, array2, null, array4, null)) == (UIntPtr)(nuint)0u)
			{
				uIntPtr = default(UIntPtr);
				if (checked(unchecked(uIntPtr / uIntPtr) - unchecked((nuint)(UIntPtr)Class5.Default)) == 0)
				{
					_ = (Class10)(object)Class5.Default;
					Class7 obj84 = (Class7)(object)class2.e(bindingFlags, (MethodBase[])(object)class2.t(bindingFlags, array6, class2.t(obj2, type, cultureInfo), cultureInfo), array4, (ParameterModifier[])class2.t(null, type, cultureInfo));
					Class7 class71 = class2;
					BindingFlags bindingFlags_37 = bindingFlags;
					BindingFlags bindingFlags_38 = bindingFlags;
					PropertyInfo[] propertyInfo_6 = array2;
					Type type_10 = (Type)(object)Class5.Default;
					Class7 class72 = class2;
					bindingFlags = default(BindingFlags);
					gClass2 = (GClass3)(object)((Class7)null).j((BindingFlags)obj84.j((BindingFlags)class71.W(bindingFlags_37, (PropertyInfo[])(object)((Class7)null).W(bindingFlags_38, propertyInfo_6, type_10, (Type[])((Class7)null).t(obj2, (Type)(object)class72.t(bindingFlags, null, null, (CultureInfo)(object)Class5.Default), (CultureInfo)((Class7)(object)class2.j((BindingFlags)((Class7)null).t((object)null, type, (CultureInfo)null), (MethodBase[])(object)class2.W(bindingFlags, null, type, (Type[])(object)Class5.Default, null), ref *(object[]*)null, array3, (CultureInfo)(object)Class5.Default, array5, out *(object*)null)).t(obj2, null, null)), array3), type, array4, array3), null, ref reference, array3, null, array5, out object_4), array, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)Class5.Default, cultureInfo, (string[])(object)class2.W(bindingFlags, array2, type, null, (ParameterModifier[])(object)Class5.Default), out object_4);
				}
			}
			else
			{
				try
				{
					Class7 class73 = class2;
					bindingFlags = default(BindingFlags);
					_ = (GClass0)(object)class73.e(bindingFlags, array, array4, null);
				}
				catch
				{
					Class7 class74 = class2;
					bindingFlags = default(BindingFlags);
					_ = (GClass1)(object)class74.W(bindingFlags, null, type, (Type[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)Class5.Default, (CultureInfo)null), array3);
					@class = null;
					class15 = class15;
				}
			}
		}
		while ((object)class2.W(bindingFlags, (PropertyInfo[])(object)((Class7)(object)Class5.Default).t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, cultureInfo), null, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default) != null)
		{
			while (obj2 != null)
			{
				Class7 class75;
				BindingFlags bindingFlags_39;
				PropertyInfo[] propertyInfo_7;
				Class7 obj86;
				BindingFlags bindingFlags_40;
				FieldInfo[] fieldInfo_4;
				Class7 obj87;
				BindingFlags bindingFlags_41;
				FieldInfo[] fieldInfo_5;
				do
				{
					class9 = class9;
					class75 = class2;
					bindingFlags_39 = bindingFlags;
					propertyInfo_7 = array2;
					Class7 class76 = class2;
					object object_14 = Class5.Default;
					Class7 class77 = class2;
					bindingFlags = default(BindingFlags);
					obj86 = (Class7)class76.t(object_14, (Type)(object)class77.t(bindingFlags, array6, null, null), cultureInfo);
					bindingFlags_40 = (BindingFlags)((Class7)null).e(bindingFlags, array, array4, (ParameterModifier[])(object)Class5.Default);
					fieldInfo_4 = (FieldInfo[])(object)class2.t(bindingFlags, array6, obj2, cultureInfo);
					obj87 = (Class7)(object)Class5.Default;
					bindingFlags_41 = bindingFlags;
					fieldInfo_5 = (FieldInfo[])(object)Class5.Default;
					bindingFlags = default(BindingFlags);
				}
				while ((object)class75.W(bindingFlags_39, propertyInfo_7, (Type)(object)obj86.t(bindingFlags_40, fieldInfo_4, obj2, (CultureInfo)(object)obj87.t(bindingFlags_41, fieldInfo_5, ((Class7)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj2, (CultureInfo)null)).e(bindingFlags, array, array4, array3), cultureInfo)), null, array3) != null);
			}
		}
		Class7 class78 = class2;
		object object_15 = class2.e((BindingFlags)class2.t(bindingFlags, array6, obj2, (CultureInfo)(object)class2.t((BindingFlags)Class5.Default, array6, obj2, (CultureInfo)(object)class2.e(bindingFlags, array, (Type[])(object)Class5.Default, (ParameterModifier[])(object)((Class7)null).W((BindingFlags)Class5.Default, array2, (Type)(object)Class5.Default, (Type[])null, array3)))), (MethodBase[])(object)class2.j((BindingFlags)((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference, array3, (CultureInfo)null, (string[])null, out object_4), (MethodBase[])(object)Class5.Default, ref *(object[]*)null, array3, (CultureInfo)class2.t(obj2, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default), null, out object_4), null, array3);
		bindingFlags = default(BindingFlags);
		if ((UIntPtr)class78.t(object_15, (Type)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)Class5.Default, (ParameterModifier[])null, cultureInfo, (string[])(object)Class5.Default, out *(object*)null), cultureInfo) == (UIntPtr)(nuint)0u)
		{
			while (obj2 != null)
			{
				qk = null;
			}
			goto IL_0f9a;
		}
		checked
		{
			try
			{
				while (obj2 != null)
				{
					_ = (Class5)((Class7)null).t((object)null, type, cultureInfo);
				}
			}
			finally
			{
				uIntPtr = default(UIntPtr);
				if (unchecked((nuint)default(UIntPtr)) * (uIntPtr - unchecked((nuint)(UIntPtr)((Class7)class2.t(null, type, (CultureInfo)(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, cultureInfo))).t((BindingFlags)Class5.Default, null, null, cultureInfo))) == 0)
				{
					_ = (GClass1)(object)class2.t(bindingFlags, array6, obj2, cultureInfo);
				}
				else
				{
					class16 = class16;
				}
				goto IL_0f9a;
			}
		}
		IL_12af:
		gClass = null;
		while (obj2 != null)
		{
		}
		UIntPtr num6 = (UIntPtr)Class5.Default;
		Class7 class79 = class2;
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_42 = bindingFlags;
		Class7 obj88 = (Class7)(object)((Class7)(object)((Class7)null).j((BindingFlags)((Class7)null).t((object)null, (Type)null, (CultureInfo)null), array, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)Class5.Default, array5, out *(object*)null)).t(bindingFlags, null, obj2, cultureInfo);
		BindingFlags bindingFlags_43 = (BindingFlags)((Class7)null).t(default(BindingFlags), (FieldInfo[])null, (object)null, cultureInfo);
		ref object[] object_16 = ref reference;
		ParameterModifier[] parameterModifier_4 = array3;
		Class7 class80 = class2;
		bindingFlags = default(BindingFlags);
		Class7 obj89 = (Class7)(object)class79.t(bindingFlags_42, (FieldInfo[])(object)obj88.j(bindingFlags_43, null, ref object_16, parameterModifier_4, null, (string[])(object)class80.j(bindingFlags, array, ref reference, (ParameterModifier[])(object)Class5.Default, null, null, out object_4), out object_4), Class5.Default, cultureInfo);
		BindingFlags bindingFlags_44 = bindingFlags;
		MethodBase[] methodBase_19 = (MethodBase[])(object)Class5.Default;
		CultureInfo cultureInfo_7 = cultureInfo;
		Class7 obj90 = (Class7)(object)Class5.Default;
		BindingFlags bindingFlags_45 = (BindingFlags)Class5.Default;
		FieldInfo[] fieldInfo_6 = array6;
		Class7 class81 = class2;
		Class7 obj91 = (Class7)(object)Class5.Default;
		BindingFlags bindingFlags_46 = bindingFlags;
		MethodBase[] methodBase_20 = array;
		ref object[] object_17 = ref *(object[]*)Class5.Default;
		ParameterModifier[] parameterModifier_5 = (ParameterModifier[])(object)((Class7)(object)class2.t(bindingFlags, null, class2.e(bindingFlags, null, null, null), cultureInfo)).j(bindingFlags, array, ref reference, null, cultureInfo, (string[])(object)Class5.Default, out *(object*)((Class7)(object)class2.e((BindingFlags)((Class7)null).e(bindingFlags, array, (Type[])(object)Class5.Default, (ParameterModifier[])null), array, array4, null)).e(default(BindingFlags), array, array4, (ParameterModifier[])(object)Class5.Default));
		string[] string_3 = array5;
		Class7 class82 = class2;
		bindingFlags = default(BindingFlags);
		if (checked(unchecked((nuint)num6) - unchecked((nuint)(UIntPtr)obj89.j(bindingFlags_44, methodBase_19, ref *(object[]*)null, null, cultureInfo_7, null, out *(object*)obj90.t(bindingFlags_45, fieldInfo_6, null, (CultureInfo)(object)class81.t((BindingFlags)obj91.j(bindingFlags_46, methodBase_20, ref object_17, parameterModifier_5, null, string_3, out *(object*)class82.W(bindingFlags, array2, null, array4, (ParameterModifier[])(object)Class5.Default)), null, obj2, cultureInfo))))) == 0)
		{
			nuint num7 = unchecked((nuint)default(UIntPtr)) / unchecked((nuint)default(UIntPtr));
			uIntPtr = default(UIntPtr);
			if (num7 / uIntPtr == 0)
			{
				gClass3 = (GClass2)(object)Class5.Default;
			}
			else if (uIntPtr == 0)
			{
				_ = (GClass3)(object)Class5.Default;
			}
		}
		else
		{
			_ = (Struct2)class2.e(bindingFlags, array, array4, array3);
		}
		try
		{
			try
			{
				if (uIntPtr == 0)
				{
					_ = (Class8)(object)Class5.Default;
				}
				else
				{
					class24 = class24;
				}
			}
			finally
			{
				_ = (Class10)class2.t(obj2, type, cultureInfo);
				class16 = class16;
				gClass3 = (GClass2)(object)Class5.Default;
				Class7 class83 = class2;
				bindingFlags = default(BindingFlags);
				_ = (Struct2)class83.t(bindingFlags, array6, ((Class7)(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, (object)Class5.Default, cultureInfo)).t((BindingFlags)((Class7)(object)Class5.Default).t(obj2, type, (CultureInfo)(object)Class5.Default), null, obj2, null), cultureInfo);
				goto end_IL_1581;
			}
			end_IL_1581:;
		}
		finally
		{
			if (uIntPtr == 0)
			{
				gClass2 = gClass2;
			}
			else
			{
				while (obj2 != null)
				{
					_ = (Class0)(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, (CultureInfo)null);
				}
			}
			goto IL_1690;
		}
		IL_410b:
		try
		{
			try
			{
				Class7 class84 = class2;
				bindingFlags = default(BindingFlags);
				_ = (Class8)(object)class84.e((BindingFlags)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, cultureInfo), array, array4, (ParameterModifier[])(object)Class5.Default);
				_ = (Class0)(object)Class5.Default;
			}
			finally
			{
				try
				{
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_47 = bindingFlags;
					MethodBase[] methodBase_21 = array;
					Class7 class85 = class2;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_48 = bindingFlags;
					MethodBase[] methodBase_22 = array;
					Type[] type_11 = array4;
					Class7 class86 = class2;
					bindingFlags = default(BindingFlags);
					_ = (GClass2)(object)((Class7)null).e(bindingFlags_47, methodBase_21, (Type[])(object)class85.e(bindingFlags_48, methodBase_22, type_11, (ParameterModifier[])(object)class86.t(bindingFlags, (FieldInfo[])(object)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, array2, type, null, array3), null, (CultureInfo)(object)class2.t((BindingFlags)Class5.Default, array6, null, cultureInfo))), array3);
					Class7 class87 = class2;
					BindingFlags bindingFlags_49 = bindingFlags;
					MethodBase[] methodBase_23 = array;
					ref object[] object_18 = ref reference;
					CultureInfo cultureInfo_8 = (CultureInfo)(object)class2.e((BindingFlags)Class5.Default, null, array4, array3);
					Class7 class88 = class2;
					BindingFlags bindingFlags_50 = bindingFlags;
					MethodBase[] methodBase_24 = array;
					ref object[] object_19 = ref reference;
					ParameterModifier[] parameterModifier_6 = (ParameterModifier[])(object)Class5.Default;
					CultureInfo cultureInfo_9 = (CultureInfo)(object)Class5.Default;
					string[] string_4 = array5;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_51 = bindingFlags;
					MethodBase[] methodBase_25 = array;
					ref object[] object_20 = ref reference;
					bindingFlags = default(BindingFlags);
					Class7 obj92 = (Class7)(object)((Class7)null).j(bindingFlags_51, methodBase_25, ref object_20, (ParameterModifier[])null, (CultureInfo)(object)((Class7)(object)((Class7)null).t(bindingFlags, array6, obj2, (CultureInfo)null)).W((BindingFlags)class2.j(bindingFlags, null, ref reference, null, cultureInfo, array5, out object_4), array2, type, array4, array3), (string[])null, out object_4);
					BindingFlags bindingFlags_52 = (BindingFlags)Class5.Default;
					Class7 class89 = class2;
					object object_21 = Class5.Default;
					Class7 class90 = class2;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_53 = bindingFlags;
					PropertyInfo[] propertyInfo_8 = array2;
					Type type_12 = type;
					BindingFlags bindingFlags_54 = bindingFlags;
					MethodBase[] methodBase_26 = array;
					Type[] type_13 = (Type[])(object)Class5.Default;
					Class7 class91 = class2;
					bindingFlags = default(BindingFlags);
					Class7 obj93 = (Class7)(object)class91.W(bindingFlags, array2, type, (Type[])(object)Class5.Default, array3);
					bindingFlags = default(BindingFlags);
					Type[] type_14 = (Type[])(object)((Class7)null).e(bindingFlags_54, methodBase_26, type_13, (ParameterModifier[])(object)obj93.t(bindingFlags, null, obj2, cultureInfo));
					bindingFlags = default(BindingFlags);
					Class7 obj94 = (Class7)(object)class87.j(bindingFlags_49, methodBase_23, ref object_18, null, cultureInfo_8, null, out *(object*)class88.j(bindingFlags_50, methodBase_24, ref object_19, parameterModifier_6, cultureInfo_9, string_4, out *(object*)((Class7)(object)obj92.e(bindingFlags_52, null, (Type[])class89.t(object_21, (Type)(object)class90.W(bindingFlags_53, propertyInfo_8, type_12, type_14, (ParameterModifier[])(object)((Class7)(object)((Class7)null).j(bindingFlags, array, ref *(object[]*)Class5.Default, array3, cultureInfo, array5, out object_4)).j(bindingFlags, null, ref reference, array3, (CultureInfo)(object)Class5.Default, array5, out *(object*)null)), null), (ParameterModifier[])(object)Class5.Default)).t(bindingFlags, null, obj2, cultureInfo)));
					BindingFlags bindingFlags_55 = bindingFlags;
					MethodBase[] methodBase_27 = array;
					Class7 obj95 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_56 = bindingFlags;
					MethodBase[] methodBase_28 = array;
					Class7 class92 = class2;
					BindingFlags bindingFlags_57 = bindingFlags;
					FieldInfo[] fieldInfo_7 = array6;
					BindingFlags bindingFlags_58 = bindingFlags;
					Class7 obj96 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					Class7 obj97 = (Class7)(object)class92.t(bindingFlags_57, fieldInfo_7, ((Class7)null).W(bindingFlags_58, (PropertyInfo[])null, (Type)(object)obj96.W(bindingFlags, null, (Type)((Class7)null).t(obj2, type, cultureInfo), null, null), (Type[])null, array3), cultureInfo);
					BindingFlags bindingFlags_59 = (BindingFlags)((Class7)null).t(bindingFlags, array6, (object)null, cultureInfo);
					FieldInfo[] fieldInfo_8 = array6;
					Class7 obj98 = (Class7)(object)class2.j((BindingFlags)Class5.Default, null, ref *(object[]*)null, array3, (CultureInfo)((Class7)(object)Class5.Default).t(obj2, type, null), array5, out object_4);
					bindingFlags = default(BindingFlags);
					Class7 obj99 = (Class7)(object)obj94.e(bindingFlags_55, methodBase_27, null, (ParameterModifier[])(object)obj95.e(bindingFlags_56, methodBase_28, (Type[])(object)obj97.t((BindingFlags)((Class7)null).t(bindingFlags_59, fieldInfo_8, (object)null, (CultureInfo)(object)obj98.j(bindingFlags, array, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, null, out object_4)), (FieldInfo[])(object)class2.t(bindingFlags, array6, null, null), null, cultureInfo), array3));
					bindingFlags = default(BindingFlags);
					_ = (GClass2)(object)obj99.j(bindingFlags, null, ref reference, array3, null, null, out object_4);
					gClass2 = (GClass3)(object)Class5.Default;
					_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
				}
				catch
				{
					BindingFlags bindingFlags_60 = bindingFlags;
					FieldInfo[] fieldInfo_9 = array6;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_61 = bindingFlags;
					Type[] type_15 = (Type[])(object)Class5.Default;
					Class7 obj100 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_62 = bindingFlags;
					Class7 class93 = class2;
					bindingFlags = default(BindingFlags);
					_ = (Class4)(object)((Class7)null).t(bindingFlags_60, fieldInfo_9, (object)((Class7)null).e(bindingFlags_61, (MethodBase[])null, type_15, (ParameterModifier[])(object)obj100.W(bindingFlags_62, null, null, (Type[])(object)((Class7)(object)class93.t(bindingFlags, null, null, cultureInfo)).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, array3, cultureInfo, array5, out *(object*)Class5.Default), (ParameterModifier[])(object)Class5.Default)), cultureInfo);
				}
				goto end_IL_410c;
			}
			end_IL_410c:;
		}
		finally
		{
			try
			{
				try
				{
					_ = (Class10)(object)Class5.Default;
				}
				finally
				{
					@struct = (Struct2)Class5.Default;
					goto end_IL_46be;
				}
				end_IL_46be:;
			}
			finally
			{
				class2 = class2;
				goto IL_46ea;
			}
		}
		IL_4a55:
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			do
			{
				qk = qk;
			}
			while (obj2 != null || (object)Class5.Default != null);
			goto IL_4b75;
		}
		try
		{
			try
			{
				class15 = class15;
				gClass2 = gClass2;
				_ = (Class10)((Class7)(object)((Class7)(object)Class5.Default).j((BindingFlags)Class5.Default, null, ref reference, array3, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out object_4)).t(obj2, type, cultureInfo);
				Class7 class94 = class2;
				bindingFlags = default(BindingFlags);
				_ = (Struct1)class94.e((BindingFlags)((Class7)null).W(bindingFlags, array2, (Type)null, array4, array3), array, array4, null);
			}
			finally
			{
				@class = @class;
				_ = (Struct1)Class5.Default;
				@class = (Class4)(object)Class5.Default;
				goto end_IL_4a87;
			}
			end_IL_4a87:;
		}
		finally
		{
			gClass4 = (GClass0)(object)class2.W(bindingFlags, array2, null, array4, null);
			goto IL_4b75;
		}
		IL_1690:
		_ = (Qk7)(object)Class5.Default;
		class23 = (Class10)((Class7)null).t(obj2, type, cultureInfo);
		_ = (Qk7)(object)Class5.Default;
		class16 = class16;
		_ = (GClass2)(object)Class5.Default;
		Class7 class95 = class2;
		BindingFlags bindingFlags_63 = bindingFlags;
		Class7 class96 = class2;
		bindingFlags = default(BindingFlags);
		if ((UIntPtr)class95.t(bindingFlags_63, null, null, (CultureInfo)(object)class96.W(bindingFlags, null, (Type)(object)class2.t(bindingFlags, array6, class2.e(bindingFlags, null, array4, (ParameterModifier[])(object)class2.W(bindingFlags, (PropertyInfo[])class2.t(null, (Type)(object)Class5.Default, null), (Type)class2.t(obj2, type, null), array4, null)), cultureInfo), (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default)) == (UIntPtr)(nuint)0u)
		{
			_ = (Class8)(object)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, array, array4, (ParameterModifier[])class2.t(obj2, type, cultureInfo));
		}
		if (uIntPtr == 0)
		{
			_ = Class5.Default;
		}
		else
		{
			do
			{
				try
				{
					_ = (GClass1)(object)Class5.Default;
				}
				finally
				{
					class9 = class9;
					continue;
				}
			}
			while (obj2 != null);
		}
		try
		{
		}
		catch
		{
		}
		if ((UIntPtr)((Class7)(object)Class5.Default).j(bindingFlags, null, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)((Class7)null).W(bindingFlags, array2, (Type)(object)Class5.Default, array4, (ParameterModifier[])(object)Class5.Default), array5, out object_4) == (UIntPtr)(nuint)0u)
		{
			try
			{
				do
				{
					class15 = class15;
					_ = (Class10)(object)Class5.Default;
					class9 = null;
				}
				while (obj2 != null);
			}
			finally
			{
				_003CModule_003E = null;
				goto IL_1892;
			}
		}
		gClass = null;
		goto IL_1892;
		IL_1dee:
		bindingFlags = default(BindingFlags);
		class13 = (Class8)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])null, (ParameterModifier[])null);
		_ = (Class9)(object)class2.e(bindingFlags, null, array4, null);
		try
		{
			UIntPtr num8 = (UIntPtr)class2.t(bindingFlags, null, obj2, (CultureInfo)(object)Class5.Default);
			uIntPtr = default(UIntPtr);
			checked
			{
				if (unchecked((nuint)num8) * uIntPtr == 0)
				{
					while (obj2 != null)
					{
						_ = (Class8)(object)Class5.Default;
					}
				}
			}
		}
		finally
		{
			_ = (Class8)(object)Class5.Default;
			goto IL_1e84;
		}
	}
}
