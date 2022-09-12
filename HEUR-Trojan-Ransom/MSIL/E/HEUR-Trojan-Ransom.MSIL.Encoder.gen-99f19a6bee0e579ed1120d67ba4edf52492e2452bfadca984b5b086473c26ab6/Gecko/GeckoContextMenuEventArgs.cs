using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gecko;

public class GeckoContextMenuEventArgs : EventArgs
{
	public readonly Point Location;

	public readonly Uri BackgroundImageSrc;

	public readonly Uri ImageSrc;

	public readonly string AssociatedLink;

	private GeckoNode _targetNode;

	private ContextMenu _contextMenu;

	public ContextMenu ContextMenu
	{
		get
		{
			return _contextMenu;
		}
		set
		{
			_contextMenu = value;
		}
	}

	public GeckoNode TargetNode => _targetNode;

	public GeckoContextMenuEventArgs(Point location, ContextMenu contextMenu, string associatedLink, Uri backgroundImageSrc, Uri imageSrc, GeckoNode targetNode)
	{
		Location = location;
		_contextMenu = contextMenu;
		AssociatedLink = associatedLink;
		BackgroundImageSrc = backgroundImageSrc;
		ImageSrc = imageSrc;
		_targetNode = targetNode;
	}
}
