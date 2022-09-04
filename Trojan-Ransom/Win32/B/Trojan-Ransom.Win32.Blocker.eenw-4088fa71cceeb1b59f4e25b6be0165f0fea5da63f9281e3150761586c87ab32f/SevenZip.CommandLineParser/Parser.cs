using System;
using System.Collections;

namespace SevenZip.CommandLineParser;

public class Parser
{
	private const char kSwitchID1 = '-';

	private const char kSwitchID2 = '/';

	private const char kSwitchMinus = '-';

	private const string kStopSwitchParsing = "--";

	public ArrayList NonSwitchStrings = new ArrayList();

	private SwitchResult[] _switches;

	public SwitchResult this[int index] => _switches[index];

	public Parser(int numSwitches)
	{
		_switches = new SwitchResult[numSwitches];
		for (int i = 0; i < numSwitches; i++)
		{
			_switches[i] = new SwitchResult();
		}
	}

	private bool ParseString(string srcString, SwitchForm[] switchForms)
	{
		int length = srcString.Length;
		if (length == 0)
		{
			return false;
		}
		int num = 0;
		if (!IsItSwitchChar(srcString[0]))
		{
			return false;
		}
		while (true)
		{
			if (num < length)
			{
				if (IsItSwitchChar(srcString[num]))
				{
					num++;
				}
				int num2 = 0;
				int num3 = -1;
				for (int i = 0; i < _switches.Length; i++)
				{
					int length2 = switchForms[i].IDString.Length;
					if (length2 > num3 && num + length2 <= length && string.Compare(switchForms[i].IDString, 0, srcString, num, length2, ignoreCase: true) == 0)
					{
						num2 = i;
						num3 = length2;
					}
				}
				if (num3 != -1)
				{
					SwitchResult switchResult = _switches[num2];
					SwitchForm switchForm = switchForms[num2];
					if (!switchForm.Multi && switchResult.ThereIs)
					{
						break;
					}
					switchResult.ThereIs = true;
					num += num3;
					int num4 = length - num;
					SwitchType type = switchForm.Type;
					switch (type)
					{
					case SwitchType.PostMinus:
						if (num4 == 0)
						{
							switchResult.WithMinus = false;
							break;
						}
						switchResult.WithMinus = srcString[num] == '-';
						if (switchResult.WithMinus)
						{
							num++;
						}
						break;
					case SwitchType.LimitedPostString:
					case SwitchType.UnLimitedPostString:
					{
						int minLen = switchForm.MinLen;
						if (num4 >= minLen)
						{
							if (type != SwitchType.UnLimitedPostString)
							{
								string text = srcString.Substring(num, minLen);
								num += minLen;
								int num6 = minLen;
								while (num6 < switchForm.MaxLen && num < length)
								{
									char c = srcString[num];
									if (IsItSwitchChar(c))
									{
										break;
									}
									text += c;
									num6++;
									num++;
								}
								switchResult.PostStrings.Add(text);
								break;
							}
							switchResult.PostStrings.Add(srcString.Substring(num));
							return true;
						}
						throw new Exception("switch is not full");
					}
					case SwitchType.PostChar:
						if (num4 >= switchForm.MinLen)
						{
							string postCharSet = switchForm.PostCharSet;
							if (num4 == 0)
							{
								switchResult.PostCharIndex = -1;
								break;
							}
							int num5 = postCharSet.IndexOf(srcString[num]);
							if (num5 < 0)
							{
								switchResult.PostCharIndex = -1;
								break;
							}
							switchResult.PostCharIndex = num5;
							num++;
							break;
						}
						throw new Exception("switch is not full");
					}
					continue;
				}
				throw new Exception("maxLen == kNoLen");
			}
			return true;
		}
		throw new Exception("switch must be single");
	}

	public void ParseStrings(SwitchForm[] switchForms, string[] commandStrings)
	{
		int num = commandStrings.Length;
		bool flag = false;
		for (int i = 0; i < num; i++)
		{
			string text = commandStrings[i];
			if (flag)
			{
				NonSwitchStrings.Add(text);
			}
			else if (text == "--")
			{
				flag = true;
			}
			else if (!ParseString(text, switchForms))
			{
				NonSwitchStrings.Add(text);
			}
		}
	}

	public static int ParseCommand(CommandForm[] commandForms, string commandString, out string postString)
	{
		int num = 0;
		while (true)
		{
			if (num < commandForms.Length)
			{
				string iDString = commandForms[num].IDString;
				if (commandForms[num].PostStringMode)
				{
					if (commandString.IndexOf(iDString) == 0)
					{
						postString = commandString.Substring(iDString.Length);
						return num;
					}
				}
				else if (commandString == iDString)
				{
					break;
				}
				num++;
				continue;
			}
			postString = "";
			return -1;
		}
		postString = "";
		return num;
	}

	private static bool ParseSubCharsCommand(int numForms, CommandSubCharsSet[] forms, string commandString, ArrayList indices)
	{
		indices.Clear();
		int num = 0;
		int num2 = 0;
		while (true)
		{
			if (num2 < numForms)
			{
				CommandSubCharsSet commandSubCharsSet = forms[num2];
				int num3 = -1;
				int length = commandSubCharsSet.Chars.Length;
				for (int i = 0; i < length; i++)
				{
					char value = commandSubCharsSet.Chars[i];
					int num4 = commandString.IndexOf(value);
					if (num4 >= 0)
					{
						if (num3 >= 0)
						{
							return false;
						}
						if (commandString.IndexOf(value, num4 + 1) >= 0)
						{
							return false;
						}
						num3 = i;
						num++;
					}
				}
				if (num3 == -1 && !commandSubCharsSet.EmptyAllowed)
				{
					break;
				}
				indices.Add(num3);
				num2++;
				continue;
			}
			return num == commandString.Length;
		}
		return false;
	}

	private static bool IsItSwitchChar(char c)
	{
		if (c != '-')
		{
			return c == '/';
		}
		return true;
	}
}
