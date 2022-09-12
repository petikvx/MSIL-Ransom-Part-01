using System;
using System.IO;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using Examine.LuceneEngine.Providers;
using Lucene.Net.Store;

namespace Examine.LuceneEngine.Directories;

public class SyncTempEnvDirectoryFactory : IDirectoryFactory
{
	[SecuritySafeCritical]
	public virtual Directory CreateDirectory(LuceneIndexer indexer, string luceneIndexFolder)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0025: Expected O, but got Unknown
		DirectoryInfo indexPath = new DirectoryInfo(luceneIndexFolder);
		DirectoryInfo localStorageDirectory = GetLocalStorageDirectory(indexPath);
		return (Directory)(object)new SyncDirectory((Directory)new SimpleFSDirectory(new DirectoryInfo(luceneIndexFolder)), (Directory)new SimpleFSDirectory(localStorageDirectory));
	}

	protected DirectoryInfo GetLocalStorageDirectory(DirectoryInfo indexPath)
	{
		string path = ToMd5(HttpRuntime.get_AppDomainAppId());
		string indexPathName = GetIndexPathName(indexPath);
		DirectoryInfo directoryInfo = new DirectoryInfo(Path.Combine(Environment.ExpandEnvironmentVariables("%temp%"), "ExamineIndexes", path, indexPathName));
		if (!directoryInfo.Exists)
		{
			directoryInfo.Create();
		}
		return directoryInfo;
	}

	private string GetIndexPathName(DirectoryInfo indexPath)
	{
		string[] array = indexPath.FullName.Split(new char[1] { Path.DirectorySeparatorChar }, StringSplitOptions.RemoveEmptyEntries);
		if (array.Length != 0 && string.Equals(array[^1], "Index", (StringComparison)Convert.ToInt32(5.0)))
		{
			return array[^Convert.ToInt32(1.0 + Math.Truncate(1.0))];
		}
		return ToMd5(indexPath.FullName);
	}

	private static string ToMd5(string stringToConvert)
	{
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] bytes = Encoding.UTF8.GetBytes(stringToConvert);
		byte[] array = mD5CryptoServiceProvider.ComputeHash(bytes);
		StringBuilder stringBuilder = new StringBuilder();
		byte[] array2 = array;
		foreach (byte b in array2)
		{
			stringBuilder.Append(b.ToString("x2").ToLower());
		}
		return stringBuilder.ToString();
	}
}
