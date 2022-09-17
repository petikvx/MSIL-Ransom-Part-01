using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using CiscoAnyconnectControl.Model;
using CiscoAnyconnectControl.UI.Command;

namespace CiscoAnyconnectControl.UI.ViewModel;

internal class VpnStatusViewModel : IVpnStatusViewModel, INotifyPropertyChanged
{
	private DateTime _connectLastClicked;

	public string TimeConnected
	{
		get
		{
			if (CurrStatus.Status == VpnStatusModel.VpnStatus.Connected || CurrStatus.Status == VpnStatusModel.VpnStatus.Disconnecting)
			{
				return (!CurrStatus.TimeConnected.HasValue) ? "loading ..." : VpnStatusViewModel.smethod_0("({0:h\\:mm\\:ss})", (object)CurrStatus.TimeConnected);
			}
			return "";
		}
	}

	private VpnStatusModel CurrStatus { get; set; }

	public string Color
	{
		get
		{
			switch (CurrStatus.Status)
			{
			case VpnStatusModel.VpnStatus.Disconnected:
				return "red";
			case VpnStatusModel.VpnStatus.Connected:
				return "green";
			case VpnStatusModel.VpnStatus.Connecting:
			case VpnStatusModel.VpnStatus.Disconnecting:
			case VpnStatusModel.VpnStatus.Reconnecting:
				return "yellow";
			default:
				return "orange";
			case VpnStatusModel.VpnStatus.Unknown:
				return "purple";
			}
		}
	}

	public string Status => CurrStatus.Status switch
	{
		VpnStatusModel.VpnStatus.Disconnected => "Disconnected.", 
		VpnStatusModel.VpnStatus.Connecting => "Connecting ...", 
		VpnStatusModel.VpnStatus.Connected => "Connected.", 
		VpnStatusModel.VpnStatus.Disconnecting => "Disconnecting ...", 
		VpnStatusModel.VpnStatus.Reconnecting => "Reconnecting ...", 
		VpnStatusModel.VpnStatus.Unknown => "Not connected to backend ...", 
		_ => VpnStatusViewModel.smethod_0("Error ... {0} is not defined.", (object)CurrStatus.Status), 
	};

	public string Message => CurrStatus.Message ?? "No messages yet :(";

	public string ActionButtonText
	{
		get
		{
			switch (CurrStatus.Status)
			{
			case VpnStatusModel.VpnStatus.Disconnected:
				return "Connect";
			case VpnStatusModel.VpnStatus.Connecting:
				return "Connecting ...";
			case VpnStatusModel.VpnStatus.Disconnecting:
				return "Disconnecting ...";
			case VpnStatusModel.VpnStatus.Connected:
			case VpnStatusModel.VpnStatus.Reconnecting:
				return "Disconnect";
			default:
				return "Error ...";
			case VpnStatusModel.VpnStatus.Unknown:
				return "Not connected to backend ...";
			}
		}
	}

	public bool ActionButtonEnabled
	{
		get
		{
			switch (CurrStatus.Status)
			{
			default:
				return false;
			case VpnStatusModel.VpnStatus.Disconnected:
			case VpnStatusModel.VpnStatus.Connected:
			case VpnStatusModel.VpnStatus.Reconnecting:
			case VpnStatusModel.VpnStatus.Paused:
			case VpnStatusModel.VpnStatus.SsoPolling:
			case VpnStatusModel.VpnStatus.Unknown:
				return true;
			}
		}
	}

	private RelayCommand CommandConnectVpn { get; set; }

	private RelayCommand CommandDisconnectVpn { get; set; }

	public RelayCommand CurrentActionCommand
	{
		get
		{
			RelayCommand relayCommand = null;
			switch (CurrStatus.Status)
			{
			case VpnStatusModel.VpnStatus.Disconnected:
				return CommandConnectVpn;
			default:
				return RelayCommand.Empty;
			case VpnStatusModel.VpnStatus.Connected:
			case VpnStatusModel.VpnStatus.Reconnecting:
				return CommandDisconnectVpn;
			}
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
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)VpnStatusViewModel.smethod_3((Delegate)propertyChangedEventHandler2, (Delegate)value);
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
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)VpnStatusViewModel.smethod_4((Delegate)propertyChangedEventHandler2, (Delegate)value);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
	}

	public VpnStatusViewModel()
	{
		SetupCommands();
		CurrStatus = VpnStatusModel.Instance;
		CurrStatus.PropertyChanged += CurrStatus_PropertyChanged;
		CurrStatus.GroupRequested += CurrStatus_GroupRequested;
		CurrStatus.Notice += CurrStatus_Notice;
		_connectLastClicked = DateTime.MinValue;
	}

	private void CurrStatus_Notice(object sender, VpnStatusModel.NoticeEventArgs e)
	{
		_ = e.NoticeType;
	}

	private void CurrStatus_GroupRequested(object sender, VpnStatusModel.GroupEventArgs e)
	{
	}

	private void CurrStatus_PropertyChanged(object sender, PropertyChangedEventArgs e)
	{
		string text = VpnStatusViewModel.smethod_1(e);
		string string_ = text;
		if (!VpnStatusViewModel.smethod_2(string_, "Status"))
		{
			if (VpnStatusViewModel.smethod_2(string_, "Message"))
			{
				OnPropertyChanged(VpnStatusViewModel.smethod_1(e));
				OnPropertyChanged("ActionButtonEnabled");
			}
			else if (VpnStatusViewModel.smethod_2(string_, "TimeConnected"))
			{
				OnPropertyChanged("TimeConnected");
			}
		}
		else
		{
			OnPropertyChanged("Color");
			OnPropertyChanged("Status");
			OnPropertyChanged("ActionButtonText");
			OnPropertyChanged("ActionButtonEnabled");
			OnPropertyChanged("TimeConnected");
		}
	}

	private bool CanExecuteAction()
	{
		return ActionButtonEnabled;
	}

	private void SetupCommands()
	{
		CommandConnectVpn = new RelayCommand(CanExecuteAction, delegate
		{
		});
		CommandDisconnectVpn = new RelayCommand(CanExecuteAction, delegate
		{
			VpnStatusModel.Instance.Disconnect();
		});
	}

	[NotifyPropertyChangedInvocator]
	protected virtual void OnPropertyChanged(string propertyName = null)
	{
		this.PropertyChanged?.Invoke(this, VpnStatusViewModel.smethod_5(propertyName));
	}

	static string smethod_0(string string_0, object object_0)
	{
		return string.Format(string_0, object_0);
	}

	static string smethod_1(PropertyChangedEventArgs propertyChangedEventArgs_0)
	{
		return propertyChangedEventArgs_0.PropertyName;
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
