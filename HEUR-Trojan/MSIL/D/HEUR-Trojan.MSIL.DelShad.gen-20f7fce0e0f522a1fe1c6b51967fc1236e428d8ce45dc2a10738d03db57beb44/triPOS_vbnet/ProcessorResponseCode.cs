namespace triPOS_vbnet;

public enum ProcessorResponseCode
{
	Unknown,
	Approved,
	PartialApproval,
	Decline,
	ExpiredCard,
	Duplicate,
	PickUpCard,
	ReferralCallIssuer,
	InvalidData
}
