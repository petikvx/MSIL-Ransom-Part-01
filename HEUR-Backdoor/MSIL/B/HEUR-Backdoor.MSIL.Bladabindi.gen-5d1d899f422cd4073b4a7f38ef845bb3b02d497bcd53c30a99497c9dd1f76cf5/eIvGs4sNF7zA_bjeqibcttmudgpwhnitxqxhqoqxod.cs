using System;
using System.IO;
using System.Text;
using qEg0Sfz8nzriQ;

internal class eIvGs4sNF7zA_bjeqibcttmudgpwhnitxqxhqoqxod : r47GLlMZiRh_bjeqibcttmudgpwhnitxqxhqoqxnz
{
	private char i;

	internal new Enum1 b;

	internal string a
	{
		get
		{
			return i.ToString();
		}
		set
		{
			if (value.Length != 1 || (value[0] != 'D' && value[0] != 'F'))
			{
				throw new ArgumentException(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ղՑՄՂՈՇ\u0558ԁՀԁՒՈՏՆՍՄԁՂՉՀՓՀՂՕՄՓԛԁՄՈՕՉՄՓԁեԁՎՓԁէ", 61274), 60145));
			}
			i = value[0];
		}
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ସଵ\u0b3c\u0b29୬", 58150), 59505)).Append(Class2.PsYjkc_a(b)).Append(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ᔤ", 62562), 57662))
			.Append(a);
		return stringBuilder.ToString();
	}

	internal override bool PsYjkc_d(string a)
	{
		bool flag = ((i == 'D') ? Directory.Exists(a) : File.Exists(a));
		if (b != Enum1.e)
		{
			flag = !flag;
		}
		return flag;
	}

	internal override bool PsYjkc_d(GClass3 a)
	{
		bool flag = ((i == 'D') ? a.IsDirectory : (!a.IsDirectory));
		if (b != Enum1.e)
		{
			flag = !flag;
		}
		return flag;
	}
}
