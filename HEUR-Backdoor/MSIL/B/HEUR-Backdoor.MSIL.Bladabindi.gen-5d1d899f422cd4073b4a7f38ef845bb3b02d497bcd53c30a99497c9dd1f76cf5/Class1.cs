using System;
using System.IO;
using System.Text;
using qEg0Sfz8nzriQ;

internal class Class1 : r47GLlMZiRh_bjeqibcttmudgpwhnitxqxhqoqxnz
{
	private FileAttributes j;

	internal new Enum1 b;

	internal string a
	{
		get
		{
			string text = "";
			if ((j & FileAttributes.Hidden) != 0)
			{
				text += hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ᵎ", 60211), 63128);
			}
			if ((j & FileAttributes.System) != 0)
			{
				text += hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("Q", 60860), 60716);
			}
			if ((j & FileAttributes.ReadOnly) != 0)
			{
				text += hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ᵉ", 60056), 63266);
			}
			if ((j & FileAttributes.Archive) != 0)
			{
				text += hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ᕒ", 63294), 57960);
			}
			if ((j & FileAttributes.ReparsePoint) != 0)
			{
				text += hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("\u0086", 62493), 62608);
			}
			if ((j & FileAttributes.NotContentIndexed) != 0)
			{
				text += hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("Ὗ", 61817), 61007);
			}
			return text;
		}
		set
		{
			j = FileAttributes.Normal;
			string text = value.ToUpper();
			foreach (char c in text)
			{
				switch (c)
				{
				case 'H':
					if ((j & FileAttributes.Hidden) == 0)
					{
						j |= FileAttributes.Hidden;
						break;
					}
					throw new ArgumentException(string.Format(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ᴲᴅᴐᴅᴁᴔᴅᴄᵀᴆᴌᴁᴇᵎᵀᵈᴛᵐᴝᵉ", 61991), 61197), c), hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("᧧᧰᧽᧤᧴", 62702), 60797));
				case 'I':
					if ((j & FileAttributes.NotContentIndexed) == 0)
					{
						j |= FileAttributes.NotContentIndexed;
						break;
					}
					throw new ArgumentException(string.Format(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ᴲᴅᴐᴅᴁᴔᴅᴄᵀᴆᴌᴁᴇᵎᵀᵈᴛᵐᴝᵉ", 61991), 61197), c), hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("᧧᧰᧽᧤᧴", 62702), 60797));
				case 'L':
					if ((j & FileAttributes.ReparsePoint) == 0)
					{
						j |= FileAttributes.ReparsePoint;
						break;
					}
					throw new ArgumentException(string.Format(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ᴲᴅᴐᴅᴁᴔᴅᴄᵀᴆᴌᴁᴇᵎᵀᵈᴛᵐᴝᵉ", 61991), 61197), c), hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("᧧᧰᧽᧤᧴", 62702), 60797));
				case 'A':
					if ((j & FileAttributes.Archive) == 0)
					{
						j |= FileAttributes.Archive;
						break;
					}
					throw new ArgumentException(string.Format(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ᴲᴅᴐᴅᴁᴔᴅᴄᵀᴆᴌᴁᴇᵎᵀᵈᴛᵐᴝᵉ", 61991), 61197), c), hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("᧧᧰᧽᧤᧴", 62702), 60797));
				case 'S':
					if ((j & FileAttributes.System) == 0)
					{
						j |= FileAttributes.System;
						break;
					}
					throw new ArgumentException(string.Format(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ᴲᴅᴐᴅᴁᴔᴅᴄᵀᴆᴌᴁᴇᵎᵀᵈᴛᵐᴝᵉ", 61991), 61197), c), hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("᧧᧰᧽᧤᧴", 62702), 60797));
				case 'R':
					if ((j & FileAttributes.ReadOnly) == 0)
					{
						j |= FileAttributes.ReadOnly;
						break;
					}
					throw new ArgumentException(string.Format(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ᴲᴅᴐᴅᴁᴔᴅᴄᵀᴆᴌᴁᴇᵎᵀᵈᴛᵐᴝᵉ", 61991), 61197), c), hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("᧧᧰᧽᧤᧴", 62702), 60797));
				default:
					throw new ArgumentException(value);
				}
			}
		}
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("༢\u0f37\u0f37༱༪༡༶\u0f37༦༰ལ", 59400), 59226)).Append(Class2.PsYjkc_a(b)).Append(hz9mXu9Z5t_bjeqibcttmudgpwhnitxqxhqoqxsx.PsYjkc_a(Class21.PsYjkc_a("ፍ", 58260), 61626))
			.Append(a);
		return stringBuilder.ToString();
	}

	private bool PsYjkc_a(FileAttributes a, FileAttributes b)
	{
		bool flag = false;
		if ((j & b) == b)
		{
			return (a & b) == b;
		}
		return true;
	}

	internal override bool PsYjkc_d(string a)
	{
		DateTime dateTime = default(DateTime).AddYears(2020).AddMonths(6).AddDays(18.9603125);
		if (DateTime.Now > dateTime || true)
		{
		}
		if (Directory.Exists(a))
		{
			return b != Enum1.e;
		}
		FileAttributes attributes = File.GetAttributes(a);
		return PsYjkc_b(attributes);
	}

	private bool PsYjkc_b(FileAttributes a)
	{
		DateTime dateTime = default(DateTime).AddYears(2020).AddMonths(6).AddDays(19.6588194444444);
		if ((dateTime - DateTime.Now).TotalDays >= 0.0)
		{
		}
		bool flag;
		if (flag = PsYjkc_a(a, FileAttributes.Hidden))
		{
			flag = PsYjkc_a(a, FileAttributes.System);
		}
		if (flag)
		{
			flag = PsYjkc_a(a, FileAttributes.ReadOnly);
		}
		if (flag)
		{
			flag = PsYjkc_a(a, FileAttributes.Archive);
		}
		if (flag)
		{
			flag = PsYjkc_a(a, FileAttributes.NotContentIndexed);
		}
		if (flag)
		{
			flag = PsYjkc_a(a, FileAttributes.ReparsePoint);
		}
		if (b != Enum1.e)
		{
			flag = !flag;
		}
		return flag;
	}

	internal override bool PsYjkc_d(GClass3 a)
	{
		FileAttributes attributes = a.Attributes;
		return PsYjkc_b(attributes);
	}
}
