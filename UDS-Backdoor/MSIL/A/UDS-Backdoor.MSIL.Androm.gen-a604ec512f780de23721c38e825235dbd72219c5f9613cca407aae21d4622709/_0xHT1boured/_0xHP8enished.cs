using System;
using System.Windows.Forms;
using EnvDTE;
using Microsoft.Cct.Services.AzureProjectInternals;
using Microsoft.Cct.Services.Notifications;
using Microsoft.VSDesigner.ServerExplorer;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Shell.Interop;
using _0xHHa8kamore;

namespace _0xHT1boured;

internal static class _0xHP8enished
{
	public static INestedHierarchyNodeSite _0xHStin2ier(this INodeSite _0xHLic6ens)
	{
		if (_0xHLic6ens == null)
		{
			return null;
		}
		return (INestedHierarchyNodeSite)(object)((_0xHLic6ens is INestedHierarchyNodeSite) ? _0xHLic6ens : null);
	}

	public static INotificationService _0xHBrandl2ngs(this INodeSite _0xHAn3le)
	{
		object service = _0xHAn3le.GetService(typeof(INotificationService));
		return (INotificationService)((service is INotificationService) ? service : null);
	}

	public static IAzureProjectInternalsService _0xHSuperablene88e8(this INodeSite _0xHIn3elicitous)
	{
		object service = _0xHIn3elicitous.GetService(typeof(IAzureProjectInternalsService));
		return (IAzureProjectInternalsService)((service is IAzureProjectInternalsService) ? service : null);
	}

	public static IVsUIShell _0xHP3aties(this INodeSite _0xHRecep7ion)
	{
		return _0xHRecep7ion._0xHSubdia5ects<IVsUIShell, SVsUIShell>(Resources_Common.ErrorRetrievingCommonService);
	}

	public static T _0xHInelas7ic<T>(this INodeSite _0xHE4dplay, string _0xHEp2od)
	{
		return (T)(_0xHE4dplay.GetService(typeof(T)) ?? throw new InvalidOperationException(_0xHEp2od));
	}

	public static T _0xHSubdia5ects<T, U>(this INodeSite _0xHHaphazar8ness, string _0xH2oachman)
	{
		return (T)(_0xHHaphazar8ness.GetService(typeof(U)) ?? throw new InvalidOperationException(_0xH2oachman));
	}

	public static bool _0xHJ5w5ll5ry(this INodeSite _0xHM0n0carp)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Invalid comparison between Unknown and I4
		IAzureProjectInternalsService val = _0xHM0n0carp._0xHSuperablene88e8();
		if (val != null && !(val.GetLatestInstalledAzureToolsVersion() == null))
		{
			return true;
		}
		if ((int)_0xHM0n0carp.ShowMessageBox(Resources_Common.MissingTools, (MessageBoxButtons)1, (MessageBoxIcon)16) == 1)
		{
			val.BrowseToDownloadTools();
		}
		return false;
	}

	public static bool _0xHSto6ing(this INodeSite _0xH7enim)
	{
		object service = _0xH7enim.GetService(typeof(IVsExtensibility));
		object obj = ((service is IVsExtensibility3) ? service : null) ?? throw new InvalidOperationException();
		int num = 0;
		ErrorHandler.ThrowOnFailure(((IVsExtensibility3)obj).IsInAutomationFunction(ref num));
		return num != 0;
	}
}
