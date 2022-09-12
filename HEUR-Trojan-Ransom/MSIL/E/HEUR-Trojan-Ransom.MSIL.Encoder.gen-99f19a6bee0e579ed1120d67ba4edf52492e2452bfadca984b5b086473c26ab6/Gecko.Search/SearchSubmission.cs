using System;
using Gecko.IO;

namespace Gecko.Search;

public sealed class SearchSubmission
{
	private nsISearchSubmission _searchSubmission;

	public Uri Uri => Xpcom.TranslateUriAttribute(_searchSubmission.GetUriAttribute);

	public InputStream PostData => InputStream.Create(_searchSubmission.GetPostDataAttribute());

	internal SearchSubmission(nsISearchSubmission searchSubmission)
	{
		_searchSubmission = searchSubmission;
		_searchSubmission.GetPostDataAttribute();
	}
}
