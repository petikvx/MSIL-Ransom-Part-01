using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using _0023ab;

namespace _0023Me;

[DesignerCategory("Code")]
internal class _0023Ve : Control
{
	private readonly Label _0023a = new Label();

	internal Image _0023b;

	internal bool _0023c;

	internal readonly Timer _0023d = new Timer();

	internal bool _0023e = true;

	internal string _0023f = string.Empty;

	private float _0023g = 1f;

	private float _0023h = 1f;

	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	public override string Text
	{
		get
		{
			return ((Control)this).get_Text();
		}
		set
		{
			((Control)this).set_Text(value);
			((Control)this).Refresh();
		}
	}

	protected override void _0023Je(EventArgs _0023Rc)
	{
		((Control)_0023a).SetBounds(Convert.ToInt32(22f * _0023g), Convert.ToInt32(_0023h), ((Control)this).get_Width() - Convert.ToInt32(22f * _0023g), ((Control)this).get_Height() - Convert.ToInt32(_0023h));
		((Control)this).OnResize(_0023Rc);
	}

	protected override void _0023Pe(float _0023Qe, float _0023Re)
	{
		_0023g = _0023Qe;
		_0023h = _0023Re;
		((Control)this).ScaleCore(_0023Qe, _0023Re);
		((Control)this).OnResize(EventArgs.Empty);
	}

	protected override void _0023Se(PaintEventArgs _0023Rc)
	{
		((Control)this).OnPaint(_0023Rc);
		if (((Component)this).DesignMode)
		{
			_0023b = (Image)(object)_0023_0023._0023Uf(_00239._00237(107393474));
			_0023c = true;
		}
		if (_0023b != null && _0023e)
		{
			_0023Rc.get_Graphics().DrawImage(_0023b, new Rectangle(0, 0, Convert.ToInt32(16f * _0023g), Convert.ToInt32(16f * _0023h)), new Rectangle(0, 0, 16, 16), (GraphicsUnit)2);
		}
		if (_0023c)
		{
			((Control)_0023a).set_Text((_0023f.Length > 0) ? (((Control)this).get_Text() + _00239._00237(107393493) + _0023f + _00239._00237(107393488)) : ((Control)this).get_Text());
		}
		else
		{
			((Control)_0023a).set_Text(string.Empty);
		}
	}

	public _0023Ve()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		_0023d.set_Interval(250);
		_0023d.add_Tick((EventHandler)_0023Ue);
		_0023a.set_FlatStyle((FlatStyle)3);
		((Control)this).get_Controls().Add((Control)(object)_0023a);
		((Control)this).SetStyle((ControlStyles)75794, true);
		((Control)this).set_TabStop(false);
	}

	public _0023Ve(string _0023re)
		: this()
	{
		((Control)this).set_Text(_00239._00237(107395645) + _0023re);
	}

	protected override void _0023U(bool _0023Te)
	{
		if (_0023Te)
		{
			if (_0023b != null)
			{
				_0023b.Dispose();
			}
			((Component)(object)_0023d).Dispose();
		}
		((Control)this).Dispose(_0023Te);
	}

	private void _0023Ue(object _00232d, EventArgs _0023Rc)
	{
		_0023e = !_0023e;
		((Control)this).Refresh();
	}
}
