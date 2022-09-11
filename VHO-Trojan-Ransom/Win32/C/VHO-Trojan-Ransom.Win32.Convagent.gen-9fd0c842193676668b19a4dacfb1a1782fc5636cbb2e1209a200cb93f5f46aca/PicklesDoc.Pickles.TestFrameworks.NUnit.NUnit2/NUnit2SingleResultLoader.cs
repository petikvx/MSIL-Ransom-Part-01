using System.IO.Abstractions;

namespace PicklesDoc.Pickles.TestFrameworks.NUnit.NUnit2;

public class NUnit2SingleResultLoader : ISingleResultLoader
{
	private readonly XDocumentLoader documentLoader = new XDocumentLoader();

	public SingleTestRunBase Load(FileInfoBase fileInfo)
	{
		return new NUnit2SingleResults(documentLoader.Load(fileInfo));
	}
}
