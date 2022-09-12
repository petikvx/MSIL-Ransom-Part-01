using System;
using System.Collections;
using System.ComponentModel;
using System.Configuration.Install;
using System.IO;
using System.Reflection;
using System.Security.Permissions;
using System.Xml;
using Microsoft.Win32;

namespace MySql.Data.MySqlClient;

[RunInstaller(true)]
[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
[PermissionSet(SecurityAction.InheritanceDemand, Name = "FullTrust")]
public class CustomInstaller : Installer
{
	public override void Install(IDictionary stateSaver)
	{
		((Installer)this).Install(stateSaver);
		AddProviderToMachineConfig();
	}

	private static void AddProviderToMachineConfig()
	{
		object? obj = Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Microsoft\\.NETFramework\\", "InstallRoot", null) ?? throw new Exception("Unable to retrieve install root for .NET framework");
		UpdateMachineConfigs(obj!.ToString(), add: true);
		string text = obj!.ToString();
		text = text.Substring(0, text.Length - 1);
		text = $"{text}64{Path.DirectorySeparatorChar}";
		if (Directory.Exists(text))
		{
			UpdateMachineConfigs(text, add: true);
		}
	}

	internal static void UpdateMachineConfigs(string rootPath, bool add)
	{
		string[] array = new string[2] { "v2.0.50727", "v4.0.30319" };
		foreach (string text in array)
		{
			string arg = rootPath + text;
			string path = $"{arg}\\CONFIG";
			if (Directory.Exists(path))
			{
				if (add)
				{
					AddProviderToMachineConfigInDir(path);
				}
				else
				{
					RemoveProviderFromMachineConfigInDir(path);
				}
			}
		}
	}

	private static XmlElement CreateNodeAssemblyBindingRedirection(XmlElement mysqlNode, XmlDocument doc, string oldVersion, string newVersion)
	{
		if (doc != null && mysqlNode != null)
		{
			string namespaceURI = "urn:schemas-microsoft-com:asm.v1";
			XmlElement xmlElement = (XmlElement)doc.CreateNode(XmlNodeType.Element, "dependentAssembly", namespaceURI);
			XmlElement xmlElement2 = (XmlElement)doc.CreateNode(XmlNodeType.Element, "assemblyIdentity", namespaceURI);
			xmlElement2.SetAttribute("name", "MySql.Data");
			xmlElement2.SetAttribute("publicKeyToken", "c5687fc88969c44d");
			xmlElement2.SetAttribute("culture", "neutral");
			XmlElement xmlElement3 = (XmlElement)doc.CreateNode(XmlNodeType.Element, "bindingRedirect", namespaceURI);
			xmlElement3.SetAttribute("oldVersion", oldVersion);
			xmlElement3.SetAttribute("newVersion", newVersion);
			xmlElement.AppendChild(xmlElement2);
			xmlElement.AppendChild(xmlElement3);
			mysqlNode.AppendChild(xmlElement);
			xmlElement = (XmlElement)doc.CreateNode(XmlNodeType.Element, "dependentAssembly", namespaceURI);
			xmlElement2 = (XmlElement)doc.CreateNode(XmlNodeType.Element, "assemblyIdentity", namespaceURI);
			xmlElement2.SetAttribute("name", "MySql.Data.Entity");
			xmlElement2.SetAttribute("publicKeyToken", "c5687fc88969c44d");
			xmlElement2.SetAttribute("culture", "neutral");
			xmlElement3 = (XmlElement)doc.CreateNode(XmlNodeType.Element, "bindingRedirect", namespaceURI);
			xmlElement3.SetAttribute("oldVersion", oldVersion);
			xmlElement3.SetAttribute("newVersion", newVersion);
			xmlElement.AppendChild(xmlElement2);
			xmlElement.AppendChild(xmlElement3);
			mysqlNode.AppendChild(xmlElement);
			xmlElement = (XmlElement)doc.CreateNode(XmlNodeType.Element, "dependentAssembly", namespaceURI);
			xmlElement2 = (XmlElement)doc.CreateNode(XmlNodeType.Element, "assemblyIdentity", namespaceURI);
			xmlElement2.SetAttribute("name", "MySql.Web");
			xmlElement2.SetAttribute("publicKeyToken", "c5687fc88969c44d");
			xmlElement2.SetAttribute("culture", "neutral");
			xmlElement3 = (XmlElement)doc.CreateNode(XmlNodeType.Element, "bindingRedirect", namespaceURI);
			xmlElement3.SetAttribute("oldVersion", oldVersion);
			xmlElement3.SetAttribute("newVersion", newVersion);
			xmlElement.AppendChild(xmlElement2);
			xmlElement.AppendChild(xmlElement3);
			mysqlNode.AppendChild(xmlElement);
			return mysqlNode;
		}
		return null;
	}

	private static void AddProviderToMachineConfigInDir(string path)
	{
		string text = $"{path}\\machine.config";
		if (!File.Exists(text))
		{
			return;
		}
		StreamReader streamReader = new StreamReader(text);
		string xml = streamReader.ReadToEnd();
		streamReader.Close();
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(xml);
		xmlDocument = RemoveOldBindingRedirection(xmlDocument);
		XmlElement xmlElement = (XmlElement)xmlDocument.CreateNode(XmlNodeType.Element, "add", "");
		xmlElement.SetAttribute("name", "MySQL Data Provider");
		xmlElement.SetAttribute("invariant", "MySql.Data.MySqlClient");
		xmlElement.SetAttribute("description", ".Net Framework Data Provider for MySQL");
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		string value = string.Format("MySql.Data.MySqlClient.MySqlClientFactory, {0}", executingAssembly.FullName!.Replace("Installers", "Data"));
		xmlElement.SetAttribute("type", value);
		XmlNodeList elementsByTagName = xmlDocument.GetElementsByTagName("DbProviderFactories");
		foreach (XmlNode childNode in elementsByTagName[0]!.ChildNodes)
		{
			if (childNode.Attributes == null)
			{
				continue;
			}
			foreach (XmlAttribute item in childNode.Attributes!)
			{
				if (item.Name == "invariant" && item.Value == "MySql.Data.MySqlClient")
				{
					elementsByTagName[0]!.RemoveChild(childNode);
					break;
				}
			}
		}
		elementsByTagName[0]!.AppendChild(xmlElement);
		try
		{
			XmlElement xmlElement2;
			if (xmlDocument.GetElementsByTagName("assemblyBinding").Count == 0)
			{
				xmlElement2 = (XmlElement)xmlDocument.CreateNode(XmlNodeType.Element, "assemblyBinding", "");
				xmlElement2.SetAttribute("xmlns", "urn:schemas-microsoft-com:asm.v1");
			}
			else
			{
				xmlElement2 = (XmlElement)xmlDocument.GetElementsByTagName("assemblyBinding")[0];
			}
			string newVersion = Assembly.GetExecutingAssembly().GetName().Version!.ToString();
			xmlElement2 = CreateNodeAssemblyBindingRedirection(xmlElement2, xmlDocument, "6.7.4.0", newVersion);
			xmlDocument.GetElementsByTagName("runtime")[0]!.AppendChild(xmlElement2);
		}
		catch
		{
		}
		XmlTextWriter xmlTextWriter = new XmlTextWriter(text, null);
		xmlTextWriter.Formatting = Formatting.Indented;
		xmlDocument.Save(xmlTextWriter);
		xmlTextWriter.Flush();
		xmlTextWriter.Close();
	}

	private static XmlDocument RemoveOldBindingRedirection(XmlDocument doc)
	{
		if (doc.GetElementsByTagName("assemblyBinding").Count == 0)
		{
			return doc;
		}
		XmlNodeList childNodes = doc.GetElementsByTagName("assemblyBinding")[0]!.ChildNodes;
		if (childNodes != null)
		{
			int count = childNodes.Count;
			for (int i = 0; i < count; i++)
			{
				if (childNodes[0]!.ChildNodes[0]!.Attributes![0].Name == "name" && childNodes[0]!.ChildNodes[0]!.Attributes![0].Value.Contains("MySql"))
				{
					doc.GetElementsByTagName("assemblyBinding")[0]!.RemoveChild(childNodes[0]);
				}
			}
		}
		return doc;
	}

	public override void Uninstall(IDictionary savedState)
	{
		((Installer)this).Uninstall(savedState);
		RemoveProviderFromMachineConfig();
	}

	private static void RemoveProviderFromMachineConfig()
	{
		object? obj = Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Microsoft\\.NETFramework\\", "InstallRoot", null) ?? throw new Exception("Unable to retrieve install root for .NET framework");
		UpdateMachineConfigs(obj!.ToString(), add: false);
		string text = obj!.ToString();
		text = text.Substring(0, text.Length - 1);
		text = $"{text}64{Path.DirectorySeparatorChar}";
		if (Directory.Exists(text))
		{
			UpdateMachineConfigs(text, add: false);
		}
	}

	private static void RemoveProviderFromMachineConfigInDir(string path)
	{
		string text = $"{path}\\machine.config";
		if (!File.Exists(text))
		{
			return;
		}
		StreamReader streamReader = new StreamReader(text);
		string xml = streamReader.ReadToEnd();
		streamReader.Close();
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(xml);
		XmlNodeList elementsByTagName = xmlDocument.GetElementsByTagName("DbProviderFactories");
		foreach (XmlNode childNode in elementsByTagName[0]!.ChildNodes)
		{
			if (childNode.Attributes != null && childNode.Attributes!["name"]!.Value == "MySQL Data Provider")
			{
				elementsByTagName[0]!.RemoveChild(childNode);
				break;
			}
		}
		try
		{
			xmlDocument = RemoveOldBindingRedirection(xmlDocument);
		}
		catch
		{
		}
		XmlTextWriter xmlTextWriter = new XmlTextWriter(text, null);
		xmlTextWriter.Formatting = Formatting.Indented;
		xmlDocument.Save(xmlTextWriter);
		xmlTextWriter.Flush();
		xmlTextWriter.Close();
	}
}
