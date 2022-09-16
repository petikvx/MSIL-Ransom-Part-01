using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

namespace pal.EventLog;

public class CsvEventLogRecord : IEventLogRecord
{
	private const int COMPUTER_NAME = 0;

	private const string DATETIME_MATCHER = "(?<year>\\d{4})(?<month>\\d{2})(?<day>\\d{2})(?<hour>\\d{2})(?<minute>\\d{2})(?<second>\\d{2})\\.(?<millisecond>\\d*)";

	private const int EVENT_ID = 7;

	private const int EVENT_LOG_TYPE = 3;

	private const int GENERATED_TIME = 10;

	private const int MESSAGE = 8;

	private const int SOURCE = 6;

	private const int USER = 4;

	private static readonly Regex _dateTimeMatcher = new Regex("(?<year>\\d{4})(?<month>\\d{2})(?<day>\\d{2})(?<hour>\\d{2})(?<minute>\\d{2})(?<second>\\d{2})\\.(?<millisecond>\\d*)", RegexOptions.Compiled);

	private ushort _category;

	private string _computer;

	private IEnumerable<IEventLogRecord> _containingFile;

	private int _eventId;

	private DateTime _generatedTime;

	private string _message;

	private string _source;

	private EventLogEntryType _type;

	private string _user;

	public EventLogEntryType Type => _type;

	public DateTime GeneratedTime => _generatedTime;

	public string Source => _source;

	public ushort Category => _category;

	public int EventId => _eventId;

	public string User => _user;

	public string Computer => _computer;

	public string Message => _message;

	public IEnumerable<IEventLogRecord> ContainingFile
	{
		get
		{
			return _containingFile;
		}
		set
		{
			_containingFile = value;
		}
	}

	public bool Matches(LogRecordSearchCriteria searchCriteria)
	{
		if (_source.IndexOf(searchCriteria.Source) != -1 || _message.IndexOf(searchCriteria.Message) != -1)
		{
			return true;
		}
		return false;
	}

	public static CsvEventLogRecord Fetch(string csvLine)
	{
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		List<string> list = new List<string>();
		string[] array = csvLine.Split(new char[1] { ',' });
		for (int i = 0; i < array.Length; i++)
		{
			StringBuilder stringBuilder = new StringBuilder(array[i]);
			if (array[i].StartsWith("\"") && !array[i].EndsWith("\""))
			{
				do
				{
					i++;
					stringBuilder.Append(array[i]);
				}
				while (!array[i].Trim().EndsWith("\""));
			}
			list.Add(stringBuilder.ToString());
		}
		for (int j = 0; j < list.Count; j++)
		{
			list[j] = list[j].Replace("<NL>", "\n");
		}
		CsvEventLogRecord csvEventLogRecord = new CsvEventLogRecord();
		csvEventLogRecord._computer = list[0];
		csvEventLogRecord._type = getEventLogEntryType(list[3]);
		csvEventLogRecord._user = list[4];
		csvEventLogRecord._source = list[6];
		csvEventLogRecord._eventId = int.Parse(list[7]);
		csvEventLogRecord._message = list[8];
		csvEventLogRecord._generatedTime = parseDateTime(list[10]);
		return csvEventLogRecord;
	}

	private static DateTime parseDateTime(string dateTimeString)
	{
		Match match = _dateTimeMatcher.Match(dateTimeString);
		int year = int.Parse(match.Groups["year"].Value);
		int month = int.Parse(match.Groups["month"].Value);
		int day = int.Parse(match.Groups["day"].Value);
		int hour = int.Parse(match.Groups["hour"].Value);
		int minute = int.Parse(match.Groups["minute"].Value);
		int second = int.Parse(match.Groups["second"].Value);
		int millisecond = int.Parse(match.Groups["millisecond"].Value);
		return new DateTime(year, month, day, hour, minute, second, millisecond);
	}

	private static EventLogEntryType getEventLogEntryType(string entryAsString)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		if (entryAsString.ToLower().Contains("audit"))
		{
			if (entryAsString.ToLower().Contains("success"))
			{
				return (EventLogEntryType)8;
			}
			if (entryAsString.ToLower().Contains("failure"))
			{
				return (EventLogEntryType)16;
			}
		}
		return (EventLogEntryType)Enum.Parse(typeof(EventLogEntryType), entryAsString, ignoreCase: true);
	}
}
