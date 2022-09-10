using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ITiiE34eRSm4XTiAdM0;
using NCDRxx4R49CZy0gNBsi;

namespace AZPaoL44ds7wDoFriKA;

internal sealed class BUgpn54LHsSP29Ryc6b : Label
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CraTZWhyTP()
	{
		//Discarded unreachable code: IL_003a
		try
		{
			Graphics val = ((Control)this).CreateGraphics();
			try
			{
				int num = EyY6ZF4u1pw8LWWYsyc.Fe1Hsbruq3(val, ((Control)this).get_Text(), ((Control)this).get_Font(), ((Control)this).get_Width());
				int num2 = 2;
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					case 0:
					case 2:
						if (num > 0)
						{
							goto case 1;
						}
						return;
					case 1:
					case 3:
						((Control)this).set_Height(num);
						return;
					}
					num3 = 3;
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void _0001(EventArgs _0020)
	{
		((Label)this).OnFontChanged(_0020);
		CraTZWhyTP();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void _0002(EventArgs _0020)
	{
		((Control)this).OnResize(_0020);
		CraTZWhyTP();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void _0003(EventArgs _0020)
	{
		((Label)this).OnTextChanged(_0020);
		CraTZWhyTP();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BUgpn54LHsSP29Ryc6b()
	{
		//Discarded unreachable code: IL_003d
		int num = 5;
		while (true)
		{
			int num2;
			switch (num)
			{
			case 5:
				QA1I51451Fm9FyPCw1q.nLTn9WFXoXK9o();
				num2 = 2;
				goto IL_0046;
			case 1:
			case 2:
				((Label)this)._002Ector();
				num2 = 4;
				goto IL_0046;
			case 4:
				((Label)this).set_FlatStyle((FlatStyle)3);
				break;
			default:
				num2 = 0;
				goto IL_0046;
			case 0:
			case 3:
				break;
			case 6:
				return;
			}
			((Label)this).set_UseMnemonic(false);
			num2 = 6;
			goto IL_0046;
			IL_0046:
			num = num2;
		}
	}

	internal static bool TiBHbrgj4A8G7gVe63y()
	{
		return true;
	}

	internal static bool B6kXV1gQlHOg7QYT9bO()
	{
		return false;
	}
}
