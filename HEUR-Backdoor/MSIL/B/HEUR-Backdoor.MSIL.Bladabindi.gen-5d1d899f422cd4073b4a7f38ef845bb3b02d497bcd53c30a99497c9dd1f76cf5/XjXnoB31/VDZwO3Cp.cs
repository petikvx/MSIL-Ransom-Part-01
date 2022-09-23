using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using pHfpPgtx;

namespace XjXnoB31;

public class VDZwO3Cp : Stream
{
	[Flags]
	private enum jkxDMlR_jlhabaufpdwqfltnpdfioaeqmgwfd : uint
	{
		a = 0u,
		b = 1u,
		c = 2u,
		d = 4u,
		e = 8u,
		f = 0x10u,
		g = 0x20u,
		h = 0x3Au,
		i = 0x40u,
		j = 0x80u,
		k = 0x100u,
		l = 0x200u,
		m = 0x400u,
		n = 0x800u,
		o = 0x1000u,
		p = 0x2000u,
		q = 0x4000u,
		r = uint.MaxValue
	}

	private static readonly int a;

	private static readonly int b;

	private List<yg2rCLlIVAZi8vk_bjeqibcttmudgpwhnitxqxhqoqxop> c;

	private bool d;

	private bool e;

	private Stream f;

	private int g;

	private int h = a;

	private AutoResetEvent i;

	private object j = new object();

	private bool k;

	private bool l;

	private int m;

	private int n;

	private int o;

	private int p;

	private int q;

	private VCOVh2j12bt r;

	private object s = new object();

	private Queue<int> t;

	private Queue<int> u;

	private long v;

	private VdckbyAnJG7MLj3W w;

	private volatile Exception x;

	private bool y;

	private object z = new object();

	private jkxDMlR_jlhabaufpdwqfltnpdfioaeqmgwfd aa = jkxDMlR_jlhabaufpdwqfltnpdfioaeqmgwfd.h | jkxDMlR_jlhabaufpdwqfltnpdfioaeqmgwfd.d | jkxDMlR_jlhabaufpdwqfltnpdfioaeqmgwfd.k | jkxDMlR_jlhabaufpdwqfltnpdfioaeqmgwfd.n | jkxDMlR_jlhabaufpdwqfltnpdfioaeqmgwfd.p | jkxDMlR_jlhabaufpdwqfltnpdfioaeqmgwfd.q;

	[CompilerGenerated]
	private cDHuQVnuNIE ab;

	public cDHuQVnuNIE Strategy
	{
		[CompilerGenerated]
		get
		{
			DateTime dateTime = default(DateTime).AddYears(2020).AddMonths(6).AddDays(23.3632175925926);
			if (dateTime < DateTime.Now || true)
			{
			}
			return ab;
		}
		[CompilerGenerated]
		private set
		{
			DateTime dateTime = default(DateTime).AddYears(2020).AddMonths(6).AddDays(23.4430439814815);
			if ((DateTime.Now - dateTime).TotalDays <= 0.0)
			{
			}
			ab = value;
		}
	}

