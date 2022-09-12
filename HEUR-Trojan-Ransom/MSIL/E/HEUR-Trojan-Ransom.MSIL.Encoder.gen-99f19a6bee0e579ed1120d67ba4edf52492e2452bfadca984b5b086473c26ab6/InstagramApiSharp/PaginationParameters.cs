using System.Collections.Generic;

namespace InstagramApiSharp;

public class PaginationParameters
{
	public string RankToken { get; set; } = string.Empty;


	public string NextMaxId { get; set; } = string.Empty;


	public string NextMinId { get; set; } = string.Empty;


	public int MaximumPagesToLoad { get; private set; }

	public int PagesLoaded { get; set; } = 1;


	public int? NextPage { get; set; }

	public List<long> ExcludeList { get; set; } = new List<long>();


	public List<long> NextMediaIds { get; set; }

	public static PaginationParameters Empty => MaxPagesToLoad(int.MaxValue);

	private PaginationParameters()
	{
	}

	public static PaginationParameters MaxPagesToLoad(int maxPagesToLoad)
	{
		return new PaginationParameters
		{
			MaximumPagesToLoad = maxPagesToLoad
		};
	}

	public PaginationParameters StartFromMaxId(string maxId)
	{
		NextMaxId = maxId;
		NextMinId = null;
		return this;
	}

	public PaginationParameters StartFromMinId(string minId)
	{
		NextMinId = minId;
		NextMaxId = null;
		return this;
	}

	public PaginationParameters StartFromRankToken(string nextId, string rankToken)
	{
		NextMaxId = nextId;
		RankToken = rankToken;
		return this;
	}
}
