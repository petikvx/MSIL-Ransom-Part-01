using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Xml;

namespace NChanges;

[DebuggerDisplay("{Name}")]
public class MemberInfo
{
	private List<ParameterInfo> _parameters = new List<ParameterInfo>();

	private List<MemberChangeInfo> _changes = new List<MemberChangeInfo>();

	public string Name { get; set; }

	public MemberKind Kind { get; set; }

	public string Type { get; set; }

	public bool Obsolete { get; set; }

	public string ObsoleteMessage { get; set; }

	public IList<ParameterInfo> Parameters => _parameters;

	public ICollection<MemberChangeInfo> Changes => _changes;

	public void ReadMember(System.Reflection.MemberInfo memberInfo)
	{
		Name = memberInfo.Name;
		if (memberInfo is ConstructorInfo)
		{
			Kind = MemberKind.Constructor;
			Type = "";
			ReadParameters(((ConstructorInfo)memberInfo).GetParameters());
		}
		else if (memberInfo is MethodInfo)
		{
			Kind = MemberKind.Method;
			Type = ((MethodInfo)memberInfo).ReturnType.FullName;
			ReadParameters(((MethodInfo)memberInfo).GetParameters());
		}
		else if (memberInfo is PropertyInfo)
		{
			Kind = MemberKind.Property;
			Type = ((PropertyInfo)memberInfo).PropertyType.FullName;
		}
		else if (memberInfo is EventInfo)
		{
			Kind = MemberKind.Event;
			Type = ((EventInfo)memberInfo).EventHandlerType!.FullName;
		}
		else if (memberInfo is FieldInfo)
		{
			Kind = MemberKind.Field;
			Type = ((FieldInfo)memberInfo).FieldType.FullName;
		}
		ObsoleteAttribute obsoleteAttribute = (ObsoleteAttribute)Attribute.GetCustomAttribute(memberInfo, typeof(ObsoleteAttribute));
		if (obsoleteAttribute != null)
		{
			Obsolete = true;
			ObsoleteMessage = obsoleteAttribute.Message;
		}
	}

	private void ReadParameters(IEnumerable<System.Reflection.ParameterInfo> parameters)
	{
		foreach (System.Reflection.ParameterInfo parameter in parameters)
		{
			Parameters.Add(new ParameterInfo
			{
				Name = parameter.Name,
				Type = TypeHelpers.CleanUpGenericTypes(parameter.ParameterType.FullName ?? parameter.ParameterType.Name)
			});
		}
	}

	public void WriteXml(XmlWriter xmlWriter)
	{
		xmlWriter.WriteStartElement("member");
		xmlWriter.WriteAttributeString("name", Name);
		xmlWriter.WriteAttributeString("kind", Kind.ToString());
		xmlWriter.WriteAttributeString("type", Type);
		if (Obsolete)
		{
			xmlWriter.WriteAttributeString("obsolete", Obsolete.ToString());
		}
		if (ObsoleteMessage != null)
		{
			xmlWriter.WriteAttributeString("obsoleteMessage", ObsoleteMessage);
		}
		foreach (MemberChangeInfo change in Changes)
		{
			change.WriteXml(xmlWriter);
		}
		foreach (ParameterInfo parameter in Parameters)
		{
			parameter.WriteXml(xmlWriter);
		}
		xmlWriter.WriteEndElement();
	}

	public void ReadXml(XmlReader xmlReader)
	{
		Name = xmlReader.GetAttribute("name");
		Kind = (MemberKind)Enum.Parse(typeof(MemberKind), xmlReader.GetAttribute("kind"));
		Type = xmlReader.GetAttribute("type");
		Obsolete = string.Equals(xmlReader.GetAttribute("obsolete"), "true", StringComparison.OrdinalIgnoreCase);
		ObsoleteMessage = xmlReader.GetAttribute("obsoleteMessage");
		if (xmlReader.IsEmptyElement)
		{
			return;
		}
		XmlReader xmlReader2 = xmlReader.ReadSubtree();
		while (xmlReader2.Read())
		{
			if (xmlReader2.NodeType == XmlNodeType.Element)
			{
				if (xmlReader2.Name == "change")
				{
					MemberChangeInfo memberChangeInfo = new MemberChangeInfo();
					memberChangeInfo.ReadXml(xmlReader);
					Changes.Add(memberChangeInfo);
				}
				else if (xmlReader2.Name == "param")
				{
					ParameterInfo parameterInfo = new ParameterInfo();
					parameterInfo.ReadXml(xmlReader);
					Parameters.Add(parameterInfo);
				}
			}
		}
	}

	public MemberInfo Clone()
	{
		MemberInfo obj = (MemberInfo)MemberwiseClone();
		obj._parameters = new List<ParameterInfo>(Parameters.Select((ParameterInfo p) => p.Clone()));
		obj._changes = new List<MemberChangeInfo>(Changes.Select((MemberChangeInfo c) => c.Clone()));
		return obj;
	}

	public void UpdateParameters(MemberInfo memberInfo)
	{
		_parameters = new List<ParameterInfo>(memberInfo.Parameters.Select((ParameterInfo p) => p.Clone()));
	}
}
