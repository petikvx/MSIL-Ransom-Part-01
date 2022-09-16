using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.OLE.Interop;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.VisualStudio.WindowsAzure;
using _0xH0ammock;
using _0xH2ignifiers;

namespace _0xHAcclaim6rs;

internal static class _0xHOvermatc0ing
{
	public static bool _0xHGallst7ne(IServiceProvider _0xHDe1ickers, string _0xHAbs8esses, out IVsHierarchy _0xHPresci0ds, out uint _0xHScu11lers, out object _0xHT8atim8s)
	{
		return _0xH2ae<object>(_0xHDe1ickers, _0xHAbs8esses, out _0xHPresci0ds, out _0xHScu11lers, out _0xHT8atim8s);
	}

	public static bool _0xH2ae<T>(IServiceProvider _0xH7reconcerted, string _0xHDispe0d, out IVsHierarchy _0xH8oils, out uint _0xH8inemas, out T _0xHFl7gless) where T : class
	{
		if (_0xH7reconcerted == null)
		{
			throw new ArgumentNullException("serviceProvider", "You must specify a serviceProvider.");
		}
		if (string.IsNullOrEmpty(_0xHDispe0d))
		{
			throw new ArgumentException("The document moniker wasn't set", "moniker");
		}
		IVsRunningDocumentTable service = ServiceProviderExtensions.GetService<IVsRunningDocumentTable, SVsRunningDocumentTable>(_0xH7reconcerted);
		if (service == null)
		{
			throw new InvalidOperationException();
		}
		_0xHFl7gless = null;
		IntPtr zero = IntPtr.Zero;
		try
		{
			uint num = default(uint);
			if (ErrorHandler.Succeeded(service.FindAndLockDocument(0u, _0xHDispe0d, ref _0xH8oils, ref _0xH8inemas, ref zero, ref num)) && zero != IntPtr.Zero)
			{
				object objectForIUnknown = Marshal.GetObjectForIUnknown(zero);
				if (!(objectForIUnknown is T))
				{
					throw new InvalidOperationException("Invalid document object associated with the document.");
				}
				_0xHFl7gless = objectForIUnknown as T;
				return true;
			}
			return false;
		}
		finally
		{
			if (zero != IntPtr.Zero)
			{
				Marshal.Release(zero);
			}
		}
	}

	public static void _0xHPhi5o5ogy(IServiceProvider _0xHEgoma8iacally, string _0xHLegalize0, string _0xHI5e5aps)
	{
		_0xHHepate6tomy(_0xHEgoma8iacally, _0xHLegalize0, _0xHI5e5aps, null, uint.MaxValue);
	}

	public static void _0xHHepate6tomy(IServiceProvider _0xHPaunchine55e5, string _0xHSolid6st, string _0xHWinge4, IVsHierarchy _0xHAdd3ces, uint _0xHA6azons)
	{
		if (_0xHPaunchine55e5 == null)
		{
			throw new ArgumentNullException("serviceProvider", "You must specify a serviceProvider.");
		}
		if (string.IsNullOrEmpty(_0xHSolid6st))
		{
			throw new ArgumentException("The document moniker wasn't set", "moniker");
		}
		if (string.IsNullOrEmpty(_0xHWinge4))
		{
			throw new ArgumentException("The new document moniker wasn't set", "newName");
		}
		IVsRunningDocumentTable service = ServiceProviderExtensions.GetService<IVsRunningDocumentTable, SVsRunningDocumentTable>(_0xHPaunchine55e5);
		if (service == null)
		{
			throw _0xHL1mniscus._0xHEx2viates(new InvalidOperationException());
		}
		if (!_0xHGallst7ne(_0xHPaunchine55e5, _0xHSolid6st, out var _, out var _, out var _))
		{
			return;
		}
		IntPtr intPtr = IntPtr.Zero;
		IntPtr ppv = VSConstants.HIERARCHY_DONTCHANGE;
		try
		{
			if (_0xHAdd3ces != null)
			{
				intPtr = Marshal.GetIUnknownForObject(_0xHAdd3ces);
				Guid iid = typeof(IVsHierarchy).GUID;
				Marshal.QueryInterface(intPtr, ref iid, out ppv);
			}
			ErrorHandler.ThrowOnFailure(service.RenameDocument(_0xHSolid6st, _0xHWinge4, ppv, _0xHA6azons));
		}
		finally
		{
			if (ppv != IntPtr.Zero && ppv != VSConstants.HIERARCHY_DONTCHANGE)
			{
				Marshal.Release(ppv);
			}
			if (intPtr != IntPtr.Zero)
			{
				Marshal.Release(intPtr);
			}
		}
	}

	public static void _0xHBall11ning(IServiceProvider _0xHG3eamier, string _0xHE6u, object _0xHEx0ostulated)
	{
		if (_0xHG3eamier == null)
		{
			throw new ArgumentNullException("site");
		}
		if (string.IsNullOrEmpty(_0xHE6u))
		{
			throw new ArgumentNullException("caption");
		}
		object? service = _0xHG3eamier.GetService(typeof(SVsUIShell));
		ErrorHandler.ThrowOnFailure(_0xHJ5lling((IVsUIShell)((service is IVsUIShell) ? service : null), _0xHEx0ostulated).SetProperty(-4001, (object)_0xHE6u));
	}

