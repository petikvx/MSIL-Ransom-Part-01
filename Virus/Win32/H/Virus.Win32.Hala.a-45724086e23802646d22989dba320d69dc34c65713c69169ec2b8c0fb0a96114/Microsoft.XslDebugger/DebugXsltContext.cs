using System.Collections;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace Microsoft.XslDebugger;

internal class DebugXsltContext : XsltContext
{
	private Hashtable variablesInScope;

	private Hashtable namespaces;

	public override string DefaultNamespace
	{
		get
		{
			if (namespaces != null)
			{
				return namespaces[string.Empty] as string;
			}
			return string.Empty;
		}
	}

	public override bool Whitespace => false;

	public DebugXsltContext()
	{
		variablesInScope = new Hashtable();
		namespaces = new Hashtable();
	}

	public void AddToContext(XmlQualifiedName qname, object variable)
	{
		if (qname.Namespace.Equals("urn:schemas-microsoft-com:xslt-debug"))
		{
			switch (qname.Name)
			{
			case "last":
			{
				double num = (double)variable;
				Evaluator.CreateEvaluator().SetLast((int)num);
				break;
			}
			case "position":
			{
				double num2 = (double)variable;
				Evaluator.CreateEvaluator().SetPosition((int)num2);
				break;
			}
			case "current":
				Evaluator.CreateEvaluator().SetContextNode(variable as XPathNavigator);
				break;
			case "namespaces":
			{
				IList list = null;
				XPathNavigator xPathNavigator = null;
				if (variable is IList list2)
				{
					int count = list2.Count;
					for (int i = 0; i < count; i++)
					{
						xPathNavigator = list2[i] as XPathNavigator;
						if (string.IsNullOrEmpty(xPathNavigator.LocalName))
						{
							namespaces.Add(string.Empty, (list2[i] as XPathNavigator).Value);
						}
						else
						{
							namespaces.Add(xPathNavigator.LocalName, xPathNavigator.Value);
						}
					}
				}
				else if (variable is XPathNavigator xPathNavigator2)
				{
					if (string.IsNullOrEmpty(xPathNavigator2.LocalName))
					{
						namespaces.Add(string.Empty, xPathNavigator2.Value);
					}
					else
					{
						namespaces.Add(xPathNavigator2.LocalName, xPathNavigator2.Value);
					}
				}
				break;
			}
			default:
				variablesInScope.Add(qname, new DebugXsltVariable(variable));
				break;
			}
		}
		else
		{
			variablesInScope.Add(qname, new DebugXsltVariable(variable));
		}
	}

	public void ClearContext()
	{
		variablesInScope.Clear();
		namespaces.Clear();
	}

	public override string LookupNamespace(string prefix)
	{
		if (namespaces != null)
		{
			if (!(namespaces[prefix] is string))
			{
				return string.Empty;
			}
			return namespaces[prefix] as string;
		}
		return string.Empty;
	}

	public override IXsltContextVariable ResolveVariable(string prefix, string name)
	{
		string ns = LookupNamespace(prefix);
		XmlQualifiedName key = new XmlQualifiedName(name, ns);
		return variablesInScope[key] as IXsltContextVariable;
	}

	public override IXsltContextFunction ResolveFunction(string prefix, string name, XPathResultType[] ArgTypes)
	{
		return null;
	}

	public override bool PreserveWhitespace(XPathNavigator node)
	{
		return false;
	}

	public override int CompareDocument(string baseUri, string nextbaseUri)
	{
		return 0;
	}

	internal bool HasVariable(XmlQualifiedName name)
	{
		return variablesInScope.ContainsKey(name);
	}
}
