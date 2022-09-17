#define TRACE
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

namespace CiscoAnyconnectControl.Model;

public class VpnStatusModel : IDisposable, INotifyPropertyChanged
{
	public class GroupEventArgs : EventArgs
	{
		public List<string> AvailableGroups;

		public string SelectedGroup { get; set; } = null;


		public GroupEventArgs(List<string> availableGroups)
		{
			AvailableGroups = availableGroups;
		}
	}

	public enum NoticeType
	{
		Error,
		Warning,
		Info,
		Status
	}

	public class NoticeEventArgs : EventArgs
	{
		public string Notice { get; set; }

		public NoticeType NoticeType { get; set; }

		public NoticeEventArgs(string notice, NoticeType noticeType)
		{
			Notice = notice;
			NoticeType = noticeType;
		}
	}

	public enum VpnStatus
	{
		Disconnected,
		Connecting,
		Connected,
		Disconnecting,
		Reconnecting,
		Pausing,
		Paused,
		SsoPolling,
		Unknown
	}

	private class VpnApiEventListener
	{
		private readonly VpnStatusModel _model;

		public object VPNStatsTag { get; private set; }

		public VpnApiEventListener(VpnStatusModel model)
		{
			_model = model;
		}

		public void VpnBannerNotification(string strBannerMessage)
		{
			VpnApiEventListener.smethod_1(VpnApiEventListener.smethod_0("VpnBannerNotification: ", strBannerMessage));
			_model.Message = strBannerMessage;
		}

		public void VpnExitNotification(string strExitMessage, int exitCode)
		{
			VpnApiEventListener.smethod_3(VpnApiEventListener.smethod_2("VpnExitNotification: '{0}' exit code: {1}", (object)strExitMessage, (object)exitCode));
		}

		public void VpnServiceReadyNotification()
		{
			VpnApiEventListener.smethod_3("VpnServiceReadyNotification");
		}

		public void VpnUserPromptNotification(IConnectPromptInfo pConnectPromptInfo)
		{
		}

		public void VpnWebLaunchHostNotification(string strActiveHost)
		{
			VpnApiEventListener.smethod_3(VpnApiEventListener.smethod_0("VpnWebLaunchHostNotification not implemented: ", strActiveHost));
		}

		public void VpnEventAvailableNotification()
		{
			VpnApiEventListener.smethod_3("VpnEventAvailableNotification not implemented ... trying VpnApi.ProcessEvents()");
		}

		public void VpnCertBlockedNotification(string strUntrustedServer)
		{
			VpnApiEventListener.smethod_3(VpnApiEventListener.smethod_0("VpnCertBlockedNotification: ", strUntrustedServer));
		}

		static string smethod_0(string string_0, string string_1)
		{
			return string_0 + string_1;
		}

		static void smethod_1(string string_0)
		{
			Trace.TraceInformation(string_0);
		}

		static string smethod_2(string string_0, object object_0, object object_1)
		{
			return string.Format(string_0, object_0, object_1);
		}

		static void smethod_3(string string_0)
		{
			Trace.TraceError(string_0);
		}
	}

	private static Lazy<VpnStatusModel> _instance = new Lazy<VpnStatusModel>(() => new VpnStatusModel());

	private VpnStatus _status = VpnStatus.Unknown;

	private string _message = null;

	private TimeSpan? _timeConnected = null;

	private VpnDataModel _connectData;

	public static VpnStatusModel Instance => _instance.Value;

	public VpnStatus Status
	{
		get
		{
			return _status;
		}
		set
		{
			if (_status != value)
			{
				_status = value;
				if (value == VpnStatus.Disconnected)
				{
					TimeConnected = null;
				}
				OnPropertyChanged();
			}
		}
	}

	public TimeSpan? TimeConnected
	{
		get
		{
			if (Status == VpnStatus.Connected || Status == VpnStatus.Disconnecting)
			{
				return _timeConnected;
			}
			return null;
		}
		set
		{
			if (value != _timeConnected)
			{
				_timeConnected = value;
				OnPropertyChanged();
			}
		}
	}

