using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using pal.EventLog;
using pal.EventLogAnalyzer.ConsoleClient.FuzzyComparer;

namespace pal.EventLogAnalyzer.ConsoleClient.Reporting;

internal class HtmlSummaryWriter : AbstractSummaryWriter
{
	public HtmlSummaryWriter(ICollection<Aggregate<IEventLogRecord>> aggregates, FileNameGenerator fileNameGenerator)
		: base(aggregates, fileNameGenerator)
	{
	}

	public override void WriteIn(string folder)
	{
		StreamWriter streamWriter = new StreamWriter(File.Open(folder + "\\Summary.htm", FileMode.Create));
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("<html>");
		stringBuilder.Append("<head>");
		stringBuilder.Append("<style>");
		stringBuilder.Append(".tableStyle {border: none; }").Append(Environment.NewLine);
		stringBuilder.Append(".rowStyle {border:none; }").Append(Environment.NewLine);
		stringBuilder.Append(".cellStyle {border-width: 1px; border-style: solid; }").Append(Environment.NewLine);
		stringBuilder.Append(".headerStyle {border-width: 1px; border-style: solid; }").Append(Environment.NewLine);
		stringBuilder.Append("</style>");
		stringBuilder.Append("</head>");
		stringBuilder.Append("<body>");
		stringBuilder.Append("<h2>Analysis Summary</h2><br>Generated on: ").Append(DateTime.Now);
		stringBuilder.Append("<br>No of groups: ").Append(_aggregates.Count).Append("<br>");
		stringBuilder.Append("<h3>Grouping details</h3>");
		stringBuilder.Append("<table id='summaryTable' class='tableStyle'><tr><th class='headerStyle'>Number of occurences</th><th class='headerStyle'>Message</th><th class='headerStyle'>Details</th></tr>");
		double num = 0.0;
		DateTime dateTime = DateTime.MaxValue;
		DateTime dateTime2 = DateTime.MinValue;
		foreach (Aggregate<IEventLogRecord> aggregate in _aggregates)
		{
			string nextName = _fileNameGenerator.NextName;
			stringBuilder.Append("<tr class='rowStyle'><td class='cellStyle'>").Append(aggregate.Entries.Count).Append("</td><td class='cellStyle'><pre>")
				.Append(aggregate.AggregationCriteria)
				.Append("</pre></td><td class='cellStyle'>")
				.Append("<a href='./")
				.Append(nextName)
				.Append("'>")
				.Append(nextName)
				.Append("</a></td></tr>");
			num += (double)aggregate.Entries.Count;
			foreach (IEventLogRecord entry in aggregate.Entries)
			{
				if (entry.GeneratedTime.CompareTo(dateTime) < 0)
				{
					dateTime = entry.GeneratedTime;
				}
				if (entry.GeneratedTime.CompareTo(dateTime2) > 0)
				{
					dateTime2 = entry.GeneratedTime;
				}
			}
		}
		stringBuilder.Append("</table>");
		stringBuilder.Append("<br><br><b>Total number of records processed:</b> <i>").Append(num).Append("</i><br>");
		stringBuilder.Append("<b>Time range:</b> [From: <i>").Append(dateTime).Append("</i> Till:<i>")
			.Append(dateTime2)
			.Append("</i>]<br>");
		stringBuilder.Append("<br><br>");
		stringBuilder.Append("</body>");
		stringBuilder.Append("</html>");
		streamWriter.Write((object?)stringBuilder);
		streamWriter.Close();
	}
}
