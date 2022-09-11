using System.Security.AccessControl;
using System.Security.Principal;

namespace ns0;

public abstract class GClass1
{
	private readonly IdentityReference identityReference_0;

	private readonly int int_0;

	private readonly bool bool_0;

	private readonly InheritanceFlags inheritanceFlags_0;

	internal PropagationFlags propagationFlags_0;

	public IdentityReference IdentityReference => identityReference_0;

	protected internal int AccessMask => int_0;

	public bool IsInherited => bool_0;

	public InheritanceFlags InheritanceFlags => inheritanceFlags_0;

	public PropagationFlags PropagationFlags => propagationFlags_0;

	protected internal GClass1(IdentityReference identity, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags)
	{
		identityReference_0 = identity;
		int_0 = accessMask;
		bool_0 = isInherited;
		inheritanceFlags_0 = inheritanceFlags;
		if (inheritanceFlags != 0)
		{
			PropagationFlags propagationFlags2 = (propagationFlags_0 = propagationFlags);
		}
		else
		{
			propagationFlags_0 = PropagationFlags.None;
		}
	}
}
