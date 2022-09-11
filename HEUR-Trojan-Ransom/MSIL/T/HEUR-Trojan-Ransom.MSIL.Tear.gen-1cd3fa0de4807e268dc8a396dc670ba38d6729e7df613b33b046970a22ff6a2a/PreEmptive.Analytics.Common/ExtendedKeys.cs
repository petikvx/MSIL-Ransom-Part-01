using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using PreEmptive.Analytics.Common.Tags;

namespace PreEmptive.Analytics.Common;

public class ExtendedKeys
{
	[CompilerGenerated]
	private IDictionary<string, ExtendedKey> idictionary_0;

	public IDictionary<string, ExtendedKey> Map
	{
		[CompilerGenerated]
		get
		{
			int num = 4574;
			int num2 = num;
			num = 4574;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return idictionary_0;
			}
		}
		[CompilerGenerated]
		set
		{
			int num = 29165;
			int num2 = num;
			num = 29165;
			switch (num2 == num)
			{
			}
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			idictionary_0 = value;
		}
	}

	public ExtendedKeys()
	{
		Map = new Dictionary<string, ExtendedKey>();
	}

	public void Add(string string_0, string value)
	{
		int num = 3;
		while (true)
		{
			string text = method_1(string_0);
			int num2 = 3;
			int num3 = num2;
			while (true)
			{
				switch (num3)
				{
				case 3:
					if (string.IsNullOrEmpty(text))
					{
						return;
					}
					goto IL_0019;
				case 1:
					if (1 == 0)
					{
					}
					num2 = 0;
					num3 = num2;
					continue;
				case 0:
				{
					method_0((value != null) ? new ExtendedKey(text, value) : new ExtendedKey(text, "튼\udeab튾횺"));
					num2 = -15233;
					int num4 = num2;
					num2 = -15233;
					switch (num4 == num2)
					{
					case false:
					case true:
						break;
					default:
						if (0 == 0)
						{
						}
						num2 = 2;
						num3 = num2;
						continue;
					}
					goto IL_0019;
				}
				case 2:
					return;
					IL_0019:
					num2 = 1;
					num3 = num2;
					continue;
				}
				break;
			}
		}
	}

	public void Add(string string_0, int value)
	{
		if (true)
		{
		}
		while (true)
		{
			string text = method_1(string_0);
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (string.IsNullOrEmpty(text))
					{
						return;
					}
					goto IL_0023;
				case 0:
				{
					method_0(new ExtendedKey(text, value));
					num = -2419;
					int num3 = num;
					num = -2419;
					switch (num3 == num)
					{
					case false:
					case true:
						break;
					default:
						if (0 == 0)
						{
						}
						num = 1;
						num2 = num;
						continue;
					}
					goto IL_0023;
				}
				case 1:
					return;
					IL_0023:
					num = 0;
					num2 = num;
					continue;
				}
				break;
			}
		}
	}

	public void Add(string string_0, long value)
	{
		while (true)
		{
			string text = method_1(string_0);
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (string.IsNullOrEmpty(text))
					{
						return;
					}
					goto IL_0011;
				case 0:
				{
					method_0(new ExtendedKey(text, value));
					num = -8372;
					int num3 = num;
					num = -8372;
					switch (num3 == num)
					{
					case false:
					case true:
						break;
					default:
						if (1 == 0)
						{
						}
						if (0 == 0)
						{
						}
						num = 1;
						num2 = num;
						continue;
					}
					goto IL_0011;
				}
				case 1:
					return;
					IL_0011:
					num = 0;
					num2 = num;
					continue;
				}
				break;
			}
		}
	}

	public void Add(string string_0, float value)
	{
		while (true)
		{
			string text = method_1(string_0);
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (string.IsNullOrEmpty(text))
					{
						return;
					}
					goto IL_0011;
				case 0:
				{
					method_0(new ExtendedKey(text, value));
					num = 25182;
					int num3 = num;
					num = 25182;
					switch (num3 == num)
					{
					case false:
					case true:
						break;
					default:
						if (1 == 0)
						{
						}
						if (0 == 0)
						{
						}
						num = 1;
						num2 = num;
						continue;
					}
					goto IL_0011;
				}
				case 1:
					return;
					IL_0011:
					num = 0;
					num2 = num;
					continue;
				}
				break;
			}
		}
	}

	public void Add(string string_0, double value)
	{
		while (true)
		{
			if (true)
			{
			}
			string text = method_1(string_0);
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (string.IsNullOrEmpty(text))
					{
						return;
					}
					goto IL_002a;
				case 0:
				{
					method_0(new ExtendedKey(text, value));
					num = 8903;
					int num3 = num;
					num = 8903;
					switch (num3 == num)
					{
					case false:
					case true:
						break;
					default:
						if (0 == 0)
						{
						}
						num = 1;
						num2 = num;
						continue;
					}
					goto IL_002a;
				}
				case 1:
					return;
					IL_002a:
					num = 0;
					num2 = num;
					continue;
				}
				break;
			}
		}
	}

	public void Add(string string_0, decimal value)
	{
		while (true)
		{
			string text = method_1(string_0);
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (string.IsNullOrEmpty(text))
					{
						return;
					}
					goto IL_0011;
				case 0:
				{
					method_0(new ExtendedKey(text, value));
					num = 13013;
					int num3 = num;
					num = 13013;
					switch (num3 == num)
					{
					case false:
					case true:
						break;
					default:
						if (1 == 0)
						{
						}
						if (0 == 0)
						{
						}
						num = 1;
						num2 = num;
						continue;
					}
					goto IL_0011;
				}
				case 1:
					return;
					IL_0011:
					num = 0;
					num2 = num;
					continue;
				}
				break;
			}
		}
	}

	private void method_0(ExtendedKey extendedKey_0)
	{
		int num = -5359;
		int num2 = num;
		num = -5359;
		switch (num2 == num)
		{
		}
		if (1 == 0)
		{
		}
		if (0 == 0)
		{
		}
		Map[extendedKey_0.Key] = extendedKey_0;
	}

	private string method_1(string string_0)
	{
		int num = 9;
		if (string_0 == null)
		{
			while (true)
			{
				int num2 = -1817;
				int num3 = num2;
				num2 = -1817;
				switch (num3 == num2)
				{
				case false:
				case true:
					break;
				default:
					if (0 == 0)
					{
					}
					if (1 == 0)
					{
					}
					return null;
				}
			}
		}
		return Regex.Replace(string_0, "횊튡꺅", "훶").Trim();
	}

	public List<ExtendedKeyTag> ToTags()
	{
		List<ExtendedKeyTag> list = new List<ExtendedKeyTag>(Map.Count);
		IEnumerator<ExtendedKey> enumerator = Map.Values.GetEnumerator();
		try
		{
			int num = 4;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					num = 2;
					num2 = num;
					continue;
				case 2:
				{
					num = -6869;
					int num3 = num;
					num = -6869;
					switch (num3 == num)
					{
					case false:
					case true:
						break;
					default:
					{
						if (0 == 0)
						{
						}
						if (!enumerator.MoveNext())
						{
							num = 0;
							num2 = num;
							continue;
						}
						ExtendedKey current = enumerator.Current;
						list.Add(new ExtendedKeyTag(current.Key, current.Value, current.IsNumeric));
						num = 1;
						num2 = num;
						continue;
					}
					}
					goto default;
				}
				case 0:
					num = 3;
					num2 = num;
					continue;
				case 3:
					break;
				}
				break;
			}
		}
		finally
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (enumerator != null)
					{
						num = 0;
						num2 = num;
						continue;
					}
					break;
				case 0:
					enumerator.Dispose();
					num = 1;
					num2 = num;
					continue;
				case 1:
					break;
				}
				break;
			}
		}
		if (1 == 0)
		{
		}
		return list;
	}
}
