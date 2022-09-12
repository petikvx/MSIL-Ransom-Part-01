using System;

namespace Gecko;

public class GeckoHistoryEntry
{
	private Uri _Url;

	private string _Title;

	private bool _IsSubFrame;

	public virtual Uri Url => _Url;

	public virtual string Title => _Title;

	public virtual bool IsSubFrame => _IsSubFrame;

	internal GeckoHistoryEntry()
	{
	}

	public GeckoHistoryEntry(Uri url, string title, bool isSubFrame)
	{
		_Url = url;
		_Title = title;
		_IsSubFrame = isSubFrame;
	}
}
