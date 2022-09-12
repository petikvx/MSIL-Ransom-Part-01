using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.Kofe.IJDWP;

namespace Microsoft.Kofe.Engine;

internal class A28774298
{
	private enum BFB116EC0
	{
		Int,
		Long
	}

	private enum C42EDE98F
	{
		Float,
		Double
	}

	private struct E2BF92117
	{
		public readonly string DF1F22F36;

		public readonly DF0AD6554 CC609BEEE;

		public E2BF92117(string v, DF0AD6554 t)
		{
			DF1F22F36 = v;
			CC609BEEE = t;
		}
	}

	private delegate bool A92B697E9(char c);

	[CompilerGenerated]
	private sealed class B4BEAB019
	{
		public DF0AD6554 F40FC833A;

		internal bool B8B5080FC(E2BF92117 E87CB6062)
		{
			return F40FC833A == E87CB6062.CC609BEEE;
		}
	}

	[CompilerGenerated]
	private sealed class F4ED974D8
	{
		public string AC2D47077;

		internal bool BABBB6505(E2BF92117 B143958D8)
		{
			return B143958D8.DF1F22F36 == AC2D47077;
		}
	}

	[CompilerGenerated]
	private sealed class E3BC29D97
	{
		public DF0AD6554 F9E88B529;

		internal bool E7C6FCBBE(E2BF92117 E4AE6D76E)
		{
			return E4AE6D76E.CC609BEEE == F9E88B529;
		}
	}

	private string E4D5077CC;

	private int D585AD04A;

	private int EC4B957DA;

	private static E2BF92117[] C686A0D72 = new E2BF92117[9]
	{
		new E2BF92117("(", DF0AD6554.LeftParen),
		new E2BF92117(")", DF0AD6554.RightParen),
		new E2BF92117("{", DF0AD6554.LeftCurly),
		new E2BF92117("}", DF0AD6554.RightCurly),
		new E2BF92117("[", DF0AD6554.LeftBrace),
		new E2BF92117("]", DF0AD6554.RightBrace),
		new E2BF92117(";", DF0AD6554.SemiColon),
		new E2BF92117(",", DF0AD6554.Comma),
		new E2BF92117(".", DF0AD6554.Dot)
	};

	private static E2BF92117[] BFFC67C42 = new E2BF92117[37]
	{
		new E2BF92117(">>>=", DF0AD6554.UnsignedRightShiftEquals),
		new E2BF92117("<<=", DF0AD6554.RightShiftEquals),
		new E2BF92117(">>=", DF0AD6554.LeftShiftEquals),
		new E2BF92117(">>>", DF0AD6554.UnsignedRightShift),
		new E2BF92117("<<", DF0AD6554.LeftShift),
		new E2BF92117(">>", DF0AD6554.RightShift),
		new E2BF92117("+=", DF0AD6554.PlusEquals),
		new E2BF92117("-=", DF0AD6554.MinusEquals),
		new E2BF92117("*=", DF0AD6554.TimesEquals),
		new E2BF92117("/=", DF0AD6554.DivideEquals),
		new E2BF92117("&=", DF0AD6554.AndEquals),
		new E2BF92117("|=", DF0AD6554.OrEquals),
		new E2BF92117("^=", DF0AD6554.ExclusiveOrEquals),
		new E2BF92117("%=", DF0AD6554.ModEquals),
		new E2BF92117("==", DF0AD6554.Equals),
		new E2BF92117("<=", DF0AD6554.LessThanOrEqual),
		new E2BF92117(">=", DF0AD6554.GreaterThanOrEqual),
		new E2BF92117("!=", DF0AD6554.NotEqual),
		new E2BF92117("&&", DF0AD6554.And),
		new E2BF92117("||", DF0AD6554.Or),
		new E2BF92117("++", DF0AD6554.Increment),
		new E2BF92117("--", DF0AD6554.Decrement),
		new E2BF92117("=", DF0AD6554.Assignment),
		new E2BF92117(">", DF0AD6554.GreaterThan),
		new E2BF92117("<", DF0AD6554.LessThan),
		new E2BF92117("!", DF0AD6554.UnaryNot),
		new E2BF92117("~", DF0AD6554.UnaryComplement),
		new E2BF92117("?", DF0AD6554.QuestionMark),
		new E2BF92117(":", DF0AD6554.Colon),
		new E2BF92117("+", DF0AD6554.Plus),
		new E2BF92117("-", DF0AD6554.Minus),
		new E2BF92117("*", DF0AD6554.Times),
		new E2BF92117("/", DF0AD6554.Divide),
		new E2BF92117("&", DF0AD6554.BitwiseAnd),
		new E2BF92117("|", DF0AD6554.BitwiseOr),
		new E2BF92117("^", DF0AD6554.BitwiseExclusiveOr),
		new E2BF92117("%", DF0AD6554.Modulus)
	};

