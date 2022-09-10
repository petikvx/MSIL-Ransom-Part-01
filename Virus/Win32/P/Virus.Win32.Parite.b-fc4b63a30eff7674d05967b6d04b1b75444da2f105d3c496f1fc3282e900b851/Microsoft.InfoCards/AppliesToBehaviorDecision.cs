namespace Microsoft.InfoCards;

internal enum AppliesToBehaviorDecision : byte
{
	DoNotSend,
	SendRPAppliesTo,
	SendCustomAppliesTo,
	FailMatch
}
