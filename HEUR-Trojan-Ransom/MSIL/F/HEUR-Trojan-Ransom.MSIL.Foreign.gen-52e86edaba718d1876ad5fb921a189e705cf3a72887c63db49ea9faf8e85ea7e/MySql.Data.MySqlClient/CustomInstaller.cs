using System;
using System.Collections;
using System.ComponentModel;
using System.Configuration.Install;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Xml;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace MySql.Data.MySqlClient;

[RunInstaller(true)]
[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
[PermissionSet(SecurityAction.InheritanceDemand, Name = "FullTrust")]
public sealed class CustomInstaller : Installer
{
	[NonSerialized]
	internal static GetString getString_0;

	public override void Install(IDictionary stateSaver)
	{
		((Installer)this).Install(stateSaver);
		AddProviderToMachineConfig();
	}

	private static void AddProviderToMachineConfig()
	{
		object? obj = Registry.GetValue(getString_0(107352935), getString_0(107352318), null) ?? throw new Exception(getString_0(107352333));
		UpdateMachineConfigs(obj!.ToString(), add: true);
		string text = obj!.ToString();
		text = text.Substring(0, text.Length - 1);
		text = string.Format(getString_0(107352264), text, Path.DirectorySeparatorChar);
		if (Directory.Exists(text))
		{
			UpdateMachineConfigs(text, add: true);
		}
	}

	internal static void UpdateMachineConfigs(string rootPath, bool add)
	{
		string[] array = new string[2]
		{
			getString_0(107352219),
			getString_0(107352234)
		};
		foreach (string text in array)
		{
			string arg = rootPath + text;
			string path = string.Format(getString_0(107352185), arg);
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
			string namespaceURI = getString_0(107352200);
			XmlElement xmlElement = (XmlElement)doc.CreateNode(XmlNodeType.Element, getString_0(107352123), namespaceURI);
			XmlElement xmlElement2 = (XmlElement)doc.CreateNode(XmlNodeType.Element, getString_0(107352130), namespaceURI);
			xmlElement2.SetAttribute(getString_0(107408636), getString_0(107352617));
			xmlElement2.SetAttribute(getString_0(107352568), getString_0(107352579));
			xmlElement2.SetAttribute(getString_0(107352554), getString_0(107352509));
			XmlElement xmlElement3 = (XmlElement)doc.CreateNode(XmlNodeType.Element, getString_0(107352496), namespaceURI);
			xmlElement3.SetAttribute(getString_0(107352475), oldVersion);
			xmlElement3.SetAttribute(getString_0(107352490), newVersion);
			xmlElement.AppendChild(xmlElement2);
			xmlElement.AppendChild(xmlElement3);
			mysqlNode.AppendChild(xmlElement);
			xmlElement = (XmlElement)doc.CreateNode(XmlNodeType.Element, getString_0(107352123), namespaceURI);
			xmlElement2 = (XmlElement)doc.CreateNode(XmlNodeType.Element, getString_0(107352130), namespaceURI);
			xmlElement2.SetAttribute(getString_0(107408636), getString_0(107352441));
			xmlElement2.SetAttribute(getString_0(107352568), getString_0(107352579));
			xmlElement2.SetAttribute(getString_0(107352554), getString_0(107352509));
			xmlElement3 = (XmlElement)doc.CreateNode(XmlNodeType.Element, getString_0(107352496), namespaceURI);
			xmlElement3.SetAttribute(getString_0(107352475), oldVersion);
			xmlElement3.SetAttribute(getString_0(107352490), newVersion);
			xmlElement.AppendChild(xmlElement2);
			xmlElement.AppendChild(xmlElement3);
			mysqlNode.AppendChild(xmlElement);
			xmlElement = (XmlElement)doc.CreateNode(XmlNodeType.Element, getString_0(107352123), namespaceURI);
			xmlElement2 = (XmlElement)doc.CreateNode(XmlNodeType.Element, getString_0(107352130), namespaceURI);
			xmlElement2.SetAttribute(getString_0(107408636), getString_0(107352448));
			xmlElement2.SetAttribute(getString_0(107352568), getString_0(107352579));
			xmlElement2.SetAttribute(getString_0(107352554), getString_0(107352509));
			xmlElement3 = (XmlElement)doc.CreateNode(XmlNodeType.Element, getString_0(107352496), namespaceURI);
			xmlElement3.SetAttribute(getString_0(107352475), oldVersion);
			xmlElement3.SetAttribute(getString_0(107352490), newVersion);
			xmlElement.AppendChild(xmlElement2);
			xmlElement.AppendChild(xmlElement3);
			mysqlNode.AppendChild(xmlElement);
			return mysqlNode;
		}
		return null;
	}

	private static void AddProviderToMachineConfigInDir(string path)
	{
		string text = string.Format(getString_0(107352403), path);
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
		XmlElement xmlElement = (XmlElement)xmlDocument.CreateNode(XmlNodeType.Element, getString_0(107352378), getString_0(107398194));
		xmlElement.SetAttribute(getString_0(107408636), getString_0(107352373));
		xmlElement.SetAttribute(getString_0(107351832), getString_0(107351851));
		xmlElement.SetAttribute(getString_0(107351818), getString_0(107351769));
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		string value = string.Format(getString_0(107351748), executingAssembly.FullName!.Replace(getString_0(107351683), getString_0(107351634)));
		xmlElement.SetAttribute(getString_0(107408448), value);
		XmlNodeList elementsByTagName = xmlDocument.GetElementsByTagName(getString_0(107351657));
		foreach (XmlNode childNode in elementsByTagName[0]!.ChildNodes)
		{
			if (childNode.Attributes == null)
			{
				continue;
			}
			foreach (XmlAttribute item in childNode.Attributes!)
			{
				if (item.Name == getString_0(107351832) && item.Value == getString_0(107351851))
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
			if (xmlDocument.GetElementsByTagName(getString_0(107351628)).Count == 0)
			{
				xmlElement2 = (XmlElement)xmlDocument.CreateNode(XmlNodeType.Element, getString_0(107351628), getString_0(107398194));
				xmlElement2.SetAttribute(getString_0(107352087), getString_0(107352200));
			}
			else
			{
				xmlElement2 = (XmlElement)xmlDocument.GetElementsByTagName(getString_0(107351628))[0];
			}
			string newVersion = Assembly.GetExecutingAssembly().GetName().Version!.ToString();
			xmlElement2 = CreateNodeAssemblyBindingRedirection(xmlElement2, xmlDocument, getString_0(107352110), newVersion);
			xmlDocument.GetElementsByTagName(getString_0(107352097))[0]!.AppendChild(xmlElement2);
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
		if (doc.GetElementsByTagName(getString_0(107351628)).Count == 0)
		{
			return doc;
		}
		XmlNodeList childNodes = doc.GetElementsByTagName(getString_0(107351628))[0]!.ChildNodes;
		if (childNodes != null)
		{
			int count = childNodes.Count;
			for (int i = 0; i < count; i++)
			{
				if (childNodes[0]!.ChildNodes[0]!.Attributes![0].Name == getString_0(107408636) && childNodes[0]!.ChildNodes[0]!.Attributes![0].Value.Contains(getString_0(107352052)))
				{
					doc.GetElementsByTagName(getString_0(107351628))[0]!.RemoveChild(childNodes[0]);
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
		object? obj = Registry.GetValue(getString_0(107352935), getString_0(107352318), null) ?? throw new Exception(getString_0(107352333));
		UpdateMachineConfigs(obj!.ToString(), add: false);
		string text = obj!.ToString();
		text = text.Substring(0, text.Length - 1);
		text = string.Format(getString_0(107352264), text, Path.DirectorySeparatorChar);
		if (Directory.Exists(text))
		{
			UpdateMachineConfigs(text, add: false);
		}
	}

	private static void RemoveProviderFromMachineConfigInDir(string path)
	{
		string text = string.Format(getString_0(107352403), path);
		if (!File.Exists(text))
		{
			return;
		}
		StreamReader streamReader = new StreamReader(text);
		string xml = streamReader.ReadToEnd();
		streamReader.Close();
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(xml);
		XmlNodeList elementsByTagName = xmlDocument.GetElementsByTagName(getString_0(107351657));
		foreach (XmlNode childNode in elementsByTagName[0]!.ChildNodes)
		{
			if (childNode.Attributes != null && childNode.Attributes![getString_0(107408636)]!.Value == getString_0(107352373))
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

	static CustomInstaller()
	{
		Strings.CreateGetStringDelegate(typeof(CustomInstaller));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107398372), getString_0(107398367)).Replace(getString_0(107398330), getString_0(107398325)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107398320)))
		{
			throw new SecurityException(getString_0(107398295));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
