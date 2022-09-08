using System.Windows.Forms;
using Orcus.Plugins;
using Orcus.Shared.Commands.MessageBox;
using Orcus.Shared.NetSerializer;

namespace Orcus.Commands.MessageBox;

internal class MessageBoxCommand : Command
{
	public override void ProcessCommand(byte[] parameter, IConnectionInfo connectionInfo)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		MessageBoxInformation val = new Serializer(typeof(MessageBoxInformation)).Deserialize<MessageBoxInformation>(parameter);
		MessageBox.Show(val.get_Text(), val.get_Title(), (MessageBoxButtons)val.get_MessageBoxButtons(), SystemIconToMessageBoxIcon(val.get_Icon()));
		connectionInfo.CommandSucceed((Command)(object)this, new byte[0]);
	}

	private static MessageBoxIcon SystemIconToMessageBoxIcon(SystemIcon icon)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected I4, but got Unknown
		return (MessageBoxIcon)((int)icon switch
		{
			0 => 16, 
			1 => 64, 
			2 => 48, 
			3 => 32, 
			_ => 0, 
		});
	}

	protected override uint GetId()
	{
		return 11u;
	}
}
