using System.Collections.Generic;
using ZqaFD1Ap;
using av2p5dFj;
using di1mqJMz;
using geYLBm6w;
using iiraiv39;
using ns2;
using qGIjTe0w;

namespace BZJnSPwx;

internal class j3huuqBG : Zgdu3ojh
{
	public j3huuqBG(ref Class2 jaX3TzjP)
		: base(ref jaX3TzjP)
	{
	}

	public string NCazJ4ux()
	{
		string text = ivlgLlId.jnXal2jf(uwtJIsFs(), jPuAefZQ, 28657);
		text = FFXb5i9i.Be2UxXd8(new string[11]
		{
			text, "void AvaluaReceptivitats(unsigned char nG)", jPuAefZQ, "{", jPuAefZQ, hevTs6I2, "switch (nG)", jPuAefZQ, hevTs6I2, "{",
			jPuAefZQ
		}, 53581);
		Class12 class12_ = default(Class12);
		foreach (KeyValuePair<int, sm18FGKs> item in RuM7nYib.E8cNtPVW)
		{
			KeyValuePair<int, sm18FGKs> pSf9sG7u = item;
			text = FFXb5i9i.Be2UxXd8(new string[7]
			{
				text,
				hevTs6I2,
				hevTs6I2,
				"case ",
				pSf9sG7u.Value.mGeNVBao,
				":",
				jPuAefZQ
			}, 53581);
			LQPodRO3 pnFjzbsw = new LQPodRO3();
			GnNqYKdA gnNqYKdA_ = pSf9sG7u.Value;
			i5abCRMT(ref gnNqYKdA_, ref pnFjzbsw);
			using (List<Class12>.Enumerator enumerator2 = pnFjzbsw.GetEnumerator())
			{
				int num = 0;
				while (true)
				{
					if (num != 0)
					{
						text = ivlgLlId.jnXal2jf(text, jYe6YOTG(ref pSf9sG7u, ref class12_), 28657);
					}
					if (enumerator2.MoveNext())
					{
						class12_ = enumerator2.Current;
						num = 1;
						continue;
					}
					break;
				}
			}
			text = FFXb5i9i.Be2UxXd8(new string[7] { text, hevTs6I2, hevTs6I2, hevTs6I2, "break;", jPuAefZQ, jPuAefZQ }, 53581);
		}
		return FFXb5i9i.Be2UxXd8(new string[6] { text, hevTs6I2, "}", jPuAefZQ, "}", jPuAefZQ }, 53581);
	}

	private string jYe6YOTG(ref KeyValuePair<int, sm18FGKs> pSf9sG7u, ref Class12 class12_0)
	{
		string text = "";
		string text2 = "";
		bool flag;
		if (flag = ivlgLlId.smethod_3(class12_0.iJ2mNm4t.zLvhmgIq, "true", bool_0: false, 3221) != 0)
		{
			string string_ = text;
			string arNlePjH = FFXb5i9i.smethod_0(hevTs6I2, hevTs6I2, hevTs6I2, 52605);
			int key = pSf9sG7u.Key;
			VZxzVnkV KWjlMlS = class12_0.BCDZLksu();
			text = ivlgLlId.jnXal2jf(string_, xDdloI5s(arNlePjH, key, ref KWjlMlS), 28657);
			text2 = hevTs6I2;
		}
		text = FFXb5i9i.Be2UxXd8(new string[11]
		{
			text,
			text2,
			hevTs6I2,
			hevTs6I2,
			hevTs6I2,
			"G[",
			pSf9sG7u.Value.mGeNVBao,
			"].Receptivitat.bits.bit",
			RuM7nYib.CfoWAt93[pSf9sG7u.Key].I6ksM8Iw[class12_0].ToString(),
			" = 1;",
			jPuAefZQ
		}, 53581);
		if (flag)
		{
			text = FFXb5i9i.Be2UxXd8(new string[6] { text, hevTs6I2, hevTs6I2, hevTs6I2, "}", jPuAefZQ }, 53581);
		}
		return text;
	}
}
