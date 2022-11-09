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

namespace a3B;

[Serializable]
[HelpKeyword("vs.data.DataSet")]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[DesignerCategory("code")]
[XmlRoot("DatabaseDataSet1")]
[ToolboxItem(true)]
public class Di1 : DataSet
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void Zp2(object sender, w6P e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void Ti8(object sender, Pb0 e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void m8B(object sender, o3T e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void b6C(object sender, d1T e);

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class f8J : TypedTableBase<Zc34>
	{
		private DataColumn columnISBN;

		private DataColumn columnTotal;

		private DataColumn columnRemaining;

		private DataColumn columnLocation;

		private DataColumn columnPublishYear;

		private DataColumn columnTitle;

		private DataColumn columnAuthor;

		private DataColumn columnPublisher;

		private DataColumn columnField;

		private DataColumn columnBookImage;

		private DataColumn columnPrice;

		private Zp2 BooksRowChangingEvent;

		private Zp2 BooksRowChangedEvent;

		private Zp2 BooksRowDeletingEvent;

		private Zp2 BooksRowDeletedEvent;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ISBNColumn => columnISBN;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn TotalColumn => columnTotal;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn RemainingColumn => columnRemaining;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn LocationColumn => columnLocation;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PublishYearColumn => columnPublishYear;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn TitleColumn => columnTitle;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn AuthorColumn => columnAuthor;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PublisherColumn => columnPublisher;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn FieldColumn => columnField;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BookImageColumn => columnBookImage;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PriceColumn => columnPrice;

		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int Count => base.Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Zc34 this[int Wd8] => (Zc34)base.Rows[Wd8];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Zp2 BooksRowChanging
		{
			add
			{
				Zp2 zp = BooksRowChangingEvent;
				Zp2 zp2;
				do
				{
					zp2 = zp;
					Zp2 value2 = (Zp2)Delegate.Combine(zp2, value);
					zp = Interlocked.CompareExchange(ref BooksRowChangingEvent, value2, zp2);
				}
				while ((object)zp != zp2);
			}
			remove
			{
				Zp2 zp = BooksRowChangingEvent;
				Zp2 zp2;
				do
				{
					zp2 = zp;
					Zp2 value2 = (Zp2)Delegate.Remove(zp2, value);
					zp = Interlocked.CompareExchange(ref BooksRowChangingEvent, value2, zp2);
				}
				while ((object)zp != zp2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Zp2 BooksRowChanged
		{
			add
			{
				Zp2 zp = BooksRowChangedEvent;
				Zp2 zp2;
				do
				{
					zp2 = zp;
					Zp2 value2 = (Zp2)Delegate.Combine(zp2, value);
					zp = Interlocked.CompareExchange(ref BooksRowChangedEvent, value2, zp2);
				}
				while ((object)zp != zp2);
			}
			remove
			{
				Zp2 zp = BooksRowChangedEvent;
				Zp2 zp2;
				do
				{
					zp2 = zp;
					Zp2 value2 = (Zp2)Delegate.Remove(zp2, value);
					zp = Interlocked.CompareExchange(ref BooksRowChangedEvent, value2, zp2);
				}
				while ((object)zp != zp2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Zp2 BooksRowDeleting
		{
			add
			{
				Zp2 zp = BooksRowDeletingEvent;
				Zp2 zp2;
				do
				{
					zp2 = zp;
					Zp2 value2 = (Zp2)Delegate.Combine(zp2, value);
					zp = Interlocked.CompareExchange(ref BooksRowDeletingEvent, value2, zp2);
				}
				while ((object)zp != zp2);
			}
			remove
			{
				Zp2 zp = BooksRowDeletingEvent;
				Zp2 zp2;
				do
				{
					zp2 = zp;
					Zp2 value2 = (Zp2)Delegate.Remove(zp2, value);
					zp = Interlocked.CompareExchange(ref BooksRowDeletingEvent, value2, zp2);
				}
				while ((object)zp != zp2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Zp2 BooksRowDeleted
		{
			add
			{
				Zp2 zp = BooksRowDeletedEvent;
				Zp2 zp2;
				do
				{
					zp2 = zp;
					Zp2 value2 = (Zp2)Delegate.Combine(zp2, value);
					zp = Interlocked.CompareExchange(ref BooksRowDeletedEvent, value2, zp2);
				}
				while ((object)zp != zp2);
			}
			remove
			{
				Zp2 zp = BooksRowDeletedEvent;
				Zp2 zp2;
				do
				{
					zp2 = zp;
					Zp2 value2 = (Zp2)Delegate.Remove(zp2, value);
					zp = Interlocked.CompareExchange(ref BooksRowDeletedEvent, value2, zp2);
				}
				while ((object)zp != zp2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public f8J()
		{
			base.TableName = "Books";
			BeginInit();
			Ks2();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal f8J(DataTable table)
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
		protected f8J(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			Re6();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Ct2(Zc34 s9J)
		{
			base.Rows.Add(s9J);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Zc34 o4Z(string Er2, int q9Y, int k2Z, string e2B, DateTime n2C, string Mf7, string Ax6, string Xf7, string g5Z, string x7H, decimal x7D)
		{
			Zc34 zc = (Zc34)NewRow();
			object[] array2 = (zc.ItemArray = new object[11]
			{
				Er2, q9Y, k2Z, e2B, n2C, Mf7, Ax6, Xf7, g5Z, x7H,
				x7D
			});
			base.Rows.Add(zc);
			return zc;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Zc34 Hr6(string Bb6)
		{
			return (Zc34)base.Rows.Find(new object[1] { Bb6 });
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Zc4()
		{
			f8J f8J = (f8J)base.Clone();
			f8J.Re6();
			return f8J;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable s8B()
		{
			return new f8J();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void Re6()
		{
			columnISBN = base.Columns["ISBN"];
			columnTotal = base.Columns["Total"];
			columnRemaining = base.Columns["Remaining"];
			columnLocation = base.Columns["Location"];
			columnPublishYear = base.Columns["PublishYear"];
			columnTitle = base.Columns["Title"];
			columnAuthor = base.Columns["Author"];
			columnPublisher = base.Columns["Publisher"];
			columnField = base.Columns["Field"];
			columnBookImage = base.Columns["BookImage"];
			columnPrice = base.Columns["Price"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void Ks2()
		{
			columnISBN = new DataColumn("ISBN", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnISBN);
			columnTotal = new DataColumn("Total", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnTotal);
			columnRemaining = new DataColumn("Remaining", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnRemaining);
			columnLocation = new DataColumn("Location", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnLocation);
			columnPublishYear = new DataColumn("PublishYear", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnPublishYear);
			columnTitle = new DataColumn("Title", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnTitle);
			columnAuthor = new DataColumn("Author", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnAuthor);
			columnPublisher = new DataColumn("Publisher", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnPublisher);
			columnField = new DataColumn("Field", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnField);
			columnBookImage = new DataColumn("BookImage", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnBookImage);
			columnPrice = new DataColumn("Price", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnPrice);
			base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[1] { columnISBN }, isPrimaryKey: true));
			columnISBN.AllowDBNull = false;
			columnISBN.Unique = true;
			columnISBN.MaxLength = 255;
			columnLocation.MaxLength = 255;
			columnTitle.MaxLength = 255;
			columnAuthor.MaxLength = 255;
			columnPublisher.MaxLength = 255;
			columnField.MaxLength = 255;
			columnBookImage.MaxLength = 255;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Zc34 Bg5()
		{
			return (Zc34)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow Zw8(DataRowBuilder w4H)
		{
			return new Zc34(w4H);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type t5F()
		{
			return typeof(Zc34);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void w3J(DataRowChangeEventArgs Ke5)
		{
			base.OnRowChanged(Ke5);
			if (BooksRowChangedEvent != null)
			{
				BooksRowChangedEvent?.Invoke(this, new w6P((Zc34)Ke5.Row, Ke5.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void Se4(DataRowChangeEventArgs Ex8)
		{
			base.OnRowChanging(Ex8);
			if (BooksRowChangingEvent != null)
			{
				BooksRowChangingEvent?.Invoke(this, new w6P((Zc34)Ex8.Row, Ex8.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void La7(DataRowChangeEventArgs Pm9)
		{
			base.OnRowDeleted(Pm9);
			if (BooksRowDeletedEvent != null)
			{
				BooksRowDeletedEvent?.Invoke(this, new w6P((Zc34)Pm9.Row, Pm9.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void o8C(DataRowChangeEventArgs Wx0)
		{
			base.OnRowDeleting(Wx0);
			if (BooksRowDeletingEvent != null)
			{
				BooksRowDeletingEvent?.Invoke(this, new w6P((Zc34)Wx0.Row, Wx0.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void k4M(Zc34 e2G)
		{
			base.Rows.Remove(e2G);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType g1Q(XmlSchemaSet Bt0)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Di1 di = new Di1();
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
			xmlSchemaAttribute.FixedValue = di.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "BooksDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema xmlSchema = di.m6M();
			if (Bt0.Contains(xmlSchema.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema2 = null;
					xmlSchema.Write(memoryStream);
					IEnumerator enumerator = Bt0.Schemas(xmlSchema.TargetNamespace).GetEnumerator();
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
			Bt0.Add(xmlSchema);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class m6P : TypedTableBase<t1AL>
	{
		private DataColumn columnAccNo;

		private DataColumn columnISBN;

		private DataColumn columnBorrowerId;

		private DataColumn columnIssueDate;

		private DataColumn columnReturnDate;

		private DataColumn columnIsIssued;

		private DataColumn columnFine;

		private DataColumn columnIssueCount;

		private Ti8 BorrowedRowChangingEvent;

		private Ti8 BorrowedRowChangedEvent;

		private Ti8 BorrowedRowDeletingEvent;

		private Ti8 BorrowedRowDeletedEvent;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn AccNoColumn => columnAccNo;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ISBNColumn => columnISBN;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BorrowerIdColumn => columnBorrowerId;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn IssueDateColumn => columnIssueDate;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ReturnDateColumn => columnReturnDate;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn IsIssuedColumn => columnIsIssued;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn FineColumn => columnFine;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn IssueCountColumn => columnIssueCount;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		public int Count => base.Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public t1AL this[int Ey7] => (t1AL)base.Rows[Ey7];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Ti8 BorrowedRowChanging
		{
			add
			{
				Ti8 ti = BorrowedRowChangingEvent;
				Ti8 ti2;
				do
				{
					ti2 = ti;
					Ti8 value2 = (Ti8)Delegate.Combine(ti2, value);
					ti = Interlocked.CompareExchange(ref BorrowedRowChangingEvent, value2, ti2);
				}
				while ((object)ti != ti2);
			}
			remove
			{
				Ti8 ti = BorrowedRowChangingEvent;
				Ti8 ti2;
				do
				{
					ti2 = ti;
					Ti8 value2 = (Ti8)Delegate.Remove(ti2, value);
					ti = Interlocked.CompareExchange(ref BorrowedRowChangingEvent, value2, ti2);
				}
				while ((object)ti != ti2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Ti8 BorrowedRowChanged
		{
			add
			{
				Ti8 ti = BorrowedRowChangedEvent;
				Ti8 ti2;
				do
				{
					ti2 = ti;
					Ti8 value2 = (Ti8)Delegate.Combine(ti2, value);
					ti = Interlocked.CompareExchange(ref BorrowedRowChangedEvent, value2, ti2);
				}
				while ((object)ti != ti2);
			}
			remove
			{
				Ti8 ti = BorrowedRowChangedEvent;
				Ti8 ti2;
				do
				{
					ti2 = ti;
					Ti8 value2 = (Ti8)Delegate.Remove(ti2, value);
					ti = Interlocked.CompareExchange(ref BorrowedRowChangedEvent, value2, ti2);
				}
				while ((object)ti != ti2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Ti8 BorrowedRowDeleting
		{
			add
			{
				Ti8 ti = BorrowedRowDeletingEvent;
				Ti8 ti2;
				do
				{
					ti2 = ti;
					Ti8 value2 = (Ti8)Delegate.Combine(ti2, value);
					ti = Interlocked.CompareExchange(ref BorrowedRowDeletingEvent, value2, ti2);
				}
				while ((object)ti != ti2);
			}
			remove
			{
				Ti8 ti = BorrowedRowDeletingEvent;
				Ti8 ti2;
				do
				{
					ti2 = ti;
					Ti8 value2 = (Ti8)Delegate.Remove(ti2, value);
					ti = Interlocked.CompareExchange(ref BorrowedRowDeletingEvent, value2, ti2);
				}
				while ((object)ti != ti2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Ti8 BorrowedRowDeleted
		{
			add
			{
				Ti8 ti = BorrowedRowDeletedEvent;
				Ti8 ti2;
				do
				{
					ti2 = ti;
					Ti8 value2 = (Ti8)Delegate.Combine(ti2, value);
					ti = Interlocked.CompareExchange(ref BorrowedRowDeletedEvent, value2, ti2);
				}
				while ((object)ti != ti2);
			}
			remove
			{
				Ti8 ti = BorrowedRowDeletedEvent;
				Ti8 ti2;
				do
				{
					ti2 = ti;
					Ti8 value2 = (Ti8)Delegate.Remove(ti2, value);
					ti = Interlocked.CompareExchange(ref BorrowedRowDeletedEvent, value2, ti2);
				}
				while ((object)ti != ti2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public m6P()
		{
			base.TableName = "Borrowed";
			BeginInit();
			En5();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal m6P(DataTable table)
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
		protected m6P(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			Ej0();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Ty6(t1AL Gw0)
		{
			base.Rows.Add(Gw0);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public t1AL Zr4(string Cg5, string w4M, DateTime Ci2, DateTime r7K, bool Ac7, decimal q2T, int c6L)
		{
			t1AL t1AL = (t1AL)NewRow();
			object[] array2 = (t1AL.ItemArray = new object[8] { null, Cg5, w4M, Ci2, r7K, Ac7, q2T, c6L });
			base.Rows.Add(t1AL);
			return t1AL;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public t1AL Sk7(int m1B)
		{
			return (t1AL)base.Rows.Find(new object[1] { m1B });
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable p1S()
		{
			m6P m6P = (m6P)base.Clone();
			m6P.Ej0();
			return m6P;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable Ho7()
		{
			return new m6P();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void Ej0()
		{
			columnAccNo = base.Columns["AccNo"];
			columnISBN = base.Columns["ISBN"];
			columnBorrowerId = base.Columns["BorrowerId"];
			columnIssueDate = base.Columns["IssueDate"];
			columnReturnDate = base.Columns["ReturnDate"];
			columnIsIssued = base.Columns["IsIssued"];
			columnFine = base.Columns["Fine"];
			columnIssueCount = base.Columns["IssueCount"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void En5()
		{
			columnAccNo = new DataColumn("AccNo", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnAccNo);
			columnISBN = new DataColumn("ISBN", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnISBN);
			columnBorrowerId = new DataColumn("BorrowerId", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnBorrowerId);
			columnIssueDate = new DataColumn("IssueDate", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnIssueDate);
			columnReturnDate = new DataColumn("ReturnDate", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnReturnDate);
			columnIsIssued = new DataColumn("IsIssued", typeof(bool), null, MappingType.Element);
			base.Columns.Add(columnIsIssued);
			columnFine = new DataColumn("Fine", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnFine);
			columnIssueCount = new DataColumn("IssueCount", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnIssueCount);
			base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[1] { columnAccNo }, isPrimaryKey: true));
			columnAccNo.AutoIncrement = true;
			columnAccNo.AutoIncrementSeed = -1L;
			columnAccNo.AutoIncrementStep = -1L;
			columnAccNo.AllowDBNull = false;
			columnAccNo.Unique = true;
			columnISBN.MaxLength = 50;
			columnBorrowerId.MaxLength = 255;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public t1AL Nf1()
		{
			return (t1AL)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow Lw4(DataRowBuilder o7Y)
		{
			return new t1AL(o7Y);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type Jg2()
		{
			return typeof(t1AL);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void w4Y(DataRowChangeEventArgs a8XT)
		{
			base.OnRowChanged(a8XT);
			if (BorrowedRowChangedEvent != null)
			{
				BorrowedRowChangedEvent?.Invoke(this, new Pb0((t1AL)a8XT.Row, a8XT.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void s4HF(DataRowChangeEventArgs b7HS)
		{
			base.OnRowChanging(b7HS);
			if (BorrowedRowChangingEvent != null)
			{
				BorrowedRowChangingEvent?.Invoke(this, new Pb0((t1AL)b7HS.Row, b7HS.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void Jq7a(DataRowChangeEventArgs i9NL)
		{
			base.OnRowDeleted(i9NL);
			if (BorrowedRowDeletedEvent != null)
			{
				BorrowedRowDeletedEvent?.Invoke(this, new Pb0((t1AL)i9NL.Row, i9NL.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void b4A6(DataRowChangeEventArgs x3BP)
		{
			base.OnRowDeleting(x3BP);
			if (BorrowedRowDeletingEvent != null)
			{
				BorrowedRowDeletingEvent?.Invoke(this, new Pb0((t1AL)x3BP.Row, x3BP.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Pd6q(t1AL Pc01)
		{
			base.Rows.Remove(Pc01);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType r9RN(XmlSchemaSet r7A4)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Di1 di = new Di1();
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
			xmlSchemaAttribute.FixedValue = di.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "BorrowedDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema xmlSchema = di.m6M();
			if (r7A4.Contains(xmlSchema.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema2 = null;
					xmlSchema.Write(memoryStream);
					IEnumerator enumerator = r7A4.Schemas(xmlSchema.TargetNamespace).GetEnumerator();
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
			r7A4.Add(xmlSchema);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class Yz83 : TypedTableBase<g2Z>
	{
		private DataColumn columnUserId;

		private DataColumn columnProfileName;

		private DataColumn columnUserName;

		private DataColumn columnPassword;

		private DataColumn columnIsAdmin;

		private DataColumn columnEmail;

		private DataColumn columnPhoneNumber;

		private DataColumn columnDepartment;

		private DataColumn columnDesignation;

		private DataColumn columnTotalFine;

		private DataColumn columnBooksIssued;

		private DataColumn columnProfileImage;

		private DataColumn columnMaxBooks;

		private m8B UsersRowChangingEvent;

		private m8B UsersRowChangedEvent;

		private m8B UsersRowDeletingEvent;

		private m8B UsersRowDeletedEvent;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn UserIdColumn => columnUserId;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ProfileNameColumn => columnProfileName;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn UserNameColumn => columnUserName;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PasswordColumn => columnPassword;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn IsAdminColumn => columnIsAdmin;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn EmailColumn => columnEmail;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PhoneNumberColumn => columnPhoneNumber;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DepartmentColumn => columnDepartment;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DesignationColumn => columnDesignation;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn TotalFineColumn => columnTotalFine;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BooksIssuedColumn => columnBooksIssued;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ProfileImageColumn => columnProfileImage;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn MaxBooksColumn => columnMaxBooks;

		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int Count => base.Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public g2Z this[int q9BP] => (g2Z)base.Rows[q9BP];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event m8B UsersRowChanging
		{
			add
			{
				m8B m8B = UsersRowChangingEvent;
				m8B m8B2;
				do
				{
					m8B2 = m8B;
					m8B value2 = (m8B)Delegate.Combine(m8B2, value);
					m8B = Interlocked.CompareExchange(ref UsersRowChangingEvent, value2, m8B2);
				}
				while ((object)m8B != m8B2);
			}
			remove
			{
				m8B m8B = UsersRowChangingEvent;
				m8B m8B2;
				do
				{
					m8B2 = m8B;
					m8B value2 = (m8B)Delegate.Remove(m8B2, value);
					m8B = Interlocked.CompareExchange(ref UsersRowChangingEvent, value2, m8B2);
				}
				while ((object)m8B != m8B2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event m8B UsersRowChanged
		{
			add
			{
				m8B m8B = UsersRowChangedEvent;
				m8B m8B2;
				do
				{
					m8B2 = m8B;
					m8B value2 = (m8B)Delegate.Combine(m8B2, value);
					m8B = Interlocked.CompareExchange(ref UsersRowChangedEvent, value2, m8B2);
				}
				while ((object)m8B != m8B2);
			}
			remove
			{
				m8B m8B = UsersRowChangedEvent;
				m8B m8B2;
				do
				{
					m8B2 = m8B;
					m8B value2 = (m8B)Delegate.Remove(m8B2, value);
					m8B = Interlocked.CompareExchange(ref UsersRowChangedEvent, value2, m8B2);
				}
				while ((object)m8B != m8B2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event m8B UsersRowDeleting
		{
			add
			{
				m8B m8B = UsersRowDeletingEvent;
				m8B m8B2;
				do
				{
					m8B2 = m8B;
					m8B value2 = (m8B)Delegate.Combine(m8B2, value);
					m8B = Interlocked.CompareExchange(ref UsersRowDeletingEvent, value2, m8B2);
				}
				while ((object)m8B != m8B2);
			}
			remove
			{
				m8B m8B = UsersRowDeletingEvent;
				m8B m8B2;
				do
				{
					m8B2 = m8B;
					m8B value2 = (m8B)Delegate.Remove(m8B2, value);
					m8B = Interlocked.CompareExchange(ref UsersRowDeletingEvent, value2, m8B2);
				}
				while ((object)m8B != m8B2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event m8B UsersRowDeleted
		{
			add
			{
				m8B m8B = UsersRowDeletedEvent;
				m8B m8B2;
				do
				{
					m8B2 = m8B;
					m8B value2 = (m8B)Delegate.Combine(m8B2, value);
					m8B = Interlocked.CompareExchange(ref UsersRowDeletedEvent, value2, m8B2);
				}
				while ((object)m8B != m8B2);
			}
			remove
			{
				m8B m8B = UsersRowDeletedEvent;
				m8B m8B2;
				do
				{
					m8B2 = m8B;
					m8B value2 = (m8B)Delegate.Remove(m8B2, value);
					m8B = Interlocked.CompareExchange(ref UsersRowDeletedEvent, value2, m8B2);
				}
				while ((object)m8B != m8B2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Yz83()
		{
			base.TableName = "Users";
			BeginInit();
			Ss7j();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Yz83(DataTable table)
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
		protected Yz83(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			w0AB();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Ms0p(g2Z g6QF)
		{
			base.Rows.Add(g6QF);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public g2Z Lo35(string a4P3, string j5Z9, string Ln9j, bool a7J4, string Dt7q, string Ad84, string g8FP, string Ep4o, int Yg83, int Zy04, string Fe14, int Ys4w)
		{
			g2Z g2Z = (g2Z)NewRow();
			object[] array2 = (g2Z.ItemArray = new object[13]
			{
				null, a4P3, j5Z9, Ln9j, a7J4, Dt7q, Ad84, g8FP, Ep4o, Yg83,
				Zy04, Fe14, Ys4w
			});
			base.Rows.Add(g2Z);
			return g2Z;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public g2Z i8L0(int q6HF)
		{
			return (g2Z)base.Rows.Find(new object[1] { q6HF });
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable q4EL()
		{
			Yz83 yz = (Yz83)base.Clone();
			yz.w0AB();
			return yz;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable y8S5()
		{
			return new Yz83();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void w0AB()
		{
			columnUserId = base.Columns["UserId"];
			columnProfileName = base.Columns["ProfileName"];
			columnUserName = base.Columns["UserName"];
			columnPassword = base.Columns["Password"];
			columnIsAdmin = base.Columns["IsAdmin"];
			columnEmail = base.Columns["Email"];
			columnPhoneNumber = base.Columns["PhoneNumber"];
			columnDepartment = base.Columns["Department"];
			columnDesignation = base.Columns["Designation"];
			columnTotalFine = base.Columns["TotalFine"];
			columnBooksIssued = base.Columns["BooksIssued"];
			columnProfileImage = base.Columns["ProfileImage"];
			columnMaxBooks = base.Columns["MaxBooks"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void Ss7j()
		{
			columnUserId = new DataColumn("UserId", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnUserId);
			columnProfileName = new DataColumn("ProfileName", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnProfileName);
			columnUserName = new DataColumn("UserName", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnUserName);
			columnPassword = new DataColumn("Password", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnPassword);
			columnIsAdmin = new DataColumn("IsAdmin", typeof(bool), null, MappingType.Element);
			base.Columns.Add(columnIsAdmin);
			columnEmail = new DataColumn("Email", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnEmail);
			columnPhoneNumber = new DataColumn("PhoneNumber", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnPhoneNumber);
			columnDepartment = new DataColumn("Department", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDepartment);
			columnDesignation = new DataColumn("Designation", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDesignation);
			columnTotalFine = new DataColumn("TotalFine", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnTotalFine);
			columnBooksIssued = new DataColumn("BooksIssued", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnBooksIssued);
			columnProfileImage = new DataColumn("ProfileImage", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnProfileImage);
			columnMaxBooks = new DataColumn("MaxBooks", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnMaxBooks);
			base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[1] { columnUserId }, isPrimaryKey: true));
			columnUserId.AutoIncrement = true;
			columnUserId.AutoIncrementSeed = -1L;
			columnUserId.AutoIncrementStep = -1L;
			columnUserId.AllowDBNull = false;
			columnUserId.Unique = true;
			columnProfileName.MaxLength = 255;
			columnUserName.MaxLength = 255;
			columnPassword.MaxLength = 536870910;
			columnEmail.MaxLength = 536870910;
			columnPhoneNumber.MaxLength = 255;
			columnDepartment.MaxLength = 255;
			columnDesignation.MaxLength = 255;
			columnProfileImage.MaxLength = 255;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public g2Z r2JX()
		{
			return (g2Z)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow x3D4(DataRowBuilder Te19)
		{
			return new g2Z(Te19);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type Si97()
		{
			return typeof(g2Z);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void j7ZF(DataRowChangeEventArgs Tr6e)
		{
			base.OnRowChanged(Tr6e);
			if (UsersRowChangedEvent != null)
			{
				UsersRowChangedEvent?.Invoke(this, new o3T((g2Z)Tr6e.Row, Tr6e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void c2KP(DataRowChangeEventArgs Cc38)
		{
			base.OnRowChanging(Cc38);
			if (UsersRowChangingEvent != null)
			{
				UsersRowChangingEvent?.Invoke(this, new o3T((g2Z)Cc38.Row, Cc38.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void Cf1n(DataRowChangeEventArgs Yj7m)
		{
			base.OnRowDeleted(Yj7m);
			if (UsersRowDeletedEvent != null)
			{
				UsersRowDeletedEvent?.Invoke(this, new o3T((g2Z)Yj7m.Row, Yj7m.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void Bq9y(DataRowChangeEventArgs o0DH)
		{
			base.OnRowDeleting(o0DH);
			if (UsersRowDeletingEvent != null)
			{
				UsersRowDeletingEvent?.Invoke(this, new o3T((g2Z)o0DH.Row, o0DH.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Fs9z(g2Z Dm3p)
		{
			base.Rows.Remove(Dm3p);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType Bs82(XmlSchemaSet Tt81)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Di1 di = new Di1();
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
			xmlSchemaAttribute.FixedValue = di.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "UsersDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema xmlSchema = di.m6M();
			if (Tt81.Contains(xmlSchema.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema2 = null;
					xmlSchema.Write(memoryStream);
					IEnumerator enumerator = Tt81.Schemas(xmlSchema.TargetNamespace).GetEnumerator();
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
			Tt81.Add(xmlSchema);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class b1XG : TypedTableBase<Rd6>
	{
		private DataColumn columnID;

		private DataColumn columnISBN;

		private DataColumn columnUserName;

		private DataColumn columnStarcount;

		private b6C RatingListRowChangingEvent;

		private b6C RatingListRowChangedEvent;

		private b6C RatingListRowDeletingEvent;

		private b6C RatingListRowDeletedEvent;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn IDColumn => columnID;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ISBNColumn => columnISBN;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn UserNameColumn => columnUserName;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn StarcountColumn => columnStarcount;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		public int Count => base.Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Rd6 this[int Fr93] => (Rd6)base.Rows[Fr93];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event b6C RatingListRowChanging
		{
			add
			{
				b6C b6C = RatingListRowChangingEvent;
				b6C b6C2;
				do
				{
					b6C2 = b6C;
					b6C value2 = (b6C)Delegate.Combine(b6C2, value);
					b6C = Interlocked.CompareExchange(ref RatingListRowChangingEvent, value2, b6C2);
				}
				while ((object)b6C != b6C2);
			}
			remove
			{
				b6C b6C = RatingListRowChangingEvent;
				b6C b6C2;
				do
				{
					b6C2 = b6C;
					b6C value2 = (b6C)Delegate.Remove(b6C2, value);
					b6C = Interlocked.CompareExchange(ref RatingListRowChangingEvent, value2, b6C2);
				}
				while ((object)b6C != b6C2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event b6C RatingListRowChanged
		{
			add
			{
				b6C b6C = RatingListRowChangedEvent;
				b6C b6C2;
				do
				{
					b6C2 = b6C;
					b6C value2 = (b6C)Delegate.Combine(b6C2, value);
					b6C = Interlocked.CompareExchange(ref RatingListRowChangedEvent, value2, b6C2);
				}
				while ((object)b6C != b6C2);
			}
			remove
			{
				b6C b6C = RatingListRowChangedEvent;
				b6C b6C2;
				do
				{
					b6C2 = b6C;
					b6C value2 = (b6C)Delegate.Remove(b6C2, value);
					b6C = Interlocked.CompareExchange(ref RatingListRowChangedEvent, value2, b6C2);
				}
				while ((object)b6C != b6C2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event b6C RatingListRowDeleting
		{
			add
			{
				b6C b6C = RatingListRowDeletingEvent;
				b6C b6C2;
				do
				{
					b6C2 = b6C;
					b6C value2 = (b6C)Delegate.Combine(b6C2, value);
					b6C = Interlocked.CompareExchange(ref RatingListRowDeletingEvent, value2, b6C2);
				}
				while ((object)b6C != b6C2);
			}
			remove
			{
				b6C b6C = RatingListRowDeletingEvent;
				b6C b6C2;
				do
				{
					b6C2 = b6C;
					b6C value2 = (b6C)Delegate.Remove(b6C2, value);
					b6C = Interlocked.CompareExchange(ref RatingListRowDeletingEvent, value2, b6C2);
				}
				while ((object)b6C != b6C2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event b6C RatingListRowDeleted
		{
			add
			{
				b6C b6C = RatingListRowDeletedEvent;
				b6C b6C2;
				do
				{
					b6C2 = b6C;
					b6C value2 = (b6C)Delegate.Combine(b6C2, value);
					b6C = Interlocked.CompareExchange(ref RatingListRowDeletedEvent, value2, b6C2);
				}
				while ((object)b6C != b6C2);
			}
			remove
			{
				b6C b6C = RatingListRowDeletedEvent;
				b6C b6C2;
				do
				{
					b6C2 = b6C;
					b6C value2 = (b6C)Delegate.Remove(b6C2, value);
					b6C = Interlocked.CompareExchange(ref RatingListRowDeletedEvent, value2, b6C2);
				}
				while ((object)b6C != b6C2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public b1XG()
		{
			base.TableName = "RatingList";
			BeginInit();
			m2YH();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal b1XG(DataTable table)
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
		protected b1XG(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			Em5p();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void i8N3(Rd6 Yn7p)
		{
			base.Rows.Add(Yn7p);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Rd6 s2TW(string Jq5i, string Pm5y, string Pc27)
		{
			Rd6 rd = (Rd6)NewRow();
			object[] array2 = (rd.ItemArray = new object[4] { null, Jq5i, Pm5y, Pc27 });
			base.Rows.Add(rd);
			return rd;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Rd6 d5C3(int Lt3y)
		{
			return (Rd6)base.Rows.Find(new object[1] { Lt3y });
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Mq3x()
		{
			b1XG b1XG = (b1XG)base.Clone();
			b1XG.Em5p();
			return b1XG;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable n2PF()
		{
			return new b1XG();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void Em5p()
		{
			columnID = base.Columns["ID"];
			columnISBN = base.Columns["ISBN"];
			columnUserName = base.Columns["UserName"];
			columnStarcount = base.Columns["Starcount"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void m2YH()
		{
			columnID = new DataColumn("ID", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnID);
			columnISBN = new DataColumn("ISBN", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnISBN);
			columnUserName = new DataColumn("UserName", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnUserName);
			columnStarcount = new DataColumn("Starcount", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnStarcount);
			base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[1] { columnID }, isPrimaryKey: true));
			columnID.AutoIncrement = true;
			columnID.AutoIncrementSeed = -1L;
			columnID.AutoIncrementStep = -1L;
			columnID.AllowDBNull = false;
			columnID.Unique = true;
			columnISBN.MaxLength = 255;
			columnUserName.MaxLength = 255;
			columnStarcount.MaxLength = 255;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Rd6 x4CE()
		{
			return (Rd6)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow Np6d(DataRowBuilder Kk2x)
		{
			return new Rd6(Kk2x);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type j9ZG()
		{
			return typeof(Rd6);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void Bt59(DataRowChangeEventArgs Pr78)
		{
			base.OnRowChanged(Pr78);
			if (RatingListRowChangedEvent != null)
			{
				RatingListRowChangedEvent?.Invoke(this, new d1T((Rd6)Pr78.Row, Pr78.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void Cz37(DataRowChangeEventArgs c3SL)
		{
			base.OnRowChanging(c3SL);
			if (RatingListRowChangingEvent != null)
			{
				RatingListRowChangingEvent?.Invoke(this, new d1T((Rd6)c3SL.Row, c3SL.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void d7X3(DataRowChangeEventArgs y7QZ)
		{
			base.OnRowDeleted(y7QZ);
			if (RatingListRowDeletedEvent != null)
			{
				RatingListRowDeletedEvent?.Invoke(this, new d1T((Rd6)y7QZ.Row, y7QZ.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void f2WH(DataRowChangeEventArgs o6DR)
		{
			base.OnRowDeleting(o6DR);
			if (RatingListRowDeletingEvent != null)
			{
				RatingListRowDeletingEvent?.Invoke(this, new d1T((Rd6)o6DR.Row, o6DR.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void By2r(Rd6 t0QK)
		{
			base.Rows.Remove(t0QK);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType g8F3(XmlSchemaSet p2XG)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Di1 di = new Di1();
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
			xmlSchemaAttribute.FixedValue = di.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "RatingListDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema xmlSchema = di.m6M();
			if (p2XG.Contains(xmlSchema.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema2 = null;
					xmlSchema.Write(memoryStream);
					IEnumerator enumerator = p2XG.Schemas(xmlSchema.TargetNamespace).GetEnumerator();
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
			p2XG.Add(xmlSchema);
			return xmlSchemaComplexType;
		}
	}

	public class Zc34 : DataRow
	{
		private f8J tableBooks;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string ISBN
		{
			get
			{
				return Conversions.ToString(base[tableBooks.ISBNColumn]);
			}
			set
			{
				base[tableBooks.ISBNColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int Total
		{
			get
			{
				try
				{
					return Conversions.ToInteger(base[tableBooks.TotalColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'Total' in table 'Books' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableBooks.TotalColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int Remaining
		{
			get
			{
				try
				{
					return Conversions.ToInteger(base[tableBooks.RemainingColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'Remaining' in table 'Books' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableBooks.RemainingColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Location
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableBooks.LocationColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'Location' in table 'Books' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableBooks.LocationColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime PublishYear
		{
			get
			{
				try
				{
					return Conversions.ToDate(base[tableBooks.PublishYearColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PublishYear' in table 'Books' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableBooks.PublishYearColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Title
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableBooks.TitleColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'Title' in table 'Books' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableBooks.TitleColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Author
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableBooks.AuthorColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'Author' in table 'Books' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableBooks.AuthorColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Publisher
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableBooks.PublisherColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'Publisher' in table 'Books' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableBooks.PublisherColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Field
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableBooks.FieldColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'Field' in table 'Books' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableBooks.FieldColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string BookImage
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableBooks.BookImageColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BookImage' in table 'Books' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableBooks.BookImageColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public decimal Price
		{
			get
			{
				try
				{
					return Conversions.ToDecimal(base[tableBooks.PriceColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'Price' in table 'Books' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableBooks.PriceColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Zc34(DataRowBuilder rb)
			: base(rb)
		{
			tableBooks = (f8J)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool i5RN()
		{
			return IsNull(tableBooks.TotalColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Gd9i()
		{
			base[tableBooks.TotalColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool m0LA()
		{
			return IsNull(tableBooks.RemainingColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void z8WB()
		{
			base[tableBooks.RemainingColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool b6W2()
		{
			return IsNull(tableBooks.LocationColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Ns29()
		{
			base[tableBooks.LocationColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Nk98()
		{
			return IsNull(tableBooks.PublishYearColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void x7EX()
		{
			base[tableBooks.PublishYearColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool z4Y0()
		{
			return IsNull(tableBooks.TitleColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void y2M3()
		{
			base[tableBooks.TitleColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool s7RL()
		{
			return IsNull(tableBooks.AuthorColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void q1GZ()
		{
			base[tableBooks.AuthorColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool n9T3()
		{
			return IsNull(tableBooks.PublisherColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Ew71()
		{
			base[tableBooks.PublisherColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool To02()
		{
			return IsNull(tableBooks.FieldColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void o3K1()
		{
			base[tableBooks.FieldColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool m3NP()
		{
			return IsNull(tableBooks.BookImageColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void a9T7()
		{
			base[tableBooks.BookImageColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Kb94()
		{
			return IsNull(tableBooks.PriceColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void y8HN()
		{
			base[tableBooks.PriceColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	public class t1AL : DataRow
	{
		private m6P tableBorrowed;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int AccNo
		{
			get
			{
				return Conversions.ToInteger(base[tableBorrowed.AccNoColumn]);
			}
			set
			{
				base[tableBorrowed.AccNoColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string ISBN
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableBorrowed.ISBNColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'ISBN' in table 'Borrowed' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableBorrowed.ISBNColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string BorrowerId
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableBorrowed.BorrowerIdColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BorrowerId' in table 'Borrowed' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableBorrowed.BorrowerIdColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime IssueDate
		{
			get
			{
				try
				{
					return Conversions.ToDate(base[tableBorrowed.IssueDateColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'IssueDate' in table 'Borrowed' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableBorrowed.IssueDateColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime ReturnDate
		{
			get
			{
				try
				{
					return Conversions.ToDate(base[tableBorrowed.ReturnDateColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'ReturnDate' in table 'Borrowed' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableBorrowed.ReturnDateColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsIssued
		{
			get
			{
				try
				{
					return Conversions.ToBoolean(base[tableBorrowed.IsIssuedColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'IsIssued' in table 'Borrowed' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableBorrowed.IsIssuedColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public decimal Fine
		{
			get
			{
				try
				{
					return Conversions.ToDecimal(base[tableBorrowed.FineColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'Fine' in table 'Borrowed' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableBorrowed.FineColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int IssueCount
		{
			get
			{
				try
				{
					return Conversions.ToInteger(base[tableBorrowed.IssueCountColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'IssueCount' in table 'Borrowed' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableBorrowed.IssueCountColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal t1AL(DataRowBuilder rb)
			: base(rb)
		{
			tableBorrowed = (m6P)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool x4X()
		{
			return IsNull(tableBorrowed.ISBNColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void j3N()
		{
			base[tableBorrowed.ISBNColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Kc6()
		{
			return IsNull(tableBorrowed.BorrowerIdColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void c5G()
		{
			base[tableBorrowed.BorrowerIdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Tb7()
		{
			return IsNull(tableBorrowed.IssueDateColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void p2J()
		{
			base[tableBorrowed.IssueDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool c5Y()
		{
			return IsNull(tableBorrowed.ReturnDateColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void g3B()
		{
			base[tableBorrowed.ReturnDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool o3E()
		{
			return IsNull(tableBorrowed.IsIssuedColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Tt3()
		{
			base[tableBorrowed.IsIssuedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Nz8()
		{
			return IsNull(tableBorrowed.FineColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void g5A()
		{
			base[tableBorrowed.FineColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool t0M()
		{
			return IsNull(tableBorrowed.IssueCountColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Xd0()
		{
			base[tableBorrowed.IssueCountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	public class g2Z : DataRow
	{
		private Yz83 tableUsers;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int UserId
		{
			get
			{
				return Conversions.ToInteger(base[tableUsers.UserIdColumn]);
			}
			set
			{
				base[tableUsers.UserIdColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string ProfileName
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableUsers.ProfileNameColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'ProfileName' in table 'Users' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableUsers.ProfileNameColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string UserName
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableUsers.UserNameColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'UserName' in table 'Users' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableUsers.UserNameColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Password
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableUsers.PasswordColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'Password' in table 'Users' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableUsers.PasswordColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsAdmin
		{
			get
			{
				try
				{
					return Conversions.ToBoolean(base[tableUsers.IsAdminColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'IsAdmin' in table 'Users' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableUsers.IsAdminColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Email
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableUsers.EmailColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'Email' in table 'Users' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableUsers.EmailColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string PhoneNumber
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableUsers.PhoneNumberColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PhoneNumber' in table 'Users' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableUsers.PhoneNumberColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Department
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableUsers.DepartmentColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'Department' in table 'Users' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableUsers.DepartmentColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Designation
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableUsers.DesignationColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'Designation' in table 'Users' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableUsers.DesignationColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int TotalFine
		{
			get
			{
				try
				{
					return Conversions.ToInteger(base[tableUsers.TotalFineColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'TotalFine' in table 'Users' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableUsers.TotalFineColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int BooksIssued
		{
			get
			{
				try
				{
					return Conversions.ToInteger(base[tableUsers.BooksIssuedColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BooksIssued' in table 'Users' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableUsers.BooksIssuedColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string ProfileImage
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableUsers.ProfileImageColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'ProfileImage' in table 'Users' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableUsers.ProfileImageColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int MaxBooks
		{
			get
			{
				try
				{
					return Conversions.ToInteger(base[tableUsers.MaxBooksColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'MaxBooks' in table 'Users' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableUsers.MaxBooksColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal g2Z(DataRowBuilder rb)
			: base(rb)
		{
			tableUsers = (Yz83)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool j8J()
		{
			return IsNull(tableUsers.ProfileNameColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void w5N()
		{
			base[tableUsers.ProfileNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Ey8()
		{
			return IsNull(tableUsers.UserNameColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void p9D()
		{
			base[tableUsers.UserNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool e5D()
		{
			return IsNull(tableUsers.PasswordColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Cw1()
		{
			base[tableUsers.PasswordColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Zd6()
		{
			return IsNull(tableUsers.IsAdminColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Tz3()
		{
			base[tableUsers.IsAdminColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Ed3()
		{
			return IsNull(tableUsers.EmailColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void z4R()
		{
			base[tableUsers.EmailColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Tf9()
		{
			return IsNull(tableUsers.PhoneNumberColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void q1W()
		{
			base[tableUsers.PhoneNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool n2A()
		{
			return IsNull(tableUsers.DepartmentColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void a4C()
		{
			base[tableUsers.DepartmentColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool z1E()
		{
			return IsNull(tableUsers.DesignationColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Ca3()
		{
			base[tableUsers.DesignationColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Rf8()
		{
			return IsNull(tableUsers.TotalFineColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Nx7()
		{
			base[tableUsers.TotalFineColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Aw6()
		{
			return IsNull(tableUsers.BooksIssuedColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void s0F()
		{
			base[tableUsers.BooksIssuedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Dm7()
		{
			return IsNull(tableUsers.ProfileImageColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void t1C()
		{
			base[tableUsers.ProfileImageColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool q1P()
		{
			return IsNull(tableUsers.MaxBooksColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Yf4()
		{
			base[tableUsers.MaxBooksColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	public class Rd6 : DataRow
	{
		private b1XG tableRatingList;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int ID
		{
			get
			{
				return Conversions.ToInteger(base[tableRatingList.IDColumn]);
			}
			set
			{
				base[tableRatingList.IDColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string ISBN
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableRatingList.ISBNColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'ISBN' in table 'RatingList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableRatingList.ISBNColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string UserName
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableRatingList.UserNameColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'UserName' in table 'RatingList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableRatingList.UserNameColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Starcount
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableRatingList.StarcountColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'Starcount' in table 'RatingList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableRatingList.StarcountColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Rd6(DataRowBuilder rb)
			: base(rb)
		{
			tableRatingList = (b1XG)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool We6()
		{
			return IsNull(tableRatingList.ISBNColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void c9G()
		{
			base[tableRatingList.ISBNColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Kg7()
		{
			return IsNull(tableRatingList.UserNameColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void My1()
		{
			base[tableRatingList.UserNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool d6E()
		{
			return IsNull(tableRatingList.StarcountColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void c6J()
		{
			base[tableRatingList.StarcountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class w6P : EventArgs
	{
		private Zc34 eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Zc34 Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public w6P(Zc34 row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class Pb0 : EventArgs
	{
		private t1AL eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public t1AL Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Pb0(t1AL row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class o3T : EventArgs
	{
		private g2Z eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public g2Z Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public o3T(g2Z row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class d1T : EventArgs
	{
		private Rd6 eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Rd6 Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public d1T(Rd6 row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	private f8J tableBooks;

	private m6P tableBorrowed;

	private Yz83 tableUsers;

	private b1XG tableRatingList;

	private SchemaSerializationMode _schemaSerializationMode;

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public f8J Books => tableBooks;

	[Browsable(false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public m6P Borrowed => tableBorrowed;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public Yz83 Users => tableUsers;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	public b1XG RatingList => tableRatingList;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[Browsable(true)]
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public new DataTableCollection Tables => base.Tables;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public new DataRelationCollection Relations => base.Relations;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public Di1()
	{
		_schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		BeginInit();
		Kw9();
		CollectionChangeEventHandler value = c2M;
		base.Tables.CollectionChanged += value;
		base.Relations.CollectionChanged += value;
		EndInit();
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected Di1(SerializationInfo info, StreamingContext context)
		: base(info, context, ConstructSchema: false)
	{
		_schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		if (IsBinarySerialized(info, context))
		{
			Pp8(i9A: false);
			CollectionChangeEventHandler value = c2M;
			Tables.CollectionChanged += value;
			Relations.CollectionChanged += value;
			return;
		}
		string s = Conversions.ToString(info.GetValue("XmlSchema", typeof(string)));
		if (DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
		{
			DataSet dataSet = new DataSet();
			dataSet.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
			if (dataSet.Tables["Books"] != null)
			{
				base.Tables.Add(new f8J(dataSet.Tables["Books"]));
			}
			if (dataSet.Tables["Borrowed"] != null)
			{
				base.Tables.Add(new m6P(dataSet.Tables["Borrowed"]));
			}
			if (dataSet.Tables["Users"] != null)
			{
				base.Tables.Add(new Yz83(dataSet.Tables["Users"]));
			}
			if (dataSet.Tables["RatingList"] != null)
			{
				base.Tables.Add(new b1XG(dataSet.Tables["RatingList"]));
			}
			base.DataSetName = dataSet.DataSetName;
			base.Prefix = dataSet.Prefix;
			base.Namespace = dataSet.Namespace;
			base.Locale = dataSet.Locale;
			base.CaseSensitive = dataSet.CaseSensitive;
			base.EnforceConstraints = dataSet.EnforceConstraints;
			Merge(dataSet, preserveChanges: false, MissingSchemaAction.Add);
			q8Z();
		}
		else
		{
			ReadXmlSchema(new XmlTextReader(new StringReader(s)));
		}
		GetSerializationData(info, context);
		CollectionChangeEventHandler value2 = c2M;
		base.Tables.CollectionChanged += value2;
		Relations.CollectionChanged += value2;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected override void Jb1()
	{
		BeginInit();
		Kw9();
		EndInit();
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public override DataSet Ge4()
	{
		Di1 di = (Di1)base.Clone();
		di.q8Z();
		di.SchemaSerializationMode = SchemaSerializationMode;
		return di;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected override bool x9Y()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected override bool j6Y()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected override void r1F(XmlReader Jo0)
	{
		if (DetermineSchemaSerializationMode(Jo0) == SchemaSerializationMode.IncludeSchema)
		{
			Reset();
			DataSet dataSet = new DataSet();
			dataSet.ReadXml(Jo0);
			if (dataSet.Tables["Books"] != null)
			{
				base.Tables.Add(new f8J(dataSet.Tables["Books"]));
			}
			if (dataSet.Tables["Borrowed"] != null)
			{
				base.Tables.Add(new m6P(dataSet.Tables["Borrowed"]));
			}
			if (dataSet.Tables["Users"] != null)
			{
				base.Tables.Add(new Yz83(dataSet.Tables["Users"]));
			}
			if (dataSet.Tables["RatingList"] != null)
			{
				base.Tables.Add(new b1XG(dataSet.Tables["RatingList"]));
			}
			base.DataSetName = dataSet.DataSetName;
			base.Prefix = dataSet.Prefix;
			base.Namespace = dataSet.Namespace;
			base.Locale = dataSet.Locale;
			base.CaseSensitive = dataSet.CaseSensitive;
			base.EnforceConstraints = dataSet.EnforceConstraints;
			Merge(dataSet, preserveChanges: false, MissingSchemaAction.Add);
			q8Z();
		}
		else
		{
			ReadXml(Jo0);
			q8Z();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected override XmlSchema m6M()
	{
		MemoryStream memoryStream = new MemoryStream();
		WriteXmlSchema(new XmlTextWriter(memoryStream, null));
		memoryStream.Position = 0L;
		return XmlSchema.Read(new XmlTextReader(memoryStream), null);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	internal void q8Z()
	{
		Pp8(i9A: true);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	internal void Pp8(bool i9A)
	{
		tableBooks = (f8J)base.Tables["Books"];
		if (i9A && tableBooks != null)
		{
			tableBooks.Re6();
		}
		tableBorrowed = (m6P)base.Tables["Borrowed"];
		if (i9A && tableBorrowed != null)
		{
			tableBorrowed.Ej0();
		}
		tableUsers = (Yz83)base.Tables["Users"];
		if (i9A && tableUsers != null)
		{
			tableUsers.w0AB();
		}
		tableRatingList = (b1XG)base.Tables["RatingList"];
		if (i9A && tableRatingList != null)
		{
			tableRatingList.Em5p();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void Kw9()
	{
		base.DataSetName = "DatabaseDataSet1";
		base.Prefix = "";
		base.Namespace = "http://tempuri.org/DatabaseDataSet1.xsd";
		base.EnforceConstraints = true;
		SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		tableBooks = new f8J();
		base.Tables.Add(tableBooks);
		tableBorrowed = new m6P();
		base.Tables.Add(tableBorrowed);
		tableUsers = new Yz83();
		base.Tables.Add(tableUsers);
		tableRatingList = new b1XG();
		base.Tables.Add(tableRatingList);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool Ne5()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool Ha5()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool o9Q()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool Cs8()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void c2M(object sender, CollectionChangeEventArgs e)
	{
		if (e.Action == CollectionChangeAction.Remove)
		{
			q8Z();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public static XmlSchemaComplexType Ff1(XmlSchemaSet j5A)
	{
		Di1 di = new Di1();
		XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
		XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
		XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
		xmlSchemaAny.Namespace = di.Namespace;
		xmlSchemaSequence.Items.Add(xmlSchemaAny);
		xmlSchemaComplexType.Particle = xmlSchemaSequence;
		XmlSchema xmlSchema = di.m6M();
		if (j5A.Contains(xmlSchema.TargetNamespace))
		{
			MemoryStream memoryStream = new MemoryStream();
			MemoryStream memoryStream2 = new MemoryStream();
			try
			{
				XmlSchema xmlSchema2 = null;
				xmlSchema.Write(memoryStream);
				IEnumerator enumerator = j5A.Schemas(xmlSchema.TargetNamespace).GetEnumerator();
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
		j5A.Add(xmlSchema);
		return xmlSchemaComplexType;
	}
}
