using System.Collections.Generic;

namespace Examine;

public interface IIndexCriteria
{
	IEnumerable<string> ExcludeNodeTypes { get; }

	IEnumerable<string> IncludeNodeTypes { get; }

	int? ParentNodeId { get; }

	IEnumerable<IIndexField> StandardFields { get; }

	IEnumerable<IIndexField> UserFields { get; }
}
