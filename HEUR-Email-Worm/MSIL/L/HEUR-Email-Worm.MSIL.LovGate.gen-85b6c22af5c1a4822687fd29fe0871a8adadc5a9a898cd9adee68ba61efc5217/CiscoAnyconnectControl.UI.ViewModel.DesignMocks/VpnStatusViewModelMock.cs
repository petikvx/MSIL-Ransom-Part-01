using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using CiscoAnyconnectControl.UI.Command;

namespace CiscoAnyconnectControl.UI.ViewModel.DesignMocks;

internal class VpnStatusViewModelMock : IVpnStatusViewModel
{
	public bool ActionButtonEnabled => true;

	public string ActionButtonText => "Connect";

	public string Color => "purple";

	public RelayCommand CurrentActionCommand => RelayCommand.Empty;

	public string Message => "This is a design mock.";

	public string Status => "DesignStatus";

	public string TimeConnected => "00:00:00";

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
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)VpnStatusViewModelMock.smethod_0((Delegate)propertyChangedEventHandler2, (Delegate)value);
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
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)VpnStatusViewModelMock.smethod_1((Delegate)propertyChangedEventHandler2, (Delegate)value);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
	}

	static Delegate smethod_0(Delegate delegate_0, Delegate delegate_1)
	{
		return Delegate.Combine(delegate_0, delegate_1);
	}

	static Delegate smethod_1(Delegate delegate_0, Delegate delegate_1)
	{
		return Delegate.Remove(delegate_0, delegate_1);
	}
}
