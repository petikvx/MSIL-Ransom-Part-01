using System.Security.AccessControl;
using System.Security.Principal;

internal class Class18 : AccessRule
{
	public Class18(IdentityReference identityReference_0, int int_0, AccessControlType accessControlType_0)
		: base(identityReference_0, int_0, isInherited: false, InheritanceFlags.None, PropagationFlags.None, accessControlType_0)
	{
	}
}
