using System.Runtime.CompilerServices;
using System.Threading;
using di1mqJMz;

namespace ns0;

internal class O4cyMZfG : nEL4fiNj
{
	public delegate void BENVV3UP(nEL4fiNj sender, bool newValue);

	private bool OOjOLDLW;

	[CompilerGenerated]
	private BENVV3UP BvhkPA9U;

	bool nEL4fiNj.SU3dSNXE
	{
		get
		{
			return OOjOLDLW;
		}
		set
		{
			bool num = value != ns0_002EnEL4fiNj_002ESU3dSNXE;
			OOjOLDLW = value;
			if (num)
			{
				BvhkPA9U?.Invoke(this, ns0_002EnEL4fiNj_002ESU3dSNXE);
			}
		}
	}

	public event BENVV3UP LpQCjw51
	{
		[CompilerGenerated]
		add
		{
			BENVV3UP bENVV3UP = BvhkPA9U;
			BENVV3UP bENVV3UP2;
			do
			{
				bENVV3UP2 = bENVV3UP;
				BENVV3UP value2 = (BENVV3UP)FFXb5i9i.PcI4tKMj(bENVV3UP2, value, 32722);
				bENVV3UP = Interlocked.CompareExchange(ref BvhkPA9U, value2, bENVV3UP2);
			}
			while ((object)bENVV3UP != bENVV3UP2);
		}
		[CompilerGenerated]
		remove
		{
			BENVV3UP bENVV3UP = BvhkPA9U;
			BENVV3UP bENVV3UP2;
			do
			{
				bENVV3UP2 = bENVV3UP;
				BENVV3UP value2 = (BENVV3UP)FFXb5i9i.PcI4tKMj(bENVV3UP2, value, 32723);
				bENVV3UP = Interlocked.CompareExchange(ref BvhkPA9U, value2, bENVV3UP2);
			}
			while ((object)bENVV3UP != bENVV3UP2);
		}
	}

	public O4cyMZfG(bool CqLT3Xvq = false)
	{
		OOjOLDLW = CqLT3Xvq;
	}

	public void PDB22TYw()
	{
		ns0_002EnEL4fiNj_002ESU3dSNXE = false;
	}

	void nEL4fiNj.NUrti1kH()
	{
		//ILSpy generated this explicit interface implementation from .override directive in PDB22TYw
		this.PDB22TYw();
	}

	public void dz88nqLG()
	{
		ns0_002EnEL4fiNj_002ESU3dSNXE = true;
	}

	void nEL4fiNj.PDB22TYw()
	{
		//ILSpy generated this explicit interface implementation from .override directive in dz88nqLG
		this.dz88nqLG();
	}
}
