using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Total_Links.My;

[EditorBrowsable(EditorBrowsableState.Never)]
[CompilerGenerated]
[DebuggerNonUserCode]
internal sealed class InternalXmlHelper
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[CompilerGenerated]
	[DebuggerNonUserCode]
	private sealed class RemoveNamespaceAttributesClosure
	{
		private readonly XNamespace[] m_ns;

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal RemoveNamespaceAttributesClosure(XNamespace[] ns)
		{
			m_ns = ns;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal XElement ProcessXElement(XElement elem)
		{
			return RemoveNamespaceAttributes(m_ns, elem);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal object ProcessObject(object obj)
		{
			XElement val = (XElement)((obj is XElement) ? obj : null);
			if (val != null)
			{
				return RemoveNamespaceAttributes(m_ns, val);
			}
			return obj;
		}
	}

	public static string Value
	{
		get
		{
			using (IEnumerator<XElement> enumerator = source.GetEnumerator())
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
			using IEnumerator<XElement> enumerator = source.GetEnumerator();
			if (enumerator.MoveNext())
			{
				XElement current = enumerator.Current;
				current.set_Value(value);
			}
		}
	}

	public static string AttributeValue
	{
		get
		{
			using (IEnumerator<XElement> enumerator = source.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					XElement current = enumerator.Current;
					return (string)current.Attribute(name);
				}
			}
			return null;
		}
		set
		{
			using IEnumerator<XElement> enumerator = source.GetEnumerator();
			if (enumerator.MoveNext())
			{
				XElement current = enumerator.Current;
				current.SetAttributeValue(name, (object)value);
			}
		}
	}

	public static string AttributeValue
	{
		get
		{
			return (string)source.Attribute(name);
		}
		set
		{
			source.SetAttributeValue(name, (object)value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	private InternalXmlHelper()
	{
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static XAttribute CreateAttribute(XName name, object value)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		if (value == null)
		{
			return null;
		}
		return new XAttribute(name, RuntimeHelpers.GetObjectValue(value));
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static XAttribute CreateNamespaceAttribute(XName name, XNamespace ns)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		XAttribute val = new XAttribute(name, (object)ns.get_NamespaceName());
		((XObject)val).AddAnnotation((object)ns);
		return val;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static object RemoveNamespaceAttributes(XNamespace[] ns, object obj)
	{
		if ((ns != null && obj != null) ? true : false)
		{
			XElement val = (XElement)((obj is XElement) ? obj : null);
			if (val != null)
			{
				return RemoveNamespaceAttributes(ns, val);
			}
			if (obj is IEnumerable obj2)
			{
				return RemoveNamespaceAttributes(ns, obj2);
			}
		}
		return obj;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static IEnumerable RemoveNamespaceAttributes(XNamespace[] ns, IEnumerable obj)
	{
		if ((ns != null && obj != null) ? true : false)
		{
			if (obj is IEnumerable<XElement> source)
			{
				return source.Select(new RemoveNamespaceAttributesClosure(ns).ProcessXElement);
			}
			return obj.Cast<object>().Select(new RemoveNamespaceAttributesClosure(ns).ProcessObject);
		}
		return obj;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static XElement RemoveNamespaceAttributes(XNamespace[] ns, XElement e)
	{
		checked
		{
			if ((ns != null && e != null) ? true : false)
			{
				XAttribute val = e.get_FirstAttribute();
				while (val != null)
				{
					XAttribute nextAttribute = val.get_NextAttribute();
					if (val.get_IsNamespaceDeclaration())
					{
						XNamespace val2 = ((XObject)val).Annotation<XNamespace>();
						if (val2 != null)
						{
							int num = ns.Length - 1;
							int num2 = num;
							int num3 = 0;
							while (true)
							{
								int num4 = num3;
								int num5 = num2;
								if (num4 <= num5)
								{
									if (!(val2 == ns[num3]))
									{
										num3++;
										continue;
									}
									val.Remove();
									break;
								}
								break;
							}
						}
					}
					val = nextAttribute;
				}
			}
			return e;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static XNamespace GetNamespace(ref XNamespace xns, string ns)
	{
		if (xns == null)
		{
			xns = XNamespace.Get(ns);
		}
		return xns;
	}
}
