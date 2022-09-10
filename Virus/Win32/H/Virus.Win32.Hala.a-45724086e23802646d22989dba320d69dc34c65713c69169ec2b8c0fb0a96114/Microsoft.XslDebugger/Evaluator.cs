using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Xml;
using System.Xml.Schema;
using System.Xml.XPath;
using System.Xml.Xsl;
using System.Xml.Xsl.Runtime;

namespace Microsoft.XslDebugger;

public class Evaluator
{
	private static Evaluator evaluator;

	private DebugXsltContext context;

	private XPathNavigator contextNode;

	private int position;

	private int last;

	private Evaluator()
	{
		context = new DebugXsltContext();
	}

	public static Evaluator CreateEvaluator()
	{
		if (evaluator == null)
		{
			evaluator = new Evaluator();
		}
		return evaluator;
	}

	public bool SetDebugContext(XmlQueryRuntime runtime, string[] pdbNames, object[] pValues)
	{
		context.ClearContext();
		NameTuple nameTuple = null;
		int num = pdbNames.Length;
		for (int i = 0; i < num; i++)
		{
			nameTuple = NameTuple.CreateTupleFromPDBName(pdbNames[i]);
			AddToContext(runtime, nameTuple.LocalName, nameTuple.Namespace, pValues[i]);
		}
		DebugXsltContext debugXsltContext = context;
		string[] array = runtime.DebugGetGlobalNames();
		string[] array2 = array;
		foreach (string pdbName in array2)
		{
			NameTuple nameTuple2 = NameTuple.CreateTupleFromPDBName(pdbName);
			if ((string.IsNullOrEmpty(nameTuple2.Namespace) || !nameTuple2.Namespace.Equals("urn:schemas-microsoft-com:xslt-debug")) && !debugXsltContext.HasVariable(nameTuple2.QName))
			{
				AddToContext(runtime, nameTuple2.LocalName, nameTuple2.Namespace, runtime.DebugGetGlobalValue(nameTuple2.PDBName));
			}
		}
		return true;
	}

	public object[] GetXsltValues(XmlQueryRuntime runtime, IList[] values)
	{
		int num = values.Length;
		object[] array = new object[num];
		for (int i = 0; i < num; i++)
		{
			IList list = values[i];
			if (list != null)
			{
				array[i] = runtime.DebugGetXsltValue(list);
			}
		}
		return array;
	}

	public int[] GetSequenceLengths(IList[] values)
	{
		int num = values.Length;
		int[] array = new int[num];
		for (int i = 0; i < num; i++)
		{
			IList list = values[i];
			if (list != null)
			{
				array[i] = list.Count;
			}
		}
		return array;
	}

	public IList[] GetGlobalValues(XmlQueryRuntime runtime, string[] names)
	{
		int num = names.Length;
		IList[] array = new IList[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = runtime.DebugGetGlobalValue(names[i]);
		}
		return array;
	}

	public string[] GetGlobalNames(XmlQueryRuntime runtime)
	{
		string[] result = null;
		if (runtime != null)
		{
			result = runtime.DebugGetGlobalNames();
		}
		return result;
	}

	public bool AddToContext(XmlQueryRuntime runtime, string pName, string pNamespace, object pValue)
	{
		IList list = null;
		XPathNavigator xPathNavigator = null;
		if (pValue is IList list2)
		{
			if (list2.Count == 1)
			{
				XPathItem xPathItem = list2[0] as XPathItem;
				pValue = xPathItem;
				if (xPathItem != null && !xPathItem.IsNode)
				{
					switch (xPathItem.XmlType!.TypeCode)
					{
					case XmlTypeCode.Integer:
						pValue = xPathItem.ValueAsInt;
						break;
					case XmlTypeCode.String:
						pValue = xPathItem.Value;
						break;
					case XmlTypeCode.Boolean:
						pValue = xPathItem.ValueAsBoolean;
						break;
					case XmlTypeCode.Double:
						pValue = xPathItem.ValueAsDouble;
						break;
					}
				}
				else
				{
					pValue = runtime.DebugGetXsltValue(list2);
				}
			}
		}
		else if (!pNamespace.Equals("urn:schemas-microsoft-com:xslt-debug") && pValue is XPathNavigator xPathNavigator2)
		{
			pValue = new SingletonIterator(xPathNavigator2);
		}
		context.AddToContext(new XmlQualifiedName(pName, pNamespace), pValue);
		return true;
	}

	public void SetContextNode(XPathNavigator pContext)
	{
		contextNode = pContext;
	}

	public bool ClearContext()
	{
		context.ClearContext();
		return true;
	}

	public void SetPosition(int pPosition)
	{
		position = pPosition;
	}

	public void SetLast(int pLast)
	{
		last = pLast;
	}

