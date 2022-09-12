using System;
using System.Runtime.InteropServices;

namespace Gecko;

public class LauncherDialog : nsIHelperAppLauncherDialog
{
	public static event EventHandler<LauncherDialogEvent> Download;

	[DllImport("xul", CharSet = CharSet.Ansi)]
	private static extern int NS_NewNativeLocalFile(nsACString path, bool followLinks, [MarshalAs(UnmanagedType.IUnknown)] out object result);

	public nsILocalFile PromptForSaveToFile(nsIHelperAppLauncher aLauncher, nsISupports aWindowContext, string aDefaultFileName, string aSuggestedFileExtension, bool aForcePrompt)
	{
		aLauncher.Cancel(-2142568446);
		return null;
	}

	public void PromptForSaveToFileAsync(nsIHelperAppLauncher aLauncher, nsISupports aWindowContext, string aDefaultFileName, string aSuggestedFileExtension, bool aForcePrompt)
	{
		throw new NotImplementedException();
	}

	public void Show(nsIHelperAppLauncher aLauncher, nsISupports aWindowContext, uint aReason)
	{
		if (LauncherDialog.Download != null)
		{
			LauncherDialog.Download(this, new LauncherDialogEvent(aLauncher, aWindowContext, aReason));
		}
		else
		{
			aLauncher.Cancel(-2142568446);
		}
	}
}
