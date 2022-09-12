using System;
using Coache.Common;

namespace Coache.Core;

public class PermissionRequiredAttribute : Attribute
{
	public Functionalities[] Permissions { get; set; }

	public PermissionRequiredAttribute(params Functionalities[] permissions)
	{
		Permissions = permissions;
	}
}
