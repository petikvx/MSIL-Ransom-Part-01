using System;
using System.Runtime.CompilerServices;
using System.Threading;
using CCfpfC7h;
using di1mqJMz;
using geYLBm6w;
using ns0;
using ns2;

namespace ZqaFD1Ap;

[Serializable]
internal class sm18FGKs : GnNqYKdA
{
	public delegate void Delegate5();

	protected GEBbAG79 RNPyC3En;

	[CompilerGenerated]
	[AccessedThroughProperty("m_GrafcetVariables")]
	private Uj8nVl61 Q3btZrrL;

	[CompilerGenerated]
	private Delegate5 pENysgl3;

	protected virtual Uj8nVl61 Uj8nVl61_0
	{
		[CompilerGenerated]
		get
		{
			return Q3btZrrL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			Uj8nVl61.IpfNq9cF value2 = delegate
			{
				GVA1yqUn();
			};
			Uj8nVl61.nrBDc9K1 value3 = delegate
			{
				GVA1yqUn();
			};
			Uj8nVl61.OdSAB6kX value4 = delegate
			{
				GVA1yqUn();
			};
			Uj8nVl61.zbQ7ZLAJ value5 = GVA1yqUn;
			Uj8nVl61 q3btZrrL = Q3btZrrL;
			if (q3btZrrL != null)
			{
				q3btZrrL.Event_0 -= value2;
				q3btZrrL.VTTYn86B -= value3;
				q3btZrrL.HFCjL5QW -= value4;
				q3btZrrL.tW2SRCt8 -= value5;
			}
			Q3btZrrL = value;
			q3btZrrL = Q3btZrrL;
			if (q3btZrrL != null)
			{
				q3btZrrL.Event_0 += value2;
				q3btZrrL.VTTYn86B += value3;
				q3btZrrL.HFCjL5QW += value4;
				q3btZrrL.tW2SRCt8 += value5;
			}
		}
	}

	public override GEBbAG79 U241pHzB => RNPyC3En;

	public override Uj8nVl61 rLqNMLgo => RNPyC3En.XvLGPGVT;

	public override Uj8nVl61 FCB6aCiu => Uj8nVl61_0;

	public event Delegate5 jFmHv6Yg
	{
		[CompilerGenerated]
		add
		{
			Delegate5 @delegate = pENysgl3;
			Delegate5 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate5 value2 = (Delegate5)FFXb5i9i.PcI4tKMj(delegate2, value, 32722);
				@delegate = Interlocked.CompareExchange(ref pENysgl3, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
		[CompilerGenerated]
		remove
		{
			Delegate5 @delegate = pENysgl3;
			Delegate5 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate5 value2 = (Delegate5)FFXb5i9i.PcI4tKMj(delegate2, value, 32723);
				@delegate = Interlocked.CompareExchange(ref pENysgl3, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
	}

	public sm18FGKs(ref GEBbAG79 gebbAG79_0, string UzB8129X)
		: base(UzB8129X)
	{
		RNPyC3En = gebbAG79_0;
		Uj8nVl61_0 = new Uj8nVl61();
	}

	public sm18FGKs()
	{
		RNPyC3En = new GEBbAG79();
		Uj8nVl61_0 = new Uj8nVl61();
	}

	public override object d8KtJE2g()
	{
		sm18FGKs sm18FGKs2 = new sm18FGKs(ref RNPyC3En, fbpqob0x);
		StKhY3Gf wpugRovX = WpugRovX;
		GnNqYKdA I5kk6D9q = sm18FGKs2;
		StKhY3Gf stKhY3Gf = wpugRovX.GJ3ja957(ref I5kk6D9q);
		sm18FGKs2 = (sm18FGKs)I5kk6D9q;
		StKhY3Gf GhytSO3c = stKhY3Gf;
		LQPodRO3 lQPodRO = bu6xGmcT;
		I5kk6D9q = sm18FGKs2;
		LQPodRO3 lQPodRO2 = lQPodRO.gaaF6IMC(ref I5kk6D9q, ref GhytSO3c);
		sm18FGKs2 = (sm18FGKs)I5kk6D9q;
		LQPodRO3 lQPodRO3 = lQPodRO2;
		sm18FGKs2.PAwen1cW = GhytSO3c;
		sm18FGKs2.yKovkzbq = lQPodRO3;
		return sm18FGKs2;
	}

	public override string WrbkIYgy()
	{
		return fbpqob0x;
	}

	public override sm18FGKs L0TyRGNz()
	{
		return this;
	}

	protected void GVA1yqUn()
	{
		pENysgl3?.Invoke();
	}

	public void DmoRoQOu(ref GEBbAG79 dTrRta7T)
	{
		method_6();
		for (int num = 0; num == 0; num = 1)
		{
			RNPyC3En = dTrRta7T;
		}
	}

	[CompilerGenerated]
	private void iM7WAUz2(ref vilSnlZy vilSnlZy_0)
	{
		GVA1yqUn();
	}

	[CompilerGenerated]
	private void method_7(ref vilSnlZy L7U8Biuw)
	{
		GVA1yqUn();
	}

	[CompilerGenerated]
	private void OGIMjYMI(ref vilSnlZy MlNuFcf2)
	{
		GVA1yqUn();
	}
}
