using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace pal.EventLog;

public class BinaryEventLogRecord : IEventLogRecord
{
	protected string _computerName;

	protected IEnumerable<IEventLogRecord> _containingFile;

	protected byte[] _data;

	protected string _message;

	protected Metadata _metadata;

	protected string _sourceName;

	protected byte[] _userSid;

	public EventLogEntryType Type => (EventLogEntryType)Enum.Parse(typeof(EventLogEntryType), _metadata.EventType.ToString());

	public DateTime GeneratedTime => new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(_metadata.TimeGenerated);

	public string Source => _sourceName;

	public ushort Category => _metadata.EventCategory;

	public int EventId => (int)_metadata.EventID;

	public string User => (_userSid.Length != 0) ? userSidHexString() : "N/A";

	public string Computer => _computerName;

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

	public string Message => _message;

	public static IEventLogRecord NULL => new BinaryEventLogRecord();

	public static BinaryEventLogRecord Fetch(BinaryReader reader)
	{
		uint count = reader.ReadUInt32();
		reader.BaseStream.Seek(-4L, SeekOrigin.Current);
		byte[] array = reader.ReadBytes((int)count);
		int num = 0;
		BinaryEventLogRecord binaryEventLogRecord = new BinaryEventLogRecord();
		binaryEventLogRecord._metadata = Metadata.Fetch(array);
		num = 0 + Globals.MetadataSize;
		binaryEventLogRecord._sourceName = extractString(array, num);
		num += binaryEventLogRecord._sourceName.Length * Globals.UnicodeCharSize + Globals.NullCharSize;
		binaryEventLogRecord._computerName = extractString(array, num);
		num += binaryEventLogRecord._computerName.Length * Globals.UnicodeCharSize + Globals.NullCharSize;
		binaryEventLogRecord._userSid = new byte[binaryEventLogRecord._metadata.UserSidLength];
		Array.Copy(array, num, binaryEventLogRecord._userSid, 0L, binaryEventLogRecord._metadata.UserSidLength);
		num += (int)binaryEventLogRecord._metadata.UserSidLength;
		binaryEventLogRecord._message = Encoding.Unicode.GetString(array, num, (int)(binaryEventLogRecord._metadata.DataOffset - binaryEventLogRecord._metadata.StringOffset));
		binaryEventLogRecord._data = new byte[binaryEventLogRecord._metadata.DataLength];
		Array.Copy(array, binaryEventLogRecord._data, binaryEventLogRecord._metadata.DataLength);
		return binaryEventLogRecord;
	}

	public static bool CanHaveALogRecord(BinaryReader reader)
	{
		return !endOfRecords(reader);
	}

	public bool Matches(LogRecordSearchCriteria searchCriteria)
	{
		if (_sourceName.IndexOf(searchCriteria.Source) != -1 || _message.IndexOf(searchCriteria.Message) != -1)
		{
			return true;
		}
		return false;
	}

	private string userSidHexString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		byte[] userSid = _userSid;
		foreach (byte b in userSid)
		{
			stringBuilder.AppendFormat("{0:X}", b);
		}
		return "0X" + stringBuilder;
	}

	public override string ToString()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		return $"{Type} ~~ {Source} ~~ {Category} ~~ {EventId} ~~ {Computer} ~~ {User} ~~ {Message}";
	}

	private static string extractString(byte[] recordBytes, int startIndex)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = startIndex; i < recordBytes.Length; i += 2)
		{
			char c = Convert.ToChar(Encoding.Unicode.GetString(recordBytes, i, 2));
			if (c == '\0')
			{
				break;
			}
			stringBuilder.Append(c);
		}
		return stringBuilder.ToString();
	}

	private static bool endOfRecords(BinaryReader reader)
	{
		return reader.BaseStream.Length - reader.BaseStream.Position <= Globals.FooterSize;
	}
}
