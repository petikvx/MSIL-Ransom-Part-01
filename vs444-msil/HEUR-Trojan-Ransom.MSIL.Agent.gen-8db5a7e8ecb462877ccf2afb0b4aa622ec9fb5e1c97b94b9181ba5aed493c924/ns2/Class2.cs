using System;
using System.Collections;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using A_0024r;
using Dn7;
using Je5;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.Logging;
using Xt9;
using ns1;
using ns10;
using ns11;
using ns12;
using ns3;
using ns4;
using ns5;
using ns6;
using ns7;
using ns8;
using ns9;

namespace ns2;

[StandardModule]
[HideModuleName]
internal sealed class Class2
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Window", "Create__Instance__", "Dispose__Instance__", "My.MyWpfExtenstionModule.Windows")]
	internal sealed class Class3
	{
		[ThreadStatic]
		private static Hashtable E;

		private static Hx5 smethod_0<Hx5>(Hx5 gparam_0) where Hx5 : Window, new()
		{
			if (gparam_0 == null)
			{
				if (E != null)
				{
					if (E.ContainsKey(typeof(Hx5)))
					{
						throw new InvalidOperationException("The window cannot be accessed via My.Windows from the Window constructor.");
					}
				}
				else
				{
					E = new Hashtable();
				}
				E.Add(typeof(Hx5), null);
				return new Hx5();
			}
			return gparam_0;
		}

		private void method_0<Qs9>(ref Qs9 gparam_0) where Qs9 : Window
		{
			gparam_0 = default(Qs9);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class3()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool vmethod_0(object object_0)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(object_0));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int vmethod_1()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type method_1()
		{
			return typeof(Class3);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string vmethod_2()
		{
			return base.ToString();
		}
	}

	private static Class0.Class1<Computer> O = new Class0.Class1<Computer>();

	private static Class0.Class1<User> f = new Class0.Class1<User>();

	private static Class0.Class1<Class3> V = new Class0.Class1<Class3>();

	private static Class0.Class1<Log> L = new Class0.Class1<Log>();

	[SpecialName]
	internal static Class3 smethod_0()
	{
		return V.h();
	}

	unsafe static void smethod_1()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out FieldInfo[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo);
		Class7 @class;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		while (true)
		{
			@class = null;
			Class7 class2 = @class;
			object object_ = obj;
			type = type;
			if (class2.t(object_, type, null) == null)
			{
				break;
			}
			Class7 obj2 = (Class7)(object)Class5.Default;
			bindingFlags = bindingFlags;
			BindingFlags bindingFlags_ = bindingFlags;
			array = array;
			FieldInfo[] fieldInfo_ = array;
			obj = obj;
			object object_2 = obj;
			cultureInfo = null;
			_003CModule_003E obj3 = (_003CModule_003E)(object)obj2.t(bindingFlags_, fieldInfo_, null, (CultureInfo)((Class7)null).t(object_2, (Type)null, cultureInfo));
			_003CModule_003E = null;
			_003CModule_003E = obj3;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] array2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] array3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class10 class3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qk7 qk);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class6 class5);
		try
		{
			try
			{
				class3 = class3;
				class3 = class3;
			}
			catch
			{
				while (obj != null)
				{
					Class7 class4 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_2 = bindingFlags;
					array2 = array2;
					PropertyInfo[] propertyInfo_ = array2;
					Type type_ = type;
					Type[] type_2 = (Type[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, (CultureInfo)null);
					array3 = null;
					_ = (Class0)(object)class4.W(bindingFlags_2, propertyInfo_, type_, type_2, array3);
				}
			}
		}
		catch
		{
			try
			{
				qk = null;
				qk = qk;
				bindingFlags = default(BindingFlags);
				_ = (GClass2)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])(object)Class5.Default, array3);
			}
			finally
			{
				try
				{
					class5 = class5;
					class5 = null;
				}
				catch
				{
					Class7 class6 = @class;
					BindingFlags bindingFlags_3 = bindingFlags;
					ParameterModifier[] parameterModifier_ = (ParameterModifier[])(object)Class5.Default;
					CultureInfo cultureInfo_ = cultureInfo;
					reference = ref reference;
					_ = (_003CModule_003E)(object)class6.j(bindingFlags_3, null, ref *(object[]*)null, parameterModifier_, cultureInfo_, null, out reference);
				}
				goto end_IL_00ee;
			}
			end_IL_00ee:;
		}
		Class7 class7 = @class;
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_4 = bindingFlags;
		MethodBase[] array4 = array4;
		_ = (Class4)(object)class7.e(bindingFlags_4, array4, (Type[])(object)Class5.Default, array3);
		GClass2 gClass = (GClass2)(object)@class.W(bindingFlags, (PropertyInfo[])(object)((Class7)(object)Class5.Default).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, (Type[])(object)Class5.Default, null), type, (Type[])(object)@class.t(bindingFlags, array, Class5.Default, null), null);
		gClass = gClass;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class2 class9);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class0 class8);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class8 class11);
		try
		{
			do
			{
				try
				{
					_ = (Class8)(object)Class5.Default;
				}
				finally
				{
					_ = (Qk7)(object)Class5.Default;
					class8 = (Class0)(object)Class5.Default;
					class8 = null;
					class9 = class9;
					class9 = class9;
					continue;
				}
			}
			while (obj != null);
		}
		finally
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (_003CModule_003E)(object)Class5.Default;
					gClass = (GClass2)(object)Class5.Default;
					_ = (GClass3)(object)Class5.Default;
					Class7 class10 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class8)(object)class10.e(bindingFlags, array4, null, null);
				}
				finally
				{
					class11 = class11;
					class11 = class11;
					goto IL_02ca;
				}
			}
			goto IL_02ca;
		}
		IL_112c:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass3 gClass2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string[] array5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] array6);
		UIntPtr num;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct2 @struct);
		try
		{
			while (obj != null)
			{
				try
				{
					qk = null;
				}
				catch
				{
					GClass3 obj7 = (GClass3)(object)@class.e(bindingFlags, null, (Type[])(object)Class5.Default, array3);
					gClass2 = null;
					gClass2 = obj7;
				}
			}
		}
		catch
		{
			num = default(UIntPtr);
			if (checked(num * num) == 0)
			{
				Class7 class12 = @class;
				bindingFlags = default(BindingFlags);
				_ = (GClass1)(object)((Class7)(object)class12.j(bindingFlags, null, ref *(object[]*)null, array3, (CultureInfo)(object)Class5.Default, array5, out reference)).e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, array6, array3);
			}
			else
			{
				try
				{
					_ = (Struct2)Class5.Default;
				}
				catch
				{
					_ = Class5.Default;
					@class = @class;
					@struct = @struct;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object[] reference2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass0 gClass3);
		checked
		{
			try
			{
				while ((object)Class5.Default != null)
				{
					try
					{
						_ = (Qk7)(object)Class5.Default;
					}
					catch
					{
						Class7 class13 = @class;
						BindingFlags bindingFlags_5 = bindingFlags;
						MethodBase[] methodBase_ = array4;
						ref object[] object_3 = ref reference2;
						Class7 class14 = @class;
						object object_4 = obj;
						Class7 class15 = @class;
						bindingFlags = default(BindingFlags);
						_ = (GClass1)(object)class13.j(bindingFlags_5, methodBase_, ref object_3, (ParameterModifier[])class14.t(object_4, null, (CultureInfo)(object)class15.j(bindingFlags, null, ref reference2, null, cultureInfo, array5, out reference)), null, (string[])(object)Class5.Default, out reference);
					}
				}
			}
			finally
			{
				if (unchecked((nuint)(UIntPtr)Class5.Default) * num == 0)
				{
					if (num == 0)
					{
						gClass3 = gClass3;
					}
					else
					{
						class11 = class11;
					}
				}
				goto IL_12cd;
			}
		}
		IL_2a0f:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct1 struct2);
		try
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				_ = (_003CModule_003E)(object)((Class7)(object)Class5.Default).e(bindingFlags, null, array6, array3);
				_ = (Class0)(object)Class5.Default;
				Class7 obj12 = (Class7)(object)Class5.Default;
				Class7 class16 = @class;
				bindingFlags = default(BindingFlags);
				_003CModule_003E = (_003CModule_003E)(object)obj12.W((BindingFlags)((Class7)null).t((object)class16.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, cultureInfo), (Type)null, (CultureInfo)null), (PropertyInfo[])@class.t(obj, null, cultureInfo), (Type)(object)Class5.Default, array6, (ParameterModifier[])(object)Class5.Default);
				_ = (Struct2)@class.t(bindingFlags, array, null, null);
			}
		}
		catch
		{
			Class7 class17 = @class;
			BindingFlags bindingFlags_6 = bindingFlags;
			FieldInfo[] fieldInfo_2 = array;
			Class7 class18 = @class;
			bindingFlags = default(BindingFlags);
			struct2 = (Struct1)class17.t(bindingFlags_6, fieldInfo_2, class18.e(bindingFlags, null, array6, null), (CultureInfo)(object)@class.t(bindingFlags, (FieldInfo[])(object)@class.W((BindingFlags)Class5.Default, array2, type, array6, null), obj, cultureInfo));
		}
		try
		{
			if ((UIntPtr)Class5.Default != (UIntPtr)(nuint)0u)
			{
				try
				{
					class3 = class3;
					class11 = null;
				}
				finally
				{
					_ = (_003CModule_003E)(object)Class5.Default;
					goto end_IL_2b6c;
				}
			}
			do
			{
				_ = (Class6)(object)@class.e(bindingFlags, (MethodBase[])(object)@class.j(bindingFlags, (MethodBase[])(object)((Class7)null).e(bindingFlags, array4, (Type[])((Class7)null).t((object)Class5.Default, type, (CultureInfo)(object)Class5.Default), (ParameterModifier[])(object)Class5.Default), ref reference2, (ParameterModifier[])(object)((Class7)null).W((BindingFlags)Class5.Default, array2, (Type)(object)((Class7)null).e(bindingFlags, array4, array6, array3), array6, (ParameterModifier[])null), cultureInfo, null, out *(object*)null), (Type[])@class.t(obj, type, cultureInfo), null);
			}
			while (obj != null);
			end_IL_2b6c:;
		}
		catch
		{
			try
			{
				try
				{
					BindingFlags bindingFlags_7 = (BindingFlags)Class5.Default;
					MethodBase[] methodBase_2 = (MethodBase[])(object)Class5.Default;
					ParameterModifier[] parameterModifier_2 = array3;
					Class7 class19 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class2)(object)((Class7)null).j(bindingFlags_7, methodBase_2, ref *(object[]*)null, parameterModifier_2, (CultureInfo)null, (string[])null, out *(object*)class19.t(bindingFlags, array, null, (CultureInfo)(object)Class5.Default));
				}
				finally
				{
					class11 = null;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_8 = bindingFlags;
					PropertyInfo[] propertyInfo_2 = array2;
					bindingFlags = default(BindingFlags);
					_ = (Class2)(object)((Class7)null).W(bindingFlags_8, propertyInfo_2, (Type)(object)((Class7)null).W(bindingFlags, array2, (Type)(object)Class5.Default, (Type[])null, array3), array6, array3);
					goto end_IL_2c6c;
				}
				end_IL_2c6c:;
			}
			catch
			{
				try
				{
					Class7 class20 = @class;
					BindingFlags bindingFlags_9 = bindingFlags;
					Class7 class21 = @class;
					BindingFlags bindingFlags_10 = bindingFlags;
					ref object[] object_5 = ref reference2;
					bindingFlags = default(BindingFlags);
					ParameterModifier[] parameterModifier_3 = (ParameterModifier[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)null, array6, array3);
					CultureInfo cultureInfo_2 = (CultureInfo)(object)Class5.Default;
					Class7 class22 = @class;
					BindingFlags bindingFlags_11 = bindingFlags;
					PropertyInfo[] propertyInfo_3 = (PropertyInfo[])(object)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, null, null, array6, array3);
					Type[] type_3 = (Type[])(object)Class5.Default;
					Class7 obj14 = (Class7)(object)@class.j(bindingFlags, null, ref reference2, null, null, null, out *(object*)null);
					BindingFlags bindingFlags_12 = bindingFlags;
					PropertyInfo[] propertyInfo_4 = array2;
					bindingFlags = default(BindingFlags);
					string[] string_ = (string[])(object)((Class7)null).j((BindingFlags)class22.W(bindingFlags_11, propertyInfo_3, null, type_3, (ParameterModifier[])(object)obj14.W(bindingFlags_12, propertyInfo_4, (Type)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])null, (ParameterModifier[])null), (Type[])(object)@class.e(bindingFlags, (MethodBase[])(object)@class.e(bindingFlags, null, array6, array3), (Type[])(object)((Class7)null).t(bindingFlags, array, (object)Class5.Default, (CultureInfo)(object)Class5.Default), (ParameterModifier[])(object)((Class7)(object)((Class7)(object)@class.W(bindingFlags, null, type, array6, (ParameterModifier[])(object)Class5.Default)).t(bindingFlags, array, obj, null)).W(bindingFlags, array2, (Type)(object)Class5.Default, null, array3)), null)), array4, ref reference2, array3, (CultureInfo)(object)@class.e(bindingFlags, array4, array6, array3), (string[])(object)Class5.Default, out reference);
					Class7 class23 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Struct1)((Class7)(object)class20.t(bindingFlags_9, (FieldInfo[])(object)class21.j(bindingFlags_10, null, ref object_5, parameterModifier_3, cultureInfo_2, string_, out *(object*)class23.t(bindingFlags, array, obj, (CultureInfo)(object)((Class7)null).t((BindingFlags)((Class7)(object)Class5.Default).t(Class5.Default, null, cultureInfo), (FieldInfo[])null, obj, (CultureInfo)null))), Class5.Default, (CultureInfo)(object)Class5.Default)).e(bindingFlags, null, (Type[])(object)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, null, ((Class7)(object)Class5.Default).t(obj, (Type)(object)@class.j(bindingFlags, null, ref *(object[]*)@class.t(obj, type, null), array3, cultureInfo, array5, out *(object*)Class5.Default), (CultureInfo)(object)Class5.Default), null), null);
					_ = (Struct1)((Class7)null).W((BindingFlags)Class5.Default, array2, type, array6, array3);
					_ = (Qk7)(object)Class5.Default;
					_ = (Qk7)(object)@class.W(bindingFlags, null, null, array6, null);
					goto end_IL_2d1f;
				}
				finally
				{
					class5 = class5;
					goto end_IL_2d1f;
				}
				end_IL_2d1f:;
			}
		}
		_ = (GClass0)(object)Class5.Default;
		_ = (Class4)(object)Class5.Default;
		Class4 class24 = class24;
		struct2 = default(Struct1);
		Class7 class25 = @class;
		bindingFlags = default(BindingFlags);
		_ = (GClass2)(object)class25.j(bindingFlags, null, ref *(object[]*)null, array3, null, array5, out *(object*)((Class7)(object)Class5.Default).t(obj, null, cultureInfo));
		do
		{
			_003CModule_003E = (((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u) ? _003CModule_003E : ((_003CModule_003E)(object)Class5.Default));
		}
		while ((object)Class5.Default != null);
		try
		{
			class5 = class5;
			class24 = (Class4)(object)Class5.Default;
			class11 = class11;
		}
		catch
		{
			while (obj != null)
			{
				@class = (Class7)(object)@class.j((BindingFlags)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo, (string[])(object)Class5.Default, out *(object*)((Class7)null).j((BindingFlags)((Class7)(object)((Class7)(object)Class5.Default).e(bindingFlags, array4, array6, null)).W((BindingFlags)Class5.Default, (PropertyInfo[])(object)Class5.Default, type, array6, (ParameterModifier[])@class.t(@class.t(obj, type, cultureInfo), type, cultureInfo)), (MethodBase[])@class.t(obj, type, null), ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, (CultureInfo)null, (string[])null, out *(object*)((Class7)null).j(bindingFlags, array4, ref *(object[]*)null, array3, cultureInfo, array5, out *(object*)null))), array4, ref *(object[]*)@class.W(bindingFlags, array2, type, array6, array3), null, cultureInfo, array5, out *(object*)null);
			}
		}
		finally
		{
			_ = (Class2)(object)((Class7)(object)Class5.Default).e(default(BindingFlags), null, null, null);
			goto IL_32a4;
		}
		IL_1035:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass1 gClass4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class5 class29);
		while (obj != null)
		{
			try
			{
				gClass4 = (GClass1)(object)Class5.Default;
			}
			finally
			{
				try
				{
					Class7 obj18 = (Class7)(object)Class5.Default;
					Class7 obj19 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_13 = bindingFlags;
					BindingFlags bindingFlags_14 = bindingFlags;
					Class7 class26 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_15 = bindingFlags;
					FieldInfo[] fieldInfo_3 = array;
					Class7 class27 = @class;
					BindingFlags bindingFlags_16 = (BindingFlags)Class5.Default;
					FieldInfo[] fieldInfo_4 = array;
					Class7 class28 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class6)(object)obj18.t((BindingFlags)obj19.j(bindingFlags_13, (MethodBase[])(object)((Class7)null).e(bindingFlags_14, (MethodBase[])(object)class26.t(bindingFlags_15, fieldInfo_3, ((Class7)(object)class27.t(bindingFlags_16, fieldInfo_4, ((Class7)null).e((BindingFlags)class28.W(bindingFlags, array2, type, array6, (ParameterModifier[])(object)Class5.Default), (MethodBase[])(object)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])null, (object)Class5.Default, cultureInfo), array6, (ParameterModifier[])null), (CultureInfo)@class.t(obj, null, (CultureInfo)(object)Class5.Default))).t(bindingFlags, null, obj, (CultureInfo)(object)Class5.Default), (CultureInfo)(object)((Class7)(object)@class.t(bindingFlags, array, obj, null)).t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, null)), (Type[])(object)Class5.Default, array3), ref reference2, null, cultureInfo, null, out reference), (FieldInfo[])(object)Class5.Default, obj, (CultureInfo)(object)((Class7)(object)Class5.Default).j(bindingFlags, null, ref *(object[]*)null, array3, null, array5, out reference));
				}
				catch
				{
					_ = (Class0)(object)@class.e(bindingFlags, array4, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
					class29 = class29;
					_ = (Qk7)(object)@class.t(bindingFlags, array, obj, cultureInfo);
					_ = (Class8)(object)Class5.Default;
				}
				continue;
			}
		}
		class3 = class3;
		_ = Class5.Default;
		try
		{
			if ((UIntPtr)((Class7)((Class7)null).t((object)null, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default)).W((BindingFlags)((Class7)null).t(obj, (Type)null, (CultureInfo)null), null, type, array6, null) == (UIntPtr)(nuint)0u)
			{
				do
				{
					_ = (Class2)(object)Class5.Default;
				}
				while (obj != null);
			}
			else if (num == 0)
			{
				class3 = class3;
				gClass3 = (GClass0)(object)((Class7)@class.t(obj, type, (CultureInfo)(object)Class5.Default)).e(bindingFlags, null, array6, array3);
			}
		}
		finally
		{
			UIntPtr num2 = (UIntPtr)Class5.Default;
			num = default(UIntPtr);
			checked
			{
				if ((unchecked((nuint)num2 / checked(num + (num - num))) - num) * num == 0)
				{
					class5 = null;
				}
				goto IL_112c;
			}
		}
		IL_02ca:
		gClass4 = gClass4;
		gClass4 = null;
		try
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					class3 = class3;
				}
				catch
				{
					_ = (Class6)(object)Class5.Default;
				}
			}
		}
		catch
		{
			@struct = @struct;
			@struct = @struct;
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u && checked(unchecked((nuint)(UIntPtr)((Class7)null).t(obj, type, cultureInfo)) - unchecked((nuint)default(UIntPtr))) == 0)
		{
			gClass = null;
		}
		try
		{
			if (unchecked((nuint)default(UIntPtr)) / unchecked((nuint)default(UIntPtr)) == 0)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Class4)(object)Class5.Default;
				}
				else
				{
					@struct = (Struct2)Class5.Default;
				}
			}
			else
			{
				_ = (Class9)(object)Class5.Default;
			}
		}
		finally
		{
			while (obj != null)
			{
			}
			goto IL_03bb;
		}
		IL_12cd:
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				class9 = class9;
			}
		}
		catch
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
			}
		}
		num = default(UIntPtr);
		if (unchecked((nuint)default(UIntPtr)) / num == 0)
		{
			try
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = Class5.Default;
					_ = (Class4)(object)Class5.Default;
					Class7 class30 = @class;
					Class7 obj24 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Class0)(object)class30.W((BindingFlags)((Class7)(object)obj24.j(bindingFlags, array4, ref *(object[]*)Class5.Default, array3, cultureInfo, array5, out *(object*)Class5.Default)).t((BindingFlags)((Class7)@class.t(obj, type, cultureInfo)).e((BindingFlags)Class5.Default, null, (Type[])(object)Class5.Default, null), null, obj, cultureInfo), array2, type, array6, array3);
				}
			}
			catch
			{
				while ((object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)null, (Type[])(object)@class.j((BindingFlags)@class.t(bindingFlags, array, obj, null), null, ref *(object[]*)null, array3, cultureInfo, array5, out reference), (ParameterModifier[])null) != null)
				{
					@class = null;
				}
			}
		}
		_ = (GClass1)(object)Class5.Default;
		_ = (Class0)@class.t(obj, null, null);
		gClass4 = gClass4;
		if (num == 0)
		{
			while (obj != null)
			{
				_ = (Class2)((Class7)null).t(obj, type, (CultureInfo)(object)@class.t((BindingFlags)Class5.Default, array, obj, (CultureInfo)(object)Class5.Default));
			}
		}
		try
		{
			_ = (Class8)(object)Class5.Default;
		}
		catch
		{
			try
			{
				Class7 class31 = @class;
				BindingFlags bindingFlags_17 = bindingFlags;
				Class7 obj26 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				_ = (GClass2)(object)class31.W(bindingFlags_17, (PropertyInfo[])(object)obj26.j(bindingFlags, array4, ref *(object[]*)null, null, cultureInfo, (string[])(object)((Class7)(object)@class.W((BindingFlags)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, (Type[])null, array3), array2, null, (Type[])(object)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, null, obj, cultureInfo), null)).W(bindingFlags, null, type, array6, array3), out reference), type, array6, (ParameterModifier[])(object)Class5.Default);
				class11 = class11;
				class3 = (Class10)((Class7)(object)@class.e(bindingFlags, array4, array6, array3)).t(null, type, cultureInfo);
			}
			catch
			{
				if (num == 0)
				{
					qk = qk;
				}
			}
		}
		_ = (Struct1)((Class7)(object)Class5.Default).t(obj, (Type)(object)((Class7)null).t((BindingFlags)@class.t(null, type, cultureInfo), (FieldInfo[])(object)Class5.Default, (object)@class.t(bindingFlags, array, Class5.Default, cultureInfo), (CultureInfo)null), cultureInfo);
		do
		{
			try
			{
				do
				{
					gClass = null;
				}
				while (obj != null);
			}
			finally
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (Struct1)Class5.Default;
				}
				else
				{
					_ = (Class0)@class.t(@class.t(obj, type, (CultureInfo)(object)Class5.Default), null, null);
				}
				continue;
			}
		}
		while (obj != null);
		if (num == 0)
		{
			if ((UIntPtr)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)(object)Class5.Default, (Type[])(object)((Class7)null).j((BindingFlags)((Class7)null).W(bindingFlags, array2, (Type)null, array6, array3), array4, ref reference2, (ParameterModifier[])(object)@class.t(bindingFlags, null, null, null), cultureInfo, array5, out reference), array3) == (UIntPtr)(nuint)0u)
			{
				UIntPtr num3 = (UIntPtr)Class5.Default;
				num = default(UIntPtr);
				checked
				{
					if (unchecked((nuint)num3) * num == 0)
					{
						gClass = gClass;
					}
					else
					{
						_ = Class5.Default;
					}
				}
			}
		}
		else
		{
			while ((object)Class5.Default != null)
			{
				class29 = class29;
			}
		}
		try
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				while (obj != null)
				{
					class3 = class3;
				}
			}
		}
		finally
		{
			do
			{
				_ = (Class6)(object)((Class7)null).j((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, ref *(object[]*)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, (CultureInfo)null), array3, cultureInfo, array5, out reference);
			}
			while (obj != null);
			goto IL_18e1;
		}
		IL_249d:
		if (num == 0)
		{
			try
			{
				_ = (Class5)(object)((Class7)(object)((Class7)(object)Class5.Default).e(bindingFlags, array4, (Type[])(object)Class5.Default, null)).W((BindingFlags)Class5.Default, array2, type, array6, null);
			}
			catch
			{
				if (checked(unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr)) - unchecked((nuint)(UIntPtr)Class5.Default)) == 0)
				{
					Class7 class32 = @class;
					bindingFlags = default(BindingFlags);
					_ = (_003CModule_003E)(object)class32.W(bindingFlags, array2, type, array6, null);
				}
				else
				{
					class9 = (Class2)(object)@class.e((BindingFlags)Class5.Default, null, array6, (ParameterModifier[])((Class7)(object)Class5.Default).t(obj, (Type)(object)Class5.Default, (CultureInfo)((Class7)null).t((object)null, type, cultureInfo)));
				}
			}
		}
		Class9 class33 = class33;
		_ = (_003CModule_003E)(object)Class5.Default;
		num = default(UIntPtr);
		if (num == 0)
		{
			nuint num4 = num;
			UIntPtr num5 = (UIntPtr)Class5.Default;
			num = default(UIntPtr);
			if (num4 / ((nuint)num5 / num) == 0)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (Class7)(object)Class5.Default;
				}
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
				class29 = class29;
			}
			while (obj != null || obj != null);
		}
		_ = (Class7)(object)Class5.Default;
		class24 = (Class4)((Class7)null).t((object)Class5.Default, (Type)null, (CultureInfo)(object)@class.t((BindingFlags)@class.t(((Class7)(object)((Class7)(object)((Class7)null).W(bindingFlags, array2, type, array6, (ParameterModifier[])(object)Class5.Default)).W(bindingFlags, array2, type, array6, array3)).W((BindingFlags)((Class7)(object)@class.t(bindingFlags, array, ((Class7)null).t(default(BindingFlags), array, obj, cultureInfo), (CultureInfo)(object)Class5.Default)).t(default(BindingFlags), array, Class5.Default, null), null, (Type)(object)Class5.Default, array6, null), null, cultureInfo), array, obj, (CultureInfo)(object)Class5.Default));
		_ = (Class7)(object)@class.W(default(BindingFlags), array2, type, array6, null);
		Class7 class34 = @class;
		bindingFlags = default(BindingFlags);
		_ = (Qk7)(object)class34.j(default(BindingFlags), (MethodBase[])(object)((Class7)null).W(bindingFlags, array2, type, array6, array3), ref *(object[]*)Class5.Default, null, cultureInfo, null, out reference);
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				Class7 obj30 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_18 = bindingFlags;
				FieldInfo[] fieldInfo_5 = array;
				Class7 class35 = @class;
				BindingFlags bindingFlags_19 = (BindingFlags)Class5.Default;
				FieldInfo[] fieldInfo_6 = array;
				object object_6 = obj;
				Class7 obj31 = (Class7)(object)@class.W(default(BindingFlags), array2, type, array6, null);
				bindingFlags = default(BindingFlags);
				_ = (GClass2)(object)((Class7)(object)obj30.t(bindingFlags_18, fieldInfo_5, ((Class7)(object)class35.t(bindingFlags_19, fieldInfo_6, object_6, (CultureInfo)(object)obj31.t(bindingFlags, null, null, cultureInfo))).t(bindingFlags, null, Class5.Default, (CultureInfo)(object)Class5.Default), cultureInfo)).e(bindingFlags, array4, array6, array3);
			}
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				if (num == 0)
				{
					_ = (Class8)(object)Class5.Default;
				}
			}
			finally
			{
				if ((nuint)(UIntPtr)Class5.Default / (nuint)(UIntPtr)Class5.Default == 0)
				{
					_ = (Class4)@class.t(obj, type, cultureInfo);
				}
				else
				{
					Class7 class36 = @class;
					BindingFlags bindingFlags_20 = bindingFlags;
					bindingFlags = default(BindingFlags);
					_ = (Class5)(object)class36.W(bindingFlags_20, (PropertyInfo[])(object)((Class7)null).t(bindingFlags, array, (object)Class5.Default, cultureInfo), type, array6, (ParameterModifier[])(object)Class5.Default);
					_ = (GClass3)(object)((Class7)null).W(bindingFlags, array2, (Type)(object)((Class7)(object)@class.t((BindingFlags)((Class7)(object)Class5.Default).t(bindingFlags, array, obj, null), array, obj, cultureInfo)).e((BindingFlags)Class5.Default, null, array6, null), (Type[])(object)((Class7)null).t(bindingFlags, array, (object)@class.j((BindingFlags)Class5.Default, null, ref reference2, array3, null, array5, out reference), cultureInfo), array3);
				}
				goto IL_2a0f;
			}
		}
		class8 = null;
		goto IL_2a0f;
		IL_39bd:
		nuint num6;
		checked
		{
			if (num == 0)
			{
				num = default(UIntPtr);
				if (unchecked((nuint)default(UIntPtr)) * num == 0)
				{
					num = default(UIntPtr);
					if (num == 0)
					{
						_ = (Class0)(object)Class5.Default;
					}
					else
					{
						class8 = null;
					}
				}
			}
			else
			{
				_ = (Class6)(object)Class5.Default;
			}
			num6 = num;
			num = default(UIntPtr);
		}
		if (num6 / num == 0)
		{
			nuint num7 = num;
			nuint num8 = num;
			Class7 class37 = @class;
			BindingFlags bindingFlags_21 = bindingFlags;
			Class7 class38 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_22 = bindingFlags;
			Class7 class39 = @class;
			BindingFlags bindingFlags_23 = bindingFlags;
			bindingFlags = default(BindingFlags);
			MethodBase[] methodBase_3 = (MethodBase[])(object)class38.W(bindingFlags_22, (PropertyInfo[])(object)class39.j(bindingFlags_23, (MethodBase[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)(object)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, array2, type, (Type[])(object)@class.t(bindingFlags, array, obj, null), (ParameterModifier[])(object)Class5.Default), array6, (ParameterModifier[])null), ref reference2, null, cultureInfo, array5, out *(object*)Class5.Default), null, null, array3);
			Class7 class40 = @class;
			bindingFlags = default(BindingFlags);
			nuint num9;
			checked
			{
				num9 = num8 - unchecked((nuint)(UIntPtr)class37.j(bindingFlags_21, methodBase_3, ref *(object[]*)((Class7)(object)class40.t(bindingFlags, array, obj, cultureInfo)).t((BindingFlags)Class5.Default, array, obj, cultureInfo), array3, (CultureInfo)(object)Class5.Default, array5, out *(object*)Class5.Default));
				num = default(UIntPtr);
			}
			if (num7 / checked(num9 * num) == 0)
			{
				try
				{
					_ = (Struct2)((Class7)(object)@class.W(bindingFlags, array2, null, null, array3)).e((BindingFlags)((Class7)(object)Class5.Default).t(Class5.Default, null, (CultureInfo)(object)((Class7)null).j((BindingFlags)((Class7)null).t((object)((Class7)null).t(bindingFlags, array, obj, cultureInfo), (Type)null, cultureInfo), (MethodBase[])null, ref *(object[]*)null, array3, (CultureInfo)null, array5, out reference)), null, (Type[])(object)Class5.Default, array3);
					class33 = class33;
					class5 = null;
					Class7 class41 = @class;
					BindingFlags bindingFlags_24 = bindingFlags;
					Class7 class42 = @class;
					object object_7 = obj;
					Type type_4 = (Type)(object)@class.j((BindingFlags)((Class7)null).j((BindingFlags)Class5.Default, array4, ref reference2, array3, cultureInfo, array5, out reference), null, ref *(object[]*)@class.t(Class5.Default, type, cultureInfo), array3, (CultureInfo)(object)Class5.Default, (string[])(object)((Class7)null).e(bindingFlags, array4, (Type[])null, (ParameterModifier[])(object)@class.e((BindingFlags)Class5.Default, (MethodBase[])(object)@class.e(bindingFlags, array4, null, null), array6, array3)), out reference);
					Class7 class43 = @class;
					BindingFlags bindingFlags_25 = bindingFlags;
					MethodBase[] methodBase_4 = array4;
					bindingFlags = default(BindingFlags);
					_ = (Class5)(object)class41.W(bindingFlags_24, null, (Type)class42.t(object_7, type_4, (CultureInfo)(object)class43.e(bindingFlags_25, methodBase_4, null, (ParameterModifier[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)null, (Type[])(object)Class5.Default, (ParameterModifier[])null))), array6, array3);
				}
				finally
				{
					class3 = (Class10)(object)Class5.Default;
					goto IL_3dbe;
				}
			}
			do
			{
				_ = (Class6)(object)@class.W(bindingFlags, array2, null, (Type[])(object)@class.W(bindingFlags, null, (Type)(object)Class5.Default, array6, array3), array3);
				_ = (_003CModule_003E)(object)Class5.Default;
				_ = (GClass0)(object)Class5.Default;
			}
			while (obj != null);
		}
		goto IL_3dbe;
		IL_44e4:
		while (true)
		{
			if (obj != null)
			{
				gClass4 = (GClass1)(object)((Class7)(object)@class.j(bindingFlags, array4, ref reference2, null, (CultureInfo)(object)Class5.Default, array5, out reference)).t(bindingFlags, (FieldInfo[])(object)@class.e((BindingFlags)Class5.Default, (MethodBase[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, (Type[])null, array3), null, (ParameterModifier[])(object)Class5.Default), Class5.Default, (CultureInfo)(object)@class.t(bindingFlags, array, obj, cultureInfo));
			}
			else if ((object)Class5.Default == null)
			{
				break;
			}
		}
		class33 = class33;
		qk = qk;
		_ = (_003CModule_003E)(object)Class5.Default;
		gClass4 = gClass4;
		_ = (Struct1)Class5.Default;
		_ = (Class9)(object)Class5.Default;
		num = default(UIntPtr);
		if (num / num == 0)
		{
			class11 = (Class8)(object)Class5.Default;
			return;
		}
		try
		{
			Class7 class44 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_26 = bindingFlags;
			ref object[] object_8 = ref reference2;
			ParameterModifier[] parameterModifier_4 = array3;
			Class7 class45 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_27 = bindingFlags;
			Class7 class46 = @class;
			bindingFlags = default(BindingFlags);
			class29 = (Class5)(object)class44.j(bindingFlags_26, null, ref object_8, parameterModifier_4, null, (string[])(object)class45.t(bindingFlags_27, (FieldInfo[])(object)class46.e(bindingFlags, array4, array6, null), @class.t(bindingFlags, null, obj, cultureInfo), cultureInfo), out reference);
			return;
		}
		finally
		{
			gClass = gClass;
			BindingFlags bindingFlags_28 = bindingFlags;
			PropertyInfo[] propertyInfo_5 = (PropertyInfo[])(object)Class5.Default;
			Class7 class47 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_29 = (BindingFlags)((Class7)null).W(bindingFlags_28, propertyInfo_5, (Type)(object)class47.e(bindingFlags, null, null, null), array6, array3);
			Class7 class48 = @class;
			BindingFlags bindingFlags_30 = bindingFlags;
			PropertyInfo[] propertyInfo_6 = array2;
			Type type_5 = type;
			Type[] type_6 = array6;
			Class7 class49 = @class;
			bindingFlags = default(BindingFlags);
			FieldInfo[] fieldInfo_7 = (FieldInfo[])(object)class48.W(bindingFlags_30, propertyInfo_6, type_5, type_6, (ParameterModifier[])(object)class49.e(bindingFlags, array4, array6, array3));
			Class7 obj32 = (Class7)(object)Class5.Default;
			Class7 class50 = @class;
			BindingFlags bindingFlags_31 = bindingFlags;
			PropertyInfo[] propertyInfo_7 = array2;
			Type type_7 = (Type)(object)Class5.Default;
			Class7 obj33 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_32 = (BindingFlags)Class5.Default;
			MethodBase[] methodBase_5 = (MethodBase[])(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_33 = bindingFlags;
			MethodBase[] methodBase_6 = array4;
			ref object[] object_9 = ref reference2;
			Class7 class51 = @class;
			BindingFlags bindingFlags_34 = bindingFlags;
			MethodBase[] methodBase_7 = (MethodBase[])(object)Class5.Default;
			Class7 obj34 = (Class7)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])null, (ParameterModifier[])null);
			Class7 class52 = @class;
			BindingFlags bindingFlags_35 = bindingFlags;
			MethodBase[] methodBase_8 = (MethodBase[])(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array6, (ParameterModifier[])@class.t(obj, type, cultureInfo));
			ref object[] object_10 = ref reference2;
			ParameterModifier[] parameterModifier_5 = (ParameterModifier[])@class.t(null, (Type)(object)Class5.Default, cultureInfo);
			CultureInfo cultureInfo_3 = cultureInfo;
			Class7 obj35 = (Class7)(object)@class.e(bindingFlags, array4, array6, null);
			BindingFlags bindingFlags_36 = (BindingFlags)Class5.Default;
			MethodBase[] methodBase_9 = array4;
			ref object[] object_11 = ref *(object[]*)((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])(object)((Class7)null).t((BindingFlags)Class5.Default, array, obj, cultureInfo), array6, null);
			CultureInfo cultureInfo_4 = cultureInfo;
			string[] string_2 = array5;
			Class7 class53 = @class;
			PropertyInfo[] propertyInfo_8 = (PropertyInfo[])(object)Class5.Default;
			Class7 obj36 = (Class7)(object)Class5.Default;
			object object_12 = obj;
			Type type_8 = type;
			Class7 class54 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Class6)(object)((Class7)(object)((Class7)null).t(bindingFlags_29, fieldInfo_7, (object)obj32.e((BindingFlags)class50.W(bindingFlags_31, propertyInfo_7, type_7, null, (ParameterModifier[])(object)obj33.e(bindingFlags_32, methodBase_5, (Type[])(object)((Class7)null).j(bindingFlags_33, methodBase_6, ref object_9, (ParameterModifier[])null, (CultureInfo)(object)class51.e(bindingFlags_34, methodBase_7, (Type[])(object)obj34.t((BindingFlags)class52.j(bindingFlags_35, methodBase_8, ref object_10, parameterModifier_5, cultureInfo_3, null, out *(object*)obj35.j(bindingFlags_36, methodBase_9, ref object_11, null, cultureInfo_4, string_2, out *(object*)class53.W(default(BindingFlags), propertyInfo_8, null, (Type[])obj36.t(object_12, type_8, (CultureInfo)(object)class54.W(bindingFlags, null, null, (Type[])(object)Class5.Default, array3)), array3))), array, null, (CultureInfo)(object)@class.W(bindingFlags, array2, type, array6, array3)), array3), array5, out *(object*)Class5.Default), null)), array4, array6, array3), cultureInfo)).t(bindingFlags, null, obj, (CultureInfo)(object)@class.t(bindingFlags, null, obj, cultureInfo));
			return;
		}
		IL_03bb:
		try
		{
			do
			{
				struct2 = (Struct1)Class5.Default;
				struct2 = struct2;
			}
			while (obj != null);
		}
		finally
		{
			_ = (Struct2)((Class7)(object)@class.W(bindingFlags, array2, type, null, array3)).t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, cultureInfo);
			goto IL_0434;
		}
		IL_0434:
		do
		{
			bindingFlags = default(BindingFlags);
			_ = (Struct1)((Class7)null).e(bindingFlags, array4, (Type[])null, array3);
		}
		while ((object)Class5.Default != null || (object)((Class7)null).t(bindingFlags, array, (object)null, cultureInfo) != null);
		class11 = class11;
		_ = (GClass0)(object)Class5.Default;
		gClass = gClass;
		_ = (GClass1)(object)@class.W(bindingFlags, array2, type, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
		class11 = (Class8)(object)Class5.Default;
		_ = (Class2)(object)Class5.Default;
		gClass = null;
		class9 = class9;
		try
		{
			num = default(UIntPtr);
			if (checked(num - num) == 0)
			{
				Class7 class55 = @class;
				bindingFlags = default(BindingFlags);
				Class4 obj37 = (Class4)(object)class55.j(bindingFlags, array4, ref *(object[]*)Class5.Default, null, cultureInfo, (string[])(object)@class.t(bindingFlags, array, null, (CultureInfo)(object)Class5.Default), out *(object*)null);
				class24 = null;
				class24 = obj37;
			}
		}
		catch
		{
			_ = (GClass2)(object)Class5.Default;
		}
		finally
		{
			UIntPtr num10 = (UIntPtr)Class5.Default;
			Class7 obj39 = (Class7)(object)Class5.Default;
			object object_13 = Class5.Default;
			Class7 class56 = @class;
			Class7 obj40 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_37 = bindingFlags;
			BindingFlags bindingFlags_38 = bindingFlags;
			MethodBase[] methodBase_10 = array4;
			array6 = array6;
			if (checked(unchecked((nuint)num10) + unchecked((nuint)(UIntPtr)obj39.t(object_13, null, (CultureInfo)(object)class56.W((BindingFlags)obj40.e(bindingFlags_37, (MethodBase[])(object)((Class7)null).e(bindingFlags_38, methodBase_10, array6, (ParameterModifier[])(object)Class5.Default), array6, array3), (PropertyInfo[])((Class7)(object)Class5.Default).t(null, type, cultureInfo), type, null, null)))) == 0)
			{
				try
				{
					GClass0 obj41 = (GClass0)(object)Class5.Default;
					gClass3 = null;
					gClass3 = obj41;
				}
				finally
				{
					class5 = class5;
					_ = (GClass1)(object)@class.W((BindingFlags)@class.W(default(BindingFlags), array2, type, null, null), array2, type, null, array3);
					goto IL_0725;
				}
			}
			try
			{
				_ = (Qk7)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, (CultureInfo)null);
			}
			catch
			{
				_ = (Class8)(object)Class5.Default;
				_ = (GClass1)(object)@class.t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, ((Class7)null).t(default(BindingFlags), (FieldInfo[])(object)Class5.Default, obj, (CultureInfo)(object)((Class7)(object)Class5.Default).W(default(BindingFlags), null, null, (Type[])(object)Class5.Default, array3)), null);
				_ = (GClass3)(object)Class5.Default;
			}
			goto IL_0725;
		}
		IL_3dbe:
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
					@struct = (Struct2)Class5.Default;
				}
			}
			catch
			{
				try
				{
					@class = null;
				}
				finally
				{
					@class = null;
					goto end_IL_3de1;
				}
				end_IL_3de1:;
			}
		}
		while (obj != null);
		@struct = default(Struct2);
		while ((object)Class5.Default != null)
		{
			do
			{
				gClass = gClass;
			}
			while ((object)((Class7)null).j(bindingFlags, array4, ref reference2, (ParameterModifier[])(object)Class5.Default, (CultureInfo)@class.t(obj, null, cultureInfo), array5, out *(object*)null) != null || obj != null);
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				gClass = gClass;
			}
		}
		else
		{
			do
			{
				Class7 class57 = @class;
				BindingFlags bindingFlags_39 = bindingFlags;
				MethodBase[] methodBase_11 = array4;
				BindingFlags bindingFlags_40 = bindingFlags;
				MethodBase[] methodBase_12 = (MethodBase[])@class.t(obj, type, (CultureInfo)(object)Class5.Default);
				Class7 class58 = @class;
				BindingFlags bindingFlags_41 = (BindingFlags)Class5.Default;
				FieldInfo[] fieldInfo_8 = array;
				Type type_9 = type;
				Class7 obj44 = (Class7)(object)((Class7)(object)@class.j(bindingFlags, array4, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo, array5, out reference)).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, array6, null);
				BindingFlags bindingFlags_42 = (BindingFlags)@class.j((BindingFlags)Class5.Default, array4, ref reference2, array3, null, null, out *(object*)((Class7)(object)Class5.Default).e(bindingFlags, null, (Type[])(object)Class5.Default, null));
				Class7 obj45 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_43 = (BindingFlags)Class5.Default;
				Class7 class59 = @class;
				BindingFlags bindingFlags_44 = bindingFlags;
				Class7 class60 = @class;
				Class7 class61 = @class;
				BindingFlags bindingFlags_45 = bindingFlags;
				PropertyInfo[] propertyInfo_9 = (PropertyInfo[])(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, null, array3);
				Class7 obj46 = (Class7)(object)Class5.Default;
				PropertyInfo[] propertyInfo_10 = array2;
				Type type_10 = type;
				Type[] type_11 = (Type[])(object)Class5.Default;
				Class7 class62 = @class;
				bindingFlags = default(BindingFlags);
				Type[] type_12 = (Type[])(object)class58.t(bindingFlags_41, fieldInfo_8, ((Class7)null).t((object)null, type_9, (CultureInfo)(object)obj44.e(bindingFlags_42, (MethodBase[])(object)obj45.t(bindingFlags_43, null, class59.e(bindingFlags_44, (MethodBase[])(object)class60.W((BindingFlags)((Class7)null).j((BindingFlags)((Class7)(object)class61.W(bindingFlags_45, propertyInfo_9, null, (Type[])(object)obj46.W(default(BindingFlags), propertyInfo_10, type_10, type_11, (ParameterModifier[])(object)class62.t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, cultureInfo)), null)).t(Class5.Default, (Type)(object)@class.t(bindingFlags, array, Class5.Default, cultureInfo), cultureInfo), array4, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, (CultureInfo)null, array5, out *(object*)((Class7)@class.t(Class5.Default, (Type)(object)Class5.Default, (CultureInfo)(object)@class.j(bindingFlags, null, ref reference2, null, cultureInfo, (string[])(object)@class.W(default(BindingFlags), null, (Type)(object)Class5.Default, array6, (ParameterModifier[])(object)@class.e(default(BindingFlags), null, array6, array3)), out reference))).t(null, type, cultureInfo)), array2, type, array6, (ParameterModifier[])(object)Class5.Default), array6, null), null), null, (ParameterModifier[])(object)Class5.Default)), cultureInfo);
				Class7 obj47 = (Class7)(object)Class5.Default;
				MethodBase[] methodBase_13 = array4;
				ParameterModifier[] parameterModifier_6 = array3;
				Class7 class63 = @class;
				Class7 class64 = @class;
				bindingFlags = default(BindingFlags);
				_ = (GClass1)(object)class57.e((BindingFlags)((Class7)null).j(bindingFlags_39, methodBase_11, ref *(object[]*)((Class7)((Class7)null).t((object)((Class7)null).e(bindingFlags_40, methodBase_12, type_12, (ParameterModifier[])(object)obj47.j(default(BindingFlags), methodBase_13, ref *(object[]*)null, parameterModifier_6, null, null, out *(object*)class63.t((BindingFlags)((Class7)(object)class64.t(bindingFlags, array, null, null)).t(obj, type, (CultureInfo)(object)Class5.Default), null, obj, cultureInfo))), type, cultureInfo)).t(bindingFlags, array, obj, (CultureInfo)(object)Class5.Default), (ParameterModifier[])null, cultureInfo, array5, out reference), array4, array6, array3);
				@class = @class;
			}
			while ((object)Class5.Default != null);
		}
		num = default(UIntPtr);
		checked
		{
			if (num + unchecked((nuint)(UIntPtr)@class.j(bindingFlags, array4, ref *(object[]*)Class5.Default, null, (CultureInfo)(object)Class5.Default, array5, out reference)) * num == 0)
			{
				Class7 class65 = @class;
				bindingFlags = default(BindingFlags);
				_ = (GClass3)(object)class65.W(bindingFlags, array2, null, array6, array3);
			}
		}
		try
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					class11 = class11;
					_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
				}
				else
				{
					gClass4 = (GClass1)(object)Class5.Default;
					_ = (Struct1)Class5.Default;
					gClass3 = null;
				}
			}
			finally
			{
				while ((object)Class5.Default != null)
				{
					_ = (Qk7)(object)@class.j(bindingFlags, array4, ref *(object[]*)@class.t(obj, type, null), array3, null, array5, out *(object*)Class5.Default);
				}
				goto end_IL_4302;
			}
			end_IL_4302:;
		}
		finally
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (GClass3)(object)Class5.Default;
					struct2 = struct2;
				}
			}
			finally
			{
				try
				{
					Class7 class66 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass2)(object)class66.e(bindingFlags, (MethodBase[])(object)Class5.Default, array6, (ParameterModifier[])(object)Class5.Default);
				}
				catch
				{
					_ = (GClass0)(object)Class5.Default;
					_ = (GClass3)(object)Class5.Default;
					class5 = class5;
					_ = (GClass2)(object)Class5.Default;
				}
				goto IL_44e4;
			}
		}
		IL_18e1:
		while (obj != null)
		{
			if (num == 0)
			{
				try
				{
					Class7 class67 = @class;
					BindingFlags bindingFlags_46 = bindingFlags;
					object object_14 = obj;
					Class7 class68 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_47 = bindingFlags;
					ref object[] object_15 = ref reference2;
					ParameterModifier[] parameterModifier_7 = array3;
					Class7 class69 = @class;
					BindingFlags bindingFlags_48 = bindingFlags;
					MethodBase[] methodBase_14 = array4;
					Class7 class70 = @class;
					bindingFlags = default(BindingFlags);
					gClass = (GClass2)(object)class67.t(bindingFlags_46, null, object_14, (CultureInfo)(object)class68.j(bindingFlags_47, null, ref object_15, parameterModifier_7, (CultureInfo)(object)class69.e(bindingFlags_48, methodBase_14, (Type[])(object)class70.W(bindingFlags, array2, type, (Type[])(object)Class5.Default, array3), null), array5, out *(object*)Class5.Default));
				}
				catch
				{
					_003CModule_003E = (_003CModule_003E)(object)@class.j(bindingFlags, array4, ref reference2, array3, null, array5, out reference);
				}
			}
			else
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					class24 = class24;
				}
			}
		}
		num = default(UIntPtr);
		if (checked(num + num) == 0)
		{
			try
			{
				do
				{
					_ = (Struct1)@class.W(bindingFlags, array2, type, array6, null);
				}
				while ((object)Class5.Default != null);
			}
			catch
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Class8)(object)((Class7)(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)@class.W(bindingFlags, array2, type, (Type[])(object)Class5.Default, array3), (object)null, (CultureInfo)null)).j(bindingFlags, array4, ref reference2, (ParameterModifier[])(object)Class5.Default, cultureInfo, array5, out *(object*)null);
				}
			}
		}
		if (num == 0)
		{
			nuint num11 = num;
			num = default(UIntPtr);
			if (num11 / num == 0)
			{
				Class7 class71 = @class;
				BindingFlags bindingFlags_49 = bindingFlags;
				Class7 class72 = @class;
				BindingFlags bindingFlags_50 = bindingFlags;
				Class7 class73 = @class;
				BindingFlags bindingFlags_51 = (BindingFlags)Class5.Default;
				MethodBase[] methodBase_15 = array4;
				Type[] type_13 = array6;
				Class7 class74 = @class;
				BindingFlags bindingFlags_52 = (BindingFlags)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, null, null);
				ref object[] object_16 = ref reference2;
				ParameterModifier[] parameterModifier_8 = array3;
				Class7 class75 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_53 = bindingFlags;
				PropertyInfo[] propertyInfo_11 = array2;
				Type type_14 = (Type)(object)Class5.Default;
				Type[] type_15 = (Type[])(object)Class5.Default;
				Class7 class76 = @class;
				Class7 class77 = @class;
				BindingFlags bindingFlags_54 = (BindingFlags)((Class7)(object)@class.j(bindingFlags, array4, ref *(object[]*)null, null, cultureInfo, array5, out reference)).t(obj, type, null);
				ref object[] object_17 = ref reference2;
				ParameterModifier[] parameterModifier_9 = array3;
				Class7 class78 = @class;
				bindingFlags = default(BindingFlags);
				Class7 obj51 = (Class7)(object)class78.t(bindingFlags, array, obj, cultureInfo);
				BindingFlags bindingFlags_55 = bindingFlags;
				MethodBase[] methodBase_16 = array4;
				Class7 class79 = @class;
				bindingFlags = default(BindingFlags);
				CultureInfo cultureInfo_5 = (CultureInfo)(object)((Class7)(object)((Class7)null).t((BindingFlags)obj51.e(bindingFlags_55, methodBase_16, (Type[])(object)class79.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference2, null, cultureInfo, array5, out *(object*)null), array3), array, obj, cultureInfo)).W(bindingFlags, (PropertyInfo[])(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, null, (ParameterModifier[])((Class7)(object)Class5.Default).t(obj, type, cultureInfo)), type, array6, (ParameterModifier[])(object)Class5.Default);
				Class7 obj52 = (Class7)(object)@class.e((BindingFlags)Class5.Default, array4, array6, null);
				bindingFlags = default(BindingFlags);
				_ = (GClass1)(object)class71.t(bindingFlags_49, (FieldInfo[])(object)class72.e(bindingFlags_50, (MethodBase[])(object)class73.e(bindingFlags_51, methodBase_15, type_13, (ParameterModifier[])(object)class74.j(bindingFlags_52, null, ref object_16, parameterModifier_8, (CultureInfo)(object)class75.W(bindingFlags_53, propertyInfo_11, type_14, type_15, (ParameterModifier[])(object)class76.e((BindingFlags)class77.j(bindingFlags_54, null, ref object_17, parameterModifier_9, cultureInfo_5, (string[])(object)obj52.j(bindingFlags, null, ref reference2, array3, null, array5, out *(object*)null), out *(object*)Class5.Default), array4, array6, array3)), null, out reference)), array6, null), obj, cultureInfo);
			}
			else
			{
				_ = (Class6)(object)Class5.Default;
			}
		}
		else
		{
			qk = (Qk7)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, ((Class7)null).t(obj, type, (CultureInfo)((Class7)null).t((object)null, type, cultureInfo)), cultureInfo);
		}
		do
		{
			_ = (Class7)@class.t(obj, type, cultureInfo);
		}
		while (obj != null);
		struct2 = struct2;
		_ = (GClass2)(object)Class5.Default;
		try
		{
		}
		catch
		{
			if (num == 0)
			{
				Class9 obj53 = (Class9)(object)((Class7)(object)@class.e(bindingFlags, array4, null, array3)).W(bindingFlags, array2, type, (Type[])(object)Class5.Default, array3);
				class33 = class33;
				class33 = obj53;
			}
			else
			{
				@class = @class;
			}
		}
		finally
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					gClass4 = gClass4;
				}
				else
				{
					struct2 = default(Struct1);
				}
			}
			else
			{
				do
				{
					Class7 obj55 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					class8 = (Class0)(object)obj55.t(bindingFlags, null, obj, cultureInfo);
				}
				while (obj != null);
			}
			goto IL_1d78;
		}
		IL_0725:
		bindingFlags = default(BindingFlags);
		_ = (GClass1)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])null, array3);
		_ = (Class0)(object)Class5.Default;
		gClass = null;
		_ = (Class6)(object)Class5.Default;
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
			do
			{
				try
				{
					_ = (GClass0)(object)((Class7)(object)Class5.Default).t((BindingFlags)@class.t((BindingFlags)((Class7)null).t(obj, type, (CultureInfo)null), null, obj, cultureInfo), array, obj, null);
				}
				catch
				{
					bindingFlags = default(BindingFlags);
					_ = (Struct2)((Class7)null).e(bindingFlags, array4, (Type[])null, array3);
					class9 = (Class2)(object)Class5.Default;
					_ = (Qk7)(object)Class5.Default;
					Class7 class80 = @class;
					BindingFlags bindingFlags_56 = bindingFlags;
					Class7 class81 = @class;
					bindingFlags = default(BindingFlags);
					class11 = (Class8)(object)class80.e(bindingFlags_56, null, (Type[])(object)class81.W(bindingFlags, (PropertyInfo[])(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)@class.t(Class5.Default, null, cultureInfo), null, array3), type, array6, null), array3);
				}
			}
			while ((object)Class5.Default != null);
		}
		do
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				do
				{
					_ = (_003CModule_003E)(object)@class.e(bindingFlags, null, array6, (ParameterModifier[])(object)((Class7)(object)Class5.Default).e(bindingFlags, null, null, array3));
				}
				while ((object)Class5.Default != null);
			}
		}
		while (obj != null);
		if ((nuint)(UIntPtr)Class5.Default / num == 0)
		{
			do
			{
				_ = (Class2)(object)Class5.Default;
			}
			while (obj != null);
		}
		if (num == 0)
		{
			Class5 obj58 = (Class5)((Class7)null).t(obj, (Type)null, (CultureInfo)null);
			class29 = Class5.Default;
			class29 = obj58;
			@struct = @struct;
		}
		else
		{
			num = default(UIntPtr);
			if (num != 0)
			{
				try
				{
					_ = (Struct1)Class5.Default;
				}
				catch
				{
					Class7 class82 = @class;
					BindingFlags bindingFlags_57 = (BindingFlags)@class.e(bindingFlags, (MethodBase[])@class.t(null, type, null), array6, (ParameterModifier[])((Class7)null).t(obj, type, (CultureInfo)null));
					MethodBase[] methodBase_17 = array4;
					CultureInfo cultureInfo_6 = (CultureInfo)((Class7)@class.t(((Class7)(object)@class.W((BindingFlags)Class5.Default, array2, type, array6, (ParameterModifier[])(object)Class5.Default)).e(default(BindingFlags), null, array6, array3), null, null)).t(obj, null, cultureInfo);
					array5 = array5;
					struct2 = (Struct1)class82.j(bindingFlags_57, methodBase_17, ref *(object[]*)null, null, cultureInfo_6, array5, out *(object*)null);
				}
			}
		}
		_ = (Class9)((Class7)null).t(obj, type, cultureInfo);
		while (true)
		{
			Class7 obj60 = (Class7)(object)Class5.Default;
			Class7 class83 = @class;
			bindingFlags = default(BindingFlags);
			if ((object)obj60.e((BindingFlags)class83.W(bindingFlags, array2, null, (Type[])(object)((Class7)((Class7)(object)Class5.Default).t(null, null, (CultureInfo)(object)@class.W(bindingFlags, array2, type, array6, null))).W(bindingFlags, null, null, array6, array3), null), (MethodBase[])(object)Class5.Default, array6, (ParameterModifier[])(object)((Class7)null).e((BindingFlags)Class5.Default, array4, (Type[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, (CultureInfo)null), array3)) == null)
			{
				break;
			}
			try
			{
				_ = (Class8)(object)@class.W(bindingFlags, array2, (Type)(object)Class5.Default, null, array3);
			}
			finally
			{
				@struct = (Struct2)Class5.Default;
				continue;
			}
		}
		_ = (GClass0)@class.t(null, (Type)(object)Class5.Default, cultureInfo);
		do
		{
			if (num == 0)
			{
			}
		}
		while (obj != null);
		Class7 class84 = @class;
		object object_18 = Class5.Default;
		BindingFlags bindingFlags_58 = bindingFlags;
		Class7 obj61 = (Class7)(object)Class5.Default;
		Class7 class85 = @class;
		bindingFlags = default(BindingFlags);
		UIntPtr num12 = (UIntPtr)class84.t(object_18, (Type)(object)((Class7)(object)((Class7)null).W(bindingFlags_58, (PropertyInfo[])((Class7)(object)obj61.e((BindingFlags)class85.t(bindingFlags, (FieldInfo[])(object)Class5.Default, @class.t(obj, null, cultureInfo), null), array4, array6, array3)).t(obj, null, (CultureInfo)(object)Class5.Default), (Type)null, array6, array3)).W(bindingFlags, array2, type, array6, array3), (CultureInfo)@class.t(obj, (Type)@class.t(null, type, cultureInfo), cultureInfo));
		num = default(UIntPtr);
		if (checked(unchecked((nuint)num12 / (num / (num / num))) * num) == 0 && (UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (GClass0)(object)Class5.Default;
				class5 = null;
				@struct = default(Struct2);
				@struct = @struct;
			}
			finally
			{
				_ = (Class8)(object)@class.e((BindingFlags)Class5.Default, null, array6, null);
				goto IL_0ced;
			}
		}
		goto IL_0ced;
		IL_1d78:
		_ = (GClass0)(object)@class.W((BindingFlags)((Class7)null).t(bindingFlags, array, obj, (CultureInfo)(object)((Class7)(object)Class5.Default).t(bindingFlags, null, null, cultureInfo)), (PropertyInfo[])(object)Class5.Default, null, array6, null);
		_ = (Class6)(object)Class5.Default;
		Class7 obj63;
		BindingFlags bindingFlags_59;
		Type type_16;
		Type[] type_17;
		Class7 class86;
		do
		{
			_ = (Struct1)((Class7)(object)Class5.Default).e(default(BindingFlags), null, (Type[])(object)((Class7)(object)@class.e(default(BindingFlags), array4, array6, array3)).j((BindingFlags)Class5.Default, array4, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)Class5.Default, (string[])((Class7)null).t((object)Class5.Default, (Type)null, cultureInfo), out *(object*)Class5.Default), null);
			Class7 obj62 = (Class7)(object)@class.t(default(BindingFlags), array, obj, cultureInfo);
			bindingFlags = default(BindingFlags);
			obj63 = (Class7)(object)obj62.W(bindingFlags, array2, type, null, null);
			bindingFlags_59 = bindingFlags;
			type_16 = type;
			type_17 = array6;
			class86 = @class;
			bindingFlags = default(BindingFlags);
		}
		while ((object)obj63.W(bindingFlags_59, null, type_16, type_17, (ParameterModifier[])(object)class86.t(bindingFlags, array, null, cultureInfo)) != null);
		while (obj != null)
		{
			do
			{
				try
				{
					_ = (Class6)((Class7)null).t((object)Class5.Default, (Type)null, (CultureInfo)null);
				}
				catch
				{
					gClass2 = gClass2;
					BindingFlags bindingFlags_60 = bindingFlags;
					MethodBase[] methodBase_18 = array4;
					Type[] type_18 = array6;
					Class7 obj64 = (Class7)(object)Class5.Default;
					Class7 class87 = @class;
					MethodBase[] methodBase_19 = array4;
					Class7 class88 = @class;
					Class7 class89 = @class;
					bindingFlags = default(BindingFlags);
					Class7 obj65 = (Class7)(object)((Class7)null).e(bindingFlags_60, methodBase_18, type_18, (ParameterModifier[])(object)obj64.e((BindingFlags)class87.j(default(BindingFlags), methodBase_19, ref *(object[]*)class88.j(default(BindingFlags), null, ref *(object[]*)null, (ParameterModifier[])(object)class89.j(bindingFlags, array4, ref reference2, array3, cultureInfo, (string[])(object)Class5.Default, out *(object*)Class5.Default), cultureInfo, null, out *(object*)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])null, (ParameterModifier[])null)), (ParameterModifier[])(object)Class5.Default, cultureInfo, array5, out *(object*)Class5.Default), array4, array6, array3));
					BindingFlags bindingFlags_61 = (BindingFlags)Class5.Default;
					bindingFlags = default(BindingFlags);
					Type type_19 = (Type)(object)((Class7)null).W(bindingFlags, array2, type, array6, array3);
					Class7 class90 = @class;
					Class7 class91 = @class;
					Class7 obj66 = (Class7)((Class7)(object)((Class7)null).W(bindingFlags, array2, (Type)(object)Class5.Default, (Type[])(object)Class5.Default, (ParameterModifier[])(object)@class.t(bindingFlags, null, null, cultureInfo))).t(obj, type, cultureInfo);
					bindingFlags = default(BindingFlags);
					_ = (GClass2)(object)obj65.W(bindingFlags_61, null, type_19, (Type[])(object)((Class7)(object)((Class7)(object)class90.e((BindingFlags)class91.t(null, (Type)(object)obj66.t((BindingFlags)((Class7)(object)((Class7)null).e(bindingFlags, array4, (Type[])(object)Class5.Default, (ParameterModifier[])(object)@class.j(bindingFlags, null, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo, null, out reference))).t(null, null, null), array, Class5.Default, cultureInfo), cultureInfo), array4, null, array3)).t((BindingFlags)Class5.Default, array, obj, cultureInfo)).t((BindingFlags)((Class7)(object)Class5.Default).t(((Class7)null).t((object)null, type, (CultureInfo)(object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference2, array3, null, array5, out *(object*)null)), type, cultureInfo), array, obj, cultureInfo), null);
				}
			}
			while ((object)Class5.Default != null);
		}
		if ((UIntPtr)@class.W(bindingFlags, (PropertyInfo[])(object)@class.e(bindingFlags, array4, array6, (ParameterModifier[])(object)@class.W(bindingFlags, null, null, array6, array3)), (Type)@class.t(Class5.Default, (Type)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, (CultureInfo)null), cultureInfo), array6, array3) == (UIntPtr)(nuint)0u)
		{
			try
			{
				if (unchecked((nuint)default(UIntPtr)) / (nuint)(UIntPtr)Class5.Default == 0)
				{
					_ = (Class7)(object)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, array2, (Type)(object)Class5.Default, array6, array3);
				}
			}
			finally
			{
				class24 = (Class4)(object)Class5.Default;
				goto IL_22d5;
			}
		}
		goto IL_22d5;
		IL_330f:
		gClass4 = gClass4;
		Class7 class92 = @class;
		Class7 class93 = @class;
		bindingFlags = default(BindingFlags);
		_ = (Class0)(object)class92.j(default(BindingFlags), null, ref *(object[]*)class93.j(bindingFlags, array4, ref reference2, array3, cultureInfo, array5, out reference), array3, cultureInfo, null, out *(object*)Class5.Default);
		@class = null;
		do
		{
			try
			{
				gClass = gClass;
			}
			catch
			{
				while (obj != null)
				{
					class8 = class8;
				}
			}
		}
		while ((object)Class5.Default != null);
		_003CModule_003E = null;
		try
		{
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_62 = bindingFlags;
			Class7 class94 = @class;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)((Class7)null).t(bindingFlags_62, (FieldInfo[])null, (object)null, (CultureInfo)(object)((Class7)null).j((BindingFlags)class94.e(bindingFlags, null, (Type[])(object)Class5.Default, array3), array4, ref *(object[]*)null, (ParameterModifier[])(object)((Class7)null).t((BindingFlags)Class5.Default, array, (object)Class5.Default, (CultureInfo)(object)Class5.Default), cultureInfo, array5, out *(object*)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference2, array3, null, null, out *(object*)((Class7)null).t((object)null, type, (CultureInfo)null)))) == (UIntPtr)(nuint)0u)
			{
				_ = (Class7)(object)@class.W(bindingFlags, null, (Type)(object)Class5.Default, null, (ParameterModifier[])(object)Class5.Default);
			}
		}
		finally
		{
			try
			{
				do
				{
					_ = (Struct2)((Class7)(object)Class5.Default).j(bindingFlags, array4, ref reference2, array3, null, array5, out *(object*)null);
				}
				while (obj != null);
			}
			catch
			{
				UIntPtr num13 = (UIntPtr)((Class7)(object)Class5.Default).t(obj, type, cultureInfo);
				num = default(UIntPtr);
				checked
				{
					nuint num14 = unchecked((nuint)num13) + (num - num) + unchecked((nuint)(UIntPtr)Class5.Default);
					num = default(UIntPtr);
					UIntPtr num15 = num;
					Class7 class95 = @class;
					bindingFlags = default(BindingFlags);
					nuint num16 = unchecked((nuint)num15) + unchecked((nuint)(UIntPtr)class95.W(bindingFlags, array2, null, array6, array3));
					UIntPtr num17 = num;
					UIntPtr num18 = num;
					num = default(UIntPtr);
					if (num14 * unchecked(num16 / checked(unchecked((nuint)num17) + (unchecked(checked(unchecked((nuint)num18) * num) / (nuint)(UIntPtr)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, cultureInfo)) - unchecked((nuint)(UIntPtr)Class5.Default)))) == 0)
					{
						class8 = (Class0)(object)@class.t(unchecked((BindingFlags)Class5.Default), null, null, cultureInfo);
					}
					else
					{
						_ = (_003CModule_003E)(object)Class5.Default;
					}
				}
			}
			goto IL_35c5;
		}
		IL_32a4:
		try
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (Qk7)(object)Class5.Default;
				}
				else
				{
					_ = (Class4)(object)Class5.Default;
					_003CModule_003E = _003CModule_003E;
				}
			}
		}
		finally
		{
			do
			{
				if (num == 0)
				{
					_ = (GClass1)@class.t(null, null, cultureInfo);
				}
			}
			while (obj != null);
			goto IL_330f;
		}
		IL_35c5:
		try
		{
			try
			{
				Class7 class96 = @class;
				BindingFlags bindingFlags_63 = bindingFlags;
				PropertyInfo[] propertyInfo_12 = (PropertyInfo[])(object)Class5.Default;
				Class7 class97 = @class;
				bindingFlags = default(BindingFlags);
				UIntPtr num19 = (UIntPtr)class96.W(bindingFlags_63, propertyInfo_12, (Type)(object)class97.e(bindingFlags, array4, array6, array3), array6, (ParameterModifier[])(object)Class5.Default);
				UIntPtr num20 = (UIntPtr)Class5.Default;
				num = default(UIntPtr);
				nuint num21 = (nuint)num20 / num;
				num = default(UIntPtr);
				if (checked(unchecked((nuint)num19) * (num21 + num + num)) == 0)
				{
					_ = (Struct2)Class5.Default;
					_ = (Qk7)(object)Class5.Default;
					Class7 class98 = @class;
					BindingFlags bindingFlags_64 = bindingFlags;
					MethodBase[] methodBase_20 = (MethodBase[])(object)Class5.Default;
					ref object[] object_19 = ref reference2;
					ParameterModifier[] parameterModifier_10 = (ParameterModifier[])(object)Class5.Default;
					CultureInfo cultureInfo_7 = cultureInfo;
					bindingFlags = default(BindingFlags);
					_ = (Class2)(object)class98.j(bindingFlags_64, methodBase_20, ref object_19, parameterModifier_10, cultureInfo_7, (string[])(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference2, (ParameterModifier[])null, cultureInfo, array5, out reference), out *(object*)@class.t(obj, type, null));
					gClass = (GClass2)(object)((Class7)null).e((BindingFlags)@class.t(bindingFlags, null, obj, cultureInfo), (MethodBase[])null, (Type[])null, (ParameterModifier[])(object)Class5.Default);
				}
			}
			finally
			{
				class24 = class24;
				goto end_IL_35c6;
			}
			end_IL_35c6:;
		}
		catch
		{
			try
			{
				while ((object)Class5.Default != null)
				{
					class8 = class8;
				}
			}
			finally
			{
				@class = @class;
				gClass4 = gClass4;
				goto end_IL_3717;
			}
			end_IL_3717:;
		}
		if (num == 0)
		{
			if ((UIntPtr)@class.e(bindingFlags, null, null, array3) == (UIntPtr)(nuint)0u)
			{
				num = default(UIntPtr);
				checked
				{
					if (num * (unchecked((nuint)(UIntPtr)Class5.Default) * unchecked((nuint)(UIntPtr)@class.j((BindingFlags)Class5.Default, null, ref reference2, (ParameterModifier[])(object)@class.e(bindingFlags, (MethodBase[])(object)@class.e((BindingFlags)@class.t(obj, type, cultureInfo), array4, (Type[])(object)((Class7)null).W(bindingFlags, array2, type, (Type[])(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)@class.e((BindingFlags)Class5.Default, null, (Type[])(object)((Class7)null).W((BindingFlags)Class5.Default, array2, (Type)null, array6, array3), array3), ref *(object[]*)Class5.Default, array3, cultureInfo, (string[])(object)Class5.Default, out *(object*)@class.t(obj, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default)), (ParameterModifier[])null), null), array6, array3), cultureInfo, (string[])((Class7)(object)Class5.Default).t(null, type, cultureInfo), out *(object*)null)) - num) == 0)
					{
						class24 = null;
					}
				}
			}
			else
			{
				try
				{
					_ = (Struct2)((Class7)null).e((BindingFlags)Class5.Default, (MethodBase[])null, (Type[])(object)Class5.Default, array3);
				}
				catch
				{
					class24 = class24;
				}
			}
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					class11 = class11;
					_ = (Class2)(object)Class5.Default;
					class24 = null;
				}
				finally
				{
					_ = (Class8)(object)Class5.Default;
					goto IL_39bd;
				}
			}
			Class7 class99 = @class;
			BindingFlags bindingFlags_65 = bindingFlags;
			FieldInfo[] fieldInfo_9 = array;
			object object_20 = obj;
			bindingFlags = default(BindingFlags);
			class11 = (Class8)(object)class99.t(bindingFlags_65, fieldInfo_9, object_20, (CultureInfo)(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)@class.e(bindingFlags, array4, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default), ref *(object[]*)Class5.Default, array3, (CultureInfo)(object)Class5.Default, array5, out reference));
		}
		goto IL_39bd;
		IL_22d5:
		_003CModule_003E = _003CModule_003E;
		_ = (Class2)(object)Class5.Default;
		try
		{
			if ((UIntPtr)((Class7)(object)@class.W(bindingFlags, array2, type, (Type[])(object)Class5.Default, array3)).t(obj, type, cultureInfo) == (UIntPtr)(nuint)0u && (UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				_ = Class5.Default;
			}
		}
		finally
		{
			goto IL_2343;
		}
		IL_0ced:
		if (num == 0)
		{
			try
			{
				Class7 class100 = @class;
				BindingFlags bindingFlags_66 = (BindingFlags)@class.j(bindingFlags, null, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo, (string[])(object)Class5.Default, out reference);
				PropertyInfo[] propertyInfo_13 = (PropertyInfo[])(object)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, array, obj, null);
				Class7 class101 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_67 = bindingFlags;
				reference2 = ref reference2;
				_ = (_003CModule_003E)(object)class100.W(bindingFlags_66, propertyInfo_13, (Type)(object)class101.j(bindingFlags_67, null, ref reference2, null, cultureInfo, array5, out reference), array6, array3);
			}
			finally
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Class0)(object)@class.t(bindingFlags, array, obj, (CultureInfo)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference2, array3, (CultureInfo)null, array5, out reference));
				}
				else
				{
					@struct = @struct;
					_ = (Class5)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, array6, array3);
					_ = (Class9)(object)Class5.Default;
				}
				goto IL_1035;
			}
		}
		goto IL_1035;
		IL_2343:
		_ = (Class7)(object)((Class7)(object)Class5.Default).t(bindingFlags, array, obj, cultureInfo);
		class24 = (Class4)((Class7)(object)Class5.Default).t(obj, null, cultureInfo);
		num = default(UIntPtr);
		if (unchecked((nuint)default(UIntPtr)) / checked(num + unchecked(checked(num - num * num) / (nuint)(UIntPtr)@class.t(bindingFlags, array, obj, cultureInfo))) == 0)
		{
			_ = (GClass3)(object)Class5.Default;
		}
		else
		{
			while (obj != null)
			{
				try
				{
					class9 = class9;
				}
				catch
				{
					_003CModule_003E = _003CModule_003E;
				}
			}
		}
		while ((object)Class5.Default != null)
		{
			class3 = class3;
		}
		if (num == 0)
		{
			Class7 class102 = @class;
			BindingFlags bindingFlags_68 = bindingFlags;
			PropertyInfo[] propertyInfo_14 = array2;
			Type type_20 = (Type)(object)Class5.Default;
			Class7 class103 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Class4)(object)class102.W(bindingFlags_68, propertyInfo_14, type_20, (Type[])(object)class103.e(bindingFlags, (MethodBase[])(object)Class5.Default, array6, array3), null);
		}
		try
		{
			@struct = @struct;
		}
		finally
		{
			do
			{
				_ = (GClass3)((Class7)(object)Class5.Default).t(obj, null, cultureInfo);
			}
			while (obj != null);
			goto IL_249d;
		}
	}

	unsafe static void smethod_2()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] array2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] array3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] array4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out FieldInfo[] array5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class7 @class);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out UIntPtr num2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags);
		try
		{
			UIntPtr num = (UIntPtr)Class5.Default;
			num2 = num2;
			num2 = default(UIntPtr);
			if (checked(unchecked((nuint)num) + num2) == 0)
			{
				BindingFlags bindingFlags_ = (BindingFlags)Class5.Default;
				array = array;
				PropertyInfo[] propertyInfo_ = array;
				Type type_ = (Type)(object)Class5.Default;
				@class = @class;
				Class7 class2 = @class;
				bindingFlags = bindingFlags;
				BindingFlags bindingFlags_2 = bindingFlags;
				BindingFlags bindingFlags_3 = bindingFlags;
				array2 = array2;
				MethodBase[] methodBase_ = array2;
				Class7 obj = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_4 = (BindingFlags)((Class7)null).e(bindingFlags, array2, (Type[])null, (ParameterModifier[])(object)Class5.Default);
				PropertyInfo[] propertyInfo_2 = array;
				type = null;
				Type[] type_2 = (Type[])(object)obj.W(bindingFlags_4, propertyInfo_2, type, (Type[])(object)Class5.Default, null);
				array3 = array3;
				FieldInfo[] fieldInfo_ = (FieldInfo[])(object)((Class7)null).e(bindingFlags_3, methodBase_, type_2, array3);
				obj2 = null;
				array4 = (Type[])(object)class2.t(bindingFlags_2, fieldInfo_, obj2, (CultureInfo)(object)Class5.Default);
				Type[] type_3 = array4;
				Class7 obj3 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_5 = bindingFlags;
				array5 = array5;
				FieldInfo[] fieldInfo_2 = array5;
				cultureInfo = null;
				_ = (GClass2)(object)((Class7)null).W(bindingFlags_, propertyInfo_, type_, type_3, (ParameterModifier[])(object)obj3.t(bindingFlags_5, fieldInfo_2, null, cultureInfo));
			}
		}
		catch
		{
			do
			{
				try
				{
					_ = (GClass1)(object)Class5.Default;
				}
				catch
				{
					_ = (GClass1)(object)((Class7)null).t((BindingFlags)((Class7)(object)Class5.Default).W(bindingFlags, array, null, array4, array3), (FieldInfo[])(object)Class5.Default, obj2, (CultureInfo)null);
				}
			}
			while ((object)Class5.Default != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct1 @struct);
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					_ = (Class2)(object)Class5.Default;
				}
				finally
				{
					@struct = @struct;
					@struct = default(Struct1);
					@struct = @struct;
					goto end_IL_019f;
				}
				end_IL_019f:;
			}
			finally
			{
				if (num2 == 0)
				{
					_ = (Class4)(object)Class5.Default;
				}
				else
				{
					Class7 obj6 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_6 = (BindingFlags)Class5.Default;
					MethodBase[] methodBase_2 = (MethodBase[])(object)Class5.Default;
					ref object[] object_ = ref *(object[]*)Class5.Default;
					ParameterModifier[] parameterModifier_ = array3;
					CultureInfo cultureInfo_ = (CultureInfo)(object)@class.t(bindingFlags, array5, obj2, cultureInfo);
					Class7 class3 = @class;
					bindingFlags = default(BindingFlags);
					string[] string_ = (string[])(object)class3.e(bindingFlags, (MethodBase[])(object)@class.e((BindingFlags)Class5.Default, (MethodBase[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, (CultureInfo)null), (Type[])(object)Class5.Default, null), null, array3);
					reference = ref reference;
					_ = (Class0)(object)obj6.j(bindingFlags_6, methodBase_2, ref object_, parameterModifier_, cultureInfo_, string_, out reference);
				}
				goto IL_02a9;
			}
		}
		goto IL_02a9;
		IL_3918:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class4 class4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct2 struct2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class0 class5);
		try
		{
			if (num2 == 0)
			{
				try
				{
					class4 = null;
				}
				catch
				{
					class5 = class5;
				}
			}
			else
			{
				struct2 = struct2;
			}
		}
		finally
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Class0)(object)((Class7)(object)Class5.Default).e((BindingFlags)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array4, null), array2, array4, array3);
				}
				finally
				{
					class4 = class4;
					goto IL_39b1;
				}
			}
			_ = (GClass0)(object)Class5.Default;
			_ = (_003CModule_003E)(object)Class5.Default;
			goto IL_39b1;
		}
		IL_3c5f:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class6 class6);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qk7 qk);
		if (checked(num2 * num2) / num2 / checked(num2 * num2) == 0)
		{
			try
			{
				qk = qk;
			}
			finally
			{
				try
				{
					_ = (Class4)(object)Class5.Default;
				}
				finally
				{
					_ = (Qk7)(object)((Class7)null).W((BindingFlags)Class5.Default, array, (Type)(object)Class5.Default, array4, (ParameterModifier[])null);
					class6 = class6;
					qk = qk;
					_ = (_003CModule_003E)(object)Class5.Default;
					goto IL_3cd9;
				}
			}
		}
		goto IL_3cd9;
		IL_02a9:
		_ = (_003CModule_003E)(object)Class5.Default;
		do
		{
			if (num2 == 0)
			{
				try
				{
					_ = (Class7)(object)Class5.Default;
				}
				finally
				{
					_ = (Class9)(object)Class5.Default;
					_ = (GClass1)(object)Class5.Default;
					continue;
				}
			}
		}
		while (obj2 != null);
		Class7 class7 = @class;
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_7 = bindingFlags;
		MethodBase[] methodBase_3 = array2;
		ref object[] object_2 = ref *(object[]*)((Class7)(object)Class5.Default).t(null, (Type)((Class7)null).t((object)Class5.Default, (Type)null, cultureInfo), null);
		string[] string_2 = null;
		nuint num3 = unchecked((nuint)default(UIntPtr)) / (nuint)(UIntPtr)class7.j(bindingFlags_7, methodBase_3, ref object_2, null, null, string_2, out *(object*)null);
		num2 = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class8 class8);
		if (checked(num3 + num2) == 0)
		{
			if (checked(num2 * num2) == 0)
			{
				class8 = (Class8)(object)@class.e((BindingFlags)Class5.Default, array2, array4, null);
				class8 = null;
			}
			else
			{
				while ((object)Class5.Default != null)
				{
					_ = (Class2)(object)Class5.Default;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass0 gClass);
		try
		{
			while (true)
			{
				BindingFlags bindingFlags_8 = (BindingFlags)Class5.Default;
				Class7 class9 = @class;
				BindingFlags bindingFlags_9 = bindingFlags;
				MethodBase[] methodBase_4 = array2;
				ref object[] object_3 = ref *(object[]*)Class5.Default;
				CultureInfo cultureInfo_2 = cultureInfo;
				Class7 class10 = @class;
				object object_4 = obj2;
				Type type_4 = type;
				Class7 obj8 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				if ((object)((Class7)null).W(bindingFlags_8, (PropertyInfo[])(object)class9.j(bindingFlags_9, methodBase_4, ref object_3, null, cultureInfo_2, (string[])class10.t(object_4, type_4, (CultureInfo)(object)obj8.j(bindingFlags, array2, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, null, string_2, out *(object*)Class5.Default)), out *(object*)@class.W((BindingFlags)Class5.Default, array, type, null, (ParameterModifier[])@class.t(null, null, cultureInfo))), type, (Type[])null, (ParameterModifier[])null) != null)
				{
					try
					{
						Qk7 obj9 = (Qk7)(object)Class5.Default;
						qk = null;
						qk = obj9;
						GClass0 obj10 = (GClass0)(object)Class5.Default;
						gClass = gClass;
						gClass = obj10;
					}
					finally
					{
						Class7 class11 = @class;
						bindingFlags = default(BindingFlags);
						_ = (Class4)(object)class11.j((BindingFlags)((Class7)null).t(bindingFlags, array5, (object)@class.t(bindingFlags, array5, obj2, cultureInfo), (CultureInfo)(object)Class5.Default), array2, ref *(object[]*)null, (ParameterModifier[])(object)@class.e((BindingFlags)Class5.Default, array2, null, array3), cultureInfo, string_2, out reference);
						continue;
					}
				}
				break;
			}
		}
		finally
		{
			try
			{
				while (obj2 != null)
				{
					class4 = (Class4)@class.t(obj2, type, null);
					class4 = null;
				}
			}
			catch
			{
				while ((object)Class5.Default != null)
				{
					Class0 obj11 = (Class0)(object)@class.e((BindingFlags)@class.e(bindingFlags, array2, null, array3), (MethodBase[])(object)Class5.Default, array4, array3);
					class5 = null;
					class5 = obj11;
				}
			}
			goto IL_05c5;
		}
		IL_0a3d:
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			_ = (Class6)(object)Class5.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass3 gClass2);
		try
		{
			_ = (Qk7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			_ = (Class9)(object)((Class7)(object)((Class7)null).W(bindingFlags, array, type, array4, array3)).W((BindingFlags)Class5.Default, (PropertyInfo[])(object)@class.t((BindingFlags)Class5.Default, array5, obj2, cultureInfo), type, array4, array3);
		}
		catch
		{
			try
			{
				if ((UIntPtr)((Class7)((Class7)(object)Class5.Default).t(obj2, null, null)).t(null, null, cultureInfo) == (UIntPtr)(nuint)0u)
				{
					_ = (GClass1)(object)Class5.Default;
				}
			}
			finally
			{
				try
				{
					gClass2 = (GClass3)(object)Class5.Default;
				}
				finally
				{
					struct2 = struct2;
					struct2 = struct2;
					goto end_IL_0ad0;
				}
			}
			end_IL_0ad0:;
		}
		ref object[] object_5;
		try
		{
			try
			{
				UIntPtr num4 = (UIntPtr)@class.j(bindingFlags, null, ref object_5, array3, cultureInfo, null, out *(object*)Class5.Default);
				Class7 class12 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_10 = bindingFlags;
				MethodBase[] methodBase_5 = array2;
				Type[] type_5 = array4;
				Class7 class13 = @class;
				BindingFlags bindingFlags_11 = bindingFlags;
				PropertyInfo[] propertyInfo_3 = array;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_12 = bindingFlags;
				bindingFlags = default(BindingFlags);
				Class7 obj14 = (Class7)(object)class12.e(bindingFlags_10, methodBase_5, type_5, (ParameterModifier[])(object)class13.W(bindingFlags_11, propertyInfo_3, null, (Type[])(object)((Class7)null).t(bindingFlags_12, (FieldInfo[])(object)((Class7)null).t(bindingFlags, array5, obj2, (CultureInfo)null), (object)Class5.Default, cultureInfo), null));
				Class7 class14 = @class;
				BindingFlags bindingFlags_13 = bindingFlags;
				MethodBase[] methodBase_6 = array2;
				Class7 class15 = @class;
				bindingFlags = default(BindingFlags);
				Class7 obj15 = (Class7)(object)obj14.j((BindingFlags)class14.j(bindingFlags_13, methodBase_6, ref *(object[]*)class15.e(bindingFlags, array2, array4, null), array3, null, string_2, out *(object*)null), array2, ref object_5, null, (CultureInfo)(object)Class5.Default, null, out reference);
				bindingFlags = default(BindingFlags);
				if ((nuint)num4 / (nuint)(UIntPtr)obj15.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, null, array3) == 0)
				{
					_ = (GClass2)(object)Class5.Default;
				}
			}
			catch
			{
				if (num2 == 0)
				{
					_ = (_003CModule_003E)(object)Class5.Default;
				}
				else
				{
					_ = (Class6)(object)Class5.Default;
				}
			}
		}
		catch
		{
			UIntPtr num5 = (UIntPtr)Class5.Default;
			Class7 obj17 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			checked
			{
				if (unchecked((nuint)num5) - unchecked((nuint)(UIntPtr)obj17.e(bindingFlags, null, (Type[])@class.t(obj2, type, cultureInfo), null)) == 0)
				{
					UIntPtr num6 = unchecked((UIntPtr)@class.t((BindingFlags)((Class7)(object)Class5.Default).t(bindingFlags, null, obj2, null), array5, obj2, cultureInfo));
					num2 = default(UIntPtr);
					if (unchecked((nuint)num6) - num2 == 0)
					{
						_ = (GClass0)(object)Class5.Default;
						Class7 obj18 = (Class7)@class.t(null, null, null);
						object object_6 = obj2;
						bindingFlags = default(BindingFlags);
						_ = (Class4)obj18.t(object_6, (Type)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj2, cultureInfo), cultureInfo);
						_ = (Class6)(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array4, null);
						_ = (Class2)(object)Class5.Default;
					}
				}
			}
		}
		_ = (Class7)(object)Class5.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass1 gClass3);
		try
		{
			try
			{
				_ = (GClass3)@class.t(obj2, type, cultureInfo);
				BindingFlags bindingFlags_14 = (BindingFlags)Class5.Default;
				Class7 class16 = @class;
				Class7 obj20 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				MethodBase[] methodBase_7 = (MethodBase[])class16.t(obj20.e(bindingFlags, array2, array4, array3), type, null);
				Type[] type_6 = (Type[])(object)((Class7)null).t(bindingFlags, array5, obj2, cultureInfo);
				bindingFlags = default(BindingFlags);
				gClass3 = (GClass1)(object)((Class7)(object)((Class7)null).e(bindingFlags_14, methodBase_7, type_6, (ParameterModifier[])(object)((Class7)null).e(bindingFlags, array2, (Type[])null, array3))).e(bindingFlags, array2, array4, (ParameterModifier[])(object)Class5.Default);
			}
			catch
			{
				_ = (Class8)(object)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])(object)Class5.Default, (Type)null, array4, array3);
			}
			finally
			{
				class8 = class8;
				goto end_IL_0dca;
			}
			end_IL_0dca:;
		}
		finally
		{
			while (obj2 != null)
			{
				do
				{
					@class = @class;
				}
				while (obj2 != null);
			}
			goto IL_0f8e;
		}
		IL_41e1:
		_ = (Class8)(object)Class5.Default;
		num2 = default(UIntPtr);
		if (unchecked((nuint)default(UIntPtr)) / num2 == 0)
		{
			gClass = gClass;
		}
		while ((object)@class.e(bindingFlags, array2, (Type[])(object)Class5.Default, null) != null)
		{
			gClass3 = gClass3;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class5 class17);
		if (num2 / unchecked((nuint)default(UIntPtr)) == 0)
		{
			while (obj2 != null)
			{
				while ((object)Class5.Default != null)
				{
					class17 = class17;
				}
			}
		}
		@struct = @struct;
		Class7 class18 = @class;
		bindingFlags = default(BindingFlags);
		_ = (Class9)(object)class18.e(bindingFlags, null, array4, array3);
		_ = (Struct1)Class5.Default;
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			_ = (Class2)(object)Class5.Default;
		}
		else
		{
			try
			{
				do
				{
					_ = (Class0)(object)Class5.Default;
				}
				while (obj2 != null);
			}
			catch
			{
				try
				{
					class5 = class5;
					_ = (GClass0)(object)Class5.Default;
					_ = (Class8)(object)Class5.Default;
				}
				catch
				{
					class8 = class8;
				}
			}
		}
		class4 = null;
		num2 = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class9 class20);
		if (num2 == (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)@class.W((BindingFlags)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])null, obj2, (CultureInfo)(object)@class.W((BindingFlags)Class5.Default, array, type, (Type[])(object)Class5.Default, (ParameterModifier[])(object)@class.t(bindingFlags, array5, ((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)null, (CultureInfo)null), cultureInfo))), array, null, array4, null) == (UIntPtr)(nuint)0u)
			{
				Class7 class19 = @class;
				BindingFlags bindingFlags_15 = bindingFlags;
				bindingFlags = default(BindingFlags);
				_ = (Class6)(object)class19.e(bindingFlags_15, null, (Type[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)((Class7)(object)@class.e((BindingFlags)Class5.Default, null, array4, (ParameterModifier[])(object)Class5.Default)).t((BindingFlags)((Class7)null).W(bindingFlags, array, type, (Type[])null, (ParameterModifier[])null), null, null, null), (object)null, cultureInfo), null);
				class20 = null;
				_ = Class5.Default;
				Class7 class21 = @class;
				bindingFlags = default(BindingFlags);
				_ = (GClass3)class21.t(((Class7)null).e(bindingFlags, array2, array4, (ParameterModifier[])@class.t(obj2, null, cultureInfo)), null, cultureInfo);
			}
			goto IL_47df;
		}
		try
		{
			do
			{
				_ = (GClass3)(object)@class.e(bindingFlags, null, null, array3);
			}
			while ((object)Class5.Default != null);
		}
		finally
		{
			try
			{
				Class7 obj24 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_16 = bindingFlags;
				ref object[] object_7 = ref *(object[]*)Class5.Default;
				ParameterModifier[] parameterModifier_2 = (ParameterModifier[])@class.t(obj2, null, cultureInfo);
				Class7 obj25 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_17 = bindingFlags;
				MethodBase[] methodBase_8 = (MethodBase[])@class.t(Class5.Default, type, cultureInfo);
				Type[] type_7 = (Type[])(object)Class5.Default;
				Class7 class22 = @class;
				BindingFlags bindingFlags_18 = bindingFlags;
				Class7 class23 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_19 = bindingFlags;
				Class7 class24 = @class;
				BindingFlags bindingFlags_20 = bindingFlags;
				Class7 class25 = @class;
				bindingFlags = default(BindingFlags);
				Class7 obj26 = (Class7)(object)class24.e(bindingFlags_20, (MethodBase[])(object)class25.W(bindingFlags, (PropertyInfo[])(object)@class.t(bindingFlags, array5, obj2, null), (Type)(object)Class5.Default, (Type[])(object)Class5.Default, null), array4, (ParameterModifier[])(object)Class5.Default);
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_21 = (BindingFlags)((Class7)null).j(bindingFlags_16, (MethodBase[])null, ref object_7, parameterModifier_2, (CultureInfo)(object)obj25.e(bindingFlags_17, methodBase_8, type_7, (ParameterModifier[])(object)class22.j(bindingFlags_18, null, ref *(object[]*)class23.j(bindingFlags_19, (MethodBase[])(object)obj26.j(bindingFlags, array2, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)@class.t((BindingFlags)Class5.Default, array5, obj2, null), cultureInfo, string_2, out reference), ref *(object[]*)Class5.Default, array3, (CultureInfo)(object)@class.W(bindingFlags, (PropertyInfo[])@class.t(null, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default), null, array4, null), null, out reference), null, null, (string[])(object)Class5.Default, out *(object*)null)), (string[])(object)Class5.Default, out reference);
				MethodBase[] methodBase_9 = array2;
				Class7 class26 = @class;
				bindingFlags = default(BindingFlags);
				ref object[] object_8 = ref *(object[]*)((Class7)(object)class26.e(bindingFlags, null, array4, null)).j((BindingFlags)Class5.Default, array2, ref *(object[]*)null, array3, cultureInfo, null, out reference);
				object object_9 = obj2;
				Type type_8 = type;
				Class7 class27 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Struct2)obj24.j(bindingFlags_21, methodBase_9, ref object_8, (ParameterModifier[])((Class7)null).t(object_9, type_8, (CultureInfo)(object)class27.e(bindingFlags, array2, array4, (ParameterModifier[])(object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref object_5, null, cultureInfo, string_2, out reference))), cultureInfo, null, out *(object*)Class5.Default);
			}
			finally
			{
				_ = (GClass1)(object)@class.e((BindingFlags)((Class7)((Class7)(object)Class5.Default).t(obj2, null, (CultureInfo)(object)@class.e((BindingFlags)((Class7)null).e(bindingFlags, array2, array4, array3), (MethodBase[])(object)Class5.Default, array4, array3))).t(null, type, null), null, (Type[])(object)Class5.Default, null);
				goto IL_47df;
			}
		}
		IL_39b1:
		checked
		{
			try
			{
				try
				{
					if (unchecked((nuint)(UIntPtr)Class5.Default) - unchecked((nuint)(UIntPtr)Class5.Default) == 0)
					{
						_ = (Class6)(object)((Class7)null).t(bindingFlags, array5, obj2, (CultureInfo)(object)@class.e(bindingFlags, array2, array4, array3));
					}
				}
				finally
				{
					class17 = class17;
					goto end_IL_39b2;
				}
				end_IL_39b2:;
			}
			catch
			{
				_ = (Class4)(object)Class5.Default;
			}
		}
		do
		{
			if (default(UIntPtr) != (UIntPtr)(nuint)0u)
			{
				qk = qk;
				Class7 class28 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class6)((Class7)(object)class28.j(bindingFlags, array2, ref object_5, array3, null, null, out *(object*)null)).t(obj2, type, cultureInfo);
				_ = (Qk7)(object)Class5.Default;
			}
			else if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				bindingFlags = default(BindingFlags);
				_ = (GClass3)(object)((Class7)(object)((Class7)null).e(bindingFlags, array2, array4, (ParameterModifier[])null)).e(bindingFlags, array2, array4, array3);
			}
		}
		while (obj2 != null);
		num2 = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class2 class29);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		if (unchecked((nuint)default(UIntPtr)) / num2 == 0)
		{
			class29 = class29;
			_ = (GClass2)(object)Class5.Default;
			_003CModule_003E = (_003CModule_003E)(object)((Class7)null).W(bindingFlags, array, type, array4, array3);
		}
		else
		{
			_ = (GClass0)(object)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, array2, null, array3);
			bindingFlags = default(BindingFlags);
			_ = (Class5)(object)((Class7)null).W(bindingFlags, array, type, array4, array3);
			gClass3 = gClass3;
		}
		gClass3 = gClass3;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class10 class30);
		try
		{
			checked
			{
				if (num2 == 0)
				{
					num2 = default(UIntPtr);
					if (num2 + unchecked((nuint)(UIntPtr)@class.j(bindingFlags, array2, ref *(object[]*)Class5.Default, array3, (CultureInfo)(object)Class5.Default, string_2, out reference)) == 0)
					{
						class30 = class30;
					}
				}
				else
				{
					qk = qk;
					_ = (Qk7)(object)@class.t(bindingFlags, array5, obj2, cultureInfo);
				}
			}
		}
		finally
		{
			while ((object)Class5.Default != null)
			{
				while (obj2 != null)
				{
					_ = (Class7)(object)((Class7)null).W((BindingFlags)Class5.Default, array, type, array4, (ParameterModifier[])(object)Class5.Default);
				}
			}
			goto IL_3c5f;
		}
		IL_19d4:
		try
		{
			class17 = class17;
		}
		catch
		{
			while ((object)Class5.Default != null)
			{
				gClass2 = gClass2;
			}
		}
		try
		{
			while ((object)Class5.Default != null)
			{
				do
				{
					_ = (Class0)(object)Class5.Default;
					_ = (GClass1)(object)((Class7)null).e((BindingFlags)Class5.Default, array2, (Type[])null, array3);
				}
				while (obj2 != null);
			}
		}
		finally
		{
			try
			{
				do
				{
					_ = (Class0)(object)Class5.Default;
				}
				while (obj2 != null);
			}
			catch
			{
				do
				{
					Class7 class31 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass2)(object)class31.t(bindingFlags, array5, @class.t(obj2, type, cultureInfo), cultureInfo);
				}
				while (obj2 != null);
			}
			goto IL_1a99;
		}
		IL_2e51:
		if (checked(num2 - num2) == 0)
		{
			while ((object)Class5.Default != null)
			{
				try
				{
					class4 = null;
				}
				finally
				{
					Class7 obj30 = (Class7)@class.t(null, null, cultureInfo);
					BindingFlags bindingFlags_22 = bindingFlags;
					MethodBase[] methodBase_10 = array2;
					BindingFlags bindingFlags_23 = (BindingFlags)Class5.Default;
					Class7 class32 = @class;
					bindingFlags = default(BindingFlags);
					_ = (_003CModule_003E)(object)obj30.e(bindingFlags_22, methodBase_10, (Type[])(object)((Class7)null).e(bindingFlags_23, (MethodBase[])null, (Type[])(object)class32.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo, null, out reference), array3), array3);
					continue;
				}
			}
		}
		Class7 obj31 = (Class7)@class.t(obj2, type, cultureInfo);
		bindingFlags = default(BindingFlags);
		if (checked(unchecked((nuint)(UIntPtr)obj31.e(bindingFlags, array2, array4, array3)) + num2) == 0 && num2 == 0 && (UIntPtr)((Class7)(object)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, array5, obj2, cultureInfo)).t(obj2, type, (CultureInfo)(object)Class5.Default) == (UIntPtr)(nuint)0u)
		{
			Class7 obj32 = (Class7)(object)@class.t(bindingFlags, array5, null, cultureInfo);
			BindingFlags bindingFlags_24 = bindingFlags;
			MethodBase[] methodBase_11 = (MethodBase[])(object)Class5.Default;
			ParameterModifier[] parameterModifier_3 = array3;
			CultureInfo cultureInfo_3 = cultureInfo;
			Class7 class33 = @class;
			MethodBase[] methodBase_12 = array2;
			Type[] type_9 = array4;
			Class7 obj33 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			_ = (GClass3)(object)obj32.j(bindingFlags_24, methodBase_11, ref object_5, parameterModifier_3, cultureInfo_3, string_2, out *(object*)class33.e(default(BindingFlags), methodBase_12, type_9, (ParameterModifier[])(object)obj33.t(bindingFlags, array5, obj2, cultureInfo)));
		}
		qk = qk;
		class30 = null;
		struct2 = default(Struct2);
		gClass = (GClass0)(object)Class5.Default;
		do
		{
			_ = (_003CModule_003E)(object)Class5.Default;
		}
		while (obj2 != null);
		do
		{
			BindingFlags bindingFlags_25 = bindingFlags;
			Class7 class34 = @class;
			Class7 class35 = @class;
			Class7 class36 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Class9)(object)((Class7)null).e(bindingFlags_25, (MethodBase[])null, (Type[])(object)class34.j(default(BindingFlags), (MethodBase[])(object)class35.W((BindingFlags)class36.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref object_5, array3, null, string_2, out reference), (PropertyInfo[])(object)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, null, array4, array3), (Type)(object)@class.j((BindingFlags)Class5.Default, array2, ref *(object[]*)null, null, (CultureInfo)(object)Class5.Default, (string[])(object)((Class7)(object)Class5.Default).j(bindingFlags, null, ref *(object[]*)null, array3, cultureInfo, null, out reference), out reference), array4, null), ref object_5, array3, cultureInfo, (string[])(object)Class5.Default, out *(object*)Class5.Default), array3);
		}
		while (obj2 != null);
		if ((UIntPtr)@class.e(bindingFlags, array2, null, array3) == (UIntPtr)(nuint)0u)
		{
			do
			{
				try
				{
					Class7 class37 = @class;
					BindingFlags bindingFlags_26 = (BindingFlags)Class5.Default;
					Class7 class38 = @class;
					bindingFlags = default(BindingFlags);
					PropertyInfo[] propertyInfo_4 = (PropertyInfo[])(object)class38.t(bindingFlags, array5, Class5.Default, cultureInfo);
					Type type_10 = (Type)@class.t(null, null, cultureInfo);
					Type[] type_11 = (Type[])(object)Class5.Default;
					Class7 class39 = @class;
					bindingFlags = default(BindingFlags);
					Class7 obj34 = (Class7)(object)class39.W(bindingFlags, array, type, array4, array3);
					bindingFlags = default(BindingFlags);
					_ = (GClass1)(object)class37.W(bindingFlags_26, propertyInfo_4, type_10, type_11, (ParameterModifier[])(object)obj34.W(bindingFlags, array, null, array4, null));
				}
				catch
				{
					gClass2 = (GClass3)(object)((Class7)(object)@class.W(bindingFlags, array, (Type)(object)Class5.Default, (Type[])(object)Class5.Default, (ParameterModifier[])(object)@class.W(bindingFlags, null, type, array4, array3))).t(bindingFlags, array5, obj2, cultureInfo);
				}
			}
			while ((object)Class5.Default != null);
		}
		GClass2 gClass4;
		try
		{
			try
			{
				_ = (Class6)(object)Class5.Default;
			}
			catch
			{
				gClass4 = gClass4;
			}
			finally
			{
				Class7 class40 = @class;
				BindingFlags bindingFlags_27 = bindingFlags;
				FieldInfo[] fieldInfo_3 = array5;
				object object_10 = obj2;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_28 = bindingFlags;
				MethodBase[] methodBase_13 = array2;
				Class7 obj37 = (Class7)@class.t(null, null, null);
				Class7 class41 = @class;
				bindingFlags = default(BindingFlags);
				_ = (GClass2)(object)class40.t(bindingFlags_27, fieldInfo_3, object_10, (CultureInfo)(object)((Class7)null).e(bindingFlags_28, methodBase_13, (Type[])null, (ParameterModifier[])(object)obj37.W((BindingFlags)((Class7)(object)class41.j(bindingFlags, array2, ref *(object[]*)null, (ParameterModifier[])(object)@class.j(bindingFlags, null, ref *(object[]*)Class5.Default, array3, (CultureInfo)((Class7)(object)Class5.Default).t(null, null, cultureInfo), (string[])(object)Class5.Default, out *(object*)null), cultureInfo, (string[])(object)Class5.Default, out *(object*)Class5.Default)).j(bindingFlags, array2, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo, string_2, out reference), (PropertyInfo[])(object)Class5.Default, null, array4, array3)));
				goto end_IL_32dd;
			}
			end_IL_32dd:;
		}
		finally
		{
			while ((object)((Class7)null).t(bindingFlags, array5, obj2, (CultureInfo)null) != null)
			{
				while (obj2 != null)
				{
					class4 = null;
					struct2 = struct2;
				}
			}
			goto IL_3441;
		}
		IL_22cb:
		if ((UIntPtr)((Class7)null).t(bindingFlags, array5, obj2, cultureInfo) == (UIntPtr)(nuint)0u)
		{
			struct2 = default(Struct2);
		}
		num2 = default(UIntPtr);
		if (num2 == (UIntPtr)(nuint)0u)
		{
			if (num2 == (UIntPtr)(nuint)0u)
			{
				do
				{
					class30 = class30;
				}
				while (obj2 != null);
			}
			else
			{
				bindingFlags = default(BindingFlags);
				if (unchecked((nuint)default(UIntPtr)) / (nuint)(UIntPtr)((Class7)null).t(bindingFlags, array5, (object)null, cultureInfo) == 0)
				{
					class8 = class8;
				}
				else
				{
					@class = @class;
				}
			}
		}
		num2 = default(UIntPtr);
		UIntPtr num7 = num2;
		Class7 class42 = @class;
		BindingFlags bindingFlags_29 = (BindingFlags)((Class7)@class.t(obj2, null, cultureInfo)).j((BindingFlags)((Class7)null).W((BindingFlags)Class5.Default, array, (Type)@class.t(obj2, type, (CultureInfo)(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array4, array3)), array4, (ParameterModifier[])null), (MethodBase[])(object)Class5.Default, ref object_5, array3, null, null, out reference);
		Class7 obj38 = (Class7)(object)((Class7)(object)@class.j(bindingFlags, null, ref object_5, (ParameterModifier[])@class.t(obj2, type, null), cultureInfo, null, out *(object*)null)).t((BindingFlags)Class5.Default, array5, obj2, cultureInfo);
		bindingFlags = default(BindingFlags);
		if (checked(unchecked((nuint)num7) - unchecked((nuint)(UIntPtr)class42.j((BindingFlags)((Class7)null).t(bindingFlags_29, (FieldInfo[])null, (object)obj38.W(bindingFlags, array, null, null, null), cultureInfo), array2, ref object_5, array3, cultureInfo, string_2, out reference))) == 0)
		{
			try
			{
				Class7 class43 = @class;
				bindingFlags = default(BindingFlags);
				if ((UIntPtr)class43.e(bindingFlags, (MethodBase[])(object)Class5.Default, array4, array3) == (UIntPtr)(nuint)0u)
				{
					Class7 class44 = @class;
					bindingFlags = default(BindingFlags);
					_ = (_003CModule_003E)(object)class44.j(bindingFlags, array2, ref *(object[]*)null, array3, null, null, out reference);
				}
				else
				{
					class8 = class8;
				}
			}
			finally
			{
				if (num2 == (UIntPtr)(nuint)0u)
				{
					@class = @class;
				}
				goto IL_2597;
			}
		}
		while (obj2 != null)
		{
			while (obj2 != null)
			{
				_ = (GClass0)(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, cultureInfo);
				_ = (Qk7)(object)@class.j(bindingFlags, null, ref object_5, null, cultureInfo, string_2, out reference);
				struct2 = default(Struct2);
			}
		}
		goto IL_2597;
		IL_0f8e:
		while ((object)Class5.Default != null)
		{
			num2 = default(UIntPtr);
			nuint num8 = num2;
			Class7 class45 = @class;
			BindingFlags bindingFlags_30 = (BindingFlags)Class5.Default;
			MethodBase[] methodBase_14 = array2;
			Class7 class46 = @class;
			BindingFlags bindingFlags_31 = (BindingFlags)Class5.Default;
			Type[] type_12 = array4;
			Class7 obj39 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			checked
			{
				if (num8 - unchecked((nuint)(UIntPtr)class45.e(bindingFlags_30, methodBase_14, (Type[])(object)class46.e(bindingFlags_31, null, type_12, (ParameterModifier[])(object)obj39.W(bindingFlags, null, null, array4, (ParameterModifier[])(object)Class5.Default)), array3)) == 0)
				{
					while (obj2 != null)
					{
						class17 = null;
						class17 = class17;
					}
				}
			}
		}
		if (num2 == 0)
		{
			num2 = default(UIntPtr);
			if (num2 == 0)
			{
				do
				{
					BindingFlags bindingFlags_32 = bindingFlags;
					PropertyInfo[] propertyInfo_5 = array;
					Type type_13 = type;
					Type[] type_14 = (Type[])(object)Class5.Default;
					Class7 class47 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class7)(object)((Class7)null).W(bindingFlags_32, propertyInfo_5, type_13, type_14, (ParameterModifier[])(object)((Class7)null).t((BindingFlags)((Class7)(object)class47.W(bindingFlags, array, (Type)(object)@class.t(bindingFlags, null, Class5.Default, (CultureInfo)(object)Class5.Default), array4, null)).t(obj2, (Type)(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)@class.t((BindingFlags)Class5.Default, null, obj2, (CultureInfo)(object)Class5.Default), (object)@class.j((BindingFlags)Class5.Default, array2, ref object_5, array3, cultureInfo, string_2, out reference), (CultureInfo)null), cultureInfo), array5, obj2, (CultureInfo)null));
				}
				while (obj2 != null);
			}
		}
		else
		{
			try
			{
				class5 = (Class0)(object)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, array2, null, array3);
			}
			catch
			{
				num2 = default(UIntPtr);
				if (num2 == 0)
				{
					class8 = class8;
				}
				else
				{
					Class6 obj40 = (Class6)(object)Class5.Default;
					class6 = null;
					class6 = obj40;
				}
			}
		}
		_ = (GClass1)(object)@class.j(bindingFlags, array2, ref *(object[]*)null, array3, (CultureInfo)(object)Class5.Default, string_2, out *(object*)Class5.Default);
		gClass = (GClass0)(object)@class.e(bindingFlags, null, array4, array3);
		gClass = gClass;
		class8 = class8;
		_ = (GClass3)@class.t(obj2, (Type)(object)Class5.Default, cultureInfo);
		class20 = class20;
		class20 = class20;
		try
		{
			do
			{
				class29 = class29;
			}
			while (obj2 != null || (object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref object_5, null, null, (string[])(object)Class5.Default, out *(object*)null) != null);
		}
		catch
		{
			if (num2 == 0)
			{
				_ = (Struct2)Class5.Default;
			}
		}
		num2 = default(UIntPtr);
		if (checked(num2 * num2) == 0)
		{
			try
			{
				class29 = class29;
			}
			catch
			{
				try
				{
					_ = Class5.Default;
				}
				catch
				{
					_ = (Class7)(object)Class5.Default;
				}
			}
		}
		else
		{
			@struct = default(Struct1);
		}
		_ = (Class5)@class.t(null, null, null);
		Class7 class48 = @class;
		bindingFlags = default(BindingFlags);
		_ = (GClass0)(object)class48.e(bindingFlags, (MethodBase[])(object)Class5.Default, null, array3);
		struct2 = struct2;
		if (num2 == 0)
		{
			class30 = class30;
		}
		else
		{
			_003CModule_003E = _003CModule_003E;
			_003CModule_003E = _003CModule_003E;
		}
		try
		{
			while (obj2 != null)
			{
				num2 = default(UIntPtr);
				if (num2 == 0)
				{
					class8 = (Class8)(object)Class5.Default;
				}
				else
				{
					_ = (Class10)(object)Class5.Default;
				}
			}
		}
		catch
		{
			do
			{
				Class7 class49 = @class;
				BindingFlags bindingFlags_33 = bindingFlags;
				PropertyInfo[] propertyInfo_6 = array;
				Class7 obj45 = (Class7)((Class7)null).t(obj2, type, cultureInfo);
				bindingFlags = default(BindingFlags);
				_ = (Class4)(object)class49.W(bindingFlags_33, propertyInfo_6, (Type)(object)obj45.W(bindingFlags, array, (Type)@class.t(((Class7)(object)Class5.Default).j(bindingFlags, array2, ref object_5, array3, cultureInfo, string_2, out reference), type, cultureInfo), array4, (ParameterModifier[])(object)((Class7)null).t(bindingFlags, array5, (object)Class5.Default, (CultureInfo)null)), null, (ParameterModifier[])((Class7)null).t(obj2, type, cultureInfo));
				gClass2 = null;
			}
			while (obj2 != null);
		}
		Class7 obj47;
		BindingFlags bindingFlags_34;
		BindingFlags bindingFlags_35;
		FieldInfo[] fieldInfo_4;
		object object_11;
		Class7 class50;
		Class7 obj48;
		BindingFlags bindingFlags_36;
		ParameterModifier[] parameterModifier_4;
		CultureInfo cultureInfo_4;
		Class7 class51;
		do
		{
			if ((UIntPtr)@class.t(null, null, (CultureInfo)(object)@class.e(bindingFlags, array2, (Type[])(object)Class5.Default, array3)) == (UIntPtr)(nuint)0u)
			{
				do
				{
					_ = (Class8)(object)Class5.Default;
				}
				while ((object)Class5.Default != null);
			}
			obj47 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			bindingFlags_34 = bindingFlags;
			bindingFlags_35 = bindingFlags;
			fieldInfo_4 = array5;
			object_11 = obj2;
			class50 = @class;
			obj48 = (Class7)(object)@class.t(bindingFlags, array5, obj2, (CultureInfo)(object)((Class7)(object)Class5.Default).e(bindingFlags, array2, (Type[])(object)Class5.Default, null));
			bindingFlags_36 = (BindingFlags)((Class7)null).W((BindingFlags)((Class7)null).j(bindingFlags, array2, ref *(object[]*)Class5.Default, array3, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out *(object*)null), array, (Type)null, array4, (ParameterModifier[])@class.t(obj2, type, null));
			parameterModifier_4 = (ParameterModifier[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array4, array3);
			cultureInfo_4 = (CultureInfo)(object)Class5.Default;
			class51 = @class;
			bindingFlags = default(BindingFlags);
		}
		while ((object)obj47.W(bindingFlags_34, (PropertyInfo[])(object)((Class7)null).t(bindingFlags_35, fieldInfo_4, object_11, (CultureInfo)(object)class50.j((BindingFlags)obj48.j(bindingFlags_36, null, ref *(object[]*)null, parameterModifier_4, cultureInfo_4, (string[])(object)class51.j(bindingFlags, array2, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo, string_2, out *(object*)null), out *(object*)null), null, ref *(object[]*)Class5.Default, array3, (CultureInfo)(object)Class5.Default, null, out reference)), (Type)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default), (Type[])(object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref object_5, null, cultureInfo, string_2, out *(object*)Class5.Default), null) != null);
		try
		{
			try
			{
				try
				{
					_ = (Class2)(object)Class5.Default;
				}
				finally
				{
					@class = (Class7)(object)Class5.Default;
					goto end_IL_1605;
				}
				end_IL_1605:;
			}
			finally
			{
				Class7 class52 = @class;
				bindingFlags = default(BindingFlags);
				class5 = (Class0)(object)class52.j(bindingFlags, array2, ref *(object[]*)@class.t(Class5.Default, (Type)(object)@class.t((BindingFlags)Class5.Default, array5, null, null), cultureInfo), array3, (CultureInfo)@class.t(Class5.Default, type, cultureInfo), string_2, out reference);
				_ = (Qk7)(object)@class.j(bindingFlags, (MethodBase[])(object)@class.W(bindingFlags, array, type, array4, null), ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)Class5.Default, string_2, out reference);
				gClass4 = (GClass2)(object)Class5.Default;
				goto end_IL_1604;
			}
			end_IL_1604:;
		}
		catch
		{
			class8 = class8;
		}
		nuint num9 = num2;
		num2 = default(UIntPtr);
		if (checked(num9 + num2 - num2) == 0)
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				Class7 obj50 = (Class7)(object)Class5.Default;
				Class7 class53 = @class;
				bindingFlags = default(BindingFlags);
				_ = (GClass3)(object)obj50.W((BindingFlags)class53.e((BindingFlags)((Class7)null).W(bindingFlags, array, type, array4, array3), array2, array4, array3), (PropertyInfo[])(object)((Class7)null).e((BindingFlags)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)null, array4, (ParameterModifier[])null), (MethodBase[])null, (Type[])null, array3), type, array4, array3);
			}
		}
		else
		{
			num2 = default(UIntPtr);
			nuint num10 = num2;
			Class7 obj51 = (Class7)(object)Class5.Default;
			Class7 obj52 = (Class7)(object)@class.t(bindingFlags, array5, obj2, null);
			Class7 class54 = @class;
			Class7 obj53 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			checked
			{
				if (unchecked((nuint)default(UIntPtr)) + (num10 - unchecked((nuint)(UIntPtr)obj51.t((BindingFlags)obj52.W((BindingFlags)class54.t((BindingFlags)obj53.W((BindingFlags)((Class7)null).e(bindingFlags, array2, array4, (ParameterModifier[])@class.t(obj2, null, (CultureInfo)(object)Class5.Default)), (PropertyInfo[])(object)Class5.Default, null, array4, array3), array5, obj2, cultureInfo), array, type, (Type[])(object)Class5.Default, array3), array5, @class.t(obj2, null, (CultureInfo)@class.t(null, type, cultureInfo)), cultureInfo))) == 0)
				{
					try
					{
						_ = (Class7)(object)@class.t(bindingFlags, array5, obj2, null);
					}
					finally
					{
						_ = (GClass1)(object)@class.W(bindingFlags, null, null, array4, (ParameterModifier[])@class.t(obj2, type, cultureInfo));
						goto IL_19d4;
					}
				}
				num2 = default(UIntPtr);
			}
			if (checked(num2 - num2) / checked(unchecked((nuint)(UIntPtr)@class.t((BindingFlags)((Class7)null).t(obj2, type, (CultureInfo)(object)((Class7)null).t(bindingFlags, array5, obj2, (CultureInfo)null)), array5, Class5.Default, cultureInfo)) + num2) == 0)
			{
				_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
			}
			else
			{
				_ = (GClass2)(object)Class5.Default;
			}
		}
		goto IL_19d4;
		IL_3cd9:
		class17 = Class5.Default;
		try
		{
			while (true)
			{
				if ((object)Class5.Default != null)
				{
					gClass2 = gClass2;
				}
				else if ((object)Class5.Default == null)
				{
					break;
				}
			}
		}
		finally
		{
			_ = (Class2)(object)@class.j(bindingFlags, array2, ref object_5, (ParameterModifier[])(object)@class.t(bindingFlags, array5, obj2, cultureInfo), (CultureInfo)(object)Class5.Default, string_2, out *(object*)null);
			goto IL_3d5a;
		}
		IL_47df:
		try
		{
			Class7 class55 = @class;
			BindingFlags bindingFlags_37 = bindingFlags;
			ref object[] object_12 = ref *(object[]*)@class.W((BindingFlags)Class5.Default, array, (Type)(object)@class.t(bindingFlags, (FieldInfo[])@class.t(obj2, type, cultureInfo), obj2, cultureInfo), (Type[])(object)Class5.Default, null);
			CultureInfo cultureInfo_5 = cultureInfo;
			Class7 class56 = @class;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)class55.j(bindingFlags_37, null, ref object_12, null, cultureInfo_5, string_2, out *(object*)((Class7)(object)class56.j(bindingFlags, array2, ref *(object[]*)null, array3, cultureInfo, null, out *(object*)Class5.Default)).j(bindingFlags, (MethodBase[])(object)((Class7)(object)Class5.Default).t(bindingFlags, array5, Class5.Default, cultureInfo), ref object_5, null, cultureInfo, null, out *(object*)Class5.Default)) == (UIntPtr)(nuint)0u)
			{
				while ((object)@class.e(bindingFlags, array2, (Type[])(object)Class5.Default, null) != null)
				{
					class6 = class6;
				}
			}
		}
		catch
		{
			try
			{
				while (obj2 != null)
				{
					class5 = class5;
				}
			}
			finally
			{
				try
				{
					@struct = @struct;
				}
				finally
				{
					class29 = class29;
					goto end_IL_4908;
				}
			}
			end_IL_4908:;
		}
		do
		{
			gClass2 = gClass2;
		}
		while (obj2 != null);
		object object_13 = obj2;
		Class7 obj55 = (Class7)(object)Class5.Default;
		Class7 obj56 = (Class7)(object)Class5.Default;
		Class7 class57 = @class;
		Class7 class58 = @class;
		Class7 obj57 = (Class7)(object)Class5.Default;
		BindingFlags bindingFlags_38 = bindingFlags;
		MethodBase[] methodBase_15 = array2;
		Type[] type_15 = (Type[])(object)Class5.Default;
		Class7 obj58 = (Class7)(object)@class.W(bindingFlags, array, (Type)(object)@class.e(bindingFlags, null, array4, array3), array4, array3);
		object object_14 = ((Class7)(object)Class5.Default).t(bindingFlags, array5, obj2, cultureInfo);
		Type type_16 = type;
		Class7 class59 = @class;
		BindingFlags bindingFlags_39 = bindingFlags;
		Class7 class60 = @class;
		object object_15 = obj2;
		Type type_17 = type;
		Class7 obj59 = (Class7)(object)Class5.Default;
		BindingFlags bindingFlags_40 = bindingFlags;
		MethodBase[] methodBase_16 = array2;
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_41 = (BindingFlags)class58.e((BindingFlags)obj57.e(bindingFlags_38, methodBase_15, type_15, (ParameterModifier[])obj58.t(object_14, type_16, (CultureInfo)(object)class59.e(bindingFlags_39, null, (Type[])class60.t(object_15, type_17, (CultureInfo)(object)obj59.e(bindingFlags_40, methodBase_16, (Type[])(object)((Class7)null).j(bindingFlags, array2, ref *(object[]*)null, (ParameterModifier[])null, (CultureInfo)null, string_2, out reference), (ParameterModifier[])@class.t(@class.e(bindingFlags, array2, array4, (ParameterModifier[])(object)Class5.Default), null, null))), array3))), null, null, (ParameterModifier[])(object)Class5.Default);
		BindingFlags bindingFlags_42 = bindingFlags;
		MethodBase[] methodBase_17 = (MethodBase[])(object)Class5.Default;
		Class7 obj60 = (Class7)(object)Class5.Default;
		Class7 class61 = @class;
		BindingFlags bindingFlags_43 = bindingFlags;
		MethodBase[] methodBase_18 = (MethodBase[])(object)Class5.Default;
		ParameterModifier[] parameterModifier_5 = array3;
		CultureInfo cultureInfo_6 = (CultureInfo)(object)Class5.Default;
		Class7 class62 = @class;
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_44 = (BindingFlags)class57.W(bindingFlags_41, (PropertyInfo[])(object)((Class7)null).j(bindingFlags_42, methodBase_17, ref object_5, (ParameterModifier[])(object)obj60.j((BindingFlags)class61.j(bindingFlags_43, methodBase_18, ref *(object[]*)null, parameterModifier_5, cultureInfo_6, string_2, out *(object*)class62.t(bindingFlags, array5, @class.t(Class5.Default, null, cultureInfo), (CultureInfo)(object)@class.e((BindingFlags)Class5.Default, array2, array4, array3))), (MethodBase[])(object)Class5.Default, ref *(object[]*)null, null, (CultureInfo)(object)Class5.Default, string_2, out *(object*)null), (CultureInfo)(object)Class5.Default, (string[])(object)@class.W(bindingFlags, array, null, (Type[])((Class7)(object)Class5.Default).t(Class5.Default, null, cultureInfo), array3), out *(object*)Class5.Default), null, null, array3);
		MethodBase[] methodBase_19 = array2;
		ParameterModifier[] parameterModifier_6 = (ParameterModifier[])(object)Class5.Default;
		Class7 obj61 = (Class7)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		_ = (GClass3)((Class7)null).t(object_13, (Type)(object)obj55.W((BindingFlags)obj56.j(bindingFlags_44, methodBase_19, ref object_5, parameterModifier_6, (CultureInfo)(object)((Class7)(object)obj61.j(bindingFlags, array2, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, null, (string[])(object)Class5.Default, out reference)).e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)@class.t(bindingFlags, array5, obj2, (CultureInfo)(object)Class5.Default), array3), string_2, out *(object*)Class5.Default), (PropertyInfo[])(object)Class5.Default, null, array4, null), cultureInfo);
		class5 = (Class0)(object)Class5.Default;
		UIntPtr num11 = num2;
		UIntPtr num12 = (UIntPtr)@class.e((BindingFlags)Class5.Default, array2, array4, array3);
		num2 = default(UIntPtr);
		nuint num13 = num2;
		Class7 class63 = @class;
		bindingFlags = default(BindingFlags);
		checked
		{
			if (unchecked((nuint)num11) * (unchecked((nuint)default(UIntPtr)) + unchecked((nuint)num12) * (num13 - unchecked((nuint)(UIntPtr)class63.e(bindingFlags, array2, array4, array3)))) == 0 && num2 == 0)
			{
				class20 = null;
			}
		}
		while (obj2 != null)
		{
			Class7 class64 = @class;
			BindingFlags bindingFlags_45 = bindingFlags;
			MethodBase[] methodBase_20 = array2;
			ParameterModifier[] parameterModifier_7 = array3;
			Class7 class65 = @class;
			BindingFlags bindingFlags_46 = bindingFlags;
			Type type_18 = type;
			Class7 class66 = @class;
			object object_16 = obj2;
			Class7 class67 = @class;
			Class7 class68 = @class;
			BindingFlags bindingFlags_47 = bindingFlags;
			Class7 obj62 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			_ = (Class7)(object)class64.j(bindingFlags_45, methodBase_20, ref object_5, parameterModifier_7, (CultureInfo)(object)class65.W(bindingFlags_46, null, type_18, (Type[])(object)((Class7)class66.t(object_16, (Type)(object)class67.t((BindingFlags)class68.j(bindingFlags_47, (MethodBase[])(object)obj62.j(bindingFlags, array2, ref *(object[]*)null, array3, cultureInfo, string_2, out reference), ref object_5, (ParameterModifier[])(object)Class5.Default, cultureInfo, string_2, out *(object*)((Class7)null).j(bindingFlags, array2, ref object_5, array3, cultureInfo, (string[])null, out reference)), (FieldInfo[])((Class7)(object)Class5.Default).t(((Class7)null).e((BindingFlags)Class5.Default, (MethodBase[])(object)((Class7)(object)@class.j(bindingFlags, array2, ref *(object[]*)((Class7)null).t(bindingFlags, array5, (object)null, cultureInfo), (ParameterModifier[])(object)((Class7)null).e(bindingFlags, array2, (Type[])null, (ParameterModifier[])null), null, null, out *(object*)null)).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, null), (Type[])(object)Class5.Default, (ParameterModifier[])null), null, cultureInfo), null, cultureInfo), (CultureInfo)(object)Class5.Default)).j((BindingFlags)((Class7)null).W(bindingFlags, array, type, (Type[])null, array3), array2, ref object_5, null, (CultureInfo)(object)Class5.Default, null, out *(object*)Class5.Default), array3), string_2, out reference);
		}
		gClass4 = gClass4;
		_ = (Class6)(object)@class.t((BindingFlags)@class.W(default(BindingFlags), null, type, null, array3), (FieldInfo[])(object)Class5.Default, obj2, null);
		Class7 class69 = @class;
		bindingFlags = default(BindingFlags);
		class29 = (Class2)(object)class69.e(bindingFlags, array2, array4, array3);
		_ = (Struct2)Class5.Default;
		while ((object)@class.j((BindingFlags)((Class7)null).t(bindingFlags, array5, obj2, (CultureInfo)null), (MethodBase[])(object)Class5.Default, ref object_5, array3, cultureInfo, (string[])(object)Class5.Default, out *(object*)null) != null)
		{
			do
			{
				_ = (Class0)@class.t(obj2, (Type)(object)((Class7)(object)Class5.Default).j(bindingFlags, array2, ref *(object[]*)null, array3, null, string_2, out *(object*)@class.t(bindingFlags, null, null, cultureInfo)), cultureInfo);
			}
			while (obj2 != null || obj2 != null);
		}
		do
		{
			try
			{
				_ = (GClass3)(object)Class5.Default;
			}
			catch
			{
				if (checked(num2 + num2) == 0)
				{
					_003CModule_003E = null;
				}
			}
		}
		while (obj2 != null);
		class17 = null;
		_ = (Qk7)((Class7)(object)Class5.Default).t(obj2, null, cultureInfo);
		try
		{
			_ = (Class9)(object)@class.t(default(BindingFlags), null, Class5.Default, cultureInfo);
			return;
		}
		catch
		{
			while (true)
			{
				Class7 class70 = @class;
				Class7 class71 = @class;
				bindingFlags = default(BindingFlags);
				if ((object)class70.t((BindingFlags)class71.j((BindingFlags)((Class7)null).j(bindingFlags, (MethodBase[])null, ref object_5, array3, cultureInfo, (string[])(object)@class.t(bindingFlags, null, obj2, cultureInfo), out reference), array2, ref *(object[]*)null, array3, cultureInfo, null, out reference), null, null, null) != null)
				{
					while (obj2 != null)
					{
						_ = (Class4)(object)@class.t(bindingFlags, null, obj2, null);
					}
					continue;
				}
				break;
			}
			return;
		}
		IL_05c5:
		_ = (Class9)(object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, array3, cultureInfo, string_2, out *(object*)((Class7)(object)@class.t(bindingFlags, null, null, cultureInfo)).t(Class5.Default, type, null));
		nuint num14 = num2;
		nuint num15;
		BindingFlags bindingFlags_48;
		MethodBase[] methodBase_21;
		checked
		{
			num15 = num2 * unchecked((nuint)(UIntPtr)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, (Type[])null, (ParameterModifier[])(object)Class5.Default) / checked(num2 * unchecked((nuint)(UIntPtr)Class5.Default))) - num2;
			bindingFlags_48 = bindingFlags;
			methodBase_21 = array2;
		}
		object_5 = ref *(object[]*)Class5.Default;
		UIntPtr num16 = (UIntPtr)((Class7)null).j(bindingFlags_48, methodBase_21, ref object_5, (ParameterModifier[])null, cultureInfo, string_2, out reference);
		num2 = default(UIntPtr);
		nuint num17;
		nuint num18;
		checked
		{
			num17 = unchecked((nuint)num16) - num2;
			num18 = num2;
			num2 = default(UIntPtr);
		}
		if (checked(unchecked(num14 / checked(num15 + unchecked(num17 / checked(num18 + unchecked((nuint)default(UIntPtr)) * num2)))) + num2) == 0)
		{
			if ((UIntPtr)@class.j(bindingFlags, (MethodBase[])(object)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, array, type, array4, array3), ref object_5, null, cultureInfo, string_2, out reference) == (UIntPtr)(nuint)0u)
			{
				_ = (Class10)(object)Class5.Default;
				_ = (Class7)(object)Class5.Default;
			}
		}
		else
		{
			while (obj2 != null)
			{
				Class7 obj65 = (Class7)(object)@class.j((BindingFlags)Class5.Default, array2, ref object_5, array3, cultureInfo, null, out reference);
				bindingFlags = default(BindingFlags);
				_ = (Class6)(object)obj65.W(bindingFlags, (PropertyInfo[])(object)((Class7)(object)@class.j((BindingFlags)@class.t(obj2, type, cultureInfo), array2, ref *(object[]*)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, array5, obj2, cultureInfo), null, cultureInfo, string_2, out *(object*)@class.t(obj2, (Type)(object)@class.t(bindingFlags, array5, obj2, cultureInfo), cultureInfo))).W((BindingFlags)Class5.Default, (PropertyInfo[])(object)Class5.Default, (Type)(object)@class.e(bindingFlags, array2, (Type[])(object)Class5.Default, array3), (Type[])(object)((Class7)(object)Class5.Default).e(bindingFlags, array2, array4, null), array3), type, array4, null);
			}
		}
		_ = (Class4)((Class7)(object)Class5.Default).t(obj2, type, (CultureInfo)(object)((Class7)(object)@class.t((BindingFlags)@class.j(bindingFlags, null, ref *(object[]*)Class5.Default, null, cultureInfo, (string[])(object)@class.e(bindingFlags, array2, null, array3), out reference), (FieldInfo[])(object)@class.e(bindingFlags, (MethodBase[])(object)@class.W(bindingFlags, array, type, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default), array4, array3), obj2, (CultureInfo)(object)@class.t(bindingFlags, array5, obj2, null))).e((BindingFlags)Class5.Default, null, null, (ParameterModifier[])(object)Class5.Default));
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			class4 = class4;
		}
		else
		{
			do
			{
				_ = (Class9)(object)Class5.Default;
			}
			while (obj2 != null);
		}
		if (num2 == 0)
		{
			while (obj2 != null)
			{
				do
				{
					Class10 obj66 = (Class10)(object)@class.j(bindingFlags, array2, ref object_5, (ParameterModifier[])@class.t(null, type, null), null, (string[])(object)Class5.Default, out reference);
					class30 = class30;
					class30 = obj66;
				}
				while (obj2 != null);
			}
		}
		try
		{
			gClass3 = gClass3;
			gClass3 = null;
			_ = (Class2)(object)Class5.Default;
		}
		finally
		{
			try
			{
				class4 = class4;
			}
			catch
			{
				_ = (Class10)(object)Class5.Default;
			}
			goto IL_0a3d;
		}
		IL_1a99:
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
					gClass = null;
					_ = (GClass1)(object)@class.t(bindingFlags, (FieldInfo[])(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array4, (ParameterModifier[])(object)@class.e(bindingFlags, null, (Type[])(object)Class5.Default, array3)), null, cultureInfo);
					_ = (Class0)(object)@class.e(bindingFlags, array2, array4, array3);
					_ = (GClass2)(object)Class5.Default;
					goto end_IL_1a9b;
				}
				end_IL_1a9b:;
			}
			finally
			{
				Class7 class72 = @class;
				BindingFlags bindingFlags_49 = (BindingFlags)@class.t(null, type, (CultureInfo)(object)Class5.Default);
				MethodBase[] methodBase_22 = array2;
				ParameterModifier[] parameterModifier_8 = (ParameterModifier[])(object)Class5.Default;
				string[] string_3 = (string[])(object)Class5.Default;
				Class7 class73 = @class;
				Class7 class74 = @class;
				BindingFlags bindingFlags_50 = bindingFlags;
				MethodBase[] methodBase_23 = array2;
				ParameterModifier[] parameterModifier_9 = (ParameterModifier[])(object)Class5.Default;
				Class7 class75 = @class;
				bindingFlags = default(BindingFlags);
				Class7 obj68 = (Class7)(object)class75.e(bindingFlags, null, null, array3);
				bindingFlags = default(BindingFlags);
				_ = (_003CModule_003E)(object)class72.j(bindingFlags_49, methodBase_22, ref *(object[]*)null, parameterModifier_8, null, string_3, out *(object*)class73.t(null, (Type)(object)class74.j(bindingFlags_50, methodBase_23, ref *(object[]*)null, parameterModifier_9, (CultureInfo)(object)obj68.e(bindingFlags, null, (Type[])(object)Class5.Default, null), null, out *(object*)Class5.Default), cultureInfo));
				goto end_IL_1a9a;
			}
			end_IL_1a9a:;
		}
		finally
		{
			_ = (Class0)(object)Class5.Default;
			class29 = null;
			gClass2 = gClass2;
			goto IL_1c21;
		}
		IL_1c21:
		do
		{
			_ = (Struct2)@class.j((BindingFlags)@class.t(obj2, type, cultureInfo), array2, ref object_5, array3, cultureInfo, string_2, out reference);
		}
		while ((object)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, array5, Class5.Default, cultureInfo) != null);
		@class = (Class7)(object)Class5.Default;
		Class7 class76 = @class;
		BindingFlags bindingFlags_51 = bindingFlags;
		Class7 class77 = @class;
		bindingFlags = default(BindingFlags);
		_ = (Struct1)((Class7)(object)class76.j(bindingFlags_51, (MethodBase[])(object)((Class7)(object)class77.e(bindingFlags, array2, null, array3)).e(bindingFlags, array2, null, array3), ref object_5, (ParameterModifier[])(object)@class.j(bindingFlags, null, ref *(object[]*)null, array3, cultureInfo, string_2, out *(object*)null), null, (string[])(object)Class5.Default, out reference)).j(bindingFlags, null, ref *(object[]*)Class5.Default, (ParameterModifier[])((Class7)null).t((object)Class5.Default, (Type)null, cultureInfo), cultureInfo, null, out reference);
		_ = (Class4)(object)@class.t(bindingFlags, array5, obj2, null);
		try
		{
			try
			{
				while ((object)Class5.Default != null)
				{
					_ = (Class0)(object)Class5.Default;
				}
			}
			finally
			{
				if (checked(num2 + num2) == 0)
				{
					class30 = class30;
				}
				else
				{
					Class7 obj69 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_52 = bindingFlags;
					PropertyInfo[] propertyInfo_7 = array;
					Type type_19 = (Type)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Class2)(object)obj69.W(bindingFlags_52, propertyInfo_7, type_19, (Type[])(object)((Class7)null).j(bindingFlags, array2, ref object_5, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)Class5.Default, (string[])(object)@class.e(bindingFlags, array2, array4, (ParameterModifier[])(object)@class.t((BindingFlags)((Class7)null).t(bindingFlags, array5, (object)Class5.Default, cultureInfo), array5, null, null)), out *(object*)null), array3);
				}
				goto end_IL_1d7d;
			}
			end_IL_1d7d:;
		}
		catch
		{
			try
			{
				class8 = class8;
			}
			finally
			{
				try
				{
					_ = (GClass3)((Class7)(object)Class5.Default).t(obj2, (Type)(object)((Class7)null).W(bindingFlags, array, type, array4, (ParameterModifier[])null), cultureInfo);
				}
				finally
				{
					qk = qk;
					class17 = null;
					goto end_IL_1e73;
				}
			}
			end_IL_1e73:;
		}
		try
		{
			if (num2 == 0)
			{
				num2 = default(UIntPtr);
				if (num2 == 0)
				{
					gClass = gClass;
				}
				else
				{
					_ = (Qk7)(object)Class5.Default;
				}
			}
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
					gClass3 = (GClass1)(object)Class5.Default;
				}
			}
			while (@class.t(null, (Type)(object)Class5.Default, null) != null);
			goto IL_1f39;
		}
		IL_224e:
		checked
		{
			if (num2 == 0)
			{
				try
				{
					nuint num19 = num2 * unchecked((nuint)(UIntPtr)@class.t(obj2, type, cultureInfo) / unchecked((nuint)default(UIntPtr)));
					num2 = default(UIntPtr);
					if (num19 - num2 + (num2 + unchecked((nuint)default(UIntPtr))) == 0)
					{
						gClass2 = gClass2;
					}
				}
				finally
				{
					try
					{
						_ = (Struct2)Class5.Default;
					}
					finally
					{
						gClass3 = gClass3;
						goto IL_22cb;
					}
				}
			}
			goto IL_22cb;
		}
		IL_3d5a:
		num2 = default(UIntPtr);
		if (num2 == (UIntPtr)(nuint)0u)
		{
			do
			{
				gClass = null;
				class20 = class20;
			}
			while (obj2 != null || (object)Class5.Default != null);
		}
		else
		{
			while ((object)@class.t(bindingFlags, (FieldInfo[])@class.t(@class.t(bindingFlags, array5, @class.t(obj2, null, cultureInfo), null), type, cultureInfo), Class5.Default, (CultureInfo)(object)@class.j((BindingFlags)Class5.Default, null, ref object_5, null, cultureInfo, string_2, out reference)) != null)
			{
				_ = Class5.Default;
				object object_17 = obj2;
				bindingFlags = default(BindingFlags);
				gClass3 = (GClass1)(object)((Class7)null).t(default(BindingFlags), (FieldInfo[])null, object_17, (CultureInfo)(object)((Class7)null).e((BindingFlags)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj2, (CultureInfo)null), array2, (Type[])(object)Class5.Default, array3));
				gClass = gClass;
				_ = (Qk7)(object)((Class7)(object)((Class7)null).e((BindingFlags)@class.t(bindingFlags, array5, obj2, null), array2, array4, array3)).W(bindingFlags, array, null, array4, (ParameterModifier[])(object)Class5.Default);
			}
		}
		try
		{
			class8 = null;
		}
		catch
		{
			try
			{
				class30 = null;
				_ = (GClass0)(object)((Class7)null).W(bindingFlags, array, type, array4, array3);
				bindingFlags = default(BindingFlags);
				gClass = (GClass0)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)(object)((Class7)(object)((Class7)(object)@class.e(bindingFlags, null, array4, null)).e(bindingFlags, null, array4, array3)).e((BindingFlags)Class5.Default, null, null, (ParameterModifier[])(object)@class.j(bindingFlags, array2, ref object_5, (ParameterModifier[])(object)@class.j(bindingFlags, (MethodBase[])(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)@class.W(bindingFlags, array, null, array4, null), (ParameterModifier[])null, cultureInfo, string_2, out *(object*)null), ref object_5, null, cultureInfo, (string[])(object)Class5.Default, out *(object*)Class5.Default), null, string_2, out reference)), (Type[])null, array3);
				_ = (Struct1)@class.W((BindingFlags)Class5.Default, null, type, (Type[])(object)Class5.Default, null);
			}
			catch
			{
			}
		}
		try
		{
			_ = (Class2)(object)((Class7)(object)((Class7)null).j(bindingFlags, array2, ref *(object[]*)Class5.Default, (ParameterModifier[])null, cultureInfo, string_2, out *(object*)null)).W((BindingFlags)Class5.Default, array, type, array4, array3);
		}
		finally
		{
			try
			{
				do
				{
					class6 = class6;
					class29 = class29;
					@class = null;
					_ = (GClass0)((Class7)(object)Class5.Default).t(obj2, type, (CultureInfo)(object)@class.W((BindingFlags)Class5.Default, (PropertyInfo[])(object)Class5.Default, type, null, array3));
				}
				while ((object)@class.e(bindingFlags, (MethodBase[])((Class7)null).t((object)null, (Type)null, (CultureInfo)null), array4, null) != null);
			}
			catch
			{
				if (num2 == (UIntPtr)(nuint)0u)
				{
					BindingFlags bindingFlags_53 = (BindingFlags)Class5.Default;
					MethodBase[] methodBase_24 = (MethodBase[])(object)Class5.Default;
					BindingFlags bindingFlags_54 = bindingFlags;
					MethodBase[] methodBase_25 = array2;
					Type[] type_20 = array4;
					BindingFlags bindingFlags_55 = bindingFlags;
					Type type_21 = type;
					Type[] type_22 = array4;
					Class7 obj74 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Class7)((Class7)(object)((Class7)null).j(bindingFlags_53, methodBase_24, ref *(object[]*)((Class7)null).e(bindingFlags_54, methodBase_25, type_20, (ParameterModifier[])(object)((Class7)null).W(bindingFlags_55, (PropertyInfo[])null, type_21, type_22, (ParameterModifier[])(object)obj74.e(bindingFlags, (MethodBase[])(object)Class5.Default, null, array3))), array3, cultureInfo, string_2, out *(object*)((Class7)(object)Class5.Default).t(bindingFlags, null, null, null))).t(null, null, null);
				}
				else
				{
					qk = null;
				}
			}
			goto IL_41e1;
		}
		IL_1f39:
		try
		{
			if (checked(num2 - unchecked((nuint)(UIntPtr)((Class7)null).t((object)null, type, cultureInfo)) * unchecked((nuint)(UIntPtr)Class5.Default)) == 0)
			{
				do
				{
					_ = Class5.Default;
				}
				while (obj2 != null);
			}
			else
			{
				class17 = (Class5)(object)@class.t(bindingFlags, (FieldInfo[])(object)((Class7)(object)@class.W(bindingFlags, null, null, null, null)).t(bindingFlags, array5, Class5.Default, cultureInfo), null, (CultureInfo)(object)((Class7)null).e(default(BindingFlags), (MethodBase[])(object)((Class7)((Class7)(object)((Class7)(object)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])(object)Class5.Default, type, array4, array3)).j(default(BindingFlags), array2, ref *(object[]*)Class5.Default, null, cultureInfo, string_2, out reference)).t(null, null, cultureInfo)).j(default(BindingFlags), (MethodBase[])(object)Class5.Default, ref object_5, array3, cultureInfo, null, out *(object*)Class5.Default), array4, array3));
			}
		}
		finally
		{
			Class7 class78 = @class;
			bindingFlags = default(BindingFlags);
			UIntPtr num20 = (UIntPtr)class78.e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, null);
			num2 = default(UIntPtr);
			if ((nuint)num20 / num2 == 0)
			{
				try
				{
					struct2 = default(Struct2);
					struct2 = struct2;
				}
				finally
				{
					class17 = null;
					goto IL_2225;
				}
			}
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Class10)(object)Class5.Default;
				_ = (Qk7)(object)Class5.Default;
				_ = (Struct1)Class5.Default;
				gClass2 = (GClass3)(object)@class.W(bindingFlags, array, (Type)(object)Class5.Default, (Type[])(object)Class5.Default, (ParameterModifier[])(object)@class.e(bindingFlags, array2, array4, array3));
			}
			else
			{
				qk = null;
				Class7 class79 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class8)(object)class79.e(bindingFlags, (MethodBase[])@class.t(Class5.Default, type, (CultureInfo)(object)((Class7)(object)Class5.Default).t(bindingFlags, array5, obj2, null)), (Type[])(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])(object)Class5.Default, array3), array3);
				class29 = null;
			}
			goto IL_2225;
		}
		IL_2225:
		do
		{
			if ((UIntPtr)Class5.Default != (UIntPtr)(nuint)0u)
			{
				do
				{
					_ = (Class0)(object)Class5.Default;
				}
				while (obj2 != null);
			}
			else
			{
				do
				{
					_ = (Class8)(object)Class5.Default;
				}
				while (obj2 != null);
			}
		}
		while (obj2 != null);
		try
		{
			@struct = default(Struct1);
			@struct = @struct;
		}
		finally
		{
			gClass4 = null;
			goto IL_224e;
		}
		IL_3441:
		Class7 class80 = @class;
		FieldInfo[] fieldInfo_5 = (FieldInfo[])(object)Class5.Default;
		Class7 obj76 = (Class7)(object)@class.j((BindingFlags)Class5.Default, array2, ref object_5, array3, cultureInfo, null, out *(object*)null);
		bindingFlags = default(BindingFlags);
		_ = (Class0)(object)class80.t(default(BindingFlags), fieldInfo_5, obj76.e(bindingFlags, (MethodBase[])(object)((Class7)null).t((BindingFlags)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, null), array5, obj2, cultureInfo), array4, array3), cultureInfo);
		do
		{
			try
			{
				gClass = (GClass0)((Class7)(object)Class5.Default).t(Class5.Default, (Type)(object)Class5.Default, null);
			}
			finally
			{
				_ = Class5.Default;
				_ = (Qk7)(object)Class5.Default;
				class17 = class17;
				gClass3 = null;
				continue;
			}
		}
		while (obj2 != null);
		try
		{
			_ = (Class10)(object)Class5.Default;
		}
		catch
		{
			try
			{
				try
				{
					_ = (GClass1)(object)@class.e(bindingFlags, array2, (Type[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)null, (CultureInfo)(object)Class5.Default), null);
				}
				catch
				{
					_ = (Class7)(object)Class5.Default;
				}
			}
			catch
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					Class7 class81 = @class;
					Class7 class82 = @class;
					Class7 class83 = @class;
					Class7 obj78 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_56 = bindingFlags;
					object object_18 = obj2;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_57 = bindingFlags;
					PropertyInfo[] propertyInfo_8 = array;
					Type type_23 = type;
					Type[] type_24 = array4;
					Class7 class84 = @class;
					BindingFlags bindingFlags_58 = bindingFlags;
					Class7 class85 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_59 = (BindingFlags)((Class7)(object)class83.W((BindingFlags)obj78.t(bindingFlags_56, null, object_18, (CultureInfo)(object)((Class7)null).W(bindingFlags_57, propertyInfo_8, type_23, type_24, (ParameterModifier[])(object)class84.t(bindingFlags_58, (FieldInfo[])(object)class85.e(bindingFlags, array2, (Type[])(object)Class5.Default, (ParameterModifier[])(object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref object_5, array3, cultureInfo, null, out *(object*)@class.t((BindingFlags)Class5.Default, (FieldInfo[])(object)((Class7)@class.t(obj2, type, cultureInfo)).j(bindingFlags, array2, ref object_5, array3, cultureInfo, (string[])(object)Class5.Default, out reference), obj2, null))), null, cultureInfo))), array, type, array4, array3)).e((BindingFlags)Class5.Default, (MethodBase[])((Class7)null).t((object)Class5.Default, type, (CultureInfo)(object)Class5.Default), array4, (ParameterModifier[])(object)Class5.Default);
					PropertyInfo[] propertyInfo_9 = (PropertyInfo[])(object)@class.j(bindingFlags, null, ref object_5, null, (CultureInfo)(object)Class5.Default, string_2, out reference);
					Type type_25 = type;
					Type[] type_26 = array4;
					Class7 class86 = @class;
					BindingFlags bindingFlags_60 = bindingFlags;
					PropertyInfo[] propertyInfo_10 = array;
					Class7 class87 = @class;
					BindingFlags bindingFlags_61 = (BindingFlags)Class5.Default;
					Class7 class88 = @class;
					Class7 class89 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_62 = (BindingFlags)((Class7)null).t((BindingFlags)class89.t(bindingFlags, null, null, null), array5, obj2, cultureInfo);
					Class7 class90 = @class;
					Class7 class91 = @class;
					object object_19 = obj2;
					Type type_27 = (Type)(object)Class5.Default;
					Class7 class92 = @class;
					BindingFlags bindingFlags_63 = bindingFlags;
					MethodBase[] methodBase_26 = array2;
					Type[] type_28 = array4;
					Class7 obj79 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (GClass2)class81.t(class82.W(bindingFlags_59, propertyInfo_9, type_25, type_26, (ParameterModifier[])(object)class86.W(bindingFlags_60, propertyInfo_10, (Type)(object)class87.W(bindingFlags_61, null, (Type)(object)class88.t(bindingFlags_62, (FieldInfo[])(object)class90.e((BindingFlags)class91.t(object_19, type_27, (CultureInfo)(object)class92.e(bindingFlags_63, methodBase_26, type_28, (ParameterModifier[])(object)obj79.W(bindingFlags, array, type, array4, array3))), array2, array4, null), obj2, (CultureInfo)(object)Class5.Default), (Type[])(object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, (ParameterModifier[])@class.t(null, (Type)(object)Class5.Default, cultureInfo), null, null, out *(object*)Class5.Default), array3), (Type[])@class.t(obj2, type, cultureInfo), array3)), null, (CultureInfo)(object)Class5.Default);
				}
			}
		}
		try
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				class6 = (Class6)(object)Class5.Default;
			}
		}
		finally
		{
			gClass3 = null;
			goto IL_3918;
		}
		IL_2597:
		_ = (GClass2)(object)((Class7)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, (Type[])(object)Class5.Default, (ParameterModifier[])null)).W(default(BindingFlags), null, type, array4, array3);
		do
		{
			_003CModule_003E = _003CModule_003E;
		}
		while (obj2 != null);
		_ = (GClass0)(object)Class5.Default;
		while ((object)((Class7)@class.t(obj2, type, cultureInfo)).W(default(BindingFlags), (PropertyInfo[])(object)Class5.Default, type, (Type[])(object)((Class7)(object)Class5.Default).j((BindingFlags)Class5.Default, null, ref *(object[]*)null, array3, cultureInfo, null, out reference), array3) != null)
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				if (num2 == (UIntPtr)(nuint)0u)
				{
					_003CModule_003E = _003CModule_003E;
					_ = (GClass3)(object)Class5.Default;
					continue;
				}
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_64 = bindingFlags;
				Class7 obj82 = (Class7)(object)@class.W(bindingFlags, array, type, (Type[])(object)Class5.Default, (ParameterModifier[])((Class7)(object)Class5.Default).t(obj2, type, cultureInfo));
				BindingFlags bindingFlags_65 = bindingFlags;
				Class7 class93 = @class;
				BindingFlags bindingFlags_66 = (BindingFlags)Class5.Default;
				Type[] type_29 = (Type[])(object)Class5.Default;
				Class7 class94 = @class;
				bindingFlags = default(BindingFlags);
				ref object[] object_20 = ref *(object[]*)obj82.e(bindingFlags_65, (MethodBase[])(object)class93.e(bindingFlags_66, null, type_29, (ParameterModifier[])(object)class94.W(bindingFlags, array, type, (Type[])(object)((Class7)null).j(bindingFlags, array2, ref object_5, (ParameterModifier[])null, cultureInfo, string_2, out *(object*)Class5.Default), null)), array4, array3);
				ParameterModifier[] parameterModifier_10 = array3;
				BindingFlags bindingFlags_67 = bindingFlags;
				FieldInfo[] fieldInfo_6 = array5;
				Class7 class95 = @class;
				bindingFlags = default(BindingFlags);
				object object_21 = class95.W(bindingFlags, array, type, array4, array3);
				Class7 class96 = @class;
				BindingFlags bindingFlags_68 = bindingFlags;
				MethodBase[] methodBase_27 = (MethodBase[])(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_69 = (BindingFlags)((Class7)null).j(bindingFlags_68, methodBase_27, ref *(object[]*)null, (ParameterModifier[])(object)((Class7)(object)((Class7)null).t(bindingFlags, array5, obj2, (CultureInfo)(object)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])null, type, (Type[])null, array3))).e(bindingFlags, array2, array4, (ParameterModifier[])(object)Class5.Default), (CultureInfo)null, string_2, out reference);
				Class7 class97 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class6)(object)((Class7)null).j(bindingFlags_64, (MethodBase[])null, ref object_20, parameterModifier_10, (CultureInfo)null, string_2, out *(object*)((Class7)null).t(bindingFlags_67, fieldInfo_6, object_21, (CultureInfo)(object)class96.e(bindingFlags_69, (MethodBase[])(object)class97.e(bindingFlags, (MethodBase[])(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)((Class7)null).t(default(BindingFlags), array5, (object)((Class7)null).j(default(BindingFlags), array2, ref object_5, (ParameterModifier[])null, (CultureInfo)(object)Class5.Default, (string[])(object)@class.W(default(BindingFlags), array, (Type)(object)Class5.Default, (Type[])(object)Class5.Default, array3), out *(object*)((Class7)(object)Class5.Default).e(default(BindingFlags), (MethodBase[])(object)((Class7)((Class7)(object)Class5.Default).t(obj2, (Type)(object)Class5.Default, (CultureInfo)(object)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, (MethodBase[])(object)((Class7)null).e(default(BindingFlags), (MethodBase[])null, (Type[])null, (ParameterModifier[])(object)Class5.Default), (Type[])(object)((Class7)null).e(default(BindingFlags), (MethodBase[])null, (Type[])null, (ParameterModifier[])null), array3))).W((BindingFlags)Class5.Default, array, type, (Type[])(object)Class5.Default, array3), (Type[])((Class7)null).t((object)Class5.Default, (Type)@class.t(null, type, null), cultureInfo), array3)), cultureInfo), (CultureInfo)(object)Class5.Default, string_2, out reference), null, (ParameterModifier[])(object)Class5.Default), null, array3)));
			}
			else
			{
				gClass4 = gClass4;
			}
		}
		Class7 class98 = @class;
		bindingFlags = default(BindingFlags);
		nuint num21;
		UIntPtr num22;
		checked
		{
			num21 = unchecked((nuint)(UIntPtr)class98.W(bindingFlags, null, null, null, array3)) * unchecked((nuint)(UIntPtr)Class5.Default);
			num22 = num2;
		}
		UIntPtr num23 = (UIntPtr)Class5.Default;
		num2 = default(UIntPtr);
		nuint num24 = num2;
		UIntPtr num25 = (UIntPtr)@class.t(((Class7)null).W((BindingFlags)Class5.Default, array, type, (Type[])((Class7)null).t((object)null, (Type)null, cultureInfo), array3), null, (CultureInfo)(object)@class.t(bindingFlags, array5, obj2, cultureInfo));
		Class7 class99 = @class;
		bindingFlags = default(BindingFlags);
		if (checked(num21 * unchecked((nuint)num22 / checked(unchecked((nuint)num23) - (num24 - (unchecked((nuint)num25) - unchecked((nuint)(UIntPtr)class99.e(bindingFlags, array2, null, array3))))))) == 0)
		{
			try
			{
				num2 = default(UIntPtr);
				if (num2 == 0)
				{
					Class7 class100 = @class;
					BindingFlags bindingFlags_70 = bindingFlags;
					Class7 class101 = @class;
					BindingFlags bindingFlags_71 = bindingFlags;
					Class7 obj83 = (Class7)(object)@class.W(bindingFlags, array, type, null, null);
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_72 = bindingFlags;
					Class7 obj84 = (Class7)(object)((Class7)(object)@class.e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, null, null)).e(bindingFlags, (MethodBase[])(object)@class.e(bindingFlags, array2, null, (ParameterModifier[])(object)Class5.Default), null, array3);
					bindingFlags = default(BindingFlags);
					Class7 obj85 = (Class7)(object)class101.e(bindingFlags_71, (MethodBase[])(object)((Class7)(object)obj83.e(bindingFlags_72, (MethodBase[])(object)obj84.t(bindingFlags, array5, null, cultureInfo), (Type[])(object)Class5.Default, array3)).e(bindingFlags, null, array4, array3), null, array3);
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_73 = bindingFlags;
					Class7 class102 = @class;
					Class7 class103 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass0)(object)class100.j(bindingFlags_70, null, ref *(object[]*)obj85.t(bindingFlags_73, (FieldInfo[])(object)((Class7)(object)class102.j((BindingFlags)class103.t(bindingFlags, (FieldInfo[])@class.t(obj2, null, cultureInfo), obj2, (CultureInfo)(object)Class5.Default), array2, ref object_5, array3, cultureInfo, string_2, out reference)).t(bindingFlags, null, obj2, cultureInfo), obj2, (CultureInfo)(object)@class.t(bindingFlags, array5, obj2, null)), null, (CultureInfo)(object)Class5.Default, string_2, out *(object*)null);
				}
			}
			catch
			{
				_ = (Qk7)(object)@class.e(bindingFlags, null, array4, null);
			}
		}
		do
		{
			struct2 = struct2;
		}
		while (obj2 != null);
		try
		{
			gClass4 = gClass4;
			BindingFlags bindingFlags_74 = bindingFlags;
			bindingFlags = default(BindingFlags);
			_ = (GClass0)(object)((Class7)(object)((Class7)null).t(bindingFlags_74, (FieldInfo[])(object)((Class7)null).e(bindingFlags, (MethodBase[])null, array4, array3), (object)null, cultureInfo)).e(bindingFlags, null, null, array3);
			gClass = gClass;
			_ = (Struct1)Class5.Default;
		}
		finally
		{
			try
			{
				try
				{
					_ = (Class6)(object)Class5.Default;
				}
				finally
				{
					@struct = @struct;
					goto end_IL_2d94;
				}
				end_IL_2d94:;
			}
			finally
			{
				Class7 obj87 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_75 = bindingFlags;
				Class7 obj88 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_76 = bindingFlags;
				PropertyInfo[] propertyInfo_11 = array;
				Type type_30 = type;
				Class7 class104 = @class;
				Class7 class105 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class0)(object)obj87.j(bindingFlags_75, null, ref *(object[]*)obj88.W(bindingFlags_76, propertyInfo_11, type_30, (Type[])(object)class104.e((BindingFlags)class105.t(bindingFlags, array5, Class5.Default, cultureInfo), null, (Type[])(object)Class5.Default, array3), (ParameterModifier[])(object)Class5.Default), null, (CultureInfo)(object)Class5.Default, null, out *(object*)null);
				goto IL_2e51;
			}
		}
	}

	unsafe static void smethod_3()
	{
		Class7 obj = (Class7)(object)Class5.Default;
		BindingFlags bindingFlags = bindingFlags;
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_ = bindingFlags;
		FieldInfo[] fieldInfo_ = (FieldInfo[])(object)Class5.Default;
		object obj2 = null;
		_003CModule_003E obj3 = (_003CModule_003E)(object)obj.t(bindingFlags_, fieldInfo_, obj2, (CultureInfo)(object)Class5.Default);
		_003CModule_003E _003CModule_003E = null;
		_003CModule_003E = obj3;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo);
		PropertyInfo[] propertyInfo_;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class7 @class);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] array);
		ref object[] object_;
		Type[] array2;
		ParameterModifier[] parameterModifier_;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object reference);
		string[] string_3;
		FieldInfo[] fieldInfo_3;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class0 class19);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass1 gClass);
		do
		{
			Class7 obj4 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_2 = bindingFlags;
			type = type;
			Type type_ = type;
			cultureInfo = cultureInfo;
			propertyInfo_ = (PropertyInfo[])((Class7)null).t(obj2, type_, cultureInfo);
			Class7 class2 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_3 = bindingFlags;
			array = array;
			MethodBase[] methodBase_ = array;
			object_ = ref *(object[]*)Class5.Default;
			CultureInfo cultureInfo_ = cultureInfo;
			string[] string_ = (string[])@class.t(obj2, null, cultureInfo);
			Class7 obj5 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_4 = (BindingFlags)Class5.Default;
			Class7 class3 = @class;
			BindingFlags bindingFlags_5 = bindingFlags;
			Class7 obj6 = (Class7)((Class7)null).t((object)null, (Type)null, cultureInfo);
			Class7 class4 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_6 = bindingFlags;
			MethodBase[] methodBase_2 = (MethodBase[])(object)Class5.Default;
			array2 = null;
			parameterModifier_ = (ParameterModifier[])(object)Class5.Default;
			object object_2 = ((Class7)null).t((object)obj6.W((BindingFlags)class4.e(bindingFlags_6, methodBase_2, array2, parameterModifier_), (PropertyInfo[])(object)Class5.Default, (Type)(object)Class5.Default, null, (ParameterModifier[])(object)Class5.Default), type, cultureInfo);
			BindingFlags bindingFlags_7 = bindingFlags;
			MethodBase[] methodBase_3 = (MethodBase[])(object)Class5.Default;
			ref object[] object_3 = ref *(object[]*)@class.j(bindingFlags, array, ref object_, null, cultureInfo, (string[])(object)Class5.Default, out *(object*)Class5.Default);
			CultureInfo cultureInfo_2 = cultureInfo;
			Class7 obj7 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_8 = bindingFlags;
			Type type_2 = type;
			Class7 class5 = @class;
			BindingFlags bindingFlags_9 = bindingFlags;
			MethodBase[] methodBase_4 = array;
			ref object[] object_4 = ref *(object[]*)Class5.Default;
			CultureInfo cultureInfo_3 = cultureInfo;
			string[] string_2 = (string[])((Class7)(object)Class5.Default).t(obj2, type, (CultureInfo)(object)Class5.Default);
			reference = ref reference;
			FieldInfo[] fieldInfo_2 = (FieldInfo[])((Class7)null).t(object_2, (Type)(object)((Class7)null).j(bindingFlags_7, methodBase_3, ref object_3, (ParameterModifier[])null, cultureInfo_2, (string[])(object)obj7.W(bindingFlags_8, propertyInfo_, type_2, (Type[])(object)class5.j(bindingFlags_9, methodBase_4, ref object_4, parameterModifier_, cultureInfo_3, string_2, out reference), (ParameterModifier[])(object)Class5.Default), out reference), cultureInfo);
			Class7 class6 = @class;
			BindingFlags bindingFlags_10 = bindingFlags;
			MethodBase[] methodBase_5 = (MethodBase[])@class.t(obj2, type, cultureInfo);
			Class7 class7 = @class;
			BindingFlags bindingFlags_11 = bindingFlags;
			Class7 class8 = @class;
			bindingFlags = default(BindingFlags);
			@class = (Class7)(object)obj4.W(bindingFlags_2, propertyInfo_, (Type)(object)class2.j(bindingFlags_3, methodBase_, ref object_, null, cultureInfo_, string_, out *(object*)obj5.t(bindingFlags_4, null, null, (CultureInfo)(object)class3.t(bindingFlags_5, fieldInfo_2, null, (CultureInfo)(object)class6.e(bindingFlags_10, methodBase_5, array2, (ParameterModifier[])(object)class7.t(bindingFlags_11, (FieldInfo[])(object)((Class7)(object)class8.e(bindingFlags, null, array2, parameterModifier_)).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, parameterModifier_, cultureInfo, (string[])@class.t(obj2, type, cultureInfo), out reference), obj2, null))))), null, parameterModifier_);
			Class7 class9 = @class;
			Class7 obj8 = (Class7)(object)@class.e(bindingFlags, array, array2, null);
			BindingFlags bindingFlags_12 = bindingFlags;
			Class7 obj9 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_13 = bindingFlags;
			MethodBase[] methodBase_6 = array;
			BindingFlags bindingFlags_14 = bindingFlags;
			MethodBase[] methodBase_7 = array;
			Class7 class10 = @class;
			BindingFlags bindingFlags_15 = bindingFlags;
			Class7 class11 = @class;
			object object_5 = @class.e(bindingFlags, array, array2, null);
			Class7 class12 = @class;
			BindingFlags bindingFlags_16 = bindingFlags;
			Class7 obj10 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_17 = bindingFlags;
			MethodBase[] methodBase_8 = array;
			CultureInfo cultureInfo_4 = cultureInfo;
			Class7 class13 = @class;
			MethodBase[] methodBase_9 = array;
			ParameterModifier[] parameterModifier_2 = (ParameterModifier[])(object)Class5.Default;
			Class7 class14 = @class;
			bindingFlags = default(BindingFlags);
			string_3 = (string[])(object)class13.j(default(BindingFlags), methodBase_9, ref *(object[]*)null, parameterModifier_2, null, (string[])(object)class14.e(bindingFlags, array, array2, (ParameterModifier[])(object)@class.e((BindingFlags)Class5.Default, (MethodBase[])(object)((Class7)(object)Class5.Default).t(bindingFlags, null, obj2, cultureInfo), array2, parameterModifier_)), out *(object*)@class.W(bindingFlags, propertyInfo_, null, array2, parameterModifier_));
			BindingFlags bindingFlags_18 = (BindingFlags)((Class7)null).j(bindingFlags_14, methodBase_7, ref *(object[]*)class10.W(bindingFlags_15, null, (Type)(object)((Class7)class11.t(object_5, (Type)(object)class12.t(bindingFlags_16, (FieldInfo[])(object)obj10.j(bindingFlags_17, methodBase_8, ref object_, null, cultureInfo_4, string_3, out reference), obj2, null), null)).e(bindingFlags, array, (Type[])(object)Class5.Default, parameterModifier_), (Type[])(object)Class5.Default, parameterModifier_), parameterModifier_, (CultureInfo)null, string_3, out reference);
			fieldInfo_3 = (FieldInfo[])(object)Class5.Default;
			BindingFlags bindingFlags_19 = (BindingFlags)obj8.e(bindingFlags_12, (MethodBase[])(object)obj9.e(bindingFlags_13, methodBase_6, (Type[])(object)((Class7)null).t(bindingFlags_18, fieldInfo_3, (object)((Class7)(object)Class5.Default).t(bindingFlags, fieldInfo_3, null, cultureInfo), cultureInfo), parameterModifier_), array2, parameterModifier_);
			Class7 class15 = @class;
			BindingFlags bindingFlags_20 = (BindingFlags)Class5.Default;
			Class7 class16 = @class;
			Class7 class17 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_21 = bindingFlags;
			Class7 obj11 = (Class7)(object)@class.W((BindingFlags)Class5.Default, (PropertyInfo[])(object)((Class7)((Class7)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])null, (ParameterModifier[])null)).t(null, (Type)(object)Class5.Default, (CultureInfo)(object)@class.e((BindingFlags)@class.t(((Class7)(object)Class5.Default).j(bindingFlags, null, ref object_, parameterModifier_, cultureInfo, string_3, out reference), type, cultureInfo), null, null, (ParameterModifier[])(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, (ParameterModifier[])(object)Class5.Default)))).e(bindingFlags, array, null, parameterModifier_), type, array2, parameterModifier_);
			BindingFlags bindingFlags_22 = bindingFlags;
			Class7 class18 = @class;
			bindingFlags = default(BindingFlags);
			PropertyInfo[] propertyInfo_2 = (PropertyInfo[])(object)class15.e(bindingFlags_20, (MethodBase[])(object)class16.j(default(BindingFlags), null, ref *(object[]*)((Class7)((Class7)(object)class17.W(bindingFlags_21, (PropertyInfo[])(object)obj11.t(bindingFlags_22, (FieldInfo[])(object)((Class7)(object)class18.W(bindingFlags, propertyInfo_, type, null, parameterModifier_)).j(bindingFlags, null, ref object_, null, cultureInfo, (string[])(object)@class.t((BindingFlags)((Class7)null).j((BindingFlags)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, (Type[])null, parameterModifier_), (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)Class5.Default, (CultureInfo)null, (string[])null, out *(object*)null), null, Class5.Default, cultureInfo), out reference), obj2, null), (Type)(object)Class5.Default, null, parameterModifier_)).t(null, type, cultureInfo)).W((BindingFlags)((Class7)null).t((BindingFlags)@class.t(null, type, (CultureInfo)(object)Class5.Default), (FieldInfo[])null, (object)Class5.Default, cultureInfo), null, type, null, parameterModifier_), parameterModifier_, null, string_3, out reference), (Type[])(object)Class5.Default, parameterModifier_);
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)class9.W(bindingFlags_19, propertyInfo_2, null, (Type[])(object)((Class7)(object)((Class7)null).j(bindingFlags, array, ref object_, parameterModifier_, (CultureInfo)null, string_3, out *(object*)@class.j((BindingFlags)Class5.Default, array, ref object_, null, null, (string[])(object)Class5.Default, out *(object*)null))).t(bindingFlags, fieldInfo_3, obj2, (CultureInfo)(object)@class.W(bindingFlags, null, null, (Type[])(object)@class.j(bindingFlags, array, ref object_, parameterModifier_, cultureInfo, string_3, out reference), null)), (ParameterModifier[])(object)Class5.Default) != (UIntPtr)(nuint)0u)
			{
				checked
				{
					num = unchecked((nuint)default(UIntPtr)) * unchecked((nuint)(UIntPtr)Class5.Default);
					num = default(UIntPtr);
					if (num == 0)
					{
						gClass = gClass;
						gClass = gClass;
					}
					else
					{
						class19 = class19;
						class19 = class19;
					}
				}
			}
			else
			{
				_ = (Class7)(object)@class.j(bindingFlags, array, ref *(object[]*)null, parameterModifier_, cultureInfo, string_3, out reference);
				_ = (Struct1)Class5.Default;
				Class7 obj12 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				_003CModule_003E = (_003CModule_003E)(object)obj12.t(bindingFlags, (FieldInfo[])(object)((Class7)null).W(bindingFlags, propertyInfo_, (Type)null, array2, parameterModifier_), Class5.Default, null);
			}
		}
		while (@class.t(obj2, null, null) != null);
		_ = (GClass3)(object)@class.W(default(BindingFlags), propertyInfo_, null, array2, (ParameterModifier[])(object)Class5.Default);
		Class9 class20 = (Class9)(object)Class5.Default;
		class20 = class20;
		bindingFlags = default(BindingFlags);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass3 gClass2);
		if ((UIntPtr)((Class7)null).t(bindingFlags, fieldInfo_3, obj2, (CultureInfo)null) == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (GClass0)(object)Class5.Default;
			}
			catch
			{
				try
				{
					GClass3 obj13 = (GClass3)(object)Class5.Default;
					gClass2 = gClass2;
					gClass2 = obj13;
				}
				finally
				{
					_ = (Class6)(object)Class5.Default;
					_ = (Class4)((Class7)null).t((object)null, type, cultureInfo);
					class20 = null;
					goto end_IL_0a19;
				}
				end_IL_0a19:;
			}
			goto IL_0a86;
		}
		try
		{
			_ = (Class9)((Class7)null).t((object)Class5.Default, type, (CultureInfo)null);
		}
		finally
		{
			_ = (Class6)(object)Class5.Default;
			goto IL_0a86;
		}
		IL_5298:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class10 class21);
		if (checked(num + unchecked((nuint)(UIntPtr)Class5.Default)) == 0)
		{
			try
			{
				try
				{
					class21 = null;
					class20 = class20;
					@class = (Class7)(object)Class5.Default;
					_ = (Class6)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, parameterModifier_, (CultureInfo)null, (string[])(object)Class5.Default, out reference), parameterModifier_);
				}
				finally
				{
					_ = (Struct2)Class5.Default;
					Class7 obj15 = (Class7)(object)@class.e((BindingFlags)Class5.Default, null, array2, parameterModifier_);
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_23 = bindingFlags;
					PropertyInfo[] propertyInfo_3 = (PropertyInfo[])(object)Class5.Default;
					Class7 obj16 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Class7)(object)obj15.W(bindingFlags_23, propertyInfo_3, (Type)(object)obj16.W(bindingFlags, null, null, array2, (ParameterModifier[])@class.t(Class5.Default, (Type)(object)Class5.Default, cultureInfo)), array2, parameterModifier_);
					@class = (Class7)(object)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])null, type, array2, parameterModifier_);
					Type type_3 = type;
					Class7 obj17 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_24 = (BindingFlags)@class.W(bindingFlags, propertyInfo_, (Type)(object)Class5.Default, array2, (ParameterModifier[])(object)((Class7)(object)Class5.Default).t(bindingFlags, fieldInfo_3, Class5.Default, (CultureInfo)(object)Class5.Default));
					Class7 class22 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass0)((Class7)null).t((object)null, type_3, (CultureInfo)(object)obj17.j(bindingFlags_24, (MethodBase[])(object)class22.e(bindingFlags, null, null, parameterModifier_), ref object_, null, (CultureInfo)(object)Class5.Default, string_3, out reference));
					goto end_IL_52ac;
				}
				end_IL_52ac:;
			}
			finally
			{
				if ((UIntPtr)((Class7)(object)Class5.Default).j((BindingFlags)@class.j(bindingFlags, array, ref object_, parameterModifier_, (CultureInfo)((Class7)null).t((object)null, type, (CultureInfo)(object)Class5.Default), string_3, out *(object*)null), array, ref object_, (ParameterModifier[])(object)Class5.Default, null, string_3, out *(object*)Class5.Default) == (UIntPtr)(nuint)0u)
				{
					_ = (_003CModule_003E)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)null, array2, parameterModifier_);
				}
				goto IL_552b;
			}
		}
		GClass2 gClass3 = gClass3;
		goto IL_552b;
		IL_4335:
		try
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				try
				{
					class19 = null;
					_ = (Class7)(object)Class5.Default;
					_ = (GClass0)(object)Class5.Default;
					_ = (GClass2)(object)Class5.Default;
				}
				finally
				{
					_ = (Class0)(object)@class.W((BindingFlags)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref object_, parameterModifier_, cultureInfo, (string[])(object)Class5.Default, out reference), null, type, null, parameterModifier_);
					goto end_IL_4336;
				}
			}
			end_IL_4336:;
		}
		catch
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (GClass1)(object)Class5.Default;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class5 class23);
		try
		{
			class23 = class23;
		}
		catch
		{
			_ = (Qk7)(object)Class5.Default;
		}
		if (num == 0)
		{
			_ = (Class6)(object)Class5.Default;
		}
		while (((Class7)null).t(obj2, type, cultureInfo) != null)
		{
			try
			{
				do
				{
					BindingFlags bindingFlags_25 = bindingFlags;
					Type type_4 = type;
					Class7 class24 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass2)(object)((Class7)null).W(bindingFlags_25, propertyInfo_, type_4, (Type[])(object)((Class7)null).t((BindingFlags)class24.e(bindingFlags, (MethodBase[])(object)Class5.Default, null, parameterModifier_), fieldInfo_3, (object)null, (CultureInfo)null), parameterModifier_);
				}
				while ((object)Class5.Default != null);
			}
			catch
			{
				nuint num2 = num;
				num = default(UIntPtr);
				if (num2 / num == 0)
				{
					_ = (Class0)(object)Class5.Default;
				}
				else
				{
					_ = (Class5)(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, (CultureInfo)(object)Class5.Default);
				}
			}
		}
		while (true)
		{
			Class7 class25 = @class;
			bindingFlags = default(BindingFlags);
			if ((object)class25.e(bindingFlags, (MethodBase[])(object)((Class7)null).j(bindingFlags, array, ref *(object[]*)null, (ParameterModifier[])(object)((Class7)null).e(default(BindingFlags), array, array2, parameterModifier_), cultureInfo, string_3, out reference), (Type[])((Class7)null).t(obj2, (Type)(object)Class5.Default, cultureInfo), null) == null)
			{
				break;
			}
			_ = (GClass1)(object)Class5.Default;
		}
		Class7 obj21 = (Class7)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		_ = (Struct2)obj21.e(bindingFlags, array, array2, null);
		_ = (Class8)(object)((Class7)(object)Class5.Default).t(bindingFlags, (FieldInfo[])(object)@class.j((BindingFlags)Class5.Default, array, ref *(object[]*)null, parameterModifier_, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out *(object*)null), obj2, cultureInfo);
		if (num == 0)
		{
			try
			{
				do
				{
					_ = (Class0)(object)@class.e(bindingFlags, array, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
					_ = (Class4)(object)((Class7)(object)@class.t((BindingFlags)Class5.Default, fieldInfo_3, obj2, null)).W((BindingFlags)((Class7)(object)((Class7)(object)Class5.Default).e(bindingFlags, array, array2, null)).t(obj2, type, (CultureInfo)(object)Class5.Default), propertyInfo_, type, (Type[])(object)Class5.Default, parameterModifier_);
					_ = (Struct1)((Class7)null).e(bindingFlags, array, array2, (ParameterModifier[])(object)Class5.Default);
				}
				while ((object)((Class7)null).W(bindingFlags, propertyInfo_, type, array2, (ParameterModifier[])(object)Class5.Default) != null);
			}
			finally
			{
				while (obj2 != null)
				{
					class19 = class19;
				}
				goto IL_471e;
			}
		}
		goto IL_471e;
		IL_3d28:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass0 gClass4);
		if ((UIntPtr)@class.W((BindingFlags)Class5.Default, propertyInfo_, type, array2, parameterModifier_) == (UIntPtr)(nuint)0u)
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					gClass4 = null;
				}
			}
			catch
			{
				Class7 class26 = @class;
				BindingFlags bindingFlags_26 = bindingFlags;
				Type[] type_5 = (Type[])@class.t(obj2, type, (CultureInfo)(object)Class5.Default);
				MethodBase[] methodBase_10 = array;
				Class7 class27 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_27 = bindingFlags;
				Class7 class28 = @class;
				BindingFlags bindingFlags_28 = bindingFlags;
				Class7 obj22 = (Class7)@class.t(obj2, type, cultureInfo);
				BindingFlags bindingFlags_29 = bindingFlags;
				Class7 class29 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class7)(object)class26.e(bindingFlags_26, null, type_5, (ParameterModifier[])(object)((Class7)null).j(default(BindingFlags), methodBase_10, ref *(object[]*)class27.j(bindingFlags_27, null, ref object_, (ParameterModifier[])(object)class28.W(bindingFlags_28, (PropertyInfo[])(object)obj22.t(bindingFlags_29, null, class29.j(bindingFlags, null, ref *(object[]*)null, null, (CultureInfo)(object)@class.j(bindingFlags, array, ref object_, parameterModifier_, (CultureInfo)(object)Class5.Default, null, out *(object*)Class5.Default), null, out reference), null), null, null, null), cultureInfo, string_3, out reference), (ParameterModifier[])null, (CultureInfo)null, string_3, out *(object*)null));
			}
		}
		do
		{
			gClass2 = gClass2;
		}
		while ((object)Class5.Default != null);
		_ = (Class4)(object)Class5.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qk7 qk);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct1 @struct);
		try
		{
			gClass = gClass;
			gClass4 = gClass4;
			gClass3 = null;
			@struct = (Struct1)((Class7)null).j((BindingFlags)Class5.Default, array, ref *(object[]*)null, parameterModifier_, cultureInfo, (string[])null, out reference);
		}
		catch
		{
			while (obj2 != null)
			{
				qk = qk;
			}
		}
		num = default(UIntPtr);
		if (num == 0)
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				while (obj2 != null)
				{
					gClass = gClass;
				}
			}
			else
			{
				while ((object)@class.j(bindingFlags, null, ref object_, parameterModifier_, cultureInfo, string_3, out *(object*)@class.t(Class5.Default, type, cultureInfo)) != null)
				{
					_ = (GClass2)(object)Class5.Default;
				}
			}
		}
		else
		{
			_ = (Class10)(object)Class5.Default;
		}
		_ = (Struct1)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, null, cultureInfo, string_3, out reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class8 class31);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct2 struct2);
		try
		{
			try
			{
				nuint num3 = num;
				num = default(UIntPtr);
				if (num3 / checked(num - num) == 0)
				{
					_ = (Class4)@class.t(obj2, (Type)(object)Class5.Default, cultureInfo);
					@struct = default(Struct1);
					@struct = @struct;
					Class7 class30 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Struct1)class30.e(bindingFlags, (MethodBase[])(object)((Class7)(object)Class5.Default).e(bindingFlags, array, array2, parameterModifier_), array2, (ParameterModifier[])(object)Class5.Default);
					class23 = class23;
				}
				else
				{
					struct2 = (Struct2)Class5.Default;
				}
			}
			finally
			{
				@class = @class;
				goto end_IL_3fb7;
			}
			end_IL_3fb7:;
		}
		finally
		{
			try
			{
				_ = (Class10)(object)Class5.Default;
				class31 = class31;
			}
			catch
			{
				do
				{
					gClass3 = gClass3;
				}
				while (obj2 != null);
			}
			goto IL_40a6;
		}
		IL_4a53:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class4 class32);
		try
		{
			try
			{
				do
				{
					qk = null;
				}
				while (obj2 != null);
			}
			finally
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					class19 = class19;
				}
				goto end_IL_4a54;
			}
			end_IL_4a54:;
		}
		catch
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				do
				{
					class32 = class32;
				}
				while (obj2 != null);
			}
			else if (num == (UIntPtr)(nuint)0u)
			{
				_ = (Class2)@class.t(obj2, null, null);
			}
		}
		try
		{
			while (obj2 != null)
			{
				do
				{
					_ = (Class9)(object)@class.j(bindingFlags, array, ref object_, (ParameterModifier[])(object)Class5.Default, cultureInfo, null, out *(object*)((Class7)(object)Class5.Default).t(null, null, null));
					Class7 class33 = @class;
					BindingFlags bindingFlags_30 = bindingFlags;
					PropertyInfo[] propertyInfo_4 = (PropertyInfo[])(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					gClass3 = (GClass2)(object)class33.W(bindingFlags_30, propertyInfo_4, (Type)((Class7)null).t((object)((Class7)null).j(bindingFlags, array, ref *(object[]*)Class5.Default, parameterModifier_, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out *(object*)Class5.Default), type, cultureInfo), array2, parameterModifier_);
				}
				while (obj2 != null);
			}
		}
		catch
		{
			try
			{
				try
				{
					class31 = class31;
				}
				finally
				{
					_ = (GClass1)(object)Class5.Default;
					_ = (GClass2)(object)Class5.Default;
					Class7 class34 = @class;
					BindingFlags bindingFlags_31 = bindingFlags;
					FieldInfo[] fieldInfo_4 = (FieldInfo[])(object)Class5.Default;
					Class7 class35 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_32 = bindingFlags;
					MethodBase[] methodBase_11 = array;
					ref object[] object_6 = ref *(object[]*)@class.t(null, null, null);
					BindingFlags bindingFlags_33 = bindingFlags;
					Class7 obj27 = (Class7)(object)@class.W(bindingFlags, propertyInfo_, (Type)(object)@class.e(bindingFlags, array, array2, (ParameterModifier[])(object)Class5.Default), array2, parameterModifier_);
					BindingFlags bindingFlags_34 = bindingFlags;
					MethodBase[] methodBase_12 = (MethodBase[])(object)Class5.Default;
					Class7 class36 = @class;
					bindingFlags = default(BindingFlags);
					CultureInfo cultureInfo_5 = (CultureInfo)(object)((Class7)(object)class36.j(bindingFlags, array, ref object_, parameterModifier_, null, (string[])(object)Class5.Default, out reference)).t(bindingFlags, fieldInfo_3, @class.t(obj2, type, null), cultureInfo);
					string[] string_4 = (string[])(object)Class5.Default;
					Class7 class37 = @class;
					Class7 obj28 = (Class7)@class.t(obj2, null, cultureInfo);
					bindingFlags = default(BindingFlags);
					_ = (_003CModule_003E)(object)class34.t(bindingFlags_31, fieldInfo_4, obj2, (CultureInfo)(object)class35.j(bindingFlags_32, methodBase_11, ref object_6, parameterModifier_, (CultureInfo)(object)((Class7)null).j(bindingFlags_33, (MethodBase[])((Class7)null).t((object)((Class7)(object)obj27.j(bindingFlags_34, methodBase_12, ref *(object[]*)null, parameterModifier_, cultureInfo_5, string_4, out *(object*)class37.t(null, null, (CultureInfo)(object)obj28.e(bindingFlags, (MethodBase[])(object)((Class7)null).e(bindingFlags, array, array2, parameterModifier_), array2, (ParameterModifier[])(object)Class5.Default)))).j(bindingFlags, array, ref object_, null, cultureInfo, null, out *(object*)null), type, (CultureInfo)null), ref object_, (ParameterModifier[])null, cultureInfo, string_3, out reference), string_3, out reference));
					struct2 = default(Struct2);
					struct2 = struct2;
					goto end_IL_4b93;
				}
				end_IL_4b93:;
			}
			finally
			{
				num = default(UIntPtr);
				UIntPtr num4 = num;
				Class7 obj29 = (Class7)(object)((Class7)(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, (object)Class5.Default, (CultureInfo)null)).j((BindingFlags)@class.W(bindingFlags, propertyInfo_, type, null, null), (MethodBase[])(object)((Class7)(object)Class5.Default).j(bindingFlags, array, ref *(object[]*)@class.t(null, null, (CultureInfo)(object)Class5.Default), parameterModifier_, null, (string[])(object)Class5.Default, out *(object*)Class5.Default), ref *(object[]*)@class.j(default(BindingFlags), null, ref object_, (ParameterModifier[])(object)Class5.Default, cultureInfo, string_3, out reference), parameterModifier_, null, (string[])(object)Class5.Default, out *(object*)Class5.Default);
				bindingFlags = default(BindingFlags);
				checked
				{
					if (unchecked((nuint)num4) * unchecked((nuint)(UIntPtr)obj29.e(bindingFlags, array, null, parameterModifier_)) == 0)
					{
						_003CModule_003E = (_003CModule_003E)(object)@class.t(bindingFlags, fieldInfo_3, null, null);
					}
					else
					{
						_ = (GClass2)(object)((Class7)null).t(default(BindingFlags), (FieldInfo[])null, obj2, (CultureInfo)null);
					}
					goto end_IL_4b92;
				}
			}
			end_IL_4b92:;
		}
		do
		{
			if (num != (UIntPtr)(nuint)0u)
			{
				_ = (GClass2)(object)Class5.Default;
			}
			else
			{
				qk = (Qk7)(object)Class5.Default;
			}
		}
		while (obj2 != null);
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				while (obj2 != null)
				{
					_ = Class5.Default;
				}
			}
			else
			{
				_ = (Class9)@class.t(obj2, type, (CultureInfo)(object)((Class7)null).t((BindingFlags)Class5.Default, fieldInfo_3, (object)null, (CultureInfo)null));
			}
		}
		else
		{
			_ = (Class6)(object)((Class7)null).t(default(BindingFlags), (FieldInfo[])null, obj2, cultureInfo);
		}
		do
		{
			try
			{
				_ = (Class0)(object)Class5.Default;
			}
			finally
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					struct2 = struct2;
				}
				continue;
			}
		}
		while (obj2 != null);
		while (true)
		{
			if (obj2 != null)
			{
				_ = (Qk7)(object)Class5.Default;
				continue;
			}
			bindingFlags = default(BindingFlags);
			if ((object)((Class7)null).j(bindingFlags, array, ref object_, parameterModifier_, (CultureInfo)(object)Class5.Default, (string[])null, out *(object*)null) == null)
			{
				break;
			}
		}
		try
		{
			do
			{
				try
				{
					_ = (Class10)(object)((Class7)(object)Class5.Default).t((BindingFlags)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array2, (ParameterModifier[])@class.t(obj2, (Type)(object)Class5.Default, cultureInfo)), fieldInfo_3, null, (CultureInfo)(object)@class.W(bindingFlags, null, null, array2, parameterModifier_));
				}
				catch
				{
					_ = (Class0)(object)Class5.Default;
				}
			}
			while (obj2 != null);
		}
		catch
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				do
				{
					_ = (Class0)(object)@class.t(bindingFlags, null, obj2, null);
				}
				while ((object)Class5.Default != null);
			}
			else
			{
				_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
			}
		}
		try
		{
			try
			{
				struct2 = struct2;
			}
			finally
			{
				_ = (GClass1)(object)@class.e((BindingFlags)((Class7)(object)Class5.Default).t(obj2, null, null), array, (Type[])(object)Class5.Default, parameterModifier_);
				goto end_IL_5117;
			}
			end_IL_5117:;
		}
		finally
		{
			_ = (Class10)(object)Class5.Default;
			gClass3 = gClass3;
			class20 = class20;
			class21 = class21;
			goto IL_5186;
		}
		IL_3373:
		while ((object)@class.e(bindingFlags, array, array2, null) != null)
		{
			try
			{
				try
				{
					@struct = @struct;
				}
				finally
				{
					Class7 class38 = @class;
					BindingFlags bindingFlags_35 = bindingFlags;
					Class7 obj33 = (Class7)(object)@class.W(bindingFlags, null, type, null, parameterModifier_);
					BindingFlags bindingFlags_36 = bindingFlags;
					MethodBase[] methodBase_13 = array;
					Class7 class39 = @class;
					Class7 class40 = @class;
					Class7 class41 = @class;
					BindingFlags bindingFlags_37 = bindingFlags;
					Class7 obj34 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					Class7 obj35 = (Class7)(object)obj34.e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, null);
					Class7 obj36 = (Class7)(object)@class.e(bindingFlags, null, array2, null);
					bindingFlags = default(BindingFlags);
					ref object[] object_7 = ref *(object[]*)((Class7)((Class7)(object)class39.t((BindingFlags)((Class7)(object)class40.t((BindingFlags)class41.e((BindingFlags)((Class7)null).j(bindingFlags_37, (MethodBase[])obj35.t(obj2, (Type)(object)obj36.e(bindingFlags, array, array2, parameterModifier_), cultureInfo), ref *(object[]*)null, (ParameterModifier[])null, (CultureInfo)((Class7)(object)Class5.Default).t(obj2, type, cultureInfo), (string[])null, out *(object*)Class5.Default), array, null, parameterModifier_), fieldInfo_3, Class5.Default, (CultureInfo)(object)Class5.Default)).W(bindingFlags, null, (Type)(object)Class5.Default, array2, (ParameterModifier[])(object)@class.e((BindingFlags)@class.t(((Class7)null).W(bindingFlags, (PropertyInfo[])(object)@class.j((BindingFlags)Class5.Default, (MethodBase[])@class.t(obj2, null, cultureInfo), ref *(object[]*)Class5.Default, null, cultureInfo, null, out *(object*)Class5.Default), (Type)(object)@class.e(bindingFlags, null, array2, null), (Type[])null, (ParameterModifier[])(object)Class5.Default), type, cultureInfo), (MethodBase[])(object)@class.e(bindingFlags, array, array2, null), null, null)), (FieldInfo[])(object)Class5.Default, obj2, cultureInfo)).t(obj2, (Type)(object)Class5.Default, cultureInfo)).t(bindingFlags, fieldInfo_3, obj2, (CultureInfo)(object)Class5.Default);
					Class7 class42 = @class;
					BindingFlags bindingFlags_38 = bindingFlags;
					Class7 class43 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class6)(object)class38.e(bindingFlags_35, null, (Type[])(object)obj33.j(bindingFlags_36, methodBase_13, ref object_7, (ParameterModifier[])(object)((Class7)(object)class42.W(bindingFlags_38, (PropertyInfo[])(object)class43.W(bindingFlags, (PropertyInfo[])(object)((Class7)null).W(bindingFlags, propertyInfo_, type, array2, parameterModifier_), type, (Type[])(object)@class.j(bindingFlags, array, ref *(object[]*)null, (ParameterModifier[])((Class7)null).t((object)Class5.Default, (Type)null, cultureInfo), cultureInfo, (string[])(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, array2, (ParameterModifier[])((Class7)(object)Class5.Default).t(null, (Type)(object)@class.W((BindingFlags)((Class7)null).j((BindingFlags)((Class7)(object)Class5.Default).t(bindingFlags, null, obj2, cultureInfo), array, ref object_, (ParameterModifier[])null, cultureInfo, string_3, out *(object*)Class5.Default), (PropertyInfo[])(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, null, null), (Type)(object)Class5.Default, array2, parameterModifier_), cultureInfo)), out *(object*)Class5.Default), (ParameterModifier[])(object)Class5.Default), null, (Type[])(object)Class5.Default, parameterModifier_)).t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, cultureInfo), (CultureInfo)(object)Class5.Default, null, out *(object*)null), null);
					goto end_IL_2f0f;
				}
				end_IL_2f0f:;
			}
			finally
			{
				_ = (Class0)@class.t(null, type, (CultureInfo)(object)((Class7)null).e((BindingFlags)((Class7)null).j((BindingFlags)Class5.Default, (MethodBase[])null, ref object_, parameterModifier_, cultureInfo, string_3, out *(object*)null), (MethodBase[])null, array2, parameterModifier_));
				continue;
			}
		}
		Class7 obj37 = (Class7)(object)Class5.Default;
		Class7 class44 = @class;
		bindingFlags = default(BindingFlags);
		_ = (Qk7)obj37.t(class44.W(bindingFlags, propertyInfo_, type, array2, (ParameterModifier[])(object)Class5.Default), (Type)(object)@class.W(bindingFlags, propertyInfo_, type, array2, parameterModifier_), cultureInfo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class2 class45);
		if ((UIntPtr)@class.t(null, type, cultureInfo) == (UIntPtr)(nuint)0u)
		{
			try
			{
			}
			catch
			{
				Class7 obj38 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_39 = bindingFlags;
				BindingFlags bindingFlags_40 = bindingFlags;
				bindingFlags = default(BindingFlags);
				_ = (Struct1)obj38.t(bindingFlags_39, null, obj2, (CultureInfo)(object)((Class7)null).W(bindingFlags_40, (PropertyInfo[])null, (Type)(object)((Class7)null).W(bindingFlags, propertyInfo_, (Type)null, (Type[])null, parameterModifier_), array2, (ParameterModifier[])null));
			}
		}
		else if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				class45 = class45;
			}
			catch
			{
				_ = (Class4)((Class7)(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, null)).t(obj2, type, cultureInfo);
			}
		}
		else
		{
			_ = (Qk7)(object)Class5.Default;
		}
		_ = (Class5)(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref object_, parameterModifier_, (CultureInfo)(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, (CultureInfo)(object)Class5.Default), string_3, out reference);
		while ((object)@class.t(bindingFlags, fieldInfo_3, obj2, null) != null)
		{
			try
			{
				num = default(UIntPtr);
				if (num == (UIntPtr)(nuint)0u)
				{
					_ = (Class5)@class.t(obj2, type, cultureInfo);
					_ = (GClass2)(object)Class5.Default;
				}
			}
			catch
			{
				class31 = class31;
			}
		}
		gClass4 = gClass4;
		struct2 = (Struct2)Class5.Default;
		try
		{
			gClass2 = gClass2;
		}
		finally
		{
			_ = (GClass3)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, (ParameterModifier[])null);
			goto IL_35d2;
		}
		IL_5186:
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)((Class7)null).e(bindingFlags, array, array2, (ParameterModifier[])(object)Class5.Default) == (UIntPtr)(nuint)0u)
			{
				while (obj2 != null)
				{
					class19 = class19;
				}
			}
		}
		else
		{
			class45 = class45;
			_ = (Class4)(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, parameterModifier_);
			qk = qk;
		}
		try
		{
			try
			{
				num = default(UIntPtr);
				nuint num5 = num;
				num = default(UIntPtr);
				if (checked(num5 * num) == 0)
				{
					@struct = @struct;
					qk = qk;
				}
			}
			finally
			{
				if (num == 0)
				{
					_ = (Class9)(object)@class.t((BindingFlags)Class5.Default, fieldInfo_3, null, cultureInfo);
				}
				goto end_IL_51fd;
			}
			end_IL_51fd:;
		}
		finally
		{
			_003CModule_003E = _003CModule_003E;
			class23 = class23;
			_ = (Class7)(object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref object_, parameterModifier_, null, null, out reference);
			goto IL_5298;
		}
		IL_552b:
		bindingFlags = default(BindingFlags);
		if ((UIntPtr)((Class7)null).e(bindingFlags, (MethodBase[])(object)@class.e(bindingFlags, null, array2, null), array2, (ParameterModifier[])null) == (UIntPtr)(nuint)0u)
		{
			try
			{
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
				_ = (Class4)@class.t(Class5.Default, (Type)(object)Class5.Default, null);
			}
			catch
			{
				try
				{
					_ = (Class9)(object)Class5.Default;
				}
				finally
				{
					gClass4 = null;
					goto end_IL_5597;
				}
				end_IL_5597:;
			}
		}
		class19 = (Class0)(object)Class5.Default;
		while (obj2 != null)
		{
			try
			{
				if (num == 0)
				{
					_ = (GClass1)((Class7)@class.t(((Class7)null).t(bindingFlags, fieldInfo_3, obj2, cultureInfo), (Type)(object)((Class7)null).W(bindingFlags, propertyInfo_, (Type)null, (Type[])(object)Class5.Default, parameterModifier_), cultureInfo)).t(obj2, null, (CultureInfo)(object)Class5.Default);
				}
			}
			finally
			{
				do
				{
					_003CModule_003E = _003CModule_003E;
				}
				while (obj2 != null);
				continue;
			}
		}
		while (obj2 != null)
		{
			try
			{
				qk = (Qk7)(object)@class.t(bindingFlags, fieldInfo_3, obj2, cultureInfo);
			}
			catch
			{
				try
				{
					_ = (Class7)(object)((Class7)null).W(bindingFlags, propertyInfo_, (Type)null, (Type[])null, parameterModifier_);
				}
				catch
				{
					_ = (GClass1)(object)Class5.Default;
					_ = (Struct1)Class5.Default;
					gClass4 = null;
					_ = (Class10)(object)Class5.Default;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class6 class46);
		do
		{
			class46 = (Class6)(object)@class.e(bindingFlags, null, array2, parameterModifier_);
		}
		while (obj2 != null);
		_ = (Class7)((Class7)null).t(obj2, type, cultureInfo);
		Class7 class47 = @class;
		bindingFlags = default(BindingFlags);
		_ = (Class6)(object)class47.e(bindingFlags, array, array2, (ParameterModifier[])(object)Class5.Default);
		gClass3 = gClass3;
		do
		{
			@struct = (Struct1)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)(object)Class5.Default, (Type[])(object)Class5.Default, parameterModifier_);
		}
		while (obj2 != null);
		_ = (Class2)(object)@class.t((BindingFlags)((Class7)null).t(obj2, (Type)null, cultureInfo), (FieldInfo[])(object)Class5.Default, Class5.Default, cultureInfo);
		if (num == 0)
		{
			Class7 obj46 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_41 = (BindingFlags)((Class7)null).t((object)@class.j(default(BindingFlags), null, ref object_, parameterModifier_, cultureInfo, (string[])(object)@class.t(default(BindingFlags), fieldInfo_3, null, cultureInfo), out *(object*)null), (Type)(object)Class5.Default, cultureInfo);
			bindingFlags = default(BindingFlags);
			_ = (Class0)(object)((Class7)(object)((Class7)null).W(default(BindingFlags), (PropertyInfo[])null, (Type)null, (Type[])null, (ParameterModifier[])(object)obj46.W((BindingFlags)((Class7)null).j(bindingFlags_41, (MethodBase[])(object)((Class7)null).e(bindingFlags, array, (Type[])null, (ParameterModifier[])null), ref *(object[]*)null, parameterModifier_, (CultureInfo)(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, parameterModifier_), string_3, out *(object*)null), null, null, array2, parameterModifier_))).e(bindingFlags, null, array2, (ParameterModifier[])(object)@class.j(default(BindingFlags), (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, parameterModifier_, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out reference));
		}
		while (true)
		{
			bindingFlags = default(BindingFlags);
			if ((object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)(object)Class5.Default, (Type[])null, (ParameterModifier[])null) == null)
			{
				break;
			}
			try
			{
				try
				{
					_ = (Class9)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref object_, parameterModifier_, (CultureInfo)(object)Class5.Default, string_3, out reference);
				}
				finally
				{
					gClass3 = gClass3;
					goto end_IL_5915;
				}
				end_IL_5915:;
			}
			finally
			{
				try
				{
					_ = (Class5)(object)@class.j(bindingFlags, null, ref object_, (ParameterModifier[])(object)Class5.Default, cultureInfo, null, out reference);
				}
				finally
				{
					_ = (Class2)(object)Class5.Default;
					continue;
				}
			}
		}
		try
		{
			bindingFlags = default(BindingFlags);
			nuint num6 = (nuint)(UIntPtr)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)Class5.Default, (ParameterModifier[])null, (CultureInfo)null, (string[])null, out reference) / (nuint)(UIntPtr)Class5.Default;
			nuint num7 = num;
			num = default(UIntPtr);
			checked
			{
				if (num6 * unchecked(checked(num7 * num) / num) == 0)
				{
					if (num == 0)
					{
						_ = (Qk7)(object)Class5.Default;
					}
					else
					{
						class19 = (Class0)(object)Class5.Default;
					}
				}
			}
		}
		catch
		{
			try
			{
				_ = (GClass2)((Class7)null).t(obj2, type, (CultureInfo)null);
			}
			catch
			{
				try
				{
					_ = Class5.Default;
					goto end_IL_5a43;
				}
				catch
				{
					class23 = class23;
					goto end_IL_5a43;
				}
				end_IL_5a43:;
			}
		}
		Class7 class48 = @class;
		BindingFlags bindingFlags_42 = bindingFlags;
		Type type_6 = type;
		Class7 class49 = @class;
		MethodBase[] methodBase_14 = array;
		Class7 class50 = @class;
		BindingFlags bindingFlags_43 = (BindingFlags)Class5.Default;
		Type type_7 = type;
		bindingFlags = default(BindingFlags);
		UIntPtr num8 = (UIntPtr)class48.W(bindingFlags_42, null, type_6, (Type[])(object)class49.e(default(BindingFlags), methodBase_14, null, (ParameterModifier[])(object)class50.W(bindingFlags_43, propertyInfo_, type_7, null, (ParameterModifier[])(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)Class5.Default, parameterModifier_, cultureInfo, (string[])(object)Class5.Default, out reference))), parameterModifier_);
		UIntPtr num9 = (UIntPtr)Class5.Default;
		num = default(UIntPtr);
		if ((nuint)num8 / ((nuint)num9 / num) == 0)
		{
			try
			{
				if (num == 0)
				{
					@struct = @struct;
				}
			}
			catch
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (Class6)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)null, parameterModifier_, cultureInfo, string_3, out *(object*)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, null, (CultureInfo)(object)((Class7)(object)Class5.Default).e(bindingFlags, array, null, (ParameterModifier[])(object)@class.W((BindingFlags)((Class7)(object)Class5.Default).W((BindingFlags)((Class7)(object)@class.j(bindingFlags, null, ref *(object[]*)@class.W(bindingFlags, null, type, array2, (ParameterModifier[])(object)Class5.Default), null, cultureInfo, string_3, out reference)).j(bindingFlags, array, ref *(object[]*)null, parameterModifier_, null, string_3, out reference), propertyInfo_, null, array2, parameterModifier_), (PropertyInfo[])(object)((Class7)(object)Class5.Default).W(bindingFlags, (PropertyInfo[])(object)@class.e(bindingFlags, array, array2, parameterModifier_), type, array2, parameterModifier_), type, array2, null)), (string[])(object)@class.W(bindingFlags, null, type, null, parameterModifier_), out reference));
				}
				else
				{
					class19 = class19;
				}
			}
		}
		try
		{
			return;
		}
		catch
		{
			do
			{
				if (num == 0)
				{
					class31 = class31;
				}
			}
			while (obj2 != null);
			return;
		}
		IL_1fea:
		num = default(UIntPtr);
		if (num == 0)
		{
			try
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (Class10)(object)Class5.Default;
				}
				else
				{
					class45 = (Class2)(object)Class5.Default;
				}
			}
			finally
			{
				try
				{
					class23 = Class5.Default;
				}
				finally
				{
					class31 = class31;
					goto IL_2044;
				}
			}
		}
		goto IL_2044;
		IL_471e:
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u && (UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			Class7 class51 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Class10)(object)class51.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array2, parameterModifier_);
			class31 = class31;
		}
		try
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
				class32 = class32;
				Class7 class52 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class6)(object)class52.e(bindingFlags, array, array2, parameterModifier_);
				_ = Class5.Default;
			}
			else
			{
				qk = (Qk7)(object)Class5.Default;
			}
		}
		finally
		{
			class21 = null;
			goto IL_47db;
		}
		IL_0a86:
		try
		{
			try
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					class31 = null;
					class31 = class31;
				}
				else
				{
					Class7 class53 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_44 = bindingFlags;
					MethodBase[] methodBase_15 = (MethodBase[])@class.t(obj2, null, (CultureInfo)(object)((Class7)null).e((BindingFlags)Class5.Default, array, array2, parameterModifier_));
					Class7 class54 = @class;
					BindingFlags bindingFlags_45 = bindingFlags;
					bindingFlags = default(BindingFlags);
					Class7 obj52 = (Class7)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)(object)Class5.Default, array2, parameterModifier_);
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_46 = bindingFlags;
					MethodBase[] methodBase_16 = (MethodBase[])(object)Class5.Default;
					Class7 class55 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class2)(object)class53.j(bindingFlags_44, methodBase_15, ref *(object[]*)null, parameterModifier_, null, null, out *(object*)class54.t(bindingFlags_45, (FieldInfo[])(object)((Class7)(object)obj52.e(bindingFlags_46, methodBase_16, null, (ParameterModifier[])(object)class55.W(bindingFlags, propertyInfo_, null, array2, (ParameterModifier[])(object)@class.W(bindingFlags, null, null, array2, parameterModifier_)))).W(bindingFlags, null, (Type)(object)Class5.Default, array2, (ParameterModifier[])@class.t(@class.W(bindingFlags, propertyInfo_, type, (Type[])(object)Class5.Default, (ParameterModifier[])(object)@class.W((BindingFlags)((Class7)null).e(bindingFlags, (MethodBase[])((Class7)(object)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, null, obj2, cultureInfo)).t(obj2, type, null), array2, parameterModifier_), propertyInfo_, (Type)(object)@class.j(bindingFlags, array, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)@class.t(bindingFlags, null, obj2, cultureInfo), null, string_3, out reference), (Type[])(object)Class5.Default, parameterModifier_)), null, cultureInfo)), null, (CultureInfo)(object)Class5.Default));
				}
			}
			catch
			{
				qk = qk;
				qk = qk;
			}
		}
		catch
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				while (obj2 != null)
				{
					class20 = null;
					class23 = class23;
					class23 = class23;
				}
			}
			else
			{
				_ = (_003CModule_003E)(object)Class5.Default;
			}
		}
		if (checked(num * num) == 0)
		{
			_003CModule_003E = _003CModule_003E;
		}
		_ = (Class0)(object)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, null, (Type[])@class.t(obj2, (Type)(object)@class.W(bindingFlags, propertyInfo_, type, array2, (ParameterModifier[])(object)Class5.Default), cultureInfo), parameterModifier_);
		Class7 obj55 = (Class7)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		_ = (_003CModule_003E)(object)obj55.t(bindingFlags, null, obj2, cultureInfo);
		gClass2 = null;
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			while (true)
			{
				Class7 class56 = @class;
				Type type_8 = type;
				Class7 class57 = @class;
				bindingFlags = default(BindingFlags);
				if ((object)class56.W(default(BindingFlags), propertyInfo_, type_8, array2, (ParameterModifier[])(object)class57.e(bindingFlags, array, array2, parameterModifier_)) == null)
				{
					break;
				}
				while (obj2 != null)
				{
					_ = (_003CModule_003E)(object)@class.j(bindingFlags, array, ref object_, parameterModifier_, null, string_3, out *(object*)((Class7)(object)((Class7)(object)Class5.Default).t(bindingFlags, fieldInfo_3, obj2, (CultureInfo)(object)Class5.Default)).t(obj2, type, (CultureInfo)(object)@class.j(bindingFlags, array, ref *(object[]*)null, (ParameterModifier[])((Class7)(object)@class.W(bindingFlags, propertyInfo_, (Type)(object)Class5.Default, array2, parameterModifier_)).t(null, null, cultureInfo), (CultureInfo)(object)Class5.Default, null, out reference)));
				}
			}
		}
		num = default(UIntPtr);
		if (num == 0)
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				if ((UIntPtr)((Class7)(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, cultureInfo)).j(bindingFlags, (MethodBase[])((Class7)null).t((object)Class5.Default, type, (CultureInfo)null), ref *(object[]*)Class5.Default, parameterModifier_, (CultureInfo)(object)@class.j(bindingFlags, (MethodBase[])(object)@class.W((BindingFlags)Class5.Default, propertyInfo_, type, null, (ParameterModifier[])@class.t(obj2, (Type)(object)Class5.Default, cultureInfo)), ref *(object[]*)Class5.Default, parameterModifier_, cultureInfo, (string[])(object)Class5.Default, out *(object*)null), string_3, out *(object*)Class5.Default) == (UIntPtr)(nuint)0u)
				{
					Class7 obj56 = (Class7)(object)@class.j((BindingFlags)Class5.Default, array, ref *(object[]*)null, null, cultureInfo, string_3, out *(object*)null);
					Class7 class58 = @class;
					Class7 class59 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class0)(object)obj56.W(default(BindingFlags), propertyInfo_, (Type)(object)class58.t(default(BindingFlags), (FieldInfo[])(object)((Class7)(object)class59.t(bindingFlags, (FieldInfo[])((Class7)(object)Class5.Default).t(obj2, type, null), obj2, null)).e((BindingFlags)@class.e(bindingFlags, array, (Type[])(object)@class.W(bindingFlags, propertyInfo_, type, null, parameterModifier_), null), null, array2, null), null, (CultureInfo)(object)@class.j(bindingFlags, null, ref *(object[]*)null, (ParameterModifier[])((Class7)(object)Class5.Default).t(obj2, type, cultureInfo), cultureInfo, (string[])(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, parameterModifier_), out *(object*)null)), (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
				}
			}
			else if (num == 0)
			{
				class20 = class20;
			}
		}
		else
		{
			_ = (Class9)@class.t(((Class7)null).t((BindingFlags)Class5.Default, fieldInfo_3, obj2, cultureInfo), type, cultureInfo);
		}
		while (obj2 != null)
		{
			if ((UIntPtr)((Class7)(object)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, propertyInfo_, null, array2, null)).W((BindingFlags)@class.e((BindingFlags)Class5.Default, array, array2, parameterModifier_), (PropertyInfo[])(object)Class5.Default, type, array2, null) == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (GClass0)(object)Class5.Default;
				}
				finally
				{
					_ = (Class2)(object)Class5.Default;
					continue;
				}
			}
		}
		class31 = class31;
		PropertyInfo[] propertyInfo_5 = (PropertyInfo[])(object)Class5.Default;
		Class7 class60 = @class;
		bindingFlags = default(BindingFlags);
		if ((UIntPtr)((Class7)null).W(default(BindingFlags), propertyInfo_5, (Type)(object)class60.e(bindingFlags, (MethodBase[])@class.t(obj2, type, cultureInfo), array2, (ParameterModifier[])(object)@class.e(bindingFlags, null, null, null)), array2, parameterModifier_) == (UIntPtr)(nuint)0u)
		{
			while (obj2 != null)
			{
				Class7 class61 = @class;
				Class7 obj57 = (Class7)(object)((Class7)null).W(bindingFlags, propertyInfo_, type, array2, (ParameterModifier[])@class.t(Class5.Default, null, null));
				Class7 obj58 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_47 = bindingFlags;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_48 = (BindingFlags)obj57.t(null, (Type)(object)obj58.e(bindingFlags_47, (MethodBase[])(object)((Class7)null).W(bindingFlags, propertyInfo_, type, (Type[])(object)Class5.Default, parameterModifier_), array2, parameterModifier_), cultureInfo);
				MethodBase[] methodBase_17 = array;
				CultureInfo cultureInfo_6 = cultureInfo;
				Class7 obj59 = (Class7)(object)Class5.Default;
				Class7 class62 = @class;
				BindingFlags bindingFlags_49 = bindingFlags;
				FieldInfo[] fieldInfo_5 = (FieldInfo[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)(object)Class5.Default, array2, (ParameterModifier[])null);
				Class7 obj60 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				Struct2 obj61 = (Struct2)class61.j(bindingFlags_48, methodBase_17, ref object_, parameterModifier_, cultureInfo_6, (string[])(object)obj59.j((BindingFlags)class62.t(bindingFlags_49, fieldInfo_5, null, (CultureInfo)(object)obj60.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, cultureInfo)), (MethodBase[])(object)Class5.Default, ref *(object[]*)null, parameterModifier_, (CultureInfo)(object)Class5.Default, string_3, out reference), out *(object*)Class5.Default);
				struct2 = struct2;
				struct2 = obj61;
			}
		}
		else
		{
			_ = (GClass1)(object)((Class7)null).W(bindingFlags, propertyInfo_, (Type)(object)Class5.Default, array2, (ParameterModifier[])null);
		}
		try
		{
			if (num == 0)
			{
				gClass4 = gClass4;
				gClass4 = gClass4;
			}
		}
		finally
		{
			if (num == 0)
			{
				try
				{
					_ = (GClass2)(object)Class5.Default;
				}
				finally
				{
					_ = (GClass2)((Class7)(object)@class.t(bindingFlags, fieldInfo_3, obj2, cultureInfo)).t(obj2, type, null);
					class32 = class32;
					class32 = class32;
					class45 = (Class2)(object)Class5.Default;
					class45 = class45;
					goto IL_1504;
				}
			}
			goto IL_1504;
		}
		IL_1504:
		while (obj2 != null)
		{
			class32 = (Class4)(object)((Class7)null).t((BindingFlags)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, parameterModifier_, cultureInfo, (string[])(object)Class5.Default, out *(object*)null), fieldInfo_3, (object)null, cultureInfo);
		}
		checked
		{
			nuint num10 = unchecked((nuint)(UIntPtr)((Class7)(object)Class5.Default).e(bindingFlags, array, null, null)) - num;
			nuint num11 = num;
			num = default(UIntPtr);
			if (num10 - (num11 - num) == 0)
			{
				try
				{
					_ = (Class10)(object)Class5.Default;
				}
				catch
				{
					class21 = class21;
					class21 = class21;
				}
			}
			else
			{
				nuint num12 = num * unchecked((nuint)default(UIntPtr)) * unchecked((nuint)default(UIntPtr)) - unchecked((nuint)(UIntPtr)Class5.Default);
				num = default(UIntPtr);
				nuint num13 = num12 + (num - unchecked((nuint)(UIntPtr)Class5.Default));
				nuint num14 = num;
				num = default(UIntPtr);
				nuint num15;
				unchecked
				{
					num15 = checked(num14 - num + num) / checked(num + unchecked((nuint)default(UIntPtr)));
					num = default(UIntPtr);
				}
				if (num13 + (num15 - (unchecked((nuint)default(UIntPtr)) - unchecked(num / num) - num)) == 0)
				{
					do
					{
						gClass2 = gClass2;
					}
					while (obj2 != null);
				}
			}
			_ = (Qk7)(object)Class5.Default;
			num = default(UIntPtr);
		}
		if (num == (UIntPtr)(nuint)0u)
		{
			while (obj2 != null)
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					@class = @class;
				}
			}
		}
		else
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					_003CModule_003E = _003CModule_003E;
				}
			}
			else
			{
				try
				{
					_ = (Class0)(object)@class.j((BindingFlags)Class5.Default, array, ref object_, parameterModifier_, cultureInfo, (string[])(object)Class5.Default, out reference);
					_003CModule_003E = _003CModule_003E;
					class31 = (Class8)(object)Class5.Default;
				}
				catch
				{
					_ = (Struct2)Class5.Default;
				}
			}
		}
		try
		{
			try
			{
				try
				{
					bindingFlags = default(BindingFlags);
					_ = (Qk7)(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, (object)null, (CultureInfo)(object)Class5.Default);
				}
				finally
				{
					_ = (Struct2)Class5.Default;
					goto end_IL_16c8;
				}
				end_IL_16c8:;
			}
			finally
			{
				try
				{
					_ = (GClass3)((Class7)null).t(obj2, (Type)null, (CultureInfo)null);
				}
				finally
				{
					Class7 class63 = @class;
					bindingFlags = default(BindingFlags);
					GClass2 obj64 = (GClass2)class63.t(((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])null, (ParameterModifier[])(object)((Class7)null).j((BindingFlags)Class5.Default, (MethodBase[])null, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)@class.t(bindingFlags, fieldInfo_3, obj2, cultureInfo), (CultureInfo)null, string_3, out reference)), type, (CultureInfo)(object)@class.e(bindingFlags, array, array2, (ParameterModifier[])(object)@class.W((BindingFlags)Class5.Default, propertyInfo_, type, array2, parameterModifier_)));
					gClass3 = gClass3;
					gClass3 = obj64;
					goto end_IL_16c7;
				}
			}
			end_IL_16c7:;
		}
		catch
		{
			while (obj2 != null)
			{
				class46 = class46;
				class46 = class46;
			}
		}
		while ((object)Class5.Default != null)
		{
			do
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					_ = (Class4)((Class7)null).t(obj2, type, (CultureInfo)(object)Class5.Default);
				}
			}
			while ((object)Class5.Default != null);
		}
		while ((object)Class5.Default != null)
		{
			while ((object)Class5.Default != null)
			{
				Class7 obj66 = (Class7)(object)Class5.Default;
				Class7 class64 = @class;
				bindingFlags = default(BindingFlags);
				_ = (GClass2)(object)obj66.W(default(BindingFlags), propertyInfo_, (Type)(object)class64.e(bindingFlags, array, null, (ParameterModifier[])@class.t(obj2, type, null)), null, parameterModifier_);
			}
		}
		num = default(UIntPtr);
		if (checked(num + num) == 0)
		{
			_ = (Struct2)Class5.Default;
		}
		if ((UIntPtr)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, null) == (UIntPtr)(nuint)0u)
		{
			Class7 class65 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Class5)(object)class65.e(bindingFlags, array, array2, parameterModifier_);
		}
		try
		{
			try
			{
				bindingFlags = default(BindingFlags);
				Class7 obj67 = (Class7)(object)((Class7)null).W(bindingFlags, propertyInfo_, type, (Type[])null, parameterModifier_);
				Class7 obj68 = (Class7)(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)@class.e(bindingFlags, array, array2, parameterModifier_), ref object_, (ParameterModifier[])(object)((Class7)(object)Class5.Default).e(bindingFlags, null, (Type[])((Class7)(object)Class5.Default).t(obj2, null, cultureInfo), (ParameterModifier[])(object)Class5.Default), cultureInfo, (string[])(object)Class5.Default, out reference);
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_50 = bindingFlags;
				Class7 class66 = @class;
				bindingFlags = default(BindingFlags);
				gClass2 = (GClass3)(object)obj67.t((BindingFlags)obj68.e(bindingFlags_50, (MethodBase[])(object)class66.e(bindingFlags, array, null, parameterModifier_), (Type[])(object)Class5.Default, parameterModifier_), fieldInfo_3, obj2, cultureInfo);
			}
			catch
			{
				gClass = null;
			}
		}
		catch
		{
			checked
			{
				if (unchecked((nuint)(UIntPtr)Class5.Default) - unchecked((nuint)(UIntPtr)Class5.Default) == 0)
				{
					gClass = null;
				}
				else
				{
					_ = (Class6)(object)Class5.Default;
				}
			}
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					_ = (Class4)(object)Class5.Default;
					_ = (_003CModule_003E)@class.t(obj2, type, cultureInfo);
				}
				finally
				{
					class46 = (Class6)(object)@class.t(bindingFlags, fieldInfo_3, obj2, null);
					@struct = @struct;
					@struct = default(Struct1);
					@struct = @struct;
					_ = (Class9)(object)Class5.Default;
					goto end_IL_1a93;
				}
				end_IL_1a93:;
			}
			catch
			{
				if ((UIntPtr)((Class7)null).t(obj2, type, cultureInfo) == (UIntPtr)(nuint)0u)
				{
					Class7 class67 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class8)(object)class67.e(bindingFlags, (MethodBase[])(object)@class.e(bindingFlags, (MethodBase[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj2, (CultureInfo)(object)((Class7)(object)@class.j(bindingFlags, null, ref object_, parameterModifier_, (CultureInfo)(object)((Class7)(object)@class.e(bindingFlags, array, null, null)).W(bindingFlags, null, (Type)(object)@class.e(bindingFlags, array, array2, (ParameterModifier[])(object)Class5.Default), array2, null), string_3, out *(object*)null)).t(bindingFlags, (FieldInfo[])(object)((Class7)null).W(bindingFlags, propertyInfo_, type, (Type[])null, parameterModifier_), null, (CultureInfo)(object)Class5.Default)), array2, null), array2, parameterModifier_);
				}
				else
				{
					Class7 class68 = @class;
					Class7 class69 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_51 = (BindingFlags)class69.j(bindingFlags, array, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo, string_3, out *(object*)Class5.Default);
					MethodBase[] methodBase_18 = array;
					ref object[] object_8 = ref *(object[]*)Class5.Default;
					Class7 class70 = @class;
					BindingFlags bindingFlags_52 = bindingFlags;
					Class7 obj71 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (GClass2)(object)class68.j(bindingFlags_51, methodBase_18, ref object_8, (ParameterModifier[])(object)class70.e(bindingFlags_52, null, array2, (ParameterModifier[])(object)obj71.W(bindingFlags, propertyInfo_, type, null, (ParameterModifier[])(object)@class.t(bindingFlags, null, obj2, null))), cultureInfo, string_3, out reference);
					_ = (Struct2)Class5.Default;
					_ = (Class8)(object)@class.j((BindingFlags)Class5.Default, null, ref *(object[]*)null, (ParameterModifier[])(object)@class.j(bindingFlags, array, ref *(object[]*)@class.e(default(BindingFlags), array, array2, null), parameterModifier_, null, null, out *(object*)null), cultureInfo, string_3, out *(object*)Class5.Default);
					_ = (Class10)(object)@class.j((BindingFlags)Class5.Default, array, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)Class5.Default, string_3, out *(object*)null);
				}
			}
		}
		checked
		{
			try
			{
				gClass4 = (GClass0)(object)Class5.Default;
			}
			finally
			{
				Class7 class71 = @class;
				MethodBase[] methodBase_19 = array;
				Class7 class72 = @class;
				bindingFlags = default(BindingFlags);
				Class7 obj73 = (Class7)(object)class72.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref object_, parameterModifier_, cultureInfo, string_3, out reference);
				Class7 class73 = @class;
				BindingFlags bindingFlags_53 = bindingFlags;
				Class7 class74 = @class;
				Class7 class75 = @class;
				Class7 class76 = @class;
				bindingFlags = default(BindingFlags);
				if (unchecked((nuint)(UIntPtr)class71.e(default(BindingFlags), methodBase_19, (Type[])obj73.t(obj2, (Type)(object)class73.W(bindingFlags_53, (PropertyInfo[])(object)((Class7)null).t(default(BindingFlags), (FieldInfo[])(object)class74.t((BindingFlags)class75.W((BindingFlags)class76.W(bindingFlags, propertyInfo_, null, array2, parameterModifier_), propertyInfo_, (Type)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)(object)Class5.Default, (Type[])(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array2, parameterModifier_), (ParameterModifier[])null), null, parameterModifier_), fieldInfo_3, obj2, (CultureInfo)(object)Class5.Default), obj2, (CultureInfo)(object)((Class7)(object)@class.W((BindingFlags)Class5.Default, propertyInfo_, type, null, parameterModifier_)).W((BindingFlags)((Class7)null).j((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, (ParameterModifier[])null, (CultureInfo)@class.t(obj2, type, cultureInfo), (string[])null, out reference), null, null, array2, null)), type, null, parameterModifier_), null), parameterModifier_)) - unchecked((nuint)(UIntPtr)@class.W(bindingFlags, null, type, array2, null) / (nuint)(UIntPtr)Class5.Default) == 0)
				{
					try
					{
						@struct = default(Struct1);
						@struct = @struct;
					}
					catch
					{
						_ = Class5.Default;
					}
				}
				else if (num == 0)
				{
					class31 = null;
				}
				else
				{
					_ = (GClass2)(object)((Class7)(object)Class5.Default).W(bindingFlags, propertyInfo_, type, null, null);
				}
				goto IL_1fea;
			}
		}
		IL_2044:
		try
		{
			num = default(UIntPtr);
			nuint num16 = num;
			num = default(UIntPtr);
			if (num16 / num == 0)
			{
				_ = (Class0)(object)Class5.Default;
			}
		}
		catch
		{
			bindingFlags = default(BindingFlags);
			class20 = (Class9)(object)((Class7)null).j(bindingFlags, array, ref *(object[]*)null, parameterModifier_, (CultureInfo)(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, cultureInfo), (string[])null, out *(object*)null);
		}
		try
		{
			gClass2 = gClass2;
		}
		catch
		{
			try
			{
				do
				{
					gClass = gClass;
				}
				while (obj2 != null);
			}
			finally
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					@class = null;
				}
				goto end_IL_20cb;
			}
			end_IL_20cb:;
		}
		while (obj2 != null)
		{
			try
			{
				try
				{
					_ = (Struct1)Class5.Default;
				}
				finally
				{
					_ = Class5.Default;
					goto end_IL_20f3;
				}
				end_IL_20f3:;
			}
			catch
			{
				do
				{
					class45 = null;
				}
				while (obj2 != null);
			}
		}
		gClass = (GClass1)(object)((Class7)null).j(bindingFlags, array, ref object_, (ParameterModifier[])null, cultureInfo, string_3, out reference);
		if (num == 0)
		{
			try
			{
				_ = (GClass1)(object)@class.W((BindingFlags)Class5.Default, (PropertyInfo[])(object)Class5.Default, (Type)(object)Class5.Default, array2, parameterModifier_);
				gClass3 = gClass3;
				@class = @class;
				class46 = (Class6)(object)Class5.Default;
			}
			catch
			{
				try
				{
					Class7 obj78 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_54 = bindingFlags;
					MethodBase[] methodBase_20 = array;
					Class7 class77 = @class;
					BindingFlags bindingFlags_55 = bindingFlags;
					Class7 class78 = @class;
					BindingFlags bindingFlags_56 = bindingFlags;
					MethodBase[] methodBase_21 = array;
					BindingFlags bindingFlags_57 = (BindingFlags)Class5.Default;
					Type[] type_9 = (Type[])@class.t(obj2, type, (CultureInfo)(object)Class5.Default);
					Class7 class79 = @class;
					BindingFlags bindingFlags_58 = bindingFlags;
					MethodBase[] methodBase_22 = array;
					bindingFlags = default(BindingFlags);
					Class7 obj79 = (Class7)((Class7)(object)obj78.e(bindingFlags_54, methodBase_20, (Type[])(object)class77.t(bindingFlags_55, null, class78.j(bindingFlags_56, methodBase_21, ref object_, (ParameterModifier[])(object)((Class7)null).e(bindingFlags_57, (MethodBase[])null, type_9, (ParameterModifier[])(object)((Class7)(object)class79.j(bindingFlags_58, methodBase_22, ref object_, (ParameterModifier[])(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, (ParameterModifier[])null), cultureInfo, string_3, out *(object*)null)).t(bindingFlags, null, null, null)), null, string_3, out reference), cultureInfo), parameterModifier_)).t(obj2, (Type)(object)Class5.Default, cultureInfo);
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_59 = bindingFlags;
					MethodBase[] methodBase_23 = array;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_60 = bindingFlags;
					BindingFlags bindingFlags_61 = (BindingFlags)Class5.Default;
					Class7 class80 = @class;
					BindingFlags bindingFlags_62 = bindingFlags;
					FieldInfo[] fieldInfo_6 = (FieldInfo[])(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					Class7 obj80 = (Class7)(object)((Class7)null).t(bindingFlags_61, (FieldInfo[])(object)class80.t(bindingFlags_62, fieldInfo_6, obj2, (CultureInfo)(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, (ParameterModifier[])null, (CultureInfo)null, string_3, out reference)), (object)null, cultureInfo);
					Class7 class81 = @class;
					BindingFlags bindingFlags_63 = bindingFlags;
					Class7 class82 = @class;
					bindingFlags = default(BindingFlags);
					Type[] type_10 = (Type[])(object)((Class7)null).j(bindingFlags_60, (MethodBase[])obj80.t(null, (Type)(object)class81.W(bindingFlags_63, (PropertyInfo[])(object)class82.j(bindingFlags, array, ref object_, parameterModifier_, null, null, out *(object*)((Class7)null).t((BindingFlags)((Class7)null).t(obj2, type, cultureInfo), fieldInfo_3, (object)null, (CultureInfo)@class.t(obj2, type, null))), (Type)@class.t(obj2, null, (CultureInfo)(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, Class5.Default, (CultureInfo)(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, null))), array2, null), null), ref object_, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, null), string_3, out *(object*)null);
					BindingFlags bindingFlags_64 = bindingFlags;
					Type type_11 = type;
					Class7 class83 = @class;
					Class7 obj81 = (Class7)((Class7)(object)@class.W(bindingFlags, propertyInfo_, type, (Type[])(object)Class5.Default, parameterModifier_)).t(obj2, type, null);
					bindingFlags = default(BindingFlags);
					Class7 obj82 = (Class7)(object)obj81.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, null);
					bindingFlags = default(BindingFlags);
					_ = (_003CModule_003E)(object)obj79.e(bindingFlags_59, methodBase_23, type_10, (ParameterModifier[])(object)((Class7)(object)((Class7)null).W(bindingFlags_64, propertyInfo_, type_11, (Type[])(object)class83.W((BindingFlags)obj82.j(bindingFlags, null, ref *(object[]*)null, null, null, string_3, out *(object*)Class5.Default), propertyInfo_, type, (Type[])(object)Class5.Default, null), parameterModifier_)).t(bindingFlags, null, @class.e(bindingFlags, array, null, parameterModifier_), cultureInfo));
					_ = (Class8)(object)@class.j((BindingFlags)Class5.Default, array, ref object_, parameterModifier_, cultureInfo, string_3, out reference);
					gClass2 = null;
					class20 = class20;
				}
				finally
				{
					class23 = null;
					goto end_IL_21ad;
				}
				end_IL_21ad:;
			}
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			class46 = class46;
		}
		else
		{
			do
			{
				try
				{
					_003CModule_003E = null;
				}
				catch
				{
					gClass2 = gClass2;
				}
			}
			while (obj2 != null);
		}
		do
		{
			try
			{
				_ = (Qk7)(object)Class5.Default;
			}
			finally
			{
				Class7 class84 = @class;
				BindingFlags bindingFlags_65 = bindingFlags;
				Class7 obj85 = (Class7)(object)@class.j(bindingFlags, array, ref *(object[]*)null, (ParameterModifier[])(object)((Class7)(object)((Class7)(object)Class5.Default).t(bindingFlags, null, obj2, null)).t(bindingFlags, null, null, null), cultureInfo, string_3, out *(object*)null);
				bindingFlags = default(BindingFlags);
				_ = (GClass0)(object)class84.W(bindingFlags_65, (PropertyInfo[])(object)obj85.e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, null), (Type)@class.t(obj2, (Type)(object)@class.t(bindingFlags, fieldInfo_3, obj2, cultureInfo), cultureInfo), (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
				continue;
			}
		}
		while (obj2 != null || obj2 != null);
		num = default(UIntPtr);
		checked
		{
			if (num + num * unchecked(num / (nuint)(UIntPtr)Class5.Default) == 0)
			{
				class31 = (Class8)(object)Class5.Default;
			}
			else
			{
				while (obj2 != null)
				{
					if (num == 0)
					{
						class45 = class45;
					}
					else
					{
						class23 = (Class5)(object)((Class7)(object)Class5.Default).t(bindingFlags, fieldInfo_3, obj2, null);
					}
				}
			}
		}
		try
		{
			try
			{
				try
				{
					_ = (Class8)((Class7)null).t((object)Class5.Default, type, cultureInfo);
				}
				catch
				{
					_ = (Qk7)(object)@class.j(bindingFlags, (MethodBase[])(object)((Class7)null).j(bindingFlags, array, ref object_, (ParameterModifier[])(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)@class.j((BindingFlags)Class5.Default, array, ref *(object[]*)null, parameterModifier_, null, null, out *(object*)null), ref *(object[]*)Class5.Default, (ParameterModifier[])null, (CultureInfo)null, (string[])null, out *(object*)Class5.Default), cultureInfo, string_3, out *(object*)null), ref *(object[]*)Class5.Default, parameterModifier_, (CultureInfo)(object)Class5.Default, string_3, out reference);
				}
			}
			catch
			{
				@class = (Class7)(object)Class5.Default;
			}
		}
		catch
		{
			_ = (Class2)(object)Class5.Default;
		}
		try
		{
			do
			{
				_ = (GClass1)(object)@class.W((BindingFlags)Class5.Default, null, (Type)(object)Class5.Default, array2, parameterModifier_);
			}
			while ((object)Class5.Default != null);
		}
		catch
		{
			if (checked(num - unchecked((nuint)(UIntPtr)@class.e(bindingFlags, null, array2, parameterModifier_)) + unchecked((nuint)(UIntPtr)((Class7)(object)Class5.Default).t((BindingFlags)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, parameterModifier_, cultureInfo, string_3, out *(object*)null), null, ((Class7)(object)Class5.Default).t(bindingFlags, null, obj2, cultureInfo), cultureInfo))) == 0)
			{
				_ = (GClass2)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)@class.W(bindingFlags, propertyInfo_, type, null, parameterModifier_), (Type[])(object)((Class7)null).W(bindingFlags, propertyInfo_, (Type)(object)Class5.Default, (Type[])@class.t(((Class7)(object)((Class7)null).e(bindingFlags, array, (Type[])null, (ParameterModifier[])null)).j((BindingFlags)Class5.Default, null, ref *(object[]*)null, null, cultureInfo, null, out reference), null, cultureInfo), parameterModifier_), (ParameterModifier[])(object)Class5.Default);
				_ = (Class2)(object)Class5.Default;
				class45 = class45;
				_003CModule_003E = _003CModule_003E;
			}
			else
			{
				class45 = (Class2)(object)@class.t(bindingFlags, fieldInfo_3, obj2, cultureInfo);
			}
		}
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			while (true)
			{
				if ((object)Class5.Default != null)
				{
					Class7 class85 = @class;
					BindingFlags bindingFlags_66 = (BindingFlags)((Class7)(object)@class.j((BindingFlags)@class.W(bindingFlags, null, type, array2, parameterModifier_), array, ref object_, parameterModifier_, null, string_3, out reference)).W((BindingFlags)Class5.Default, null, type, null, null);
					Class7 class86 = @class;
					BindingFlags bindingFlags_67 = bindingFlags;
					MethodBase[] methodBase_24 = (MethodBase[])(object)Class5.Default;
					ref object[] object_9 = ref *(object[]*)Class5.Default;
					Class7 class87 = @class;
					Class7 class88 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_68 = (BindingFlags)((Class7)(object)((Class7)null).e((BindingFlags)class88.j(bindingFlags, array, ref *(object[]*)null, null, cultureInfo, string_3, out reference), array, array2, (ParameterModifier[])null)).t(obj2, (Type)(object)((Class7)(object)Class5.Default).t(bindingFlags, fieldInfo_3, null, null), null);
					MethodBase[] methodBase_25 = (MethodBase[])(object)Class5.Default;
					Class7 class89 = @class;
					Type type_12 = type;
					bindingFlags = default(BindingFlags);
					_ = (Class4)(object)class85.t(bindingFlags_66, fieldInfo_3, null, (CultureInfo)((Class7)(object)class86.j(bindingFlags_67, methodBase_24, ref object_9, parameterModifier_, (CultureInfo)(object)class87.e(bindingFlags_68, methodBase_25, (Type[])class89.t(null, type_12, (CultureInfo)(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, parameterModifier_, (CultureInfo)null, string_3, out *(object*)null)), null), string_3, out *(object*)null)).t(((Class7)(object)((Class7)null).e(bindingFlags, array, array2, (ParameterModifier[])null)).j(bindingFlags, array, ref *(object[]*)@class.j(bindingFlags, null, ref object_, (ParameterModifier[])(object)@class.t(bindingFlags, (FieldInfo[])(object)((Class7)(object)Class5.Default).t((BindingFlags)((Class7)(object)Class5.Default).t(obj2, (Type)(object)Class5.Default, cultureInfo), fieldInfo_3, obj2, (CultureInfo)(object)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])null, (Type)null, (Type[])null, parameterModifier_)), null, cultureInfo), (CultureInfo)@class.t(Class5.Default, (Type)(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)@class.e(bindingFlags, array, null, parameterModifier_), obj2, (CultureInfo)null), cultureInfo), string_3, out reference), null, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out reference), type, cultureInfo));
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
				_ = (Struct2)Class5.Default;
			}
			finally
			{
				@class = @class;
				continue;
			}
		}
		while (obj2 != null);
		struct2 = (Struct2)Class5.Default;
		try
		{
			try
			{
				num = default(UIntPtr);
				if (num == (UIntPtr)(nuint)0u)
				{
					_ = (GClass1)(object)Class5.Default;
				}
			}
			catch
			{
				do
				{
					class23 = class23;
				}
				while ((object)Class5.Default != null);
			}
		}
		catch
		{
			do
			{
				if ((UIntPtr)Class5.Default != (UIntPtr)(nuint)0u)
				{
					_ = (GClass3)(object)Class5.Default;
					@struct = @struct;
				}
				else
				{
					_ = (Class9)(object)((Class7)(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array2, null)).e(bindingFlags, null, (Type[])(object)@class.e((BindingFlags)Class5.Default, (MethodBase[])(object)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])(object)@class.j(bindingFlags, null, ref *(object[]*)@class.W(bindingFlags, propertyInfo_, type, array2, parameterModifier_), parameterModifier_, cultureInfo, null, out *(object*)Class5.Default), type, array2, (ParameterModifier[])(object)((Class7)null).j((BindingFlags)((Class7)(object)Class5.Default).t((BindingFlags)((Class7)null).t((object)null, (Type)null, (CultureInfo)null), (FieldInfo[])(object)Class5.Default, obj2, null), (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, parameterModifier_, cultureInfo, (string[])null, out *(object*)null)), (Type[])(object)Class5.Default, null), parameterModifier_);
				}
			}
			while (obj2 != null);
		}
		if (num == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (Class6)(object)((Class7)@class.t(null, type, null)).t(bindingFlags, fieldInfo_3, obj2, cultureInfo);
			}
			catch
			{
				do
				{
					_ = (Class6)(object)((Class7)(object)Class5.Default).t(bindingFlags, null, obj2, cultureInfo);
				}
				while (obj2 != null);
			}
		}
		try
		{
			_003CModule_003E = _003CModule_003E;
		}
		finally
		{
			while (obj2 != null)
			{
				while (obj2 != null)
				{
					_ = (Class2)(object)Class5.Default;
					_ = (Class0)(object)Class5.Default;
				}
			}
			goto IL_3373;
		}
		IL_47db:
		if (num == (UIntPtr)(nuint)0u)
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				try
				{
					BindingFlags bindingFlags_69 = bindingFlags;
					MethodBase[] methodBase_26 = (MethodBase[])(object)Class5.Default;
					Class7 class90 = @class;
					BindingFlags bindingFlags_70 = bindingFlags;
					Class7 obj93 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Class9)(object)((Class7)null).j(bindingFlags_69, methodBase_26, ref object_, (ParameterModifier[])(object)class90.t(bindingFlags_70, fieldInfo_3, obj93.e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, parameterModifier_), cultureInfo), (CultureInfo)(object)@class.t(bindingFlags, fieldInfo_3, null, null), string_3, out reference);
					_ = (GClass3)(object)Class5.Default;
				}
				finally
				{
					gClass3 = gClass3;
					goto IL_4a53;
				}
			}
			try
			{
				gClass = (GClass1)(object)Class5.Default;
			}
			finally
			{
				qk = qk;
				goto IL_4a53;
			}
		}
		try
		{
			do
			{
				class31 = class31;
			}
			while (obj2 != null);
		}
		finally
		{
			do
			{
				Class7 obj94 = (Class7)(object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, null, cultureInfo, string_3, out *(object*)null);
				BindingFlags bindingFlags_71 = bindingFlags;
				PropertyInfo[] propertyInfo_6 = (PropertyInfo[])(object)Class5.Default;
				Class7 class91 = @class;
				BindingFlags bindingFlags_72 = bindingFlags;
				Type type_13 = type;
				bindingFlags = default(BindingFlags);
				Type[] type_14 = (Type[])((Class7)null).t(obj2, type_13, (CultureInfo)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)@class.W((BindingFlags)Class5.Default, propertyInfo_, type, (Type[])(object)@class.W((BindingFlags)Class5.Default, propertyInfo_, type, array2, null), null), (Type)(object)Class5.Default, array2, parameterModifier_));
				BindingFlags bindingFlags_73 = bindingFlags;
				FieldInfo[] fieldInfo_7 = (FieldInfo[])(object)Class5.Default;
				Class7 obj95 = (Class7)(object)Class5.Default;
				Class7 class92 = @class;
				Class7 class93 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class8)(object)obj94.W(bindingFlags_71, propertyInfo_6, (Type)(object)class91.W(bindingFlags_72, null, null, type_14, (ParameterModifier[])(object)((Class7)null).t(bindingFlags_73, fieldInfo_7, (object)obj95.t(default(BindingFlags), fieldInfo_3, class92.W(default(BindingFlags), propertyInfo_, (Type)(object)class93.W(bindingFlags, propertyInfo_, type, array2, parameterModifier_), null, parameterModifier_), null), cultureInfo)), (Type[])(object)Class5.Default, parameterModifier_);
			}
			while (obj2 != null);
			goto IL_4a53;
		}
		IL_40a6:
		if ((UIntPtr)@class.j(bindingFlags, array, ref object_, null, cultureInfo, string_3, out reference) == (UIntPtr)(nuint)0u)
		{
			Class7 class94 = @class;
			bindingFlags = default(BindingFlags);
			_ = (GClass0)(object)class94.j(bindingFlags, null, ref object_, parameterModifier_, cultureInfo, string_3, out *(object*)null);
		}
		_ = (Class9)(object)Class5.Default;
		try
		{
			while (obj2 != null)
			{
				class31 = null;
			}
		}
		catch
		{
			if (num == 0)
			{
				class46 = class46;
			}
		}
		finally
		{
			try
			{
				if (checked(unchecked((nuint)(UIntPtr)@class.e(bindingFlags, array, array2, null)) * (unchecked((nuint)default(UIntPtr)) - unchecked((nuint)(UIntPtr)@class.t(obj2, (Type)(object)((Class7)(object)Class5.Default).t((BindingFlags)@class.t(obj2, type, (CultureInfo)((Class7)null).t((object)Class5.Default, (Type)null, cultureInfo)), fieldInfo_3, obj2, cultureInfo), cultureInfo)))) == 0)
				{
					_003CModule_003E = _003CModule_003E;
					@struct = @struct;
					_ = (Class9)(object)Class5.Default;
				}
				else
				{
					_ = (Class4)(object)Class5.Default;
					_ = (Class8)(object)((Class7)null).j((BindingFlags)Class5.Default, (MethodBase[])null, ref *(object[]*)Class5.Default, parameterModifier_, (CultureInfo)null, (string[])null, out reference);
				}
			}
			catch
			{
				try
				{
					qk = qk;
				}
				finally
				{
					Class7 obj97 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_74 = (BindingFlags)Class5.Default;
					Class7 obj98 = (Class7)(object)Class5.Default;
					Class7 obj99 = (Class7)((Class7)null).t((object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj2, cultureInfo), (Type)null, cultureInfo);
					BindingFlags bindingFlags_75 = bindingFlags;
					FieldInfo[] fieldInfo_8 = (FieldInfo[])(object)Class5.Default;
					Class7 obj100 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Class10)(object)obj97.W(bindingFlags_74, propertyInfo_, null, (Type[])(object)obj98.t((BindingFlags)obj99.t(bindingFlags_75, fieldInfo_8, null, (CultureInfo)(object)obj100.e(bindingFlags, array, array2, null)), null, ((Class7)(object)Class5.Default).W(bindingFlags, null, (Type)(object)Class5.Default, (Type[])(object)Class5.Default, null), cultureInfo), parameterModifier_);
					class21 = (Class10)(object)Class5.Default;
					@struct = (Struct1)Class5.Default;
					class21 = (Class10)(object)Class5.Default;
					goto end_IL_421c;
				}
				end_IL_421c:;
			}
			goto IL_4335;
		}
		IL_35d2:
		try
		{
			try
			{
				while ((object)((Class7)(object)Class5.Default).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, cultureInfo) != null)
				{
					class19 = null;
					_ = (Class0)(object)Class5.Default;
					qk = qk;
				}
			}
			catch
			{
				try
				{
					gClass2 = gClass2;
				}
				catch
				{
					Class7 class95 = @class;
					BindingFlags bindingFlags_76 = bindingFlags;
					MethodBase[] methodBase_27 = array;
					BindingFlags bindingFlags_77 = (BindingFlags)Class5.Default;
					Class7 class96 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass3)(object)class95.j(bindingFlags_76, methodBase_27, ref object_, (ParameterModifier[])(object)((Class7)null).t(bindingFlags_77, (FieldInfo[])(object)class96.j(bindingFlags, array, ref *(object[]*)null, null, cultureInfo, string_3, out *(object*)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, Class5.Default, cultureInfo)), (object)Class5.Default, (CultureInfo)null), cultureInfo, string_3, out reference);
				}
			}
		}
		catch
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					gClass2 = (GClass3)(object)Class5.Default;
				}
				else
				{
					Class7 obj104 = (Class7)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, parameterModifier_);
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_78 = bindingFlags;
					FieldInfo[] fieldInfo_9 = (FieldInfo[])((Class7)null).t(((Class7)(object)((Class7)null).e(bindingFlags, array, (Type[])null, parameterModifier_)).t(obj2, null, cultureInfo), type, cultureInfo);
					Class7 obj105 = (Class7)(object)((Class7)(object)Class5.Default).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array2, null);
					BindingFlags bindingFlags_79 = (BindingFlags)Class5.Default;
					Type type_15 = type;
					bindingFlags = default(BindingFlags);
					_ = (Class9)((Class7)(object)obj104.t(bindingFlags_78, fieldInfo_9, obj2, (CultureInfo)(object)obj105.W(bindingFlags_79, propertyInfo_, type_15, (Type[])(object)((Class7)null).t(bindingFlags, fieldInfo_3, (object)null, (CultureInfo)null), null))).t(obj2, type, null);
				}
			}
		}
		_ = (Class2)(object)@class.j(bindingFlags, array, ref object_, parameterModifier_, cultureInfo, string_3, out *(object*)null);
		while ((object)Class5.Default != null)
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_003CModule_003E = _003CModule_003E;
				}
				finally
				{
					_ = (Class6)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)@class.j(bindingFlags, array, ref *(object[]*)((Class7)null).e(bindingFlags, array, array2, parameterModifier_), parameterModifier_, null, string_3, out *(object*)null), type, array2, parameterModifier_);
					continue;
				}
			}
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				BindingFlags bindingFlags_80 = (BindingFlags)Class5.Default;
				MethodBase[] methodBase_28 = (MethodBase[])(object)Class5.Default;
				ref object[] object_10 = ref *(object[]*)Class5.Default;
				CultureInfo cultureInfo_7 = (CultureInfo)(object)Class5.Default;
				Class7 class97 = @class;
				BindingFlags bindingFlags_81 = (BindingFlags)Class5.Default;
				MethodBase[] methodBase_29 = array;
				CultureInfo cultureInfo_8 = cultureInfo;
				Class7 class98 = @class;
				Class7 class99 = @class;
				Class7 class100 = @class;
				Class7 class101 = @class;
				MethodBase[] methodBase_30 = (MethodBase[])(object)Class5.Default;
				Class7 class102 = @class;
				Class7 class103 = @class;
				BindingFlags bindingFlags_82 = (BindingFlags)Class5.Default;
				MethodBase[] methodBase_31 = array;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_83 = bindingFlags;
				Class7 obj107 = (Class7)(object)@class.t(bindingFlags, fieldInfo_3, ((Class7)null).t((object)Class5.Default, (Type)null, cultureInfo), cultureInfo);
				Class7 obj108 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				CultureInfo cultureInfo_9 = (CultureInfo)(object)((Class7)null).W(bindingFlags_83, propertyInfo_, (Type)(object)obj107.e((BindingFlags)((Class7)(object)obj108.t(bindingFlags, fieldInfo_3, obj2, (CultureInfo)(object)((Class7)(object)((Class7)null).t(bindingFlags, fieldInfo_3, obj2, (CultureInfo)(object)Class5.Default)).W((BindingFlags)Class5.Default, null, type, array2, (ParameterModifier[])(object)Class5.Default))).t(bindingFlags, (FieldInfo[])(object)Class5.Default, ((Class7)null).j((BindingFlags)Class5.Default, (MethodBase[])null, ref *(object[]*)Class5.Default, (ParameterModifier[])null, cultureInfo, string_3, out reference), cultureInfo), array, array2, parameterModifier_), (Type[])(object)Class5.Default, parameterModifier_);
				bindingFlags = default(BindingFlags);
				Class7 obj109 = (Class7)(object)class102.W((BindingFlags)class103.j(bindingFlags_82, methodBase_31, ref object_, null, cultureInfo_9, (string[])(object)((Class7)(object)((Class7)null).W(bindingFlags, propertyInfo_, (Type)null, (Type[])null, (ParameterModifier[])null)).j(bindingFlags, array, ref object_, null, null, null, out reference), out *(object*)null), propertyInfo_, null, null, parameterModifier_);
				Class7 class104 = @class;
				BindingFlags bindingFlags_84 = bindingFlags;
				PropertyInfo[] propertyInfo_7 = (PropertyInfo[])(object)((Class7)((Class7)null).t(obj2, type, cultureInfo)).t(bindingFlags, fieldInfo_3, null, cultureInfo);
				Class7 class105 = @class;
				BindingFlags bindingFlags_85 = bindingFlags;
				Class7 class106 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Qk7)((Class7)null).t(obj2, (Type)(object)((Class7)null).j(bindingFlags_80, methodBase_28, ref object_10, parameterModifier_, cultureInfo_7, (string[])(object)class97.j(bindingFlags_81, methodBase_29, ref *(object[]*)null, parameterModifier_, cultureInfo_8, string_3, out *(object*)class98.W((BindingFlags)class99.W(default(BindingFlags), propertyInfo_, (Type)class100.t(class101.j(default(BindingFlags), methodBase_30, ref object_, parameterModifier_, (CultureInfo)(object)obj109.j((BindingFlags)class104.W(bindingFlags_84, propertyInfo_7, (Type)(object)class105.t(bindingFlags_85, fieldInfo_3, class106.W(bindingFlags, propertyInfo_, type, array2, null), (CultureInfo)@class.t(obj2, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default)), array2, null), array, ref object_, null, cultureInfo, null, out reference), (string[])(object)Class5.Default, out reference), type, null), array2, null), null, (Type)(object)((Class7)@class.t(null, type, cultureInfo)).e(bindingFlags, array, array2, parameterModifier_), (Type[])(object)Class5.Default, parameterModifier_)), out reference), (CultureInfo)null);
				@struct = default(Struct1);
			}
			else
			{
				Class7 class107 = @class;
				BindingFlags bindingFlags_86 = (BindingFlags)Class5.Default;
				Class7 class108 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Qk7)(object)class107.j(bindingFlags_86, (MethodBase[])(object)class108.e(bindingFlags, array, null, (ParameterModifier[])(object)Class5.Default), ref object_, null, null, null, out *(object*)null);
				_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
			}
		}
		try
		{
			while (obj2 != null)
			{
				try
				{
					_ = (Struct1)Class5.Default;
				}
				catch
				{
					gClass = gClass;
					_ = (Struct2)Class5.Default;
					class31 = class31;
				}
			}
		}
		finally
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					class46 = null;
				}
				catch
				{
					_ = (Class10)(object)Class5.Default;
				}
			}
			goto IL_3d28;
		}
	}

	unsafe static void smethod_4()
	{
		Class7 @class = @class;
		@class = @class;
		Class7 class2 = @class;
		BindingFlags bindingFlags_ = (BindingFlags)Class5.Default;
		Class7 class3 = @class;
		BindingFlags bindingFlags = (BindingFlags)Class5.Default;
		BindingFlags bindingFlags_2 = bindingFlags;
		Class7 class4 = @class;
		BindingFlags bindingFlags_3 = (BindingFlags)Class5.Default;
		BindingFlags bindingFlags_4 = bindingFlags;
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_5 = bindingFlags;
		Class7 class5 = @class;
		BindingFlags bindingFlags_6 = bindingFlags;
		Type type_ = (Type)(object)Class5.Default;
		Type[] array = array;
		MethodBase[] methodBase_ = (MethodBase[])(object)((Class7)(object)((Class7)null).t(bindingFlags_5, (FieldInfo[])null, (object)class5.W(bindingFlags_6, null, type_, array, (ParameterModifier[])(object)Class5.Default), (CultureInfo)null)).W(default(BindingFlags), null, type_, array, null);
		Type[] type_2 = array;
		Class7 class6 = @class;
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_7 = bindingFlags;
		Class7 obj = (Class7)(object)Class5.Default;
		BindingFlags bindingFlags_8 = bindingFlags;
		BindingFlags bindingFlags_9 = bindingFlags;
		PropertyInfo[] array2 = array2;
		PropertyInfo[] propertyInfo_ = array2;
		Type[] type_3 = array;
		Class7 class7 = @class;
		BindingFlags bindingFlags_10 = bindingFlags;
		FieldInfo[] fieldInfo_ = (FieldInfo[])(object)@class.W(bindingFlags, (PropertyInfo[])@class.t(null, type_, null), type_, array, (ParameterModifier[])(object)Class5.Default);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object object_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo_);
		MethodBase[] methodBase_2 = (MethodBase[])(object)obj.W(bindingFlags_8, (PropertyInfo[])(object)((Class7)null).W(bindingFlags_9, propertyInfo_, type_, type_3, (ParameterModifier[])(object)class7.t(bindingFlags_10, fieldInfo_, @class.t(null, null, cultureInfo_), (CultureInfo)@class.t(object_, type_, cultureInfo_))), (Type)(object)Class5.Default, array, (ParameterModifier[])(object)Class5.Default);
		ParameterModifier[] parameterModifier_ = (ParameterModifier[])(object)class6.e(bindingFlags_7, methodBase_2, (Type[])(object)Class5.Default, null);
		object_ = ((Class7)null).e(bindingFlags_4, methodBase_, type_2, parameterModifier_);
		Class7 obj2 = (Class7)(object)class4.t(bindingFlags_3, null, object_, cultureInfo_);
		string[] string_ = (string[])(object)Class5.Default;
		ref object object_2 = ref *(object*)((Class7)(object)Class5.Default).e(default(BindingFlags), null, null, parameterModifier_);
		MethodBase[] methodBase_3 = (MethodBase[])(object)obj2.j(default(BindingFlags), methodBase_2, ref *(object[]*)null, null, null, string_, out object_2);
		ref object[] reference = ref reference;
		cultureInfo_ = (CultureInfo)(object)class3.j(bindingFlags_2, methodBase_3, ref reference, (ParameterModifier[])(object)Class5.Default, null, null, out object_2);
		_003CModule_003E _003CModule_003E = (_003CModule_003E)(object)class2.t(bindingFlags_, null, null, cultureInfo_);
		_003CModule_003E = _003CModule_003E;
		GClass1 obj3 = (GClass1)(object)Class5.Default;
		GClass1 gClass = (GClass1)(object)Class5.Default;
		gClass = obj3;
		Class7 class8 = @class;
		object object_3 = object_;
		Class7 class9 = @class;
		bindingFlags = default(BindingFlags);
		Struct1 obj4 = (Struct1)class8.t(object_3, type_, (CultureInfo)((Class7)(object)class9.e(bindingFlags, methodBase_2, array, null)).t(object_, type_, (CultureInfo)(object)@class.t((BindingFlags)Class5.Default, null, null, null)));
		Struct1 @struct = (Struct1)Class5.Default;
		@struct = obj4;
		Qk7 qk = null;
		qk = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint uIntPtr);
		try
		{
			_ = (Class4)(object)Class5.Default;
		}
		catch
		{
			uIntPtr = (UIntPtr)Class5.Default;
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				bindingFlags = default(BindingFlags);
				_ = (Class8)(object)((Class7)null).t(bindingFlags, fieldInfo_, object_, cultureInfo_);
			}
		}
		Class7 obj6;
		Class7 class10;
		ref object[] object_4;
		ParameterModifier[] parameterModifier_2;
		string[] string_2;
		Class7 obj7;
		do
		{
			nuint num = uIntPtr / (nuint)(UIntPtr)Class5.Default;
			UIntPtr num2 = (UIntPtr)@class.t(object_, type_, (CultureInfo)(object)((Class7)null).j(bindingFlags, methodBase_2, ref reference, (ParameterModifier[])null, cultureInfo_, (string[])null, out *(object*)@class.e(bindingFlags, methodBase_2, array, (ParameterModifier[])(object)Class5.Default)));
			uIntPtr = default(UIntPtr);
			checked
			{
				if (num + (unchecked((nuint)num2) - uIntPtr) + unchecked((nuint)(UIntPtr)@class.e(bindingFlags, methodBase_2, array, parameterModifier_)) == 0)
				{
				}
				obj6 = (Class7)(object)Class5.Default;
				class10 = @class;
			}
			object_4 = ref *(object[]*)Class5.Default;
			parameterModifier_2 = (ParameterModifier[])(object)Class5.Default;
			string_2 = (string[])(object)Class5.Default;
			obj7 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
		}
		while ((object)obj6.t((BindingFlags)class10.j(default(BindingFlags), methodBase_2, ref object_4, parameterModifier_2, null, string_2, out *(object*)obj7.j(bindingFlags, methodBase_2, ref *(object[]*)Class5.Default, parameterModifier_, null, string_, out *(object*)Class5.Default)), (FieldInfo[])(object)Class5.Default, object_, cultureInfo_) != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class5 class11);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			do
			{
				try
				{
					class11 = Class5.Default;
					class11 = null;
				}
				catch
				{
					_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
				}
			}
			while (object_ != null);
			goto IL_03dd;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class10 class12);
		try
		{
			class12 = null;
			class12 = class12;
		}
		catch
		{
			@class = @class;
		}
		finally
		{
			gClass = gClass;
			goto IL_03dd;
		}
		IL_20b4:
		Struct2 struct2 = struct2;
		uIntPtr = default(UIntPtr);
		checked
		{
			if (unchecked((nuint)default(UIntPtr)) + uIntPtr == 0)
			{
				try
				{
					_ = (Struct1)Class5.Default;
				}
				finally
				{
					goto IL_20de;
				}
			}
			goto IL_20de;
		}
		IL_303b:
		try
		{
		}
		catch
		{
			@struct = @struct;
		}
		while (@class.t(null, null, cultureInfo_) != null)
		{
			try
			{
				if (checked(uIntPtr - uIntPtr) == 0)
				{
					_ = (Class5)(object)@class.j(bindingFlags, methodBase_2, ref reference, parameterModifier_, cultureInfo_, string_, out object_2);
				}
				else
				{
					_ = (GClass2)(object)Class5.Default;
				}
			}
			catch
			{
				if ((UIntPtr)@class.t(object_, null, cultureInfo_) == (UIntPtr)(nuint)0u)
				{
					_ = (Qk7)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)null, (Type[])null, parameterModifier_);
					continue;
				}
				gClass = null;
				_ = (GClass3)(object)Class5.Default;
				gClass = gClass;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass2 gClass3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass3 gClass2);
		checked
		{
			nuint num3 = unchecked((nuint)(UIntPtr)Class5.Default) - (unchecked((nuint)(UIntPtr)Class5.Default) + unchecked((nuint)(UIntPtr)((Class7)null).t(object_, type_, cultureInfo_))) * unchecked((nuint)(UIntPtr)@class.j(bindingFlags, null, ref reference, parameterModifier_, (CultureInfo)((Class7)(object)Class5.Default).t(object_, type_, cultureInfo_), string_, out object_2));
			uIntPtr = default(UIntPtr);
			nuint num4 = uIntPtr - unchecked((nuint)(UIntPtr)@class.t(object_, type_, cultureInfo_)) + unchecked((nuint)(UIntPtr)Class5.Default) + uIntPtr * unchecked(unchecked((nuint)default(UIntPtr)) / checked(unchecked((nuint)default(UIntPtr)) * unchecked((nuint)(UIntPtr)Class5.Default)));
			uIntPtr = default(UIntPtr);
			if (num3 + (num4 - uIntPtr) + unchecked((nuint)(UIntPtr)Class5.Default) == 0)
			{
				Class7 class13 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_11 = bindingFlags;
				Class7 class14 = @class;
				unchecked
				{
					BindingFlags bindingFlags_12 = (BindingFlags)Class5.Default;
					PropertyInfo[] propertyInfo_2 = array2;
					Type type_4 = (Type)(object)@class.j((BindingFlags)((Class7)(object)((Class7)null).e((BindingFlags)Class5.Default, methodBase_2, array, (ParameterModifier[])(object)@class.j(bindingFlags, null, ref *(object[]*)@class.t(object_, type_, cultureInfo_), null, null, (string[])(object)Class5.Default, out *(object*)Class5.Default))).t(default(BindingFlags), fieldInfo_, object_, cultureInfo_), methodBase_2, ref reference, null, cultureInfo_, string_, out *(object*)null);
					Class7 class15 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class6)(object)class13.t(bindingFlags_11, (FieldInfo[])(object)class14.W(bindingFlags_12, propertyInfo_2, type_4, (Type[])(object)class15.t(bindingFlags, (FieldInfo[])(object)Class5.Default, object_, cultureInfo_), null), Class5.Default, (CultureInfo)(object)Class5.Default);
				}
			}
			if (uIntPtr == 0)
			{
				_ = (Class10)(object)Class5.Default;
			}
			else
			{
				gClass2 = null;
			}
			_ = (Class9)((Class7)(object)Class5.Default).t(null, null, null);
			_ = (GClass2)(object)Class5.Default;
			do
			{
				gClass3 = (GClass2)(object)Class5.Default;
			}
			while ((object)Class5.Default != null);
			uIntPtr = default(UIntPtr);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class4 class16);
		if (uIntPtr == 0)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				try
				{
					_ = (Struct1)Class5.Default;
				}
				finally
				{
					_ = (Class2)(object)@class.t((BindingFlags)Class5.Default, fieldInfo_, null, cultureInfo_);
					_ = (Class9)(object)((Class7)null).t((BindingFlags)Class5.Default, fieldInfo_, object_, (CultureInfo)null);
					class16 = class16;
					@struct = @struct;
					goto IL_330c;
				}
			}
		}
		goto IL_330c;
		IL_1b7a:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class8 class18);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class6 class17);
		try
		{
			if ((UIntPtr)@class.t(null, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default) == (UIntPtr)(nuint)0u)
			{
				class17 = class17;
			}
		}
		catch
		{
			try
			{
				class18 = class18;
			}
			finally
			{
				Class7 class19 = @class;
				Class7 class20 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_13 = (BindingFlags)class19.e((BindingFlags)class20.j(bindingFlags, methodBase_2, ref reference, (ParameterModifier[])(object)@class.e(bindingFlags, methodBase_2, array, null), cultureInfo_, string_, out object_2), methodBase_2, (Type[])(object)Class5.Default, parameterModifier_);
				object object_5 = Class5.Default;
				Class7 class21 = @class;
				BindingFlags bindingFlags_14 = bindingFlags;
				Class7 class22 = @class;
				Class7 obj12 = (Class7)@class.t(object_, (Type)(object)Class5.Default, cultureInfo_);
				Class7 class23 = @class;
				BindingFlags bindingFlags_15 = bindingFlags;
				MethodBase[] methodBase_4 = (MethodBase[])(object)@class.W(default(BindingFlags), array2, null, (Type[])(object)Class5.Default, parameterModifier_);
				ref object[] object_6 = ref reference;
				CultureInfo cultureInfo_2 = cultureInfo_;
				Class7 class24 = @class;
				bindingFlags = default(BindingFlags);
				ref object[] object_7 = ref *(object[]*)class22.j((BindingFlags)obj12.W((BindingFlags)class23.j(bindingFlags_15, methodBase_4, ref object_6, parameterModifier_, cultureInfo_2, (string[])(object)class24.W(bindingFlags, array2, type_, null, null), out *(object*)null), array2, (Type)(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array, parameterModifier_), array, parameterModifier_), methodBase_2, ref *(object[]*)null, parameterModifier_, cultureInfo_, null, out *(object*)null);
				CultureInfo cultureInfo_3 = cultureInfo_;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_16 = bindingFlags;
				PropertyInfo[] propertyInfo_3 = (PropertyInfo[])(object)@class.W((BindingFlags)@class.e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, array, (ParameterModifier[])(object)Class5.Default), null, type_, array, parameterModifier_);
				Type[] type_5 = (Type[])(object)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])null, type_, (Type[])(object)@class.W((BindingFlags)@class.e(bindingFlags, methodBase_2, null, (ParameterModifier[])@class.t(null, null, (CultureInfo)(object)Class5.Default)), null, (Type)(object)Class5.Default, array, parameterModifier_), parameterModifier_);
				Class7 class25 = @class;
				bindingFlags = default(BindingFlags);
				if ((UIntPtr)((Class7)null).t(bindingFlags_13, fieldInfo_, object_5, (CultureInfo)(object)class21.j(bindingFlags_14, methodBase_2, ref object_7, null, cultureInfo_3, (string[])(object)((Class7)null).W(bindingFlags_16, propertyInfo_3, type_, type_5, (ParameterModifier[])(object)class25.e(bindingFlags, (MethodBase[])(object)@class.j((BindingFlags)((Class7)null).t(object_, type_, (CultureInfo)(object)((Class7)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, array, (ParameterModifier[])(object)Class5.Default)).e(default(BindingFlags), methodBase_2, array, parameterModifier_)), methodBase_2, ref *(object[]*)null, parameterModifier_, null, string_, out object_2), array, parameterModifier_)), out *(object*)null)) == (UIntPtr)(nuint)0u)
				{
					_ = (GClass0)((Class7)null).t(@class.t(Class5.Default, type_, cultureInfo_), type_, cultureInfo_);
				}
				goto end_IL_1ba6;
			}
			end_IL_1ba6:;
		}
		Class7 class26 = @class;
		Class7 class27 = @class;
		bindingFlags = default(BindingFlags);
		if ((UIntPtr)class26.e(default(BindingFlags), methodBase_2, (Type[])(object)class27.t(bindingFlags, null, object_, null), parameterModifier_) == (UIntPtr)(nuint)0u)
		{
			if ((nuint)(UIntPtr)Class5.Default / uIntPtr == 0)
			{
				try
				{
					class12 = class12;
				}
				finally
				{
					_ = (Class4)(object)Class5.Default;
					goto IL_20b4;
				}
			}
			if ((UIntPtr)((Class7)null).t(bindingFlags, fieldInfo_, (object)null, (CultureInfo)(object)Class5.Default) == (UIntPtr)(nuint)0u)
			{
				@struct = default(Struct1);
				Class7 class28 = @class;
				BindingFlags bindingFlags_17 = bindingFlags;
				Class7 class29 = @class;
				PropertyInfo[] propertyInfo_4 = (PropertyInfo[])(object)@class.t(default(BindingFlags), fieldInfo_, object_, null);
				bindingFlags = default(BindingFlags);
				Class7 obj14 = (Class7)(object)((Class7)null).e(bindingFlags, methodBase_2, array, (ParameterModifier[])null);
				BindingFlags bindingFlags_18 = bindingFlags;
				Class7 class30 = @class;
				BindingFlags bindingFlags_19 = bindingFlags;
				ref object[] object_8 = ref *(object[]*)Class5.Default;
				Class7 obj15 = (Class7)(object)Class5.Default;
				Class7 class31 = @class;
				object object_9 = object_;
				Class7 class32 = @class;
				bindingFlags = default(BindingFlags);
				Class7 obj16 = (Class7)(object)class30.j(bindingFlags_19, null, ref object_8, null, (CultureInfo)(object)obj15.j(default(BindingFlags), methodBase_2, ref *(object[]*)class31.t(object_9, (Type)(object)class32.e(bindingFlags, null, array, parameterModifier_), cultureInfo_), null, null, string_, out *(object*)Class5.Default), string_, out *(object*)Class5.Default);
				Class7 obj17 = (Class7)(object)@class.t(bindingFlags, fieldInfo_, Class5.Default, (CultureInfo)(object)Class5.Default);
				BindingFlags bindingFlags_20 = (BindingFlags)Class5.Default;
				PropertyInfo[] propertyInfo_5 = array2;
				Class7 class33 = @class;
				bindingFlags = default(BindingFlags);
				Class7 obj18 = (Class7)(object)obj16.t((BindingFlags)obj17.W(bindingFlags_20, propertyInfo_5, type_, (Type[])((Class7)(object)((Class7)(object)class33.t(bindingFlags, (FieldInfo[])(object)Class5.Default, object_, cultureInfo_)).W(bindingFlags, array2, type_, null, (ParameterModifier[])(object)Class5.Default)).t(((Class7)(object)@class.t(default(BindingFlags), null, object_, null)).t(object_, null, cultureInfo_), type_, cultureInfo_), parameterModifier_), (FieldInfo[])(object)Class5.Default, object_, cultureInfo_);
				bindingFlags = default(BindingFlags);
				Type type_6 = (Type)(object)obj14.W(bindingFlags_18, (PropertyInfo[])((Class7)(object)obj18.W(bindingFlags, null, type_, null, parameterModifier_)).t(object_, type_, null), null, array, parameterModifier_);
				Class7 class34 = @class;
				BindingFlags bindingFlags_21 = bindingFlags;
				ref object[] object_10 = ref reference;
				bindingFlags = default(BindingFlags);
				_003CModule_003E = (_003CModule_003E)(object)class28.t(bindingFlags_17, null, class29.W(default(BindingFlags), propertyInfo_4, type_6, (Type[])(object)((Class7)(object)class34.j(bindingFlags_21, null, ref object_10, parameterModifier_, (CultureInfo)(object)((Class7)null).e(bindingFlags, methodBase_2, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default), (string[])(object)Class5.Default, out object_2)).e(bindingFlags, methodBase_2, null, null), parameterModifier_), null);
				Class2 class35 = null;
				gClass3 = (GClass2)(object)Class5.Default;
			}
		}
		goto IL_20b4;
		IL_2633:
		try
		{
			try
			{
				try
				{
					class16 = null;
					_ = (GClass3)(object)Class5.Default;
				}
				catch
				{
					_ = Class5.Default;
					_ = (_003CModule_003E)(object)Class5.Default;
					gClass3 = gClass3;
					Class7 class36 = @class;
					BindingFlags bindingFlags_22 = bindingFlags;
					Type[] type_7 = array;
					Class7 obj19 = (Class7)(object)((Class7)(object)Class5.Default).j(bindingFlags, methodBase_2, ref *(object[]*)null, null, cultureInfo_, null, out *(object*)null);
					bindingFlags = default(BindingFlags);
					class17 = (Class6)((Class7)(object)class36.e(bindingFlags_22, methodBase_2, type_7, (ParameterModifier[])(object)obj19.e(bindingFlags, null, array, (ParameterModifier[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)null, cultureInfo_)))).t(object_, null, null);
				}
			}
			catch
			{
				while (true)
				{
					Class7 class37 = @class;
					BindingFlags bindingFlags_23 = (BindingFlags)((Class7)null).j(bindingFlags, methodBase_2, ref reference, (ParameterModifier[])null, (CultureInfo)null, string_, out *(object*)null);
					object object_11 = Class5.Default;
					bindingFlags = default(BindingFlags);
					if ((object)class37.t(bindingFlags_23, null, object_11, (CultureInfo)(object)((Class7)null).t(bindingFlags, fieldInfo_, (object)null, cultureInfo_)) != null)
					{
						gClass = gClass;
						continue;
					}
					break;
				}
			}
		}
		catch
		{
			_ = (_003CModule_003E)(object)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])@class.t(null, (Type)(object)Class5.Default, (CultureInfo)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)(object)Class5.Default, array, parameterModifier_)), (object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type_, array, parameterModifier_), cultureInfo_);
		}
		while (object_ != null)
		{
			do
			{
				if (uIntPtr == 0)
				{
					_ = (Class4)(object)Class5.Default;
				}
			}
			while (object_ != null);
		}
		PropertyInfo[] propertyInfo_6 = (PropertyInfo[])(object)Class5.Default;
		Type[] type_8 = array;
		Class7 class38 = @class;
		bindingFlags = default(BindingFlags);
		_ = (Class0)(object)((Class7)null).W(default(BindingFlags), propertyInfo_6, type_, type_8, (ParameterModifier[])(object)class38.j(bindingFlags, methodBase_2, ref reference, parameterModifier_, cultureInfo_, string_, out *(object*)null));
		do
		{
			if (uIntPtr != 0)
			{
				try
				{
					bindingFlags = default(BindingFlags);
					_ = (Class10)(object)((Class7)null).t(bindingFlags, fieldInfo_, object_, (CultureInfo)(object)@class.t(bindingFlags, (FieldInfo[])((Class7)((Class7)(object)Class5.Default).t(object_, null, null)).t(object_, type_, cultureInfo_), object_, cultureInfo_));
					Class2 class35 = null;
					_ = Class5.Default;
				}
				finally
				{
					Class7 class39 = @class;
					Class7 obj23 = (Class7)(object)@class.j(bindingFlags, methodBase_2, ref *(object[]*)null, parameterModifier_, (CultureInfo)(object)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])null, type_, array, parameterModifier_), (string[])(object)Class5.Default, out object_2);
					bindingFlags = default(BindingFlags);
					_ = (GClass3)(object)class39.t((BindingFlags)obj23.e(bindingFlags, methodBase_2, null, null), fieldInfo_, object_, cultureInfo_);
					continue;
				}
			}
			while (object_ != null)
			{
				_ = (Class10)(object)((Class7)(object)Class5.Default).W(bindingFlags, null, (Type)(object)@class.e(bindingFlags, methodBase_2, array, null), array, parameterModifier_);
			}
		}
		while (object_ != null);
		try
		{
			Class7 class40 = @class;
			BindingFlags bindingFlags_24 = bindingFlags;
			Class7 obj24 = (Class7)(object)Class5.Default;
			Class7 obj25 = (Class7)(object)((Class7)null).e(default(BindingFlags), methodBase_2, array, parameterModifier_);
			object object_12 = Class5.Default;
			Class7 class41 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_25 = bindingFlags;
			PropertyInfo[] propertyInfo_7 = array2;
			Class7 obj26 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_26 = (BindingFlags)Class5.Default;
			PropertyInfo[] propertyInfo_8 = (PropertyInfo[])(object)((Class7)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type_, array, (ParameterModifier[])null)).t((BindingFlags)Class5.Default, fieldInfo_, object_, cultureInfo_);
			BindingFlags bindingFlags_27 = bindingFlags;
			ref object[] object_13 = ref *(object[]*)Class5.Default;
			CultureInfo cultureInfo_4 = cultureInfo_;
			Class7 class42 = @class;
			BindingFlags bindingFlags_28 = bindingFlags;
			Type[] type_9 = array;
			bindingFlags = default(BindingFlags);
			MethodBase[] methodBase_5 = (MethodBase[])(object)((Class7)(object)((Class7)null).t(default(BindingFlags), fieldInfo_, (object)null, (CultureInfo)((Class7)(object)obj25.e((BindingFlags)((Class7)null).t(object_12, (Type)(object)class41.W(bindingFlags_25, propertyInfo_7, type_, (Type[])(object)obj26.W(bindingFlags_26, propertyInfo_8, (Type)(object)((Class7)(object)((Class7)null).j(bindingFlags_27, methodBase_2, ref object_13, (ParameterModifier[])null, cultureInfo_4, (string[])(object)class42.e(bindingFlags_28, methodBase_2, type_9, (ParameterModifier[])(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default)), out object_2)).W(bindingFlags, null, type_, null, parameterModifier_), array, parameterModifier_), parameterModifier_), (CultureInfo)@class.t(object_, type_, null)), null, null, (ParameterModifier[])(object)Class5.Default)).t(object_, (Type)(object)Class5.Default, null))).j(bindingFlags, methodBase_2, ref reference, null, null, string_, out object_2);
			ref object[] object_14 = ref reference;
			bindingFlags = default(BindingFlags);
			_ = (Class7)(object)class40.t(bindingFlags_24, (FieldInfo[])(object)obj24.j(default(BindingFlags), methodBase_5, ref object_14, (ParameterModifier[])(object)((Class7)null).t(bindingFlags, fieldInfo_, (object)null, cultureInfo_), cultureInfo_, null, out object_2), ((Class7)(object)((Class7)null).W(bindingFlags, array2, type_, array, (ParameterModifier[])null)).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type_, null, parameterModifier_), cultureInfo_);
		}
		finally
		{
			bindingFlags = default(BindingFlags);
			_ = (GClass3)(object)((Class7)null).e(bindingFlags, methodBase_2, array, parameterModifier_);
			gClass = null;
			qk = qk;
			goto IL_2ad5;
		}
		IL_364e:
		class17 = class17;
		_ = (Class2)(object)Class5.Default;
		while ((object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array, null) != null)
		{
		}
		while (true)
		{
			Class7 class43 = @class;
			bindingFlags = default(BindingFlags);
			if ((object)class43.e(bindingFlags, methodBase_2, array, (ParameterModifier[])(object)Class5.Default) != null)
			{
				if (uIntPtr == 0)
				{
					Class7 class44 = @class;
					BindingFlags bindingFlags_29 = bindingFlags;
					Class7 class45 = @class;
					bindingFlags = default(BindingFlags);
					Class7 obj27 = (Class7)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, array, parameterModifier_);
					BindingFlags bindingFlags_30 = bindingFlags;
					Class7 obj28 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_31 = bindingFlags;
					Class7 class46 = @class;
					BindingFlags bindingFlags_32 = bindingFlags;
					Class7 obj29 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					gClass = (GClass1)(object)class44.j(bindingFlags_29, (MethodBase[])(object)((Class7)(object)class45.e(default(BindingFlags), (MethodBase[])(object)obj27.j(bindingFlags_30, methodBase_2, ref *(object[]*)((Class7)null).t((BindingFlags)obj28.e(bindingFlags_31, null, (Type[])(object)class46.e(bindingFlags_32, null, (Type[])(object)obj29.e(bindingFlags, methodBase_2, (Type[])(object)((Class7)(object)Class5.Default).W((BindingFlags)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type_, (Type[])(object)((Class7)(object)Class5.Default).j(bindingFlags, methodBase_2, ref reference, (ParameterModifier[])@class.t(@class.t(bindingFlags, fieldInfo_, object_, null), null, (CultureInfo)(object)Class5.Default), cultureInfo_, string_, out *(object*)null), parameterModifier_), array2, null, (Type[])(object)Class5.Default, null), parameterModifier_), parameterModifier_), parameterModifier_), (FieldInfo[])null, (object)Class5.Default, cultureInfo_), parameterModifier_, (CultureInfo)(object)Class5.Default, string_, out *(object*)@class.W(bindingFlags, null, type_, array, parameterModifier_)), array, (ParameterModifier[])(object)Class5.Default)).W(default(BindingFlags), null, type_, array, parameterModifier_), ref *(object[]*)null, parameterModifier_, null, null, out *(object*)null);
				}
			}
			else if (object_ == null)
			{
				break;
			}
		}
		class16 = (Class4)(object)Class5.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class0 class47);
		try
		{
			while (object_ != null)
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					class47 = null;
				}
			}
		}
		catch
		{
			uIntPtr = default(UIntPtr);
			checked
			{
				nuint num5 = unchecked((nuint)default(UIntPtr)) - (uIntPtr + unchecked(uIntPtr / uIntPtr));
				uIntPtr = default(UIntPtr);
				if (num5 - uIntPtr == 0)
				{
					if (uIntPtr == 0)
					{
						_ = Class5.Default;
					}
					else
					{
						class18 = (Class8)(object)Class5.Default;
					}
				}
				else
				{
					do
					{
						_ = (Qk7)(object)((Class7)null).t(bindingFlags, fieldInfo_, (object)null, cultureInfo_);
					}
					while (object_ != null);
				}
			}
		}
		class11 = class11;
		try
		{
			try
			{
				while ((object)Class5.Default != null)
				{
					_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
					class12 = class12;
				}
			}
			finally
			{
				_ = (Class10)(object)@class.t(bindingFlags, fieldInfo_, null, (CultureInfo)(object)Class5.Default);
				goto end_IL_38ab;
			}
			end_IL_38ab:;
		}
		catch
		{
			_ = (GClass2)(object)Class5.Default;
		}
		try
		{
			_ = (GClass3)(object)Class5.Default;
		}
		catch
		{
			_ = (Class6)(object)@class.j(bindingFlags, null, ref reference, null, cultureInfo_, (string[])@class.t(object_, type_, (CultureInfo)(object)Class5.Default), out *(object*)@class.W(bindingFlags, array2, (Type)(object)@class.W((BindingFlags)((Class7)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference, parameterModifier_, (CultureInfo)null, string_, out object_2)).t(bindingFlags, fieldInfo_, object_, cultureInfo_), array2, type_, array, parameterModifier_), null, parameterModifier_));
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class9 class48);
		try
		{
			try
			{
				class48 = class48;
			}
			finally
			{
				nuint num6 = uIntPtr;
				uIntPtr = default(UIntPtr);
				if (checked(num6 * uIntPtr) == 0)
				{
					gClass2 = gClass2;
					_ = (Class2)(object)Class5.Default;
					Class2 class35 = null;
					_ = (Class2)(object)Class5.Default;
				}
				else
				{
					_ = (Class5)(object)@class.j(bindingFlags, (MethodBase[])(object)@class.j(bindingFlags, methodBase_2, ref reference, (ParameterModifier[])(object)Class5.Default, null, string_, out *(object*)Class5.Default), ref reference, parameterModifier_, null, null, out object_2);
				}
				goto end_IL_397f;
			}
			end_IL_397f:;
		}
		catch
		{
			if (uIntPtr == 0)
			{
				do
				{
					@class = (Class7)(object)@class.t(bindingFlags, null, null, (CultureInfo)(object)Class5.Default);
				}
				while (object_ != null);
			}
		}
		qk = qk;
		_003CModule_003E = null;
		_ = (Qk7)(object)Class5.Default;
		checked
		{
			if (uIntPtr + unchecked((nuint)(UIntPtr)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type_, array, (ParameterModifier[])(object)@class.e(bindingFlags, methodBase_2, (Type[])(object)Class5.Default, parameterModifier_))) == 0)
			{
				qk = qk;
			}
			while (object_ != null)
			{
				qk = null;
				class18 = null;
			}
			try
			{
				class11 = null;
				return;
			}
			catch
			{
				while (object_ != null)
				{
					UIntPtr num7 = unchecked((UIntPtr)Class5.Default);
					uIntPtr = default(UIntPtr);
					if (unchecked((nuint)num7) + unchecked(uIntPtr / uIntPtr) == 0)
					{
						class12 = null;
					}
				}
				return;
			}
		}
		IL_22c0:
		_003CModule_003E = _003CModule_003E;
		_ = (GClass3)(object)Class5.Default;
		_ = (Class8)@class.t(((Class7)null).W(bindingFlags, (PropertyInfo[])(object)((Class7)null).t(bindingFlags, fieldInfo_, (object)((Class7)(object)Class5.Default).e(bindingFlags, null, array, null), cultureInfo_), type_, (Type[])null, parameterModifier_), (Type)(object)Class5.Default, (CultureInfo)(object)@class.t(bindingFlags, fieldInfo_, @class.j((BindingFlags)Class5.Default, null, ref reference, parameterModifier_, (CultureInfo)(object)Class5.Default, null, out *(object*)null), (CultureInfo)(object)Class5.Default));
		if (uIntPtr == 0)
		{
			while (object_ != null)
			{
				if (uIntPtr == 0)
				{
					Class7 class49 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class6)(object)class49.j(bindingFlags, methodBase_2, ref reference, parameterModifier_, cultureInfo_, string_, out *(object*)Class5.Default);
				}
			}
		}
		gClass3 = gClass3;
		try
		{
			try
			{
				try
				{
					class48 = null;
					_ = (Qk7)((Class7)(object)((Class7)null).e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, array, parameterModifier_)).t(null, type_, (CultureInfo)(object)Class5.Default);
					_ = (Qk7)(object)Class5.Default;
				}
				finally
				{
					qk = null;
					goto end_IL_2397;
				}
				end_IL_2397:;
			}
			finally
			{
				struct2 = (Struct2)Class5.Default;
				goto end_IL_2396;
			}
			end_IL_2396:;
		}
		finally
		{
			try
			{
				_ = (Class2)(object)Class5.Default;
			}
			catch
			{
				class11 = Class5.Default;
			}
			finally
			{
				Class7 obj36 = (Class7)(object)((Class7)null).t(bindingFlags, fieldInfo_, (object)Class5.Default, (CultureInfo)null);
				bindingFlags = default(BindingFlags);
				_ = (_003CModule_003E)(object)obj36.j(bindingFlags, methodBase_2, ref reference, parameterModifier_, null, null, out *(object*)Class5.Default);
				goto IL_245b;
			}
		}
		IL_03dd:
		_ = (GClass2)(object)Class5.Default;
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			checked
			{
				if (unchecked((nuint)default(UIntPtr)) - (unchecked((nuint)(UIntPtr)((Class7)@class.t(Class5.Default, (Type)(object)Class5.Default, null)).t(@class.t(object_, (Type)(object)((Class7)null).e(bindingFlags, methodBase_2, array, (ParameterModifier[])(object)Class5.Default), null), (Type)(object)Class5.Default, cultureInfo_)) + unchecked((nuint)(UIntPtr)@class.j(bindingFlags, methodBase_2, ref *(object[]*)@class.W(bindingFlags, null, (Type)((Class7)null).t(object_, (Type)null, (CultureInfo)(object)Class5.Default), array, null), parameterModifier_, cultureInfo_, (string[])(object)Class5.Default, out *(object*)null) / (nuint)(UIntPtr)Class5.Default)) == 0)
				{
					Class9 obj37 = (Class9)@class.t(object_, type_, cultureInfo_);
					class48 = class48;
					class48 = obj37;
				}
				else
				{
					_ = (Class0)(object)Class5.Default;
				}
			}
		}
		while (true)
		{
			if (@class.t(object_, type_, cultureInfo_) != null)
			{
				class11 = class11;
				_ = (Struct1)Class5.Default;
				gClass2 = gClass2;
			}
			else if (object_ == null)
			{
				break;
			}
		}
		class48 = null;
		try
		{
			class48 = (Class9)(object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, parameterModifier_, (CultureInfo)((Class7)(object)Class5.Default).t(Class5.Default, null, cultureInfo_), null, out *(object*)null);
		}
		catch
		{
			_ = (Struct1)Class5.Default;
		}
		finally
		{
			if ((UIntPtr)@class.j(bindingFlags, methodBase_2, ref *(object[]*)null, null, cultureInfo_, null, out *(object*)Class5.Default) == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Qk7)@class.t(Class5.Default, (Type)(object)((Class7)(object)Class5.Default).e(default(BindingFlags), methodBase_2, array, (ParameterModifier[])(object)@class.j(default(BindingFlags), (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)Class5.Default, cultureInfo_, string_, out object_2)), (CultureInfo)@class.t(null, null, null));
					class18 = null;
					class18 = class18;
				}
				catch
				{
					gClass2 = (GClass3)(object)Class5.Default;
				}
			}
			goto IL_0613;
		}
		IL_2da5:
		if (checked(unchecked((nuint)(UIntPtr)((Class7)(object)Class5.Default).W(bindingFlags, array2, type_, null, (ParameterModifier[])(object)Class5.Default)) * unchecked((nuint)(UIntPtr)((Class7)null).t((object)null, (Type)null, cultureInfo_))) == 0)
		{
			try
			{
				try
				{
					_ = (Struct2)((Class7)@class.t(object_, null, (CultureInfo)(object)Class5.Default)).t(bindingFlags, null, null, null);
				}
				catch
				{
					_ = (GClass1)(object)Class5.Default;
				}
			}
			catch
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					Class7 class50 = @class;
					object object_15 = object_;
					Class7 class51 = @class;
					BindingFlags bindingFlags_33 = bindingFlags;
					Class7 obj41 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (GClass0)class50.t(object_15, (Type)(object)class51.t(bindingFlags_33, fieldInfo_, ((Class7)(object)obj41.W(bindingFlags, array2, (Type)(object)Class5.Default, (Type[])(object)Class5.Default, parameterModifier_)).t(null, null, (CultureInfo)(object)((Class7)(object)((Class7)null).e(bindingFlags, methodBase_2, array, parameterModifier_)).e((BindingFlags)Class5.Default, (MethodBase[])(object)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, null, (Type[])(object)@class.j(bindingFlags, null, ref *(object[]*)Class5.Default, parameterModifier_, cultureInfo_, (string[])(object)@class.W(bindingFlags, array2, null, array, parameterModifier_), out *(object*)@class.W((BindingFlags)((Class7)(object)Class5.Default).t(null, type_, cultureInfo_), array2, type_, null, null)), null), array, parameterModifier_)), cultureInfo_), null);
				}
			}
		}
		try
		{
			try
			{
				_ = (Class6)(object)@class.e(bindingFlags, methodBase_2, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
			}
			catch
			{
				BindingFlags bindingFlags_34 = bindingFlags;
				ref object[] object_16 = ref reference;
				CultureInfo cultureInfo_5 = cultureInfo_;
				bindingFlags = default(BindingFlags);
				_ = (GClass3)(object)((Class7)null).j(bindingFlags_34, methodBase_2, ref object_16, (ParameterModifier[])null, cultureInfo_5, (string[])(object)((Class7)null).e(bindingFlags, (MethodBase[])((Class7)(object)Class5.Default).t(object_, type_, cultureInfo_), array, (ParameterModifier[])null), out *(object*)null);
			}
			finally
			{
				try
				{
					class48 = class48;
				}
				finally
				{
					class48 = (Class9)(object)@class.t((BindingFlags)Class5.Default, null, object_, null);
					_ = (Class6)(object)Class5.Default;
					goto end_IL_2f2a;
				}
			}
			end_IL_2f2a:;
		}
		finally
		{
			try
			{
				while ((object)Class5.Default != null)
				{
					gClass2 = gClass2;
				}
			}
			catch
			{
				try
				{
					class47 = class47;
					class47 = null;
					class18 = null;
				}
				catch
				{
					gClass2 = (GClass3)((Class7)null).t((object)null, type_, cultureInfo_);
					_ = (_003CModule_003E)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)(object)@class.W(bindingFlags, null, type_, null, (ParameterModifier[])(object)Class5.Default), array, parameterModifier_);
				}
			}
			goto IL_303b;
		}
		IL_0d98:
		try
		{
			if (uIntPtr == 0)
			{
				class48 = (Class9)(object)Class5.Default;
			}
		}
		catch
		{
			_ = (GClass2)(object)Class5.Default;
		}
		try
		{
			_ = (Class0)(object)Class5.Default;
		}
		finally
		{
			uIntPtr = default(UIntPtr);
			nuint num8 = unchecked((nuint)default(UIntPtr)) / uIntPtr;
			Class7 class52 = @class;
			BindingFlags bindingFlags_35 = bindingFlags;
			object object_17 = ((Class7)null).t(object_, (Type)null, (CultureInfo)null);
			Class7 class53 = @class;
			BindingFlags bindingFlags_36 = bindingFlags;
			PropertyInfo[] propertyInfo_9 = array2;
			Class7 class54 = @class;
			BindingFlags bindingFlags_37 = bindingFlags;
			Class7 class55 = @class;
			BindingFlags bindingFlags_38 = (BindingFlags)@class.t(bindingFlags, null, object_, (CultureInfo)(object)Class5.Default);
			Type[] type_10 = array;
			Class7 obj47 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			MethodBase[] methodBase_6 = (MethodBase[])(object)((Class7)null).W((BindingFlags)class55.e(bindingFlags_38, null, type_10, (ParameterModifier[])(object)obj47.e(bindingFlags, methodBase_2, (Type[])(object)Class5.Default, parameterModifier_)), (PropertyInfo[])(object)@class.j((BindingFlags)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, null, null, cultureInfo_), (MethodBase[])(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, (Type[])(object)Class5.Default, null), ref reference, null, null, string_, out *(object*)null), type_, array, parameterModifier_);
			Class7 obj48 = (Class7)(object)((Class7)(object)Class5.Default).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, parameterModifier_, cultureInfo_, string_, out *(object*)null);
			bindingFlags = default(BindingFlags);
			if (checked(num8 * unchecked((nuint)(UIntPtr)class52.t(bindingFlags_35, fieldInfo_, object_17, (CultureInfo)(object)class53.W(bindingFlags_36, propertyInfo_9, (Type)(object)class54.e(bindingFlags_37, methodBase_6, (Type[])(object)obj48.e(bindingFlags, (MethodBase[])(object)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, null, object_, cultureInfo_), array, (ParameterModifier[])(object)Class5.Default), parameterModifier_), array, null)))) == 0)
			{
				Class7 class56;
				Class7 obj49;
				BindingFlags bindingFlags_39;
				PropertyInfo[] propertyInfo_10;
				Class7 class57;
				do
				{
					qk = qk;
					class56 = @class;
					obj49 = (Class7)(object)Class5.Default;
					bindingFlags_39 = (BindingFlags)Class5.Default;
					propertyInfo_10 = array2;
					class57 = @class;
					bindingFlags = default(BindingFlags);
				}
				while ((object)class56.e((BindingFlags)obj49.W(bindingFlags_39, propertyInfo_10, (Type)(object)class57.e(bindingFlags, methodBase_2, array, parameterModifier_), (Type[])((Class7)(object)((Class7)(object)@class.t(bindingFlags, fieldInfo_, null, (CultureInfo)(object)((Class7)(object)((Class7)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)(object)Class5.Default, array, parameterModifier_)).e(bindingFlags, (MethodBase[])@class.t(null, type_, null), array, null)).j((BindingFlags)Class5.Default, methodBase_2, ref *(object[]*)null, parameterModifier_, (CultureInfo)(object)Class5.Default, string_, out object_2))).t(bindingFlags, null, object_, cultureInfo_)).t(null, null, cultureInfo_), parameterModifier_), methodBase_2, null, null) != null);
			}
			else
			{
				struct2 = struct2;
			}
			goto IL_1026;
		}
		IL_245b:
		class48 = null;
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			while (object_ != null)
			{
				_ = (Class0)(object)Class5.Default;
			}
		}
		while (object_ != null)
		{
			while ((object)Class5.Default != null)
			{
				try
				{
					_ = (Class8)(object)Class5.Default;
				}
				finally
				{
					_ = (Class0)(object)Class5.Default;
					Class7 class58 = @class;
					BindingFlags bindingFlags_40 = bindingFlags;
					ref object[] object_18 = ref *(object[]*)Class5.Default;
					bindingFlags = default(BindingFlags);
					Class7 obj50 = (Class7)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)@class.e((BindingFlags)@class.W((BindingFlags)((Class7)null).e(bindingFlags, (MethodBase[])null, array, parameterModifier_), (PropertyInfo[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type_, array, parameterModifier_), (Type)(object)Class5.Default, (Type[])(object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, parameterModifier_, cultureInfo_, null, out object_2), parameterModifier_), (MethodBase[])(object)Class5.Default, array, (ParameterModifier[])(object)@class.j(bindingFlags, methodBase_2, ref *(object[]*)null, null, null, string_, out object_2)), type_, array, parameterModifier_);
					bindingFlags = default(BindingFlags);
					_ = (GClass3)(object)class58.j(bindingFlags_40, methodBase_2, ref object_18, (ParameterModifier[])(object)obj50.t((BindingFlags)((Class7)null).t(bindingFlags, fieldInfo_, (object)null, cultureInfo_), fieldInfo_, object_, cultureInfo_), (CultureInfo)(object)((Class7)(object)Class5.Default).j(bindingFlags, null, ref *(object[]*)null, parameterModifier_, cultureInfo_, string_, out *(object*)null), string_, out *(object*)null);
					class11 = null;
					continue;
				}
			}
		}
		try
		{
			if (default(UIntPtr) != (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Class10)(object)Class5.Default;
					_ = (GClass1)(object)Class5.Default;
					_ = (Qk7)(object)Class5.Default;
					struct2 = struct2;
				}
				finally
				{
					_ = (Class6)(object)Class5.Default;
					goto end_IL_25b4;
				}
			}
			_ = (GClass1)(object)@class.W(bindingFlags, array2, null, array, null);
			end_IL_25b4:;
		}
		finally
		{
			checked
			{
				nuint num9 = unchecked((nuint)(UIntPtr)Class5.Default) + unchecked((nuint)(UIntPtr)Class5.Default);
				uIntPtr = default(UIntPtr);
				if (num9 - uIntPtr == 0)
				{
					gClass = gClass;
				}
				goto IL_2633;
			}
		}
		IL_11f4:
		if (uIntPtr == 0)
		{
			_ = (Struct2)Class5.Default;
		}
		while ((object)Class5.Default != null)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				class18 = (Class8)(object)((Class7)(object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, parameterModifier_, cultureInfo_, string_, out *(object*)Class5.Default)).t((BindingFlags)((Class7)null).t((object)null, type_, cultureInfo_), fieldInfo_, object_, null);
				_ = (Struct2)Class5.Default;
			}
		}
		do
		{
			try
			{
				try
				{
					_003CModule_003E = (_003CModule_003E)(object)((Class7)(object)@class.t(bindingFlags, null, object_, null)).j(bindingFlags, methodBase_2, ref *(object[]*)null, parameterModifier_, cultureInfo_, string_, out *(object*)null);
				}
				finally
				{
					_ = (Class7)(object)Class5.Default;
					goto end_IL_1270;
				}
				end_IL_1270:;
			}
			catch
			{
				Class7 class59;
				do
				{
					_ = (GClass1)(object)((Class7)(object)@class.t((BindingFlags)Class5.Default, fieldInfo_, object_, cultureInfo_)).t(default(BindingFlags), fieldInfo_, object_, null);
					class59 = @class;
					bindingFlags = default(BindingFlags);
				}
				while ((object)class59.W(bindingFlags, array2, (Type)(object)Class5.Default, array, (ParameterModifier[])(object)Class5.Default) != null);
			}
		}
		while (object_ != null);
		Class7 class60 = @class;
		BindingFlags bindingFlags_41 = (BindingFlags)((Class7)(object)Class5.Default).t(bindingFlags, (FieldInfo[])(object)Class5.Default, Class5.Default, cultureInfo_);
		FieldInfo[] fieldInfo_2 = (FieldInfo[])(object)@class.t(bindingFlags, fieldInfo_, object_, cultureInfo_);
		object object_19 = @class.e(bindingFlags, null, array, parameterModifier_);
		Class7 class61 = @class;
		BindingFlags bindingFlags_42 = bindingFlags;
		Class7 class62 = @class;
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_43 = bindingFlags;
		PropertyInfo[] propertyInfo_11 = (PropertyInfo[])(object)Class5.Default;
		BindingFlags bindingFlags_44 = bindingFlags;
		PropertyInfo[] propertyInfo_12 = array2;
		Type[] type_11 = array;
		bindingFlags = default(BindingFlags);
		_ = (GClass2)(object)class60.t(bindingFlags_41, fieldInfo_2, object_19, (CultureInfo)(object)class61.j(bindingFlags_42, (MethodBase[])(object)class62.W(bindingFlags_43, propertyInfo_11, type_, null, (ParameterModifier[])(object)((Class7)null).W(bindingFlags_44, propertyInfo_12, type_, type_11, (ParameterModifier[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, (object)Class5.Default, (CultureInfo)(object)((Class7)(object)Class5.Default).e(bindingFlags, methodBase_2, (Type[])(object)Class5.Default, parameterModifier_)))), ref reference, (ParameterModifier[])(object)@class.e((BindingFlags)@class.t(Class5.Default, (Type)(object)Class5.Default, cultureInfo_), null, array, (ParameterModifier[])(object)Class5.Default), cultureInfo_, (string[])(object)Class5.Default, out *(object*)((Class7)(object)Class5.Default).t(bindingFlags, fieldInfo_, object_, null)));
		checked
		{
			try
			{
				try
				{
					Class7 class63 = @class;
					object object_20 = object_;
					Class7 obj52 = (Class7)(object)@class.e(bindingFlags, methodBase_2, array, parameterModifier_);
					bindingFlags = default(BindingFlags);
					_ = (Class7)class63.t(object_20, type_, (CultureInfo)(object)obj52.W(bindingFlags, null, type_, array, parameterModifier_));
				}
				catch
				{
					_ = (Struct2)Class5.Default;
				}
			}
			catch
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr * unchecked((nuint)(UIntPtr)Class5.Default) == 0)
				{
					_ = Class5.Default;
				}
			}
			try
			{
				try
				{
					while (object_ != null)
					{
						class16 = null;
						class16 = null;
					}
				}
				catch
				{
					uIntPtr = default(UIntPtr);
					if (uIntPtr == 0)
					{
						_ = (Struct1)Class5.Default;
						bindingFlags = default(BindingFlags);
						class47 = (Class0)(object)((Class7)null).e(bindingFlags, methodBase_2, array, (ParameterModifier[])(object)Class5.Default);
						class47 = class47;
						class12 = null;
					}
					else
					{
						Class7 class64 = @class;
						bindingFlags = default(BindingFlags);
						_ = (Class10)(object)class64.t(bindingFlags, fieldInfo_, object_, (CultureInfo)(object)((Class7)@class.t(null, null, cultureInfo_)).W(bindingFlags, (PropertyInfo[])(object)((Class7)(object)Class5.Default).W(bindingFlags, null, type_, array, null), type_, array, (ParameterModifier[])(object)Class5.Default));
					}
				}
			}
			catch
			{
				gClass = gClass;
				_ = (GClass0)(object)Class5.Default;
				_ = (GClass0)@class.t(Class5.Default, type_, null);
				_ = (GClass1)(object)Class5.Default;
			}
			try
			{
				do
				{
					uIntPtr = default(UIntPtr);
					if (uIntPtr * uIntPtr + uIntPtr == 0)
					{
						_003CModule_003E = _003CModule_003E;
						_ = (Struct1)((Class7)(object)Class5.Default).t(bindingFlags, fieldInfo_, object_, (CultureInfo)(object)Class5.Default);
						_ = (GClass1)((Class7)null).t((object)Class5.Default, (Type)(object)@class.W(bindingFlags, array2, type_, null, parameterModifier_), (CultureInfo)null);
					}
				}
				while ((object)Class5.Default != null);
			}
			finally
			{
				_ = (GClass2)(object)Class5.Default;
				goto IL_1635;
			}
		}
		IL_33e9:
		try
		{
			try
			{
				if ((nuint)(UIntPtr)Class5.Default / uIntPtr == 0)
				{
					class16 = null;
				}
			}
			catch
			{
				try
				{
					Class7 class65 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class0)(object)class65.W((BindingFlags)((Class7)null).e(bindingFlags, methodBase_2, (Type[])(object)@class.t(bindingFlags, null, object_, null), (ParameterModifier[])null), array2, type_, null, null);
					_ = (_003CModule_003E)(object)@class.W(bindingFlags, array2, type_, array, (ParameterModifier[])(object)Class5.Default);
				}
				finally
				{
					_ = (GClass2)@class.t(null, null, null);
					qk = null;
					goto end_IL_33ff;
				}
				end_IL_33ff:;
			}
		}
		catch
		{
			if (uIntPtr == 0)
			{
				UIntPtr num10 = (UIntPtr)Class5.Default;
				uIntPtr = default(UIntPtr);
				checked
				{
					if (unchecked((nuint)num10) - uIntPtr == 0)
					{
						_ = (_003CModule_003E)(object)@class.e(default(BindingFlags), methodBase_2, null, parameterModifier_);
					}
					else
					{
						@class = @class;
					}
				}
			}
		}
		class11 = class11;
		bindingFlags = default(BindingFlags);
		_ = (Class2)(object)((Class7)null).j(bindingFlags, methodBase_2, ref *(object[]*)null, parameterModifier_, cultureInfo_, (string[])null, out object_2);
		gClass2 = null;
		_ = (Class2)(object)@class.t(bindingFlags, (FieldInfo[])(object)@class.t(bindingFlags, null, object_, cultureInfo_), object_, null);
		class12 = class12;
		if (uIntPtr == 0)
		{
			while (object_ != null)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					gClass3 = gClass3;
				}
				else
				{
					_ = (Class4)(object)@class.t(default(BindingFlags), fieldInfo_, object_, (CultureInfo)(object)Class5.Default);
				}
			}
		}
		else
		{
			gClass = gClass;
		}
		nuint num11 = uIntPtr;
		nuint num13;
		Class7 obj59;
		checked
		{
			nuint num12 = uIntPtr - unchecked((nuint)(UIntPtr)Class5.Default / unchecked((nuint)default(UIntPtr)));
			uIntPtr = default(UIntPtr);
			num13 = unchecked(num12 / uIntPtr) - uIntPtr;
			obj59 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
		}
		if (num11 / checked(num13 + unchecked((nuint)(UIntPtr)obj59.j(bindingFlags, null, ref reference, parameterModifier_, cultureInfo_, null, out object_2))) == 0)
		{
			_ = (GClass1)(object)Class5.Default;
			_ = (GClass0)(object)Class5.Default;
			_ = (Struct2)@class.W(bindingFlags, array2, null, array, (ParameterModifier[])(object)((Class7)(object)@class.W(bindingFlags, array2, null, null, (ParameterModifier[])((Class7)null).t(object_, (Type)null, (CultureInfo)null))).e(bindingFlags, (MethodBase[])(object)Class5.Default, array, null));
		}
		while ((object)Class5.Default != null)
		{
			qk = (Qk7)(object)Class5.Default;
		}
		try
		{
			while (object_ != null)
			{
				try
				{
					_ = (Class9)(object)Class5.Default;
					class11 = class11;
				}
				finally
				{
					Class7 class66 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class8)(object)class66.j(bindingFlags, methodBase_2, ref reference, null, cultureInfo_, string_, out object_2);
					continue;
				}
			}
		}
		finally
		{
			class18 = (Class8)(object)Class5.Default;
			goto IL_364e;
		}
		IL_1026:
		do
		{
			_ = (Qk7)(object)Class5.Default;
		}
		while ((object)Class5.Default != null || object_ != null);
		_ = (Class9)(object)((Class7)null).j(bindingFlags, methodBase_2, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)Class5.Default, (string[])null, out *(object*)null);
		do
		{
			@class = @class;
		}
		while (object_ != null || (object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type_, (Type[])null, (ParameterModifier[])null) != null);
		_ = (GClass3)(object)@class.t(bindingFlags, (FieldInfo[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])@class.t(object_, type_, cultureInfo_), (Type)(object)Class5.Default, (Type[])null, parameterModifier_), object_, (CultureInfo)(object)Class5.Default);
		@class = (Class7)(object)((Class7)(object)@class.j((BindingFlags)Class5.Default, methodBase_2, ref reference, parameterModifier_, cultureInfo_, string_, out object_2)).t(bindingFlags, null, null, (CultureInfo)(object)@class.e(bindingFlags, null, null, parameterModifier_));
		if ((UIntPtr)@class.t(bindingFlags, null, object_, (CultureInfo)(object)Class5.Default) == (UIntPtr)(nuint)0u)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				try
				{
					Class7 class67 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class4)(object)class67.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, parameterModifier_, null, string_, out *(object*)((Class7)null).t((object)@class.j(bindingFlags, (MethodBase[])(object)((Class7)(object)@class.e(bindingFlags, methodBase_2, array, null)).W(bindingFlags, array2, type_, null, null), ref reference, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)@class.W((BindingFlags)Class5.Default, array2, (Type)(object)Class5.Default, (Type[])(object)Class5.Default, (ParameterModifier[])(object)@class.W(bindingFlags, null, type_, null, parameterModifier_)), null, out object_2), type_, cultureInfo_));
				}
				finally
				{
					_ = (_003CModule_003E)(object)Class5.Default;
					_ = (Class10)(object)Class5.Default;
					goto IL_11f4;
				}
			}
		}
		goto IL_11f4;
		IL_0613:
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Class2 class35);
			while ((object)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, null, (Type)(object)Class5.Default, null, parameterModifier_) != null)
			{
				try
				{
					Class2 obj60 = (Class2)(object)Class5.Default;
					class35 = class35;
					class35 = obj60;
				}
				catch
				{
					_ = (GClass3)(object)Class5.Default;
				}
			}
		}
		finally
		{
			while (true)
			{
				Class7 class68 = @class;
				bindingFlags = default(BindingFlags);
				if ((object)class68.e(bindingFlags, null, array, parameterModifier_) != null)
				{
					try
					{
						Class2 class35 = null;
					}
					catch
					{
						qk = (Qk7)@class.t(Class5.Default, null, (CultureInfo)(object)@class.j(bindingFlags, methodBase_2, ref reference, parameterModifier_, cultureInfo_, string_, out object_2));
					}
					continue;
				}
				break;
			}
			goto IL_06c0;
		}
		IL_06c0:
		try
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				while (object_ != null)
				{
					Class7 class69 = @class;
					BindingFlags bindingFlags_45 = (BindingFlags)Class5.Default;
					FieldInfo[] fieldInfo_3 = (FieldInfo[])(object)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, object_, (CultureInfo)null);
					Class7 class70 = @class;
					BindingFlags bindingFlags_46 = bindingFlags;
					bindingFlags = default(BindingFlags);
					_ = (Struct2)((Class7)(object)class69.W((BindingFlags)((Class7)null).t(bindingFlags_45, fieldInfo_3, (object)null, (CultureInfo)(object)class70.W(bindingFlags_46, (PropertyInfo[])(object)((Class7)null).W((BindingFlags)((Class7)null).e((BindingFlags)((Class7)null).t(bindingFlags, (FieldInfo[])(object)((Class7)(object)Class5.Default).W(bindingFlags, array2, null, null, parameterModifier_), object_, cultureInfo_), methodBase_2, array, (ParameterModifier[])(object)Class5.Default), array2, (Type)(object)Class5.Default, (Type[])null, parameterModifier_), (Type)(object)@class.W(bindingFlags, null, (Type)(object)Class5.Default, null, parameterModifier_), (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default)), array2, type_, (Type[])(object)Class5.Default, null)).t(bindingFlags, null, object_, cultureInfo_);
				}
			}
			else
			{
				while (object_ != null)
				{
					_ = (Class10)(object)Class5.Default;
				}
			}
		}
		finally
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (_003CModule_003E)(object)((Class7)null).W(bindingFlags, array2, type_, (Type[])null, (ParameterModifier[])null);
			}
			goto IL_0851;
		}
		IL_0851:
		do
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				Class7 class71 = @class;
				BindingFlags bindingFlags_47 = bindingFlags;
				Type[] type_12 = array;
				Class7 class72 = @class;
				bindingFlags = default(BindingFlags);
				_ = (_003CModule_003E)(object)class71.W(bindingFlags_47, null, null, type_12, (ParameterModifier[])(object)class72.W(bindingFlags, array2, type_, array, parameterModifier_));
			}
		}
		while ((object)@class.t(bindingFlags, fieldInfo_, object_, null) != null);
		if (uIntPtr == 0)
		{
			gClass2 = gClass2;
		}
		else
		{
			do
			{
				class11 = Class5.Default;
				class12 = class12;
			}
			while (object_ != null || object_ != null);
		}
		if (uIntPtr == 0)
		{
			try
			{
				try
				{
					Class7 obj63 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_48 = bindingFlags;
					Class7 class73 = @class;
					bindingFlags = default(BindingFlags);
					struct2 = (Struct2)obj63.t(bindingFlags_48, (FieldInfo[])(object)class73.W(bindingFlags, array2, null, array, null), null, (CultureInfo)(object)Class5.Default);
					struct2 = default(Struct2);
					struct2 = struct2;
				}
				finally
				{
					gClass2 = gClass2;
					_ = (Qk7)(object)@class.e(bindingFlags, methodBase_2, null, null);
					class11 = null;
					_ = (Class6)(object)@class.j((BindingFlags)Class5.Default, null, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)@class.e(bindingFlags, null, null, parameterModifier_), (CultureInfo)(object)((Class7)(object)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])(object)Class5.Default, type_, (Type[])null, parameterModifier_)).j(bindingFlags, methodBase_2, ref reference, parameterModifier_, cultureInfo_, (string[])@class.t(null, (Type)(object)Class5.Default, null), out *(object*)null), null, out *(object*)null);
					goto end_IL_088a;
				}
				end_IL_088a:;
			}
			finally
			{
				gClass2 = (GClass3)(object)Class5.Default;
				goto IL_0b1e;
			}
		}
		try
		{
			if ((UIntPtr)@class.t(((Class7)null).e(bindingFlags, methodBase_2, array, parameterModifier_), type_, (CultureInfo)(object)@class.j(bindingFlags, methodBase_2, ref *(object[]*)null, parameterModifier_, cultureInfo_, (string[])(object)Class5.Default, out object_2)) == (UIntPtr)(nuint)0u)
			{
				gClass2 = (GClass3)(object)Class5.Default;
			}
			else
			{
				qk = null;
			}
		}
		catch
		{
			try
			{
				Class7 obj64 = (Class7)(object)((Class7)null).W(bindingFlags, array2, (Type)null, array, (ParameterModifier[])(object)@class.t(bindingFlags, (FieldInfo[])(object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, parameterModifier_, cultureInfo_, (string[])(object)Class5.Default, out *(object*)Class5.Default), null, cultureInfo_));
				Class7 class74 = @class;
				BindingFlags bindingFlags_49 = (BindingFlags)@class.e(bindingFlags, methodBase_2, array, null);
				Class7 obj65 = (Class7)@class.t(null, type_, cultureInfo_);
				BindingFlags bindingFlags_50 = bindingFlags;
				ref object[] object_21 = ref reference;
				ParameterModifier[] parameterModifier_3 = (ParameterModifier[])(object)Class5.Default;
				Class7 obj66 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_51 = bindingFlags;
				Type[] type_13 = array;
				Class7 class75 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class5)(object)obj64.W((BindingFlags)class74.j(bindingFlags_49, methodBase_2, ref *(object[]*)null, parameterModifier_, null, (string[])(object)obj65.j(bindingFlags_50, null, ref object_21, parameterModifier_3, (CultureInfo)(object)obj66.e(bindingFlags_51, methodBase_2, type_13, (ParameterModifier[])(object)class75.j(bindingFlags, methodBase_2, ref *(object[]*)null, (ParameterModifier[])(object)@class.j(bindingFlags, methodBase_2, ref reference, parameterModifier_, (CultureInfo)(object)Class5.Default, null, out object_2), (CultureInfo)(object)@class.j(bindingFlags, methodBase_2, ref reference, (ParameterModifier[])(object)Class5.Default, null, null, out object_2), string_, out *(object*)Class5.Default)), (string[])(object)Class5.Default, out object_2), out object_2), (PropertyInfo[])(object)Class5.Default, type_, null, parameterModifier_);
			}
			catch
			{
				class18 = class18;
			}
		}
		goto IL_0b1e;
		IL_2d19:
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				Class2 class35 = null;
				class12 = null;
				_ = (Struct2)Class5.Default;
				_ = (Class9)(object)@class.e(bindingFlags, null, (Type[])(object)Class5.Default, parameterModifier_);
			}
		}
		catch
		{
			struct2 = struct2;
		}
		finally
		{
			class17 = class17;
			_ = (GClass1)@class.t(null, type_, cultureInfo_);
			_ = (_003CModule_003E)(object)Class5.Default;
			goto IL_2d7e;
		}
		IL_2ad5:
		@class = (Class7)(object)Class5.Default;
		_ = (GClass3)(object)Class5.Default;
		_ = (GClass2)(object)((Class7)null).W(bindingFlags, array2, type_, (Type[])(object)Class5.Default, (ParameterModifier[])null);
		do
		{
			nuint num14 = uIntPtr;
			uIntPtr = default(UIntPtr);
			if (checked(num14 + uIntPtr) / uIntPtr != 0)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					BindingFlags bindingFlags_52 = bindingFlags;
					PropertyInfo[] propertyInfo_13 = array2;
					Type[] type_14 = array;
					Class7 obj70 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_53 = bindingFlags;
					Class7 class76 = @class;
					BindingFlags bindingFlags_54 = (BindingFlags)Class5.Default;
					Class7 class77 = @class;
					bindingFlags = default(BindingFlags);
					class47 = (Class0)(object)((Class7)null).W(bindingFlags_52, propertyInfo_13, (Type)null, type_14, (ParameterModifier[])(object)obj70.W(bindingFlags_53, (PropertyInfo[])(object)class76.j(default(BindingFlags), methodBase_2, ref *(object[]*)((Class7)null).t(bindingFlags_54, (FieldInfo[])(object)class77.t(bindingFlags, fieldInfo_, null, null), (object)((Class7)null).W(bindingFlags, (PropertyInfo[])@class.t(((Class7)(object)Class5.Default).t(object_, null, null), null, (CultureInfo)(object)Class5.Default), type_, array, parameterModifier_), cultureInfo_), parameterModifier_, null, (string[])(object)Class5.Default, out object_2), type_, array, parameterModifier_));
				}
			}
			else if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Class9)(object)Class5.Default;
			}
			else
			{
				gClass = gClass;
			}
		}
		while ((object)Class5.Default != null);
		try
		{
			try
			{
				_ = (Class2)(object)Class5.Default;
				class11 = class11;
				class11 = Class5.Default;
			}
			catch
			{
				struct2 = struct2;
			}
		}
		catch
		{
			try
			{
				Class2 class35 = (Class2)(object)Class5.Default;
			}
			catch
			{
				struct2 = default(Struct2);
				struct2 = struct2;
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
				do
				{
					_ = (Class2)(object)((Class7)null).t((BindingFlags)((Class7)null).t((object)null, (Type)(object)Class5.Default, cultureInfo_), (FieldInfo[])@class.t(object_, type_, cultureInfo_), object_, cultureInfo_);
				}
				while (object_ != null);
			}
			goto IL_2cb5;
		}
		IL_2cb5:
		try
		{
			do
			{
				bindingFlags = default(BindingFlags);
				_ = (_003CModule_003E)(object)((Class7)null).j(bindingFlags, methodBase_2, ref reference, parameterModifier_, cultureInfo_, string_, out object_2);
			}
			while ((object)Class5.Default != null || object_ != null);
		}
		finally
		{
			try
			{
				_ = (Class7)(object)Class5.Default;
			}
			catch
			{
				do
				{
					class11 = Class5.Default;
				}
				while ((object)Class5.Default != null);
			}
			goto IL_2d19;
		}
		IL_2139:
		do
		{
			_ = (Class9)(object)Class5.Default;
		}
		while (object_ != null);
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			_003CModule_003E = _003CModule_003E;
			_ = (Struct2)Class5.Default;
		}
		else
		{
			try
			{
				try
				{
					_ = (Qk7)(object)Class5.Default;
				}
				finally
				{
					_ = (GClass2)@class.t(object_, type_, cultureInfo_);
					goto end_IL_2169;
				}
				end_IL_2169:;
			}
			catch
			{
				if (uIntPtr / uIntPtr == 0)
				{
					qk = qk;
				}
				else
				{
					class47 = class47;
					_ = (Struct2)Class5.Default;
					gClass = gClass;
					_ = (Class9)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)null, (ParameterModifier[])null, (CultureInfo)(object)@class.t(bindingFlags, null, object_, (CultureInfo)((Class7)null).t((object)Class5.Default, type_, (CultureInfo)(object)Class5.Default)), (string[])(object)Class5.Default, out object_2);
				}
			}
		}
		qk = qk;
		class11 = null;
		_ = (GClass0)(object)@class.j(bindingFlags, methodBase_2, ref *(object[]*)null, parameterModifier_, cultureInfo_, (string[])(object)Class5.Default, out object_2);
		do
		{
			try
			{
				try
				{
					_ = (GClass0)(object)Class5.Default;
				}
				catch
				{
					class48 = class48;
				}
			}
			catch
			{
				class18 = null;
				_ = (Qk7)(object)Class5.Default;
			}
			bindingFlags = default(BindingFlags);
		}
		while ((object)((Class7)null).t(bindingFlags, (FieldInfo[])null, object_, (CultureInfo)(object)((Class7)null).e((BindingFlags)Class5.Default, methodBase_2, array, (ParameterModifier[])(object)Class5.Default)) != null);
		try
		{
			_ = (Struct2)@class.t(object_, type_, null);
		}
		finally
		{
			_ = (Class9)(object)Class5.Default;
			_ = (Class6)(object)@class.t((BindingFlags)Class5.Default, fieldInfo_, object_, cultureInfo_);
			goto IL_22c0;
		}
		IL_2d7e:
		gClass2 = (GClass3)(object)Class5.Default;
		try
		{
			_ = (Struct2)Class5.Default;
		}
		finally
		{
			gClass3 = (GClass2)(object)Class5.Default;
			goto IL_2da5;
		}
		IL_330c:
		class16 = (Class4)(object)Class5.Default;
		try
		{
			if ((UIntPtr)((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])(object)Class5.Default, array, parameterModifier_) == (UIntPtr)(nuint)0u)
			{
				class48 = class48;
			}
			else
			{
				@class = (Class7)((Class7)(object)@class.j(bindingFlags, null, ref *(object[]*)null, parameterModifier_, null, string_, out object_2)).t(object_, type_, cultureInfo_);
			}
		}
		catch
		{
			try
			{
				struct2 = default(Struct2);
				struct2 = struct2;
			}
			catch
			{
				@struct = default(Struct1);
				_ = (Class2)(object)((Class7)null).t((BindingFlags)Class5.Default, fieldInfo_, (object)null, (CultureInfo)(object)Class5.Default);
				struct2 = struct2;
			}
		}
		finally
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					class12 = class12;
				}
			}
			finally
			{
				do
				{
					class48 = class48;
					_ = (GClass1)(object)Class5.Default;
					_ = (Class9)(object)Class5.Default;
				}
				while (object_ != null);
				goto IL_33e9;
			}
		}
		IL_20de:
		gClass3 = gClass3;
		while ((object)@class.t(bindingFlags, fieldInfo_, object_, null) != null)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				_ = (Class0)(object)Class5.Default;
			}
			else
			{
				class17 = class17;
			}
		}
		try
		{
			_ = (GClass0)(object)Class5.Default;
		}
		catch
		{
			class17 = class17;
		}
		finally
		{
			class48 = (Class9)(object)Class5.Default;
			goto IL_2139;
		}
		IL_1635:
		try
		{
			_ = (Class4)(object)Class5.Default;
		}
		catch
		{
			_003CModule_003E = _003CModule_003E;
		}
		finally
		{
			goto IL_164f;
		}
		IL_164f:
		Class7 class80;
		object object_22;
		Class7 class81;
		BindingFlags bindingFlags_56;
		Class7 obj86;
		BindingFlags bindingFlags_57;
		Class7 obj87;
		checked
		{
			try
			{
				Class7 class78 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_55 = bindingFlags;
				Class7 class79 = @class;
				bindingFlags = default(BindingFlags);
				if (unchecked((UIntPtr)class78.e(bindingFlags_55, methodBase_2, null, (ParameterModifier[])(object)class79.e(bindingFlags, null, array, parameterModifier_)) == (UIntPtr)(nuint)0u))
				{
					uIntPtr = default(UIntPtr);
					nuint num15 = uIntPtr;
					uIntPtr = default(UIntPtr);
					if (num15 + uIntPtr == 0)
					{
						_ = (Class8)(object)Class5.Default;
					}
				}
				else
				{
					try
					{
						@struct = default(Struct1);
						@struct = @struct;
					}
					catch
					{
						gClass2 = null;
					}
				}
			}
			catch
			{
				try
				{
					do
					{
						class16 = class16;
					}
					while ((object)Class5.Default != null);
				}
				catch
				{
					nuint num16 = uIntPtr;
					uIntPtr = default(UIntPtr);
					if (num16 - uIntPtr == 0)
					{
						_ = (Qk7)(object)Class5.Default;
					}
					else
					{
						class48 = null;
					}
				}
			}
			_ = (GClass3)(object)@class.e(bindingFlags, methodBase_2, array, null);
			class16 = class16;
			_ = (Class4)(object)Class5.Default;
			_ = (Struct1)Class5.Default;
			class11 = class11;
			_ = (Class2)@class.t(object_, type_, cultureInfo_);
			do
			{
				_ = (GClass2)(object)Class5.Default;
			}
			while (object_ != null);
			while (object_ != null)
			{
				_ = (Class9)(object)((Class7)null).t(bindingFlags, fieldInfo_, object_, (CultureInfo)(object)Class5.Default);
				class17 = null;
				class17 = null;
				_ = (Class2)(object)Class5.Default;
			}
			if (uIntPtr - unchecked((nuint)default(UIntPtr)) != 0)
			{
				_ = (GClass0)(object)@class.j(default(BindingFlags), methodBase_2, ref reference, null, null, (string[])(object)Class5.Default, out object_2);
			}
			class12 = class12;
			_ = (Class9)(object)Class5.Default;
			class12 = (Class10)(object)Class5.Default;
			_003CModule_003E = _003CModule_003E;
			class80 = @class;
			object_22 = object_;
			class81 = @class;
			bindingFlags = default(BindingFlags);
			bindingFlags_56 = bindingFlags;
			obj86 = (Class7)(object)Class5.Default;
			bindingFlags_57 = bindingFlags;
			obj87 = (Class7)(object)Class5.Default;
		}
		BindingFlags bindingFlags_58 = (BindingFlags)@class.t(bindingFlags, fieldInfo_, object_, null);
		Type[] type_15 = array;
		Class7 class82 = @class;
		Class7 class83 = @class;
		bindingFlags = default(BindingFlags);
		ref object[] object_23 = ref *(object[]*)obj87.e(bindingFlags_58, methodBase_2, type_15, (ParameterModifier[])(object)class82.e(default(BindingFlags), methodBase_2, (Type[])(object)class83.t(bindingFlags, (FieldInfo[])(object)((Class7)null).t(bindingFlags, fieldInfo_, (object)null, cultureInfo_), object_, null), null));
		ParameterModifier[] parameterModifier_4 = (ParameterModifier[])(object)Class5.Default;
		Class7 class84 = @class;
		Class7 class85 = @class;
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_59 = bindingFlags;
		PropertyInfo[] propertyInfo_14 = array2;
		Class7 class86 = @class;
		BindingFlags bindingFlags_60 = (BindingFlags)((Class7)null).e(bindingFlags, methodBase_2, (Type[])null, parameterModifier_);
		ref object[] object_24 = ref reference;
		ParameterModifier[] parameterModifier_5 = (ParameterModifier[])(object)Class5.Default;
		CultureInfo cultureInfo_6 = cultureInfo_;
		Class7 class87 = @class;
		ref object[] object_25 = ref reference;
		Class7 obj88 = (Class7)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_61 = bindingFlags;
		Class7 obj89 = (Class7)(object)@class.e((BindingFlags)Class5.Default, methodBase_2, array, parameterModifier_);
		BindingFlags bindingFlags_62 = bindingFlags;
		PropertyInfo[] propertyInfo_15 = array2;
		Class7 class88 = @class;
		BindingFlags bindingFlags_63 = (BindingFlags)@class.t(null, type_, cultureInfo_);
		Class7 obj90 = (Class7)(object)((Class7)(object)((Class7)null).j(bindingFlags, methodBase_2, ref reference, parameterModifier_, cultureInfo_, (string[])(object)Class5.Default, out *(object*)null)).j((BindingFlags)((Class7)(object)Class5.Default).W(default(BindingFlags), array2, type_, null, null), methodBase_2, ref reference, parameterModifier_, (CultureInfo)(object)Class5.Default, string_, out object_2);
		Type type_16 = (Type)(object)Class5.Default;
		Type[] type_17 = array;
		Class7 class89 = @class;
		BindingFlags bindingFlags_64 = (BindingFlags)Class5.Default;
		object object_26 = Class5.Default;
		Class7 class90 = @class;
		bindingFlags = default(BindingFlags);
		_ = (GClass2)class80.t(object_22, type_, (CultureInfo)(object)class81.e(bindingFlags_56, methodBase_2, null, (ParameterModifier[])(object)obj86.j(bindingFlags_57, methodBase_2, ref object_23, parameterModifier_4, null, (string[])class84.t(class85.W(bindingFlags_59, propertyInfo_14, (Type)(object)((Class7)null).W((BindingFlags)class86.j(bindingFlags_60, methodBase_2, ref object_24, parameterModifier_5, cultureInfo_6, (string[])(object)class87.j(default(BindingFlags), methodBase_2, ref object_25, (ParameterModifier[])(object)obj88.e(bindingFlags_61, null, null, (ParameterModifier[])(object)obj89.W(bindingFlags_62, propertyInfo_15, type_, (Type[])(object)class88.e(bindingFlags_63, (MethodBase[])((Class7)(object)obj90.W(default(BindingFlags), null, type_16, type_17, (ParameterModifier[])(object)class89.j(default(BindingFlags), (MethodBase[])(object)((Class7)null).t(bindingFlags_64, fieldInfo_, object_26, (CultureInfo)(object)class90.j(bindingFlags, null, ref *(object[]*)null, parameterModifier_, cultureInfo_, string_, out object_2)), ref *(object[]*)null, parameterModifier_, null, null, out object_2))).t(object_, null, (CultureInfo)(object)Class5.Default), null, parameterModifier_), (ParameterModifier[])(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, null))), null, null, out object_2), out *(object*)Class5.Default), array2, type_, array, (ParameterModifier[])null), null, parameterModifier_), null, cultureInfo_), out *(object*)null)));
		if (checked(unchecked((nuint)default(UIntPtr)) + unchecked((nuint)default(UIntPtr))) == 0 && default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			class18 = class18;
		}
		try
		{
			while (object_ != null)
			{
				if ((UIntPtr)((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])(object)@class.j(bindingFlags, methodBase_2, ref reference, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)Class5.Default, string_, out *(object*)((Class7)null).t((object)null, (Type)null, cultureInfo_)), (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default) == (UIntPtr)(nuint)0u)
				{
					qk = qk;
					_ = (GClass3)(object)@class.W(bindingFlags, array2, null, array, (ParameterModifier[])(object)Class5.Default);
					_ = (Class6)(object)Class5.Default;
				}
				else
				{
					_ = (Qk7)(object)@class.W(bindingFlags, array2, type_, array, null);
				}
			}
		}
		finally
		{
			uIntPtr = default(UIntPtr);
			if (checked(uIntPtr - uIntPtr) == 0)
			{
				while ((object)Class5.Default != null)
				{
					@struct = @struct;
				}
			}
			else if (uIntPtr == 0)
			{
				gClass3 = null;
				_ = (GClass3)(object)Class5.Default;
			}
			goto IL_1b7a;
		}
		IL_0b1e:
		try
		{
			bindingFlags = default(BindingFlags);
			gClass3 = (GClass2)(object)((Class7)null).W(bindingFlags, array2, type_, array, parameterModifier_);
			gClass3 = gClass3;
		}
		finally
		{
			while (object_ != null)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (Class9)(object)Class5.Default;
					continue;
				}
				Class7 class91 = @class;
				BindingFlags bindingFlags_65 = (BindingFlags)@class.t(null, type_, cultureInfo_);
				FieldInfo[] fieldInfo_4 = (FieldInfo[])(object)Class5.Default;
				Class7 obj91 = (Class7)(object)@class.e((BindingFlags)Class5.Default, null, null, null);
				BindingFlags bindingFlags_66 = bindingFlags;
				Class7 class92 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class5)((Class7)(object)class91.t(bindingFlags_65, fieldInfo_4, obj91.e(bindingFlags_66, (MethodBase[])(object)class92.t(bindingFlags, null, Class5.Default, cultureInfo_), (Type[])(object)Class5.Default, parameterModifier_), (CultureInfo)(object)Class5.Default)).t(null, type_, cultureInfo_);
			}
			goto IL_0c0e;
		}
		IL_0c0e:
		while (object_ != null)
		{
			qk = (Qk7)@class.t(object_, null, cultureInfo_);
		}
		if ((nuint)(UIntPtr)@class.W(bindingFlags, array2, type_, array, parameterModifier_) / uIntPtr == 0)
		{
			if (uIntPtr == 0)
			{
				gClass3 = gClass3;
			}
			else
			{
				_003CModule_003E = _003CModule_003E;
			}
		}
		gClass2 = (GClass3)(object)Class5.Default;
		if (uIntPtr == 0)
		{
			try
			{
				gClass2 = gClass2;
			}
			finally
			{
				if (checked(unchecked((nuint)(UIntPtr)Class5.Default) + unchecked((nuint)(UIntPtr)((Class7)null).e(bindingFlags, methodBase_2, array, parameterModifier_))) == 0)
				{
					_ = (Class8)(object)((Class7)null).j(bindingFlags, methodBase_2, ref *(object[]*)null, parameterModifier_, (CultureInfo)null, string_, out *(object*)Class5.Default);
				}
				else
				{
					_ = (Struct1)@class.t(bindingFlags, (FieldInfo[])(object)((Class7)(object)((Class7)(object)Class5.Default).W(bindingFlags, array2, type_, (Type[])(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type_, array, (ParameterModifier[])(object)@class.W(bindingFlags, (PropertyInfo[])(object)@class.e((BindingFlags)Class5.Default, (MethodBase[])(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, Class5.Default, cultureInfo_), array, (ParameterModifier[])(object)Class5.Default), type_, null, (ParameterModifier[])(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])(object)Class5.Default, parameterModifier_))), parameterModifier_)).e((BindingFlags)@class.e((BindingFlags)@class.W((BindingFlags)((Class7)null).t((object)null, (Type)null, (CultureInfo)(object)Class5.Default), null, (Type)(object)Class5.Default, null, null), null, array, parameterModifier_), methodBase_2, array, parameterModifier_), Class5.Default, cultureInfo_);
				}
				goto IL_0d98;
			}
		}
		goto IL_0d98;
	}

	unsafe static void smethod_5()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] array2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type_2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] methodBase_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class7 @class);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags);
		try
		{
		}
		catch
		{
			do
			{
				Class7 class2 = @class;
				BindingFlags bindingFlags_ = bindingFlags;
				Class7 class3 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_2 = bindingFlags;
				array = array;
				Type[] type_ = array;
				array2 = array2;
				obj = class2.W(bindingFlags_, null, type_2, (Type[])(object)class3.e(bindingFlags_2, methodBase_, type_, array2), array2);
			}
			while (obj != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass3 gClass);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct2 @struct);
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				@struct = default(Struct2);
				@struct = @struct;
				@struct = default(Struct2);
				@struct = @struct;
			}
			catch
			{
				GClass3 obj3 = (GClass3)(object)Class5.Default;
				gClass = gClass;
				gClass = obj3;
			}
			finally
			{
				_ = (GClass1)(object)Class5.Default;
				goto IL_06f7;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out FieldInfo[] fieldInfo_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object[] reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object reference2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string[] string_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] array3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class10 class20);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class0 class18);
		nuint num2;
		try
		{
			UIntPtr num = (UIntPtr)Class5.Default;
			num2 = default(UIntPtr);
			num2 = checked(num2 + (num2 + num2 - num2));
			if (checked(unchecked((nuint)num) + num2) == 0)
			{
				Class7 class4 = @class;
				BindingFlags bindingFlags_3 = (BindingFlags)Class5.Default;
				MethodBase[] methodBase_2 = (MethodBase[])(object)((Class7)null).t(bindingFlags, fieldInfo_, obj, cultureInfo_);
				Class7 class5 = @class;
				Class7 class6 = @class;
				bindingFlags = default(BindingFlags);
				Class7 obj5 = (Class7)class5.t(((Class7)(object)class6.e(bindingFlags, null, array, array2)).t(bindingFlags, null, obj, cultureInfo_), type_2, (CultureInfo)(object)Class5.Default);
				BindingFlags bindingFlags_4 = bindingFlags;
				Type[] type_3 = array;
				Class7 class7 = @class;
				BindingFlags bindingFlags_5 = bindingFlags;
				Class7 class8 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_6 = bindingFlags;
				Class7 obj6 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_7 = bindingFlags;
				reference = ref *(object[]*)null;
				ref object[] object_ = ref reference;
				ParameterModifier[] parameterModifier_ = (ParameterModifier[])(object)@class.t((BindingFlags)Class5.Default, null, null, cultureInfo_);
				reference2 = ref reference2;
				_ = (Class7)(object)class4.e(bindingFlags_3, methodBase_2, (Type[])(object)obj5.e(bindingFlags_4, methodBase_, type_3, (ParameterModifier[])(object)class7.t(bindingFlags_5, fieldInfo_, class8.j(bindingFlags_6, (MethodBase[])(object)obj6.j(bindingFlags_7, methodBase_, ref object_, parameterModifier_, cultureInfo_, null, out reference2), ref *(object[]*)null, array2, cultureInfo_, (string[])(object)@class.j(bindingFlags, methodBase_, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo_, (string[])(object)Class5.Default, out reference2), out reference2), cultureInfo_)), array2);
			}
			else
			{
				Class7 class9 = @class;
				BindingFlags bindingFlags_8 = bindingFlags;
				Class7 class10 = @class;
				BindingFlags bindingFlags_9 = bindingFlags;
				Class7 class11 = @class;
				object object_2 = obj;
				Class7 class12 = @class;
				BindingFlags bindingFlags_10 = bindingFlags;
				ref object[] object_3 = ref *(object[]*)Class5.Default;
				Class7 class13 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_11 = bindingFlags;
				Class7 class14 = @class;
				BindingFlags bindingFlags_12 = (BindingFlags)Class5.Default;
				ref object[] object_4 = ref *(object[]*)@class.W((BindingFlags)Class5.Default, (PropertyInfo[])(object)Class5.Default, (Type)(object)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, null, (Type[])(object)Class5.Default, array2), null, array2);
				ParameterModifier[] parameterModifier_2 = (ParameterModifier[])(object)((Class7)(object)Class5.Default).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, cultureInfo_);
				Class7 obj7 = (Class7)(object)Class5.Default;
				Class7 class15 = @class;
				bindingFlags = default(BindingFlags);
				PropertyInfo[] propertyInfo_ = (PropertyInfo[])(object)class14.j(bindingFlags_12, methodBase_, ref object_4, parameterModifier_2, cultureInfo_, string_, out *(object*)obj7.j((BindingFlags)class15.e(default(BindingFlags), (MethodBase[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)@class.t(bindingFlags, null, obj, cultureInfo_), obj, cultureInfo_), (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default), null, ref reference, null, null, string_, out *(object*)@class.e(bindingFlags, null, (Type[])(object)Class5.Default, array2)));
				Type type_4 = (Type)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				ParameterModifier[] parameterModifier_3 = (ParameterModifier[])(object)class13.W(bindingFlags_11, propertyInfo_, type_4, null, (ParameterModifier[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, cultureInfo_));
				Class7 obj8 = (Class7)(object)((Class7)null).e(bindingFlags, methodBase_, array, array2);
				Class7 class16 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_13 = (BindingFlags)class16.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type_2, null, (ParameterModifier[])(object)((Class7)null).t(bindingFlags, fieldInfo_, obj, cultureInfo_));
				array3 = null;
				FieldInfo[] fieldInfo_2 = (FieldInfo[])class11.t(object_2, (Type)(object)((Class7)(object)((Class7)(object)class12.j(bindingFlags_10, methodBase_, ref object_3, parameterModifier_3, cultureInfo_, string_, out *(object*)obj8.W(bindingFlags_13, array3, (Type)(object)Class5.Default, array, null))).W((BindingFlags)Class5.Default, array3, type_2, array, null)).e(bindingFlags, (MethodBase[])(object)Class5.Default, array, array2), null);
				object object_5 = @class.e(bindingFlags, methodBase_, (Type[])(object)Class5.Default, array2);
				object object_6 = Class5.Default;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_14 = bindingFlags;
				FieldInfo[] fieldInfo_3 = (FieldInfo[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)null, array, (ParameterModifier[])null);
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_15 = bindingFlags;
				object object_7 = obj;
				Class7 class17 = @class;
				BindingFlags bindingFlags_16 = bindingFlags;
				bindingFlags = default(BindingFlags);
				Class0 obj9 = (Class0)(object)((Class7)(object)class9.j(bindingFlags_8, (MethodBase[])(object)class10.t(bindingFlags_9, fieldInfo_2, object_5, (CultureInfo)((Class7)null).t(object_6, (Type)(object)((Class7)null).e(default(BindingFlags), (MethodBase[])(object)((Class7)null).t(bindingFlags_14, fieldInfo_3, (object)((Class7)null).t(bindingFlags_15, fieldInfo_, object_7, (CultureInfo)(object)((Class7)(object)class17.W(bindingFlags_16, null, (Type)(object)((Class7)null).j(bindingFlags, methodBase_, ref *(object[]*)null, array2, (CultureInfo)null, (string[])null, out *(object*)null), array, (ParameterModifier[])(object)Class5.Default)).W(bindingFlags, array3, (Type)(object)Class5.Default, array, (ParameterModifier[])(object)Class5.Default)), (CultureInfo)(object)((Class7)(object)Class5.Default).e(bindingFlags, null, null, null)), array, array2), cultureInfo_)), ref *(object[]*)null, array2, null, string_, out *(object*)null)).e(default(BindingFlags), methodBase_, null, array2);
				class18 = class18;
				class18 = obj9;
			}
		}
		finally
		{
			do
			{
				Class7 class19 = @class;
				bindingFlags = default(BindingFlags);
				Class10 obj10 = (Class10)(object)class19.W(bindingFlags, null, type_2, array, array2);
				class20 = (Class10)(object)Class5.Default;
				class20 = obj10;
			}
			while (obj != null);
			goto IL_06f7;
		}
		IL_2fc8:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class4 class23);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class9 class22);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class8 class21);
		try
		{
			while (obj != null)
			{
				try
				{
					class21 = class21;
				}
				finally
				{
					class22 = null;
					continue;
				}
			}
		}
		catch
		{
			try
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					class23 = null;
				}
				else
				{
					class22 = (Class9)(object)Class5.Default;
				}
			}
			finally
			{
				@class = @class;
				class18 = null;
				goto end_IL_2fe6;
			}
			end_IL_2fe6:;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct1 struct2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass0 gClass2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass1 gClass3);
		try
		{
			if (num2 == 0)
			{
				if (num2 == 0)
				{
					_ = (Class9)(object)Class5.Default;
				}
			}
			else
			{
				try
				{
					bindingFlags = default(BindingFlags);
					_ = (Struct1)((Class7)null).e(bindingFlags, methodBase_, (Type[])(object)Class5.Default, array2);
					struct2 = default(Struct1);
					struct2 = struct2;
					Class7 class24 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_17 = bindingFlags;
					PropertyInfo[] propertyInfo_2 = array3;
					bindingFlags = default(BindingFlags);
					Class7 obj12 = (Class7)(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)@class.e(bindingFlags, (MethodBase[])(object)@class.t(bindingFlags, fieldInfo_, obj, cultureInfo_), null, null), obj, cultureInfo_);
					bindingFlags = default(BindingFlags);
					_ = (Struct1)class24.W(bindingFlags_17, propertyInfo_2, (Type)(object)obj12.W(bindingFlags, null, type_2, array, null), (Type[])(object)((Class7)null).W(bindingFlags, array3, (Type)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)(object)Class5.Default, array, (ParameterModifier[])null), array, array2), array2);
				}
				catch
				{
					_ = (Class2)(object)Class5.Default;
					_ = (GClass2)(object)Class5.Default;
				}
			}
		}
		catch
		{
			try
			{
				try
				{
					_ = (Class2)(object)Class5.Default;
					_ = Class5.Default;
					gClass2 = gClass2;
					class22 = class22;
				}
				finally
				{
					class20 = (Class10)(object)Class5.Default;
					_ = (Class8)(object)Class5.Default;
					goto end_IL_3175;
				}
				end_IL_3175:;
			}
			catch
			{
				if ((UIntPtr)@class.e(bindingFlags, methodBase_, null, array2) == (UIntPtr)(nuint)0u)
				{
					gClass3 = gClass3;
				}
			}
		}
		class23 = class23;
		while (obj != null)
		{
			do
			{
				Class7 class25 = @class;
				BindingFlags bindingFlags_18 = bindingFlags;
				Type[] type_5 = array;
				bindingFlags = default(BindingFlags);
				_ = (Class7)(object)((Class7)(object)class25.e(bindingFlags_18, methodBase_, type_5, (ParameterModifier[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, (CultureInfo)(object)@class.t(bindingFlags, fieldInfo_, obj, null)))).j(bindingFlags, methodBase_, ref *(object[]*)null, array2, cultureInfo_, string_, out *(object*)null);
			}
			while ((object)@class.e((BindingFlags)@class.t(null, type_2, cultureInfo_), (MethodBase[])((Class7)(object)Class5.Default).t(Class5.Default, type_2, (CultureInfo)(object)Class5.Default), array, null) != null);
		}
		num2 = default(UIntPtr);
		if (checked(unchecked((nuint)default(UIntPtr)) - (num2 - unchecked((nuint)(UIntPtr)Class5.Default / checked(num2 + num2 + num2)))) == 0)
		{
			while ((object)Class5.Default != null)
			{
				try
				{
					_ = (Struct1)Class5.Default;
					@class = @class;
					class20 = null;
				}
				catch
				{
					Class7 class26 = @class;
					Class7 class27 = @class;
					BindingFlags bindingFlags_19 = bindingFlags;
					Class7 class28 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class9)(object)class26.W((BindingFlags)class27.e(bindingFlags_19, methodBase_, (Type[])(object)class28.j(bindingFlags, methodBase_, ref reference, array2, null, (string[])(object)Class5.Default, out *(object*)Class5.Default), array2), null, type_2, array, array2);
				}
			}
		}
		else
		{
			do
			{
				if ((UIntPtr)Class5.Default != (UIntPtr)(nuint)0u)
				{
					@class = @class;
					gClass = null;
				}
				else
				{
					_ = (GClass0)(object)((Class7)null).j(bindingFlags, methodBase_, ref *(object[]*)Class5.Default, (ParameterModifier[])null, cultureInfo_, string_, out reference2);
				}
			}
			while ((object)Class5.Default != null);
		}
		_ = (_003CModule_003E)(object)((Class7)(object)@class.W(bindingFlags, null, (Type)(object)Class5.Default, null, (ParameterModifier[])(object)Class5.Default)).W(bindingFlags, null, (Type)(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, null), array, array2);
		do
		{
			try
			{
				Class7 class29 = @class;
				Class7 class30 = @class;
				bindingFlags = default(BindingFlags);
				if ((nuint)(UIntPtr)class29.t((BindingFlags)class30.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type_2, (Type[])(object)@class.e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, array, array2), array2), null, null, cultureInfo_) / checked(num2 - num2) == 0)
				{
					gClass3 = gClass3;
				}
				else
				{
					class21 = (Class8)(object)Class5.Default;
				}
			}
			finally
			{
				while (obj != null)
				{
					class18 = (Class0)(object)Class5.Default;
				}
				continue;
			}
		}
		while (obj != null);
		_ = (GClass2)(object)Class5.Default;
		while (obj != null)
		{
			try
			{
				if (num2 == 0)
				{
					_ = (Class2)(object)Class5.Default;
				}
				else
				{
					_ = (Class4)(object)@class.W((BindingFlags)Class5.Default, null, type_2, array, array2);
					class23 = null;
					_ = (Struct1)Class5.Default;
				}
			}
			finally
			{
				while ((object)Class5.Default != null)
				{
					_ = (_003CModule_003E)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, array, (ParameterModifier[])(object)Class5.Default);
				}
				continue;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class2 class31);
		while (obj != null)
		{
			_ = (Class6)(object)@class.e(bindingFlags, methodBase_, null, array2);
			struct2 = default(Struct1);
			class31 = class31;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class6 class32);
		while (true)
		{
			Class7 obj17 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_20 = bindingFlags;
			bindingFlags = default(BindingFlags);
			Class7 obj18 = (Class7)(object)obj17.j(bindingFlags_20, methodBase_, ref *(object[]*)((Class7)null).t((BindingFlags)((Class7)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])(object)@class.t(bindingFlags, (FieldInfo[])(object)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, null, array, null), Class5.Default, null), (ParameterModifier[])(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, null, null))).e(bindingFlags, (MethodBase[])(object)@class.e(bindingFlags, null, (Type[])(object)((Class7)(object)Class5.Default).j((BindingFlags)Class5.Default, methodBase_, ref reference, array2, cultureInfo_, string_, out reference2), array2), null, array2), (FieldInfo[])null, ((Class7)@class.t(obj, type_2, cultureInfo_)).t(obj, null, cultureInfo_), (CultureInfo)null), array2, cultureInfo_, string_, out reference2);
			bindingFlags = default(BindingFlags);
			if ((object)obj18.W(bindingFlags, array3, type_2, (Type[])(object)Class5.Default, (ParameterModifier[])(object)@class.W(bindingFlags, (PropertyInfo[])(object)@class.t(bindingFlags, fieldInfo_, obj, cultureInfo_), (Type)(object)Class5.Default, array, array2)) == null)
			{
				break;
			}
			try
			{
				try
				{
					_ = (Class6)(object)((Class7)null).t(bindingFlags, fieldInfo_, obj, (CultureInfo)@class.t(Class5.Default, type_2, (CultureInfo)(object)Class5.Default));
				}
				finally
				{
					_ = (Class8)(object)Class5.Default;
					goto end_IL_3601;
				}
				end_IL_3601:;
			}
			finally
			{
				if (checked(num2 - num2) == 0)
				{
					class32 = class32;
				}
				else
				{
					struct2 = default(Struct1);
				}
				continue;
			}
		}
		try
		{
			class31 = class31;
		}
		finally
		{
			do
			{
				class22 = null;
			}
			while ((object)Class5.Default != null);
			goto IL_387b;
		}
		IL_3ff0:
		Class5 class33 = (Class5)(object)@class.j(bindingFlags, null, ref reference, array2, cultureInfo_, string_, out reference2);
		while ((object)Class5.Default != null)
		{
			class22 = class22;
		}
		@struct = @struct;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		if ((UIntPtr)((Class7)(object)Class5.Default).j(bindingFlags, null, ref *(object[]*)null, array2, cultureInfo_, (string[])(object)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, fieldInfo_, @class.e((BindingFlags)@class.W(bindingFlags, array3, (Type)(object)Class5.Default, array, null), (MethodBase[])(object)Class5.Default, array, null), (CultureInfo)(object)Class5.Default), out *(object*)((Class7)(object)Class5.Default).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, null, null)) == (UIntPtr)(nuint)0u && default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			do
			{
				_ = (Class4)(object)Class5.Default;
				_ = (Qk7)@class.t(obj, type_2, null);
				_003CModule_003E = null;
			}
			while (obj != null);
		}
		num2 = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass2 gClass4);
		checked
		{
			if (num2 * (unchecked((nuint)(UIntPtr)Class5.Default) * num2) == 0)
			{
				class32 = null;
			}
			else if (unchecked((nuint)(UIntPtr)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)(object)Class5.Default, (Type[])(object)Class5.Default, array2)) * num2 == 0)
			{
				gClass4 = gClass4;
			}
		}
		try
		{
			if (num2 / unchecked((nuint)default(UIntPtr)) == 0)
			{
				try
				{
					class31 = (Class2)(object)Class5.Default;
				}
				finally
				{
					_ = (Class2)(object)@class.t(bindingFlags, fieldInfo_, obj, (CultureInfo)((Class7)(object)Class5.Default).t(obj, type_2, null));
					goto end_IL_418d;
				}
			}
			end_IL_418d:;
		}
		finally
		{
			num2 = default(UIntPtr);
			if (num2 == (UIntPtr)(nuint)0u)
			{
				if (num2 == (UIntPtr)(nuint)0u)
				{
					gClass = gClass;
				}
				else
				{
					gClass4 = gClass4;
				}
			}
			else
			{
				gClass3 = (GClass1)(object)Class5.Default;
				@class = null;
				class20 = (Class10)(object)Class5.Default;
				_003CModule_003E = _003CModule_003E;
			}
			goto IL_4243;
		}
		IL_39fc:
		try
		{
			checked
			{
				try
				{
					gClass3 = gClass3;
				}
				catch
				{
					@struct = @struct;
				}
				finally
				{
					if (unchecked((nuint)(UIntPtr)Class5.Default) * unchecked((nuint)(UIntPtr)Class5.Default) == 0)
					{
						_ = (Struct2)Class5.Default;
					}
					else
					{
						_ = (Struct1)Class5.Default;
					}
					goto end_IL_39fd;
				}
			}
			end_IL_39fd:;
		}
		finally
		{
			num2 = default(UIntPtr);
			if (num2 == 0)
			{
				nuint num3 = num2;
				num2 = default(UIntPtr);
				if (checked(num3 * num2) == 0)
				{
					class23 = class23;
				}
				else
				{
					gClass3 = gClass3;
				}
			}
			else
			{
				Class7 obj20 = (Class7)(object)@class.t(bindingFlags, fieldInfo_, ((Class7)@class.t(obj, type_2, cultureInfo_)).e(default(BindingFlags), null, array, array2), cultureInfo_);
				bindingFlags = default(BindingFlags);
				if ((UIntPtr)obj20.e(bindingFlags, null, array, array2) == (UIntPtr)(nuint)0u)
				{
					_ = (Class7)(object)((Class7)null).e(bindingFlags, methodBase_, (Type[])(object)((Class7)((Class7)(object)@class.j(bindingFlags, null, ref *(object[]*)@class.W(bindingFlags, (PropertyInfo[])(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type_2, array, array2), null, (Type[])(object)Class5.Default, array2), array2, null, null, out *(object*)null)).t(obj, type_2, null)).t(bindingFlags, fieldInfo_, Class5.Default, cultureInfo_), array2);
				}
			}
			goto IL_3bb9;
		}
		IL_06f7:
		num2 = default(UIntPtr);
		if (num2 == 0)
		{
			num2 = default(UIntPtr);
			nuint num4 = num2;
			BindingFlags bindingFlags_21 = bindingFlags;
			MethodBase[] methodBase_3 = (MethodBase[])(object)@class.j(bindingFlags, (MethodBase[])@class.t(null, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default), ref reference, null, null, string_, out reference2);
			ref object[] object_8 = ref reference;
			ParameterModifier[] parameterModifier_4 = array2;
			Class7 class34 = @class;
			bindingFlags = default(BindingFlags);
			checked
			{
				if (num4 * unchecked((nuint)(UIntPtr)((Class7)null).j(bindingFlags_21, methodBase_3, ref object_8, parameterModifier_4, (CultureInfo)(object)class34.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)@class.t(@class.W(bindingFlags, array3, type_2, array, null), type_2, cultureInfo_), null, cultureInfo_, null, out *(object*)Class5.Default), (string[])null, out *(object*)null)) != 0)
				{
					try
					{
						@struct = @struct;
					}
					finally
					{
						class23 = class23;
						class23 = class23;
						goto IL_08ba;
					}
				}
				do
				{
					class22 = class22;
					class22 = null;
					_003CModule_003E = _003CModule_003E;
					_003CModule_003E = _003CModule_003E;
					_ = (Qk7)((Class7)null).t(obj, (Type)null, (CultureInfo)null);
				}
				while (obj != null);
			}
		}
		else
		{
			try
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					GClass2 obj21 = (GClass2)(object)Class5.Default;
					gClass4 = (GClass2)(object)Class5.Default;
					gClass4 = obj21;
					@struct = default(Struct2);
					@struct = @struct;
				}
				else
				{
					_ = (Class2)(object)@class.j(bindingFlags, methodBase_, ref *(object[]*)null, array2, cultureInfo_, string_, out *(object*)Class5.Default);
				}
			}
			catch
			{
				if (num2 == 0)
				{
					class23 = class23;
				}
			}
		}
		goto IL_08ba;
		IL_2682:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qk7 qk);
		try
		{
			if (num2 != 0)
			{
				try
				{
					class32 = class32;
					class21 = (Class8)(object)@class.W(bindingFlags, array3, null, array, array2);
				}
				finally
				{
					class33 = null;
					_ = (Class10)@class.t(obj, (Type)(object)Class5.Default, null);
					gClass = gClass;
					gClass3 = gClass3;
					goto end_IL_2683;
				}
			}
			try
			{
				_ = (Class2)@class.t(null, type_2, cultureInfo_);
			}
			catch
			{
				Class7 class35 = @class;
				bindingFlags = default(BindingFlags);
				Class7 obj23 = (Class7)(object)class35.W(bindingFlags, array3, null, null, array2);
				BindingFlags bindingFlags_22 = bindingFlags;
				PropertyInfo[] propertyInfo_3 = array3;
				bindingFlags = default(BindingFlags);
				_ = (Class6)(object)obj23.W(bindingFlags_22, propertyInfo_3, type_2, (Type[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)(object)@class.W(bindingFlags, null, (Type)(object)Class5.Default, null, array2), (Type[])((Class7)null).t((object)null, type_2, cultureInfo_), array2), array2);
			}
			end_IL_2683:;
		}
		catch
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					gClass3 = gClass3;
					_ = (GClass0)(object)Class5.Default;
					qk = qk;
					_ = (Class9)(object)Class5.Default;
				}
				else
				{
					_ = (Qk7)((Class7)null).t(obj, (Type)(object)@class.j((BindingFlags)Class5.Default, methodBase_, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo_, string_, out *(object*)@class.t(obj, type_2, cultureInfo_)), cultureInfo_);
				}
			}
			catch
			{
				while (true)
				{
					if (obj != null)
					{
						struct2 = default(Struct1);
						continue;
					}
					goto end_IL_2841;
				}
				end_IL_2841:;
			}
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			Class7 class36 = @class;
			BindingFlags bindingFlags_23 = bindingFlags;
			ref object[] object_9 = ref *(object[]*)((Class7)null).t((object)@class.W(default(BindingFlags), array3, type_2, (Type[])(object)Class5.Default, array2), (Type)(object)((Class7)null).W((BindingFlags)Class5.Default, array3, (Type)null, (Type[])null, (ParameterModifier[])@class.t(null, null, cultureInfo_)), (CultureInfo)(object)Class5.Default);
			Class7 class37 = @class;
			ref object[] object_10 = ref reference;
			Class7 class38 = @class;
			Class7 class39 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_24 = bindingFlags;
			Type[] type_6 = (Type[])(object)((Class7)null).t(bindingFlags, fieldInfo_, (object)Class5.Default, cultureInfo_);
			Class7 obj27 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			_ = (Class7)(object)class36.j(bindingFlags_23, null, ref object_9, (ParameterModifier[])(object)class37.j(default(BindingFlags), methodBase_, ref object_10, (ParameterModifier[])(object)class38.e(default(BindingFlags), methodBase_, (Type[])(object)class39.e(bindingFlags_24, methodBase_, type_6, (ParameterModifier[])(object)obj27.W(bindingFlags, (PropertyInfo[])(object)@class.t((BindingFlags)Class5.Default, fieldInfo_, null, null), (Type)((Class7)((Class7)null).t(obj, (Type)null, cultureInfo_)).t(obj, type_2, cultureInfo_), null, array2)), array2), cultureInfo_, string_, out *(object*)null), null, null, out reference2);
		}
		num2 = default(UIntPtr);
		if (num2 == 0)
		{
			while (obj != null)
			{
				if (num2 == 0)
				{
					gClass = null;
				}
				else
				{
					_ = (GClass0)(object)Class5.Default;
				}
			}
		}
		if (num2 == 0)
		{
			try
			{
				if (num2 / checked(unchecked((nuint)(UIntPtr)Class5.Default) * unchecked((nuint)default(UIntPtr))) == 0)
				{
					Class7 class40 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_25 = bindingFlags;
					MethodBase[] methodBase_4 = (MethodBase[])(object)Class5.Default;
					ref object[] object_11 = ref *(object[]*)@class.j((BindingFlags)@class.t(bindingFlags, fieldInfo_, obj, cultureInfo_), methodBase_, ref reference, array2, cultureInfo_, (string[])((Class7)(object)Class5.Default).t(Class5.Default, type_2, cultureInfo_), out *(object*)null);
					Class7 obj28 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Class9)(object)class40.j(bindingFlags_25, methodBase_4, ref object_11, null, (CultureInfo)(object)obj28.e(bindingFlags, methodBase_, null, array2), string_, out reference2);
				}
			}
			catch
			{
				do
				{
					gClass4 = null;
					_ = (Struct1)Class5.Default;
					_ = (Class9)(object)@class.j(bindingFlags, methodBase_, ref *(object[]*)Class5.Default, array2, cultureInfo_, string_, out reference2);
					struct2 = struct2;
				}
				while (obj != null);
			}
		}
		else if ((UIntPtr)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type_2, array, array2) == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				_ = (Class9)(object)Class5.Default;
			}
		}
		Class7 class41 = @class;
		bindingFlags = default(BindingFlags);
		_ = (Struct1)class41.e(bindingFlags, methodBase_, null, (ParameterModifier[])(object)Class5.Default);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			bindingFlags = default(BindingFlags);
			_ = (Class7)(object)((Class7)null).j(bindingFlags, methodBase_, ref *(object[]*)null, (ParameterModifier[])null, (CultureInfo)null, string_, out reference2);
		}
		num2 = default(UIntPtr);
		if (num2 == (UIntPtr)(nuint)0u)
		{
			num2 = default(UIntPtr);
			if (num2 == (UIntPtr)(nuint)0u && (UIntPtr)@class.t((BindingFlags)@class.t(bindingFlags, null, Class5.Default, cultureInfo_), fieldInfo_, null, cultureInfo_) == (UIntPtr)(nuint)0u)
			{
				class21 = (Class8)(object)@class.j(bindingFlags, methodBase_, ref *(object[]*)null, null, null, (string[])(object)Class5.Default, out *(object*)Class5.Default);
			}
		}
		else
		{
			try
			{
				while (obj != null)
				{
					_ = (GClass0)(object)((Class7)null).e(bindingFlags, methodBase_, (Type[])null, array2);
				}
			}
			catch
			{
				try
				{
					class23 = class23;
					_ = (Struct1)Class5.Default;
				}
				catch
				{
					Class7 obj30 = (Class7)(object)@class.W(default(BindingFlags), (PropertyInfo[])(object)Class5.Default, null, null, (ParameterModifier[])(object)Class5.Default);
					bindingFlags = default(BindingFlags);
					_ = (GClass0)(object)((Class7)(object)obj30.j(bindingFlags, methodBase_, ref reference, array2, cultureInfo_, (string[])(object)Class5.Default, out reference2)).j(bindingFlags, (MethodBase[])(object)@class.t(bindingFlags, fieldInfo_, null, (CultureInfo)(object)Class5.Default), ref reference, array2, null, string_, out reference2);
					_ = (GClass3)(object)Class5.Default;
				}
			}
		}
		do
		{
			_ = (Qk7)(object)@class.e(default(BindingFlags), methodBase_, (Type[])(object)@class.t((BindingFlags)@class.t(null, null, cultureInfo_), fieldInfo_, null, (CultureInfo)(object)@class.W((BindingFlags)Class5.Default, array3, (Type)(object)Class5.Default, array, null)), (ParameterModifier[])(object)Class5.Default);
		}
		while (obj != null);
		UIntPtr num5 = num2;
		object object_12 = ((Class7)null).e((BindingFlags)Class5.Default, methodBase_, (Type[])null, array2);
		Type type_7 = (Type)(object)Class5.Default;
		Class7 obj33 = (Class7)(object)@class.W(default(BindingFlags), array3, null, (Type[])(object)Class5.Default, array2);
		bindingFlags = default(BindingFlags);
		UIntPtr num6 = (UIntPtr)((Class7)null).e((BindingFlags)((Class7)null).t(object_12, type_7, (CultureInfo)(object)obj33.e(bindingFlags, methodBase_, array, (ParameterModifier[])(object)Class5.Default)), methodBase_, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
		num2 = default(UIntPtr);
		checked
		{
			if (unchecked((nuint)num5 / checked(unchecked((nuint)default(UIntPtr)) * unchecked((nuint)num6 / num2))) + unchecked((nuint)(UIntPtr)Class5.Default) == 0)
			{
				_ = (Struct1)Class5.Default;
			}
			else
			{
				try
				{
					class23 = class23;
				}
				catch
				{
					try
					{
						class23 = null;
					}
					finally
					{
						class32 = null;
						goto end_IL_2f27;
					}
					end_IL_2f27:;
				}
			}
		}
		try
		{
			Class7 class42;
			object object_13;
			BindingFlags bindingFlags_26;
			object object_14;
			do
			{
				if (num2 == 0)
				{
					@struct = @struct;
				}
				class42 = @class;
				object_13 = Class5.Default;
				bindingFlags_26 = (BindingFlags)Class5.Default;
				object_14 = obj;
				bindingFlags = default(BindingFlags);
			}
			while (class42.t(object_13, (Type)(object)((Class7)null).t(bindingFlags_26, fieldInfo_, object_14, (CultureInfo)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, array2)), cultureInfo_) != null);
		}
		finally
		{
			class22 = class22;
			goto IL_2fc8;
		}
		IL_0e1b:
		try
		{
			if (num2 == 0)
			{
				try
				{
					_ = (Qk7)(object)@class.t((BindingFlags)Class5.Default, null, null, null);
					class32 = class32;
					@class = @class;
				}
				finally
				{
					class32 = (Class6)(object)Class5.Default;
					goto end_IL_0e1c;
				}
			}
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				Class7 obj35 = (Class7)(object)((Class7)(object)Class5.Default).e(bindingFlags, methodBase_, array, null);
				bindingFlags = default(BindingFlags);
				_ = (GClass0)(object)obj35.e(bindingFlags, methodBase_, null, array2);
			}
			else
			{
				gClass3 = (GClass1)(object)Class5.Default;
				gClass3 = gClass3;
			}
			end_IL_0e1c:;
		}
		finally
		{
			num2 = default(UIntPtr);
			if (num2 == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)@class.t(obj, null, (CultureInfo)(object)Class5.Default) == (UIntPtr)(nuint)0u)
				{
					Class7 class43 = @class;
					Class7 class44 = @class;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_27 = (BindingFlags)class44.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, null, array2);
					MethodBase[] methodBase_5 = (MethodBase[])(object)@class.e(bindingFlags, methodBase_, array, array2);
					Type[] type_8 = array;
					Class7 class45 = @class;
					BindingFlags bindingFlags_28 = (BindingFlags)Class5.Default;
					FieldInfo[] fieldInfo_4 = (FieldInfo[])(object)Class5.Default;
					object object_15 = obj;
					Class7 class46 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class0)(object)class43.e(bindingFlags_27, methodBase_5, type_8, (ParameterModifier[])(object)class45.t(bindingFlags_28, fieldInfo_4, object_15, (CultureInfo)(object)class46.t(bindingFlags, fieldInfo_, null, cultureInfo_)));
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
					_ = (Class8)(object)Class5.Default;
				}
			}
			goto IL_0fca;
		}
		IL_0fca:
		try
		{
			do
			{
				Class7 class47 = @class;
				Class7 obj37 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				_ = (Class6)(object)((Class7)(object)class47.W((BindingFlags)obj37.e(bindingFlags, methodBase_, array, array2), null, type_2, array, (ParameterModifier[])((Class7)null).t(obj, type_2, cultureInfo_))).e((BindingFlags)@class.W((BindingFlags)Class5.Default, array3, (Type)(object)Class5.Default, null, null), methodBase_, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
				@struct = default(Struct2);
				@struct = @struct;
			}
			while ((object)Class5.Default != null);
		}
		catch
		{
			qk = qk;
			qk = null;
		}
		try
		{
			if (num2 == (UIntPtr)(nuint)0u)
			{
				_ = (Struct2)Class5.Default;
			}
		}
		finally
		{
			do
			{
				try
				{
					_ = (Struct1)((Class7)null).W(bindingFlags, array3, type_2, (Type[])@class.t(Class5.Default, type_2, cultureInfo_), array2);
				}
				catch
				{
					class32 = class32;
				}
			}
			while ((object)Class5.Default != null);
			goto IL_1113;
		}
		IL_238e:
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				do
				{
					_ = Class5.Default;
				}
				while (obj != null);
			}
		}
		catch
		{
			try
			{
				while (obj != null)
				{
					class31 = (Class2)(object)((Class7)null).W(bindingFlags, array3, type_2, (Type[])(object)Class5.Default, (ParameterModifier[])null);
					class31 = class31;
				}
			}
			catch
			{
				try
				{
					_ = (Class2)(object)Class5.Default;
					goto end_IL_23ef;
				}
				catch
				{
					bindingFlags = default(BindingFlags);
					_ = (Class6)(object)((Class7)null).W(bindingFlags, array3, type_2, (Type[])null, array2);
					goto end_IL_23ef;
				}
				end_IL_23ef:;
			}
		}
		checked
		{
			do
			{
				try
				{
					if (unchecked((nuint)default(UIntPtr)) * unchecked((nuint)default(UIntPtr)) == 0)
					{
						class33 = class33;
					}
				}
				catch
				{
					do
					{
						_ = (Class6)(object)Class5.Default;
						_ = (Class8)(object)@class.e(bindingFlags, methodBase_, null, array2);
						struct2 = (Struct1)Class5.Default;
					}
					while (obj != null);
				}
			}
			while (obj != null);
			while (obj != null)
			{
				gClass4 = gClass4;
				qk = null;
				class33 = class33;
			}
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			while (true)
			{
				Class7 obj44 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_29 = bindingFlags;
				Class7 class48 = @class;
				bindingFlags = default(BindingFlags);
				if ((object)obj44.W(bindingFlags_29, (PropertyInfo[])(object)class48.j(bindingFlags, methodBase_, ref reference, array2, cultureInfo_, (string[])(object)Class5.Default, out reference2), null, (Type[])(object)Class5.Default, array2) != null)
				{
					try
					{
						_ = (Class2)(object)Class5.Default;
					}
					catch
					{
						_ = (Class4)(object)Class5.Default;
					}
					continue;
				}
				break;
			}
		}
		else
		{
			try
			{
				try
				{
					_003CModule_003E = (_003CModule_003E)@class.t(obj, type_2, (CultureInfo)(object)Class5.Default);
				}
				catch
				{
					_ = (GClass0)((Class7)(object)@class.j(bindingFlags, methodBase_, ref reference, array2, null, string_, out *(object*)Class5.Default)).t(obj, (Type)(object)Class5.Default, null);
				}
			}
			catch
			{
				try
				{
					class31 = (Class2)(object)Class5.Default;
					class18 = class18;
				}
				finally
				{
					_ = (GClass2)(object)Class5.Default;
					goto end_IL_25c3;
				}
				end_IL_25c3:;
			}
		}
		checked
		{
			try
			{
				while (obj != null)
				{
					try
					{
						class33 = null;
					}
					catch
					{
						_ = (Qk7)(object)Class5.Default;
						@struct = @struct;
					}
				}
			}
			finally
			{
				num2 = default(UIntPtr);
				if (unchecked((nuint)default(UIntPtr)) * num2 == 0)
				{
					nuint num7 = unchecked((nuint)default(UIntPtr)) - unchecked((nuint)(UIntPtr)Class5.Default);
					num2 = default(UIntPtr);
					if (num7 + num2 == 0)
					{
						@struct = default(Struct2);
					}
				}
				else
				{
					do
					{
						qk = qk;
					}
					while (obj != null);
				}
				goto IL_2682;
			}
		}
		IL_08ba:
		if (num2 == 0)
		{
			try
			{
				while (obj != null)
				{
					class22 = null;
				}
			}
			catch
			{
				_ = (Struct1)Class5.Default;
				_ = (GClass2)(object)Class5.Default;
				class31 = null;
				class31 = class31;
			}
		}
		if (num2 == 0)
		{
			while (obj != null)
			{
				class20 = class20;
			}
		}
		if ((UIntPtr)((Class7)(object)Class5.Default).e(bindingFlags, methodBase_, null, null) == (UIntPtr)(nuint)0u)
		{
			struct2 = (Struct1)Class5.Default;
			struct2 = struct2;
		}
		else
		{
			while (obj != null)
			{
				try
				{
					bindingFlags = default(BindingFlags);
					_ = (Struct2)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)null, cultureInfo_);
				}
				finally
				{
					Class8 obj50 = (Class8)(object)@class.t((BindingFlags)Class5.Default, null, obj, null);
					class21 = class21;
					class21 = obj50;
					class32 = class32;
					class32 = null;
					continue;
				}
			}
		}
		while (obj != null)
		{
			try
			{
				while (obj != null)
				{
					class18 = class18;
				}
			}
			catch
			{
				_ = (Class6)(object)Class5.Default;
			}
		}
		try
		{
			try
			{
				_ = (_003CModule_003E)(object)Class5.Default;
				_ = (Class7)(object)Class5.Default;
				class31 = class31;
			}
			catch
			{
				gClass4 = gClass4;
			}
			finally
			{
				num2 = default(UIntPtr);
				if (num2 == 0)
				{
					_ = (Class7)(object)Class5.Default;
				}
				else
				{
					class18 = class18;
				}
				goto end_IL_09d3;
			}
			end_IL_09d3:;
		}
		catch
		{
			while (obj != null)
			{
				while (obj != null)
				{
					class23 = null;
					gClass2 = gClass2;
					gClass2 = gClass2;
				}
			}
		}
		do
		{
			@class = null;
		}
		while ((object)Class5.Default != null);
		try
		{
			Class7 class49 = @class;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_30 = bindingFlags;
			ref object[] object_16 = ref *(object[]*)Class5.Default;
			Class7 obj54 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_31 = (BindingFlags)Class5.Default;
			FieldInfo[] fieldInfo_5 = (FieldInfo[])@class.t(null, type_2, (CultureInfo)(object)((Class7)(object)Class5.Default).t(bindingFlags, fieldInfo_, obj, (CultureInfo)(object)Class5.Default));
			Class7 class50 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Class0)(object)class49.j(bindingFlags_30, null, ref object_16, (ParameterModifier[])(object)obj54.t(bindingFlags_31, fieldInfo_5, class50.j(bindingFlags, methodBase_, ref *(object[]*)Class5.Default, (ParameterModifier[])@class.t(obj, type_2, cultureInfo_), cultureInfo_, string_, out *(object*)null), (CultureInfo)((Class7)@class.t(obj, type_2, cultureInfo_)).t(((Class7)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type_2, (Type[])(object)Class5.Default, array2)).t((BindingFlags)Class5.Default, (FieldInfo[])@class.t(@class.t(obj, type_2, cultureInfo_), type_2, (CultureInfo)(object)((Class7)null).t((BindingFlags)Class5.Default, fieldInfo_, obj, cultureInfo_)), obj, null), null, null)), (CultureInfo)((Class7)(object)Class5.Default).t(obj, (Type)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)@class.e((BindingFlags)((Class7)(object)@class.t((BindingFlags)Class5.Default, fieldInfo_, ((Class7)null).t((object)null, type_2, cultureInfo_), cultureInfo_)).j(bindingFlags, null, ref *(object[]*)null, (ParameterModifier[])((Class7)null).t((object)((Class7)(object)Class5.Default).t(bindingFlags, fieldInfo_, obj, cultureInfo_), (Type)null, cultureInfo_), (CultureInfo)(object)Class5.Default, (string[])(object)((Class7)null).W(bindingFlags, array3, (Type)(object)Class5.Default, (Type[])null, array2), out *(object*)null), methodBase_, null, array2), (Type[])(object)Class5.Default, array2), null), string_, out reference2);
		}
		catch
		{
			_ = (Class4)@class.t(null, type_2, (CultureInfo)(object)Class5.Default);
		}
		checked
		{
			try
			{
				UIntPtr num8 = unchecked((UIntPtr)Class5.Default);
				num2 = default(UIntPtr);
				if (unchecked((nuint)num8) + num2 == 0 && unchecked((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u))
				{
					_ = Class5.Default;
				}
			}
			finally
			{
				if (unchecked((nuint)(UIntPtr)((Class7)null).e((BindingFlags)Class5.Default, methodBase_, (Type[])(object)@class.t(bindingFlags, fieldInfo_, ((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, methodBase_, null, null), cultureInfo_), array2)) + unchecked((nuint)(UIntPtr)((Class7)null).t((object)null, type_2, (CultureInfo)(object)Class5.Default)) == 0)
				{
					try
					{
						_ = (_003CModule_003E)(object)Class5.Default;
					}
					catch
					{
						_ = (Struct1)Class5.Default;
					}
				}
				else if (num2 == 0)
				{
					_ = (Struct2)Class5.Default;
				}
				else
				{
					gClass4 = (GClass2)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Class10)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type_2, array, array2);
				}
				goto IL_0e1b;
			}
		}
		IL_1113:
		_ = (Class10)((Class7)null).t(obj, (Type)null, cultureInfo_);
		gClass4 = gClass4;
		do
		{
			class33 = class33;
			class33 = class33;
		}
		while (obj != null);
		while ((object)Class5.Default != null)
		{
			_ = (Class5)((Class7)null).t(obj, (Type)null, (CultureInfo)(object)Class5.Default);
		}
		while (obj != null)
		{
			try
			{
				if (num2 == (UIntPtr)(nuint)0u)
				{
					_ = (Class4)(object)((Class7)null).j(bindingFlags, methodBase_, ref reference, (ParameterModifier[])null, (CultureInfo)(object)Class5.Default, string_, out reference2);
				}
				else
				{
					_ = (_003CModule_003E)(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array, array2);
				}
			}
			catch
			{
				try
				{
					class31 = null;
				}
				finally
				{
					_ = (_003CModule_003E)(object)((Class7)(object)Class5.Default).W(bindingFlags, null, type_2, array, (ParameterModifier[])(object)Class5.Default);
					goto end_IL_11cf;
				}
				end_IL_11cf:;
			}
		}
		num2 = default(UIntPtr);
		if (num2 == (UIntPtr)(nuint)0u)
		{
			do
			{
				_ = (Class2)(object)Class5.Default;
			}
			while (obj != null);
		}
		else if (num2 == (UIntPtr)(nuint)0u)
		{
			try
			{
				gClass4 = gClass4;
			}
			catch
			{
				Class7 class51 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Class10)(object)class51.W(bindingFlags, null, type_2, array, array2);
			}
		}
		else
		{
			_ = (Class8)(object)Class5.Default;
		}
		while (obj != null)
		{
			num2 = default(UIntPtr);
			if (checked(unchecked((nuint)default(UIntPtr)) * num2) == 0)
			{
				if (num2 / checked(num2 * unchecked((nuint)default(UIntPtr))) == 0)
				{
					qk = (Qk7)(object)Class5.Default;
				}
			}
			else
			{
				while (obj != null)
				{
					class31 = (Class2)(object)@class.W(bindingFlags, array3, null, array, array2);
				}
			}
		}
		gClass2 = gClass2;
		num2 = default(UIntPtr);
		if (num2 == 0)
		{
			do
			{
				try
				{
					_ = (Class8)(object)Class5.Default;
				}
				finally
				{
					class22 = class22;
					continue;
				}
			}
			while (obj != null);
		}
		while (obj != null)
		{
			while (obj != null)
			{
				while (@class.t(Class5.Default, type_2, cultureInfo_) != null)
				{
					class18 = (Class0)(object)Class5.Default;
				}
			}
		}
		try
		{
			try
			{
				do
				{
					class23 = class23;
				}
				while (((Class7)(object)@class.e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, array, (ParameterModifier[])(object)Class5.Default)).t(((Class7)(object)Class5.Default).t(((Class7)null).j((BindingFlags)Class5.Default, methodBase_, ref *(object[]*)null, (ParameterModifier[])(object)@class.e(bindingFlags, methodBase_, array, array2), (CultureInfo)null, string_, out *(object*)null), type_2, cultureInfo_), type_2, cultureInfo_) != null);
			}
			catch
			{
				num2 = default(UIntPtr);
				if (num2 == 0)
				{
					struct2 = default(Struct1);
					struct2 = struct2;
				}
				else
				{
					_ = Class5.Default;
				}
			}
		}
		catch
		{
			try
			{
				if (num2 / (nuint)(UIntPtr)@class.e(bindingFlags, methodBase_, (Type[])((Class7)null).t((object)((Class7)(object)@class.W(bindingFlags, null, type_2, array, (ParameterModifier[])(object)Class5.Default)).W((BindingFlags)Class5.Default, (PropertyInfo[])(object)@class.t(bindingFlags, fieldInfo_, obj, null), type_2, null, (ParameterModifier[])(object)Class5.Default), (Type)(object)Class5.Default, cultureInfo_), array2) == 0)
				{
					class33 = class33;
				}
			}
			catch
			{
				try
				{
					_ = (Class8)(object)Class5.Default;
					goto end_IL_14fb;
				}
				catch
				{
					_ = (Struct1)Class5.Default;
					goto end_IL_14fb;
				}
				end_IL_14fb:;
			}
		}
		_ = (Class8)(object)Class5.Default;
		_ = (Qk7)(object)Class5.Default;
		_ = (Struct1)((Class7)(object)Class5.Default).e(bindingFlags, methodBase_, (Type[])(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array2, (CultureInfo)((Class7)(object)Class5.Default).t(obj, type_2, cultureInfo_), string_, out *(object*)null), array2);
		class18 = null;
		gClass = gClass;
		try
		{
			_ = (GClass2)(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array, array2);
		}
		finally
		{
			try
			{
				do
				{
					class18 = class18;
				}
				while ((object)Class5.Default != null);
			}
			catch
			{
				try
				{
					class23 = null;
				}
				finally
				{
					@class = (Class7)(object)((Class7)(object)((Class7)(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)((Class7)null).t((BindingFlags)@class.t(((Class7)null).t((object)Class5.Default, type_2, cultureInfo_), (Type)(object)Class5.Default, cultureInfo_), (FieldInfo[])(object)Class5.Default, obj, cultureInfo_), string_, out reference2)).j(bindingFlags, null, ref *(object[]*)null, array2, null, (string[])(object)@class.W(bindingFlags, array3, type_2, null, array2), out *(object*)Class5.Default)).t(bindingFlags, fieldInfo_, obj, (CultureInfo)(object)Class5.Default);
					goto end_IL_15ea;
				}
				end_IL_15ea:;
			}
			goto IL_16df;
		}
		IL_4243:
		qk = qk;
		try
		{
			struct2 = default(Struct1);
			struct2 = struct2;
		}
		catch
		{
			do
			{
				try
				{
					_ = (Struct2)Class5.Default;
				}
				catch
				{
					qk = qk;
					@struct = default(Struct2);
				}
			}
			while (obj != null);
		}
		_ = (GClass0)(object)Class5.Default;
		gClass2 = null;
		_ = (Class0)(object)((Class7)(object)Class5.Default).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array2, cultureInfo_, string_, out *(object*)Class5.Default);
		while (obj != null)
		{
			@struct = default(Struct2);
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])(object)Class5.Default, array, null) == (UIntPtr)(nuint)0u)
			{
				do
				{
					gClass2 = gClass2;
				}
				while (obj != null);
			}
			else
			{
				while (obj != null)
				{
					_ = (GClass2)(object)Class5.Default;
				}
			}
		}
		_ = (GClass3)(object)Class5.Default;
		try
		{
			struct2 = struct2;
		}
		catch
		{
			class20 = (Class10)(object)@class.t(bindingFlags, fieldInfo_, obj, (CultureInfo)(object)Class5.Default);
		}
		try
		{
			while ((object)Class5.Default != null)
			{
				_ = (Class7)((Class7)null).t(obj, type_2, (CultureInfo)null);
			}
			return;
		}
		catch
		{
			do
			{
				try
				{
					_ = (GClass2)@class.t(Class5.Default, (Type)(object)Class5.Default, null);
				}
				catch
				{
					_ = (GClass3)(object)Class5.Default;
				}
			}
			while ((object)((Class7)(object)Class5.Default).t(bindingFlags, fieldInfo_, obj, (CultureInfo)(object)Class5.Default) != null);
			return;
		}
		IL_387b:
		do
		{
			if (num2 == 0)
			{
				try
				{
					_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
				}
				catch
				{
					_ = (Class2)(object)Class5.Default;
					class23 = null;
					class22 = class22;
				}
			}
		}
		while (obj != null);
		class32 = (Class6)(object)Class5.Default;
		class33 = class33;
		class18 = (Class0)(object)Class5.Default;
		while (obj != null)
		{
			do
			{
				if ((UIntPtr)Class5.Default != (UIntPtr)(nuint)0u)
				{
					_ = (GClass2)(object)Class5.Default;
					continue;
				}
				_ = (Class10)((Class7)null).t((object)null, type_2, cultureInfo_);
				Class7 class52 = @class;
				Class7 class53 = @class;
				bindingFlags = default(BindingFlags);
				gClass4 = (GClass2)(object)class52.W((BindingFlags)class53.W(bindingFlags, array3, type_2, array, (ParameterModifier[])(object)Class5.Default), array3, null, (Type[])(object)Class5.Default, (ParameterModifier[])(object)((Class7)null).t((BindingFlags)Class5.Default, fieldInfo_, obj, cultureInfo_));
				class20 = (Class10)(object)Class5.Default;
				struct2 = struct2;
			}
			while (obj != null);
		}
		while (obj != null)
		{
			if ((UIntPtr)@class.W(bindingFlags, null, (Type)(object)@class.W(bindingFlags, array3, (Type)(object)Class5.Default, null, null), null, array2) == (UIntPtr)(nuint)0u)
			{
				while (obj != null)
				{
					_ = (GClass3)(object)Class5.Default;
				}
			}
		}
		try
		{
			gClass2 = gClass2;
		}
		catch
		{
			while (obj != null)
			{
				class23 = class23;
			}
		}
		finally
		{
			goto IL_39fc;
		}
		IL_3f1d:
		checked
		{
			if (unchecked((nuint)(UIntPtr)@class.t(obj, (Type)(object)Class5.Default, cultureInfo_)) + unchecked((nuint)(UIntPtr)Class5.Default) == 0)
			{
				gClass4 = gClass4;
				goto IL_3ff0;
			}
		}
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
			while (true)
			{
				Class7 class54 = @class;
				BindingFlags bindingFlags_32 = bindingFlags;
				ref object[] object_17 = ref reference;
				ParameterModifier[] parameterModifier_5 = (ParameterModifier[])(object)@class.j(default(BindingFlags), (MethodBase[])(object)Class5.Default, ref reference, (ParameterModifier[])(object)Class5.Default, null, null, out *(object*)null);
				Class7 class55 = @class;
				bindingFlags = default(BindingFlags);
				if ((object)class54.j(bindingFlags_32, null, ref object_17, parameterModifier_5, null, (string[])(object)class55.t(bindingFlags, null, obj, null), out reference2) != null)
				{
					_003CModule_003E = _003CModule_003E;
					continue;
				}
				break;
			}
			goto IL_3ff0;
		}
		IL_3bb9:
		do
		{
			try
			{
				class22 = class22;
			}
			catch
			{
				gClass4 = gClass4;
			}
		}
		while ((object)@class.t((BindingFlags)@class.e(bindingFlags, methodBase_, array, null), (FieldInfo[])(object)Class5.Default, null, (CultureInfo)(object)Class5.Default) != null || (object)@class.t(bindingFlags, fieldInfo_, ((Class7)(object)Class5.Default).W(bindingFlags, array3, type_2, array, array2), cultureInfo_) != null);
		try
		{
			_ = (GClass0)@class.t(@class.t(bindingFlags, fieldInfo_, null, cultureInfo_), type_2, null);
		}
		catch
		{
			try
			{
				try
				{
					gClass3 = gClass3;
				}
				finally
				{
					class20 = class20;
					goto end_IL_3c8a;
				}
				end_IL_3c8a:;
			}
			catch
			{
				_ = (Struct1)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, cultureInfo_);
				_ = Class5.Default;
				_003CModule_003E = null;
				_ = (Class9)(object)Class5.Default;
			}
		}
		bindingFlags = default(BindingFlags);
		_ = (Class5)(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, (ParameterModifier[])null, cultureInfo_, string_, out *(object*)null);
		_ = (GClass0)(object)Class5.Default;
		class22 = (Class9)(object)Class5.Default;
		_ = (Class6)(object)@class.W(bindingFlags, array3, type_2, (Type[])(object)Class5.Default, array2);
		try
		{
			do
			{
				class33 = null;
				qk = null;
				class22 = class22;
			}
			while (obj != null);
		}
		catch
		{
			while ((object)Class5.Default != null)
			{
				try
				{
					struct2 = struct2;
					class33 = class33;
					class21 = class21;
					_ = (GClass1)(object)Class5.Default;
				}
				catch
				{
					_ = (Struct2)Class5.Default;
				}
			}
		}
		if (num2 == 0)
		{
			try
			{
				while ((object)Class5.Default != null)
				{
					class18 = null;
					qk = qk;
					_ = (Qk7)(object)@class.e((BindingFlags)((Class7)@class.t(null, type_2, (CultureInfo)(object)((Class7)(object)Class5.Default).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array2, cultureInfo_, string_, out reference2))).j(bindingFlags, methodBase_, ref *(object[]*)null, array2, null, (string[])(object)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, array3, null, null, (ParameterModifier[])(object)Class5.Default), out reference2), methodBase_, array, null);
					Class7 class56 = @class;
					BindingFlags bindingFlags_33 = bindingFlags;
					Class7 class57 = @class;
					bindingFlags = default(BindingFlags);
					gClass3 = (GClass1)(object)class56.e(bindingFlags_33, (MethodBase[])((Class7)((Class7)null).t((object)class57.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, (CultureInfo)(object)Class5.Default), (Type)(object)Class5.Default, cultureInfo_)).t(obj, type_2, cultureInfo_), array, null);
				}
			}
			finally
			{
				if (num2 == 0)
				{
					_ = (Struct1)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj, (CultureInfo)null);
				}
				goto IL_3f1d;
			}
		}
		goto IL_3f1d;
		IL_1dce:
		while (obj != null)
		{
			try
			{
				try
				{
					Class7 class58 = @class;
					Class7 class59 = @class;
					BindingFlags bindingFlags_34 = bindingFlags;
					FieldInfo[] fieldInfo_6 = (FieldInfo[])(object)Class5.Default;
					object object_18 = Class5.Default;
					Class7 obj76 = (Class7)(object)@class.W((BindingFlags)@class.t(obj, null, null), array3, type_2, array, array2);
					BindingFlags bindingFlags_35 = bindingFlags;
					Class7 class60 = @class;
					BindingFlags bindingFlags_36 = (BindingFlags)Class5.Default;
					bindingFlags = default(BindingFlags);
					_003CModule_003E = (_003CModule_003E)(object)((Class7)(object)class58.t((BindingFlags)((Class7)null).e((BindingFlags)class59.t(bindingFlags_34, fieldInfo_6, object_18, (CultureInfo)(object)obj76.e(bindingFlags_35, (MethodBase[])(object)((Class7)(object)class60.j(bindingFlags_36, (MethodBase[])(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, (ParameterModifier[])null), ref *(object[]*)null, array2, null, string_, out *(object*)null)).j(bindingFlags, null, ref *(object[]*)((Class7)null).t(obj, (Type)null, (CultureInfo)null), array2, (CultureInfo)(object)((Class7)null).j((BindingFlags)Class5.Default, methodBase_, ref reference, array2, (CultureInfo)null, string_, out *(object*)null), string_, out reference2), array, array2)), methodBase_, array, (ParameterModifier[])null), null, obj, null)).W(bindingFlags, null, (Type)@class.t(obj, type_2, cultureInfo_), array, (ParameterModifier[])@class.t(null, type_2, (CultureInfo)(object)((Class7)(object)Class5.Default).W(bindingFlags, array3, null, array, array2)));
				}
				catch
				{
					gClass4 = null;
				}
			}
			catch
			{
				_ = (GClass0)(object)Class5.Default;
			}
		}
		if ((UIntPtr)@class.W((BindingFlags)@class.j(bindingFlags, methodBase_, ref reference, (ParameterModifier[])((Class7)null).t(obj, type_2, cultureInfo_), null, string_, out *(object*)null), null, null, array, array2) == (UIntPtr)(nuint)0u && (UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				_ = (Class10)((Class7)(object)Class5.Default).t(obj, (Type)(object)Class5.Default, cultureInfo_);
				class33 = class33;
			}
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			gClass3 = (GClass1)(object)Class5.Default;
			@class = @class;
		}
		try
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (GClass2)(object)Class5.Default;
					struct2 = (Struct1)Class5.Default;
				}
				finally
				{
					gClass4 = gClass4;
					goto end_IL_1e92;
				}
			}
			end_IL_1e92:;
		}
		catch
		{
			while (obj != null)
			{
				Class7 class61 = @class;
				BindingFlags bindingFlags_37 = bindingFlags;
				ref object[] object_19 = ref reference;
				CultureInfo cultureInfo_2 = (CultureInfo)(object)((Class7)(object)Class5.Default).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)@class.j((BindingFlags)Class5.Default, (MethodBase[])(object)@class.W((BindingFlags)Class5.Default, array3, type_2, null, array2), ref reference, null, null, null, out reference2), null, string_, out reference2);
				Class7 class62 = @class;
				object object_20 = obj;
				Class7 obj79 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				if ((UIntPtr)class61.j(bindingFlags_37, methodBase_, ref object_19, null, cultureInfo_2, (string[])(object)class62.e(default(BindingFlags), (MethodBase[])((Class7)null).t(object_20, (Type)null, (CultureInfo)(object)obj79.t(bindingFlags, (FieldInfo[])(object)Class5.Default, Class5.Default, cultureInfo_)), (Type[])(object)@class.t((BindingFlags)@class.t(obj, null, null), fieldInfo_, @class.t(obj, type_2, cultureInfo_), cultureInfo_), null), out reference2) == (UIntPtr)(nuint)0u)
				{
					_003CModule_003E = _003CModule_003E;
					class23 = class23;
					class20 = class20;
				}
			}
		}
		_ = Class5.Default;
		class31 = class31;
		_ = (Class8)(object)((Class7)null).j((BindingFlags)Class5.Default, methodBase_, ref reference, (ParameterModifier[])null, cultureInfo_, string_, out reference2);
		_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
		_ = (Class7)(object)((Class7)(object)Class5.Default).e(bindingFlags, null, array, array2);
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (Class2)(object)Class5.Default;
				struct2 = struct2;
				class18 = class18;
			}
		}
		catch
		{
			while (obj != null)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Class8)(object)Class5.Default;
				}
			}
		}
		do
		{
			class21 = (Class8)(object)Class5.Default;
		}
		while (obj != null);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			do
			{
				try
				{
					gClass2 = gClass2;
				}
				catch
				{
					_ = (Class4)(object)Class5.Default;
				}
			}
			while ((object)((Class7)null).e(bindingFlags, methodBase_, array, array2) != null);
		}
		else
		{
			while (obj != null)
			{
				try
				{
					gClass = null;
					@class = @class;
					_ = (GClass0)((Class7)null).t((object)null, type_2, (CultureInfo)(object)((Class7)null).e((BindingFlags)Class5.Default, (MethodBase[])null, (Type[])(object)Class5.Default, array2));
				}
				catch
				{
					class32 = class32;
				}
			}
		}
		qk = qk;
		gClass3 = gClass3;
		_ = (Class9)(object)Class5.Default;
		try
		{
		}
		finally
		{
			Class7 obj84 = (Class7)((Class7)(object)Class5.Default).t(obj, (Type)(object)Class5.Default, cultureInfo_);
			BindingFlags bindingFlags_38 = bindingFlags;
			FieldInfo[] fieldInfo_7 = (FieldInfo[])(object)Class5.Default;
			object object_21 = obj;
			object object_22 = @class.j(bindingFlags, (MethodBase[])(object)@class.j(bindingFlags, methodBase_, ref reference, array2, cultureInfo_, null, out reference2), ref *(object[]*)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)@class.t(@class.W(bindingFlags, null, null, (Type[])(object)Class5.Default, array2), null, null), (Type[])(object)Class5.Default, array2), (ParameterModifier[])(object)Class5.Default, null, string_, out reference2);
			BindingFlags bindingFlags_39 = bindingFlags;
			MethodBase[] methodBase_6 = (MethodBase[])(object)Class5.Default;
			ref object[] object_23 = ref *(object[]*)@class.e(bindingFlags, null, array, (ParameterModifier[])(object)Class5.Default);
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)obj84.t(bindingFlags_38, fieldInfo_7, object_21, (CultureInfo)((Class7)null).t(object_22, (Type)(object)((Class7)null).j(bindingFlags_39, methodBase_6, ref object_23, (ParameterModifier[])null, cultureInfo_, (string[])(object)((Class7)null).e(bindingFlags, methodBase_, array, array2), out reference2), cultureInfo_)) == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					gClass = (GClass3)(object)((Class7)(object)Class5.Default).t(bindingFlags, fieldInfo_, obj, null);
				}
				else
				{
					qk = (Qk7)(object)Class5.Default;
					class21 = class21;
				}
			}
			else
			{
				_ = (Struct1)Class5.Default;
			}
			goto IL_238e;
		}
		IL_16df:
		_ = (Struct1)@class.t(obj, null, cultureInfo_);
		if (num2 == 0)
		{
			while (obj != null)
			{
				Class7 obj85 = (Class7)(object)Class5.Default;
				Class7 class63 = @class;
				BindingFlags bindingFlags_40 = (BindingFlags)Class5.Default;
				Type[] type_9 = array;
				bindingFlags = default(BindingFlags);
				_ = (GClass3)(object)obj85.j(default(BindingFlags), (MethodBase[])(object)class63.W(bindingFlags_40, null, type_2, type_9, (ParameterModifier[])(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)Class5.Default, array2, (CultureInfo)null, string_, out reference2)), ref *(object[]*)null, null, cultureInfo_, string_, out *(object*)null);
			}
		}
		if (unchecked((nuint)default(UIntPtr)) / (nuint)(UIntPtr)Class5.Default == 0)
		{
			num2 = default(UIntPtr);
			if (num2 == (UIntPtr)(nuint)0u)
			{
				if (num2 == (UIntPtr)(nuint)0u)
				{
					class20 = class20;
					class31 = class31;
				}
				else
				{
					@class = (Class7)(object)((Class7)(object)Class5.Default).e(bindingFlags, methodBase_, array, array2);
				}
			}
			else if (num2 == (UIntPtr)(nuint)0u)
			{
				class31 = (Class2)(object)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, array3, null, (Type[])(object)((Class7)null).e(bindingFlags, (MethodBase[])null, array, (ParameterModifier[])null), (ParameterModifier[])(object)Class5.Default);
				class31 = class31;
				_003CModule_003E = _003CModule_003E;
				gClass4 = gClass4;
			}
			else
			{
				_ = Class5.Default;
			}
		}
		do
		{
			num2 = default(UIntPtr);
			if (num2 == 0)
			{
				_ = (GClass2)(object)Class5.Default;
				gClass2 = null;
			}
		}
		while ((object)Class5.Default != null);
		_ = (Class6)(object)Class5.Default;
		try
		{
			while (obj != null)
			{
				Class7 class64 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_41 = bindingFlags;
				bindingFlags = default(BindingFlags);
				if ((UIntPtr)class64.t(bindingFlags_41, fieldInfo_, ((Class7)null).t((BindingFlags)((Class7)null).e(bindingFlags, methodBase_, array, (ParameterModifier[])null), fieldInfo_, obj, cultureInfo_), cultureInfo_) == (UIntPtr)(nuint)0u)
				{
					_003CModule_003E = null;
					class31 = class31;
					_ = (Class2)(object)Class5.Default;
					class22 = (Class9)((Class7)null).t((object)Class5.Default, (Type)null, (CultureInfo)null);
				}
			}
		}
		catch
		{
			try
			{
				do
				{
					_ = (Struct2)((Class7)(object)Class5.Default).t(null, (Type)((Class7)(object)@class.W(bindingFlags, null, null, array, array2)).t(((Class7)(object)@class.W((BindingFlags)Class5.Default, array3, null, null, array2)).e(bindingFlags, methodBase_, array, null), type_2, null), (CultureInfo)(object)Class5.Default);
				}
				while (obj != null);
			}
			catch
			{
				while (true)
				{
					_ = (GClass2)(object)Class5.Default;
					if (obj != null)
					{
						continue;
					}
					goto end_IL_19eb;
				}
				end_IL_19eb:;
			}
		}
		try
		{
			try
			{
				_ = (Class4)(object)@class.j((BindingFlags)@class.j(bindingFlags, null, ref reference, array2, (CultureInfo)(object)Class5.Default, null, out *(object*)Class5.Default), null, ref *(object[]*)null, null, null, string_, out reference2);
				_ = (Class9)(object)Class5.Default;
			}
			finally
			{
				class33 = (Class5)(object)((Class7)(object)((Class7)(object)Class5.Default).W(bindingFlags, null, type_2, (Type[])(object)Class5.Default, array2)).t(bindingFlags, fieldInfo_, null, (CultureInfo)(object)Class5.Default);
				goto end_IL_1a03;
			}
			end_IL_1a03:;
		}
		catch
		{
			_ = (Class6)(object)Class5.Default;
		}
		finally
		{
			BindingFlags bindingFlags_42;
			ref object[] object_24;
			string[] string_2;
			BindingFlags bindingFlags_43;
			Type[] type_10;
			Class7 class65;
			do
			{
				UIntPtr num9 = (UIntPtr)Class5.Default;
				nuint num10 = num2;
				num2 = default(UIntPtr);
				checked
				{
					nuint num11 = unchecked((nuint)num9) * (unchecked(num10 / num2) - num2) + unchecked((nuint)default(UIntPtr));
					num2 = default(UIntPtr);
					if (num11 + num2 == 0)
					{
						_ = (Class8)@class.t(obj, null, cultureInfo_);
					}
				}
				bindingFlags_42 = (BindingFlags)Class5.Default;
				object_24 = ref *(object[]*)Class5.Default;
				string_2 = (string[])(object)((Class7)null).W(bindingFlags, array3, type_2, array, array2);
				bindingFlags_43 = bindingFlags;
				type_10 = (Type[])(object)Class5.Default;
				class65 = @class;
				bindingFlags = default(BindingFlags);
			}
			while ((object)((Class7)null).j(bindingFlags_42, (MethodBase[])null, ref object_24, (ParameterModifier[])null, cultureInfo_, string_2, out *(object*)((Class7)null).e(bindingFlags_43, (MethodBase[])null, type_10, (ParameterModifier[])(object)class65.t(default(BindingFlags), null, null, (CultureInfo)(object)((Class7)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)((Class7)null).e(bindingFlags, methodBase_, array, (ParameterModifier[])null), type_2, array, (ParameterModifier[])(object)Class5.Default)).j(bindingFlags, null, ref reference, null, null, string_, out reference2)))) != null);
			goto IL_1dce;
		}
	}

	unsafe static void smethod_6()
	{
		Class7 obj = (Class7)(object)Class5.Default;
		object obj2 = obj2;
		object object_ = obj2;
		Type type_ = null;
		CultureInfo cultureInfo = cultureInfo;
		Class7 obj3 = (Class7)obj.t(object_, type_, cultureInfo);
		BindingFlags bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_ = bindingFlags;
		FieldInfo[] array = array;
		Class7 @class = (Class7)(object)obj3.t(bindingFlags_, array, null, cultureInfo);
		Class7 class2 = @class;
		BindingFlags bindingFlags_2 = bindingFlags;
		PropertyInfo[] propertyInfo_ = (PropertyInfo[])(object)Class5.Default;
		Type[] array2 = null;
		ParameterModifier[] parameterModifier_ = null;
		nuint uIntPtr = (UIntPtr)class2.W(bindingFlags_2, propertyInfo_, type_, array2, parameterModifier_);
		uIntPtr = default(UIntPtr);
		Class9 class3;
		if (checked(uIntPtr * uIntPtr) == 0)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				_ = (Struct2)Class5.Default;
			}
		}
		else
		{
			class3 = (Class9)(object)Class5.Default;
			class3 = null;
		}
		Class4 class4 = class4;
		class4 = class4;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class6 class5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass0 gClass);
		do
		{
			try
			{
				if (uIntPtr == 0)
				{
					class5 = (Class6)(object)Class5.Default;
					class5 = class5;
				}
				else
				{
					class5 = class5;
				}
			}
			finally
			{
				try
				{
					_ = (GClass0)@class.t(null, null, null);
				}
				catch
				{
					_ = (Class6)(object)Class5.Default;
					@class = @class;
					Class7 class6 = @class;
					bindingFlags = default(BindingFlags);
					GClass0 obj4 = (GClass0)(object)class6.e(bindingFlags, (MethodBase[])(object)Class5.Default, null, (ParameterModifier[])(object)Class5.Default);
					gClass = (GClass0)((Class7)(object)Class5.Default).t(obj2, type_, (CultureInfo)(object)Class5.Default);
					gClass = obj4;
					_ = (Struct1)Class5.Default;
				}
				continue;
			}
		}
		while ((object)Class5.Default != null);
		_ = (GClass1)(object)Class5.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] array5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] array3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string[] array4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object[] reference2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct2 @struct);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class5 class7);
		try
		{
			try
			{
				_ = (Struct2)Class5.Default;
			}
			catch
			{
				class7 = class7;
				class7 = class7;
			}
		}
		catch
		{
			if (uIntPtr == 0)
			{
				Class7 obj7 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_3 = bindingFlags;
				Class7 class8 = @class;
				Class7 obj8 = (Class7)@class.t(obj2, null, cultureInfo);
				BindingFlags bindingFlags_4 = (BindingFlags)((Class7)(object)Class5.Default).e(bindingFlags, null, array2, parameterModifier_);
				array3 = array3;
				PropertyInfo[] propertyInfo_2 = array3;
				Class7 class9 = @class;
				BindingFlags bindingFlags_5 = bindingFlags;
				array4 = null;
				string[] string_ = array4;
				reference = ref reference;
				Type[] type_2 = (Type[])(object)class9.j(bindingFlags_5, null, ref *(object[]*)null, null, null, string_, out reference);
				Class7 class10 = @class;
				bindingFlags = default(BindingFlags);
				Class7 obj9 = (Class7)(object)obj8.W(bindingFlags_4, propertyInfo_2, null, type_2, (ParameterModifier[])(object)class10.t(bindingFlags, array, obj2, cultureInfo));
				BindingFlags bindingFlags_6 = bindingFlags;
				PropertyInfo[] propertyInfo_3 = (PropertyInfo[])(object)Class5.Default;
				Class7 class11 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_7 = bindingFlags;
				array5 = array5;
				Class7 obj10 = (Class7)(object)obj9.W(bindingFlags_6, propertyInfo_3, type_, array2, (ParameterModifier[])(object)class11.e(bindingFlags_7, array5, (Type[])(object)Class5.Default, parameterModifier_));
				BindingFlags bindingFlags_8 = (BindingFlags)Class5.Default;
				MethodBase[] methodBase_ = array5;
				reference2 = ref reference2;
				_ = (_003CModule_003E)(object)obj7.W(bindingFlags_3, (PropertyInfo[])(object)class8.e((BindingFlags)obj10.j(bindingFlags_8, methodBase_, ref reference2, parameterModifier_, cultureInfo, array4, out reference), null, (Type[])((Class7)(object)((Class7)(object)Class5.Default).j(bindingFlags, array5, ref reference2, (ParameterModifier[])(object)Class5.Default, cultureInfo, (string[])(object)((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, (ParameterModifier[])(object)@class.t(bindingFlags, null, obj2, cultureInfo)), out *(object*)null)).t(obj2, null, null), parameterModifier_), type_, array2, parameterModifier_);
			}
		}
		finally
		{
			try
			{
				if (uIntPtr == 0)
				{
					Class7 class12 = @class;
					bindingFlags = default(BindingFlags);
					Struct2 obj12 = (Struct2)class12.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj2, cultureInfo);
					@struct = @struct;
					@struct = obj12;
				}
			}
			catch
			{
				_ = (Class4)(object)@class.t(bindingFlags, (FieldInfo[])(object)@class.e(bindingFlags, array5, array2, null), Class5.Default, cultureInfo);
			}
			goto IL_0475;
		}
		IL_1645:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct1 struct2);
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				try
				{
					@struct = (Struct2)@class.j(bindingFlags, array5, ref reference2, (ParameterModifier[])(object)Class5.Default, null, null, out *(object*)null);
				}
				catch
				{
					class3 = null;
				}
			}
			else
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (Class7)(object)@class.t(bindingFlags, null, null, cultureInfo);
				}
			}
		}
		catch
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				struct2 = default(Struct1);
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass3 gClass3);
		GClass1 gClass2;
		try
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					class7 = Class5.Default;
				}
			}
			finally
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					@class = (Class7)(object)@class.j((BindingFlags)@class.W(bindingFlags, null, null, (Type[])(object)Class5.Default, null), (MethodBase[])(object)Class5.Default, ref *(object[]*)@class.t((BindingFlags)Class5.Default, array, obj2, cultureInfo), parameterModifier_, null, (string[])(object)@class.e(bindingFlags, null, (Type[])(object)Class5.Default, null), out reference);
				}
				else
				{
					gClass2 = (GClass1)(object)Class5.Default;
					@struct = default(Struct2);
					gClass3 = gClass3;
					_ = (GClass2)(object)Class5.Default;
				}
				goto end_IL_16dc;
			}
			end_IL_16dc:;
		}
		finally
		{
			do
			{
				_ = (Class5)(object)((Class7)null).e(bindingFlags, array5, array2, parameterModifier_);
			}
			while (obj2 != null || (object)Class5.Default != null);
			goto IL_17fd;
		}
		IL_4af5:
		struct2 = struct2;
		try
		{
			if ((UIntPtr)((Class7)null).W(bindingFlags, array3, type_, (Type[])null, parameterModifier_) == (UIntPtr)(nuint)0u)
			{
				class4 = class4;
			}
		}
		catch
		{
			checked
			{
				nuint num = unchecked((nuint)(UIntPtr)((Class7)null).j(bindingFlags, (MethodBase[])((Class7)(object)Class5.Default).t(obj2, type_, cultureInfo), ref *(object[]*)null, parameterModifier_, cultureInfo, array4, out reference)) + unchecked(unchecked((nuint)default(UIntPtr)) / (nuint)(UIntPtr)Class5.Default);
				uIntPtr = default(UIntPtr);
				nuint num2 = num + uIntPtr * uIntPtr;
				uIntPtr = default(UIntPtr);
				if (num2 + unchecked(uIntPtr / uIntPtr) == 0)
				{
					try
					{
						_ = (GClass1)((Class7)null).t((object)Class5.Default, type_, (CultureInfo)null);
					}
					finally
					{
						Class7 class13 = @class;
						bindingFlags = default(BindingFlags);
						_ = (GClass0)(object)class13.j(bindingFlags, array5, ref *unchecked((object[]*)null), parameterModifier_, cultureInfo, (string[])(object)Class5.Default, out reference);
						class3 = null;
						goto end_IL_4b28;
					}
				}
			}
			end_IL_4b28:;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass2 gClass4);
		if ((UIntPtr)((Class7)null).t((BindingFlags)@class.e(bindingFlags, null, array2, parameterModifier_), (FieldInfo[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)(object)Class5.Default, (Type[])(object)Class5.Default, parameterModifier_), @class.t(Class5.Default, type_, cultureInfo), cultureInfo) == (UIntPtr)(nuint)0u)
		{
			gClass4 = (GClass2)((Class7)@class.t(Class5.Default, null, cultureInfo)).t(obj2, (Type)(object)Class5.Default, null);
		}
		return;
		IL_341a:
		nuint num3 = uIntPtr;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class10 class14);
		if (checked((num3 + uIntPtr + unchecked((nuint)(UIntPtr)@class.j(bindingFlags, null, ref reference2, parameterModifier_, null, null, out reference)) + uIntPtr) * uIntPtr) == 0)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				class14 = null;
			}
			else
			{
				do
				{
					bindingFlags = default(BindingFlags);
					_ = (Class0)(object)((Class7)null).W(bindingFlags, array3, (Type)(object)@class.t(bindingFlags, null, obj2, (CultureInfo)(object)@class.W(bindingFlags, null, type_, array2, (ParameterModifier[])(object)@class.t((BindingFlags)Class5.Default, array, @class.j(bindingFlags, null, ref reference2, null, cultureInfo, null, out *(object*)null), null))), (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
				}
				while (obj2 != null);
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qk7 qk);
		if ((UIntPtr)@class.W((BindingFlags)Class5.Default, array3, type_, array2, parameterModifier_) == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					_ = (_003CModule_003E)(object)Class5.Default;
				}
				finally
				{
					class5 = null;
					goto end_IL_354a;
				}
				end_IL_354a:;
			}
			catch
			{
				do
				{
					gClass4 = gClass4;
					qk = qk;
					_ = (Class6)(object)Class5.Default;
				}
				while (obj2 != null);
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class8 class15);
		try
		{
			try
			{
				gClass2 = gClass2;
			}
			catch
			{
				while (obj2 != null)
				{
					class15 = class15;
				}
			}
		}
		catch
		{
			_ = (Struct2)Class5.Default;
			_ = (Class9)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type_, array2, (ParameterModifier[])null);
		}
		try
		{
		}
		finally
		{
			do
			{
				gClass3 = gClass3;
				_ = (Class0)(object)Class5.Default;
				_ = (GClass3)(object)Class5.Default;
			}
			while ((object)Class5.Default != null);
			goto IL_35fe;
		}
		IL_0f3b:
		@class = @class;
		_003CModule_003E _003CModule_003E = (_003CModule_003E)(object)@class.t(bindingFlags, null, ((Class7)(object)Class5.Default).e(bindingFlags, array5, (Type[])(object)Class5.Default, (ParameterModifier[])(object)@class.W(bindingFlags, null, (Type)((Class7)(object)((Class7)null).t(bindingFlags, array, (object)null, cultureInfo)).t(obj2, type_, cultureInfo), array2, parameterModifier_)), null);
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				Class7 class16 = @class;
				Class7 obj20 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				class14 = (Class10)(object)class16.j((BindingFlags)obj20.W(bindingFlags, null, null, null, null), array5, ref reference2, parameterModifier_, (CultureInfo)(object)Class5.Default, array4, out *(object*)null);
				class14 = class14;
			}
			else if (uIntPtr == 0)
			{
				qk = null;
				qk = qk;
			}
			else
			{
				_ = (GClass1)(object)Class5.Default;
				_ = (Class4)(object)Class5.Default;
				@class = @class;
			}
		}
		catch
		{
			if (uIntPtr == 0)
			{
				if (uIntPtr == 0)
				{
					gClass3 = gClass3;
				}
				else
				{
					_ = (GClass2)(object)Class5.Default;
				}
			}
		}
		do
		{
			IL_10d3:
			if ((object)Class5.Default != null)
			{
				try
				{
					gClass2 = (GClass1)(object)Class5.Default;
				}
				finally
				{
					gClass4 = null;
					gClass4 = null;
					goto IL_10d3;
				}
			}
		}
		while ((object)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, obj2, (CultureInfo)null) != null);
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				while (obj2 != null)
				{
					_ = (GClass3)(object)Class5.Default;
				}
			}
			finally
			{
				do
				{
					class15 = (Class8)@class.t(obj2, type_, null);
					class15 = null;
				}
				while (obj2 != null);
				goto IL_114a;
			}
		}
		class4 = class4;
		_ = (Class4)(object)Class5.Default;
		_ = (Class8)(object)Class5.Default;
		goto IL_114a;
		IL_17fd:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class2 class17);
		try
		{
			_ = (Struct1)Class5.Default;
		}
		finally
		{
			do
			{
				if (default(UIntPtr) != (UIntPtr)(nuint)0u)
				{
					class15 = (Class8)(object)((Class7)(object)Class5.Default).W(default(BindingFlags), (PropertyInfo[])(object)Class5.Default, null, null, null);
					continue;
				}
				class14 = class14;
				class17 = null;
				class17 = null;
				_ = (_003CModule_003E)(object)Class5.Default;
			}
			while (obj2 != null);
			goto IL_187c;
		}
		IL_2ceb:
		try
		{
			try
			{
				_ = (GClass2)(object)Class5.Default;
			}
			catch
			{
				try
				{
					class5 = null;
				}
				catch
				{
					class5 = null;
				}
			}
		}
		catch
		{
			if (uIntPtr == 0)
			{
				try
				{
					qk = (Qk7)(object)Class5.Default;
				}
				catch
				{
					gClass3 = gClass3;
					@class = null;
					Class7 class18 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class8)(object)((Class7)null).j((BindingFlags)((Class7)(object)class18.W((BindingFlags)((Class7)null).e((BindingFlags)((Class7)null).e(bindingFlags, (MethodBase[])((Class7)null).t((object)null, type_, (CultureInfo)null), array2, (ParameterModifier[])null), array5, array2, (ParameterModifier[])null), array3, type_, array2, null)).W(bindingFlags, array3, type_, array2, parameterModifier_), array5, ref *(object[]*)null, (ParameterModifier[])null, (CultureInfo)null, (string[])(object)Class5.Default, out reference);
				}
			}
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			nuint num4 = uIntPtr;
			uIntPtr = default(UIntPtr);
			if (num4 / uIntPtr == 0)
			{
				gClass4 = gClass4;
				_ = (GClass0)((Class7)null).t((object)Class5.Default, type_, cultureInfo);
				Class7 obj26 = (Class7)(object)Class5.Default;
				Class7 obj27 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				Class7 obj28 = (Class7)(object)((Class7)(object)((Class7)(object)obj27.W(bindingFlags, array3, (Type)(object)Class5.Default, (Type[])(object)Class5.Default, parameterModifier_)).j(bindingFlags, (MethodBase[])((Class7)null).t(obj2, (Type)null, cultureInfo), ref reference2, parameterModifier_, cultureInfo, (string[])(object)((Class7)(object)Class5.Default).W((BindingFlags)@class.t(Class5.Default, null, cultureInfo), null, type_, null, (ParameterModifier[])(object)Class5.Default), out reference)).e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, (ParameterModifier[])(object)Class5.Default);
				bindingFlags = default(BindingFlags);
				_ = (Class9)(object)obj26.W((BindingFlags)obj28.t(bindingFlags, null, Class5.Default, cultureInfo), array3, type_, array2, parameterModifier_);
			}
			else
			{
				Class7 class19 = @class;
				bindingFlags = default(BindingFlags);
				if ((UIntPtr)((Class7)(object)class19.W(bindingFlags, null, (Type)(object)((Class7)null).t(bindingFlags, array, (object)((Class7)null).t((BindingFlags)((Class7)null).W(bindingFlags, array3, type_, array2, (ParameterModifier[])(object)Class5.Default), array, obj2, (CultureInfo)(object)Class5.Default), cultureInfo), array2, null)).t(Class5.Default, (Type)(object)@class.e(bindingFlags, array5, (Type[])(object)Class5.Default, null), cultureInfo) == (UIntPtr)(nuint)0u)
				{
					_ = (Class5)(object)@class.e(bindingFlags, array5, (Type[])(object)Class5.Default, parameterModifier_);
				}
				else
				{
					gClass = (GClass0)(object)Class5.Default;
				}
			}
		}
		if (uIntPtr == 0)
		{
			_ = (GClass2)(object)Class5.Default;
			_ = (Class9)(object)Class5.Default;
			goto IL_3119;
		}
		try
		{
			gClass = gClass;
		}
		finally
		{
			try
			{
				_ = (Struct2)Class5.Default;
			}
			finally
			{
				class7 = class7;
				_ = (Class8)((Class7)null).t(obj2, (Type)null, cultureInfo);
				class14 = class14;
				gClass = gClass;
				goto IL_3119;
			}
		}
		IL_187c:
		Class7 class20 = @class;
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_9 = bindingFlags;
		Class7 obj29 = (Class7)(object)@class.W(bindingFlags, null, null, null, null);
		BindingFlags bindingFlags_10 = (BindingFlags)@class.t(((Class7)null).e(bindingFlags, (MethodBase[])null, array2, (ParameterModifier[])null), (Type)(object)@class.t(bindingFlags, array, Class5.Default, cultureInfo), (CultureInfo)(object)Class5.Default);
		Class7 class21 = @class;
		object object_2 = obj2;
		Class7 obj30 = (Class7)@class.t(Class5.Default, type_, cultureInfo);
		MethodBase[] methodBase_2 = array5;
		Class7 class22 = @class;
		bindingFlags = default(BindingFlags);
		Class0 class23 = (Class0)(object)class20.t((BindingFlags)((Class7)null).t(bindingFlags_9, (FieldInfo[])(object)obj29.t(bindingFlags_10, (FieldInfo[])(object)class21.t(default(BindingFlags), null, object_2, (CultureInfo)(object)obj30.e(default(BindingFlags), methodBase_2, array2, (ParameterModifier[])(object)class22.j(bindingFlags, null, ref reference2, null, cultureInfo, (string[])(object)((Class7)null).e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, (Type[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)null, array2, parameterModifier_), (ParameterModifier[])(object)Class5.Default), out *(object*)@class.W(bindingFlags, array3, type_, array2, null)))), Class5.Default, cultureInfo), (object)Class5.Default, cultureInfo), null, obj2, null);
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			gClass4 = gClass4;
		}
		checked
		{
			if (unchecked((nuint)(UIntPtr)@class.e(bindingFlags, array5, array2, null)) * uIntPtr == 0)
			{
				gClass2 = null;
			}
			else if (uIntPtr * ((uIntPtr + unchecked((nuint)(UIntPtr)@class.W(bindingFlags, array3, null, array2, parameterModifier_))) * unchecked((nuint)(UIntPtr)((Class7)null).j(bindingFlags, array5, ref *(object[]*)null, parameterModifier_, (CultureInfo)null, array4, out *(object*)Class5.Default))) == 0)
			{
				while (obj2 != null)
				{
					class17 = (Class2)((Class7)(object)((Class7)null).W(bindingFlags, array3, type_, (Type[])null, (ParameterModifier[])@class.t(null, type_, null))).t(obj2, null, cultureInfo);
				}
			}
			else
			{
				_ = (Class9)(object)Class5.Default;
				_ = Class5.Default;
				_ = (Class4)(object)Class5.Default;
				class4 = null;
			}
			_ = (Class10)(object)Class5.Default;
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_003CModule_003E = null;
			gClass3 = gClass3;
			class4 = null;
			class5 = class5;
		}
		else
		{
			try
			{
				try
				{
					BindingFlags bindingFlags_11 = bindingFlags;
					Class7 class24 = @class;
					BindingFlags bindingFlags_12 = bindingFlags;
					MethodBase[] methodBase_3 = array5;
					ref object[] object_3 = ref reference2;
					CultureInfo cultureInfo_ = cultureInfo;
					Class7 class25 = @class;
					Class7 class26 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass1)(object)((Class7)null).W(bindingFlags_11, (PropertyInfo[])null, type_, (Type[])null, (ParameterModifier[])(object)class24.j(bindingFlags_12, methodBase_3, ref object_3, parameterModifier_, cultureInfo_, (string[])(object)class25.t((BindingFlags)class26.t(bindingFlags, array, obj2, null), array, obj2, cultureInfo), out reference));
				}
				catch
				{
					bindingFlags = default(BindingFlags);
					class7 = (Class5)(object)((Class7)(object)((Class7)null).e(bindingFlags, array5, (Type[])null, (ParameterModifier[])(object)Class5.Default)).e(bindingFlags, array5, (Type[])(object)Class5.Default, parameterModifier_);
					_ = (GClass0)(object)Class5.Default;
					_ = (_003CModule_003E)@class.t(obj2, type_, cultureInfo);
				}
			}
			catch
			{
			}
		}
		uIntPtr = default(UIntPtr);
		checked
		{
			if (unchecked((nuint)default(UIntPtr)) * uIntPtr == 0)
			{
				try
				{
				}
				finally
				{
					try
					{
						class17 = class17;
					}
					catch
					{
						_ = (Class6)(object)Class5.Default;
					}
					goto IL_1de8;
				}
			}
			if (uIntPtr == 0)
			{
				MethodBase[] methodBase_4 = array5;
				bindingFlags = default(BindingFlags);
				_ = (Class0)(object)((Class7)null).e(default(BindingFlags), methodBase_4, (Type[])null, (ParameterModifier[])((Class7)(object)((Class7)null).e(bindingFlags, array5, (Type[])null, (ParameterModifier[])null)).t(Class5.Default, type_, null));
				_ = (GClass0)(object)Class5.Default;
			}
			goto IL_1de8;
		}
		IL_0475:
		try
		{
			try
			{
				do
				{
					Class7 class27 = @class;
					Class7 class28 = @class;
					bindingFlags = default(BindingFlags);
					Class7 obj34 = (Class7)(object)class28.j(bindingFlags, (MethodBase[])(object)((Class7)(object)((Class7)null).t(bindingFlags, array, (object)null, (CultureInfo)(object)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference2, parameterModifier_, cultureInfo, array4, out reference))).e(bindingFlags, null, (Type[])(object)Class5.Default, parameterModifier_), ref *(object[]*)Class5.Default, null, null, (string[])(object)Class5.Default, out reference);
					Class7 class29 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class10)(object)class27.e((BindingFlags)obj34.t((BindingFlags)class29.j(bindingFlags, (MethodBase[])(object)@class.t(bindingFlags, (FieldInfo[])(object)Class5.Default, @class.e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, parameterModifier_), cultureInfo), ref *(object[]*)null, null, cultureInfo, array4, out reference), null, null, cultureInfo), array5, (Type[])(object)Class5.Default, parameterModifier_);
					_ = (Class4)(object)((Class7)null).W((BindingFlags)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, parameterModifier_), (PropertyInfo[])null, type_, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
					Class0 obj35 = (Class0)(object)Class5.Default;
					class23 = class23;
					class23 = obj35;
					gClass3 = gClass3;
					gClass3 = gClass3;
				}
				while (obj2 != null);
			}
			catch
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					@struct = default(Struct2);
					@struct = @struct;
				}
				else
				{
					_ = (GClass2)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)@class.t(bindingFlags, null, null, cultureInfo), parameterModifier_, cultureInfo, array4, out reference);
				}
			}
		}
		catch
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				try
				{
					@struct = @struct;
					_ = (_003CModule_003E)@class.t(obj2, type_, cultureInfo);
				}
				finally
				{
					_ = (GClass1)(object)Class5.Default;
					goto end_IL_0690;
				}
			}
			do
			{
				Class7 obj37 = (Class7)(object)@class.t(bindingFlags, null, null, cultureInfo);
				BindingFlags bindingFlags_13 = bindingFlags;
				MethodBase[] methodBase_5 = array5;
				ref object[] object_4 = ref *(object[]*)Class5.Default;
				Class7 class30 = @class;
				Class7 class31 = @class;
				bindingFlags = default(BindingFlags);
				_ = (Qk7)(object)obj37.j(bindingFlags_13, methodBase_5, ref object_4, (ParameterModifier[])class30.t(class31.j(bindingFlags, array5, ref reference2, null, null, null, out reference), null, null), cultureInfo, (string[])(object)Class5.Default, out reference);
			}
			while ((object)Class5.Default != null);
			end_IL_0690:;
		}
		@struct = default(Struct2);
		try
		{
			while (true)
			{
				Class7 obj39 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_14 = bindingFlags;
				Class7 class32 = @class;
				BindingFlags bindingFlags_15 = bindingFlags;
				MethodBase[] methodBase_6 = array5;
				ParameterModifier[] parameterModifier_2 = (ParameterModifier[])(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, array2, parameterModifier_);
				BindingFlags bindingFlags_16 = bindingFlags;
				MethodBase[] methodBase_7 = array5;
				Class7 class33 = @class;
				BindingFlags bindingFlags_17 = (BindingFlags)Class5.Default;
				PropertyInfo[] propertyInfo_4 = array3;
				bindingFlags = default(BindingFlags);
				if ((object)obj39.W(bindingFlags_14, (PropertyInfo[])(object)class32.j(bindingFlags_15, methodBase_6, ref *(object[]*)null, parameterModifier_2, null, (string[])(object)((Class7)null).e(bindingFlags_16, methodBase_7, (Type[])null, (ParameterModifier[])(object)class33.W(bindingFlags_17, propertyInfo_4, (Type)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])null, parameterModifier_), (Type[])@class.t(obj2, null, cultureInfo), parameterModifier_)), out *(object*)Class5.Default), type_, null, parameterModifier_) != null)
				{
					try
					{
						_003CModule_003E obj40 = (_003CModule_003E)(object)Class5.Default;
						_003CModule_003E = _003CModule_003E;
						_003CModule_003E = obj40;
					}
					finally
					{
						_ = (Class8)(object)Class5.Default;
						continue;
					}
				}
				break;
			}
		}
		catch
		{
			_ = (GClass1)(object)Class5.Default;
		}
		BindingFlags bindingFlags_18 = (BindingFlags)Class5.Default;
		MethodBase[] methodBase_8 = array5;
		Class7 class34 = @class;
		BindingFlags bindingFlags_19 = bindingFlags;
		MethodBase[] methodBase_9 = (MethodBase[])(object)((Class7)null).j((BindingFlags)((Class7)null).j(bindingFlags, array5, ref *(object[]*)Class5.Default, (ParameterModifier[])null, (CultureInfo)null, (string[])(object)Class5.Default, out *(object*)((Class7)null).e(bindingFlags, array5, array2, (ParameterModifier[])(object)((Class7)null).j(bindingFlags, array5, ref *(object[]*)Class5.Default, parameterModifier_, cultureInfo, array4, out reference))), array5, ref *(object[]*)@class.W((BindingFlags)Class5.Default, array3, (Type)(object)Class5.Default, null, parameterModifier_), parameterModifier_, cultureInfo, array4, out *(object*)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])null, (object)Class5.Default, cultureInfo));
		Class7 obj42 = (Class7)(object)Class5.Default;
		Class7 class35 = @class;
		bindingFlags = default(BindingFlags);
		_ = (Class2)(object)((Class7)null).j(bindingFlags_18, methodBase_8, ref *(object[]*)class34.e(bindingFlags_19, methodBase_9, (Type[])(object)obj42.t(default(BindingFlags), (FieldInfo[])((Class7)(object)class35.e(bindingFlags, array5, array2, parameterModifier_)).t(null, (Type)(object)Class5.Default, cultureInfo), Class5.Default, (CultureInfo)(object)Class5.Default), parameterModifier_), (ParameterModifier[])(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)null, parameterModifier_, (CultureInfo)(object)@class.e((BindingFlags)Class5.Default, null, null, null), (string[])null, out *(object*)null), (CultureInfo)(object)Class5.Default, array4, out *(object*)Class5.Default);
		while (obj2 != null)
		{
			if ((UIntPtr)@class.W(bindingFlags, null, (Type)((Class7)(object)Class5.Default).t(obj2, type_, cultureInfo), array2, null) == (UIntPtr)(nuint)0u && (UIntPtr)((Class7)(object)Class5.Default).t(null, type_, (CultureInfo)(object)Class5.Default) == (UIntPtr)(nuint)0u)
			{
				_ = (Class7)(object)Class5.Default;
			}
		}
		class5 = class5;
		gClass2 = null;
		gClass2 = null;
		Class7 class36 = @class;
		bindingFlags = default(BindingFlags);
		_ = (Struct2)class36.e(bindingFlags, array5, array2, null);
		do
		{
			try
			{
				Class7 obj43 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				_ = (Class6)(object)obj43.t(bindingFlags, (FieldInfo[])(object)((Class7)null).W(bindingFlags, array3, type_, (Type[])null, (ParameterModifier[])(object)Class5.Default), null, (CultureInfo)(object)Class5.Default);
			}
			catch
			{
				_003CModule_003E = null;
				_ = (GClass1)@class.t(null, type_, (CultureInfo)(object)((Class7)null).j((BindingFlags)Class5.Default, array5, ref *(object[]*)Class5.Default, (ParameterModifier[])null, cultureInfo, (string[])null, out reference));
			}
		}
		while (obj2 != null);
		_ = (Struct2)Class5.Default;
		while (obj2 != null)
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					Class7 class37 = @class;
					BindingFlags bindingFlags_20 = bindingFlags;
					PropertyInfo[] propertyInfo_5 = array3;
					BindingFlags bindingFlags_21 = bindingFlags;
					MethodBase[] methodBase_10 = array5;
					ref object[] object_5 = ref reference2;
					Class7 class38 = @class;
					bindingFlags = default(BindingFlags);
					_ = (GClass0)(object)class37.W(bindingFlags_20, propertyInfo_5, type_, (Type[])(object)((Class7)null).j(bindingFlags_21, methodBase_10, ref object_5, parameterModifier_, (CultureInfo)(object)class38.t(bindingFlags, null, obj2, null), (string[])((Class7)null).t((object)null, (Type)(object)Class5.Default, (CultureInfo)null), out *(object*)@class.t(bindingFlags, (FieldInfo[])(object)@class.t((BindingFlags)Class5.Default, array, null, cultureInfo), obj2, null)), null);
				}
				catch
				{
					_ = (Class4)(object)Class5.Default;
					_ = (Class7)(object)Class5.Default;
					_ = (_003CModule_003E)(object)Class5.Default;
				}
			}
			else
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					Class7 class39 = @class;
					BindingFlags bindingFlags_22 = bindingFlags;
					Type[] type_3 = (Type[])(object)((Class7)null).W(bindingFlags, array3, type_, array2, parameterModifier_);
					Class7 obj46 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Class7)(object)((Class7)(object)class39.W(bindingFlags_22, null, type_, type_3, (ParameterModifier[])(object)obj46.t(bindingFlags, array, null, (CultureInfo)(object)Class5.Default))).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, null, cultureInfo, array4, out reference);
				}
				else
				{
					Class7 class40 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Struct2)class40.j(bindingFlags, array5, ref reference2, parameterModifier_, cultureInfo, array4, out reference);
				}
			}
		}
		try
		{
			try
			{
				_ = (Class10)(object)Class5.Default;
			}
			finally
			{
				Class7 class41;
				BindingFlags bindingFlags_23;
				MethodBase[] methodBase_11;
				CultureInfo cultureInfo_2;
				string[] string_2;
				Class7 class43;
				Class7 class44;
				do
				{
					class4 = (Class4)(object)Class5.Default;
					class41 = @class;
					bindingFlags_23 = (BindingFlags)@class.j((BindingFlags)Class5.Default, array5, ref *(object[]*)null, parameterModifier_, (CultureInfo)(object)Class5.Default, array4, out *(object*)Class5.Default);
					methodBase_11 = array5;
					Class7 class42 = @class;
					bindingFlags = default(BindingFlags);
					cultureInfo_2 = (CultureInfo)(object)class42.t(bindingFlags, null, ((Class7)@class.t(obj2, type_, cultureInfo)).e(bindingFlags, array5, array2, parameterModifier_), cultureInfo);
					string_2 = array4;
					class43 = @class;
					class44 = @class;
					bindingFlags = default(BindingFlags);
				}
				while ((object)class41.j(bindingFlags_23, methodBase_11, ref *(object[]*)null, parameterModifier_, cultureInfo_2, string_2, out *(object*)((Class7)(object)class43.j((BindingFlags)class44.W(bindingFlags, array3, type_, array2, parameterModifier_), null, ref *(object[]*)null, (ParameterModifier[])(object)((Class7)null).j(bindingFlags, array5, ref *(object[]*)@class.t(@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type_, array2, parameterModifier_), null, (CultureInfo)(object)Class5.Default), (ParameterModifier[])null, cultureInfo, (string[])(object)Class5.Default, out *(object*)Class5.Default), null, (string[])(object)@class.e(bindingFlags, null, null, parameterModifier_), out reference)).e((BindingFlags)Class5.Default, array5, array2, parameterModifier_)) != null);
				goto end_IL_0d79;
			}
			end_IL_0d79:;
		}
		finally
		{
			gClass2 = gClass2;
			goto IL_0f3b;
		}
		IL_114a:
		if (uIntPtr == 0)
		{
			while (obj2 != null)
			{
			}
		}
		Class7 obj47 = (Class7)(object)Class5.Default;
		object object_6 = ((Class7)(object)Class5.Default).W(bindingFlags, array3, type_, array2, (ParameterModifier[])@class.t(obj2, type_, (CultureInfo)(object)Class5.Default));
		bindingFlags = default(BindingFlags);
		_ = (Class10)obj47.t(object_6, (Type)(object)((Class7)null).j(bindingFlags, array5, ref reference2, (ParameterModifier[])@class.t(obj2, type_, null), cultureInfo, (string[])null, out reference), cultureInfo);
		do
		{
			try
			{
				try
				{
					gClass3 = null;
					class7 = class7;
					Class7 obj48 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_24 = (BindingFlags)Class5.Default;
					FieldInfo[] fieldInfo_ = (FieldInfo[])(object)Class5.Default;
					Class7 class45 = @class;
					Class7 class46 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class10)(object)((Class7)null).t((BindingFlags)obj48.t(bindingFlags_24, fieldInfo_, null, (CultureInfo)(object)class45.W((BindingFlags)class46.t(((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)null, array2, parameterModifier_), null, (CultureInfo)(object)Class5.Default), array3, null, array2, null)), array, obj2, (CultureInfo)null);
					_ = (_003CModule_003E)(object)Class5.Default;
				}
				finally
				{
					Class7 class47 = @class;
					BindingFlags bindingFlags_25 = bindingFlags;
					PropertyInfo[] propertyInfo_6 = array3;
					Class7 obj49 = (Class7)(object)@class.t(bindingFlags, (FieldInfo[])((Class7)(object)@class.e(bindingFlags, null, null, (ParameterModifier[])(object)@class.j(bindingFlags, (MethodBase[])((Class7)null).t((object)null, type_, cultureInfo), ref reference2, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)((Class7)null).t(bindingFlags, array, obj2, cultureInfo), (string[])(object)Class5.Default, out reference))).t(obj2, type_, cultureInfo), obj2, (CultureInfo)(object)Class5.Default);
					BindingFlags bindingFlags_26 = (BindingFlags)Class5.Default;
					FieldInfo[] fieldInfo_2 = array;
					Class7 class48 = @class;
					bindingFlags = default(BindingFlags);
					gClass = (GClass0)(object)class47.W(bindingFlags_25, propertyInfo_6, null, array2, (ParameterModifier[])(object)obj49.t(bindingFlags_26, fieldInfo_2, null, (CultureInfo)(object)class48.t(bindingFlags, array, obj2, null)));
					goto end_IL_11f5;
				}
				end_IL_11f5:;
			}
			finally
			{
				_ = (Class4)(object)Class5.Default;
				continue;
			}
		}
		while ((object)Class5.Default != null);
		while (true)
		{
			BindingFlags bindingFlags_27 = bindingFlags;
			FieldInfo[] fieldInfo_3 = (FieldInfo[])(object)Class5.Default;
			object object_7 = obj2;
			Class7 class49 = @class;
			BindingFlags bindingFlags_28 = bindingFlags;
			BindingFlags bindingFlags_29 = bindingFlags;
			MethodBase[] methodBase_12 = array5;
			bindingFlags = default(BindingFlags);
			if (((Class7)null).t((object)((Class7)null).t(bindingFlags_27, fieldInfo_3, object_7, (CultureInfo)(object)class49.t(bindingFlags_28, (FieldInfo[])(object)((Class7)null).j(bindingFlags_29, methodBase_12, ref *(object[]*)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)null, array2, parameterModifier_), (ParameterModifier[])null, cultureInfo, array4, out reference), obj2, cultureInfo)), (Type)(object)((Class7)(object)((Class7)null).t(bindingFlags, array, (object)Class5.Default, cultureInfo)).W((BindingFlags)((Class7)(object)Class5.Default).W(bindingFlags, null, (Type)(object)Class5.Default, array2, parameterModifier_), array3, type_, (Type[])(object)Class5.Default, (ParameterModifier[])(object)@class.j(bindingFlags, array5, ref reference2, parameterModifier_, cultureInfo, array4, out reference)), cultureInfo) != null)
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					class23 = null;
				}
				continue;
			}
			break;
		}
		while (obj2 != null)
		{
			uIntPtr = default(UIntPtr);
			if (checked(uIntPtr * uIntPtr) == 0)
			{
				try
				{
					_003CModule_003E = (_003CModule_003E)(object)@class.j(bindingFlags, array5, ref *(object[]*)Class5.Default, null, null, array4, out *(object*)Class5.Default);
				}
				finally
				{
					_ = (Class5)(object)@class.e(bindingFlags, array5, null, parameterModifier_);
					continue;
				}
			}
		}
		@struct = default(Struct2);
		_ = (_003CModule_003E)(object)Class5.Default;
		class23 = null;
		_003CModule_003E = _003CModule_003E;
		try
		{
			while (obj2 != null)
			{
				_ = (GClass3)(object)@class.e((BindingFlags)Class5.Default, null, (Type[])(object)Class5.Default, parameterModifier_);
				_ = (_003CModule_003E)(object)((Class7)null).W((BindingFlags)Class5.Default, array3, type_, (Type[])(object)@class.t(bindingFlags, array, null, (CultureInfo)@class.t(obj2, type_, null)), parameterModifier_);
				struct2 = (Struct1)@class.t(Class5.Default, null, null);
			}
		}
		finally
		{
			class3 = null;
			goto IL_1645;
		}
		IL_32a7:
		Class7 class50 = @class;
		Class7 class51 = @class;
		bindingFlags = default(BindingFlags);
		_ = (Class10)((Class7)class50.t(class51.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, (Type[])(object)Class5.Default, parameterModifier_), null, null)).t(obj2, (Type)(object)Class5.Default, null);
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			while (true)
			{
				if (obj2 != null)
				{
					class17 = null;
				}
				else if ((object)@class.e(bindingFlags, null, null, (ParameterModifier[])(object)Class5.Default) == null)
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
				_ = (_003CModule_003E)(object)Class5.Default;
			}
		}
		do
		{
			if ((UIntPtr)Class5.Default != (UIntPtr)(nuint)0u)
			{
				_ = (Class6)(object)@class.e(bindingFlags, null, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
			}
			else if (checked(unchecked((nuint)(UIntPtr)Class5.Default) + uIntPtr) == 0)
			{
				bindingFlags = default(BindingFlags);
				_ = (Struct1)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj2, cultureInfo);
			}
		}
		while (obj2 != null);
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr / uIntPtr == 0)
				{
					_ = (GClass1)(object)Class5.Default;
				}
			}
		}
		finally
		{
			_ = (GClass3)(object)Class5.Default;
			goto IL_341a;
		}
		IL_3b2f:
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					class4 = (Class4)@class.t(Class5.Default, (Type)((Class7)(object)@class.t((BindingFlags)Class5.Default, array, obj2, cultureInfo)).t(null, null, cultureInfo), (CultureInfo)(object)((Class7)null).W(bindingFlags, array3, type_, (Type[])null, (ParameterModifier[])null));
				}
				else
				{
					_ = (Class10)(object)@class.j((BindingFlags)Class5.Default, null, ref *(object[]*)null, parameterModifier_, cultureInfo, (string[])(object)((Class7)null).t(bindingFlags, array, (object)null, cultureInfo), out *(object*)Class5.Default);
				}
			}
			else
			{
				_ = (Class0)(object)Class5.Default;
				@class = null;
				bindingFlags = default(BindingFlags);
				_ = (Class7)(object)((Class7)null).t(bindingFlags, array, obj2, (CultureInfo)null);
			}
		}
		@struct = @struct;
		struct2 = struct2;
		_ = (Class8)(object)Class5.Default;
		Class7 class52 = @class;
		BindingFlags bindingFlags_30 = (BindingFlags)@class.j((BindingFlags)@class.j((BindingFlags)((Class7)(object)@class.W(bindingFlags, array3, type_, null, null)).t(bindingFlags, null, obj2, cultureInfo), (MethodBase[])(object)((Class7)null).W(bindingFlags, array3, type_, (Type[])null, (ParameterModifier[])(object)Class5.Default), ref reference2, null, null, array4, out reference), (MethodBase[])(object)Class5.Default, ref reference2, parameterModifier_, cultureInfo, array4, out reference);
		Class7 class53 = @class;
		bindingFlags = default(BindingFlags);
		PropertyInfo[] propertyInfo_7 = (PropertyInfo[])(object)class53.j(bindingFlags, array5, ref *(object[]*)null, parameterModifier_, cultureInfo, (string[])(object)Class5.Default, out *(object*)@class.W(bindingFlags, array3, null, (Type[])(object)((Class7)null).t(bindingFlags, array, (object)Class5.Default, (CultureInfo)null), parameterModifier_));
		Class7 class54 = @class;
		bindingFlags = default(BindingFlags);
		Class7 obj50 = (Class7)(object)class54.W(bindingFlags, array3, (Type)(object)@class.t(bindingFlags, null, @class.e(bindingFlags, null, null, parameterModifier_), null), null, null);
		bindingFlags = default(BindingFlags);
		Type type_4 = (Type)(object)obj50.j(bindingFlags, array5, ref reference2, parameterModifier_, null, array4, out *(object*)null);
		Class7 class55 = @class;
		Class7 obj51 = (Class7)(object)@class.e(bindingFlags, array5, array2, parameterModifier_);
		bindingFlags = default(BindingFlags);
		Class7 obj52 = (Class7)(object)class52.W((BindingFlags)((Class7)null).W(bindingFlags_30, propertyInfo_7, type_4, (Type[])(object)class55.e((BindingFlags)obj51.j(bindingFlags, null, ref reference2, parameterModifier_, null, (string[])((Class7)null).t((object)null, (Type)null, cultureInfo), out reference), null, array2, parameterModifier_), (ParameterModifier[])null), array3, type_, array2, (ParameterModifier[])(object)Class5.Default);
		BindingFlags bindingFlags_31 = bindingFlags;
		PropertyInfo[] propertyInfo_8 = array3;
		Class7 obj53 = (Class7)(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, (object)null, (CultureInfo)null);
		BindingFlags bindingFlags_32 = bindingFlags;
		bindingFlags = default(BindingFlags);
		Class7 obj54 = (Class7)(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, (ParameterModifier[])null, (CultureInfo)(object)((Class7)((Class7)null).t(obj2, (Type)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)null, (CultureInfo)null), (CultureInfo)null)).t(bindingFlags, array, obj2, (CultureInfo)@class.t(null, type_, (CultureInfo)(object)Class5.Default)), (string[])null, out reference);
		Class7 class56 = @class;
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_33 = (BindingFlags)((Class7)(object)((Class7)null).W(bindingFlags, array3, (Type)(object)Class5.Default, (Type[])(object)((Class7)(object)((Class7)null).e(bindingFlags, array5, (Type[])null, parameterModifier_)).j((BindingFlags)Class5.Default, array5, ref *(object[]*)@class.t(null, type_, cultureInfo), (ParameterModifier[])(object)@class.e(bindingFlags, array5, (Type[])@class.t(obj2, (Type)(object)Class5.Default, cultureInfo), parameterModifier_), cultureInfo, null, out *(object*)Class5.Default), (ParameterModifier[])null)).e(bindingFlags, null, null, null);
		PropertyInfo[] propertyInfo_9 = array3;
		Class7 obj55 = (Class7)(object)Class5.Default;
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_34 = bindingFlags;
		Type[] type_5 = (Type[])(object)((Class7)(object)Class5.Default).e(bindingFlags, array5, (Type[])(object)@class.W(default(BindingFlags), (PropertyInfo[])(object)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, (PropertyInfo[])(object)@class.t((BindingFlags)Class5.Default, null, null, cultureInfo), type_, array2, parameterModifier_), type_, null, parameterModifier_), parameterModifier_);
		Class7 class57 = @class;
		BindingFlags bindingFlags_35 = (BindingFlags)@class.t(obj2, (Type)(object)Class5.Default, cultureInfo);
		Class7 class58 = @class;
		Class7 class59 = @class;
		bindingFlags = default(BindingFlags);
		if ((UIntPtr)obj52.W(bindingFlags_31, propertyInfo_8, (Type)(object)obj53.e(bindingFlags_32, (MethodBase[])obj54.t(class56.W(bindingFlags_33, propertyInfo_9, null, (Type[])(object)obj55.W(bindingFlags_34, null, null, type_5, (ParameterModifier[])(object)class57.e(bindingFlags_35, null, array2, (ParameterModifier[])(object)class58.t((BindingFlags)class59.j(bindingFlags, array5, ref reference2, parameterModifier_, cultureInfo, null, out reference), array, obj2, (CultureInfo)(object)Class5.Default))), (ParameterModifier[])(object)Class5.Default), type_, cultureInfo), (Type[])(object)Class5.Default, null), null, parameterModifier_) == (UIntPtr)(nuint)0u)
		{
			class14 = class14;
		}
		@struct = default(Struct2);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			Class7 class60 = @class;
			BindingFlags bindingFlags_36 = bindingFlags;
			MethodBase[] methodBase_13 = array5;
			ref object[] object_8 = ref reference2;
			ParameterModifier[] parameterModifier_3 = (ParameterModifier[])(object)Class5.Default;
			Class7 obj56 = (Class7)(object)@class.j(bindingFlags, null, ref reference2, (ParameterModifier[])(object)((Class7)@class.t(null, type_, null)).W(bindingFlags, array3, (Type)@class.t(obj2, type_, null), null, null), null, null, out reference);
			BindingFlags bindingFlags_37 = bindingFlags;
			BindingFlags bindingFlags_38 = bindingFlags;
			Class7 class61 = @class;
			object object_9 = obj2;
			Class7 class62 = @class;
			Class7 obj57 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_39 = (BindingFlags)Class5.Default;
			Class7 obj58 = (Class7)(object)Class5.Default;
			Class7 obj59 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)class60.j(bindingFlags_36, methodBase_13, ref object_8, parameterModifier_3, (CultureInfo)(object)obj56.e(bindingFlags_37, (MethodBase[])(object)((Class7)null).t(bindingFlags_38, (FieldInfo[])class61.t(object_9, (Type)(object)((Class7)class62.t(((Class7)null).j(default(BindingFlags), (MethodBase[])null, ref *(object[]*)obj57.t(bindingFlags_39, (FieldInfo[])(object)obj58.e((BindingFlags)obj59.e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, parameterModifier_), array5, array2, parameterModifier_), obj2, cultureInfo), (ParameterModifier[])null, (CultureInfo)null, (string[])null, out reference), (Type)(object)Class5.Default, cultureInfo)).j(bindingFlags, array5, ref reference2, null, (CultureInfo)(object)Class5.Default, array4, out *(object*)null), cultureInfo), (object)Class5.Default, cultureInfo), (Type[])(object)Class5.Default, parameterModifier_), array4, out *(object*)null) != (UIntPtr)(nuint)0u)
			{
			}
		}
		else if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			if (checked(unchecked((nuint)default(UIntPtr)) * (unchecked((nuint)(UIntPtr)Class5.Default) - unchecked((nuint)(UIntPtr)@class.t(bindingFlags, array, Class5.Default, (CultureInfo)(object)Class5.Default)))) == 0)
			{
				_ = (Class9)(object)Class5.Default;
				_ = (Class10)(object)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, null, array2, null);
				qk = qk;
				class4 = null;
			}
		}
		else
		{
			@class = null;
		}
		_ = (Qk7)(object)Class5.Default;
		try
		{
			try
			{
				try
				{
					class17 = class17;
					_ = (Class0)(object)Class5.Default;
					_ = (Struct2)Class5.Default;
				}
				catch
				{
					_ = (Qk7)(object)Class5.Default;
				}
			}
			catch
			{
				try
				{
					_ = (GClass1)(object)Class5.Default;
				}
				catch
				{
					class17 = class17;
					_ = (GClass0)(object)Class5.Default;
				}
			}
		}
		catch
		{
			_ = (Class8)(object)((Class7)null).t(default(BindingFlags), array, obj2, (CultureInfo)null);
		}
		_ = (Class8)(object)Class5.Default;
		while (obj2 != null)
		{
			class23 = null;
		}
		Class7 class63 = @class;
		bindingFlags = default(BindingFlags);
		_ = (Class6)(object)class63.j(bindingFlags, (MethodBase[])(object)@class.W((BindingFlags)Class5.Default, array3, type_, array2, parameterModifier_), ref *(object[]*)@class.t(bindingFlags, array, null, (CultureInfo)(object)((Class7)null).j((BindingFlags)@class.j(bindingFlags, null, ref reference2, null, null, null, out *(object*)Class5.Default), array5, ref *(object[]*)null, parameterModifier_, (CultureInfo)null, (string[])(object)Class5.Default, out *(object*)null)), null, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out reference);
		try
		{
			do
			{
				class3 = class3;
			}
			while (((Class7)null).t(obj2, (Type)null, cultureInfo) != null || (object)@class.t((BindingFlags)Class5.Default, array, obj2, cultureInfo) != null);
		}
		finally
		{
			while ((object)((Class7)@class.t(Class5.Default, null, cultureInfo)).t(bindingFlags, array, null, cultureInfo) != null)
			{
				_003CModule_003E = null;
			}
			goto IL_45cf;
		}
		IL_1de8:
		do
		{
			if (uIntPtr != 0)
			{
				do
				{
					_ = (GClass1)(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)Class5.Default, (CultureInfo)(object)Class5.Default);
				}
				while (obj2 != null);
				continue;
			}
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				_ = (Class10)(object)Class5.Default;
				_ = (Struct1)Class5.Default;
				class23 = null;
				@struct = (Struct2)Class5.Default;
			}
			else
			{
				_ = (Class9)(object)Class5.Default;
				class4 = class4;
				gClass2 = null;
			}
		}
		while ((object)((Class7)(object)@class.W(bindingFlags, array3, null, array2, null)).e(bindingFlags, (MethodBase[])(object)@class.e(bindingFlags, array5, null, parameterModifier_), array2, parameterModifier_) != null);
		_ = (Class5)@class.t(null, null, cultureInfo);
		while (obj2 != null)
		{
			_ = (Class10)(object)Class5.Default;
			class3 = (Class9)(object)Class5.Default;
			_ = (Struct2)Class5.Default;
		}
		do
		{
			_ = (Class0)(object)((Class7)null).t(bindingFlags, array, (object)Class5.Default, (CultureInfo)null);
			gClass4 = gClass4;
			_ = (Qk7)(object)@class.j(bindingFlags, array5, ref reference2, null, cultureInfo, null, out reference);
			_ = (Class0)(object)Class5.Default;
		}
		while ((object)Class5.Default != null);
		if (checked(uIntPtr - (unchecked((nuint)(UIntPtr)Class5.Default / unchecked((nuint)default(UIntPtr))) - unchecked((nuint)default(UIntPtr)))) == 0)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				Class7 obj64 = (Class7)(object)Class5.Default;
				Class7 class64 = @class;
				BindingFlags bindingFlags_40 = bindingFlags;
				MethodBase[] methodBase_14 = (MethodBase[])(object)Class5.Default;
				ref object[] object_10 = ref reference2;
				string[] string_3 = array4;
				BindingFlags bindingFlags_41 = bindingFlags;
				FieldInfo[] fieldInfo_4 = array;
				bindingFlags = default(BindingFlags);
				_ = (Struct2)obj64.t(null, (Type)(object)class64.j(bindingFlags_40, methodBase_14, ref object_10, parameterModifier_, null, string_3, out *(object*)((Class7)null).t(bindingFlags_41, fieldInfo_4, (object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type_, (Type[])(object)Class5.Default, parameterModifier_), (CultureInfo)null)), null);
			}
			else
			{
				struct2 = struct2;
			}
		}
		gClass4 = (GClass2)(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)@class.j(bindingFlags, null, ref reference2, parameterModifier_, cultureInfo, array4, out reference), ref *(object[]*)null, parameterModifier_, cultureInfo, (string[])(object)Class5.Default, out *(object*)Class5.Default);
		class7 = (Class5)(object)@class.j((BindingFlags)((Class7)null).e(bindingFlags, (MethodBase[])(object)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])null, obj2, cultureInfo), array2, (ParameterModifier[])(object)Class5.Default), null, ref reference2, parameterModifier_, cultureInfo, (string[])(object)((Class7)null).e(bindingFlags, array5, array2, parameterModifier_), out *(object*)Class5.Default);
		_ = (Class4)(object)Class5.Default;
		@struct = (Struct2)Class5.Default;
		try
		{
			_ = (Class6)(object)Class5.Default;
		}
		catch
		{
			while (obj2 != null)
			{
				try
				{
					class3 = class3;
				}
				catch
				{
					_ = (Class0)(object)Class5.Default;
				}
			}
		}
		while (obj2 != null)
		{
			try
			{
				Class7 class65 = @class;
				object object_11 = obj2;
				Class7 class66 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_42 = bindingFlags;
				MethodBase[] methodBase_15 = array5;
				CultureInfo cultureInfo_3 = (CultureInfo)(object)((Class7)null).j((BindingFlags)@class.e((BindingFlags)Class5.Default, array5, array2, null), (MethodBase[])null, ref reference2, parameterModifier_, cultureInfo, array4, out reference);
				Class7 class67 = @class;
				BindingFlags bindingFlags_43 = (BindingFlags)((Class7)null).W(bindingFlags, array3, (Type)null, array2, parameterModifier_);
				MethodBase[] methodBase_16 = array5;
				ref object[] object_12 = ref *(object[]*)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, null, (Type)((Class7)null).t(obj2, (Type)null, (CultureInfo)null), array2, (ParameterModifier[])(object)Class5.Default);
				string[] string_4 = array4;
				Class7 class68 = @class;
				Class7 class69 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_44 = (BindingFlags)((Class7)(object)class69.W(bindingFlags, null, (Type)@class.t(Class5.Default, null, null), array2, null)).t(bindingFlags, array, Class5.Default, (CultureInfo)(object)Class5.Default);
				MethodBase[] methodBase_17 = array5;
				string[] string_5 = (string[])(object)Class5.Default;
				BindingFlags bindingFlags_45 = bindingFlags;
				PropertyInfo[] propertyInfo_10 = (PropertyInfo[])(object)Class5.Default;
				Class7 class70 = @class;
				BindingFlags bindingFlags_46 = (BindingFlags)Class5.Default;
				Type[] type_6 = (Type[])(object)Class5.Default;
				Class7 class71 = @class;
				BindingFlags bindingFlags_47 = bindingFlags;
				MethodBase[] methodBase_18 = array5;
				Class7 class72 = @class;
				BindingFlags bindingFlags_48 = bindingFlags;
				FieldInfo[] fieldInfo_5 = array;
				object object_13 = Class5.Default;
				Class7 class73 = @class;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_49 = bindingFlags;
				FieldInfo[] fieldInfo_6 = array;
				object object_14 = Class5.Default;
				Class7 class74 = @class;
				bindingFlags = default(BindingFlags);
				_ = (GClass1)class65.t(object_11, (Type)(object)class66.j(bindingFlags_42, methodBase_15, ref *(object[]*)null, parameterModifier_, cultureInfo_3, (string[])(object)class67.j(bindingFlags_43, methodBase_16, ref object_12, parameterModifier_, null, string_4, out *(object*)class68.j(bindingFlags_44, methodBase_17, ref *(object[]*)null, parameterModifier_, null, string_5, out *(object*)((Class7)(object)((Class7)null).W(bindingFlags_45, propertyInfo_10, (Type)(object)class70.W(bindingFlags_46, null, type_, type_6, (ParameterModifier[])(object)class71.e(bindingFlags_47, methodBase_18, (Type[])(object)class72.t(bindingFlags_48, fieldInfo_5, object_13, (CultureInfo)((Class7)(object)class73.t(bindingFlags_49, fieldInfo_6, object_14, (CultureInfo)(object)class74.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, null, null, array4, out reference))).t(obj2, (Type)(object)((Class7)null).W((BindingFlags)@class.j(bindingFlags, array5, ref reference2, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)((Class7)(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, parameterModifier_)).t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, null, cultureInfo), (string[])(object)Class5.Default, out *(object*)@class.j((BindingFlags)Class5.Default, null, ref *(object[]*)null, parameterModifier_, (CultureInfo)@class.t(obj2, (Type)(object)Class5.Default, null), array4, out *(object*)@class.W(bindingFlags, null, type_, null, parameterModifier_))), array3, (Type)(object)Class5.Default, array2, (ParameterModifier[])(object)Class5.Default), null)), parameterModifier_)), (Type[])(object)Class5.Default, parameterModifier_)).j(bindingFlags, null, ref reference2, parameterModifier_, cultureInfo, null, out *(object*)Class5.Default))), out *(object*)null), null);
			}
			finally
			{
				@struct = (Struct2)Class5.Default;
				continue;
			}
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			do
			{
				class7 = class7;
			}
			while (obj2 != null);
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			while (obj2 != null)
			{
				bindingFlags = default(BindingFlags);
				_ = (Qk7)(object)((Class7)null).W(bindingFlags, array3, (Type)(object)@class.W(bindingFlags, null, null, array2, (ParameterModifier[])@class.t(null, type_, cultureInfo)), array2, (ParameterModifier[])null);
			}
		}
		else
		{
			while ((object)Class5.Default != null)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					class5 = (Class6)(object)Class5.Default;
				}
			}
		}
		while (true)
		{
			if (obj2 != null)
			{
				try
				{
					_ = (Class7)(object)Class5.Default;
				}
				catch
				{
					class7 = null;
					_ = (Qk7)(object)Class5.Default;
					gClass2 = gClass2;
				}
			}
			else if ((object)Class5.Default == null)
			{
				break;
			}
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			if (uIntPtr == 0)
			{
				do
				{
					_ = (_003CModule_003E)(object)Class5.Default;
				}
				while (obj2 != null);
			}
			else
			{
				_ = (Class6)(object)@class.W(bindingFlags, null, (Type)(object)Class5.Default, array2, null);
			}
		}
		_ = (Qk7)(object)Class5.Default;
		do
		{
			gClass3 = gClass3;
			struct2 = struct2;
		}
		while (obj2 != null);
		Class7 class75 = @class;
		bindingFlags = default(BindingFlags);
		_ = (GClass1)(object)((Class7)(object)class75.t(bindingFlags, null, Class5.Default, null)).e((BindingFlags)Class5.Default, null, array2, parameterModifier_);
		try
		{
			BindingFlags bindingFlags_50 = (BindingFlags)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)null, array2, (ParameterModifier[])null);
			BindingFlags bindingFlags_51 = bindingFlags;
			Class7 class76 = @class;
			Class7 class77 = @class;
			BindingFlags bindingFlags_52 = bindingFlags;
			MethodBase[] methodBase_19 = array5;
			object object_15 = Class5.Default;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)((Class7)null).j(bindingFlags_50, (MethodBase[])(object)((Class7)null).W(bindingFlags_51, (PropertyInfo[])(object)class76.j((BindingFlags)class77.e(bindingFlags_52, methodBase_19, null, (ParameterModifier[])((Class7)null).t(object_15, (Type)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])((Class7)null).t((object)null, (Type)null, (CultureInfo)null), (Type)null, array2, parameterModifier_), cultureInfo)), null, ref reference2, null, (CultureInfo)(object)Class5.Default, array4, out *(object*)@class.t(bindingFlags, array, Class5.Default, (CultureInfo)(object)((Class7)null).j((BindingFlags)Class5.Default, array5, ref *(object[]*)((Class7)null).j((BindingFlags)((Class7)(object)Class5.Default).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, null, cultureInfo, null, out *(object*)Class5.Default), array5, ref reference2, (ParameterModifier[])(object)Class5.Default, (CultureInfo)null, (string[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)null, (Type[])(object)((Class7)null).W(bindingFlags, array3, type_, (Type[])@class.t(null, type_, (CultureInfo)(object)Class5.Default), parameterModifier_), (ParameterModifier[])null), out reference), (ParameterModifier[])(object)@class.j(bindingFlags, array5, ref *(object[]*)null, parameterModifier_, (CultureInfo)(object)Class5.Default, array4, out reference), (CultureInfo)(object)@class.e(bindingFlags, array5, array2, parameterModifier_), array4, out reference))), type_, array2, parameterModifier_), ref *(object[]*)Class5.Default, parameterModifier_, (CultureInfo)@class.t(obj2, type_, (CultureInfo)(object)Class5.Default), (string[])(object)Class5.Default, out reference) == (UIntPtr)(nuint)0u)
			{
				while (obj2 != null)
				{
					_ = (GClass1)(object)Class5.Default;
				}
			}
			else
			{
				_ = (GClass3)(object)Class5.Default;
			}
		}
		catch
		{
			do
			{
				object object_16 = obj2;
				Type type_7 = (Type)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				if (checked(unchecked((nuint)(UIntPtr)((Class7)null).t(object_16, type_7, (CultureInfo)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, (ParameterModifier[])(object)Class5.Default))) * uIntPtr) == 0)
				{
					Class7 class78 = @class;
					bindingFlags = default(BindingFlags);
					_ = (_003CModule_003E)(object)class78.j(bindingFlags, (MethodBase[])@class.t(null, (Type)(object)Class5.Default, cultureInfo), ref *(object[]*)@class.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference2, (ParameterModifier[])@class.t(obj2, (Type)(object)Class5.Default, cultureInfo), null, (string[])(object)@class.e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, parameterModifier_), out *(object*)Class5.Default), null, cultureInfo, null, out *(object*)null);
					gClass = (GClass0)(object)Class5.Default;
					Class7 class79 = @class;
					BindingFlags bindingFlags_53 = bindingFlags;
					Class7 class80 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class6)(object)class79.W(bindingFlags_53, null, null, (Type[])(object)class80.t((BindingFlags)((Class7)null).j(bindingFlags, array5, ref reference2, parameterModifier_, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out reference), null, obj2, cultureInfo), parameterModifier_);
				}
			}
			while (obj2 != null);
		}
		try
		{
			if (uIntPtr == 0)
			{
				try
				{
					Class7 class81 = @class;
					BindingFlags bindingFlags_54 = bindingFlags;
					MethodBase[] methodBase_20 = array5;
					Class7 class82 = @class;
					bindingFlags = default(BindingFlags);
					Class7 obj69 = (Class7)(object)class81.e(bindingFlags_54, methodBase_20, array2, (ParameterModifier[])(object)class82.e(bindingFlags, null, array2, parameterModifier_));
					object object_17 = Class5.Default;
					Class7 class83 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Struct1)obj69.t(object_17, type_, (CultureInfo)(object)class83.j(bindingFlags, array5, ref reference2, parameterModifier_, cultureInfo, array4, out *(object*)null));
				}
				catch
				{
					gClass = (GClass0)(object)Class5.Default;
				}
			}
		}
		catch
		{
			do
			{
				if (uIntPtr != 0)
				{
					class4 = class4;
				}
				else
				{
					_ = (_003CModule_003E)(object)Class5.Default;
				}
			}
			while ((object)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])null, @class.t(null, (Type)(object)Class5.Default, cultureInfo), (CultureInfo)null) != null);
		}
		checked
		{
			nuint num5 = unchecked((nuint)default(UIntPtr)) * unchecked((nuint)default(UIntPtr));
			uIntPtr = default(UIntPtr);
			if (unchecked(num5 / uIntPtr) * unchecked((nuint)(UIntPtr)Class5.Default) == 0)
			{
				if (uIntPtr == 0)
				{
					try
					{
						gClass4 = null;
						gClass = gClass;
						_ = (GClass2)@class.t(obj2, type_, cultureInfo);
					}
					finally
					{
						gClass4 = gClass4;
						goto IL_2ceb;
					}
				}
				unchecked
				{
					try
					{
						_ = (GClass2)(object)Class5.Default;
					}
					finally
					{
						class5 = class5;
						Class7 class84 = @class;
						BindingFlags bindingFlags_55 = bindingFlags;
						MethodBase[] methodBase_21 = array5;
						ref object[] object_18 = ref reference2;
						Class7 class85 = @class;
						bindingFlags = default(BindingFlags);
						ParameterModifier[] parameterModifier_4 = (ParameterModifier[])(object)class85.j((BindingFlags)((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference2, parameterModifier_, (CultureInfo)null, array4, out *(object*)@class.j(bindingFlags, array5, ref *(object[]*)Class5.Default, null, (CultureInfo)(object)Class5.Default, null, out *(object*)null)), null, ref *(object[]*)Class5.Default, null, null, array4, out *(object*)@class.j(default(BindingFlags), null, ref reference2, (ParameterModifier[])(object)Class5.Default, cultureInfo, array4, out reference));
						CultureInfo cultureInfo_4 = cultureInfo;
						Class7 class86 = @class;
						BindingFlags bindingFlags_56 = (BindingFlags)@class.t(obj2, type_, null);
						FieldInfo[] fieldInfo_7 = array;
						Class7 class87 = @class;
						BindingFlags bindingFlags_57 = (BindingFlags)Class5.Default;
						MethodBase[] methodBase_22 = (MethodBase[])(object)Class5.Default;
						ref object[] object_19 = ref *(object[]*)Class5.Default;
						Class7 obj72 = (Class7)(object)Class5.Default;
						bindingFlags = default(BindingFlags);
						_ = (Class4)(object)class84.j(bindingFlags_55, methodBase_21, ref object_18, parameterModifier_4, cultureInfo_4, (string[])(object)class86.t(bindingFlags_56, fieldInfo_7, class87.j(bindingFlags_57, methodBase_22, ref object_19, parameterModifier_, (CultureInfo)(object)obj72.j(bindingFlags, (MethodBase[])(object)@class.W(bindingFlags, null, type_, null, parameterModifier_), ref *(object[]*)null, null, cultureInfo, array4, out *(object*)null), (string[])(object)@class.W(bindingFlags, null, type_, array2, parameterModifier_), out reference), cultureInfo), out reference);
						goto IL_2ceb;
					}
				}
			}
			_ = (Class6)(object)Class5.Default;
			goto IL_2ceb;
		}
		IL_3119:
		while (obj2 != null)
		{
			try
			{
				class15 = class15;
			}
			catch
			{
				gClass2 = null;
				class7 = null;
				_ = (Class10)((Class7)(object)Class5.Default).t(obj2, type_, (CultureInfo)(object)@class.t(bindingFlags, array, null, cultureInfo));
				_ = Class5.Default;
			}
			finally
			{
				if (uIntPtr == 0)
				{
					gClass4 = gClass4;
				}
				continue;
			}
		}
		class7 = class7;
		class14 = class14;
		try
		{
			Class7 class88 = @class;
			bindingFlags = default(BindingFlags);
			_ = (Class2)(object)class88.t(bindingFlags, array, obj2, cultureInfo);
		}
		catch
		{
			if (uIntPtr == 0)
			{
				Class7 obj74 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				if ((UIntPtr)obj74.e(bindingFlags, array5, array2, parameterModifier_) == (UIntPtr)(nuint)0u)
				{
					_ = (GClass1)(object)Class5.Default;
				}
			}
		}
		_ = (GClass3)(object)((Class7)(object)Class5.Default).t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, null);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u && (UIntPtr)((Class7)(object)Class5.Default).t(bindingFlags, array, Class5.Default, cultureInfo) == (UIntPtr)(nuint)0u)
		{
			class17 = class17;
		}
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				qk = (Qk7)(object)((Class7)(object)((Class7)null).t(bindingFlags, array, (object)((Class7)(object)Class5.Default).W(default(BindingFlags), array3, (Type)(object)Class5.Default, null, parameterModifier_), (CultureInfo)(object)Class5.Default)).t(default(BindingFlags), array, obj2, (CultureInfo)(object)Class5.Default);
			}
		}
		finally
		{
			@struct = @struct;
			goto IL_32a7;
		}
		IL_38a3:
		if (uIntPtr == 0)
		{
			gClass4 = gClass4;
		}
		BindingFlags bindingFlags_58 = bindingFlags;
		PropertyInfo[] propertyInfo_11 = (PropertyInfo[])(object)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, array3, type_, (Type[])@class.t(obj2, null, cultureInfo), null);
		Class7 obj76 = (Class7)(object)@class.t(bindingFlags, array, null, cultureInfo);
		bindingFlags = default(BindingFlags);
		if ((UIntPtr)((Class7)null).W(bindingFlags_58, propertyInfo_11, type_, (Type[])(object)obj76.W(bindingFlags, null, (Type)(object)Class5.Default, array2, parameterModifier_), parameterModifier_) == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (Class9)(object)Class5.Default;
			}
			finally
			{
				gClass2 = (GClass1)(object)Class5.Default;
				goto IL_396b;
			}
		}
		goto IL_396b;
		IL_396b:
		class5 = (Class6)(object)Class5.Default;
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				class23 = class23;
			}
			catch
			{
				try
				{
					class7 = class7;
					class17 = class17;
				}
				finally
				{
					_ = (Qk7)(object)Class5.Default;
					goto end_IL_3993;
				}
				end_IL_3993:;
			}
		}
		_ = (Class10)(object)@class.t((BindingFlags)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, parameterModifier_), null, null, cultureInfo);
		Class7 class89 = @class;
		bindingFlags = default(BindingFlags);
		_ = (GClass2)(object)class89.e(bindingFlags, null, (Type[])((Class7)null).t((object)Class5.Default, type_, cultureInfo), null);
		_ = (Class9)(object)Class5.Default;
		_ = (Class4)(object)Class5.Default;
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (Class6)@class.t(null, (Type)(object)Class5.Default, cultureInfo);
			}
			catch
			{
				class5 = null;
				struct2 = struct2;
				_ = (Class9)(object)Class5.Default;
				_ = (GClass3)(object)Class5.Default;
			}
			finally
			{
				try
				{
					@struct = default(Struct2);
					@struct = @struct;
				}
				catch
				{
					_ = (Struct1)Class5.Default;
				}
				goto IL_3b2f;
			}
		}
		while ((object)((Class7)null).W(bindingFlags, array3, type_, array2, (ParameterModifier[])(object)((Class7)null).t(bindingFlags, array, (object)Class5.Default, cultureInfo)) != null)
		{
			_ = (Struct1)Class5.Default;
			gClass = null;
			gClass = null;
			class17 = (Class2)(object)@class.e(bindingFlags, array5, null, parameterModifier_);
		}
		goto IL_3b2f;
		IL_35fe:
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			class3 = (Class9)(object)((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])(object)@class.t((BindingFlags)Class5.Default, array, null, null), null, parameterModifier_);
			qk = (Qk7)@class.t(null, type_, (CultureInfo)(object)Class5.Default);
		}
		else if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			if (uIntPtr == 0)
			{
				struct2 = (Struct1)((Class7)(object)Class5.Default).e(bindingFlags, null, array2, null);
			}
			else
			{
				@class = (Class7)(object)Class5.Default;
			}
		}
		_ = (GClass3)(object)((Class7)null).t(bindingFlags, array, obj2, cultureInfo);
		while (obj2 != null)
		{
			_ = (Struct2)((Class7)(object)((Class7)null).e(bindingFlags, array5, array2, parameterModifier_)).t(obj2, type_, null);
		}
		nuint num6 = uIntPtr / uIntPtr;
		nuint num7 = uIntPtr;
		uIntPtr = default(UIntPtr);
		if (checked(num6 - (num7 * uIntPtr - unchecked((nuint)(UIntPtr)Class5.Default))) == 0 && (UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr / (nuint)(UIntPtr)Class5.Default == 0)
			{
				qk = null;
				_ = (Class8)(object)Class5.Default;
				_ = (GClass3)(object)Class5.Default;
			}
			else
			{
				@class = @class;
			}
		}
		gClass2 = (GClass1)(object)Class5.Default;
		_ = (Struct1)Class5.Default;
		Class7 class90 = @class;
		bindingFlags = default(BindingFlags);
		_ = (Class4)(object)class90.j(bindingFlags, array5, ref *(object[]*)null, null, cultureInfo, null, out reference);
		try
		{
			while (true)
			{
				if (obj2 != null)
				{
					class3 = class3;
				}
				else if (obj2 == null)
				{
					break;
				}
			}
		}
		finally
		{
			if (uIntPtr == 0)
			{
				if (uIntPtr == 0)
				{
					Class7 class91 = @class;
					bindingFlags = default(BindingFlags);
					Class7 obj80 = (Class7)(object)class91.e(bindingFlags, array5, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
					BindingFlags bindingFlags_59 = bindingFlags;
					MethodBase[] methodBase_23 = array5;
					Class7 obj81 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (GClass3)(object)obj80.j(bindingFlags_59, methodBase_23, ref *(object[]*)obj81.j(bindingFlags, array5, ref reference2, parameterModifier_, (CultureInfo)(object)Class5.Default, array4, out *(object*)null), (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)Class5.Default, array4, out reference);
				}
				else
				{
					_ = (Class9)(object)Class5.Default;
				}
			}
			goto IL_38a3;
		}
		IL_45cf:
		while (true)
		{
			try
			{
				class17 = class17;
			}
			catch
			{
				_ = (Class8)(object)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, null, obj2, null);
			}
			if (obj2 == null)
			{
				BindingFlags bindingFlags_60 = bindingFlags;
				PropertyInfo[] propertyInfo_12 = array3;
				Class7 class92 = @class;
				Class7 class93 = @class;
				BindingFlags bindingFlags_61 = (BindingFlags)((Class7)null).t(bindingFlags, array, obj2, cultureInfo);
				MethodBase[] methodBase_24 = array5;
				Class7 class94 = @class;
				bindingFlags = default(BindingFlags);
				if ((object)((Class7)null).W(bindingFlags_60, propertyInfo_12, type_, (Type[])null, (ParameterModifier[])(object)class92.t((BindingFlags)class93.j(bindingFlags_61, methodBase_24, ref *(object[]*)class94.j(bindingFlags, array5, ref *(object[]*)@class.e((BindingFlags)@class.t((BindingFlags)@class.W(bindingFlags, null, type_, array2, parameterModifier_), array, null, null), (MethodBase[])(object)@class.t((BindingFlags)@class.t(null, (Type)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference2, (ParameterModifier[])(object)Class5.Default, (CultureInfo)null, (string[])null, out reference), (CultureInfo)(object)@class.t((BindingFlags)Class5.Default, array, obj2, null)), (FieldInfo[])(object)Class5.Default, null, null), null, null), parameterModifier_, (CultureInfo)(object)Class5.Default, null, out *(object*)@class.t(obj2, null, (CultureInfo)(object)@class.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type_, array2, parameterModifier_))), parameterModifier_, null, null, out *(object*)Class5.Default), array, obj2, cultureInfo)) == null)
				{
					break;
				}
			}
		}
		UIntPtr num8 = (UIntPtr)Class5.Default;
		uIntPtr = default(UIntPtr);
		checked
		{
			if (unchecked((nuint)num8) - uIntPtr == 0)
			{
				try
				{
					bindingFlags = default(BindingFlags);
					_ = (GClass1)(object)((Class7)null).W(bindingFlags, array3, type_, (Type[])(object)Class5.Default, parameterModifier_);
				}
				catch
				{
					class7 = Class5.Default;
				}
			}
			else
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					if (uIntPtr == 0)
					{
						_ = (Class0)(object)Class5.Default;
					}
					else
					{
						_ = (_003CModule_003E)((Class7)null).t((object)null, type_, cultureInfo);
					}
				}
				else if (uIntPtr + unchecked((nuint)(UIntPtr)Class5.Default) + uIntPtr == 0)
				{
					@class = null;
				}
			}
			nuint num9 = uIntPtr * uIntPtr;
			uIntPtr = default(UIntPtr);
			if (num9 * unchecked(unchecked((nuint)default(UIntPtr)) / uIntPtr) == 0)
			{
				do
				{
					try
					{
						gClass = null;
					}
					finally
					{
						Class7 class95 = @class;
						Class7 class96 = @class;
						bindingFlags = default(BindingFlags);
						_ = (Class0)(object)class95.e(default(BindingFlags), (MethodBase[])(object)class96.j(bindingFlags, array5, ref reference2, parameterModifier_, null, array4, out reference), array2, parameterModifier_);
						continue;
					}
				}
				while ((object)Class5.Default != null);
			}
			else if (unchecked((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u))
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					class15 = class15;
				}
				else
				{
					_ = (Class7)(object)Class5.Default;
				}
			}
			else
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					gClass2 = (GClass1)(object)@class.e(unchecked((BindingFlags)Class5.Default), array5, array2, parameterModifier_);
				}
			}
		}
		try
		{
			if (uIntPtr == 0)
			{
				try
				{
					Class7 class97 = @class;
					object object_20 = obj2;
					Class7 class98 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class10)class97.t(object_20, (Type)((Class7)(object)class98.t(bindingFlags, array, obj2, cultureInfo)).t(null, type_, cultureInfo), cultureInfo);
				}
				finally
				{
					Class7 class99 = @class;
					bindingFlags = default(BindingFlags);
					_ = (Class4)(object)class99.t(bindingFlags, array, Class5.Default, cultureInfo);
					goto end_IL_4953;
				}
			}
			do
			{
				Class7 class100 = @class;
				BindingFlags bindingFlags_62 = (BindingFlags)@class.t(bindingFlags, array, Class5.Default, null);
				PropertyInfo[] propertyInfo_13 = (PropertyInfo[])(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				_ = (GClass0)(object)((Class7)(object)((Class7)null).e((BindingFlags)((Class7)(object)class100.W(bindingFlags_62, propertyInfo_13, (Type)(object)((Class7)null).t(bindingFlags, array, obj2, cultureInfo), (Type[])(object)Class5.Default, parameterModifier_)).t(Class5.Default, null, cultureInfo), array5, (Type[])null, parameterModifier_)).t((BindingFlags)Class5.Default, (FieldInfo[])@class.t(null, type_, (CultureInfo)(object)((Class7)(object)@class.W(bindingFlags, null, type_, array2, parameterModifier_)).t(bindingFlags, array, null, cultureInfo)), obj2, null);
			}
			while (obj2 != null);
			end_IL_4953:;
		}
		finally
		{
			class4 = null;
			goto IL_4af5;
		}
	}

	unsafe static void smethod_7()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] array2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] array3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object reference);
		Class4 @class;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class7 class2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags);
		nuint uIntPtr;
		try
		{
			@class = null;
			@class = null;
		}
		finally
		{
			try
			{
				do
				{
					_ = (GClass1)(object)Class5.Default;
					obj = obj;
				}
				while (obj != null);
			}
			finally
			{
				uIntPtr = (UIntPtr)Class5.Default;
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					class2 = null;
					Class7 class3 = class2;
					Class7 class4 = class2;
					bindingFlags = bindingFlags;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_ = bindingFlags;
					array = array;
					MethodBase[] methodBase_ = array;
					array2 = null;
					BindingFlags bindingFlags_2 = (BindingFlags)class4.e(bindingFlags_, methodBase_, array2, (ParameterModifier[])(object)Class5.Default);
					MethodBase[] methodBase_2 = (MethodBase[])(object)Class5.Default;
					ref object[] object_ = ref *(object[]*)Class5.Default;
					array3 = (ParameterModifier[])(object)Class5.Default;
					ParameterModifier[] parameterModifier_ = array3;
					cultureInfo = (CultureInfo)class2.t(obj, null, (CultureInfo)(object)Class5.Default);
					CultureInfo cultureInfo_ = cultureInfo;
					reference = ref reference;
					_003CModule_003E = (_003CModule_003E)(object)class3.j(bindingFlags_2, methodBase_2, ref object_, parameterModifier_, cultureInfo_, null, out reference);
					_003CModule_003E = _003CModule_003E;
				}
				goto IL_0104;
			}
		}
		IL_0104:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] array4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object[] reference2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string[] array5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class0 class10);
		try
		{
			try
			{
				Class7 class5 = class2;
				type = type;
				_ = (Struct1)class5.t(null, type, cultureInfo);
			}
			finally
			{
				while (obj != null)
				{
					Class7 class6 = class2;
					BindingFlags bindingFlags_3 = (BindingFlags)Class5.Default;
					object object_2 = obj;
					Class7 class7 = class2;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_4 = bindingFlags;
					array4 = null;
					BindingFlags bindingFlags_5 = (BindingFlags)class6.t(bindingFlags_3, null, object_2, (CultureInfo)(object)class7.W(bindingFlags_4, array4, type, array2, (ParameterModifier[])(object)Class5.Default));
					Class7 obj2 = (Class7)(object)Class5.Default;
					Class7 obj3 = (Class7)(object)Class5.Default;
					Class7 class8 = class2;
					bindingFlags = default(BindingFlags);
					Class7 obj4 = (Class7)(object)class8.e(bindingFlags, null, null, array3);
					BindingFlags bindingFlags_6 = bindingFlags;
					PropertyInfo[] propertyInfo_ = array4;
					Class7 class9 = class2;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_7 = bindingFlags;
					MethodBase[] methodBase_3 = array;
					BindingFlags bindingFlags_8 = bindingFlags;
					reference2 = ref reference2;
					ref object[] object_3 = ref reference2;
					ParameterModifier[] parameterModifier_2 = array3;
					CultureInfo cultureInfo_2 = cultureInfo;
					array5 = array5;
					_ = (Class0)(object)((Class7)null).t(bindingFlags_5, (FieldInfo[])null, (object)null, (CultureInfo)(object)((Class7)(object)obj2.j((BindingFlags)obj3.e((BindingFlags)obj4.W(bindingFlags_6, propertyInfo_, (Type)(object)class9.j(bindingFlags_7, methodBase_3, ref *(object[]*)((Class7)null).j(bindingFlags_8, (MethodBase[])null, ref object_3, parameterModifier_2, cultureInfo_2, array5, out *(object*)null), array3, cultureInfo, array5, out *(object*)class2.e(bindingFlags, (MethodBase[])(object)Class5.Default, null, (ParameterModifier[])(object)Class5.Default)), array2, null), array, array2, (ParameterModifier[])(object)class2.e(bindingFlags, array, array2, array3)), (MethodBase[])(object)Class5.Default, ref *(object[]*)null, array3, cultureInfo, array5, out reference)).t(bindingFlags, null, obj, null));
				}
				goto end_IL_0105;
			}
			end_IL_0105:;
		}
		catch
		{
			while ((object)Class5.Default != null)
			{
				Class0 obj5 = (Class0)(object)Class5.Default;
				class10 = (Class0)class2.t(obj, type, null);
				class10 = obj5;
				class10 = class10;
			}
		}
		try
		{
			while (obj != null)
			{
				_ = (Class6)(object)((Class7)(object)Class5.Default).e(bindingFlags, array, array2, (ParameterModifier[])(object)Class5.Default);
			}
		}
		catch
		{
			_ = (_003CModule_003E)(object)Class5.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class10 class12);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class2 class11);
		do
		{
			try
			{
				class11 = class11;
				class11 = null;
			}
			catch
			{
				try
				{
					_ = (Struct2)Class5.Default;
				}
				finally
				{
					class12 = class12;
					class12 = class12;
					goto end_IL_0370;
				}
				end_IL_0370:;
			}
		}
		while ((object)Class5.Default != null);
		while (obj != null)
		{
			while (true)
			{
				if ((object)((Class7)(object)Class5.Default).j(bindingFlags, array, ref reference2, array3, cultureInfo, array5, out reference) != null)
				{
					class2 = class2;
				}
				else if (obj == null)
				{
					break;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass0 gClass);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			gClass = gClass;
			gClass = gClass;
		}
		else
		{
			do
			{
				_ = (GClass0)(object)Class5.Default;
			}
			while ((object)Class5.Default != null || obj != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out FieldInfo[] array6);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct2 @struct);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			_ = (Struct2)Class5.Default;
			Class7 class13 = class2;
			BindingFlags bindingFlags_9 = bindingFlags;
			array6 = array6;
			_ = (Qk7)(object)((Class7)null).t((BindingFlags)class13.t(bindingFlags_9, array6, obj, null), array6, (object)null, cultureInfo);
		}
		else
		{
			try
			{
			}
			catch
			{
				try
				{
					_ = (GClass1)((Class7)(object)Class5.Default).t(obj, null, cultureInfo);
					@struct = @struct;
					@struct = default(Struct2);
					@struct = @struct;
				}
				finally
				{
					_ = (_003CModule_003E)(object)Class5.Default;
					goto end_IL_0470;
				}
				end_IL_0470:;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass1 gClass2);
		try
		{
			GClass1 obj10 = (GClass1)(object)class2.j(bindingFlags, array, ref reference2, null, null, array5, out *(object*)null);
			gClass2 = (GClass1)(object)Class5.Default;
			gClass2 = obj10;
			gClass = gClass;
			_ = (GClass3)(object)Class5.Default;
			_ = (GClass1)(object)Class5.Default;
		}
		catch
		{
			checked
			{
				try
				{
					do
					{
						@struct = @struct;
					}
					while (obj != null);
				}
				catch
				{
					if (unchecked((nuint)(UIntPtr)((Class7)null).W(bindingFlags, array4, (Type)(object)Class5.Default, array2, array3)) * unchecked((nuint)default(UIntPtr)) == 0)
					{
						_003CModule_003E = _003CModule_003E;
					}
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class5 class14);
		do
		{
			if (default(UIntPtr) != (UIntPtr)(nuint)0u)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Class0)(object)Class5.Default;
				}
				else
				{
					Class5 obj13 = Class5.Default;
					class14 = class14;
					class14 = obj13;
				}
			}
			else
			{
				while (obj != null)
				{
					_ = (Class6)(object)Class5.Default;
				}
			}
			bindingFlags = default(BindingFlags);
		}
		while ((object)((Class7)null).t(bindingFlags, array6, obj, cultureInfo) != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct1 struct2);
		Class6 class17;
		try
		{
			if ((UIntPtr)class2.W((BindingFlags)Class5.Default, (PropertyInfo[])class2.t(obj, type, cultureInfo), type, array2, array3) == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (_003CModule_003E)(object)Class5.Default;
				}
				catch
				{
					gClass = gClass;
				}
			}
			else if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				Struct1 obj15 = (Struct1)class2.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)Class5.Default, array5, out *(object*)null);
				struct2 = (Struct1)Class5.Default;
				struct2 = obj15;
			}
			else
			{
				_ = (Struct1)Class5.Default;
			}
		}
		finally
		{
			try
			{
				while ((object)Class5.Default != null)
				{
					_ = (Struct1)Class5.Default;
				}
			}
			finally
			{
				Class7 obj16 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_10 = bindingFlags;
				Class7 class15 = class2;
				Type type_ = type;
				Class7 class16 = class2;
				bindingFlags = default(BindingFlags);
				Class6 obj17 = (Class6)(object)obj16.j(bindingFlags_10, (MethodBase[])class15.t(null, type_, (CultureInfo)(object)class16.t(bindingFlags, (FieldInfo[])(object)Class5.Default, Class5.Default, cultureInfo)), ref reference2, array3, cultureInfo, array5, out *(object*)Class5.Default);
				class17 = null;
				class17 = obj17;
				goto IL_0758;
			}
		}
		IL_2a9b:
		gClass2 = gClass2;
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			do
			{
				Class7 obj18 = (Class7)class2.t(null, type, cultureInfo);
				MethodBase[] methodBase_4 = array;
				Class7 class18 = class2;
				bindingFlags = default(BindingFlags);
				_ = (Struct1)obj18.e(default(BindingFlags), methodBase_4, null, (ParameterModifier[])(object)class18.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)(object)Class5.Default, array2, array3));
				_ = (Class0)(object)((Class7)(object)Class5.Default).j((BindingFlags)class2.t((BindingFlags)((Class7)null).t(bindingFlags, array6, obj, cultureInfo), (FieldInfo[])(object)class2.W((BindingFlags)Class5.Default, array4, (Type)(object)Class5.Default, array2, null), Class5.Default, cultureInfo), array, ref reference2, null, (CultureInfo)(object)Class5.Default, null, out reference);
				class2 = class2;
			}
			while (obj != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass3 gClass3);
		do
		{
			if (uIntPtr != 0)
			{
				gClass3 = (GClass3)(object)Class5.Default;
				_ = (GClass0)(object)Class5.Default;
				Class7 class19 = class2;
				bindingFlags = default(BindingFlags);
				_ = (GClass2)(object)class19.t(bindingFlags, null, obj, (CultureInfo)(object)Class5.Default);
				class17 = null;
			}
			else
			{
				_ = (Class6)(object)((Class7)(object)((Class7)null).e(bindingFlags, array, array2, (ParameterModifier[])(object)Class5.Default)).e(bindingFlags, array, array2, array3);
			}
		}
		while (obj != null);
		if (uIntPtr != 0)
		{
			while (obj != null)
			{
				do
				{
					gClass3 = gClass3;
					class14 = class14;
					_003CModule_003E = _003CModule_003E;
					gClass2 = gClass2;
				}
				while ((object)Class5.Default != null);
			}
		}
		try
		{
			_ = (Struct2)Class5.Default;
			class2 = (Class7)(object)class2.t(bindingFlags, null, Class5.Default, cultureInfo);
		}
		catch
		{
			UIntPtr num = (UIntPtr)Class5.Default;
			uIntPtr = default(UIntPtr);
			if (checked(unchecked((nuint)num) - uIntPtr) == 0)
			{
				class17 = class17;
				class10 = (Class0)(object)class2.t((BindingFlags)Class5.Default, array6, null, cultureInfo);
			}
			else if (uIntPtr == 0)
			{
				_ = (Class2)(object)Class5.Default;
			}
			else
			{
				_003CModule_003E = null;
			}
		}
		do
		{
			if (uIntPtr == 0)
			{
				class14 = Class5.Default;
			}
		}
		while (obj != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass2 gClass4);
		try
		{
			if (uIntPtr == 0)
			{
				gClass4 = gClass4;
			}
			else
			{
				Class7 obj20 = (Class7)(object)class2.j(bindingFlags, array, ref *(object[]*)Class5.Default, array3, cultureInfo, array5, out reference);
				object object_4 = obj;
				Type type_2 = type;
				BindingFlags bindingFlags_11 = (BindingFlags)Class5.Default;
				Class7 class20 = class2;
				bindingFlags = default(BindingFlags);
				MethodBase[] methodBase_5 = (MethodBase[])(object)class20.j(bindingFlags, array, ref reference2, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)class2.W((BindingFlags)((Class7)null).e(bindingFlags, array, (Type[])class2.t(null, null, null), array3), array4, (Type)(object)Class5.Default, array2, null), array5, out reference);
				ref object[] object_5 = ref reference2;
				Class7 class21 = class2;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_12 = bindingFlags;
				BindingFlags bindingFlags_13 = bindingFlags;
				MethodBase[] methodBase_6 = array;
				ref object[] object_6 = ref reference2;
				ParameterModifier[] parameterModifier_3 = array3;
				bindingFlags = default(BindingFlags);
				class10 = (Class0)obj20.t(object_4, type_2, (CultureInfo)(object)((Class7)null).j(bindingFlags_11, methodBase_5, ref object_5, (ParameterModifier[])(object)class21.t(bindingFlags_12, (FieldInfo[])(object)((Class7)null).j(bindingFlags_13, methodBase_6, ref object_6, parameterModifier_3, (CultureInfo)(object)((Class7)null).W(bindingFlags, array4, (Type)null, array2, (ParameterModifier[])(object)Class5.Default), (string[])class2.t(Class5.Default, null, null), out *(object*)null), obj, cultureInfo), (CultureInfo)(object)Class5.Default, (string[])null, out reference));
			}
		}
		finally
		{
			gClass4 = null;
			gClass4 = null;
			_ = (Struct2)class2.t(bindingFlags, array6, obj, cultureInfo);
			goto IL_2f08;
		}
		IL_2401:
		Qk7 qk;
		while (true)
		{
			bindingFlags = default(BindingFlags);
			if ((object)((Class7)null).j(bindingFlags, array, ref *(object[]*)null, array3, (CultureInfo)(object)class2.W((BindingFlags)Class5.Default, array4, (Type)(object)Class5.Default, array2, array3), array5, out reference) == null)
			{
				break;
			}
			if (uIntPtr == 0)
			{
				if (uIntPtr == 0)
				{
					_ = (Class9)(object)Class5.Default;
					gClass3 = (GClass3)(object)class2.W(default(BindingFlags), null, null, null, array3);
					_ = (Class6)(object)Class5.Default;
					gClass3 = null;
				}
				else
				{
					qk = qk;
				}
			}
		}
		class10 = class10;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class8 class22);
		try
		{
			try
			{
				class22 = null;
				_ = (Class8)(object)Class5.Default;
				qk = qk;
				_ = (Class10)(object)Class5.Default;
			}
			catch
			{
			}
		}
		catch
		{
			try
			{
				class2 = class2;
			}
			catch
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = Class5.Default;
				}
			}
		}
		while (obj != null)
		{
			Class7 class23 = class2;
			BindingFlags bindingFlags_14 = bindingFlags;
			MethodBase[] methodBase_7 = array;
			ref object[] object_7 = ref reference2;
			Class7 class24 = class2;
			Class7 class25 = class2;
			BindingFlags bindingFlags_15 = bindingFlags;
			Class7 obj24 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			_ = (Struct1)((Class7)(object)class23.j(bindingFlags_14, methodBase_7, ref object_7, (ParameterModifier[])(object)class24.e((BindingFlags)class25.W(bindingFlags_15, (PropertyInfo[])(object)obj24.e(bindingFlags, null, array2, null), type, null, array3), null, array2, array3), (CultureInfo)(object)class2.e((BindingFlags)((Class7)null).e((BindingFlags)class2.e(bindingFlags, array, array2, null), array, array2, array3), array, array2, array3), null, out reference)).t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, cultureInfo);
		}
		class2 = class2;
		_ = (Class0)(object)Class5.Default;
		_ = (Struct1)Class5.Default;
		class2 = null;
		do
		{
			try
			{
				_ = (GClass1)(object)Class5.Default;
			}
			finally
			{
				try
				{
					gClass2 = gClass2;
				}
				finally
				{
					Class7 obj25 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_16 = (BindingFlags)Class5.Default;
					object object_8 = Class5.Default;
					Type type_3 = type;
					Class7 class26 = class2;
					bindingFlags = default(BindingFlags);
					_ = (Class7)(object)obj25.e(bindingFlags_16, (MethodBase[])((Class7)null).t(object_8, type_3, (CultureInfo)(object)class26.t(bindingFlags, null, obj, cultureInfo)), null, null);
					gClass = gClass;
					continue;
				}
			}
		}
		while (obj != null);
		try
		{
			try
			{
				try
				{
					gClass3 = gClass3;
				}
				finally
				{
					_ = (Class6)(object)Class5.Default;
					goto end_IL_2662;
				}
				end_IL_2662:;
			}
			catch
			{
				Class7 obj26 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				@struct = (Struct2)obj26.W(bindingFlags, null, type, null, (ParameterModifier[])(object)Class5.Default);
			}
		}
		catch
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0 && (UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Struct2)class2.t(null, type, null);
			}
		}
		nuint num2 = uIntPtr;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class9 class28);
		if (checked(num2 + (unchecked((nuint)default(UIntPtr)) - (uIntPtr + unchecked((nuint)(UIntPtr)((Class7)(object)Class5.Default).j(bindingFlags, array, ref reference2, null, cultureInfo, array5, out *(object*)null))))) == 0)
		{
			Class7 class27 = class2;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)class27.e(bindingFlags, array, (Type[])((Class7)(object)Class5.Default).t(obj, type, null), array3) == (UIntPtr)(nuint)0u)
			{
				class11 = (Class2)class2.t(obj, (Type)(object)Class5.Default, cultureInfo);
			}
		}
		else if (uIntPtr == 0)
		{
			try
			{
				_ = (Class2)(object)Class5.Default;
			}
			catch
			{
				class28 = (Class9)(object)Class5.Default;
			}
		}
		_ = (Class5)(object)((Class7)(object)class2.e(bindingFlags, array, array2, array3)).e(bindingFlags, null, array2, array3);
		_ = (Class8)(object)Class5.Default;
		do
		{
			try
			{
				while (obj != null)
				{
					class28 = class28;
				}
			}
			finally
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Qk7)(object)Class5.Default;
				}
				else
				{
					class2 = class2;
				}
				continue;
			}
		}
		while (obj != null);
		gClass2 = gClass2;
		class12 = class12;
		class17 = null;
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					qk = null;
				}
				finally
				{
					class14 = Class5.Default;
					goto end_IL_2871;
				}
				end_IL_2871:;
			}
			finally
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (Class7)((Class7)null).t(obj, type, cultureInfo);
					Class7 class29 = class2;
					bindingFlags = default(BindingFlags);
					_ = (Class6)(object)class29.e(bindingFlags, array, array2, null);
					_ = (Class9)(object)Class5.Default;
					_ = (Qk7)(object)Class5.Default;
				}
				else
				{
					_ = (Qk7)(object)Class5.Default;
					@class = null;
					Class7 obj30 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_17 = bindingFlags;
					BindingFlags bindingFlags_18 = bindingFlags;
					Class7 class30 = class2;
					bindingFlags = default(BindingFlags);
					PropertyInfo[] propertyInfo_2 = (PropertyInfo[])(object)((Class7)null).W(bindingFlags_18, (PropertyInfo[])null, (Type)(object)class30.t(bindingFlags, array6, obj, cultureInfo), (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
					Type type_4 = (Type)(object)class2.e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, array3);
					Class7 class31 = class2;
					bindingFlags = default(BindingFlags);
					_ = (GClass1)((Class7)(object)obj30.e((BindingFlags)((Class7)(object)((Class7)null).W(bindingFlags_17, propertyInfo_2, type_4, (Type[])(object)class31.t(default(BindingFlags), (FieldInfo[])(object)((Class7)null).t(bindingFlags, array6, obj, cultureInfo), class2.W(bindingFlags, null, (Type)(object)Class5.Default, array2, null), (CultureInfo)(object)Class5.Default), (ParameterModifier[])null)).e(bindingFlags, array, (Type[])(object)class2.W((BindingFlags)((Class7)null).j(bindingFlags, (MethodBase[])null, ref *(object[]*)null, (ParameterModifier[])(object)class2.t(bindingFlags, array6, obj, cultureInfo), cultureInfo, (string[])null, out *(object*)null), array4, null, null, array3), array3), array, array2, array3)).t(Class5.Default, null, null);
					_ = (_003CModule_003E)(object)Class5.Default;
				}
				goto IL_2a9b;
			}
		}
		goto IL_2a9b;
		IL_20be:
		class11 = (Class2)class2.t(obj, type, null);
		try
		{
			bindingFlags = default(BindingFlags);
			_ = (Class6)(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])(object)Class5.Default, array3);
		}
		catch
		{
			try
			{
				Class7 class32 = class2;
				BindingFlags bindingFlags_19 = bindingFlags;
				MethodBase[] methodBase_8 = array;
				ref object[] object_9 = ref *(object[]*)((Class7)null).W(bindingFlags, array4, type, (Type[])(object)Class5.Default, (ParameterModifier[])null);
				ParameterModifier[] parameterModifier_4 = array3;
				CultureInfo cultureInfo_3 = cultureInfo;
				string[] string_ = (string[])(object)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])null, (ParameterModifier[])(object)Class5.Default);
				Class7 class33 = class2;
				BindingFlags bindingFlags_20 = (BindingFlags)Class5.Default;
				PropertyInfo[] propertyInfo_3 = (PropertyInfo[])(object)Class5.Default;
				Type type_5 = type;
				Class7 class34 = class2;
				BindingFlags bindingFlags_21 = bindingFlags;
				object object_10 = Class5.Default;
				Class7 class35 = class2;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_22 = bindingFlags;
				Class7 obj31 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_23 = bindingFlags;
				Class7 class36 = class2;
				BindingFlags bindingFlags_24 = bindingFlags;
				MethodBase[] methodBase_9 = array;
				ref object[] object_11 = ref *(object[]*)Class5.Default;
				ParameterModifier[] parameterModifier_5 = (ParameterModifier[])(object)class2.W((BindingFlags)Class5.Default, null, null, array2, array3);
				Class7 class37 = class2;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_25 = bindingFlags;
				PropertyInfo[] propertyInfo_4 = (PropertyInfo[])(object)Class5.Default;
				Class7 class38 = class2;
				BindingFlags bindingFlags_26 = bindingFlags;
				Class7 obj32 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				class22 = (Class8)(object)class32.j(bindingFlags_19, methodBase_8, ref object_9, parameterModifier_4, cultureInfo_3, string_, out *(object*)class33.W(bindingFlags_20, propertyInfo_3, type_5, (Type[])(object)class34.t(bindingFlags_21, null, object_10, (CultureInfo)(object)class35.e(bindingFlags_22, (MethodBase[])(object)obj31.t(bindingFlags_23, (FieldInfo[])(object)class36.j(bindingFlags_24, methodBase_9, ref object_11, parameterModifier_5, (CultureInfo)(object)class37.W(bindingFlags_25, propertyInfo_4, (Type)(object)class38.W(bindingFlags_26, (PropertyInfo[])(object)obj32.e(bindingFlags, array, (Type[])(object)((Class7)null).t(bindingFlags, array6, obj, (CultureInfo)null), array3), type, array2, null), (Type[])(object)((Class7)(object)((Class7)(object)class2.j(bindingFlags, null, ref reference2, (ParameterModifier[])(object)Class5.Default, cultureInfo, array5, out reference)).j((BindingFlags)class2.e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, array3), (MethodBase[])(object)Class5.Default, ref reference2, (ParameterModifier[])(object)Class5.Default, null, array5, out reference)).t(bindingFlags, null, obj, cultureInfo), array3), array5, out *(object*)null), obj, (CultureInfo)(object)Class5.Default), array2, array3)), null));
			}
			finally
			{
				_ = (Qk7)(object)class2.W(bindingFlags, array4, type, null, array3);
				goto end_IL_2108;
			}
			end_IL_2108:;
		}
		finally
		{
			gClass3 = (GClass3)class2.t(obj, type, cultureInfo);
			goto IL_2401;
		}
		IL_457c:
		try
		{
			_003CModule_003E = (_003CModule_003E)class2.t(obj, type, null);
		}
		catch
		{
			_ = (GClass1)(object)Class5.Default;
		}
		do
		{
			_ = (GClass1)class2.t(obj, null, cultureInfo);
		}
		while (obj != null);
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			try
			{
				if (uIntPtr / uIntPtr == 0)
				{
					gClass = null;
				}
				else
				{
					class12 = (Class10)(object)Class5.Default;
				}
			}
			catch
			{
				while ((object)Class5.Default != null)
				{
					class12 = class12;
					class14 = (Class5)(object)((Class7)(object)class2.j((BindingFlags)Class5.Default, array, ref reference2, (ParameterModifier[])class2.t(null, null, cultureInfo), (CultureInfo)(object)Class5.Default, array5, out *(object*)((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, array3))).e(bindingFlags, array, (Type[])(object)((Class7)null).j(bindingFlags, array, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo, (string[])(object)Class5.Default, out *(object*)null), array3);
				}
			}
		}
		else
		{
			_ = (Class0)(object)class2.t(bindingFlags, (FieldInfo[])(object)class2.e(bindingFlags, (MethodBase[])(object)((Class7)(object)Class5.Default).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, array3, null, array5, out reference), array2, array3), obj, cultureInfo);
		}
		do
		{
			if ((UIntPtr)class2.W((BindingFlags)Class5.Default, null, type, array2, (ParameterModifier[])(object)class2.t(bindingFlags, array6, obj, cultureInfo)) == (UIntPtr)(nuint)0u)
			{
				while (obj != null)
				{
					class28 = (Class9)(object)class2.j(bindingFlags, array, ref *(object[]*)Class5.Default, null, null, array5, out *(object*)null);
				}
			}
		}
		while (obj != null);
		_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
		try
		{
			checked
			{
				while (obj != null)
				{
					Class7 class39 = class2;
					bindingFlags = default(BindingFlags);
					if (unchecked((nuint)(UIntPtr)class39.t(bindingFlags, null, obj, cultureInfo)) + unchecked(unchecked((nuint)default(UIntPtr)) / unchecked((nuint)default(UIntPtr))) == 0)
					{
						class14 = null;
						_ = (GClass0)(object)Class5.Default;
						_ = (Class7)(object)Class5.Default;
						_ = (GClass3)(object)Class5.Default;
					}
					else
					{
						class12 = (Class10)(object)Class5.Default;
						_ = (Class6)class2.t(null, null, null);
					}
				}
			}
		}
		finally
		{
			try
			{
				@struct = default(Struct2);
			}
			catch
			{
				Class7 obj36 = (Class7)(object)Class5.Default;
				Class7 class40 = class2;
				bindingFlags = default(BindingFlags);
				_ = (Class9)(object)obj36.W((BindingFlags)class40.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, cultureInfo), array4, null, array2, array3);
			}
			goto IL_48ce;
		}
		IL_3cd4:
		while (obj != null)
		{
			class17 = (Class6)(object)Class5.Default;
			_ = (Class2)(object)Class5.Default;
			_ = (GClass2)(object)Class5.Default;
			@struct = @struct;
		}
		try
		{
			class2 = (Class7)(object)Class5.Default;
			class11 = (Class2)(object)Class5.Default;
			@struct = default(Struct2);
		}
		catch
		{
			while (obj != null)
			{
				try
				{
					class2 = class2;
				}
				catch
				{
					_003CModule_003E = _003CModule_003E;
				}
			}
		}
		while (obj != null)
		{
			do
			{
				@struct = default(Struct2);
			}
			while ((object)Class5.Default != null);
		}
		_ = (Qk7)(object)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, array6, null, (CultureInfo)(object)((Class7)(object)((Class7)(object)((Class7)null).j((BindingFlags)Class5.Default, array, ref reference2, array3, (CultureInfo)null, (string[])null, out reference)).e((BindingFlags)Class5.Default, array, null, null)).e(bindingFlags, null, array2, null));
		_ = (Class6)class2.t(null, (Type)(object)((Class7)null).j(bindingFlags, (MethodBase[])null, ref reference2, array3, cultureInfo, (string[])null, out reference), cultureInfo);
		_ = (GClass3)(object)Class5.Default;
		_ = (Class2)(object)((Class7)(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo, (string[])null, out reference)).W(bindingFlags, array4, type, array2, array3);
		class2 = class2;
		try
		{
			try
			{
				if (uIntPtr == 0)
				{
					class2 = class2;
					_ = (Class7)(object)class2.e(bindingFlags, array, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
				}
				else
				{
					gClass2 = (GClass1)(object)((Class7)(object)Class5.Default).j(bindingFlags, null, ref reference2, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)Class5.Default, array5, out *(object*)Class5.Default);
				}
			}
			catch
			{
				class14 = class14;
			}
		}
		catch
		{
			class14 = class14;
		}
		try
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				while (obj != null)
				{
					struct2 = (Struct1)class2.j((BindingFlags)Class5.Default, null, ref reference2, array3, cultureInfo, array5, out *(object*)((Class7)(object)Class5.Default).t((BindingFlags)class2.t(obj, type, cultureInfo), (FieldInfo[])(object)Class5.Default, Class5.Default, cultureInfo));
				}
			}
		}
		catch
		{
		}
		if (uIntPtr == 0)
		{
			if ((UIntPtr)((Class7)(object)Class5.Default).j(bindingFlags, array, ref *(object[]*)null, null, cultureInfo, array5, out reference) == (UIntPtr)(nuint)0u)
			{
				do
				{
					gClass4 = (GClass2)(object)Class5.Default;
				}
				while (obj != null);
			}
		}
		else if (uIntPtr == 0)
		{
			class10 = class10;
			_ = (_003CModule_003E)(object)Class5.Default;
			_ = (Class8)(object)Class5.Default;
			Class7 class41 = class2;
			Class7 class42 = class2;
			BindingFlags bindingFlags_27 = (BindingFlags)((Class7)(object)Class5.Default).W((BindingFlags)class2.t(bindingFlags, (FieldInfo[])(object)((Class7)(object)((Class7)(object)Class5.Default).e(bindingFlags, array, array2, array3)).t(bindingFlags, null, obj, cultureInfo), obj, null), null, null, null, array3);
			Class7 obj43 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_28 = bindingFlags;
			MethodBase[] methodBase_10 = array;
			ref object[] object_12 = ref reference2;
			CultureInfo cultureInfo_4 = cultureInfo;
			string[] string_2 = array5;
			BindingFlags bindingFlags_29 = (BindingFlags)class2.j((BindingFlags)Class5.Default, null, ref *(object[]*)((Class7)null).t(obj, (Type)null, cultureInfo), array3, (CultureInfo)((Class7)(object)class2.W(bindingFlags, array4, (Type)(object)class2.W(bindingFlags, array4, type, (Type[])((Class7)null).t((object)((Class7)(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)class2.e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, null), obj, (CultureInfo)(object)Class5.Default)).t(bindingFlags, (FieldInfo[])(object)class2.W(bindingFlags, array4, (Type)(object)class2.t(default(BindingFlags), array6, null, cultureInfo), null, array3), null, (CultureInfo)(object)Class5.Default), type, (CultureInfo)null), array3), array2, array3)).t(obj, type, null), array5, out reference);
			Class7 class43 = class2;
			Class7 class44 = class2;
			Class7 obj44 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			object object_13 = obj44.j(bindingFlags, array, ref *(object[]*)Class5.Default, array3, cultureInfo, (string[])((Class7)null).t(obj, type, (CultureInfo)(object)Class5.Default), out reference);
			Class7 class45 = class2;
			object object_14 = ((Class7)(object)Class5.Default).t(obj, (Type)(object)Class5.Default, cultureInfo);
			BindingFlags bindingFlags_30 = bindingFlags;
			BindingFlags bindingFlags_31 = bindingFlags;
			Class7 class46 = class2;
			bindingFlags = default(BindingFlags);
			_ = (Class7)(object)class41.t((BindingFlags)class42.e(bindingFlags_27, (MethodBase[])(object)obj43.j(bindingFlags_28, methodBase_10, ref object_12, null, cultureInfo_4, string_2, out *(object*)((Class7)null).e(bindingFlags_29, (MethodBase[])class43.t(class44.t(object_13, (Type)class45.t(object_14, (Type)(object)((Class7)null).e(bindingFlags_30, (MethodBase[])(object)((Class7)null).W(bindingFlags_31, (PropertyInfo[])null, (Type)null, (Type[])(object)class46.j((BindingFlags)((Class7)null).j(bindingFlags, array, ref *(object[]*)class2.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array2, (ParameterModifier[])((Class7)null).t((object)Class5.Default, (Type)null, (CultureInfo)null)), array3, cultureInfo, (string[])null, out reference), array, ref reference2, array3, null, null, out reference), array3), (Type[])null, (ParameterModifier[])(object)((Class7)(object)Class5.Default).W(bindingFlags, array4, null, (Type[])(object)class2.e(bindingFlags, array, null, array3), null)), (CultureInfo)((Class7)(object)class2.j(bindingFlags, null, ref reference2, null, cultureInfo, null, out reference)).t(obj, null, (CultureInfo)(object)Class5.Default)), cultureInfo), (Type)(object)class2.e((BindingFlags)Class5.Default, array, null, array3), (CultureInfo)(object)((Class7)null).W(bindingFlags, array4, (Type)null, array2, (ParameterModifier[])(object)Class5.Default)), array2, array3)), (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default), array6, obj, cultureInfo);
		}
		else
		{
			class12 = (Class10)(object)Class5.Default;
			class11 = (Class2)(object)Class5.Default;
		}
		try
		{
			try
			{
				class10 = (Class0)(object)Class5.Default;
			}
			catch
			{
				_ = (Struct2)Class5.Default;
			}
		}
		catch
		{
			@class = @class;
			gClass4 = null;
			gClass4 = gClass4;
			_ = (GClass3)(object)class2.t(bindingFlags, (FieldInfo[])class2.t(obj, type, (CultureInfo)(object)Class5.Default), obj, cultureInfo);
		}
		struct2 = struct2;
		_003CModule_003E = null;
		struct2 = struct2;
		try
		{
		}
		finally
		{
			_ = (Class6)(object)Class5.Default;
			goto IL_44ce;
		}
		IL_51ad:
		try
		{
			if ((UIntPtr)((Class7)(object)Class5.Default).t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, null) == (UIntPtr)(nuint)0u)
			{
				_ = (Class2)class2.t(null, type, cultureInfo);
			}
		}
		catch
		{
			while (class2.t(null, null, cultureInfo) != null)
			{
				nuint num3 = (nuint)(UIntPtr)class2.t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, cultureInfo) / checked(uIntPtr + unchecked((nuint)(UIntPtr)class2.t(bindingFlags, array6, obj, null)) + unchecked((nuint)default(UIntPtr)));
				uIntPtr = default(UIntPtr);
				if (checked(num3 - uIntPtr) == 0)
				{
					Class7 obj47 = (Class7)(object)((Class7)null).W(bindingFlags, array4, (Type)null, (Type[])null, array3);
					bindingFlags = default(BindingFlags);
					_ = (Class8)(object)obj47.t(bindingFlags, (FieldInfo[])(object)((Class7)(object)Class5.Default).W((BindingFlags)class2.e((BindingFlags)class2.W(bindingFlags, array4, type, (Type[])(object)Class5.Default, array3), array, array2, null), (PropertyInfo[])(object)Class5.Default, type, array2, array3), obj, null);
					class10 = class10;
				}
			}
		}
		if (uIntPtr == 0)
		{
			do
			{
				if (uIntPtr != 0)
				{
					_ = (Class7)(object)Class5.Default;
					_ = (Class0)(object)((Class7)null).e(bindingFlags, array, (Type[])null, (ParameterModifier[])null);
					_ = (GClass3)(object)Class5.Default;
					_ = (Class4)(object)((Class7)(object)Class5.Default).e(bindingFlags, array, array2, array3);
				}
				else
				{
					_ = (GClass0)(object)Class5.Default;
				}
			}
			while (obj != null);
		}
		else
		{
			Class7 class47 = class2;
			BindingFlags bindingFlags_32 = bindingFlags;
			FieldInfo[] fieldInfo_ = array6;
			Class7 obj49 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)class47.t(bindingFlags_32, fieldInfo_, null, (CultureInfo)((Class7)(object)obj49.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array2, array3)).t(null, null, null)) == (UIntPtr)(nuint)0u)
			{
				try
				{
					BindingFlags bindingFlags_33 = (BindingFlags)((Class7)(object)Class5.Default).j((BindingFlags)class2.t(class2.t(obj, type, null), type, cultureInfo), array, ref reference2, array3, cultureInfo, (string[])(object)class2.W((BindingFlags)Class5.Default, null, (Type)(object)((Class7)null).W(default(BindingFlags), (PropertyInfo[])null, type, (Type[])(object)Class5.Default, array3), null, array3), out *(object*)null);
					MethodBase[] methodBase_11 = array;
					Type[] type_6 = array2;
					Class7 class48 = class2;
					bindingFlags = default(BindingFlags);
					_ = (Class5)(object)((Class7)null).j((BindingFlags)((Class7)null).e(bindingFlags_33, methodBase_11, type_6, (ParameterModifier[])(object)class48.j(bindingFlags, array, ref reference2, array3, cultureInfo, null, out *(object*)null)), (MethodBase[])(object)Class5.Default, ref reference2, array3, (CultureInfo)(object)Class5.Default, (string[])null, out reference);
				}
				catch
				{
					_ = Class5.Default;
					Class7 class49 = class2;
					bindingFlags = default(BindingFlags);
					_ = (GClass3)(object)((Class7)null).j((BindingFlags)class49.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)class2.t(null, null, null), null, array3), array, ref reference2, (ParameterModifier[])null, cultureInfo, array5, out reference);
				}
			}
		}
		try
		{
			try
			{
				do
				{
					class11 = null;
					bindingFlags = default(BindingFlags);
				}
				while ((object)((Class7)null).W(bindingFlags, array4, (Type)null, array2, (ParameterModifier[])(object)Class5.Default) != null);
			}
			catch
			{
				do
				{
					_ = (Struct2)Class5.Default;
				}
				while (obj != null);
			}
		}
		catch
		{
			if (uIntPtr == 0)
			{
				try
				{
					class11 = class11;
				}
				finally
				{
					class10 = (Class0)(object)Class5.Default;
					goto end_IL_55be;
				}
			}
			end_IL_55be:;
		}
		while (true)
		{
			if (obj != null)
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					@class = @class;
					_ = (Class6)(object)Class5.Default;
					_ = (GClass0)(object)Class5.Default;
				}
				else
				{
					_ = (GClass3)(object)Class5.Default;
				}
			}
			else if ((object)((Class7)null).t((BindingFlags)Class5.Default, array6, (object)Class5.Default, (CultureInfo)(object)class2.t(bindingFlags, array6, null, null)) == null)
			{
				break;
			}
		}
		Class7 obj54;
		Class7 obj55;
		BindingFlags bindingFlags_34;
		PropertyInfo[] propertyInfo_5;
		Class7 obj56;
		do
		{
			try
			{
				_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
			}
			catch
			{
				gClass3 = gClass3;
				_ = (Class0)(object)Class5.Default;
			}
			finally
			{
				do
				{
					class2 = class2;
					_ = (GClass1)(object)Class5.Default;
					_ = Class5.Default;
				}
				while (obj != null);
				goto IL_56b0;
			}
			IL_56b0:
			obj54 = (Class7)(object)Class5.Default;
			obj55 = (Class7)(object)Class5.Default;
			bindingFlags_34 = bindingFlags;
			propertyInfo_5 = array4;
			obj56 = (Class7)(object)class2.e(bindingFlags, array, null, (ParameterModifier[])(object)Class5.Default);
			bindingFlags = default(BindingFlags);
		}
		while (((Class7)null).t((object)obj54.e((BindingFlags)obj55.W(bindingFlags_34, propertyInfo_5, (Type)(object)obj56.t(bindingFlags, array6, obj, cultureInfo), (Type[])(object)Class5.Default, array3), array, array2, null), (Type)null, cultureInfo) != null);
		bindingFlags = default(BindingFlags);
		if ((UIntPtr)((Class7)null).W(bindingFlags, array4, type, array2, array3) != (UIntPtr)(nuint)0u)
		{
			return;
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			do
			{
				qk = qk;
			}
			while ((object)((Class7)(object)Class5.Default).t(bindingFlags, null, Class5.Default, cultureInfo) != null);
		}
		else if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = (Class4)(object)Class5.Default;
		}
		else
		{
			_ = (Class2)(object)class2.W((BindingFlags)Class5.Default, array4, (Type)(object)Class5.Default, array2, array3);
			_ = (GClass3)(object)Class5.Default;
		}
		return;
		IL_1061:
		uIntPtr = default(UIntPtr);
		if (checked(unchecked(uIntPtr / uIntPtr) - uIntPtr) == 0)
		{
			do
			{
				try
				{
					Class7 obj57 = (Class7)(object)Class5.Default;
					Class7 class50 = class2;
					BindingFlags bindingFlags_35 = bindingFlags;
					Class7 class51 = class2;
					BindingFlags bindingFlags_36 = bindingFlags;
					ref object[] object_15 = ref reference2;
					ParameterModifier[] parameterModifier_6 = array3;
					Class7 obj58 = (Class7)(object)class2.e(bindingFlags, (MethodBase[])(object)class2.e(bindingFlags, array, array2, array3), null, (ParameterModifier[])(object)Class5.Default);
					Class7 class52 = class2;
					Class7 class53 = class2;
					BindingFlags bindingFlags_37 = bindingFlags;
					Class7 class54 = class2;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_38 = (BindingFlags)class52.t(class53.e(bindingFlags_37, null, (Type[])(object)class54.e(bindingFlags, array, array2, array3), null), null, null);
					Class7 obj59 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (GClass0)(object)obj57.e((BindingFlags)class50.W(bindingFlags_35, null, (Type)(object)class51.j(bindingFlags_36, null, ref object_15, parameterModifier_6, null, (string[])(object)obj58.W(bindingFlags_38, (PropertyInfo[])(object)obj59.e(bindingFlags, null, array2, null), type, array2, (ParameterModifier[])(object)Class5.Default), out *(object*)Class5.Default), array2, array3), null, array2, array3);
				}
				catch
				{
					_ = (Class4)(object)Class5.Default;
				}
			}
			while (obj != null);
			goto IL_1407;
		}
		try
		{
			while (obj != null)
			{
				class28 = class28;
				BindingFlags bindingFlags_39 = bindingFlags;
				FieldInfo[] fieldInfo_2 = (FieldInfo[])(object)Class5.Default;
				Class7 obj61 = (Class7)(object)class2.j(bindingFlags, array, ref reference2, array3, cultureInfo, null, out reference);
				bindingFlags = default(BindingFlags);
				_ = (Class10)(object)((Class7)null).t(bindingFlags_39, fieldInfo_2, (object)obj61.e(bindingFlags, (MethodBase[])(object)((Class7)(object)((Class7)(object)Class5.Default).W((BindingFlags)((Class7)null).t((object)Class5.Default, (Type)(object)Class5.Default, cultureInfo), array4, null, null, array3)).e(bindingFlags, (MethodBase[])(object)Class5.Default, null, array3), array2, array3), cultureInfo);
				class2 = class2;
			}
		}
		finally
		{
			try
			{
				_ = (Class6)(object)Class5.Default;
				gClass4 = gClass4;
				gClass4 = gClass4;
			}
			catch
			{
				_ = (GClass0)(object)((Class7)(object)Class5.Default).t((BindingFlags)Class5.Default, array6, obj, cultureInfo);
				_ = (GClass3)(object)class2.t(bindingFlags, (FieldInfo[])(object)Class5.Default, ((Class7)(object)((Class7)(object)Class5.Default).j(bindingFlags, array, ref reference2, null, (CultureInfo)((Class7)class2.t(obj, null, (CultureInfo)(object)Class5.Default)).t(null, (Type)(object)class2.e(bindingFlags, array, array2, null), (CultureInfo)(object)class2.t((BindingFlags)Class5.Default, array6, obj, null)), array5, out *(object*)null)).W(bindingFlags, array4, type, array2, null), null);
				_ = (GClass3)(object)Class5.Default;
				class22 = class22;
			}
			goto IL_1407;
		}
		IL_1bb9:
		_ = (GClass2)(object)Class5.Default;
		do
		{
			try
			{
				class12 = class12;
			}
			catch
			{
				_ = (Class2)(object)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, array2, array3);
			}
		}
		while ((object)Class5.Default != null);
		if (uIntPtr == 0)
		{
			if (uIntPtr == 0)
			{
				do
				{
					_ = (Class4)(object)((Class7)(object)Class5.Default).W((BindingFlags)class2.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, (CultureInfo)(object)Class5.Default), (PropertyInfo[])(object)class2.e(bindingFlags, array, (Type[])(object)class2.t(bindingFlags, array6, obj, null), array3), null, array2, null);
				}
				while (obj != null);
			}
			else if (uIntPtr == 0)
			{
				gClass2 = null;
			}
		}
		else
		{
			while (obj != null)
			{
				if ((UIntPtr)((Class7)(object)((Class7)null).e(bindingFlags, array, (Type[])(object)Class5.Default, (ParameterModifier[])null)).W(bindingFlags, null, null, array2, array3) == (UIntPtr)(nuint)0u)
				{
					_ = (Class10)(object)Class5.Default;
				}
				else
				{
					_ = (GClass1)(object)Class5.Default;
				}
			}
		}
		if (uIntPtr == 0)
		{
			class11 = class11;
		}
		else
		{
			while ((object)class2.e((BindingFlags)((Class7)(object)Class5.Default).W(bindingFlags, array4, type, null, (ParameterModifier[])(object)Class5.Default), (MethodBase[])(object)Class5.Default, null, null) != null)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					class14 = class14;
				}
				else
				{
					_ = (Class8)(object)Class5.Default;
				}
			}
		}
		_ = (Class7)(object)class2.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, null, (ParameterModifier[])(object)Class5.Default);
		gClass = gClass;
		while (true)
		{
			if ((object)Class5.Default != null)
			{
				do
				{
					gClass = (GClass0)(object)Class5.Default;
					gClass4 = gClass4;
					@struct = @struct;
					class28 = null;
				}
				while ((object)Class5.Default != null);
			}
			else if (obj == null)
			{
				break;
			}
		}
		_ = (Class9)(object)Class5.Default;
		try
		{
			while ((object)Class5.Default != null)
			{
				while (class2.t(Class5.Default, type, cultureInfo) != null)
				{
					Class7 obj64 = (Class7)(object)((Class7)(object)((Class7)null).e((BindingFlags)Class5.Default, array, (Type[])(object)class2.W((BindingFlags)class2.t(obj, type, (CultureInfo)(object)Class5.Default), array4, type, array2, (ParameterModifier[])(object)((Class7)null).j(bindingFlags, array, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo, array5, out reference)), (ParameterModifier[])(object)Class5.Default)).e(bindingFlags, array, null, array3);
					object object_16 = obj;
					Type type_7 = (Type)class2.t(obj, (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default);
					Class7 class55 = class2;
					Class7 class56 = class2;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_40 = bindingFlags;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_41 = bindingFlags;
					MethodBase[] methodBase_12 = array;
					Type[] type_8 = array2;
					Class7 class57 = class2;
					BindingFlags bindingFlags_42 = bindingFlags;
					Class7 obj65 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					Class7 obj66 = (Class7)(object)((Class7)null).e(bindingFlags_41, methodBase_12, type_8, (ParameterModifier[])(object)class57.W(bindingFlags_42, null, (Type)(object)obj65.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, (Type[])(object)((Class7)null).e(bindingFlags, array, array2, array3), null), (Type[])(object)Class5.Default, array3));
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_43 = (BindingFlags)class56.j(bindingFlags_40, (MethodBase[])(object)((Class7)null).e((BindingFlags)obj66.e((BindingFlags)((Class7)null).t(bindingFlags, array6, (object)null, (CultureInfo)null), null, (Type[])(object)Class5.Default, null), array, array2, array3), ref reference2, array3, cultureInfo, array5, out reference);
					Class7 class58 = class2;
					bindingFlags = default(BindingFlags);
					_ = (Struct1)obj64.t(object_16, type_7, (CultureInfo)(object)class55.j(bindingFlags_43, (MethodBase[])(object)class58.t(bindingFlags, array6, obj, null), ref reference2, array3, null, null, out *(object*)((Class7)null).j(bindingFlags, array, ref *(object[]*)Class5.Default, (ParameterModifier[])null, (CultureInfo)((Class7)(object)Class5.Default).t(obj, type, cultureInfo), array5, out *(object*)null)));
				}
			}
		}
		finally
		{
			try
			{
				class28 = null;
			}
			finally
			{
				while ((object)Class5.Default != null)
				{
					class11 = class11;
				}
				goto IL_20be;
			}
		}
		IL_0758:
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_44 = (BindingFlags)((Class7)null).t(bindingFlags, array6, (object)Class5.Default, (CultureInfo)null);
					FieldInfo[] fieldInfo_3 = (FieldInfo[])(object)Class5.Default;
					object object_17 = obj;
					Class7 class59 = class2;
					BindingFlags bindingFlags_45 = bindingFlags;
					MethodBase[] methodBase_13 = array;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_46 = bindingFlags;
					Class7 class60 = class2;
					bindingFlags = default(BindingFlags);
					Class7 obj67 = (Class7)(object)class59.j(bindingFlags_45, methodBase_13, ref *(object[]*)((Class7)null).W(bindingFlags_46, (PropertyInfo[])(object)class60.e(bindingFlags, array, array2, array3), type, (Type[])(object)Class5.Default, array3), (ParameterModifier[])(object)Class5.Default, null, array5, out reference);
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_47 = bindingFlags;
					Class7 class61 = class2;
					bindingFlags = default(BindingFlags);
					_ = (GClass0)(object)((Class7)null).t(bindingFlags_44, fieldInfo_3, object_17, (CultureInfo)(object)obj67.j(bindingFlags_47, null, ref *(object[]*)class61.t(bindingFlags, (FieldInfo[])(object)class2.W(bindingFlags, array4, null, array2, null), obj, cultureInfo), (ParameterModifier[])(object)((Class7)null).W((BindingFlags)((Class7)(object)Class5.Default).W(bindingFlags, array4, (Type)(object)((Class7)(object)Class5.Default).t(bindingFlags, null, obj, null), array2, array3), array4, type, (Type[])class2.t(Class5.Default, type, cultureInfo), (ParameterModifier[])null), cultureInfo, null, out reference));
				}
				finally
				{
					class2 = null;
					class22 = class22;
					class22 = class22;
					Class7 obj68 = (Class7)(object)Class5.Default;
					object object_18 = obj;
					Class7 class62 = class2;
					bindingFlags = default(BindingFlags);
					_ = (Class7)obj68.t(object_18, (Type)(object)class62.j(bindingFlags, array, ref reference2, (ParameterModifier[])(object)class2.j(bindingFlags, array, ref reference2, (ParameterModifier[])(object)class2.W(bindingFlags, array4, type, null, array3), null, array5, out *(object*)null), null, null, out reference), cultureInfo);
					goto end_IL_076b;
				}
				end_IL_076b:;
			}
			finally
			{
				gClass2 = (GClass1)(object)class2.t((BindingFlags)Class5.Default, array6, Class5.Default, (CultureInfo)class2.t(obj, null, (CultureInfo)(object)Class5.Default));
				goto IL_0a68;
			}
		}
		Class7 class63;
		BindingFlags bindingFlags_48;
		Class7 class64;
		BindingFlags bindingFlags_49;
		Type[] type_9;
		do
		{
			class2 = null;
			class63 = class2;
			bindingFlags_48 = bindingFlags;
			class64 = class2;
			bindingFlags_49 = bindingFlags;
			type_9 = array2;
			bindingFlags = default(BindingFlags);
		}
		while ((object)class63.e(bindingFlags_48, (MethodBase[])(object)class64.e(bindingFlags_49, null, type_9, (ParameterModifier[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)null, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default)), array2, (ParameterModifier[])(object)Class5.Default) != null);
		goto IL_0a68;
		IL_0ccf:
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr != 0)
			{
				try
				{
					_ = (GClass2)(object)Class5.Default;
					_ = (GClass2)class2.t(obj, (Type)(object)Class5.Default, cultureInfo);
				}
				finally
				{
					_ = (Class9)(object)Class5.Default;
					_003CModule_003E = null;
					class12 = class12;
					goto end_IL_0cd0;
				}
			}
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				_ = (GClass3)(object)Class5.Default;
			}
			end_IL_0cd0:;
		}
		catch
		{
			while (obj != null)
			{
				while ((object)Class5.Default != null)
				{
					class10 = class10;
					_ = (_003CModule_003E)(object)Class5.Default;
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
				try
				{
					Class7 class65 = class2;
					bindingFlags = default(BindingFlags);
					_ = (Class0)(object)class65.j(bindingFlags, array, ref *(object[]*)((Class7)null).t(obj, type, (CultureInfo)(object)Class5.Default), array3, cultureInfo, null, out *(object*)null);
				}
				finally
				{
					@class = (Class4)((Class7)(object)Class5.Default).t(obj, (Type)(object)Class5.Default, null);
					continue;
				}
			}
		}
		while (obj != null);
		try
		{
			try
			{
				class14 = class14;
				qk = (Qk7)(object)class2.j(bindingFlags, array, ref reference2, null, (CultureInfo)(object)((Class7)(object)Class5.Default).j(bindingFlags, array, ref reference2, null, null, array5, out *(object*)null), null, out reference);
				gClass2 = gClass2;
			}
			catch
			{
				_ = (Class4)class2.t(class2.t(null, type, (CultureInfo)(object)Class5.Default), null, (CultureInfo)(object)Class5.Default);
			}
			finally
			{
				if (uIntPtr == 0)
				{
					class22 = null;
				}
				goto end_IL_0df9;
			}
			end_IL_0df9:;
		}
		finally
		{
			while ((object)Class5.Default != null)
			{
				Class7 class66 = class2;
				BindingFlags bindingFlags_50 = (BindingFlags)Class5.Default;
				FieldInfo[] fieldInfo_4 = array6;
				object object_19 = obj;
				Class7 class67 = class2;
				bindingFlags = default(BindingFlags);
				struct2 = (Struct1)((Class7)null).j((BindingFlags)class66.t(bindingFlags_50, fieldInfo_4, object_19, (CultureInfo)(object)class67.j(bindingFlags, null, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)class2.j((BindingFlags)class2.t((BindingFlags)Class5.Default, null, obj, cultureInfo), (MethodBase[])(object)class2.W((BindingFlags)Class5.Default, array4, null, (Type[])(object)((Class7)(object)Class5.Default).t(bindingFlags, null, obj, null), array3), ref *(object[]*)((Class7)(object)Class5.Default).e(bindingFlags, array, (Type[])(object)Class5.Default, null), array3, (CultureInfo)(object)Class5.Default, null, out reference), array5, out reference)), array, ref *(object[]*)((Class7)(object)Class5.Default).e(bindingFlags, array, array2, array3), array3, (CultureInfo)((Class7)null).t(obj, type, (CultureInfo)null), (string[])null, out *(object*)((Class7)(object)class2.e(bindingFlags, null, array2, array3)).e((BindingFlags)class2.W((BindingFlags)Class5.Default, array4, (Type)(object)Class5.Default, array2, null), (MethodBase[])(object)Class5.Default, null, null));
			}
			goto IL_1061;
		}
		IL_38b7:
		if (uIntPtr == 0)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
				{
					struct2 = struct2;
				}
				else
				{
					_ = (GClass2)(object)Class5.Default;
				}
			}
			else
			{
				BindingFlags bindingFlags_51;
				Class7 obj71;
				BindingFlags bindingFlags_52;
				FieldInfo[] fieldInfo_5;
				Class7 class68;
				BindingFlags bindingFlags_53;
				do
				{
					class11 = class11;
					bindingFlags_51 = bindingFlags;
					obj71 = (Class7)(object)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])(object)class2.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array2, (ParameterModifier[])(object)Class5.Default), obj, (CultureInfo)(object)((Class7)class2.t(Class5.Default, type, (CultureInfo)(object)class2.t(bindingFlags, array6, ((Class7)(object)Class5.Default).e((BindingFlags)class2.W((BindingFlags)Class5.Default, (PropertyInfo[])class2.t(Class5.Default, type, null), null, (Type[])(object)Class5.Default, array3), array, array2, array3), (CultureInfo)(object)Class5.Default))).t(bindingFlags, array6, null, null));
					bindingFlags_52 = (BindingFlags)((Class7)null).e(bindingFlags, array, (Type[])null, array3);
					fieldInfo_5 = array6;
					class68 = class2;
					bindingFlags_53 = bindingFlags;
					bindingFlags = default(BindingFlags);
				}
				while ((object)((Class7)null).W(bindingFlags_51, (PropertyInfo[])(object)obj71.t(bindingFlags_52, fieldInfo_5, class68.e(bindingFlags_53, null, (Type[])(object)((Class7)null).e(bindingFlags, array, array2, array3), null), cultureInfo), (Type)null, array2, array3) != null);
			}
		}
		try
		{
			while (obj != null)
			{
				try
				{
					_ = (Class0)(object)Class5.Default;
				}
				finally
				{
					gClass2 = gClass2;
					continue;
				}
			}
		}
		catch
		{
			while (obj != null)
			{
				_ = (Class7)(object)Class5.Default;
			}
		}
		try
		{
			while (obj != null)
			{
				while (obj != null)
				{
					_ = (GClass0)(object)((Class7)(object)class2.W((BindingFlags)((Class7)(object)Class5.Default).t(null, type, cultureInfo), null, null, array2, array3)).t(bindingFlags, array6, obj, cultureInfo);
					Class7 obj73 = (Class7)(object)((Class7)(object)Class5.Default).t(bindingFlags, null, obj, null);
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_54 = bindingFlags;
					Class7 class69 = class2;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_55 = bindingFlags;
					MethodBase[] methodBase_14 = array;
					Class7 class70 = class2;
					BindingFlags bindingFlags_56 = bindingFlags;
					PropertyInfo[] propertyInfo_6 = (PropertyInfo[])(object)Class5.Default;
					Class7 class71 = class2;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_57 = bindingFlags;
					MethodBase[] methodBase_15 = array;
					Class7 class72 = class2;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_58 = bindingFlags;
					PropertyInfo[] propertyInfo_7 = (PropertyInfo[])(object)Class5.Default;
					Type type_10 = type;
					Type[] type_11 = array2;
					bindingFlags = default(BindingFlags);
					Class7 obj74 = (Class7)(object)class72.W(bindingFlags_58, propertyInfo_7, type_10, type_11, (ParameterModifier[])(object)((Class7)null).t(bindingFlags, array6, obj, (CultureInfo)(object)Class5.Default));
					bindingFlags = default(BindingFlags);
					_ = (Class4)(object)obj73.j(bindingFlags_54, (MethodBase[])(object)class69.e(bindingFlags_55, methodBase_14, (Type[])(object)class70.W(bindingFlags_56, propertyInfo_6, (Type)(object)class71.e(bindingFlags_57, methodBase_15, null, (ParameterModifier[])(object)obj74.e(bindingFlags, null, array2, (ParameterModifier[])(object)Class5.Default)), null, (ParameterModifier[])(object)class2.e(bindingFlags, array, null, array3)), (ParameterModifier[])(object)((Class7)null).e(bindingFlags, (MethodBase[])null, array2, array3)), ref *(object[]*)null, array3, cultureInfo, null, out *(object*)((Class7)null).t((object)null, type, cultureInfo));
				}
			}
		}
		finally
		{
			while (obj != null)
			{
				try
				{
					class28 = class28;
				}
				catch
				{
					_ = (Struct1)Class5.Default;
				}
			}
			goto IL_3cd4;
		}
		IL_0a68:
		if ((UIntPtr)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)Class5.Default, (CultureInfo)null) == (UIntPtr)(nuint)0u)
		{
			do
			{
				class12 = null;
			}
			while (obj != null);
		}
		else
		{
			_ = (Class5)(object)class2.W((BindingFlags)Class5.Default, array4, (Type)class2.t(obj, type, cultureInfo), array2, (ParameterModifier[])(object)Class5.Default);
		}
		try
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					Class7 class73 = class2;
					bindingFlags = default(BindingFlags);
					_ = (Qk7)(object)class73.j(bindingFlags, array, ref reference2, array3, cultureInfo, null, out *(object*)null);
				}
				else
				{
					_ = (Class0)(object)Class5.Default;
				}
			}
			finally
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					class22 = null;
				}
				goto end_IL_0ad8;
			}
			end_IL_0ad8:;
		}
		catch
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr / uIntPtr != 0)
			{
				try
				{
					_ = (Qk7)(object)Class5.Default;
				}
				finally
				{
					_ = (_003CModule_003E)(object)Class5.Default;
					goto end_IL_0b43;
				}
			}
			end_IL_0b43:;
		}
		while (obj != null)
		{
			try
			{
				do
				{
					_003CModule_003E = null;
				}
				while (obj != null);
			}
			finally
			{
				Class7 class74;
				Class7 class75;
				Class7 class76;
				do
				{
					_ = (Class2)(object)Class5.Default;
					class74 = class2;
					class75 = class2;
					class76 = class2;
					bindingFlags = default(BindingFlags);
				}
				while (class74.t(class75.t(((Class7)null).j(default(BindingFlags), (MethodBase[])(object)class76.t(bindingFlags, (FieldInfo[])(object)((Class7)null).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)(object)Class5.Default, (Type[])null, array3), Class5.Default, cultureInfo), ref *(object[]*)null, array3, cultureInfo, array5, out *(object*)null), null, null), (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default) != null);
				continue;
			}
		}
		qk = null;
		qk = qk;
		if ((UIntPtr)((Class7)null).t(bindingFlags, array6, (object)null, cultureInfo) == (UIntPtr)(nuint)0u && uIntPtr == 0)
		{
			try
			{
				gClass3 = gClass3;
				gClass3 = gClass3;
				class12 = class12;
				_ = (Qk7)(object)Class5.Default;
			}
			finally
			{
				Class7 class77 = class2;
				bindingFlags = default(BindingFlags);
				class28 = (Class9)(object)class77.j(bindingFlags, null, ref *(object[]*)null, null, null, null, out reference);
				goto IL_0ccf;
			}
		}
		goto IL_0ccf;
		IL_1407:
		while (true)
		{
			if (obj != null)
			{
				if (uIntPtr == 0)
				{
					class17 = (Class6)(object)Class5.Default;
					class10 = null;
					_ = (_003CModule_003E)(object)Class5.Default;
					class12 = null;
				}
			}
			else if (obj == null)
			{
				break;
			}
		}
		while (obj != null)
		{
			try
			{
				UIntPtr num4 = (UIntPtr)class2.t(bindingFlags, array6, obj, cultureInfo);
				uIntPtr = default(UIntPtr);
				checked
				{
					if (unchecked((nuint)num4) - (uIntPtr + uIntPtr) == 0)
					{
						class28 = null;
					}
					else
					{
						@class = (Class4)(object)((Class7)(object)Class5.Default).t(bindingFlags, array6, obj, cultureInfo);
					}
				}
			}
			catch
			{
				_ = (Struct1)Class5.Default;
			}
		}
		do
		{
			if ((UIntPtr)Class5.Default != (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Class5)(object)class2.W((BindingFlags)Class5.Default, array4, type, null, array3);
					class22 = null;
					_ = (Class7)(object)Class5.Default;
				}
				catch
				{
					_ = (Class10)(object)Class5.Default;
				}
			}
		}
		while ((object)Class5.Default != null);
		if (uIntPtr == 0)
		{
		}
		while (obj != null)
		{
		}
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			nuint num5;
			checked
			{
				num5 = unchecked((nuint)(UIntPtr)Class5.Default) * unchecked((nuint)(UIntPtr)Class5.Default);
				uIntPtr = default(UIntPtr);
			}
			if (checked(num5 * uIntPtr) == 0)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					class14 = class14;
				}
				else
				{
					gClass3 = gClass3;
					@struct = @struct;
					_ = (Class6)(object)class2.e(bindingFlags, array, null, null);
				}
			}
			else if (uIntPtr == 0)
			{
				Class7 class78 = class2;
				Class7 obj79 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_59 = (BindingFlags)Class5.Default;
				PropertyInfo[] propertyInfo_8 = (PropertyInfo[])(object)Class5.Default;
				Type type_12 = (Type)(object)Class5.Default;
				Type[] type_13 = (Type[])(object)Class5.Default;
				Class7 class79 = class2;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_60 = bindingFlags;
				ref object[] object_20 = ref *(object[]*)Class5.Default;
				CultureInfo cultureInfo_5 = cultureInfo;
				string[] string_3 = array5;
				BindingFlags bindingFlags_61 = bindingFlags;
				PropertyInfo[] propertyInfo_9 = (PropertyInfo[])(object)((Class7)null).e(bindingFlags, array, (Type[])null, array3);
				Type type_14 = (Type)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				_ = (GClass2)class78.t(((Class7)(object)((Class7)null).e((BindingFlags)obj79.W(bindingFlags_59, propertyInfo_8, type_12, type_13, (ParameterModifier[])(object)class79.j(bindingFlags_60, null, ref object_20, null, cultureInfo_5, string_3, out *(object*)((Class7)null).W(bindingFlags_61, propertyInfo_9, type_14, (Type[])null, (ParameterModifier[])((Class7)null).t((object)((Class7)null).W(bindingFlags, array4, type, array2, array3), (Type)((Class7)null).t(obj, (Type)null, (CultureInfo)(object)Class5.Default), (CultureInfo)null)))), array, (Type[])null, (ParameterModifier[])null)).e(bindingFlags, null, array2, array3), type, (CultureInfo)(object)Class5.Default);
			}
			else
			{
				class12 = (Class10)(object)Class5.Default;
			}
		}
		else
		{
			try
			{
				try
				{
					_ = (GClass2)(object)Class5.Default;
				}
				catch
				{
					_ = (Class0)(object)Class5.Default;
					_ = (Class6)(object)Class5.Default;
					_ = Class5.Default;
				}
			}
			catch
			{
			}
		}
		while (obj != null)
		{
			try
			{
				do
				{
					class2 = (Class7)(object)class2.e(default(BindingFlags), (MethodBase[])(object)Class5.Default, null, array3);
				}
				while (obj != null);
			}
			catch
			{
				_ = (GClass1)(object)class2.W((BindingFlags)class2.j(default(BindingFlags), array, ref reference2, (ParameterModifier[])(object)Class5.Default, cultureInfo, array5, out *(object*)null), array4, type, (Type[])class2.t(null, type, null), null);
			}
		}
		while (true)
		{
			Class7 class80 = class2;
			bindingFlags = default(BindingFlags);
			if ((object)class80.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, null, null) == null)
			{
				break;
			}
			if (uIntPtr == 0)
			{
				class28 = class28;
			}
		}
		try
		{
			if (uIntPtr == 0)
			{
				_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
				class22 = class22;
				_ = (Class8)(object)Class5.Default;
			}
			else
			{
				try
				{
					class17 = null;
					class2 = class2;
					BindingFlags bindingFlags_62 = bindingFlags;
					Class7 class81 = class2;
					BindingFlags bindingFlags_63 = bindingFlags;
					PropertyInfo[] propertyInfo_10 = array4;
					Class7 class82 = class2;
					Class7 class83 = class2;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_64 = (BindingFlags)((Class7)(object)class83.e(bindingFlags, null, array2, array3)).t(Class5.Default, type, cultureInfo);
					PropertyInfo[] propertyInfo_11 = array4;
					Type[] type_15 = array2;
					Class7 class84 = class2;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_65 = bindingFlags;
					MethodBase[] methodBase_16 = array;
					Type[] type_16 = array2;
					Class7 class85 = class2;
					bindingFlags = default(BindingFlags);
					Class7 obj83 = (Class7)(object)class84.e(bindingFlags_65, methodBase_16, type_16, (ParameterModifier[])(object)((Class7)(object)class85.j(bindingFlags, array, ref reference2, array3, null, array5, out *(object*)null)).j(bindingFlags, array, ref reference2, (ParameterModifier[])(object)Class5.Default, null, array5, out reference));
					object object_21 = Class5.Default;
					Type type_17 = type;
					Class7 class86 = class2;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_66 = (BindingFlags)((Class7)null).t(object_21, type_17, (CultureInfo)(object)class86.W(bindingFlags, array4, type, null, null));
					MethodBase[] methodBase_17 = (MethodBase[])class2.t(obj, type, cultureInfo);
					Class7 obj84 = (Class7)class2.t(obj, type, cultureInfo);
					bindingFlags = default(BindingFlags);
					ref object[] object_22 = ref *(object[]*)((Class7)(object)obj84.j(bindingFlags, (MethodBase[])(object)((Class7)(object)class2.t(bindingFlags, null, obj, (CultureInfo)(object)Class5.Default)).W(bindingFlags, array4, (Type)(object)Class5.Default, array2, array3), ref reference2, array3, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out reference)).t(((Class7)class2.t(null, null, cultureInfo)).e((BindingFlags)Class5.Default, array, null, array3), (Type)(object)Class5.Default, cultureInfo);
					ParameterModifier[] parameterModifier_7 = (ParameterModifier[])(object)Class5.Default;
					object object_23 = obj;
					Class7 obj85 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_67 = bindingFlags;
					MethodBase[] methodBase_18 = array;
					Class7 obj86 = (Class7)class2.t(obj, (Type)(object)class2.e((BindingFlags)Class5.Default, array, array2, null), null);
					BindingFlags bindingFlags_68 = bindingFlags;
					Type[] type_18 = array2;
					Class7 class87 = class2;
					bindingFlags = default(BindingFlags);
					_ = (Class10)(object)((Class7)null).j(bindingFlags_62, (MethodBase[])(object)class81.j((BindingFlags)((Class7)null).W(bindingFlags_63, propertyInfo_10, (Type)null, (Type[])(object)((Class7)null).W((BindingFlags)class82.e((BindingFlags)((Class7)null).t((BindingFlags)((Class7)null).W(bindingFlags_64, propertyInfo_11, (Type)null, type_15, (ParameterModifier[])(object)obj83.j(bindingFlags_66, methodBase_17, ref object_22, parameterModifier_7, (CultureInfo)((Class7)null).t(object_23, (Type)(object)obj85.e(bindingFlags_67, methodBase_18, (Type[])(object)obj86.e(bindingFlags_68, null, type_18, (ParameterModifier[])(object)class87.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj, cultureInfo)), array3), (CultureInfo)(object)Class5.Default), array5, out *(object*)null)), (FieldInfo[])null, obj, (CultureInfo)null), array, null, null), (PropertyInfo[])(object)Class5.Default, (Type)null, array2, array3), (ParameterModifier[])null), null, ref reference2, (ParameterModifier[])(object)Class5.Default, null, null, out reference), ref reference2, (ParameterModifier[])null, (CultureInfo)(object)Class5.Default, array5, out *(object*)Class5.Default);
				}
				catch
				{
					_ = (Class6)(object)Class5.Default;
				}
			}
		}
		finally
		{
			class28 = class28;
			goto IL_1bb9;
		}
		IL_2f08:
		nuint num6 = uIntPtr;
		uIntPtr = default(UIntPtr);
		if (checked(num6 - uIntPtr * uIntPtr) == 0)
		{
			while (obj != null)
			{
				try
				{
					_ = (Class7)(object)((Class7)(object)((Class7)(object)Class5.Default).j(bindingFlags, null, ref *(object[]*)null, (ParameterModifier[])(object)class2.j(bindingFlags, array, ref *(object[]*)Class5.Default, null, cultureInfo, array5, out *(object*)null), (CultureInfo)(object)Class5.Default, null, out *(object*)((Class7)null).t(obj, type, cultureInfo))).e((BindingFlags)Class5.Default, array, array2, (ParameterModifier[])(object)Class5.Default);
				}
				finally
				{
					_ = (Class7)(object)Class5.Default;
					continue;
				}
			}
		}
		else
		{
			while (obj != null)
			{
			}
		}
		try
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
				try
				{
					BindingFlags bindingFlags_69 = (BindingFlags)Class5.Default;
					MethodBase[] methodBase_19 = array;
					ref object[] object_24 = ref *(object[]*)class2.W((BindingFlags)Class5.Default, array4, type, null, array3);
					bindingFlags = default(BindingFlags);
					Class7 obj88 = (Class7)(object)((Class7)null).j(bindingFlags, (MethodBase[])class2.t(Class5.Default, type, cultureInfo), ref *(object[]*)null, (ParameterModifier[])(object)((Class7)null).e(bindingFlags, (MethodBase[])null, array2, array3), cultureInfo, array5, out *(object*)Class5.Default);
					bindingFlags = default(BindingFlags);
					gClass4 = (GClass2)((Class7)(object)((Class7)null).j(bindingFlags_69, methodBase_19, ref object_24, (ParameterModifier[])null, (CultureInfo)(object)obj88.e(bindingFlags, array, array2, (ParameterModifier[])(object)Class5.Default), (string[])null, out reference)).t(null, type, cultureInfo);
				}
				catch
				{
					_ = (GClass3)(object)((Class7)null).W((BindingFlags)class2.t(bindingFlags, array6, obj, null), (PropertyInfo[])(object)Class5.Default, type, (Type[])(object)class2.W(bindingFlags, null, (Type)(object)Class5.Default, array2, array3), (ParameterModifier[])((Class7)(object)Class5.Default).t(obj, type, null));
				}
				goto end_IL_2fd9;
			}
			end_IL_2fd9:;
		}
		catch
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					class11 = class11;
				}
				else
				{
					@struct = @struct;
				}
			}
			catch
			{
				try
				{
					class22 = class22;
					_003CModule_003E = _003CModule_003E;
					_ = (_003CModule_003E)(object)Class5.Default;
					goto end_IL_317d;
				}
				finally
				{
					class17 = (Class6)(object)Class5.Default;
					@struct = default(Struct2);
					class28 = class28;
					_ = (GClass2)(object)Class5.Default;
					goto end_IL_317d;
				}
				end_IL_317d:;
			}
		}
		nuint num7 = uIntPtr;
		checked
		{
			nuint num8 = unchecked((nuint)default(UIntPtr)) * unchecked((nuint)default(UIntPtr));
			uIntPtr = default(UIntPtr);
			if (unchecked(num7 / checked(unchecked((nuint)default(UIntPtr)) * (unchecked((nuint)default(UIntPtr)) - (num8 + uIntPtr))) / (nuint)(UIntPtr)Class5.Default) * unchecked((nuint)(UIntPtr)((Class7)null).t((object)null, (Type)null, cultureInfo)) == 0)
			{
				while (obj != null)
				{
					do
					{
						struct2 = (Struct1)Class5.Default;
					}
					while ((object)Class5.Default != null);
				}
			}
			else
			{
				try
				{
					if (uIntPtr == 0)
					{
						gClass = gClass;
						class22 = class22;
					}
				}
				catch
				{
					_ = (Class10)(object)Class5.Default;
				}
			}
		}
		do
		{
			try
			{
				try
				{
					@struct = @struct;
					_ = Class5.Default;
					Class7 class88 = class2;
					BindingFlags bindingFlags_70 = bindingFlags;
					Class7 class89 = class2;
					BindingFlags bindingFlags_71 = (BindingFlags)Class5.Default;
					Class7 obj93 = (Class7)(object)Class5.Default;
					Class7 class90 = class2;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_72 = bindingFlags;
					Class7 class91 = class2;
					BindingFlags bindingFlags_73 = (BindingFlags)((Class7)(object)((Class7)null).t(bindingFlags, array6, obj, (CultureInfo)(object)Class5.Default)).t(bindingFlags, (FieldInfo[])(object)((Class7)(object)class2.j((BindingFlags)Class5.Default, array, ref reference2, null, cultureInfo, array5, out *(object*)Class5.Default)).j((BindingFlags)((Class7)(object)((Class7)null).W(bindingFlags, array4, (Type)(object)Class5.Default, array2, (ParameterModifier[])(object)class2.t(bindingFlags, (FieldInfo[])class2.t(obj, (Type)(object)Class5.Default, cultureInfo), obj, (CultureInfo)(object)((Class7)(object)Class5.Default).W((BindingFlags)Class5.Default, null, type, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default)))).t(obj, type, null), (MethodBase[])class2.t(obj, null, cultureInfo), ref *(object[]*)null, array3, cultureInfo, array5, out *(object*)Class5.Default), null, null);
					MethodBase[] methodBase_20 = array;
					ref object[] object_25 = ref reference2;
					Class7 class92 = class2;
					BindingFlags bindingFlags_74 = bindingFlags;
					FieldInfo[] fieldInfo_6 = (FieldInfo[])(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_75 = (BindingFlags)class90.e(bindingFlags_72, (MethodBase[])(object)((Class7)(object)((Class7)(object)class91.j(bindingFlags_73, methodBase_20, ref object_25, (ParameterModifier[])(object)class92.t(bindingFlags_74, fieldInfo_6, ((Class7)null).t(bindingFlags, (FieldInfo[])(object)Class5.Default, (object)Class5.Default, cultureInfo), cultureInfo), cultureInfo, null, out reference)).t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, obj, null)).t((BindingFlags)class2.j(bindingFlags, null, ref reference2, null, null, (string[])(object)class2.j(bindingFlags, null, ref *(object[]*)Class5.Default, array3, cultureInfo, null, out *(object*)((Class7)null).j(bindingFlags, (MethodBase[])(object)((Class7)null).j(bindingFlags, array, ref reference2, (ParameterModifier[])(object)Class5.Default, cultureInfo, (string[])null, out *(object*)null), ref reference2, (ParameterModifier[])null, (CultureInfo)(object)((Class7)(object)Class5.Default).t(bindingFlags, array6, null, cultureInfo), array5, out reference)), out reference), (FieldInfo[])class2.t(null, type, cultureInfo), obj, cultureInfo), (Type[])(object)Class5.Default, array3);
					FieldInfo[] fieldInfo_7 = array6;
					bindingFlags = default(BindingFlags);
					object object_26 = ((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference2, array3, cultureInfo, (string[])null, out *(object*)null);
					Class7 class93 = class2;
					BindingFlags bindingFlags_76 = (BindingFlags)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Class6)class88.t(((Class7)null).W(bindingFlags_70, (PropertyInfo[])null, (Type)(object)class89.t(bindingFlags_71, (FieldInfo[])(object)obj93.t(bindingFlags_75, fieldInfo_7, object_26, (CultureInfo)(object)class93.e(bindingFlags_76, (MethodBase[])(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)((Class7)null).j(bindingFlags, (MethodBase[])((Class7)null).t((object)null, type, (CultureInfo)null), ref reference2, array3, cultureInfo, array5, out *(object*)((Class7)(object)Class5.Default).j(bindingFlags, array, ref *(object[]*)null, array3, (CultureInfo)(object)class2.t(bindingFlags, null, null, (CultureInfo)(object)Class5.Default), array5, out *(object*)null)), ref *(object[]*)null, array3, (CultureInfo)(object)class2.W(bindingFlags, array4, type, array2, (ParameterModifier[])(object)Class5.Default), (string[])null, out *(object*)Class5.Default), null, (ParameterModifier[])(object)Class5.Default)), null, cultureInfo), array2, (ParameterModifier[])(object)Class5.Default), (Type)(object)Class5.Default, cultureInfo);
				}
				finally
				{
					_ = (GClass0)(object)Class5.Default;
					goto end_IL_3296;
				}
				end_IL_3296:;
			}
			catch
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (Qk7)(object)Class5.Default;
				}
			}
		}
		while (obj != null);
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				_ = (Class8)(object)Class5.Default;
			}
		}
		catch
		{
			try
			{
				_ = (Class0)(object)Class5.Default;
			}
			catch
			{
				while (true)
				{
					class28 = class28;
					_ = (Class8)(object)Class5.Default;
					_ = (Class9)(object)Class5.Default;
					if (obj != null)
					{
						continue;
					}
					goto end_IL_3763;
				}
				end_IL_3763:;
			}
		}
		while ((object)Class5.Default != null)
		{
			while (obj != null)
			{
				try
				{
					_003CModule_003E = _003CModule_003E;
				}
				catch
				{
					_003CModule_003E = null;
				}
			}
		}
		gClass = null;
		struct2 = struct2;
		if (uIntPtr == 0)
		{
			gClass = null;
			goto IL_38b7;
		}
		try
		{
			if ((UIntPtr)class2.t((BindingFlags)((Class7)null).e((BindingFlags)Class5.Default, array, array2, array3), array6, obj, (CultureInfo)(object)((Class7)(object)Class5.Default).j((BindingFlags)((Class7)(object)Class5.Default).j(bindingFlags, array, ref reference2, array3, null, null, out reference), array, ref reference2, (ParameterModifier[])(object)class2.t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, obj, cultureInfo), null, (string[])((Class7)(object)Class5.Default).t(obj, (Type)(object)Class5.Default, cultureInfo), out reference)) == (UIntPtr)(nuint)0u)
			{
				_ = (Class9)(object)Class5.Default;
			}
		}
		finally
		{
			class11 = null;
			goto IL_38b7;
		}
		IL_48ce:
		do
		{
			_ = (GClass0)(object)Class5.Default;
		}
		while (obj != null);
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			while (obj != null)
			{
			}
		}
		else
		{
			while (true)
			{
				Class7 obj98 = (Class7)(object)class2.t(bindingFlags, null, class2.e(bindingFlags, (MethodBase[])(object)Class5.Default, null, null), null);
				BindingFlags bindingFlags_77 = bindingFlags;
				PropertyInfo[] propertyInfo_12 = (PropertyInfo[])(object)((Class7)(object)class2.t(bindingFlags, array6, obj, (CultureInfo)(object)((Class7)null).j(default(BindingFlags), (MethodBase[])null, ref reference2, array3, cultureInfo, (string[])null, out *(object*)null))).j(default(BindingFlags), (MethodBase[])(object)Class5.Default, ref *(object[]*)null, array3, cultureInfo, array5, out reference);
				bindingFlags = default(BindingFlags);
				if ((object)obj98.W(bindingFlags_77, propertyInfo_12, (Type)(object)((Class7)null).j(bindingFlags, array, ref reference2, array3, cultureInfo, (string[])(object)Class5.Default, out reference), null, array3) == null)
				{
					break;
				}
				try
				{
					_ = (GClass1)(object)class2.e(bindingFlags, array, array2, (ParameterModifier[])(object)Class5.Default);
				}
				catch
				{
					_ = (Class4)(object)Class5.Default;
				}
			}
		}
		Class7 class94 = class2;
		Class7 obj100 = (Class7)(object)Class5.Default;
		Class7 class95 = class2;
		bindingFlags = default(BindingFlags);
		BindingFlags bindingFlags_78 = (BindingFlags)((Class7)(object)obj100.W((BindingFlags)class95.e(bindingFlags, array, array2, array3), array4, type, (Type[])class2.t(obj, type, cultureInfo), array3)).t(Class5.Default, (Type)(object)Class5.Default, cultureInfo);
		FieldInfo[] fieldInfo_8 = array6;
		object object_27 = obj;
		Class7 obj101 = (Class7)(object)((Class7)(object)Class5.Default).W((BindingFlags)((Class7)null).t(obj, type, (CultureInfo)(object)Class5.Default), (PropertyInfo[])(object)Class5.Default, type, null, array3);
		Class7 obj102 = (Class7)(object)class2.e(bindingFlags, array, array2, null);
		bindingFlags = default(BindingFlags);
		Class7 obj103 = (Class7)(object)obj101.W((BindingFlags)((Class7)(object)obj102.W(bindingFlags, array4, type, array2, array3)).t(bindingFlags, array6, obj, cultureInfo), null, null, null, null);
		BindingFlags bindingFlags_79 = (BindingFlags)((Class7)null).t((object)null, type, cultureInfo);
		BindingFlags bindingFlags_80 = bindingFlags;
		Class7 obj104 = (Class7)(object)Class5.Default;
		BindingFlags bindingFlags_81 = bindingFlags;
		MethodBase[] methodBase_21 = array;
		ref object[] object_28 = ref *(object[]*)Class5.Default;
		ParameterModifier[] parameterModifier_8 = array3;
		Class7 class96 = class2;
		bindingFlags = default(BindingFlags);
		gClass3 = (GClass3)(object)class94.t(bindingFlags_78, fieldInfo_8, object_27, (CultureInfo)(object)((Class7)null).t((BindingFlags)obj103.W(bindingFlags_79, (PropertyInfo[])(object)((Class7)null).e(bindingFlags_80, (MethodBase[])(object)obj104.j(bindingFlags_81, methodBase_21, ref object_28, parameterModifier_8, (CultureInfo)(object)class96.e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, null), array5, out reference), (Type[])((Class7)(object)Class5.Default).t(null, (Type)(object)Class5.Default, (CultureInfo)class2.t(class2.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference2, (ParameterModifier[])(object)Class5.Default, null, array5, out reference), type, null)), (ParameterModifier[])null), type, (Type[])(object)Class5.Default, null), array6, (object)Class5.Default, cultureInfo));
		gClass3 = null;
		_ = (Qk7)(object)Class5.Default;
		nuint num9 = checked(uIntPtr * uIntPtr);
		uIntPtr = default(UIntPtr);
		nuint num10 = uIntPtr / checked(uIntPtr * unchecked((nuint)(UIntPtr)((Class7)(object)Class5.Default).j(bindingFlags, null, ref *(object[]*)Class5.Default, null, null, array5, out reference)));
		uIntPtr = default(UIntPtr);
		if (checked(num9 - (num10 - uIntPtr)) == 0)
		{
			try
			{
				try
				{
					_ = (Class6)(object)class2.t(bindingFlags, array6, obj, null);
				}
				finally
				{
					Class7 class97 = class2;
					BindingFlags bindingFlags_82 = (BindingFlags)Class5.Default;
					PropertyInfo[] propertyInfo_13 = array4;
					Type type_19 = (Type)(object)Class5.Default;
					Type[] type_20 = array2;
					Class7 class98 = class2;
					Class7 class99 = class2;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_83 = bindingFlags;
					MethodBase[] methodBase_22 = array;
					Class7 class100 = class2;
					Class7 obj105 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Class7)(object)((Class7)(object)class97.W(bindingFlags_82, propertyInfo_13, type_19, type_20, (ParameterModifier[])(object)class98.e((BindingFlags)class99.e(bindingFlags_83, methodBase_22, null, (ParameterModifier[])((Class7)(object)class100.e((BindingFlags)obj105.j(bindingFlags, array, ref reference2, array3, cultureInfo, array5, out *(object*)Class5.Default), (MethodBase[])(object)Class5.Default, null, array3)).t(Class5.Default, null, (CultureInfo)(object)Class5.Default)), (MethodBase[])(object)Class5.Default, array2, array3))).W(bindingFlags, null, null, array2, (ParameterModifier[])(object)((Class7)null).j((BindingFlags)((Class7)(object)Class5.Default).t(obj, (Type)class2.t(null, type, cultureInfo), (CultureInfo)(object)Class5.Default), array, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, (CultureInfo)null, (string[])class2.t(obj, null, (CultureInfo)class2.t(((Class7)(object)Class5.Default).t(class2.e(bindingFlags, null, null, (ParameterModifier[])(object)class2.t(bindingFlags, array6, Class5.Default, cultureInfo)), (Type)(object)Class5.Default, cultureInfo), type, null)), out reference));
					goto end_IL_4d04;
				}
				end_IL_4d04:;
			}
			finally
			{
				Class7 class101 = class2;
				object object_29 = obj;
				Class7 class102 = class2;
				Class7 obj106 = (Class7)(object)class2.j(bindingFlags, array, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, (CultureInfo)((Class7)(object)class2.t((BindingFlags)Class5.Default, null, obj, null)).t(Class5.Default, type, null), array5, out *(object*)null);
				Class7 obj107 = (Class7)(object)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])(object)((Class7)(object)Class5.Default).t(bindingFlags, (FieldInfo[])(object)Class5.Default, Class5.Default, null), (object)null, (CultureInfo)null);
				BindingFlags bindingFlags_84 = bindingFlags;
				PropertyInfo[] propertyInfo_14 = (PropertyInfo[])(object)class2.e(bindingFlags, array, (Type[])(object)class2.t(bindingFlags, (FieldInfo[])(object)((Class7)((Class7)(object)Class5.Default).t(Class5.Default, type, cultureInfo)).j(bindingFlags, (MethodBase[])(object)class2.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, (Type[])(object)((Class7)null).e(default(BindingFlags), (MethodBase[])null, (Type[])null, array3), array3), ref reference2, array3, cultureInfo, null, out *(object*)null), obj, null), null);
				Type type_21 = type;
				PropertyInfo[] propertyInfo_15 = array4;
				Class7 obj108 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				_ = (Class2)class101.t(object_29, (Type)(object)((Class7)(object)class102.j((BindingFlags)obj106.e((BindingFlags)obj107.W(bindingFlags_84, propertyInfo_14, type_21, (Type[])(object)((Class7)null).W(default(BindingFlags), propertyInfo_15, (Type)(object)obj108.e((BindingFlags)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, (Type[])(object)Class5.Default, (ParameterModifier[])null), array, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default), (Type[])((Class7)null).t(obj, (Type)(object)Class5.Default, cultureInfo), (ParameterModifier[])null), array3), array, null, array3), array, ref *(object[]*)Class5.Default, array3, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out reference)).t(bindingFlags, array6, obj, (CultureInfo)(object)class2.e((BindingFlags)Class5.Default, (MethodBase[])(object)class2.e(bindingFlags, (MethodBase[])(object)Class5.Default, array2, null), null, null)), cultureInfo);
				goto IL_51ad;
			}
		}
		goto IL_51ad;
		IL_44ce:
		_ = (GClass3)(object)class2.t(bindingFlags, array6, obj, cultureInfo);
		try
		{
			uIntPtr = default(UIntPtr);
			if (checked(uIntPtr - uIntPtr) == 0)
			{
				try
				{
					_ = Class5.Default;
					class2 = class2;
				}
				catch
				{
					_ = (GClass1)(object)class2.e(bindingFlags, array, array2, array3);
				}
			}
		}
		finally
		{
			_ = (GClass0)class2.t(class2.W((BindingFlags)Class5.Default, null, type, null, array3), type, (CultureInfo)(object)Class5.Default);
			goto IL_457c;
		}
	}

	unsafe static void smethod_8()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object[] reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string[] array2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out FieldInfo[] array3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] array4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class7 class2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class9 @class);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint uIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags);
		try
		{
			try
			{
				uIntPtr = uIntPtr;
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					@class = @class;
					@class = @class;
				}
				else
				{
					class2 = (Class7)(object)Class5.Default;
					class2 = null;
				}
			}
			catch
			{
				_ = (Class8)(object)Class5.Default;
			}
		}
		catch
		{
			do
			{
				Class7 class3 = class2;
				bindingFlags = bindingFlags;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_ = bindingFlags;
				array = array;
				MethodBase[] methodBase_ = array;
				Class7 obj2 = (Class7)(object)Class5.Default;
				BindingFlags bindingFlags_2 = bindingFlags;
				reference = ref *(object[]*)null;
				ref object[] object_ = ref reference;
				array2 = null;
				string[] string_ = array2;
				BindingFlags bindingFlags_3 = (BindingFlags)class2.e(bindingFlags, array, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
				array3 = null;
				array4 = (Type[])(object)obj2.j(bindingFlags_2, null, ref object_, null, null, string_, out *(object*)((Class7)null).t(bindingFlags_3, array3, (object)Class5.Default, (CultureInfo)(object)Class5.Default));
				_ = (GClass3)(object)class3.e(bindingFlags_, methodBase_, array4, null);
				obj3 = obj3;
			}
			while (obj3 != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CultureInfo cultureInfo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] array5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out PropertyInfo[] array6);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref object reference2);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					Class7 class4 = class2;
					BindingFlags bindingFlags_4 = bindingFlags;
					MethodBase[] methodBase_2 = array;
					ref object[] object_2 = ref reference;
					string[] string_2 = array2;
					Class7 obj5 = (Class7)(object)Class5.Default;
					object object_3 = obj3;
					type = type;
					Type type_ = type;
					cultureInfo = cultureInfo;
					_ = (Class5)(object)class4.j(bindingFlags_4, methodBase_2, ref object_2, null, null, string_2, out *(object*)obj5.t(object_3, type_, cultureInfo));
				}
				finally
				{
					@class = @class;
					_ = (Struct1)Class5.Default;
					BindingFlags bindingFlags_5 = bindingFlags;
					MethodBase[] methodBase_3 = array;
					Class7 class5 = class2;
					BindingFlags bindingFlags_6 = (BindingFlags)class2.t(bindingFlags, null, obj3, cultureInfo);
					Type[] type_2 = (Type[])(object)Class5.Default;
					array5 = null;
					_ = (GClass3)(object)((Class7)null).e(bindingFlags_5, methodBase_3, (Type[])null, (ParameterModifier[])(object)class5.e(bindingFlags_6, null, type_2, array5));
					goto end_IL_011f;
				}
				end_IL_011f:;
			}
			finally
			{
				do
				{
					Class7 class6 = class2;
					BindingFlags bindingFlags_7 = bindingFlags;
					Class7 obj6 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_8 = (BindingFlags)Class5.Default;
					MethodBase[] methodBase_4 = array;
					ref object[] object_4 = ref reference;
					Class7 class7 = class2;
					BindingFlags bindingFlags_9 = (BindingFlags)Class5.Default;
					array6 = null;
					ParameterModifier[] parameterModifier_ = (ParameterModifier[])(object)class7.W(bindingFlags_9, array6, null, array4, array5);
					CultureInfo cultureInfo_ = cultureInfo;
					string[] string_3 = array2;
					reference2 = ref reference2;
					MethodBase[] methodBase_5 = (MethodBase[])(object)obj6.j(bindingFlags_8, methodBase_4, ref object_4, parameterModifier_, cultureInfo_, string_3, out reference2);
					Class7 obj7 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_10 = bindingFlags;
					Class7 class8 = class2;
					bindingFlags = default(BindingFlags);
					_ = (Qk7)(object)class6.e(bindingFlags_7, methodBase_5, (Type[])(object)obj7.W(bindingFlags_10, (PropertyInfo[])(object)class8.W(bindingFlags, array6, type, array4, null), null, array4, (ParameterModifier[])(object)class2.t((BindingFlags)Class5.Default, array3, Class5.Default, (CultureInfo)(object)Class5.Default)), array5);
				}
				while ((object)Class5.Default != null);
				goto IL_02e2;
			}
		}
		goto IL_02e2;
		IL_1100:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class10 class9);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass3 gClass);
		do
		{
			try
			{
				try
				{
					class9 = class9;
				}
				finally
				{
					_ = (Class6)(object)class2.e(bindingFlags, (MethodBase[])(object)Class5.Default, array4, (ParameterModifier[])((Class7)null).t((object)null, type, (CultureInfo)(object)class2.W((BindingFlags)((Class7)(object)Class5.Default).W(bindingFlags, array6, null, (Type[])(object)class2.W(bindingFlags, null, null, (Type[])((Class7)null).t(obj3, type, (CultureInfo)null), array5), (ParameterModifier[])(object)Class5.Default), null, null, null, array5)));
					_ = (Class5)(object)class2.j((BindingFlags)Class5.Default, array, ref *(object[]*)Class5.Default, array5, (CultureInfo)(object)Class5.Default, null, out reference2);
					goto end_IL_1100;
				}
				end_IL_1100:;
			}
			finally
			{
				try
				{
					Class7 class10 = class2;
					BindingFlags bindingFlags_11 = (BindingFlags)Class5.Default;
					MethodBase[] methodBase_6 = (MethodBase[])(object)Class5.Default;
					ref object[] object_5 = ref *(object[]*)Class5.Default;
					Class7 class11 = class2;
					BindingFlags bindingFlags_12 = bindingFlags;
					MethodBase[] methodBase_7 = (MethodBase[])(object)class2.j((BindingFlags)Class5.Default, null, ref reference, array5, null, array2, out *(object*)((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])(object)Class5.Default, array4, array5));
					Class7 obj8 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_13 = bindingFlags;
					PropertyInfo[] propertyInfo_ = array6;
					Class7 class12 = class2;
					bindingFlags = default(BindingFlags);
					gClass = (GClass3)(object)class10.j(bindingFlags_11, methodBase_6, ref object_5, (ParameterModifier[])(object)class11.j(bindingFlags_12, methodBase_7, ref *(object[]*)obj8.W(bindingFlags_13, propertyInfo_, (Type)(object)class12.e(bindingFlags, array, array4, array5), null, array5), array5, (CultureInfo)(object)Class5.Default, array2, out reference2), cultureInfo, (string[])class2.t(obj3, (Type)(object)class2.t(bindingFlags, array3, obj3, (CultureInfo)(object)Class5.Default), cultureInfo), out *(object*)null);
					_ = (Struct1)((Class7)null).e(bindingFlags, array, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
					_ = (Class7)(object)Class5.Default;
				}
				finally
				{
					bindingFlags = default(BindingFlags);
					_ = (Qk7)(object)((Class7)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, (Type[])(object)Class5.Default, array5)).W(bindingFlags, null, null, array4, array5);
					_ = (Class6)(object)Class5.Default;
					continue;
				}
			}
		}
		while (obj3 != null);
		Class5 class13 = class13;
		GClass0 gClass2 = gClass2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass2 gClass3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class8 class14);
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					class14 = class14;
				}
				catch
				{
					gClass3 = gClass3;
					_ = (GClass3)(object)Class5.Default;
				}
			}
			catch
			{
				_ = (Qk7)(object)Class5.Default;
			}
		}
		else if (uIntPtr == 0)
		{
			try
			{
				_ = (GClass2)(object)Class5.Default;
			}
			finally
			{
				Class7 class15 = class2;
				bindingFlags = default(BindingFlags);
				_ = (Class8)(object)class15.t(bindingFlags, null, Class5.Default, cultureInfo);
				goto IL_143c;
			}
		}
		goto IL_143c;
		IL_3e36:
		_ = (Class10)(object)class2.e(bindingFlags, (MethodBase[])(object)Class5.Default, null, array5);
		Class7 class16 = class2;
		Type type_3 = (Type)(object)Class5.Default;
		Class7 obj11 = (Class7)(object)class2.W(default(BindingFlags), array6, type, array4, null);
		bindingFlags = default(BindingFlags);
		_ = (Class7)(object)class16.W(default(BindingFlags), null, type_3, (Type[])(object)obj11.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array5, null, null, out reference2), array5);
		_ = Class5.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct1 @struct);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass1 gClass4);
		try
		{
			@struct = (Struct1)class2.t(class2.e(bindingFlags, array, array4, array5), type, cultureInfo);
			_ = (_003CModule_003E)(object)Class5.Default;
			_ = (Class4)(object)class2.W((BindingFlags)Class5.Default, array6, type, array4, (ParameterModifier[])(object)class2.t((BindingFlags)class2.t(obj3, type, cultureInfo), (FieldInfo[])(object)Class5.Default, null, cultureInfo));
			class2 = null;
		}
		catch
		{
			gClass4 = gClass4;
		}
		while (obj3 != null)
		{
			do
			{
				if (uIntPtr == 0)
				{
					_ = (GClass3)(object)Class5.Default;
				}
			}
			while (obj3 != null);
		}
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				while (true)
				{
					Class7 class17 = class2;
					Class7 class18 = class2;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_14 = (BindingFlags)class18.W(bindingFlags, array6, null, array4, null);
					PropertyInfo[] propertyInfo_2 = (PropertyInfo[])class2.t(obj3, null, null);
					Type type_4 = type;
					Class7 obj13 = (Class7)(object)class2.j(bindingFlags, null, ref *(object[]*)((Class7)null).W((BindingFlags)Class5.Default, array6, (Type)null, (Type[])null, array5), array5, cultureInfo, (string[])(object)class2.j(bindingFlags, array, ref reference, null, cultureInfo, array2, out *(object*)class2.t(obj3, type, cultureInfo)), out reference2);
					BindingFlags bindingFlags_15 = bindingFlags;
					Class7 class19 = class2;
					Class7 obj14 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					if ((object)class17.W(bindingFlags_14, propertyInfo_2, type_4, (Type[])(object)obj13.t(bindingFlags_15, (FieldInfo[])(object)class19.t((BindingFlags)obj14.t(bindingFlags, (FieldInfo[])(object)Class5.Default, class2.e((BindingFlags)Class5.Default, array, (Type[])(object)Class5.Default, null), cultureInfo), array3, obj3, null), obj3, cultureInfo), array5) != null)
					{
						_ = (GClass1)(object)Class5.Default;
						_ = (Class7)(object)Class5.Default;
						class9 = class9;
						_ = (Class4)(object)Class5.Default;
						continue;
					}
					break;
				}
			}
		}
		finally
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					Class7 obj15 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_16 = bindingFlags;
					Type type_5 = type;
					Class7 class20 = class2;
					BindingFlags bindingFlags_17 = bindingFlags;
					FieldInfo[] fieldInfo_ = array3;
					BindingFlags bindingFlags_18 = (BindingFlags)((Class7)null).j((BindingFlags)Class5.Default, (MethodBase[])((Class7)(object)Class5.Default).t(Class5.Default, type, (CultureInfo)(object)Class5.Default), ref reference, (ParameterModifier[])(object)Class5.Default, (CultureInfo)(object)Class5.Default, array2, out *(object*)null);
					Class7 obj16 = (Class7)(object)Class5.Default;
					Class7 class21 = class2;
					BindingFlags bindingFlags_19 = (BindingFlags)((Class7)null).t((object)null, type, (CultureInfo)null);
					MethodBase[] methodBase_8 = array;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_20 = (BindingFlags)class21.j(bindingFlags_19, methodBase_8, ref *(object[]*)((Class7)null).W(bindingFlags, array6, type, array4, array5), (ParameterModifier[])(object)class2.W(bindingFlags, array6, type, array4, null), (CultureInfo)(object)Class5.Default, array2, out *(object*)Class5.Default);
					PropertyInfo[] propertyInfo_3 = (PropertyInfo[])(object)Class5.Default;
					Type type_6 = type;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_21 = bindingFlags;
					Class7 obj17 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_22 = bindingFlags;
					PropertyInfo[] propertyInfo_4 = array6;
					Class7 obj18 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Class5)(object)obj15.W(bindingFlags_16, null, type_5, (Type[])(object)class20.t(bindingFlags_17, fieldInfo_, null, (CultureInfo)(object)((Class7)null).t(bindingFlags_18, (FieldInfo[])(object)obj16.W(bindingFlags_20, propertyInfo_3, type_6, (Type[])(object)((Class7)null).j(bindingFlags_21, (MethodBase[])(object)obj17.W(bindingFlags_22, propertyInfo_4, null, (Type[])(object)obj18.t(bindingFlags, null, Class5.Default, null), array5), ref reference, (ParameterModifier[])((Class7)(object)Class5.Default).t(null, null, cultureInfo), cultureInfo, array2, out reference2), array5), (object)class2.t(bindingFlags, (FieldInfo[])(object)((Class7)null).W(bindingFlags, array6, type, (Type[])null, array5), null, cultureInfo), cultureInfo)), null);
				}
				finally
				{
					Class7 class22 = class2;
					Class7 class23 = class2;
					BindingFlags bindingFlags_23 = (BindingFlags)Class5.Default;
					ref object[] object_6 = ref *(object[]*)((Class7)null).e(default(BindingFlags), (MethodBase[])(object)Class5.Default, array4, array5);
					ParameterModifier[] parameterModifier_2 = (ParameterModifier[])(object)Class5.Default;
					CultureInfo cultureInfo_2 = cultureInfo;
					string[] string_4 = array2;
					Class7 class24 = class2;
					bindingFlags = default(BindingFlags);
					_ = (Class4)((Class7)class22.t(class23.j(bindingFlags_23, null, ref object_6, parameterModifier_2, cultureInfo_2, string_4, out *(object*)class24.W(bindingFlags, null, type, null, null)), type, (CultureInfo)(object)Class5.Default)).t(obj3, null, null);
					goto IL_4422;
				}
			}
			goto IL_4422;
		}
		IL_02e2:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qk7 qk);
		try
		{
			qk = qk;
			qk = null;
		}
		finally
		{
			do
			{
				if (checked(unchecked((nuint)(UIntPtr)Class5.Default) + unchecked((nuint)(UIntPtr)Class5.Default)) != 0)
				{
					_ = (Struct1)Class5.Default;
					Class7 class25 = class2;
					object object_7 = obj3;
					Type type_7 = (Type)(object)Class5.Default;
					Class7 class26 = class2;
					BindingFlags bindingFlags_24 = bindingFlags;
					MethodBase[] methodBase_9 = array;
					ref object[] object_8 = ref reference;
					Class7 obj19 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_25 = (BindingFlags)class26.j(bindingFlags_24, methodBase_9, ref object_8, (ParameterModifier[])(object)((Class7)(object)obj19.j((BindingFlags)((Class7)null).j(bindingFlags, array, ref reference, (ParameterModifier[])null, (CultureInfo)null, array2, out reference2), (MethodBase[])(object)Class5.Default, ref reference, array5, null, array2, out reference2)).j(bindingFlags, null, ref *(object[]*)null, array5, cultureInfo, array2, out *(object*)null), cultureInfo, null, out reference2);
					PropertyInfo[] propertyInfo_5 = (PropertyInfo[])(object)Class5.Default;
					Type type_8 = type;
					Type[] type_9 = array4;
					Class7 class27 = class2;
					PropertyInfo[] propertyInfo_6 = array6;
					Type type_10 = (Type)(object)Class5.Default;
					Class7 class28 = class2;
					bindingFlags = default(BindingFlags);
					Class7 obj20 = (Class7)(object)((Class7)null).W(bindingFlags_25, propertyInfo_5, type_8, type_9, (ParameterModifier[])(object)((Class7)(object)class27.W(default(BindingFlags), propertyInfo_6, type_10, null, (ParameterModifier[])(object)((Class7)(object)class28.e(bindingFlags, array, null, array5)).e(bindingFlags, array, array4, array5))).t((BindingFlags)((Class7)null).t(bindingFlags, array3, obj3, (CultureInfo)null), array3, null, cultureInfo));
					BindingFlags bindingFlags_26 = (BindingFlags)class2.t(bindingFlags, null, null, cultureInfo);
					Class7 obj21 = (Class7)(object)class2.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj3, null);
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_27 = bindingFlags;
					FieldInfo[] fieldInfo_2 = (FieldInfo[])(object)class2.j(bindingFlags, array, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, array2, out *(object*)Class5.Default);
					object object_9 = obj3;
					Class7 obj22 = (Class7)(object)class2.e((BindingFlags)class2.t(bindingFlags, null, obj3, cultureInfo), null, null, null);
					BindingFlags bindingFlags_28 = (BindingFlags)Class5.Default;
					PropertyInfo[] propertyInfo_7 = array6;
					Class7 class29 = class2;
					BindingFlags bindingFlags_29 = bindingFlags;
					MethodBase[] methodBase_10 = (MethodBase[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj3, (CultureInfo)null);
					ref object[] object_10 = ref reference;
					Class7 obj23 = (Class7)(object)class2.j(bindingFlags, array, ref reference, array5, null, null, out *(object*)null);
					FieldInfo[] fieldInfo_3 = array3;
					object object_11 = obj3;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_30 = bindingFlags;
					MethodBase[] methodBase_11 = (MethodBase[])(object)class2.t((BindingFlags)((Class7)(object)class2.e(bindingFlags, array, array4, array5)).t(bindingFlags, null, Class5.Default, cultureInfo), null, null, null);
					Class7 class30 = class2;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_31 = bindingFlags;
					MethodBase[] methodBase_12 = array;
					ParameterModifier[] parameterModifier_3 = array5;
					Class7 obj24 = (Class7)(object)class2.e(bindingFlags, array, array4, array5);
					MethodBase[] methodBase_13 = (MethodBase[])(object)Class5.Default;
					ref object[] object_12 = ref reference;
					Class7 class31 = class2;
					bindingFlags = default(BindingFlags);
					Type[] type_11 = (Type[])(object)class30.t((BindingFlags)((Class7)null).j(bindingFlags_31, methodBase_12, ref *(object[]*)null, parameterModifier_3, (CultureInfo)null, (string[])(object)obj24.j(default(BindingFlags), methodBase_13, ref object_12, null, (CultureInfo)(object)class31.e(bindingFlags, array, array4, array5), null, out *(object*)Class5.Default), out *(object*)null), array3, obj3, (CultureInfo)(object)((Class7)null).t(bindingFlags, array3, (object)null, (CultureInfo)null));
					Class7 class32 = class2;
					BindingFlags bindingFlags_32 = bindingFlags;
					Class7 class33 = class2;
					object object_13 = obj3;
					Class7 class34 = class2;
					bindingFlags = default(BindingFlags);
					CultureInfo cultureInfo_3 = (CultureInfo)(object)obj23.t(default(BindingFlags), fieldInfo_3, object_11, (CultureInfo)(object)((Class7)null).e(bindingFlags_30, methodBase_11, type_11, (ParameterModifier[])(object)class32.e(bindingFlags_32, (MethodBase[])class33.t(object_13, null, (CultureInfo)(object)class34.e(bindingFlags, array, null, null)), null, array5)));
					Class7 class35 = class2;
					BindingFlags bindingFlags_33 = bindingFlags;
					Class7 obj25 = (Class7)(object)((Class7)null).j((BindingFlags)Class5.Default, array, ref *(object[]*)Class5.Default, (ParameterModifier[])null, cultureInfo, array2, out *(object*)null);
					bindingFlags = default(BindingFlags);
					MethodBase[] methodBase_14 = (MethodBase[])(object)obj21.t(bindingFlags_27, fieldInfo_2, object_9, (CultureInfo)(object)obj22.W(bindingFlags_28, propertyInfo_7, (Type)(object)class29.j(bindingFlags_29, methodBase_10, ref object_10, null, cultureInfo_3, (string[])(object)class35.j(bindingFlags_33, (MethodBase[])(object)obj25.e(bindingFlags, array, (Type[])(object)class2.e(bindingFlags, array, (Type[])(object)class2.e(bindingFlags, array, array4, null), array5), array5), ref reference, array5, (CultureInfo)class2.t(obj3, null, (CultureInfo)(object)class2.W(bindingFlags, array6, type, null, array5)), (string[])((Class7)(object)((Class7)null).t(bindingFlags, array3, obj3, cultureInfo)).t(null, type, cultureInfo), out *(object*)null), out *(object*)null), (Type[])(object)class2.e(default(BindingFlags), array, (Type[])class2.t(null, type, cultureInfo), array5), array5));
					ref object[] object_14 = ref reference;
					ParameterModifier[] parameterModifier_4 = (ParameterModifier[])(object)Class5.Default;
					CultureInfo cultureInfo_4 = cultureInfo;
					Class7 class36 = class2;
					bindingFlags = default(BindingFlags);
					_ = (Class8)class25.t(object_7, type_7, (CultureInfo)(object)obj20.j(bindingFlags_26, methodBase_14, ref object_14, parameterModifier_4, cultureInfo_4, (string[])(object)class36.j(bindingFlags, null, ref reference, array5, (CultureInfo)(object)Class5.Default, array2, out reference2), out *(object*)Class5.Default));
				}
				else
				{
					_ = (Class4)(object)((Class7)(object)Class5.Default).j(bindingFlags, array, ref *(object[]*)null, array5, (CultureInfo)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, array4, array5), null, out reference2);
				}
			}
			while (class2.t(obj3, null, null) != null);
			goto IL_093d;
		}
		IL_093d:
		gClass2 = null;
		gClass2 = gClass2;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct2 struct2);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = (_003CModule_003E)(object)class2.j(bindingFlags, null, ref reference, array5, cultureInfo, array2, out reference2);
			}
		}
		else
		{
			try
			{
				try
				{
					_ = (GClass1)(object)Class5.Default;
				}
				catch
				{
					_ = (GClass0)(object)Class5.Default;
				}
			}
			catch
			{
				try
				{
					struct2 = struct2;
					struct2 = struct2;
					gClass4 = gClass4;
					gClass4 = null;
				}
				catch
				{
					_ = (Class9)class2.t(null, null, cultureInfo);
				}
			}
		}
		do
		{
			Class7 obj29 = (Class7)(object)((Class7)(object)((Class7)null).e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, array4, array5)).j(default(BindingFlags), array, ref *(object[]*)((Class7)null).t(obj3, (Type)null, cultureInfo), null, cultureInfo, (string[])(object)Class5.Default, out *(object*)null);
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)obj29.t(bindingFlags, array3, obj3, (CultureInfo)(object)((Class7)(object)Class5.Default).j(bindingFlags, (MethodBase[])(object)((Class7)null).e(bindingFlags, (MethodBase[])null, array4, (ParameterModifier[])null), ref reference, (ParameterModifier[])(object)((Class7)(object)Class5.Default).t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, cultureInfo), (CultureInfo)class2.t(obj3, (Type)(object)Class5.Default, cultureInfo), array2, out reference2)) == (UIntPtr)(nuint)0u)
			{
				Class7 class37 = class2;
				bindingFlags = default(BindingFlags);
				_ = (Class9)(object)class37.e(bindingFlags, array, null, null);
			}
		}
		while (obj3 != null || obj3 != null);
		try
		{
			try
			{
				Class7 class38 = class2;
				bindingFlags = default(BindingFlags);
				_ = (Class6)(object)class38.e(bindingFlags, array, null, array5);
			}
			catch
			{
				gClass4 = gClass4;
			}
			finally
			{
				Class7 class39 = class2;
				bindingFlags = default(BindingFlags);
				Class7 obj31 = (Class7)(object)class39.e(bindingFlags, null, array4, array5);
				bindingFlags = default(BindingFlags);
				class9 = (Class10)((Class7)(object)obj31.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array5, null, null, out reference2)).t(null, (Type)(object)Class5.Default, cultureInfo);
				class9 = null;
				goto end_IL_0b30;
			}
			end_IL_0b30:;
		}
		finally
		{
			@class = null;
			goto IL_0c21;
		}
		IL_268f:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class0 class41);
		try
		{
			while (obj3 != null)
			{
				do
				{
					_ = Class5.Default;
				}
				while ((object)Class5.Default != null);
			}
		}
		finally
		{
			while ((object)class2.t(bindingFlags, null, null, cultureInfo) != null)
			{
				if (uIntPtr == 0)
				{
					BindingFlags bindingFlags_34 = bindingFlags;
					Class7 class40 = class2;
					Class7 obj32 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Qk7)(object)((Class7)null).W(bindingFlags_34, (PropertyInfo[])(object)class40.j((BindingFlags)obj32.e(bindingFlags, array, array4, array5), null, ref *(object[]*)null, (ParameterModifier[])class2.t(obj3, type, null), (CultureInfo)(object)Class5.Default, array2, out reference2), type, array4, (ParameterModifier[])(object)Class5.Default);
				}
				else
				{
					class41 = (Class0)class2.t(obj3, null, null);
					_ = (GClass1)(object)Class5.Default;
					class14 = (Class8)(object)Class5.Default;
					_ = (Class2)(object)Class5.Default;
				}
			}
			goto IL_27aa;
		}
		IL_396c:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			_003CModule_003E = null;
		}
		@struct = @struct;
		try
		{
			try
			{
				while (obj3 != null)
				{
					_ = (Class6)(object)Class5.Default;
				}
			}
			finally
			{
				do
				{
					_ = (Struct1)Class5.Default;
				}
				while (obj3 != null);
				goto end_IL_3985;
			}
			end_IL_3985:;
		}
		finally
		{
			try
			{
				_ = (GClass2)(object)Class5.Default;
			}
			finally
			{
				struct2 = struct2;
				goto IL_39cc;
			}
		}
		IL_18f4:
		do
		{
			try
			{
				try
				{
					_ = (Class10)(object)class2.j(bindingFlags, array, ref reference, array5, cultureInfo, null, out reference2);
				}
				finally
				{
					@struct = default(Struct1);
					@struct = @struct;
					goto end_IL_18f4;
				}
				end_IL_18f4:;
			}
			finally
			{
				if (uIntPtr == 0)
				{
					_ = (GClass3)(object)Class5.Default;
				}
				continue;
			}
		}
		while (obj3 != null);
		checked
		{
			try
			{
				if (unchecked((nuint)(UIntPtr)Class5.Default) + unchecked((nuint)(UIntPtr)class2.j(bindingFlags, array, ref reference, array5, (CultureInfo)(object)Class5.Default, array2, out *(object*)null)) + uIntPtr == 0)
				{
					class14 = null;
				}
				else
				{
					gClass3 = gClass3;
				}
			}
			catch
			{
				struct2 = default(Struct2);
				struct2 = struct2;
			}
			finally
			{
				try
				{
					uIntPtr = default(UIntPtr);
					nuint num = uIntPtr;
					Class7 obj34 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					if (num + unchecked((nuint)(UIntPtr)obj34.j(bindingFlags, array, ref reference, array5, null, null, out *(object*)Class5.Default)) == 0)
					{
						_ = (Struct2)Class5.Default;
					}
					else
					{
						struct2 = default(Struct2);
						struct2 = struct2;
					}
				}
				finally
				{
					goto IL_1a2a;
				}
			}
		}
		IL_185e:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class6 class42);
		try
		{
			while (obj3 != null)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (Qk7)(object)Class5.Default;
					_ = (Struct1)Class5.Default;
				}
				else
				{
					_003CModule_003E obj35 = (_003CModule_003E)(object)Class5.Default;
					_003CModule_003E = _003CModule_003E;
					_003CModule_003E = obj35;
				}
			}
		}
		catch
		{
			Class6 obj36 = (Class6)(object)Class5.Default;
			class42 = class42;
			class42 = obj36;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class4 class43);
		try
		{
			while (obj3 != null)
			{
				do
				{
					class43 = (Class4)(object)Class5.Default;
				}
				while (obj3 != null);
			}
		}
		finally
		{
			while (obj3 != null)
			{
				class41 = class41;
			}
			goto IL_18f4;
		}
		IL_4466:
		_ = (Class10)(object)((Class7)class2.t(Class5.Default, type, cultureInfo)).j(bindingFlags, null, ref reference, array5, (CultureInfo)(object)((Class7)(object)Class5.Default).t(bindingFlags, array3, obj3, cultureInfo), (string[])(object)class2.t(bindingFlags, array3, obj3, (CultureInfo)(object)Class5.Default), out reference2);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			while ((object)Class5.Default != null)
			{
			}
		}
		else
		{
			do
			{
				gClass = null;
			}
			while (obj3 != null);
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			try
			{
				_ = (Class9)(object)Class5.Default;
			}
			catch
			{
				Class7 class44 = class2;
				bindingFlags = default(BindingFlags);
				_ = (Class5)(object)class44.j(bindingFlags, array, ref reference, (ParameterModifier[])(object)Class5.Default, null, array2, out *(object*)null);
			}
		}
		else
		{
			Class7 class45 = class2;
			bindingFlags = default(BindingFlags);
			if ((UIntPtr)class45.W(bindingFlags, null, (Type)(object)Class5.Default, null, array5) == (UIntPtr)(nuint)0u)
			{
				if (uIntPtr == 0)
				{
					Class7 class46 = class2;
					bindingFlags = default(BindingFlags);
					_ = (Struct1)class46.e(bindingFlags, (MethodBase[])((Class7)((Class7)null).t(obj3, (Type)(object)class2.t((BindingFlags)class2.W(bindingFlags, array6, type, array4, null), array3, ((Class7)(object)Class5.Default).t(bindingFlags, array3, obj3, cultureInfo), (CultureInfo)(object)((Class7)(object)Class5.Default).t(bindingFlags, null, obj3, null)), cultureInfo)).t(((Class7)(object)Class5.Default).e(bindingFlags, array, array4, array5), null, cultureInfo), array4, array5);
				}
				else
				{
					_ = (GClass3)(object)Class5.Default;
					_ = (Struct1)Class5.Default;
					Class2 class47 = null;
					Class7 obj39 = (Class7)(object)((Class7)(object)Class5.Default).t(bindingFlags, (FieldInfo[])(object)class2.t((BindingFlags)Class5.Default, array3, obj3, cultureInfo), null, cultureInfo);
					bindingFlags = default(BindingFlags);
					_ = (_003CModule_003E)(object)obj39.W(bindingFlags, array6, (Type)((Class7)null).t(obj3, (Type)null, (CultureInfo)(object)Class5.Default), array4, array5);
				}
			}
		}
		try
		{
			if (checked(uIntPtr + uIntPtr) == 0)
			{
				Class7 class48 = class2;
				BindingFlags bindingFlags_35 = bindingFlags;
				FieldInfo[] fieldInfo_4 = array3;
				Class7 class49 = class2;
				bindingFlags = default(BindingFlags);
				Class7 obj40 = (Class7)(object)class49.j(bindingFlags, null, ref *(object[]*)null, array5, cultureInfo, null, out *(object*)((Class7)null).t(bindingFlags, (FieldInfo[])null, (object)class2.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array4, array5), (CultureInfo)(object)Class5.Default));
				bindingFlags = default(BindingFlags);
				if ((UIntPtr)class48.t(bindingFlags_35, fieldInfo_4, obj40.j(bindingFlags, array, ref reference, array5, cultureInfo, (string[])(object)((Class7)(object)class2.W(bindingFlags, array6, type, array4, null)).W(bindingFlags, array6, null, null, null), out *(object*)null), cultureInfo) == (UIntPtr)(nuint)0u)
				{
					@class = (Class9)(object)Class5.Default;
				}
				return;
			}
			try
			{
				class13 = class13;
				return;
			}
			finally
			{
				class13 = class13;
				struct2 = default(Struct2);
				class2 = null;
				return;
			}
		}
		finally
		{
			try
			{
				do
				{
					_ = (GClass3)(object)Class5.Default;
				}
				while (obj3 != null);
				return;
			}
			catch
			{
				if (uIntPtr == 0)
				{
					_ = (Class6)(object)Class5.Default;
				}
				else
				{
					gClass = gClass;
				}
				return;
			}
		}
		IL_34a1:
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			class41 = null;
			qk = qk;
			goto IL_3553;
		}
		try
		{
			try
			{
				class13 = class13;
				_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
				_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
				gClass = (GClass3)(object)class2.W(bindingFlags, (PropertyInfo[])class2.t(obj3, (Type)(object)Class5.Default, cultureInfo), type, array4, array5);
			}
			finally
			{
				_ = (Class7)(object)Class5.Default;
				goto end_IL_34c4;
			}
			end_IL_34c4:;
		}
		finally
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				class43 = null;
			}
			goto IL_3553;
		}
		IL_2f45:
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (Class10)(object)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])null, (Type)(object)Class5.Default, (Type[])null, array5);
			}
			catch
			{
				_ = (GClass3)(object)class2.t(bindingFlags, (FieldInfo[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])(object)((Class7)(object)class2.W(bindingFlags, null, null, array4, (ParameterModifier[])(object)Class5.Default)).j(bindingFlags, array, ref *(object[]*)null, array5, cultureInfo, array2, out *(object*)null), (object)null, cultureInfo), null, (CultureInfo)((Class7)(object)class2.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array5, null, array2, out *(object*)Class5.Default)).t(obj3, null, null));
			}
		}
		else
		{
			_ = (Class6)class2.t(obj3, null, null);
		}
		Class7 obj44;
		Class7 class52;
		Class7 class53;
		do
		{
			_ = (Class8)(object)Class5.Default;
			Class7 class50 = class2;
			BindingFlags bindingFlags_36 = (BindingFlags)class2.e(default(BindingFlags), array, null, null);
			MethodBase[] methodBase_15 = (MethodBase[])(object)class2.j(default(BindingFlags), array, ref reference, array5, cultureInfo, null, out *(object*)Class5.Default);
			ref object[] object_15 = ref *(object[]*)((Class7)(object)class2.e((BindingFlags)class2.t(obj3, null, cultureInfo), (MethodBase[])(object)Class5.Default, array4, null)).t((BindingFlags)((Class7)(object)Class5.Default).j((BindingFlags)((Class7)(object)Class5.Default).t(Class5.Default, null, (CultureInfo)(object)class2.e((BindingFlags)Class5.Default, null, array4, array5)), array, ref *(object[]*)Class5.Default, array5, cultureInfo, null, out *(object*)null), null, null, cultureInfo);
			ParameterModifier[] parameterModifier_5 = array5;
			CultureInfo cultureInfo_5 = cultureInfo;
			Class7 obj43 = (Class7)(object)Class5.Default;
			bindingFlags = default(BindingFlags);
			string[] string_5 = (string[])(object)obj43.e(bindingFlags, array, array4, array5);
			BindingFlags bindingFlags_37 = bindingFlags;
			FieldInfo[] fieldInfo_5 = (FieldInfo[])(object)((Class7)null).e((BindingFlags)Class5.Default, array, array4, array5);
			object object_16 = obj3;
			Class7 class51 = class2;
			bindingFlags = default(BindingFlags);
			obj44 = (Class7)(object)class50.j(bindingFlags_36, methodBase_15, ref object_15, parameterModifier_5, cultureInfo_5, string_5, out *(object*)((Class7)null).t(bindingFlags_37, fieldInfo_5, object_16, (CultureInfo)(object)((Class7)(object)class51.j(bindingFlags, array, ref *(object[]*)null, null, cultureInfo, array2, out reference2)).e(bindingFlags, array, array4, array5)));
			class52 = class2;
			class53 = class2;
			bindingFlags = default(BindingFlags);
		}
		while ((object)((Class7)obj44.t(class52.e((BindingFlags)((Class7)null).W((BindingFlags)class53.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)((Class7)null).t((object)null, type, cultureInfo), array5, null, (string[])(object)Class5.Default, out reference2), (PropertyInfo[])(object)((Class7)(object)Class5.Default).j(bindingFlags, array, ref *(object[]*)null, array5, null, null, out reference2), type, array4, array5), (MethodBase[])(object)Class5.Default, (Type[])(object)Class5.Default, array5), type, (CultureInfo)(object)Class5.Default)).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array4, array5) != null);
		gClass4 = gClass4;
		qk = qk;
		_ = (Qk7)(object)Class5.Default;
		do
		{
			_ = (GClass2)(object)Class5.Default;
		}
		while (((Class7)(object)Class5.Default).t(class2.j(bindingFlags, array, ref *(object[]*)null, array5, cultureInfo, array2, out reference2), null, cultureInfo) != null);
		while (true)
		{
			if (obj3 != null)
			{
				_ = (Struct2)class2.j(bindingFlags, null, ref *(object[]*)Class5.Default, array5, cultureInfo, array2, out reference2);
				continue;
			}
			object object_17 = obj3;
			bindingFlags = default(BindingFlags);
			if ((object)((Class7)null).j((BindingFlags)((Class7)null).t(object_17, (Type)(object)((Class7)null).e(bindingFlags, array, array4, array5), (CultureInfo)class2.t(Class5.Default, null, (CultureInfo)(object)Class5.Default)), array, ref reference, (ParameterModifier[])(object)class2.t(bindingFlags, array3, obj3, cultureInfo), cultureInfo, (string[])null, out reference2) == null && obj3 == null)
			{
				break;
			}
		}
		try
		{
			while (obj3 != null)
			{
				try
				{
					class9 = null;
				}
				finally
				{
					_ = (Qk7)((Class7)null).t(obj3, type, (CultureInfo)null);
					continue;
				}
			}
		}
		finally
		{
			while ((object)Class5.Default != null)
			{
				try
				{
					_003CModule_003E = _003CModule_003E;
				}
				finally
				{
					class9 = class9;
					continue;
				}
			}
			goto IL_34a1;
		}
		IL_143c:
		class13 = class13;
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (GClass0)(object)class2.e(bindingFlags, null, array4, (ParameterModifier[])(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)Class5.Default, (Type[])((Class7)(object)Class5.Default).t(null, type, null), (ParameterModifier[])null));
			}
			finally
			{
				try
				{
					class41 = class41;
					_ = (Struct2)class2.W((BindingFlags)Class5.Default, null, type, (Type[])(object)((Class7)null).e(bindingFlags, array, array4, array5), (ParameterModifier[])(object)Class5.Default);
				}
				finally
				{
					@class = @class;
					goto IL_151c;
				}
			}
		}
		if (uIntPtr == 0)
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				gClass = gClass;
			}
			else
			{
				class13 = null;
			}
		}
		goto IL_151c;
		IL_0c21:
		while (obj3 != null)
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = Class5.Default;
				}
			}
			catch
			{
				try
				{
					gClass3 = gClass3;
				}
				finally
				{
					_ = (Class0)(object)Class5.Default;
					goto end_IL_0c07;
				}
				end_IL_0c07:;
			}
		}
		_ = (Class6)(object)Class5.Default;
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			if (uIntPtr != (UIntPtr)(nuint)0u)
			{
				try
				{
					gClass = (GClass3)(object)Class5.Default;
					gClass = gClass;
				}
				finally
				{
					gClass = gClass;
					goto IL_0ca8;
				}
			}
			try
			{
				_ = (GClass1)(object)Class5.Default;
				gClass4 = (GClass1)(object)Class5.Default;
				class14 = class14;
				class14 = class14;
				class9 = class9;
			}
			catch
			{
				_ = (_003CModule_003E)(object)Class5.Default;
			}
		}
		goto IL_0ca8;
		IL_2e46:
		while ((object)Class5.Default != null)
		{
			try
			{
				class9 = (Class10)(object)Class5.Default;
				_ = (GClass3)class2.t(((Class7)(object)class2.W(bindingFlags, array6, (Type)(object)class2.e((BindingFlags)Class5.Default, array, null, array5), (Type[])(object)Class5.Default, array5)).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref reference, array5, cultureInfo, (string[])(object)Class5.Default, out *(object*)((Class7)null).t(obj3, type, (CultureInfo)(object)Class5.Default)), (Type)(object)Class5.Default, (CultureInfo)(object)Class5.Default);
				_ = (Class4)(object)Class5.Default;
			}
			catch
			{
				_ = (GClass1)(object)class2.t(bindingFlags, array3, obj3, cultureInfo);
			}
			finally
			{
				_ = (Class10)(object)Class5.Default;
				continue;
			}
		}
		class2 = class2;
		try
		{
			try
			{
				nuint num2;
				nuint num3;
				checked
				{
					num2 = uIntPtr * unchecked((nuint)(UIntPtr)Class5.Default);
					num3 = uIntPtr;
					uIntPtr = default(UIntPtr);
				}
				if (num2 / (checked(num3 + uIntPtr) / (nuint)(UIntPtr)Class5.Default) == 0)
				{
					class42 = null;
				}
				else
				{
					_ = (Struct2)Class5.Default;
				}
			}
			finally
			{
				if (checked(uIntPtr - unchecked((nuint)default(UIntPtr))) == 0)
				{
					class2 = class2;
					_ = (Class2)(object)Class5.Default;
					class43 = (Class4)(object)Class5.Default;
					_ = (Struct1)((Class7)(object)class2.j(bindingFlags, array, ref reference, null, null, array2, out *(object*)null)).W(bindingFlags, array6, type, array4, (ParameterModifier[])(object)Class5.Default);
				}
				goto end_IL_2e5d;
			}
			end_IL_2e5d:;
		}
		finally
		{
			while (obj3 != null)
			{
				try
				{
					qk = qk;
				}
				finally
				{
					_ = (Class6)(object)Class5.Default;
					continue;
				}
			}
			goto IL_2f45;
		}
		IL_1a2a:
		class14 = null;
		checked
		{
			if (uIntPtr == 0)
			{
				try
				{
					while ((object)Class5.Default != null)
					{
						class9 = class9;
					}
				}
				finally
				{
					uIntPtr = default(UIntPtr);
					if (unchecked((nuint)default(UIntPtr)) * uIntPtr == 0)
					{
						_ = (GClass2)(object)Class5.Default;
					}
					goto IL_1a83;
				}
			}
			goto IL_1a83;
		}
		IL_27aa:
		@class = null;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_38 = bindingFlags;
				Type[] type_12 = array4;
				Class7 class54 = class2;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_39 = bindingFlags;
				FieldInfo[] fieldInfo_6 = array3;
				Class7 class55 = class2;
				bindingFlags = default(BindingFlags);
				_ = (Class0)(object)((Class7)null).e(bindingFlags_38, (MethodBase[])null, type_12, (ParameterModifier[])(object)class54.t(bindingFlags_39, fieldInfo_6, ((Class7)(object)class55.e(bindingFlags, null, array4, (ParameterModifier[])(object)Class5.Default)).j((BindingFlags)Class5.Default, null, ref *(object[]*)null, (ParameterModifier[])(object)((Class7)(object)Class5.Default).t((BindingFlags)class2.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, array4, array5), null, obj3, null), cultureInfo, (string[])(object)Class5.Default, out reference2), cultureInfo));
			}
			catch
			{
				@struct = default(Struct1);
			}
		}
		gClass4 = (GClass1)(object)Class5.Default;
		gClass4 = gClass4;
		_ = (Struct1)Class5.Default;
		_ = (GClass2)(object)class2.j((BindingFlags)Class5.Default, array, ref reference, array5, null, array2, out reference2);
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			Class7 class56 = class2;
			BindingFlags bindingFlags_40 = bindingFlags;
			Class7 obj49 = (Class7)(object)((Class7)null).j((BindingFlags)Class5.Default, (MethodBase[])(object)((Class7)null).j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, (ParameterModifier[])null, cultureInfo, (string[])null, out *(object*)null), ref reference, (ParameterModifier[])null, (CultureInfo)(object)Class5.Default, (string[])null, out reference2);
			bindingFlags = default(BindingFlags);
			_ = (Class9)(object)class56.j((BindingFlags)((Class7)null).W(bindingFlags_40, (PropertyInfo[])(object)obj49.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj3, (CultureInfo)(object)Class5.Default), type, (Type[])(object)((Class7)null).t(bindingFlags, (FieldInfo[])null, obj3, (CultureInfo)null), array5), array, ref reference, array5, cultureInfo, array2, out *(object*)Class5.Default);
			_ = (Class8)(object)class2.j(bindingFlags, array, ref *(object[]*)null, array5, cultureInfo, array2, out reference2);
		}
		while (obj3 != null)
		{
		}
		_ = (Class2)(object)Class5.Default;
		try
		{
			try
			{
				try
				{
					_ = (Class9)(object)Class5.Default;
				}
				catch
				{
					class42 = null;
				}
			}
			catch
			{
				class43 = (Class4)(object)((Class7)null).j(bindingFlags, array, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, array2, out reference2);
				_ = (GClass3)(object)Class5.Default;
				@class = (Class9)(object)class2.t((BindingFlags)Class5.Default, null, obj3, null);
				_ = (_003CModule_003E)class2.t(obj3, type, cultureInfo);
			}
		}
		catch
		{
			try
			{
				gClass3 = gClass3;
			}
			finally
			{
				try
				{
					Class7 class57 = class2;
					bindingFlags = default(BindingFlags);
					_ = (Class8)(object)class57.e(bindingFlags, array, (Type[])(object)class2.e(bindingFlags, null, array4, array5), array5);
				}
				catch
				{
					_ = (Class0)(object)((Class7)class2.t(null, null, null)).t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, obj3, cultureInfo);
					gClass = null;
				}
				goto end_IL_2ab9;
			}
			end_IL_2ab9:;
		}
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			do
			{
				struct2 = struct2;
			}
			while (obj3 != null);
		}
		while ((object)Class5.Default != null)
		{
			gClass2 = gClass2;
		}
		try
		{
			try
			{
				gClass3 = gClass3;
			}
			catch
			{
				try
				{
					class9 = null;
					@class = null;
				}
				finally
				{
					_ = (Class9)(object)class2.j(bindingFlags, (MethodBase[])class2.t(null, null, null), ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, cultureInfo, array2, out reference2);
					goto end_IL_2b83;
				}
				end_IL_2b83:;
			}
		}
		catch
		{
			try
			{
				_ = (Class7)(object)Class5.Default;
			}
			catch
			{
				try
				{
					gClass2 = gClass2;
					gClass4 = null;
					qk = (Qk7)(object)class2.t(bindingFlags, (FieldInfo[])(object)Class5.Default, obj3, null);
					goto end_IL_2bdf;
				}
				finally
				{
					qk = (Qk7)(object)Class5.Default;
					goto end_IL_2bdf;
				}
				end_IL_2bdf:;
			}
		}
		try
		{
			qk = null;
		}
		catch
		{
			try
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					class41 = null;
				}
			}
			finally
			{
				do
				{
					class41 = null;
				}
				while (obj3 != null);
				goto end_IL_2c33;
			}
			end_IL_2c33:;
		}
		do
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					struct2 = struct2;
				}
			}
			catch
			{
				try
				{
					_ = (Qk7)class2.t(obj3, null, cultureInfo);
				}
				finally
				{
					class13 = null;
					goto end_IL_2c6b;
				}
				end_IL_2c6b:;
			}
			bindingFlags = default(BindingFlags);
		}
		while ((object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, type, array4, array5) != null);
		UIntPtr num4 = uIntPtr;
		uIntPtr = default(UIntPtr);
		checked
		{
			if ((unchecked((nuint)num4) - uIntPtr) * uIntPtr == 0)
			{
				uIntPtr = default(UIntPtr);
				nuint num5 = uIntPtr - uIntPtr;
				uIntPtr = default(UIntPtr);
				if (num5 - uIntPtr == 0)
				{
					try
					{
						_ = (Class9)(object)Class5.Default;
					}
					catch
					{
						_ = (Class4)(object)Class5.Default;
						_ = (Class8)(object)Class5.Default;
					}
				}
			}
			else
			{
				while (obj3 != null)
				{
				}
			}
			if (uIntPtr == 0)
			{
				class42 = null;
			}
			try
			{
				if (uIntPtr == 0)
				{
				}
			}
			finally
			{
				class14 = null;
				goto IL_2e46;
			}
		}
		IL_1a83:
		Class7 class60;
		BindingFlags bindingFlags_41;
		PropertyInfo[] propertyInfo_8;
		Class7 class61;
		do
		{
			try
			{
				Class7 class58 = class2;
				bindingFlags = default(BindingFlags);
				_ = (Class5)(object)((Class7)null).t((BindingFlags)class58.t(null, (Type)(object)((Class7)null).W(bindingFlags, (PropertyInfo[])null, (Type)null, (Type[])(object)Class5.Default, (ParameterModifier[])null), cultureInfo), (FieldInfo[])null, obj3, (CultureInfo)(object)((Class7)(object)Class5.Default).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, (Type)(object)((Class7)null).W((BindingFlags)class2.t(obj3, type, (CultureInfo)(object)Class5.Default), (PropertyInfo[])((Class7)null).t(obj3, (Type)null, cultureInfo), (Type)null, array4, (ParameterModifier[])null), null, null));
			}
			finally
			{
				while ((object)((Class7)(object)class2.e(bindingFlags, array, array4, (ParameterModifier[])((Class7)null).t((object)class2.t((BindingFlags)((Class7)null).t((object)null, type, cultureInfo), array3, Class5.Default, cultureInfo), type, cultureInfo))).e((BindingFlags)Class5.Default, (MethodBase[])class2.t(obj3, type, cultureInfo), (Type[])(object)Class5.Default, array5) != null)
				{
					Class7 class59 = class2;
					bindingFlags = default(BindingFlags);
					_ = (Class10)(object)class59.e(bindingFlags, array, null, (ParameterModifier[])(object)Class5.Default);
				}
				goto IL_1c0e;
			}
			IL_1c0e:
			class60 = class2;
			bindingFlags_41 = bindingFlags;
			propertyInfo_8 = (PropertyInfo[])(object)Class5.Default;
			class61 = class2;
			bindingFlags = default(BindingFlags);
		}
		while ((object)class60.j((BindingFlags)((Class7)null).W(bindingFlags_41, propertyInfo_8, (Type)(object)((Class7)(object)class61.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, null, array4, array5)).j(bindingFlags, null, ref *(object[]*)null, (ParameterModifier[])(object)((Class7)null).j((BindingFlags)Class5.Default, (MethodBase[])null, ref reference, (ParameterModifier[])(object)Class5.Default, (CultureInfo)null, (string[])null, out reference2), null, array2, out *(object*)null), (Type[])null, array5), (MethodBase[])(object)Class5.Default, ref reference, null, (CultureInfo)(object)class2.j((BindingFlags)Class5.Default, (MethodBase[])((Class7)(object)Class5.Default).t(null, null, cultureInfo), ref reference, (ParameterModifier[])(object)class2.t(bindingFlags, null, obj3, cultureInfo), cultureInfo, array2, out *(object*)((Class7)(object)Class5.Default).t(null, (Type)(object)Class5.Default, null)), (string[])(object)Class5.Default, out *(object*)Class5.Default) != null);
		try
		{
			qk = null;
		}
		finally
		{
			try
			{
				class14 = class14;
			}
			catch
			{
				_ = (Class7)(object)Class5.Default;
			}
			goto IL_1d6f;
		}
		IL_0ca8:
		struct2 = struct2;
		UIntPtr num6 = (UIntPtr)((Class7)(object)Class5.Default).W(bindingFlags, array6, type, array4, null);
		uIntPtr = default(UIntPtr);
		if (checked(unchecked((nuint)num6) - uIntPtr) == 0)
		{
			try
			{
				_ = (GClass0)(object)((Class7)null).e(bindingFlags, (MethodBase[])(object)((Class7)(object)Class5.Default).W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, array4, (ParameterModifier[])(object)class2.j(bindingFlags, (MethodBase[])(object)((Class7)null).t((BindingFlags)Class5.Default, (FieldInfo[])(object)Class5.Default, (object)null, (CultureInfo)null), ref reference, null, cultureInfo, null, out reference2)), array4, array5);
				class41 = class41;
				class41 = null;
				@class = null;
				_ = (GClass0)(object)((Class7)(object)class2.W((BindingFlags)Class5.Default, array6, type, (Type[])(object)class2.t((BindingFlags)((Class7)((Class7)(object)Class5.Default).t(obj3, type, cultureInfo)).j(bindingFlags, null, ref reference, (ParameterModifier[])(object)((Class7)null).W((BindingFlags)Class5.Default, (PropertyInfo[])null, (Type)(object)Class5.Default, (Type[])null, array5), null, array2, out reference2), array3, obj3, (CultureInfo)(object)Class5.Default), array5)).t(bindingFlags, array3, obj3, cultureInfo);
			}
			catch
			{
				gClass = null;
				qk = qk;
				_ = (Class9)(object)((Class7)(object)Class5.Default).e(bindingFlags, (MethodBase[])(object)Class5.Default, array4, array5);
			}
			finally
			{
				if (uIntPtr == 0)
				{
					_ = (Class0)(object)Class5.Default;
				}
				else
				{
					Class5 obj62 = Class5.Default;
					class13 = class13;
					class13 = obj62;
				}
				goto IL_0ebe;
			}
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			class13 = null;
		}
		goto IL_0ebe;
		IL_4422:
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u && uIntPtr == 0)
		{
			try
			{
				_ = (Class9)(object)Class5.Default;
			}
			finally
			{
				_ = (Class4)(object)class2.W(bindingFlags, null, (Type)(object)Class5.Default, array4, null);
				goto IL_4466;
			}
		}
		goto IL_4466;
		IL_151c:
		_ = (Class0)(object)Class5.Default;
		UIntPtr num7 = (UIntPtr)class2.W((BindingFlags)((Class7)null).t((object)null, (Type)null, (CultureInfo)null), (PropertyInfo[])(object)((Class7)null).t(bindingFlags, array3, obj3, cultureInfo), null, (Type[])(object)((Class7)(object)Class5.Default).j(bindingFlags, array, ref *(object[]*)null, (ParameterModifier[])(object)class2.W(bindingFlags, array6, null, array4, null), null, array2, out reference2), (ParameterModifier[])(object)Class5.Default);
		uIntPtr = default(UIntPtr);
		Class7 class62;
		BindingFlags bindingFlags_42;
		MethodBase[] methodBase_16;
		Class7 obj63;
		BindingFlags bindingFlags_43;
		PropertyInfo[] propertyInfo_9;
		Class7 obj64;
		checked
		{
			if (unchecked((nuint)num7) + uIntPtr == 0)
			{
				do
				{
					try
					{
						_ = (GClass0)(object)Class5.Default;
					}
					finally
					{
						struct2 = default(Struct2);
						continue;
					}
				}
				while (obj3 != null);
			}
			class62 = class2;
			bindingFlags = default(BindingFlags);
			bindingFlags_42 = bindingFlags;
			methodBase_16 = array;
			obj63 = (Class7)(object)Class5.Default;
			bindingFlags_43 = bindingFlags;
			propertyInfo_9 = array6;
			obj64 = (Class7)(object)Class5.Default;
		}
		BindingFlags bindingFlags_44 = (BindingFlags)Class5.Default;
		MethodBase[] methodBase_17 = (MethodBase[])(object)Class5.Default;
		ref object[] object_18 = ref reference;
		ParameterModifier[] parameterModifier_6 = array5;
		Class7 obj65 = (Class7)((Class7)(object)Class5.Default).t(obj3, type, (CultureInfo)(object)Class5.Default);
		BindingFlags bindingFlags_45 = bindingFlags;
		bindingFlags = default(BindingFlags);
		_ = (Class8)(object)class62.e(bindingFlags_42, methodBase_16, (Type[])(object)obj63.W(bindingFlags_43, propertyInfo_9, (Type)(object)obj64.j(bindingFlags_44, methodBase_17, ref object_18, parameterModifier_6, null, (string[])(object)obj65.j(bindingFlags_45, null, ref *(object[]*)((Class7)null).j(bindingFlags, array, ref reference, array5, (CultureInfo)(object)Class5.Default, (string[])null, out reference2), array5, cultureInfo, array2, out reference2), out *(object*)null), array4, (ParameterModifier[])(object)Class5.Default), array5);
		_ = (Class2)(object)Class5.Default;
		_ = (GClass0)(object)class2.j((BindingFlags)Class5.Default, null, ref reference, (ParameterModifier[])(object)Class5.Default, cultureInfo, array2, out reference2);
		try
		{
			do
			{
				_ = (Class7)(object)Class5.Default;
				class43 = class43;
				@struct = @struct;
			}
			while ((object)class2.W((BindingFlags)((Class7)(object)Class5.Default).e((BindingFlags)Class5.Default, null, array4, (ParameterModifier[])(object)class2.e(bindingFlags, array, array4, null)), (PropertyInfo[])(object)class2.e((BindingFlags)Class5.Default, (MethodBase[])(object)Class5.Default, (Type[])(object)class2.j(bindingFlags, null, ref *(object[]*)Class5.Default, null, (CultureInfo)(object)((Class7)(object)Class5.Default).e(bindingFlags, array, array4, array5), null, out reference2), null), null, null, array5) != null);
		}
		finally
		{
			try
			{
				if (uIntPtr == 0)
				{
					_ = (Qk7)(object)Class5.Default;
				}
			}
			finally
			{
				try
				{
					_ = (_003CModule_003E)(object)Class5.Default;
				}
				finally
				{
					_ = (Class6)(object)class2.j((BindingFlags)Class5.Default, array, ref *(object[]*)Class5.Default, array5, (CultureInfo)(object)Class5.Default, null, out reference2);
					goto IL_185e;
				}
			}
		}
		IL_1d6f:
		_ = (Class9)(object)class2.e((BindingFlags)((Class7)(object)Class5.Default).j(bindingFlags, null, ref *(object[]*)class2.e(bindingFlags, array, array4, (ParameterModifier[])(object)Class5.Default), (ParameterModifier[])(object)((Class7)null).W(bindingFlags, array6, type, (Type[])null, array5), cultureInfo, null, out *(object*)Class5.Default), array, (Type[])(object)Class5.Default, null);
		_ = (GClass2)(object)Class5.Default;
		gClass3 = null;
		if (uIntPtr == 0)
		{
			do
			{
				_ = (Class6)(object)Class5.Default;
			}
			while (obj3 != null);
		}
		_ = (GClass0)(object)Class5.Default;
		if (uIntPtr == 0)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				while (obj3 != null)
				{
					Class7 class63 = class2;
					bindingFlags = default(BindingFlags);
					_ = (Class7)(object)class63.e(bindingFlags, array, array4, array5);
					gClass3 = (GClass2)(object)class2.W(bindingFlags, (PropertyInfo[])(object)Class5.Default, type, null, array5);
				}
			}
			else
			{
				Class7 class64;
				BindingFlags bindingFlags_46;
				Class7 obj66;
				Class7 class65;
				do
				{
					_ = (Class7)(object)Class5.Default;
					class64 = class2;
					bindingFlags_46 = (BindingFlags)Class5.Default;
					obj66 = (Class7)(object)Class5.Default;
					class65 = class2;
					bindingFlags = default(BindingFlags);
				}
				while ((object)((Class7)null).j((BindingFlags)class64.j(bindingFlags_46, (MethodBase[])obj66.t(class65.t(bindingFlags, (FieldInfo[])(object)((Class7)null).t(bindingFlags, array3, obj3, (CultureInfo)(object)Class5.Default), obj3, cultureInfo), null, cultureInfo), ref reference, array5, cultureInfo, array2, out reference2), (MethodBase[])null, ref *(object[]*)null, (ParameterModifier[])(object)Class5.Default, (CultureInfo)null, array2, out *(object*)null) != null);
			}
		}
		_ = (Class9)(object)((Class7)null).t(bindingFlags, array3, obj3, (CultureInfo)null);
		try
		{
			try
			{
				nuint num8 = uIntPtr;
				uIntPtr = default(UIntPtr);
				nuint num9 = uIntPtr;
				uIntPtr = default(UIntPtr);
				nuint num10 = uIntPtr;
				Class7 class66 = class2;
				BindingFlags bindingFlags_47 = bindingFlags;
				PropertyInfo[] propertyInfo_10 = array6;
				Class7 obj67 = (Class7)(object)Class5.Default;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_48 = bindingFlags;
				Class7 obj68 = (Class7)(object)class2.W((BindingFlags)((Class7)null).W((BindingFlags)((Class7)null).e(bindingFlags, (MethodBase[])null, (Type[])(object)class2.W(bindingFlags, array6, type, array4, array5), array5), (PropertyInfo[])null, type, (Type[])null, array5), null, type, null, null);
				bindingFlags = default(BindingFlags);
				Class7 obj69 = (Class7)(object)obj68.j(bindingFlags, array, ref *(object[]*)null, array5, cultureInfo, array2, out reference2);
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_49 = bindingFlags;
				bindingFlags = default(BindingFlags);
				BindingFlags bindingFlags_50 = bindingFlags;
				Class7 class67 = class2;
				bindingFlags = default(BindingFlags);
				nuint num11 = checked(num9 * unchecked(num10 / (nuint)(UIntPtr)class66.W(bindingFlags_47, propertyInfo_10, (Type)(object)obj67.j(bindingFlags_48, (MethodBase[])(object)obj69.j(bindingFlags_49, null, ref *(object[]*)((Class7)null).j(bindingFlags_50, (MethodBase[])(object)class67.t(bindingFlags, array3, null, (CultureInfo)(object)Class5.Default), ref reference, array5, cultureInfo, array2, out *(object*)null), null, null, array2, out reference2), ref reference, array5, null, array2, out reference2), (Type[])(object)Class5.Default, array5))) / uIntPtr;
				uIntPtr = default(UIntPtr);
				if (checked(num8 - (num11 - uIntPtr)) == 0)
				{
					@struct = (Struct1)Class5.Default;
				}
				else
				{
					_ = (GClass3)(object)Class5.Default;
					_ = (Class8)(object)Class5.Default;
					_ = (_003CModule_003E)(object)((Class7)(object)Class5.Default).W(bindingFlags, array6, type, (Type[])(object)class2.t(bindingFlags, null, obj3, cultureInfo), null);
					_ = (GClass1)(object)Class5.Default;
				}
			}
			catch
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = Class5.Default;
				}
				else
				{
					_003CModule_003E = _003CModule_003E;
				}
			}
		}
		catch
		{
			if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					Class7 obj71 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					Class7 obj72 = (Class7)(object)obj71.t(bindingFlags, array3, obj3, null);
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_51 = bindingFlags;
					Class7 class68 = class2;
					Class7 class69 = class2;
					BindingFlags bindingFlags_52 = bindingFlags;
					bindingFlags = default(BindingFlags);
					_ = (Class9)(object)obj72.t(bindingFlags_51, null, class68.W((BindingFlags)class69.W(bindingFlags_52, (PropertyInfo[])(object)((Class7)null).e(bindingFlags, array, (Type[])null, (ParameterModifier[])null), type, null, null), (PropertyInfo[])(object)class2.j(bindingFlags, null, ref reference, (ParameterModifier[])(object)Class5.Default, null, array2, out *(object*)Class5.Default), type, array4, array5), null);
				}
				catch
				{
					_ = (Struct2)Class5.Default;
				}
			}
		}
		_ = (Struct1)Class5.Default;
		while ((object)((Class7)null).W(bindingFlags, array6, type, array4, (ParameterModifier[])null) != null)
		{
			_ = (Class0)(object)class2.e(bindingFlags, array, array4, array5);
		}
		if ((UIntPtr)((Class7)class2.t(null, type, cultureInfo)).j(bindingFlags, array, ref *(object[]*)null, null, cultureInfo, (string[])(object)Class5.Default, out reference2) == (UIntPtr)(nuint)0u)
		{
			try
			{
				class14 = (Class8)(object)Class5.Default;
			}
			finally
			{
				try
				{
					gClass4 = gClass4;
				}
				catch
				{
					Class7 class70 = class2;
					BindingFlags bindingFlags_53 = bindingFlags;
					ref object[] object_19 = ref reference;
					ParameterModifier[] parameterModifier_7 = array5;
					CultureInfo cultureInfo_6 = cultureInfo;
					Class7 obj75 = (Class7)(object)Class5.Default;
					BindingFlags bindingFlags_54 = bindingFlags;
					Class7 obj76 = (Class7)(object)class2.W(default(BindingFlags), (PropertyInfo[])(object)Class5.Default, null, array4, null);
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_55 = bindingFlags;
					MethodBase[] methodBase_18 = array;
					Class7 class71 = class2;
					BindingFlags bindingFlags_56 = bindingFlags;
					FieldInfo[] fieldInfo_7 = array3;
					object object_20 = obj3;
					BindingFlags bindingFlags_57 = bindingFlags;
					Class7 class72 = class2;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_58 = bindingFlags;
					MethodBase[] methodBase_19 = array;
					ref object[] object_21 = ref reference;
					CultureInfo cultureInfo_7 = cultureInfo;
					string[] string_6 = array2;
					BindingFlags bindingFlags_59 = (BindingFlags)Class5.Default;
					PropertyInfo[] propertyInfo_11 = (PropertyInfo[])(object)Class5.Default;
					Class7 class73 = class2;
					BindingFlags bindingFlags_60 = bindingFlags;
					FieldInfo[] fieldInfo_8 = (FieldInfo[])(object)class2.W((BindingFlags)((Class7)null).e(default(BindingFlags), array, (Type[])null, array5), (PropertyInfo[])(object)class2.t(default(BindingFlags), null, null, cultureInfo), type, array4, null);
					object object_22 = obj3;
					Class7 class74 = class2;
					MethodBase[] methodBase_20 = (MethodBase[])(object)Class5.Default;
					Class7 class75 = class2;
					bindingFlags = default(BindingFlags);
					BindingFlags bindingFlags_61 = bindingFlags;
					PropertyInfo[] propertyInfo_12 = array6;
					Class7 obj77 = (Class7)(object)class2.t((BindingFlags)class2.j(bindingFlags, (MethodBase[])(object)Class5.Default, ref *(object[]*)null, array5, cultureInfo, array2, out *(object*)class2.j(default(BindingFlags), array, ref *(object[]*)null, array5, (CultureInfo)(object)Class5.Default, array2, out *(object*)((Class7)(object)Class5.Default).j(default(BindingFlags), array, ref reference, array5, cultureInfo, array2, out *(object*)Class5.Default))), (FieldInfo[])(object)class2.W((BindingFlags)((Class7)null).W(default(BindingFlags), (PropertyInfo[])null, type, (Type[])null, (ParameterModifier[])null), (PropertyInfo[])(object)Class5.Default, (Type)(object)Class5.Default, (Type[])(object)Class5.Default, null), Class5.Default, cultureInfo);
					bindingFlags = default(BindingFlags);
					_ = (Class7)(object)class70.j(bindingFlags_53, null, ref object_19, parameterModifier_7, cultureInfo_6, (string[])(object)obj75.W(bindingFlags_54, (PropertyInfo[])(object)obj76.e(bindingFlags_55, methodBase_18, (Type[])(object)class71.t(bindingFlags_56, fieldInfo_7, object_20, (CultureInfo)(object)((Class7)null).e(bindingFlags_57, (MethodBase[])(object)class72.j(bindingFlags_58, methodBase_19, ref object_21, null, cultureInfo_7, string_6, out *(object*)((Class7)null).W(bindingFlags_59, propertyInfo_11, (Type)((Class7)null).t((object)null, (Type)(object)class73.t(bindingFlags_60, fieldInfo_8, object_22, (CultureInfo)(object)class74.e(default(BindingFlags), methodBase_20, null, (ParameterModifier[])(object)class75.W(bindingFlags_61, propertyInfo_12, null, null, (ParameterModifier[])(object)obj77.W(bindingFlags, array6, type, array4, array5)))), (CultureInfo)(object)Class5.Default), (Type[])(object)Class5.Default, array5)), array4, array5)), array5), type, array4, null), out *(object*)Class5.Default);
				}
				goto IL_268f;
			}
		}
		try
		{
			class43 = (Class4)(object)Class5.Default;
		}
		catch
		{
			gClass2 = null;
		}
		finally
		{
			do
			{
				_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
			}
			while (obj3 != null);
			goto IL_268f;
		}
		IL_0ebe:
		_ = (GClass2)(object)((Class7)null).t(bindingFlags, array3, obj3, (CultureInfo)(object)Class5.Default);
		try
		{
			try
			{
				struct2 = struct2;
			}
			finally
			{
				@class = (Class9)(object)Class5.Default;
				_ = (Class0)(object)class2.e(bindingFlags, array, array4, array5);
				goto end_IL_0ee0;
			}
			end_IL_0ee0:;
		}
		finally
		{
			while (obj3 != null)
			{
			}
			goto IL_0f25;
		}
		IL_0f25:
		try
		{
			while (obj3 != null)
			{
				Class7 obj80 = (Class7)((Class7)(object)Class5.Default).t(Class5.Default, null, null);
				BindingFlags bindingFlags_62 = bindingFlags;
				Class7 class76 = class2;
				bindingFlags = default(BindingFlags);
				if ((UIntPtr)obj80.W(bindingFlags_62, null, (Type)(object)class76.e(bindingFlags, null, (Type[])(object)Class5.Default, null), array4, array5) == (UIntPtr)(nuint)0u)
				{
					Class7 class77 = class2;
					BindingFlags bindingFlags_63 = bindingFlags;
					MethodBase[] methodBase_21 = array;
					ref object[] object_23 = ref reference;
					CultureInfo cultureInfo_8 = (CultureInfo)(object)Class5.Default;
					Class7 class78 = class2;
					BindingFlags bindingFlags_64 = bindingFlags;
					bindingFlags = default(BindingFlags);
					_ = (Class7)(object)class77.j(bindingFlags_63, methodBase_21, ref object_23, null, cultureInfo_8, (string[])(object)class78.j(bindingFlags_64, (MethodBase[])(object)((Class7)null).t(bindingFlags, array3, (object)null, cultureInfo), ref *(object[]*)Class5.Default, null, cultureInfo, null, out reference2), out *(object*)Class5.Default);
				}
				else
				{
					class13 = class13;
				}
			}
		}
		finally
		{
			goto IL_101c;
		}
		IL_101c:
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				try
				{
					class9 = (Class10)(object)Class5.Default;
				}
				catch
				{
					_ = (Class4)(object)class2.e(bindingFlags, array, array4, array5);
				}
			}
			else
			{
				_ = (Class0)(object)Class5.Default;
			}
		}
		catch
		{
		}
		checked
		{
			while (obj3 != null)
			{
				nuint num12 = unchecked((nuint)default(UIntPtr)) * unchecked((nuint)default(UIntPtr));
				uIntPtr = default(UIntPtr);
				if (unchecked((nuint)default(UIntPtr)) * (num12 - uIntPtr) == 0 && uIntPtr == 0)
				{
					bindingFlags = default(BindingFlags);
					_ = (Qk7)(object)((Class7)null).t(bindingFlags, array3, (object)null, cultureInfo);
				}
			}
			try
			{
				gClass2 = null;
			}
			finally
			{
				_ = (GClass3)(object)Class5.Default;
				_ = (GClass1)(object)Class5.Default;
				goto IL_1100;
			}
		}
		IL_3553:
		class2 = (Class7)(object)((Class7)(object)Class5.Default).j(bindingFlags, array, ref *(object[]*)null, array5, cultureInfo, array2, out *(object*)null);
		_ = (Struct1)Class5.Default;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			@class = @class;
		}
		uIntPtr = default(UIntPtr);
		checked
		{
			if (uIntPtr == 0 && uIntPtr - unchecked((nuint)(UIntPtr)class2.j(bindingFlags, array, ref *(object[]*)null, array5, (CultureInfo)(object)Class5.Default, null, out *(object*)null)) == 0)
			{
				unchecked
				{
					try
					{
						bindingFlags = default(BindingFlags);
						BindingFlags bindingFlags_65 = bindingFlags;
						object object_24 = obj3;
						Class7 class79 = class2;
						BindingFlags bindingFlags_66 = bindingFlags;
						FieldInfo[] fieldInfo_9 = array3;
						Class7 class80 = class2;
						bindingFlags = default(BindingFlags);
						Class7 obj83 = (Class7)(object)class80.t(bindingFlags, array3, null, null);
						bindingFlags = default(BindingFlags);
						_ = (Qk7)(object)((Class7)null).t(bindingFlags_65, (FieldInfo[])null, object_24, (CultureInfo)(object)class79.t(bindingFlags_66, fieldInfo_9, obj83.j(bindingFlags, null, ref reference, array5, (CultureInfo)(object)Class5.Default, null, out reference2), cultureInfo));
					}
					catch
					{
						_ = (Class5)(object)((Class7)(object)Class5.Default).W(bindingFlags, array6, type, (Type[])(object)Class5.Default, (ParameterModifier[])(object)Class5.Default);
						class9 = class9;
						_ = (GClass2)(object)Class5.Default;
						bindingFlags = default(BindingFlags);
						BindingFlags bindingFlags_67 = bindingFlags;
						FieldInfo[] fieldInfo_10 = array3;
						Class7 class81 = class2;
						BindingFlags bindingFlags_68 = bindingFlags;
						BindingFlags bindingFlags_69 = (BindingFlags)Class5.Default;
						Type type_13 = type;
						Class7 class82 = class2;
						Class7 obj84 = (Class7)(object)Class5.Default;
						bindingFlags = default(BindingFlags);
						Class7 obj85 = (Class7)(object)obj84.W(bindingFlags, array6, type, array4, null);
						BindingFlags bindingFlags_70 = bindingFlags;
						Class7 obj86 = (Class7)(object)((Class7)(object)Class5.Default).W((BindingFlags)((Class7)null).t(class2.t(obj3, type, null), (Type)class2.t(obj3, type, cultureInfo), (CultureInfo)(object)Class5.Default), array6, type, array4, array5);
						bindingFlags = default(BindingFlags);
						_ = (Class7)(object)((Class7)null).t(bindingFlags_67, fieldInfo_10, (object)class81.j(bindingFlags_68, (MethodBase[])(object)((Class7)null).e((BindingFlags)((Class7)null).W(bindingFlags_69, (PropertyInfo[])null, type_13, (Type[])(object)class82.W((BindingFlags)obj85.t(bindingFlags_70, (FieldInfo[])(object)obj86.t(bindingFlags, null, obj3, cultureInfo), obj3, cultureInfo), (PropertyInfo[])(object)Class5.Default, null, null, array5), array5), (MethodBase[])null, array4, array5), ref reference, array5, null, (string[])(object)Class5.Default, out reference2), cultureInfo);
					}
				}
			}
			_ = (GClass0)(object)Class5.Default;
			while ((object)Class5.Default != null)
			{
				try
				{
					_ = (GClass0)(object)class2.t(bindingFlags, (FieldInfo[])(object)Class5.Default, null, cultureInfo);
				}
				finally
				{
					Class2 class47 = (Class2)(object)Class5.Default;
					class47 = class47;
					_ = (Class8)(object)Class5.Default;
					Class7 obj88 = (Class7)(object)Class5.Default;
					bindingFlags = default(BindingFlags);
					_ = (Struct2)obj88.j(bindingFlags, array, ref reference, array5, (CultureInfo)(object)Class5.Default, (string[])(object)Class5.Default, out reference2);
					continue;
				}
			}
			uIntPtr = default(UIntPtr);
			if (unchecked((nuint)default(UIntPtr)) - uIntPtr == 0)
			{
				_ = (GClass2)(object)class2.W(bindingFlags, null, null, (Type[])((Class7)null).t((object)Class5.Default, (Type)null, (CultureInfo)(object)Class5.Default), null);
				class14 = (Class8)(object)Class5.Default;
				_ = (GClass1)(object)Class5.Default;
				_ = (Class6)(object)Class5.Default;
				goto IL_396c;
			}
			try
			{
				class43 = class43;
			}
			finally
			{
				class41 = class41;
				goto IL_396c;
			}
		}
		IL_39cc:
		class43 = class43;
		while ((object)Class5.Default != null)
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (Class4)(object)((Class7)null).e((BindingFlags)((Class7)null).W((BindingFlags)class2.t(obj3, null, (CultureInfo)(object)Class5.Default), array6, (Type)(object)Class5.Default, (Type[])null, array5), array, (Type[])(object)Class5.Default, (ParameterModifier[])null);
				}
			}
			finally
			{
				while (obj3 != null)
				{
					class42 = null;
				}
				continue;
			}
		}
		do
		{
			UIntPtr num13 = (UIntPtr)class2.e(bindingFlags, (MethodBase[])(object)((Class7)null).W((BindingFlags)((Class7)(object)class2.t(bindingFlags, array3, obj3, cultureInfo)).e(bindingFlags, array, (Type[])(object)Class5.Default, null), array6, (Type)null, array4, (ParameterModifier[])null), null, array5);
			Class7 obj89 = (Class7)(object)Class5.Default;
			Class7 obj90 = (Class7)(object)Class5.Default;
			BindingFlags bindingFlags_71 = (BindingFlags)Class5.Default;
			Class7 class83 = class2;
			bindingFlags = default(BindingFlags);
			checked
			{
				if (unchecked((nuint)num13) + unchecked((nuint)(UIntPtr)obj89.j((BindingFlags)obj90.t(bindingFlags_71, (FieldInfo[])(object)class83.e(bindingFlags, array, null, null), obj3, null), null, ref *(object[]*)Class5.Default, (ParameterModifier[])(object)Class5.Default, null, (string[])(object)Class5.Default, out reference2)) * uIntPtr - unchecked((nuint)(UIntPtr)Class5.Default) - uIntPtr == 0)
				{
				}
			}
		}
		while (obj3 != null);
		if ((UIntPtr)Class5.Default == (UIntPtr)(nuint)0u)
		{
			_ = (GClass1)(object)Class5.Default;
		}
		_ = (_003CModule_003E)(object)Class5.Default;
		try
		{
			_ = (Class7)(object)Class5.Default;
		}
		catch
		{
			try
			{
				while (obj3 != null)
				{
					_ = (GClass2)(object)class2.t(bindingFlags, (FieldInfo[])(object)Class5.Default, class2.j(bindingFlags, array, ref reference, array5, null, array2, out *(object*)null), null);
					class42 = class42;
					class9 = class9;
					_ = (Class7)(object)Class5.Default;
				}
			}
			catch
			{
			}
		}
		_ = (Class0)(object)class2.W((BindingFlags)Class5.Default, null, type, array4, (ParameterModifier[])(object)Class5.Default);
		if ((UIntPtr)class2.j(bindingFlags, array, ref *(object[]*)null, null, cultureInfo, (string[])(object)Class5.Default, out *(object*)null) != (UIntPtr)(nuint)0u)
		{
			_ = (Class0)(object)((Class7)null).t(bindingFlags, array3, ((Class7)((Class7)null).t(obj3, (Type)(object)Class5.Default, cultureInfo)).t(Class5.Default, type, null), cultureInfo);
		}
		while (obj3 != null)
		{
			Class7 class84;
			do
			{
				if (checked(uIntPtr + uIntPtr) != 0)
				{
					_ = (Class5)(object)class2.t(default(BindingFlags), null, obj3, cultureInfo);
				}
				else
				{
					_ = (GClass3)(object)((Class7)null).W(default(BindingFlags), array6, (Type)null, (Type[])null, (ParameterModifier[])null);
				}
				class84 = class2;
				bindingFlags = default(BindingFlags);
			}
			while ((object)class84.e(bindingFlags, array, array4, array5) != null);
		}
		if (uIntPtr == 0)
		{
			try
			{
				class2 = class2;
				_ = (Class8)(object)Class5.Default;
			}
			catch
			{
				_ = (Struct2)((Class7)null).t((object)Class5.Default, (Type)null, cultureInfo);
				class14 = class14;
				_ = (Class6)(object)((Class7)(object)class2.W((BindingFlags)class2.j((BindingFlags)Class5.Default, array, ref reference, array5, (CultureInfo)(object)class2.j(bindingFlags, array, ref *(object[]*)null, null, cultureInfo, null, out reference2), array2, out *(object*)null), array6, type, null, (ParameterModifier[])(object)Class5.Default)).e((BindingFlags)Class5.Default, array, array4, array5);
				_ = (Struct1)Class5.Default;
			}
			finally
			{
				_003CModule_003E = (_003CModule_003E)(object)Class5.Default;
				goto IL_3e36;
			}
		}
		gClass = gClass;
		goto IL_3e36;
	}
}
