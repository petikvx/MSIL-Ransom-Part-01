using System;
using Alphaleonis.Win32.Filesystem;

namespace Alphaleonis.Win32.Network;

[Serializable]
public sealed class SessionInfo
{
	private string _netName;

	public string HostName { get; private set; }

	public string NetName
	{
		get
		{
			return _netName;
		}
		set
		{
			_netName = value?.ReplaceIgnoreCase(Path.LongPathUncPrefix, string.Empty).Replace(Path.UncPrefix, string.Empty).Trim('[', ']');
		}
	}

	public string UserName { get; private set; }

	public int OpenedResources { get; private set; }

	public TimeSpan ActiveTime { get; private set; }

	public TimeSpan IdleTime { get; private set; }

	public bool GuestSession { get; private set; }

	public bool EncryptedSession { get; private set; }

	public string ClientType { get; private set; }

	public string TransportType { get; private set; }

	public SessionInfoLevel SessionLevel { get; private set; }

	internal SessionInfo(string hostName, SessionInfoLevel sessionLevel, object structure)
	{
		int num = 0;
		switch (sessionLevel)
		{
		case SessionInfoLevel.Info502:
		{
			NativeMethods.SESSION_INFO_502 sESSION_INFO_4 = (NativeMethods.SESSION_INFO_502)structure;
			NetName = sESSION_INFO_4.sesi502_cname;
			UserName = sESSION_INFO_4.sesi502_username;
			OpenedResources = (int)sESSION_INFO_4.sesi502_num_opens;
			ActiveTime = TimeSpan.FromSeconds((int)sESSION_INFO_4.sesi502_time);
			IdleTime = TimeSpan.FromSeconds((int)sESSION_INFO_4.sesi502_idle_time);
			ClientType = sESSION_INFO_4.sesi502_cltype_name;
			TransportType = sESSION_INFO_4.sesi502_transport;
			num = (int)sESSION_INFO_4.sesi502_user_flags;
			break;
		}
		case SessionInfoLevel.Info10:
		{
			NativeMethods.SESSION_INFO_10 sESSION_INFO_3 = (NativeMethods.SESSION_INFO_10)structure;
			NetName = sESSION_INFO_3.sesi10_cname;
			UserName = sESSION_INFO_3.sesi10_username;
			ActiveTime = TimeSpan.FromSeconds((int)sESSION_INFO_3.sesi10_time);
			IdleTime = TimeSpan.FromSeconds((int)sESSION_INFO_3.sesi10_idle_time);
			break;
		}
		case SessionInfoLevel.Info0:
			NetName = ((NativeMethods.SESSION_INFO_0)structure).sesi0_cname;
			break;
		case SessionInfoLevel.Info1:
		{
			NativeMethods.SESSION_INFO_1 sESSION_INFO_2 = (NativeMethods.SESSION_INFO_1)structure;
			NetName = sESSION_INFO_2.sesi1_cname;
			UserName = sESSION_INFO_2.sesi1_username;
			OpenedResources = (int)sESSION_INFO_2.sesi1_num_opens;
			ActiveTime = TimeSpan.FromSeconds((int)sESSION_INFO_2.sesi1_time);
			IdleTime = TimeSpan.FromSeconds((int)sESSION_INFO_2.sesi1_idle_time);
			num = (int)sESSION_INFO_2.sesi1_user_flags;
			break;
		}
		case SessionInfoLevel.Info2:
		{
			NativeMethods.SESSION_INFO_2 sESSION_INFO_ = (NativeMethods.SESSION_INFO_2)structure;
			NetName = sESSION_INFO_.sesi2_cname;
			UserName = sESSION_INFO_.sesi2_username;
			OpenedResources = (int)sESSION_INFO_.sesi2_num_opens;
			ActiveTime = TimeSpan.FromSeconds((int)sESSION_INFO_.sesi2_time);
			ClientType = sESSION_INFO_.sesi2_cltype_name;
			num = (int)sESSION_INFO_.sesi2_user_flags;
			break;
		}
		}
		HostName = hostName;
		SessionLevel = sessionLevel;
		GuestSession = num == 1;
		EncryptedSession = !GuestSession && num != 2;
	}

	public override string ToString()
	{
		return HostName;
	}
}
