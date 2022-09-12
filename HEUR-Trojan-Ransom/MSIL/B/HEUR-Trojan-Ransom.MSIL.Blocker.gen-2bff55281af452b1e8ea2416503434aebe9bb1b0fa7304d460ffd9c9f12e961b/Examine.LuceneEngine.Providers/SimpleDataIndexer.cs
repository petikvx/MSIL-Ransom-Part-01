using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Security;
using Lucene.Net.Analysis;
using Lucene.Net.Store;

namespace Examine.LuceneEngine.Providers;

public class SimpleDataIndexer : LuceneIndexer
{
	public ISimpleDataService DataService { get; set; }

	public IEnumerable<string> IndexTypes { get; set; }

	public SimpleDataIndexer()
	{
	}

	[SecuritySafeCritical]
	public SimpleDataIndexer(IIndexCriteria indexerData, DirectoryInfo workingFolder, Analyzer analyzer, ISimpleDataService dataService, IEnumerable<string> indexTypes, bool async)
		: base(indexerData, workingFolder, analyzer, async)
	{
		DataService = dataService;
		IndexTypes = indexTypes;
	}

	[SecuritySafeCritical]
	public SimpleDataIndexer(IIndexCriteria indexerData, Directory luceneDirectory, Analyzer analyzer, ISimpleDataService dataService, IEnumerable<string> indexTypes, bool async)
		: base(indexerData, luceneDirectory, analyzer, async)
	{
		DataService = dataService;
		IndexTypes = indexTypes;
	}

	protected override void PerformIndexAll(string type)
	{
		AddNodesToIndex(from d in DataService.GetAllData(type)
			select d.RowData.ToExamineXml(d.NodeDefinition.NodeId, d.NodeDefinition.Type), type);
	}

	protected override void PerformIndexRebuild()
	{
		foreach (string indexType in IndexTypes)
		{
			IndexAll(indexType);
		}
	}

	[SecuritySafeCritical]
	public override void Initialize(string name, NameValueCollection config)
	{
		base.Initialize(name, config);
		if (config["indexTypes"] != null && !string.IsNullOrEmpty(config["indexTypes"]))
		{
			IndexTypes = config["indexTypes"]!.Split(new char[1] { (char)Convert.ToInt32(43.99114869070959 - Math.Sin(22.0)) });
			if (config["dataService"] == null || string.IsNullOrEmpty(config["dataService"]))
			{
				throw new ArgumentNullException("The dataService property must be specified for the SimpleDataIndexer provider");
			}
			Type type = Type.GetType(config["dataService"]);
			DataService = (ISimpleDataService)Activator.CreateInstance(type);
			return;
		}
		throw new ArgumentNullException("The indexTypes property must be specified for the SimpleDataIndexer provider");
	}
}
