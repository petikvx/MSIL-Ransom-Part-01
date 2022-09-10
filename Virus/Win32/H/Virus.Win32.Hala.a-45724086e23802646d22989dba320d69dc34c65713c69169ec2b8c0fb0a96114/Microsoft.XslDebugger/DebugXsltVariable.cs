using System.Collections;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace Microsoft.XslDebugger;

internal class DebugXsltVariable : IXsltContextVariable
{
	private object value;

	public bool IsLocal => true;

	public bool IsParam => false;

	public XPathResultType VariableType => XPathResultType.Any;

	public DebugXsltVariable(object pValue)
	{
		value = pValue;
	}

	public object Evaluate(XsltContext xsltContext)
	{
		IList list = null;
		XPathNavigator xPathNavigator = null;
		if (value is IList list2)
		{
			ArrayList arrayList = new ArrayList();
			int count = list2.Count;
			for (int i = 0; i < count; i++)
			{
				arrayList.Add(list2[i] as XPathNavigator);
			}
			return new CachedIterator(arrayList);
		}
		if (value is XPathNavigator context)
		{
			return new SingletonIterator(context);
		}
		return value;
	}
}
