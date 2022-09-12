using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Microsoft.VisualBasic.CompilerServices;

namespace g4N1;

[Serializable]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[HelpKeyword("vs.data.DataSet")]
[XmlRoot("libraryDataSet1")]
[ToolboxItem(true)]
[DesignerCategory("code")]
public class Ct6g : DataSet
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void Kr52(object sender, Wi4 e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void Ai24(object sender, Hf7 e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void k8DA(object sender, Gm9 e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void j4BK(object sender, Xa4 e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void e4R7(object sender, Qq6 e);

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class m2R4 : TypedTableBase<Xi9>
	{
		private DataColumn columnbnum;

		private DataColumn columnbname;

		private DataColumn columnauthorName;

		private DataColumn columnnumberOfCopies;

		private Kr52 booksRowChangingEvent;

		private Kr52 booksRowChangedEvent;

		private Kr52 booksRowDeletingEvent;

		private Kr52 booksRowDeletedEvent;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn bnumColumn => columnbnum;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn bnameColumn => columnbname;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn authorNameColumn => columnauthorName;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn numberOfCopiesColumn => columnnumberOfCopies;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		public int Count => base.Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Xi9 this[int Ni2] => (Xi9)base.Rows[Ni2];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Kr52 booksRowChanging
		{
			add
			{
				Kr52 kr = booksRowChangingEvent;
				Kr52 kr2;
				do
				{
					kr2 = kr;
					Kr52 value2 = (Kr52)Delegate.Combine(kr2, value);
					kr = Interlocked.CompareExchange(ref booksRowChangingEvent, value2, kr2);
				}
				while ((object)kr != kr2);
			}
			remove
			{
				Kr52 kr = booksRowChangingEvent;
				Kr52 kr2;
				do
				{
					kr2 = kr;
					Kr52 value2 = (Kr52)Delegate.Remove(kr2, value);
					kr = Interlocked.CompareExchange(ref booksRowChangingEvent, value2, kr2);
				}
				while ((object)kr != kr2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Kr52 booksRowChanged
		{
			add
			{
				Kr52 kr = booksRowChangedEvent;
				Kr52 kr2;
				do
				{
					kr2 = kr;
					Kr52 value2 = (Kr52)Delegate.Combine(kr2, value);
					kr = Interlocked.CompareExchange(ref booksRowChangedEvent, value2, kr2);
				}
				while ((object)kr != kr2);
			}
			remove
			{
				Kr52 kr = booksRowChangedEvent;
				Kr52 kr2;
				do
				{
					kr2 = kr;
					Kr52 value2 = (Kr52)Delegate.Remove(kr2, value);
					kr = Interlocked.CompareExchange(ref booksRowChangedEvent, value2, kr2);
				}
				while ((object)kr != kr2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Kr52 booksRowDeleting
		{
			add
			{
				Kr52 kr = booksRowDeletingEvent;
				Kr52 kr2;
				do
				{
					kr2 = kr;
					Kr52 value2 = (Kr52)Delegate.Combine(kr2, value);
					kr = Interlocked.CompareExchange(ref booksRowDeletingEvent, value2, kr2);
				}
				while ((object)kr != kr2);
			}
			remove
			{
				Kr52 kr = booksRowDeletingEvent;
				Kr52 kr2;
				do
				{
					kr2 = kr;
					Kr52 value2 = (Kr52)Delegate.Remove(kr2, value);
					kr = Interlocked.CompareExchange(ref booksRowDeletingEvent, value2, kr2);
				}
				while ((object)kr != kr2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Kr52 booksRowDeleted
		{
			add
			{
				Kr52 kr = booksRowDeletedEvent;
				Kr52 kr2;
				do
				{
					kr2 = kr;
					Kr52 value2 = (Kr52)Delegate.Combine(kr2, value);
					kr = Interlocked.CompareExchange(ref booksRowDeletedEvent, value2, kr2);
				}
				while ((object)kr != kr2);
			}
			remove
			{
				Kr52 kr = booksRowDeletedEvent;
				Kr52 kr2;
				do
				{
					kr2 = kr;
					Kr52 value2 = (Kr52)Delegate.Remove(kr2, value);
					kr = Interlocked.CompareExchange(ref booksRowDeletedEvent, value2, kr2);
				}
				while ((object)kr != kr2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public m2R4()
		{
			base.TableName = "books";
			BeginInit();
			t2B();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal m2R4(DataTable table)
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected m2R4(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			z9Y();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void My0(Xi9 t3E)
		{
			base.Rows.Add(t3E);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Xi9 a6P(int i9Q, string To6, string Ts8, int Pr4)
		{
			Xi9 xi = (Xi9)NewRow();
			object[] array2 = (xi.ItemArray = new object[4] { i9Q, To6, Ts8, Pr4 });
			base.Rows.Add(xi);
			return xi;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Xi9 q0N(int Se9)
		{
			return (Xi9)base.Rows.Find(new object[1] { Se9 });
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Tw7()
		{
			m2R4 m2R = (m2R4)base.Clone();
			m2R.z9Y();
			return m2R;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable k9Z()
		{
			return new m2R4();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void z9Y()
		{
			columnbnum = base.Columns["bnum"];
			columnbname = base.Columns["bname"];
			columnauthorName = base.Columns["authorName"];
			columnnumberOfCopies = base.Columns["numberOfCopies"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void t2B()
		{
			columnbnum = new DataColumn("bnum", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnbnum);
			columnbname = new DataColumn("bname", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnbname);
			columnauthorName = new DataColumn("authorName", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnauthorName);
			columnnumberOfCopies = new DataColumn("numberOfCopies", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnnumberOfCopies);
			base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[1] { columnbnum }, isPrimaryKey: true));
			columnbnum.AllowDBNull = false;
			columnbnum.Unique = true;
			columnbname.MaxLength = 25;
			columnauthorName.MaxLength = 25;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Xi9 e0G()
		{
			return (Xi9)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow Ls8(DataRowBuilder q7Z)
		{
			return new Xi9(q7Z);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type t6Q()
		{
			return typeof(Xi9);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void Rj9(DataRowChangeEventArgs Nn2)
		{
			base.OnRowChanged(Nn2);
			if (booksRowChangedEvent != null)
			{
				booksRowChangedEvent?.Invoke(this, new Wi4((Xi9)Nn2.Row, Nn2.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void Wi1(DataRowChangeEventArgs Yj3)
		{
			base.OnRowChanging(Yj3);
			if (booksRowChangingEvent != null)
			{
				booksRowChangingEvent?.Invoke(this, new Wi4((Xi9)Yj3.Row, Yj3.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void Wk6(DataRowChangeEventArgs Hj9)
		{
			base.OnRowDeleted(Hj9);
			if (booksRowDeletedEvent != null)
			{
				booksRowDeletedEvent?.Invoke(this, new Wi4((Xi9)Hj9.Row, Hj9.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void g3X(DataRowChangeEventArgs Ja7)
		{
			base.OnRowDeleting(Ja7);
			if (booksRowDeletingEvent != null)
			{
				booksRowDeletingEvent?.Invoke(this, new Wi4((Xi9)Ja7.Row, Ja7.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void e1Q(Xi9 No3)
		{
			base.Rows.Remove(No3);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType c8D(XmlSchemaSet a2C)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Ct6g ct6g = new Ct6g();
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
			xmlSchemaAttribute.FixedValue = ct6g.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "booksDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema xmlSchema = ct6g.o7DZ();
			if (a2C.Contains(xmlSchema.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema2 = null;
					xmlSchema.Write(memoryStream);
					IEnumerator enumerator = a2C.Schemas(xmlSchema.TargetNamespace).GetEnumerator();
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
			a2C.Add(xmlSchema);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class Xw8 : TypedTableBase<Zf1>
	{
		private DataColumn columnuserid;

		private DataColumn columnusername;

		private DataColumn columnbid;

		private DataColumn columnbname;

		private DataColumn columnaname;

		private Ai24 borrowbookRowChangingEvent;

		private Ai24 borrowbookRowChangedEvent;

		private Ai24 borrowbookRowDeletingEvent;

		private Ai24 borrowbookRowDeletedEvent;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn useridColumn => columnuserid;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn usernameColumn => columnusername;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn bidColumn => columnbid;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn bnameColumn => columnbname;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn anameColumn => columnaname;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		public int Count => base.Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Zf1 this[int e0K] => (Zf1)base.Rows[e0K];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Ai24 borrowbookRowChanging
		{
			add
			{
				Ai24 ai = borrowbookRowChangingEvent;
				Ai24 ai2;
				do
				{
					ai2 = ai;
					Ai24 value2 = (Ai24)Delegate.Combine(ai2, value);
					ai = Interlocked.CompareExchange(ref borrowbookRowChangingEvent, value2, ai2);
				}
				while ((object)ai != ai2);
			}
			remove
			{
				Ai24 ai = borrowbookRowChangingEvent;
				Ai24 ai2;
				do
				{
					ai2 = ai;
					Ai24 value2 = (Ai24)Delegate.Remove(ai2, value);
					ai = Interlocked.CompareExchange(ref borrowbookRowChangingEvent, value2, ai2);
				}
				while ((object)ai != ai2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Ai24 borrowbookRowChanged
		{
			add
			{
				Ai24 ai = borrowbookRowChangedEvent;
				Ai24 ai2;
				do
				{
					ai2 = ai;
					Ai24 value2 = (Ai24)Delegate.Combine(ai2, value);
					ai = Interlocked.CompareExchange(ref borrowbookRowChangedEvent, value2, ai2);
				}
				while ((object)ai != ai2);
			}
			remove
			{
				Ai24 ai = borrowbookRowChangedEvent;
				Ai24 ai2;
				do
				{
					ai2 = ai;
					Ai24 value2 = (Ai24)Delegate.Remove(ai2, value);
					ai = Interlocked.CompareExchange(ref borrowbookRowChangedEvent, value2, ai2);
				}
				while ((object)ai != ai2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Ai24 borrowbookRowDeleting
		{
			add
			{
				Ai24 ai = borrowbookRowDeletingEvent;
				Ai24 ai2;
				do
				{
					ai2 = ai;
					Ai24 value2 = (Ai24)Delegate.Combine(ai2, value);
					ai = Interlocked.CompareExchange(ref borrowbookRowDeletingEvent, value2, ai2);
				}
				while ((object)ai != ai2);
			}
			remove
			{
				Ai24 ai = borrowbookRowDeletingEvent;
				Ai24 ai2;
				do
				{
					ai2 = ai;
					Ai24 value2 = (Ai24)Delegate.Remove(ai2, value);
					ai = Interlocked.CompareExchange(ref borrowbookRowDeletingEvent, value2, ai2);
				}
				while ((object)ai != ai2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Ai24 borrowbookRowDeleted
		{
			add
			{
				Ai24 ai = borrowbookRowDeletedEvent;
				Ai24 ai2;
				do
				{
					ai2 = ai;
					Ai24 value2 = (Ai24)Delegate.Combine(ai2, value);
					ai = Interlocked.CompareExchange(ref borrowbookRowDeletedEvent, value2, ai2);
				}
				while ((object)ai != ai2);
			}
			remove
			{
				Ai24 ai = borrowbookRowDeletedEvent;
				Ai24 ai2;
				do
				{
					ai2 = ai;
					Ai24 value2 = (Ai24)Delegate.Remove(ai2, value);
					ai = Interlocked.CompareExchange(ref borrowbookRowDeletedEvent, value2, ai2);
				}
				while ((object)ai != ai2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Xw8()
		{
			base.TableName = "borrowbook";
			BeginInit();
			m6A();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Xw8(DataTable table)
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected Xw8(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			c0Z();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void z7Y(Zf1 Ec8)
		{
			base.Rows.Add(Ec8);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Zf1 d2X(string p8N, string j7X, int q9E, string x7H, string Cf4)
		{
			Zf1 zf = (Zf1)NewRow();
			object[] array2 = (zf.ItemArray = new object[5] { p8N, j7X, q9E, x7H, Cf4 });
			base.Rows.Add(zf);
			return zf;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable d4X()
		{
			Xw8 xw = (Xw8)base.Clone();
			xw.c0Z();
			return xw;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable Tm2()
		{
			return new Xw8();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void c0Z()
		{
			columnuserid = base.Columns["userid"];
			columnusername = base.Columns["username"];
			columnbid = base.Columns["bid"];
			columnbname = base.Columns["bname"];
			columnaname = base.Columns["aname"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void m6A()
		{
			columnuserid = new DataColumn("userid", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnuserid);
			columnusername = new DataColumn("username", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnusername);
			columnbid = new DataColumn("bid", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnbid);
			columnbname = new DataColumn("bname", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnbname);
			columnaname = new DataColumn("aname", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnaname);
			columnuserid.MaxLength = 25;
			columnusername.MaxLength = 25;
			columnbname.MaxLength = 25;
			columnaname.MaxLength = 25;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Zf1 Ae3()
		{
			return (Zf1)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow j9E(DataRowBuilder i7Z)
		{
			return new Zf1(i7Z);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type Ts3()
		{
			return typeof(Zf1);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void x0Q(DataRowChangeEventArgs f7X)
		{
			base.OnRowChanged(f7X);
			if (borrowbookRowChangedEvent != null)
			{
				borrowbookRowChangedEvent?.Invoke(this, new Hf7((Zf1)f7X.Row, f7X.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void f9E(DataRowChangeEventArgs Rn8)
		{
			base.OnRowChanging(Rn8);
			if (borrowbookRowChangingEvent != null)
			{
				borrowbookRowChangingEvent?.Invoke(this, new Hf7((Zf1)Rn8.Row, Rn8.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void f2F(DataRowChangeEventArgs e2K)
		{
			base.OnRowDeleted(e2K);
			if (borrowbookRowDeletedEvent != null)
			{
				borrowbookRowDeletedEvent?.Invoke(this, new Hf7((Zf1)e2K.Row, e2K.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void Yn8(DataRowChangeEventArgs Ao7)
		{
			base.OnRowDeleting(Ao7);
			if (borrowbookRowDeletingEvent != null)
			{
				borrowbookRowDeletingEvent?.Invoke(this, new Hf7((Zf1)Ao7.Row, Ao7.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void z8Q(Zf1 Hq1)
		{
			base.Rows.Remove(Hq1);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType Ci6(XmlSchemaSet Jo1)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Ct6g ct6g = new Ct6g();
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
			xmlSchemaAttribute.FixedValue = ct6g.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "borrowbookDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema xmlSchema = ct6g.o7DZ();
			if (Jo1.Contains(xmlSchema.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema2 = null;
					xmlSchema.Write(memoryStream);
					IEnumerator enumerator = Jo1.Schemas(xmlSchema.TargetNamespace).GetEnumerator();
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
			Jo1.Add(xmlSchema);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class d5E : TypedTableBase<q2E>
	{
		private DataColumn columnluserid;

		private DataColumn columnlname;

		private DataColumn columnlpassword;

		private DataColumn columnborrow;

		private k8DA leacturelibloginRowChangingEvent;

		private k8DA leacturelibloginRowChangedEvent;

		private k8DA leacturelibloginRowDeletingEvent;

		private k8DA leacturelibloginRowDeletedEvent;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn luseridColumn => columnluserid;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn lnameColumn => columnlname;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn lpasswordColumn => columnlpassword;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn borrowColumn => columnborrow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		public int Count => base.Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public q2E this[int Bg7] => (q2E)base.Rows[Bg7];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event k8DA leacturelibloginRowChanging
		{
			add
			{
				k8DA k8DA = leacturelibloginRowChangingEvent;
				k8DA k8DA2;
				do
				{
					k8DA2 = k8DA;
					k8DA value2 = (k8DA)Delegate.Combine(k8DA2, value);
					k8DA = Interlocked.CompareExchange(ref leacturelibloginRowChangingEvent, value2, k8DA2);
				}
				while ((object)k8DA != k8DA2);
			}
			remove
			{
				k8DA k8DA = leacturelibloginRowChangingEvent;
				k8DA k8DA2;
				do
				{
					k8DA2 = k8DA;
					k8DA value2 = (k8DA)Delegate.Remove(k8DA2, value);
					k8DA = Interlocked.CompareExchange(ref leacturelibloginRowChangingEvent, value2, k8DA2);
				}
				while ((object)k8DA != k8DA2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event k8DA leacturelibloginRowChanged
		{
			add
			{
				k8DA k8DA = leacturelibloginRowChangedEvent;
				k8DA k8DA2;
				do
				{
					k8DA2 = k8DA;
					k8DA value2 = (k8DA)Delegate.Combine(k8DA2, value);
					k8DA = Interlocked.CompareExchange(ref leacturelibloginRowChangedEvent, value2, k8DA2);
				}
				while ((object)k8DA != k8DA2);
			}
			remove
			{
				k8DA k8DA = leacturelibloginRowChangedEvent;
				k8DA k8DA2;
				do
				{
					k8DA2 = k8DA;
					k8DA value2 = (k8DA)Delegate.Remove(k8DA2, value);
					k8DA = Interlocked.CompareExchange(ref leacturelibloginRowChangedEvent, value2, k8DA2);
				}
				while ((object)k8DA != k8DA2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event k8DA leacturelibloginRowDeleting
		{
			add
			{
				k8DA k8DA = leacturelibloginRowDeletingEvent;
				k8DA k8DA2;
				do
				{
					k8DA2 = k8DA;
					k8DA value2 = (k8DA)Delegate.Combine(k8DA2, value);
					k8DA = Interlocked.CompareExchange(ref leacturelibloginRowDeletingEvent, value2, k8DA2);
				}
				while ((object)k8DA != k8DA2);
			}
			remove
			{
				k8DA k8DA = leacturelibloginRowDeletingEvent;
				k8DA k8DA2;
				do
				{
					k8DA2 = k8DA;
					k8DA value2 = (k8DA)Delegate.Remove(k8DA2, value);
					k8DA = Interlocked.CompareExchange(ref leacturelibloginRowDeletingEvent, value2, k8DA2);
				}
				while ((object)k8DA != k8DA2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event k8DA leacturelibloginRowDeleted
		{
			add
			{
				k8DA k8DA = leacturelibloginRowDeletedEvent;
				k8DA k8DA2;
				do
				{
					k8DA2 = k8DA;
					k8DA value2 = (k8DA)Delegate.Combine(k8DA2, value);
					k8DA = Interlocked.CompareExchange(ref leacturelibloginRowDeletedEvent, value2, k8DA2);
				}
				while ((object)k8DA != k8DA2);
			}
			remove
			{
				k8DA k8DA = leacturelibloginRowDeletedEvent;
				k8DA k8DA2;
				do
				{
					k8DA2 = k8DA;
					k8DA value2 = (k8DA)Delegate.Remove(k8DA2, value);
					k8DA = Interlocked.CompareExchange(ref leacturelibloginRowDeletedEvent, value2, k8DA2);
				}
				while ((object)k8DA != k8DA2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public d5E()
		{
			base.TableName = "leactureliblogin";
			BeginInit();
			a7B();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal d5E(DataTable table)
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected d5E(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			Js2();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void k3X(q2E Xj2)
		{
			base.Rows.Add(Xj2);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public q2E o9F(string Qz2, string Zg0, string a6J, int Tq6)
		{
			q2E q2E = (q2E)NewRow();
			object[] array2 = (q2E.ItemArray = new object[4] { Qz2, Zg0, a6J, Tq6 });
			base.Rows.Add(q2E);
			return q2E;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public q2E Cg7(string k0A)
		{
			return (q2E)base.Rows.Find(new object[1] { k0A });
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable j2C()
		{
			d5E d5E = (d5E)base.Clone();
			d5E.Js2();
			return d5E;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable Bk9()
		{
			return new d5E();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void Js2()
		{
			columnluserid = base.Columns["luserid"];
			columnlname = base.Columns["lname"];
			columnlpassword = base.Columns["lpassword"];
			columnborrow = base.Columns["borrow"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void a7B()
		{
			columnluserid = new DataColumn("luserid", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnluserid);
			columnlname = new DataColumn("lname", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnlname);
			columnlpassword = new DataColumn("lpassword", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnlpassword);
			columnborrow = new DataColumn("borrow", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnborrow);
			base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[1] { columnluserid }, isPrimaryKey: true));
			columnluserid.AllowDBNull = false;
			columnluserid.Unique = true;
			columnluserid.MaxLength = 25;
			columnlname.MaxLength = 25;
			columnlpassword.MaxLength = 25;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public q2E o2Z()
		{
			return (q2E)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow Zt5(DataRowBuilder Es6)
		{
			return new q2E(Es6);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type Lk3()
		{
			return typeof(q2E);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void Hb9(DataRowChangeEventArgs q8L)
		{
			base.OnRowChanged(q8L);
			if (leacturelibloginRowChangedEvent != null)
			{
				leacturelibloginRowChangedEvent?.Invoke(this, new Gm9((q2E)q8L.Row, q8L.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void Zz6(DataRowChangeEventArgs m9T)
		{
			base.OnRowChanging(m9T);
			if (leacturelibloginRowChangingEvent != null)
			{
				leacturelibloginRowChangingEvent?.Invoke(this, new Gm9((q2E)m9T.Row, m9T.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void y3Y(DataRowChangeEventArgs Ki4)
		{
			base.OnRowDeleted(Ki4);
			if (leacturelibloginRowDeletedEvent != null)
			{
				leacturelibloginRowDeletedEvent?.Invoke(this, new Gm9((q2E)Ki4.Row, Ki4.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void Wd5(DataRowChangeEventArgs q7N)
		{
			base.OnRowDeleting(q7N);
			if (leacturelibloginRowDeletingEvent != null)
			{
				leacturelibloginRowDeletingEvent?.Invoke(this, new Gm9((q2E)q7N.Row, q7N.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void s4W(q2E Fs3)
		{
			base.Rows.Remove(Fs3);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType s3C(XmlSchemaSet Ry7)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Ct6g ct6g = new Ct6g();
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
			xmlSchemaAttribute.FixedValue = ct6g.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "leacturelibloginDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema xmlSchema = ct6g.o7DZ();
			if (Ry7.Contains(xmlSchema.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema2 = null;
					xmlSchema.Write(memoryStream);
					IEnumerator enumerator = Ry7.Schemas(xmlSchema.TargetNamespace).GetEnumerator();
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
			Ry7.Add(xmlSchema);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class m5F : TypedTableBase<w9R>
	{
		private DataColumn columnuname;

		private DataColumn columnpwd;

		private DataColumn columnpost;

		private DataColumn columnpermission;

		private j4BK loginRowChangingEvent;

		private j4BK loginRowChangedEvent;

		private j4BK loginRowDeletingEvent;

		private j4BK loginRowDeletedEvent;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn unameColumn => columnuname;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn pwdColumn => columnpwd;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn postColumn => columnpost;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn permissionColumn => columnpermission;

		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int Count => base.Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public w9R this[int q9L] => (w9R)base.Rows[q9L];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event j4BK loginRowChanging
		{
			add
			{
				j4BK j4BK = loginRowChangingEvent;
				j4BK j4BK2;
				do
				{
					j4BK2 = j4BK;
					j4BK value2 = (j4BK)Delegate.Combine(j4BK2, value);
					j4BK = Interlocked.CompareExchange(ref loginRowChangingEvent, value2, j4BK2);
				}
				while ((object)j4BK != j4BK2);
			}
			remove
			{
				j4BK j4BK = loginRowChangingEvent;
				j4BK j4BK2;
				do
				{
					j4BK2 = j4BK;
					j4BK value2 = (j4BK)Delegate.Remove(j4BK2, value);
					j4BK = Interlocked.CompareExchange(ref loginRowChangingEvent, value2, j4BK2);
				}
				while ((object)j4BK != j4BK2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event j4BK loginRowChanged
		{
			add
			{
				j4BK j4BK = loginRowChangedEvent;
				j4BK j4BK2;
				do
				{
					j4BK2 = j4BK;
					j4BK value2 = (j4BK)Delegate.Combine(j4BK2, value);
					j4BK = Interlocked.CompareExchange(ref loginRowChangedEvent, value2, j4BK2);
				}
				while ((object)j4BK != j4BK2);
			}
			remove
			{
				j4BK j4BK = loginRowChangedEvent;
				j4BK j4BK2;
				do
				{
					j4BK2 = j4BK;
					j4BK value2 = (j4BK)Delegate.Remove(j4BK2, value);
					j4BK = Interlocked.CompareExchange(ref loginRowChangedEvent, value2, j4BK2);
				}
				while ((object)j4BK != j4BK2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event j4BK loginRowDeleting
		{
			add
			{
				j4BK j4BK = loginRowDeletingEvent;
				j4BK j4BK2;
				do
				{
					j4BK2 = j4BK;
					j4BK value2 = (j4BK)Delegate.Combine(j4BK2, value);
					j4BK = Interlocked.CompareExchange(ref loginRowDeletingEvent, value2, j4BK2);
				}
				while ((object)j4BK != j4BK2);
			}
			remove
			{
				j4BK j4BK = loginRowDeletingEvent;
				j4BK j4BK2;
				do
				{
					j4BK2 = j4BK;
					j4BK value2 = (j4BK)Delegate.Remove(j4BK2, value);
					j4BK = Interlocked.CompareExchange(ref loginRowDeletingEvent, value2, j4BK2);
				}
				while ((object)j4BK != j4BK2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event j4BK loginRowDeleted
		{
			add
			{
				j4BK j4BK = loginRowDeletedEvent;
				j4BK j4BK2;
				do
				{
					j4BK2 = j4BK;
					j4BK value2 = (j4BK)Delegate.Combine(j4BK2, value);
					j4BK = Interlocked.CompareExchange(ref loginRowDeletedEvent, value2, j4BK2);
				}
				while ((object)j4BK != j4BK2);
			}
			remove
			{
				j4BK j4BK = loginRowDeletedEvent;
				j4BK j4BK2;
				do
				{
					j4BK2 = j4BK;
					j4BK value2 = (j4BK)Delegate.Remove(j4BK2, value);
					j4BK = Interlocked.CompareExchange(ref loginRowDeletedEvent, value2, j4BK2);
				}
				while ((object)j4BK != j4BK2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public m5F()
		{
			base.TableName = "login";
			BeginInit();
			j7K();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal m5F(DataTable table)
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected m5F(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			d5A();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void o8Y(w9R Kj5)
		{
			base.Rows.Add(Kj5);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public w9R c9T(string p5B, string o9W, string Sg1, string Ce2)
		{
			w9R w9R = (w9R)NewRow();
			object[] array2 = (w9R.ItemArray = new object[4] { p5B, o9W, Sg1, Ce2 });
			base.Rows.Add(w9R);
			return w9R;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public w9R x3W(string Dk4)
		{
			return (w9R)base.Rows.Find(new object[1] { Dk4 });
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Xp0()
		{
			m5F m5F = (m5F)base.Clone();
			m5F.d5A();
			return m5F;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable a9H()
		{
			return new m5F();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void d5A()
		{
			columnuname = base.Columns["uname"];
			columnpwd = base.Columns["pwd"];
			columnpost = base.Columns["post"];
			columnpermission = base.Columns["permission"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void j7K()
		{
			columnuname = new DataColumn("uname", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnuname);
			columnpwd = new DataColumn("pwd", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnpwd);
			columnpost = new DataColumn("post", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnpost);
			columnpermission = new DataColumn("permission", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnpermission);
			base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[1] { columnuname }, isPrimaryKey: true));
			columnuname.AllowDBNull = false;
			columnuname.Unique = true;
			columnuname.MaxLength = 25;
			columnpwd.MaxLength = 32;
			columnpost.MaxLength = 15;
			columnpermission.MaxLength = 15;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public w9R Fm2()
		{
			return (w9R)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow r6G(DataRowBuilder Qs9)
		{
			return new w9R(Qs9);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type a6E()
		{
			return typeof(w9R);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void Nr1(DataRowChangeEventArgs f6Q)
		{
			base.OnRowChanged(f6Q);
			if (loginRowChangedEvent != null)
			{
				loginRowChangedEvent?.Invoke(this, new Xa4((w9R)f6Q.Row, f6Q.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void p7E(DataRowChangeEventArgs m2K)
		{
			base.OnRowChanging(m2K);
			if (loginRowChangingEvent != null)
			{
				loginRowChangingEvent?.Invoke(this, new Xa4((w9R)m2K.Row, m2K.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void t3Y(DataRowChangeEventArgs s2S)
		{
			base.OnRowDeleted(s2S);
			if (loginRowDeletedEvent != null)
			{
				loginRowDeletedEvent?.Invoke(this, new Xa4((w9R)s2S.Row, s2S.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void m4G(DataRowChangeEventArgs d2M)
		{
			base.OnRowDeleting(d2M);
			if (loginRowDeletingEvent != null)
			{
				loginRowDeletingEvent?.Invoke(this, new Xa4((w9R)d2M.Row, d2M.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void z0A(w9R c5Q)
		{
			base.Rows.Remove(c5Q);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType Lj9(XmlSchemaSet t2Q)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Ct6g ct6g = new Ct6g();
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
			xmlSchemaAttribute.FixedValue = ct6g.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "loginDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema xmlSchema = ct6g.o7DZ();
			if (t2Q.Contains(xmlSchema.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema2 = null;
					xmlSchema.Write(memoryStream);
					IEnumerator enumerator = t2Q.Schemas(xmlSchema.TargetNamespace).GetEnumerator();
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
			t2Q.Add(xmlSchema);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class d1P : TypedTableBase<f7L>
	{
		private DataColumn columnstduserid;

		private DataColumn columnstdname;

		private DataColumn columnstdpassword;

		private DataColumn columnborrow;

		private e4R7 studentlibloginRowChangingEvent;

		private e4R7 studentlibloginRowChangedEvent;

		private e4R7 studentlibloginRowDeletingEvent;

		private e4R7 studentlibloginRowDeletedEvent;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn stduseridColumn => columnstduserid;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn stdnameColumn => columnstdname;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn stdpasswordColumn => columnstdpassword;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn borrowColumn => columnborrow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		public int Count => base.Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public f7L this[int Wp7] => (f7L)base.Rows[Wp7];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event e4R7 studentlibloginRowChanging
		{
			add
			{
				e4R7 e4R = studentlibloginRowChangingEvent;
				e4R7 e4R2;
				do
				{
					e4R2 = e4R;
					e4R7 value2 = (e4R7)Delegate.Combine(e4R2, value);
					e4R = Interlocked.CompareExchange(ref studentlibloginRowChangingEvent, value2, e4R2);
				}
				while ((object)e4R != e4R2);
			}
			remove
			{
				e4R7 e4R = studentlibloginRowChangingEvent;
				e4R7 e4R2;
				do
				{
					e4R2 = e4R;
					e4R7 value2 = (e4R7)Delegate.Remove(e4R2, value);
					e4R = Interlocked.CompareExchange(ref studentlibloginRowChangingEvent, value2, e4R2);
				}
				while ((object)e4R != e4R2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event e4R7 studentlibloginRowChanged
		{
			add
			{
				e4R7 e4R = studentlibloginRowChangedEvent;
				e4R7 e4R2;
				do
				{
					e4R2 = e4R;
					e4R7 value2 = (e4R7)Delegate.Combine(e4R2, value);
					e4R = Interlocked.CompareExchange(ref studentlibloginRowChangedEvent, value2, e4R2);
				}
				while ((object)e4R != e4R2);
			}
			remove
			{
				e4R7 e4R = studentlibloginRowChangedEvent;
				e4R7 e4R2;
				do
				{
					e4R2 = e4R;
					e4R7 value2 = (e4R7)Delegate.Remove(e4R2, value);
					e4R = Interlocked.CompareExchange(ref studentlibloginRowChangedEvent, value2, e4R2);
				}
				while ((object)e4R != e4R2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event e4R7 studentlibloginRowDeleting
		{
			add
			{
				e4R7 e4R = studentlibloginRowDeletingEvent;
				e4R7 e4R2;
				do
				{
					e4R2 = e4R;
					e4R7 value2 = (e4R7)Delegate.Combine(e4R2, value);
					e4R = Interlocked.CompareExchange(ref studentlibloginRowDeletingEvent, value2, e4R2);
				}
				while ((object)e4R != e4R2);
			}
			remove
			{
				e4R7 e4R = studentlibloginRowDeletingEvent;
				e4R7 e4R2;
				do
				{
					e4R2 = e4R;
					e4R7 value2 = (e4R7)Delegate.Remove(e4R2, value);
					e4R = Interlocked.CompareExchange(ref studentlibloginRowDeletingEvent, value2, e4R2);
				}
				while ((object)e4R != e4R2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event e4R7 studentlibloginRowDeleted
		{
			add
			{
				e4R7 e4R = studentlibloginRowDeletedEvent;
				e4R7 e4R2;
				do
				{
					e4R2 = e4R;
					e4R7 value2 = (e4R7)Delegate.Combine(e4R2, value);
					e4R = Interlocked.CompareExchange(ref studentlibloginRowDeletedEvent, value2, e4R2);
				}
				while ((object)e4R != e4R2);
			}
			remove
			{
				e4R7 e4R = studentlibloginRowDeletedEvent;
				e4R7 e4R2;
				do
				{
					e4R2 = e4R;
					e4R7 value2 = (e4R7)Delegate.Remove(e4R2, value);
					e4R = Interlocked.CompareExchange(ref studentlibloginRowDeletedEvent, value2, e4R2);
				}
				while ((object)e4R != e4R2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public d1P()
		{
			base.TableName = "studentliblogin";
			BeginInit();
			Tx6();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal d1P(DataTable table)
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected d1P(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			k1A();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void c2Q(f7L d8T)
		{
			base.Rows.Add(d8T);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public f7L s3M(string An6, string Zq5, string d4J, int Zf2)
		{
			f7L f7L = (f7L)NewRow();
			object[] array2 = (f7L.ItemArray = new object[4] { An6, Zq5, d4J, Zf2 });
			base.Rows.Add(f7L);
			return f7L;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public f7L Cf2(string Aw5)
		{
			return (f7L)base.Rows.Find(new object[1] { Aw5 });
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Sr5()
		{
			d1P d1P = (d1P)base.Clone();
			d1P.k1A();
			return d1P;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable i7M()
		{
			return new d1P();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void k1A()
		{
			columnstduserid = base.Columns["stduserid"];
			columnstdname = base.Columns["stdname"];
			columnstdpassword = base.Columns["stdpassword"];
			columnborrow = base.Columns["borrow"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void Tx6()
		{
			columnstduserid = new DataColumn("stduserid", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnstduserid);
			columnstdname = new DataColumn("stdname", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnstdname);
			columnstdpassword = new DataColumn("stdpassword", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnstdpassword);
			columnborrow = new DataColumn("borrow", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnborrow);
			base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[1] { columnstduserid }, isPrimaryKey: true));
			columnstduserid.AllowDBNull = false;
			columnstduserid.Unique = true;
			columnstduserid.MaxLength = 25;
			columnstdname.MaxLength = 25;
			columnstdpassword.MaxLength = 25;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public f7L g4R()
		{
			return (f7L)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow s3S(DataRowBuilder k0Y)
		{
			return new f7L(k0Y);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type Fa5()
		{
			return typeof(f7L);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void Hs9(DataRowChangeEventArgs k7Z)
		{
			base.OnRowChanged(k7Z);
			if (studentlibloginRowChangedEvent != null)
			{
				studentlibloginRowChangedEvent?.Invoke(this, new Qq6((f7L)k7Z.Row, k7Z.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void c5D(DataRowChangeEventArgs Ke1)
		{
			base.OnRowChanging(Ke1);
			if (studentlibloginRowChangingEvent != null)
			{
				studentlibloginRowChangingEvent?.Invoke(this, new Qq6((f7L)Ke1.Row, Ke1.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void Py8(DataRowChangeEventArgs w4Q)
		{
			base.OnRowDeleted(w4Q);
			if (studentlibloginRowDeletedEvent != null)
			{
				studentlibloginRowDeletedEvent?.Invoke(this, new Qq6((f7L)w4Q.Row, w4Q.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void r1P(DataRowChangeEventArgs q4Z)
		{
			base.OnRowDeleting(q4Z);
			if (studentlibloginRowDeletingEvent != null)
			{
				studentlibloginRowDeletingEvent?.Invoke(this, new Qq6((f7L)q4Z.Row, q4Z.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Ek1(f7L e9H)
		{
			base.Rows.Remove(e9H);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType Xq4(XmlSchemaSet Kq9)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Ct6g ct6g = new Ct6g();
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
			xmlSchemaAttribute.FixedValue = ct6g.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "studentlibloginDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema xmlSchema = ct6g.o7DZ();
			if (Kq9.Contains(xmlSchema.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema2 = null;
					xmlSchema.Write(memoryStream);
					IEnumerator enumerator = Kq9.Schemas(xmlSchema.TargetNamespace).GetEnumerator();
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
			Kq9.Add(xmlSchema);
			return xmlSchemaComplexType;
		}
	}

	public class Xi9 : DataRow
	{
		private m2R4 tablebooks;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int bnum
		{
			get
			{
				return Conversions.ToInteger(base[tablebooks.bnumColumn]);
			}
			set
			{
				base[tablebooks.bnumColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string bname
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tablebooks.bnameColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'bname' in table 'books' is DBNull.", innerException);
				}
			}
			set
			{
				base[tablebooks.bnameColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string authorName
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tablebooks.authorNameColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'authorName' in table 'books' is DBNull.", innerException);
				}
			}
			set
			{
				base[tablebooks.authorNameColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int numberOfCopies
		{
			get
			{
				try
				{
					return Conversions.ToInteger(base[tablebooks.numberOfCopiesColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'numberOfCopies' in table 'books' is DBNull.", innerException);
				}
			}
			set
			{
				base[tablebooks.numberOfCopiesColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Xi9(DataRowBuilder rb)
			: base(rb)
		{
			tablebooks = (m2R4)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool c1B()
		{
			return IsNull(tablebooks.bnameColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Ey3()
		{
			base[tablebooks.bnameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool g2Z()
		{
			return IsNull(tablebooks.authorNameColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void p6C()
		{
			base[tablebooks.authorNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool o8L()
		{
			return IsNull(tablebooks.numberOfCopiesColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Xg1()
		{
			base[tablebooks.numberOfCopiesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	public class Zf1 : DataRow
	{
		private Xw8 tableborrowbook;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string userid
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableborrowbook.useridColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'userid' in table 'borrowbook' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableborrowbook.useridColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string username
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableborrowbook.usernameColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'username' in table 'borrowbook' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableborrowbook.usernameColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int bid
		{
			get
			{
				try
				{
					return Conversions.ToInteger(base[tableborrowbook.bidColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'bid' in table 'borrowbook' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableborrowbook.bidColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string bname
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableborrowbook.bnameColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'bname' in table 'borrowbook' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableborrowbook.bnameColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string aname
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableborrowbook.anameColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'aname' in table 'borrowbook' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableborrowbook.anameColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Zf1(DataRowBuilder rb)
			: base(rb)
		{
			tableborrowbook = (Xw8)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool y7B()
		{
			return IsNull(tableborrowbook.useridColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void y5A()
		{
			base[tableborrowbook.useridColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Rq9()
		{
			return IsNull(tableborrowbook.usernameColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void s2H()
		{
			base[tableborrowbook.usernameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Gj7()
		{
			return IsNull(tableborrowbook.bidColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Qe7()
		{
			base[tableborrowbook.bidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Gr9()
		{
			return IsNull(tableborrowbook.bnameColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void j5K()
		{
			base[tableborrowbook.bnameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool n8P()
		{
			return IsNull(tableborrowbook.anameColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void x7J()
		{
			base[tableborrowbook.anameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	public class q2E : DataRow
	{
		private d5E tableleactureliblogin;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string luserid
		{
			get
			{
				return Conversions.ToString(base[tableleactureliblogin.luseridColumn]);
			}
			set
			{
				base[tableleactureliblogin.luseridColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string lname
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableleactureliblogin.lnameColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'lname' in table 'leactureliblogin' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableleactureliblogin.lnameColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string lpassword
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableleactureliblogin.lpasswordColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'lpassword' in table 'leactureliblogin' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableleactureliblogin.lpasswordColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int borrow
		{
			get
			{
				try
				{
					return Conversions.ToInteger(base[tableleactureliblogin.borrowColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'borrow' in table 'leactureliblogin' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableleactureliblogin.borrowColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal q2E(DataRowBuilder rb)
			: base(rb)
		{
			tableleactureliblogin = (d5E)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Ho9()
		{
			return IsNull(tableleactureliblogin.lnameColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void p6T()
		{
			base[tableleactureliblogin.lnameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool m6J()
		{
			return IsNull(tableleactureliblogin.lpasswordColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void j2G()
		{
			base[tableleactureliblogin.lpasswordColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool p6C()
		{
			return IsNull(tableleactureliblogin.borrowColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void d7P()
		{
			base[tableleactureliblogin.borrowColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	public class w9R : DataRow
	{
		private m5F tablelogin;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string uname
		{
			get
			{
				return Conversions.ToString(base[tablelogin.unameColumn]);
			}
			set
			{
				base[tablelogin.unameColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string pwd
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tablelogin.pwdColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'pwd' in table 'login' is DBNull.", innerException);
				}
			}
			set
			{
				base[tablelogin.pwdColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string post
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tablelogin.postColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'post' in table 'login' is DBNull.", innerException);
				}
			}
			set
			{
				base[tablelogin.postColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string permission
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tablelogin.permissionColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'permission' in table 'login' is DBNull.", innerException);
				}
			}
			set
			{
				base[tablelogin.permissionColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal w9R(DataRowBuilder rb)
			: base(rb)
		{
			tablelogin = (m5F)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Mr3()
		{
			return IsNull(tablelogin.pwdColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void r6N()
		{
			base[tablelogin.pwdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool r6Y()
		{
			return IsNull(tablelogin.postColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Bz7()
		{
			base[tablelogin.postColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool z4W()
		{
			return IsNull(tablelogin.permissionColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void d4Q()
		{
			base[tablelogin.permissionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	public class f7L : DataRow
	{
		private d1P tablestudentliblogin;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string stduserid
		{
			get
			{
				return Conversions.ToString(base[tablestudentliblogin.stduseridColumn]);
			}
			set
			{
				base[tablestudentliblogin.stduseridColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string stdname
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tablestudentliblogin.stdnameColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'stdname' in table 'studentliblogin' is DBNull.", innerException);
				}
			}
			set
			{
				base[tablestudentliblogin.stdnameColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string stdpassword
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tablestudentliblogin.stdpasswordColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'stdpassword' in table 'studentliblogin' is DBNull.", innerException);
				}
			}
			set
			{
				base[tablestudentliblogin.stdpasswordColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int borrow
		{
			get
			{
				try
				{
					return Conversions.ToInteger(base[tablestudentliblogin.borrowColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'borrow' in table 'studentliblogin' is DBNull.", innerException);
				}
			}
			set
			{
				base[tablestudentliblogin.borrowColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal f7L(DataRowBuilder rb)
			: base(rb)
		{
			tablestudentliblogin = (d1P)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Xj9()
		{
			return IsNull(tablestudentliblogin.stdnameColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Tj8()
		{
			base[tablestudentliblogin.stdnameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Kj8()
		{
			return IsNull(tablestudentliblogin.stdpasswordColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void r1K()
		{
			base[tablestudentliblogin.stdpasswordColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Dy7()
		{
			return IsNull(tablestudentliblogin.borrowColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Fa4()
		{
			base[tablestudentliblogin.borrowColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class Wi4 : EventArgs
	{
		private Xi9 eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Xi9 Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Wi4(Xi9 row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class Hf7 : EventArgs
	{
		private Zf1 eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Zf1 Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Hf7(Zf1 row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class Gm9 : EventArgs
	{
		private q2E eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public q2E Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Gm9(q2E row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class Xa4 : EventArgs
	{
		private w9R eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public w9R Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Xa4(w9R row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class Qq6 : EventArgs
	{
		private f7L eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public f7L Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Qq6(f7L row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	private m2R4 tablebooks;

	private Xw8 tableborrowbook;

	private d5E tableleactureliblogin;

	private m5F tablelogin;

	private d1P tablestudentliblogin;

	private SchemaSerializationMode _schemaSerializationMode;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[Browsable(false)]
	public m2R4 books => tablebooks;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public Xw8 borrowbook => tableborrowbook;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	public d5E leactureliblogin => tableleactureliblogin;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[Browsable(false)]
	public m5F login => tablelogin;

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public d1P studentliblogin => tablestudentliblogin;

	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public new DataTableCollection Tables => base.Tables;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public new DataRelationCollection Relations => base.Relations;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public Ct6g()
	{
		_schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		BeginInit();
		Rj01();
		CollectionChangeEventHandler value = Bn9j;
		base.Tables.CollectionChanged += value;
		base.Relations.CollectionChanged += value;
		EndInit();
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected Ct6g(SerializationInfo info, StreamingContext context)
		: base(info, context, ConstructSchema: false)
	{
		_schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		if (IsBinarySerialized(info, context))
		{
			Jp6f(Fa51: false);
			CollectionChangeEventHandler value = Bn9j;
			Tables.CollectionChanged += value;
			Relations.CollectionChanged += value;
			return;
		}
		string s = Conversions.ToString(info.GetValue("XmlSchema", typeof(string)));
		if (DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
		{
			DataSet dataSet = new DataSet();
			dataSet.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
			if (dataSet.Tables["books"] != null)
			{
				base.Tables.Add(new m2R4(dataSet.Tables["books"]));
			}
			if (dataSet.Tables["borrowbook"] != null)
			{
				base.Tables.Add(new Xw8(dataSet.Tables["borrowbook"]));
			}
			if (dataSet.Tables["leactureliblogin"] != null)
			{
				base.Tables.Add(new d5E(dataSet.Tables["leactureliblogin"]));
			}
			if (dataSet.Tables["login"] != null)
			{
				base.Tables.Add(new m5F(dataSet.Tables["login"]));
			}
			if (dataSet.Tables["studentliblogin"] != null)
			{
				base.Tables.Add(new d1P(dataSet.Tables["studentliblogin"]));
			}
			base.DataSetName = dataSet.DataSetName;
			base.Prefix = dataSet.Prefix;
			base.Namespace = dataSet.Namespace;
			base.Locale = dataSet.Locale;
			base.CaseSensitive = dataSet.CaseSensitive;
			base.EnforceConstraints = dataSet.EnforceConstraints;
			Merge(dataSet, preserveChanges: false, MissingSchemaAction.Add);
			p8Q7();
		}
		else
		{
			ReadXmlSchema(new XmlTextReader(new StringReader(s)));
		}
		GetSerializationData(info, context);
		CollectionChangeEventHandler value2 = Bn9j;
		base.Tables.CollectionChanged += value2;
		Relations.CollectionChanged += value2;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected override void Gc5w()
	{
		BeginInit();
		Rj01();
		EndInit();
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public override DataSet Ks7q()
	{
		Ct6g ct6g = (Ct6g)base.Clone();
		ct6g.p8Q7();
		ct6g.SchemaSerializationMode = SchemaSerializationMode;
		return ct6g;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected override bool Bi3f()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected override bool Ft85()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected override void z1Q4(XmlReader m2FK)
	{
		if (DetermineSchemaSerializationMode(m2FK) == SchemaSerializationMode.IncludeSchema)
		{
			Reset();
			DataSet dataSet = new DataSet();
			dataSet.ReadXml(m2FK);
			if (dataSet.Tables["books"] != null)
			{
				base.Tables.Add(new m2R4(dataSet.Tables["books"]));
			}
			if (dataSet.Tables["borrowbook"] != null)
			{
				base.Tables.Add(new Xw8(dataSet.Tables["borrowbook"]));
			}
			if (dataSet.Tables["leactureliblogin"] != null)
			{
				base.Tables.Add(new d5E(dataSet.Tables["leactureliblogin"]));
			}
			if (dataSet.Tables["login"] != null)
			{
				base.Tables.Add(new m5F(dataSet.Tables["login"]));
			}
			if (dataSet.Tables["studentliblogin"] != null)
			{
				base.Tables.Add(new d1P(dataSet.Tables["studentliblogin"]));
			}
			base.DataSetName = dataSet.DataSetName;
			base.Prefix = dataSet.Prefix;
			base.Namespace = dataSet.Namespace;
			base.Locale = dataSet.Locale;
			base.CaseSensitive = dataSet.CaseSensitive;
			base.EnforceConstraints = dataSet.EnforceConstraints;
			Merge(dataSet, preserveChanges: false, MissingSchemaAction.Add);
			p8Q7();
		}
		else
		{
			ReadXml(m2FK);
			p8Q7();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected override XmlSchema o7DZ()
	{
		MemoryStream memoryStream = new MemoryStream();
		WriteXmlSchema(new XmlTextWriter(memoryStream, null));
		memoryStream.Position = 0L;
		return XmlSchema.Read(new XmlTextReader(memoryStream), null);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	internal void p8Q7()
	{
		Jp6f(Fa51: true);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	internal void Jp6f(bool Fa51)
	{
		tablebooks = (m2R4)base.Tables["books"];
		if (Fa51 && tablebooks != null)
		{
			tablebooks.z9Y();
		}
		tableborrowbook = (Xw8)base.Tables["borrowbook"];
		if (Fa51 && tableborrowbook != null)
		{
			tableborrowbook.c0Z();
		}
		tableleactureliblogin = (d5E)base.Tables["leactureliblogin"];
		if (Fa51 && tableleactureliblogin != null)
		{
			tableleactureliblogin.Js2();
		}
		tablelogin = (m5F)base.Tables["login"];
		if (Fa51 && tablelogin != null)
		{
			tablelogin.d5A();
		}
		tablestudentliblogin = (d1P)base.Tables["studentliblogin"];
		if (Fa51 && tablestudentliblogin != null)
		{
			tablestudentliblogin.k1A();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void Rj01()
	{
		base.DataSetName = "libraryDataSet1";
		base.Prefix = "";
		base.Namespace = "http://tempuri.org/libraryDataSet1.xsd";
		base.EnforceConstraints = true;
		SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		tablebooks = new m2R4();
		base.Tables.Add(tablebooks);
		tableborrowbook = new Xw8();
		base.Tables.Add(tableborrowbook);
		tableleactureliblogin = new d5E();
		base.Tables.Add(tableleactureliblogin);
		tablelogin = new m5F();
		base.Tables.Add(tablelogin);
		tablestudentliblogin = new d1P();
		base.Tables.Add(tablestudentliblogin);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool Ck0e()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool Po2d()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool Te7z()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool Ya65()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool Dc13()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void Bn9j(object sender, CollectionChangeEventArgs e)
	{
		if (e.Action == CollectionChangeAction.Remove)
		{
			p8Q7();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public static XmlSchemaComplexType Dq78(XmlSchemaSet Db50)
	{
		Ct6g ct6g = new Ct6g();
		XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
		XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
		XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
		xmlSchemaAny.Namespace = ct6g.Namespace;
		xmlSchemaSequence.Items.Add(xmlSchemaAny);
		xmlSchemaComplexType.Particle = xmlSchemaSequence;
		XmlSchema xmlSchema = ct6g.o7DZ();
		if (Db50.Contains(xmlSchema.TargetNamespace))
		{
			MemoryStream memoryStream = new MemoryStream();
			MemoryStream memoryStream2 = new MemoryStream();
			try
			{
				XmlSchema xmlSchema2 = null;
				xmlSchema.Write(memoryStream);
				IEnumerator enumerator = Db50.Schemas(xmlSchema.TargetNamespace).GetEnumerator();
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
		Db50.Add(xmlSchema);
		return xmlSchemaComplexType;
	}
}
