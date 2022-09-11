using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;

internal class Class19 : NativeObjectSecurity
{
	public override Type AccessRightType
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	public override Type AccessRuleType => typeof(AccessRule);

	public override Type AuditRuleType => typeof(AuditRule);

	public Class19(bool bool_0, ResourceType resourceType_0, SafeHandle safeHandle_0, AccessControlSections accessControlSections_0)
		: base(bool_0, resourceType_0, safeHandle_0, accessControlSections_0)
	{
	}

	public void method_0(SafeHandle safeHandle_0, AccessControlSections accessControlSections_0)
	{
		Persist(safeHandle_0, accessControlSections_0);
	}

	public void method_1(AccessRule accessRule_0)
	{
		AddAccessRule(accessRule_0);
	}

	public override AccessRule AccessRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type)
	{
		throw new NotImplementedException();
	}

	public override AuditRule AuditRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags)
	{
		throw new NotImplementedException();
	}
}
