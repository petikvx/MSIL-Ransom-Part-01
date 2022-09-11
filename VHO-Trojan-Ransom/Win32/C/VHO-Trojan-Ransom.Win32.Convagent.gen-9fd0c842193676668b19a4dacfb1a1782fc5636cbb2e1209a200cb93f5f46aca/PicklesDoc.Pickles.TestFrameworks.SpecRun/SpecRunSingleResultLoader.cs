using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Abstractions;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace PicklesDoc.Pickles.TestFrameworks.SpecRun;

public class SpecRunSingleResultLoader : ISingleResultLoader
{
	public SingleTestRunBase Load(FileInfoBase fileInfo)
	{
		XDocument readResultsFile = ReadResultsFile(fileInfo);
		return new SpecRunSingleResults(ToFeatures(readResultsFile));
	}

	private List<SpecRunFeature> ToFeatures(XDocument readResultsFile)
	{
		return ((XContainer)readResultsFile).Descendants(XName.op_Implicit("feature")).Select(Factory.ToSpecRunFeature).ToList();
	}

	private XDocument ReadResultsFile(FileInfoBase testResultsFile)
	{
		using Stream stream = testResultsFile.OpenRead();
		using StreamReader streamReader = new StreamReader(stream);
		string text = streamReader.ReadToEnd();
		int startIndex = text.IndexOf("<!-- Pickles Begin", StringComparison.Ordinal);
		string text2 = text.Substring(startIndex).Replace("<!-- Pickles Begin", string.Empty);
		return XDocument.Load(XmlReader.Create(new StringReader(text2[..text2.IndexOf("Pickles End -->", StringComparison.Ordinal)].Replace("&lt;", "<").Replace("&gt;", ">"))));
	}
}