	private static E2BF92117[] B2DDA6654 = new E2BF92117[11]
	{
		new E2BF92117("this", DF0AD6554.This),
		new E2BF92117("super", DF0AD6554.Super),
		new E2BF92117("class", DF0AD6554.Class),
		new E2BF92117("boolean", DF0AD6554.Boolean),
		new E2BF92117("byte", DF0AD6554.Byte),
		new E2BF92117("short", DF0AD6554.Short),
		new E2BF92117("int", DF0AD6554.Int),
		new E2BF92117("long", DF0AD6554.Long),
		new E2BF92117("char", DF0AD6554.Char),
		new E2BF92117("float", DF0AD6554.Float),
		new E2BF92117("double", DF0AD6554.Double)
	};

	private int EC88DD41C => EC4B957DA - D585AD04A;

	private int D70960424 => EC4B957DA;

	private int A7EA8DF30 => D585AD04A;

	private bool B8781A042 => A7EA8DF30 == D70960424;

	private char FB4652E24 => E4D5077CC[D585AD04A];

	private char BD918FE8C => E4D5077CC[D585AD04A - 1];

	public A28774298(string Input)
	{
		E4D5077CC = Input;
		D585AD04A = 0;
		EC4B957DA = Input.Length;
	}

	public void ECCD44FDC(string B45CBB3AD)
	{
		throw new ED27ADBE9(B45CBB3AD, D585AD04A);
	}

	public void C3727A316(string F47DE6681, Exception D907784B8)
	{
		throw new ED27ADBE9(F47DE6681, D907784B8, D585AD04A);
	}

	private void D42A2351D(int B119E11C5)
	{
		D585AD04A = B119E11C5;
	}

	private void C06678D70()
	{
		D585AD04A++;
	}

	private bool C74FB4E95(string AA5BDA299)
	{
		if (EC88DD41C >= AA5BDA299.Length && E4D5077CC.Substring(D585AD04A, AA5BDA299.Length) == AA5BDA299)
		{
			D585AD04A += AA5BDA299.Length;
			return true;
		}
		return false;
	}

	private static bool D0C696BA4(char EFC142544)
	{
		if (EFC142544 >= '0')
		{
			return EFC142544 <= '9';
		}
		return false;
	}

	private static bool C3EA03806(char C704830A9)
	{
		if ((C704830A9 < '0' || C704830A9 > '9') && (C704830A9 < 'a' || C704830A9 > 'f'))
		{
			if (C704830A9 >= 'A')
			{
				return C704830A9 <= 'F';
			}
			return false;
		}
		return true;
	}

	private static bool C4BB062FB(char A127996C7)
	{
		if (A127996C7 >= '0')
		{
			return A127996C7 <= '7';
		}
		return false;
	}

	private static bool FC2FCF486(char D064D6889)
	{
		if (D064D6889 >= '0')
		{
			return D064D6889 <= '3';
		}
		return false;
	}

	private static bool EA78D573E(char B463171B8)
	{
		if (B463171B8 != '0')
		{
			return B463171B8 == '1';
		}
		return true;
	}

	private static int F00763589(char E36B7E49E)
	{
		if (E36B7E49E >= '0' && E36B7E49E <= '9')
		{
			return E36B7E49E - 48;
		}
		if (E36B7E49E >= 'a' && E36B7E49E <= 'f')
		{
			return E36B7E49E - 97 + 10;
		}
		return E36B7E49E - 65 + 10;
	}

	private static bool F30D2A162(char CB54E7DBE)
	{
		if (!char.IsLetter(CB54E7DBE) && CB54E7DBE != '_')
		{
			return CB54E7DBE == '$';
		}
		return true;
	}

	private static bool C17D74ACE(char B930A0F54)
	{
		if (!F30D2A162(B930A0F54))
		{
			return char.IsDigit(B930A0F54);
		}
		return true;
	}

