using System;
using System.Windows.Controls;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;

namespace _0xHMu11on;

internal abstract class _0xHU6satisfactory<TDocument> : WindowPane, IVsWindowPaneCommit
{
	private TDocument _0xHJusti1ied;

	public _0xHU6satisfactory(TDocument doc)
		: base((IServiceProvider)null)
	{
		this._documentToBeEdited = doc;
	}

	private int _0xHB1laying(out int _0xHSmallhold2rs)
	{
		_0xHSmallhold2rs = 0;
		return 0;
	}

	protected override void Initialize()
	{
		((WindowPane)this).Initialize();
		((WindowPane)this).set_Content((object)GetEditorControl(this._documentToBeEdited));
	}

	protected abstract Control GetEditorControl(TDocument documentToBeEdited);
}
