using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using ns1;
using ns2;
using ns4;
using ns6;

namespace ns5;

internal abstract class Class6
{
	[CompilerGenerated]
	private sealed class Class7
	{
		public Type U;

		public char q;

		internal bool method_0(MethodInfo methodInfo_0)
		{
			return Class4.smethod_0(U, q);
		}
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 48)]
	private struct Struct0
	{
	}

	protected DependencyPropertyKey N;

	protected Enum0 I;

	protected Enum0 K;

	protected Enum0 C;

	protected Enum0 o;

	private static readonly Array p;

	private static readonly object n = new char[24];

	private static readonly object B;

	internal static byte k/* Not supported: data(00) */;

	internal Class6(DependencyPropertyKey dependencyPropertyKey_0, Enum0 enum0_0, Enum0 enum0_1)
		: this(dependencyPropertyKey_0, enum0_0, enum0_1, Enum0.L, Enum0.L)
	{
	}

	internal Class6(DependencyPropertyKey dependencyPropertyKey_0, Enum0 enum0_0, Enum0 enum0_1, Enum0 enum0_2, Enum0 enum0_3)
	{
		N = dependencyPropertyKey_0;
		I = enum0_0;
		K = enum0_1;
		C = enum0_2;
		o = enum0_3;
	}

	internal abstract void m(UIElement uielement_0, ContentElement contentElement_0, UIElement3D uielement3D_0, bool bool_0);

	internal void method_0(DependencyObject dependencyObject_0, DependencyObject dependencyObject_1, ref object object_0)
	{
		method_1(dependencyObject_0, dependencyObject_1, null, ref object_0, null);
	}

	internal void method_1(DependencyObject dependencyObject_0, DependencyObject dependencyObject_1, IList<DependencyObject> ilist_0, ref object object_0, Action<DependencyObject, bool> action_0)
	{
		object obj = object_0;
		object_0 = null;
		bool bool_ = action_0 != null && C != 0 && o != Enum0.L;
		if (dependencyObject_0 != null)
		{
			method_2(dependencyObject_0, bool_0: false, obj, bool_1: true, bool_);
		}
		if (dependencyObject_1 != null)
		{
			method_2(dependencyObject_1, bool_0: true, null, bool_1: true, bool_);
		}
		int num = ilist_0?.Count ?? 0;
		for (int i = 0; i < num; i++)
		{
			method_2(ilist_0[i], bool_0: true, null, bool_1: false, bool_2: false);
		}
		if (dependencyObject_0 != null)
		{
			method_3(dependencyObject_0, bool_0: true, obj, action_0);
		}
		if (dependencyObject_1 != null)
		{
			method_3(dependencyObject_1, bool_0: false, null, action_0);
		}
		if (object_0 == null && obj != null)
		{
			object_0 = obj;
		}
	}

	private void method_2(DependencyObject dependencyObject_0, bool bool_0, object object_0, bool bool_1, bool bool_2)
	{
		smethod_3(dependencyObject_0, out var uielement_, out var contentElement_, out var uielement3D_);
		bool flag = smethod_2(uielement_, contentElement_, uielement3D_, I);
		bool flag2 = bool_2 && smethod_2(uielement_, contentElement_, uielement3D_, bool_0 ? o : C);
		if (bool_0 != flag || (bool_2 && !flag2) || !bool_1)
		{
			if (bool_0 != flag)
			{
				smethod_1(uielement_, contentElement_, uielement3D_, I, bool_0);
				smethod_1(uielement_, contentElement_, uielement3D_, K, !smethod_2(uielement_, contentElement_, uielement3D_, K));
			}
			if (bool_2 && !flag2)
			{
				smethod_1(uielement_, contentElement_, uielement3D_, bool_0 ? o : C, bool_0: true);
			}
			smethod_0(uielement_, contentElement_, uielement3D_);
		}
	}

	private void method_3(DependencyObject dependencyObject_0, bool bool_0, object object_0, Action<DependencyObject, bool> action_0)
	{
		smethod_3(dependencyObject_0, out var uielement_, out var contentElement_, out var uielement3D_);
		bool flag = smethod_2(uielement_, contentElement_, uielement3D_, K);
		bool flag2 = C != 0 && smethod_2(uielement_, contentElement_, uielement3D_, C);
		bool flag3 = o != 0 && smethod_2(uielement_, contentElement_, uielement3D_, o);
		if (!(flag || flag2 || flag3))
		{
			return;
		}
		if (flag)
		{
			smethod_1(uielement_, contentElement_, uielement3D_, K, bool_0: false);
			if (bool_0)
			{
				dependencyObject_0.ClearValue(N);
			}
			else
			{
				dependencyObject_0.SetValue(N, (object)true);
			}
			m(uielement_, contentElement_, uielement3D_, bool_0);
		}
		if (flag2 || flag3)
		{
			smethod_1(uielement_, contentElement_, uielement3D_, C, bool_0: false);
			smethod_1(uielement_, contentElement_, uielement3D_, o, bool_0: false);
			if (flag2 != flag3)
			{
				action_0(dependencyObject_0, bool_0);
			}
		}
		smethod_0(uielement_, contentElement_, uielement3D_);
	}

	private static bool smethod_0(UIElement uielement_0, ContentElement contentElement_0, UIElement3D uielement3D_0)
	{
		return false;
	}

	private static void smethod_1(UIElement uielement_0, ContentElement contentElement_0, UIElement3D uielement3D_0, Enum0 enum0_0, bool bool_0)
	{
	}

	private static bool smethod_2(UIElement uielement_0, ContentElement contentElement_0, UIElement3D uielement3D_0, Enum0 enum0_0)
	{
		return false;
	}

	private static void smethod_3(DependencyObject dependencyObject_0, out UIElement uielement_0, out ContentElement contentElement_0, out UIElement3D uielement3D_0)
	{
		uielement_0 = (UIElement)(object)((dependencyObject_0 is UIElement) ? dependencyObject_0 : null);
		contentElement_0 = (ContentElement)(object)((uielement_0 != null) ? null : ((dependencyObject_0 is ContentElement) ? dependencyObject_0 : null));
		uielement3D_0 = (UIElement3D)(object)((uielement_0 != null || contentElement_0 != null) ? null : ((dependencyObject_0 is UIElement3D) ? dependencyObject_0 : null));
	}

	protected internal static bool smethod_4(Type type_0, char char_0)
	{
		if (!Enumerable.Any(Class0.Class1.smethod_0(type_0), (MethodInfo methodInfo_0) => Class4.smethod_0(type_0, char_0)))
		{
			return true;
		}
		Class8.smethod_0(type_0)();
		return false;
	}

	static Class6()
	{
		char[] array = new char[8];
		array[5] = 'ᑞ';
		array[7] = 'ᯒ';
		array[4] = 'ཉ';
		array[6] = 'ᓐ';
		array[2] = '៲';
		array[0] = '㟒';
		array[1] = 'Ǚ';
		array[3] = 'ሜ';
		B = new string[2];
		p = array;
	}
}
