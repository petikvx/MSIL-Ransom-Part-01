namespace InstagramApiSharp.Classes;

public enum InstaLoginTwoFactorResult
{
	Success,
	InvalidCode,
	CodeExpired,
	Exception,
	ChallengeRequired
}
