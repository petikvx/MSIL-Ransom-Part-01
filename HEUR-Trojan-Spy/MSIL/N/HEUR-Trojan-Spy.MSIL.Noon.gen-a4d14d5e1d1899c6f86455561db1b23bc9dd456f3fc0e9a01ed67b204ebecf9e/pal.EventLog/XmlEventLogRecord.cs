using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Xml;

namespace pal.EventLog;

public class XmlEventLogRecord : IEventLogRecord
{
	private const string DATETIME_MATCHER = "(?<year>\\d{4})(?<month>\\d{2})(?<day>\\d{2})(?<hour>\\d{2})(?<minute>\\d{2})(?<second>\\d{2})\\.(?<millisecond>\\d*)";

	private const string COMPUTER_XPATH = "Computer";

	private const string EVENT_TYPE_XPATH = "Type";

	private const string USER_XPATH = "User";

	private const string EVENT_SOURCE_XPATH = "Source";

	private const string EVENT_ID_XPATH = "EventId";

	private const string EVENT_MESSAGE_XPATH = "Message";

	private const string GENERATED_TIME_XPATH = "TimeGenerated";

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

	public static XmlEventLogRecord Fetch(XmlNode xmlNode)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		XmlEventLogRecord xmlEventLogRecord = new XmlEventLogRecord();
		xmlEventLogRecord._computer = xmlNode.SelectSingleNode("Computer")!.InnerText;
		xmlEventLogRecord._type = getEventLogEntryType(xmlNode.SelectSingleNode("Type")!.InnerText);
		xmlEventLogRecord._user = xmlNode.SelectSingleNode("User")!.InnerText;
		xmlEventLogRecord._source = xmlNode.SelectSingleNode("Source")!.InnerText;
		xmlEventLogRecord._eventId = int.Parse(xmlNode.SelectSingleNode("EventId")!.InnerText);
		xmlEventLogRecord._message = xmlNode.SelectSingleNode("Message")!.InnerText;
		xmlEventLogRecord._generatedTime = parseDateTime(xmlNode.SelectSingleNode("TimeGenerated")!.InnerText);
		return xmlEventLogRecord;
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
