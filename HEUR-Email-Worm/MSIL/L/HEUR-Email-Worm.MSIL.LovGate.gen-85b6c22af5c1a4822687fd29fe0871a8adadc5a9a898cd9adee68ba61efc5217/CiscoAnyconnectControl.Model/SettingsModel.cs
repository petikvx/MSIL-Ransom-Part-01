using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;

namespace CiscoAnyconnectControl.Model;

[Serializable]
public class SettingsModel : INotifyPropertyChanged
{
	private bool _savePassword = true;

	private bool _connectOnSystemStartup = true;

	private bool _reconnectOnConnectionLoss = true;

	private bool _startGuiOnLogon = false;

	private bool _notifyAfterX = true;

	private int _notifyAfterHours = 9;

	private bool _closeToTray;

	public bool SavePassword
	{
		get
		{
			return _savePassword;
		}
		set
		{
			if (_savePassword != value)
			{
				_savePassword = value;
				OnPropertyChanged();
			}
		}
	}

	public bool ConnectOnSystemStartup
	{
		get
		{
			return _connectOnSystemStartup;
		}
		set
		{
			if (_connectOnSystemStartup != value)
			{
				_connectOnSystemStartup = value;
				OnPropertyChanged();
			}
		}
	}

	public bool ReconnectOnConnectionLoss
	{
		get
		{
			return _reconnectOnConnectionLoss;
		}
		set
		{
			if (_reconnectOnConnectionLoss != value)
			{
				_reconnectOnConnectionLoss = value;
				OnPropertyChanged();
			}
		}
	}

	public bool StartGuiOnLogon
	{
		get
		{
			return _startGuiOnLogon;
		}
		set
		{
			if (_startGuiOnLogon != value)
			{
				_startGuiOnLogon = value;
				OnPropertyChanged();
			}
		}
	}

	public bool NotifyAfterX
	{
		get
		{
			return _notifyAfterX;
		}
		set
		{
			if (_notifyAfterX != value)
			{
				_notifyAfterX = value;
				OnPropertyChanged();
			}
		}
	}

	public int NotifyAfterHours
	{
		get
		{
			return _notifyAfterHours;
		}
		set
		{
			if (_notifyAfterHours != value)
			{
				_notifyAfterHours = value;
				OnPropertyChanged();
			}
		}
	}

	public bool CloseToTray
	{
		get
		{
			return _closeToTray;
		}
		set
		{
			if (_closeToTray != value)
			{
				_closeToTray = value;
				OnPropertyChanged();
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
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)SettingsModel.smethod_0((Delegate)propertyChangedEventHandler2, (Delegate)value);
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
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)SettingsModel.smethod_1((Delegate)propertyChangedEventHandler2, (Delegate)value);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
	}

	[NotifyPropertyChangedInvocator]
	protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
		this.PropertyChanged?.Invoke(this, SettingsModel.smethod_2(propertyName));
	}

	static Delegate smethod_0(Delegate delegate_0, Delegate delegate_1)
	{
		return Delegate.Combine(delegate_0, delegate_1);
	}

	static Delegate smethod_1(Delegate delegate_0, Delegate delegate_1)
	{
		return Delegate.Remove(delegate_0, delegate_1);
	}

	static PropertyChangedEventArgs smethod_2(string string_0)
	{
		return new PropertyChangedEventArgs(string_0);
	}
}
