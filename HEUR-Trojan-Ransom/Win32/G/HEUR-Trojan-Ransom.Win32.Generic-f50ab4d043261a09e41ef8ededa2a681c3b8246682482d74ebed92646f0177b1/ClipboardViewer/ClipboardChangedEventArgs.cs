using System;
using System.Windows.Forms;

namespace ClipboardViewer;

public class ClipboardChangedEventArgs : EventArgs
{
	public readonly IDataObject DataObject;

	public ClipboardChangedEventArgs(IDataObject dataObject)
	{
		DataObject = dataObject;
	}
}
