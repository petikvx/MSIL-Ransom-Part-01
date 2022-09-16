using System;
using System.Collections.Generic;
using System.IO;
using pal.EventLog;
using pal.EventLogAnalyzer.ConsoleClient.FuzzyComparer;

namespace pal.EventLogAnalyzer.ConsoleClient.Reporting;

internal class TextSummaryWriter : AbstractSummaryWriter
{
	public TextSummaryWriter(ICollection<Aggregate<IEventLogRecord>> aggregates, FileNameGenerator fileNameGenerator)
		: base(aggregates, fileNameGenerator)
	{
	}

	public override void WriteIn(string folder)
	{
		StreamWriter streamWriter = new StreamWriter(File.Open(folder + "\\Summary.txt", FileMode.Create));
		streamWriter.WriteLine("Analysis summary: {0}", DateTime.Now);
		streamWriter.WriteLine("No of groups: {0}", _aggregates.Count);
		streamWriter.WriteLine();
		streamWriter.WriteLine("Grouping details");
		streamWriter.WriteLine("----------------------------------------------------------------");
		foreach (Aggregate<IEventLogRecord> aggregate in _aggregates)
		{
			streamWriter.WriteLine("Following message occurs {0} times", aggregate.Entries.Count);
			streamWriter.WriteLine();
			streamWriter.WriteLine(aggregate.AggregationCriteria);
			streamWriter.WriteLine("############################################################################");
		}
		streamWriter.Close();
	}
}