	public object Evaluate(string expr)
	{
		try
		{
			XPathExpression xPathExpression = contextNode.Compile(expr);
			xPathExpression.SetContext(context);
			object obj = contextNode.Evaluate(xPathExpression, new SingletonIterator(contextNode, position, last));
			XPathNodeIterator xPathNodeIterator = null;
			if (obj is XPathNodeIterator xPathNodeIterator2)
			{
				ArrayList arrayList = new ArrayList();
				while (xPathNodeIterator2.MoveNext())
				{
					arrayList.Add(xPathNodeIterator2.Current!.Clone());
				}
				if (arrayList.Count == 1)
				{
					return arrayList[0];
				}
				return arrayList;
			}
			return obj;
		}
		catch (XPathException ex)
		{
			throw new Exception(XslDebugProxy.GetExceptionText(ex));
		}
		catch (ArgumentException ex2)
		{
			throw new Exception(XslDebugProxy.GetExceptionText(ex2));
		}
		catch (XsltCompileException ex3)
		{
			throw new Exception(XslDebugProxy.GetExceptionText(ex3));
		}
		catch (XsltException ex4)
		{
			throw new Exception(XslDebugProxy.GetExceptionText(ex4));
		}
	}

	public bool SetVariableValue(string expr, IList var)
	{
		bool result = false;
		if (var != null && var.Count == 1)
		{
			try
			{
				XPathExpression xPathExpression = contextNode.Compile(expr);
				xPathExpression.SetContext(context);
				object obj = contextNode.Evaluate(xPathExpression, new SingletonIterator(contextNode, position, last));
				if (obj == null)
				{
					return result;
				}
				XPathItem xPathItem = var[0] as XPathItem;
				object typedValue = xPathItem.TypedValue;
				XmlAtomicValue xmlAtomicValue = null;
				if (typedValue is string)
				{
					string value = XPathConverter.toString(obj);
					xmlAtomicValue = XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype!.ChangeType(value, typeof(XmlAtomicValue)) as XmlAtomicValue;
				}
				else if (typedValue is double)
				{
					double num = XPathConverter.toNumber(obj);
					xmlAtomicValue = XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Double).Datatype!.ChangeType(num, typeof(XmlAtomicValue)) as XmlAtomicValue;
				}
				else if (typedValue is bool)
				{
					bool flag = XPathConverter.toBoolean(obj);
					xmlAtomicValue = XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Boolean).Datatype!.ChangeType(flag, typeof(XmlAtomicValue)) as XmlAtomicValue;
				}
				if (xmlAtomicValue != null)
				{
					Type type = var.GetType();
					MethodInfo method = type.GetMethod("Clear");
					MethodInfo method2 = type.GetMethod("Add", new Type[1] { typeof(XPathItem) });
					method.Invoke(var, new object[0]);
					method2.Invoke(var, new object[1] { xmlAtomicValue });
					return true;
				}
				return result;
			}
			catch
			{
				return false;
			}
		}
		return result;
	}

	public string GetPDBNameFromDisplayName(string displayName)
	{
		string result = string.Empty;
		if (displayName.Equals("self::node()"))
		{
			return "current";
		}
		if (displayName.Equals("last()"))
		{
			return "last";
		}
		if (displayName.Equals("position()"))
		{
			return "position";
		}
		string text = displayName;
		if (displayName.StartsWith("$"))
		{
			text = displayName.Substring(1);
			string[] array = text.Split(new char[1] { ':' });
			if (array.Length == 1)
			{
				string defaultNamespace = context.DefaultNamespace;
				result = ((!string.IsNullOrEmpty(defaultNamespace)) ? ("{" + defaultNamespace + "}" + text) : text);
			}
			else if (array.Length == 2)
			{
				string text2 = array[0];
				string text3 = context.LookupNamespace(text2);
				result = "{" + text3 + "}" + text2 + ":" + array[1];
			}
			return result;
		}
		return result;
	}

	public XPathNavigator[] GetNavigatorChildren(XPathNavigator nav)
	{
		List<XPathNavigator> list = new List<XPathNavigator>();
		if (nav != null)
		{
			if (nav.MoveToFirstNamespace(XPathNamespaceScope.Local))
			{
				list.Add(nav.Clone());
				while (nav.MoveToNextNamespace(XPathNamespaceScope.Local))
				{
					list.Add(nav.Clone());
				}
				nav.MoveToParent();
			}
			if (nav.MoveToFirstAttribute())
			{
				list.Add(nav.Clone());
				while (nav.MoveToNextAttribute())
				{
					list.Add(nav.Clone());
				}
				nav.MoveToParent();
			}
			if (nav.MoveToFirstChild())
			{
				list.Add(nav.Clone());
				while (nav.MoveToNext())
				{
					list.Add(nav.Clone());
				}
				nav.MoveToParent();
			}
		}
		return list.ToArray();
	}

	public string GetNodeValue(XPathNavigator nav)
	{
		string result = string.Empty;
		if (nav != null)
		{
			switch (nav.NodeType)
			{
			case XPathNodeType.Root:
				result = SR.GetString("XslRootNodeValue", nav.SelectChildren(XPathNodeType.All).Count);
				break;
			case XPathNodeType.Element:
			{
				string prefix = nav.Prefix;
				string localName = nav.LocalName;
				result = ((!string.IsNullOrEmpty(prefix)) ? (prefix + ":" + localName) : localName);
				break;
			}
			case XPathNodeType.Attribute:
			case XPathNodeType.Namespace:
			case XPathNodeType.Text:
			case XPathNodeType.SignificantWhitespace:
			case XPathNodeType.Whitespace:
			case XPathNodeType.ProcessingInstruction:
			case XPathNodeType.Comment:
				result = nav.Value;
				break;
			}
		}
		return result;
	}
}