	private DF0AD6554 BBE74270B(E2BF92117[] B4E6004DD)
	{
		for (int i = 0; i < B4E6004DD.Length; i++)
		{
			E2BF92117 e2BF = B4E6004DD[i];
			if (C74FB4E95(e2BF.DF1F22F36))
			{
				return e2BF.CC609BEEE;
			}
		}
		return DF0AD6554.IllegalToken;
	}

	public static string E903ED30B(DF0AD6554 D1659989F)
	{
		return Array.Find(BFFC67C42, (E2BF92117 E87CB6062) => D1659989F == E87CB6062.CC609BEEE)!.DF1F22F36;
	}

	private void F5568FF10()
	{
		while (EC88DD41C >= 2)
		{
			if (E4D5077CC[D585AD04A] == '*' && E4D5077CC[D585AD04A + 1] == '/')
			{
				D585AD04A += 2;
				return;
			}
			C06678D70();
		}
		ECCD44FDC(B0E4D9146.B51DF12C5);
	}

	private string DDD024680()
	{
		if (F30D2A162(FB4652E24))
		{
			int d585AD04A = D585AD04A;
			C06678D70();
			while (!B8781A042 && C17D74ACE(FB4652E24))
			{
				C06678D70();
			}
			return E4D5077CC.Substring(d585AD04A, D585AD04A - d585AD04A);
		}
		return null;
	}

	private void DC3D26B98(out long F90F531B2, A92B697E9 DA780978D, int B3B341A6F)
	{
		int num = 0;
		long num2 = 0L;
		while (!B8781A042)
		{
			_ = FB4652E24;
			_ = 95;
			if (!DA780978D(FB4652E24))
			{
				break;
			}
			num2 = num2 * B3B341A6F + F00763589(FB4652E24);
			num++;
			C06678D70();
		}
		F90F531B2 = num2;
		if (num == 0 || BD918FE8C == '_')
		{
			ECCD44FDC(B0E4D9146.C3A373321);
		}
	}

	private DF0AD6554 CFB114F5E(out FC5192EE3 AC717D4CB)
	{
		if (!B8781A042 && D0C696BA4(FB4652E24))
		{
			long F90F531B = 0L;
			if (FB4652E24 == '0')
			{
				C06678D70();
				if (!B8781A042)
				{
					if (FB4652E24 == 'x' || FB4652E24 == 'X')
					{
						C06678D70();
						DC3D26B98(out F90F531B, C3EA03806, 16);
					}
					else if (FB4652E24 == 'b' || FB4652E24 == 'B')
					{
						C06678D70();
						DC3D26B98(out F90F531B, EA78D573E, 2);
					}
					else if (C4BB062FB(FB4652E24))
					{
						DC3D26B98(out F90F531B, C4BB062FB, 8);
					}
					else if (D0C696BA4(FB4652E24))
					{
						ECCD44FDC(B0E4D9146.B79DD481F);
					}
					else
					{
						F90F531B = 0L;
					}
				}
			}
			else
			{
				DC3D26B98(out F90F531B, D0C696BA4, 10);
			}
			if (!B8781A042 && (FB4652E24 == 'l' || FB4652E24 == 'L'))
			{
				C06678D70();
				AC717D4CB = new FC5192EE3(F90F531B);
			}
			else
			{
				AC717D4CB = new FC5192EE3((int)F90F531B);
			}
			return DF0AD6554.IntegerLiteral;
		}
		AC717D4CB = null;
		return DF0AD6554.IllegalToken;
	}

	private void E46B795C3(A92B697E9 FC7FD4AAE)
	{
		while (!B8781A042 && FC7FD4AAE(FB4652E24))
		{
			C06678D70();
		}
	}

