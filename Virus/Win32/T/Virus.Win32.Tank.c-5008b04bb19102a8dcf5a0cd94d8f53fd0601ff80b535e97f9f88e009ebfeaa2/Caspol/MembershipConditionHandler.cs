using System.Security.Policy;

namespace Caspol;

internal delegate IMembershipCondition MembershipConditionHandler(PolicyLevel level, string[] args, int index, out int offset);
