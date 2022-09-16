#define TRACE
using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.OLE.Interop;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;

namespace _0xH6lister;

internal abstract class _0xHGala0tosyl<TDocument> : IVsEditorFactory, IDisposable where TDocument : class
{
	private ServiceProvider _0xHBregmat6c;

	protected abstract string _0xHSuspe2dered { get; }

	public _0xHGala0tosyl()
	{
	}

	public void _0xHMini2us()
	{
		this.Dispose(true);
		GC.SuppressFinalize(this);
	}

	public int _0xHQuaveringl4()
	{
		return 0;
	}

	public int _0xHN4rr4tions(uint _0xHForeteet3, string _0xHInsect6c6dally, string _0xHGlyco4ics, IVsHierarchy _0xHPyra4id, uint _0xHRetributi2ns, IntPtr _0xH0sogenic, out IntPtr _0xH3evigate, out IntPtr _0xHMa4ournins, out string _0xH6aking, out Guid _0xHEnok3, out int _0xHJu66ler)
	{
		Trace.WriteLine(string.Format(CultureInfo.CurrentCulture, "Entering {0} CreateEditorInstance()", ToString()));
		_0xH3evigate = IntPtr.Zero;
		_0xHMa4ournins = IntPtr.Zero;
		_0xHEnok3 = GetEditorFactoryGuid();
		_0xHJu66ler = 0;
		_0xH6aking = null;
		if ((_0xHForeteet3 & 6) == 0)
		{
			return -2147024809;
		}
		if (_0xH0sogenic == IntPtr.Zero)
		{
			return -2147213334;
		}
		TDocument editorDocument = GetEditorDocument(_0xH0sogenic);
		if (editorDocument == null)
		{
			return -2147213334;
		}
		WindowPane windowPane = GetWindowPane(editorDocument);
		_0xH3evigate = Marshal.GetIUnknownForObject(windowPane);
		_0xHMa4ournins = Marshal.GetIUnknownForObject(editorDocument);
		_0xH6aking = GetEditorCaption();
		_0xHJu66ler = GetEditorFlags();
		return 0;
	}

	public int _0xHWic7et(ref Guid _0xHSusurrat0s, out string _0xH6vacuates)
	{
		_0xH6vacuates = null;
		if (VSConstants.LOGVIEWID_Primary == _0xHSusurrat0s)
		{
			return 0;
		}
		return -2147467263;
	}

	public int _0xHNylg6ai(IServiceProvider _0xHLugubriou7ly)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		this._serviceProvider = new ServiceProvider(_0xHLugubriou7ly);
		return 0;
	}

	protected abstract Guid GetEditorFactoryGuid();

	protected virtual TDocument GetEditorDocument(IntPtr existingDoc)
	{
		return Marshal.GetObjectForIUnknown(existingDoc) as TDocument;
	}

	protected abstract WindowPane GetWindowPane(TDocument doc);

	protected virtual string GetEditorCaption()
	{
		if (!string.IsNullOrEmpty(_0xHSuspe2dered))
		{
			return string.Format(CultureInfo.CurrentCulture, " [{0}]", _0xHSuspe2dered);
		}
		return null;
	}

	protected virtual int GetEditorFlags()
	{
		return 65640;
	}

	private void _0xHV8cably(bool _0xH0nfusions)
	{
		if (_0xH0nfusions && this._serviceProvider != null)
		{
			this._serviceProvider.Dispose();
			this._serviceProvider = null;
		}
	}
}
