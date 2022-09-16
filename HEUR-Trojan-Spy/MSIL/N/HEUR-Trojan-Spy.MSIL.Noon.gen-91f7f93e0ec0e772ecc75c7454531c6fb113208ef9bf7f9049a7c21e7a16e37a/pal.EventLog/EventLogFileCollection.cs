using System;
using System.Collections;
using System.Collections.Generic;

namespace pal.EventLog;

public class EventLogFileCollection : IEnumerable<IEventLogRecord>, IEnumerable, IDisposable
{
	private List<IEventLogFile> _eventLogFiles = new List<IEventLogFile>();

	IEnumerator<IEventLogRecord> IEnumerable<IEventLogRecord>.GetEnumerator()
	{
		foreach (IEventLogFile file in _eventLogFiles)
		{
			foreach (IEventLogRecord item in file)
			{
				yield return item;
			}
		}
	}

	public IEnumerator GetEnumerator()
	{
		return ((IEnumerable<IEventLogRecord>)this).GetEnumerator();
	}

	public void Add(IEventLogFile file)
	{
		_eventLogFiles.Add(file);
	}

	public void Dispose()
	{
		foreach (IEventLogFile eventLogFile in _eventLogFiles)
		{
			eventLogFile.Dispose();
		}
	}
}
