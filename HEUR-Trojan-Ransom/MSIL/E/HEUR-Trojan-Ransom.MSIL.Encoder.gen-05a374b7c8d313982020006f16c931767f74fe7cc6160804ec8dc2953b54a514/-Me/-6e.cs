using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using _0023ab;

namespace _0023Me;

[DesignerCategory("Code")]
internal class _00236e : Control
{
	internal int _0023a = 99;

	private readonly Bitmap _0023b = _0023_0023._0023Uf(_00239._00237(107392660));

	private readonly Bitmap _0023c = _0023_0023._0023Uf(_00239._00237(107392619));

	internal readonly Timer _0023d = new Timer();

	private float _0023e = 1f;

	private float _0023f = 1f;

	protected override void _00234e(EventArgs _0023Rc)
	{
		((Control)this).OnVisibleChanged(_0023Rc);
		if (!((Component)this).DesignMode)
		{
			_0023_0023._0023Gh(((Control)this).get_Visible(), this);
		}
	}

	protected override void _0023Je(EventArgs _0023Rc)
	{
		((Control)this).set_Size(new Size(Convert.ToInt32(250f * _0023e), Convert.ToInt32(42f * _0023f)));
		((Control)this).OnResize(_0023Rc);
	}

	protected override void _0023Pe(float _0023Qe, float _0023Re)
	{
		_0023e = _0023Qe;
		_0023f = _0023Re;
		((Control)this).ScaleCore(_0023Qe, _0023Re);
		((Control)this).OnResize(EventArgs.Empty);
	}

	protected override void _0023U(bool _0023Te)
	{
		if (_0023Te)
		{
			if (_0023b != null)
			{
				((Image)_0023b).Dispose();
			}
			((Component)(object)_0023d).Dispose();
		}
		((Control)this).Dispose(_0023Te);
	}

	protected override void _0023Se(PaintEventArgs _0023Rc)
	{
		((Control)this).OnPaint(_0023Rc);
		if (_0023c != null)
		{
			_0023Rc.get_Graphics().DrawImage((Image)(object)_0023c, new Rectangle(0, 0, Convert.ToInt32(250f * _0023e), Convert.ToInt32(42f * _0023f)), new Rectangle(0, 0, 250, 42), (GraphicsUnit)2);
		}
		if (_0023b != null && _0023a > 0)
		{
			_0023Rc.get_Graphics().SetClip(new Rectangle(Convert.ToInt32(46f * _0023e), 0, Convert.ToInt32(165f * _0023e), Convert.ToInt32(34f * _0023f)));
			_0023Rc.get_Graphics().DrawImage((Image)(object)_0023b, new Rectangle(Convert.ToInt32((float)(_0023a - 6) * _0023e), Convert.ToInt32(16f * _0023f), Convert.ToInt32(40f * _0023e), Convert.ToInt32(12f * _0023f)), 0, 0, 40, 12, (GraphicsUnit)2);
		}
	}

	private void _0023Ue(object _00232d, EventArgs _0023Rc)
	{
		_0023a += 11;
		if (_0023a > 198)
		{
			_0023a = 0;
		}
		((Control)this).Refresh();
	}

	public _00236e()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		_0023d.set_Interval(85);
		_0023d.add_Tick((EventHandler)_0023Ue);
		((Control)this).set_Size(new Size(250, 42));
		((Control)this).set_TabStop(false);
		((Control)this).SetStyle((ControlStyles)75794, true);
	}
}
