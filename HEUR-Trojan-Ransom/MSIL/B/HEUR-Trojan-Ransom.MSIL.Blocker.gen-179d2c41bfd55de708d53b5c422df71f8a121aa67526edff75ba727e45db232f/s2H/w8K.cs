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

namespace s2H;

[Serializable]
[XmlRoot("libraryDataSet")]
[DesignerCategory("code")]
[HelpKeyword("vs.data.DataSet")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
public class w8K : DataSet
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void b1F(object sender, Gz14 e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void Xy8(object sender, Ec38 e);

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class c7E : TypedTableBase<Sk0>
	{
		private DataColumn columnbnum;

		private DataColumn columnbname;

		private DataColumn columnauthorName;

		private DataColumn columnnumberOfCopies;

		private b1F booksRowChangingEvent;

		private b1F booksRowChangedEvent;

		private b1F booksRowDeletingEvent;

		private b1F booksRowDeletedEvent;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn bnumColumn => columnbnum;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn bnameColumn => columnbname;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn authorNameColumn => columnauthorName;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn numberOfCopiesColumn => columnnumberOfCopies;

		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int Count => base.Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Sk0 this[int Et9] => (Sk0)base.Rows[Et9];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event b1F booksRowChanging
		{
			add
			{
				b1F b1F = booksRowChangingEvent;
				b1F b1F2;
				do
				{
					b1F2 = b1F;
					b1F value2 = (b1F)Delegate.Combine(b1F2, value);
					b1F = Interlocked.CompareExchange(ref booksRowChangingEvent, value2, b1F2);
				}
				while ((object)b1F != b1F2);
			}
			remove
			{
				b1F b1F = booksRowChangingEvent;
				b1F b1F2;
				do
				{
					b1F2 = b1F;
					b1F value2 = (b1F)Delegate.Remove(b1F2, value);
					b1F = Interlocked.CompareExchange(ref booksRowChangingEvent, value2, b1F2);
				}
				while ((object)b1F != b1F2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event b1F booksRowChanged
		{
			add
			{
				b1F b1F = booksRowChangedEvent;
				b1F b1F2;
				do
				{
					b1F2 = b1F;
					b1F value2 = (b1F)Delegate.Combine(b1F2, value);
					b1F = Interlocked.CompareExchange(ref booksRowChangedEvent, value2, b1F2);
				}
				while ((object)b1F != b1F2);
			}
			remove
			{
				b1F b1F = booksRowChangedEvent;
				b1F b1F2;
				do
				{
					b1F2 = b1F;
					b1F value2 = (b1F)Delegate.Remove(b1F2, value);
					b1F = Interlocked.CompareExchange(ref booksRowChangedEvent, value2, b1F2);
				}
				while ((object)b1F != b1F2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event b1F booksRowDeleting
		{
			add
			{
				b1F b1F = booksRowDeletingEvent;
				b1F b1F2;
				do
				{
					b1F2 = b1F;
					b1F value2 = (b1F)Delegate.Combine(b1F2, value);
					b1F = Interlocked.CompareExchange(ref booksRowDeletingEvent, value2, b1F2);
				}
				while ((object)b1F != b1F2);
			}
			remove
			{
				b1F b1F = booksRowDeletingEvent;
				b1F b1F2;
				do
				{
					b1F2 = b1F;
					b1F value2 = (b1F)Delegate.Remove(b1F2, value);
					b1F = Interlocked.CompareExchange(ref booksRowDeletingEvent, value2, b1F2);
				}
				while ((object)b1F != b1F2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event b1F booksRowDeleted
		{
			add
			{
				b1F b1F = booksRowDeletedEvent;
				b1F b1F2;
				do
				{
					b1F2 = b1F;
					b1F value2 = (b1F)Delegate.Combine(b1F2, value);
					b1F = Interlocked.CompareExchange(ref booksRowDeletedEvent, value2, b1F2);
				}
				while ((object)b1F != b1F2);
			}
			remove
			{
				b1F b1F = booksRowDeletedEvent;
				b1F b1F2;
				do
				{
					b1F2 = b1F;
					b1F value2 = (b1F)Delegate.Remove(b1F2, value);
					b1F = Interlocked.CompareExchange(ref booksRowDeletedEvent, value2, b1F2);
				}
				while ((object)b1F != b1F2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public c7E()
		{
			base.TableName = "books";
			BeginInit();
			z6F();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal c7E(DataTable table)
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
		protected c7E(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			Pi7();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Rs6(Sk0 o3G)
		{
			base.Rows.Add(o3G);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Sk0 Lq0(int x7D, string Pb9, string s3X, int b8B)
		{
			Sk0 sk = (Sk0)NewRow();
			object[] array2 = (sk.ItemArray = new object[4] { x7D, Pb9, s3X, b8B });
			base.Rows.Add(sk);
			return sk;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Sk0 Bf6(int Gy5)
		{
			return (Sk0)base.Rows.Find(new object[1] { Gy5 });
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Zx9()
		{
			c7E c7E = (c7E)base.Clone();
			c7E.Pi7();
			return c7E;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable De9()
		{
			return new c7E();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void Pi7()
		{
			columnbnum = base.Columns["bnum"];
			columnbname = base.Columns["bname"];
			columnauthorName = base.Columns["authorName"];
			columnnumberOfCopies = base.Columns["numberOfCopies"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void z6F()
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
		public Sk0 Fe8()
		{
			return (Sk0)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow t2Y(DataRowBuilder c6Y)
		{
			return new Sk0(c6Y);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type Ec5()
		{
			return typeof(Sk0);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void e2H(DataRowChangeEventArgs k1N)
		{
			base.OnRowChanged(k1N);
			if (booksRowChangedEvent != null)
			{
				booksRowChangedEvent?.Invoke(this, new Gz14((Sk0)k1N.Row, k1N.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void x8X(DataRowChangeEventArgs b8N)
		{
			base.OnRowChanging(b8N);
			if (booksRowChangingEvent != null)
			{
				booksRowChangingEvent?.Invoke(this, new Gz14((Sk0)b8N.Row, b8N.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void Xp0(DataRowChangeEventArgs a5Y)
		{
			base.OnRowDeleted(a5Y);
			if (booksRowDeletedEvent != null)
			{
				booksRowDeletedEvent?.Invoke(this, new Gz14((Sk0)a5Y.Row, a5Y.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void d3R(DataRowChangeEventArgs Fi4)
		{
			base.OnRowDeleting(Fi4);
			if (booksRowDeletingEvent != null)
			{
				booksRowDeletingEvent?.Invoke(this, new Gz14((Sk0)Fi4.Row, Fi4.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void a3T(Sk0 o5J)
		{
			base.Rows.Remove(o5J);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType c7Z(XmlSchemaSet Hy4)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			w8K w8K2 = new w8K();
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
			xmlSchemaAttribute.FixedValue = w8K2.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "booksDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema xmlSchema = w8K2.m1Y();
			if (Hy4.Contains(xmlSchema.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema2 = null;
					xmlSchema.Write(memoryStream);
					IEnumerator enumerator = Hy4.Schemas(xmlSchema.TargetNamespace).GetEnumerator();
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
			Hy4.Add(xmlSchema);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class m0K : TypedTableBase<Kg4>
	{
		private DataColumn columnuname;

		private DataColumn columnpwd;

		private DataColumn columnpost;

		private DataColumn columnpermission;

		private Xy8 loginRowChangingEvent;

		private Xy8 loginRowChangedEvent;

		private Xy8 loginRowDeletingEvent;

		private Xy8 loginRowDeletedEvent;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn unameColumn => columnuname;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn pwdColumn => columnpwd;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn postColumn => columnpost;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn permissionColumn => columnpermission;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		public int Count => base.Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Kg4 this[int Gq2] => (Kg4)base.Rows[Gq2];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Xy8 loginRowChanging
		{
			add
			{
				Xy8 xy = loginRowChangingEvent;
				Xy8 xy2;
				do
				{
					xy2 = xy;
					Xy8 value2 = (Xy8)Delegate.Combine(xy2, value);
					xy = Interlocked.CompareExchange(ref loginRowChangingEvent, value2, xy2);
				}
				while ((object)xy != xy2);
			}
			remove
			{
				Xy8 xy = loginRowChangingEvent;
				Xy8 xy2;
				do
				{
					xy2 = xy;
					Xy8 value2 = (Xy8)Delegate.Remove(xy2, value);
					xy = Interlocked.CompareExchange(ref loginRowChangingEvent, value2, xy2);
				}
				while ((object)xy != xy2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Xy8 loginRowChanged
		{
			add
			{
				Xy8 xy = loginRowChangedEvent;
				Xy8 xy2;
				do
				{
					xy2 = xy;
					Xy8 value2 = (Xy8)Delegate.Combine(xy2, value);
					xy = Interlocked.CompareExchange(ref loginRowChangedEvent, value2, xy2);
				}
				while ((object)xy != xy2);
			}
			remove
			{
				Xy8 xy = loginRowChangedEvent;
				Xy8 xy2;
				do
				{
					xy2 = xy;
					Xy8 value2 = (Xy8)Delegate.Remove(xy2, value);
					xy = Interlocked.CompareExchange(ref loginRowChangedEvent, value2, xy2);
				}
				while ((object)xy != xy2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Xy8 loginRowDeleting
		{
			add
			{
				Xy8 xy = loginRowDeletingEvent;
				Xy8 xy2;
				do
				{
					xy2 = xy;
					Xy8 value2 = (Xy8)Delegate.Combine(xy2, value);
					xy = Interlocked.CompareExchange(ref loginRowDeletingEvent, value2, xy2);
				}
				while ((object)xy != xy2);
			}
			remove
			{
				Xy8 xy = loginRowDeletingEvent;
				Xy8 xy2;
				do
				{
					xy2 = xy;
					Xy8 value2 = (Xy8)Delegate.Remove(xy2, value);
					xy = Interlocked.CompareExchange(ref loginRowDeletingEvent, value2, xy2);
				}
				while ((object)xy != xy2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Xy8 loginRowDeleted
		{
			add
			{
				Xy8 xy = loginRowDeletedEvent;
				Xy8 xy2;
				do
				{
					xy2 = xy;
					Xy8 value2 = (Xy8)Delegate.Combine(xy2, value);
					xy = Interlocked.CompareExchange(ref loginRowDeletedEvent, value2, xy2);
				}
				while ((object)xy != xy2);
			}
			remove
			{
				Xy8 xy = loginRowDeletedEvent;
				Xy8 xy2;
				do
				{
					xy2 = xy;
					Xy8 value2 = (Xy8)Delegate.Remove(xy2, value);
					xy = Interlocked.CompareExchange(ref loginRowDeletedEvent, value2, xy2);
				}
				while ((object)xy != xy2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public m0K()
		{
			base.TableName = "login";
			BeginInit();
			Ns8();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal m0K(DataTable table)
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
		protected m0K(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			g5J();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Ge0(Kg4 Wa4)
		{
			base.Rows.Add(Wa4);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Kg4 Hr5(string Fm5, string p2G, string o4L, string y5J)
		{
			Kg4 kg = (Kg4)NewRow();
			object[] array2 = (kg.ItemArray = new object[4] { Fm5, p2G, o4L, y5J });
			base.Rows.Add(kg);
			return kg;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Kg4 To5(string c1P)
		{
			return (Kg4)base.Rows.Find(new object[1] { c1P });
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable i0B()
		{
			m0K m0K = (m0K)base.Clone();
			m0K.g5J();
			return m0K;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable Pj1()
		{
			return new m0K();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void g5J()
		{
			columnuname = base.Columns["uname"];
			columnpwd = base.Columns["pwd"];
			columnpost = base.Columns["post"];
			columnpermission = base.Columns["permission"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void Ns8()
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
		public Kg4 a5M()
		{
			return (Kg4)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow Hq4(DataRowBuilder r3G)
		{
			return new Kg4(r3G);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type Ds9()
		{
			return typeof(Kg4);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void Nt6(DataRowChangeEventArgs Pp1)
		{
			base.OnRowChanged(Pp1);
			if (loginRowChangedEvent != null)
			{
				loginRowChangedEvent?.Invoke(this, new Ec38((Kg4)Pp1.Row, Pp1.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void z4W(DataRowChangeEventArgs d1J)
		{
			base.OnRowChanging(d1J);
			if (loginRowChangingEvent != null)
			{
				loginRowChangingEvent?.Invoke(this, new Ec38((Kg4)d1J.Row, d1J.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void Da1(DataRowChangeEventArgs Fz2)
		{
			base.OnRowDeleted(Fz2);
			if (loginRowDeletedEvent != null)
			{
				loginRowDeletedEvent?.Invoke(this, new Ec38((Kg4)Fz2.Row, Fz2.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void Kw8(DataRowChangeEventArgs z0X)
		{
			base.OnRowDeleting(z0X);
			if (loginRowDeletingEvent != null)
			{
				loginRowDeletingEvent?.Invoke(this, new Ec38((Kg4)z0X.Row, z0X.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Gy2(Kg4 k5N)
		{
			base.Rows.Remove(k5N);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType Np5(XmlSchemaSet g7P)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			w8K w8K2 = new w8K();
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
			xmlSchemaAttribute.FixedValue = w8K2.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "loginDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema xmlSchema = w8K2.m1Y();
			if (g7P.Contains(xmlSchema.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema2 = null;
					xmlSchema.Write(memoryStream);
					IEnumerator enumerator = g7P.Schemas(xmlSchema.TargetNamespace).GetEnumerator();
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
			g7P.Add(xmlSchema);
			return xmlSchemaComplexType;
		}
	}

	public class Sk0 : DataRow
	{
		private c7E tablebooks;

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
		internal Sk0(DataRowBuilder rb)
			: base(rb)
		{
			tablebooks = (c7E)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool e8A()
		{
			return IsNull(tablebooks.bnameColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void n6G()
		{
			base[tablebooks.bnameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Fg8()
		{
			return IsNull(tablebooks.authorNameColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void w0M()
		{
			base[tablebooks.authorNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool x8G()
		{
			return IsNull(tablebooks.numberOfCopiesColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void g3P()
		{
			base[tablebooks.numberOfCopiesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	public class Kg4 : DataRow
	{
		private m0K tablelogin;

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
		internal Kg4(DataRowBuilder rb)
			: base(rb)
		{
			tablelogin = (m0K)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool c6T()
		{
			return IsNull(tablelogin.pwdColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Lo7()
		{
			base[tablelogin.pwdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Ek3()
		{
			return IsNull(tablelogin.postColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void s7Z()
		{
			base[tablelogin.postColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Gk9()
		{
			return IsNull(tablelogin.permissionColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void d7M()
		{
			base[tablelogin.permissionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class Gz14 : EventArgs
	{
		private Sk0 eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Sk0 Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Gz14(Sk0 row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class Ec38 : EventArgs
	{
		private Kg4 eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Kg4 Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Ec38(Kg4 row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	private c7E tablebooks;

	private m0K tablelogin;

	private SchemaSerializationMode _schemaSerializationMode;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public c7E books => tablebooks;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[Browsable(false)]
	public m0K login => tablelogin;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public new DataTableCollection Tables => base.Tables;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public new DataRelationCollection Relations => base.Relations;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public w8K()
	{
		_schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		BeginInit();
		r2S();
		CollectionChangeEventHandler value = m5X;
		base.Tables.CollectionChanged += value;
		base.Relations.CollectionChanged += value;
		EndInit();
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected w8K(SerializationInfo info, StreamingContext context)
		: base(info, context, ConstructSchema: false)
	{
		_schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		if (IsBinarySerialized(info, context))
		{
			d9W(Xo8: false);
			CollectionChangeEventHandler value = m5X;
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
				base.Tables.Add(new c7E(dataSet.Tables["books"]));
			}
			if (dataSet.Tables["login"] != null)
			{
				base.Tables.Add(new m0K(dataSet.Tables["login"]));
			}
			base.DataSetName = dataSet.DataSetName;
			base.Prefix = dataSet.Prefix;
			base.Namespace = dataSet.Namespace;
			base.Locale = dataSet.Locale;
			base.CaseSensitive = dataSet.CaseSensitive;
			base.EnforceConstraints = dataSet.EnforceConstraints;
			Merge(dataSet, preserveChanges: false, MissingSchemaAction.Add);
			j2T();
		}
		else
		{
			ReadXmlSchema(new XmlTextReader(new StringReader(s)));
		}
		GetSerializationData(info, context);
		CollectionChangeEventHandler value2 = m5X;
		base.Tables.CollectionChanged += value2;
		Relations.CollectionChanged += value2;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected override void z1J()
	{
		BeginInit();
		r2S();
		EndInit();
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public override DataSet Fw7()
	{
		w8K w8K2 = (w8K)base.Clone();
		w8K2.j2T();
		w8K2.SchemaSerializationMode = SchemaSerializationMode;
		return w8K2;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected override bool w8X()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected override bool w2A()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected override void z2N(XmlReader Cs7)
	{
		if (DetermineSchemaSerializationMode(Cs7) == SchemaSerializationMode.IncludeSchema)
		{
			Reset();
			DataSet dataSet = new DataSet();
			dataSet.ReadXml(Cs7);
			if (dataSet.Tables["books"] != null)
			{
				base.Tables.Add(new c7E(dataSet.Tables["books"]));
			}
			if (dataSet.Tables["login"] != null)
			{
				base.Tables.Add(new m0K(dataSet.Tables["login"]));
			}
			base.DataSetName = dataSet.DataSetName;
			base.Prefix = dataSet.Prefix;
			base.Namespace = dataSet.Namespace;
			base.Locale = dataSet.Locale;
			base.CaseSensitive = dataSet.CaseSensitive;
			base.EnforceConstraints = dataSet.EnforceConstraints;
			Merge(dataSet, preserveChanges: false, MissingSchemaAction.Add);
			j2T();
		}
		else
		{
			ReadXml(Cs7);
			j2T();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected override XmlSchema m1Y()
	{
		MemoryStream memoryStream = new MemoryStream();
		WriteXmlSchema(new XmlTextWriter(memoryStream, null));
		memoryStream.Position = 0L;
		return XmlSchema.Read(new XmlTextReader(memoryStream), null);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	internal void j2T()
	{
		d9W(Xo8: true);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	internal void d9W(bool Xo8)
	{
		tablebooks = (c7E)base.Tables["books"];
		if (Xo8 && tablebooks != null)
		{
			tablebooks.Pi7();
		}
		tablelogin = (m0K)base.Tables["login"];
		if (Xo8 && tablelogin != null)
		{
			tablelogin.g5J();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void r2S()
	{
		base.DataSetName = "libraryDataSet";
		base.Prefix = "";
		base.Namespace = "http://tempuri.org/libraryDataSet.xsd";
		base.EnforceConstraints = true;
		SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		tablebooks = new c7E();
		base.Tables.Add(tablebooks);
		tablelogin = new m0K();
		base.Tables.Add(tablelogin);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool Ho2()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool s6B()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void m5X(object sender, CollectionChangeEventArgs e)
	{
		if (e.Action == CollectionChangeAction.Remove)
		{
			j2T();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public static XmlSchemaComplexType Xt5(XmlSchemaSet Lx5)
	{
		w8K w8K2 = new w8K();
		XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
		XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
		XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
		xmlSchemaAny.Namespace = w8K2.Namespace;
		xmlSchemaSequence.Items.Add(xmlSchemaAny);
		xmlSchemaComplexType.Particle = xmlSchemaSequence;
		XmlSchema xmlSchema = w8K2.m1Y();
		if (Lx5.Contains(xmlSchema.TargetNamespace))
		{
			MemoryStream memoryStream = new MemoryStream();
			MemoryStream memoryStream2 = new MemoryStream();
			try
			{
				XmlSchema xmlSchema2 = null;
				xmlSchema.Write(memoryStream);
				IEnumerator enumerator = Lx5.Schemas(xmlSchema.TargetNamespace).GetEnumerator();
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
		Lx5.Add(xmlSchema);
		return xmlSchemaComplexType;
	}
}
