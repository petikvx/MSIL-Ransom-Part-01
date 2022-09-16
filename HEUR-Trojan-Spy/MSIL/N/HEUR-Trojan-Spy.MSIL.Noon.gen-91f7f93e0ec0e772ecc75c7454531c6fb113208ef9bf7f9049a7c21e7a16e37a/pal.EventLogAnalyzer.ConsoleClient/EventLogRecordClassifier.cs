using System.Collections.Generic;
using pal.EventLog;
using pal.EventLogAnalyzer.ConsoleClient.FuzzyComparer;

namespace pal.EventLogAnalyzer.ConsoleClient;

public class EventLogRecordClassifier : ILogRecordClassifier<IEventLogRecord>
{
	private readonly List<Aggregate<IEventLogRecord>> _aggregates = new List<Aggregate<IEventLogRecord>>();

	public List<Aggregate<IEventLogRecord>> Aggregates => _aggregates;

	public void Classify(List<IEventLogRecord> records, double toleranceMargin)
	{
		foreach (IEventLogRecord record in records)
		{
			bool flag = false;
			foreach (Aggregate<IEventLogRecord> aggregate2 in _aggregates)
			{
				if (aggregate2.IsAcceptable(record.Message))
				{
					aggregate2.Hold(record);
					flag = true;
				}
			}
			if (!flag)
			{
				Aggregate<IEventLogRecord> aggregate = new Aggregate<IEventLogRecord>(record.Message, toleranceMargin);
				aggregate.Hold(record);
				_aggregates.Add(aggregate);
			}
		}
	}
}
