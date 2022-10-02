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

namespace b8D;

[Serializable]
[XmlRoot("Database1DataSet")]
[HelpKeyword("vs.data.DataSet")]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[DesignerCategory("code")]
[ToolboxItem(true)]
public class s1D : DataSet
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public delegate void Hy6(object sender, Pj7 e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public delegate void Wi0(object sender, x8E e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public delegate void d0S(object sender, Mn2 e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public delegate void n1D(object sender, n4Z e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public delegate void g0S(object sender, e8D e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public delegate void Rr5(object sender, Jn1 e);

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class s1E : TypedTableBase<Rf8>
	{
		private DataColumn columnFaculty_ID;

		private DataColumn columnPassword;

		private Hy6 FloginRowChangingEvent;

		private Hy6 FloginRowChangedEvent;

		private Hy6 FloginRowDeletingEvent;

		private Hy6 FloginRowDeletedEvent;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn Faculty_IDColumn => columnFaculty_ID;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn PasswordColumn => columnPassword;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		[Browsable(false)]
		public int Count => base.Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Rf8 this[int Ti5] => (Rf8)base.Rows[Ti5];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event Hy6 FloginRowChanging
		{
			add
			{
				Hy6 hy = FloginRowChangingEvent;
				Hy6 hy2;
				do
				{
					hy2 = hy;
					Hy6 value2 = (Hy6)Delegate.Combine(hy2, value);
					hy = Interlocked.CompareExchange(ref FloginRowChangingEvent, value2, hy2);
				}
				while ((object)hy != hy2);
			}
			remove
			{
				Hy6 hy = FloginRowChangingEvent;
				Hy6 hy2;
				do
				{
					hy2 = hy;
					Hy6 value2 = (Hy6)Delegate.Remove(hy2, value);
					hy = Interlocked.CompareExchange(ref FloginRowChangingEvent, value2, hy2);
				}
				while ((object)hy != hy2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event Hy6 FloginRowChanged
		{
			add
			{
				Hy6 hy = FloginRowChangedEvent;
				Hy6 hy2;
				do
				{
					hy2 = hy;
					Hy6 value2 = (Hy6)Delegate.Combine(hy2, value);
					hy = Interlocked.CompareExchange(ref FloginRowChangedEvent, value2, hy2);
				}
				while ((object)hy != hy2);
			}
			remove
			{
				Hy6 hy = FloginRowChangedEvent;
				Hy6 hy2;
				do
				{
					hy2 = hy;
					Hy6 value2 = (Hy6)Delegate.Remove(hy2, value);
					hy = Interlocked.CompareExchange(ref FloginRowChangedEvent, value2, hy2);
				}
				while ((object)hy != hy2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event Hy6 FloginRowDeleting
		{
			add
			{
				Hy6 hy = FloginRowDeletingEvent;
				Hy6 hy2;
				do
				{
					hy2 = hy;
					Hy6 value2 = (Hy6)Delegate.Combine(hy2, value);
					hy = Interlocked.CompareExchange(ref FloginRowDeletingEvent, value2, hy2);
				}
				while ((object)hy != hy2);
			}
			remove
			{
				Hy6 hy = FloginRowDeletingEvent;
				Hy6 hy2;
				do
				{
					hy2 = hy;
					Hy6 value2 = (Hy6)Delegate.Remove(hy2, value);
					hy = Interlocked.CompareExchange(ref FloginRowDeletingEvent, value2, hy2);
				}
				while ((object)hy != hy2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event Hy6 FloginRowDeleted
		{
			add
			{
				Hy6 hy = FloginRowDeletedEvent;
				Hy6 hy2;
				do
				{
					hy2 = hy;
					Hy6 value2 = (Hy6)Delegate.Combine(hy2, value);
					hy = Interlocked.CompareExchange(ref FloginRowDeletedEvent, value2, hy2);
				}
				while ((object)hy != hy2);
			}
			remove
			{
				Hy6 hy = FloginRowDeletedEvent;
				Hy6 hy2;
				do
				{
					hy2 = hy;
					Hy6 value2 = (Hy6)Delegate.Remove(hy2, value);
					hy = Interlocked.CompareExchange(ref FloginRowDeletedEvent, value2, hy2);
				}
				while ((object)hy != hy2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public s1E()
		{
			base.TableName = "Flogin";
			BeginInit();
			w6N();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal s1E(DataTable table)
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
		protected s1E(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			y2A();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void Sa7(Rf8 r1P)
		{
			base.Rows.Add(r1P);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Rf8 c0N(string m4J, string Sp5)
		{
			Rf8 rf = (Rf8)NewRow();
			object[] array2 = (rf.ItemArray = new object[2] { m4J, Sp5 });
			base.Rows.Add(rf);
			return rf;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public override DataTable Pa0()
		{
			s1E s1E = (s1E)base.Clone();
			s1E.y2A();
			return s1E;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataTable b9J()
		{
			return new s1E();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal void y2A()
		{
			columnFaculty_ID = base.Columns["Faculty_ID"];
			columnPassword = base.Columns["Password"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		private void w6N()
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
		public Rf8 x6C()
		{
			return (Rf8)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataRow f8F(DataRowBuilder n0K)
		{
			return new Rf8(n0K);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override Type We3()
		{
			return typeof(Rf8);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void Sd4(DataRowChangeEventArgs Eo9)
		{
			base.OnRowChanged(Eo9);
			if (FloginRowChangedEvent != null)
			{
				FloginRowChangedEvent?.Invoke(this, new Pj7((Rf8)Eo9.Row, Eo9.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void m0P(DataRowChangeEventArgs Mx2)
		{
			base.OnRowChanging(Mx2);
			if (FloginRowChangingEvent != null)
			{
				FloginRowChangingEvent?.Invoke(this, new Pj7((Rf8)Mx2.Row, Mx2.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void i2Q(DataRowChangeEventArgs t6Z)
		{
			base.OnRowDeleted(t6Z);
			if (FloginRowDeletedEvent != null)
			{
				FloginRowDeletedEvent?.Invoke(this, new Pj7((Rf8)t6Z.Row, t6Z.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void Tb9(DataRowChangeEventArgs Be5)
		{
			base.OnRowDeleting(Be5);
			if (FloginRowDeletingEvent != null)
			{
				FloginRowDeletingEvent?.Invoke(this, new Pj7((Rf8)Be5.Row, Be5.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void Zj9(Rf8 Qn1)
		{
			base.Rows.Remove(Qn1);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public static XmlSchemaComplexType Sa8(XmlSchemaSet Ha6)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			s1D s1D2 = new s1D();
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
			xmlSchemaAttribute.FixedValue = s1D2.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "FloginDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema xmlSchema = s1D2.Xq3();
			if (Ha6.Contains(xmlSchema.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema2 = null;
					xmlSchema.Write(memoryStream);
					IEnumerator enumerator = Ha6.Schemas(xmlSchema.TargetNamespace).GetEnumerator();
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
			Ha6.Add(xmlSchema);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class j3P : TypedTableBase<s2L>
	{
		private DataColumn columnEmail;

		private DataColumn columnFaculty;

		private DataColumn columnSchedule;

		private DataColumn columnAppointment;

		private DataColumn columnRequest;

		private Wi0 HistoryRowChangingEvent;

		private Wi0 HistoryRowChangedEvent;

		private Wi0 HistoryRowDeletingEvent;

		private Wi0 HistoryRowDeletedEvent;

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
		public s2L this[int g3C] => (s2L)base.Rows[g3C];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event Wi0 HistoryRowChanging
		{
			add
			{
				Wi0 wi = HistoryRowChangingEvent;
				Wi0 wi2;
				do
				{
					wi2 = wi;
					Wi0 value2 = (Wi0)Delegate.Combine(wi2, value);
					wi = Interlocked.CompareExchange(ref HistoryRowChangingEvent, value2, wi2);
				}
				while ((object)wi != wi2);
			}
			remove
			{
				Wi0 wi = HistoryRowChangingEvent;
				Wi0 wi2;
				do
				{
					wi2 = wi;
					Wi0 value2 = (Wi0)Delegate.Remove(wi2, value);
					wi = Interlocked.CompareExchange(ref HistoryRowChangingEvent, value2, wi2);
				}
				while ((object)wi != wi2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event Wi0 HistoryRowChanged
		{
			add
			{
				Wi0 wi = HistoryRowChangedEvent;
				Wi0 wi2;
				do
				{
					wi2 = wi;
					Wi0 value2 = (Wi0)Delegate.Combine(wi2, value);
					wi = Interlocked.CompareExchange(ref HistoryRowChangedEvent, value2, wi2);
				}
				while ((object)wi != wi2);
			}
			remove
			{
				Wi0 wi = HistoryRowChangedEvent;
				Wi0 wi2;
				do
				{
					wi2 = wi;
					Wi0 value2 = (Wi0)Delegate.Remove(wi2, value);
					wi = Interlocked.CompareExchange(ref HistoryRowChangedEvent, value2, wi2);
				}
				while ((object)wi != wi2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event Wi0 HistoryRowDeleting
		{
			add
			{
				Wi0 wi = HistoryRowDeletingEvent;
				Wi0 wi2;
				do
				{
					wi2 = wi;
					Wi0 value2 = (Wi0)Delegate.Combine(wi2, value);
					wi = Interlocked.CompareExchange(ref HistoryRowDeletingEvent, value2, wi2);
				}
				while ((object)wi != wi2);
			}
			remove
			{
				Wi0 wi = HistoryRowDeletingEvent;
				Wi0 wi2;
				do
				{
					wi2 = wi;
					Wi0 value2 = (Wi0)Delegate.Remove(wi2, value);
					wi = Interlocked.CompareExchange(ref HistoryRowDeletingEvent, value2, wi2);
				}
				while ((object)wi != wi2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event Wi0 HistoryRowDeleted
		{
			add
			{
				Wi0 wi = HistoryRowDeletedEvent;
				Wi0 wi2;
				do
				{
					wi2 = wi;
					Wi0 value2 = (Wi0)Delegate.Combine(wi2, value);
					wi = Interlocked.CompareExchange(ref HistoryRowDeletedEvent, value2, wi2);
				}
				while ((object)wi != wi2);
			}
			remove
			{
				Wi0 wi = HistoryRowDeletedEvent;
				Wi0 wi2;
				do
				{
					wi2 = wi;
					Wi0 value2 = (Wi0)Delegate.Remove(wi2, value);
					wi = Interlocked.CompareExchange(ref HistoryRowDeletedEvent, value2, wi2);
				}
				while ((object)wi != wi2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public j3P()
		{
			base.TableName = "History";
			BeginInit();
			Kb9();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal j3P(DataTable table)
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
		protected j3P(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			Mk2();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void z4S(s2L Pa5)
		{
			base.Rows.Add(Pa5);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public s2L Xw3(string e0T, string Bj9, string Lc1, string Wt9, string t9A)
		{
			s2L s2L = (s2L)NewRow();
			object[] array2 = (s2L.ItemArray = new object[5] { e0T, Bj9, Lc1, Wt9, t9A });
			base.Rows.Add(s2L);
			return s2L;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public override DataTable e9H()
		{
			j3P j3P = (j3P)base.Clone();
			j3P.Mk2();
			return j3P;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataTable Qj7()
		{
			return new j3P();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal void Mk2()
		{
			columnEmail = base.Columns["Email"];
			columnFaculty = base.Columns["Faculty"];
			columnSchedule = base.Columns["Schedule"];
			columnAppointment = base.Columns["Appointment"];
			columnRequest = base.Columns["Request"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		private void Kb9()
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
		public s2L m0D()
		{
			return (s2L)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataRow Xt8(DataRowBuilder Ai0)
		{
			return new s2L(Ai0);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override Type Pk8()
		{
			return typeof(s2L);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void Nc2(DataRowChangeEventArgs f4K)
		{
			base.OnRowChanged(f4K);
			if (HistoryRowChangedEvent != null)
			{
				HistoryRowChangedEvent?.Invoke(this, new x8E((s2L)f4K.Row, f4K.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void Ly0(DataRowChangeEventArgs Gp6)
		{
			base.OnRowChanging(Gp6);
			if (HistoryRowChangingEvent != null)
			{
				HistoryRowChangingEvent?.Invoke(this, new x8E((s2L)Gp6.Row, Gp6.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void Aw4(DataRowChangeEventArgs Cp2)
		{
			base.OnRowDeleted(Cp2);
			if (HistoryRowDeletedEvent != null)
			{
				HistoryRowDeletedEvent?.Invoke(this, new x8E((s2L)Cp2.Row, Cp2.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void Se1(DataRowChangeEventArgs w8B)
		{
			base.OnRowDeleting(w8B);
			if (HistoryRowDeletingEvent != null)
			{
				HistoryRowDeletingEvent?.Invoke(this, new x8E((s2L)w8B.Row, w8B.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void Mc0(s2L Nq3)
		{
			base.Rows.Remove(Nq3);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public static XmlSchemaComplexType x3Z(XmlSchemaSet Gy6)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			s1D s1D2 = new s1D();
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
			xmlSchemaAttribute.FixedValue = s1D2.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "HistoryDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema xmlSchema = s1D2.Xq3();
			if (Gy6.Contains(xmlSchema.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema2 = null;
					xmlSchema.Write(memoryStream);
					IEnumerator enumerator = Gy6.Schemas(xmlSchema.TargetNamespace).GetEnumerator();
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
			Gy6.Add(xmlSchema);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class Cf9 : TypedTableBase<c8Z>
	{
		private DataColumn columnStudent_ID;

		private DataColumn columnName;

		private DataColumn columnEmail;

		private DataColumn columnSchedule;

		private DataColumn columnAppointment;

		private DataColumn columnFaculty_ID;

		private d0S PendingRowChangingEvent;

		private d0S PendingRowChangedEvent;

		private d0S PendingRowDeletingEvent;

		private d0S PendingRowDeletedEvent;

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
		public c8Z this[int g9L] => (c8Z)base.Rows[g9L];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event d0S PendingRowChanging
		{
			add
			{
				d0S d0S = PendingRowChangingEvent;
				d0S d0S2;
				do
				{
					d0S2 = d0S;
					d0S value2 = (d0S)Delegate.Combine(d0S2, value);
					d0S = Interlocked.CompareExchange(ref PendingRowChangingEvent, value2, d0S2);
				}
				while ((object)d0S != d0S2);
			}
			remove
			{
				d0S d0S = PendingRowChangingEvent;
				d0S d0S2;
				do
				{
					d0S2 = d0S;
					d0S value2 = (d0S)Delegate.Remove(d0S2, value);
					d0S = Interlocked.CompareExchange(ref PendingRowChangingEvent, value2, d0S2);
				}
				while ((object)d0S != d0S2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event d0S PendingRowChanged
		{
			add
			{
				d0S d0S = PendingRowChangedEvent;
				d0S d0S2;
				do
				{
					d0S2 = d0S;
					d0S value2 = (d0S)Delegate.Combine(d0S2, value);
					d0S = Interlocked.CompareExchange(ref PendingRowChangedEvent, value2, d0S2);
				}
				while ((object)d0S != d0S2);
			}
			remove
			{
				d0S d0S = PendingRowChangedEvent;
				d0S d0S2;
				do
				{
					d0S2 = d0S;
					d0S value2 = (d0S)Delegate.Remove(d0S2, value);
					d0S = Interlocked.CompareExchange(ref PendingRowChangedEvent, value2, d0S2);
				}
				while ((object)d0S != d0S2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event d0S PendingRowDeleting
		{
			add
			{
				d0S d0S = PendingRowDeletingEvent;
				d0S d0S2;
				do
				{
					d0S2 = d0S;
					d0S value2 = (d0S)Delegate.Combine(d0S2, value);
					d0S = Interlocked.CompareExchange(ref PendingRowDeletingEvent, value2, d0S2);
				}
				while ((object)d0S != d0S2);
			}
			remove
			{
				d0S d0S = PendingRowDeletingEvent;
				d0S d0S2;
				do
				{
					d0S2 = d0S;
					d0S value2 = (d0S)Delegate.Remove(d0S2, value);
					d0S = Interlocked.CompareExchange(ref PendingRowDeletingEvent, value2, d0S2);
				}
				while ((object)d0S != d0S2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event d0S PendingRowDeleted
		{
			add
			{
				d0S d0S = PendingRowDeletedEvent;
				d0S d0S2;
				do
				{
					d0S2 = d0S;
					d0S value2 = (d0S)Delegate.Combine(d0S2, value);
					d0S = Interlocked.CompareExchange(ref PendingRowDeletedEvent, value2, d0S2);
				}
				while ((object)d0S != d0S2);
			}
			remove
			{
				d0S d0S = PendingRowDeletedEvent;
				d0S d0S2;
				do
				{
					d0S2 = d0S;
					d0S value2 = (d0S)Delegate.Remove(d0S2, value);
					d0S = Interlocked.CompareExchange(ref PendingRowDeletedEvent, value2, d0S2);
				}
				while ((object)d0S != d0S2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Cf9()
		{
			base.TableName = "Pending";
			BeginInit();
			a7S();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal Cf9(DataTable table)
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
		protected Cf9(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			g3R();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void Mo4(c8Z r1W)
		{
			base.Rows.Add(r1W);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public c8Z Db8(string f5X, string Ne6, string p0S, string Eg8, string Pr4, string Sg8)
		{
			c8Z c8Z = (c8Z)NewRow();
			object[] array2 = (c8Z.ItemArray = new object[6] { f5X, Ne6, p0S, Eg8, Pr4, Sg8 });
			base.Rows.Add(c8Z);
			return c8Z;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public override DataTable Ja0()
		{
			Cf9 cf = (Cf9)base.Clone();
			cf.g3R();
			return cf;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataTable f5P()
		{
			return new Cf9();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal void g3R()
		{
			columnStudent_ID = base.Columns["Student_ID"];
			columnName = base.Columns["Name"];
			columnEmail = base.Columns["Email"];
			columnSchedule = base.Columns["Schedule"];
			columnAppointment = base.Columns["Appointment"];
			columnFaculty_ID = base.Columns["Faculty_ID"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		private void a7S()
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
		public c8Z m0X()
		{
			return (c8Z)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataRow k0L(DataRowBuilder Wc9)
		{
			return new c8Z(Wc9);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override Type b2R()
		{
			return typeof(c8Z);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void Td4(DataRowChangeEventArgs Cn3)
		{
			base.OnRowChanged(Cn3);
			if (PendingRowChangedEvent != null)
			{
				PendingRowChangedEvent?.Invoke(this, new Mn2((c8Z)Cn3.Row, Cn3.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void y9J(DataRowChangeEventArgs y3H)
		{
			base.OnRowChanging(y3H);
			if (PendingRowChangingEvent != null)
			{
				PendingRowChangingEvent?.Invoke(this, new Mn2((c8Z)y3H.Row, y3H.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void Ek2(DataRowChangeEventArgs Tk0)
		{
			base.OnRowDeleted(Tk0);
			if (PendingRowDeletedEvent != null)
			{
				PendingRowDeletedEvent?.Invoke(this, new Mn2((c8Z)Tk0.Row, Tk0.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void Xx1(DataRowChangeEventArgs w3S)
		{
			base.OnRowDeleting(w3S);
			if (PendingRowDeletingEvent != null)
			{
				PendingRowDeletingEvent?.Invoke(this, new Mn2((c8Z)w3S.Row, w3S.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void d1Q(c8Z p4C)
		{
			base.Rows.Remove(p4C);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public static XmlSchemaComplexType p9Y(XmlSchemaSet Qk6)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			s1D s1D2 = new s1D();
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
			xmlSchemaAttribute.FixedValue = s1D2.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "PendingDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema xmlSchema = s1D2.Xq3();
			if (Qk6.Contains(xmlSchema.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema2 = null;
					xmlSchema.Write(memoryStream);
					IEnumerator enumerator = Qk6.Schemas(xmlSchema.TargetNamespace).GetEnumerator();
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
			Qk6.Add(xmlSchema);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class Yt5 : TypedTableBase<Zy6>
	{
		private DataColumn columnStudent_ID;

		private DataColumn columnName;

		private DataColumn columnEmail;

		private DataColumn columnSchedule;

		private DataColumn columnAppointment;

		private DataColumn columnFaculty_ID;

		private n1D ScheduleRowChangingEvent;

		private n1D ScheduleRowChangedEvent;

		private n1D ScheduleRowDeletingEvent;

		private n1D ScheduleRowDeletedEvent;

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
		public Zy6 this[int Fm2] => (Zy6)base.Rows[Fm2];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event n1D ScheduleRowChanging
		{
			add
			{
				n1D n1D = ScheduleRowChangingEvent;
				n1D n1D2;
				do
				{
					n1D2 = n1D;
					n1D value2 = (n1D)Delegate.Combine(n1D2, value);
					n1D = Interlocked.CompareExchange(ref ScheduleRowChangingEvent, value2, n1D2);
				}
				while ((object)n1D != n1D2);
			}
			remove
			{
				n1D n1D = ScheduleRowChangingEvent;
				n1D n1D2;
				do
				{
					n1D2 = n1D;
					n1D value2 = (n1D)Delegate.Remove(n1D2, value);
					n1D = Interlocked.CompareExchange(ref ScheduleRowChangingEvent, value2, n1D2);
				}
				while ((object)n1D != n1D2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event n1D ScheduleRowChanged
		{
			add
			{
				n1D n1D = ScheduleRowChangedEvent;
				n1D n1D2;
				do
				{
					n1D2 = n1D;
					n1D value2 = (n1D)Delegate.Combine(n1D2, value);
					n1D = Interlocked.CompareExchange(ref ScheduleRowChangedEvent, value2, n1D2);
				}
				while ((object)n1D != n1D2);
			}
			remove
			{
				n1D n1D = ScheduleRowChangedEvent;
				n1D n1D2;
				do
				{
					n1D2 = n1D;
					n1D value2 = (n1D)Delegate.Remove(n1D2, value);
					n1D = Interlocked.CompareExchange(ref ScheduleRowChangedEvent, value2, n1D2);
				}
				while ((object)n1D != n1D2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event n1D ScheduleRowDeleting
		{
			add
			{
				n1D n1D = ScheduleRowDeletingEvent;
				n1D n1D2;
				do
				{
					n1D2 = n1D;
					n1D value2 = (n1D)Delegate.Combine(n1D2, value);
					n1D = Interlocked.CompareExchange(ref ScheduleRowDeletingEvent, value2, n1D2);
				}
				while ((object)n1D != n1D2);
			}
			remove
			{
				n1D n1D = ScheduleRowDeletingEvent;
				n1D n1D2;
				do
				{
					n1D2 = n1D;
					n1D value2 = (n1D)Delegate.Remove(n1D2, value);
					n1D = Interlocked.CompareExchange(ref ScheduleRowDeletingEvent, value2, n1D2);
				}
				while ((object)n1D != n1D2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event n1D ScheduleRowDeleted
		{
			add
			{
				n1D n1D = ScheduleRowDeletedEvent;
				n1D n1D2;
				do
				{
					n1D2 = n1D;
					n1D value2 = (n1D)Delegate.Combine(n1D2, value);
					n1D = Interlocked.CompareExchange(ref ScheduleRowDeletedEvent, value2, n1D2);
				}
				while ((object)n1D != n1D2);
			}
			remove
			{
				n1D n1D = ScheduleRowDeletedEvent;
				n1D n1D2;
				do
				{
					n1D2 = n1D;
					n1D value2 = (n1D)Delegate.Remove(n1D2, value);
					n1D = Interlocked.CompareExchange(ref ScheduleRowDeletedEvent, value2, n1D2);
				}
				while ((object)n1D != n1D2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Yt5()
		{
			base.TableName = "Schedule";
			BeginInit();
			Ex6();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal Yt5(DataTable table)
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
		protected Yt5(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			Qr9();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void Jt5(Zy6 Hq8)
		{
			base.Rows.Add(Hq8);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Zy6 Ng6(string Ae9, string Nf7, string Tz4, string Lx8, string Gy7, string g0A)
		{
			Zy6 zy = (Zy6)NewRow();
			object[] array2 = (zy.ItemArray = new object[6] { Ae9, Nf7, Tz4, Lx8, Gy7, g0A });
			base.Rows.Add(zy);
			return zy;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public override DataTable s1G()
		{
			Yt5 yt = (Yt5)base.Clone();
			yt.Qr9();
			return yt;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataTable w0F()
		{
			return new Yt5();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal void Qr9()
		{
			columnStudent_ID = base.Columns["Student_ID"];
			columnName = base.Columns["Name"];
			columnEmail = base.Columns["Email"];
			columnSchedule = base.Columns["Schedule"];
			columnAppointment = base.Columns["Appointment"];
			columnFaculty_ID = base.Columns["Faculty_ID"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		private void Ex6()
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
		public Zy6 Ep7()
		{
			return (Zy6)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataRow a8Z(DataRowBuilder k2P)
		{
			return new Zy6(k2P);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override Type s4Q()
		{
			return typeof(Zy6);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void Tn4(DataRowChangeEventArgs Js2)
		{
			base.OnRowChanged(Js2);
			if (ScheduleRowChangedEvent != null)
			{
				ScheduleRowChangedEvent?.Invoke(this, new n4Z((Zy6)Js2.Row, Js2.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void Lz9(DataRowChangeEventArgs q7P)
		{
			base.OnRowChanging(q7P);
			if (ScheduleRowChangingEvent != null)
			{
				ScheduleRowChangingEvent?.Invoke(this, new n4Z((Zy6)q7P.Row, q7P.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void k5P(DataRowChangeEventArgs r9S)
		{
			base.OnRowDeleted(r9S);
			if (ScheduleRowDeletedEvent != null)
			{
				ScheduleRowDeletedEvent?.Invoke(this, new n4Z((Zy6)r9S.Row, r9S.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void Pr6(DataRowChangeEventArgs j6T)
		{
			base.OnRowDeleting(j6T);
			if (ScheduleRowDeletingEvent != null)
			{
				ScheduleRowDeletingEvent?.Invoke(this, new n4Z((Zy6)j6T.Row, j6T.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void a2B(Zy6 Ma2)
		{
			base.Rows.Remove(Ma2);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public static XmlSchemaComplexType t3R(XmlSchemaSet n2C)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			s1D s1D2 = new s1D();
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
			xmlSchemaAttribute.FixedValue = s1D2.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "ScheduleDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema xmlSchema = s1D2.Xq3();
			if (n2C.Contains(xmlSchema.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema2 = null;
					xmlSchema.Write(memoryStream);
					IEnumerator enumerator = n2C.Schemas(xmlSchema.TargetNamespace).GetEnumerator();
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
			n2C.Add(xmlSchema);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class Rk3 : TypedTableBase<b3Z>
	{
		private DataColumn columnStudent_ID;

		private DataColumn columnPassword;

		private DataColumn columnName;

		private g0S SloginRowChangingEvent;

		private g0S SloginRowChangedEvent;

		private g0S SloginRowDeletingEvent;

		private g0S SloginRowDeletedEvent;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn Student_IDColumn => columnStudent_ID;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn PasswordColumn => columnPassword;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataColumn NameColumn => columnName;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		[Browsable(false)]
		public int Count => base.Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public b3Z this[int Fn3] => (b3Z)base.Rows[Fn3];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event g0S SloginRowChanging
		{
			add
			{
				g0S g0S = SloginRowChangingEvent;
				g0S g0S2;
				do
				{
					g0S2 = g0S;
					g0S value2 = (g0S)Delegate.Combine(g0S2, value);
					g0S = Interlocked.CompareExchange(ref SloginRowChangingEvent, value2, g0S2);
				}
				while ((object)g0S != g0S2);
			}
			remove
			{
				g0S g0S = SloginRowChangingEvent;
				g0S g0S2;
				do
				{
					g0S2 = g0S;
					g0S value2 = (g0S)Delegate.Remove(g0S2, value);
					g0S = Interlocked.CompareExchange(ref SloginRowChangingEvent, value2, g0S2);
				}
				while ((object)g0S != g0S2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event g0S SloginRowChanged
		{
			add
			{
				g0S g0S = SloginRowChangedEvent;
				g0S g0S2;
				do
				{
					g0S2 = g0S;
					g0S value2 = (g0S)Delegate.Combine(g0S2, value);
					g0S = Interlocked.CompareExchange(ref SloginRowChangedEvent, value2, g0S2);
				}
				while ((object)g0S != g0S2);
			}
			remove
			{
				g0S g0S = SloginRowChangedEvent;
				g0S g0S2;
				do
				{
					g0S2 = g0S;
					g0S value2 = (g0S)Delegate.Remove(g0S2, value);
					g0S = Interlocked.CompareExchange(ref SloginRowChangedEvent, value2, g0S2);
				}
				while ((object)g0S != g0S2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event g0S SloginRowDeleting
		{
			add
			{
				g0S g0S = SloginRowDeletingEvent;
				g0S g0S2;
				do
				{
					g0S2 = g0S;
					g0S value2 = (g0S)Delegate.Combine(g0S2, value);
					g0S = Interlocked.CompareExchange(ref SloginRowDeletingEvent, value2, g0S2);
				}
				while ((object)g0S != g0S2);
			}
			remove
			{
				g0S g0S = SloginRowDeletingEvent;
				g0S g0S2;
				do
				{
					g0S2 = g0S;
					g0S value2 = (g0S)Delegate.Remove(g0S2, value);
					g0S = Interlocked.CompareExchange(ref SloginRowDeletingEvent, value2, g0S2);
				}
				while ((object)g0S != g0S2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event g0S SloginRowDeleted
		{
			add
			{
				g0S g0S = SloginRowDeletedEvent;
				g0S g0S2;
				do
				{
					g0S2 = g0S;
					g0S value2 = (g0S)Delegate.Combine(g0S2, value);
					g0S = Interlocked.CompareExchange(ref SloginRowDeletedEvent, value2, g0S2);
				}
				while ((object)g0S != g0S2);
			}
			remove
			{
				g0S g0S = SloginRowDeletedEvent;
				g0S g0S2;
				do
				{
					g0S2 = g0S;
					g0S value2 = (g0S)Delegate.Remove(g0S2, value);
					g0S = Interlocked.CompareExchange(ref SloginRowDeletedEvent, value2, g0S2);
				}
				while ((object)g0S != g0S2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Rk3()
		{
			base.TableName = "Slogin";
			BeginInit();
			a0Q();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal Rk3(DataTable table)
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
		protected Rk3(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			s2F();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void Te3(b3Z Cp9)
		{
			base.Rows.Add(Cp9);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public b3Z Dr9(string b9C, string Nn9, string o9K)
		{
			b3Z b3Z = (b3Z)NewRow();
			object[] array2 = (b3Z.ItemArray = new object[3] { b9C, Nn9, o9K });
			base.Rows.Add(b3Z);
			return b3Z;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public override DataTable Sq4()
		{
			Rk3 rk = (Rk3)base.Clone();
			rk.s2F();
			return rk;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataTable w3F()
		{
			return new Rk3();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal void s2F()
		{
			columnStudent_ID = base.Columns["Student_ID"];
			columnPassword = base.Columns["Password"];
			columnName = base.Columns["Name"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		private void a0Q()
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
		public b3Z Sy5()
		{
			return (b3Z)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataRow t7D(DataRowBuilder Ze9)
		{
			return new b3Z(Ze9);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override Type Xs8()
		{
			return typeof(b3Z);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void Jc6(DataRowChangeEventArgs Tq4)
		{
			base.OnRowChanged(Tq4);
			if (SloginRowChangedEvent != null)
			{
				SloginRowChangedEvent?.Invoke(this, new e8D((b3Z)Tq4.Row, Tq4.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void x2X(DataRowChangeEventArgs Bg6)
		{
			base.OnRowChanging(Bg6);
			if (SloginRowChangingEvent != null)
			{
				SloginRowChangingEvent?.Invoke(this, new e8D((b3Z)Bg6.Row, Bg6.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void k4G(DataRowChangeEventArgs i1Z)
		{
			base.OnRowDeleted(i1Z);
			if (SloginRowDeletedEvent != null)
			{
				SloginRowDeletedEvent?.Invoke(this, new e8D((b3Z)i1Z.Row, i1Z.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void Cz8(DataRowChangeEventArgs s3L)
		{
			base.OnRowDeleting(s3L);
			if (SloginRowDeletingEvent != null)
			{
				SloginRowDeletingEvent?.Invoke(this, new e8D((b3Z)s3L.Row, s3L.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void Jq7(b3Z q2Y)
		{
			base.Rows.Remove(q2Y);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public static XmlSchemaComplexType q5Z(XmlSchemaSet Ww4)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			s1D s1D2 = new s1D();
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
			xmlSchemaAttribute.FixedValue = s1D2.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "SloginDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema xmlSchema = s1D2.Xq3();
			if (Ww4.Contains(xmlSchema.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema2 = null;
					xmlSchema.Write(memoryStream);
					IEnumerator enumerator = Ww4.Schemas(xmlSchema.TargetNamespace).GetEnumerator();
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
			Ww4.Add(xmlSchema);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class z6K : TypedTableBase<c5W>
	{
		private DataColumn columnStudent_ID;

		private DataColumn columnName;

		private DataColumn columnEmail;

		private DataColumn columnSchedule;

		private DataColumn columnAppointment;

		private DataColumn columnFaculty_ID;

		private Rr5 TableRowChangingEvent;

		private Rr5 TableRowChangedEvent;

		private Rr5 TableRowDeletingEvent;

		private Rr5 TableRowDeletedEvent;

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
		public c5W this[int Dp2] => (c5W)base.Rows[Dp2];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event Rr5 TableRowChanging
		{
			add
			{
				Rr5 rr = TableRowChangingEvent;
				Rr5 rr2;
				do
				{
					rr2 = rr;
					Rr5 value2 = (Rr5)Delegate.Combine(rr2, value);
					rr = Interlocked.CompareExchange(ref TableRowChangingEvent, value2, rr2);
				}
				while ((object)rr != rr2);
			}
			remove
			{
				Rr5 rr = TableRowChangingEvent;
				Rr5 rr2;
				do
				{
					rr2 = rr;
					Rr5 value2 = (Rr5)Delegate.Remove(rr2, value);
					rr = Interlocked.CompareExchange(ref TableRowChangingEvent, value2, rr2);
				}
				while ((object)rr != rr2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event Rr5 TableRowChanged
		{
			add
			{
				Rr5 rr = TableRowChangedEvent;
				Rr5 rr2;
				do
				{
					rr2 = rr;
					Rr5 value2 = (Rr5)Delegate.Combine(rr2, value);
					rr = Interlocked.CompareExchange(ref TableRowChangedEvent, value2, rr2);
				}
				while ((object)rr != rr2);
			}
			remove
			{
				Rr5 rr = TableRowChangedEvent;
				Rr5 rr2;
				do
				{
					rr2 = rr;
					Rr5 value2 = (Rr5)Delegate.Remove(rr2, value);
					rr = Interlocked.CompareExchange(ref TableRowChangedEvent, value2, rr2);
				}
				while ((object)rr != rr2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event Rr5 TableRowDeleting
		{
			add
			{
				Rr5 rr = TableRowDeletingEvent;
				Rr5 rr2;
				do
				{
					rr2 = rr;
					Rr5 value2 = (Rr5)Delegate.Combine(rr2, value);
					rr = Interlocked.CompareExchange(ref TableRowDeletingEvent, value2, rr2);
				}
				while ((object)rr != rr2);
			}
			remove
			{
				Rr5 rr = TableRowDeletingEvent;
				Rr5 rr2;
				do
				{
					rr2 = rr;
					Rr5 value2 = (Rr5)Delegate.Remove(rr2, value);
					rr = Interlocked.CompareExchange(ref TableRowDeletingEvent, value2, rr2);
				}
				while ((object)rr != rr2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public event Rr5 TableRowDeleted
		{
			add
			{
				Rr5 rr = TableRowDeletedEvent;
				Rr5 rr2;
				do
				{
					rr2 = rr;
					Rr5 value2 = (Rr5)Delegate.Combine(rr2, value);
					rr = Interlocked.CompareExchange(ref TableRowDeletedEvent, value2, rr2);
				}
				while ((object)rr != rr2);
			}
			remove
			{
				Rr5 rr = TableRowDeletedEvent;
				Rr5 rr2;
				do
				{
					rr2 = rr;
					Rr5 value2 = (Rr5)Delegate.Remove(rr2, value);
					rr = Interlocked.CompareExchange(ref TableRowDeletedEvent, value2, rr2);
				}
				while ((object)rr != rr2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public z6K()
		{
			base.TableName = "Table";
			BeginInit();
			p7W();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal z6K(DataTable table)
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
		protected z6K(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			Mz1();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void Br8(c5W Ax8)
		{
			base.Rows.Add(Ax8);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public c5W m0T(string z6M, string g3C, string x1P, string Sa6, string n8J, string Kx7)
		{
			c5W c5W = (c5W)NewRow();
			object[] array2 = (c5W.ItemArray = new object[6] { z6M, g3C, x1P, Sa6, n8J, Kx7 });
			base.Rows.Add(c5W);
			return c5W;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public override DataTable p6T()
		{
			z6K z6K = (z6K)base.Clone();
			z6K.Mz1();
			return z6K;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataTable w7S()
		{
			return new z6K();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal void Mz1()
		{
			columnStudent_ID = base.Columns["Student_ID"];
			columnName = base.Columns["Name"];
			columnEmail = base.Columns["Email"];
			columnSchedule = base.Columns["Schedule"];
			columnAppointment = base.Columns["Appointment"];
			columnFaculty_ID = base.Columns["Faculty_ID"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		private void p7W()
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
		public c5W Ck5()
		{
			return (c5W)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override DataRow q4P(DataRowBuilder o7L)
		{
			return new c5W(o7L);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override Type b5N()
		{
			return typeof(c5W);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void Wr4(DataRowChangeEventArgs Kk3)
		{
			base.OnRowChanged(Kk3);
			if (TableRowChangedEvent != null)
			{
				TableRowChangedEvent?.Invoke(this, new Jn1((c5W)Kk3.Row, Kk3.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void m8K(DataRowChangeEventArgs m0Q)
		{
			base.OnRowChanging(m0Q);
			if (TableRowChangingEvent != null)
			{
				TableRowChangingEvent?.Invoke(this, new Jn1((c5W)m0Q.Row, m0Q.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void e4D(DataRowChangeEventArgs d2H)
		{
			base.OnRowDeleted(d2H);
			if (TableRowDeletedEvent != null)
			{
				TableRowDeletedEvent?.Invoke(this, new Jn1((c5W)d2H.Row, d2H.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void q7K(DataRowChangeEventArgs Li6)
		{
			base.OnRowDeleting(Li6);
			if (TableRowDeletingEvent != null)
			{
				TableRowDeletingEvent?.Invoke(this, new Jn1((c5W)Li6.Row, Li6.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public void Fx9(c5W Wi6)
		{
			base.Rows.Remove(Wi6);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public static XmlSchemaComplexType r9F(XmlSchemaSet Jx5)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			s1D s1D2 = new s1D();
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
			xmlSchemaAttribute.FixedValue = s1D2.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "TableDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema xmlSchema = s1D2.Xq3();
			if (Jx5.Contains(xmlSchema.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema2 = null;
					xmlSchema.Write(memoryStream);
					IEnumerator enumerator = Jx5.Schemas(xmlSchema.TargetNamespace).GetEnumerator();
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
			Jx5.Add(xmlSchema);
			return xmlSchemaComplexType;
		}
	}

	public class Rf8 : DataRow
	{
		private s1E tableFlogin;

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
		internal Rf8(DataRowBuilder rb)
			: base(rb)
		{
			tableFlogin = (s1E)base.Table;
		}
	}

	public class s2L : DataRow
	{
		private j3P tableHistory;

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
		internal s2L(DataRowBuilder rb)
			: base(rb)
		{
			tableHistory = (j3P)base.Table;
		}
	}

	public class c8Z : DataRow
	{
		private Cf9 tablePending;

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
		internal c8Z(DataRowBuilder rb)
			: base(rb)
		{
			tablePending = (Cf9)base.Table;
		}
	}

	public class Zy6 : DataRow
	{
		private Yt5 tableSchedule;

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
		internal Zy6(DataRowBuilder rb)
			: base(rb)
		{
			tableSchedule = (Yt5)base.Table;
		}
	}

	public class b3Z : DataRow
	{
		private Rk3 tableSlogin;

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
		internal b3Z(DataRowBuilder rb)
			: base(rb)
		{
			tableSlogin = (Rk3)base.Table;
		}
	}

	public class c5W : DataRow
	{
		private z6K tableTable;

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
		internal c5W(DataRowBuilder rb)
			: base(rb)
		{
			tableTable = (z6K)base.Table;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public class Pj7 : EventArgs
	{
		private Rf8 eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Rf8 Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Pj7(Rf8 row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public class x8E : EventArgs
	{
		private s2L eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public s2L Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public x8E(s2L row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public class Mn2 : EventArgs
	{
		private c8Z eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public c8Z Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Mn2(c8Z row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public class n4Z : EventArgs
	{
		private Zy6 eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Zy6 Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public n4Z(Zy6 row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public class e8D : EventArgs
	{
		private b3Z eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public b3Z Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public e8D(b3Z row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public class Jn1 : EventArgs
	{
		private c5W eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public c5W Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public Jn1(c5W row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	private s1E tableFlogin;

	private j3P tableHistory;

	private Cf9 tablePending;

	private Yt5 tableSchedule;

	private Rk3 tableSlogin;

	private z6K tableTable;

	private SchemaSerializationMode _schemaSerializationMode;

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public s1E Flogin => tableFlogin;

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public j3P History => tableHistory;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public Cf9 Pending => tablePending;

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public Yt5 Schedule => tableSchedule;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[Browsable(false)]
	public Rk3 Slogin => tableSlogin;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	[Browsable(false)]
	public z6K Table => tableTable;

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
	public s1D()
	{
		_schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		BeginInit();
		Yt3();
		CollectionChangeEventHandler value = Ht7;
		base.Tables.CollectionChanged += value;
		base.Relations.CollectionChanged += value;
		EndInit();
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected s1D(SerializationInfo info, StreamingContext context)
		: base(info, context, ConstructSchema: false)
	{
		_schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		if (IsBinarySerialized(info, context))
		{
			p3X(w8P: false);
			CollectionChangeEventHandler value = Ht7;
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
				base.Tables.Add(new s1E(dataSet.Tables["Flogin"]));
			}
			if (dataSet.Tables["History"] != null)
			{
				base.Tables.Add(new j3P(dataSet.Tables["History"]));
			}
			if (dataSet.Tables["Pending"] != null)
			{
				base.Tables.Add(new Cf9(dataSet.Tables["Pending"]));
			}
			if (dataSet.Tables["Schedule"] != null)
			{
				base.Tables.Add(new Yt5(dataSet.Tables["Schedule"]));
			}
			if (dataSet.Tables["Slogin"] != null)
			{
				base.Tables.Add(new Rk3(dataSet.Tables["Slogin"]));
			}
			if (dataSet.Tables["Table"] != null)
			{
				base.Tables.Add(new z6K(dataSet.Tables["Table"]));
			}
			base.DataSetName = dataSet.DataSetName;
			base.Prefix = dataSet.Prefix;
			base.Namespace = dataSet.Namespace;
			base.Locale = dataSet.Locale;
			base.CaseSensitive = dataSet.CaseSensitive;
			base.EnforceConstraints = dataSet.EnforceConstraints;
			Merge(dataSet, preserveChanges: false, MissingSchemaAction.Add);
			St5();
		}
		else
		{
			ReadXmlSchema(new XmlTextReader(new StringReader(s)));
		}
		GetSerializationData(info, context);
		CollectionChangeEventHandler value2 = Ht7;
		base.Tables.CollectionChanged += value2;
		Relations.CollectionChanged += value2;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected override void Ab8()
	{
		BeginInit();
		Yt3();
		EndInit();
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public override DataSet g4B()
	{
		s1D s1D2 = (s1D)base.Clone();
		s1D2.St5();
		s1D2.SchemaSerializationMode = SchemaSerializationMode;
		return s1D2;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected override bool Tc7()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected override bool o8W()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected override void Ht9(XmlReader c9F)
	{
		if (DetermineSchemaSerializationMode(c9F) == SchemaSerializationMode.IncludeSchema)
		{
			Reset();
			DataSet dataSet = new DataSet();
			dataSet.ReadXml(c9F);
			if (dataSet.Tables["Flogin"] != null)
			{
				base.Tables.Add(new s1E(dataSet.Tables["Flogin"]));
			}
			if (dataSet.Tables["History"] != null)
			{
				base.Tables.Add(new j3P(dataSet.Tables["History"]));
			}
			if (dataSet.Tables["Pending"] != null)
			{
				base.Tables.Add(new Cf9(dataSet.Tables["Pending"]));
			}
			if (dataSet.Tables["Schedule"] != null)
			{
				base.Tables.Add(new Yt5(dataSet.Tables["Schedule"]));
			}
			if (dataSet.Tables["Slogin"] != null)
			{
				base.Tables.Add(new Rk3(dataSet.Tables["Slogin"]));
			}
			if (dataSet.Tables["Table"] != null)
			{
				base.Tables.Add(new z6K(dataSet.Tables["Table"]));
			}
			base.DataSetName = dataSet.DataSetName;
			base.Prefix = dataSet.Prefix;
			base.Namespace = dataSet.Namespace;
			base.Locale = dataSet.Locale;
			base.CaseSensitive = dataSet.CaseSensitive;
			base.EnforceConstraints = dataSet.EnforceConstraints;
			Merge(dataSet, preserveChanges: false, MissingSchemaAction.Add);
			St5();
		}
		else
		{
			ReadXml(c9F);
			St5();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	protected override XmlSchema Xq3()
	{
		MemoryStream memoryStream = new MemoryStream();
		WriteXmlSchema(new XmlTextWriter(memoryStream, null));
		memoryStream.Position = 0L;
		return XmlSchema.Read(new XmlTextReader(memoryStream), null);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	internal void St5()
	{
		p3X(w8P: true);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	internal void p3X(bool w8P)
	{
		tableFlogin = (s1E)base.Tables["Flogin"];
		if (w8P && tableFlogin != null)
		{
			tableFlogin.y2A();
		}
		tableHistory = (j3P)base.Tables["History"];
		if (w8P && tableHistory != null)
		{
			tableHistory.Mk2();
		}
		tablePending = (Cf9)base.Tables["Pending"];
		if (w8P && tablePending != null)
		{
			tablePending.g3R();
		}
		tableSchedule = (Yt5)base.Tables["Schedule"];
		if (w8P && tableSchedule != null)
		{
			tableSchedule.Qr9();
		}
		tableSlogin = (Rk3)base.Tables["Slogin"];
		if (w8P && tableSlogin != null)
		{
			tableSlogin.s2F();
		}
		tableTable = (z6K)base.Tables["Table"];
		if (w8P && tableTable != null)
		{
			tableTable.Mz1();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void Yt3()
	{
		base.DataSetName = "Database1DataSet";
		base.Prefix = "";
		base.Namespace = "http://tempuri.org/Database1DataSet.xsd";
		base.EnforceConstraints = true;
		SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		tableFlogin = new s1E();
		base.Tables.Add(tableFlogin);
		tableHistory = new j3P();
		base.Tables.Add(tableHistory);
		tablePending = new Cf9();
		base.Tables.Add(tablePending);
		tableSchedule = new Yt5();
		base.Tables.Add(tableSchedule);
		tableSlogin = new Rk3();
		base.Tables.Add(tableSlogin);
		tableTable = new z6K();
		base.Tables.Add(tableTable);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private bool k5C()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private bool Nc7()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private bool t7C()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private bool Pw5()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private bool Ft3()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private bool e4N()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	private void Ht7(object sender, CollectionChangeEventArgs e)
	{
		if (e.Action == CollectionChangeAction.Remove)
		{
			St5();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
	public static XmlSchemaComplexType p9Y(XmlSchemaSet e2A)
	{
		s1D s1D2 = new s1D();
		XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
		XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
		XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
		xmlSchemaAny.Namespace = s1D2.Namespace;
		xmlSchemaSequence.Items.Add(xmlSchemaAny);
		xmlSchemaComplexType.Particle = xmlSchemaSequence;
		XmlSchema xmlSchema = s1D2.Xq3();
		if (e2A.Contains(xmlSchema.TargetNamespace))
		{
			MemoryStream memoryStream = new MemoryStream();
			MemoryStream memoryStream2 = new MemoryStream();
			try
			{
				XmlSchema xmlSchema2 = null;
				xmlSchema.Write(memoryStream);
				IEnumerator enumerator = e2A.Schemas(xmlSchema.TargetNamespace).GetEnumerator();
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
		e2A.Add(xmlSchema);
		return xmlSchemaComplexType;
	}
}
