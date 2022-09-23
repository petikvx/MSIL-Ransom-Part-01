using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using qEg0Sfz8nzriQ;

internal class pa2Bj6lQ1_bjeqibcttmudgpwhnitxqxhqoqxoc : r47GLlMZiRh_bjeqibcttmudgpwhnitxqxhqoqxnz
{
	private Regex f;

	private string g;

	internal new Enum1 b;

	private string h;

	internal virtual string a
	{
		set
		{
			if (Directory.Exists(value))
			{
				h = hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("\u07aaߘ", 62647), 62257) + value + hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ᕢᔔᔐᔔ", 62144), 59239);
			}
			else
			{
				h = value;
			}
			g = hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ص", 61349), 59862) + Regex.Escape(h).Replace(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ᐛᐛᐛᑭᐛᑩᐛᑭ", 63395), 58284), hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ዬዬኘያዮዬኞይኛዌኞኚዬኞያዮዬዬዬኞይኚኙ", 62526), 58950)).Replace(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ɦȔɦȐ", 61877), 62347), hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ϏνψύϏϏϏνώι", 61223), 60476))
				.Replace(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ჶႀ", 62177), 57924), hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ᖈᖌ", 58973), 62313))
				.Replace(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("\u1a67ᨄ", 60764), 63332), hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ཋཎཌཌཌ\u0f3eཌྷ", 60577), 58271)) + hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ᔀ", 62545), 57641);
			f = new Regex(g, RegexOptions.IgnoreCase);
		}
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ഈഇഋ\u0d03\u0d46", 58739), 59541)).Append(Class2.PsYjkc_a(b)).Append(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("\u036c\u036b", 60889), 61076))
			.Append(h)
			.Append(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ᮇ", 63307), 60561));
		return stringBuilder.ToString();
	}

	internal override bool PsYjkc_d(string a)
	{
		return PsYjkc_a(a);
	}

	private bool PsYjkc_a(string a)
	{
		string input = ((h.IndexOf('\\') == -1) ? Path.GetFileName(a) : a);
		bool flag = f.IsMatch(input);
		if (b != Enum1.e)
		{
			flag = !flag;
		}
		return flag;
	}

	internal override bool PsYjkc_d(GClass3 a)
	{
		string text = a.FileName.Replace(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("\u033b", 58273), 57587), hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ቕ", 62437), 57708));
		return PsYjkc_a(text);
	}
}
