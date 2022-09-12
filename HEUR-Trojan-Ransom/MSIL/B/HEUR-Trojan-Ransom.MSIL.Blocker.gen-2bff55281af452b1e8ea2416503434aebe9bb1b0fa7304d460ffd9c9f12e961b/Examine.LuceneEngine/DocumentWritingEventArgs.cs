using System.Collections.Generic;
using System.ComponentModel;
using System.Security;
using Lucene.Net.Documents;

namespace Examine.LuceneEngine;

public class DocumentWritingEventArgs : CancelEventArgs, INodeEventArgs
{
	public Document Document
	{
		[SecuritySafeCritical]
		get;
		[SecuritySafeCritical]
		private set;
	}

	public Dictionary<string, string> Fields { get; private set; }

	public int NodeId { get; private set; }

	[SecuritySafeCritical]
	public DocumentWritingEventArgs(int nodeId, Document d, Dictionary<string, string> fields)
	{
		NodeId = nodeId;
		Document = d;
		Fields = fields;
	}
}
