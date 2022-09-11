using System.Collections.Generic;
using System.IO;
using System.IO.Abstractions;
using Newtonsoft.Json;

namespace PicklesDoc.Pickles.TestFrameworks.CucumberJson;

public class CucumberJsonSingleResultLoader : ISingleResultLoader
{
	public SingleTestRunBase Load(FileInfoBase fileInfo)
	{
		return new CucumberJsonSingleResults(ReadResultsFile(fileInfo));
	}

	private List<Feature> ReadResultsFile(FileInfoBase testResultsFile)
	{
		using Stream stream = testResultsFile.OpenRead();
		using StreamReader streamReader = new StreamReader(stream);
		return JsonConvert.DeserializeObject<List<Feature>>(streamReader.ReadToEnd());
	}
}
