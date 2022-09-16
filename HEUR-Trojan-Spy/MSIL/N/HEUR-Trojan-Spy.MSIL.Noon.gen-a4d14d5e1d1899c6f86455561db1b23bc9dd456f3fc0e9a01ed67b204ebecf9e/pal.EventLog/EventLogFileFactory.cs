using System;

namespace pal.EventLog;

public class EventLogFileFactory
{
	private readonly string _fileName;

	public IEventLogFile EventLogFile
	{
		get
		{
			if (_fileName.ToLower().EndsWith(".evt"))
			{
				return new BinaryEventLogFile(_fileName);
			}
			if (_fileName.ToLower().EndsWith(".csv"))
			{
				return new CsvEventLogFile(_fileName);
			}
			if (_fileName.ToLower().EndsWith(".xml"))
			{
				return new XmlEventLogFile(_fileName);
			}
			throw new Exception("Not smart enuf yet to understand that format :P");
		}
	}

	public EventLogFileFactory(string fileName)
	{
		_fileName = fileName;
	}
}
