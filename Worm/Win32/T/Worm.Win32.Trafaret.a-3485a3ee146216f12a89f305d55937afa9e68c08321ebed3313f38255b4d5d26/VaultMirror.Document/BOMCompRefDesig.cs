using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace VaultMirror.Document;

[Serializable]
[DebuggerStepThrough]
[DesignerCategory("code")]
[GeneratedCode("System.Xml", "2.0.50727.42")]
[XmlType(Namespace = "http://AutodeskDM/Services/Document/01/02/2007/")]
public class BOMCompRefDesig
{
	private long idField;

	private long compIdField;

	private long refIdField;

	private int cntField;

	[XmlAttribute]
	public long Id
	{
		get
		{
			return idField;
		}
		set
		{
			idField = value;
		}
	}

	[XmlAttribute]
	public long CompId
	{
		get
		{
			return compIdField;
		}
		set
		{
			compIdField = value;
		}
	}

	[XmlAttribute]
	public long RefId
	{
		get
		{
			return refIdField;
		}
		set
		{
			refIdField = value;
		}
	}

	[XmlAttribute]
	public int Cnt
	{
		get
		{
			return cntField;
		}
		set
		{
			cntField = value;
		}
	}
}
