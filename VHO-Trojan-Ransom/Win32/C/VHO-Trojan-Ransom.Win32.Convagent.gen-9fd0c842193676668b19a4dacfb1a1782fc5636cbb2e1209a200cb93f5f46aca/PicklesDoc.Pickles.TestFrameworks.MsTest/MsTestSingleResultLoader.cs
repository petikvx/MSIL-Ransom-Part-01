using System.IO.Abstractions;

namespace PicklesDoc.Pickles.TestFrameworks.MsTest;

public class MsTestSingleResultLoader : ISingleResultLoader
{
	private readonly XDocumentLoader documentLoader = new XDocumentLoader();

	public SingleTestRunBase Load(FileInfoBase fileInfo)
	{
		return new MsTestSingleResults(documentLoader.Load(fileInfo));
	}
}
