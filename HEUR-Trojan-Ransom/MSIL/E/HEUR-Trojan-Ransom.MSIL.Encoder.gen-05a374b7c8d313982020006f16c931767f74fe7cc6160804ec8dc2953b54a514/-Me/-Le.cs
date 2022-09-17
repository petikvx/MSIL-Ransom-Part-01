using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace _0023Me;

[DesignerCategory("Code")]
internal class _0023Le : Label
{
	protected override void _0023Ie(EventArgs _0023Rc)
	{
		((Label)this).OnFontChanged(_0023Rc);
		_0023_0023._0023eh(this);
	}

	protected override void _0023Je(EventArgs _0023Rc)
	{
		((Control)this).OnResize(_0023Rc);
		_0023_0023._0023eh(this);
	}

	protected override void _0023Ke(EventArgs _0023Rc)
	{
		((Label)this).OnTextChanged(_0023Rc);
		_0023_0023._0023eh(this);
	}

	public _0023Le()
	{
		((Label)this).set_FlatStyle((FlatStyle)3);
		((Label)this).set_UseMnemonic(false);
	}
}
