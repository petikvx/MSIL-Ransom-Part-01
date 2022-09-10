using System;
using System.IO;
using System.Runtime.Remoting.Lifetime;
using System.Threading;
using IERYETF;

namespace eRecoveryService;

public class ETFclass : MarshalByRefObject, IERY
{
	private ILease lease;

	public override object InitializeLifetimeService()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		if (lease == null)
		{
			lease = (ILease)base.InitializeLifetimeService();
			if ((int)lease.get_CurrentState() == 1)
			{
				lease.set_InitialLeaseTime(TimeSpan.Zero);
			}
		}
		return lease;
	}

	private string GetAvailableDrLetter()
	{
		uint logicalDrives = WIN32.GetLogicalDrives();
		string text = "";
		char c = 'D';
		int num = 3;
		for (num = 3; num < 26; num++)
		{
			if (((logicalDrives >> num) & (true ? 1u : 0u)) != 0)
			{
				c = (char)(c + 1);
				continue;
			}
			text = c.ToString();
			break;
		}
		text += ":";
		if (num == 26)
		{
			text = "";
		}
		return text;
	}

	private bool MountHiddenPartition(string szDr)
	{
		bool flag = false;
		int num = 0;
		while (!flag && num < 5)
		{
			if (!(flag = WIN32.DefineDosDevice(1u, szDr, "\\Device\\Harddisk0\\Partition1")))
			{
				Thread.Sleep(1000);
			}
		}
		return flag;
	}

	public bool UnMountHiddenPartition(string m_szTempHid)
	{
		bool flag = false;
		int num = 0;
		while (!flag && num < 5)
		{
			if (!(flag = WIN32.DefineDosDevice(7u, m_szTempHid, "\\Device\\Harddisk0\\Partition1")))
			{
				Thread.Sleep(1000);
			}
		}
		return flag;
	}

	public bool SetHiddenPartPassHint(string szPass, string szHint)
	{
		string availableDrLetter = GetAvailableDrLetter();
		string text = availableDrLetter + "\\aimdrs.dat";
		MountHiddenPartition(availableDrLetter);
		if (szPass.Length == 0)
		{
			if (File.Exists(text))
			{
				File.SetAttributes(text, FileAttributes.Normal);
				File.Delete(text);
				UnMountHiddenPartition(availableDrLetter);
			}
			return true;
		}
		if (szPass.Length > 0 && File.Exists(text))
		{
			File.SetAttributes(text, FileAttributes.Normal);
		}
		WIN32.WritePrivateProfileString("MyData", "PD", szPass, text);
		WIN32.WritePrivateProfileString("MyData", "HT", szHint, text);
		File.SetAttributes(text, FileAttributes.ReadOnly | FileAttributes.Hidden | FileAttributes.System);
		UnMountHiddenPartition(availableDrLetter);
		return true;
	}
}
