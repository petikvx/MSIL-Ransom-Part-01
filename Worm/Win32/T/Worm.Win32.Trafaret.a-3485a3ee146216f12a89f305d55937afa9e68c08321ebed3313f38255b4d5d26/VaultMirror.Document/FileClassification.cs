using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace VaultMirror.Document;

[Serializable]
[XmlType(Namespace = "http://AutodeskDM/Services/Document/01/02/2007/")]
[GeneratedCode("System.Xml", "2.0.50727.42")]
public enum FileClassification
{
	None,
	DesignVisualization,
	DesignDocument,
	ConfigurationMember,
	ConfigurationFactory,
	ElectricalProject
}
