using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;
using Mono.Options;

namespace NChanges;

public class ReportCommand
{
	private readonly OptionSet _optionSet;

	private string _output = "%name%-%version%-report.xml";

	private string _transform;

	private string _transformOutput = "%name%-%version%-report.html";

	public ReportCommand()
	{
		_optionSet = new OptionSet
		{
			{
				"o|output=",
				"output file",
				delegate(string v)
				{
					_output = v;
				}
			},
			{
				"t|transform=",
				"XSLT file",
				delegate(string v)
				{
					_transform = v;
				}
			},
			{
				"r|result=",
				"XSLT output file",
				delegate(string v)
				{
					_transformOutput = v;
				}
			}
		};
	}

	public void Run(IEnumerable<string> args)
	{
		List<string> paths = _optionSet.Parse(args);
		List<AssemblyInfo> list = new List<AssemblyInfo>();
		foreach (string item in PathHelper.ExpandPaths(paths))
		{
			AssemblyInfo assemblyInfo = new AssemblyInfo();
			using (XmlTextReader xmlReader = new XmlTextReader(item))
			{
				assemblyInfo.ReadXml(xmlReader);
			}
			list.Add(assemblyInfo);
		}
		foreach (IGrouping<string, AssemblyInfo> item2 in from a in list
			group a by a.Name)
		{
			Reporter reporter = new Reporter();
			foreach (AssemblyInfo item3 in item2)
			{
				reporter.Assemblies.Add(item3);
			}
			AssemblyInfo assemblyInfo2 = reporter.GenerateReport();
			string text = PathHelper.FormatPath(_output, assemblyInfo2);
			PathHelper.EnsureFolderExists(text);
			using (XmlTextWriter xmlWriter = new XmlTextWriter(text, Encoding.UTF8)
			{
				Formatting = Formatting.Indented
			})
			{
				assemblyInfo2.WriteXml(xmlWriter);
			}
			if (!string.IsNullOrEmpty(_transform))
			{
				XslCompiledTransform xslCompiledTransform = new XslCompiledTransform();
				xslCompiledTransform.Load(_transform);
				XPathDocument input = new XPathDocument(text);
				using FileStream fileStream = new FileStream(PathHelper.FormatPath(_transformOutput, assemblyInfo2), FileMode.Create);
				xslCompiledTransform.Transform(input, null, fileStream);
				fileStream.Flush();
			}
		}
	}

	public void ShowHelp()
	{
		_optionSet.WriteOptionDescriptions(Console.Error);
	}
}
