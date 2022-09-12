using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Xml;

namespace NChanges;

[DebuggerDisplay("{Name}")]
public class TypeInfo
{
	private List<MemberInfo> _members = new List<MemberInfo>();

	private List<TypeChangeInfo> _changes = new List<TypeChangeInfo>();

	public string Name { get; set; }

	public string Namespace { get; set; }

	public TypeKind Kind { get; set; }

	public bool Obsolete { get; set; }

	public string ObsoleteMessage { get; set; }

	public ICollection<MemberInfo> Members => _members;

	public ICollection<TypeChangeInfo> Changes => _changes;

	public void ReadType(Type type)
	{
		Name = type.Name;
		Namespace = type.Namespace;
		if (type.IsSubclassOf(typeof(Delegate)))
		{
			Kind = TypeKind.Delegate;
		}
		else if (type.IsClass)
		{
			Kind = TypeKind.Class;
		}
		else if (type.IsInterface)
		{
			Kind = TypeKind.Interface;
		}
		else if (type.IsEnum)
		{
			Kind = TypeKind.Enum;
		}
		else if (type.IsValueType)
		{
			Kind = TypeKind.ValueType;
		}
		ObsoleteAttribute obsoleteAttribute = (ObsoleteAttribute)Attribute.GetCustomAttribute(type, typeof(ObsoleteAttribute));
		if (obsoleteAttribute != null)
		{
			Obsolete = true;
			ObsoleteMessage = obsoleteAttribute.Message;
		}
		System.Reflection.MemberInfo[] members = type.GetMembers();
		foreach (System.Reflection.MemberInfo memberInfo in members)
		{
			if (!MemberIsNotDeclaredOnThisType(memberInfo, type) && !MemberIsSpecialMethodButNotConstructor(memberInfo) && !MemberIsSpecialField(memberInfo) && !MemberIsOverride(memberInfo))
			{
				MemberInfo memberInfo2 = new MemberInfo();
				memberInfo2.ReadMember(memberInfo);
				_members.Add(memberInfo2);
			}
		}
	}

	private static bool MemberIsNotDeclaredOnThisType(System.Reflection.MemberInfo member, Type type)
	{
		return (object)member.DeclaringType != type;
	}

	private static bool MemberIsSpecialMethodButNotConstructor(System.Reflection.MemberInfo member)
	{
		if (member is MethodBase && ((MethodBase)member).IsSpecialName)
		{
			return !(member is ConstructorInfo);
		}
		return false;
	}

	private static bool MemberIsSpecialField(System.Reflection.MemberInfo member)
	{
		if (member is FieldInfo)
		{
			return (((FieldInfo)member).Attributes & FieldAttributes.RTSpecialName) == FieldAttributes.RTSpecialName;
		}
		return false;
	}

	private static bool MemberIsOverride(System.Reflection.MemberInfo member)
	{
		if (member is MethodInfo)
		{
			MethodInfo methodInfo = (MethodInfo)member;
			if (methodInfo.IsVirtual && (object)methodInfo.GetBaseDefinition() != methodInfo)
			{
				return true;
			}
		}
		if (member is PropertyInfo)
		{
			PropertyInfo obj = (PropertyInfo)member;
			MethodInfo getMethod = obj.GetGetMethod();
			MethodInfo getMethod2 = obj.GetGetMethod();
			if ((getMethod == null || (getMethod.IsVirtual && MemberIsOverride(getMethod))) && (getMethod2 == null || (getMethod2.IsVirtual && MemberIsOverride(getMethod2))))
			{
				return true;
			}
		}
		return false;
	}

	public void WriteXml(XmlWriter xmlWriter)
	{
		xmlWriter.WriteStartElement("type");
		xmlWriter.WriteAttributeString("name", Name);
		xmlWriter.WriteAttributeString("namespace", Namespace);
		xmlWriter.WriteAttributeString("kind", Kind.ToString());
		if (Obsolete)
		{
			xmlWriter.WriteAttributeString("obsolete", Obsolete.ToString());
		}
		if (ObsoleteMessage != null)
		{
			xmlWriter.WriteAttributeString("obsoleteMessage", ObsoleteMessage);
		}
		foreach (TypeChangeInfo change in Changes)
		{
			change.WriteXml(xmlWriter);
		}
		foreach (MemberInfo member in Members)
		{
			member.WriteXml(xmlWriter);
		}
		xmlWriter.WriteEndElement();
	}

	public void ReadXml(XmlReader xmlReader)
	{
		Name = xmlReader.GetAttribute("name");
		Namespace = xmlReader.GetAttribute("namespace");
		Kind = (TypeKind)Enum.Parse(typeof(TypeKind), xmlReader.GetAttribute("kind"));
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
					TypeChangeInfo typeChangeInfo = new TypeChangeInfo();
					typeChangeInfo.ReadXml(xmlReader);
					Changes.Add(typeChangeInfo);
				}
				else if (xmlReader2.Name == "member")
				{
					MemberInfo memberInfo = new MemberInfo();
					memberInfo.ReadXml(xmlReader);
					Members.Add(memberInfo);
				}
			}
		}
	}

	public TypeInfo Clone()
	{
		TypeInfo obj = (TypeInfo)MemberwiseClone();
		obj._members = new List<MemberInfo>(Members.Select((MemberInfo m) => m.Clone()));
		obj._changes = new List<TypeChangeInfo>(Changes.Select((TypeChangeInfo c) => c.Clone()));
		return obj;
	}
}
