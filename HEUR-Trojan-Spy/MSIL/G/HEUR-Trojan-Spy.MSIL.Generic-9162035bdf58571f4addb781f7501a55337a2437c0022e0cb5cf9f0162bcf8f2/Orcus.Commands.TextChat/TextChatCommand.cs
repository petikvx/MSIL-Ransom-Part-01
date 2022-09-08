using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Orcus.Commands.TextChat.Utilities;
using Orcus.Plugins;
using Orcus.Shared.Commands.TextChat;
using Orcus.Shared.NetSerializer;

namespace Orcus.Commands.TextChat;

public class TextChatCommand : Command
{
	private TextChatForm _currentChatForm;

	public override void Dispose()
	{
		((Command)this).Dispose();
		TextChatForm currentChatForm = _currentChatForm;
		if (currentChatForm != null)
		{
			((Form)currentChatForm).Close();
		}
		_currentChatForm = null;
	}

	public override void ProcessCommand(byte[] parameter, IConnectionInfo connectionInfo)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected I4, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		TextChatCommunication val = (TextChatCommunication)parameter[0];
		switch (val - 3)
		{
		default:
			throw new ArgumentOutOfRangeException();
		case 0:
			_currentChatForm?.MessageReceived(new DateTime(BitConverter.ToInt64(parameter, 1)), Encoding.UTF8.GetString(parameter, 9, parameter.Length - 9));
			break;
		case 1:
		{
			ChatSettings val2 = new Serializer(typeof(ChatSettings)).Deserialize<ChatSettings>(parameter, 1);
			if (val2.get_HideEveythingElse())
			{
				Computer.MinimizeAllScreens();
			}
			_currentChatForm = new TextChatForm(val2);
			_currentChatForm.SendMessage += delegate(object sender, SendTextMessageEventArgs e)
			{
				List<byte> list = new List<byte> { 2 };
				list.AddRange(BitConverter.GetBytes(DateTime.UtcNow.Ticks));
				list.AddRange(Encoding.UTF8.GetBytes(e.Message));
				connectionInfo.CommandResponse((Command)(object)this, list.ToArray(), (PackageCompression)0);
			};
			((Form)_currentChatForm).add_Closed((EventHandler)delegate
			{
				_currentChatForm = null;
				try
				{
					connectionInfo.CommandResponse((Command)(object)this, new byte[1] { 1 }, (PackageCompression)0);
				}
				catch (Exception)
				{
				}
			});
			connectionInfo.CommandResponse((Command)(object)this, new byte[1], (PackageCompression)0);
			((Form)_currentChatForm).ShowDialog();
			break;
		}
		case 2:
			if (_currentChatForm == null)
			{
				break;
			}
			if (!_currentChatForm.IsClosed)
			{
				try
				{
					((Control)_currentChatForm).Invoke((Delegate)(MethodInvoker)delegate
					{
						_currentChatForm.ForceClose();
					});
				}
				catch (Exception)
				{
				}
			}
			_currentChatForm = null;
			break;
		}
	}

	protected override uint GetId()
	{
		return 21u;
	}
}
