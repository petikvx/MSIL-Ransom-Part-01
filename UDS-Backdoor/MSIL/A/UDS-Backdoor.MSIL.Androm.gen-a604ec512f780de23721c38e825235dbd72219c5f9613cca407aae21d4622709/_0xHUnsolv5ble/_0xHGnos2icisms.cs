using System;
using System.Diagnostics;
using System.Security.Permissions;
using Microsoft.Cct.Services;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.OLE.Interop;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.VisualStudio.TextManager.Interop;
using Microsoft.VisualStudio.WindowsAzure;
using _0xH2ignifiers;
using _0xHEmba77assable;
using _0xHHa8kamore;
using _0xHS3ashed;

namespace _0xHUnsolv5ble;

internal static class _0xHGnos2icisms
{
	internal static void _0xHAdipo4ere(IServiceProvider _0xHPin2ricking, string _0xHTantamo3nt)
	{
		CommonShellUtilities.LaunchNonElevated(_0xHPin2ricking, _0xHTantamo3nt, (string)null, (string)null, (string)null, 1, (Action<IServiceProvider>)_0xHAn2mal);
	}

	internal static void _0xH3eracious(IServiceProvider _0xHShampoo5d, string _0xHMo3orcycle)
	{
		CommonShellUtilities.LaunchNonElevated(_0xHShampoo5d, _0xHMo3orcycle, (Action<IServiceProvider>)_0xHGr55s);
	}

	internal static void _0xH1jin(IServiceProvider _0xHLea6ed, string _0xH1ibroses, string _0xHOver7lay)
	{
		CommonShellUtilities.LaunchNonElevated(_0xHLea6ed, _0xH1ibroses, _0xHOver7lay, (Action<IServiceProvider>)_0xHGr55s);
	}

	[SecurityPermission(SecurityAction.Demand)]
	internal static bool _0xHWa22ailer(string _0xHMesothorac0c)
	{
		try
		{
			Process.Start(new ProcessStartInfo(_0xHMesothorac0c)
			{
				Verb = "explore"
			});
		}
		catch (Exception)
		{
			return false;
		}
		return true;
	}

	internal static void _0xHWart3ogs(IServiceProvider _0xHZ3ll3onth, Uri _0xHUn4cted, bool _0xHBi7)
	{
		CommonShellUtilities.BrowseToUrl(_0xHZ3ll3onth, _0xHUn4cted, (Action<IServiceProvider>)_0xHGr55s, _0xHBi7);
	}

	internal static void _0xHV2loni2(IServiceProvider _0xHR2allocat2, string _0xHBida8kas, bool _0xHSee2sucke2s)
	{
		CommonShellUtilities.BrowseToUrl(_0xHR2allocat2, _0xHBida8kas, (Action<IServiceProvider>)_0xHGr55s, _0xHSee2sucke2s);
	}

	internal static void _0xHCe1tuple(object sender, EventArgs e)
	{
		Task val = (Task)((sender is Task) ? sender : null);
		if (val == null)
		{
			throw _0xHL1mniscus._0xHEx2viates(new ArgumentException("Sender is not a Microsoft.VisualStudio.Shell.Task", "sender"));
		}
		if (string.IsNullOrEmpty(val.get_Document()))
		{
			return;
		}
		IVsUIShellOpenDocument val2 = _0xHSe4tu4let._0xHTug5ik<IVsUIShellOpenDocument, SVsUIShellOpenDocument>();
		if (val2 == null)
		{
			return;
		}
		Guid lOGVIEWID_Code = VSConstants.LOGVIEWID_Code;
		IServiceProvider val3 = default(IServiceProvider);
		IVsUIHierarchy val4 = default(IVsUIHierarchy);
		uint num = default(uint);
		IVsWindowFrame val5 = default(IVsWindowFrame);
		if (ErrorHandler.Failed(val2.OpenDocumentViaProject(val.get_Document(), ref lOGVIEWID_Code, ref val3, ref val4, ref num, ref val5)) || val5 == null)
		{
			return;
		}
		object obj = default(object);
		ErrorHandler.ThrowOnFailure(val5.GetProperty(-4004, ref obj));
		VsTextBuffer val6 = (VsTextBuffer)((obj is VsTextBuffer) ? obj : null);
		if (val6 == null)
		{
			IVsTextBufferProvider val7 = (IVsTextBufferProvider)((obj is IVsTextBufferProvider) ? obj : null);
			if (val7 != null)
			{
				IVsTextLines val8 = default(IVsTextLines);
				ErrorHandler.ThrowOnFailure(val7.GetTextBuffer(ref val8));
				val6 = (VsTextBuffer)(object)((val8 is VsTextBuffer) ? val8 : null);
				if (val6 == null)
				{
					return;
				}
			}
		}
		IVsTextManager val9 = _0xHSe4tu4let._0xHTug5ik<IVsTextManager, VsTextManagerClass>();
		if (val9 != null)
		{
			ErrorHandler.ThrowOnFailure(val9.NavigateToLineAndColumn((IVsTextBuffer)(object)val6, ref lOGVIEWID_Code, val.get_Line(), val.get_Column(), val.get_Line(), val.get_Column()));
		}
	}

	internal static void _0xHN5wsp5aks(IServiceProvider _0xHVa5iegato5s, __ACTIVITYLOG_ENTRYTYPE _0xHScu22er, string _0xHD1prav1)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected I4, but got Unknown
		if (_0xHVa5iegato5s != null)
		{
			IVsActivityLog service = ServiceProviderExtensions.GetService<IVsActivityLog, SVsActivityLog>(_0xHVa5iegato5s);
			if (service != null)
			{
				ErrorHandler.Failed(service.LogEntry((uint)(int)_0xHScu22er, Resources_Common.OfficialName, _0xHD1prav1));
			}
		}
	}

	private static void _0xHGr55s(IServiceProvider _0xHL2bbers)
	{
		_0xHCol8cky._0xHPai6ed(_0xHL2bbers, (WatError)223);
	}

	private static void _0xHAn2mal(IServiceProvider _0xHCo2d2pt2tions)
	{
		_0xHCol8cky._0xHPai6ed(_0xHCo2d2pt2tions, (WatError)244);
	}
}
