using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

[DebuggerNonUserCode]
[EditorBrowsable(EditorBrowsableState.Never)]
[CompilerGenerated]
internal sealed class Class3
{
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[CompilerGenerated]
	private sealed class Class4
	{
		private readonly string[] string_0;

		private readonly XNamespace[] xnamespace_0;

		private readonly List<XAttribute> list_0;

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Class4(string[] inScopePrefixes, XNamespace[] inScopeNs, List<XAttribute> attributes)
		{
			string_0 = inScopePrefixes;
			xnamespace_0 = inScopeNs;
			list_0 = attributes;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal XElement method_0(XElement xelement_0)
		{
			return smethod_4(string_0, xnamespace_0, list_0, xelement_0);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal object method_1(object object_0)
		{
			XElement val = (XElement)((object_0 is XElement) ? object_0 : null);
			if (val != null)
			{
				return smethod_4(string_0, xnamespace_0, list_0, val);
			}
			return object_0;
		}
	}

	public static string this[IEnumerable<XElement> ienumerable_0]
	{
		get
		{
			using (IEnumerator<XElement> enumerator = ienumerable_0.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					XElement current = enumerator.Current;
					return current.get_Value();
				}
			}
			return null;
		}
		set
		{
			using IEnumerator<XElement> enumerator = ienumerable_0.GetEnumerator();
			if (enumerator.MoveNext())
			{
				XElement current = enumerator.Current;
				current.set_Value(value);
			}
		}
	}

	public static string this[IEnumerable<XElement> ienumerable_0, XName xname_0]
	{
		get
		{
			using (IEnumerator<XElement> enumerator = ienumerable_0.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					XElement current = enumerator.Current;
					return (string)current.Attribute(xname_0);
				}
			}
			return null;
		}
		set
		{
			using IEnumerator<XElement> enumerator = ienumerable_0.GetEnumerator();
			if (enumerator.MoveNext())
			{
				XElement current = enumerator.Current;
				current.SetAttributeValue(xname_0, (object)value);
			}
		}
	}

	public static string AttributeValue
	{
		get
		{
			return (string)xelement_0.Attribute(xname_0);
		}
		set
		{
			xelement_0.SetAttributeValue(xname_0, (object)value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	private Class3()
	{
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static XAttribute smethod_0(XName xname_0, object object_0)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		if (object_0 == null)
		{
			return null;
		}
		return new XAttribute(xname_0, RuntimeHelpers.GetObjectValue(object_0));
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static XAttribute smethod_1(XName xname_0, XNamespace xnamespace_0)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		XAttribute val = new XAttribute(xname_0, (object)xnamespace_0.get_NamespaceName());
		((XObject)val).AddAnnotation((object)xnamespace_0);
		return val;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static object smethod_2(string[] string_0, XNamespace[] xnamespace_0, List<XAttribute> list_0, object object_0)
	{
		if (object_0 != null)
		{
			XElement val = (XElement)((object_0 is XElement) ? object_0 : null);
			if (val != null)
			{
				return smethod_4(string_0, xnamespace_0, list_0, val);
			}
			if (object_0 is IEnumerable ienumerable_)
			{
				return smethod_3(string_0, xnamespace_0, list_0, ienumerable_);
			}
		}
		return object_0;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static IEnumerable smethod_3(string[] string_0, XNamespace[] xnamespace_0, List<XAttribute> list_0, IEnumerable ienumerable_0)
	{
		if (ienumerable_0 != null)
		{
			if (ienumerable_0 is IEnumerable<XElement> source)
			{
				return source.Select(new Class4(string_0, xnamespace_0, list_0).method_0);
			}
			return ienumerable_0.Cast<object>().Select(new Class4(string_0, xnamespace_0, list_0).method_1);
		}
		return ienumerable_0;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static XElement smethod_4(string[] string_0, XNamespace[] xnamespace_0, List<XAttribute> list_0, XElement xelement_0)
	{
		checked
		{
			if (xelement_0 != null)
			{
				XAttribute val = xelement_0.get_FirstAttribute();
				while (val != null)
				{
					XAttribute nextAttribute = val.get_NextAttribute();
					if (val.get_IsNamespaceDeclaration())
					{
						XNamespace val2 = ((XObject)val).Annotation<XNamespace>();
						string localName = val.get_Name().get_LocalName();
						if (val2 != null)
						{
							if ((string_0 != null && xnamespace_0 != null) ? true : false)
							{
								int num = string_0.Length - 1;
								int num2 = num;
								int num3 = 0;
								while (true)
								{
									int num4 = num3;
									int num5 = num2;
									if (num4 > num5)
									{
										break;
									}
									string value = string_0[num3];
									XNamespace val3 = xnamespace_0[num3];
									if (!localName.Equals(value))
									{
										num3++;
										continue;
									}
									if (val2 == val3)
									{
										val.Remove();
									}
									val = null;
									break;
								}
							}
							if (val != null)
							{
								if (list_0 != null)
								{
									int num6 = list_0.Count - 1;
									int num7 = num6;
									int num8 = 0;
									while (true)
									{
										int num9 = num8;
										int num5 = num7;
										if (num9 > num5)
										{
											break;
										}
										XAttribute val4 = list_0[num8];
										string localName2 = val4.get_Name().get_LocalName();
										XNamespace val5 = ((XObject)val4).Annotation<XNamespace>();
										if (val5 == null || !localName.Equals(localName2))
										{
											num8++;
											continue;
										}
										if (val2 == val5)
										{
											val.Remove();
										}
										val = null;
										break;
									}
								}
								if (val != null)
								{
									val.Remove();
									list_0.Add(val);
								}
							}
						}
					}
					val = nextAttribute;
				}
			}
			return xelement_0;
		}
	}
}
