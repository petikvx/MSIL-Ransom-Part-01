using System;
using System.IO;
using System.Text;

namespace XjXnoB31;

public class RApUt0plJ8G : Stream
{
	public DateTime? nullable_0;

	private int a;

	internal Irpfum8KArHHdWO_bjeqibcttmudgpwhnitxqxhqoqxov b;

	private bool c;

	private bool d;

	private string e;

	private string f;

	private int g;

	internal static readonly DateTime h = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

	internal static readonly Encoding i = Encoding.GetEncoding(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("!;'epp}qey", 58898), 58930));

	public string Comment
	{
		get
		{
			return f;
		}
		set
		{
			if (c)
			{
				throw new ObjectDisposedException(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ứỴệỞỽỚỜịỏể", 59635), 63060));
			}
			f = value;
		}
	}

	public string FileName
	{
		get
		{
			return e;
		}
		set
		{
			if (c)
			{
				throw new ObjectDisposedException(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ᢕᢈᢻᢢᢁᢦᢠᢷᢳᢿ", 59959), 62120));
			}
			e = value;
			if (e != null)
			{
				if (e.IndexOf(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ణ", 62580), 63497)) != -1)
				{
					e = e.Replace(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ణ", 62580), 63497), hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("հ", 61731), 62592));
				}
				if (e.EndsWith(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("հ", 61731), 62592)))
				{
					throw new Exception(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ᅏᅪᅪᅣᅡᅧᅪᄦᅠᅯᅪᅣᅨᅧᅫᅣ", 61576), 57787));
				}
				if (e.IndexOf(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("հ", 61731), 62592)) != -1)
				{
					e = Path.GetFileName(e);
				}
			}
		}
	}

	public int Crc32 => g;

	public virtual ADGP36Df FlushMode
	{
		get
		{
			return b.c;
		}
		set
		{
			if (c)
			{
				throw new ObjectDisposedException(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("\u0b81ஜயஶகலழண\u0ba7\u0bab", 58768), 60928));
			}
			b.c = value;
		}
	}

	public int BufferSize
	{
		get
		{
			return b.i;
		}
		set
		{
			if (c)
			{
				throw new ObjectDisposedException(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("\u0a77੪ਖ਼\u0a40\u0a63\u0a44\u0a42\u0a55\u0a51\u0a5d", 58879), 61191));
			}
			if (b.h != null)
			{
				throw new Vq0hzqOV0Ivo0(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ҕҩҤӡҶҮҳҪҨүҦӡңҴҧҧҤҳӡҨҲӡҠҭҳҤҠҥҸӡҲҤҵӯ", 58515), 57466));
			}
			if (value < 1024)
			{
				throw new Vq0hzqOV0Ivo0(string.Format(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ᑮᑅᑄᐍᑞᐊᑈᑏᐊᑙᑃᑆᑆᑓᐄᐊᑑᐚᑗᐊᑈᑓᑞᑏᑙᐕᐕᐊᑿᑙᑏᐊᑋᐊᑈᑃᑍᑍᑏᑘᐊᑈᑟᑌᑌᑏᑘᐆᐊᑋᑞᐊᑆᑏᑋᑙᑞᐊᑑᐛᑗᐄ", 62628), 57477), value, 1024));
			}
			b.i = value;
		}
	}

	public virtual long TotalIn => b.a.long_0;

	public virtual long TotalOut => b.a.cVk5Mz;

	public override bool CanRead
	{
		get
		{
			if (c)
			{
				throw new ObjectDisposedException(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ᶍᶐᶣᶺᶙᶾᶸᶯᶫᶧ", 63133), 60176));
			}
			return b.k.CanRead;
		}
	}

	public override bool CanSeek => false;

	public override bool CanWrite
	{
		get
		{
			if (c)
			{
				throw new ObjectDisposedException(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("\u0b4d\u0b50\u0b63\u0b7a\u0b59\u0b7e\u0b78୯୫୧", 60381), 57552));
			}
			return b.k.CanWrite;
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
			if (b.b == Irpfum8KArHHdWO_bjeqibcttmudgpwhnitxqxhqoqxov.Enum2.a)
			{
				return b.a.cVk5Mz + a;
			}
			if (b.b == Irpfum8KArHHdWO_bjeqibcttmudgpwhnitxqxhqoqxov.Enum2.b)
			{
				return b.a.long_0 + b.q;
			}
			return 0L;
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	public RApUt0plJ8G(Stream stream_0, hoerKaWa g9ErT3tfgzS)
		: this(stream_0, g9ErT3tfgzS, VdckbyAnJG7MLj3W.m7wqam, bool_0: false)
	{
	}

	public RApUt0plJ8G(Stream CF1iaFr, hoerKaWa hoerKaWa_0, VdckbyAnJG7MLj3W YTc690v)
		: this(CF1iaFr, hoerKaWa_0, YTc690v, bool_0: false)
	{
	}

	public RApUt0plJ8G(Stream Zl1XbZt2TjDTv, hoerKaWa hoerKaWa_0, bool bool_0)
		: this(Zl1XbZt2TjDTv, hoerKaWa_0, VdckbyAnJG7MLj3W.m7wqam, bool_0)
	{
	}

	public RApUt0plJ8G(Stream vf5h2TkAAMFLfZs0, hoerKaWa qWuohoLbzj, VdckbyAnJG7MLj3W vdckbyAnJG7MLj3W_0, bool bool_0)
	{
		b = new Irpfum8KArHHdWO_bjeqibcttmudgpwhnitxqxhqoqxov(vf5h2TkAAMFLfZs0, qWuohoLbzj, vdckbyAnJG7MLj3W_0, U7doUTpEnhbKTw_bjeqibcttmudgpwhnitxqxhqoqxou.c, bool_0);
	}

	protected override void Dispose(bool tUI9HTks0Qzo)
	{
		try
		{
			if (!c)
			{
				if (tUI9HTks0Qzo && b != null)
				{
					b.Close();
					g = b.s;
				}
				c = true;
			}
		}
		finally
		{
			base.Dispose(tUI9HTks0Qzo);
		}
	}

	public override void Flush()
	{
		if (c)
		{
			throw new ObjectDisposedException(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("\u177eᝣᝐᝉᝪᝍᝋ\u175c\u1758\u1754", 63332), 57558));
		}
		b.Flush();
	}

	public override int Read(byte[] AjLrG2a4BEK, int QB4CUCY59pTe8ym, int sUr1mlzkj)
	{
		if (c)
		{
			throw new ObjectDisposedException(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ጓጎጽጤጇጠጦጱጵጹ", 57770), 62142));
		}
		int result = b.Read(AjLrG2a4BEK, QB4CUCY59pTe8ym, sUr1mlzkj);
		if (!d)
		{
			d = true;
			FileName = b.n;
			Comment = b.o;
		}
		return result;
	}

	public override long Seek(long Ee7VrR9, SeekOrigin UENIDs)
	{
		throw new NotImplementedException();
	}

	public override void SetLength(long A5pLNWWJUln)
	{
		throw new NotImplementedException();
	}

	public override void Write(byte[] b36bPqTCAa, int s18tGBuS1VS, int p0SlNo4)
	{
		if (c)
		{
			throw new ObjectDisposedException(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ޝހ\u07b3\u07aaމ\u07ae\u07a8\u07bf\u07bb\u07b7", 62439), 62516));
		}
		if (b.b == Irpfum8KArHHdWO_bjeqibcttmudgpwhnitxqxhqoqxov.Enum2.c)
		{
			if (!b.t)
			{
				throw new InvalidOperationException();
			}
			a = PsYjkc_a();
		}
		b.Write(b36bPqTCAa, s18tGBuS1VS, p0SlNo4);
	}

	private int PsYjkc_a()
	{
		byte[] array = ((Comment == null) ? null : i.GetBytes(Comment));
		byte[] array2 = ((FileName == null) ? null : i.GetBytes(FileName));
		int num = ((Comment != null) ? (array.Length + 1) : 0);
		int num2 = ((FileName != null) ? (array2.Length + 1) : 0);
		byte[] array3 = new byte[10 + num + num2];
		int num3 = 0;
		num3 = 1;
		array3[0] = 31;
		num3 = 2;
		array3[1] = 139;
		num3 = 3;
		array3[2] = 8;
		byte b = 0;
		if (Comment != null)
		{
			b = (byte)(b ^ 0x10u);
		}
		if (FileName != null)
		{
			b = (byte)(b ^ 8u);
		}
		array3[num3++] = b;
		if (!nullable_0.HasValue)
		{
			nullable_0 = DateTime.Now;
		}
		Array.Copy(BitConverter.GetBytes((int)(nullable_0.Value - h).TotalSeconds), 0, array3, num3, 4);
		num3 += 4;
		array3[num3++] = 0;
		array3[num3++] = byte.MaxValue;
		if (num2 != 0)
		{
			Array.Copy(array2, 0, array3, num3, num2 - 1);
			num3 += num2 - 1;
			array3[num3++] = 0;
		}
		if (num != 0)
		{
			Array.Copy(array, 0, array3, num3, num - 1);
			num3 += num - 1;
			array3[num3++] = 0;
		}
		this.b.k.Write(array3, 0, array3.Length);
		return array3.Length;
	}

	public static byte[] HbfxGXsf(string string_0)
	{
		using MemoryStream memoryStream = new MemoryStream();
		Stream stream = new RApUt0plJ8G(memoryStream, hoerKaWa.dhSImQm6QL, VdckbyAnJG7MLj3W.dvBHV0YgfC);
		Irpfum8KArHHdWO_bjeqibcttmudgpwhnitxqxhqoqxov.PsYjkc_e(string_0, stream);
		return memoryStream.ToArray();
	}

	public static byte[] ZjpO1Fu(byte[] pJhod5tgcW)
	{
		using MemoryStream memoryStream = new MemoryStream();
		Stream stream = new RApUt0plJ8G(memoryStream, hoerKaWa.dhSImQm6QL, VdckbyAnJG7MLj3W.dvBHV0YgfC);
		Irpfum8KArHHdWO_bjeqibcttmudgpwhnitxqxhqoqxov.PsYjkc_f(pJhod5tgcW, stream);
		return memoryStream.ToArray();
	}

	public static string jQlN6VDUkI4(byte[] ueUmXd8MPbZs6)
	{
		using MemoryStream stream_ = new MemoryStream(ueUmXd8MPbZs6);
		Stream stream = new RApUt0plJ8G(stream_, hoerKaWa.DLsHxV7UHMC);
		return Irpfum8KArHHdWO_bjeqibcttmudgpwhnitxqxhqoqxov.PsYjkc_g(ueUmXd8MPbZs6, stream);
	}

	public static byte[] smethod_0(byte[] lFdOpmX)
	{
		using MemoryStream stream_ = new MemoryStream(lFdOpmX);
		Stream stream = new RApUt0plJ8G(stream_, hoerKaWa.DLsHxV7UHMC);
		return Irpfum8KArHHdWO_bjeqibcttmudgpwhnitxqxhqoqxov.PsYjkc_h(lFdOpmX, stream);
	}
}
