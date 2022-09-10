using System.Security.Policy;

namespace Microsoft.Tools.Caspol;

internal delegate IMembershipCondition MembershipConditionHandler(PolicyLevel level, string[] args, int index, out int offset);
