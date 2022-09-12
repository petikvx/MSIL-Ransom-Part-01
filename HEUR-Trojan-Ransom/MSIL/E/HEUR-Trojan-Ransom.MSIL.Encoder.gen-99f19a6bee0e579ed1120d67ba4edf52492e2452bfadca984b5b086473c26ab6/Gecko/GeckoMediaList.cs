using System;
using System.Collections;
using System.Collections.Generic;

namespace Gecko;

public class GeckoMediaList : IEnumerable<string>, IEnumerable
{
	private nsIDOMMediaList MediaList;

	public int Count => (int)MediaList.GetLengthAttribute();

	public string this[int index]
	{
		get
		{
			if (index < 0 || index >= Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			nsAString nsAString2 = new nsAString();
			MediaList.Item((uint)index, nsAString2);
			return nsAString2.ToString();
		}
	}

	public string MediaText
	{
		get
		{
			return nsString.Get(MediaList.GetMediaTextAttribute);
		}
		set
		{
			nsString.Set(MediaList.SetMediaTextAttribute, value);
		}
	}

	internal GeckoMediaList(nsIDOMMediaList mediaList)
	{
		MediaList = mediaList;
	}

	public void AppendMedium(string medium)
	{
		MediaList.AppendMedium(new nsAString(medium));
	}

	public void DeleteMedium(string medium)
	{
		MediaList.DeleteMedium(new nsAString(medium));
	}

	public override string ToString()
	{
		return MediaText;
	}

	public IEnumerator<string> GetEnumerator()
	{
		int length = Count;
		for (int i = 0; i < length; i++)
		{
			yield return this[i];
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		using IEnumerator<string> enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			yield return enumerator.Current;
		}
	}
}
