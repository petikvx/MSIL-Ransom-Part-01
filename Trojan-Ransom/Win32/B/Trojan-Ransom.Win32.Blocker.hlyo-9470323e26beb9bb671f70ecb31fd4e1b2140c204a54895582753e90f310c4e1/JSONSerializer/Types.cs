using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace JSONSerializer;

[StandardModule]
public sealed class Types
{
	public class JSONObject : ICollection<JSONPair>, IDisposable
	{
		private List<JSONPair> list;

		private int id;

		private bool disposedValue;

		public object this[string name]
		{
			get
			{
				foreach (JSONPair item in list)
				{
					if (Operators.CompareString(item.Name, name, false) == 0)
					{
						return item.Value;
					}
				}
				return null;
			}
			set
			{
				Add(name, RuntimeHelpers.GetObjectValue(value));
			}
		}

		public int Count => list.Count;

		private bool IsReadOnly => false;

		public JSONObject()
		{
			list = new List<JSONPair>();
			id = 0;
		}

		public void Add(JSONPair item)
		{
			foreach (JSONPair item2 in list)
			{
				if (Operators.CompareString(item2.Name, item.Name, false) == 0)
				{
					Remove(item2.Name);
					break;
				}
			}
			list.Add(item);
		}

		public void Add(string name, object value)
		{
			Add(new JSONPair(name, RuntimeHelpers.GetObjectValue(value)));
		}

		public void Add(object value)
		{
			list.Add(new JSONPair(id.ToString(), RuntimeHelpers.GetObjectValue(value)));
			checked
			{
				id++;
			}
		}

		public bool Remove(JSONPair item)
		{
			return list.Remove(item);
		}

		public bool Remove(string name, object value)
		{
			return list.Remove(new JSONPair(name, RuntimeHelpers.GetObjectValue(value)));
		}

		public bool Remove(string name)
		{
			foreach (JSONPair item in list)
			{
				if (Operators.CompareString(item.Name, name, false) == 0)
				{
					return list.Remove(item);
				}
			}
			return false;
		}

		public bool Remove(object value)
		{
			foreach (JSONPair item in list)
			{
				if (item.Value == value)
				{
					return list.Remove(item);
				}
			}
			return false;
		}

		public void Clear()
		{
			list.Clear();
		}

		public bool Contains(JSONPair item)
		{
			return list.Contains(item);
		}

		public bool ContainsName(string name)
		{
			foreach (JSONPair item in list)
			{
				if (Operators.CompareString(item.Name, name, false) == 0)
				{
					return true;
				}
			}
			return false;
		}

		public bool ContainsValue(object value)
		{
			foreach (JSONPair item in list)
			{
				if (item.Value == value)
				{
					return true;
				}
			}
			return false;
		}

		public void CopyTo(JSONPair[] array, int arrayIndex)
		{
			list.CopyTo(array, arrayIndex);
		}

		public IEnumerator<JSONPair> GetEnumerator()
		{
			return list.GetEnumerator();
		}

		private IEnumerator GetEnumerator1()
		{
			return GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in GetEnumerator1
			return this.GetEnumerator1();
		}

		public void Dispose()
		{
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (!disposedValue)
			{
				if (!disposing)
				{
				}
				list = null;
			}
			disposedValue = true;
		}

		protected override void Finalize()
		{
			Dispose(disposing: false);
			base.Finalize();
		}
	}

	public class JSONArray : List<object>
	{
	}

	public class JSONPair
	{
		public string Name;

		public object Value;

		public JSONPair()
		{
		}

		public JSONPair(string Name, object Value)
		{
			this.Name = Name;
			this.Value = RuntimeHelpers.GetObjectValue(Value);
		}
	}
}
