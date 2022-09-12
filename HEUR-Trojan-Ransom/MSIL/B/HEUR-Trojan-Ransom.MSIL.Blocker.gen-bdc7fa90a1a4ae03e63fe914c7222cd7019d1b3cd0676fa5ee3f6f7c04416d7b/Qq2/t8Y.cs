using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Microsoft.VisualBasic.CompilerServices;
using b5R;
using d0E;
using y4S;

namespace Qq2;

[Serializable]
[HelpKeyword("vs.data.DataSet")]
[XmlRoot("ReepahDataSet")]
[DesignerCategory("code")]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[ToolboxItem(true)]
public class t8Y : DataSet
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public delegate void Fc3(object sender, s2S e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public delegate void i7C(object sender, Yp5 e);

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class Xm1 : TypedTableBase<r5P>
	{
		private DataColumn columnID;

		private DataColumn columnMenu;

		private DataColumn columnCost;

		private Fc3 MenuRowChangingEvent;

		private Fc3 MenuRowChangedEvent;

		private Fc3 MenuRowDeletingEvent;

		private Fc3 MenuRowDeletedEvent;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn IDColumn => columnID;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn MenuColumn => columnMenu;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn CostColumn => columnCost;

		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public int Count => base.Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public r5P this[int e0S] => (r5P)base.Rows[e0S];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event Fc3 MenuRowChanging
		{
			add
			{
				Fc3 fc = MenuRowChangingEvent;
				Fc3 fc2;
				do
				{
					fc2 = fc;
					Fc3 value2 = (Fc3)Delegate.Combine(fc2, value);
					fc = Interlocked.CompareExchange(ref MenuRowChangingEvent, value2, fc2);
				}
				while ((object)fc != fc2);
			}
			remove
			{
				Fc3 fc = MenuRowChangingEvent;
				Fc3 fc2;
				do
				{
					fc2 = fc;
					Fc3 value2 = (Fc3)Delegate.Remove(fc2, value);
					fc = Interlocked.CompareExchange(ref MenuRowChangingEvent, value2, fc2);
				}
				while ((object)fc != fc2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event Fc3 MenuRowChanged
		{
			add
			{
				Fc3 fc = MenuRowChangedEvent;
				Fc3 fc2;
				do
				{
					fc2 = fc;
					Fc3 value2 = (Fc3)Delegate.Combine(fc2, value);
					fc = Interlocked.CompareExchange(ref MenuRowChangedEvent, value2, fc2);
				}
				while ((object)fc != fc2);
			}
			remove
			{
				Fc3 fc = MenuRowChangedEvent;
				Fc3 fc2;
				do
				{
					fc2 = fc;
					Fc3 value2 = (Fc3)Delegate.Remove(fc2, value);
					fc = Interlocked.CompareExchange(ref MenuRowChangedEvent, value2, fc2);
				}
				while ((object)fc != fc2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event Fc3 MenuRowDeleting
		{
			add
			{
				Fc3 fc = MenuRowDeletingEvent;
				Fc3 fc2;
				do
				{
					fc2 = fc;
					Fc3 value2 = (Fc3)Delegate.Combine(fc2, value);
					fc = Interlocked.CompareExchange(ref MenuRowDeletingEvent, value2, fc2);
				}
				while ((object)fc != fc2);
			}
			remove
			{
				Fc3 fc = MenuRowDeletingEvent;
				Fc3 fc2;
				do
				{
					fc2 = fc;
					Fc3 value2 = (Fc3)Delegate.Remove(fc2, value);
					fc = Interlocked.CompareExchange(ref MenuRowDeletingEvent, value2, fc2);
				}
				while ((object)fc != fc2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event Fc3 MenuRowDeleted
		{
			add
			{
				Fc3 fc = MenuRowDeletedEvent;
				Fc3 fc2;
				do
				{
					fc2 = fc;
					Fc3 value2 = (Fc3)Delegate.Combine(fc2, value);
					fc = Interlocked.CompareExchange(ref MenuRowDeletedEvent, value2, fc2);
				}
				while ((object)fc != fc2);
			}
			remove
			{
				Fc3 fc = MenuRowDeletedEvent;
				Fc3 fc2;
				do
				{
					fc2 = fc;
					Fc3 value2 = (Fc3)Delegate.Remove(fc2, value);
					fc = Interlocked.CompareExchange(ref MenuRowDeletedEvent, value2, fc2);
				}
				while ((object)fc != fc2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Xm1()
		{
			base.TableName = "Menu";
			BeginInit();
			Gf4();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal Xm1(DataTable table)
		{
			base.TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet!.CaseSensitive)
			{
				base.CaseSensitive = table.CaseSensitive;
			}
			if (Operators.CompareString(table.Locale.ToString(), table.DataSet!.Locale.ToString(), false) != 0)
			{
				base.Locale = table.Locale;
			}
			if (Operators.CompareString(table.Namespace, table.DataSet!.Namespace, false) != 0)
			{
				base.Namespace = table.Namespace;
			}
			base.Prefix = table.Prefix;
			base.MinimumCapacity = table.MinimumCapacity;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected Xm1(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			Fg3();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void Je1(r5P Lk8)
		{
			base.Rows.Add(Lk8);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public r5P Fw4(string Px6, decimal e8H)
		{
			r5P r5P = (r5P)NewRow();
			object[] array2 = (r5P.ItemArray = new object[3] { null, Px6, e8H });
			base.Rows.Add(r5P);
			return r5P;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public r5P z6T(int a8S)
		{
			return (r5P)base.Rows.Find(new object[1] { a8S });
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public override DataTable Pf3()
		{
			Xm1 xm = (Xm1)base.Clone();
			xm.Fg3();
			return xm;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataTable Np8()
		{
			return new Xm1();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal void Fg3()
		{
			columnID = base.Columns["ID"];
			columnMenu = base.Columns["Menu"];
			columnCost = base.Columns["Cost"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		private void Gf4()
		{
			columnID = new DataColumn("ID", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnID);
			columnMenu = new DataColumn("Menu", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnMenu);
			columnCost = new DataColumn("Cost", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnCost);
			base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[1] { columnID }, isPrimaryKey: true));
			columnID.AutoIncrement = true;
			columnID.AutoIncrementSeed = -1L;
			columnID.AutoIncrementStep = -1L;
			columnID.AllowDBNull = false;
			columnID.Unique = true;
			columnMenu.MaxLength = 536870910;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public r5P e1Q()
		{
			return (r5P)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataRow e8E(DataRowBuilder Dm4)
		{
			return new r5P(Dm4);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override Type z0R()
		{
			return typeof(r5P);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void Hz2(DataRowChangeEventArgs He2)
		{
			base.OnRowChanged(He2);
			if (MenuRowChangedEvent != null)
			{
				MenuRowChangedEvent?.Invoke(this, new s2S((r5P)He2.Row, He2.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void Qs8(DataRowChangeEventArgs c8Q)
		{
			base.OnRowChanging(c8Q);
			if (MenuRowChangingEvent != null)
			{
				MenuRowChangingEvent?.Invoke(this, new s2S((r5P)c8Q.Row, c8Q.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void n6S(DataRowChangeEventArgs p5F)
		{
			base.OnRowDeleted(p5F);
			if (MenuRowDeletedEvent != null)
			{
				MenuRowDeletedEvent?.Invoke(this, new s2S((r5P)p5F.Row, p5F.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void m8Z(DataRowChangeEventArgs Aw5)
		{
			base.OnRowDeleting(Aw5);
			if (MenuRowDeletingEvent != null)
			{
				MenuRowDeletingEvent?.Invoke(this, new s2S((r5P)Aw5.Row, Aw5.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void Jx3(r5P Bs5)
		{
			base.Rows.Remove(Bs5);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public static XmlSchemaComplexType i4C(XmlSchemaSet g9K)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			t8Y t8Y2 = new t8Y();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
			xmlSchemaAny.MinOccurs = 0m;
			xmlSchemaAny.MaxOccurs = decimal.MaxValue;
			xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
			xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			xmlSchemaAny2.MinOccurs = 1m;
			xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny2);
			XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
			xmlSchemaAttribute.Name = "namespace";
			xmlSchemaAttribute.FixedValue = t8Y2.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "MenuDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema xmlSchema = t8Y2.Ab6();
			if (g9K.Contains(xmlSchema.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema2 = null;
					xmlSchema.Write(memoryStream);
					IEnumerator enumerator = g9K.Schemas(xmlSchema.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						xmlSchema2 = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema2.Write(memoryStream2);
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
			g9K.Add(xmlSchema);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class m9Y : TypedTableBase<d6Q>
	{
		private DataColumn columnID;

		private DataColumn columnItems;

		private DataColumn columnCost;

		private i7C Requested_ItemsRowChangingEvent;

		private i7C Requested_ItemsRowChangedEvent;

		private i7C Requested_ItemsRowDeletingEvent;

		private i7C Requested_ItemsRowDeletedEvent;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn IDColumn => columnID;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn ItemsColumn => columnItems;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn CostColumn => columnCost;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		[Browsable(false)]
		public int Count => base.Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public d6Q this[int y8K] => (d6Q)base.Rows[y8K];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event i7C Requested_ItemsRowChanging
		{
			add
			{
				i7C i7C = Requested_ItemsRowChangingEvent;
				i7C i7C2;
				do
				{
					i7C2 = i7C;
					i7C value2 = (i7C)Delegate.Combine(i7C2, value);
					i7C = Interlocked.CompareExchange(ref Requested_ItemsRowChangingEvent, value2, i7C2);
				}
				while ((object)i7C != i7C2);
			}
			remove
			{
				i7C i7C = Requested_ItemsRowChangingEvent;
				i7C i7C2;
				do
				{
					i7C2 = i7C;
					i7C value2 = (i7C)Delegate.Remove(i7C2, value);
					i7C = Interlocked.CompareExchange(ref Requested_ItemsRowChangingEvent, value2, i7C2);
				}
				while ((object)i7C != i7C2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event i7C Requested_ItemsRowChanged
		{
			add
			{
				i7C i7C = Requested_ItemsRowChangedEvent;
				i7C i7C2;
				do
				{
					i7C2 = i7C;
					i7C value2 = (i7C)Delegate.Combine(i7C2, value);
					i7C = Interlocked.CompareExchange(ref Requested_ItemsRowChangedEvent, value2, i7C2);
				}
				while ((object)i7C != i7C2);
			}
			remove
			{
				i7C i7C = Requested_ItemsRowChangedEvent;
				i7C i7C2;
				do
				{
					i7C2 = i7C;
					i7C value2 = (i7C)Delegate.Remove(i7C2, value);
					i7C = Interlocked.CompareExchange(ref Requested_ItemsRowChangedEvent, value2, i7C2);
				}
				while ((object)i7C != i7C2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event i7C Requested_ItemsRowDeleting
		{
			add
			{
				i7C i7C = Requested_ItemsRowDeletingEvent;
				i7C i7C2;
				do
				{
					i7C2 = i7C;
					i7C value2 = (i7C)Delegate.Combine(i7C2, value);
					i7C = Interlocked.CompareExchange(ref Requested_ItemsRowDeletingEvent, value2, i7C2);
				}
				while ((object)i7C != i7C2);
			}
			remove
			{
				i7C i7C = Requested_ItemsRowDeletingEvent;
				i7C i7C2;
				do
				{
					i7C2 = i7C;
					i7C value2 = (i7C)Delegate.Remove(i7C2, value);
					i7C = Interlocked.CompareExchange(ref Requested_ItemsRowDeletingEvent, value2, i7C2);
				}
				while ((object)i7C != i7C2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event i7C Requested_ItemsRowDeleted
		{
			add
			{
				i7C i7C = Requested_ItemsRowDeletedEvent;
				i7C i7C2;
				do
				{
					i7C2 = i7C;
					i7C value2 = (i7C)Delegate.Combine(i7C2, value);
					i7C = Interlocked.CompareExchange(ref Requested_ItemsRowDeletedEvent, value2, i7C2);
				}
				while ((object)i7C != i7C2);
			}
			remove
			{
				i7C i7C = Requested_ItemsRowDeletedEvent;
				i7C i7C2;
				do
				{
					i7C2 = i7C;
					i7C value2 = (i7C)Delegate.Remove(i7C2, value);
					i7C = Interlocked.CompareExchange(ref Requested_ItemsRowDeletedEvent, value2, i7C2);
				}
				while ((object)i7C != i7C2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public m9Y()
		{
			base.TableName = "Requested_Items";
			BeginInit();
			Nz3();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal m9Y(DataTable table)
		{
			base.TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet!.CaseSensitive)
			{
				base.CaseSensitive = table.CaseSensitive;
			}
			if (Operators.CompareString(table.Locale.ToString(), table.DataSet!.Locale.ToString(), false) != 0)
			{
				base.Locale = table.Locale;
			}
			if (Operators.CompareString(table.Namespace, table.DataSet!.Namespace, false) != 0)
			{
				base.Namespace = table.Namespace;
			}
			base.Prefix = table.Prefix;
			base.MinimumCapacity = table.MinimumCapacity;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected m9Y(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			Td0();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void k8C(d6Q Lw6)
		{
			base.Rows.Add(Lw6);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public d6Q f5D(string k7A, decimal Ec9)
		{
			d6Q d6Q = (d6Q)NewRow();
			object[] array2 = (d6Q.ItemArray = new object[3] { null, k7A, Ec9 });
			base.Rows.Add(d6Q);
			return d6Q;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public d6Q w9B(int g1N)
		{
			return (d6Q)base.Rows.Find(new object[1] { g1N });
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public override DataTable Hz2()
		{
			m9Y m9Y = (m9Y)base.Clone();
			m9Y.Td0();
			return m9Y;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataTable d2D()
		{
			return new m9Y();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal void Td0()
		{
			columnID = base.Columns["ID"];
			columnItems = base.Columns["Items"];
			columnCost = base.Columns["Cost"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		private void Nz3()
		{
			columnID = new DataColumn("ID", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnID);
			columnItems = new DataColumn("Items", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnItems);
			columnCost = new DataColumn("Cost", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnCost);
			base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[1] { columnID }, isPrimaryKey: true));
			columnID.AutoIncrement = true;
			columnID.AutoIncrementSeed = -1L;
			columnID.AutoIncrementStep = -1L;
			columnID.AllowDBNull = false;
			columnID.Unique = true;
			columnItems.MaxLength = 536870910;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public d6Q Az9()
		{
			return (d6Q)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataRow Px1(DataRowBuilder Yg7)
		{
			return new d6Q(Yg7);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override Type Cw2()
		{
			return typeof(d6Q);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void Cj7(DataRowChangeEventArgs Tn2)
		{
			base.OnRowChanged(Tn2);
			if (Requested_ItemsRowChangedEvent != null)
			{
				Requested_ItemsRowChangedEvent?.Invoke(this, new Yp5((d6Q)Tn2.Row, Tn2.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void Nz8(DataRowChangeEventArgs m0L)
		{
			base.OnRowChanging(m0L);
			if (Requested_ItemsRowChangingEvent != null)
			{
				Requested_ItemsRowChangingEvent?.Invoke(this, new Yp5((d6Q)m0L.Row, m0L.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void Kf1(DataRowChangeEventArgs m5A)
		{
			base.OnRowDeleted(m5A);
			if (Requested_ItemsRowDeletedEvent != null)
			{
				Requested_ItemsRowDeletedEvent?.Invoke(this, new Yp5((d6Q)m5A.Row, m5A.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void z7A(DataRowChangeEventArgs n2Y)
		{
			base.OnRowDeleting(n2Y);
			if (Requested_ItemsRowDeletingEvent != null)
			{
				Requested_ItemsRowDeletingEvent?.Invoke(this, new Yp5((d6Q)n2Y.Row, n2Y.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void g9D(d6Q St1)
		{
			base.Rows.Remove(St1);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public static XmlSchemaComplexType Gk0(XmlSchemaSet a6M)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			t8Y t8Y2 = new t8Y();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
			xmlSchemaAny.MinOccurs = 0m;
			xmlSchemaAny.MaxOccurs = decimal.MaxValue;
			xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
			xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			xmlSchemaAny2.MinOccurs = 1m;
			xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny2);
			XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
			xmlSchemaAttribute.Name = "namespace";
			xmlSchemaAttribute.FixedValue = t8Y2.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "Requested_ItemsDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema xmlSchema = t8Y2.Ab6();
			if (a6M.Contains(xmlSchema.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema2 = null;
					xmlSchema.Write(memoryStream);
					IEnumerator enumerator = a6M.Schemas(xmlSchema.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						xmlSchema2 = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema2.Write(memoryStream2);
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
			a6M.Add(xmlSchema);
			return xmlSchemaComplexType;
		}
	}

	public class r5P : DataRow
	{
		private Xm1 tableMenu;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public int ID
		{
			get
			{
				return Conversions.ToInteger(base[tableMenu.IDColumn]);
			}
			set
			{
				base[tableMenu.IDColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string Menu
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableMenu.MenuColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'Menu' in table 'Menu' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableMenu.MenuColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public decimal Cost
		{
			get
			{
				try
				{
					return Conversions.ToDecimal(base[tableMenu.CostColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'Cost' in table 'Menu' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableMenu.CostColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal r5P(DataRowBuilder rb)
			: base(rb)
		{
			tableMenu = (Xm1)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool Pr3()
		{
			return IsNull(tableMenu.MenuColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void z1N()
		{
			base[tableMenu.MenuColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool Sc0()
		{
			return IsNull(tableMenu.CostColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void z1L()
		{
			base[tableMenu.CostColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	public class d6Q : DataRow
	{
		private m9Y tableRequested_Items;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public int ID
		{
			get
			{
				return Conversions.ToInteger(base[tableRequested_Items.IDColumn]);
			}
			set
			{
				base[tableRequested_Items.IDColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string Items
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableRequested_Items.ItemsColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'Items' in table 'Requested_Items' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableRequested_Items.ItemsColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public decimal Cost
		{
			get
			{
				try
				{
					return Conversions.ToDecimal(base[tableRequested_Items.CostColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'Cost' in table 'Requested_Items' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableRequested_Items.CostColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal d6Q(DataRowBuilder rb)
			: base(rb)
		{
			tableRequested_Items = (m9Y)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool Lc9()
		{
			return IsNull(tableRequested_Items.ItemsColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void By5()
		{
			base[tableRequested_Items.ItemsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool k8D()
		{
			return IsNull(tableRequested_Items.CostColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void Wi4()
		{
			base[tableRequested_Items.CostColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public class s2S : EventArgs
	{
		private r5P eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public r5P Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public s2S(r5P row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public class Yp5 : EventArgs
	{
		private d6Q eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public d6Q Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Yp5(d6Q row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	private Xm1 tableMenu;

	private m9Y tableRequested_Items;

	private SchemaSerializationMode _schemaSerializationMode;

	[Browsable(false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public Xm1 Menu => tableMenu;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	public m9Y Requested_Items => tableRequested_Items;

	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public new DataTableCollection Tables => base.Tables;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public new DataRelationCollection Relations => base.Relations;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public t8Y()
	{
		_schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		BeginInit();
		i6J();
		CollectionChangeEventHandler value = r3T;
		base.Tables.CollectionChanged += value;
		base.Relations.CollectionChanged += value;
		EndInit();
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected t8Y(SerializationInfo info, StreamingContext context)
		: base(info, context, ConstructSchema: false)
	{
		_schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		if (IsBinarySerialized(info, context))
		{
			Eg1(Jm1: false);
			CollectionChangeEventHandler value = r3T;
			Tables.CollectionChanged += value;
			Relations.CollectionChanged += value;
			return;
		}
		string s = Conversions.ToString(info.GetValue("XmlSchema", typeof(string)));
		if (DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
		{
			DataSet dataSet = new DataSet();
			dataSet.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
			if (dataSet.Tables["Menu"] != null)
			{
				base.Tables.Add(new Xm1(dataSet.Tables["Menu"]));
			}
			if (dataSet.Tables["Requested_Items"] != null)
			{
				base.Tables.Add(new m9Y(dataSet.Tables["Requested_Items"]));
			}
			base.DataSetName = dataSet.DataSetName;
			base.Prefix = dataSet.Prefix;
			base.Namespace = dataSet.Namespace;
			base.Locale = dataSet.Locale;
			base.CaseSensitive = dataSet.CaseSensitive;
			base.EnforceConstraints = dataSet.EnforceConstraints;
			Merge(dataSet, preserveChanges: false, MissingSchemaAction.Add);
			f3D();
		}
		else
		{
			ReadXmlSchema(new XmlTextReader(new StringReader(s)));
		}
		GetSerializationData(info, context);
		CollectionChangeEventHandler value2 = r3T;
		base.Tables.CollectionChanged += value2;
		Relations.CollectionChanged += value2;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected override void f5E()
	{
		BeginInit();
		i6J();
		EndInit();
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public override DataSet b3F()
	{
		t8Y t8Y2 = (t8Y)base.Clone();
		t8Y2.f3D();
		t8Y2.SchemaSerializationMode = SchemaSerializationMode;
		return t8Y2;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected override bool Xq1()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected override bool Yi1()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected override void k1A(XmlReader Ff2)
	{
		if (DetermineSchemaSerializationMode(Ff2) == SchemaSerializationMode.IncludeSchema)
		{
			Reset();
			DataSet dataSet = new DataSet();
			dataSet.ReadXml(Ff2);
			if (dataSet.Tables["Menu"] != null)
			{
				base.Tables.Add(new Xm1(dataSet.Tables["Menu"]));
			}
			if (dataSet.Tables["Requested_Items"] != null)
			{
				base.Tables.Add(new m9Y(dataSet.Tables["Requested_Items"]));
			}
			base.DataSetName = dataSet.DataSetName;
			base.Prefix = dataSet.Prefix;
			base.Namespace = dataSet.Namespace;
			base.Locale = dataSet.Locale;
			base.CaseSensitive = dataSet.CaseSensitive;
			base.EnforceConstraints = dataSet.EnforceConstraints;
			Merge(dataSet, preserveChanges: false, MissingSchemaAction.Add);
			f3D();
		}
		else
		{
			ReadXml(Ff2);
			f3D();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected override XmlSchema Ab6()
	{
		MemoryStream memoryStream = new MemoryStream();
		WriteXmlSchema(new XmlTextWriter(memoryStream, null));
		memoryStream.Position = 0L;
		return XmlSchema.Read(new XmlTextReader(memoryStream), null);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	internal void f3D()
	{
		Eg1(Jm1: true);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	internal void Eg1(bool Jm1)
	{
		tableMenu = (Xm1)base.Tables["Menu"];
		if (Jm1 && tableMenu != null)
		{
			tableMenu.Fg3();
		}
		tableRequested_Items = (m9Y)base.Tables["Requested_Items"];
		if (Jm1 && tableRequested_Items != null)
		{
			tableRequested_Items.Td0();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void i6J()
	{
		base.DataSetName = "ReepahDataSet";
		base.Prefix = "";
		base.Namespace = "http://tempuri.org/ReepahDataSet.xsd";
		base.EnforceConstraints = true;
		SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		tableMenu = new Xm1();
		base.Tables.Add(tableMenu);
		tableRequested_Items = new m9Y();
		base.Tables.Add(tableRequested_Items);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private bool o0Q()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private bool n8K()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void r3T(object sender, CollectionChangeEventArgs e)
	{
		if (e.Action == CollectionChangeAction.Remove)
		{
			f3D();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public static XmlSchemaComplexType Ni1(XmlSchemaSet Me0)
	{
		t8Y t8Y2 = new t8Y();
		XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
		XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
		XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
		xmlSchemaAny.Namespace = t8Y2.Namespace;
		xmlSchemaSequence.Items.Add(xmlSchemaAny);
		xmlSchemaComplexType.Particle = xmlSchemaSequence;
		XmlSchema xmlSchema = t8Y2.Ab6();
		if (Me0.Contains(xmlSchema.TargetNamespace))
		{
			MemoryStream memoryStream = new MemoryStream();
			MemoryStream memoryStream2 = new MemoryStream();
			try
			{
				XmlSchema xmlSchema2 = null;
				xmlSchema.Write(memoryStream);
				IEnumerator enumerator = Me0.Schemas(xmlSchema.TargetNamespace).GetEnumerator();
				while (enumerator.MoveNext())
				{
					xmlSchema2 = (XmlSchema)enumerator.Current;
					memoryStream2.SetLength(0L);
					xmlSchema2.Write(memoryStream2);
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
		Me0.Add(xmlSchema);
		return xmlSchemaComplexType;
	}

	internal static string o2B()
	{
		return Xg9(new string[22]
		{
			t5R.Ck6(0),
			t5R.Ck6(1),
			t5R.Ck6(2),
			t5R.Ck6(3),
			t5R.Ck6(4),
			t5R.Ck6(5),
			t5R.Ck6(6),
			t5R.Ck6(7),
			t5R.Ck6(8),
			t5R.Ck6(9),
			t5R.Ck6(10),
			t5R.Ck6(11),
			t5R.Ck6(12),
			t5R.Ck6(13),
			t5R.Ck6(14),
			t5R.Ck6(15),
			t5R.Ck6(16),
			t5R.Ck6(17),
			t5R.Ck6(18),
			t5R.Ck6(19),
			t5R.Ck6(20),
			t5R.Ck6(21)
		});
	}

	internal static string Xg9(string[] Ww8)
	{
		return string.Concat(Ww8);
	}

	internal static byte[] a9N(int Mk8, int Zs1)
	{
		if (Mk8 <= 0)
		{
			return null;
		}
		checked
		{
			int[] array = new int[Zs1 + 1];
			for (int i = 0; i <= Zs1; i++)
			{
				int num = Mk8 * i;
				if (num > 255)
				{
					num = 255;
				}
				array[i] = num;
			}
			return t5R.f7D(array, Zs1);
		}
	}

	internal static string[] Lb2()
	{
		Xw9.f0L();
		List<string> list = new List<string>();
		int num = 0;
		Assembly assembly = Assembly.LoadFrom(Environment.GetCommandLineArgs()[0]);
		Cj0.mDic.Add("Ass", assembly);
		string[] manifestResourceNames = assembly.GetManifestResourceNames();
		foreach (string item in manifestResourceNames)
		{
			list.Add(item);
		}
		checked
		{
			string[] array = new string[list.Count - 1 + 1];
			int num2 = array.Length - 1;
			for (num = 0; num <= num2; num++)
			{
				array[num] = list[num];
			}
			return array;
		}
	}
}
