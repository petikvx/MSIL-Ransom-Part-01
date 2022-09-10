using System;
using System.Threading;

namespace Wrox.ProCSharp.Collections;

public class ProcessDocuments
{
	private DocumentManager documentManager;

	public static void Start(DocumentManager dm)
	{
		new Thread(new ProcessDocuments(dm).Run).Start();
	}

	protected ProcessDocuments(DocumentManager dm)
	{
		documentManager = dm;
	}

	protected void Run()
	{
		while (true)
		{
			if (documentManager.IsDocumentAvailable)
			{
				Document document = documentManager.GetDocument();
				Console.WriteLine("Processing document {0}", document.Title);
			}
			Thread.Sleep(new Random().Next(20));
		}
	}
}
