using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using g1YNiPtPvSRBvAhXIq;
using gw3DRdpG9gZIr60hEO;

namespace Yugcbr;

public class Xuzprbllekygwf : Form
{
	private IContainer HgC42WNjo;

	private static Xuzprbllekygwf G0oMWHJQikHekn6JQF;

	protected override void Dispose(bool disposing)
	{
		int num = 1;
		while (disposing)
		{
			int num2 = 0;
			if (N0l6ltbuhs1gBDLryQ() != null)
			{
				goto IL_0026;
			}
			goto IL_002a;
			IL_0026:
			num2 = num;
			goto IL_002a;
			IL_002a:
			while (true)
			{
				switch (num2)
				{
				case 1:
					goto end_IL_002a;
				case 2:
					goto end_IL_005b;
				case 3:
					return;
				}
				if (HgC42WNjo == null)
				{
					goto end_IL_005b;
				}
				MaNAc5yTDmSJJ2xRE8(HgC42WNjo);
				num2 = 2;
				if (N0l6ltbuhs1gBDLryQ() == null)
				{
					continue;
				}
				goto IL_0026;
				continue;
				end_IL_002a:
				break;
			}
			continue;
			end_IL_005b:
			break;
		}
		((Form)this).Dispose(disposing);
	}

	private void nS1xAVXKR()
	{
		HgC42WNjo = new Container();
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		int num = 0;
		if (!zjggMrMf93b7ilGSXV())
		{
			int num2 = default(int);
			num = num2;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			bVkW14hLgQigxSKCja(this, new Size(975, 823));
			ek3PiTlSjn49x9PAwB(this, "Xuzprbllekygwf");
			num = 1;
			if (zjggMrMf93b7ilGSXV())
			{
				return;
			}
		}
	}

	public Xuzprbllekygwf()
	{
		iVZG9R1oqUZrSiIOLE.ExbLcoxzRwxZj();
		HgC42WNjo = null;
		((Form)this)._002Ector();
		nS1xAVXKR();
	}

	static Xuzprbllekygwf()
	{
		GOSVNDaQpjiPO8bUNi();
	}

	internal static void MaNAc5yTDmSJJ2xRE8(object object_0)
	{
		((IDisposable)object_0).Dispose();
	}

	internal static bool zjggMrMf93b7ilGSXV()
	{
		return G0oMWHJQikHekn6JQF == null;
	}

	internal static Xuzprbllekygwf N0l6ltbuhs1gBDLryQ()
	{
		return G0oMWHJQikHekn6JQF;
	}

	internal static void bVkW14hLgQigxSKCja(object object_0, Size size_0)
	{
		((Form)object_0).set_ClientSize(size_0);
	}

	internal static void ek3PiTlSjn49x9PAwB(object object_0, object object_1)
	{
		((Control)object_0).set_Text((string)object_1);
	}

	internal static void GOSVNDaQpjiPO8bUNi()
	{
		J5LlPjhj0b2Nc1D9HG.PKPIlAlcr();
	}
}
