using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace chicken;

public class Buttoncontroller : PictureBox
{
	private Image jLDPLITvPNnwiKeErLiEpCyNoUCG;

	private Image BRvmctxnMaSCADlKVxCBmyhuGUAo;

	private bool QJXAWuIkojHezAqYfEtahbYlCaJHA;

	private GraphicsPath YWaJunRpChAiBzJqzRbbWxynghFl;

	private NzMhXGhPlibCMPskiBGovgiGrqRA.UJiKqWhEakFXHIrjJDUmEhCLnBiRA BNbfXaIwKOjyYODeEuMbVbuaaKFf;

	private NzMhXGhPlibCMPskiBGovgiGrqRA.CUgbJJxlnlhElqAxLZBahPYoFleS UxyYxoKZjiwGBrZXflbuebIcHHFT;

	public Image ButtonImage
	{
		get
		{
			return jLDPLITvPNnwiKeErLiEpCyNoUCG;
		}
		set
		{
			jLDPLITvPNnwiKeErLiEpCyNoUCG = value;
			((Control)this).set_BackgroundImage(jLDPLITvPNnwiKeErLiEpCyNoUCG);
			((Control)this).Refresh();
		}
	}

	public Image HoverImage
	{
		get
		{
			return BRvmctxnMaSCADlKVxCBmyhuGUAo;
		}
		set
		{
			BRvmctxnMaSCADlKVxCBmyhuGUAo = value;
		}
	}

	public Buttoncontroller()
	{
		QJXAWuIkojHezAqYfEtahbYlCaJHA = false;
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
		((Control)this).set_BackgroundImage(jLDPLITvPNnwiKeErLiEpCyNoUCG);
		((Control)this).set_Width(jLDPLITvPNnwiKeErLiEpCyNoUCG.get_Width());
		((Control)this).set_Height(jLDPLITvPNnwiKeErLiEpCyNoUCG.get_Height());
		YWaJunRpChAiBzJqzRbbWxynghFl = Commons.calcGraphicsPath((Bitmap)jLDPLITvPNnwiKeErLiEpCyNoUCG);
		((Control)this).set_Region(new Region(YWaJunRpChAiBzJqzRbbWxynghFl));
		((Control)this).add_MouseEnter((EventHandler)tniuYoyLOPWDYHgsohqyZgzffMsx);
		((Control)this).add_MouseMove(new MouseEventHandler(dttCqLxTDNuLlMhTAhanepWgxazPA));
		((Control)this).add_MouseClick(new MouseEventHandler(sCitDwlcuOCuMalTuSQnVUiHNCFK));
		((Control)this).get_Region().Translate(((Control)this).get_Left(), ((Control)this).get_Top());
	}

	public void reset()
	{
		((Control)this).set_Capture(false);
		QJXAWuIkojHezAqYfEtahbYlCaJHA = true;
		((Control)this).set_BackgroundImage(jLDPLITvPNnwiKeErLiEpCyNoUCG);
	}

	private void sCitDwlcuOCuMalTuSQnVUiHNCFK(object sender, MouseEventArgs e)
	{
		reset();
	}

	private void tniuYoyLOPWDYHgsohqyZgzffMsx(object sender, EventArgs e)
	{
		((Control)this).set_Capture(true);
		((Control)this).set_BackgroundImage(BRvmctxnMaSCADlKVxCBmyhuGUAo);
		QJXAWuIkojHezAqYfEtahbYlCaJHA = true;
		((Control)this).Invalidate();
	}

	private void dttCqLxTDNuLlMhTAhanepWgxazPA(object sender, EventArgs e)
	{
		if (QJXAWuIkojHezAqYfEtahbYlCaJHA && ((Control)this).get_Capture() && !YOeMbvQPCCDFOHBEytikegJbHnVXA(((Control)this).get_Handle()))
		{
			((Control)this).set_Capture(false);
			QJXAWuIkojHezAqYfEtahbYlCaJHA = true;
			((Control)this).set_BackgroundImage(jLDPLITvPNnwiKeErLiEpCyNoUCG);
			((Control)this).Invalidate();
		}
	}

	private bool TytsSUPaDTgFsfOnvehweGUAYxRab(NzMhXGhPlibCMPskiBGovgiGrqRA.UJiKqWhEakFXHIrjJDUmEhCLnBiRA rt, NzMhXGhPlibCMPskiBGovgiGrqRA.CUgbJJxlnlhElqAxLZBahPYoFleS pt)
	{
		if (rt.xVdiVzLyPIDFhxQYUimekYRSoPOy <= pt.ydfGBgKLJMvTVeCiNkjWcjfdzTcF && rt.evoYjoIqPdVTGxPxNfiTNnpaeQPm >= pt.ydfGBgKLJMvTVeCiNkjWcjfdzTcF && rt.nNmmBFOBAOSnFsTpPVqZewbbGpeJ <= pt.UlxLDptadkfoqfWSLVEFbOahRcRS)
		{
			return rt.wdBMdGdPRJpqxofqKMSnVXJkJuQj >= pt.UlxLDptadkfoqfWSLVEFbOahRcRS;
		}
		return false;
	}

	private bool TytsSUPaDTgFsfOnvehweGUAYxRab(RectangleF rt, Point pt)
	{
		if (rt.Left <= (float)pt.X && rt.Right >= (float)pt.X && rt.Top <= (float)pt.Y)
		{
			return rt.Bottom >= (float)pt.Y;
		}
		return false;
	}

	private bool YOeMbvQPCCDFOHBEytikegJbHnVXA(IntPtr hwnd)
	{
		BNbfXaIwKOjyYODeEuMbVbuaaKFf = default(NzMhXGhPlibCMPskiBGovgiGrqRA.UJiKqWhEakFXHIrjJDUmEhCLnBiRA);
		UxyYxoKZjiwGBrZXflbuebIcHHFT = default(NzMhXGhPlibCMPskiBGovgiGrqRA.CUgbJJxlnlhElqAxLZBahPYoFleS);
		NzMhXGhPlibCMPskiBGovgiGrqRA.GetWindowRect(hwnd, ref BNbfXaIwKOjyYODeEuMbVbuaaKFf);
		NzMhXGhPlibCMPskiBGovgiGrqRA.GetCursorPos(out UxyYxoKZjiwGBrZXflbuebIcHHFT);
		return TytsSUPaDTgFsfOnvehweGUAYxRab(BNbfXaIwKOjyYODeEuMbVbuaaKFf, UxyYxoKZjiwGBrZXflbuebIcHHFT);
	}

	IntPtr method_0()
	{
		return ((Control)this).get_Handle();
	}
}
