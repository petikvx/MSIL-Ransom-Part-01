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

namespace To59;

[Serializable]
[ToolboxItem(true)]
[DesignerCategory("code")]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[HelpKeyword("vs.data.DataSet")]
[XmlRoot("Database1DataSet")]
public class Ck89 : DataSet
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public delegate void Pc56(object sender, Nn9 e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public delegate void Yx9e(object sender, Kk6 e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public delegate void z3QF(object sender, Rt6 e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public delegate void Wk1o(object sender, Hx6 e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public delegate void Er3j(object sender, So9 e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public delegate void Cg7a(object sender, d8X e);

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class e6QZ : TypedTableBase<Yc6>
	{
		private DataColumn columnFaculty_ID;

		private DataColumn columnPassword;

		private Pc56 FloginRowChangingEvent;

		private Pc56 FloginRowChangedEvent;

		private Pc56 FloginRowDeletingEvent;

		private Pc56 FloginRowDeletedEvent;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn Faculty_IDColumn => columnFaculty_ID;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn PasswordColumn => columnPassword;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		[Browsable(false)]
		public int Count => base.Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Yc6 this[int f4PA] => (Yc6)base.Rows[f4PA];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event Pc56 FloginRowChanging
		{
			add
			{
				Pc56 pc = FloginRowChangingEvent;
				Pc56 pc2;
				do
				{
					pc2 = pc;
					Pc56 value2 = (Pc56)Delegate.Combine(pc2, value);
					pc = Interlocked.CompareExchange(ref FloginRowChangingEvent, value2, pc2);
				}
				while ((object)pc != pc2);
			}
			remove
			{
				Pc56 pc = FloginRowChangingEvent;
				Pc56 pc2;
				do
				{
					pc2 = pc;
					Pc56 value2 = (Pc56)Delegate.Remove(pc2, value);
					pc = Interlocked.CompareExchange(ref FloginRowChangingEvent, value2, pc2);
				}
				while ((object)pc != pc2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event Pc56 FloginRowChanged
		{
			add
			{
				Pc56 pc = FloginRowChangedEvent;
				Pc56 pc2;
				do
				{
					pc2 = pc;
					Pc56 value2 = (Pc56)Delegate.Combine(pc2, value);
					pc = Interlocked.CompareExchange(ref FloginRowChangedEvent, value2, pc2);
				}
				while ((object)pc != pc2);
			}
			remove
			{
				Pc56 pc = FloginRowChangedEvent;
				Pc56 pc2;
				do
				{
					pc2 = pc;
					Pc56 value2 = (Pc56)Delegate.Remove(pc2, value);
					pc = Interlocked.CompareExchange(ref FloginRowChangedEvent, value2, pc2);
				}
				while ((object)pc != pc2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event Pc56 FloginRowDeleting
		{
			add
			{
				Pc56 pc = FloginRowDeletingEvent;
				Pc56 pc2;
				do
				{
					pc2 = pc;
					Pc56 value2 = (Pc56)Delegate.Combine(pc2, value);
					pc = Interlocked.CompareExchange(ref FloginRowDeletingEvent, value2, pc2);
				}
				while ((object)pc != pc2);
			}
			remove
			{
				Pc56 pc = FloginRowDeletingEvent;
				Pc56 pc2;
				do
				{
					pc2 = pc;
					Pc56 value2 = (Pc56)Delegate.Remove(pc2, value);
					pc = Interlocked.CompareExchange(ref FloginRowDeletingEvent, value2, pc2);
				}
				while ((object)pc != pc2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event Pc56 FloginRowDeleted
		{
			add
			{
				Pc56 pc = FloginRowDeletedEvent;
				Pc56 pc2;
				do
				{
					pc2 = pc;
					Pc56 value2 = (Pc56)Delegate.Combine(pc2, value);
					pc = Interlocked.CompareExchange(ref FloginRowDeletedEvent, value2, pc2);
				}
				while ((object)pc != pc2);
			}
			remove
			{
				Pc56 pc = FloginRowDeletedEvent;
				Pc56 pc2;
				do
				{
					pc2 = pc;
					Pc56 value2 = (Pc56)Delegate.Remove(pc2, value);
					pc = Interlocked.CompareExchange(ref FloginRowDeletedEvent, value2, pc2);
				}
				while ((object)pc != pc2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public e6QZ()
		{
			base.TableName = "Flogin";
			BeginInit();
			o7WK();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal e6QZ(DataTable table)
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
		protected e6QZ(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			Ng12();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void c0P4(Yc6 n2RY)
		{
			base.Rows.Add(n2RY);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Yc6 Ht8p(string Nd78, string Xy8r)
		{
			Yc6 yc = (Yc6)NewRow();
			object[] array2 = (yc.ItemArray = new object[2] { Nd78, Xy8r });
			base.Rows.Add(yc);
			return yc;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public override DataTable r0QS()
		{
			e6QZ e6QZ = (e6QZ)base.Clone();
			e6QZ.Ng12();
			return e6QZ;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataTable w6QE()
		{
			return new e6QZ();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal void Ng12()
		{
			columnFaculty_ID = base.Columns["Faculty_ID"];
			columnPassword = base.Columns["Password"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		private void o7WK()
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
		public Yc6 f8MS()
		{
			return (Yc6)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataRow a4H8(DataRowBuilder s5PM)
		{
			return new Yc6(s5PM);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override Type Rc12()
		{
			return typeof(Yc6);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void s8DQ(DataRowChangeEventArgs Yb43)
		{
			base.OnRowChanged(Yb43);
			if (FloginRowChangedEvent != null)
			{
				FloginRowChangedEvent?.Invoke(this, new Nn9((Yc6)Yb43.Row, Yb43.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void Yr25(DataRowChangeEventArgs p7Y0)
		{
			base.OnRowChanging(p7Y0);
			if (FloginRowChangingEvent != null)
			{
				FloginRowChangingEvent?.Invoke(this, new Nn9((Yc6)p7Y0.Row, p7Y0.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void Zx21(DataRowChangeEventArgs n9MZ)
		{
			base.OnRowDeleted(n9MZ);
			if (FloginRowDeletedEvent != null)
			{
				FloginRowDeletedEvent?.Invoke(this, new Nn9((Yc6)n9MZ.Row, n9MZ.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void Gp9y(DataRowChangeEventArgs Mz3k)
		{
			base.OnRowDeleting(Mz3k);
			if (FloginRowDeletingEvent != null)
			{
				FloginRowDeletingEvent?.Invoke(this, new Nn9((Yc6)Mz3k.Row, Mz3k.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void m2PZ(Yc6 Xo6g)
		{
			base.Rows.Remove(Xo6g);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public static XmlSchemaComplexType Jx8o(XmlSchemaSet Hc2d)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Ck89 ck = new Ck89();
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
			xmlSchemaAttribute.FixedValue = ck.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "FloginDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema xmlSchema = ck.m8B2();
			if (Hc2d.Contains(xmlSchema.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema2 = null;
					xmlSchema.Write(memoryStream);
					IEnumerator enumerator = Hc2d.Schemas(xmlSchema.TargetNamespace).GetEnumerator();
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
			Hc2d.Add(xmlSchema);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class An1p : TypedTableBase<Ae3>
	{
		private DataColumn columnEmail;

		private DataColumn columnFaculty;

		private DataColumn columnSchedule;

		private DataColumn columnAppointment;

		private DataColumn columnRequest;

		private Yx9e HistoryRowChangingEvent;

		private Yx9e HistoryRowChangedEvent;

		private Yx9e HistoryRowDeletingEvent;

		private Yx9e HistoryRowDeletedEvent;

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

		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public int Count => base.Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Ae3 this[int s9FX] => (Ae3)base.Rows[s9FX];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event Yx9e HistoryRowChanging
		{
			add
			{
				Yx9e yx9e = HistoryRowChangingEvent;
				Yx9e yx9e2;
				do
				{
					yx9e2 = yx9e;
					Yx9e value2 = (Yx9e)Delegate.Combine(yx9e2, value);
					yx9e = Interlocked.CompareExchange(ref HistoryRowChangingEvent, value2, yx9e2);
				}
				while ((object)yx9e != yx9e2);
			}
			remove
			{
				Yx9e yx9e = HistoryRowChangingEvent;
				Yx9e yx9e2;
				do
				{
					yx9e2 = yx9e;
					Yx9e value2 = (Yx9e)Delegate.Remove(yx9e2, value);
					yx9e = Interlocked.CompareExchange(ref HistoryRowChangingEvent, value2, yx9e2);
				}
				while ((object)yx9e != yx9e2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event Yx9e HistoryRowChanged
		{
			add
			{
				Yx9e yx9e = HistoryRowChangedEvent;
				Yx9e yx9e2;
				do
				{
					yx9e2 = yx9e;
					Yx9e value2 = (Yx9e)Delegate.Combine(yx9e2, value);
					yx9e = Interlocked.CompareExchange(ref HistoryRowChangedEvent, value2, yx9e2);
				}
				while ((object)yx9e != yx9e2);
			}
			remove
			{
				Yx9e yx9e = HistoryRowChangedEvent;
				Yx9e yx9e2;
				do
				{
					yx9e2 = yx9e;
					Yx9e value2 = (Yx9e)Delegate.Remove(yx9e2, value);
					yx9e = Interlocked.CompareExchange(ref HistoryRowChangedEvent, value2, yx9e2);
				}
				while ((object)yx9e != yx9e2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event Yx9e HistoryRowDeleting
		{
			add
			{
				Yx9e yx9e = HistoryRowDeletingEvent;
				Yx9e yx9e2;
				do
				{
					yx9e2 = yx9e;
					Yx9e value2 = (Yx9e)Delegate.Combine(yx9e2, value);
					yx9e = Interlocked.CompareExchange(ref HistoryRowDeletingEvent, value2, yx9e2);
				}
				while ((object)yx9e != yx9e2);
			}
			remove
			{
				Yx9e yx9e = HistoryRowDeletingEvent;
				Yx9e yx9e2;
				do
				{
					yx9e2 = yx9e;
					Yx9e value2 = (Yx9e)Delegate.Remove(yx9e2, value);
					yx9e = Interlocked.CompareExchange(ref HistoryRowDeletingEvent, value2, yx9e2);
				}
				while ((object)yx9e != yx9e2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event Yx9e HistoryRowDeleted
		{
			add
			{
				Yx9e yx9e = HistoryRowDeletedEvent;
				Yx9e yx9e2;
				do
				{
					yx9e2 = yx9e;
					Yx9e value2 = (Yx9e)Delegate.Combine(yx9e2, value);
					yx9e = Interlocked.CompareExchange(ref HistoryRowDeletedEvent, value2, yx9e2);
				}
				while ((object)yx9e != yx9e2);
			}
			remove
			{
				Yx9e yx9e = HistoryRowDeletedEvent;
				Yx9e yx9e2;
				do
				{
					yx9e2 = yx9e;
					Yx9e value2 = (Yx9e)Delegate.Remove(yx9e2, value);
					yx9e = Interlocked.CompareExchange(ref HistoryRowDeletedEvent, value2, yx9e2);
				}
				while ((object)yx9e != yx9e2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public An1p()
		{
			base.TableName = "History";
			BeginInit();
			Gn9f();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal An1p(DataTable table)
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
		protected An1p(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			i4M5();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void Tj9m(Ae3 e5PY)
		{
			base.Rows.Add(e5PY);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Ae3 An6q(string Wq8t, string Pz0n, string Py9i, string Kx39, string Aw47)
		{
			Ae3 ae = (Ae3)NewRow();
			object[] array2 = (ae.ItemArray = new object[5] { Wq8t, Pz0n, Py9i, Kx39, Aw47 });
			base.Rows.Add(ae);
			return ae;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public override DataTable Jk13()
		{
			An1p an1p = (An1p)base.Clone();
			an1p.i4M5();
			return an1p;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataTable g7J9()
		{
			return new An1p();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal void i4M5()
		{
			columnEmail = base.Columns["Email"];
			columnFaculty = base.Columns["Faculty"];
			columnSchedule = base.Columns["Schedule"];
			columnAppointment = base.Columns["Appointment"];
			columnRequest = base.Columns["Request"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		private void Gn9f()
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
		public Ae3 Hj37()
		{
			return (Ae3)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataRow q1XH(DataRowBuilder Po9t)
		{
			return new Ae3(Po9t);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override Type n4P7()
		{
			return typeof(Ae3);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void Jr4z(DataRowChangeEventArgs Ky1p)
		{
			base.OnRowChanged(Ky1p);
			if (HistoryRowChangedEvent != null)
			{
				HistoryRowChangedEvent?.Invoke(this, new Kk6((Ae3)Ky1p.Row, Ky1p.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void e8NT(DataRowChangeEventArgs e5P3)
		{
			base.OnRowChanging(e5P3);
			if (HistoryRowChangingEvent != null)
			{
				HistoryRowChangingEvent?.Invoke(this, new Kk6((Ae3)e5P3.Row, e5P3.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void Re02(DataRowChangeEventArgs c7Q8)
		{
			base.OnRowDeleted(c7Q8);
			if (HistoryRowDeletedEvent != null)
			{
				HistoryRowDeletedEvent?.Invoke(this, new Kk6((Ae3)c7Q8.Row, c7Q8.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void a6PQ(DataRowChangeEventArgs Lf27)
		{
			base.OnRowDeleting(Lf27);
			if (HistoryRowDeletingEvent != null)
			{
				HistoryRowDeletingEvent?.Invoke(this, new Kk6((Ae3)Lf27.Row, Lf27.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void Yd4m(Ae3 Yx7y)
		{
			base.Rows.Remove(Yx7y);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public static XmlSchemaComplexType Qx9o(XmlSchemaSet Hw1)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Ck89 ck = new Ck89();
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
			xmlSchemaAttribute.FixedValue = ck.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "HistoryDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema xmlSchema = ck.m8B2();
			if (Hw1.Contains(xmlSchema.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema2 = null;
					xmlSchema.Write(memoryStream);
					IEnumerator enumerator = Hw1.Schemas(xmlSchema.TargetNamespace).GetEnumerator();
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
			Hw1.Add(xmlSchema);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class j5P : TypedTableBase<p6T>
	{
		private DataColumn columnStudent_ID;

		private DataColumn columnName;

		private DataColumn columnEmail;

		private DataColumn columnSchedule;

		private DataColumn columnAppointment;

		private DataColumn columnFaculty_ID;

		private z3QF PendingRowChangingEvent;

		private z3QF PendingRowChangedEvent;

		private z3QF PendingRowDeletingEvent;

		private z3QF PendingRowDeletedEvent;

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
		public p6T this[int z2Z] => (p6T)base.Rows[z2Z];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event z3QF PendingRowChanging
		{
			add
			{
				z3QF z3QF = PendingRowChangingEvent;
				z3QF z3QF2;
				do
				{
					z3QF2 = z3QF;
					z3QF value2 = (z3QF)Delegate.Combine(z3QF2, value);
					z3QF = Interlocked.CompareExchange(ref PendingRowChangingEvent, value2, z3QF2);
				}
				while ((object)z3QF != z3QF2);
			}
			remove
			{
				z3QF z3QF = PendingRowChangingEvent;
				z3QF z3QF2;
				do
				{
					z3QF2 = z3QF;
					z3QF value2 = (z3QF)Delegate.Remove(z3QF2, value);
					z3QF = Interlocked.CompareExchange(ref PendingRowChangingEvent, value2, z3QF2);
				}
				while ((object)z3QF != z3QF2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event z3QF PendingRowChanged
		{
			add
			{
				z3QF z3QF = PendingRowChangedEvent;
				z3QF z3QF2;
				do
				{
					z3QF2 = z3QF;
					z3QF value2 = (z3QF)Delegate.Combine(z3QF2, value);
					z3QF = Interlocked.CompareExchange(ref PendingRowChangedEvent, value2, z3QF2);
				}
				while ((object)z3QF != z3QF2);
			}
			remove
			{
				z3QF z3QF = PendingRowChangedEvent;
				z3QF z3QF2;
				do
				{
					z3QF2 = z3QF;
					z3QF value2 = (z3QF)Delegate.Remove(z3QF2, value);
					z3QF = Interlocked.CompareExchange(ref PendingRowChangedEvent, value2, z3QF2);
				}
				while ((object)z3QF != z3QF2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event z3QF PendingRowDeleting
		{
			add
			{
				z3QF z3QF = PendingRowDeletingEvent;
				z3QF z3QF2;
				do
				{
					z3QF2 = z3QF;
					z3QF value2 = (z3QF)Delegate.Combine(z3QF2, value);
					z3QF = Interlocked.CompareExchange(ref PendingRowDeletingEvent, value2, z3QF2);
				}
				while ((object)z3QF != z3QF2);
			}
			remove
			{
				z3QF z3QF = PendingRowDeletingEvent;
				z3QF z3QF2;
				do
				{
					z3QF2 = z3QF;
					z3QF value2 = (z3QF)Delegate.Remove(z3QF2, value);
					z3QF = Interlocked.CompareExchange(ref PendingRowDeletingEvent, value2, z3QF2);
				}
				while ((object)z3QF != z3QF2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event z3QF PendingRowDeleted
		{
			add
			{
				z3QF z3QF = PendingRowDeletedEvent;
				z3QF z3QF2;
				do
				{
					z3QF2 = z3QF;
					z3QF value2 = (z3QF)Delegate.Combine(z3QF2, value);
					z3QF = Interlocked.CompareExchange(ref PendingRowDeletedEvent, value2, z3QF2);
				}
				while ((object)z3QF != z3QF2);
			}
			remove
			{
				z3QF z3QF = PendingRowDeletedEvent;
				z3QF z3QF2;
				do
				{
					z3QF2 = z3QF;
					z3QF value2 = (z3QF)Delegate.Remove(z3QF2, value);
					z3QF = Interlocked.CompareExchange(ref PendingRowDeletedEvent, value2, z3QF2);
				}
				while ((object)z3QF != z3QF2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public j5P()
		{
			base.TableName = "Pending";
			BeginInit();
			Po2();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal j5P(DataTable table)
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
		protected j5P(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			e2N();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void Sg2(p6T Bf1)
		{
			base.Rows.Add(Bf1);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public p6T Az7(string Bs6, string r1K, string Fw3, string Qg0, string Hp1, string z3T)
		{
			p6T p6T = (p6T)NewRow();
			object[] array2 = (p6T.ItemArray = new object[6] { Bs6, r1K, Fw3, Qg0, Hp1, z3T });
			base.Rows.Add(p6T);
			return p6T;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public override DataTable Xs7()
		{
			j5P j5P = (j5P)base.Clone();
			j5P.e2N();
			return j5P;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataTable Xc3()
		{
			return new j5P();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal void e2N()
		{
			columnStudent_ID = base.Columns["Student_ID"];
			columnName = base.Columns["Name"];
			columnEmail = base.Columns["Email"];
			columnSchedule = base.Columns["Schedule"];
			columnAppointment = base.Columns["Appointment"];
			columnFaculty_ID = base.Columns["Faculty_ID"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		private void Po2()
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
		public p6T Sy0()
		{
			return (p6T)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataRow a2H(DataRowBuilder n2R)
		{
			return new p6T(n2R);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override Type i4L()
		{
			return typeof(p6T);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void Hg3(DataRowChangeEventArgs b7Z)
		{
			base.OnRowChanged(b7Z);
			if (PendingRowChangedEvent != null)
			{
				PendingRowChangedEvent?.Invoke(this, new Rt6((p6T)b7Z.Row, b7Z.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void d5Y(DataRowChangeEventArgs Bo0)
		{
			base.OnRowChanging(Bo0);
			if (PendingRowChangingEvent != null)
			{
				PendingRowChangingEvent?.Invoke(this, new Rt6((p6T)Bo0.Row, Bo0.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void Kd2(DataRowChangeEventArgs Ls0)
		{
			base.OnRowDeleted(Ls0);
			if (PendingRowDeletedEvent != null)
			{
				PendingRowDeletedEvent?.Invoke(this, new Rt6((p6T)Ls0.Row, Ls0.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void w0P(DataRowChangeEventArgs p0G)
		{
			base.OnRowDeleting(p0G);
			if (PendingRowDeletingEvent != null)
			{
				PendingRowDeletingEvent?.Invoke(this, new Rt6((p6T)p0G.Row, p0G.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void x1C(p6T i7F)
		{
			base.Rows.Remove(i7F);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public static XmlSchemaComplexType z4J(XmlSchemaSet Nn0)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Ck89 ck = new Ck89();
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
			xmlSchemaAttribute.FixedValue = ck.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "PendingDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema xmlSchema = ck.m8B2();
			if (Nn0.Contains(xmlSchema.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema2 = null;
					xmlSchema.Write(memoryStream);
					IEnumerator enumerator = Nn0.Schemas(xmlSchema.TargetNamespace).GetEnumerator();
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
			Nn0.Add(xmlSchema);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class k6A : TypedTableBase<Ww4>
	{
		private DataColumn columnStudent_ID;

		private DataColumn columnName;

		private DataColumn columnEmail;

		private DataColumn columnSchedule;

		private DataColumn columnAppointment;

		private DataColumn columnFaculty_ID;

		private Wk1o ScheduleRowChangingEvent;

		private Wk1o ScheduleRowChangedEvent;

		private Wk1o ScheduleRowDeletingEvent;

		private Wk1o ScheduleRowDeletedEvent;

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
		public Ww4 this[int Zc6] => (Ww4)base.Rows[Zc6];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event Wk1o ScheduleRowChanging
		{
			add
			{
				Wk1o wk1o = ScheduleRowChangingEvent;
				Wk1o wk1o2;
				do
				{
					wk1o2 = wk1o;
					Wk1o value2 = (Wk1o)Delegate.Combine(wk1o2, value);
					wk1o = Interlocked.CompareExchange(ref ScheduleRowChangingEvent, value2, wk1o2);
				}
				while ((object)wk1o != wk1o2);
			}
			remove
			{
				Wk1o wk1o = ScheduleRowChangingEvent;
				Wk1o wk1o2;
				do
				{
					wk1o2 = wk1o;
					Wk1o value2 = (Wk1o)Delegate.Remove(wk1o2, value);
					wk1o = Interlocked.CompareExchange(ref ScheduleRowChangingEvent, value2, wk1o2);
				}
				while ((object)wk1o != wk1o2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event Wk1o ScheduleRowChanged
		{
			add
			{
				Wk1o wk1o = ScheduleRowChangedEvent;
				Wk1o wk1o2;
				do
				{
					wk1o2 = wk1o;
					Wk1o value2 = (Wk1o)Delegate.Combine(wk1o2, value);
					wk1o = Interlocked.CompareExchange(ref ScheduleRowChangedEvent, value2, wk1o2);
				}
				while ((object)wk1o != wk1o2);
			}
			remove
			{
				Wk1o wk1o = ScheduleRowChangedEvent;
				Wk1o wk1o2;
				do
				{
					wk1o2 = wk1o;
					Wk1o value2 = (Wk1o)Delegate.Remove(wk1o2, value);
					wk1o = Interlocked.CompareExchange(ref ScheduleRowChangedEvent, value2, wk1o2);
				}
				while ((object)wk1o != wk1o2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event Wk1o ScheduleRowDeleting
		{
			add
			{
				Wk1o wk1o = ScheduleRowDeletingEvent;
				Wk1o wk1o2;
				do
				{
					wk1o2 = wk1o;
					Wk1o value2 = (Wk1o)Delegate.Combine(wk1o2, value);
					wk1o = Interlocked.CompareExchange(ref ScheduleRowDeletingEvent, value2, wk1o2);
				}
				while ((object)wk1o != wk1o2);
			}
			remove
			{
				Wk1o wk1o = ScheduleRowDeletingEvent;
				Wk1o wk1o2;
				do
				{
					wk1o2 = wk1o;
					Wk1o value2 = (Wk1o)Delegate.Remove(wk1o2, value);
					wk1o = Interlocked.CompareExchange(ref ScheduleRowDeletingEvent, value2, wk1o2);
				}
				while ((object)wk1o != wk1o2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event Wk1o ScheduleRowDeleted
		{
			add
			{
				Wk1o wk1o = ScheduleRowDeletedEvent;
				Wk1o wk1o2;
				do
				{
					wk1o2 = wk1o;
					Wk1o value2 = (Wk1o)Delegate.Combine(wk1o2, value);
					wk1o = Interlocked.CompareExchange(ref ScheduleRowDeletedEvent, value2, wk1o2);
				}
				while ((object)wk1o != wk1o2);
			}
			remove
			{
				Wk1o wk1o = ScheduleRowDeletedEvent;
				Wk1o wk1o2;
				do
				{
					wk1o2 = wk1o;
					Wk1o value2 = (Wk1o)Delegate.Remove(wk1o2, value);
					wk1o = Interlocked.CompareExchange(ref ScheduleRowDeletedEvent, value2, wk1o2);
				}
				while ((object)wk1o != wk1o2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public k6A()
		{
			base.TableName = "Schedule";
			BeginInit();
			Rw2();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal k6A(DataTable table)
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
		protected k6A(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			Si3();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void Xi2(Ww4 c3F)
		{
			base.Rows.Add(c3F);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Ww4 g7J(string s9T, string Tw5, string Tg4, string Fz0, string Dg3, string d6D)
		{
			Ww4 ww = (Ww4)NewRow();
			object[] array2 = (ww.ItemArray = new object[6] { s9T, Tw5, Tg4, Fz0, Dg3, d6D });
			base.Rows.Add(ww);
			return ww;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public override DataTable Xx1()
		{
			k6A k6A = (k6A)base.Clone();
			k6A.Si3();
			return k6A;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataTable Ej8()
		{
			return new k6A();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal void Si3()
		{
			columnStudent_ID = base.Columns["Student_ID"];
			columnName = base.Columns["Name"];
			columnEmail = base.Columns["Email"];
			columnSchedule = base.Columns["Schedule"];
			columnAppointment = base.Columns["Appointment"];
			columnFaculty_ID = base.Columns["Faculty_ID"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		private void Rw2()
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
		public Ww4 b5M()
		{
			return (Ww4)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataRow a2W(DataRowBuilder Xm5)
		{
			return new Ww4(Xm5);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override Type Re3()
		{
			return typeof(Ww4);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void Mp8(DataRowChangeEventArgs f8T)
		{
			base.OnRowChanged(f8T);
			if (ScheduleRowChangedEvent != null)
			{
				ScheduleRowChangedEvent?.Invoke(this, new Hx6((Ww4)f8T.Row, f8T.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void b4N(DataRowChangeEventArgs k1D)
		{
			base.OnRowChanging(k1D);
			if (ScheduleRowChangingEvent != null)
			{
				ScheduleRowChangingEvent?.Invoke(this, new Hx6((Ww4)k1D.Row, k1D.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void s6Y(DataRowChangeEventArgs d4J)
		{
			base.OnRowDeleted(d4J);
			if (ScheduleRowDeletedEvent != null)
			{
				ScheduleRowDeletedEvent?.Invoke(this, new Hx6((Ww4)d4J.Row, d4J.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void Hn0(DataRowChangeEventArgs Hx8)
		{
			base.OnRowDeleting(Hx8);
			if (ScheduleRowDeletingEvent != null)
			{
				ScheduleRowDeletingEvent?.Invoke(this, new Hx6((Ww4)Hx8.Row, Hx8.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void b6L(Ww4 Wp7)
		{
			base.Rows.Remove(Wp7);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public static XmlSchemaComplexType j6R(XmlSchemaSet Sd6)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Ck89 ck = new Ck89();
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
			xmlSchemaAttribute.FixedValue = ck.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "ScheduleDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema xmlSchema = ck.m8B2();
			if (Sd6.Contains(xmlSchema.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema2 = null;
					xmlSchema.Write(memoryStream);
					IEnumerator enumerator = Sd6.Schemas(xmlSchema.TargetNamespace).GetEnumerator();
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
			Sd6.Add(xmlSchema);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class Rq4 : TypedTableBase<j0T>
	{
		private DataColumn columnStudent_ID;

		private DataColumn columnPassword;

		private DataColumn columnName;

		private Er3j SloginRowChangingEvent;

		private Er3j SloginRowChangedEvent;

		private Er3j SloginRowDeletingEvent;

		private Er3j SloginRowDeletedEvent;

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
		public j0T this[int r3R] => (j0T)base.Rows[r3R];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event Er3j SloginRowChanging
		{
			add
			{
				Er3j er3j = SloginRowChangingEvent;
				Er3j er3j2;
				do
				{
					er3j2 = er3j;
					Er3j value2 = (Er3j)Delegate.Combine(er3j2, value);
					er3j = Interlocked.CompareExchange(ref SloginRowChangingEvent, value2, er3j2);
				}
				while ((object)er3j != er3j2);
			}
			remove
			{
				Er3j er3j = SloginRowChangingEvent;
				Er3j er3j2;
				do
				{
					er3j2 = er3j;
					Er3j value2 = (Er3j)Delegate.Remove(er3j2, value);
					er3j = Interlocked.CompareExchange(ref SloginRowChangingEvent, value2, er3j2);
				}
				while ((object)er3j != er3j2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event Er3j SloginRowChanged
		{
			add
			{
				Er3j er3j = SloginRowChangedEvent;
				Er3j er3j2;
				do
				{
					er3j2 = er3j;
					Er3j value2 = (Er3j)Delegate.Combine(er3j2, value);
					er3j = Interlocked.CompareExchange(ref SloginRowChangedEvent, value2, er3j2);
				}
				while ((object)er3j != er3j2);
			}
			remove
			{
				Er3j er3j = SloginRowChangedEvent;
				Er3j er3j2;
				do
				{
					er3j2 = er3j;
					Er3j value2 = (Er3j)Delegate.Remove(er3j2, value);
					er3j = Interlocked.CompareExchange(ref SloginRowChangedEvent, value2, er3j2);
				}
				while ((object)er3j != er3j2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event Er3j SloginRowDeleting
		{
			add
			{
				Er3j er3j = SloginRowDeletingEvent;
				Er3j er3j2;
				do
				{
					er3j2 = er3j;
					Er3j value2 = (Er3j)Delegate.Combine(er3j2, value);
					er3j = Interlocked.CompareExchange(ref SloginRowDeletingEvent, value2, er3j2);
				}
				while ((object)er3j != er3j2);
			}
			remove
			{
				Er3j er3j = SloginRowDeletingEvent;
				Er3j er3j2;
				do
				{
					er3j2 = er3j;
					Er3j value2 = (Er3j)Delegate.Remove(er3j2, value);
					er3j = Interlocked.CompareExchange(ref SloginRowDeletingEvent, value2, er3j2);
				}
				while ((object)er3j != er3j2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event Er3j SloginRowDeleted
		{
			add
			{
				Er3j er3j = SloginRowDeletedEvent;
				Er3j er3j2;
				do
				{
					er3j2 = er3j;
					Er3j value2 = (Er3j)Delegate.Combine(er3j2, value);
					er3j = Interlocked.CompareExchange(ref SloginRowDeletedEvent, value2, er3j2);
				}
				while ((object)er3j != er3j2);
			}
			remove
			{
				Er3j er3j = SloginRowDeletedEvent;
				Er3j er3j2;
				do
				{
					er3j2 = er3j;
					Er3j value2 = (Er3j)Delegate.Remove(er3j2, value);
					er3j = Interlocked.CompareExchange(ref SloginRowDeletedEvent, value2, er3j2);
				}
				while ((object)er3j != er3j2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Rq4()
		{
			base.TableName = "Slogin";
			BeginInit();
			Xx8();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal Rq4(DataTable table)
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
		protected Rq4(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			Zf7();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void Bb2(j0T Qb5)
		{
			base.Rows.Add(Qb5);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public j0T Hf8(string Xg6, string q9F, string Pm3)
		{
			j0T j0T = (j0T)NewRow();
			object[] array2 = (j0T.ItemArray = new object[3] { Xg6, q9F, Pm3 });
			base.Rows.Add(j0T);
			return j0T;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public override DataTable Zt2()
		{
			Rq4 rq = (Rq4)base.Clone();
			rq.Zf7();
			return rq;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataTable d7Z()
		{
			return new Rq4();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal void Zf7()
		{
			columnStudent_ID = base.Columns["Student_ID"];
			columnPassword = base.Columns["Password"];
			columnName = base.Columns["Name"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		private void Xx8()
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
		public j0T p0P()
		{
			return (j0T)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataRow Hp1(DataRowBuilder Kx6)
		{
			return new j0T(Kx6);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override Type n0T()
		{
			return typeof(j0T);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void Gk9(DataRowChangeEventArgs Ez9)
		{
			base.OnRowChanged(Ez9);
			if (SloginRowChangedEvent != null)
			{
				SloginRowChangedEvent?.Invoke(this, new So9((j0T)Ez9.Row, Ez9.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void Nf3(DataRowChangeEventArgs y2R)
		{
			base.OnRowChanging(y2R);
			if (SloginRowChangingEvent != null)
			{
				SloginRowChangingEvent?.Invoke(this, new So9((j0T)y2R.Row, y2R.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void t4A(DataRowChangeEventArgs Jp3)
		{
			base.OnRowDeleted(Jp3);
			if (SloginRowDeletedEvent != null)
			{
				SloginRowDeletedEvent?.Invoke(this, new So9((j0T)Jp3.Row, Jp3.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void Nm9(DataRowChangeEventArgs p1F)
		{
			base.OnRowDeleting(p1F);
			if (SloginRowDeletingEvent != null)
			{
				SloginRowDeletingEvent?.Invoke(this, new So9((j0T)p1F.Row, p1F.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void Mi5(j0T c0Y)
		{
			base.Rows.Remove(c0Y);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public static XmlSchemaComplexType c1R(XmlSchemaSet i5C)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Ck89 ck = new Ck89();
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
			xmlSchemaAttribute.FixedValue = ck.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "SloginDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema xmlSchema = ck.m8B2();
			if (i5C.Contains(xmlSchema.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema2 = null;
					xmlSchema.Write(memoryStream);
					IEnumerator enumerator = i5C.Schemas(xmlSchema.TargetNamespace).GetEnumerator();
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
			i5C.Add(xmlSchema);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class Dq6 : TypedTableBase<Dy1>
	{
		private DataColumn columnStudent_ID;

		private DataColumn columnName;

		private DataColumn columnEmail;

		private DataColumn columnSchedule;

		private DataColumn columnAppointment;

		private DataColumn columnFaculty_ID;

		private Cg7a TableRowChangingEvent;

		private Cg7a TableRowChangedEvent;

		private Cg7a TableRowDeletingEvent;

		private Cg7a TableRowDeletedEvent;

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
		public Dy1 this[int Ea4] => (Dy1)base.Rows[Ea4];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event Cg7a TableRowChanging
		{
			add
			{
				Cg7a cg7a = TableRowChangingEvent;
				Cg7a cg7a2;
				do
				{
					cg7a2 = cg7a;
					Cg7a value2 = (Cg7a)Delegate.Combine(cg7a2, value);
					cg7a = Interlocked.CompareExchange(ref TableRowChangingEvent, value2, cg7a2);
				}
				while ((object)cg7a != cg7a2);
			}
			remove
			{
				Cg7a cg7a = TableRowChangingEvent;
				Cg7a cg7a2;
				do
				{
					cg7a2 = cg7a;
					Cg7a value2 = (Cg7a)Delegate.Remove(cg7a2, value);
					cg7a = Interlocked.CompareExchange(ref TableRowChangingEvent, value2, cg7a2);
				}
				while ((object)cg7a != cg7a2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event Cg7a TableRowChanged
		{
			add
			{
				Cg7a cg7a = TableRowChangedEvent;
				Cg7a cg7a2;
				do
				{
					cg7a2 = cg7a;
					Cg7a value2 = (Cg7a)Delegate.Combine(cg7a2, value);
					cg7a = Interlocked.CompareExchange(ref TableRowChangedEvent, value2, cg7a2);
				}
				while ((object)cg7a != cg7a2);
			}
			remove
			{
				Cg7a cg7a = TableRowChangedEvent;
				Cg7a cg7a2;
				do
				{
					cg7a2 = cg7a;
					Cg7a value2 = (Cg7a)Delegate.Remove(cg7a2, value);
					cg7a = Interlocked.CompareExchange(ref TableRowChangedEvent, value2, cg7a2);
				}
				while ((object)cg7a != cg7a2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event Cg7a TableRowDeleting
		{
			add
			{
				Cg7a cg7a = TableRowDeletingEvent;
				Cg7a cg7a2;
				do
				{
					cg7a2 = cg7a;
					Cg7a value2 = (Cg7a)Delegate.Combine(cg7a2, value);
					cg7a = Interlocked.CompareExchange(ref TableRowDeletingEvent, value2, cg7a2);
				}
				while ((object)cg7a != cg7a2);
			}
			remove
			{
				Cg7a cg7a = TableRowDeletingEvent;
				Cg7a cg7a2;
				do
				{
					cg7a2 = cg7a;
					Cg7a value2 = (Cg7a)Delegate.Remove(cg7a2, value);
					cg7a = Interlocked.CompareExchange(ref TableRowDeletingEvent, value2, cg7a2);
				}
				while ((object)cg7a != cg7a2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event Cg7a TableRowDeleted
		{
			add
			{
				Cg7a cg7a = TableRowDeletedEvent;
				Cg7a cg7a2;
				do
				{
					cg7a2 = cg7a;
					Cg7a value2 = (Cg7a)Delegate.Combine(cg7a2, value);
					cg7a = Interlocked.CompareExchange(ref TableRowDeletedEvent, value2, cg7a2);
				}
				while ((object)cg7a != cg7a2);
			}
			remove
			{
				Cg7a cg7a = TableRowDeletedEvent;
				Cg7a cg7a2;
				do
				{
					cg7a2 = cg7a;
					Cg7a value2 = (Cg7a)Delegate.Remove(cg7a2, value);
					cg7a = Interlocked.CompareExchange(ref TableRowDeletedEvent, value2, cg7a2);
				}
				while ((object)cg7a != cg7a2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Dq6()
		{
			base.TableName = "Table";
			BeginInit();
			x6A();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal Dq6(DataTable table)
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
		protected Dq6(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			De0();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void Yk3(Dy1 j5N)
		{
			base.Rows.Add(j5N);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Dy1 Cf1(string g0W, string Ff3, string i3H, string n7B, string Dd3, string g2B)
		{
			Dy1 dy = (Dy1)NewRow();
			object[] array2 = (dy.ItemArray = new object[6] { g0W, Ff3, i3H, n7B, Dd3, g2B });
			base.Rows.Add(dy);
			return dy;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public override DataTable Ed0()
		{
			Dq6 dq = (Dq6)base.Clone();
			dq.De0();
			return dq;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataTable d4Z()
		{
			return new Dq6();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal void De0()
		{
			columnStudent_ID = base.Columns["Student_ID"];
			columnName = base.Columns["Name"];
			columnEmail = base.Columns["Email"];
			columnSchedule = base.Columns["Schedule"];
			columnAppointment = base.Columns["Appointment"];
			columnFaculty_ID = base.Columns["Faculty_ID"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		private void x6A()
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
		public Dy1 Qm6()
		{
			return (Dy1)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataRow Bx0(DataRowBuilder Sf8)
		{
			return new Dy1(Sf8);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override Type r3X()
		{
			return typeof(Dy1);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void Gz3(DataRowChangeEventArgs Ac3)
		{
			base.OnRowChanged(Ac3);
			if (TableRowChangedEvent != null)
			{
				TableRowChangedEvent?.Invoke(this, new d8X((Dy1)Ac3.Row, Ac3.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void c8A(DataRowChangeEventArgs w3T)
		{
			base.OnRowChanging(w3T);
			if (TableRowChangingEvent != null)
			{
				TableRowChangingEvent?.Invoke(this, new d8X((Dy1)w3T.Row, w3T.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void Tg4(DataRowChangeEventArgs Hm3)
		{
			base.OnRowDeleted(Hm3);
			if (TableRowDeletedEvent != null)
			{
				TableRowDeletedEvent?.Invoke(this, new d8X((Dy1)Hm3.Row, Hm3.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void e9J(DataRowChangeEventArgs k0X)
		{
			base.OnRowDeleting(k0X);
			if (TableRowDeletingEvent != null)
			{
				TableRowDeletingEvent?.Invoke(this, new d8X((Dy1)k0X.Row, k0X.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void m3N(Dy1 Wy0)
		{
			base.Rows.Remove(Wy0);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public static XmlSchemaComplexType m1R(XmlSchemaSet n2Y)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Ck89 ck = new Ck89();
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
			xmlSchemaAttribute.FixedValue = ck.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "TableDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema xmlSchema = ck.m8B2();
			if (n2Y.Contains(xmlSchema.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema2 = null;
					xmlSchema.Write(memoryStream);
					IEnumerator enumerator = n2Y.Schemas(xmlSchema.TargetNamespace).GetEnumerator();
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
			n2Y.Add(xmlSchema);
			return xmlSchemaComplexType;
		}
	}

	public class Yc6 : DataRow
	{
		private e6QZ tableFlogin;

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
		internal Yc6(DataRowBuilder rb)
			: base(rb)
		{
			tableFlogin = (e6QZ)base.Table;
		}
	}

	public class Ae3 : DataRow
	{
		private An1p tableHistory;

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
		internal Ae3(DataRowBuilder rb)
			: base(rb)
		{
			tableHistory = (An1p)base.Table;
		}
	}

	public class p6T : DataRow
	{
		private j5P tablePending;

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
		internal p6T(DataRowBuilder rb)
			: base(rb)
		{
			tablePending = (j5P)base.Table;
		}
	}

	public class Ww4 : DataRow
	{
		private k6A tableSchedule;

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
		internal Ww4(DataRowBuilder rb)
			: base(rb)
		{
			tableSchedule = (k6A)base.Table;
		}
	}

	public class j0T : DataRow
	{
		private Rq4 tableSlogin;

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
		internal j0T(DataRowBuilder rb)
			: base(rb)
		{
			tableSlogin = (Rq4)base.Table;
		}
	}

	public class Dy1 : DataRow
	{
		private Dq6 tableTable;

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
		internal Dy1(DataRowBuilder rb)
			: base(rb)
		{
			tableTable = (Dq6)base.Table;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public class Nn9 : EventArgs
	{
		private Yc6 eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Yc6 Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Nn9(Yc6 row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public class Kk6 : EventArgs
	{
		private Ae3 eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Ae3 Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Kk6(Ae3 row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public class Rt6 : EventArgs
	{
		private p6T eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public p6T Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Rt6(p6T row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public class Hx6 : EventArgs
	{
		private Ww4 eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Ww4 Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Hx6(Ww4 row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public class So9 : EventArgs
	{
		private j0T eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public j0T Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public So9(j0T row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public class d8X : EventArgs
	{
		private Dy1 eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Dy1 Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public d8X(Dy1 row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	private e6QZ tableFlogin;

	private An1p tableHistory;

	private j5P tablePending;

	private k6A tableSchedule;

	private Rq4 tableSlogin;

	private Dq6 tableTable;

	private SchemaSerializationMode _schemaSerializationMode;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	public e6QZ Flogin => tableFlogin;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public An1p History => tableHistory;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[Browsable(false)]
	public j5P Pending => tablePending;

	[Browsable(false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public k6A Schedule => tableSchedule;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public Rq4 Slogin => tableSlogin;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public Dq6 Table => tableTable;

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
	public Ck89()
	{
		_schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		BeginInit();
		Aw09();
		CollectionChangeEventHandler value = x7XZ;
		base.Tables.CollectionChanged += value;
		base.Relations.CollectionChanged += value;
		EndInit();
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected Ck89(SerializationInfo info, StreamingContext context)
		: base(info, context, ConstructSchema: false)
	{
		_schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		if (IsBinarySerialized(info, context))
		{
			d8JS(q5C1: false);
			CollectionChangeEventHandler value = x7XZ;
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
				base.Tables.Add(new e6QZ(dataSet.Tables["Flogin"]));
			}
			if (dataSet.Tables["History"] != null)
			{
				base.Tables.Add(new An1p(dataSet.Tables["History"]));
			}
			if (dataSet.Tables["Pending"] != null)
			{
				base.Tables.Add(new j5P(dataSet.Tables["Pending"]));
			}
			if (dataSet.Tables["Schedule"] != null)
			{
				base.Tables.Add(new k6A(dataSet.Tables["Schedule"]));
			}
			if (dataSet.Tables["Slogin"] != null)
			{
				base.Tables.Add(new Rq4(dataSet.Tables["Slogin"]));
			}
			if (dataSet.Tables["Table"] != null)
			{
				base.Tables.Add(new Dq6(dataSet.Tables["Table"]));
			}
			base.DataSetName = dataSet.DataSetName;
			base.Prefix = dataSet.Prefix;
			base.Namespace = dataSet.Namespace;
			base.Locale = dataSet.Locale;
			base.CaseSensitive = dataSet.CaseSensitive;
			base.EnforceConstraints = dataSet.EnforceConstraints;
			Merge(dataSet, preserveChanges: false, MissingSchemaAction.Add);
			c8W4();
		}
		else
		{
			ReadXmlSchema(new XmlTextReader(new StringReader(s)));
		}
		GetSerializationData(info, context);
		CollectionChangeEventHandler value2 = x7XZ;
		base.Tables.CollectionChanged += value2;
		Relations.CollectionChanged += value2;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected override void o0ZN()
	{
		BeginInit();
		Aw09();
		EndInit();
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public override DataSet Am93()
	{
		Ck89 ck = (Ck89)base.Clone();
		ck.c8W4();
		ck.SchemaSerializationMode = SchemaSerializationMode;
		return ck;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected override bool Bs1o()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected override bool Ag1w()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected override void Pe49(XmlReader y3NP)
	{
		if (DetermineSchemaSerializationMode(y3NP) == SchemaSerializationMode.IncludeSchema)
		{
			Reset();
			DataSet dataSet = new DataSet();
			dataSet.ReadXml(y3NP);
			if (dataSet.Tables["Flogin"] != null)
			{
				base.Tables.Add(new e6QZ(dataSet.Tables["Flogin"]));
			}
			if (dataSet.Tables["History"] != null)
			{
				base.Tables.Add(new An1p(dataSet.Tables["History"]));
			}
			if (dataSet.Tables["Pending"] != null)
			{
				base.Tables.Add(new j5P(dataSet.Tables["Pending"]));
			}
			if (dataSet.Tables["Schedule"] != null)
			{
				base.Tables.Add(new k6A(dataSet.Tables["Schedule"]));
			}
			if (dataSet.Tables["Slogin"] != null)
			{
				base.Tables.Add(new Rq4(dataSet.Tables["Slogin"]));
			}
			if (dataSet.Tables["Table"] != null)
			{
				base.Tables.Add(new Dq6(dataSet.Tables["Table"]));
			}
			base.DataSetName = dataSet.DataSetName;
			base.Prefix = dataSet.Prefix;
			base.Namespace = dataSet.Namespace;
			base.Locale = dataSet.Locale;
			base.CaseSensitive = dataSet.CaseSensitive;
			base.EnforceConstraints = dataSet.EnforceConstraints;
			Merge(dataSet, preserveChanges: false, MissingSchemaAction.Add);
			c8W4();
		}
		else
		{
			ReadXml(y3NP);
			c8W4();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected override XmlSchema m8B2()
	{
		MemoryStream memoryStream = new MemoryStream();
		WriteXmlSchema(new XmlTextWriter(memoryStream, null));
		memoryStream.Position = 0L;
		return XmlSchema.Read(new XmlTextReader(memoryStream), null);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	internal void c8W4()
	{
		d8JS(q5C1: true);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	internal void d8JS(bool q5C1)
	{
		tableFlogin = (e6QZ)base.Tables["Flogin"];
		if (q5C1 && tableFlogin != null)
		{
			tableFlogin.Ng12();
		}
		tableHistory = (An1p)base.Tables["History"];
		if (q5C1 && tableHistory != null)
		{
			tableHistory.i4M5();
		}
		tablePending = (j5P)base.Tables["Pending"];
		if (q5C1 && tablePending != null)
		{
			tablePending.e2N();
		}
		tableSchedule = (k6A)base.Tables["Schedule"];
		if (q5C1 && tableSchedule != null)
		{
			tableSchedule.Si3();
		}
		tableSlogin = (Rq4)base.Tables["Slogin"];
		if (q5C1 && tableSlogin != null)
		{
			tableSlogin.Zf7();
		}
		tableTable = (Dq6)base.Tables["Table"];
		if (q5C1 && tableTable != null)
		{
			tableTable.De0();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void Aw09()
	{
		base.DataSetName = "Database1DataSet";
		base.Prefix = "";
		base.Namespace = "http://tempuri.org/Database1DataSet.xsd";
		base.EnforceConstraints = true;
		SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		tableFlogin = new e6QZ();
		base.Tables.Add(tableFlogin);
		tableHistory = new An1p();
		base.Tables.Add(tableHistory);
		tablePending = new j5P();
		base.Tables.Add(tablePending);
		tableSchedule = new k6A();
		base.Tables.Add(tableSchedule);
		tableSlogin = new Rq4();
		base.Tables.Add(tableSlogin);
		tableTable = new Dq6();
		base.Tables.Add(tableTable);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private bool s4Z7()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private bool z1X8()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private bool Pm0g()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private bool Yz9i()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private bool t6G3()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private bool Wn25()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void x7XZ(object sender, CollectionChangeEventArgs e)
	{
		if (e.Action == CollectionChangeAction.Remove)
		{
			c8W4();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public static XmlSchemaComplexType Ae0d(XmlSchemaSet Sc34)
	{
		Ck89 ck = new Ck89();
		XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
		XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
		XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
		xmlSchemaAny.Namespace = ck.Namespace;
		xmlSchemaSequence.Items.Add(xmlSchemaAny);
		xmlSchemaComplexType.Particle = xmlSchemaSequence;
		XmlSchema xmlSchema = ck.m8B2();
		if (Sc34.Contains(xmlSchema.TargetNamespace))
		{
			MemoryStream memoryStream = new MemoryStream();
			MemoryStream memoryStream2 = new MemoryStream();
			try
			{
				XmlSchema xmlSchema2 = null;
				xmlSchema.Write(memoryStream);
				IEnumerator enumerator = Sc34.Schemas(xmlSchema.TargetNamespace).GetEnumerator();
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
		Sc34.Add(xmlSchema);
		return xmlSchemaComplexType;
	}
}
