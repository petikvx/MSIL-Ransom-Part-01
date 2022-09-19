using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.TaskScheduler.V2Interop;

namespace Microsoft.Win32.TaskScheduler;

[ComVisible(false)]
public sealed class TaskPrincipalPrivileges : IList<TaskPrincipalPrivilege>, ICollection<TaskPrincipalPrivilege>, IEnumerable<TaskPrincipalPrivilege>, IEnumerable
{
	public sealed class TaskPrincipalPrivilegesEnumerator : IDisposable, IEnumerator<TaskPrincipalPrivilege>, IEnumerator
	{
		private IPrincipal2 v2Principal2;

		private int cur;

		private TaskPrincipalPrivilege curVal;

		public TaskPrincipalPrivilege Current => curVal;

		object IEnumerator.Current => Current;

		internal TaskPrincipalPrivilegesEnumerator(IPrincipal2 iPrincipal2 = null)
		{
			v2Principal2 = iPrincipal2;
			Reset();
		}

		public void Dispose()
		{
		}

		public bool MoveNext()
		{
			if (v2Principal2 != null && cur < v2Principal2.RequiredPrivilegeCount)
			{
				cur++;
				curVal = (TaskPrincipalPrivilege)Enum.Parse(typeof(TaskPrincipalPrivilege), v2Principal2[cur]);
				return true;
			}
			curVal = (TaskPrincipalPrivilege)0;
			return false;
		}

		public void Reset()
		{
			cur = 0;
			curVal = (TaskPrincipalPrivilege)0;
		}
	}

	private IPrincipal2 v2Principal2;

	public TaskPrincipalPrivilege this[int index]
	{
		get
		{
			if (v2Principal2 == null)
			{
				throw new IndexOutOfRangeException();
			}
			return (TaskPrincipalPrivilege)Enum.Parse(typeof(TaskPrincipalPrivilege), v2Principal2[index + 1]);
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	public int Count
	{
		get
		{
			if (v2Principal2 == null)
			{
				return 0;
			}
			return v2Principal2.RequiredPrivilegeCount;
		}
	}

	public bool IsReadOnly => false;

	internal TaskPrincipalPrivileges(IPrincipal2 iPrincipal2 = null)
	{
		v2Principal2 = iPrincipal2;
	}

	public int IndexOf(TaskPrincipalPrivilege item)
	{
		int num = 0;
		while (true)
		{
			if (num < Count)
			{
				if (item == this[num])
				{
					break;
				}
				num++;
				continue;
			}
			return -1;
		}
		return num;
	}

	public void Insert(int index, TaskPrincipalPrivilege item)
	{
		throw new NotImplementedException();
	}

	public void RemoveAt(int index)
	{
		throw new NotImplementedException();
	}

	public void Add(TaskPrincipalPrivilege item)
	{
		if (v2Principal2 == null)
		{
			throw new NotSupportedPriorToException(TaskCompatibility.V2_1);
		}
		v2Principal2.AddRequiredPrivilege(item.ToString());
	}

	public void Clear()
	{
		throw new NotImplementedException();
	}

	public bool Contains(TaskPrincipalPrivilege item)
	{
		return IndexOf(item) != -1;
	}

	public void CopyTo(TaskPrincipalPrivilege[] array, int arrayIndex)
	{
		IEnumerator<TaskPrincipalPrivilege> enumerator = GetEnumerator();
		for (int i = arrayIndex; i < array.Length; i++)
		{
			if (!enumerator.MoveNext())
			{
				break;
			}
			array[i] = enumerator.Current;
		}
	}

	public bool Remove(TaskPrincipalPrivilege item)
	{
		throw new NotImplementedException();
	}

	public IEnumerator<TaskPrincipalPrivilege> GetEnumerator()
	{
		return new TaskPrincipalPrivilegesEnumerator(v2Principal2);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}
