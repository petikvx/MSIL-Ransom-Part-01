using System;

namespace TRM.Spread;

public static class WatchMeProcess
{
	private static AppGlobalMessages _globalMessage;

	private static readonly int _watchmeMessage = AppGlobalMessages.RegisterWindowMessage("wm");

	public static void StartWatchMeProcessMessages()
	{
		if (_globalMessage != null)
		{
			_globalMessage.Dispose();
			_globalMessage = null;
		}
		_globalMessage = new AppGlobalMessages();
		_globalMessage.AddMessage(_watchmeMessage, MessageEventArg);
	}

	public static void SendWatchmeMessage(int processId)
	{
		AppGlobalMessages.PostMessage(_watchmeMessage, (IntPtr)processId, IntPtr.Zero);
	}

	private static void MessageEventArg(int msg, IntPtr wparam, IntPtr lparam)
	{
		if (msg == _watchmeMessage)
		{
			try
			{
				int value = wparam.ToInt32();
				AppManager.StartWatchProccess(value);
			}
			catch
			{
			}
		}
	}
}
