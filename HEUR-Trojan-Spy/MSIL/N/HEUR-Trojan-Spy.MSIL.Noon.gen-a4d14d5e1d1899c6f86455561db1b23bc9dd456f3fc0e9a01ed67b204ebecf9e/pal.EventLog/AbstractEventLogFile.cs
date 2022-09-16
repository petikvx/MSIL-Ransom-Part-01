using System;
using System.Collections;
using System.Collections.Generic;

namespace pal.EventLog;

public abstract class AbstractEventLogFile : IEnumerable<IEventLogRecord>, IEventLogFile, IEnumerable, IDisposable
{
	protected readonly string _fileName;

	protected List<IEventLogRecord> _records = new List<IEventLogRecord>();

	public int RecordCount => _records.Count;

	public IEventLogRecord this[int recordNo] => _records[recordNo];

	public AbstractEventLogFile(string fileName)
	{
		_fileName = fileName;
	}

	IEnumerator<IEventLogRecord> IEnumerable<IEventLogRecord>.GetEnumerator()
	{
		for (int i = 0; i < RecordCount; i++)
		{
			yield return this[i];
		}
	}

	public IEnumerator GetEnumerator()
	{
		return ((IEnumerable<IEventLogRecord>)this).GetEnumerator();
	}

	public abstract void Parse();

	public ArrayList Find(LogRecordSearchCriteria searchCriteria)
	{
		ArrayList arrayList = new ArrayList();
		foreach (IEventLogRecord record in _records)
		{
			if (record.Matches(searchCriteria))
			{
				arrayList.Add(record);
			}
		}
		return arrayList;
	}

	public abstract void Dispose();
}
