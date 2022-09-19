using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Microsoft.Win32.TaskScheduler.Properties;
using Microsoft.Win32.TaskScheduler.V1Interop;
using Microsoft.Win32.TaskScheduler.V2Interop;

namespace Microsoft.Win32.TaskScheduler;

[ComVisible(false)]
[XmlRoot("Triggers", Namespace = "http://schemas.microsoft.com/windows/2004/02/mit/task", IsNullable = false)]
public sealed class TriggerCollection : IDisposable, IEnumerable<Trigger>, IEnumerable, IXmlSerializable
{
	internal sealed class V1TriggerEnumerator : IDisposable, IEnumerator<Trigger>, IEnumerator
	{
		private ITask iTask;

		private short curItem = -1;

		public Trigger Current => Trigger.CreateTrigger(iTask.GetTrigger((ushort)curItem));

		object IEnumerator.Current => Current;

		internal V1TriggerEnumerator(ITask task)
		{
			iTask = task;
		}

		public void Dispose()
		{
			iTask = null;
		}

		public bool MoveNext()
		{
			if (++curItem >= iTask.GetTriggerCount())
			{
				return false;
			}
			return true;
		}

		public void Reset()
		{
			curItem = -1;
		}
	}

	internal sealed class V2TriggerEnumerator : IDisposable, IEnumerator<Trigger>, IEnumerator
	{
		private IEnumerator iEnum;

		public Trigger Current => Trigger.CreateTrigger((ITrigger)iEnum.Current);

		object IEnumerator.Current => Current;

		internal V2TriggerEnumerator(ITriggerCollection iColl)
		{
			iEnum = iColl.GetEnumerator();
		}

		public void Dispose()
		{
			iEnum = null;
		}

		public bool MoveNext()
		{
			return iEnum.MoveNext();
		}

		public void Reset()
		{
			iEnum.Reset();
		}
	}

	private ITask v1Task;

	private ITaskDefinition v2Def;

	private ITriggerCollection v2Coll;

	public int Count
	{
		get
		{
			if (v2Coll != null)
			{
				return v2Coll.Count;
			}
			return v1Task.GetTriggerCount();
		}
	}

	public Trigger this[int index]
	{
		get
		{
			if (v2Coll != null)
			{
				return Trigger.CreateTrigger(v2Coll[++index]);
			}
			return Trigger.CreateTrigger(v1Task.GetTrigger((ushort)index));
		}
		set
		{
			if (Count <= index)
			{
				throw new ArgumentOutOfRangeException("index", index, "Index is not a valid index in the TriggerCollection");
			}
			RemoveAt(index);
			Insert(index, value);
		}
	}

	internal TriggerCollection(ITask iTask)
	{
		v1Task = iTask;
	}

	internal TriggerCollection(ITaskDefinition iTaskDef)
	{
		v2Def = iTaskDef;
		v2Coll = v2Def.Triggers;
	}

	public void Dispose()
	{
		if (v2Coll != null)
		{
			Marshal.ReleaseComObject(v2Coll);
		}
		v2Def = null;
		v1Task = null;
	}

	public IEnumerator<Trigger> GetEnumerator()
	{
		if (v1Task != null)
		{
			return new V1TriggerEnumerator(v1Task);
		}
		return new V2TriggerEnumerator(v2Coll);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public Trigger Add(Trigger unboundTrigger)
	{
		if (v2Def != null)
		{
			unboundTrigger.Bind(v2Def);
		}
		else
		{
			unboundTrigger.Bind(v1Task);
		}
		return unboundTrigger;
	}

	public Trigger AddNew(TaskTriggerType taskTriggerType)
	{
		ushort NewTriggerIndex;
		if (v1Task != null)
		{
			return Trigger.CreateTrigger(v1Task.CreateTrigger(out NewTriggerIndex), Trigger.ConvertToV1TriggerType(taskTriggerType));
		}
		return Trigger.CreateTrigger(v2Coll.Create(taskTriggerType));
	}

	internal void Bind()
	{
		using IEnumerator<Trigger> enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			Trigger current = enumerator.Current;
			current.SetV1TriggerData();
		}
	}

	public void Clear()
	{
		if (v2Coll != null)
		{
			v2Coll.Clear();
			return;
		}
		for (int num = Count - 1; num >= 0; num--)
		{
			RemoveAt(num);
		}
	}

	public bool ContainsType(Type triggerType)
	{
		using (IEnumerator<Trigger> enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				Trigger current = enumerator.Current;
				if ((object)current.GetType() == triggerType)
				{
					return true;
				}
			}
		}
		return false;
	}

	public void Insert(int index, Trigger trigger)
	{
		Trigger[] array = new Trigger[Count - index];
		for (int i = index; i < Count; i++)
		{
			array[i - index] = (Trigger)this[i].Clone();
		}
		for (int num = Count - 1; num >= index; num--)
		{
			RemoveAt(num);
		}
		Add(trigger);
		for (int j = 0; j < array.Length; j++)
		{
			Add(array[j]);
		}
	}

	public void RemoveAt(int index)
	{
		if (index >= Count)
		{
			throw new ArgumentOutOfRangeException("index", index, "Failed to remove Trigger. Index out of range.");
		}
		if (v2Coll != null)
		{
			v2Coll.Remove(++index);
		}
		else
		{
			v1Task.DeleteTrigger((ushort)index);
		}
	}

	public override string ToString()
	{
		if (Count == 1)
		{
			return this[0].ToString();
		}
		if (Count > 1)
		{
			return Resources.MultipleTriggers;
		}
		return string.Empty;
	}

	XmlSchema IXmlSerializable.GetSchema()
	{
		throw new NotImplementedException();
	}

	void IXmlSerializable.ReadXml(XmlReader reader)
	{
		reader.ReadStartElement("Triggers", "http://schemas.microsoft.com/windows/2004/02/mit/task");
		while (reader.MoveToContent() == XmlNodeType.Element)
		{
			switch (reader.LocalName)
			{
			case "CalendarTrigger":
				Add(CalendarTrigger.GetTriggerFromXml(reader));
				break;
			case "LogonTrigger":
				XmlSerializationHelper.ReadObject(reader, AddNew(TaskTriggerType.Logon));
				break;
			case "TimeTrigger":
				XmlSerializationHelper.ReadObject(reader, AddNew(TaskTriggerType.Time));
				break;
			case "IdleTrigger":
				XmlSerializationHelper.ReadObject(reader, AddNew(TaskTriggerType.Idle));
				break;
			case "BootTrigger":
				XmlSerializationHelper.ReadObject(reader, AddNew(TaskTriggerType.Boot));
				break;
			default:
				reader.Skip();
				break;
			}
		}
		reader.ReadEndElement();
	}

	void IXmlSerializable.WriteXml(XmlWriter writer)
	{
		using IEnumerator<Trigger> enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			Trigger current = enumerator.Current;
			XmlSerializationHelper.WriteObject(writer, current);
		}
	}
}
