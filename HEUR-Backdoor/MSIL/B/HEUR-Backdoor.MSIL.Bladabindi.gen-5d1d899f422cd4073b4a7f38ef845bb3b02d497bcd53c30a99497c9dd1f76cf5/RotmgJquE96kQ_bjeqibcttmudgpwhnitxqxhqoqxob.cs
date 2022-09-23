using System;
using System.IO;
using System.Text;
using BIEoqAXg6;
using qEg0Sfz8nzriQ;

internal class RotmgJquE96kQ_bjeqibcttmudgpwhnitxqxhqoqxob : r47GLlMZiRh_bjeqibcttmudgpwhnitxqxhqoqxnz
{
	internal new Enum1 b;

	internal Enum0 d;

	internal DateTime e;

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(d.ToString()).Append(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("\u0019", 61070), 61136)).Append(Class2.PsYjkc_a(b))
			.Append(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("\u0019", 61070), 61136))
			.Append(e.ToString(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("\u0b53\u0b53\u0b53\u0b53ଇ୧୧ଇ\u0b4e\u0b4eଇ\u0b62\u0b62ଐ\u0b47\u0b47ଐ\u0b59\u0b59", 58837), 61149)));
		return stringBuilder.ToString();
	}

	internal override bool PsYjkc_d(string a)
	{
		return PsYjkc_a(d switch
		{
			Enum0.IetURhIZJ5reLB => File.GetLastAccessTime(a).ToUniversalTime(), 
			Enum0.JbkbB4ixj3Vm => File.GetLastWriteTime(a).ToUniversalTime(), 
			Enum0.Ahfo4qPzR => File.GetCreationTime(a).ToUniversalTime(), 
			_ => throw new ArgumentException(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ఇసభ\u0c3a\u0c29\u0c3cధ\u0c3a", 59394), 58386)), 
		});
	}

	private bool PsYjkc_a(DateTime a)
	{
		bool flag = false;
		return b switch
		{
			Enum1.a => a > e, 
			Enum1.b => a >= e, 
			Enum1.c => a < e, 
			Enum1.d => a <= e, 
			Enum1.e => a == e, 
			Enum1.f => a != e, 
			_ => throw new ArgumentException(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("Gxmzi|gz", 60134), 59967)), 
		};
	}

	internal override bool PsYjkc_d(GClass3 a)
	{
		return PsYjkc_a(d switch
		{
			Enum0.IetURhIZJ5reLB => a.AccessedTime, 
			Enum0.JbkbB4ixj3Vm => a.ModifiedTime, 
			Enum0.Ahfo4qPzR => a.CreationTime, 
			_ => throw new ArgumentException(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("\u1df3\u1df3ᶸᶥᶡᶩ", 61222), 62161)), 
		});
	}
}
