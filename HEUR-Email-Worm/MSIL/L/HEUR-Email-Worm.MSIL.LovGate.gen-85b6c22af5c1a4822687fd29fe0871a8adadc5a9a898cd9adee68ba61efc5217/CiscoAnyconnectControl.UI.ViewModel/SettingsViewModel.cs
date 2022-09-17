using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using CiscoAnyconnectControl.Model;
using CiscoAnyconnectControl.UI.Command;

namespace CiscoAnyconnectControl.UI.ViewModel;

internal class SettingsViewModel : INotifyPropertyChanged
{
	public RelayCommand CommandSelectCiscoCli { get; private set; }

	public RelayCommand CommandSaveToPersistentStorage { get; private set; }

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
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)SettingsViewModel.smethod_4((Delegate)propertyChangedEventHandler2, (Delegate)value);
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
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)SettingsViewModel.smethod_5((Delegate)propertyChangedEventHandler2, (Delegate)value);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
	}

	private void SettingsModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
	{
		if (SettingsViewModel.smethod_3(SettingsViewModel.smethod_2(SettingsViewModel.smethod_0((object)this), SettingsViewModel.smethod_1(e)), (PropertyInfo)null))
		{
			OnPropertyChanged(SettingsViewModel.smethod_1(e));
		}
	}

	[NotifyPropertyChangedInvocator]
	protected virtual void OnPropertyChanged(string propertyName = null)
	{
		this.PropertyChanged?.Invoke(this, SettingsViewModel.smethod_6(propertyName));
	}

	static Type smethod_0(object object_0)
	{
		return object_0.GetType();
	}

	static string smethod_1(PropertyChangedEventArgs propertyChangedEventArgs_0)
	{
		return propertyChangedEventArgs_0.PropertyName;
	}

	static PropertyInfo smethod_2(Type type_0, string string_0)
	{
		return type_0.GetProperty(string_0);
	}

	static bool smethod_3(PropertyInfo propertyInfo_0, PropertyInfo propertyInfo_1)
	{
		return propertyInfo_0 != propertyInfo_1;
	}

	static Delegate smethod_4(Delegate delegate_0, Delegate delegate_1)
	{
		return Delegate.Combine(delegate_0, delegate_1);
	}

	static Delegate smethod_5(Delegate delegate_0, Delegate delegate_1)
	{
		return Delegate.Remove(delegate_0, delegate_1);
	}

	static PropertyChangedEventArgs smethod_6(string string_0)
	{
		return new PropertyChangedEventArgs(string_0);
	}
}
