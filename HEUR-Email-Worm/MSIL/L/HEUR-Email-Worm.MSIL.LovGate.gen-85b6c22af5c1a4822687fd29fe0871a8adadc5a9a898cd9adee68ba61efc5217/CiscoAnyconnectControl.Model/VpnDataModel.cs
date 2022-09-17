using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;

namespace CiscoAnyconnectControl.Model;

[Serializable]
public class VpnDataModel : INotifyPropertyChanged
{
	private string _username = "username";

	private string _address = "vpn.example.com";

	private string _password = "";

	private string _group = null;

	private int _groupId = 0;

	public string Address
	{
		get
		{
			return _address;
		}
		set
		{
			if (!VpnDataModel.smethod_0(_address, value))
			{
				_address = value;
				OnPropertyChanged();
			}
		}
	}

	public string Username
	{
		get
		{
			return _username;
		}
		set
		{
			if (!VpnDataModel.smethod_0(_username, value))
			{
				_username = value;
				OnPropertyChanged();
			}
		}
	}

	public string Password
	{
		get
		{
			return _password;
		}
		set
		{
			if (!VpnDataModel.smethod_0(_password, value))
			{
				_password = value;
				OnPropertyChanged();
			}
		}
	}

	public string Group
	{
		get
		{
			return _group;
		}
		set
		{
			if (!VpnDataModel.smethod_0(_group, value))
			{
				_group = value;
				OnPropertyChanged();
			}
		}
	}

	public int GroupId
	{
		get
		{
			return _groupId;
		}
		set
		{
			if (_groupId != value)
			{
				_groupId = value;
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
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)VpnDataModel.smethod_1((Delegate)propertyChangedEventHandler2, (Delegate)value);
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
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)VpnDataModel.smethod_2((Delegate)propertyChangedEventHandler2, (Delegate)value);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
	}

	[NotifyPropertyChangedInvocator]
	protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
		this.PropertyChanged?.Invoke(this, VpnDataModel.smethod_3(propertyName));
	}

	static bool smethod_0(string string_0, string string_1)
	{
		return string_0 == string_1;
	}

	static Delegate smethod_1(Delegate delegate_0, Delegate delegate_1)
	{
		return Delegate.Combine(delegate_0, delegate_1);
	}

	static Delegate smethod_2(Delegate delegate_0, Delegate delegate_1)
	{
		return Delegate.Remove(delegate_0, delegate_1);
	}

	static PropertyChangedEventArgs smethod_3(string string_0)
	{
		return new PropertyChangedEventArgs(string_0);
	}
}
