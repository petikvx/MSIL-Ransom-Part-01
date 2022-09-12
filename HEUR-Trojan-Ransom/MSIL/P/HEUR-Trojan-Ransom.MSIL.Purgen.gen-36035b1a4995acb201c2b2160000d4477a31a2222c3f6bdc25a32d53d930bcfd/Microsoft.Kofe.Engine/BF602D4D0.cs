using System.Globalization;
using System.Runtime.CompilerServices;
using Microsoft.Kofe.IJDWP;

namespace Microsoft.Kofe.Engine;

public class BF602D4D0 : Value, IJdwpValue
{
	private sbyte B4C39C541;

	private char E4330BB27;

	private float D3F4A1325;

	private double E77E20D5D;

	private int DEBFC3100;

	private long F2A44AD66;

	private short FEDD7CA49;

	private bool CB304D9B4;

	private JdwpValueTag A86BC6F3D;

	[CompilerGenerated]
	private static uint E6DE6440B;

	public static uint E0EE62C88
	{
		[CompilerGenerated]
		get
		{
			return E6DE6440B;
		}
		[CompilerGenerated]
		set
		{
			E6DE6440B = value;
		}
	}

	public F18024EA9 BAA049920 => F18024EA9.Simple;

	public string F81BA7DEF => AD8D3D66B(E0EE62C88);

	public bool C7B353124 => false;

