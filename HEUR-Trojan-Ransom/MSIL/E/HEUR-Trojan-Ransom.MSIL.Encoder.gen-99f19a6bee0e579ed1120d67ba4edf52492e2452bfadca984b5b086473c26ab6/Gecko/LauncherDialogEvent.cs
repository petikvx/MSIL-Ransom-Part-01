using System;

namespace Gecko;

public class LauncherDialogEvent : EventArgs
{
	public string Url
	{
		get
		{
			nsIURI sourceAttribute = HelperAppLauncher.GetSourceAttribute();
			return nsString.Get(sourceAttribute.GetSpecAttribute);
		}
	}

	public string Filename
	{
		get
		{
			nsAString nsAString2 = new nsAString();
			HelperAppLauncher.GetSuggestedFileNameAttribute(nsAString2);
			return nsAString2.ToString();
		}
	}

	public nsIMIMEInfo Mime => HelperAppLauncher.GetMIMEInfoAttribute();

	public nsIWebNavigation WebNavigation { get; private set; }

	public nsIHelperAppLauncher HelperAppLauncher { get; private set; }

	public void Cancel()
	{
		HelperAppLauncher.Cancel(-2142568446);
	}

	public void Navigate(string Url)
	{
		WebNavigation.LoadURI(Url, 0u, null, null, null);
	}

	public LauncherDialogEvent(nsIHelperAppLauncher aLauncher, nsISupports aWindowContext, uint aReason)
	{
		HelperAppLauncher = aLauncher;
		WebNavigation = aWindowContext as nsIWebNavigation;
	}
}
