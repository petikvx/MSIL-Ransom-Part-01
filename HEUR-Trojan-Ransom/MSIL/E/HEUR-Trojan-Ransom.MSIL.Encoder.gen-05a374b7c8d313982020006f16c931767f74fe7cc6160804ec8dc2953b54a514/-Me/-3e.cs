using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using _0023ab;

namespace _0023Me;

[DesignerCategory("Code")]
internal class _00233e : Control
{
	private const string _0023a = "Powered by SmartAssembly";

	private const string _0023b = "http://www.red-gate.com/products/dotnet-development/smartassembly/?utm_source=smartassemblyui&utm_medium=supportlink&utm_content=aerdialogbox&utm_campaign=smartassembly";

	private Label _0023c = new Label();

	private PictureBox _0023d = new PictureBox();

	private ToolTip _0023e = new ToolTip();

	private float _0023f = 1f;

	private float _0023g = 1f;

	protected override void _0023Je(EventArgs _0023Rc)
	{
		((Control)this).set_Size(new Size(Convert.ToInt32(112f * _0023f), Convert.ToInt32(32f * _0023g)));
		((Control)this).OnResize(_0023Rc);
	}

	protected override void _0023Pe(float _0023Qe, float _0023Re)
	{
		_0023f = _0023Qe;
		_0023g = _0023Re;
		((Control)this).ScaleCore(_0023Qe, _0023Re);
		((Control)this).OnResize(EventArgs.Empty);
	}

	protected override void _0023U(bool _0023Te)
	{
		if (_0023Te)
		{
			if (_0023e != null)
			{
				((Component)(object)_0023e).Dispose();
			}
			if (_0023d != null)
			{
				((Component)(object)_0023d).Dispose();
			}
		}
		((Control)this).Dispose(_0023Te);
	}

	private void _00232e(object _00232d, EventArgs _0023Rc)
	{
		try
		{
			Process.Start(_00239._00237(107393457));
		}
		catch
		{
		}
	}

	public _00233e()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		((Control)this).SuspendLayout();
		_0023c.set_FlatStyle((FlatStyle)3);
		((Control)_0023c).set_Location(new Point(0, 10));
		((Control)_0023c).set_Size(new Size(62, 24));
		((Control)_0023c).set_Text(_00239._00237(107392687));
		_0023d.set_Image((Image)(object)_0023_0023._0023Uf(_00239._00237(107392702)));
		((Control)_0023d).set_Location(new Point(72, 0));
		((Control)_0023d).set_Size(new Size(32, 32));
		_0023d.set_SizeMode((PictureBoxSizeMode)1);
		((Control)_0023c).add_Click((EventHandler)_00232e);
		((Control)_0023d).add_Click((EventHandler)_00232e);
		((Control)this).add_Click((EventHandler)_00232e);
		((Control)this).set_Cursor(Cursors.get_Hand());
		((Control)this).set_TabStop(false);
		((Control)this).set_Size(new Size(112, 32));
		((Control)this).get_Controls().AddRange((Control[])(object)new Control[2]
		{
			(Control)_0023d,
			(Control)_0023c
		});
		_0023e.SetToolTip((Control)(object)this, _00239._00237(107392693));
		_0023e.SetToolTip((Control)(object)_0023c, _00239._00237(107392693));
		_0023e.SetToolTip((Control)(object)_0023d, _00239._00237(107392693));
		((Control)this).ResumeLayout(true);
	}
}
