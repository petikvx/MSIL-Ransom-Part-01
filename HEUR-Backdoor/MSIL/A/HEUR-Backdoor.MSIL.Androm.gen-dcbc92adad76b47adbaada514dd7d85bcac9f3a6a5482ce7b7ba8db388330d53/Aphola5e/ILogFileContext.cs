namespace Aphola5e;

public interface ILogFileContext
{
	string FilePath { get; set; }

	int StartLineNumber { get; set; }

	int StartColumnNumber { get; set; }

	int EndLineNumber { get; set; }

	int EndColumnNumber { get; set; }
}
