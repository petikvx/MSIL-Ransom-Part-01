using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml;

namespace PreEmptive.Analytics.Common.Tags;

public class Tag
{
	private string string_0 = "튪껃닞";

	private string string_1 = "튖껋닔뛗닇뻒닆뚖닦껏刵";

	public AttributeList Attributes = new AttributeList();

	[CompilerGenerated]
	private List<Tag> list_0;

	public virtual string TagName
	{
		get
		{
			int num = -5078;
			int num2 = num;
			num = -5078;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return string_0;
			}
		}
	}

	public virtual string TagDescription
	{
		get
		{
			int num = -29335;
			int num2 = num;
			num = -29335;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return string_1;
			}
		}
	}

	public List<Tag> InnerTags
	{
		[CompilerGenerated]
		get
		{
			int num = 7784;
			int num2 = num;
			num = 7784;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				if (1 == 0)
				{
				}
				return list_0;
			}
		}
		[CompilerGenerated]
		private set
		{
			int num = -16593;
			int num2 = num;
			num = -16593;
			switch (num2 == num)
			{
			}
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			list_0 = value;
		}
	}

	public Tag()
	{
		InnerTags = new List<Tag>();
	}

	public Tag(string tagName)
		: this()
	{
		string_0 = tagName;
	}

	public virtual string ToString(IAttributeLimiter limits)
	{
		int num = 17515;
		int num2 = num;
		num = 17515;
		switch (num2 == num)
		{
		default:
		{
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			StringBuilder stringBuilder = new StringBuilder();
			AppendToStringBuilder(stringBuilder, limits);
			return stringBuilder.ToString();
		}
		}
	}

	public override string ToString()
	{
		int num = -23554;
		int num2 = num;
		num = -23554;
		switch (num2 == num)
		{
		default:
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			return ToString(null);
		}
	}

	public virtual void AppendToStringBuilder(StringBuilder stringBuilder_0, IAttributeLimiter limits)
	{
		int num = 1;
		switch (0)
		{
		}
		string string_ = default(string);
		int? maxLength = default(int?);
		Attribute current = default(Attribute);
		int length = default(int);
		while (true)
		{
			if (true)
			{
			}
			stringBuilder_0.Append("훪").Append(TagName);
			List<Attribute>.Enumerator enumerator = Attributes.GetEnumerator();
			int num2 = 2;
			int num3 = num2;
			while (true)
			{
				switch (num3)
				{
				case 2:
					try
					{
						num2 = 9;
						num3 = num2;
						while (true)
						{
							object obj;
							switch (num3)
							{
							default:
								num2 = 1;
								num3 = num2;
								continue;
							case 7:
							{
								num2 = 13644;
								int num4 = num2;
								num2 = 13644;
								switch (num4 == num2)
								{
								default:
									if (0 == 0)
									{
									}
									num2 = 8;
									num3 = num2;
									continue;
								case false:
								case true:
									break;
								}
								goto IL_00d9;
							}
							case 6:
								obj = "";
								goto IL_00f3;
							case 5:
								if (limits != null)
								{
									num2 = 2;
									num3 = num2;
									continue;
								}
								goto case 4;
							case 4:
								AppendEscape(stringBuilder_0, string_, maxLength);
								stringBuilder_0.Append("훴");
								num2 = 3;
								num3 = num2;
								continue;
							case 2:
								maxLength = limits.MaxSize(TagName, current.Name);
								num2 = 4;
								num3 = num2;
								continue;
							case 1:
								if (!enumerator.MoveNext())
								{
									num2 = 7;
									num3 = num2;
								}
								else
								{
									current = enumerator.Current;
									num2 = 0;
									num3 = num2;
								}
								continue;
							case 0:
								obj = current.Value;
								if (obj == null)
								{
									num2 = 6;
									num3 = num2;
									continue;
								}
								goto IL_00f3;
							case 8:
								break;
								IL_00f3:
								string_ = (string)obj;
								stringBuilder_0.Append("훶");
								AppendEscape(stringBuilder_0, current.Name);
								stringBuilder_0.Append("훫티");
								maxLength = null;
								goto IL_00d9;
								IL_00d9:
								num2 = 5;
								num3 = num2;
								continue;
							}
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
					}
					stringBuilder_0.Append("훨");
					length = stringBuilder_0.Length;
					AppendSerializedInnerTags(stringBuilder_0, limits);
					num2 = 0;
					num3 = num2;
					continue;
				case 0:
					if (length == stringBuilder_0.Length)
					{
						num2 = 1;
						num3 = num2;
						continue;
					}
					stringBuilder_0.AppendFormat("훪틽\udea5틢횫틬", new object[1] { TagName });
					return;
				case 1:
					stringBuilder_0.Insert(length - 1, "훹");
					return;
				}
				break;
			}
		}
	}

	public static Tag FromString(string string_2)
	{
		StringReader stringReader = new StringReader(string_2);
		try
		{
			return FromReader(stringReader);
		}
		finally
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
				{
					num = 14559;
					int num3 = num;
					num = 14559;
					switch (num3 == num)
					{
					default:
						if (1 == 0)
						{
						}
						if (false)
						{
						}
						break;
					case false:
					case true:
						break;
					}
					goto default;
				}
				default:
					if (stringReader != null)
					{
						num = 0;
						num2 = num;
						continue;
					}
					break;
				case 0:
					((IDisposable)stringReader).Dispose();
					num = 1;
					num2 = num;
					continue;
				case 1:
					break;
				}
				break;
			}
		}
	}

	public static Tag FromReader(TextReader reader)
	{
		switch (0)
		{
		default:
		{
			Tag tag = null;
			try
			{
				XmlNodeType nodeType = default(XmlNodeType);
				while (true)
				{
					IL_0346:
					XmlReader xmlReader = XmlReader.Create(reader, new XmlReaderSettings
					{
						CheckCharacters = false
					});
					Tag tag2 = null;
					Stack<Tag> stack = new Stack<Tag>();
					int num = 20;
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						case 25:
							if (tag == null)
							{
								num = 12;
								num2 = num;
								continue;
							}
							goto case 0;
						case 0:
							num = 4;
							num2 = num;
							continue;
						case 23:
							if (!xmlReader.IsEmptyElement)
							{
								num = 19;
								num2 = num;
								continue;
							}
							goto case 1;
						case 1:
						case 6:
						case 18:
						case 20:
							num = 3;
							num2 = num;
							continue;
						case 22:
							num = 24;
							num2 = num;
							continue;
						case 21:
							num = 17;
							num2 = num;
							continue;
						case 19:
							stack.Push(tag2);
							num = 18;
							num2 = num;
							continue;
						case 17:
						{
							if (nodeType != XmlNodeType.EndElement)
							{
								num = 9;
								num2 = num;
								continue;
							}
							stack.Pop();
							num = -13283;
							int num3 = num;
							num = -13283;
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
							goto case 21;
						}
						case 16:
							if (stack.Count > 0)
							{
								num = 14;
								num2 = num;
								continue;
							}
							goto case 8;
						case 8:
							num = 23;
							num2 = num;
							continue;
						case 15:
							xmlReader.MoveToElement();
							num = 5;
							num2 = num;
							continue;
						case 14:
							stack.Peek().InnerTags.Add(tag2);
							num = 8;
							num2 = num;
							continue;
						case 13:
							if (!xmlReader.MoveToNextAttribute())
							{
								num = 15;
								num2 = num;
							}
							else
							{
								tag2.AddAttribute(xmlReader.Name, xmlReader.Value);
								num = 7;
								num2 = num;
							}
							continue;
						case 12:
							tag = tag2;
							num = 0;
							num2 = num;
							continue;
						case 7:
						case 11:
							num = 13;
							num2 = num;
							continue;
						case 10:
							num = 11;
							num2 = num;
							continue;
						case 9:
							num = 6;
							num2 = num;
							continue;
						case 5:
							num = 16;
							num2 = num;
							continue;
						case 4:
							if (xmlReader.HasAttributes)
							{
								num = 10;
								num2 = num;
								continue;
							}
							goto case 5;
						case 3:
							if (!xmlReader.Read())
							{
								num = 22;
								num2 = num;
							}
							else
							{
								nodeType = xmlReader.NodeType;
								num = 2;
								num2 = num;
							}
							continue;
						case 2:
							if (nodeType != XmlNodeType.Element)
							{
								num = 21;
								num2 = num;
							}
							else
							{
								tag2 = new Tag(xmlReader.Name);
								num = 25;
								num2 = num;
							}
							continue;
						case 24:
							goto end_IL_02d7;
						}
						goto IL_0346;
						continue;
						end_IL_02d7:
						break;
					}
					break;
				}
			}
			catch (Exception)
			{
				tag = null;
			}
			if (1 == 0)
			{
			}
			return tag;
		}
		}
	}

	protected virtual void AppendSerializedInnerTags(StringBuilder stringBuilder_0, IAttributeLimiter limits)
	{
		using List<Tag>.Enumerator enumerator = InnerTags.GetEnumerator();
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				num = 1;
				num2 = num;
				break;
			case 1:
			{
				num = 2498;
				int num3 = num;
				num = 2498;
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
						goto end_IL_00c6;
					}
					Tag current = enumerator.Current;
					current.AppendToStringBuilder(stringBuilder_0, limits);
					if (1 == 0)
					{
					}
					num = 2;
					num2 = num;
					goto end_IL_00c6;
				}
				}
				goto default;
			}
			case 0:
				num = 3;
				num2 = num;
				break;
			case 3:
				return;
				end_IL_00c6:
				break;
			}
		}
	}

	public void AddAttribute(string name, string value)
	{
		int num = 7799;
		int num2 = num;
		num = 7799;
		switch (num2 == num)
		{
		}
		if (1 == 0)
		{
		}
		if (0 == 0)
		{
		}
		Attributes.Add(new Attribute(name, value));
	}

	public void AddOptionalAttribute(string name, string value)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			if (true)
			{
			}
			switch (num2)
			{
			case 0:
				AddAttribute(name, value);
				num = 1;
				num2 = num;
				continue;
			case 2:
			{
				num = 17380;
				int num3 = num;
				num = 17380;
				switch (num3 == num)
				{
				default:
					if (false)
					{
					}
					break;
				case false:
				case true:
					break;
				}
				break;
			}
			case 1:
				return;
			}
			if (!string.IsNullOrEmpty(value))
			{
				num = 0;
				num2 = num;
				continue;
			}
			break;
		}
	}

	protected static void AppendEscape(StringBuilder stringBuilder_0, string string_2, [Optional] int? maxLength)
	{
		int num = 14;
		switch (0)
		{
		}
		char c = default(char);
		char c2 = default(char);
		int num5 = default(int);
		string text = default(string);
		while (true)
		{
			stringBuilder_0.EnsureCapacity(stringBuilder_0.Length + string_2.Length);
			int num2 = 0;
			if (true)
			{
			}
			int num3 = 18;
			int num4 = num3;
			while (true)
			{
				int num6;
				switch (num4)
				{
				case 28:
				case 29:
					num3 = 15;
					num4 = num3;
					continue;
				case 27:
					switch (c)
					{
					case '<':
						goto IL_007a;
					case '=':
						goto IL_009b;
					case '>':
						goto IL_00b0;
					}
					num3 = 23;
					num4 = num3;
					continue;
				case 25:
					goto IL_009b;
				case 20:
					if (smethod_0(c2))
					{
						num3 = 6;
						num4 = num3;
						continue;
					}
					goto case 1;
				case 1:
				case 8:
				case 9:
				case 14:
				case 17:
				case 22:
					num5++;
					num3 = 29;
					num4 = num3;
					continue;
				case 26:
					if (c2 < '\u007f')
					{
						num3 = 13;
						num4 = num3;
						continue;
					}
					goto IL_015c;
				case 24:
					if (maxLength.HasValue)
					{
						num3 = 12;
						num4 = num3;
						continue;
					}
					goto IL_018f;
				case 23:
					num3 = 25;
					num4 = num3;
					continue;
				case 21:
					if (c != '&')
					{
						num3 = 4;
						num4 = num3;
					}
					else
					{
						stringBuilder_0.Append("꺔닗뛟닎뺉");
						num3 = 17;
						num4 = num3;
					}
					continue;
				case 19:
					num3 = 7;
					num4 = num3;
					continue;
				case 18:
					if (!string.IsNullOrEmpty(string_2))
					{
						num3 = 2;
						num4 = num3;
						continue;
					}
					return;
				case 16:
					if (num2 >= maxLength.Value)
					{
						num3 = 19;
						num4 = num3;
						continue;
					}
					goto IL_018f;
				case 15:
					if (num5 >= text.Length)
					{
						num3 = 5;
						num4 = num3;
					}
					else
					{
						c2 = text[num5];
						num3 = 24;
						num4 = num3;
					}
					continue;
				case 13:
					stringBuilder_0.Append(c2);
					num3 = 1;
					num4 = num3;
					continue;
				case 12:
					num3 = 16;
					num4 = num3;
					continue;
				case 11:
					if (c2 >= ' ')
					{
						num3 = 10;
						num4 = num3;
						continue;
					}
					goto IL_015c;
				case 10:
					num3 = 26;
					num4 = num3;
					continue;
				case 6:
					stringBuilder_0.Append(string.Format("꺔늕뛊닅뺂늌뛪늚긯剭", new object[1] { (long)c2 }));
					num3 = 8;
					num4 = num3;
					continue;
				case 4:
					num3 = 27;
					num4 = num3;
					continue;
				case 3:
					if (c != '"')
					{
						num3 = 0;
						num4 = num3;
					}
					else
					{
						stringBuilder_0.Append("꺔닇뛇닑뻆늍");
						num3 = 14;
						num4 = num3;
					}
					continue;
				case 2:
					text = string_2;
					num5 = 0;
					num3 = 28;
					num4 = num3;
					continue;
				case 0:
					num3 = 21;
					num4 = num3;
					continue;
				case 7:
					return;
				case 5:
					return;
					IL_018f:
					num2++;
					c = c2;
					num3 = 3;
					num4 = num3;
					continue;
					IL_007a:
					stringBuilder_0.Append("꺔닚뛆늅");
					num3 = 9;
					num4 = num3;
					continue;
					IL_015c:
					num3 = 20;
					num4 = num3;
					continue;
					IL_00b0:
					num3 = 30676;
					num6 = num3;
					num3 = 30676;
					switch (num6 == num3)
					{
					default:
						if (0 == 0)
						{
						}
						stringBuilder_0.Append("꺔닑뛆늅");
						num3 = 22;
						num4 = num3;
						continue;
					case false:
					case true:
						break;
					}
					goto case 20;
					IL_009b:
					num3 = 11;
					num4 = num3;
					continue;
				}
				break;
			}
		}
	}

	private static bool smethod_0(int int_0)
	{
		int num = 8;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 11:
				num = 1;
				num2 = num;
				continue;
			case 10:
				if (int_0 != 10)
				{
					num = 6;
					num2 = num;
					continue;
				}
				break;
			case 9:
				if (int_0 != 13)
				{
					num = 3;
					num2 = num;
					continue;
				}
				break;
			case 8:
			{
				num = -371;
				int num3 = num;
				num = -371;
				switch (num3 == num)
				{
				case false:
				case true:
					break;
				default:
					goto IL_008f;
				}
				goto case 9;
			}
			default:
				if (int_0 != 9)
				{
					num = 4;
					num2 = num;
					continue;
				}
				break;
			case 7:
				if (int_0 >= 32)
				{
					num = 5;
					num2 = num;
					continue;
				}
				goto case 11;
			case 6:
				if (1 == 0)
				{
				}
				num = 9;
				num2 = num;
				continue;
			case 5:
				num = 0;
				num2 = num;
				continue;
			case 4:
				num = 10;
				num2 = num;
				continue;
			case 3:
				num = 7;
				num2 = num;
				continue;
			case 1:
				if (int_0 >= 57344)
				{
					num = 2;
					num2 = num;
					continue;
				}
				return false;
			case 0:
				if (int_0 > 55295)
				{
					num = 11;
					num2 = num;
					continue;
				}
				break;
			case 2:
				{
					return int_0 <= 65533;
				}
				IL_008f:
				if (false)
				{
				}
				goto default;
			}
			break;
		}
		return true;
	}

	protected string Escape(string string_2, [Optional] int? maxLength)
	{
		int num = 6116;
		int num2 = num;
		num = 6116;
		switch (num2 == num)
		{
		default:
		{
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			StringBuilder stringBuilder = new StringBuilder(string_2.Length);
			AppendEscape(stringBuilder, string_2);
			return stringBuilder.ToString();
		}
		}
	}

	protected internal void AddOptionalAttribute<T>(string name, T value)
	{
		while (true)
		{
			string text = smethod_1(value);
			int num = 0;
			int num2 = num;
			while (true)
			{
				num = 16183;
				int num3 = num;
				num = 16183;
				switch (num3 == num)
				{
				default:
					if (0 == 0)
					{
					}
					switch (num2)
					{
					case 0:
						if (text != null)
						{
							num = 2;
							num2 = num;
							continue;
						}
						goto case 1;
					case 2:
						AddOptionalAttribute(name, text);
						num = 1;
						num2 = num;
						continue;
					case 1:
						if (true)
						{
						}
						return;
					}
					break;
				case false:
				case true:
					break;
				}
				break;
			}
		}
	}

	private static string smethod_1<T>(T gparam_0)
	{
		switch (0)
		{
		}
		bool? flag = default(bool?);
		Guid? guid = default(Guid?);
		long? num4 = default(long?);
		ulong? num5 = default(ulong?);
		while (true)
		{
			int? num = gparam_0 as int?;
			int num2 = 8;
			int num3 = num2;
			while (true)
			{
				switch (num3)
				{
				case 10:
					if (gparam_0 is string)
					{
						num2 = 6;
						num3 = num2;
						continue;
					}
					return null;
				case 9:
					if (flag.HasValue)
					{
						num2 = 3;
						num3 = num2;
					}
					else
					{
						guid = gparam_0 as Guid?;
						num2 = 7;
						num3 = num2;
					}
					continue;
				case 8:
					if (1 == 0)
					{
					}
					if (num.HasValue)
					{
						num2 = 4;
						num3 = num2;
					}
					else
					{
						flag = gparam_0 as bool?;
						num2 = 9;
						num3 = num2;
					}
					continue;
				case 7:
				{
					if (guid.HasValue)
					{
						num2 = 5;
						num3 = num2;
						continue;
					}
					num4 = gparam_0 as long?;
					num2 = -13716;
					int num6 = num2;
					num2 = -13716;
					switch (num6 == num2)
					{
					default:
						if (0 == 0)
						{
						}
						num2 = 0;
						num3 = num2;
						continue;
					case false:
					case true:
						break;
					}
					goto IL_0151;
				}
				case 1:
					if (num5.HasValue)
					{
						num2 = 2;
						num3 = num2;
					}
					else
					{
						num2 = 10;
						num3 = num2;
					}
					continue;
				case 0:
					if (num4.HasValue)
					{
						num2 = 11;
						num3 = num2;
						continue;
					}
					goto IL_0151;
				case 2:
					return num5.Value.ToString();
				case 3:
					return flag.Value.ToString().ToLowerInvariant();
				case 4:
					return num.Value.ToString();
				case 5:
					return guid.Value.ToString();
				case 6:
					return gparam_0 as string;
				case 11:
					{
						return num4.Value.ToString();
					}
					IL_0151:
					num5 = gparam_0 as ulong?;
					num2 = 1;
					num3 = num2;
					continue;
				}
				break;
			}
		}
	}
}
