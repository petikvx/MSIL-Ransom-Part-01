using System.ComponentModel;
using CiscoAnyconnectControl.UI.Command;

namespace CiscoAnyconnectControl.UI.ViewModel;

internal interface IVpnStatusViewModel
{
	bool ActionButtonEnabled { get; }

	string ActionButtonText { get; }

	string Color { get; }

	RelayCommand CurrentActionCommand { get; }

	string Message { get; }

	string Status { get; }

	string TimeConnected { get; }

	event PropertyChangedEventHandler PropertyChanged;
}
