using System.Runtime.CompilerServices;
using System.Threading;
using CCfpfC7h;
using di1mqJMz;
using geYLBm6w;

namespace av2p5dFj;

internal class tlWY2AYk
{
	public delegate void Delegate0(string Name);

	public delegate void dFbz86XG(string Name);

	protected yXGcq0sI pBrQCWOc;

	[CompilerGenerated]
	[AccessedThroughProperty("m_Var")]
	private vilSnlZy yCzSx3Pd;

	protected VZxzVnkV GI7bWQWy;

	protected string string_0;

	protected yYtwns2j g48bOyIW;

	[CompilerGenerated]
	private Delegate0 IfUyK9pT;

	[CompilerGenerated]
	private dFbz86XG bANHzFjz;

	protected virtual vilSnlZy bFQLi2cB
	{
		[CompilerGenerated]
		get
		{
			return yCzSx3Pd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			vilSnlZy.BNlSm4u1 value2 = S7xv29Aa;
			vilSnlZy.GfIy5BT1 value3 = Sxrtak1X;
			vilSnlZy vilSnlZy = yCzSx3Pd;
			if (vilSnlZy != null)
			{
				vilSnlZy.e4hVAkDo -= value2;
				vilSnlZy.Event_0 -= value3;
			}
			yCzSx3Pd = value;
			vilSnlZy = yCzSx3Pd;
			if (vilSnlZy != null)
			{
				vilSnlZy.e4hVAkDo += value2;
				vilSnlZy.Event_0 += value3;
			}
		}
	}

	public yXGcq0sI aFHncCDh
	{
		get
		{
			return pBrQCWOc;
		}
		set
		{
			pBrQCWOc = value;
		}
	}

	public vilSnlZy DxitHPne
	{
		get
		{
			return bFQLi2cB;
		}
		set
		{
			bFQLi2cB = value;
		}
	}

	public VZxzVnkV iQmyfBoG
	{
		get
		{
			return GI7bWQWy;
		}
		set
		{
			GI7bWQWy = value;
		}
	}

	public string BzrTEiuM
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = value;
		}
	}

	public yYtwns2j DzAcOkPK
	{
		get
		{
			return g48bOyIW;
		}
		set
		{
			g48bOyIW = value;
		}
	}

	public event Delegate0 DWJyhzJS
	{
		[CompilerGenerated]
		add
		{
			Delegate0 @delegate = IfUyK9pT;
			Delegate0 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate0 value2 = (Delegate0)FFXb5i9i.PcI4tKMj(delegate2, value, 32722);
				@delegate = Interlocked.CompareExchange(ref IfUyK9pT, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
		[CompilerGenerated]
		remove
		{
			Delegate0 @delegate = IfUyK9pT;
			Delegate0 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate0 value2 = (Delegate0)FFXb5i9i.PcI4tKMj(delegate2, value, 32723);
				@delegate = Interlocked.CompareExchange(ref IfUyK9pT, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
	}

	public event dFbz86XG Tb25CuJT
	{
		[CompilerGenerated]
		add
		{
			dFbz86XG dFbz86XG = bANHzFjz;
			dFbz86XG dFbz86XG2;
			do
			{
				dFbz86XG2 = dFbz86XG;
				dFbz86XG value2 = (dFbz86XG)FFXb5i9i.PcI4tKMj(dFbz86XG2, value, 32722);
				dFbz86XG = Interlocked.CompareExchange(ref bANHzFjz, value2, dFbz86XG2);
			}
			while ((object)dFbz86XG != dFbz86XG2);
		}
		[CompilerGenerated]
		remove
		{
			dFbz86XG dFbz86XG = bANHzFjz;
			dFbz86XG dFbz86XG2;
			do
			{
				dFbz86XG2 = dFbz86XG;
				dFbz86XG value2 = (dFbz86XG)FFXb5i9i.PcI4tKMj(dFbz86XG2, value, 32723);
				dFbz86XG = Interlocked.CompareExchange(ref bANHzFjz, value2, dFbz86XG2);
			}
			while ((object)dFbz86XG != dFbz86XG2);
		}
	}

	public tlWY2AYk(yXGcq0sI yXGcq0sI_0, ref vilSnlZy EbH0gwzm, VZxzVnkV wjoNCXm1, string QxDhzuHz, yYtwns2j EJIjXarR)
	{
		pBrQCWOc = yXGcq0sI_0;
		bFQLi2cB = EbH0gwzm;
		GI7bWQWy = wjoNCXm1;
		string_0 = QxDhzuHz;
		g48bOyIW = EJIjXarR;
	}

	public bool l8M2ZTAD()
	{
		return GI7bWQWy.hdRfBnfa();
	}

	public Class8 t54ZInj6()
	{
		return GI7bWQWy.BaB0w6am;
	}

	private void S7xv29Aa(string t7lxNfpl)
	{
		IfUyK9pT?.Invoke(t7lxNfpl);
	}

	private void Sxrtak1X(string W0OtqHQg)
	{
		bANHzFjz?.Invoke(W0OtqHQg);
	}
}
