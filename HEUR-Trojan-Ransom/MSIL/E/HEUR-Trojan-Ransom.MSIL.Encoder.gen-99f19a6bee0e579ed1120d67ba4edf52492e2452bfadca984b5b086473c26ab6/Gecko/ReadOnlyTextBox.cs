using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Gecko;

internal class ReadOnlyTextBox : TextBox
{
	private class DeviceContext : IDisposable, IDeviceContext
	{
		private IntPtr _Hdc;

		public DeviceContext(IntPtr hdc)
		{
			_Hdc = hdc;
		}

		public IntPtr GetHdc()
		{
			return _Hdc;
		}

		public void ReleaseHdc()
		{
		}

		public void Dispose()
		{
			_Hdc = IntPtr.Zero;
			GC.SuppressFinalize(this);
		}
	}

	public ReadOnlyTextBox()
	{
		((TextBoxBase)this).set_ReadOnly(true);
		((TextBoxBase)this).set_Multiline(true);
		((TextBoxBase)this).set_WordWrap(false);
	}

	protected override void WndProc(ref Message m)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		int msg = ((Message)(ref m)).get_Msg();
		if (msg == 20 && Application.get_RenderWithVisualStyles())
		{
			VisualStyleRenderer val = new VisualStyleRenderer(TextEdit.get_Normal());
			val.DrawParentBackground((IDeviceContext)(object)new DeviceContext(((Message)(ref m)).get_WParam()), ((Control)this).get_ClientRectangle(), (Control)(object)this);
			((Message)(ref m)).set_Result((IntPtr)1);
		}
		else
		{
			((TextBox)this).WndProc(ref m);
		}
	}

	protected override void OnLostFocus(EventArgs e)
	{
		((Control)this).Refresh();
		((Control)this).OnLostFocus(e);
	}
}
