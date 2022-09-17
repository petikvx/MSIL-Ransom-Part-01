using System;

namespace CiscoAnyconnectControl.UI.Utility;

internal interface I_OSUtil
{
	event EventHandler TrayExitClick;

	event EventHandler TrayIconDoubleClick;

	bool AddUiToSystemStart();

	bool RemoveUiFromSystemStart();

	void ShowTrayIcon();

	void HideTrayIcon();

	void DisableCiscoAutostart();

	void RestoreCiscoAutostart();

	bool IsCiscoAutostartEnabled();

	bool IsElevatedProcess();
}
