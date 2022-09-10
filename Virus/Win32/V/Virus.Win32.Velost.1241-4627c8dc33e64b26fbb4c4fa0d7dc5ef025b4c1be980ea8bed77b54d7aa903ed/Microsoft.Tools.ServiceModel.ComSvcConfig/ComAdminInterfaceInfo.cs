using System;

namespace Microsoft.Tools.ServiceModel.ComSvcConfig;

internal class ComAdminInterfaceInfo
{
	private Guid iid;

	private string name;

	public Guid Iid => iid;

	public string Name => name;

	public ComAdminInterfaceInfo(Guid iid, string name)
	{
		this.iid = iid;
		this.name = name;
	}
}