	public bool FC5DF890C
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Invalid comparison between Unknown and I4
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Invalid comparison between Unknown and I4
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Invalid comparison between Unknown and I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Invalid comparison between Unknown and I4
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Invalid comparison between Unknown and I4
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Invalid comparison between Unknown and I4
			JdwpValueTag a86BC6F3D = A86BC6F3D;
			if ((int)a86BC6F3D <= 67)
			{
				if ((int)a86BC6F3D == 66 || (int)a86BC6F3D == 67)
				{
					goto IL_0027;
				}
			}
			else if ((int)a86BC6F3D == 73 || (int)a86BC6F3D == 74 || (int)a86BC6F3D == 83)
			{
				goto IL_0027;
			}
			return false;
			IL_0027:
			return true;
		}
	}

	public bool BFD9DED94
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Expected I4, but got Unknown
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Invalid comparison between Unknown and I4
			JdwpValueTag a86BC6F3D = A86BC6F3D;
			switch (a86BC6F3D - 66)
			{
			default:
				if ((int)a86BC6F3D != 83)
				{
					break;
				}
				goto case 0;
			case 0:
			case 1:
			case 2:
			case 4:
			case 7:
			case 8:
				return true;
			case 3:
			case 5:
			case 6:
				break;
			}
			return false;
		}
	}

	public JdwpValueTag D305911E9 => A86BC6F3D;

	public string F34B96FE1()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return A002C58D2.CEEAA6689(A86BC6F3D);
	}

	public static bool F16904B4A(JdwpValueTag FA12AF60F)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return JdwpValueTagUtil.IsSimple(FA12AF60F);
	}

	private string AD8D3D66B(uint E294A773C)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected I4, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Invalid comparison between Unknown and I4
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Invalid comparison between Unknown and I4
		JdwpValueTag a86BC6F3D = A86BC6F3D;
		switch (a86BC6F3D - 66)
		{
		default:
			if ((int)a86BC6F3D != 83)
			{
				if ((int)a86BC6F3D != 90)
				{
					break;
				}
				return CB304D9B4.ToString(CultureInfo.CurrentCulture);
			}
			if (E294A773C == 16)
			{
				return "0x" + FEDD7CA49.ToString("x", CultureInfo.CurrentCulture);
			}
			return FEDD7CA49.ToString(CultureInfo.CurrentCulture);
		case 0:
			if (E294A773C == 16)
			{
				return "0x" + B4C39C541.ToString("x2", CultureInfo.CurrentCulture);
			}
			return B4C39C541.ToString(CultureInfo.CurrentCulture);
		case 1:
			if (E294A773C == 16)
			{
				return "'" + E4330BB27.ToString(CultureInfo.CurrentCulture) + "' 0x" + ((short)E4330BB27).ToString("x", CultureInfo.CurrentCulture);
			}
			return "'" + E4330BB27.ToString(CultureInfo.CurrentCulture) + "' " + ((short)E4330BB27).ToString(CultureInfo.CurrentCulture);
		case 4:
			return D3F4A1325.ToString(CultureInfo.CurrentCulture);
		case 2:
			return E77E20D5D.ToString(CultureInfo.CurrentCulture);
		case 7:
			if (E294A773C == 16)
			{
				return "0x" + DEBFC3100.ToString("x", CultureInfo.CurrentCulture);
			}
			return DEBFC3100.ToString(CultureInfo.CurrentCulture);
		case 8:
			if (E294A773C == 16)
			{
				return "0x" + F2A44AD66.ToString("x", CultureInfo.CurrentCulture);
			}
			return F2A44AD66.ToString(CultureInfo.CurrentCulture);
		case 3:
		case 5:
		case 6:
			break;
		}
		return string.Empty;
	}

	public BF602D4D0(IJdwpValue value)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected I4, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Invalid comparison between Unknown and I4
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Invalid comparison between Unknown and I4
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		A86BC6F3D = value.get_Tag();
		JdwpValueTag a86BC6F3D = A86BC6F3D;
		switch (a86BC6F3D - 66)
		{
		default:
			if ((int)a86BC6F3D != 83)
			{
				if ((int)a86BC6F3D != 90)
				{
					break;
				}
				CB304D9B4 = value.AsBoolean();
				return;
			}
			FEDD7CA49 = value.AsShort();
			return;
		case 0:
			B4C39C541 = value.AsByte();
			return;
		case 1:
			E4330BB27 = value.AsChar();
			return;
		case 4:
			D3F4A1325 = value.AsFloat();
			return;
		case 2:
			E77E20D5D = value.AsDouble();
			return;
		case 7:
			DEBFC3100 = value.AsInt();
			return;
		case 8:
			F2A44AD66 = value.AsLong();
			return;
		case 3:
		case 5:
		case 6:
			break;
		}
		throw new ComponentException(-2147467259);
	}

	public BF602D4D0(sbyte b)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		B4C39C541 = b;
		A86BC6F3D = (JdwpValueTag)66;
	}

	public BF602D4D0(char c)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		E4330BB27 = c;
		A86BC6F3D = (JdwpValueTag)67;
	}

	public BF602D4D0(float f)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		D3F4A1325 = f;
		A86BC6F3D = (JdwpValueTag)70;
	}

	public BF602D4D0(double d)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		E77E20D5D = d;
		A86BC6F3D = (JdwpValueTag)68;
	}

	public BF602D4D0(int i)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		DEBFC3100 = i;
		A86BC6F3D = (JdwpValueTag)73;
	}

	public BF602D4D0(long l)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		F2A44AD66 = l;
		A86BC6F3D = (JdwpValueTag)74;
	}

	public BF602D4D0(short s)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		FEDD7CA49 = s;
		A86BC6F3D = (JdwpValueTag)83;
	}

	public BF602D4D0(bool b)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		CB304D9B4 = b;
		A86BC6F3D = (JdwpValueTag)90;
	}

	public long AC648875C()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new ComponentException(-2147467259);
	}

	public sbyte C4E11FE44()
	{
		return B4C39C541;
	}

	public char E80D67ABD()
	{
		return E4330BB27;
	}

	public long C5AF22544()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new ComponentException(-2147467259);
	}

	public float A70A83630()
	{
		return D3F4A1325;
	}

	public double CDF19C4E4()
	{
		return E77E20D5D;
	}

	public int FF9267D3B()
	{
		return DEBFC3100;
	}

	public long B30004D0D()
	{
		return F2A44AD66;
	}

	public short F771F6860()
	{
		return FEDD7CA49;
	}

	public bool CD0899617()
	{
		return CB304D9B4;
	}

	public long D5137554D()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new ComponentException(-2147467259);
	}

	public long FEB4CBE4B()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new ComponentException(-2147467259);
	}

	public long A698242B0()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new ComponentException(-2147467259);
	}

	public long E362F1A47()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new ComponentException(-2147467259);
	}

	public long C520B10E7()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new ComponentException(-2147467259);
	}

	public BF602D4D0 BC31F8A4F()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected I4, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Invalid comparison between Unknown and I4
		JdwpValueTag a86BC6F3D = A86BC6F3D;
		sbyte b;
		switch (a86BC6F3D - 66)
		{
		default:
			if ((int)a86BC6F3D != 83)
			{
				goto case 3;
			}
			b = (sbyte)FEDD7CA49;
			break;
		case 0:
			b = B4C39C541;
			break;
		case 1:
			b = (sbyte)E4330BB27;
			break;
		case 7:
			b = (sbyte)DEBFC3100;
			break;
		case 8:
			b = (sbyte)F2A44AD66;
			break;
		case 4:
			b = (sbyte)D3F4A1325;
			break;
		case 2:
			b = (sbyte)E77E20D5D;
			break;
		case 3:
		case 5:
		case 6:
			throw new EEA8EDD4A(B0E4D9146.BFB0085C0);
		}
		return new BF602D4D0(b);
	}

	public BF602D4D0 DFA073CE9()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected I4, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Invalid comparison between Unknown and I4
		JdwpValueTag a86BC6F3D = A86BC6F3D;
		char c;
		switch (a86BC6F3D - 66)
		{
		default:
			if ((int)a86BC6F3D != 83)
			{
				goto case 3;
			}
			c = (char)FEDD7CA49;
			break;
		case 0:
			c = (char)B4C39C541;
			break;
		case 1:
			c = E4330BB27;
			break;
		case 7:
			c = (char)DEBFC3100;
			break;
		case 8:
			c = (char)F2A44AD66;
			break;
		case 4:
			c = (char)D3F4A1325;
			break;
		case 2:
			c = (char)E77E20D5D;
			break;
		case 3:
		case 5:
		case 6:
			throw new EEA8EDD4A(B0E4D9146.BFB0085C0);
		}
		return new BF602D4D0(c);
	}

	public BF602D4D0 D05EEA502()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected I4, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Invalid comparison between Unknown and I4
		JdwpValueTag a86BC6F3D = A86BC6F3D;
		short s;
		switch (a86BC6F3D - 66)
		{
		default:
			if ((int)a86BC6F3D != 83)
			{
				goto case 3;
			}
			s = FEDD7CA49;
			break;
		case 0:
			s = B4C39C541;
			break;
		case 1:
			s = (short)E4330BB27;
			break;
		case 7:
			s = (short)DEBFC3100;
			break;
		case 8:
			s = (short)F2A44AD66;
			break;
		case 4:
			s = (short)D3F4A1325;
			break;
		case 2:
			s = (short)E77E20D5D;
			break;
		case 3:
		case 5:
		case 6:
			throw new EEA8EDD4A(B0E4D9146.BFB0085C0);
		}
		return new BF602D4D0(s);
	}

	public BF602D4D0 D6D2BC94B()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected I4, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Invalid comparison between Unknown and I4
		JdwpValueTag a86BC6F3D = A86BC6F3D;
		int i;
		switch (a86BC6F3D - 66)
		{
		default:
			if ((int)a86BC6F3D != 83)
			{
				goto case 3;
			}
			i = FEDD7CA49;
			break;
		case 0:
			i = B4C39C541;
			break;
		case 1:
			i = E4330BB27;
			break;
		case 7:
			i = DEBFC3100;
			break;
		case 8:
			i = (int)F2A44AD66;
			break;
		case 4:
			i = (int)D3F4A1325;
			break;
		case 2:
			i = (int)E77E20D5D;
			break;
		case 3:
		case 5:
		case 6:
			throw new EEA8EDD4A(B0E4D9146.BFB0085C0);
		}
		return new BF602D4D0(i);
	}

	public BF602D4D0 DBA29F744()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected I4, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Invalid comparison between Unknown and I4
		JdwpValueTag a86BC6F3D = A86BC6F3D;
		long l;
		switch (a86BC6F3D - 66)
		{
		default:
			if ((int)a86BC6F3D != 83)
			{
				goto case 3;
			}
			l = FEDD7CA49;
			break;
		case 0:
			l = B4C39C541;
			break;
		case 1:
			l = E4330BB27;
			break;
		case 7:
			l = DEBFC3100;
			break;
		case 8:
			l = F2A44AD66;
			break;
		case 4:
			l = (long)D3F4A1325;
			break;
		case 2:
			l = (long)E77E20D5D;
			break;
		case 3:
		case 5:
		case 6:
			throw new EEA8EDD4A(B0E4D9146.BFB0085C0);
		}
		return new BF602D4D0(l);
	}

	public BF602D4D0 BB7441AF1()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected I4, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Invalid comparison between Unknown and I4
		JdwpValueTag a86BC6F3D = A86BC6F3D;
		double d;
		switch (a86BC6F3D - 66)
		{
		default:
			if ((int)a86BC6F3D != 83)
			{
				goto case 3;
			}
			d = FEDD7CA49;
			break;
		case 0:
			d = B4C39C541;
			break;
		case 1:
			d = (int)E4330BB27;
			break;
		case 7:
			d = DEBFC3100;
			break;
		case 8:
			d = F2A44AD66;
			break;
		case 4:
			d = D3F4A1325;
			break;
		case 2:
			d = E77E20D5D;
			break;
		case 3:
		case 5:
		case 6:
			throw new EEA8EDD4A(B0E4D9146.BFB0085C0);
		}
		return new BF602D4D0(d);
	}

	public BF602D4D0 A01087878()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected I4, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Invalid comparison between Unknown and I4
		JdwpValueTag a86BC6F3D = A86BC6F3D;
		float f;
		switch (a86BC6F3D - 66)
		{
		default:
			if ((int)a86BC6F3D != 83)
			{
				goto case 3;
			}
			f = FEDD7CA49;
			break;
		case 0:
			f = B4C39C541;
			break;
		case 1:
			f = (int)E4330BB27;
			break;
		case 7:
			f = DEBFC3100;
			break;
		case 8:
			f = F2A44AD66;
			break;
		case 4:
			f = D3F4A1325;
			break;
		case 2:
			f = (float)E77E20D5D;
			break;
		case 3:
		case 5:
		case 6:
			throw new EEA8EDD4A(B0E4D9146.BFB0085C0);
		}
		return new BF602D4D0(f);
	}

	public BF602D4D0 A2F95B38B()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Invalid comparison between Unknown and I4
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Invalid comparison between Unknown and I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Invalid comparison between Unknown and I4
		JdwpValueTag a86BC6F3D = A86BC6F3D;
		if ((int)a86BC6F3D == 66 || (int)a86BC6F3D == 67 || (int)a86BC6F3D == 83)
		{
			return D6D2BC94B();
		}
		return this;
	}

	public static void DFF30C2C2(ref BF602D4D0 E1A030A15, ref BF602D4D0 A5B486F8B)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Invalid comparison between Unknown and I4
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Invalid comparison between Unknown and I4
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Invalid comparison between Unknown and I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Invalid comparison between Unknown and I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Invalid comparison between Unknown and I4
		if ((int)E1A030A15.D305911E9 == 68 || (int)A5B486F8B.D305911E9 == 68)
		{
			E1A030A15 = E1A030A15.BB7441AF1();
			A5B486F8B = A5B486F8B.BB7441AF1();
		}
		else if ((int)E1A030A15.D305911E9 == 70 || (int)A5B486F8B.D305911E9 == 70)
		{
			E1A030A15 = E1A030A15.A01087878();
			A5B486F8B = A5B486F8B.A01087878();
		}
		else if ((int)E1A030A15.D305911E9 == 74 || (int)A5B486F8B.D305911E9 == 74)
		{
			E1A030A15 = E1A030A15.DBA29F744();
			A5B486F8B = A5B486F8B.DBA29F744();
		}
		else
		{
			E1A030A15 = E1A030A15.D6D2BC94B();
			A5B486F8B = A5B486F8B.D6D2BC94B();
		}
	}
}
