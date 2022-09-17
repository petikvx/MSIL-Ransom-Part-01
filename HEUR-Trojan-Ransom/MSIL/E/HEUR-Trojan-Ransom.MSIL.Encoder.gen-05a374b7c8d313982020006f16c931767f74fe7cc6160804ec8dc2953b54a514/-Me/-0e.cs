using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using _0023ab;

namespace _0023Me;

[DesignerCategory("Code")]
internal class _00230e : Control
{
	private Label _0023a = new Label();

	private Image _0023b;

	private Icon _0023c;

	private Bitmap _0023d;

	private _00231e _0023e;

	private float _0023f = 1f;

	private float _0023g = 1f;

	public _00231e IconState
	{
		get
		{
			return _0023e;
		}
		set
		{
			if (_0023e != value)
			{
				_0023e = value;
				switch (_0023e)
				{
				case _00231e._0023b:
					_0023d = _0023_0023._0023Uf(_00239._00237(107393451));
					break;
				case _00231e._0023c:
					_0023d = _0023_0023._0023Uf(_00239._00237(107393470));
					break;
				default:
					_0023d = null;
					break;
				}
				((Control)this).Refresh();
			}
		}
	}

	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	public override string Text
	{
		get
		{
			return ((Control)_0023a).get_Text();
		}
		set
		{
			((Control)_0023a).set_Text(value);
		}
	}

	public Image Image
	{
		get
		{
			return _0023b;
		}
		set
		{
			_0023b = value;
			((Control)this).Refresh();
		}
	}

	protected override void _0023U(bool _0023Te)
	{
		if (_0023Te)
		{
			if (_0023c != null)
			{
				_0023c.Dispose();
				_0023c = null;
			}
			if (_0023b != null)
			{
				_0023b.Dispose();
				_0023b = null;
			}
			if (_0023d != null)
			{
				((Image)_0023d).Dispose();
				_0023d = null;
			}
		}
		((Control)this).Dispose(_0023Te);
	}

	protected override void _0023Je(EventArgs _0023Rc)
	{
		((Control)_0023a).SetBounds(Convert.ToInt32(13f * _0023f), Convert.ToInt32(15f * _0023g), ((Control)this).get_Width() - Convert.ToInt32(69f * _0023f), ((Control)this).get_Height() - Convert.ToInt32(18f * _0023g));
		((Control)this).OnResize(_0023Rc);
	}

	protected override void _0023Pe(float _0023Qe, float _0023Re)
	{
		_0023f = _0023Qe;
		_0023g = _0023Re;
		((Control)this).ScaleCore(_0023Qe, _0023Re);
		((Control)this).OnResize(EventArgs.Empty);
	}

	protected override void _0023Se(PaintEventArgs _0023Rc)
	{
		((Control)this).OnPaint(_0023Rc);
		_0023Rc.get_Graphics().DrawLine(SystemPens.get_ControlDark(), 0, ((Control)this).get_ClientSize().Height - 2, ((Control)this).get_ClientSize().Width, ((Control)this).get_ClientSize().Height - 2);
		_0023Rc.get_Graphics().DrawLine(SystemPens.get_ControlLightLight(), 0, ((Control)this).get_ClientSize().Height - 1, ((Control)this).get_ClientSize().Width, ((Control)this).get_ClientSize().Height - 1);
		Rectangle rectangle = new Rectangle(((Control)this).get_ClientSize().Width - Convert.ToInt32(48f * _0023f), Convert.ToInt32(11f * _0023g), Convert.ToInt32(32f * _0023f), Convert.ToInt32(32f * _0023g));
		if (_0023b != null)
		{
			_0023Rc.get_Graphics().DrawImage(_0023b, rectangle, new Rectangle(0, 0, 32, 32), (GraphicsUnit)2);
		}
		else if (_0023c != null)
		{
			_0023Rc.get_Graphics().DrawIcon(_0023c, rectangle);
			if (_0023d != null)
			{
				_0023Rc.get_Graphics().DrawImage((Image)(object)_0023d, new Rectangle(rectangle.Right - Convert.ToInt32(12f * _0023f), rectangle.Bottom - Convert.ToInt32(12f * _0023g), Convert.ToInt32(16f * _0023f), Convert.ToInt32(16f * _0023g)), new Rectangle(0, 0, 16, 16), (GraphicsUnit)2);
			}
		}
	}

	protected override void _0023Ie(EventArgs _0023Rc)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		try
		{
			((Control)_0023a).set_Font(new Font(((Control)this).get_Font(), (FontStyle)1));
			((Control)this).OnFontChanged(_0023Rc);
		}
		catch
		{
		}
	}

	public _00230e()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		try
		{
			_0023a.set_FlatStyle((FlatStyle)3);
			((Control)_0023a).set_Font(new Font(((Control)this).get_Font(), (FontStyle)1));
		}
		catch
		{
		}
		((Control)this).get_Controls().Add((Control)(object)_0023a);
		((Control)this).set_BackColor(SystemColors.Window);
		((Control)this).set_TabStop(false);
		((Control)this).set_Dock((DockStyle)1);
		((Control)this).set_Height(58);
		((Control)this).SetStyle((ControlStyles)75794, true);
		_0023c = _0023_0023._00233f();
		((Control)this).OnResize(EventArgs.Empty);
	}

	public _00230e(string _0023re)
		: this()
	{
		((Control)_0023a).set_Text(_0023re);
	}
}
