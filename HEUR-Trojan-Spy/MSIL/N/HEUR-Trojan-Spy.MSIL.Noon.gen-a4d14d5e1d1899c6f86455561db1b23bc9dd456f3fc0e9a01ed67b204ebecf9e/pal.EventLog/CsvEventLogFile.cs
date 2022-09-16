using System.IO;

namespace pal.EventLog;

public class CsvEventLogFile : AbstractEventLogFile
{
	private readonly StreamReader _fileReader;

	public CsvEventLogFile(string fileName)
		: base(fileName)
	{
		_fileReader = new StreamReader(_fileName);
	}

	public override void Parse()
	{
		while (!_fileReader.EndOfStream)
		{
			string text = _fileReader.ReadLine();
			if (!isComment(text))
			{
				CsvEventLogRecord csvEventLogRecord = CsvEventLogRecord.Fetch(text);
				csvEventLogRecord.ContainingFile = this;
				_records.Add(csvEventLogRecord);
			}
		}
		_fileReader.Close();
	}

	private bool isComment(string line)
	{
		return line.Trim().StartsWith("#");
	}

	public override string ToString()
	{
		return Path.GetFileName(_fileName);
	}

	public override void Dispose()
	{
		_fileReader.Dispose();
	}
}
