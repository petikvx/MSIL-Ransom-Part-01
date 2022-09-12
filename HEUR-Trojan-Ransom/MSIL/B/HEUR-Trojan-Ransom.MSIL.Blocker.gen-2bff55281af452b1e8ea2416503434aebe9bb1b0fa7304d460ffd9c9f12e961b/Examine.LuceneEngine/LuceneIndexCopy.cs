using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using Lucene.Net.Analysis;
using Lucene.Net.Index;
using Lucene.Net.Store;

namespace Examine.LuceneEngine;

internal class LuceneIndexCopy
{
	private readonly SnapshotDeletionPolicy _snapshotter;

	[SecuritySafeCritical]
	public LuceneIndexCopy()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		IndexDeletionPolicy val = (IndexDeletionPolicy)new KeepOnlyLastCommitDeletionPolicy();
		_snapshotter = new SnapshotDeletionPolicy(val);
	}

	[SecuritySafeCritical]
	public bool Copy(SimpleFSDirectory sourceLuceneDirectory, Analyzer analyzer, DirectoryInfo targetPath)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (!targetPath.Exists)
		{
			Directory.CreateDirectory(targetPath.FullName);
		}
		if (!IndexReader.IndexExists((Directory)(object)sourceLuceneDirectory))
		{
			return true;
		}
		IndexWriter val = new IndexWriter((Directory)(object)sourceLuceneDirectory, analyzer, (IndexDeletionPolicy)(object)_snapshotter, MaxFieldLength.UNLIMITED);
		try
		{
			try
			{
				HashSet<string> hashSet = new HashSet<string>();
				IndexCommitPoint val2 = _snapshotter.Snapshot();
				foreach (string fileName in val2.GetFileNames())
				{
					hashSet.Add(fileName);
				}
				hashSet.Add(val2.GetSegmentsFileName());
				hashSet.Add("segments.gen");
				foreach (string item in (from x in targetPath.GetFiles()
					select x.Name).Except(hashSet))
				{
					try
					{
						File.Delete(Path.Combine(targetPath.FullName, item));
					}
					catch (IOException)
					{
					}
				}
				foreach (string item2 in hashSet.Where((string f) => !string.IsNullOrWhiteSpace(f)))
				{
					string text = Path.Combine(targetPath.FullName, Path.GetFileName(item2));
					if (!File.Exists(text))
					{
						try
						{
							File.Copy(Path.Combine(((FSDirectory)sourceLuceneDirectory).GetDirectory().FullName, "Index", item2), text);
						}
						catch (IOException)
						{
							return false;
						}
					}
				}
			}
			finally
			{
				_snapshotter.Release();
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		return true;
	}
}
