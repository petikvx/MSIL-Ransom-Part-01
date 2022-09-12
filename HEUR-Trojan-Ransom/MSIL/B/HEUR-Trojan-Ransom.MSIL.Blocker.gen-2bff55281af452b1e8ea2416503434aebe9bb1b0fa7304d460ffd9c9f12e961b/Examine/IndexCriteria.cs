using System.Collections.Generic;
using System.Linq;

namespace Examine;

public class IndexCriteria : IIndexCriteria
{
	public IEnumerable<IIndexField> StandardFields { get; internal set; }

	public IEnumerable<IIndexField> UserFields { get; internal set; }

	public IEnumerable<string> IncludeNodeTypes { get; internal set; }

	public IEnumerable<string> ExcludeNodeTypes { get; internal set; }

	public int? ParentNodeId { get; internal set; }

	public IndexCriteria(IEnumerable<IIndexField> standardFields, IEnumerable<IIndexField> userFields, IEnumerable<string> includeNodeTypes, IEnumerable<string> excludeNodeTypes, int? parentNodeId)
	{
		UserFields = userFields.ToList();
		StandardFields = standardFields.ToList();
		IncludeNodeTypes = includeNodeTypes;
		ExcludeNodeTypes = excludeNodeTypes;
		ParentNodeId = parentNodeId;
	}
}
