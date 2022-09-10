using System.ServiceModel;

namespace Microsoft.InfoCards;

internal static class AppliesToBehaviorDecisionTable
{
	private static AppliesToBehaviorDecision[,] appliesToDecisionTable;

	static AppliesToBehaviorDecisionTable()
	{
		appliesToDecisionTable = new AppliesToBehaviorDecision[2, 3];
		appliesToDecisionTable[0, 0] = AppliesToBehaviorDecision.DoNotSend;
		appliesToDecisionTable[1, 0] = AppliesToBehaviorDecision.FailMatch;
		appliesToDecisionTable[0, 1] = AppliesToBehaviorDecision.DoNotSend;
		appliesToDecisionTable[1, 1] = AppliesToBehaviorDecision.SendRPAppliesTo;
		appliesToDecisionTable[0, 2] = AppliesToBehaviorDecision.SendCustomAppliesTo;
		appliesToDecisionTable[1, 2] = AppliesToBehaviorDecision.SendRPAppliesTo;
	}

	private static AppliesToBehaviorDecision GetAppliesToBehaviorDecision(InfoCardPolicy policy, RequireAppliesToStatus requireAppliesTo, bool considerUnrecognizedElements)
	{
		int num = ((!((EndpointAddress)null == policy.PolicyAppliesTo)) ? 1 : 0);
		if (considerUnrecognizedElements)
		{
			num = (policy.NonWhiteListElementsFound ? 1 : num);
		}
		return appliesToDecisionTable[num, (uint)requireAppliesTo];
	}

	public static AppliesToBehaviorDecision GetAppliesToBehaviorDecisionForRst(InfoCardPolicy policy, RequireAppliesToStatus requireAppliesTo)
	{
		return GetAppliesToBehaviorDecision(policy, requireAppliesTo, considerUnrecognizedElements: false);
	}

	public static AppliesToBehaviorDecision GetAppliesToBehaviorDecisionForPolicyMatch(InfoCardPolicy policy, RequireAppliesToStatus requireAppliesTo)
	{
		return GetAppliesToBehaviorDecision(policy, requireAppliesTo, considerUnrecognizedElements: true);
	}
}
