using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml;

namespace NChanges;

public class Project
{
	public static readonly string SnapshotTaskName = "Snapshot";

	public static readonly string ReportTaskName = "Report";

	public static readonly string ExcelTaskName = "Excel";

	public static readonly string CleanTaskName = "Clean";

	private const string MSBuildNamespace = "http://schemas.microsoft.com/developer/msbuild/2003";

	private const string NChangesToolPathPropertyName = "NChangesTool";

	private const string TypesToExcludePatternPropertyName = "TypesToExclude";

	private const string ExcelOutputPathPropertyName = "ExcelOutput";

	private const string AssembliesToSnapshotItemName = "Assembly";

	private const string VersionMetaDataName = "Version";

	private readonly List<AssemblyToSnapshot> _assembliesToSnapshot = new List<AssemblyToSnapshot>();

	public string NChangesToolPath { get; set; }

	public string TypesToExcludePattern { get; set; }

	public string ExcelOutputPath { get; set; }

	public ICollection<AssemblyToSnapshot> AssembliesToSnapshot => _assembliesToSnapshot;

	public void WriteXml(string path)
	{
		using XmlTextWriter xmlTextWriter = new XmlTextWriter(path, Encoding.UTF8);
		xmlTextWriter.Formatting = Formatting.Indented;
		WriteXml(xmlTextWriter);
	}

	public void WriteXml(XmlWriter xmlWriter)
	{
		xmlWriter.WriteStartElement("Project", "http://schemas.microsoft.com/developer/msbuild/2003");
		xmlWriter.WriteAttributeString("DefaultTargets", "Excel");
		WriteProperties(xmlWriter);
		WriteAssembliesToSnapshot(xmlWriter);
		WriteTargets(xmlWriter);
		xmlWriter.WriteEndElement();
	}

	private void WriteProperties(XmlWriter xmlWriter)
	{
		xmlWriter.WriteStartElement("PropertyGroup");
		xmlWriter.WriteElementString("NChangesTool", NChangesToolPath);
		xmlWriter.WriteElementString("TypesToExclude", TypesToExcludePattern);
		xmlWriter.WriteElementString("ExcelOutput", ExcelOutputPath);
		xmlWriter.WriteEndElement();
	}

	private void WriteAssembliesToSnapshot(XmlWriter xmlWriter)
	{
		xmlWriter.WriteStartElement("ItemGroup");
		foreach (AssemblyToSnapshot item in AssembliesToSnapshot)
		{
			xmlWriter.WriteStartElement("Assembly");
			xmlWriter.WriteAttributeString("Include", item.Path);
			if (!string.IsNullOrEmpty(item.Version))
			{
				xmlWriter.WriteElementString("Version", item.Version);
			}
			xmlWriter.WriteEndElement();
		}
		xmlWriter.WriteEndElement();
	}

	private void WriteTargets(XmlWriter xmlWriter)
	{
		WriteSnapshotTarget(xmlWriter);
		WriteReportTarget(xmlWriter);
		WriteExcelTarget(xmlWriter);
		WriteCleanTarget(xmlWriter);
	}

	private static void WriteSnapshotTarget(XmlWriter xmlWriter)
	{
		xmlWriter.WriteStartElement("Target");
		xmlWriter.WriteAttributeString("Name", SnapshotTaskName);
		xmlWriter.WriteStartElement("Exec");
		xmlWriter.WriteAttributeString("Command", string.Format("$({0}) snapshot \"%({1}.Identity)\" -v=\"%({2})\" -x=\"$({3})\"", "NChangesTool", "Assembly", "Version", "TypesToExclude"));
		xmlWriter.WriteEndElement();
		xmlWriter.WriteEndElement();
	}

	private static void WriteReportTarget(XmlWriter xmlWriter)
	{
		xmlWriter.WriteStartElement("Target");
		xmlWriter.WriteAttributeString("Name", ReportTaskName);
		xmlWriter.WriteStartElement("Exec");
		xmlWriter.WriteAttributeString("Command", string.Format("$({0}) report *-snapshot.xml", "NChangesTool"));
		xmlWriter.WriteEndElement();
		xmlWriter.WriteEndElement();
	}

	private static void WriteExcelTarget(XmlWriter xmlWriter)
	{
		xmlWriter.WriteStartElement("Target");
		xmlWriter.WriteAttributeString("Name", ExcelTaskName);
		xmlWriter.WriteStartElement("Exec");
		xmlWriter.WriteAttributeString("Command", string.Format("$({0}) excel *-report.xml -o=\"$({1})\"", "NChangesTool", "ExcelOutput"));
		xmlWriter.WriteEndElement();
		xmlWriter.WriteEndElement();
	}

	private static void WriteCleanTarget(XmlWriter xmlWriter)
	{
		xmlWriter.WriteStartElement("Target");
		xmlWriter.WriteAttributeString("Name", CleanTaskName);
		xmlWriter.WriteStartElement("Delete");
		xmlWriter.WriteAttributeString("Files", string.Format("%({0}.Filename)-%({1})-snapshot.xml", "Assembly", "Version"));
		xmlWriter.WriteEndElement();
		xmlWriter.WriteStartElement("Delete");
		xmlWriter.WriteAttributeString("Files", string.Format("%({0}.Filename)-%({1})-report.xml", "Assembly", "Version"));
		xmlWriter.WriteEndElement();
		xmlWriter.WriteStartElement("Delete");
		xmlWriter.WriteAttributeString("Files", string.Format("$({0})", "ExcelOutput"));
		xmlWriter.WriteEndElement();
		xmlWriter.WriteEndElement();
	}

	public void ReadXml(string path)
	{
		using XmlTextReader xmlReader = new XmlTextReader(path);
		ReadXml(xmlReader);
	}

	public void ReadXml(XmlReader xmlReader)
	{
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.Load(xmlReader);
		XmlNamespaceManager xmlNamespaceManager = new XmlNamespaceManager(xmlDocument.NameTable);
		xmlNamespaceManager.AddNamespace("msbuild", "http://schemas.microsoft.com/developer/msbuild/2003");
		NChangesToolPath = GetPropertyValue("NChangesTool", xmlDocument, xmlNamespaceManager);
		TypesToExcludePattern = GetPropertyValue("TypesToExclude", xmlDocument, xmlNamespaceManager);
		ExcelOutputPath = GetPropertyValue("ExcelOutput", xmlDocument, xmlNamespaceManager);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("/msbuild:Project/msbuild:ItemGroup/msbuild:Assembly", xmlNamespaceManager);
		if (xmlNodeList == null)
		{
			return;
		}
		foreach (XmlElement item in xmlNodeList.Cast<XmlElement>())
		{
			string attribute = item.GetAttribute("Include");
			string version = null;
			XmlNode xmlNode = item.SelectSingleNode("msbuild:Version", xmlNamespaceManager);
			if (xmlNode != null)
			{
				version = xmlNode.InnerText;
			}
			AssembliesToSnapshot.Add(new AssemblyToSnapshot
			{
				Path = attribute,
				Version = version
			});
		}
	}

	private static string GetPropertyValue(string propertyName, XmlDocument doc, XmlNamespaceManager nsManager)
	{
		return doc.SelectSingleNode("/msbuild:Project/msbuild:PropertyGroup/msbuild:" + propertyName, nsManager)?.InnerText;
	}

	public static void Run(string projectPath, string targetName)
	{
		Process.Start(Path.Combine(RuntimeEnvironment.GetRuntimeDirectory(), "MSBuild.exe"), projectPath + " /t:" + targetName);
	}
}
