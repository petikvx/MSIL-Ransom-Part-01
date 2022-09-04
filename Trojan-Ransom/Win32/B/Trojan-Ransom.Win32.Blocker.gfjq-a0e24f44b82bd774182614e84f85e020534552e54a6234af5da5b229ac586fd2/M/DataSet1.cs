using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Microsoft.VisualBasic.CompilerServices;

namespace M;

[Serializable]
[HelpKeyword("vs.data.DataSet")]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[ToolboxItem(true)]
[DesignerCategory("code")]
[XmlRoot("DataSet1")]
public class DataSet1 : DataSet
{
	private SchemaSerializationMode _schemaSerializationMode;

	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	public override SchemaSerializationMode SchemaSerializationMode
	{
		get
		{
			return _schemaSerializationMode;
		}
		set
		{
			_schemaSerializationMode = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public new DataTableCollection Tables => base.Tables;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public new DataRelationCollection Relations => base.Relations;

	public DataSet1()
	{
		_schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		BeginInit();
		A();
		CollectionChangeEventHandler value = a;
		base.Tables.CollectionChanged += value;
		base.Relations.CollectionChanged += value;
		EndInit();
	}

	protected DataSet1(SerializationInfo info, StreamingContext context)
		: base(info, context, ConstructSchema: false)
	{
		_schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		if (IsBinarySerialized(info, context))
		{
			a(a: false);
			CollectionChangeEventHandler value = a;
			Tables.CollectionChanged += value;
			Relations.CollectionChanged += value;
			return;
		}
		string s = Conversions.ToString(info.GetValue(C.a("볣该蓧맩迫蛭闯鿱闳", 7), typeof(string)));
		if (DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
		{
			DataSet dataSet = new DataSet();
			dataSet.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
			DataSetName = dataSet.DataSetName;
			Prefix = dataSet.Prefix;
			Namespace = dataSet.Namespace;
			Locale = dataSet.Locale;
			CaseSensitive = dataSet.CaseSensitive;
			EnforceConstraints = dataSet.EnforceConstraints;
			Merge(dataSet, preserveChanges: false, MissingSchemaAction.Add);
			a();
		}
		else
		{
			ReadXmlSchema(new XmlTextReader(new StringReader(s)));
		}
		GetSerializationData(info, context);
		CollectionChangeEventHandler value2 = a;
		base.Tables.CollectionChanged += value2;
		Relations.CollectionChanged += value2;
	}

	protected override void InitializeDerivedDataSet()
	{
		BeginInit();
		A();
		EndInit();
	}

	public override DataSet Clone()
	{
		DataSet1 dataSet = (DataSet1)base.Clone();
		dataSet.a();
		dataSet.SchemaSerializationMode = SchemaSerializationMode;
		return dataSet;
	}

	protected override bool ShouldSerializeTables()
	{
		return false;
	}

	protected override bool ShouldSerializeRelations()
	{
		return false;
	}

	protected override void ReadXmlSerializable(XmlReader reader)
	{
		if (DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
		{
			Reset();
			DataSet dataSet = new DataSet();
			dataSet.ReadXml(reader);
			DataSetName = dataSet.DataSetName;
			Prefix = dataSet.Prefix;
			Namespace = dataSet.Namespace;
			Locale = dataSet.Locale;
			CaseSensitive = dataSet.CaseSensitive;
			EnforceConstraints = dataSet.EnforceConstraints;
			Merge(dataSet, preserveChanges: false, MissingSchemaAction.Add);
			a();
		}
		else
		{
			ReadXml(reader);
			a();
		}
	}

	protected override XmlSchema GetSchemaSerializable()
	{
		MemoryStream memoryStream = new MemoryStream();
		WriteXmlSchema(new XmlTextWriter(memoryStream, null));
		memoryStream.Position = 0L;
		return XmlSchema.Read(new XmlTextReader(memoryStream), null);
	}

	internal void a()
	{
		a(a: true);
	}

	internal void a(bool a)
	{
	}

	private void A()
	{
		DataSetName = C.a("ꃣ蟥鳧诩뿫语蓯쏱", 7);
		Prefix = "";
		Namespace = C.a("諡郣鋥飧탩쏫쇭蓯韱駳蛵跷裹闻탽濿瀁挃⤅䰇欉砋漍䌏眑怓✕㘗戙漛稝", 5);
		EnforceConstraints = true;
		SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
	}

	private void a(object sender, CollectionChangeEventArgs e)
	{
		if (e.Action == CollectionChangeAction.Remove)
		{
			a();
		}
	}

	public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
	{
		DataSet1 dataSet = new DataSet1();
		XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
		XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
		XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
		xmlSchemaAny.Namespace = dataSet.Namespace;
		xmlSchemaSequence.Items.Add(xmlSchemaAny);
		xmlSchemaComplexType.Particle = xmlSchemaSequence;
		XmlSchema schemaSerializable = dataSet.GetSchemaSerializable();
		if (xs.Contains(schemaSerializable.TargetNamespace))
		{
			MemoryStream memoryStream = new MemoryStream();
			MemoryStream memoryStream2 = new MemoryStream();
			try
			{
				XmlSchema xmlSchema = null;
				schemaSerializable.Write(memoryStream);
				IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
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
		xs.Add(schemaSerializable);
		return xmlSchemaComplexType;
	}
}
