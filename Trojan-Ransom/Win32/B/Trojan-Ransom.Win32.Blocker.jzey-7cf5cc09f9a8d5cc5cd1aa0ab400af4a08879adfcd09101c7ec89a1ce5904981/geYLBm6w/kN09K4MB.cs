using System;
using System.Drawing;
using TGaER2JO;
using Y7FbhctW;
using ns4;

namespace geYLBm6w;

[Serializable]
internal abstract class kN09K4MB
{
	public bool tOI0B8BP;

	protected int ecacupAK;

	protected int cPoguDmD;

	protected int JoL4SDi3;

	protected Point gnSv1hng;

	protected bool bool_0;

	protected Rectangle rectangle_0;

	protected Color s4gcnwXA;

	protected Color U7V7w5IU;

	protected Color r7fjB6gZ;

	protected Color color_0;

	protected Font w23W0aTv;

	[NonSerialized]
	protected Graphics drlfOdj2;

	protected const int edVISxel = 4;

	protected const float Oh9ry25Y = 0.75f;

	public int CVGh0ugY
	{
		get
		{
			return cPoguDmD;
		}
		set
		{
			cPoguDmD = value;
		}
	}

	public int kEu8r4AN
	{
		get
		{
			return JoL4SDi3;
		}
		set
		{
			JoL4SDi3 = value;
		}
	}

	public Point NUNnH9dO
	{
		get
		{
			return gnSv1hng;
		}
		set
		{
			gnSv1hng = value;
		}
	}

	public bool pStZ7GO9
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
		}
	}

	public kN09K4MB(int mVswJ6kc, Point FHq6dqXc, Color YjWGu0JD, Color NcZ76wTb, Color color_1, Color cTGPGrgM, Font CQvtnjBl, Graphics cOJx7c59)
	{
		ecacupAK = mVswJ6kc;
		JoL4SDi3 = checked(mVswJ6kc * 4);
		cPoguDmD = yxMhuPYn();
		gnSv1hng = FHq6dqXc;
		s4gcnwXA = YjWGu0JD;
		U7V7w5IU = NcZ76wTb;
		r7fjB6gZ = color_1;
		color_0 = cTGPGrgM;
		w23W0aTv = CQvtnjBl;
		drlfOdj2 = cOJx7c59;
		rectangle_0 = default(Rectangle);
	}

	public kN09K4MB()
	{
	}

	protected abstract int yxMhuPYn();

	public Rectangle OeZ9LONv()
	{
		return rectangle_0;
	}

	public void QauBkUXl()
	{
		sSR2WoR5.IbTYXQVQ(this, 2531);
	}

	public void Vcvg0pON(int tjXAJVEZ, int Nx0rs70O)
	{
		checked
		{
			gnSv1hng.X += tjXAJVEZ;
			for (int num = 0; num == 0; num = 1)
			{
				gnSv1hng.Y += Nx0rs70O;
			}
		}
	}

	protected abstract void vmethod_0(Color E2OqhgO1, Color irFHvEj2, Color Cy81JY2d);

	public void method_0()
	{
		vmethod_0(U7V7w5IU, r7fjB6gZ, color_0);
	}

	public void RnBUHO8o()
	{
		vmethod_0(s4gcnwXA, s4gcnwXA, s4gcnwXA);
	}

	public void qcFsRdLU(ref Graphics vuNMTvTN)
	{
		drlfOdj2 = vuNMTvTN;
	}

	public bool bGd0NAYt(int hFImjKiY, int oC1gryWP)
	{
		if (checked((hFImjKiY >= gnSv1hng.X) & (hFImjKiY < gnSv1hng.X + JoL4SDi3) & ((double)wBNSfNgl.bGpy8YPP(oC1gryWP - gnSv1hng.Y, 50085) < (double)cPoguDmD / 2.0)))
		{
			return true;
		}
		bool result = default(bool);
		return result;
	}

	public Rectangle eIIkbeol()
	{
		checked
		{
			Rectangle result = default(Rectangle);
			result.X = gnSv1hng.X - 1;
			result.Y = (int)O4s9Dog1.zxrdwZWP((double)gnSv1hng.Y - (double)cPoguDmD / 2.0 - 1.0, 40554);
			result.Width = JoL4SDi3 + 2;
			result.Height = cPoguDmD + 2;
			return result;
		}
	}
}
