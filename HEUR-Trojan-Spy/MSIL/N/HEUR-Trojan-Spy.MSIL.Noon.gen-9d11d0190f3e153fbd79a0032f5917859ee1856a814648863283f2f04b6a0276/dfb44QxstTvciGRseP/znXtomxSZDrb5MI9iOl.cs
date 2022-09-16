#define DEBUG
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;

namespace dfb44QxstTvciGRseP;

[Obsolete("Please use CommandReader and CommandWriter.")]
public class znXtomxSZDrb5MI9iOl : Stream
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct a7JllmcFWA4KdSYjkoy
	{
		public bool snkChWy4dy;

		public znXtomxSZDrb5MI9iOl DIpCLY21BI;

		public Array nErCpmBSRP;

		public int rd3CTBQV46;

		public object jRkCSiYaHc;

		public object ut9CuaRgpt;

		public int AILCMxk1Ij;
	}

	public VElg1KxQgKwns2H2VEa kdluwK4x2P;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Stream ww4us8cdtk;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool UrIuhpCCW6;

	private List<object> jTouLUZAHI;

	private byte[] mQMupw4Rbi;

	private long dPkuTpLrhT;

	private long eHMuSEwUyx;

	private AutoResetEvent VKuuui0Fd9;

	private AutoResetEvent vYXuMgqPhd;

	private static znXtomxSZDrb5MI9iOl NOc1lw7tH2nu1NtNYkf;

	public override bool CanRead => SdPTPW7JtoSBN8JoITv(Aj7SvV1JPf());

	public override bool CanSeek => false;

	public override bool CanWrite => Aj7SvV1JPf().CanWrite;

	[Obsolete("This class does not support Length", true)]
	public override long Length
	{
		get
		{
			throw new NotSupportedException();
		}
	}

	[Obsolete("This class does not support Position", true)]
	public override long Position
	{
		get
		{
			throw new NotSupportedException();
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public Stream Aj7SvV1JPf()
	{
		return ww4us8cdtk;
	}

	[SpecialName]
	[CompilerGenerated]
	public void I17S0SZGMt(Stream stream_0)
	{
		ww4us8cdtk = stream_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool mCPSKIsl3Q()
	{
		return UrIuhpCCW6;
	}

	[SpecialName]
	[CompilerGenerated]
	public void wugSYuSPrV(bool bool_0)
	{
		UrIuhpCCW6 = bool_0;
	}

	public znXtomxSZDrb5MI9iOl(Stream stream_0, VElg1KxQgKwns2H2VEa velg1KxQgKwns2H2VEa_0, uint uint_0 = 256u)
	{
		dX2hcN74T9eD0rmliCL();
		UrIuhpCCW6 = false;
		jTouLUZAHI = new List<object>();
		dPkuTpLrhT = 0L;
		eHMuSEwUyx = 0L;
		VKuuui0Fd9 = new AutoResetEvent(initialState: false);
		vYXuMgqPhd = new AutoResetEvent(initialState: false);
		base._002Ector();
		I17S0SZGMt(stream_0);
		mQMupw4Rbi = new byte[uint_0];
		kdluwK4x2P = velg1KxQgKwns2H2VEa_0;
	}

	protected override void Dispose(bool disposing)
	{
		VKuuui0Fd9.Dispose();
		o42Qqr7QsCZ2AyX2qNJ(vYXuMgqPhd);
	}

	public void sd6SNaTVdg()
	{
		if (Interlocked.Read(ref dPkuTpLrhT) < 1L || VKuuui0Fd9.WaitOne())
		{
			Interlocked.Increment(ref dPkuTpLrhT);
			if (Interlocked.Read(ref eHMuSEwUyx) < 1L || fZ29jR7H3WYOsMcghSJ(vYXuMgqPhd))
			{
				Interlocked.Increment(ref eHMuSEwUyx);
			}
		}
	}

	public void hp2SmifHP7()
	{
		if (Interlocked.Read(ref dPkuTpLrhT) >= 1L)
		{
			int num2 = default(int);
			while (true)
			{
				VKuuui0Fd9.Set();
				int num = 0;
				if (!bH0tYc7FY7QZBuulfMH())
				{
					num = num2;
				}
				switch (num)
				{
				case 1:
					continue;
				}
				break;
			}
			Interlocked.Decrement(ref dPkuTpLrhT);
		}
		if (Interlocked.Read(ref eHMuSEwUyx) >= 1L)
		{
			vUHtG871oW5LpdqXQ7P(vYXuMgqPhd);
			Interlocked.Decrement(ref eHMuSEwUyx);
		}
	}

	public hxk6SwxjJn4feiy4Pbi hyrSkUClnV(out PBo11yxJuWSePXEpLhP pbo11yxJuWSePXEpLhP_0)
	{
		a7JllmcFWA4KdSYjkoy a7JllmcFWA4KdSYjkoy_ = default(a7JllmcFWA4KdSYjkoy);
		a7JllmcFWA4KdSYjkoy_.DIpCLY21BI = this;
		if (!Aj7SvV1JPf().CanRead)
		{
			throw new InvalidOperationException("The underlyingStream is unwritable.");
		}
		pbo11yxJuWSePXEpLhP_0 = default(PBo11yxJuWSePXEpLhP);
		int num;
		if (Interlocked.Read(ref dPkuTpLrhT) >= 1L && !VKuuui0Fd9.WaitOne())
		{
			num = 1;
			if (pjx4Wo7WFyoe5g7lhkb() != null)
			{
				goto IL_0156;
			}
			goto IL_015a;
		}
		Interlocked.Increment(ref dPkuTpLrhT);
		goto IL_01ca;
		IL_01fe:
		GmMSUh75OQ(ref a7JllmcFWA4KdSYjkoy_);
		aFpSWTquf1(ref a7JllmcFWA4KdSYjkoy_);
		goto IL_020e;
		IL_0122:
		byte b = default(byte);
		bool flag = default(bool);
		if (b != byte.MaxValue)
		{
			flag = mCPSKIsl3Q() || b == 0;
			num = 0;
			if (!bH0tYc7FY7QZBuulfMH())
			{
				goto IL_014f;
			}
			goto IL_015a;
		}
		goto IL_01fe;
		IL_0156:
		int num2 = default(int);
		num = num2;
		goto IL_015a;
		IL_015a:
		switch (num)
		{
		case 4:
			break;
		default:
			goto IL_014f;
		case 6:
			goto IL_0195;
		case 12:
			goto IL_01b1;
		case 3:
			goto IL_01ca;
		case 1:
			return (hxk6SwxjJn4feiy4Pbi)3;
		case 2:
			aFpSWTquf1(ref a7JllmcFWA4KdSYjkoy_);
			return (hxk6SwxjJn4feiy4Pbi)4;
		case 8:
		case 10:
			goto IL_01fe;
		case 5:
			goto IL_020e;
		case 11:
			aFpSWTquf1(ref a7JllmcFWA4KdSYjkoy_);
			return (hxk6SwxjJn4feiy4Pbi)0;
		case 7:
		case 9:
		{
			hxk6SwxjJn4feiy4Pbi result = default(hxk6SwxjJn4feiy4Pbi);
			return result;
		}
		}
		goto IL_0122;
		IL_010c:
		GmMSUh75OQ(ref a7JllmcFWA4KdSYjkoy_);
		num = 2;
		if (pjx4Wo7WFyoe5g7lhkb() != null)
		{
			goto IL_0156;
		}
		goto IL_015a;
		IL_01ca:
		jTouLUZAHI.Clear();
		goto IL_01c2;
		IL_01c2:
		ushort num3 = 0;
		num3 = 1;
		goto IL_01b1;
		IL_01b1:
		if (JX4SgniuPk(1))
		{
			b = mQMupw4Rbi[0];
			goto IL_0195;
		}
		goto IL_01d7;
		IL_01d7:
		GmMSUh75OQ(ref a7JllmcFWA4KdSYjkoy_);
		aFpSWTquf1(ref a7JllmcFWA4KdSYjkoy_);
		return (hxk6SwxjJn4feiy4Pbi)3;
		IL_0195:
		while (b == kdluwK4x2P.i4PuaWONq9)
		{
			num3 = (ushort)(num3 - 1);
			if (q9CSVHEY1w<ushort>(out var _))
			{
				a7JllmcFWA4KdSYjkoy_.snkChWy4dy = false;
				a7JllmcFWA4KdSYjkoy_.jRkCSiYaHc = null;
				a7JllmcFWA4KdSYjkoy_.rd3CTBQV46 = 0;
				a7JllmcFWA4KdSYjkoy_.AILCMxk1Ij = 0;
				a7JllmcFWA4KdSYjkoy_.nErCpmBSRP = null;
				GmMSUh75OQ(ref a7JllmcFWA4KdSYjkoy_);
				if (JX4SgniuPk(1))
				{
					if (mQMupw4Rbi[0] != kdluwK4x2P.JQNu5aifrj)
					{
						goto IL_010c;
					}
					num = 11;
					if (pjx4Wo7WFyoe5g7lhkb() != null)
					{
						continue;
					}
					goto IL_015a;
				}
			}
			goto IL_01d7;
		}
		goto IL_0122;
		IL_014f:
		if (!flag)
		{
			goto IL_010c;
		}
		goto IL_01c2;
		IL_020e:
		return (hxk6SwxjJn4feiy4Pbi)2;
	}

	public void sXhS8bEH73(PBo11yxJuWSePXEpLhP pbo11yxJuWSePXEpLhP_0)
	{
		int num;
		if (!Aj7SvV1JPf().CanWrite)
		{
			num = 20;
			if (!bH0tYc7FY7QZBuulfMH())
			{
				goto IL_03dc;
			}
			goto IL_048e;
		}
		if (Interlocked.Read(ref eHMuSEwUyx) < 1L || vYXuMgqPhd.WaitOne())
		{
			goto IL_0500;
		}
		return;
		IL_00f4:
		int num2 = num2 + 1;
		goto IL_038e;
		IL_0091:
		object obj = default(object);
		Array array = default(Array);
		int num3 = default(int);
		int num4 = default(int);
		int num5 = default(int);
		if (obj is Array)
		{
			if (array == null)
			{
				array = (Array)obj;
				num3 = array.Length;
				Aj7SvV1JPf().x7LhEAJCht(num3.BLQhXTDePi());
				if (num3 == 0)
				{
					array = null;
					num = 1;
					if (pjx4Wo7WFyoe5g7lhkb() == null)
					{
						goto IL_00f4;
					}
					goto IL_048e;
				}
				num4 = 0;
				num5 = 2;
				goto IL_038e;
			}
			throw new InvalidOperationException("_ARRAY_OF cannot be repeated.");
		}
		goto IL_05cb;
		IL_038e:
		num2++;
		goto IL_0110;
		IL_0500:
		Interlocked.Increment(ref eHMuSEwUyx);
		byte[] byte_ = new byte[3] { kdluwK4x2P.i4PuaWONq9, 0, 0 };
		pbo11yxJuWSePXEpLhP_0.jvcSiZia4h.v1rSqe7Sqq.ulphyM5cQ1(byte_, 1);
		num = 0;
		if (bH0tYc7FY7QZBuulfMH())
		{
			goto IL_047f;
		}
		goto IL_048e;
		IL_048e:
		bool flag = default(bool);
		object obj2 = default(object);
		while (true)
		{
			switch (num)
			{
			case 25:
				break;
			default:
				goto IL_0069;
			case 23:
				goto IL_007d;
			case 7:
				goto IL_0091;
			case 1:
				goto IL_00f4;
			case 19:
				goto IL_013c;
			case 17:
				goto IL_01bb;
			case 13:
				goto IL_01d0;
			case 6:
				goto IL_0212;
			case 16:
				goto IL_02fe;
			case 22:
				goto IL_031a;
			case 24:
				goto IL_0349;
			case 18:
				goto IL_0359;
			case 2:
			case 5:
			case 21:
				goto IL_038e;
			case 15:
				goto IL_03e5;
			case 12:
				goto IL_03f5;
			case 8:
				obj = null;
				array = null;
				num3 = 0;
				num4 = 0;
				Aj7SvV1JPf().WriteByte(kdluwK4x2P.JQNu5aifrj);
				Flush();
				num = 10;
				if (pjx4Wo7WFyoe5g7lhkb() != null)
				{
					continue;
				}
				goto case 14;
			case 4:
				goto IL_0468;
			case 3:
				goto IL_047f;
			case 11:
				goto IL_0500;
			case 9:
				throw new InvalidOperationException("_IF_TRUE requires a missing parameter.");
			case 14:
				vYXuMgqPhd.Set();
				Interlocked.Decrement(ref eHMuSEwUyx);
				return;
			case 20:
				throw new InvalidOperationException("The underlyingStream is unwritable.");
			case 10:
				goto IL_05cb;
			}
			break;
			IL_03f5:
			if (flag)
			{
				num = 9;
				if (bH0tYc7FY7QZBuulfMH())
				{
					continue;
				}
				goto IL_03dc;
			}
			if (!(bool)obj2)
			{
				num2 = pbo11yxJuWSePXEpLhP_0.jvcSiZia4h.tJcSAMKqWR(num2);
			}
			goto IL_038e;
		}
		goto IL_005b;
		IL_0171:
		EdRPUvx6HtFjma48dEu edRPUvx6HtFjma48dEu = default(EdRPUvx6HtFjma48dEu);
		bool flag2 = default(bool);
		int num6 = default(int);
		if (edRPUvx6HtFjma48dEu.HasFlag((EdRPUvx6HtFjma48dEu)4))
		{
			if (edRPUvx6HtFjma48dEu != (EdRPUvx6HtFjma48dEu)2052)
			{
				goto IL_01bb;
			}
			flag = obj2 == null || !(obj2 is bool);
			num = 12;
			if (pjx4Wo7WFyoe5g7lhkb() != null)
			{
				goto IL_038e;
			}
		}
		else
		{
			flag2 = num6 > 0;
			num = 2;
			if (pjx4Wo7WFyoe5g7lhkb() == null)
			{
				goto IL_0212;
			}
		}
		goto IL_048e;
		IL_03dc:
		num = num5;
		goto IL_048e;
		IL_047f:
		Aj7SvV1JPf().x7LhEAJCht(byte_);
		goto IL_0468;
		IL_0468:
		obj2 = null;
		num4 = 0;
		num3 = 0;
		array = null;
		num6 = 0;
		num2 = 0;
		goto IL_0110;
		IL_0110:
		bool flag3 = default(bool);
		if (num2 < pbo11yxJuWSePXEpLhP_0.jvcSiZia4h.lqcSeesD6g())
		{
			edRPUvx6HtFjma48dEu = pbo11yxJuWSePXEpLhP_0.jvcSiZia4h.K6nSFA122H(num2);
			flag3 = array != null;
			goto IL_013c;
		}
		obj2 = null;
		num = 8;
		if (!bH0tYc7FY7QZBuulfMH())
		{
			goto IL_03dc;
		}
		goto IL_048e;
		IL_013c:
		if (!flag3)
		{
			obj = ((num6 < pbo11yxJuWSePXEpLhP_0.WiZS6JsgLe.Length) ? pbo11yxJuWSePXEpLhP_0.WiZS6JsgLe[num6] : null);
			obj2 = ((num6 == 0) ? null : pbo11yxJuWSePXEpLhP_0.WiZS6JsgLe[num6 - 1]);
			goto IL_0171;
		}
		num = 15;
		if (pjx4Wo7WFyoe5g7lhkb() != null)
		{
			goto IL_03dc;
		}
		goto IL_048e;
		IL_0335:
		bool flag4 = default(bool);
		if (array != null)
		{
			flag4 = ++num4 == num3;
			goto IL_0349;
		}
		goto IL_038e;
		IL_031a:
		Aj7SvV1JPf().x7LhEAJCht(lN8S4dJdNq(edRPUvx6HtFjma48dEu, obj));
		num6++;
		goto IL_0335;
		IL_0349:
		if (flag4)
		{
			array = null;
			goto IL_038e;
		}
		num2--;
		num6--;
		num = 5;
		if (pjx4Wo7WFyoe5g7lhkb() != null)
		{
			goto IL_03dc;
		}
		goto IL_048e;
		IL_02fe:
		num6++;
		goto IL_0335;
		IL_03e5:
		obj = tOyKiJ7erHfCTZfHl4R(array, num4);
		goto IL_0171;
		IL_005b:
		if (edRPUvx6HtFjma48dEu != (EdRPUvx6HtFjma48dEu)6148)
		{
			goto IL_0069;
		}
		bool flag5 = obj2 == null;
		goto IL_0359;
		IL_01bb:
		if (edRPUvx6HtFjma48dEu != (EdRPUvx6HtFjma48dEu)4100)
		{
			goto IL_005b;
		}
		bool flag6 = obj2 == null;
		goto IL_01d0;
		IL_0359:
		if (!flag5)
		{
			if (!obj2.C8bhRxET3D())
			{
				goto IL_038e;
			}
			num2 = pbo11yxJuWSePXEpLhP_0.jvcSiZia4h.tJcSAMKqWR(num2);
			num = 21;
			if (!bH0tYc7FY7QZBuulfMH())
			{
				goto IL_0069;
			}
			goto IL_048e;
		}
		throw new InvalidOperationException("_IF_NOT_0 requires a missing parameter.");
		IL_01d0:
		if (!flag6)
		{
			if (!obj2.C8bhRxET3D())
			{
				num2 = pbo11yxJuWSePXEpLhP_0.jvcSiZia4h.tJcSAMKqWR(num2);
			}
			goto IL_038e;
		}
		throw new InvalidOperationException("_IF_0 requires a missing parameter.");
		IL_0212:
		if (flag2)
		{
			Aj7SvV1JPf().WriteByte(kdluwK4x2P.liyuIDPMcm);
		}
		if (edRPUvx6HtFjma48dEu == (EdRPUvx6HtFjma48dEu)64)
		{
			EdRPUvx6HtFjma48dEu edRPUvx6HtFjma48dEu2 = G7vqI854MalMAxPWQ1.vOGhuXnIqG(obj);
			byte[] byte_2 = ((ushort)edRPUvx6HtFjma48dEu2).BLQhXTDePi();
			Aj7SvV1JPf().x7LhEAJCht(byte_2);
			Aj7SvV1JPf().WriteByte(kdluwK4x2P.jiKunPtGM5);
			Stream object_ = Aj7SvV1JPf();
			byte[] object_2;
			if (!edRPUvx6HtFjma48dEu2.HasFlag((EdRPUvx6HtFjma48dEu)1))
			{
				if (!edRPUvx6HtFjma48dEu2.HasFlag((EdRPUvx6HtFjma48dEu)2))
				{
					throw new ArgumentException("Unrecognized type of object (" + obj.GetType().FullName + ")", "currObj");
				}
				object_2 = lN8S4dJdNq(edRPUvx6HtFjma48dEu2, obj);
			}
			else
			{
				object_2 = KraSxuWnZN(edRPUvx6HtFjma48dEu2, obj);
			}
			pvvtl07GYvLgIps7ChJ(object_, object_2);
			num6++;
		}
		else
		{
			if (edRPUvx6HtFjma48dEu.HasFlag((EdRPUvx6HtFjma48dEu)1))
			{
				pvvtl07GYvLgIps7ChJ(Aj7SvV1JPf(), KraSxuWnZN(edRPUvx6HtFjma48dEu, obj));
				num = 9;
				if (pjx4Wo7WFyoe5g7lhkb() == null)
				{
					goto IL_02fe;
				}
				goto IL_048e;
			}
			if (edRPUvx6HtFjma48dEu.HasFlag((EdRPUvx6HtFjma48dEu)2))
			{
				goto IL_031a;
			}
		}
		goto IL_0335;
		IL_0069:
		bool flag7 = edRPUvx6HtFjma48dEu == (EdRPUvx6HtFjma48dEu)8196;
		num5 = 23;
		goto IL_007d;
		IL_007d:
		if (flag7)
		{
			if (obj != null)
			{
				num5 = 7;
				goto IL_0091;
			}
			goto IL_05cb;
		}
		throw new InvalidOperationException((string?)lLGm9O7kmKcT0QQvtK4("Unable to recognize special parameter: ", $"0x{edRPUvx6HtFjma48dEu:x}"));
		IL_05cb:
		throw new InvalidOperationException("_ARRAY_OF require a missing parameter.");
	}

	private bool JX4SgniuPk(int int_0)
	{
		if (int_0 < 0)
		{
			if (bH0tYc7FY7QZBuulfMH())
			{
				switch (0)
				{
				case 1:
					goto IL_00aa;
				case 2:
					goto IL_00b1;
				case 3:
				case 4:
				{
					bool result = default(bool);
					return result;
				}
				}
			}
			throw new ArgumentOutOfRangeException("requiredLength", "The required amount of data is negative.");
		}
		if (int_0 == 0)
		{
			return true;
		}
		if (int_0 > mQMupw4Rbi.Length)
		{
			mQMupw4Rbi = new byte[int_0];
		}
		int num = 0;
		int num2 = 0;
		goto IL_006b;
		IL_00aa:
		if (num2 != 0)
		{
			num += num2;
			if (num >= int_0)
			{
				if (num != int_0)
				{
					throw new IndexOutOfRangeException("Weird, but the amount of received data does not match the required one.");
				}
				return true;
			}
			goto IL_006b;
		}
		goto IL_00b1;
		IL_00b1:
		return false;
		IL_006b:
		try
		{
			num2 = Aj7SvV1JPf().Read(mQMupw4Rbi, num, int_0 - num);
		}
		catch (Exception ex)
		{
			Debug.Print(ex.Message);
			return false;
		}
		goto IL_00aa;
	}

	private bool q9CSVHEY1w<YBd669xFXXKOEFJSt4g>(out YBd669xFXXKOEFJSt4g gparam_0) where YBd669xFXXKOEFJSt4g : struct
	{
		int int_ = Marshal.SizeOf(typeof(YBd669xFXXKOEFJSt4g));
		gparam_0 = default(YBd669xFXXKOEFJSt4g);
		if (!JX4SgniuPk(int_))
		{
			return false;
		}
		gparam_0 = mQMupw4Rbi.EVTh5K5dQp<YBd669xFXXKOEFJSt4g>();
		return true;
	}

	public override void Close()
	{
		int num = 2;
		while (true)
		{
			sd6SNaTVdg();
			int num2 = 1;
			if (!bH0tYc7FY7QZBuulfMH())
			{
				num2 = num;
			}
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (Aj7SvV1JPf() != null && Aj7SvV1JPf().CanWrite)
					{
						num2 = 0;
						if (!bH0tYc7FY7QZBuulfMH())
						{
							continue;
						}
						goto default;
					}
					return;
				case 2:
					break;
				default:
					try
					{
						Aj7SvV1JPf().WriteByte(byte.MaxValue);
						Aj7SvV1JPf().Flush();
					}
					catch (IOException)
					{
					}
					Aj7SvV1JPf().Close();
					I17S0SZGMt(null);
					return;
				}
				break;
			}
		}
	}

	public override void Flush()
	{
		Aj7SvV1JPf().Flush();
	}

	[Obsolete("This class does not support Seek", true)]
	public override long Seek(long offset, SeekOrigin origin)
	{
		throw new NotSupportedException();
	}

	[Obsolete("This class does not support SetLength", true)]
	public override void SetLength(long value)
	{
		throw new NotSupportedException();
	}

	[Obsolete("This class does not support direct Read", true)]
	public override int Read(byte[] buffer, int offset, int count)
	{
		throw new NotSupportedException();
	}

	[Obsolete("This class does not support direct Write", true)]
	public override void Write(byte[] buffer, int offset, int count)
	{
		throw new NotSupportedException();
	}

	[CompilerGenerated]
	private int DM0SO5MRYG(EdRPUvx6HtFjma48dEu edRPUvx6HtFjma48dEu_0, ref a7JllmcFWA4KdSYjkoy a7JllmcFWA4KdSYjkoy_0)
	{
		EdRPUvx6HtFjma48dEu edRPUvx6HtFjma48dEu = edRPUvx6HtFjma48dEu_0 & (EdRPUvx6HtFjma48dEu)63;
		EdRPUvx6HtFjma48dEu edRPUvx6HtFjma48dEu2 = edRPUvx6HtFjma48dEu;
		int num;
		if (edRPUvx6HtFjma48dEu2 <= (EdRPUvx6HtFjma48dEu)17)
		{
			if (edRPUvx6HtFjma48dEu2 != (EdRPUvx6HtFjma48dEu)9)
			{
				num = 0;
				if (bH0tYc7FY7QZBuulfMH())
				{
					goto IL_01da;
				}
				goto IL_0403;
			}
			a7JllmcFWA4KdSYjkoy_0.snkChWy4dy = JX4SgniuPk(1);
			goto IL_04a3;
		}
		if (edRPUvx6HtFjma48dEu2 != (EdRPUvx6HtFjma48dEu)25)
		{
			goto IL_0475;
		}
		goto IL_04c3;
		IL_004b:
		EdRPUvx6HtFjma48dEu edRPUvx6HtFjma48dEu3 = default(EdRPUvx6HtFjma48dEu);
		object object_ = default(object);
		switch (edRPUvx6HtFjma48dEu3)
		{
		case (EdRPUvx6HtFjma48dEu)865:
			object_ = mQMupw4Rbi.EVTh5K5dQp<double>();
			break;
		case (EdRPUvx6HtFjma48dEu)793:
			object_ = mQMupw4Rbi.EVTh5K5dQp<float>();
			break;
		}
		goto IL_0087;
		IL_023b:
		object_ = mQMupw4Rbi.I5yhnPUQWT<byte>(0, 1);
		goto IL_0087;
		IL_0146:
		if (edRPUvx6HtFjma48dEu3 != (EdRPUvx6HtFjma48dEu)673)
		{
			if (edRPUvx6HtFjma48dEu3 != (EdRPUvx6HtFjma48dEu)737)
			{
				goto IL_0087;
			}
			object_ = mQMupw4Rbi.EVTh5K5dQp<ulong>();
			num = 10;
			if (!bH0tYc7FY7QZBuulfMH())
			{
				goto IL_0180;
			}
		}
		else
		{
			object_ = mQMupw4Rbi.EVTh5K5dQp<long>();
			num = 21;
			if (!bH0tYc7FY7QZBuulfMH())
			{
				goto IL_0087;
			}
		}
		goto IL_0403;
		IL_0217:
		object_ = mQMupw4Rbi.I5yhnPUQWT<byte>(0, 2);
		num = 11;
		if (!bH0tYc7FY7QZBuulfMH())
		{
			goto IL_00e3;
		}
		goto IL_0403;
		IL_04c3:
		a7JllmcFWA4KdSYjkoy_0.snkChWy4dy = JX4SgniuPk(4);
		goto IL_04a3;
		IL_04a3:
		bool flag = !a7JllmcFWA4KdSYjkoy_0.snkChWy4dy;
		num = 1;
		if (bH0tYc7FY7QZBuulfMH())
		{
			goto IL_02ea;
		}
		goto IL_0403;
		IL_0403:
		switch (num)
		{
		case 25:
			break;
		case 10:
		case 11:
		case 21:
			goto IL_0087;
		default:
			goto IL_00a3;
		case 23:
			goto IL_00ec;
		case 22:
			goto IL_0101;
		case 14:
		case 18:
			if (edRPUvx6HtFjma48dEu3 == (EdRPUvx6HtFjma48dEu)1065)
			{
				object_ = new Guid(mQMupw4Rbi.I5yhnPUQWT<byte>(0, 16));
			}
			goto IL_0087;
		case 17:
			goto IL_0146;
		case 7:
			goto IL_0180;
		case 16:
			goto IL_01da;
		case 13:
			goto IL_0206;
		case 6:
			goto IL_0217;
		case 8:
			goto IL_023b;
		case 12:
			goto IL_024f;
		case 9:
			if (edRPUvx6HtFjma48dEu3 == (EdRPUvx6HtFjma48dEu)41)
			{
				object_ = mQMupw4Rbi.I5yhnPUQWT<byte>(0, 16);
			}
			goto IL_0087;
		case 4:
			goto IL_0295;
		case 3:
			goto IL_02c4;
		case 1:
			goto IL_02ea;
		case 15:
			goto IL_0475;
		case 2:
			goto IL_047b;
		case 19:
		case 20:
			goto IL_04a3;
		case 24:
			goto IL_04c3;
		case 5:
			goto IL_04d5;
		}
		goto IL_004b;
		IL_01da:
		if (edRPUvx6HtFjma48dEu2 == (EdRPUvx6HtFjma48dEu)17)
		{
			a7JllmcFWA4KdSYjkoy_0.snkChWy4dy = JX4SgniuPk(2);
			num = 11;
			if (pjx4Wo7WFyoe5g7lhkb() != null)
			{
				goto IL_0403;
			}
		}
		goto IL_04a3;
		IL_00ec:
		object_ = mQMupw4Rbi.EVTh5K5dQp<ushort>();
		goto IL_0087;
		IL_0475:
		if (edRPUvx6HtFjma48dEu2 != (EdRPUvx6HtFjma48dEu)33)
		{
			goto IL_047b;
		}
		a7JllmcFWA4KdSYjkoy_0.snkChWy4dy = JX4SgniuPk(8);
		goto IL_04a3;
		IL_02c4:
		if (edRPUvx6HtFjma48dEu3 == (EdRPUvx6HtFjma48dEu)537)
		{
			object_ = mQMupw4Rbi.EVTh5K5dQp<int>();
		}
		goto IL_0087;
		IL_04d5:
		int result = default(int);
		return result;
		IL_0101:
		object_ = mQMupw4Rbi.EVTh5K5dQp<short>();
		goto IL_0087;
		IL_00a3:
		if (edRPUvx6HtFjma48dEu3 != (EdRPUvx6HtFjma48dEu)25)
		{
			if (edRPUvx6HtFjma48dEu3 != (EdRPUvx6HtFjma48dEu)33)
			{
				num = 9;
				if (!bH0tYc7FY7QZBuulfMH())
				{
					goto IL_00e3;
				}
				goto IL_0403;
			}
			object_ = mQMupw4Rbi.I5yhnPUQWT<byte>(0, 8);
		}
		else
		{
			object_ = mQMupw4Rbi.I5yhnPUQWT<byte>(0, 4);
		}
		goto IL_0087;
		IL_00e3:
		int num2 = default(int);
		num = num2;
		goto IL_0403;
		IL_047b:
		if (edRPUvx6HtFjma48dEu2 == (EdRPUvx6HtFjma48dEu)41)
		{
			a7JllmcFWA4KdSYjkoy_0.snkChWy4dy = JX4SgniuPk(16);
		}
		goto IL_04a3;
		IL_024f:
		if (edRPUvx6HtFjma48dEu3 == (EdRPUvx6HtFjma48dEu)201)
		{
			object_ = mQMupw4Rbi.EVTh5K5dQp<char>();
		}
		goto IL_0087;
		IL_02ea:
		if (!flag)
		{
			object_ = null;
			EdRPUvx6HtFjma48dEu edRPUvx6HtFjma48dEu4 = edRPUvx6HtFjma48dEu_0;
			edRPUvx6HtFjma48dEu3 = edRPUvx6HtFjma48dEu4;
			if (edRPUvx6HtFjma48dEu3 <= (EdRPUvx6HtFjma48dEu)401)
			{
				if (edRPUvx6HtFjma48dEu3 <= (EdRPUvx6HtFjma48dEu)41)
				{
					if (edRPUvx6HtFjma48dEu3 > (EdRPUvx6HtFjma48dEu)17)
					{
						goto IL_00a3;
					}
					goto IL_0206;
				}
				if (edRPUvx6HtFjma48dEu3 > (EdRPUvx6HtFjma48dEu)201)
				{
					goto IL_0295;
				}
				if (edRPUvx6HtFjma48dEu3 != (EdRPUvx6HtFjma48dEu)153)
				{
					goto IL_024f;
				}
				object_ = mQMupw4Rbi.EVTh5K5dQp<bool>();
			}
			else if (edRPUvx6HtFjma48dEu3 <= (EdRPUvx6HtFjma48dEu)737)
			{
				if (edRPUvx6HtFjma48dEu3 <= (EdRPUvx6HtFjma48dEu)537)
				{
					if (edRPUvx6HtFjma48dEu3 == (EdRPUvx6HtFjma48dEu)465)
					{
						goto IL_00ec;
					}
					goto IL_02c4;
				}
				if (edRPUvx6HtFjma48dEu3 != (EdRPUvx6HtFjma48dEu)601)
				{
					goto IL_0146;
				}
				object_ = mQMupw4Rbi.EVTh5K5dQp<uint>();
			}
			else
			{
				if (edRPUvx6HtFjma48dEu3 <= (EdRPUvx6HtFjma48dEu)865)
				{
					num2 = 25;
					goto IL_004b;
				}
				if (edRPUvx6HtFjma48dEu3 != (EdRPUvx6HtFjma48dEu)937)
				{
					if (edRPUvx6HtFjma48dEu3 != (EdRPUvx6HtFjma48dEu)993)
					{
						num = 18;
						if (!bH0tYc7FY7QZBuulfMH())
						{
							goto IL_00e3;
						}
						goto IL_0403;
					}
					object_ = DateTime.FromBinary(mQMupw4Rbi.EVTh5K5dQp<long>());
				}
				else
				{
					object_ = mQMupw4Rbi.EVTh5K5dQp<decimal>();
				}
			}
			goto IL_0087;
		}
		result = 1;
		goto IL_04d5;
		IL_0087:
		uWkSb6BKuj(object_, ref a7JllmcFWA4KdSYjkoy_0);
		result = 0;
		num = 5;
		if (pjx4Wo7WFyoe5g7lhkb() != null)
		{
			goto IL_00a3;
		}
		goto IL_0403;
		IL_0295:
		if (edRPUvx6HtFjma48dEu3 != (EdRPUvx6HtFjma48dEu)265)
		{
			num2 = 7;
			goto IL_0180;
		}
		object_ = mQMupw4Rbi.EVTh5K5dQp<sbyte>();
		goto IL_0087;
		IL_0180:
		if (edRPUvx6HtFjma48dEu3 != (EdRPUvx6HtFjma48dEu)329)
		{
			if (edRPUvx6HtFjma48dEu3 == (EdRPUvx6HtFjma48dEu)401)
			{
				goto IL_0101;
			}
		}
		else
		{
			object_ = mQMupw4Rbi.EVTh5K5dQp<byte>();
		}
		goto IL_0087;
		IL_0206:
		if (edRPUvx6HtFjma48dEu3 != (EdRPUvx6HtFjma48dEu)9)
		{
			if (edRPUvx6HtFjma48dEu3 != (EdRPUvx6HtFjma48dEu)17)
			{
				goto IL_0087;
			}
			goto IL_0217;
		}
		goto IL_023b;
	}

	[CompilerGenerated]
	private int GS4SdyIEcA(EdRPUvx6HtFjma48dEu edRPUvx6HtFjma48dEu_0, ref a7JllmcFWA4KdSYjkoy a7JllmcFWA4KdSYjkoy_0)
	{
		int num = 5;
		while (true)
		{
			int gparam_ = 0;
			while (true)
			{
				if (q9CSVHEY1w<int>(out gparam_))
				{
					if (JX4SgniuPk(1))
					{
						if (mQMupw4Rbi[0] == kdluwK4x2P.jiKunPtGM5)
						{
							if (JX4SgniuPk(gparam_))
							{
								while (true)
								{
									IL_00c3:
									object object_ = null;
									EdRPUvx6HtFjma48dEu edRPUvx6HtFjma48dEu = edRPUvx6HtFjma48dEu_0;
									EdRPUvx6HtFjma48dEu edRPUvx6HtFjma48dEu2 = edRPUvx6HtFjma48dEu;
									if (edRPUvx6HtFjma48dEu2 == (EdRPUvx6HtFjma48dEu)1090)
									{
										goto IL_004c;
									}
									if (edRPUvx6HtFjma48dEu2 == (EdRPUvx6HtFjma48dEu)1218)
									{
										object_ = mQMupw4Rbi.I5yhnPUQWT<byte>(0, gparam_);
									}
									goto IL_0067;
									IL_004c:
									object_ = kdluwK4x2P.MTKuXsMd6S.GetString(mQMupw4Rbi, 0, gparam_);
									goto IL_0067;
									IL_0067:
									while (true)
									{
										uWkSb6BKuj(object_, ref a7JllmcFWA4KdSYjkoy_0);
										int num2 = 0;
										if (pjx4Wo7WFyoe5g7lhkb() != null)
										{
											num2 = num;
										}
										switch (num2)
										{
										case 6:
											break;
										case 2:
											continue;
										case 1:
											goto IL_00c3;
										case 4:
											goto end_IL_00c3;
										case 5:
											goto end_IL_00db;
										default:
											return 0;
										case 3:
											goto IL_0106;
										}
										break;
									}
									goto IL_004c;
									continue;
									end_IL_00c3:
									break;
								}
								continue;
							}
							return 1;
						}
						goto IL_0106;
					}
					return 1;
				}
				return 1;
				IL_0106:
				return 2;
				continue;
				end_IL_00db:
				break;
			}
		}
	}

	[CompilerGenerated]
	private void uWkSb6BKuj(object object_0, ref a7JllmcFWA4KdSYjkoy a7JllmcFWA4KdSYjkoy_0)
	{
		if (a7JllmcFWA4KdSYjkoy_0.nErCpmBSRP != null)
		{
			a7JllmcFWA4KdSYjkoy_0.nErCpmBSRP.SetValue(object_0, a7JllmcFWA4KdSYjkoy_0.rd3CTBQV46);
			int num = 0;
			if (!bH0tYc7FY7QZBuulfMH())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
		else
		{
			jTouLUZAHI.Add(object_0);
		}
	}

	[CompilerGenerated]
	private void aFpSWTquf1(ref a7JllmcFWA4KdSYjkoy a7JllmcFWA4KdSYjkoy_0)
	{
		if (Interlocked.Read(ref dPkuTpLrhT) >= 1L)
		{
			VKuuui0Fd9.Set();
			Interlocked.Decrement(ref dPkuTpLrhT);
		}
	}

	[CompilerGenerated]
	private void GmMSUh75OQ(ref a7JllmcFWA4KdSYjkoy a7JllmcFWA4KdSYjkoy_0)
	{
		a7JllmcFWA4KdSYjkoy_0.jRkCSiYaHc = null;
		a7JllmcFWA4KdSYjkoy_0.ut9CuaRgpt = null;
		a7JllmcFWA4KdSYjkoy_0.nErCpmBSRP = null;
		a7JllmcFWA4KdSYjkoy_0.AILCMxk1Ij = 0;
		a7JllmcFWA4KdSYjkoy_0.rd3CTBQV46 = 0;
	}

	[CompilerGenerated]
	internal static byte[] KraSxuWnZN<OvMqOLxEc3eGGhLykbW>(EdRPUvx6HtFjma48dEu edRPUvx6HtFjma48dEu_0, OvMqOLxEc3eGGhLykbW GhFUH7xlrZcPRpPynh8)
	{
		if (!edRPUvx6HtFjma48dEu_0.HasFlag((EdRPUvx6HtFjma48dEu)1))
		{
			throw new ArgumentException("This parameter does not have a fixed length.", "param");
		}
		return edRPUvx6HtFjma48dEu_0 switch
		{
			(EdRPUvx6HtFjma48dEu)993 => ((DateTime)(object)GhFUH7xlrZcPRpPynh8).ToBinary().BLQhXTDePi(), 
			(EdRPUvx6HtFjma48dEu)1065 => ((Guid)(object)GhFUH7xlrZcPRpPynh8).ToByteArray(), 
			_ => GhFUH7xlrZcPRpPynh8.BLQhXTDePi(), 
		};
	}

	[CompilerGenerated]
	private byte[] lN8S4dJdNq(EdRPUvx6HtFjma48dEu edRPUvx6HtFjma48dEu_0, object object_0)
	{
		byte[] array;
		string text;
		int num2;
		if (edRPUvx6HtFjma48dEu_0.HasFlag((EdRPUvx6HtFjma48dEu)2))
		{
			array = null;
			int num = 0;
			text = object_0 as string;
			num2 = 0;
			if (pjx4Wo7WFyoe5g7lhkb() != null)
			{
				goto IL_004a;
			}
			goto IL_004e;
		}
		throw new ArgumentException("This parameter does not have a dynamic length.", "param");
		IL_004a:
		int num3 = default(int);
		num2 = num3;
		goto IL_004e;
		IL_004e:
		bool flag = default(bool);
		byte[] array2 = default(byte[]);
		do
		{
			switch (num2)
			{
			default:
				goto IL_0036;
			case 1:
			{
				if (!flag)
				{
					goto case 2;
				}
				int num = kdluwK4x2P.MTKuXsMd6S.GetByteCount(text);
				array = new byte[5 + num];
				num.ulphyM5cQ1(array);
				array[4] = kdluwK4x2P.jiKunPtGM5;
				goto case 4;
			}
			case 2:
				array2 = object_0 as byte[];
				goto case 3;
			case 3:
				if (array2 != null)
				{
					int num = array2.Length;
					array = new byte[5 + num];
					num.ulphyM5cQ1(array);
					array[4] = kdluwK4x2P.jiKunPtGM5;
					Array.Copy(array2, 0, array, 5, num);
					break;
				}
				throw new ArgumentException("Invalid type of data (only string and byte[] are allowed).", "value");
			case 4:
				kdluwK4x2P.MTKuXsMd6S.GetBytes(text, 0, text.Length, array, 5);
				break;
			}
			return array;
			IL_0036:
			flag = text != null;
			num2 = 1;
		}
		while (bH0tYc7FY7QZBuulfMH());
		goto IL_004a;
	}

	internal static bool SdPTPW7JtoSBN8JoITv(object object_0)
	{
		return ((Stream)object_0).CanRead;
	}

	internal static bool bH0tYc7FY7QZBuulfMH()
	{
		return NOc1lw7tH2nu1NtNYkf == null;
	}

	internal static znXtomxSZDrb5MI9iOl pjx4Wo7WFyoe5g7lhkb()
	{
		return NOc1lw7tH2nu1NtNYkf;
	}

	internal static void dX2hcN74T9eD0rmliCL()
	{
		GRgbqpcvG2cupxT0496.SF54tCZzYSfdV();
	}

	internal static void o42Qqr7QsCZ2AyX2qNJ(object object_0)
	{
		((WaitHandle)object_0).Dispose();
	}

	internal static bool fZ29jR7H3WYOsMcghSJ(object object_0)
	{
		return ((WaitHandle)object_0).WaitOne();
	}

	internal static bool vUHtG871oW5LpdqXQ7P(object object_0)
	{
		return ((EventWaitHandle)object_0).Set();
	}

	internal static object tOyKiJ7erHfCTZfHl4R(object object_0, int int_0)
	{
		return ((Array)object_0).GetValue(int_0);
	}

	internal static object lLGm9O7kmKcT0QQvtK4(object object_0, object object_1)
	{
		return (string?)object_0 + (string?)object_1;
	}

	internal static void pvvtl07GYvLgIps7ChJ(object object_0, object object_1)
	{
		((Stream)object_0).x7LhEAJCht((byte[])object_1);
	}
}
