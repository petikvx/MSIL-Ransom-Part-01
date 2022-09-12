using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Xml;
using Mono.Options;

namespace NChanges;

public class SnapshotCommand
{
	private readonly OptionSet _optionSet;

	private string _output = "%name%-%version%-snapshot.xml";

	private string _version;

	private string _excludePattern;

	public SnapshotCommand()
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
				"v|version=",
				"assume this version instead of assembly version",
				delegate(string v)
				{
					_version = v;
				}
			},
			{
				"x|exclude=",
				"regex pattern to exclude types",
				delegate(string v)
				{
					_excludePattern = v;
				}
			}
		};
	}

	public void Run(IEnumerable<string> args)
	{
		foreach (string item in PathHelper.ExpandPaths(_optionSet.Parse(args)))
		{
			Assembly assembly = Assembly.LoadFrom(Path.GetFullPath(item));
			AssemblyInfo assemblyInfo = new AssemblyInfo();
			assemblyInfo.ReadAssembly(assembly, _excludePattern);
			if (_version != null)
			{
				assemblyInfo.Version = _version;
			}
			string text = PathHelper.FormatPath(_output, assemblyInfo);
			PathHelper.EnsureFolderExists(text);
			using XmlTextWriter xmlWriter = new XmlTextWriter(text, Encoding.UTF8)
			{
				Formatting = Formatting.Indented
			};
			assemblyInfo.WriteXml(xmlWriter);
		}
	}

	public void ShowHelp()
	{
		_optionSet.WriteOptionDescriptions(Console.Error);
	}
}
