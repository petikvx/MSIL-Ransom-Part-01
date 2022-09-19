using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Microsoft.Win32.TaskScheduler.V1Interop;
using Microsoft.Win32.TaskScheduler.V2Interop;

namespace Microsoft.Win32.TaskScheduler;

[ComVisible(false)]
public sealed class TaskCollection : IDisposable, IEnumerable<Task>, IEnumerable
{
	internal class V1TaskEnumerator : IDisposable, IEnumerator<Task>, IEnumerator
	{
		private TaskService svc;

		private IEnumWorkItems wienum;

		private ITaskScheduler m_ts;

		private Guid ITaskGuid = Marshal.GenerateGuidForType(typeof(ITask));

		private string curItem;

		private Regex filter;

		public Task Current => new Task(svc, ICurrent);

		internal ITask ICurrent => m_ts.Activate(curItem, ref ITaskGuid);

		object IEnumerator.Current => Current;

		internal string[] TaskNames
		{
			get
			{
				List<string> list = new List<string>();
				IntPtr Names = IntPtr.Zero;
				bool flag = false;
				do
				{
					uint Fetched = 0u;
					try
					{
						wienum.Next(50u, out Names, out Fetched);
						if (Fetched == 0)
						{
							break;
						}
						IntPtr intPtr = Names;
						for (uint num = 0u; num < Fetched; num++)
						{
							using (CoTaskMemString coTaskMemString = new CoTaskMemString(Marshal.ReadIntPtr(intPtr)))
							{
								string text = coTaskMemString.ToString();
								if (text.EndsWith(".job", StringComparison.InvariantCultureIgnoreCase))
								{
									text = text.Remove(text.Length - 4);
								}
								if (filter == null || filter.IsMatch(text))
								{
									list.Add(text);
								}
							}
							intPtr = (IntPtr)((long)intPtr + Marshal.SizeOf((object)(nint)intPtr));
						}
						continue;
					}
					catch
					{
						continue;
					}
					finally
					{
						Marshal.FreeCoTaskMem(Names);
						Names = IntPtr.Zero;
					}
				}
				while (!flag);
				Reset();
				return list.ToArray();
			}
		}

		internal V1TaskEnumerator(TaskService svc, Regex filter = null)
		{
			this.svc = svc;
			this.filter = filter;
			m_ts = svc.v1TaskScheduler;
			wienum = m_ts.Enum();
			Reset();
		}

		public void Dispose()
		{
			if (wienum != null)
			{
				Marshal.ReleaseComObject(wienum);
			}
			m_ts = null;
		}

		public bool MoveNext()
		{
			IntPtr Names = IntPtr.Zero;
			bool flag = false;
			do
			{
				curItem = null;
				uint Fetched = 0u;
				try
				{
					wienum.Next(1u, out Names, out Fetched);
					if (Fetched != 1)
					{
						break;
					}
					using (CoTaskMemString coTaskMemString = new CoTaskMemString(Marshal.ReadIntPtr(Names)))
					{
						curItem = coTaskMemString.ToString();
					}
					if (curItem.EndsWith(".job", StringComparison.InvariantCultureIgnoreCase))
					{
						curItem = curItem.Remove(curItem.Length - 4);
					}
					goto IL_0094;
				}
				catch
				{
					goto IL_0094;
				}
				finally
				{
					Marshal.FreeCoTaskMem(Names);
					Names = IntPtr.Zero;
				}
				IL_0094:
				if (filter == null || filter.IsMatch(curItem))
				{
					try
					{
						_ = ICurrent;
						flag = true;
					}
					catch
					{
						flag = false;
					}
				}
			}
			while (!flag);
			return curItem != null;
		}

		public void Reset()
		{
			curItem = null;
			wienum.Reset();
		}
	}

	internal class V2TaskEnumerator : IDisposable, IEnumerator<Task>, IEnumerator
	{
		private IEnumerator iEnum;

		private TaskFolder fld;

		private Regex filter;

		public Task Current => new Task(fld.TaskService, (IRegisteredTask)iEnum.Current);

