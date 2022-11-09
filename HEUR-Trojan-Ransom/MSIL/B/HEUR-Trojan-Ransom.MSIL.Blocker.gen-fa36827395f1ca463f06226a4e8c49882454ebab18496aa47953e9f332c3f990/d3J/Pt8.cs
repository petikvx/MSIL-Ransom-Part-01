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

namespace d3J;

[Serializable]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("DatabaseDataSet")]
[DesignerCategory("code")]
[HelpKeyword("vs.data.DataSet")]
public class Pt8 : DataSet
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void Zg93(object sender, Pf0o e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void i0S4(object sender, z6C7 e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void Gd68(object sender, Xs1c e);

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class Yg56 : TypedTableBase<g1GW>
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

		private DataColumn columnImage;

		private Zg93 BooksRowChangingEvent;

		private Zg93 BooksRowChangedEvent;

		private Zg93 BooksRowDeletingEvent;

		private Zg93 BooksRowDeletedEvent;

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
		public DataColumn ImageColumn => columnImage;

		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int Count => base.Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public g1GW this[int Zn7y] => (g1GW)base.Rows[Zn7y];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Zg93 BooksRowChanging
		{
			add
			{
				Zg93 zg = BooksRowChangingEvent;
				Zg93 zg2;
				do
				{
					zg2 = zg;
					Zg93 value2 = (Zg93)Delegate.Combine(zg2, value);
					zg = Interlocked.CompareExchange(ref BooksRowChangingEvent, value2, zg2);
				}
				while ((object)zg != zg2);
			}
			remove
			{
				Zg93 zg = BooksRowChangingEvent;
				Zg93 zg2;
				do
				{
					zg2 = zg;
					Zg93 value2 = (Zg93)Delegate.Remove(zg2, value);
					zg = Interlocked.CompareExchange(ref BooksRowChangingEvent, value2, zg2);
				}
				while ((object)zg != zg2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Zg93 BooksRowChanged
		{
			add
			{
				Zg93 zg = BooksRowChangedEvent;
				Zg93 zg2;
				do
				{
					zg2 = zg;
					Zg93 value2 = (Zg93)Delegate.Combine(zg2, value);
					zg = Interlocked.CompareExchange(ref BooksRowChangedEvent, value2, zg2);
				}
				while ((object)zg != zg2);
			}
			remove
			{
				Zg93 zg = BooksRowChangedEvent;
				Zg93 zg2;
				do
				{
					zg2 = zg;
					Zg93 value2 = (Zg93)Delegate.Remove(zg2, value);
					zg = Interlocked.CompareExchange(ref BooksRowChangedEvent, value2, zg2);
				}
				while ((object)zg != zg2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Zg93 BooksRowDeleting
		{
			add
			{
				Zg93 zg = BooksRowDeletingEvent;
				Zg93 zg2;
				do
				{
					zg2 = zg;
					Zg93 value2 = (Zg93)Delegate.Combine(zg2, value);
					zg = Interlocked.CompareExchange(ref BooksRowDeletingEvent, value2, zg2);
				}
				while ((object)zg != zg2);
			}
			remove
			{
				Zg93 zg = BooksRowDeletingEvent;
				Zg93 zg2;
				do
				{
					zg2 = zg;
					Zg93 value2 = (Zg93)Delegate.Remove(zg2, value);
					zg = Interlocked.CompareExchange(ref BooksRowDeletingEvent, value2, zg2);
				}
				while ((object)zg != zg2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Zg93 BooksRowDeleted
		{
			add
			{
				Zg93 zg = BooksRowDeletedEvent;
				Zg93 zg2;
				do
				{
					zg2 = zg;
					Zg93 value2 = (Zg93)Delegate.Combine(zg2, value);
					zg = Interlocked.CompareExchange(ref BooksRowDeletedEvent, value2, zg2);
				}
				while ((object)zg != zg2);
			}
			remove
			{
				Zg93 zg = BooksRowDeletedEvent;
				Zg93 zg2;
				do
				{
					zg2 = zg;
					Zg93 value2 = (Zg93)Delegate.Remove(zg2, value);
					zg = Interlocked.CompareExchange(ref BooksRowDeletedEvent, value2, zg2);
				}
				while ((object)zg != zg2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Yg56()
		{
			base.TableName = "Books";
			BeginInit();
			p7BS();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Yg56(DataTable table)
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
		protected Yg56(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			Cx7b();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void e0F4(g1GW Xw3d)
		{
			base.Rows.Add(Xw3d);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public g1GW Wq3i(int s5ZT, int Zc84, int r7J6, int Ki2s, DateTime e1BR, string We45, string w3WK, string n6M7, string Zn0b, string Sj27)
		{
			g1GW g1GW = (g1GW)NewRow();
			object[] array2 = (g1GW.ItemArray = new object[10] { s5ZT, Zc84, r7J6, Ki2s, e1BR, We45, w3WK, n6M7, Zn0b, Sj27 });
			base.Rows.Add(g1GW);
			return g1GW;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public g1GW z4EY(int Nm76)
		{
			return (g1GW)base.Rows.Find(new object[1] { Nm76 });
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Qe8g()
		{
			Yg56 yg = (Yg56)base.Clone();
			yg.Cx7b();
			return yg;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable g7RG()
		{
			return new Yg56();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void Cx7b()
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
			columnImage = base.Columns["Image"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void p7BS()
		{
			columnISBN = new DataColumn("ISBN", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnISBN);
			columnTotal = new DataColumn("Total", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnTotal);
			columnRemaining = new DataColumn("Remaining", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnRemaining);
			columnLocation = new DataColumn("Location", typeof(int), null, MappingType.Element);
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
			columnImage = new DataColumn("Image", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnImage);
			base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[1] { columnISBN }, isPrimaryKey: true));
			columnISBN.AllowDBNull = false;
			columnISBN.Unique = true;
			columnTitle.MaxLength = 255;
			columnAuthor.MaxLength = 255;
			columnPublisher.MaxLength = 255;
			columnField.MaxLength = 255;
			columnImage.MaxLength = 255;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public g1GW Rr3n()
		{
			return (g1GW)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow q4Y5(DataRowBuilder Xf51)
		{
			return new g1GW(Xf51);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type j6Y1()
		{
			return typeof(g1GW);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void Zx7g(DataRowChangeEventArgs g6HQ)
		{
			base.OnRowChanged(g6HQ);
			if (BooksRowChangedEvent != null)
			{
				BooksRowChangedEvent?.Invoke(this, new Pf0o((g1GW)g6HQ.Row, g6HQ.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void Wt28(DataRowChangeEventArgs Qj86)
		{
			base.OnRowChanging(Qj86);
			if (BooksRowChangingEvent != null)
			{
				BooksRowChangingEvent?.Invoke(this, new Pf0o((g1GW)Qj86.Row, Qj86.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void Gz34(DataRowChangeEventArgs Xt5g)
		{
			base.OnRowDeleted(Xt5g);
			if (BooksRowDeletedEvent != null)
			{
				BooksRowDeletedEvent?.Invoke(this, new Pf0o((g1GW)Xt5g.Row, Xt5g.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void Ts91(DataRowChangeEventArgs La6y)
		{
			base.OnRowDeleting(La6y);
			if (BooksRowDeletingEvent != null)
			{
				BooksRowDeletingEvent?.Invoke(this, new Pf0o((g1GW)La6y.Row, La6y.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Sp50(g1GW Me8f)
		{
			base.Rows.Remove(Me8f);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType o5JL(XmlSchemaSet Hs24)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Pt8 pt = new Pt8();
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
			xmlSchemaAttribute.FixedValue = pt.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "BooksDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema xmlSchema = pt.Rt5();
			if (Hs24.Contains(xmlSchema.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema2 = null;
					xmlSchema.Write(memoryStream);
					IEnumerator enumerator = Hs24.Schemas(xmlSchema.TargetNamespace).GetEnumerator();
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
			Hs24.Add(xmlSchema);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class Qq46 : TypedTableBase<As17>
	{
		private DataColumn columnAccNo;

		private DataColumn columnISBN;

		private DataColumn columnBorrowerId;

		private DataColumn columnIssueDate;

		private DataColumn columnReturnDate;

		private DataColumn columnIsIssued;

		private DataColumn columnFine;

		private i0S4 BorrowedRowChangingEvent;

		private i0S4 BorrowedRowChangedEvent;

		private i0S4 BorrowedRowDeletingEvent;

		private i0S4 BorrowedRowDeletedEvent;

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

		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int Count => base.Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public As17 this[int Gn56] => (As17)base.Rows[Gn56];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event i0S4 BorrowedRowChanging
		{
			add
			{
				i0S4 i0S = BorrowedRowChangingEvent;
				i0S4 i0S2;
				do
				{
					i0S2 = i0S;
					i0S4 value2 = (i0S4)Delegate.Combine(i0S2, value);
					i0S = Interlocked.CompareExchange(ref BorrowedRowChangingEvent, value2, i0S2);
				}
				while ((object)i0S != i0S2);
			}
			remove
			{
				i0S4 i0S = BorrowedRowChangingEvent;
				i0S4 i0S2;
				do
				{
					i0S2 = i0S;
					i0S4 value2 = (i0S4)Delegate.Remove(i0S2, value);
					i0S = Interlocked.CompareExchange(ref BorrowedRowChangingEvent, value2, i0S2);
				}
				while ((object)i0S != i0S2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event i0S4 BorrowedRowChanged
		{
			add
			{
				i0S4 i0S = BorrowedRowChangedEvent;
				i0S4 i0S2;
				do
				{
					i0S2 = i0S;
					i0S4 value2 = (i0S4)Delegate.Combine(i0S2, value);
					i0S = Interlocked.CompareExchange(ref BorrowedRowChangedEvent, value2, i0S2);
				}
				while ((object)i0S != i0S2);
			}
			remove
			{
				i0S4 i0S = BorrowedRowChangedEvent;
				i0S4 i0S2;
				do
				{
					i0S2 = i0S;
					i0S4 value2 = (i0S4)Delegate.Remove(i0S2, value);
					i0S = Interlocked.CompareExchange(ref BorrowedRowChangedEvent, value2, i0S2);
				}
				while ((object)i0S != i0S2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event i0S4 BorrowedRowDeleting
		{
			add
			{
				i0S4 i0S = BorrowedRowDeletingEvent;
				i0S4 i0S2;
				do
				{
					i0S2 = i0S;
					i0S4 value2 = (i0S4)Delegate.Combine(i0S2, value);
					i0S = Interlocked.CompareExchange(ref BorrowedRowDeletingEvent, value2, i0S2);
				}
				while ((object)i0S != i0S2);
			}
			remove
			{
				i0S4 i0S = BorrowedRowDeletingEvent;
				i0S4 i0S2;
				do
				{
					i0S2 = i0S;
					i0S4 value2 = (i0S4)Delegate.Remove(i0S2, value);
					i0S = Interlocked.CompareExchange(ref BorrowedRowDeletingEvent, value2, i0S2);
				}
				while ((object)i0S != i0S2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event i0S4 BorrowedRowDeleted
		{
			add
			{
				i0S4 i0S = BorrowedRowDeletedEvent;
				i0S4 i0S2;
				do
				{
					i0S2 = i0S;
					i0S4 value2 = (i0S4)Delegate.Combine(i0S2, value);
					i0S = Interlocked.CompareExchange(ref BorrowedRowDeletedEvent, value2, i0S2);
				}
				while ((object)i0S != i0S2);
			}
			remove
			{
				i0S4 i0S = BorrowedRowDeletedEvent;
				i0S4 i0S2;
				do
				{
					i0S2 = i0S;
					i0S4 value2 = (i0S4)Delegate.Remove(i0S2, value);
					i0S = Interlocked.CompareExchange(ref BorrowedRowDeletedEvent, value2, i0S2);
				}
				while ((object)i0S != i0S2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Qq46()
		{
			base.TableName = "Borrowed";
			BeginInit();
			Az87();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Qq46(DataTable table)
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
		protected Qq46(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			p4Z1();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Ty3j(As17 Zf25)
		{
			base.Rows.Add(Zf25);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public As17 Bn8y(string j3H4, j3CW Sr47, DateTime a0K4, DateTime Pc9q, bool Rz04, decimal j0DM)
		{
			As17 @as = (As17)NewRow();
			object[] array = new object[7] { null, j3H4, null, a0K4, Pc9q, Rz04, j0DM };
			if (Sr47 != null)
			{
				array[2] = RuntimeHelpers.GetObjectValue(Sr47[0]);
			}
			@as.ItemArray = array;
			base.Rows.Add(@as);
			return @as;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public As17 f6EB(int Lj0d)
		{
			return (As17)base.Rows.Find(new object[1] { Lj0d });
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable d8E0()
		{
			Qq46 qq = (Qq46)base.Clone();
			qq.p4Z1();
			return qq;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable i8TX()
		{
			return new Qq46();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void p4Z1()
		{
			columnAccNo = base.Columns["AccNo"];
			columnISBN = base.Columns["ISBN"];
			columnBorrowerId = base.Columns["BorrowerId"];
			columnIssueDate = base.Columns["IssueDate"];
			columnReturnDate = base.Columns["ReturnDate"];
			columnIsIssued = base.Columns["IsIssued"];
			columnFine = base.Columns["Fine"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void Az87()
		{
			columnAccNo = new DataColumn("AccNo", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnAccNo);
			columnISBN = new DataColumn("ISBN", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnISBN);
			columnBorrowerId = new DataColumn("BorrowerId", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnBorrowerId);
			columnIssueDate = new DataColumn("IssueDate", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnIssueDate);
			columnReturnDate = new DataColumn("ReturnDate", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnReturnDate);
			columnIsIssued = new DataColumn("IsIssued", typeof(bool), null, MappingType.Element);
			base.Columns.Add(columnIsIssued);
			columnFine = new DataColumn("Fine", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnFine);
			base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[1] { columnAccNo }, isPrimaryKey: true));
			columnAccNo.AutoIncrement = true;
			columnAccNo.AutoIncrementSeed = -1L;
			columnAccNo.AutoIncrementStep = -1L;
			columnAccNo.AllowDBNull = false;
			columnAccNo.Unique = true;
			columnISBN.MaxLength = 536870910;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public As17 Tj9q()
		{
			return (As17)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow Jq85(DataRowBuilder s6PX)
		{
			return new As17(s6PX);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type s2FP()
		{
			return typeof(As17);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void e3W8(DataRowChangeEventArgs Jr6t)
		{
			base.OnRowChanged(Jr6t);
			if (BorrowedRowChangedEvent != null)
			{
				BorrowedRowChangedEvent?.Invoke(this, new z6C7((As17)Jr6t.Row, Jr6t.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void Rr7p(DataRowChangeEventArgs Cy9t)
		{
			base.OnRowChanging(Cy9t);
			if (BorrowedRowChangingEvent != null)
			{
				BorrowedRowChangingEvent?.Invoke(this, new z6C7((As17)Cy9t.Row, Cy9t.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void s9T3(DataRowChangeEventArgs St9q)
		{
			base.OnRowDeleted(St9q);
			if (BorrowedRowDeletedEvent != null)
			{
				BorrowedRowDeletedEvent?.Invoke(this, new z6C7((As17)St9q.Row, St9q.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void x7Q4(DataRowChangeEventArgs Nd37)
		{
			base.OnRowDeleting(Nd37);
			if (BorrowedRowDeletingEvent != null)
			{
				BorrowedRowDeletingEvent?.Invoke(this, new z6C7((As17)Nd37.Row, Nd37.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void p8G9(As17 g8QX)
		{
			base.Rows.Remove(g8QX);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType Fn68(XmlSchemaSet Jg8q)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Pt8 pt = new Pt8();
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
			xmlSchemaAttribute.FixedValue = pt.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "BorrowedDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema xmlSchema = pt.Rt5();
			if (Jg8q.Contains(xmlSchema.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema2 = null;
					xmlSchema.Write(memoryStream);
					IEnumerator enumerator = Jg8q.Schemas(xmlSchema.TargetNamespace).GetEnumerator();
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
			Jg8q.Add(xmlSchema);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class Gd8q : TypedTableBase<j3CW>
	{
		private DataColumn columnUserId;

		private DataColumn columnUserName;

		private DataColumn columnPassword;

		private DataColumn columnIsAdmin;

		private DataColumn columnEmail;

		private DataColumn columnPhoneNumber;

		private DataColumn columnDepartment;

		private DataColumn columnDesignation;

		private DataColumn columnTotalFine;

		private DataColumn columnImage;

		private DataColumn columnBooksIssued;

		private DataColumn columnMaxBooks;

		private Gd68 UserRowChangingEvent;

		private Gd68 UserRowChangedEvent;

		private Gd68 UserRowDeletingEvent;

		private Gd68 UserRowDeletedEvent;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn UserIdColumn => columnUserId;

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
		public DataColumn ImageColumn => columnImage;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BooksIssuedColumn => columnBooksIssued;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn MaxBooksColumn => columnMaxBooks;

		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int Count => base.Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public j3CW this[int b2XZ] => (j3CW)base.Rows[b2XZ];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Gd68 UserRowChanging
		{
			add
			{
				Gd68 gd = UserRowChangingEvent;
				Gd68 gd2;
				do
				{
					gd2 = gd;
					Gd68 value2 = (Gd68)Delegate.Combine(gd2, value);
					gd = Interlocked.CompareExchange(ref UserRowChangingEvent, value2, gd2);
				}
				while ((object)gd != gd2);
			}
			remove
			{
				Gd68 gd = UserRowChangingEvent;
				Gd68 gd2;
				do
				{
					gd2 = gd;
					Gd68 value2 = (Gd68)Delegate.Remove(gd2, value);
					gd = Interlocked.CompareExchange(ref UserRowChangingEvent, value2, gd2);
				}
				while ((object)gd != gd2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Gd68 UserRowChanged
		{
			add
			{
				Gd68 gd = UserRowChangedEvent;
				Gd68 gd2;
				do
				{
					gd2 = gd;
					Gd68 value2 = (Gd68)Delegate.Combine(gd2, value);
					gd = Interlocked.CompareExchange(ref UserRowChangedEvent, value2, gd2);
				}
				while ((object)gd != gd2);
			}
			remove
			{
				Gd68 gd = UserRowChangedEvent;
				Gd68 gd2;
				do
				{
					gd2 = gd;
					Gd68 value2 = (Gd68)Delegate.Remove(gd2, value);
					gd = Interlocked.CompareExchange(ref UserRowChangedEvent, value2, gd2);
				}
				while ((object)gd != gd2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Gd68 UserRowDeleting
		{
			add
			{
				Gd68 gd = UserRowDeletingEvent;
				Gd68 gd2;
				do
				{
					gd2 = gd;
					Gd68 value2 = (Gd68)Delegate.Combine(gd2, value);
					gd = Interlocked.CompareExchange(ref UserRowDeletingEvent, value2, gd2);
				}
				while ((object)gd != gd2);
			}
			remove
			{
				Gd68 gd = UserRowDeletingEvent;
				Gd68 gd2;
				do
				{
					gd2 = gd;
					Gd68 value2 = (Gd68)Delegate.Remove(gd2, value);
					gd = Interlocked.CompareExchange(ref UserRowDeletingEvent, value2, gd2);
				}
				while ((object)gd != gd2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Gd68 UserRowDeleted
		{
			add
			{
				Gd68 gd = UserRowDeletedEvent;
				Gd68 gd2;
				do
				{
					gd2 = gd;
					Gd68 value2 = (Gd68)Delegate.Combine(gd2, value);
					gd = Interlocked.CompareExchange(ref UserRowDeletedEvent, value2, gd2);
				}
				while ((object)gd != gd2);
			}
			remove
			{
				Gd68 gd = UserRowDeletedEvent;
				Gd68 gd2;
				do
				{
					gd2 = gd;
					Gd68 value2 = (Gd68)Delegate.Remove(gd2, value);
					gd = Interlocked.CompareExchange(ref UserRowDeletedEvent, value2, gd2);
				}
				while ((object)gd != gd2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Gd8q()
		{
			base.TableName = "User";
			BeginInit();
			Ta9c();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Gd8q(DataTable table)
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
		protected Gd8q(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			o1T0();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Jc0j(j3CW m3F6)
		{
			base.Rows.Add(m3F6);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public j3CW Md35(string Dk1t, string Ei1d, bool a6Z8, string Ne5w, int g1J9, string Ew20, string g8E7, int Ye8o, string Zt6m, int Gx72, int Tn40)
		{
			j3CW j3CW = (j3CW)NewRow();
			object[] array2 = (j3CW.ItemArray = new object[12]
			{
				null, Dk1t, Ei1d, a6Z8, Ne5w, g1J9, Ew20, g8E7, Ye8o, Zt6m,
				Gx72, Tn40
			});
			base.Rows.Add(j3CW);
			return j3CW;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public j3CW De2f(int j5G4)
		{
			return (j3CW)base.Rows.Find(new object[1] { j5G4 });
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Qw36()
		{
			Gd8q gd8q = (Gd8q)base.Clone();
			gd8q.o1T0();
			return gd8q;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable Ss7g()
		{
			return new Gd8q();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void o1T0()
		{
			columnUserId = base.Columns["UserId"];
			columnUserName = base.Columns["UserName"];
			columnPassword = base.Columns["Password"];
			columnIsAdmin = base.Columns["IsAdmin"];
			columnEmail = base.Columns["Email"];
			columnPhoneNumber = base.Columns["PhoneNumber"];
			columnDepartment = base.Columns["Department"];
			columnDesignation = base.Columns["Designation"];
			columnTotalFine = base.Columns["TotalFine"];
			columnImage = base.Columns["Image"];
			columnBooksIssued = base.Columns["BooksIssued"];
			columnMaxBooks = base.Columns["MaxBooks"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void Ta9c()
		{
			columnUserId = new DataColumn("UserId", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnUserId);
			columnUserName = new DataColumn("UserName", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnUserName);
			columnPassword = new DataColumn("Password", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnPassword);
			columnIsAdmin = new DataColumn("IsAdmin", typeof(bool), null, MappingType.Element);
			base.Columns.Add(columnIsAdmin);
			columnEmail = new DataColumn("Email", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnEmail);
			columnPhoneNumber = new DataColumn("PhoneNumber", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnPhoneNumber);
			columnDepartment = new DataColumn("Department", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDepartment);
			columnDesignation = new DataColumn("Designation", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDesignation);
			columnTotalFine = new DataColumn("TotalFine", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnTotalFine);
			columnImage = new DataColumn("Image", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnImage);
			columnBooksIssued = new DataColumn("BooksIssued", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnBooksIssued);
			columnMaxBooks = new DataColumn("MaxBooks", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnMaxBooks);
			base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[1] { columnUserId }, isPrimaryKey: true));
			columnUserId.AutoIncrement = true;
			columnUserId.AutoIncrementSeed = -1L;
			columnUserId.AutoIncrementStep = -1L;
			columnUserId.AllowDBNull = false;
			columnUserId.Unique = true;
			columnUserName.MaxLength = 255;
			columnPassword.MaxLength = 536870910;
			columnEmail.MaxLength = 536870910;
			columnDepartment.MaxLength = 255;
			columnDesignation.MaxLength = 255;
			columnImage.MaxLength = 536870910;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public j3CW Re7w()
		{
			return (j3CW)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow e2Z0(DataRowBuilder m6GJ)
		{
			return new j3CW(m6GJ);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type n6SW()
		{
			return typeof(j3CW);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void Yp94(DataRowChangeEventArgs g4F2)
		{
			base.OnRowChanged(g4F2);
			if (UserRowChangedEvent != null)
			{
				UserRowChangedEvent?.Invoke(this, new Xs1c((j3CW)g4F2.Row, g4F2.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void Kr2t(DataRowChangeEventArgs q5XE)
		{
			base.OnRowChanging(q5XE);
			if (UserRowChangingEvent != null)
			{
				UserRowChangingEvent?.Invoke(this, new Xs1c((j3CW)q5XE.Row, q5XE.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void At53(DataRowChangeEventArgs s4HB)
		{
			base.OnRowDeleted(s4HB);
			if (UserRowDeletedEvent != null)
			{
				UserRowDeletedEvent?.Invoke(this, new Xs1c((j3CW)s4HB.Row, s4HB.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void n3K1(DataRowChangeEventArgs r1F8)
		{
			base.OnRowDeleting(r1F8);
			if (UserRowDeletingEvent != null)
			{
				UserRowDeletingEvent?.Invoke(this, new Xs1c((j3CW)r1F8.Row, r1F8.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Er3k(j3CW m8WZ)
		{
			base.Rows.Remove(m8WZ);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType g2MN(XmlSchemaSet Zq93)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Pt8 pt = new Pt8();
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
			xmlSchemaAttribute.FixedValue = pt.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "UserDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema xmlSchema = pt.Rt5();
			if (Zq93.Contains(xmlSchema.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema2 = null;
					xmlSchema.Write(memoryStream);
					IEnumerator enumerator = Zq93.Schemas(xmlSchema.TargetNamespace).GetEnumerator();
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
			Zq93.Add(xmlSchema);
			return xmlSchemaComplexType;
		}
	}

	public class g1GW : DataRow
	{
		private Yg56 tableBooks;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int ISBN
		{
			get
			{
				return Conversions.ToInteger(base[tableBooks.ISBNColumn]);
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
		public int Location
		{
			get
			{
				try
				{
					return Conversions.ToInteger(base[tableBooks.LocationColumn]);
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
		public string Image
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableBooks.ImageColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'Image' in table 'Books' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableBooks.ImageColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal g1GW(DataRowBuilder rb)
			: base(rb)
		{
			tableBooks = (Yg56)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Cn52()
		{
			return IsNull(tableBooks.TotalColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void p3CY()
		{
			base[tableBooks.TotalColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Sy7e()
		{
			return IsNull(tableBooks.RemainingColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void i4CG()
		{
			base[tableBooks.RemainingColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Bo01()
		{
			return IsNull(tableBooks.LocationColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Hg3r()
		{
			base[tableBooks.LocationColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool g2TA()
		{
			return IsNull(tableBooks.PublishYearColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void c2PF()
		{
			base[tableBooks.PublishYearColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool z7ET()
		{
			return IsNull(tableBooks.TitleColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Kt9k()
		{
			base[tableBooks.TitleColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Bf8z()
		{
			return IsNull(tableBooks.AuthorColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void f9R1()
		{
			base[tableBooks.AuthorColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool r7MB()
		{
			return IsNull(tableBooks.PublisherColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void f4YM()
		{
			base[tableBooks.PublisherColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Wk8s()
		{
			return IsNull(tableBooks.FieldColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Wc40()
		{
			base[tableBooks.FieldColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool c1N6()
		{
			return IsNull(tableBooks.ImageColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Ro72()
		{
			base[tableBooks.ImageColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	public class As17 : DataRow
	{
		private Qq46 tableBorrowed;

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
		public int BorrowerId
		{
			get
			{
				try
				{
					return Conversions.ToInteger(base[tableBorrowed.BorrowerIdColumn]);
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
		public j3CW UserRow
		{
			get
			{
				return (j3CW)GetParentRow(base.Table.ParentRelations["UserBorrowed"]);
			}
			set
			{
				SetParentRow(value, base.Table.ParentRelations["UserBorrowed"]);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal As17(DataRowBuilder rb)
			: base(rb)
		{
			tableBorrowed = (Qq46)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Lp95()
		{
			return IsNull(tableBorrowed.ISBNColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Nr18()
		{
			base[tableBorrowed.ISBNColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Bd2g()
		{
			return IsNull(tableBorrowed.BorrowerIdColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Zr9m()
		{
			base[tableBorrowed.BorrowerIdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Fg24()
		{
			return IsNull(tableBorrowed.IssueDateColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void d7XA()
		{
			base[tableBorrowed.IssueDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool m4TK()
		{
			return IsNull(tableBorrowed.ReturnDateColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void g6X0()
		{
			base[tableBorrowed.ReturnDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool o1K2()
		{
			return IsNull(tableBorrowed.IsIssuedColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Tq1j()
		{
			base[tableBorrowed.IsIssuedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Cg04()
		{
			return IsNull(tableBorrowed.FineColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Ha37()
		{
			base[tableBorrowed.FineColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	public class j3CW : DataRow
	{
		private Gd8q tableUser;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int UserId
		{
			get
			{
				return Conversions.ToInteger(base[tableUser.UserIdColumn]);
			}
			set
			{
				base[tableUser.UserIdColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string UserName
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableUser.UserNameColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'UserName' in table 'User' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableUser.UserNameColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Password
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableUser.PasswordColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'Password' in table 'User' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableUser.PasswordColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsAdmin
		{
			get
			{
				try
				{
					return Conversions.ToBoolean(base[tableUser.IsAdminColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'IsAdmin' in table 'User' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableUser.IsAdminColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Email
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableUser.EmailColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'Email' in table 'User' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableUser.EmailColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int PhoneNumber
		{
			get
			{
				try
				{
					return Conversions.ToInteger(base[tableUser.PhoneNumberColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PhoneNumber' in table 'User' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableUser.PhoneNumberColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Department
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableUser.DepartmentColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'Department' in table 'User' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableUser.DepartmentColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Designation
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableUser.DesignationColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'Designation' in table 'User' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableUser.DesignationColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int TotalFine
		{
			get
			{
				try
				{
					return Conversions.ToInteger(base[tableUser.TotalFineColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'TotalFine' in table 'User' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableUser.TotalFineColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Image
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableUser.ImageColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'Image' in table 'User' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableUser.ImageColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int BooksIssued
		{
			get
			{
				try
				{
					return Conversions.ToInteger(base[tableUser.BooksIssuedColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BooksIssued' in table 'User' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableUser.BooksIssuedColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int MaxBooks
		{
			get
			{
				try
				{
					return Conversions.ToInteger(base[tableUser.MaxBooksColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError((Exception)ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'MaxBooks' in table 'User' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableUser.MaxBooksColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal j3CW(DataRowBuilder rb)
			: base(rb)
		{
			tableUser = (Gd8q)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool r5T4()
		{
			return IsNull(tableUser.UserNameColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Kw25()
		{
			base[tableUser.UserNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool m5NA()
		{
			return IsNull(tableUser.PasswordColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Hk4y()
		{
			base[tableUser.PasswordColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Ef2e()
		{
			return IsNull(tableUser.IsAdminColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Bw3y()
		{
			base[tableUser.IsAdminColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool g3ZC()
		{
			return IsNull(tableUser.EmailColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void n3G1()
		{
			base[tableUser.EmailColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool w3A6()
		{
			return IsNull(tableUser.PhoneNumberColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void f7DA()
		{
			base[tableUser.PhoneNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool f2ZF()
		{
			return IsNull(tableUser.DepartmentColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void t9B2()
		{
			base[tableUser.DepartmentColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool g8G2()
		{
			return IsNull(tableUser.DesignationColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void s5T9()
		{
			base[tableUser.DesignationColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool o6RA()
		{
			return IsNull(tableUser.TotalFineColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void o4P2()
		{
			base[tableUser.TotalFineColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool x7MA()
		{
			return IsNull(tableUser.ImageColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void p0HR()
		{
			base[tableUser.ImageColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Ap2r()
		{
			return IsNull(tableUser.BooksIssuedColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Do0k()
		{
			base[tableUser.BooksIssuedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Zs65()
		{
			return IsNull(tableUser.MaxBooksColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void c3E6()
		{
			base[tableUser.MaxBooksColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public As17[] q9B8()
		{
			if (base.Table.ChildRelations["UserBorrowed"] == null)
			{
				return new As17[0];
			}
			return (As17[])GetChildRows(base.Table.ChildRelations["UserBorrowed"]);
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class Pf0o : EventArgs
	{
		private g1GW eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public g1GW Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Pf0o(g1GW row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class z6C7 : EventArgs
	{
		private As17 eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public As17 Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public z6C7(As17 row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class Xs1c : EventArgs
	{
		private j3CW eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public j3CW Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Xs1c(j3CW row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	private Yg56 tableBooks;

	private Qq46 tableBorrowed;

	private Gd8q tableUser;

	private DataRelation relationUserBorrowed;

	private SchemaSerializationMode _schemaSerializationMode;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public Yg56 Books => tableBooks;

	[Browsable(false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public Qq46 Borrowed => tableBorrowed;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	public Gd8q User => tableUser;

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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public new DataRelationCollection Relations => base.Relations;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public Pt8()
	{
		_schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		BeginInit();
		Gn8();
		CollectionChangeEventHandler value = Qg7;
		base.Tables.CollectionChanged += value;
		base.Relations.CollectionChanged += value;
		EndInit();
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected Pt8(SerializationInfo info, StreamingContext context)
		: base(info, context, ConstructSchema: false)
	{
		_schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		if (IsBinarySerialized(info, context))
		{
			a5M(b4A: false);
			CollectionChangeEventHandler value = Qg7;
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
				base.Tables.Add(new Yg56(dataSet.Tables["Books"]));
			}
			if (dataSet.Tables["Borrowed"] != null)
			{
				base.Tables.Add(new Qq46(dataSet.Tables["Borrowed"]));
			}
			if (dataSet.Tables["User"] != null)
			{
				base.Tables.Add(new Gd8q(dataSet.Tables["User"]));
			}
			base.DataSetName = dataSet.DataSetName;
			base.Prefix = dataSet.Prefix;
			base.Namespace = dataSet.Namespace;
			base.Locale = dataSet.Locale;
			base.CaseSensitive = dataSet.CaseSensitive;
			base.EnforceConstraints = dataSet.EnforceConstraints;
			Merge(dataSet, preserveChanges: false, MissingSchemaAction.Add);
			Bt8();
		}
		else
		{
			ReadXmlSchema(new XmlTextReader(new StringReader(s)));
		}
		GetSerializationData(info, context);
		CollectionChangeEventHandler value2 = Qg7;
		base.Tables.CollectionChanged += value2;
		Relations.CollectionChanged += value2;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected override void Ep4()
	{
		BeginInit();
		Gn8();
		EndInit();
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public override DataSet o6S()
	{
		Pt8 pt = (Pt8)base.Clone();
		pt.Bt8();
		pt.SchemaSerializationMode = SchemaSerializationMode;
		return pt;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected override bool x0R()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected override bool a2W()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected override void c5Z(XmlReader z2C)
	{
		if (DetermineSchemaSerializationMode(z2C) == SchemaSerializationMode.IncludeSchema)
		{
			Reset();
			DataSet dataSet = new DataSet();
			dataSet.ReadXml(z2C);
			if (dataSet.Tables["Books"] != null)
			{
				base.Tables.Add(new Yg56(dataSet.Tables["Books"]));
			}
			if (dataSet.Tables["Borrowed"] != null)
			{
				base.Tables.Add(new Qq46(dataSet.Tables["Borrowed"]));
			}
			if (dataSet.Tables["User"] != null)
			{
				base.Tables.Add(new Gd8q(dataSet.Tables["User"]));
			}
			base.DataSetName = dataSet.DataSetName;
			base.Prefix = dataSet.Prefix;
			base.Namespace = dataSet.Namespace;
			base.Locale = dataSet.Locale;
			base.CaseSensitive = dataSet.CaseSensitive;
			base.EnforceConstraints = dataSet.EnforceConstraints;
			Merge(dataSet, preserveChanges: false, MissingSchemaAction.Add);
			Bt8();
		}
		else
		{
			ReadXml(z2C);
			Bt8();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected override XmlSchema Rt5()
	{
		MemoryStream memoryStream = new MemoryStream();
		WriteXmlSchema(new XmlTextWriter(memoryStream, null));
		memoryStream.Position = 0L;
		return XmlSchema.Read(new XmlTextReader(memoryStream), null);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	internal void Bt8()
	{
		a5M(b4A: true);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	internal void a5M(bool b4A)
	{
		tableBooks = (Yg56)base.Tables["Books"];
		if (b4A && tableBooks != null)
		{
			tableBooks.Cx7b();
		}
		tableBorrowed = (Qq46)base.Tables["Borrowed"];
		if (b4A && tableBorrowed != null)
		{
			tableBorrowed.p4Z1();
		}
		tableUser = (Gd8q)base.Tables["User"];
		if (b4A && tableUser != null)
		{
			tableUser.o1T0();
		}
		relationUserBorrowed = Relations["UserBorrowed"];
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void Gn8()
	{
		base.DataSetName = "DatabaseDataSet";
		base.Prefix = "";
		base.Namespace = "http://tempuri.org/DatabaseDataSet.xsd";
		base.EnforceConstraints = true;
		SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		tableBooks = new Yg56();
		base.Tables.Add(tableBooks);
		tableBorrowed = new Qq46();
		base.Tables.Add(tableBorrowed);
		tableUser = new Gd8q();
		base.Tables.Add(tableUser);
		relationUserBorrowed = new DataRelation("UserBorrowed", new DataColumn[1] { tableUser.UserIdColumn }, new DataColumn[1] { tableBorrowed.BorrowerIdColumn }, createConstraints: false);
		Relations.Add(relationUserBorrowed);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool Mc2()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool Xg9()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool Zr2()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void Qg7(object sender, CollectionChangeEventArgs e)
	{
		if (e.Action == CollectionChangeAction.Remove)
		{
			Bt8();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public static XmlSchemaComplexType Cf3(XmlSchemaSet p7Q)
	{
		Pt8 pt = new Pt8();
		XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
		XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
		XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
		xmlSchemaAny.Namespace = pt.Namespace;
		xmlSchemaSequence.Items.Add(xmlSchemaAny);
		xmlSchemaComplexType.Particle = xmlSchemaSequence;
		XmlSchema xmlSchema = pt.Rt5();
		if (p7Q.Contains(xmlSchema.TargetNamespace))
		{
			MemoryStream memoryStream = new MemoryStream();
			MemoryStream memoryStream2 = new MemoryStream();
			try
			{
				XmlSchema xmlSchema2 = null;
				xmlSchema.Write(memoryStream);
				IEnumerator enumerator = p7Q.Schemas(xmlSchema.TargetNamespace).GetEnumerator();
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
		p7Q.Add(xmlSchema);
		return xmlSchemaComplexType;
	}
}
