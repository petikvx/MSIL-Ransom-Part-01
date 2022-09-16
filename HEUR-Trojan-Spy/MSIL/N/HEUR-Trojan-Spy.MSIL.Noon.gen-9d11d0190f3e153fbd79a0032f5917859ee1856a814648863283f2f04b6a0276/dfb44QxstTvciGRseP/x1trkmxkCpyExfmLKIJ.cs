using System;
using System.Text;
using System.Text.RegularExpressions;

namespace dfb44QxstTvciGRseP;

public class x1trkmxkCpyExfmLKIJ : yibUOXxiELenfjL4B5c<string>
{
	private readonly Regex iqFM5w15VY;

	private readonly Regex va0MPYsquL;

	private readonly double vStMXUSxZK;

	private static x1trkmxkCpyExfmLKIJ YtQEM3Z8Q8JOvPs16RM;

	public x1trkmxkCpyExfmLKIJ(string string_0)
	{
		GRgbqpcvG2cupxT0496.SF54tCZzYSfdV();
		iqFM5w15VY = new Regex("[A-Za-z\\n\\r\\t]+", RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.Singleline);
		va0MPYsquL = new Regex(".{8}-.{4}-.{4}-.{4}-.{12}", RegexOptions.Compiled);
		vStMXUSxZK = 0.0;
		base._002Ector();
		vStMXUSxZK = fF7MI4F0iI(string_0);
	}

	public double NwMF50bbCo(string HuUJWaxwIX84r6Ctdl8)
	{
		return Math.Abs(vStMXUSxZK - fF7MI4F0iI(HuUJWaxwIX84r6Ctdl8));
	}

	private double fF7MI4F0iI(string string_0)
	{
		double num = 0.0;
		double num2 = 0.0;
		string text = z5LMnWg7qm(string_0);
		string text2 = text;
		int num3 = 0;
		int num4 = 1;
		if (!T3G8oDZvUWI4nFL5mfw())
		{
			int num5 = default(int);
			num4 = num5;
		}
		switch (num4)
		{
		case 1:
			if (num3 < text2.Length)
			{
				char c = text2[num3];
				if (char.IsControl(c))
				{
					num2 = 0.0;
				}
				else
				{
					num += (double)(int)c * num2++;
				}
				goto case 2;
			}
			return num;
		case 2:
			num3++;
			goto case 1;
		default:
		{
			double result = default(double);
			return result;
		}
		}
	}

	private string z5LMnWg7qm(string string_0)
	{
		string input = va0MPYsquL.Replace(string_0, string.Empty);
		StringBuilder stringBuilder = new StringBuilder();
		MatchCollection matchCollection = iqFM5w15VY.Matches(input);
		foreach (Match item in matchCollection)
		{
			stringBuilder.Append(item);
		}
		return stringBuilder.ToString();
	}

	internal static bool T3G8oDZvUWI4nFL5mfw()
	{
		return YtQEM3Z8Q8JOvPs16RM == null;
	}

	internal static x1trkmxkCpyExfmLKIJ lhXvqAZ9HjI81omUns1()
	{
		return YtQEM3Z8Q8JOvPs16RM;
	}
}
