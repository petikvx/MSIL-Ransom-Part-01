using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using PreEmptive.Analytics.Common;
using PreEmptive.SoS.Client.Cache;

namespace PreEmptive.SoS.Client.Messages;

public abstract class Message
{
	private IDictionary<string, string> idictionary_0;

	internal EventInformation eventInformation_0;

	private static Regex regex_0;

	[CompilerGenerated]
	private BinaryInformation binaryInformation_0;

	public BinaryInformation Binary
	{
		[CompilerGenerated]
		get
		{
			int num = 6760;
			int num2 = num;
			num = 6760;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return binaryInformation_0;
			}
		}
		[CompilerGenerated]
		set
		{
			int num = 29619;
			int num2 = num;
			num = 29619;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			binaryInformation_0 = value;
		}
	}

	public EventInformation Event
	{
		get
		{
			int num = 0;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					while (true)
					{
						num = 17470;
						int num3 = num;
						num = 17470;
						switch (num3 == num)
						{
						case false:
						case true:
							continue;
						}
						break;
					}
					if (1 == 0)
					{
					}
					if (0 == 0)
					{
					}
					eventInformation_0 = new EventInformation();
					num = 2;
					num2 = num;
					continue;
				default:
					if (eventInformation_0 == null)
					{
						num = 1;
						num2 = num;
						continue;
					}
					break;
				case 2:
					break;
				}
				break;
			}
			return eventInformation_0;
		}
		set
		{
			int num = 8150;
			int num2 = num;
			num = 8150;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			eventInformation_0 = value;
		}
	}

	public void AddExtendedKeys(IDictionary<string, string> dict)
	{
		int num = 0;
		int num2 = num;
		IEnumerator<string> enumerator = default(IEnumerator<string>);
		while (true)
		{
			switch (num2)
			{
			case 1:
				idictionary_0 = new Dictionary<string, string>(dict);
				return;
			case 2:
				try
				{
					num = 1;
					num2 = num;
					while (true)
					{
						switch (num2)
						{
						case 4:
							num = 3;
							num2 = num;
							break;
						case 2:
						{
							if (!enumerator.MoveNext())
							{
								num = 4;
								num2 = num;
								break;
							}
							string current = enumerator.Current;
							idictionary_0.Add(current, dict[current]);
							num = 0;
							num2 = num;
							break;
						}
						default:
							num = 2;
							num2 = num;
							break;
						case 3:
							return;
						}
					}
				}
				finally
				{
					num = 0;
					num2 = num;
					while (true)
					{
						switch (num2)
						{
						case 1:
							enumerator.Dispose();
							num = 2;
							num2 = num;
							continue;
						default:
							if (enumerator != null)
							{
								num = 1;
								num2 = num;
								continue;
							}
							break;
						case 2:
							break;
						}
						break;
					}
				}
			}
			if (idictionary_0 == null)
			{
				num = 1;
				num2 = num;
				continue;
			}
			num = 19382;
			int num3 = num;
			num = 19382;
			switch (num3 == num)
			{
			default:
				if (0 == 0)
				{
				}
				if (1 == 0)
				{
				}
				enumerator = dict.Keys.GetEnumerator();
				break;
			case false:
			case true:
				break;
			}
			num = 2;
			num2 = num;
		}
	}

	public void AddExtendedKeys(IDictionary dict)
	{
		int num = 0;
		int num2 = num;
		IEnumerator enumerator = default(IEnumerator);
		IDisposable disposable = default(IDisposable);
		while (true)
		{
			if (true)
			{
			}
			switch (num2)
			{
			default:
				if (idictionary_0 == null)
				{
					num = 1;
					num2 = num;
					break;
				}
				goto case 3;
			case 1:
				idictionary_0 = new Dictionary<string, string>(dict.Count);
				num = 3;
				num2 = num;
				break;
			case 3:
				enumerator = dict.Keys.GetEnumerator();
				num = 2;
				num2 = num;
				break;
			case 2:
				try
				{
					num = 1;
					num2 = num;
					while (true)
					{
						switch (num2)
						{
						case 4:
							num = 2;
							num2 = num;
							break;
						default:
							num = 0;
							num2 = num;
							break;
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = 4;
								num2 = num;
								break;
							}
							string key = (string)enumerator.Current;
							idictionary_0.Add(key, smethod_0(dict[key]));
							num = 3;
							num2 = num;
							break;
						}
						case 2:
							return;
						}
					}
				}
				finally
				{
					num = -15007;
					int num3 = num;
					num = -15007;
					switch (num3 == num)
					{
					default:
						if (0 == 0)
						{
						}
						goto IL_018c;
					case false:
					case true:
						{
							num = 2;
							num2 = num;
							goto IL_0165;
						}
						IL_018c:
						disposable = enumerator as IDisposable;
						num = 1;
						num2 = num;
						goto IL_0165;
						IL_0165:
						while (true)
						{
							switch (num2)
							{
							case 2:
								disposable.Dispose();
								num = 0;
								num2 = num;
								continue;
							case 1:
								goto IL_01a4;
							case 0:
								goto end_IL_0146;
							}
							break;
						}
						goto IL_018c;
						IL_01a4:
						if (disposable == null)
						{
							break;
						}
						goto case false;
						end_IL_0146:
						break;
					}
				}
			}
		}
	}

	public void AddExtendedKeyObjectAsString(string string_0, object value)
	{
		int num = 20293;
		int num2 = num;
		num = 20293;
		switch (num2 == num)
		{
		}
		if (0 == 0)
		{
		}
		if (1 == 0)
		{
		}
		AddExtendedKey(string_0, smethod_0(value));
	}

	public void AddExtendedKey(string string_0, string value)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				idictionary_0 = new Dictionary<string, string>();
				num = 0;
				num2 = num;
				continue;
			default:
				while (true)
				{
					if (true)
					{
					}
					if (idictionary_0 != null)
					{
						break;
					}
					num = 7683;
					int num3 = num;
					num = 7683;
					switch (num3 == num)
					{
					case false:
					case true:
						continue;
					}
					goto IL_0074;
				}
				break;
			case 0:
				break;
				IL_0074:
				if (0 == 0)
				{
				}
				num = 2;
				num2 = num;
				continue;
			}
			break;
		}
		idictionary_0.Add(string_0, value);
	}

	public IDictionary<string, string> GetExtendedKeys()
	{
		int num = 31707;
		int num2 = num;
		num = 31707;
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

	public abstract void Send(CacheService cache, PlatformClient paclient);

	protected static BinaryInfo ConvertBinaryInfo(BinaryInformation binaryInformation)
	{
		int num = 2261;
		int num2 = num;
		num = 2261;
		BinaryInfo binaryInfo = default(BinaryInfo);
		int num3;
		switch (num2 == num)
		{
		default:
			if (0 == 0)
			{
			}
			goto IL_00d0;
		case false:
		case true:
			goto IL_00e5;
			IL_00d0:
			if (true)
			{
			}
			binaryInfo = null;
			num = 1;
			num3 = num;
			goto IL_0043;
			IL_00e5:
			num = 2;
			num3 = num;
			goto IL_0043;
			IL_0043:
			while (true)
			{
				switch (num3)
				{
				case 2:
					binaryInfo = new BinaryInfo();
					binaryInfo.ID = binaryInformation.Id;
					binaryInfo.Name = binaryInformation.Name;
					binaryInfo.Version = binaryInformation.Version;
					binaryInfo.LastModified = binaryInformation.ModifiedDate;
					num = 0;
					num3 = num;
					continue;
				case 1:
					if (binaryInformation != null)
					{
						goto IL_00e5;
					}
					goto case 0;
				case 0:
					return binaryInfo;
				}
				break;
			}
			goto IL_00d0;
		}
	}

	protected static bool IsNumeric(string inputString)
	{
		int num = 5278;
		int num2 = num;
		num = 5278;
		switch (num2 == num)
		{
		default:
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			return regex_0.IsMatch(inputString);
		}
	}

	protected static ExtendedKeys ConvertExtendedKeys(IDictionary<string, string> dictionary)
	{
		int num = 2;
		switch (0)
		{
		default:
		{
			int num2 = 1;
			int num3 = num2;
			ExtendedKeys extendedKeys = default(ExtendedKeys);
			IEnumerator<string> enumerator = default(IEnumerator<string>);
			string current = default(string);
			string text = default(string);
			while (true)
			{
				switch (num3)
				{
				default:
					if (dictionary == null)
					{
						num2 = 2;
						num3 = num2;
						break;
					}
					extendedKeys = new ExtendedKeys();
					enumerator = dictionary.Keys.GetEnumerator();
					num2 = 0;
					num3 = num2;
					break;
				case 0:
					try
					{
						num2 = 0;
						num3 = num2;
						while (true)
						{
							switch (num3)
							{
							case 6:
								if (!enumerator.MoveNext())
								{
									num2 = 4;
									num3 = num2;
									break;
								}
								current = enumerator.Current;
								text = dictionary[current];
								num2 = 3;
								num3 = num2;
								break;
							case 5:
								try
								{
									num2 = 1;
									num3 = num2;
									while (true)
									{
										switch (num3)
										{
										case 0:
										case 4:
											num2 = 2;
											num3 = num2;
											continue;
										case 3:
											extendedKeys.Add(current, Convert.ToDouble(text));
											num2 = 4;
											num3 = num2;
											continue;
										default:
											if (text.Contains("훼"))
											{
												num2 = 3;
												num3 = num2;
											}
											else
											{
												extendedKeys.Add(current, Convert.ToInt64(text));
												num2 = 0;
												num3 = num2;
											}
											continue;
										case 2:
											break;
										}
										break;
									}
								}
								catch (Exception)
								{
									extendedKeys.Add(current, text);
								}
								goto default;
							case 4:
								if (1 == 0)
								{
								}
								num2 = 2;
								num3 = num2;
								break;
							case 3:
								if (IsNumeric(text))
								{
									num2 = 5;
									num3 = num2;
								}
								else
								{
									extendedKeys.Add(current, text);
									num2 = 1;
									num3 = num2;
								}
								break;
							default:
								num2 = 6;
								num3 = num2;
								break;
							case 2:
								return extendedKeys;
							}
						}
					}
					finally
					{
						num2 = 1;
						num3 = num2;
						while (true)
						{
							IL_0281:
							switch (num3)
							{
							case 2:
								enumerator.Dispose();
								num2 = 0;
								num3 = num2;
								continue;
							case 0:
								goto end_IL_0281;
							}
							while (enumerator != null)
							{
								num2 = 1643;
								int num4 = num2;
								num2 = 1643;
								switch (num4 == num2)
								{
								case false:
								case true:
									continue;
								}
								if (0 == 0)
								{
								}
								num2 = 2;
								num3 = num2;
								goto IL_0281;
							}
							break;
							continue;
							end_IL_0281:
							break;
						}
					}
				case 2:
					return null;
				}
			}
		}
		}
	}

	private static string smethod_0(object object_0)
	{
		int num = 19;
		while (true)
		{
			string result = null;
			int num2 = 1;
			int num3 = num2;
			while (true)
			{
				switch (num3)
				{
				case 10:
					result = object_0 as string;
					num2 = 7;
					num3 = num2;
					continue;
				case 9:
					result = ((DateTime)object_0).ToUniversalTime().ToString("닠", CultureInfo.InvariantCulture);
					if (1 == 0)
					{
					}
					num2 = 8;
					num3 = num2;
					continue;
				case 5:
				{
					num2 = 29106;
					int num4 = num2;
					num2 = 29106;
					switch (num4 == num2)
					{
					default:
						if (0 == 0)
						{
						}
						if (object_0 is string)
						{
							num2 = 10;
							num3 = num2;
						}
						else
						{
							num2 = 0;
							num3 = num2;
						}
						continue;
					case false:
					case true:
						break;
					}
					goto IL_00d5;
				}
				case 4:
					result = "닜뻋닞뛚";
					num2 = 6;
					num3 = num2;
					continue;
				case 2:
					if (object_0 is IFormattable)
					{
						num2 = 11;
						num3 = num2;
						continue;
					}
					goto IL_00d5;
				case 1:
					if (object_0 == null)
					{
						num2 = 4;
						num3 = num2;
					}
					else
					{
						num2 = 5;
						num3 = num2;
					}
					continue;
				case 0:
					if (object_0 is DateTime)
					{
						num2 = 9;
						num3 = num2;
					}
					else
					{
						num2 = 2;
						num3 = num2;
					}
					continue;
				case 11:
					try
					{
						return ((IFormattable)object_0).ToString("답", CultureInfo.InvariantCulture);
					}
					catch (FormatException)
					{
						return object_0.ToString();
					}
				case 3:
				case 6:
				case 7:
				case 8:
					{
						return result;
					}
					IL_00d5:
					result = object_0.ToString();
					num2 = 3;
					num3 = num2;
					continue;
				}
				break;
			}
		}
	}

	static Message()
	{
		int num = 3;
		if (1 == 0)
		{
		}
		int num2 = 6822;
		int num3 = num2;
		num2 = 6822;
		switch (num3 == num2)
		{
		}
		if (0 == 0)
		{
		}
		regex_0 = new Regex("튌\ude85틿훽튏꺑닩뚆늟뺇닯뚝닩꺀刏噩刉幮剿噯刏湄牚瘭爗縻爯瘭牟湅刏噩刉幮剿噯刏꺅늛뚉늖");
	}
}
