using System;
using System.Collections.Generic;
using System.Security;
using Lucene.Net.Index;
using Lucene.Net.Search;

namespace Examine.LuceneEngine;

[Obsolete("This is no longer used and will be removed from the codebase in future versions")]
[SecurityCritical]
public class AllHitsCollector : Collector
{
	public class AllHit
	{
		public int DocId { get; set; }

		public float Score { get; set; }

		public AllHit(int docId, float score)
		{
			DocId = docId;
			Score = score;
		}
	}

	private int docBase;

	private bool outOfOrder;

	private bool shouldScore;

	private Scorer scorer;

	private List<AllHit> hits;

	public int Count => hits.Count;

	public AllHitsCollector(bool outOfOrder, bool shouldScore)
	{
		this.outOfOrder = outOfOrder;
		this.shouldScore = shouldScore;
		hits = new List<AllHit>();
	}

	public AllHitsCollector(ScoreDoc[] docs)
	{
		outOfOrder = true;
		shouldScore = true;
		hits = new List<AllHit>(docs.Length);
		foreach (ScoreDoc val in docs)
		{
			hits.Add(new AllHit(val.doc, val.score));
		}
	}

	[SecurityCritical]
	public override bool AcceptsDocsOutOfOrder()
	{
		return outOfOrder;
	}

	[SecurityCritical]
	public override void Collect(int doc)
	{
		float score = 1f;
		if (shouldScore)
		{
			score = scorer.Score();
		}
		hits.Add(new AllHit(doc, score));
	}

	[SecurityCritical]
	public override void SetNextReader(IndexReader reader, int docBase)
	{
		this.docBase = docBase;
	}

	[SecurityCritical]
	public override void SetScorer(Scorer scorer)
	{
		this.scorer = scorer;
	}

	public int GetDocId(int index)
	{
		return hits[index].DocId;
	}

	public float GetDocScore(int index)
	{
		return hits[index].Score;
	}
}