		object IEnumerator.Current => Current;

		internal V2TaskEnumerator(TaskFolder folder, IRegisteredTaskCollection iTaskColl, Regex filter = null)
		{
			fld = folder;
			iEnum = iTaskColl.GetEnumerator();
			this.filter = filter;
		}

		public void Dispose()
		{
			iEnum = null;
		}

		public bool MoveNext()
		{
			bool flag;
			if (!(flag = iEnum.MoveNext()))
			{
				return false;
			}
			while (flag && filter != null && !filter.IsMatch(Current.Name))
			{
				flag = iEnum.MoveNext();
			}
			return flag;
		}

		public void Reset()
		{
			iEnum.Reset();
		}
	}

	private TaskService svc;

	private Regex filter;

	private TaskFolder fld;

	private ITaskScheduler v1TS;

	private IRegisteredTaskCollection v2Coll;

	public int Count
	{
		get
		{
			int num = 0;
			if (v2Coll != null)
			{
				if (filter == null)
				{
					return v2Coll.Count;
				}
				V2TaskEnumerator v2TaskEnumerator = new V2TaskEnumerator(fld, v2Coll, filter);
				while (v2TaskEnumerator.MoveNext())
				{
					num++;
				}
				return num;
			}
			V1TaskEnumerator v1TaskEnumerator = new V1TaskEnumerator(svc, filter);
			return v1TaskEnumerator.TaskNames.Length;
		}
	}

	private Regex Filter
	{
		get
		{
			return filter;
		}
		set
		{
			string text = ((value == null) ? string.Empty : value.ToString().TrimStart(new char[1] { '^' }).TrimEnd(new char[1] { '$' }));
			if (!(text == string.Empty) && !(text == "*"))
			{
				if (value.ToString().TrimEnd(new char[1] { '$' }).EndsWith("\\.job", StringComparison.InvariantCultureIgnoreCase))
				{
					filter = new Regex(value.ToString().Replace("\\.job", ""));
				}
				else
				{
					filter = value;
				}
			}
			else
			{
				filter = null;
			}
		}
	}

	public Task this[int index]
	{
		get
		{
			int num = 0;
			if (v2Coll != null)
			{
				if (filter == null)
				{
					return new Task(svc, v2Coll[++index]);
				}
				V2TaskEnumerator v2TaskEnumerator = new V2TaskEnumerator(fld, v2Coll, filter);
				while (v2TaskEnumerator.MoveNext())
				{
					if (num++ == index)
					{
						return v2TaskEnumerator.Current;
					}
				}
			}
			else
			{
				V1TaskEnumerator v1TaskEnumerator = new V1TaskEnumerator(svc, filter);
				while (v1TaskEnumerator.MoveNext())
				{
					if (num++ == index)
					{
						return v1TaskEnumerator.Current;
					}
				}
			}
			throw new ArgumentOutOfRangeException();
		}
	}

	public Task this[string name]
	{
		get
		{
			if (v2Coll != null)
			{
				return new Task(svc, v2Coll[name]);
			}
			Task task = svc.GetTask(name);
			if (task == null)
			{
				throw new ArgumentOutOfRangeException();
			}
			return task;
		}
	}

	internal TaskCollection(TaskService svc, Regex filter = null)
	{
		this.svc = svc;
		Filter = filter;
		v1TS = svc.v1TaskScheduler;
	}

	internal TaskCollection(TaskFolder folder, IRegisteredTaskCollection iTaskColl, Regex filter = null)
	{
		svc = folder.TaskService;
		Filter = filter;
		fld = folder;
		v2Coll = iTaskColl;
	}

	public void Dispose()
	{
		v1TS = null;
		if (v2Coll != null)
		{
			Marshal.ReleaseComObject(v2Coll);
		}
	}

	public IEnumerator<Task> GetEnumerator()
	{
		if (v1TS != null)
		{
			return new V1TaskEnumerator(svc, filter);
		}
		return new V2TaskEnumerator(fld, v2Coll, filter);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}
