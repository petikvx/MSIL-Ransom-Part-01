using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Complex.NTFSDirect;

public class Enumerator : IEnumerable<string>, IEnumerable
{
	private Dictionary<ulong, FileEntry> _files;

	private Dictionary<ulong, FileEntry> _folders;

	private readonly string _volume;

	public int Count
	{
		get
		{
			Init();
			return _files.Values.Count;
		}
	}

	public Enumerator(string volume)
	{
		_volume = volume;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public IEnumerator<string> GetEnumerator()
	{
		Init();
		List<string> path = new List<string>();
		foreach (FileEntry f in _files.Values)
		{
			path.Clear();
			FileEntry p = f;
			int dp = -1;
			int num2;
			do
			{
				if (p.ParentFrn != 0L)
				{
					path.Add(p.Name);
				}
				p = (_files.ContainsKey(p.ParentFrn) ? _files[p.ParentFrn] : ((!_folders.ContainsKey(p.ParentFrn)) ? null : _folders[p.ParentFrn]));
				if (p != null)
				{
					int num;
					dp = (num = dp + 1);
					num2 = ((num < 1000) ? 1 : 0);
				}
				else
				{
					num2 = 0;
				}
			}
			while (num2 != 0);
			if (path.Count != 0)
			{
				path.Reverse();
				yield return _volume + '\\' + Path.Combine(path.ToArray());
			}
		}
	}

	private void Init()
	{
		if (_files == null)
		{
			Volume volume = new Volume();
			volume.EnumerateVolume(_volume, null, out _files, out _folders);
		}
	}
}
