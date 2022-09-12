using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.Kofe.IJDWP;

namespace Microsoft.Kofe.Engine;

public class F34C80160 : Value
{
	private const int D6868B80C = 200;

	private string BA2E93FED;

	[CompilerGenerated]
	private IJdwpValue A3389EAD6;

	public F18024EA9 B98FE0CED => F18024EA9.String;

	protected IJdwpValue E6582464E
	{
		[CompilerGenerated]
		get
		{
			return A3389EAD6;
		}
		[CompilerGenerated]
		set
		{
			A3389EAD6 = value;
		}
	}

	public string FA9CF0BBD => ADFBFA5EF(BA2E93FED, 200);

	public char[] C0C405351
	{
		get
		{
			if (BA2E93FED != null)
			{
				return BA2E93FED.ToArray();
			}
			return null;
		}
	}

	public string F3B7EC00B => BA2E93FED;

	public bool AAF65A9E2 => false;

	public bool FC592E1A6 => E6582464E != null;

	public long D44B6A2C2 => E6582464E.AsObject();

	public string A57022379()
	{
		if (E6582464E == null)
		{
			return "String";
		}
		return E6582464E.DisplayType();
	}

	public static bool E15EA7742(JdwpValueTag DC8C59972)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Invalid comparison between Unknown and I4
		return (int)DC8C59972 == 115;
	}

	public static string ADFBFA5EF(string AFF4C27F0, int F9928B239 = 20)
	{
		if (AFF4C27F0 == null)
		{
			return "null";
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append('"');
		foreach (char c in AFF4C27F0)
		{
			switch (c)
			{
			case '\a':
				stringBuilder.Append("\\a");
				break;
			case '\b':
				stringBuilder.Append("\\b");
				break;
			case '\f':
				stringBuilder.Append("\\f");
				break;
			case '\n':
				stringBuilder.Append("\\n");
				break;
			case '\r':
				stringBuilder.Append("\\r");
				break;
			case '\t':
				stringBuilder.Append("\\t");
				break;
			case '\\':
				stringBuilder.Append("\\\\");
				break;
			case '"':
				stringBuilder.Append("\\\"");
				break;
			default:
				if (char.IsControl(c))
				{
					stringBuilder.Append(string.Format(CultureInfo.CurrentCulture, "\\x{0:X2}", new object[1] { (uint)c }));
				}
				else
				{
					stringBuilder.Append(c);
				}
				break;
			}
			if (--F9928B239 <= 0)
			{
				break;
			}
		}
		stringBuilder.Append('"');
		if (F9928B239 <= 0)
		{
			stringBuilder.Append("...");
		}
		return stringBuilder.ToString();
	}

	public F34C80160(IJDbg jdbg, IJdwpValue value)
	{
		E6582464E = value;
		BA2E93FED = jdbg.GetStringValue(value.AsString());
	}

	public F34C80160(string value)
	{
		E6582464E = null;
		BA2E93FED = value;
	}
}
