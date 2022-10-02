using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.IO;
using System.Runtime.Serialization;
using System.Threading;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Microsoft.VisualBasic.CompilerServices;

namespace x4J2;

[Serializable]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("Database1DataSet")]
[DesignerCategory("code")]
[HelpKeyword("vs.data.DataSet")]
[ToolboxItem(true)]
public class q6SX : DataSet
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public delegate void Kj7f(object sender, Zy81 e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public delegate void k1YH(object sender, z8QE e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public delegate void c4L3(object sender, j9T3 e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public delegate void t9R6(object sender, y9RP e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public delegate void Kf1n(object sender, Cx06 e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public delegate void Ha9j(object sender, j4P7 e);

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class m7JA : TypedTableBase<Wo2b>
	{
		private DataColumn columnFaculty_ID;

		private DataColumn columnPassword;

		private Kj7f FloginRowChangingEvent;

		private Kj7f FloginRowChangedEvent;

		private Kj7f FloginRowDeletingEvent;

		private Kj7f FloginRowDeletedEvent;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn Faculty_IDColumn => columnFaculty_ID;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn PasswordColumn => columnPassword;

		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public int Count => base.Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Wo2b this[int Hz1g] => (Wo2b)base.Rows[Hz1g];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event Kj7f FloginRowChanging
		{
			add
			{
				Kj7f kj7f = FloginRowChangingEvent;
				Kj7f kj7f2;
				do
				{
					kj7f2 = kj7f;
					Kj7f value2 = (Kj7f)Delegate.Combine(kj7f2, value);
					kj7f = Interlocked.CompareExchange(ref FloginRowChangingEvent, value2, kj7f2);
				}
				while ((object)kj7f != kj7f2);
			}
			remove
			{
				Kj7f kj7f = FloginRowChangingEvent;
				Kj7f kj7f2;
				do
				{
					kj7f2 = kj7f;
					Kj7f value2 = (Kj7f)Delegate.Remove(kj7f2, value);
					kj7f = Interlocked.CompareExchange(ref FloginRowChangingEvent, value2, kj7f2);
				}
				while ((object)kj7f != kj7f2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event Kj7f FloginRowChanged
		{
			add
			{
				Kj7f kj7f = FloginRowChangedEvent;
				Kj7f kj7f2;
				do
				{
					kj7f2 = kj7f;
					Kj7f value2 = (Kj7f)Delegate.Combine(kj7f2, value);
					kj7f = Interlocked.CompareExchange(ref FloginRowChangedEvent, value2, kj7f2);
				}
				while ((object)kj7f != kj7f2);
			}
			remove
			{
				Kj7f kj7f = FloginRowChangedEvent;
				Kj7f kj7f2;
				do
				{
					kj7f2 = kj7f;
					Kj7f value2 = (Kj7f)Delegate.Remove(kj7f2, value);
					kj7f = Interlocked.CompareExchange(ref FloginRowChangedEvent, value2, kj7f2);
				}
				while ((object)kj7f != kj7f2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event Kj7f FloginRowDeleting
		{
			add
			{
				Kj7f kj7f = FloginRowDeletingEvent;
				Kj7f kj7f2;
				do
				{
					kj7f2 = kj7f;
					Kj7f value2 = (Kj7f)Delegate.Combine(kj7f2, value);
					kj7f = Interlocked.CompareExchange(ref FloginRowDeletingEvent, value2, kj7f2);
				}
				while ((object)kj7f != kj7f2);
			}
			remove
			{
				Kj7f kj7f = FloginRowDeletingEvent;
				Kj7f kj7f2;
				do
				{
					kj7f2 = kj7f;
					Kj7f value2 = (Kj7f)Delegate.Remove(kj7f2, value);
					kj7f = Interlocked.CompareExchange(ref FloginRowDeletingEvent, value2, kj7f2);
				}
				while ((object)kj7f != kj7f2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event Kj7f FloginRowDeleted
		{
			add
			{
				Kj7f kj7f = FloginRowDeletedEvent;
				Kj7f kj7f2;
				do
				{
					kj7f2 = kj7f;
					Kj7f value2 = (Kj7f)Delegate.Combine(kj7f2, value);
					kj7f = Interlocked.CompareExchange(ref FloginRowDeletedEvent, value2, kj7f2);
				}
				while ((object)kj7f != kj7f2);
			}
			remove
			{
				Kj7f kj7f = FloginRowDeletedEvent;
				Kj7f kj7f2;
				do
				{
					kj7f2 = kj7f;
					Kj7f value2 = (Kj7f)Delegate.Remove(kj7f2, value);
					kj7f = Interlocked.CompareExchange(ref FloginRowDeletedEvent, value2, kj7f2);
				}
				while ((object)kj7f != kj7f2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public m7JA()
		{
			base.TableName = "Flogin";
			BeginInit();
			q0ZR();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal m7JA(DataTable table)
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
		protected m7JA(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			Fs1r();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void Cy5n(Wo2b e3B9)
		{
			base.Rows.Add(e3B9);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Wo2b y6ST(string a3SL, string k6SP)
		{
			Wo2b wo2b = (Wo2b)NewRow();
			object[] array2 = (wo2b.ItemArray = new object[2] { a3SL, k6SP });
			base.Rows.Add(wo2b);
			return wo2b;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public override DataTable e2XJ()
		{
			m7JA m7JA = (m7JA)base.Clone();
			m7JA.Fs1r();
			return m7JA;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataTable t2QR()
		{
			return new m7JA();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal void Fs1r()
		{
			columnFaculty_ID = base.Columns["Faculty_ID"];
			columnPassword = base.Columns["Password"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		private void q0ZR()
		{
			columnFaculty_ID = new DataColumn("Faculty_ID", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnFaculty_ID);
			columnPassword = new DataColumn("Password", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnPassword);
			columnFaculty_ID.AllowDBNull = false;
			columnFaculty_ID.MaxLength = 50;
			columnPassword.AllowDBNull = false;
			columnPassword.MaxLength = 50;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Wo2b s1YT()
		{
			return (Wo2b)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataRow k0LE(DataRowBuilder Xz83)
		{
			return new Wo2b(Xz83);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override Type g2Y1()
		{
			return typeof(Wo2b);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void e7SA(DataRowChangeEventArgs c3MR)
		{
			base.OnRowChanged(c3MR);
			if (FloginRowChangedEvent != null)
			{
				FloginRowChangedEvent?.Invoke(this, new Zy81((Wo2b)c3MR.Row, c3MR.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void q1J2(DataRowChangeEventArgs Jr48)
		{
			base.OnRowChanging(Jr48);
			if (FloginRowChangingEvent != null)
			{
				FloginRowChangingEvent?.Invoke(this, new Zy81((Wo2b)Jr48.Row, Jr48.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void n4N8(DataRowChangeEventArgs d7HB)
		{
			base.OnRowDeleted(d7HB);
			if (FloginRowDeletedEvent != null)
			{
				FloginRowDeletedEvent?.Invoke(this, new Zy81((Wo2b)d7HB.Row, d7HB.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void c0ZY(DataRowChangeEventArgs Li6f)
		{
			base.OnRowDeleting(Li6f);
			if (FloginRowDeletingEvent != null)
			{
				FloginRowDeletingEvent?.Invoke(this, new Zy81((Wo2b)Li6f.Row, Li6f.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void m4JM(Wo2b n4E9)
		{
			base.Rows.Remove(n4E9);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public static XmlSchemaComplexType Mq4a(XmlSchemaSet f0R7)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			q6SX q6SX2 = new q6SX();
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
			xmlSchemaAttribute.FixedValue = q6SX2.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "FloginDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema xmlSchema = q6SX2.t0AX();
			if (f0R7.Contains(xmlSchema.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema2 = null;
					xmlSchema.Write(memoryStream);
					IEnumerator enumerator = f0R7.Schemas(xmlSchema.TargetNamespace).GetEnumerator();
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
			f0R7.Add(xmlSchema);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class Eb67 : TypedTableBase<Tg14>
	{
		private DataColumn columnEmail;

		private DataColumn columnFaculty;

		private DataColumn columnSchedule;

		private DataColumn columnAppointment;

		private DataColumn columnRequest;

		private k1YH HistoryRowChangingEvent;

		private k1YH HistoryRowChangedEvent;

		private k1YH HistoryRowDeletingEvent;

		private k1YH HistoryRowDeletedEvent;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn EmailColumn => columnEmail;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn FacultyColumn => columnFaculty;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn ScheduleColumn => columnSchedule;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn AppointmentColumn => columnAppointment;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn RequestColumn => columnRequest;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		[Browsable(false)]
		public int Count => base.Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Tg14 this[int Tk5w] => (Tg14)base.Rows[Tk5w];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event k1YH HistoryRowChanging
		{
			add
			{
				k1YH k1YH = HistoryRowChangingEvent;
				k1YH k1YH2;
				do
				{
					k1YH2 = k1YH;
					k1YH value2 = (k1YH)Delegate.Combine(k1YH2, value);
					k1YH = Interlocked.CompareExchange(ref HistoryRowChangingEvent, value2, k1YH2);
				}
				while ((object)k1YH != k1YH2);
			}
			remove
			{
				k1YH k1YH = HistoryRowChangingEvent;
				k1YH k1YH2;
				do
				{
					k1YH2 = k1YH;
					k1YH value2 = (k1YH)Delegate.Remove(k1YH2, value);
					k1YH = Interlocked.CompareExchange(ref HistoryRowChangingEvent, value2, k1YH2);
				}
				while ((object)k1YH != k1YH2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event k1YH HistoryRowChanged
		{
			add
			{
				k1YH k1YH = HistoryRowChangedEvent;
				k1YH k1YH2;
				do
				{
					k1YH2 = k1YH;
					k1YH value2 = (k1YH)Delegate.Combine(k1YH2, value);
					k1YH = Interlocked.CompareExchange(ref HistoryRowChangedEvent, value2, k1YH2);
				}
				while ((object)k1YH != k1YH2);
			}
			remove
			{
				k1YH k1YH = HistoryRowChangedEvent;
				k1YH k1YH2;
				do
				{
					k1YH2 = k1YH;
					k1YH value2 = (k1YH)Delegate.Remove(k1YH2, value);
					k1YH = Interlocked.CompareExchange(ref HistoryRowChangedEvent, value2, k1YH2);
				}
				while ((object)k1YH != k1YH2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event k1YH HistoryRowDeleting
		{
			add
			{
				k1YH k1YH = HistoryRowDeletingEvent;
				k1YH k1YH2;
				do
				{
					k1YH2 = k1YH;
					k1YH value2 = (k1YH)Delegate.Combine(k1YH2, value);
					k1YH = Interlocked.CompareExchange(ref HistoryRowDeletingEvent, value2, k1YH2);
				}
				while ((object)k1YH != k1YH2);
			}
			remove
			{
				k1YH k1YH = HistoryRowDeletingEvent;
				k1YH k1YH2;
				do
				{
					k1YH2 = k1YH;
					k1YH value2 = (k1YH)Delegate.Remove(k1YH2, value);
					k1YH = Interlocked.CompareExchange(ref HistoryRowDeletingEvent, value2, k1YH2);
				}
				while ((object)k1YH != k1YH2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event k1YH HistoryRowDeleted
		{
			add
			{
				k1YH k1YH = HistoryRowDeletedEvent;
				k1YH k1YH2;
				do
				{
					k1YH2 = k1YH;
					k1YH value2 = (k1YH)Delegate.Combine(k1YH2, value);
					k1YH = Interlocked.CompareExchange(ref HistoryRowDeletedEvent, value2, k1YH2);
				}
				while ((object)k1YH != k1YH2);
			}
			remove
			{
				k1YH k1YH = HistoryRowDeletedEvent;
				k1YH k1YH2;
				do
				{
					k1YH2 = k1YH;
					k1YH value2 = (k1YH)Delegate.Remove(k1YH2, value);
					k1YH = Interlocked.CompareExchange(ref HistoryRowDeletedEvent, value2, k1YH2);
				}
				while ((object)k1YH != k1YH2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Eb67()
		{
			base.TableName = "History";
			BeginInit();
			Mr79();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal Eb67(DataTable table)
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
		protected Eb67(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			Wt86();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void Cx3k(Tg14 q6YH)
		{
			base.Rows.Add(q6YH);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Tg14 z7L0(string j7Q0, string b7W2, string Nd3c, string Sa26, string f0LR)
		{
			Tg14 tg = (Tg14)NewRow();
			object[] array2 = (tg.ItemArray = new object[5] { j7Q0, b7W2, Nd3c, Sa26, f0LR });
			base.Rows.Add(tg);
			return tg;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public override DataTable i2C1()
		{
			Eb67 eb = (Eb67)base.Clone();
			eb.Wt86();
			return eb;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataTable m2SP()
		{
			return new Eb67();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal void Wt86()
		{
			columnEmail = base.Columns["Email"];
			columnFaculty = base.Columns["Faculty"];
			columnSchedule = base.Columns["Schedule"];
			columnAppointment = base.Columns["Appointment"];
			columnRequest = base.Columns["Request"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		private void Mr79()
		{
			columnEmail = new DataColumn("Email", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnEmail);
			columnFaculty = new DataColumn("Faculty", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnFaculty);
			columnSchedule = new DataColumn("Schedule", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSchedule);
			columnAppointment = new DataColumn("Appointment", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnAppointment);
			columnRequest = new DataColumn("Request", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnRequest);
			columnEmail.AllowDBNull = false;
			columnEmail.MaxLength = 50;
			columnFaculty.AllowDBNull = false;
			columnFaculty.MaxLength = 50;
			columnSchedule.AllowDBNull = false;
			columnSchedule.MaxLength = 50;
			columnAppointment.AllowDBNull = false;
			columnAppointment.MaxLength = 50;
			columnRequest.AllowDBNull = false;
			columnRequest.MaxLength = 50;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Tg14 z4YJ()
		{
			return (Tg14)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataRow a4N9(DataRowBuilder Gf2g)
		{
			return new Tg14(Gf2g);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override Type Cp3i()
		{
			return typeof(Tg14);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void Ez4s(DataRowChangeEventArgs m5R1)
		{
			base.OnRowChanged(m5R1);
			if (HistoryRowChangedEvent != null)
			{
				HistoryRowChangedEvent?.Invoke(this, new z8QE((Tg14)m5R1.Row, m5R1.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void Zj93(DataRowChangeEventArgs Ty5j)
		{
			base.OnRowChanging(Ty5j);
			if (HistoryRowChangingEvent != null)
			{
				HistoryRowChangingEvent?.Invoke(this, new z8QE((Tg14)Ty5j.Row, Ty5j.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void x1Y8(DataRowChangeEventArgs z0G4)
		{
			base.OnRowDeleted(z0G4);
			if (HistoryRowDeletedEvent != null)
			{
				HistoryRowDeletedEvent?.Invoke(this, new z8QE((Tg14)z0G4.Row, z0G4.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void Kw9d(DataRowChangeEventArgs Zf47)
		{
			base.OnRowDeleting(Zf47);
			if (HistoryRowDeletingEvent != null)
			{
				HistoryRowDeletingEvent?.Invoke(this, new z8QE((Tg14)Zf47.Row, Zf47.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void o0X9(Tg14 Sb5q)
		{
			base.Rows.Remove(Sb5q);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public static XmlSchemaComplexType Eo42(XmlSchemaSet Xe76)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			q6SX q6SX2 = new q6SX();
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
			xmlSchemaAttribute.FixedValue = q6SX2.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "HistoryDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema xmlSchema = q6SX2.t0AX();
			if (Xe76.Contains(xmlSchema.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema2 = null;
					xmlSchema.Write(memoryStream);
					IEnumerator enumerator = Xe76.Schemas(xmlSchema.TargetNamespace).GetEnumerator();
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
			Xe76.Add(xmlSchema);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class j8PL : TypedTableBase<y2K6>
	{
		private DataColumn columnStudent_ID;

		private DataColumn columnName;

		private DataColumn columnEmail;

		private DataColumn columnSchedule;

		private DataColumn columnAppointment;

		private DataColumn columnFaculty_ID;

		private c4L3 PendingRowChangingEvent;

		private c4L3 PendingRowChangedEvent;

		private c4L3 PendingRowDeletingEvent;

		private c4L3 PendingRowDeletedEvent;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn Student_IDColumn => columnStudent_ID;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn NameColumn => columnName;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn EmailColumn => columnEmail;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn ScheduleColumn => columnSchedule;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn AppointmentColumn => columnAppointment;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn Faculty_IDColumn => columnFaculty_ID;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		[Browsable(false)]
		public int Count => base.Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public y2K6 this[int Pn42] => (y2K6)base.Rows[Pn42];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event c4L3 PendingRowChanging
		{
			add
			{
				c4L3 c4L = PendingRowChangingEvent;
				c4L3 c4L2;
				do
				{
					c4L2 = c4L;
					c4L3 value2 = (c4L3)Delegate.Combine(c4L2, value);
					c4L = Interlocked.CompareExchange(ref PendingRowChangingEvent, value2, c4L2);
				}
				while ((object)c4L != c4L2);
			}
			remove
			{
				c4L3 c4L = PendingRowChangingEvent;
				c4L3 c4L2;
				do
				{
					c4L2 = c4L;
					c4L3 value2 = (c4L3)Delegate.Remove(c4L2, value);
					c4L = Interlocked.CompareExchange(ref PendingRowChangingEvent, value2, c4L2);
				}
				while ((object)c4L != c4L2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event c4L3 PendingRowChanged
		{
			add
			{
				c4L3 c4L = PendingRowChangedEvent;
				c4L3 c4L2;
				do
				{
					c4L2 = c4L;
					c4L3 value2 = (c4L3)Delegate.Combine(c4L2, value);
					c4L = Interlocked.CompareExchange(ref PendingRowChangedEvent, value2, c4L2);
				}
				while ((object)c4L != c4L2);
			}
			remove
			{
				c4L3 c4L = PendingRowChangedEvent;
				c4L3 c4L2;
				do
				{
					c4L2 = c4L;
					c4L3 value2 = (c4L3)Delegate.Remove(c4L2, value);
					c4L = Interlocked.CompareExchange(ref PendingRowChangedEvent, value2, c4L2);
				}
				while ((object)c4L != c4L2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event c4L3 PendingRowDeleting
		{
			add
			{
				c4L3 c4L = PendingRowDeletingEvent;
				c4L3 c4L2;
				do
				{
					c4L2 = c4L;
					c4L3 value2 = (c4L3)Delegate.Combine(c4L2, value);
					c4L = Interlocked.CompareExchange(ref PendingRowDeletingEvent, value2, c4L2);
				}
				while ((object)c4L != c4L2);
			}
			remove
			{
				c4L3 c4L = PendingRowDeletingEvent;
				c4L3 c4L2;
				do
				{
					c4L2 = c4L;
					c4L3 value2 = (c4L3)Delegate.Remove(c4L2, value);
					c4L = Interlocked.CompareExchange(ref PendingRowDeletingEvent, value2, c4L2);
				}
				while ((object)c4L != c4L2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event c4L3 PendingRowDeleted
		{
			add
			{
				c4L3 c4L = PendingRowDeletedEvent;
				c4L3 c4L2;
				do
				{
					c4L2 = c4L;
					c4L3 value2 = (c4L3)Delegate.Combine(c4L2, value);
					c4L = Interlocked.CompareExchange(ref PendingRowDeletedEvent, value2, c4L2);
				}
				while ((object)c4L != c4L2);
			}
			remove
			{
				c4L3 c4L = PendingRowDeletedEvent;
				c4L3 c4L2;
				do
				{
					c4L2 = c4L;
					c4L3 value2 = (c4L3)Delegate.Remove(c4L2, value);
					c4L = Interlocked.CompareExchange(ref PendingRowDeletedEvent, value2, c4L2);
				}
				while ((object)c4L != c4L2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public j8PL()
		{
			base.TableName = "Pending";
			BeginInit();
			a9E6();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal j8PL(DataTable table)
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
		protected j8PL(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			Rb64();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void e1HP(y2K6 c2J5)
		{
			base.Rows.Add(c2J5);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public y2K6 m5R3(string p7GE, string s9XY, string Gs0b, string a5LS, string Tt4i, string q8PN)
		{
			y2K6 y2K = (y2K6)NewRow();
			object[] array2 = (y2K.ItemArray = new object[6] { p7GE, s9XY, Gs0b, a5LS, Tt4i, q8PN });
			base.Rows.Add(y2K);
			return y2K;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public override DataTable z6GD()
		{
			j8PL j8PL = (j8PL)base.Clone();
			j8PL.Rb64();
			return j8PL;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataTable n0T5()
		{
			return new j8PL();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal void Rb64()
		{
			columnStudent_ID = base.Columns["Student_ID"];
			columnName = base.Columns["Name"];
			columnEmail = base.Columns["Email"];
			columnSchedule = base.Columns["Schedule"];
			columnAppointment = base.Columns["Appointment"];
			columnFaculty_ID = base.Columns["Faculty_ID"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		private void a9E6()
		{
			columnStudent_ID = new DataColumn("Student_ID", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnStudent_ID);
			columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnName);
			columnEmail = new DataColumn("Email", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnEmail);
			columnSchedule = new DataColumn("Schedule", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSchedule);
			columnAppointment = new DataColumn("Appointment", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnAppointment);
			columnFaculty_ID = new DataColumn("Faculty_ID", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnFaculty_ID);
			columnStudent_ID.AllowDBNull = false;
			columnStudent_ID.MaxLength = 50;
			columnName.AllowDBNull = false;
			columnName.MaxLength = 50;
			columnEmail.AllowDBNull = false;
			columnEmail.MaxLength = 50;
			columnSchedule.AllowDBNull = false;
			columnSchedule.MaxLength = 50;
			columnAppointment.AllowDBNull = false;
			columnAppointment.MaxLength = 50;
			columnFaculty_ID.AllowDBNull = false;
			columnFaculty_ID.MaxLength = 50;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public y2K6 Kr60()
		{
			return (y2K6)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataRow Hb59(DataRowBuilder Hb72)
		{
			return new y2K6(Hb72);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override Type c6S9()
		{
			return typeof(y2K6);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void Sw81(DataRowChangeEventArgs e3EN)
		{
			base.OnRowChanged(e3EN);
			if (PendingRowChangedEvent != null)
			{
				PendingRowChangedEvent?.Invoke(this, new j9T3((y2K6)e3EN.Row, e3EN.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void j6KT(DataRowChangeEventArgs a2T4)
		{
			base.OnRowChanging(a2T4);
			if (PendingRowChangingEvent != null)
			{
				PendingRowChangingEvent?.Invoke(this, new j9T3((y2K6)a2T4.Row, a2T4.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void e2CX(DataRowChangeEventArgs Mr4g)
		{
			base.OnRowDeleted(Mr4g);
			if (PendingRowDeletedEvent != null)
			{
				PendingRowDeletedEvent?.Invoke(this, new j9T3((y2K6)Mr4g.Row, Mr4g.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void g9Q4(DataRowChangeEventArgs So8s)
		{
			base.OnRowDeleting(So8s);
			if (PendingRowDeletingEvent != null)
			{
				PendingRowDeletingEvent?.Invoke(this, new j9T3((y2K6)So8s.Row, So8s.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void q6E4(y2K6 k8BL)
		{
			base.Rows.Remove(k8BL);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public static XmlSchemaComplexType t8G7(XmlSchemaSet Yq54)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			q6SX q6SX2 = new q6SX();
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
			xmlSchemaAttribute.FixedValue = q6SX2.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "PendingDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema xmlSchema = q6SX2.t0AX();
			if (Yq54.Contains(xmlSchema.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema2 = null;
					xmlSchema.Write(memoryStream);
					IEnumerator enumerator = Yq54.Schemas(xmlSchema.TargetNamespace).GetEnumerator();
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
			Yq54.Add(xmlSchema);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class d7CL : TypedTableBase<z4LG>
	{
		private DataColumn columnStudent_ID;

		private DataColumn columnName;

		private DataColumn columnEmail;

		private DataColumn columnSchedule;

		private DataColumn columnAppointment;

		private DataColumn columnFaculty_ID;

		private t9R6 ScheduleRowChangingEvent;

		private t9R6 ScheduleRowChangedEvent;

		private t9R6 ScheduleRowDeletingEvent;

		private t9R6 ScheduleRowDeletedEvent;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn Student_IDColumn => columnStudent_ID;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn NameColumn => columnName;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn EmailColumn => columnEmail;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn ScheduleColumn => columnSchedule;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn AppointmentColumn => columnAppointment;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn Faculty_IDColumn => columnFaculty_ID;

		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public int Count => base.Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public z4LG this[int k9CM] => (z4LG)base.Rows[k9CM];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event t9R6 ScheduleRowChanging
		{
			add
			{
				t9R6 t9R = ScheduleRowChangingEvent;
				t9R6 t9R2;
				do
				{
					t9R2 = t9R;
					t9R6 value2 = (t9R6)Delegate.Combine(t9R2, value);
					t9R = Interlocked.CompareExchange(ref ScheduleRowChangingEvent, value2, t9R2);
				}
				while ((object)t9R != t9R2);
			}
			remove
			{
				t9R6 t9R = ScheduleRowChangingEvent;
				t9R6 t9R2;
				do
				{
					t9R2 = t9R;
					t9R6 value2 = (t9R6)Delegate.Remove(t9R2, value);
					t9R = Interlocked.CompareExchange(ref ScheduleRowChangingEvent, value2, t9R2);
				}
				while ((object)t9R != t9R2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event t9R6 ScheduleRowChanged
		{
			add
			{
				t9R6 t9R = ScheduleRowChangedEvent;
				t9R6 t9R2;
				do
				{
					t9R2 = t9R;
					t9R6 value2 = (t9R6)Delegate.Combine(t9R2, value);
					t9R = Interlocked.CompareExchange(ref ScheduleRowChangedEvent, value2, t9R2);
				}
				while ((object)t9R != t9R2);
			}
			remove
			{
				t9R6 t9R = ScheduleRowChangedEvent;
				t9R6 t9R2;
				do
				{
					t9R2 = t9R;
					t9R6 value2 = (t9R6)Delegate.Remove(t9R2, value);
					t9R = Interlocked.CompareExchange(ref ScheduleRowChangedEvent, value2, t9R2);
				}
				while ((object)t9R != t9R2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event t9R6 ScheduleRowDeleting
		{
			add
			{
				t9R6 t9R = ScheduleRowDeletingEvent;
				t9R6 t9R2;
				do
				{
					t9R2 = t9R;
					t9R6 value2 = (t9R6)Delegate.Combine(t9R2, value);
					t9R = Interlocked.CompareExchange(ref ScheduleRowDeletingEvent, value2, t9R2);
				}
				while ((object)t9R != t9R2);
			}
			remove
			{
				t9R6 t9R = ScheduleRowDeletingEvent;
				t9R6 t9R2;
				do
				{
					t9R2 = t9R;
					t9R6 value2 = (t9R6)Delegate.Remove(t9R2, value);
					t9R = Interlocked.CompareExchange(ref ScheduleRowDeletingEvent, value2, t9R2);
				}
				while ((object)t9R != t9R2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event t9R6 ScheduleRowDeleted
		{
			add
			{
				t9R6 t9R = ScheduleRowDeletedEvent;
				t9R6 t9R2;
				do
				{
					t9R2 = t9R;
					t9R6 value2 = (t9R6)Delegate.Combine(t9R2, value);
					t9R = Interlocked.CompareExchange(ref ScheduleRowDeletedEvent, value2, t9R2);
				}
				while ((object)t9R != t9R2);
			}
			remove
			{
				t9R6 t9R = ScheduleRowDeletedEvent;
				t9R6 t9R2;
				do
				{
					t9R2 = t9R;
					t9R6 value2 = (t9R6)Delegate.Remove(t9R2, value);
					t9R = Interlocked.CompareExchange(ref ScheduleRowDeletedEvent, value2, t9R2);
				}
				while ((object)t9R != t9R2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public d7CL()
		{
			base.TableName = "Schedule";
			BeginInit();
			Nr76();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal d7CL(DataTable table)
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
		protected d7CL(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			p2S7();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void b1Y5(z4LG g3LD)
		{
			base.Rows.Add(g3LD);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public z4LG j1T5(string g1QM, string Hw1m, string Cn4q, string b5E8, string Pz4n, string d3BN)
		{
			z4LG z4LG = (z4LG)NewRow();
			object[] array2 = (z4LG.ItemArray = new object[6] { g1QM, Hw1m, Cn4q, b5E8, Pz4n, d3BN });
			base.Rows.Add(z4LG);
			return z4LG;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public override DataTable Nk6g()
		{
			d7CL d7CL = (d7CL)base.Clone();
			d7CL.p2S7();
			return d7CL;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataTable c3F8()
		{
			return new d7CL();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal void p2S7()
		{
			columnStudent_ID = base.Columns["Student_ID"];
			columnName = base.Columns["Name"];
			columnEmail = base.Columns["Email"];
			columnSchedule = base.Columns["Schedule"];
			columnAppointment = base.Columns["Appointment"];
			columnFaculty_ID = base.Columns["Faculty_ID"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		private void Nr76()
		{
			columnStudent_ID = new DataColumn("Student_ID", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnStudent_ID);
			columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnName);
			columnEmail = new DataColumn("Email", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnEmail);
			columnSchedule = new DataColumn("Schedule", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSchedule);
			columnAppointment = new DataColumn("Appointment", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnAppointment);
			columnFaculty_ID = new DataColumn("Faculty_ID", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnFaculty_ID);
			columnStudent_ID.AllowDBNull = false;
			columnStudent_ID.MaxLength = 50;
			columnName.AllowDBNull = false;
			columnName.MaxLength = 50;
			columnEmail.AllowDBNull = false;
			columnEmail.MaxLength = 50;
			columnSchedule.AllowDBNull = false;
			columnSchedule.MaxLength = 50;
			columnAppointment.AllowDBNull = false;
			columnAppointment.MaxLength = 50;
			columnFaculty_ID.AllowDBNull = false;
			columnFaculty_ID.MaxLength = 50;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public z4LG i8P4()
		{
			return (z4LG)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataRow s2Z8(DataRowBuilder o1Z3)
		{
			return new z4LG(o1Z3);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override Type q6M0()
		{
			return typeof(z4LG);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void By6n(DataRowChangeEventArgs t6S7)
		{
			base.OnRowChanged(t6S7);
			if (ScheduleRowChangedEvent != null)
			{
				ScheduleRowChangedEvent?.Invoke(this, new y9RP((z4LG)t6S7.Row, t6S7.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void Dk16(DataRowChangeEventArgs a6WE)
		{
			base.OnRowChanging(a6WE);
			if (ScheduleRowChangingEvent != null)
			{
				ScheduleRowChangingEvent?.Invoke(this, new y9RP((z4LG)a6WE.Row, a6WE.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void y2A3(DataRowChangeEventArgs c8GL)
		{
			base.OnRowDeleted(c8GL);
			if (ScheduleRowDeletedEvent != null)
			{
				ScheduleRowDeletedEvent?.Invoke(this, new y9RP((z4LG)c8GL.Row, c8GL.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void g8XM(DataRowChangeEventArgs Yy52)
		{
			base.OnRowDeleting(Yy52);
			if (ScheduleRowDeletingEvent != null)
			{
				ScheduleRowDeletingEvent?.Invoke(this, new y9RP((z4LG)Yy52.Row, Yy52.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void z6F5(z4LG y1AF)
		{
			base.Rows.Remove(y1AF);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public static XmlSchemaComplexType Xf0n(XmlSchemaSet Ye2o)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			q6SX q6SX2 = new q6SX();
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
			xmlSchemaAttribute.FixedValue = q6SX2.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "ScheduleDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema xmlSchema = q6SX2.t0AX();
			if (Ye2o.Contains(xmlSchema.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema2 = null;
					xmlSchema.Write(memoryStream);
					IEnumerator enumerator = Ye2o.Schemas(xmlSchema.TargetNamespace).GetEnumerator();
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
			Ye2o.Add(xmlSchema);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class Ld40 : TypedTableBase<x2N7>
	{
		private DataColumn columnStudent_ID;

		private DataColumn columnPassword;

		private DataColumn columnName;

		private Kf1n SloginRowChangingEvent;

		private Kf1n SloginRowChangedEvent;

		private Kf1n SloginRowDeletingEvent;

		private Kf1n SloginRowDeletedEvent;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn Student_IDColumn => columnStudent_ID;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn PasswordColumn => columnPassword;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn NameColumn => columnName;

		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public int Count => base.Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public x2N7 this[int b9X2] => (x2N7)base.Rows[b9X2];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event Kf1n SloginRowChanging
		{
			add
			{
				Kf1n kf1n = SloginRowChangingEvent;
				Kf1n kf1n2;
				do
				{
					kf1n2 = kf1n;
					Kf1n value2 = (Kf1n)Delegate.Combine(kf1n2, value);
					kf1n = Interlocked.CompareExchange(ref SloginRowChangingEvent, value2, kf1n2);
				}
				while ((object)kf1n != kf1n2);
			}
			remove
			{
				Kf1n kf1n = SloginRowChangingEvent;
				Kf1n kf1n2;
				do
				{
					kf1n2 = kf1n;
					Kf1n value2 = (Kf1n)Delegate.Remove(kf1n2, value);
					kf1n = Interlocked.CompareExchange(ref SloginRowChangingEvent, value2, kf1n2);
				}
				while ((object)kf1n != kf1n2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event Kf1n SloginRowChanged
		{
			add
			{
				Kf1n kf1n = SloginRowChangedEvent;
				Kf1n kf1n2;
				do
				{
					kf1n2 = kf1n;
					Kf1n value2 = (Kf1n)Delegate.Combine(kf1n2, value);
					kf1n = Interlocked.CompareExchange(ref SloginRowChangedEvent, value2, kf1n2);
				}
				while ((object)kf1n != kf1n2);
			}
			remove
			{
				Kf1n kf1n = SloginRowChangedEvent;
				Kf1n kf1n2;
				do
				{
					kf1n2 = kf1n;
					Kf1n value2 = (Kf1n)Delegate.Remove(kf1n2, value);
					kf1n = Interlocked.CompareExchange(ref SloginRowChangedEvent, value2, kf1n2);
				}
				while ((object)kf1n != kf1n2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event Kf1n SloginRowDeleting
		{
			add
			{
				Kf1n kf1n = SloginRowDeletingEvent;
				Kf1n kf1n2;
				do
				{
					kf1n2 = kf1n;
					Kf1n value2 = (Kf1n)Delegate.Combine(kf1n2, value);
					kf1n = Interlocked.CompareExchange(ref SloginRowDeletingEvent, value2, kf1n2);
				}
				while ((object)kf1n != kf1n2);
			}
			remove
			{
				Kf1n kf1n = SloginRowDeletingEvent;
				Kf1n kf1n2;
				do
				{
					kf1n2 = kf1n;
					Kf1n value2 = (Kf1n)Delegate.Remove(kf1n2, value);
					kf1n = Interlocked.CompareExchange(ref SloginRowDeletingEvent, value2, kf1n2);
				}
				while ((object)kf1n != kf1n2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event Kf1n SloginRowDeleted
		{
			add
			{
				Kf1n kf1n = SloginRowDeletedEvent;
				Kf1n kf1n2;
				do
				{
					kf1n2 = kf1n;
					Kf1n value2 = (Kf1n)Delegate.Combine(kf1n2, value);
					kf1n = Interlocked.CompareExchange(ref SloginRowDeletedEvent, value2, kf1n2);
				}
				while ((object)kf1n != kf1n2);
			}
			remove
			{
				Kf1n kf1n = SloginRowDeletedEvent;
				Kf1n kf1n2;
				do
				{
					kf1n2 = kf1n;
					Kf1n value2 = (Kf1n)Delegate.Remove(kf1n2, value);
					kf1n = Interlocked.CompareExchange(ref SloginRowDeletedEvent, value2, kf1n2);
				}
				while ((object)kf1n != kf1n2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Ld40()
		{
			base.TableName = "Slogin";
			BeginInit();
			Qs21();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal Ld40(DataTable table)
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
		protected Ld40(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			Ca9n();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void y8R3(x2N7 Tk4c)
		{
			base.Rows.Add(Tk4c);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public x2N7 y1Z3(string Gt09, string m0XP, string Gc7p)
		{
			x2N7 x2N = (x2N7)NewRow();
			object[] array2 = (x2N.ItemArray = new object[3] { Gt09, m0XP, Gc7p });
			base.Rows.Add(x2N);
			return x2N;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public override DataTable Ho7e()
		{
			Ld40 ld = (Ld40)base.Clone();
			ld.Ca9n();
			return ld;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataTable Bq14()
		{
			return new Ld40();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal void Ca9n()
		{
			columnStudent_ID = base.Columns["Student_ID"];
			columnPassword = base.Columns["Password"];
			columnName = base.Columns["Name"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		private void Qs21()
		{
			columnStudent_ID = new DataColumn("Student_ID", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnStudent_ID);
			columnPassword = new DataColumn("Password", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnPassword);
			columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnName);
			columnStudent_ID.AllowDBNull = false;
			columnStudent_ID.MaxLength = 50;
			columnPassword.AllowDBNull = false;
			columnPassword.MaxLength = 50;
			columnName.AllowDBNull = false;
			columnName.MaxLength = 50;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public x2N7 r4DT()
		{
			return (x2N7)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataRow d1Y4(DataRowBuilder f7PR)
		{
			return new x2N7(f7PR);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override Type Eo0n()
		{
			return typeof(x2N7);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void a8JC(DataRowChangeEventArgs Dj97)
		{
			base.OnRowChanged(Dj97);
			if (SloginRowChangedEvent != null)
			{
				SloginRowChangedEvent?.Invoke(this, new Cx06((x2N7)Dj97.Row, Dj97.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void b8A3(DataRowChangeEventArgs c7YM)
		{
			base.OnRowChanging(c7YM);
			if (SloginRowChangingEvent != null)
			{
				SloginRowChangingEvent?.Invoke(this, new Cx06((x2N7)c7YM.Row, c7YM.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void Gr1a(DataRowChangeEventArgs Ce56)
		{
			base.OnRowDeleted(Ce56);
			if (SloginRowDeletedEvent != null)
			{
				SloginRowDeletedEvent?.Invoke(this, new Cx06((x2N7)Ce56.Row, Ce56.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void Ji45(DataRowChangeEventArgs b7S1)
		{
			base.OnRowDeleting(b7S1);
			if (SloginRowDeletingEvent != null)
			{
				SloginRowDeletingEvent?.Invoke(this, new Cx06((x2N7)b7S1.Row, b7S1.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void q6FY(x2N7 Pe4t)
		{
			base.Rows.Remove(Pe4t);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public static XmlSchemaComplexType Mt06(XmlSchemaSet a3KF)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			q6SX q6SX2 = new q6SX();
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
			xmlSchemaAttribute.FixedValue = q6SX2.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "SloginDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema xmlSchema = q6SX2.t0AX();
			if (a3KF.Contains(xmlSchema.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema2 = null;
					xmlSchema.Write(memoryStream);
					IEnumerator enumerator = a3KF.Schemas(xmlSchema.TargetNamespace).GetEnumerator();
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
			a3KF.Add(xmlSchema);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class p6YR : TypedTableBase<Yf4e>
	{
		private DataColumn columnStudent_ID;

		private DataColumn columnName;

		private DataColumn columnEmail;

		private DataColumn columnSchedule;

		private DataColumn columnAppointment;

		private DataColumn columnFaculty_ID;

		private Ha9j TableRowChangingEvent;

		private Ha9j TableRowChangedEvent;

		private Ha9j TableRowDeletingEvent;

		private Ha9j TableRowDeletedEvent;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn Student_IDColumn => columnStudent_ID;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn NameColumn => columnName;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn EmailColumn => columnEmail;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn ScheduleColumn => columnSchedule;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn AppointmentColumn => columnAppointment;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn Faculty_IDColumn => columnFaculty_ID;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		[Browsable(false)]
		public int Count => base.Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Yf4e this[int Ng40] => (Yf4e)base.Rows[Ng40];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event Ha9j TableRowChanging
		{
			add
			{
				Ha9j ha9j = TableRowChangingEvent;
				Ha9j ha9j2;
				do
				{
					ha9j2 = ha9j;
					Ha9j value2 = (Ha9j)Delegate.Combine(ha9j2, value);
					ha9j = Interlocked.CompareExchange(ref TableRowChangingEvent, value2, ha9j2);
				}
				while ((object)ha9j != ha9j2);
			}
			remove
			{
				Ha9j ha9j = TableRowChangingEvent;
				Ha9j ha9j2;
				do
				{
					ha9j2 = ha9j;
					Ha9j value2 = (Ha9j)Delegate.Remove(ha9j2, value);
					ha9j = Interlocked.CompareExchange(ref TableRowChangingEvent, value2, ha9j2);
				}
				while ((object)ha9j != ha9j2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event Ha9j TableRowChanged
		{
			add
			{
				Ha9j ha9j = TableRowChangedEvent;
				Ha9j ha9j2;
				do
				{
					ha9j2 = ha9j;
					Ha9j value2 = (Ha9j)Delegate.Combine(ha9j2, value);
					ha9j = Interlocked.CompareExchange(ref TableRowChangedEvent, value2, ha9j2);
				}
				while ((object)ha9j != ha9j2);
			}
			remove
			{
				Ha9j ha9j = TableRowChangedEvent;
				Ha9j ha9j2;
				do
				{
					ha9j2 = ha9j;
					Ha9j value2 = (Ha9j)Delegate.Remove(ha9j2, value);
					ha9j = Interlocked.CompareExchange(ref TableRowChangedEvent, value2, ha9j2);
				}
				while ((object)ha9j != ha9j2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event Ha9j TableRowDeleting
		{
			add
			{
				Ha9j ha9j = TableRowDeletingEvent;
				Ha9j ha9j2;
				do
				{
					ha9j2 = ha9j;
					Ha9j value2 = (Ha9j)Delegate.Combine(ha9j2, value);
					ha9j = Interlocked.CompareExchange(ref TableRowDeletingEvent, value2, ha9j2);
				}
				while ((object)ha9j != ha9j2);
			}
			remove
			{
				Ha9j ha9j = TableRowDeletingEvent;
				Ha9j ha9j2;
				do
				{
					ha9j2 = ha9j;
					Ha9j value2 = (Ha9j)Delegate.Remove(ha9j2, value);
					ha9j = Interlocked.CompareExchange(ref TableRowDeletingEvent, value2, ha9j2);
				}
				while ((object)ha9j != ha9j2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event Ha9j TableRowDeleted
		{
			add
			{
				Ha9j ha9j = TableRowDeletedEvent;
				Ha9j ha9j2;
				do
				{
					ha9j2 = ha9j;
					Ha9j value2 = (Ha9j)Delegate.Combine(ha9j2, value);
					ha9j = Interlocked.CompareExchange(ref TableRowDeletedEvent, value2, ha9j2);
				}
				while ((object)ha9j != ha9j2);
			}
			remove
			{
				Ha9j ha9j = TableRowDeletedEvent;
				Ha9j ha9j2;
				do
				{
					ha9j2 = ha9j;
					Ha9j value2 = (Ha9j)Delegate.Remove(ha9j2, value);
					ha9j = Interlocked.CompareExchange(ref TableRowDeletedEvent, value2, ha9j2);
				}
				while ((object)ha9j != ha9j2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public p6YR()
		{
			base.TableName = "Table";
			BeginInit();
			Bn71();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal p6YR(DataTable table)
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
		protected p6YR(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			Jr47();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void r0TE(Yf4e j9DS)
		{
			base.Rows.Add(j9DS);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Yf4e n8XE(string Yb1t, string m4Q9, string As21, string Qw36, string m6R8, string Ei13)
		{
			Yf4e yf4e = (Yf4e)NewRow();
			object[] array2 = (yf4e.ItemArray = new object[6] { Yb1t, m4Q9, As21, Qw36, m6R8, Ei13 });
			base.Rows.Add(yf4e);
			return yf4e;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public override DataTable Qk5i()
		{
			p6YR p6YR = (p6YR)base.Clone();
			p6YR.Jr47();
			return p6YR;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataTable Ya4g()
		{
			return new p6YR();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal void Jr47()
		{
			columnStudent_ID = base.Columns["Student_ID"];
			columnName = base.Columns["Name"];
			columnEmail = base.Columns["Email"];
			columnSchedule = base.Columns["Schedule"];
			columnAppointment = base.Columns["Appointment"];
			columnFaculty_ID = base.Columns["Faculty_ID"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		private void Bn71()
		{
			columnStudent_ID = new DataColumn("Student_ID", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnStudent_ID);
			columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnName);
			columnEmail = new DataColumn("Email", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnEmail);
			columnSchedule = new DataColumn("Schedule", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSchedule);
			columnAppointment = new DataColumn("Appointment", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnAppointment);
			columnFaculty_ID = new DataColumn("Faculty_ID", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnFaculty_ID);
			columnStudent_ID.AllowDBNull = false;
			columnStudent_ID.MaxLength = 50;
			columnName.AllowDBNull = false;
			columnName.MaxLength = 50;
			columnEmail.AllowDBNull = false;
			columnEmail.MaxLength = 50;
			columnSchedule.AllowDBNull = false;
			columnSchedule.MaxLength = 50;
			columnAppointment.AllowDBNull = false;
			columnAppointment.MaxLength = 50;
			columnFaculty_ID.AllowDBNull = false;
			columnFaculty_ID.MaxLength = 50;
			base.ExtendedProperties.Add("Generator_RowClassName", "TableRow");
			base.ExtendedProperties.Add("Generator_RowEvArgName", "TableRowChangeEvent");
			base.ExtendedProperties.Add("Generator_RowEvHandlerName", "TableRowChangeEventHandler");
			base.ExtendedProperties.Add("Generator_TableClassName", "TableDataTable");
			base.ExtendedProperties.Add("Generator_TablePropName", "Table");
			base.ExtendedProperties.Add("Generator_TableVarName", "tableTable");
			base.ExtendedProperties.Add("Generator_UserTableName", "Table");
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Yf4e n0R3()
		{
			return (Yf4e)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataRow Sy9z(DataRowBuilder Jy1r)
		{
			return new Yf4e(Jy1r);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override Type a2Y4()
		{
			return typeof(Yf4e);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void Wi20(DataRowChangeEventArgs Mq94)
		{
			base.OnRowChanged(Mq94);
			if (TableRowChangedEvent != null)
			{
				TableRowChangedEvent?.Invoke(this, new j4P7((Yf4e)Mq94.Row, Mq94.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void k0ZC(DataRowChangeEventArgs Gt81)
		{
			base.OnRowChanging(Gt81);
			if (TableRowChangingEvent != null)
			{
				TableRowChangingEvent?.Invoke(this, new j4P7((Yf4e)Gt81.Row, Gt81.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void q9YD(DataRowChangeEventArgs p3ZB)
		{
			base.OnRowDeleted(p3ZB);
			if (TableRowDeletedEvent != null)
			{
				TableRowDeletedEvent?.Invoke(this, new j4P7((Yf4e)p3ZB.Row, p3ZB.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void Pc4d(DataRowChangeEventArgs Jn1t)
		{
			base.OnRowDeleting(Jn1t);
			if (TableRowDeletingEvent != null)
			{
				TableRowDeletingEvent?.Invoke(this, new j4P7((Yf4e)Jn1t.Row, Jn1t.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void r3E2(Yf4e Em0f)
		{
			base.Rows.Remove(Em0f);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public static XmlSchemaComplexType Km58(XmlSchemaSet Cy9c)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			q6SX q6SX2 = new q6SX();
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
			xmlSchemaAttribute.FixedValue = q6SX2.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "TableDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema xmlSchema = q6SX2.t0AX();
			if (Cy9c.Contains(xmlSchema.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema2 = null;
					xmlSchema.Write(memoryStream);
					IEnumerator enumerator = Cy9c.Schemas(xmlSchema.TargetNamespace).GetEnumerator();
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
			Cy9c.Add(xmlSchema);
			return xmlSchemaComplexType;
		}
	}

	public class Wo2b : DataRow
	{
		private m7JA tableFlogin;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string Faculty_ID
		{
			get
			{
				return Conversions.ToString(base[tableFlogin.Faculty_IDColumn]);
			}
			set
			{
				base[tableFlogin.Faculty_IDColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string Password
		{
			get
			{
				return Conversions.ToString(base[tableFlogin.PasswordColumn]);
			}
			set
			{
				base[tableFlogin.PasswordColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal Wo2b(DataRowBuilder rb)
			: base(rb)
		{
			tableFlogin = (m7JA)base.Table;
		}
	}

	public class Tg14 : DataRow
	{
		private Eb67 tableHistory;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string Email
		{
			get
			{
				return Conversions.ToString(base[tableHistory.EmailColumn]);
			}
			set
			{
				base[tableHistory.EmailColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string Faculty
		{
			get
			{
				return Conversions.ToString(base[tableHistory.FacultyColumn]);
			}
			set
			{
				base[tableHistory.FacultyColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string Schedule
		{
			get
			{
				return Conversions.ToString(base[tableHistory.ScheduleColumn]);
			}
			set
			{
				base[tableHistory.ScheduleColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string Appointment
		{
			get
			{
				return Conversions.ToString(base[tableHistory.AppointmentColumn]);
			}
			set
			{
				base[tableHistory.AppointmentColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string Request
		{
			get
			{
				return Conversions.ToString(base[tableHistory.RequestColumn]);
			}
			set
			{
				base[tableHistory.RequestColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal Tg14(DataRowBuilder rb)
			: base(rb)
		{
			tableHistory = (Eb67)base.Table;
		}
	}

	public class y2K6 : DataRow
	{
		private j8PL tablePending;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string Student_ID
		{
			get
			{
				return Conversions.ToString(base[tablePending.Student_IDColumn]);
			}
			set
			{
				base[tablePending.Student_IDColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string Name
		{
			get
			{
				return Conversions.ToString(base[tablePending.NameColumn]);
			}
			set
			{
				base[tablePending.NameColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string Email
		{
			get
			{
				return Conversions.ToString(base[tablePending.EmailColumn]);
			}
			set
			{
				base[tablePending.EmailColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string Schedule
		{
			get
			{
				return Conversions.ToString(base[tablePending.ScheduleColumn]);
			}
			set
			{
				base[tablePending.ScheduleColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string Appointment
		{
			get
			{
				return Conversions.ToString(base[tablePending.AppointmentColumn]);
			}
			set
			{
				base[tablePending.AppointmentColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string Faculty_ID
		{
			get
			{
				return Conversions.ToString(base[tablePending.Faculty_IDColumn]);
			}
			set
			{
				base[tablePending.Faculty_IDColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal y2K6(DataRowBuilder rb)
			: base(rb)
		{
			tablePending = (j8PL)base.Table;
		}
	}

	public class z4LG : DataRow
	{
		private d7CL tableSchedule;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string Student_ID
		{
			get
			{
				return Conversions.ToString(base[tableSchedule.Student_IDColumn]);
			}
			set
			{
				base[tableSchedule.Student_IDColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string Name
		{
			get
			{
				return Conversions.ToString(base[tableSchedule.NameColumn]);
			}
			set
			{
				base[tableSchedule.NameColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string Email
		{
			get
			{
				return Conversions.ToString(base[tableSchedule.EmailColumn]);
			}
			set
			{
				base[tableSchedule.EmailColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string Schedule
		{
			get
			{
				return Conversions.ToString(base[tableSchedule.ScheduleColumn]);
			}
			set
			{
				base[tableSchedule.ScheduleColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string Appointment
		{
			get
			{
				return Conversions.ToString(base[tableSchedule.AppointmentColumn]);
			}
			set
			{
				base[tableSchedule.AppointmentColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string Faculty_ID
		{
			get
			{
				return Conversions.ToString(base[tableSchedule.Faculty_IDColumn]);
			}
			set
			{
				base[tableSchedule.Faculty_IDColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal z4LG(DataRowBuilder rb)
			: base(rb)
		{
			tableSchedule = (d7CL)base.Table;
		}
	}

	public class x2N7 : DataRow
	{
		private Ld40 tableSlogin;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string Student_ID
		{
			get
			{
				return Conversions.ToString(base[tableSlogin.Student_IDColumn]);
			}
			set
			{
				base[tableSlogin.Student_IDColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string Password
		{
			get
			{
				return Conversions.ToString(base[tableSlogin.PasswordColumn]);
			}
			set
			{
				base[tableSlogin.PasswordColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string Name
		{
			get
			{
				return Conversions.ToString(base[tableSlogin.NameColumn]);
			}
			set
			{
				base[tableSlogin.NameColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal x2N7(DataRowBuilder rb)
			: base(rb)
		{
			tableSlogin = (Ld40)base.Table;
		}
	}

	public class Yf4e : DataRow
	{
		private p6YR tableTable;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string Student_ID
		{
			get
			{
				return Conversions.ToString(base[tableTable.Student_IDColumn]);
			}
			set
			{
				base[tableTable.Student_IDColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string Name
		{
			get
			{
				return Conversions.ToString(base[tableTable.NameColumn]);
			}
			set
			{
				base[tableTable.NameColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string Email
		{
			get
			{
				return Conversions.ToString(base[tableTable.EmailColumn]);
			}
			set
			{
				base[tableTable.EmailColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string Schedule
		{
			get
			{
				return Conversions.ToString(base[tableTable.ScheduleColumn]);
			}
			set
			{
				base[tableTable.ScheduleColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string Appointment
		{
			get
			{
				return Conversions.ToString(base[tableTable.AppointmentColumn]);
			}
			set
			{
				base[tableTable.AppointmentColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public string Faculty_ID
		{
			get
			{
				return Conversions.ToString(base[tableTable.Faculty_IDColumn]);
			}
			set
			{
				base[tableTable.Faculty_IDColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal Yf4e(DataRowBuilder rb)
			: base(rb)
		{
			tableTable = (p6YR)base.Table;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public class Zy81 : EventArgs
	{
		private Wo2b eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Wo2b Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Zy81(Wo2b row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public class z8QE : EventArgs
	{
		private Tg14 eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Tg14 Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public z8QE(Tg14 row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public class j9T3 : EventArgs
	{
		private y2K6 eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public y2K6 Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public j9T3(y2K6 row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public class y9RP : EventArgs
	{
		private z4LG eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public z4LG Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public y9RP(z4LG row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public class Cx06 : EventArgs
	{
		private x2N7 eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public x2N7 Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Cx06(x2N7 row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public class j4P7 : EventArgs
	{
		private Yf4e eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Yf4e Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public j4P7(Yf4e row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	private m7JA tableFlogin;

	private Eb67 tableHistory;

	private j8PL tablePending;

	private d7CL tableSchedule;

	private Ld40 tableSlogin;

	private p6YR tableTable;

	private SchemaSerializationMode _schemaSerializationMode;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public m7JA Flogin => tableFlogin;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public Eb67 History => tableHistory;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[Browsable(false)]
	public j8PL Pending => tablePending;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	public d7CL Schedule => tableSchedule;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public Ld40 Slogin => tableSlogin;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	public p6YR Table => tableTable;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[Browsable(true)]
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public new DataRelationCollection Relations => base.Relations;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public q6SX()
	{
		_schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		BeginInit();
		o2T1();
		CollectionChangeEventHandler value = Fm79;
		base.Tables.CollectionChanged += value;
		base.Relations.CollectionChanged += value;
		EndInit();
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected q6SX(SerializationInfo info, StreamingContext context)
		: base(info, context, ConstructSchema: false)
	{
		_schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		if (IsBinarySerialized(info, context))
		{
			Wx89(d7S6: false);
			CollectionChangeEventHandler value = Fm79;
			Tables.CollectionChanged += value;
			Relations.CollectionChanged += value;
			return;
		}
		string s = Conversions.ToString(info.GetValue("XmlSchema", typeof(string)));
		if (DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
		{
			DataSet dataSet = new DataSet();
			dataSet.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
			if (dataSet.Tables["Flogin"] != null)
			{
				base.Tables.Add(new m7JA(dataSet.Tables["Flogin"]));
			}
			if (dataSet.Tables["History"] != null)
			{
				base.Tables.Add(new Eb67(dataSet.Tables["History"]));
			}
			if (dataSet.Tables["Pending"] != null)
			{
				base.Tables.Add(new j8PL(dataSet.Tables["Pending"]));
			}
			if (dataSet.Tables["Schedule"] != null)
			{
				base.Tables.Add(new d7CL(dataSet.Tables["Schedule"]));
			}
			if (dataSet.Tables["Slogin"] != null)
			{
				base.Tables.Add(new Ld40(dataSet.Tables["Slogin"]));
			}
			if (dataSet.Tables["Table"] != null)
			{
				base.Tables.Add(new p6YR(dataSet.Tables["Table"]));
			}
			base.DataSetName = dataSet.DataSetName;
			base.Prefix = dataSet.Prefix;
			base.Namespace = dataSet.Namespace;
			base.Locale = dataSet.Locale;
			base.CaseSensitive = dataSet.CaseSensitive;
			base.EnforceConstraints = dataSet.EnforceConstraints;
			Merge(dataSet, preserveChanges: false, MissingSchemaAction.Add);
			g6F7();
		}
		else
		{
			ReadXmlSchema(new XmlTextReader(new StringReader(s)));
		}
		GetSerializationData(info, context);
		CollectionChangeEventHandler value2 = Fm79;
		base.Tables.CollectionChanged += value2;
		Relations.CollectionChanged += value2;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected override void Lt89()
	{
		BeginInit();
		o2T1();
		EndInit();
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public override DataSet k8T2()
	{
		q6SX q6SX2 = (q6SX)base.Clone();
		q6SX2.g6F7();
		q6SX2.SchemaSerializationMode = SchemaSerializationMode;
		return q6SX2;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected override bool o9G0()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected override bool e2C3()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected override void i3D6(XmlReader p4WE)
	{
		if (DetermineSchemaSerializationMode(p4WE) == SchemaSerializationMode.IncludeSchema)
		{
			Reset();
			DataSet dataSet = new DataSet();
			dataSet.ReadXml(p4WE);
			if (dataSet.Tables["Flogin"] != null)
			{
				base.Tables.Add(new m7JA(dataSet.Tables["Flogin"]));
			}
			if (dataSet.Tables["History"] != null)
			{
				base.Tables.Add(new Eb67(dataSet.Tables["History"]));
			}
			if (dataSet.Tables["Pending"] != null)
			{
				base.Tables.Add(new j8PL(dataSet.Tables["Pending"]));
			}
			if (dataSet.Tables["Schedule"] != null)
			{
				base.Tables.Add(new d7CL(dataSet.Tables["Schedule"]));
			}
			if (dataSet.Tables["Slogin"] != null)
			{
				base.Tables.Add(new Ld40(dataSet.Tables["Slogin"]));
			}
			if (dataSet.Tables["Table"] != null)
			{
				base.Tables.Add(new p6YR(dataSet.Tables["Table"]));
			}
			base.DataSetName = dataSet.DataSetName;
			base.Prefix = dataSet.Prefix;
			base.Namespace = dataSet.Namespace;
			base.Locale = dataSet.Locale;
			base.CaseSensitive = dataSet.CaseSensitive;
			base.EnforceConstraints = dataSet.EnforceConstraints;
			Merge(dataSet, preserveChanges: false, MissingSchemaAction.Add);
			g6F7();
		}
		else
		{
			ReadXml(p4WE);
			g6F7();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected override XmlSchema t0AX()
	{
		MemoryStream memoryStream = new MemoryStream();
		WriteXmlSchema(new XmlTextWriter(memoryStream, null));
		memoryStream.Position = 0L;
		return XmlSchema.Read(new XmlTextReader(memoryStream), null);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	internal void g6F7()
	{
		Wx89(d7S6: true);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	internal void Wx89(bool d7S6)
	{
		tableFlogin = (m7JA)base.Tables["Flogin"];
		if (d7S6 && tableFlogin != null)
		{
			tableFlogin.Fs1r();
		}
		tableHistory = (Eb67)base.Tables["History"];
		if (d7S6 && tableHistory != null)
		{
			tableHistory.Wt86();
		}
		tablePending = (j8PL)base.Tables["Pending"];
		if (d7S6 && tablePending != null)
		{
			tablePending.Rb64();
		}
		tableSchedule = (d7CL)base.Tables["Schedule"];
		if (d7S6 && tableSchedule != null)
		{
			tableSchedule.p2S7();
		}
		tableSlogin = (Ld40)base.Tables["Slogin"];
		if (d7S6 && tableSlogin != null)
		{
			tableSlogin.Ca9n();
		}
		tableTable = (p6YR)base.Tables["Table"];
		if (d7S6 && tableTable != null)
		{
			tableTable.Jr47();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void o2T1()
	{
		base.DataSetName = "Database1DataSet";
		base.Prefix = "";
		base.Namespace = "http://tempuri.org/Database1DataSet.xsd";
		base.EnforceConstraints = true;
		SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		tableFlogin = new m7JA();
		base.Tables.Add(tableFlogin);
		tableHistory = new Eb67();
		base.Tables.Add(tableHistory);
		tablePending = new j8PL();
		base.Tables.Add(tablePending);
		tableSchedule = new d7CL();
		base.Tables.Add(tableSchedule);
		tableSlogin = new Ld40();
		base.Tables.Add(tableSlogin);
		tableTable = new p6YR();
		base.Tables.Add(tableTable);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private bool i7GK()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private bool z6B3()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private bool Mb5o()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private bool g1Y8()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private bool j0A1()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private bool m5B4()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void Fm79(object sender, CollectionChangeEventArgs e)
	{
		if (e.Action == CollectionChangeAction.Remove)
		{
			g6F7();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public static XmlSchemaComplexType o4L0(XmlSchemaSet Rn54)
	{
		q6SX q6SX2 = new q6SX();
		XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
		XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
		XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
		xmlSchemaAny.Namespace = q6SX2.Namespace;
		xmlSchemaSequence.Items.Add(xmlSchemaAny);
		xmlSchemaComplexType.Particle = xmlSchemaSequence;
		XmlSchema xmlSchema = q6SX2.t0AX();
		if (Rn54.Contains(xmlSchema.TargetNamespace))
		{
			MemoryStream memoryStream = new MemoryStream();
			MemoryStream memoryStream2 = new MemoryStream();
			try
			{
				XmlSchema xmlSchema2 = null;
				xmlSchema.Write(memoryStream);
				IEnumerator enumerator = Rn54.Schemas(xmlSchema.TargetNamespace).GetEnumerator();
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
		Rn54.Add(xmlSchema);
		return xmlSchemaComplexType;
	}
}
