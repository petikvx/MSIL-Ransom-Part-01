using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Xml;

namespace NChanges;

public class AssemblyInfo
{
	private readonly List<TypeInfo> _types = new List<TypeInfo>();

	public string Name { get; set; }

	public string Version { get; set; }

	public ICollection<TypeInfo> Types => _types;

	public void ReadAssembly(Assembly assembly, string excludePattern = null)
	{
		Name = assembly.GetName().Name;
		Version = assembly.GetName().Version!.ToString();
		Regex excludeRegex = null;
		if (!string.IsNullOrEmpty(excludePattern))
		{
			excludeRegex = new Regex(excludePattern);
		}
		Type[] types = assembly.GetTypes();
		foreach (Type type in types)
		{
			if (type.IsPublic && TypeIsNotExcluded(type, excludeRegex))
			{
				TypeInfo typeInfo = new TypeInfo();
				typeInfo.ReadType(type);
				_types.Add(typeInfo);
			}
		}
	}

	private bool TypeIsNotExcluded(Type type, Regex excludeRegex)
	{
		if (excludeRegex != null)
		{
			return !excludeRegex.IsMatch(type.FullName);
		}
		return true;
	}

	public void WriteXml(XmlWriter xmlWriter)
	{
		xmlWriter.WriteStartElement("assembly");
		xmlWriter.WriteAttributeString("name", Name);
		xmlWriter.WriteAttributeString("version", Version);
		foreach (TypeInfo type in Types)
		{
			type.WriteXml(xmlWriter);
		}
		xmlWriter.WriteEndElement();
		xmlWriter.Flush();
	}

	public void ReadXml(XmlReader xmlReader)
	{
		while (xmlReader.ReadToFollowing("assembly"))
		{
			Name = xmlReader.GetAttribute("name");
			Version = xmlReader.GetAttribute("version");
			if (xmlReader.IsEmptyElement)
			{
				continue;
			}
			XmlReader xmlReader2 = xmlReader.ReadSubtree();
			while (xmlReader2.Read())
			{
				if (xmlReader2.NodeType == XmlNodeType.Element && xmlReader2.Name == "type")
				{
					TypeInfo typeInfo = new TypeInfo();
					typeInfo.ReadXml(xmlReader);
					Types.Add(typeInfo);
				}
			}
		}
	}

	public bool HasChanges()
	{
		foreach (TypeInfo type in Types)
		{
			if (type.Changes.Count <= 0)
			{
				foreach (MemberInfo member in type.Members)
				{
					if (member.Changes.Count > 0)
					{
						return true;
					}
				}
				continue;
			}
			return true;
		}
		return false;
	}
}
