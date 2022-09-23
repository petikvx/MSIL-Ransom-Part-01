using System;
using System.IO;
using System.Text;
using qEg0Sfz8nzriQ;

internal class Class0 : r47GLlMZiRh_bjeqibcttmudgpwhnitxqxhqoqxnz
{
	internal new Enum1 b;

	internal long c;

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("᮱\u1bab᮸\u1ba7ᯢ", 61881), 59985)).Append(Class2.PsYjkc_a(b)).Append(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("\u173c", 58860), 62050))
			.Append(c.ToString());
		return stringBuilder.ToString();
	}

	internal override bool PsYjkc_d(string a)
	{
		FileInfo fileInfo = new FileInfo(a);
		return PsYjkc_a(fileInfo.Length);
	}

	private bool PsYjkc_a(long a)
	{
		bool flag = false;
		return b switch
		{
			Enum1.a => a > c, 
			Enum1.b => a >= c, 
			Enum1.c => a < c, 
			Enum1.d => a <= c, 
			Enum1.e => a == c, 
			Enum1.f => a != c, 
			_ => throw new ArgumentException(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ޞޡ\u07b4ޣ\u07b0ޥ\u07beޣ", 61566), 63277)), 
		};
	}

	internal override bool PsYjkc_d(GClass3 a)
	{
		return PsYjkc_a(a.UncompressedSize);
	}
}
