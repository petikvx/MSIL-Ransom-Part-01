using System.Collections.Generic;

namespace Examine.LuceneEngine;

public interface ISimpleDataService
{
	IEnumerable<SimpleDataSet> GetAllData(string indexType);
}
