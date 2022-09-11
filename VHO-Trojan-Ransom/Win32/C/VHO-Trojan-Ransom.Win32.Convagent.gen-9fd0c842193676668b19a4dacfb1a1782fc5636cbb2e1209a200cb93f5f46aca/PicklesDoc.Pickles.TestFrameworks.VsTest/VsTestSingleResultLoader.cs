using System.IO.Abstractions;

namespace PicklesDoc.Pickles.TestFrameworks.VsTest;

public class VsTestSingleResultLoader : ISingleResultLoader
{
	private readonly XDocumentLoader documentLoader = new XDocumentLoader();

	public SingleTestRunBase Load(FileInfoBase fileInfo)
	{
		return new VsTestSingleResults(documentLoader.Load(fileInfo));
	}
}
