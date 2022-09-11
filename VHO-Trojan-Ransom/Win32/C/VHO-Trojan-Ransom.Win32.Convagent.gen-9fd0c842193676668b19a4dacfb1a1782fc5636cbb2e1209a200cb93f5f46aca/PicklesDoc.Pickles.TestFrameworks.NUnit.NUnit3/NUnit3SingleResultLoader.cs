using System.IO.Abstractions;

namespace PicklesDoc.Pickles.TestFrameworks.NUnit.NUnit3;

public class NUnit3SingleResultLoader : ISingleResultLoader
{
	private readonly XDocumentLoader documentLoader = new XDocumentLoader();

	public SingleTestRunBase Load(FileInfoBase fileInfo)
	{
		return new NUnit3SingleResult(documentLoader.Load(fileInfo));
	}
}
