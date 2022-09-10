using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace VaultMirror.Security;

[Serializable]
[GeneratedCode("System.Xml", "2.0.50727.42")]
[XmlType(Namespace = "http://AutodeskDM/Services/Security/01/02/2007/")]
public enum SecRestricCode
{
	LessRestrctiveParent,
	BadEntityId,
	UnsupportedEntityClass
}
