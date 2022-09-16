using System;
using System.Runtime.CompilerServices;
using Microsoft.VSDesigner.ServerExplorer;

namespace _0xHCreditabi7ities;

internal abstract class _0xHK4amseen
{
	public bool _0xHAdsorpti6e { get; protected set; }

	public string _0xHTotem5 { get; protected set; }

	protected _0xHK4amseen()
	{
		_0xHAdsorpti6e = true;
	}

	public abstract void _0xHExtraversio3(EventArgs _0xHProgen0tor = null);

	public ContextMenuItem _0xHBy8led()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		return new ContextMenuItem(_0xHTotem5, (EventHandler)delegate(object sender, EventArgs e)
		{
			_0xHExtraversio3(e);
		}, _0xHAdsorpti6e);
	}

	[CompilerGenerated]
	private void _0xHChlor7romazine(object sender, EventArgs e)
	{
		_0xHExtraversio3(e);
	}
}
