using System;
using System.IO;

namespace XjXnoB31;

public class GStream0 : Stream
{
	internal Irpfum8KArHHdWO_bjeqibcttmudgpwhnitxqxhqoqxov a;

	internal Stream b;

	private bool c;

	public virtual ADGP36Df FlushMode
	{
		get
		{
			return a.c;
		}
		set
		{
			if (c)
			{
				throw new ObjectDisposedException(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("\u0744ݥݦݬݡݴݥݓݴݲݥݡݭ", 62187), 62883));
			}
			a.c = value;
		}
	}

	public int BufferSize
	{
		get
		{
			return a.i;
		}
		set
		{
			if (c)
			{
				throw new ObjectDisposedException(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ᄟᄾᄽᄷᄺᄯᄾᄈᄯᄩᄾᄺᄶ", 59317), 63142));
			}
			if (a.h != null)
			{
				throw new Vq0hzqOV0Ivo0(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ῗΎῦᾣῴῬ\u1ff1ῨῪ\u1fedῤᾣῡῶῥῥῦ\u1ff1ᾣῪ\u1ff0ᾣῢ\u1fef\u1ff1ῦῢῧῺᾣ\u1ff0ῦῷᾭ", 61551), 61308));
			}
			if (value < 1024)
			{
				throw new Vq0hzqOV0Ivo0(string.Format(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ჀძცႣჰႤღსႤჷჭშშჽႪႤჿႴჹႤღჽჰსჷႻႻႤბჷსႤქႤღჭუუსჶႤღჱტტსჶႨႤქჰႤშსქჷჰႤჿႵჹႪ", 59038), 63098), value, 1024));
			}
			a.i = value;
		}
	}

	public cDHuQVnuNIE Strategy
	{
		get
		{
			return a.l;
		}
		set
		{
			if (c)
			{
				throw new ObjectDisposedException(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("\u08e0ࣁࣂ\u08c8ࣅ\u08d0ࣁ\u08f7\u08d0\u08d6ࣁࣅ\u08c9", 61580), 63514));
			}
			a.l = value;
		}
	}

	public virtual long TotalIn => a.a.long_0;

	public virtual long TotalOut => a.a.cVk5Mz;

	public override bool CanRead
	{
		get
		{
			if (c)
			{
				throw new ObjectDisposedException(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ᵦᵇᵄᵎᵃᵖᵇᵱᵖᵐᵇᵃᵏ", 60249), 63169));
			}
			return a.k.CanRead;
		}
	}

	public override bool CanSeek => false;

	public override bool CanWrite
	{
		get
		{
			if (c)
			{
				throw new ObjectDisposedException(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ᡩᡈᡋᡁᡌᡙᡈ\u187eᡙᡟᡈᡌᡀ", 63386), 61360));
			}
			return a.k.CanWrite;
		}
	}

	public override long Length
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	public override long Position
	{
		get
		{
			if (a.b == Irpfum8KArHHdWO_bjeqibcttmudgpwhnitxqxhqoqxov.Enum2.a)
			{
				return a.a.cVk5Mz;
			}
			if (a.b == Irpfum8KArHHdWO_bjeqibcttmudgpwhnitxqxhqoqxov.Enum2.b)
			{
				return a.a.long_0;
			}
			return 0L;
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	public GStream0(Stream stream_0, hoerKaWa AgCnKu)
		: this(stream_0, AgCnKu, VdckbyAnJG7MLj3W.m7wqam, bool_0: false)
	{
	}

	public GStream0(Stream OmPynieAEF, hoerKaWa Sa4ZmjIy4GkQYcN, VdckbyAnJG7MLj3W pvc2CG)
		: this(OmPynieAEF, Sa4ZmjIy4GkQYcN, pvc2CG, bool_0: false)
	{
	}

	public GStream0(Stream stream_0, hoerKaWa Eex2IHdO, bool XjYdurC8)
		: this(stream_0, Eex2IHdO, VdckbyAnJG7MLj3W.m7wqam, XjYdurC8)
	{
	}

	public GStream0(Stream stream_0, hoerKaWa CLFJzda, VdckbyAnJG7MLj3W I27fGvmebuc7ssd, bool bool_0)
	{
		b = stream_0;
		a = new Irpfum8KArHHdWO_bjeqibcttmudgpwhnitxqxhqoqxov(stream_0, CLFJzda, I27fGvmebuc7ssd, U7doUTpEnhbKTw_bjeqibcttmudgpwhnitxqxhqoqxou.b, bool_0);
	}

	protected override void Dispose(bool vRFq35eV)
	{
		try
		{
			if (!c)
			{
				if (vRFq35eV && a != null)
				{
					a.Close();
				}
				c = true;
			}
		}
		finally
		{
			base.Dispose(vRFq35eV);
		}
	}

	public override void Flush()
	{
		if (c)
		{
			throw new ObjectDisposedException(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("\u0b80\u0ba1\u0ba2ந\u0ba5ர\u0ba1\u0b97ரஶ\u0ba1\u0ba5ன", 62362), 63574));
		}
		a.Flush();
	}

	public override int Read(byte[] IM3zrIvT4zFQs, int jGxHEF01C, int qxROIUwWyOnogS2Yb)
	{
		if (c)
		{
			throw new ObjectDisposedException(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ሑሰሳሹሴሡሰሆሡሧሰሴሸ", 59315), 62950));
		}
		return a.Read(IM3zrIvT4zFQs, jGxHEF01C, qxROIUwWyOnogS2Yb);
	}

	public override long Seek(long kipQcyYT, SeekOrigin yvzTcs52iDpo3)
	{
		throw new NotImplementedException();
	}

	public override void SetLength(long s4ioki58RkDBq)
	{
		throw new NotImplementedException();
	}

	public override void Write(byte[] EM3msxq2jB, int rWTJGx4iVHonYQ, int cow2h7ze)
	{
		if (c)
		{
			throw new ObjectDisposedException(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ӅӤӧӭӠӵӤӒӵӳӤӠӬ", 61435), 60218));
		}
		a.Write(EM3msxq2jB, rWTJGx4iVHonYQ, cow2h7ze);
	}

	public static byte[] wUN4VsaZIN(string HqyKzJijseT5)
	{
		using MemoryStream memoryStream = new MemoryStream();
		Stream stream = new GStream0(memoryStream, hoerKaWa.dhSImQm6QL, VdckbyAnJG7MLj3W.dvBHV0YgfC);
		Irpfum8KArHHdWO_bjeqibcttmudgpwhnitxqxhqoqxov.PsYjkc_e(HqyKzJijseT5, stream);
		return memoryStream.ToArray();
	}

	public static byte[] GhqQqdYR8xYUJZXr(byte[] i5WplbMzB4)
	{
		using MemoryStream memoryStream = new MemoryStream();
		Stream stream = new GStream0(memoryStream, hoerKaWa.dhSImQm6QL, VdckbyAnJG7MLj3W.dvBHV0YgfC);
		Irpfum8KArHHdWO_bjeqibcttmudgpwhnitxqxhqoqxov.PsYjkc_f(i5WplbMzB4, stream);
		return memoryStream.ToArray();
	}

	public static string jzUie7HrFY(byte[] w26jVx6d)
	{
		using MemoryStream stream_ = new MemoryStream(w26jVx6d);
		Stream stream = new GStream0(stream_, hoerKaWa.DLsHxV7UHMC);
		return Irpfum8KArHHdWO_bjeqibcttmudgpwhnitxqxhqoqxov.PsYjkc_g(w26jVx6d, stream);
	}

	public static byte[] BGGeFH5f3M6LB(byte[] KKNJgV81jowJ)
	{
		using MemoryStream stream_ = new MemoryStream(KKNJgV81jowJ);
		Stream stream = new GStream0(stream_, hoerKaWa.DLsHxV7UHMC);
		return Irpfum8KArHHdWO_bjeqibcttmudgpwhnitxqxhqoqxov.PsYjkc_h(KKNJgV81jowJ, stream);
	}
}
