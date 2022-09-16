using System;
using System.Collections;
using System.Collections.Generic;

namespace dfb44QxstTvciGRseP;

public abstract class pa5jJ0nwqAWb49sMSj : IEnumerable<oPMer26JhO73WAJG4a>, UIY8G1l7BptgyjtgQK, IDisposable, IEnumerable
{
	protected readonly string lfvXq1OVn;

	protected List<oPMer26JhO73WAJG4a> BhG9lk2Tw;

	internal static pa5jJ0nwqAWb49sMSj L7b2rPlMfiE9nca5Uo;

	public int RecordCount => BhG9lk2Tw.Count;

	public oPMer26JhO73WAJG4a this[int int_0] => BhG9lk2Tw[int_0];

	public pa5jJ0nwqAWb49sMSj(string string_0)
	{
		GRgbqpcvG2cupxT0496.SF54tCZzYSfdV();
		BhG9lk2Tw = new List<oPMer26JhO73WAJG4a>();
		base._002Ector();
		lfvXq1OVn = string_0;
	}

	IEnumerator<oPMer26JhO73WAJG4a> IEnumerable<oPMer26JhO73WAJG4a>.GetEnumerator()
	{
		int num2 = default(int);
		int i = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num = 1;
			if (!_003CSystem_002DCollections_002DGeneric_002DIEnumerable_003Cpal_002DEventLog_002DIEventLogRecord_003E_002DGetEnumerator_003Ed__7.QP1sadseF5bt6WnLuYc())
			{
				num = num2;
			}
			switch (num)
			{
			case 1:
				i = 0;
				goto IL_0062;
			case 2:
				{
					if (!flag)
					{
						yield break;
					}
					yield return this[i];
					i++;
					goto IL_0062;
				}
				IL_0062:
				flag = i < RecordCount;
				goto case 2;
			}
		}
	}

	public IEnumerator GetEnumerator()
	{
		return ((IEnumerable<oPMer26JhO73WAJG4a>)this).GetEnumerator();
	}

	public abstract void Parse();

	public ArrayList Find(bleFS5jEcfDKItM0rC bleFS5jEcfDKItM0rC_0)
	{
		ArrayList arrayList = new ArrayList();
		using (List<oPMer26JhO73WAJG4a>.Enumerator enumerator = BhG9lk2Tw.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				oPMer26JhO73WAJG4a current = enumerator.Current;
				if (current.zf4FAiJxZP(bleFS5jEcfDKItM0rC_0))
				{
					arrayList.Add(current);
				}
			}
			int num = 0;
			if (!csfxtobqBGH5Q02xbu())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		return arrayList;
	}

	public abstract void Dispose();

	internal static bool csfxtobqBGH5Q02xbu()
	{
		return L7b2rPlMfiE9nca5Uo == null;
	}

	internal static pa5jJ0nwqAWb49sMSj k5WlE6tq6k6YYrdFtt()
	{
		return L7b2rPlMfiE9nca5Uo;
	}
}
