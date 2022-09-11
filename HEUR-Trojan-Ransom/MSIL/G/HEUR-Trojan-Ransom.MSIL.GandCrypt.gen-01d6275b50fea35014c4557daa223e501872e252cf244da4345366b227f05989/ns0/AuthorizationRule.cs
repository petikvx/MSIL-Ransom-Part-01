using System.Security.AccessControl;
using System.Security.Principal;

namespace ns0;

public abstract class AuthorizationRule
{
	private readonly IdentityReference identityReference_0;

	private readonly int int_0;

	private readonly PropagationFlags propagationFlags_0;

	internal bool bool_0;

	internal InheritanceFlags inheritanceFlags_0;

	public IdentityReference IdentityReference => identityReference_0;

	protected internal int AccessMask => int_0;

	public bool IsInherited => bool_0;

	public InheritanceFlags InheritanceFlags => inheritanceFlags_0;

	public PropagationFlags PropagationFlags => propagationFlags_0;

	protected internal AuthorizationRule(IdentityReference identityReference_1, int int_1, bool bool_1, InheritanceFlags inheritanceFlags_1, PropagationFlags propagationFlags_1)
	{
		identityReference_0 = identityReference_1;
		int_0 = int_1;
		bool flag = (bool_0 = bool_1);
		InheritanceFlags inheritanceFlags = (inheritanceFlags_0 = inheritanceFlags_1);
		if (inheritanceFlags_1 != 0)
		{
			propagationFlags_0 = propagationFlags_1;
		}
		else
		{
			propagationFlags_0 = PropagationFlags.None;
		}
	}
}
