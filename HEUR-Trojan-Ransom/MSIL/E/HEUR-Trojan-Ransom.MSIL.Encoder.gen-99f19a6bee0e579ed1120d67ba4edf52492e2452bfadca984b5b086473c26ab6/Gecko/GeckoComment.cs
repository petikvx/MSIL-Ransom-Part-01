using Gecko.DOM;

namespace Gecko;

public class GeckoComment : DomCharacterData
{
	private nsIDOMComment DomComment;

	internal GeckoComment(nsIDOMComment comment)
		: base(comment)
	{
		DomComment = comment;
	}

	internal static GeckoComment CreateCommentWrapper(nsIDOMComment comment)
	{
		return (comment == null) ? null : new GeckoComment(comment);
	}
}
