using System;
using System.Drawing;
using System.Windows.Forms;
using eBl9ZK3324M2L6fGA2Z;

namespace eCautJIa3ytQRUuWHwF;

internal class eSt0sxI9HxuCKxguTsr : Label
{
	private void eulODlten()
	{
		try
		{
			Graphics val = (Graphics)euqSgX2PGoCjgmvFtFs(this);
			try
			{
				int num = eRJXDGi7a7Tp2Z2XSc4(val, eQp9DQ2mCa5igkIyK3O(this), e2KZdx2x0Y0CHPhC6Wh(this), e7YFMc2zPhNpiZP9xtf(this));
				if (num > 0)
				{
					ecTTYci9pl56ckeo281(this, num);
				}
			}
			finally
			{
				if (val != null)
				{
					eYn7tTikuSnm0OvQcqO(val);
				}
			}
		}
		catch
		{
		}
	}

	protected override void OnFontChanged(EventArgs e)
	{
		eqYhaLiQfdLU64fta6p(this, e);
		eulODlten();
	}

	protected override void OnResize(EventArgs e)
	{
		e8Z0hbiLuEDjHxv6IvD(this, e);
		eulODlten();
	}

	protected override void OnTextChanged(EventArgs e)
	{
		etCBYXiJj1S3j3vrpYX(this, e);
		eulODlten();
	}

	public eSt0sxI9HxuCKxguTsr()
	{
		eBaiYW2rtMQVlME3img();
		if (!ePNkR62nPhrwqy6k39N())
		{
			eO8VYmijh4V0lr2OJCY(this);
		}
		edDgtgi5l3KWp3URMre(this, (FlatStyle)3);
		eTZHNMiCqcdnNPgfgUx(this, bool_0: false);
	}

	internal static object euqSgX2PGoCjgmvFtFs(object object_0)
	{
		return ((Control)object_0).CreateGraphics();
	}

	internal static object eQp9DQ2mCa5igkIyK3O(object object_0)
	{
		return ((Control)object_0).get_Text();
	}

	internal static object e2KZdx2x0Y0CHPhC6Wh(object object_0)
	{
		return ((Control)object_0).get_Font();
	}

	internal static int e7YFMc2zPhNpiZP9xtf(object object_0)
	{
		return ((Control)object_0).get_Width();
	}

	internal static int eRJXDGi7a7Tp2Z2XSc4(object object_0, object object_1, object object_2, int int_0)
	{
		return eTUgIV3IyA0FU9PXyfp.e8AuvEGCG((Graphics)object_0, (string)object_1, (Font)object_2, int_0);
	}

	internal static void ecTTYci9pl56ckeo281(object object_0, int int_0)
	{
		((Control)object_0).set_Height(int_0);
	}

	internal static void eYn7tTikuSnm0OvQcqO(object object_0)
	{
		((IDisposable)object_0).Dispose();
	}

	internal static bool eBaiYW2rtMQVlME3img()
	{
		return true;
	}

	internal static bool ePNkR62nPhrwqy6k39N()
	{
		return false;
	}

	internal static void eqYhaLiQfdLU64fta6p(object object_0, object object_1)
	{
		((Label)object_0).OnFontChanged((EventArgs)object_1);
	}

	internal static void e8Z0hbiLuEDjHxv6IvD(object object_0, object object_1)
	{
		((Control)object_0).OnResize((EventArgs)object_1);
	}

	internal static void etCBYXiJj1S3j3vrpYX(object object_0, object object_1)
	{
		((Label)object_0).OnTextChanged((EventArgs)object_1);
	}

	internal static void eO8VYmijh4V0lr2OJCY(object object_0)
	{
		((Label)object_0)._002Ector();
	}

	internal static void edDgtgi5l3KWp3URMre(object object_0, FlatStyle flatStyle_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((Label)object_0).set_FlatStyle(flatStyle_0);
	}

	internal static void eTZHNMiCqcdnNPgfgUx(object object_0, bool bool_0)
	{
		((Label)object_0).set_UseMnemonic(bool_0);
	}
}
