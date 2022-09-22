using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

[DebuggerNonUserCode]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
internal sealed class Class17
{
	[CompilerGenerated]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	private sealed class Class18
	{
		private readonly string[] string_0;

		private readonly XNamespace[] xnamespace_0;

		private readonly List<XAttribute> list_0;

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal extern Class18(string[] inScopePrefixes, XNamespace[] inScopeNs, List<XAttribute> attributes);

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal extern XElement method_0(XElement xelement_0);

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal extern object method_1(object object_0);

		static object smethod_0(string[] string_1, XNamespace[] xnamespace_1, List<XAttribute> list_1, XElement xelement_0)
		{
			return smethod_4(string_1, xnamespace_1, list_1, xelement_0);
		}
	}

	public static extern string this[IEnumerable<XElement> ienumerable_0] { get; set; }

	public static string this[IEnumerable<XElement> ienumerable_0, XName xname_0]
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0004: Expected native int or pointer, but got F8
			_003F val = /*Error near IL_0002: Stack underflow*/- /*Error near IL_0002: Stack underflow*/;
			_ = (double)checked(/*Error near IL_0003: Stack underflow*/ * val);
			/*Error near IL_0004: Invalid metadata token*/;
		}
		set; }

	public static extern string this[XElement xelement_0, XName xname_0] { get; set; }

	[EditorBrowsable(EditorBrowsableState.Never)]
	private extern Class17();

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static extern XAttribute smethod_0(XName xname_0, object object_0);

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static extern XAttribute smethod_1(XName xname_0, XNamespace xnamespace_0);

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static extern object smethod_2(string[] string_0, XNamespace[] xnamespace_0, List<XAttribute> list_0, object object_0);

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static extern IEnumerable smethod_3(string[] string_0, XNamespace[] xnamespace_0, List<XAttribute> list_0, IEnumerable ienumerable_0);

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static extern XElement smethod_4(string[] string_0, XNamespace[] xnamespace_0, List<XAttribute> list_0, XElement xelement_0);

	static string smethod_5(object object_0)
	{
		return ((XElement)object_0).get_Value();
	}

	static bool smethod_6(object object_0)
	{
		return ((IEnumerator)object_0).MoveNext();
	}

	static void smethod_7(object object_0)
	{
		((IDisposable)object_0).Dispose();
	}

	static void smethod_8(object object_0, string string_0)
	{
		((XElement)object_0).set_Value(string_0);
	}

	static object smethod_9(object object_0, object object_1)
	{
		return ((XElement)object_0).Attribute((XName)object_1);
	}

	static string smethod_10(XAttribute xattribute_0)
	{
		return (string)xattribute_0;
	}

	static void smethod_11(object object_0, object object_1, object object_2)
	{
		((XElement)object_0).SetAttributeValue((XName)object_1, object_2);
	}

	static object smethod_12(object object_0)
	{
		return RuntimeHelpers.GetObjectValue(object_0);
	}

	static object smethod_13(object object_0, object object_1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return (object)new XAttribute((XName)object_0, object_1);
	}

	static string smethod_14(object object_0)
	{
		return ((XNamespace)object_0).get_NamespaceName();
	}

	static void smethod_15(object object_0, object object_1)
	{
		((XObject)object_0).AddAnnotation(object_1);
	}

	static object smethod_16(string[] string_0, XNamespace[] xnamespace_0, List<XAttribute> list_0, XElement xelement_0)
	{
		return smethod_4(string_0, xnamespace_0, list_0, xelement_0);
	}

	static object smethod_17(string[] string_0, XNamespace[] xnamespace_0, List<XAttribute> list_0, IEnumerable ienumerable_0)
	{
		return smethod_3(string_0, xnamespace_0, list_0, ienumerable_0);
	}

	static object smethod_18(string[] string_0, XNamespace[] xnamespace_0, List<XAttribute> list_0)
	{
		return new Class18(string_0, xnamespace_0, list_0);
	}

	static object smethod_19(object object_0)
	{
		return ((XElement)object_0).get_FirstAttribute();
	}

	static object smethod_20(object object_0)
	{
		return ((XAttribute)object_0).get_NextAttribute();
	}

	static bool smethod_21(object object_0)
	{
		return ((XAttribute)object_0).get_IsNamespaceDeclaration();
	}

	static object smethod_22(object object_0)
	{
		return ((XAttribute)object_0).get_Name();
	}

	static string smethod_23(object object_0)
	{
		return ((XName)object_0).get_LocalName();
	}

	static bool smethod_24(object object_0, string string_0)
	{
		return ((string)object_0).Equals(string_0);
	}

	static bool smethod_25(XNamespace xnamespace_0, XNamespace xnamespace_1)
	{
		return xnamespace_0 == xnamespace_1;
	}

	static void smethod_26(object object_0)
	{
		((XAttribute)object_0).Remove();
	}
}
