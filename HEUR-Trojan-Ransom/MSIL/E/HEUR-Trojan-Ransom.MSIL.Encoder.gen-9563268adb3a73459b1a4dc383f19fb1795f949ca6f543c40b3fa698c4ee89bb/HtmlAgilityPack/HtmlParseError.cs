namespace HtmlAgilityPack;

public class HtmlParseError
{
	private HtmlParseErrorCode _code;

	private int _line;

	private int _linePosition;

	private string _reason;

	private string _sourceText;

	private int _streamPosition;

	public HtmlParseErrorCode Code => _code;

	public int Line => _line;

	public int LinePosition => _linePosition;

	public string Reason => _reason;

	public string SourceText => _sourceText;

	public int StreamPosition => _streamPosition;

	internal HtmlParseError(HtmlParseErrorCode code, int line, int linePosition, int streamPosition, string sourceText, string reason)
	{
		_code = code;
		_line = line;
		_linePosition = linePosition;
		_streamPosition = streamPosition;
		_sourceText = sourceText;
		_reason = reason;
	}
}
