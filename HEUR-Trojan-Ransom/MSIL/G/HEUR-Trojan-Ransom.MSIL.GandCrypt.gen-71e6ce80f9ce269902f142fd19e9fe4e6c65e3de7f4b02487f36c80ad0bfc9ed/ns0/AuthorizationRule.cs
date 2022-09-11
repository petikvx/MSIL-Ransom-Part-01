using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;

namespace ns0;

public abstract class AuthorizationRule
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 316)]
	private struct Struct0
	{
	}

	private readonly int int_0;

	private readonly bool bool_0;

	private readonly InheritanceFlags inheritanceFlags_0;

	private readonly PropagationFlags propagationFlags_0;

	private static readonly object object_0;

	private static readonly object object_1 = new char[158];

	private static readonly Array array_0;

	internal static byte byte_0/* Not supported: data(00) */;

	internal IdentityReference identityReference_0;

	public IdentityReference IdentityReference => identityReference_0;

	protected internal int AccessMask => int_0;

	public bool IsInherited => bool_0;

	public InheritanceFlags InheritanceFlags => inheritanceFlags_0;

	public PropagationFlags PropagationFlags => propagationFlags_0;

	protected internal AuthorizationRule(IdentityReference identityReference_1, int int_1, bool bool_1, InheritanceFlags inheritanceFlags_1, PropagationFlags propagationFlags_1)
	{
		IdentityReference identityReference = (identityReference_0 = identityReference_1);
		int_0 = int_1;
		bool_0 = bool_1;
		inheritanceFlags_0 = inheritanceFlags_1;
		if (inheritanceFlags_1 != 0)
		{
			propagationFlags_0 = propagationFlags_1;
		}
		else
		{
			propagationFlags_0 = PropagationFlags.None;
		}
	}

	static AuthorizationRule()
	{
		char[] array = new char[8];
		array[0] = '۳';
		array[4] = '㐷';
		array[5] = 'Ӡ';
		array[3] = '㭖';
		array[6] = 'ӳ';
		array[7] = '㕉';
		array[2] = '⌙';
		array[1] = '㠻';
		array_0 = new string[17];
		object_0 = array;
	}
}
