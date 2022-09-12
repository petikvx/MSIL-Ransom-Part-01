using System;
using System.Xml.Linq;

namespace Examine;

public class IndexingFieldDataEventArgs : EventArgs, INodeEventArgs
{
	public XElement Node { get; private set; }

	public string FieldName { get; private set; }

	public string FieldValue { get; private set; }

	public bool IsStandardField { get; private set; }

	public int NodeId { get; private set; }

	public IndexingFieldDataEventArgs(XElement node, string fieldName, string fieldValue, bool isStandardField, int nodeId)
	{
		Node = node;
		FieldName = fieldName;
		FieldValue = fieldValue;
		IsStandardField = isStandardField;
		NodeId = nodeId;
	}
}
