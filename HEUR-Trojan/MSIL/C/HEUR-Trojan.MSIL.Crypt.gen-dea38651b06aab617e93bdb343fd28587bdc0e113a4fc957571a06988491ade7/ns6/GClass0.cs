using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace ns6;

[Serializable]
[HelpKeyword("vs.data.DataSet")]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[DesignerCategory("code")]
[XmlRoot("databaseDataSet")]
[ToolboxItem(true)]
public class GClass0 : DataSet
{
	private SchemaSerializationMode schemaSerializationMode_0 = SchemaSerializationMode.IncludeSchema;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[DebuggerNonUserCode]
	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	public override SchemaSerializationMode SchemaSerializationMode
	{
		get
		{
			return schemaSerializationMode_0;
		}
		set
		{
			schemaSerializationMode_0 = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[DebuggerNonUserCode]
	public new DataTableCollection Tables => base.Tables;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[DebuggerNonUserCode]
	public new DataRelationCollection Relations => base.Relations;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[DebuggerNonUserCode]
	public GClass0()
	{
		BeginInit();
		method_2();
		CollectionChangeEventHandler value = method_3;
		base.Tables.CollectionChanged += value;
		base.Relations.CollectionChanged += value;
		EndInit();
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[DebuggerNonUserCode]
	protected GClass0(SerializationInfo info, StreamingContext context)
		: base(info, context, ConstructSchema: false)
	{
		if (IsBinarySerialized(info, context))
		{
			method_1(bool_0: false);
			CollectionChangeEventHandler value = method_3;
			Tables.CollectionChanged += value;
			Relations.CollectionChanged += value;
			return;
		}
		string s = (string)info.GetValue("XmlSchema", typeof(string));
		if (DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
		{
			DataSet dataSet = new DataSet();
			dataSet.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
			base.DataSetName = dataSet.DataSetName;
			base.Prefix = dataSet.Prefix;
			base.Namespace = dataSet.Namespace;
			base.Locale = dataSet.Locale;
			base.CaseSensitive = dataSet.CaseSensitive;
			base.EnforceConstraints = dataSet.EnforceConstraints;
			Merge(dataSet, preserveChanges: false, MissingSchemaAction.Add);
			method_0();
		}
		else
		{
			ReadXmlSchema(new XmlTextReader(new StringReader(s)));
		}
		GetSerializationData(info, context);
		CollectionChangeEventHandler value2 = method_3;
		base.Tables.CollectionChanged += value2;
		Relations.CollectionChanged += value2;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected override void vmethod_0()
	{
		BeginInit();
		method_2();
		EndInit();
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[DebuggerNonUserCode]
	public override DataSet vmethod_1()
	{
		GClass0 gClass = (GClass0)base.Clone();
		gClass.method_0();
		gClass.SchemaSerializationMode = SchemaSerializationMode;
		return gClass;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected override bool vmethod_2()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected override bool vmethod_3()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[DebuggerNonUserCode]
	protected override void vmethod_4(XmlReader xmlReader_0)
	{
		if (DetermineSchemaSerializationMode(xmlReader_0) == SchemaSerializationMode.IncludeSchema)
		{
			Reset();
			DataSet dataSet = new DataSet();
			dataSet.ReadXml(xmlReader_0);
			base.DataSetName = dataSet.DataSetName;
			base.Prefix = dataSet.Prefix;
			base.Namespace = dataSet.Namespace;
			base.Locale = dataSet.Locale;
			base.CaseSensitive = dataSet.CaseSensitive;
			base.EnforceConstraints = dataSet.EnforceConstraints;
			Merge(dataSet, preserveChanges: false, MissingSchemaAction.Add);
			method_0();
		}
		else
		{
			ReadXml(xmlReader_0);
			method_0();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected override XmlSchema vmethod_5()
	{
		MemoryStream memoryStream = new MemoryStream();
		WriteXmlSchema(new XmlTextWriter(memoryStream, null));
		memoryStream.Position = 0L;
		return XmlSchema.Read(new XmlTextReader(memoryStream), null);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[DebuggerNonUserCode]
	internal void method_0()
	{
		method_1(bool_0: true);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[DebuggerNonUserCode]
	internal void method_1(bool bool_0)
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void method_2()
	{
		base.DataSetName = "databaseDataSet";
		base.Prefix = "";
		base.Namespace = "http://tempuri.org/databaseDataSet.xsd";
		base.EnforceConstraints = true;
		SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void method_3(object sender, CollectionChangeEventArgs e)
	{
		if (e.Action == CollectionChangeAction.Remove)
		{
			method_0();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
	{
		GClass0 gClass = new GClass0();
		XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
		XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
		XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
		xmlSchemaAny.Namespace = gClass.Namespace;
		xmlSchemaSequence.Items.Add(xmlSchemaAny);
		xmlSchemaComplexType.Particle = xmlSchemaSequence;
		XmlSchema schemaSerializable = gClass.GetSchemaSerializable();
		if (xmlSchemaSet_0.Contains(schemaSerializable.TargetNamespace))
		{
			MemoryStream memoryStream = new MemoryStream();
			MemoryStream memoryStream2 = new MemoryStream();
			try
			{
				XmlSchema xmlSchema = null;
				schemaSerializable.Write(memoryStream);
				IEnumerator enumerator = xmlSchemaSet_0.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
				while (enumerator.MoveNext())
				{
					xmlSchema = (XmlSchema)enumerator.Current;
					memoryStream2.SetLength(0L);
					xmlSchema.Write(memoryStream2);
					if (memoryStream.Length == memoryStream2.Length)
					{
						memoryStream.Position = 0L;
						memoryStream2.Position = 0L;
						while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
						{
						}
						if (memoryStream.Position == memoryStream.Length)
						{
							return xmlSchemaComplexType;
						}
					}
				}
			}
			finally
			{
				memoryStream?.Close();
				memoryStream2?.Close();
			}
		}
		xmlSchemaSet_0.Add(schemaSerializable);
		return xmlSchemaComplexType;
	}
}