	public static IVsWindowFrame _0xHSaltli2e(string _0xHL4tting, uint _0xHEaste2ne2s, Guid _0xHFura6ose, string _0xHConcu33ion, object _0xHCat8olicoses)
	{
		if (string.IsNullOrEmpty(_0xHL4tting))
		{
			throw new ArgumentException("The document moniker wasn't set", "moniker");
		}
		if (_0xHCat8olicoses == null)
		{
			throw new ArgumentNullException("doc", "Document object must be specified when openning with a specific editor.");
		}
		IVsUIShellOpenDocument obj = ServiceProviderExtensions.GetService<IVsUIShellOpenDocument, SVsUIShellOpenDocument>((IServiceProvider)ServiceProvider.get_GlobalProvider()) ?? throw _0xHL1mniscus._0xHEx2viates(new InvalidOperationException());
		Guid empty = Guid.Empty;
		string text = null;
		IServiceProvider val = null;
		IVsUIHierarchy _0xHDr1bbly = null;
		uint _0xHTempest4o4sness = 0u;
		IVsWindowFrame val2 = null;
		ErrorHandler.ThrowOnFailure(obj.OpenDocumentViaProjectWithSpecific(_0xHL4tting, _0xHEaste2ne2s, ref _0xHFura6ose, text, ref empty, ref val, ref _0xHDr1bbly, ref _0xHTempest4o4sness, ref val2));
		return _0xHNut6tion((IServiceProvider)ServiceProvider.get_GlobalProvider(), 0u, _0xHDr1bbly, _0xHTempest4o4sness, _0xHL4tting, _0xHConcu33ion, _0xHFura6ose, _0xHCat8olicoses);
	}

	public static IVsWindowFrame _0xHNut6tion(IServiceProvider _0xHF0li0, uint _0xH2oris, IVsUIHierarchy _0xHDr1bbly, uint _0xHTempest4o4sness, string _0xHOs1ensorium, string _0xHD2afn2ss2s, Guid _0xHUnorna3e, object _0xHHypsome8ers)
	{
		if (_0xHF0li0 == null)
		{
			throw new ArgumentNullException("serviceProvider", "You must specify a serviceProvider.");
		}
		if (_0xHDr1bbly == null)
		{
			throw new ArgumentNullException("hier", "You must specify a Hierarchy.");
		}
		if (string.IsNullOrEmpty(_0xHOs1ensorium))
		{
			throw new ArgumentException("The document moniker wasn't set", "moniker");
		}
		if (_0xHHypsome8ers == null)
		{
			throw new ArgumentNullException("doc", "Document object must be specified when openning with a specific editor.");
		}
		IServiceProvider service = ServiceProviderExtensions.GetService<IServiceProvider, IServiceProvider>(_0xHF0li0);
		if (service == null)
		{
			throw _0xHL1mniscus._0xHEx2viates(new InvalidOperationException());
		}
		IVsUIShellOpenDocument service2 = ServiceProviderExtensions.GetService<IVsUIShellOpenDocument, SVsUIShellOpenDocument>(_0xHF0li0);
		if (service2 == null)
		{
			throw _0xHL1mniscus._0xHEx2viates(new InvalidOperationException());
		}
		Guid empty = Guid.Empty;
		string text = null;
		IntPtr intPtr = IntPtr.Zero;
		if (_0xHHypsome8ers != null)
		{
			intPtr = Marshal.GetIUnknownForObject(_0xHHypsome8ers);
		}
		try
		{
			IVsWindowFrame val = default(IVsWindowFrame);
			ErrorHandler.ThrowOnFailure(service2.OpenSpecificEditor(_0xH2oris, _0xHOs1ensorium, ref _0xHUnorna3e, text, ref empty, _0xHD2afn2ss2s, _0xHDr1bbly, _0xHTempest4o4sness, intPtr, service, ref val));
			if (val != null)
			{
				ErrorHandler.ThrowOnFailure(val.Show());
			}
			return val;
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Marshal.Release(intPtr);
			}
		}
	}

	public static IVsWindowFrame _0xHJ5lling(IVsUIShell _0xHZ3ggurat, object _0xHSilan6s)
	{
		IEnumWindowFrames val = default(IEnumWindowFrames);
		ErrorHandler.ThrowOnFailure(_0xHZ3ggurat.GetDocumentWindowEnum(ref val));
		IVsWindowFrame[] array = (IVsWindowFrame[])(object)new IVsWindowFrame[1];
		uint num = default(uint);
		object _0xHDebilitatin = default(object);
		while (val.Next(1u, array, ref num) == 0 && num == 1)
		{
			IVsWindowFrame val2 = array[0];
			ErrorHandler.ThrowOnFailure(val2.GetProperty(-4004, ref _0xHDebilitatin));
			if (_0xHUn7ontra7ted._0xHWat4rproof4r(_0xHDebilitatin, _0xHSilan6s))
			{
				return val2;
			}
		}
		return null;
	}

	public static void _0xHFl4ct4ations(IServiceProvider _0xHExanthemati1, object _0xH4adaverous)
	{
		if (_0xHExanthemati1 == null)
		{
			throw new ArgumentNullException("serviceProvider");
		}
		if (_0xH4adaverous == null)
		{
			throw new ArgumentNullException("doc");
		}
		IVsWindowFrame val = _0xHJ5lling(ServiceProviderExtensions.GetService<IVsUIShell, SVsUIShell>(_0xHExanthemati1), _0xH4adaverous);
		if (val != null)
		{
			ErrorHandler.ThrowOnFailure(val.Show());
		}
	}
}
