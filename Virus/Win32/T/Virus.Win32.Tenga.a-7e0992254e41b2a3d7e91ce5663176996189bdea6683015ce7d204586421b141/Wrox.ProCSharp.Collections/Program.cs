using System;
using System.Threading;

namespace Wrox.ProCSharp.Collections;

internal class Program
{
	private static void Main()
	{
		DocumentManager documentManager = new DocumentManager();
		ProcessDocuments.Start(documentManager);
		for (int i = 0; i < 1000; i++)
		{
			Document document = new Document("Doc " + i, "content");
			documentManager.AddDocument(document);
			Console.WriteLine("Added document {0}", document.Title);
			Thread.Sleep(new Random().Next(20));
		}
	}
}
