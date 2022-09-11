using System.IO.Abstractions;

namespace PicklesDoc.Pickles.TestFrameworks.XUnit.XUnit1;

public class XUnit1SingleResultLoader : ISingleResultLoader
{
	private readonly XDocumentLoader documentLoader = new XDocumentLoader();

	public SingleTestRunBase Load(FileInfoBase fileInfo)
	{
		return new XUnit1SingleResult(documentLoader.Load(fileInfo));
	}
}
