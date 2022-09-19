using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.TaskScheduler.V2Interop;

namespace Microsoft.Win32.TaskScheduler;

[ComVisible(false)]
public sealed class TaskFolderCollection : IEnumerable<TaskFolder>, IEnumerable
{
	private class TaskFolderEnumerator : IDisposable, IEnumerator<TaskFolder>, IEnumerator
	{
		private TaskFolder[] folders;

		private IEnumerator iEnum;

		public TaskFolder Current => iEnum.Current as TaskFolder;

		object IEnumerator.Current => Current;

		internal TaskFolderEnumerator(TaskFolder[] f)
		{
			folders = f;
			iEnum = f.GetEnumerator();
		}

		public void Dispose()
		{
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

	private TaskFolder parent;

	private ITaskFolderCollection v2FolderList;

	private TaskFolder[] v1FolderList;

	public TaskFolder this[int index]
	{
		get
		{
			if (v2FolderList != null)
			{
				return new TaskFolder(parent.TaskService, v2FolderList[++index]);
			}
			return v1FolderList[index];
		}
	}

	public TaskFolder this[string path]
	{
		get
		{
			if (v2FolderList != null)
			{
				return new TaskFolder(parent.TaskService, v2FolderList[path]);
			}
			if (v1FolderList == null || v1FolderList.Length <= 0 || (!(path == string.Empty) && !(path == "\\")))
			{
				throw new ArgumentException("Path not found");
			}
			return v1FolderList[0];
		}
	}

	public int Count
	{
		get
		{
			if (v2FolderList == null)
			{
				return v1FolderList.Length;
			}
			return v2FolderList.Count;
		}
	}

	internal TaskFolderCollection()
	{
		v1FolderList = new TaskFolder[0];
	}

	internal TaskFolderCollection(TaskFolder v1Folder)
	{
		parent = v1Folder;
		v1FolderList = new TaskFolder[1] { v1Folder };
	}

	internal TaskFolderCollection(TaskFolder folder, ITaskFolderCollection iCollection)
	{
		parent = folder;
		v2FolderList = iCollection;
	}

	public void Dispose()
	{
		if (v1FolderList != null && v1FolderList.Length > 0)
		{
			v1FolderList[0].Dispose();
			v1FolderList[0] = null;
		}
		if (v2FolderList != null)
		{
			Marshal.ReleaseComObject(v2FolderList);
		}
	}

	internal void CopyTo(TaskFolder[] array, int arrayIndex)
	{
		if (arrayIndex < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (array == null)
		{
			throw new ArgumentNullException();
		}
		if (v2FolderList != null)
		{
			if (arrayIndex + Count > array.Length)
			{
				throw new ArgumentException();
			}
			{
				foreach (ITaskFolder v2Folder in v2FolderList)
				{
					array[arrayIndex++] = new TaskFolder(parent.TaskService, v2Folder);
				}
				return;
			}
		}
		if (arrayIndex + v1FolderList.Length > array.Length)
		{
			throw new ArgumentException();
		}
		v1FolderList.CopyTo(array, arrayIndex);
	}

	public IEnumerator<TaskFolder> GetEnumerator()
	{
		TaskFolder[] array = new TaskFolder[Count];
		CopyTo(array, 0);
		return new TaskFolderEnumerator(array);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}