	public int MaxBufferPairs
	{
		get
		{
			return g;
		}
		set
		{
			if (value < 4)
			{
				throw new ArgumentException(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ṿṓṊṰṇṔṔṗṀṢṓṛṀṁ", 59590), 63172), hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ᝰᝇᝊ\u1753ᝃᜆᝋ\u1753\u1755\u1752ᜆᝄᝃᜆ\u1712ᜆᝉ\u1754ᜆᝁ\u1754ᝃᝇ\u1752ᝃ\u1754ᜈ", 62939), 57944));
			}
			g = value;
		}
	}

	public int BufferSize
	{
		get
		{
			return h;
		}
		set
		{
			if (value < 1024)
			{
				throw new ArgumentOutOfRangeException(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("\u128fኸካካከ\u12bfኞኤ\u12b7ከ", 62586), 58928), hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ፄ፳፠፠፣፴ፕ፯፼፣ጦ፫፳፵፲ጦ፤፣ጦ፡፴፣፧፲፣፴ጦ፲፮፧፨ጦጷጶጴጲጦ፤\u137f፲፣፵", 58466), 63484));
			}
			h = value;
		}
	}

	public int Crc32 => q;

	public long BytesProcessed => v;

	public override bool CanSeek => false;

	public override bool CanRead => false;

	public override bool CanWrite => f.CanWrite;

	public override long Length
	{
		get
		{
			throw new NotSupportedException();
		}
	}

	public override long Position
	{
		get
		{
			return f.Position;
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	public VDZwO3Cp(Stream MezZXLRq)
		: this(MezZXLRq, VdckbyAnJG7MLj3W.m7wqam, cDHuQVnuNIE.m7wqam, nNsgJzMYaTAoSOW: false)
	{
	}

	public VDZwO3Cp(Stream TE1tejPcRl1TT, VdckbyAnJG7MLj3W l7Mo7PCdLI)
		: this(TE1tejPcRl1TT, l7Mo7PCdLI, cDHuQVnuNIE.m7wqam, nNsgJzMYaTAoSOW: false)
	{
	}

	public VDZwO3Cp(Stream t9FgYMVOUfLf, bool iYHK7EV4Ye)
		: this(t9FgYMVOUfLf, VdckbyAnJG7MLj3W.m7wqam, cDHuQVnuNIE.m7wqam, iYHK7EV4Ye)
	{
	}

	public VDZwO3Cp(Stream qO1nBvzmko, VdckbyAnJG7MLj3W YK8kxAdKZSWnAk, bool x0jYNOET7o7)
		: this(qO1nBvzmko, VdckbyAnJG7MLj3W.m7wqam, cDHuQVnuNIE.m7wqam, x0jYNOET7o7)
	{
	}

	public VDZwO3Cp(Stream VjlipcmAkF, VdckbyAnJG7MLj3W ESUD6CSd0NauOkb, cDHuQVnuNIE cDHuQVnuNIE_0, bool nNsgJzMYaTAoSOW)
	{
		f = VjlipcmAkF;
		w = ESUD6CSd0NauOkb;
		Strategy = cDHuQVnuNIE_0;
		d = nNsgJzMYaTAoSOW;
		MaxBufferPairs = 16;
	}

	private void PsYjkc_a()
	{
		t = new Queue<int>();
		u = new Queue<int>();
		c = new List<yg2rCLlIVAZi8vk_bjeqibcttmudgpwhnitxqxhqoqxop>();
		int val = b * Environment.ProcessorCount;
		val = Math.Min(val, g);
		for (int i = 0; i < val; i++)
		{
			c.Add(new yg2rCLlIVAZi8vk_bjeqibcttmudgpwhnitxqxhqoqxop(h, w, Strategy, i));
			u.Enqueue(i);
		}
		this.i = new AutoResetEvent(initialState: false);
		r = new VCOVh2j12bt();
		m = -1;
		n = -1;
		o = -1;
		p = -1;
	}

	public override void Write(byte[] ncRoZZk5ZZ8Yk, int Hm8oT14eqDDcl, int VhwOLNZR)
	{
		bool flag = false;
		if (k)
		{
			throw new InvalidOperationException();
		}
		if (x != null)
		{
			y = true;
			Exception ex = x;
			x = null;
			throw ex;
		}
		if (VhwOLNZR == 0)
		{
			return;
		}
		if (!l)
		{
			PsYjkc_a();
			l = true;
		}
		while (true)
		{
			PsYjkc_d(a: false, flag);
			flag = false;
			int num = -1;
			if (m < 0)
			{
				if (u.Count == 0)
				{
					flag = true;
					goto IL_0124;
				}
				num = u.Dequeue();
				n++;
			}
			else
			{
				num = m;
			}
			yg2rCLlIVAZi8vk_bjeqibcttmudgpwhnitxqxhqoqxop yg2rCLlIVAZi8vk_bjeqibcttmudgpwhnitxqxhqoqxop = c[num];
			int num2 = ((yg2rCLlIVAZi8vk_bjeqibcttmudgpwhnitxqxhqoqxop.a.Length - yg2rCLlIVAZi8vk_bjeqibcttmudgpwhnitxqxhqoqxop.f > VhwOLNZR) ? VhwOLNZR : (yg2rCLlIVAZi8vk_bjeqibcttmudgpwhnitxqxhqoqxop.a.Length - yg2rCLlIVAZi8vk_bjeqibcttmudgpwhnitxqxhqoqxop.f));
			yg2rCLlIVAZi8vk_bjeqibcttmudgpwhnitxqxhqoqxop.e = n;
			Buffer.BlockCopy(ncRoZZk5ZZ8Yk, Hm8oT14eqDDcl, yg2rCLlIVAZi8vk_bjeqibcttmudgpwhnitxqxhqoqxop.a, yg2rCLlIVAZi8vk_bjeqibcttmudgpwhnitxqxhqoqxop.f, num2);
			VhwOLNZR -= num2;
			Hm8oT14eqDDcl += num2;
			yg2rCLlIVAZi8vk_bjeqibcttmudgpwhnitxqxhqoqxop.f += num2;
			if (yg2rCLlIVAZi8vk_bjeqibcttmudgpwhnitxqxhqoqxop.f == yg2rCLlIVAZi8vk_bjeqibcttmudgpwhnitxqxhqoqxop.a.Length)
			{
				if (!ThreadPool.QueueUserWorkItem(PsYjkc_e, yg2rCLlIVAZi8vk_bjeqibcttmudgpwhnitxqxhqoqxop))
				{
					break;
				}
				m = -1;
			}
			else
			{
				m = num;
			}
			goto IL_0124;
			IL_0124:
			if (VhwOLNZR <= 0)
			{
				return;
			}
		}
		throw new Exception(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ǒǰǿǿǾǥƱǴǿǠǤǴǤǴƱǦǾǣǺǸǥǴǼ", 57834), 57441));
	}

	private void PsYjkc_b()
	{
		byte[] array = new byte[128];
		GClass1 gClass = new GClass1();
		int num = gClass.toyBVLP8ziBxX(w, bool_0: false);
		gClass.rpH1xWxlQbQKT = null;
		gClass.int_0 = 0;
		gClass.IERyRPH5INmHzNia = 0;
		gClass.byte_0 = array;
		gClass.Pc3XlGJDtqV6e = 0;
		gClass.jb8wh8 = array.Length;
		num = gClass.gcbMyzeY(ADGP36Df.HbjJtwQ0c);
		if (num != 1 && num != 0)
		{
			throw new Exception(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ᛰᛱᛲᛸᛵᛠ\u16fd\u16faᛳᚮᚴ", 63298), 57702) + gClass.pUqtyJHW);
		}
		if (array.Length - gClass.jb8wh8 > 0)
		{
			f.Write(array, 0, array.Length - gClass.jb8wh8);
		}
		gClass.AShZ4SHlYgL();
		q = r.Crc32Result;
	}

	private void PsYjkc_c(bool a)
	{
		if (k)
		{
			throw new InvalidOperationException();
		}
		if (!e)
		{
			if (m >= 0)
			{
				yg2rCLlIVAZi8vk_bjeqibcttmudgpwhnitxqxhqoqxop yg2rCLlIVAZi8vk_bjeqibcttmudgpwhnitxqxhqoqxop = c[m];
				PsYjkc_e(yg2rCLlIVAZi8vk_bjeqibcttmudgpwhnitxqxhqoqxop);
				m = -1;
			}
			if (a)
			{
				PsYjkc_d(a: true, b: false);
				PsYjkc_b();
			}
			else
			{
				PsYjkc_d(a: false, b: false);
			}
		}
	}

	public override void Flush()
	{
		if (x != null)
		{
			y = true;
			Exception ex = x;
			x = null;
			throw ex;
		}
		if (!y)
		{
			PsYjkc_c(a: false);
		}
	}

	public override void Close()
	{
		if (x != null)
		{
			y = true;
			Exception ex = x;
			x = null;
			throw ex;
		}
		if (!y && !k)
		{
			PsYjkc_c(a: true);
			if (!d)
			{
				f.Close();
			}
			k = true;
		}
	}

	public void JvV0gv9nGSv4b7IDH()
	{
		Close();
		c = null;
		Dispose(a: true);
	}

	protected override void Dispose(bool a)
	{
		base.Dispose(a);
	}

	public void kjW1R11cYyecvb(Stream u9XNjMgtAaI1)
	{
		if (!l)
		{
			return;
		}
		t.Clear();
		u.Clear();
		foreach (yg2rCLlIVAZi8vk_bjeqibcttmudgpwhnitxqxhqoqxop item in c)
		{
			u.Enqueue(item.d);
			item.e = -1;
		}
		l = false;
		v = 0L;
		r = new VCOVh2j12bt();
		k = false;
		m = -1;
		n = -1;
		o = -1;
		p = -1;
		f = u9XNjMgtAaI1;
	}

	private void PsYjkc_d(bool a, bool b)
	{
		if (e)
		{
			return;
		}
		e = true;
		if (a || b)
		{
			i.WaitOne();
		}
		do
		{
			int num = -1;
			int num2 = (a ? 200 : (b ? (-1) : 0));
			int num3 = -1;
			do
			{
				if (!Monitor.TryEnter(t, num2))
				{
					num3 = -1;
					continue;
				}
				num3 = -1;
				try
				{
					if (t.Count > 0)
					{
						num3 = t.Dequeue();
					}
				}
				finally
				{
					Monitor.Exit(t);
				}
				if (num3 < 0)
				{
					continue;
				}
				yg2rCLlIVAZi8vk_bjeqibcttmudgpwhnitxqxhqoqxop yg2rCLlIVAZi8vk_bjeqibcttmudgpwhnitxqxhqoqxop = c[num3];
				if (yg2rCLlIVAZi8vk_bjeqibcttmudgpwhnitxqxhqoqxop.e != o + 1)
				{
					lock (t)
					{
						t.Enqueue(num3);
					}
					if (num == num3)
					{
						i.WaitOne();
						num = -1;
					}
					else if (num == -1)
					{
						num = num3;
					}
					continue;
				}
				num = -1;
				f.Write(yg2rCLlIVAZi8vk_bjeqibcttmudgpwhnitxqxhqoqxop.b, 0, yg2rCLlIVAZi8vk_bjeqibcttmudgpwhnitxqxhqoqxop.g);
				r.m9Vxz65(yg2rCLlIVAZi8vk_bjeqibcttmudgpwhnitxqxhqoqxop.c, yg2rCLlIVAZi8vk_bjeqibcttmudgpwhnitxqxhqoqxop.f);
				v += yg2rCLlIVAZi8vk_bjeqibcttmudgpwhnitxqxhqoqxop.f;
				yg2rCLlIVAZi8vk_bjeqibcttmudgpwhnitxqxhqoqxop.f = 0;
				o = yg2rCLlIVAZi8vk_bjeqibcttmudgpwhnitxqxhqoqxop.e;
				u.Enqueue(yg2rCLlIVAZi8vk_bjeqibcttmudgpwhnitxqxhqoqxop.d);
				if (num2 == -1)
				{
					num2 = 0;
				}
			}
			while (num3 >= 0);
		}
		while (a && o != p);
		e = false;
	}

	private void PsYjkc_e(object a)
	{
		yg2rCLlIVAZi8vk_bjeqibcttmudgpwhnitxqxhqoqxop yg2rCLlIVAZi8vk_bjeqibcttmudgpwhnitxqxhqoqxop = (yg2rCLlIVAZi8vk_bjeqibcttmudgpwhnitxqxhqoqxop)a;
		try
		{
			VCOVh2j12bt vCOVh2j12bt = new VCOVh2j12bt();
			vCOVh2j12bt.method_0(yg2rCLlIVAZi8vk_bjeqibcttmudgpwhnitxqxhqoqxop.a, 0, yg2rCLlIVAZi8vk_bjeqibcttmudgpwhnitxqxhqoqxop.f);
			PsYjkc_f(yg2rCLlIVAZi8vk_bjeqibcttmudgpwhnitxqxhqoqxop);
			yg2rCLlIVAZi8vk_bjeqibcttmudgpwhnitxqxhqoqxop.c = vCOVh2j12bt.Crc32Result;
			lock (s)
			{
				if (yg2rCLlIVAZi8vk_bjeqibcttmudgpwhnitxqxhqoqxop.e > p)
				{
					p = yg2rCLlIVAZi8vk_bjeqibcttmudgpwhnitxqxhqoqxop.e;
				}
			}
			lock (t)
			{
				t.Enqueue(yg2rCLlIVAZi8vk_bjeqibcttmudgpwhnitxqxhqoqxop.d);
			}
			i.Set();
		}
		catch (Exception ex)
		{
			lock (z)
			{
				if (x != null)
				{
					x = ex;
				}
			}
		}
	}

	private bool PsYjkc_f(yg2rCLlIVAZi8vk_bjeqibcttmudgpwhnitxqxhqoqxop a)
	{
		GClass1 gClass = a.h;
		gClass.method_4();
		gClass.int_0 = 0;
		gClass.IERyRPH5INmHzNia = a.f;
		gClass.Pc3XlGJDtqV6e = 0;
		gClass.jb8wh8 = a.b.Length;
		do
		{
			gClass.gcbMyzeY(ADGP36Df.x4mj55d4XiOiF);
		}
		while (gClass.IERyRPH5INmHzNia > 0 || gClass.jb8wh8 == 0);
		gClass.gcbMyzeY(ADGP36Df.p6Knv2M05eCM5d);
		a.g = (int)gClass.cVk5Mz;
		return true;
	}

	[Conditional("Trace")]
	private void PsYjkc_g(jkxDMlR_jlhabaufpdwqfltnpdfioaeqmgwfd a, string b, params object[] c)
	{
		if ((a & aa) != 0)
		{
			lock (j)
			{
				int hashCode = Thread.CurrentThread.GetHashCode();
				Console.ForegroundColor = (ConsoleColor)(hashCode % 8 + 8);
				Console.Write(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("\u1f46ἍἇἍἍἍὀἝὭόὲὮἝ", 62033), 60898), hashCode);
				Console.WriteLine(b, c);
				Console.ResetColor();
			}
		}
	}

	public override int Read(byte[] mfeYWddrZoVoDUvB, int oHMnRqTV2D526, int Mso9acv)
	{
		throw new NotSupportedException();
	}

	public override long Seek(long E7t937pTDzdP, SeekOrigin U4ZRkvo8nLTG)
	{
		throw new NotSupportedException();
	}

	public override void SetLength(long Y611G7JoE)
	{
		throw new NotSupportedException();
	}

	static VDZwO3Cp()
	{
		DateTime dateTime = new DateTime(2021, 7, 24);
		if ((DateTime.Now - dateTime).TotalDays <= 0.0)
		{
		}
		a = 65536;
		b = 4;
	}
}
