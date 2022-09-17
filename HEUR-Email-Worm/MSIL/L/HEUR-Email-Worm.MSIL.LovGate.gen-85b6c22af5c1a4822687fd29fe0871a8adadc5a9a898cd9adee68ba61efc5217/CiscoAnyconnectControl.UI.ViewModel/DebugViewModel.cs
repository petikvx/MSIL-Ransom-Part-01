using System.Security.Principal;
using System.Windows;
using CiscoAnyconnectControl.UI.Command;
using CiscoAnyconnectControl.Utility;

namespace CiscoAnyconnectControl.UI.ViewModel;

internal class DebugViewModel
{
	public RelayCommand OpenExplorerInProcDir => new RelayCommand(() => true, delegate
	{
		_003C_003Ec.smethod_0(Util.AssemblyDirectory);
	});

	public RelayCommand RestartServiceCommand => new RelayCommand(() => true, delegate
	{
		IsAdministrator();
	});

	public RelayCommand StopServiceCommand => new RelayCommand(() => true, delegate
	{
		IsAdministrator();
	});

	public RelayCommand StartServiceCommand => new RelayCommand(() => true, delegate
	{
		IsAdministrator();
	});

	private static bool IsAdministrator()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		WindowsIdentity windowsIdentity_ = DebugViewModel.smethod_0();
		WindowsPrincipal windowsPrincipal_ = DebugViewModel.smethod_1(windowsIdentity_);
		bool result;
		if (!(result = DebugViewModel.smethod_2(windowsPrincipal_, WindowsBuiltInRole.Administrator)))
		{
			DebugViewModel.smethod_3("This process isnt started as admin, but is required for this command.");
		}
		return result;
	}

	static WindowsIdentity smethod_0()
	{
		return WindowsIdentity.GetCurrent();
	}

	static WindowsPrincipal smethod_1(WindowsIdentity windowsIdentity_0)
	{
		return new WindowsPrincipal(windowsIdentity_0);
	}

	static bool smethod_2(WindowsPrincipal windowsPrincipal_0, WindowsBuiltInRole windowsBuiltInRole_0)
	{
		return windowsPrincipal_0.IsInRole(windowsBuiltInRole_0);
	}

	static MessageBoxResult smethod_3(string string_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_0);
	}
}
