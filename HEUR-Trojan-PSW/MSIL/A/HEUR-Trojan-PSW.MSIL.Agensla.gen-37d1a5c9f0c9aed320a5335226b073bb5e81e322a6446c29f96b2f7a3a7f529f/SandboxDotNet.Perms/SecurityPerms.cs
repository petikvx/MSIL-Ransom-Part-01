using System.Security.Permissions;

namespace SandboxDotNet.Perms;

public class SecurityPerms
{
	private SecurityPermissionFlag _flag;

	public SecurityPerms()
	{
		_flag = SecurityPermissionFlag.NoFlags;
	}

	public SecurityPerms(SecurityPermissionFlag flag)
		: this()
	{
		_flag |= flag;
	}

	public SecurityPerms(bool assertion, bool bindingRedirect, bool controlAppDomain, bool controlEvidence, bool controlDomainPolicy, bool controlPolicy, bool controlPrincipal, bool controlThread, bool execution, bool infrastructure, bool remoting, bool serialization, bool skipVer, bool unmanaged)
		: this()
	{
		if (assertion)
		{
			_flag |= SecurityPermissionFlag.Assertion;
		}
		if (bindingRedirect)
		{
			_flag |= SecurityPermissionFlag.BindingRedirects;
		}
		if (controlAppDomain)
		{
			_flag |= SecurityPermissionFlag.ControlAppDomain;
		}
		if (controlEvidence)
		{
			_flag |= SecurityPermissionFlag.ControlEvidence;
		}
		if (controlDomainPolicy)
		{
			_flag |= SecurityPermissionFlag.ControlDomainPolicy;
		}
		if (controlPolicy)
		{
			_flag |= SecurityPermissionFlag.ControlPolicy;
		}
		if (controlPrincipal)
		{
			_flag |= SecurityPermissionFlag.ControlPrincipal;
		}
		if (controlThread)
		{
			_flag |= SecurityPermissionFlag.ControlThread;
		}
		if (execution)
		{
			_flag |= SecurityPermissionFlag.Execution;
		}
		if (infrastructure)
		{
			_flag |= SecurityPermissionFlag.Infrastructure;
		}
		if (remoting)
		{
			_flag |= SecurityPermissionFlag.RemotingConfiguration;
		}
		if (serialization)
		{
			_flag |= SecurityPermissionFlag.SerializationFormatter;
		}
		if (skipVer)
		{
			_flag |= SecurityPermissionFlag.SkipVerification;
		}
		if (unmanaged)
		{
			_flag |= SecurityPermissionFlag.UnmanagedCode;
		}
	}

	public SecurityPermissionFlag GetSecurityPermissionFlag()
	{
		return _flag;
	}

	public bool ContainsFlag(SecurityPermissionFlag flag)
	{
		return _flag.HasFlag(flag);
	}

	public void AddFlag(SecurityPermissionFlag flag)
	{
		_flag |= flag;
	}

	public override string ToString()
	{
		return _flag.ToString();
	}
}
