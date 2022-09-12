using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace chicken;

public class Buttoncontroller : PictureBox
{
	private Image uDROjjtKPoJFypWxcMYlVSdCaHRV;

	private Image MFhEYSZcUXgBKwPhEHsuQEonriPj;

	private bool RAZgsHciqENQxrKrmRmRHHPgQXQt;

	private GraphicsPath ZLmCEIfACQtUHMoVodeAfcneHFEZA;

	private KIpbDekXJKbLQdaLchKzTJvMfWnqb.toGbQzZOhuyUkmEZkFPqmhuVklfv GzprTBuJKrJDQpmXRnnGrRhrVwQK;

	private KIpbDekXJKbLQdaLchKzTJvMfWnqb.TLskhaFtjQMsdRmEKCGLNFTfrOfw XHkjcRgbbDbQZEMesEoTjKRJvsKVB;

	public Image ButtonImage
	{
		get
		{
			return uDROjjtKPoJFypWxcMYlVSdCaHRV;
		}
		set
		{
			uDROjjtKPoJFypWxcMYlVSdCaHRV = value;
			((Control)this).set_BackgroundImage(uDROjjtKPoJFypWxcMYlVSdCaHRV);
			((Control)this).Refresh();
		}
	}

	public Image HoverImage
	{
		get
		{
			return MFhEYSZcUXgBKwPhEHsuQEonriPj;
		}
		set
		{
			MFhEYSZcUXgBKwPhEHsuQEonriPj = value;
		}
	}

	public Buttoncontroller()
	{
		RAZgsHciqENQxrKrmRmRHHPgQXQt = false;
		((Control)this).set_Cursor(Cursors.get_Hand());
	}

	public void init()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		((Control)this).set_BackColor(Color.Transparent);
		((Control)this).set_BackgroundImage(uDROjjtKPoJFypWxcMYlVSdCaHRV);
		((Control)this).set_Width(uDROjjtKPoJFypWxcMYlVSdCaHRV.get_Width());
		((Control)this).set_Height(uDROjjtKPoJFypWxcMYlVSdCaHRV.get_Height());
		ZLmCEIfACQtUHMoVodeAfcneHFEZA = Commons.calcGraphicsPath((Bitmap)uDROjjtKPoJFypWxcMYlVSdCaHRV);
		((Control)this).set_Region(new Region(ZLmCEIfACQtUHMoVodeAfcneHFEZA));
		((Control)this).add_MouseEnter((EventHandler)ghwWQNGvToqaQivVhhqHxmsoRzpT);
		((Control)this).add_MouseMove(new MouseEventHandler(wdfmGgDdZsVzbzGeDVxMPSLlhJwP));
		((Control)this).add_MouseClick(new MouseEventHandler(rqyvFLDNsvbmWdPofaPMFbtEAgYxB));
		((Control)this).get_Region().Translate(((Control)this).get_Left(), ((Control)this).get_Top());
	}

	public void reset()
	{
		((Control)this).set_Capture(false);
		RAZgsHciqENQxrKrmRmRHHPgQXQt = true;
		((Control)this).set_BackgroundImage(uDROjjtKPoJFypWxcMYlVSdCaHRV);
	}

	private void rqyvFLDNsvbmWdPofaPMFbtEAgYxB(object sender, MouseEventArgs e)
	{
		reset();
	}

	private void ghwWQNGvToqaQivVhhqHxmsoRzpT(object sender, EventArgs e)
	{
		((Control)this).set_Capture(true);
		((Control)this).set_BackgroundImage(MFhEYSZcUXgBKwPhEHsuQEonriPj);
		RAZgsHciqENQxrKrmRmRHHPgQXQt = true;
		((Control)this).Invalidate();
	}

	private void wdfmGgDdZsVzbzGeDVxMPSLlhJwP(object sender, EventArgs e)
	{
		if (RAZgsHciqENQxrKrmRmRHHPgQXQt && ((Control)this).get_Capture() && !TdqFaKilEdlhSubbbkrFSdYgvIOM(this.method_0()))
		{
			((Control)this).set_Capture(false);
			RAZgsHciqENQxrKrmRmRHHPgQXQt = true;
			((Control)this).set_BackgroundImage(uDROjjtKPoJFypWxcMYlVSdCaHRV);
			((Control)this).Invalidate();
		}
	}

	private bool UEnmgfpFHwzjynBCqiCXuoBJYJSk(KIpbDekXJKbLQdaLchKzTJvMfWnqb.toGbQzZOhuyUkmEZkFPqmhuVklfv rt, KIpbDekXJKbLQdaLchKzTJvMfWnqb.TLskhaFtjQMsdRmEKCGLNFTfrOfw pt)
	{
		return rt.yepbfCfpTtarpSmdDVtPCqKRZwRv <= pt.bqhLyRgtJjGLXPZFUOvfEpwsCVtk && rt.pHmsiBiKNWXhCGaCWTmunAongPQhA >= pt.bqhLyRgtJjGLXPZFUOvfEpwsCVtk && rt.yHowMcqBQtEwZeJKCsCshQycjfzib <= pt.JtvlCWVphFCqeEizMXrcTAloZDUj && rt.hqDmabVNLuoTtLVLJaZShNKtQeZX >= pt.JtvlCWVphFCqeEizMXrcTAloZDUj;
	}

	private bool UEnmgfpFHwzjynBCqiCXuoBJYJSk(RectangleF rt, Point pt)
	{
		return rt.Left <= (float)pt.X && rt.Right >= (float)pt.X && rt.Top <= (float)pt.Y && rt.Bottom >= (float)pt.Y;
	}

	private bool TdqFaKilEdlhSubbbkrFSdYgvIOM(IntPtr hwnd)
	{
		GzprTBuJKrJDQpmXRnnGrRhrVwQK = default(KIpbDekXJKbLQdaLchKzTJvMfWnqb.toGbQzZOhuyUkmEZkFPqmhuVklfv);
		XHkjcRgbbDbQZEMesEoTjKRJvsKVB = default(KIpbDekXJKbLQdaLchKzTJvMfWnqb.TLskhaFtjQMsdRmEKCGLNFTfrOfw);
		KIpbDekXJKbLQdaLchKzTJvMfWnqb.GetWindowRect(hwnd, ref GzprTBuJKrJDQpmXRnnGrRhrVwQK);
		KIpbDekXJKbLQdaLchKzTJvMfWnqb.GetCursorPos(out XHkjcRgbbDbQZEMesEoTjKRJvsKVB);
		return UEnmgfpFHwzjynBCqiCXuoBJYJSk(GzprTBuJKrJDQpmXRnnGrRhrVwQK, XHkjcRgbbDbQZEMesEoTjKRJvsKVB);
	}

	IntPtr method_0()
	{
		return ((Control)this).get_Handle();
	}
}
