using System.Collections.Generic;

namespace Wrox.ProCSharp.Collections;

public class DocumentManager
{
	private readonly Queue<Document> documentQueue = new Queue<Document>();

	public bool IsDocumentAvailable => documentQueue.Count > 0;

	public void AddDocument(Document doc)
	{
		lock (this)
		{
			documentQueue.Enqueue(doc);
		}
	}

	public Document GetDocument()
	{
		Document result = null;
		lock (this)
		{
			result = documentQueue.Dequeue();
		}
		return result;
	}
}
