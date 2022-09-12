using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Kzzdehomtdt;

public static class MessagePasser
{
	public static bool ThrowOnBadMessage = true;

	public static int WindowsMessageId = 74;

	public static int SendData(IntPtr targetWindowHandle, int messageId, int id, string message)
	{
		CopyData lParam = default(CopyData);
		lParam.dwData = new IntPtr(id);
		lParam.cbData = (message.Length + 1) * Marshal.SystemDefaultCharSize;
		lParam.lpData = message;
		IntPtr intPtr = NativeMethods.SendMessage(targetWindowHandle, messageId, IntPtr.Zero, ref lParam);
		int lastWin32Error = Marshal.GetLastWin32Error();
		string message2 = new Win32Exception(lastWin32Error).Message;
		if (lastWin32Error != 0)
		{
			throw new InvalidOperationException("Last Error isn't success:" + lastWin32Error + Environment.NewLine + message2);
		}
		return intPtr.ToInt32();
	}

	public static int SendString(IntPtr targetWindowHandle, int id, string message)
	{
		return SendData(targetWindowHandle, WindowsMessageId, id, message);
	}

	public static int SendString(IntPtr targetWindowHandle, string message)
	{
		return SendString(targetWindowHandle, 1, message);
	}

	public static CopyData ReceiveData(Message m)
	{
		if (((Message)(ref m)).get_Msg() != WindowsMessageId)
		{
			if (ThrowOnBadMessage)
			{
				throw new InvalidOperationException("Message isn't WM_COPYDATA");
			}
			return default(CopyData);
		}
		((Message)(ref m)).set_Result(new IntPtr(1));
		CopyData result = (CopyData)((Message)(ref m)).GetLParam(typeof(CopyData));
		((Message)(ref m)).set_Result(new IntPtr(0));
		return result;
	}

	public static string ReceiveString(Message m)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return ReceiveData(m).lpData;
	}
}