	private DF0AD6554 AD6CBDB81(out FC5192EE3 B765D720A)
	{
		int position = A7EA8DF30;
		B765D720A = null;
		if (!B8781A042 && (FB4652E24 == '.' || D0C696BA4(FB4652E24)))
		{
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = false;
			bool flag5 = false;
			if (!B8781A042 && D0C696BA4(FB4652E24))
			{
				E46B795C3(D0C696BA4);
				flag = true;
			}
			if (!B8781A042 && FB4652E24 == '.')
			{
				C06678D70();
				flag2 = true;
				if (!B8781A042 && D0C696BA4(FB4652E24))
				{
					E46B795C3(D0C696BA4);
					flag3 = true;
				}
			}
			if (!(flag || flag3))
			{
				D42A2351D(position);
				return DF0AD6554.IllegalToken;
			}
			if (!B8781A042 && (FB4652E24 == 'e' || FB4652E24 == 'E'))
			{
				C06678D70();
				if (!B8781A042 && (FB4652E24 == '-' || FB4652E24 == '+'))
				{
					C06678D70();
				}
				if (!B8781A042 && D0C696BA4(FB4652E24))
				{
					E46B795C3(D0C696BA4);
					flag4 = true;
				}
			}
			int d585AD04A = D585AD04A;
			C42EDE98F c42EDE98F = C42EDE98F.Double;
			if (!B8781A042)
			{
				if (FB4652E24 == 'f' || FB4652E24 == 'F')
				{
					c42EDE98F = C42EDE98F.Float;
					C06678D70();
					flag5 = true;
				}
				else if (FB4652E24 == 'd' || FB4652E24 == 'D')
				{
					C06678D70();
					flag5 = true;
				}
			}
			if (!(flag4 || flag5 || flag2))
			{
				D42A2351D(position);
				return DF0AD6554.IllegalToken;
			}
			try
			{
				if (c42EDE98F == C42EDE98F.Float)
				{
					B765D720A = new FC5192EE3(float.Parse(E4D5077CC.Substring(position, d585AD04A - position), NumberStyles.Any, CultureInfo.InvariantCulture));
				}
				else
				{
					B765D720A = new FC5192EE3(double.Parse(E4D5077CC.Substring(position, d585AD04A - position), NumberStyles.Any, CultureInfo.InvariantCulture));
				}
			}
			catch (Exception d907784B)
			{
				C3727A316(B0E4D9146.A26166779, d907784B);
			}
			return DF0AD6554.FloatingLiteral;
		}
		B765D720A = null;
		return DF0AD6554.IllegalToken;
	}

	private DF0AD6554 B4123BC16(out FC5192EE3 F77D86BFC)
	{
		DF0AD6554 dF0AD = AD6CBDB81(out F77D86BFC);
		if (dF0AD == DF0AD6554.IllegalToken)
		{
			dF0AD = CFB114F5E(out F77D86BFC);
		}
		return dF0AD;
	}

	private void B845C543C(out char EC8049594)
	{
		C06678D70();
		if (!B8781A042)
		{
			char c = '\0';
			switch (FB4652E24)
			{
			case 'b':
				c = '\b';
				C06678D70();
				break;
			case 't':
				c = '\t';
				C06678D70();
				break;
			case 'n':
				c = '\n';
				C06678D70();
				break;
			case 'f':
				c = '\f';
				C06678D70();
				break;
			case 'r':
				c = '\r';
				C06678D70();
				break;
			case '"':
				c = '"';
				C06678D70();
				break;
			case '\'':
				c = '\'';
				C06678D70();
				break;
			case '\\':
				c = '\\';
				C06678D70();
				break;
			default:
				if (C4BB062FB(FB4652E24))
				{
					int num = 0;
					if (FC2FCF486(FB4652E24))
					{
						num = F00763589(FB4652E24);
						C06678D70();
					}
					if (!B8781A042 && C4BB062FB(FB4652E24))
					{
						num = 8 * num + F00763589(FB4652E24);
						C06678D70();
					}
					if (!B8781A042 && C4BB062FB(FB4652E24))
					{
						num = 8 * num + F00763589(FB4652E24);
						C06678D70();
					}
					c = (char)num;
				}
				else
				{
					ECCD44FDC(B0E4D9146.A4AB93885);
				}
				break;
			case 'u':
				break;
			}
			EC8049594 = c;
		}
		else
		{
			EC8049594 = '\0';
			ECCD44FDC(B0E4D9146.E0190ABB4);
		}
	}

	private DF0AD6554 D74707C47(out FC5192EE3 BE37BCE3D)
	{
		if (FB4652E24 == '\'')
		{
			C06678D70();
			char EC = '\0';
			if (!B8781A042 && FB4652E24 == '\\')
			{
				B845C543C(out EC);
			}
			else if (!B8781A042 && FB4652E24 != '\'')
			{
				EC = FB4652E24;
				C06678D70();
			}
			else
			{
				ECCD44FDC(B0E4D9146.E0190ABB4);
			}
			if (B8781A042 || FB4652E24 != '\'')
			{
				ECCD44FDC(B0E4D9146.E0190ABB4);
			}
			C06678D70();
			BE37BCE3D = new FC5192EE3(EC);
			return DF0AD6554.CharacterLiteral;
		}
		BE37BCE3D = null;
		return DF0AD6554.IllegalToken;
	}

