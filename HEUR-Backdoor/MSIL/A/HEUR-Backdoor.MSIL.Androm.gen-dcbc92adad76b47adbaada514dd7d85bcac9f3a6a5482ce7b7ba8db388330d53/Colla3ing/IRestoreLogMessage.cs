using System.Collections.Generic;
using Aphola5e;
using Str4ami4st;
using ns4;

namespace Colla3ing;

public interface IRestoreLogMessage : ILogFileContext, ILogMessage, INuGetLogMessage
{
	string LibraryId { get; set; }

	IReadOnlyList<string> TargetGraphs { get; set; }

	bool ShouldDisplay { get; set; }
}