	public string Message
	{
		get
		{
			return _message;
		}
		set
		{
			if (!VpnStatusModel.smethod_2(_message, value))
			{
				_message = value;
				OnPropertyChanged();
			}
		}
	}

	public event EventHandler<NoticeEventArgs> Notice
	{
		[CompilerGenerated]
		add
		{
			EventHandler<NoticeEventArgs> eventHandler = this.Notice;
			EventHandler<NoticeEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<NoticeEventArgs> value2 = (EventHandler<NoticeEventArgs>)VpnStatusModel.smethod_3((Delegate)eventHandler2, (Delegate)value);
				eventHandler = Interlocked.CompareExchange(ref this.Notice, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<NoticeEventArgs> eventHandler = this.Notice;
			EventHandler<NoticeEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<NoticeEventArgs> value2 = (EventHandler<NoticeEventArgs>)VpnStatusModel.smethod_4((Delegate)eventHandler2, (Delegate)value);
				eventHandler = Interlocked.CompareExchange(ref this.Notice, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<GroupEventArgs> GroupRequested
	{
		[CompilerGenerated]
		add
		{
			EventHandler<GroupEventArgs> eventHandler = this.GroupRequested;
			EventHandler<GroupEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GroupEventArgs> value2 = (EventHandler<GroupEventArgs>)VpnStatusModel.smethod_3((Delegate)eventHandler2, (Delegate)value);
				eventHandler = Interlocked.CompareExchange(ref this.GroupRequested, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<GroupEventArgs> eventHandler = this.GroupRequested;
			EventHandler<GroupEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GroupEventArgs> value2 = (EventHandler<GroupEventArgs>)VpnStatusModel.smethod_4((Delegate)eventHandler2, (Delegate)value);
				eventHandler = Interlocked.CompareExchange(ref this.GroupRequested, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)VpnStatusModel.smethod_3((Delegate)propertyChangedEventHandler2, (Delegate)value);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)VpnStatusModel.smethod_4((Delegate)propertyChangedEventHandler2, (Delegate)value);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
	}

	private VpnStatusModel()
	{
	}

	public void Connect(VpnDataModel vpnData)
	{
		_connectData = vpnData;
		try
		{
		}
		catch (Exception exception_)
		{
			OnNotice(VpnStatusModel.smethod_1("Error connecting to VPN, you probybly need to restart the program or hit the debug menu.\n", VpnStatusModel.smethod_0(exception_)), NoticeType.Error);
		}
	}

	public void Disconnect()
	{
	}

	public virtual void OnNotice(string notice, NoticeType noticeType)
	{
		this.Notice?.Invoke(this, new NoticeEventArgs(notice, noticeType));
	}

	private string OnGroupRequested(List<string> availableGroups)
	{
		GroupEventArgs groupEventArgs = new GroupEventArgs(availableGroups);
		this.GroupRequested?.Invoke(this, groupEventArgs);
		return groupEventArgs.SelectedGroup;
	}

	[NotifyPropertyChangedInvocator]
	protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
		this.PropertyChanged?.Invoke(this, VpnStatusModel.smethod_5(propertyName));
	}

	public void Dispose()
	{
	}

	static string smethod_0(Exception exception_0)
	{
		return exception_0.Message;
	}

	static string smethod_1(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static bool smethod_2(string string_0, string string_1)
	{
		return string_0 == string_1;
	}

	static Delegate smethod_3(Delegate delegate_0, Delegate delegate_1)
	{
		return Delegate.Combine(delegate_0, delegate_1);
	}

	static Delegate smethod_4(Delegate delegate_0, Delegate delegate_1)
	{
		return Delegate.Remove(delegate_0, delegate_1);
	}

	static PropertyChangedEventArgs smethod_5(string string_0)
	{
		return new PropertyChangedEventArgs(string_0);
	}
}