	private DF0AD6554 E3DAC8AA4(out string FF19F8E4F)
	{
		if (FB4652E24 == '"')
		{
			C06678D70();
			StringBuilder stringBuilder = new StringBuilder();
			while (!B8781A042 && FB4652E24 != '"')
			{
				char EC;
				if (FB4652E24 == '\\')
				{
					B845C543C(out EC);
				}
				else
				{
					EC = FB4652E24;
					C06678D70();
				}
				stringBuilder.Append(EC);
			}
			if (B8781A042)
			{
				ECCD44FDC(B0E4D9146.C8C2C3B4A);
			}
			C06678D70();
			FF19F8E4F = stringBuilder.ToString();
			return DF0AD6554.StringLiteral;
		}
		FF19F8E4F = null;
		return DF0AD6554.IllegalToken;
	}

	private DF0AD6554 BD6E39F10(string E54DF0EB1, out FC5192EE3 EAB4A1D58)
	{
		if (E54DF0EB1 == "true")
		{
			EAB4A1D58 = new FC5192EE3(b: true);
			return DF0AD6554.BooleanLiteral;
		}
		if (E54DF0EB1 == "false")
		{
			EAB4A1D58 = new FC5192EE3(b: false);
			return DF0AD6554.BooleanLiteral;
		}
		EAB4A1D58 = null;
		return DF0AD6554.IllegalToken;
	}

	private DF0AD6554 A2653BF58(string C2A7B946A)
	{
		if (C2A7B946A == "null")
		{
			return DF0AD6554.NullLiteral;
		}
		return DF0AD6554.IllegalToken;
	}

	private static DF0AD6554 C19595048(string CF1AF5465)
	{
		return Array.Find(B2DDA6654, (E2BF92117 B143958D8) => B143958D8.DF1F22F36 == CF1AF5465)!.CC609BEEE;
	}

	internal static string F36B47610(DF0AD6554 D6B6D2ED3)
	{
		return Array.Find(B2DDA6654, (E2BF92117 E4AE6D76E) => E4AE6D76E.CC609BEEE == D6B6D2ED3)!.DF1F22F36;
	}

	public C032C68FF DE1EC29F7()
	{
		while (!B8781A042 && char.IsWhiteSpace(FB4652E24))
		{
			C06678D70();
		}
		if (B8781A042)
		{
			return new C032C68FF(DF0AD6554.End);
		}
		DF0AD6554 dF0AD = B4123BC16(out var F77D86BFC);
		if (dF0AD != 0)
		{
			return new C032C68FF(dF0AD, new BF602D4D0((IJdwpValue)(object)F77D86BFC));
		}
		dF0AD = BBE74270B(BFFC67C42);
		if (dF0AD != 0)
		{
			return new C032C68FF(dF0AD);
		}
		dF0AD = BBE74270B(C686A0D72);
		if (dF0AD != 0)
		{
			return new C032C68FF(dF0AD);
		}
		dF0AD = E3DAC8AA4(out var FF19F8E4F);
		if (dF0AD != 0)
		{
			return new C032C68FF(dF0AD, new F34C80160(FF19F8E4F));
		}
		dF0AD = D74707C47(out F77D86BFC);
		if (dF0AD != 0)
		{
			return new C032C68FF(dF0AD, new BF602D4D0((IJdwpValue)(object)F77D86BFC));
		}
		string text = DDD024680();
		if (text == null)
		{
			ECCD44FDC(B0E4D9146.CFEABA5F9);
		}
		dF0AD = BD6E39F10(text, out F77D86BFC);
		if (dF0AD != 0)
		{
			return new C032C68FF(dF0AD, new BF602D4D0((IJdwpValue)(object)F77D86BFC));
		}
		dF0AD = A2653BF58(text);
		if (dF0AD != 0)
		{
			return new C032C68FF(dF0AD, new CC18CEB1F());
		}
		dF0AD = C19595048(text);
		if (dF0AD != 0)
		{
			return new C032C68FF(dF0AD);
		}
		return new C032C68FF(DF0AD6554.Identifier, text);
	}
}
