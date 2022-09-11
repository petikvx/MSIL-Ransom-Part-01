using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using PreEmptive.Analytics.Common.Tags;
using PreEmptive.Analytics.Common.Utilities;

namespace PreEmptive.Analytics.Common;

public class Message : Tag
{
	private string string_2;

	private IAttributeLimiter iattributeLimiter_0;

	private WeakReference weakReference_0;

	private int int_0;

	private int int_1;

	[CompilerGenerated]
	private BinaryInfoTag binaryInfoTag_0;

	public override string TagName
	{
		get
		{
			int num = -26149;
			int num2 = num;
			num = -26149;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return string_2;
			}
		}
	}

	public BinaryInfoTag BinaryInfo
	{
		[CompilerGenerated]
		get
		{
			int num = 1496;
			int num2 = num;
			num = 1496;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				if (1 == 0)
				{
				}
				return binaryInfoTag_0;
			}
		}
		[CompilerGenerated]
		private set
		{
			if (1 == 0)
			{
			}
			int num = 336;
			int num2 = num;
			num = 336;
			switch (num2 == num)
			{
			}
			if (0 == 0)
			{
			}
			binaryInfoTag_0 = value;
		}
	}

	public Message(Guid session, [Optional] ExtendedKeys keys, [Optional] BinaryInfoTag binary)
	{
		int num = 7;
		string_2 = "튿횳튡껝닓뛑닗";
		weakReference_0 = new WeakReference(null);
		int_0 = -1;
		int_1 = -1;
		base._002Ector();
		if (binary != null)
		{
			BinaryInfo = binary;
			base.InnerTags.Add(binary);
		}
		AddAttribute("튻횲", Guid.NewGuid().ToString());
		AddAttribute("튵횳튼껋닀뛗닆뻛닖", DateTime.UtcNow.ToISOFormat());
		AddAttribute("튡횳튡껝닛뛙닜", session.ToString());
		if (keys != null && keys.Map != null)
		{
			base.InnerTags.AddRange(keys.ToTags().Cast<Tag>());
		}
	}

	public Message(string messageType)
	{
		string_2 = "튻횷틝껁닗뛕닛";
		weakReference_0 = new WeakReference(null);
		int_0 = -1;
		int_1 = -1;
		base._002Ector();
		string_2 = messageType;
	}

	public static Message FromTag(Tag tag_0)
	{
		int num = 28589;
		int num2 = num;
		num = 28589;
		switch (num2 == num)
		{
		default:
			if (0 == 0)
			{
			}
			switch (0)
			{
			default:
			{
				Message result = new Message(tag_0.TagName);
				using (List<PreEmptive.Analytics.Common.Tags.Attribute>.Enumerator enumerator = tag_0.Attributes.GetEnumerator())
				{
					num = 1;
					int num3 = num;
					while (true)
					{
						switch (num3)
						{
						case 4:
							num = 2;
							num3 = num;
							continue;
						default:
							num = 0;
							num3 = num;
							continue;
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = 4;
								num3 = num;
								continue;
							}
							PreEmptive.Analytics.Common.Tags.Attribute current = enumerator.Current;
							result.AddAttribute(current.Name, current.Value);
							num = 3;
							num3 = num;
							continue;
						}
						case 2:
							break;
						}
						break;
					}
				}
				if (1 == 0)
				{
				}
				using List<Tag>.Enumerator enumerator2 = tag_0.InnerTags.GetEnumerator();
				num = 1;
				int num3 = num;
				while (true)
				{
					switch (num3)
					{
					case 4:
						num = 2;
						num3 = num;
						break;
					default:
						num = 0;
						num3 = num;
						break;
					case 0:
					{
						if (!enumerator2.MoveNext())
						{
							num = 4;
							num3 = num;
							break;
						}
						Tag current2 = enumerator2.Current;
						result.InnerTags.Add(current2);
						num = 3;
						num3 = num;
						break;
					}
					case 2:
						return result;
					}
				}
			}
			}
		case false:
		case true:
		{
			Message result = default(Message);
			return result;
		}
		}
	}

	public override string ToString(IAttributeLimiter limits)
	{
		if (1 == 0)
		{
		}
		int num = 0;
		int num2 = num;
		int capacity;
		while (true)
		{
			switch (num2)
			{
			case 3:
				num = 1;
				num2 = num;
				continue;
			case 0:
			{
				num = -13543;
				int num3 = num;
				num = -13543;
				switch (num3 == num)
				{
				case false:
				case true:
					continue;
				}
				if (false)
				{
				}
				goto default;
			}
			default:
				if (int_1 <= 0)
				{
					num = 3;
					num2 = num;
				}
				else
				{
					num = 2;
					num2 = num;
				}
				continue;
			case 1:
				capacity = 250;
				break;
			case 2:
				capacity = int_1;
				break;
			}
			break;
		}
		StringBuilder stringBuilder = new StringBuilder(capacity);
		AppendToStringBuilder(stringBuilder, limits);
		return stringBuilder.ToString();
	}

	public override string ToString()
	{
		int num = -23719;
		int num2 = num;
		num = -23719;
		switch (num2 == num)
		{
		default:
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			return ToString(null);
		}
	}

	public override void AppendToStringBuilder(StringBuilder stringBuilder_0, IAttributeLimiter limits)
	{
		int num = 10;
		int num2 = num;
		StringBuilder stringBuilder = default(StringBuilder);
		while (true)
		{
			int num3;
			switch (num2)
			{
			case 13:
				iattributeLimiter_0 = limits;
				num = 14;
				num2 = num;
				continue;
			case 12:
				if (limits != null)
				{
					num = 13;
					num2 = num;
					continue;
				}
				break;
			case 11:
				num = 8;
				num2 = num;
				continue;
			default:
				if (weakReference_0 != null)
				{
					num = 11;
					num2 = num;
					continue;
				}
				goto IL_0079;
			case 9:
				num = 4;
				num2 = num;
				continue;
			case 8:
				if (limits != null)
				{
					num = 6;
					num2 = num;
					continue;
				}
				goto case 1;
			case 1:
				stringBuilder = weakReference_0.Target as StringBuilder;
				num = 3;
				num2 = num;
				continue;
			case 7:
				if (int_0 != -1)
				{
					num = 9;
					num2 = num;
					continue;
				}
				goto IL_0079;
			case 6:
				if (1 == 0)
				{
				}
				num = 2;
				num2 = num;
				continue;
			case 5:
				num = 7;
				num2 = num;
				continue;
			case 4:
				if (int_1 != -1)
				{
					num = 0;
					num2 = num;
					continue;
				}
				goto IL_0079;
			case 3:
				if (stringBuilder != null)
				{
					num = 5;
					num2 = num;
					continue;
				}
				goto IL_0079;
			case 2:
				if (limits == iattributeLimiter_0)
				{
					num = 1;
					num2 = num;
					continue;
				}
				goto IL_0079;
			case 0:
			{
				int length = stringBuilder_0.Length;
				stringBuilder_0.Append(stringBuilder.ToString(int_0, int_1));
				int_0 = length;
				weakReference_0 = new WeakReference(stringBuilder_0);
				return;
			}
			case 14:
				break;
				IL_0079:
				weakReference_0 = new WeakReference(stringBuilder_0);
				num = 3365;
				num3 = num;
				num = 3365;
				switch (num3 == num)
				{
				default:
					if (0 == 0)
					{
					}
					num = 12;
					num2 = num;
					continue;
				case false:
				case true:
					break;
				}
				goto case 0;
			}
			break;
		}
		int_0 = stringBuilder_0.Length;
		base.AppendToStringBuilder(stringBuilder_0, limits);
		int_1 = stringBuilder_0.Length - int_0;
	}

	public void InvalidateStringCache()
	{
		int num = -11603;
		int num2 = num;
		num = -11603;
		switch (num2 == num)
		{
		}
		if (0 == 0)
		{
		}
		if (1 == 0)
		{
		}
		weakReference_0 = null;
		int_0 = -1;
		int_1 = -1;
		iattributeLimiter_0 = null;
	}
}
