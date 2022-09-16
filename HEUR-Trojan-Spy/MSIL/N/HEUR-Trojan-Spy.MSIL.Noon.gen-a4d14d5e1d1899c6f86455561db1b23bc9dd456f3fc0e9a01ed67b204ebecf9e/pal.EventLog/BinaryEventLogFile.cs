using System.IO;

namespace pal.EventLog;

public class BinaryEventLogFile : AbstractEventLogFile
{
	private Footer _footer;

	private Header _header;

	private BinaryReader _logReader;

	public BinaryEventLogFile(string fileName)
		: base(fileName)
	{
	}

	public override void Parse()
	{
		FileStream fileStream = new FileStream(_fileName, FileMode.Open, FileAccess.Read);
		_logReader = new BinaryReader(fileStream);
		_header = Header.Fetch(_logReader);
		_header.Verify();
		while (BinaryEventLogRecord.CanHaveALogRecord(_logReader))
		{
			BinaryEventLogRecord binaryEventLogRecord = BinaryEventLogRecord.Fetch(_logReader);
			binaryEventLogRecord.ContainingFile = this;
			_records.Add(binaryEventLogRecord);
		}
		_footer = Footer.Fetch(_logReader);
		_footer.Verify();
		fileStream.Close();
		_logReader.Close();
	}

	public override string ToString()
	{
		return Path.GetFileName(_fileName);
	}

	public override void Dispose()
	{
		_logReader = null;
	}
}
