namespace InstagramApiSharp.Classes;

public enum ResponseType
{
	Unknown,
	LoginRequired,
	CheckPointRequired,
	RequestsLimit,
	SentryBlock,
	OK,
	WrongRequest,
	SomePagesSkipped,
	UnExpectedResponse,
	InternalException,
	ChallengeRequired,
	InactiveUser,
	ConsentRequired,
	ActionBlocked,
	Spam,
	MediaNotFound,
	CommentingIsDisabled,
	AlreadyLiked,
	DeletedPost,
	CantLike,
	NetworkProblem
}
