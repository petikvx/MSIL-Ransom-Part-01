using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using CCfpfC7h;
using P5EWkEJj;
using TGaER2JO;
using VeeC76Ht;
using ZqaFD1Ap;
using av2p5dFj;
using di1mqJMz;
using geYLBm6w;
using iiraiv39;
using sReLFYF2;
using wMk1FHff;
using yer6kF3B;

namespace ns2;

[Serializable]
internal class StKhY3Gf : List<GAJDqHR0>
{
	private GnNqYKdA GJEzdiRJ;

	private int QtgjwJax;

	private Color LTnn9lAh;

	private Color SNWblfsh;

	private Color uZC9yCO2;

	private Font G00oTDRQ;

	private Color xVYskkhk;

	private Color color_0;

	private Color color_1;

	private Color color_2;

	[NonSerialized]
	private Graphics W5DqhZWa;

	private bool Ih0aVpFZ;

	public Uj8nVl61 WPnZD80X
	{
		set
		{
			using Enumerator enumerator = GetEnumerator();
			int num = 0;
			GAJDqHR0 current = default(GAJDqHR0);
			while (true)
			{
				if (num == 0 || ivlgLlId.smethod_3(FFXb5i9i.pOhcgUVE(FFXb5i9i.VcIT67Rx(current, 58039), 54497), "GraphicalMacroStep", bool_0: false, 3221) == 0)
				{
				}
				if (enumerator.MoveNext())
				{
					current = enumerator.Current;
					num = 1;
					continue;
				}
				break;
			}
		}
	}

	public StKhY3Gf(ref GnNqYKdA m7NShSpq, Color vsVQhqBa, Color i1E1Zy3F, Color color_3, Color q6cHklCY, Font ctDGdK03, Color color_4, Color color_5, Color XUqbeUPX, ref Graphics oGPvVnrf, int scJtNZnL)
	{
		GJEzdiRJ = m7NShSpq;
		LTnn9lAh = i1E1Zy3F;
		SNWblfsh = color_3;
		xVYskkhk = vsVQhqBa;
		uZC9yCO2 = q6cHklCY;
		G00oTDRQ = ctDGdK03;
		color_0 = color_4;
		color_2 = color_5;
		color_1 = XUqbeUPX;
		W5DqhZWa = oGPvVnrf;
		QtgjwJax = scJtNZnL;
	}

	public StKhY3Gf(ref BinaryReader eoDcsOlF, Color S5JjjOOe, Color wc7XPmTG, Color GCmqO7KX, Color xEXPhDuA, Font laDPE8VD, Color nuWASpWR, Color vWwQrURL, Color kLLERZXT, ref Graphics IwCEJ32x)
	{
		LTnn9lAh = wc7XPmTG;
		SNWblfsh = GCmqO7KX;
		xVYskkhk = S5JjjOOe;
		uZC9yCO2 = xEXPhDuA;
		G00oTDRQ = laDPE8VD;
		color_0 = nuWASpWR;
		color_2 = vWwQrURL;
		color_1 = kLLERZXT;
		W5DqhZWa = IwCEJ32x;
		Class16.MnIpuB8b(eoDcsOlF, 50393);
	}

	public StKhY3Gf()
	{
	}

	public StKhY3Gf GJ3ja957(ref GnNqYKdA I5kk6D9q)
	{
		Color vsVQhqBa = xVYskkhk;
		Color lTnn9lAh = LTnn9lAh;
		Color sNWblfsh = SNWblfsh;
		Color q6cHklCY = uZC9yCO2;
		Font g00oTDRQ = G00oTDRQ;
		Color color_ = color_0;
		Color color_2 = this.color_2;
		Color xUqbeUPX = color_1;
		Graphics oGPvVnrf = null;
		StKhY3Gf stKhY3Gf = new StKhY3Gf(ref I5kk6D9q, vsVQhqBa, lTnn9lAh, sNWblfsh, q6cHklCY, g00oTDRQ, color_, color_2, xUqbeUPX, ref oGPvVnrf, QtgjwJax);
		using Enumerator enumerator = GetEnumerator();
		int num = 0;
		GAJDqHR0 current = default(GAJDqHR0);
		while (true)
		{
			if (num != 0)
			{
				stKhY3Gf.Add((GAJDqHR0)current.eVuQ0d1c(ref I5kk6D9q));
			}
			if (enumerator.MoveNext())
			{
				current = enumerator.Current;
				num = 1;
				continue;
			}
			break;
		}
		return stKhY3Gf;
	}

