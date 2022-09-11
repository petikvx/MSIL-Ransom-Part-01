using System.IO.Abstractions;

namespace PicklesDoc.Pickles.TestFrameworks.XUnit.XUnit2;

public class XUnit2SingleResultLoader : ISingleResultLoader
{
	private readonly XmlDeserializer<assemblies> xmlDeserializer = new XmlDeserializer<assemblies>();

	public SingleTestRunBase Load(FileInfoBase fileInfo)
	{
		return new XUnit2SingleResults(xmlDeserializer.Load(fileInfo));
	}
}
