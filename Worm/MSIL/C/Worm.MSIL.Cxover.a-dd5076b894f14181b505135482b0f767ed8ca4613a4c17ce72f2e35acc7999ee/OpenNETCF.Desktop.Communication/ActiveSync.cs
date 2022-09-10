using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Win32;

namespace OpenNETCF.Desktop.Communication;

public class ActiveSync
{
	public enum ActiveSyncIcon
	{
		DataTransferring,
		NoDataTransferring,
		Error
	}

	private DccMan dccMan;

	private IDccMan idccMan;

	private IDccManSink idccSink;

	private DccManSink dccSink;

	private int dccContext = 0;

	private AutoStartApps connectapps = new AutoStartApps("SOFTWARE\\Microsoft\\Windows CE Services\\AutoStartOnConnect");

	private AutoStartApps disconnectapps = new AutoStartApps("SOFTWARE\\Microsoft\\Windows CE Services\\AutoStartOnDisconnect");

	public bool ConnectAsGuestOnly
	{
		get
		{
			bool result = false;
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows CE Services");
				result = (int)registryKey.GetValue("GuestOnly", 0) == 1;
				registryKey.Close();
				return result;
			}
			catch (Exception)
			{
				return result;
			}
		}
		set
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows CE Services", writable: true);
			registryKey.SetValue("GuestOnly", value ? 1 : 0);
			registryKey.Close();
		}
	}

	public AutoStartApps AutoStartOnConnect
	{
		get
		{
			return connectapps;
		}
		set
		{
			connectapps = value;
		}
	}

	public AutoStartApps AutoStartOnDisconnect
	{
		get
		{
			return disconnectapps;
		}
		set
		{
			disconnectapps = value;
		}
	}

	public ActiveSyncIcon Icon
	{
		set
		{
			switch (value)
			{
			case ActiveSyncIcon.DataTransferring:
				idccMan.SetIconDataTransferring();
				break;
			case ActiveSyncIcon.NoDataTransferring:
				idccMan.SetIconNoDataTransferring();
				break;
			case ActiveSyncIcon.Error:
				idccMan.SetIconError();
				break;
			}
		}
	}

	public bool AutoConnect
	{
		set
		{
			if (value)
			{
				idccMan.AutoconnectEnable();
			}
			else
			{
				idccMan.AutoconnectDisable();
			}
		}
	}

	public unsafe string Version
	{
		get
		{
			byte[] array = new byte[512];
			uint num = 0u;
			fixed (byte* lpBuffer = &array[0])
			{
				num = GetWindowsDirectory(lpBuffer, 512u);
			}
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			string fileName = aSCIIEncoding.GetString(array, 0, (int)num) + "\\System32\\rapi.dll";
			FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(fileName);
			return versionInfo.FileVersion;
		}
	}

	public event ActiveHandler Active;

	public event AnswerHandler Answer;

	public event DisconnectHandler Disconnect;

	public event ErrorHandler Error;

	public event InactiveHandler Inactive;

	public event IPAddrHandler IPChange;

	public event ListenHandler Listen;

	public event TerminatedHandler Terminated;

	[DllImport("kernel32", SetLastError = true)]
	private unsafe static extern uint GetWindowsDirectory(byte* lpBuffer, uint uSize);

	internal void BeginListen()
	{
		idccMan.Advise(idccSink, out dccContext);
	}

	internal void EndListen()
	{
	}

	internal ActiveSync()
	{
		try
		{
			dccMan = new DccMan();
			dccSink = new DccManSink();
			dccSink.Active += dccSink_Active;
			dccSink.Answer += dccSink_Answer;
			dccSink.Disconnect += dccSink_Disconnect;
			dccSink.Error += dccSink_Error;
			dccSink.Inactive += dccSink_Inactive;
			dccSink.IPChange += dccSink_IPChange;
			dccSink.Listen += dccSink_Listen;
			dccSink.Terminated += dccSink_Terminated;
			idccMan = (IDccMan)dccMan;
			idccSink = dccSink;
		}
		catch (Exception)
		{
			throw new RAPIException("Unable to create ActiveSync object.  Make sure ActiveSync is installed");
		}
	}

	public void ShowCommSettings()
	{
		idccMan.ShowCommSettings();
	}

	public void ConnectNow()
	{
		idccMan.ConnectNow();
	}

	public void DisconnectNow()
	{
		idccMan.DisconnectNow();
	}

	public static string IntToDottedIP(int IP)
	{
		byte b = 0;
		string text = "";
		for (byte b2 = 0; b2 < 4; b2 = (byte)(b2 + 1))
		{
			text += (byte)(((uint)IP & (255 << b2 * 8)) >> b2 * 8);
			if (b2 < 3)
			{
				text += ".";
			}
		}
		return text;
	}

	private void dccSink_Active()
	{
		if (this.Active != null)
		{
			Delegate[] invocationList = this.Active.GetInvocationList();
			for (int i = 0; i < invocationList.Length; i++)
			{
				ActiveHandler activeHandler = (ActiveHandler)invocationList[i];
				activeHandler();
			}
		}
	}

	private void dccSink_Answer()
	{
		if (this.Answer != null)
		{
			Delegate[] invocationList = this.Answer.GetInvocationList();
			for (int i = 0; i < invocationList.Length; i++)
			{
				AnswerHandler answerHandler = (AnswerHandler)invocationList[i];
				answerHandler();
			}
		}
	}

	private void dccSink_Disconnect()
	{
		if (this.Disconnect != null)
		{
			Delegate[] invocationList = this.Disconnect.GetInvocationList();
			for (int i = 0; i < invocationList.Length; i++)
			{
				DisconnectHandler disconnectHandler = (DisconnectHandler)invocationList[i];
				disconnectHandler();
			}
		}
	}

	private void dccSink_Error()
	{
		if (this.Error != null)
		{
			Delegate[] invocationList = this.Error.GetInvocationList();
			for (int i = 0; i < invocationList.Length; i++)
			{
				ErrorHandler errorHandler = (ErrorHandler)invocationList[i];
				errorHandler();
			}
		}
	}

	private void dccSink_Inactive()
	{
		if (this.Inactive != null)
		{
			Delegate[] invocationList = this.Inactive.GetInvocationList();
			for (int i = 0; i < invocationList.Length; i++)
			{
				InactiveHandler inactiveHandler = (InactiveHandler)invocationList[i];
				inactiveHandler();
			}
		}
	}

	private void dccSink_IPChange(int IP)
	{
		if (this.IPChange != null)
		{
			Delegate[] invocationList = this.IPChange.GetInvocationList();
			for (int i = 0; i < invocationList.Length; i++)
			{
				IPAddrHandler iPAddrHandler = (IPAddrHandler)invocationList[i];
				iPAddrHandler(IP);
			}
		}
	}

	private void dccSink_Listen()
	{
		if (this.Listen != null)
		{
			Delegate[] invocationList = this.Listen.GetInvocationList();
			for (int i = 0; i < invocationList.Length; i++)
			{
				ListenHandler listenHandler = (ListenHandler)invocationList[i];
				listenHandler();
			}
		}
	}

	private void dccSink_Terminated()
	{
		if (this.Terminated != null)
		{
			Delegate[] invocationList = this.Terminated.GetInvocationList();
			for (int i = 0; i < invocationList.Length; i++)
			{
				TerminatedHandler terminatedHandler = (TerminatedHandler)invocationList[i];
				terminatedHandler();
			}
		}
	}
}
