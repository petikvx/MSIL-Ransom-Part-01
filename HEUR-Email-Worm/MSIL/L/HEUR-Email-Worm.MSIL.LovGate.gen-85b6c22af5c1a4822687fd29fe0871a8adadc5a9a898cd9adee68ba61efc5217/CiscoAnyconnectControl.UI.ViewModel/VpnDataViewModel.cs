using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using CiscoAnyconnectControl.Model;
using CiscoAnyconnectControl.UI.Command;

namespace CiscoAnyconnectControl.UI.ViewModel;

internal class VpnDataViewModel : INotifyPropertyChanged
{
	private string _address = "vpn.example.com";

	private string _username = "username";

	private string _password = "";

	private string _group = null;

	private int _groupId = 0;

	private VpnDataModel Model { get; set; }

	public string Address
	{
		get
		{
			return _address;
		}
		set
		{
			if (!VpnDataViewModel.smethod_0(_address, value))
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
			if (!VpnDataViewModel.smethod_0(_username, value))
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
			if (!VpnDataViewModel.smethod_0(_password, value))
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
			return VpnDataViewModel.smethod_1("({0}) {1}", (object)_groupId, (object)_group);
		}
		set
		{
			if (!VpnDataViewModel.smethod_0(_group, value))
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
				OnPropertyChanged("Group");
				OnPropertyChanged();
			}
		}
	}

	public SecureString SecurePassword
	{
		set
		{
			string password = "";
			if (value != null)
			{
				try
				{
					IntPtr intptr_ = VpnDataViewModel.smethod_2(value);
					try
					{
						password = VpnDataViewModel.smethod_3(intptr_);
					}
					finally
					{
						VpnDataViewModel.smethod_4(intptr_);
					}
				}
				finally
				{
					if (value != null)
					{
						VpnDataViewModel.smethod_5((IDisposable)value);
					}
				}
			}
			Password = password;
		}
	}

	public RelayCommand SaveToModel { get; private set; }

	public RelayCommand RemoveGroup { get; private set; }

	public bool IsRemoveProfileButtonEnabled => Group != null;

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
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)VpnDataViewModel.smethod_6((Delegate)propertyChangedEventHandler2, (Delegate)value);
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
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)VpnDataViewModel.smethod_7((Delegate)propertyChangedEventHandler2, (Delegate)value);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
	}

	public VpnDataViewModel()
	{
		Address = Model.Address;
		Username = Model.Username;
		Password = Model.Password;
		Group = Model.Group;
		GroupId = Model.GroupId;
		Model.PropertyChanged += Model_PropertyChanged;
		SetupCommands();
	}

	private void Model_PropertyChanged(object sender, PropertyChangedEventArgs e)
	{
	}

	private void SetupCommands()
	{
		SaveToModel = new RelayCommand(DataChanged, delegate
		{
			Model.Address = Address;
			Model.Username = _username;
			Model.Group = _group;
			Model.GroupId = _groupId;
		});
		RemoveGroup = new RelayCommand(() => IsRemoveProfileButtonEnabled, delegate
		{
			Group = null;
			Model.GroupId = 0;
			Model.Group = null;
		});
	}

	private bool DataChanged()
	{
		return true;
	}

	[NotifyPropertyChangedInvocator]
	protected virtual void OnPropertyChanged(string propertyName = null)
	{
		this.PropertyChanged?.Invoke(this, VpnDataViewModel.smethod_8(propertyName));
	}

	static bool smethod_0(string string_0, string string_1)
	{
		return string_0 == string_1;
	}

	static string smethod_1(string string_0, object object_0, object object_1)
	{
		return string.Format(string_0, object_0, object_1);
	}

	static IntPtr smethod_2(SecureString secureString_0)
	{
		return Marshal.SecureStringToBSTR(secureString_0);
	}

	static string smethod_3(IntPtr intptr_0)
	{
		return Marshal.PtrToStringBSTR(intptr_0);
	}

	static void smethod_4(IntPtr intptr_0)
	{
		Marshal.ZeroFreeBSTR(intptr_0);
	}

	static void smethod_5(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Delegate smethod_6(Delegate delegate_0, Delegate delegate_1)
	{
		return Delegate.Combine(delegate_0, delegate_1);
	}

	static Delegate smethod_7(Delegate delegate_0, Delegate delegate_1)
	{
		return Delegate.Remove(delegate_0, delegate_1);
	}

	static PropertyChangedEventArgs smethod_8(string string_0)
	{
		return new PropertyChangedEventArgs(string_0);
	}
}
