using System;
using System.IO;
using System.Security;
using System.Web;
using Examine.LuceneEngine.Providers;
using Lucene.Net.Store;

namespace Examine.LuceneEngine.Directories;

public class SyncAspNetCodeGenDirectoryFactory : IDirectoryFactory
{
	[SecuritySafeCritical]
	public Directory CreateDirectory(LuceneIndexer indexer, string luceneIndexFolder)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0025: Expected O, but got Unknown
		DirectoryInfo indexPath = new DirectoryInfo(luceneIndexFolder);
		DirectoryInfo localStorageDirectory = GetLocalStorageDirectory(indexPath);
		return (Directory)(object)new SyncDirectory((Directory)new SimpleFSDirectory(new DirectoryInfo(luceneIndexFolder)), (Directory)new SimpleFSDirectory(localStorageDirectory));
	}

	private DirectoryInfo GetLocalStorageDirectory(DirectoryInfo indexPath)
	{
		string codegenDir = HttpRuntime.get_CodegenDir();
		string[] array = new string[Convert.ToInt32(5.0)];
		array[0] = codegenDir;
		array[1] = "App_Data";
		array[Convert.ToInt32(1.0 + Math.Abs(1.0))] = "TEMP";
		array[Convert.ToInt32(4.5 - Math.Abs(1.5))] = "ExamineIndexes";
		array[4] = indexPath.Name;
		return new DirectoryInfo(Path.Combine(array));
	}
}
