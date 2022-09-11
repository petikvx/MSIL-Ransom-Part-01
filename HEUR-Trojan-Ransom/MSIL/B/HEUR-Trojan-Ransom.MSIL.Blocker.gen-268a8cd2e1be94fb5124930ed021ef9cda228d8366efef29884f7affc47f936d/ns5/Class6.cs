using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
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
		public Type I;

		public char x;

		internal bool method_0(MethodInfo methodInfo_0)
		{
			return Class4.smethod_0(I, x);
		}
	}

	protected DependencyPropertyKey p;

	protected Enum0 K;

	protected Enum0 Q;

	protected Enum0 C;

	protected Enum0 b;

	internal Class6(DependencyPropertyKey dependencyPropertyKey_0, Enum0 enum0_0, Enum0 enum0_1)
		: this(dependencyPropertyKey_0, enum0_0, enum0_1, Enum0.I, Enum0.I)
	{
	}

	internal Class6(DependencyPropertyKey dependencyPropertyKey_0, Enum0 enum0_0, Enum0 enum0_1, Enum0 enum0_2, Enum0 enum0_3)
	{
		p = dependencyPropertyKey_0;
		K = enum0_0;
		Q = enum0_1;
		C = enum0_2;
		this.b = enum0_3;
	}

	internal abstract void b(UIElement uielement_0, ContentElement contentElement_0, UIElement3D uielement3D_0, bool bool_0);

	internal void method_0(DependencyObject dependencyObject_0, DependencyObject dependencyObject_1, ref object object_0)
	{
		method_1(dependencyObject_0, dependencyObject_1, null, ref object_0, null);
	}

	internal void method_1(DependencyObject dependencyObject_0, DependencyObject dependencyObject_1, IList<DependencyObject> ilist_0, ref object object_0, Action<DependencyObject, bool> action_0)
	{
		object obj = object_0;
		object_0 = null;
		bool bool_ = action_0 != null && C != 0 && this.b != Enum0.I;
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
		bool flag = smethod_2(uielement_, contentElement_, uielement3D_, K);
		bool flag2 = bool_2 && smethod_2(uielement_, contentElement_, uielement3D_, bool_0 ? this.b : C);
		if (bool_0 != flag || (bool_2 && !flag2) || !bool_1)
		{
			if (bool_0 != flag)
			{
				smethod_1(uielement_, contentElement_, uielement3D_, K, bool_0);
				smethod_1(uielement_, contentElement_, uielement3D_, Q, !smethod_2(uielement_, contentElement_, uielement3D_, Q));
			}
			if (bool_2 && !flag2)
			{
				smethod_1(uielement_, contentElement_, uielement3D_, bool_0 ? this.b : C, bool_0: true);
			}
			smethod_0(uielement_, contentElement_, uielement3D_);
		}
	}

	private void method_3(DependencyObject dependencyObject_0, bool bool_0, object object_0, Action<DependencyObject, bool> action_0)
	{
		smethod_3(dependencyObject_0, out var uielement_, out var contentElement_, out var uielement3D_);
		bool flag = smethod_2(uielement_, contentElement_, uielement3D_, Q);
		bool flag2 = C != 0 && smethod_2(uielement_, contentElement_, uielement3D_, C);
		bool flag3 = this.b != 0 && smethod_2(uielement_, contentElement_, uielement3D_, this.b);
		if (!(flag || flag2 || flag3))
		{
			return;
		}
		if (flag)
		{
			smethod_1(uielement_, contentElement_, uielement3D_, Q, bool_0: false);
			if (bool_0)
			{
				dependencyObject_0.ClearValue(p);
			}
			else
			{
				dependencyObject_0.SetValue(p, (object)true);
			}
			b(uielement_, contentElement_, uielement3D_, bool_0);
		}
		if (flag2 || flag3)
		{
			smethod_1(uielement_, contentElement_, uielement3D_, C, bool_0: false);
			smethod_1(uielement_, contentElement_, uielement3D_, this.b, bool_0: false);
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
}
