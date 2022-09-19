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
[XmlRoot("Actions", Namespace = "http://schemas.microsoft.com/windows/2004/02/mit/task", IsNullable = false)]
public sealed class ActionCollection : IEnumerable<Action>, IDisposable, IEnumerable, IXmlSerializable
{
	internal class Enumerator : IDisposable, IEnumerator<Action>, IEnumerator
	{
		private ITask v1Task;

		private int v1Pos = -1;

		private IEnumerator v2Enum;

		private ActionCollection parent;

		public Action Current
		{
			get
			{
				if (v2Enum != null && v2Enum.Current is IAction iAction)
				{
					return Action.CreateAction(iAction);
				}
				if (v1Pos != 0)
				{
					throw new InvalidOperationException();
				}
				return new ExecAction(v1Task.GetApplicationName(), v1Task.GetParameters(), v1Task.GetWorkingDirectory());
			}
		}

		object IEnumerator.Current => Current;

		internal Enumerator(ITask task)
		{
			v1Task = task;
		}

		internal Enumerator(ActionCollection iColl)
		{
			parent = iColl;
			if (iColl.v2Coll != null)
			{
				v2Enum = iColl.v2Coll.GetEnumerator();
			}
		}

		public void Dispose()
		{
			v1Task = null;
			v2Enum = null;
		}

		public bool MoveNext()
		{
			if (v2Enum != null)
			{
				return v2Enum.MoveNext();
			}
			return ++v1Pos == 0;
		}

		public void Reset()
		{
			if (v2Enum != null)
			{
				v2Enum.Reset();
			}
			v1Pos = -1;
		}
	}

	private ITask v1Task;

	private ITaskDefinition v2Def;

	private IActionCollection v2Coll;

	public Action this[int index]
	{
		get
		{
			if (v2Coll != null)
			{
				return Action.CreateAction(v2Coll[++index]);
			}
			if (index != 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			return new ExecAction(v1Task.GetApplicationName(), v1Task.GetParameters(), v1Task.GetWorkingDirectory());
		}
		set
		{
			if (Count <= index)
			{
				throw new ArgumentOutOfRangeException("index", index, "Index is not a valid index in the ActionCollection");
			}
			RemoveAt(index);
			Insert(index, value);
		}
	}

	[XmlAttribute(AttributeName = "Context", DataType = "IDREF")]
	public string Context
	{
		get
		{
			if (v2Coll != null)
			{
				return v2Coll.Context;
			}
			return string.Empty;
		}
		set
		{
			if (v2Coll == null)
			{
				throw new NotV1SupportedException();
			}
			v2Coll.Context = value;
		}
	}

	public int Count
	{
		get
		{
			if (v2Coll != null)
			{
				return v2Coll.Count;
			}
			if (((string)v1Task.GetApplicationName()).Length != 0)
			{
				return 1;
			}
			return 0;
		}
	}

	public string XmlText
	{
		get
		{
			if (v2Coll != null)
			{
				return v2Coll.XmlText;
			}
			return XmlSerializationHelper.WriteObjectToXmlText(this);
		}
		set
		{
			if (v2Coll != null)
			{
				v2Coll.XmlText = value;
			}
			else
			{
				XmlSerializationHelper.ReadObjectFromXmlText(value, this);
			}
		}
	}

	internal ActionCollection(ITask task)
	{
		v1Task = task;
	}

	internal ActionCollection(ITaskDefinition iTaskDef)
	{
		v2Def = iTaskDef;
		v2Coll = iTaskDef.Actions;
	}

	public void Dispose()
	{
		v1Task = null;
		v2Def = null;
		v2Coll = null;
	}

	public Action Add(Action action)
	{
		if (v2Def != null)
		{
			action.Bind(v2Def);
		}
		else
		{
			action.Bind(v1Task);
		}
		return action;
	}

	public Action AddNew(TaskActionType actionType)
	{
		if (v1Task != null)
		{
			return new ExecAction(v1Task);
		}
		return Action.CreateAction(v2Coll.Create(actionType));
	}

	public void Clear()
	{
		if (v2Coll != null)
		{
			v2Coll.Clear();
		}
		else
		{
			Add(new ExecAction());
		}
	}

	public bool ContainsType(Type actionType)
	{
		using (IEnumerator<Action> enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				Action current = enumerator.Current;
				if ((object)current.GetType() == actionType)
				{
					return true;
				}
			}
		}
		return false;
	}

	public void Insert(int index, Action action)
	{
		if (v2Coll == null && Count > 0)
		{
			throw new NotV1SupportedException("Only a single action is allowed.");
		}
		Action[] array = new Action[Count - index];
		for (int i = index; i < Count; i++)
		{
			array[i - index] = (Action)this[i].Clone();
		}
		for (int num = Count - 1; num >= index; num--)
		{
			RemoveAt(num);
		}
		Add(action);
		for (int j = 0; j < array.Length; j++)
		{
			Add(array[j]);
		}
	}

	public void RemoveAt(int index)
	{
		if (index >= Count)
		{
			throw new ArgumentOutOfRangeException("index", index, "Failed to remove action. Index out of range.");
		}
		if (v2Coll != null)
		{
			v2Coll.Remove(++index);
			return;
		}
		if (index != 0)
		{
			throw new NotV1SupportedException("There can be only a single action and it cannot be removed.");
		}
		Add(new ExecAction());
	}

	public override string ToString()
	{
		if (Count == 1)
		{
			return this[0].ToString();
		}
		if (Count > 1)
		{
			return Resources.MultipleActions;
		}
		return string.Empty;
	}

	public IEnumerator<Action> GetEnumerator()
	{
		if (v2Coll != null)
		{
			return new Enumerator(this);
		}
		return new Enumerator(v1Task);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	XmlSchema IXmlSerializable.GetSchema()
	{
		throw new NotImplementedException();
	}

	void IXmlSerializable.ReadXml(XmlReader reader)
	{
		reader.ReadStartElement("Actions", "http://schemas.microsoft.com/windows/2004/02/mit/task");
		while (reader.MoveToContent() == XmlNodeType.Element)
		{
			Action action = null;
			string localName;
			if ((localName = reader.LocalName) != null && localName == "Exec")
			{
				action = AddNew(TaskActionType.Execute);
			}
			else
			{
				reader.Skip();
			}
			if (action != null)
			{
				XmlSerializationHelper.ReadObject(reader, action);
			}
		}
		reader.ReadEndElement();
	}

	void IXmlSerializable.WriteXml(XmlWriter writer)
	{
		if (Count > 0)
		{
			XmlSerializationHelper.WriteObject(writer, this[0] as ExecAction);
		}
	}
}