	public void jSuSmhMo()
	{
		using (Enumerator enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				enumerator.Current.pHlxhd6X();
			}
		}
		sSR2WoR5.IbTYXQVQ(this, 2531);
	}

	public void w3SlNh8r(ref Graphics UY9IQxAb)
	{
		W5DqhZWa = UY9IQxAb;
		using Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current.kvH1F9D5(ref W5DqhZWa);
		}
	}

	public void GEWLEDM4(bool nblRyaap)
	{
		Ih0aVpFZ = nblRyaap;
		using Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current.method_0(ref Ih0aVpFZ);
		}
	}

	public void WFN7hJkr()
	{
		using Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current.method_9(xlm9hdPs: false);
		}
	}

	public void XSp8urAM(GAJDqHR0 hjcIk1JT)
	{
		Add(hjcIk1JT);
	}

	public void gNYCVhTK(int NKLbKtTX, string kuNLdEAW, string BzzeXs4V, Point VTQtKIvG, bool ZFkJFo1O, bool peoPdYGC = false)
	{
		joI8IGp3 joI8IGp4 = new joI8IGp3(NKLbKtTX, kuNLdEAW, BzzeXs4V, ref GJEzdiRJ, peoPdYGC, aKZV2VkB: false, VTQtKIvG, xVYskkhk, LTnn9lAh, SNWblfsh, uZC9yCO2, G00oTDRQ, color_0, color_2, color_1, ref W5DqhZWa, ZFkJFo1O, QtgjwJax);
		Add(joI8IGp4);
		joI8IGp4.sAB6sPSc(DzzG46kX: false);
	}

	public void d20lHEMl(int FQgQCqcC, string Z7MxjQgc, string xKOI3eHX, Point ddgHH9Yk, bool TZ4O8bbZ, bool bool_0 = false, bool LNOXQ3iq = false)
	{
		dOl6EfdB dOl6EfdB = new dOl6EfdB(FQgQCqcC, Z7MxjQgc, xKOI3eHX, ref GJEzdiRJ, bool_0, ItPiLvnB: false, ref LNOXQ3iq, ddgHH9Yk, xVYskkhk, LTnn9lAh, SNWblfsh, uZC9yCO2, G00oTDRQ, color_0, color_2, color_1, ref W5DqhZWa, TZ4O8bbZ, QtgjwJax);
		Add(dOl6EfdB);
		dOl6EfdB.sAB6sPSc(TgkOAk9H: false);
	}

	public void method_0(int int_0, string yPGgoAL5, string UTVTl1uP, ref Uj8nVl61 GDEPyNPx, Point R1YJtYAj, bool Jro0m12z)
	{
		Z9B67Lte z9B67Lte = new Z9B67Lte(int_0, yPGgoAL5, UTVTl1uP, ref GJEzdiRJ, R1YJtYAj, xVYskkhk, LTnn9lAh, SNWblfsh, uZC9yCO2, G00oTDRQ, color_0, color_2, color_1, W5DqhZWa, Jro0m12z, QtgjwJax);
		Add(z9B67Lte);
		z9B67Lte.sAB6sPSc(qyZ0RxWp: false);
	}

	public void xxthz1t6(int XOD8NeNL, string string_0, string iCaTDtsF, Point B5i1jyYQ, bool xRMEksvu, bool EC0dCGXu = false)
	{
		mQUbpu5F mQUbpu5F = new mQUbpu5F(XOD8NeNL, string_0, iCaTDtsF, ref GJEzdiRJ, EC0dCGXu, MoVgRz5I: false, B5i1jyYQ, xVYskkhk, LTnn9lAh, SNWblfsh, uZC9yCO2, G00oTDRQ, color_0, color_2, color_1, ref W5DqhZWa, xRMEksvu, QtgjwJax);
		Add(mQUbpu5F);
		mQUbpu5F.sAB6sPSc(DzzG46kX: false);
	}

	public bool VxYWQztu(int mYxIVMsr, int bxOKgXBQ)
	{
		using Enumerator enumerator = GetEnumerator();
		bool result = default(bool);
		while (enumerator.MoveNext())
		{
			GAJDqHR0 current = enumerator.Current;
			if (current.method_6(mYxIVMsr, bxOKgXBQ))
			{
				result = true;
				current.rFS5UJ2s(x4OMnpHh: true);
				return result;
			}
		}
		return result;
	}

	public bool method_1(int int_0, int nhimUMyR)
	{
		using Enumerator enumerator = GetEnumerator();
		bool result = default(bool);
		for (int num = 0; num == 0; num = 1)
		{
			do
			{
				if (!enumerator.MoveNext())
				{
					return result;
				}
			}
			while (!enumerator.Current.method_6(int_0, nhimUMyR));
			result = true;
		}
		return result;
	}

	public bool az24RceY(int W7Pbkt16, int VBA8GGS9)
	{
		using Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			GAJDqHR0 current = enumerator.Current;
			if (current.method_6(W7Pbkt16, VBA8GGS9) & current.BuNRjH7Y())
			{
				return true;
			}
		}
		bool result = default(bool);
		return result;
	}

	public void xQnYEfVk(Rectangle rectangle_0)
	{
		checked
		{
			using Enumerator enumerator = GetEnumerator();
			while (enumerator.MoveNext())
			{
				GAJDqHR0 current = enumerator.Current;
				int num = current.Ak6q13HJ();
				int x = rectangle_0.X;
				int num2 = rectangle_0.X + rectangle_0.Width;
				int num3 = num;
				int i;
				int j;
				for (i = x; ((num3 >> 31) ^ i) <= ((num3 >> 31) ^ num2); i += num3)
				{
					int y = rectangle_0.Y;
					int num4 = rectangle_0.Y + rectangle_0.Height;
					int num5 = num;
					for (j = y; ((num5 >> 31) ^ j) <= ((num5 >> 31) ^ num4); j += num5)
					{
						if (current.method_6(i, j))
						{
							current.rFS5UJ2s(x4OMnpHh: true);
						}
					}
				}
				i = rectangle_0.X + rectangle_0.Width;
				int y2 = rectangle_0.Y;
				int num6 = rectangle_0.Y + rectangle_0.Height;
				int num7 = num;
				for (j = y2; ((num7 >> 31) ^ j) <= ((num7 >> 31) ^ num6); j += num7)
				{
					if (current.method_6(i, j))
					{
						current.rFS5UJ2s(x4OMnpHh: true);
					}
				}
				j = rectangle_0.Y + rectangle_0.Height;
				int x2 = rectangle_0.X;
				int num8 = rectangle_0.X + rectangle_0.Width;
				int num9 = num;
				for (i = x2; ((num9 >> 31) ^ i) <= ((num9 >> 31) ^ num8); i += num9)
				{
					if (current.method_6(i, j))
					{
						current.rFS5UJ2s(x4OMnpHh: true);
					}
				}
				i = rectangle_0.X + rectangle_0.Width;
				j = rectangle_0.Y + rectangle_0.Height;
				if (current.method_6(i, j))
				{
					current.rFS5UJ2s(x4OMnpHh: true);
				}
			}
		}
	}

	public GAJDqHR0 z7PscODT(int gbqicqbt)
	{
		using (Enumerator enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				GAJDqHR0 current = enumerator.Current;
				if (current.Int32_0 == gbqicqbt)
				{
					return current;
				}
			}
		}
		return null;
	}

	public int GSw0PgkH()
	{
		int num = 0;
		checked
		{
			while (num < base.Count + 1)
			{
				num++;
				bool flag = true;
				using (Enumerator enumerator = GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						GAJDqHR0 current = enumerator.Current;
						if (current is joI8IGp3 && current.Int32_0 == num)
						{
							flag = false;
							break;
						}
					}
				}
				if (flag)
				{
					return num;
				}
			}
			int result = default(int);
			return result;
		}
	}

	public int bu4WD8UX()
	{
		int num = 0;
		checked
		{
			while (num < base.Count + 1)
			{
				num++;
				bool flag = true;
				using (Enumerator enumerator = GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						GAJDqHR0 current = enumerator.Current;
						if (ivlgLlId.smethod_3(FFXb5i9i.pOhcgUVE(FFXb5i9i.VcIT67Rx(current, 58039), 54497), "GraphicalMacroStep", bool_0: false, 3221) == 0 && current.Int32_0 == num)
						{
							flag = false;
							break;
						}
					}
				}
				if (flag)
				{
					return num;
				}
			}
			int result = default(int);
			return result;
		}
	}

	public GAJDqHR0 yEzzRqXJ(int dtHtOC8F)
	{
		return base[clckr36i(dtHtOC8F)];
	}

	public int clckr36i(int M8gHJGg8)
	{
		int result = -1;
		checked
		{
			int num = base.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				if (base[i].Int32_0 == M8gHJGg8)
				{
					result = i;
					break;
				}
			}
			return result;
		}
	}

	public int hsKxRBCg(ref GAJDqHR0 VNNmyRSz)
	{
		int num = IndexOf(VNNmyRSz);
		if (FFXb5i9i.smethod_1(num, 48316))
		{
			num = -1;
		}
		return num;
	}

	public int moKiVAwu()
	{
		return base.Count;
	}

	public void ygMJ9fZw()
	{
		int num = 0;
		checked
		{
			int num2 = base.Count - 1;
			for (int i = 0; i <= num2; i++)
			{
				if (base[i - num] is joI8IGp3)
				{
					((joI8IGp3)base[i - num]).y3eQZiAN();
				}
				if (base[i - num].BuNRjH7Y())
				{
					base[i - num].pHlxhd6X();
					RemoveAt(i - num);
					num++;
				}
			}
		}
	}

	public StKhY3Gf dzbmRAOB()
	{
		StKhY3Gf stKhY3Gf = new StKhY3Gf();
		using Enumerator enumerator = GetEnumerator();
		int num = 0;
		GAJDqHR0 current = default(GAJDqHR0);
		while (true)
		{
			if (num != 0 && current.BuNRjH7Y())
			{
				stKhY3Gf.XSp8urAM(current);
			}
			if (enumerator.MoveNext())
			{
				current = enumerator.Current;
				num = 1;
				continue;
			}
			break;
		}
		return stKhY3Gf;
	}

	public StKhY3Gf JVoDfKJV()
	{
		StKhY3Gf stKhY3Gf = new StKhY3Gf();
		using Enumerator enumerator = GetEnumerator();
		int num = 0;
		GAJDqHR0 current = default(GAJDqHR0);
		while (true)
		{
			if (num != 0 && current.method_3())
			{
				stKhY3Gf.XSp8urAM(current);
			}
			if (enumerator.MoveNext())
			{
				current = enumerator.Current;
				num = 1;
				continue;
			}
			break;
		}
		return stKhY3Gf;
	}

	public StKhY3Gf fHllWYcH()
	{
		StKhY3Gf stKhY3Gf = new StKhY3Gf();
		using Enumerator enumerator = GetEnumerator();
		int num = 0;
		GAJDqHR0 current = default(GAJDqHR0);
		while (true)
		{
			if (num != 0 && current.RBLdZ1ok())
			{
				stKhY3Gf.XSp8urAM(current);
			}
			if (enumerator.MoveNext())
			{
				current = enumerator.Current;
				num = 1;
				continue;
			}
			break;
		}
		return stKhY3Gf;
	}

	public ArrayList VgZAOT6G()
	{
		ArrayList arrayList = new ArrayList();
		using Enumerator enumerator = GetEnumerator();
		int num = 0;
		object current = default(object);
		while (true)
		{
			if (num != 0 && FFXb5i9i.rs8UXJ4a(FFXb5i9i.smethod_2(current, null, "IsAStep", new object[0], null, null, null, 44005), 21077) && F10yQwkZ.K3qKGRBN(FFXb5i9i.smethod_2(FFXb5i9i.smethod_2(current, null, "ReadSelectedActionsList", new object[0], null, null, null, 44005), null, "Count", new object[0], null, null, null, 44005), 0, bool_0: false, 48865))
			{
				Class16.kyNq7GLZ(arrayList, (ICollection)FFXb5i9i.smethod_2(current, null, "ReadSelectedActionsList", new object[0], null, null, null, 44005), 14029);
			}
			if (enumerator.MoveNext())
			{
				current = enumerator.Current;
				num = 1;
				continue;
			}
			break;
		}
		return arrayList;
	}

	public bool Oh8ZFwHM(int A9yZbTfO, int xQtsTEAf)
	{
		using Enumerator enumerator = GetEnumerator();
		bool result = default(bool);
		while (true)
		{
			if (enumerator.MoveNext())
			{
				object current = enumerator.Current;
				if (FFXb5i9i.rs8UXJ4a(FFXb5i9i.smethod_2(current, null, "IsAStep", new object[0], null, null, null, 44005), 21077))
				{
					object[] obj = new object[2] { A9yZbTfO, xQtsTEAf };
					object[] array = obj;
					bool[] obj2 = new bool[2] { true, true };
					bool[] array2 = obj2;
					object object_ = FFXb5i9i.smethod_2(current, null, "FindAndSelectAction", obj, null, null, obj2, 44005);
					if (array2[0])
					{
						A9yZbTfO = (int)ITnaJzyl.YxYsb6cN(m8meAX3U.bErpAbl3(array[0], 6598), m8meAX3U.NXTa0utH(typeof(int).TypeHandle, 9099), 4232);
					}
					if (array2[1])
					{
						xQtsTEAf = (int)ITnaJzyl.YxYsb6cN(m8meAX3U.bErpAbl3(array[1], 6598), m8meAX3U.NXTa0utH(typeof(int).TypeHandle, 9099), 4232);
					}
					if (result = FFXb5i9i.rs8UXJ4a(object_, 21077))
					{
						break;
					}
				}
				continue;
			}
			return result;
		}
		return result;
	}

	public bool muqBAdMP(int PHPYBKgJ, int ZzKNpdv2)
	{
		using Enumerator enumerator = GetEnumerator();
		bool result = default(bool);
		while (true)
		{
			if (enumerator.MoveNext())
			{
				object current = enumerator.Current;
				if (FFXb5i9i.rs8UXJ4a(FFXb5i9i.smethod_2(current, null, "IsAStep", new object[0], null, null, null, 44005), 21077))
				{
					object[] obj = new object[2] { PHPYBKgJ, ZzKNpdv2 };
					object[] array = obj;
					bool[] obj2 = new bool[2] { true, true };
					bool[] array2 = obj2;
					object object_ = FFXb5i9i.smethod_2(current, null, "FindAction", obj, null, null, obj2, 44005);
					if (array2[0])
					{
						PHPYBKgJ = (int)ITnaJzyl.YxYsb6cN(m8meAX3U.bErpAbl3(array[0], 6598), m8meAX3U.NXTa0utH(typeof(int).TypeHandle, 9099), 4232);
					}
					if (array2[1])
					{
						ZzKNpdv2 = (int)ITnaJzyl.YxYsb6cN(m8meAX3U.bErpAbl3(array[1], 6598), m8meAX3U.NXTa0utH(typeof(int).TypeHandle, 9099), 4232);
					}
					if (result = FFXb5i9i.rs8UXJ4a(object_, 21077))
					{
						break;
					}
				}
				continue;
			}
			return result;
		}
		return result;
	}

	public bool method_2(int GTCb55bn, int mJat4gcM)
	{
		using Enumerator enumerator = GetEnumerator();
		bool result = default(bool);
		while (true)
		{
			if (enumerator.MoveNext())
			{
				object current = enumerator.Current;
				if (FFXb5i9i.rs8UXJ4a(FFXb5i9i.smethod_2(current, null, "IsAStep", new object[0], null, null, null, 44005), 21077))
				{
					object[] obj = new object[2] { GTCb55bn, mJat4gcM };
					object[] array = obj;
					bool[] obj2 = new bool[2] { true, true };
					bool[] array2 = obj2;
					object object_ = FFXb5i9i.smethod_2(current, null, "ReadIfActionSelected", obj, null, null, obj2, 44005);
					if (array2[0])
					{
						GTCb55bn = (int)ITnaJzyl.YxYsb6cN(m8meAX3U.bErpAbl3(array[0], 6598), m8meAX3U.NXTa0utH(typeof(int).TypeHandle, 9099), 4232);
					}
					if (array2[1])
					{
						mJat4gcM = (int)ITnaJzyl.YxYsb6cN(m8meAX3U.bErpAbl3(array[1], 6598), m8meAX3U.NXTa0utH(typeof(int).TypeHandle, 9099), 4232);
					}
					if (result = FFXb5i9i.rs8UXJ4a(object_, 21077))
					{
						break;
					}
				}
				continue;
			}
			return result;
		}
		return result;
	}

	public bool AKtkTNQ9(int YoAp9Ppb, int VFhH85DU)
	{
		using Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			GAJDqHR0 current = enumerator.Current;
			if (current.method_6(YoAp9Ppb, VFhH85DU) & current.BuNRjH7Y())
			{
				return true;
			}
		}
		bool result = default(bool);
		return result;
	}

	public void nnqF22YK(Rectangle YgnFasgT)
	{
		using Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			object current = enumerator.Current;
			if (FFXb5i9i.rs8UXJ4a(FFXb5i9i.smethod_2(current, null, "IsAStep", new object[0], null, null, null, 44005), 21077))
			{
				object[] obj = new object[1] { YgnFasgT };
				object[] array = obj;
				bool[] obj2 = new bool[1] { true };
				bool[] array2 = obj2;
				ITnaJzyl.b26YxPWq(current, null, "FindAndSelectActions", obj, null, null, obj2, bool_1: true, 40814);
				if (array2[0])
				{
					YgnFasgT = (Rectangle)ITnaJzyl.YxYsb6cN(m8meAX3U.bErpAbl3(array[0], 6598), m8meAX3U.NXTa0utH(typeof(Rectangle).TypeHandle, 9099), 4232);
				}
			}
		}
	}

	public bool method_3(int jZyoYvEv, int int_0)
	{
		using Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			GAJDqHR0 current = enumerator.Current;
			if (!current.VVtvCEmd(jZyoYvEv, int_0))
			{
				if (current.crVElN9Y(jZyoYvEv, int_0))
				{
					current.kKgZBGWo(!current.RBLdZ1ok());
					return true;
				}
				continue;
			}
			current.method_2(!current.method_3());
			return true;
		}
		bool result = default(bool);
		return result;
	}

	public void qQrSrK0s()
	{
		using Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			object current = enumerator.Current;
			ITnaJzyl.b26YxPWq(current, null, "SetSelected", new object[1] { false }, null, null, null, bool_1: true, 40814);
			ITnaJzyl.b26YxPWq(current, null, "SetBottomRectSelected", new object[1] { false }, null, null, null, bool_1: true, 40814);
			ITnaJzyl.b26YxPWq(current, null, "SetTopRectSelected", new object[1] { false }, null, null, null, bool_1: true, 40814);
			if (FFXb5i9i.rs8UXJ4a(FFXb5i9i.smethod_2(current, null, "IsAStep", new object[0], null, null, null, 44005), 21077))
			{
				ITnaJzyl.b26YxPWq(current, null, "DeSelectActions", new object[0], null, null, null, bool_1: true, 40814);
			}
		}
	}

	public void ooDFSWpC()
	{
		using Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			ITnaJzyl.b26YxPWq(enumerator.Current, null, "SetSelected", new object[1] { true }, null, null, null, bool_1: true, 40814);
		}
	}

	public void aTm3tzLt(Rectangle BSzBvKxT, bool lggDkk5y)
	{
		using Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			GAJDqHR0 current = enumerator.Current;
			if (current.XjiVOLzY().IntersectsWith(BSzBvKxT))
			{
				current.sAB6sPSc(lggDkk5y);
			}
		}
	}

	public void Y50ARZC9(bool bool_0)
	{
		using Enumerator enumerator = GetEnumerator();
		int num = 0;
		GAJDqHR0 current = default(GAJDqHR0);
		while (true)
		{
			if (num != 0 && current.BuNRjH7Y())
			{
				current.sAB6sPSc(bool_0);
			}
			if (enumerator.MoveNext())
			{
				current = enumerator.Current;
				num = 1;
				continue;
			}
			break;
		}
	}

	public void method_4(int RKkCGLiP, int NN5oybBC)
	{
		using Enumerator enumerator = GetEnumerator();
		int num = 0;
		GAJDqHR0 current = default(GAJDqHR0);
		while (true)
		{
			if (num != 0 && current.BuNRjH7Y())
			{
				current.kMYcFQrD(RKkCGLiP, NN5oybBC);
			}
			if (enumerator.MoveNext())
			{
				current = enumerator.Current;
				num = 1;
				continue;
			}
			break;
		}
	}

	public void fpsbp35h(yXGcq0sI Npyl3voz, ref vilSnlZy vilSnlZy_0, VZxzVnkV vzxzVnkV_0, string mEkKWLeN, yYtwns2j E2PgdWMh)
	{
		using Enumerator enumerator = GetEnumerator();
		int num = 0;
		object current = default(object);
		while (true)
		{
			if (num != 0 && FFXb5i9i.rs8UXJ4a(FFXb5i9i.TCNI2YTH(FFXb5i9i.smethod_2(current, null, "ReadSelected", new object[0], null, null, null, 44005), FFXb5i9i.smethod_2(current, null, "IsAStep", new object[0], null, null, null, 44005), 1483), 21077))
			{
				((joI8IGp3)current).JWGuPiPO(Npyl3voz, ref vilSnlZy_0, vzxzVnkV_0, mEkKWLeN, E2PgdWMh);
			}
			if (enumerator.MoveNext())
			{
				current = enumerator.Current;
				num = 1;
				continue;
			}
			break;
		}
	}

	public void pvfbruXf(ref sm18FGKs W5aSn5iI, MxjPN5Gd mxjPN5Gd_0, ref StKhY3Gf stKhY3Gf_0)
	{
		using Enumerator enumerator = GetEnumerator();
		int num = 0;
		object current = default(object);
		while (true)
		{
			if (num != 0 && FFXb5i9i.rs8UXJ4a(FFXb5i9i.TCNI2YTH(FFXb5i9i.smethod_2(current, null, "ReadSelected", new object[0], null, null, null, 44005), FFXb5i9i.smethod_2(current, null, "IsAStep", new object[0], null, null, null, 44005), 1483), 21077))
			{
				((joI8IGp3)current).J3WbREen(ref W5aSn5iI, mxjPN5Gd_0, ref stKhY3Gf_0);
			}
			if (enumerator.MoveNext())
			{
				current = enumerator.Current;
				num = 1;
				continue;
			}
			break;
		}
	}

	public bool KnAtO6sR()
	{
		using Enumerator enumerator = GetEnumerator();
		bool result = default(bool);
		while (enumerator.MoveNext())
		{
			GAJDqHR0 current = enumerator.Current;
			if (current.OqG5Jn98() & current.BuNRjH7Y())
			{
				result = true;
				((joI8IGp3)current).mAvsI2FW(!((joI8IGp3)current).EZTgWQlY());
			}
		}
		return result;
	}

	public bool H4OQBlpy()
	{
		using Enumerator enumerator = GetEnumerator();
		bool result = default(bool);
		while (enumerator.MoveNext())
		{
			GAJDqHR0 current = enumerator.Current;
			if (current.OqG5Jn98() & current.BuNRjH7Y())
			{
				result = true;
				((joI8IGp3)current).JztIciSx(!((joI8IGp3)current).pcprwvrA());
			}
		}
		return result;
	}

	public void J68xXn6M(bool ST2v2l5J)
	{
		using Enumerator enumerator = GetEnumerator();
		int num = 0;
		GAJDqHR0 current = default(GAJDqHR0);
		while (true)
		{
			if (num != 0 && current.BuNRjH7Y())
			{
				current.ns0_002EBF4Ltdel_002ElVY5bdPP(ST2v2l5J);
			}
			if (enumerator.MoveNext())
			{
				current = enumerator.Current;
				num = 1;
				continue;
			}
			break;
		}
	}

	public bool V580vPT0(Rectangle d7G7ONKN, ref bool wTS45C7m, ref bool hOAV4WPm)
	{
		using Enumerator enumerator = GetEnumerator();
		GAJDqHR0 current;
		bool result = default(bool);
		do
		{
			if (enumerator.MoveNext())
			{
				current = enumerator.Current;
				continue;
			}
			return result;
		}
		while (!current.BuNRjH7Y() || !(result = SC9OdAxX.smethod_2(d7G7ONKN, current.XjiVOLzY(), ref wTS45C7m, ref hOAV4WPm)));
		return result;
	}

	public int Z5Uwcp3U()
	{
		int num = 0;
		using Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			if (enumerator.Current.BuNRjH7Y())
			{
				num = checked(num + 1);
			}
		}
		return num;
	}

	public int c7kQHZX5()
	{
		int num = 0;
		using Enumerator enumerator = GetEnumerator();
		int num2 = 0;
		object current = default(object);
		while (true)
		{
			if (num2 != 0 && FFXb5i9i.rs8UXJ4a(FFXb5i9i.smethod_2(current, null, "IsAStep", new object[0], null, null, null, 44005), 21077))
			{
				num = FFXb5i9i.fEqPi5J6(FFXb5i9i.TCNI2YTH(num, FFXb5i9i.smethod_2(current, null, "CountSelectedActions", new object[0], null, null, null, 44005), 1485), 22520);
			}
			if (enumerator.MoveNext())
			{
				current = enumerator.Current;
				num2 = 1;
				continue;
			}
			break;
		}
		return num;
	}

	public GAJDqHR0 method_5()
	{
		using (Enumerator enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				GAJDqHR0 current = enumerator.Current;
				if (current.BuNRjH7Y())
				{
					return current;
				}
			}
		}
		return null;
	}

	public kN09K4MB YMIGfYWg()
	{
		kN09K4MB kN09K4MB = null;
		using Enumerator enumerator = GetEnumerator();
		while (true)
		{
			if (enumerator.MoveNext())
			{
				object current = enumerator.Current;
				if (FFXb5i9i.rs8UXJ4a(FFXb5i9i.smethod_2(current, null, "IsAStep", new object[0], null, null, null, 44005), 21077))
				{
					kN09K4MB = (kN09K4MB)FFXb5i9i.smethod_2(current, null, "ReadSelectedAction", new object[0], null, null, null, 44005);
					if (!FFXb5i9i.smethod_1(kN09K4MB, 48316))
					{
						break;
					}
				}
				continue;
			}
			return kN09K4MB;
		}
		return kN09K4MB;
	}

	public void hk7JSeB7()
	{
		using Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current.vmethod_1();
		}
	}

	public void QYRXhgFi(ref StKhY3Gf QvMQXGTY)
	{
		foreach (GAJDqHR0 item in QvMQXGTY)
		{
			int index = IndexOf(item);
			base[index].vmethod_0();
		}
	}

	public bool rAxqGmEe()
	{
		bool result = true;
		using Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			GAJDqHR0 current = enumerator.Current;
			if (ivlgLlId.smethod_3(FFXb5i9i.pOhcgUVE(FFXb5i9i.VcIT67Rx(current, 58039), 54497), "GraphicalMacroStep", bool_0: false, 3221) == 0)
			{
				if (!current.uylLGOFX())
				{
					return false;
				}
			}
			else if (current.OqG5Jn98() && (!current.uylLGOFX() & !current.zWdLqRfk()))
			{
				return false;
			}
		}
		return result;
	}

	public string a3ymRdcT()
	{
		string string_ = "";
		using (Enumerator enumerator = GetEnumerator())
		{
			int num = 0;
			GAJDqHR0 current = default(GAJDqHR0);
			while (true)
			{
				if (num != 0)
				{
					string_ = FFXb5i9i.smethod_0(string_, current.NHfrgFk8, ", ", 52605);
				}
				if (enumerator.MoveNext())
				{
					current = enumerator.Current;
					num = 1;
					continue;
				}
				break;
			}
		}
		return Class16.neRkDuZz(Class16.neRkDuZz(string_, new char[1] { ' ' }, 10748), new char[1] { ',' }, 10748);
	}

	public void DRiu9G2H(ref Font font_0, ref Color q9iiHaqt, ref Color jDMdHiqD, ref Color jTc6ooOK, ref Color yPigwV24, ref Color KXVIVTcs, ref Color rObwTOZO, ref Color ZcpiTdc2, ref Color kxKRSaWn, ref Color AItKmIIq)
	{
		using Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current.hSvx5nbv(ref font_0, ref q9iiHaqt, ref jDMdHiqD, ref jTc6ooOK, ref yPigwV24, ref KXVIVTcs, ref rObwTOZO, ref ZcpiTdc2, ref kxKRSaWn, ref AItKmIIq);
		}
	}
}
