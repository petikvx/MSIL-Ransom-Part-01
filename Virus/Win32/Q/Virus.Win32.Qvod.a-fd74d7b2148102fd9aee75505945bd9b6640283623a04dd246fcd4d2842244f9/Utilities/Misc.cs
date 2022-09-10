using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Xml;
using Microsoft.Win32;

namespace Utilities;

public sealed class Misc
{
	public static bool IsCriticalException(Exception ex)
	{
		if (!(ex is NullReferenceException) && !(ex is StackOverflowException) && !(ex is OutOfMemoryException))
		{
			return ex is ThreadAbortException;
		}
		return true;
	}

	public static void ValidateCodebase(string codebase)
	{
		try
		{
			ValidateUrl(codebase);
		}
		catch (UriFormatException)
		{
			Path.GetDirectoryName(codebase);
		}
	}

	public static void ValidateUrl(string url)
	{
		Uri uri = new Uri(url);
		if (uri.AbsoluteUri.IndexOf("://") != uri.Scheme.Length)
		{
			throw new UriFormatException();
		}
	}

	public static bool IsValidUrl(string url)
	{
		bool flag = false;
		try
		{
			ValidateUrl(url);
			return true;
		}
		catch (UriFormatException)
		{
			return false;
		}
	}

	public static bool IsValidCodebase(string codebase)
	{
		bool result = true;
		try
		{
			ValidateCodebase(codebase);
			return result;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public static XmlElement CloneElementToDocument(XmlElement element, XmlDocument document, string namespaceURI)
	{
		XmlElement xmlElement = document.CreateElement(element.Name, namespaceURI);
		foreach (XmlAttribute attribute in element.Attributes)
		{
			XmlAttribute xmlAttribute2 = document.CreateAttribute(attribute.Name);
			xmlAttribute2.Value = attribute.Value;
			xmlElement.Attributes.Append(xmlAttribute2);
		}
		foreach (XmlNode childNode in element.ChildNodes)
		{
			if (childNode.NodeType == XmlNodeType.Element)
			{
				XmlElement newChild = CloneElementToDocument((XmlElement)childNode, document, namespaceURI);
				xmlElement.AppendChild(newChild);
			}
		}
		return xmlElement;
	}

	public static string FormatXml(XmlDocument doc)
	{
		if (doc == null)
		{
			return "";
		}
		StringWriter stringWriter = new StringWriter();
		XmlTextWriter xmlTextWriter = new XmlTextWriter(stringWriter);
		xmlTextWriter.Formatting = Formatting.Indented;
		doc.Save(xmlTextWriter);
		return Regex.Replace(stringWriter.ToString(), "\\<\\?.*\\?\\>\\r\\n", "");
	}

	public static string FormatXml(XmlElement element)
	{
		if (element == null)
		{
			return "";
		}
		XmlDocument xmlDocument = new XmlDocument();
		XmlElement newChild = xmlDocument.ImportNode(element, deep: true) as XmlElement;
		xmlDocument.AppendChild(newChild);
		return FormatXml(xmlDocument);
	}

	internal static string GetRegisteredOrganization()
	{
		string result = "";
		using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", writable: false);
		if (registryKey != null)
		{
			if (!(registryKey.GetValue("RegisteredOrganization") is string result2))
			{
				return "";
			}
			return result2;
		}
		return result;
	}
}
