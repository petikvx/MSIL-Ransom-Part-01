using System.Xml;

namespace Microsoft.XslDebugger;

internal class NameTuple
{
	private XmlQualifiedName qName;

	private string prefix;

	private string pdbName;

	internal XmlQualifiedName QName
	{
		get
		{
			return qName;
		}
		set
		{
			qName = value;
		}
	}

	internal string LocalName => qName.Name;

	internal string Prefix
	{
		get
		{
			return prefix;
		}
		set
		{
			prefix = value;
		}
	}

	internal string Namespace => qName.Namespace;

	internal string PDBName
	{
		get
		{
			return pdbName;
		}
		set
		{
			pdbName = value;
		}
	}

	internal bool IsNamespaceVariable => PDBName.Equals("namespaces");

	internal bool IsInternalNamespace => Namespace.Equals("urn:schemas-microsoft-com:xslt-debug");

	internal string DisplayName
	{
		get
		{
			if (!string.IsNullOrEmpty(Namespace) && Namespace.Equals("urn:schemas-microsoft-com:xslt-debug"))
			{
				switch (QName.Name)
				{
				case "namespaces":
					return "namespace::node()";
				case "current":
					return "self::node()";
				case "position":
					return "position()";
				case "last":
					return "last()";
				default:
					if (QName.Name.StartsWith("with-param"))
					{
						return LocalName;
					}
					return "$$$" + LocalName;
				}
			}
			if (string.IsNullOrEmpty(Prefix))
			{
				return "$" + LocalName;
			}
			return "$" + Prefix + ":" + LocalName;
		}
	}

	private NameTuple()
	{
		qName = XmlQualifiedName.Empty;
		prefix = string.Empty;
		pdbName = string.Empty;
	}

	internal static NameTuple CreateTupleFromPDBName(string pdbName)
	{
		NameTuple nameTuple = new NameTuple();
		string text = string.Empty;
		string empty = string.Empty;
		nameTuple.PDBName = pdbName;
		int num = pdbName.LastIndexOf("}");
		string empty2 = string.Empty;
		if (num > 0)
		{
			empty2 = pdbName.Substring(num + 1);
			text = pdbName.Substring(1, num - 1);
		}
		else
		{
			empty2 = pdbName;
		}
		int num2 = empty2.LastIndexOf(":");
		if (num2 > 0)
		{
			nameTuple.Prefix = empty2.Substring(0, num2);
			empty = empty2.Substring(num2 + 1);
		}
		else
		{
			empty = empty2;
		}
		if (string.IsNullOrEmpty(text))
		{
			nameTuple.QName = new XmlQualifiedName(empty);
		}
		else
		{
			nameTuple.QName = new XmlQualifiedName(empty, text);
		}
		return nameTuple;
	}
}
