using System.Collections.Generic;

namespace NuGet.Common;

public interface IRestoreLogMessage : INuGetLogMessage, ILogMessage, ILogFileContext
{
	string LibraryId { get; set; }

	IReadOnlyList<string> TargetGraphs { get; set; }

	bool ShouldDisplay { get; set; }
}
