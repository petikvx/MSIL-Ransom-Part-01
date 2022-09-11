using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using PreEmptive.Analytics.Common.Tags;

namespace PreEmptive.Analytics.Common;

public class MessageBatch
{
	public string ID = Guid.NewGuid().ToString();

	[CompilerGenerated]
	private DateTime dateTime_0;

	[CompilerGenerated]
	private int int_0;

	[CompilerGenerated]
	private AgentInfo agentInfo_0;

	[CompilerGenerated]
	private Configuration configuration_0;

	[CompilerGenerated]
	private IList<Message> ilist_0;

	[CompilerGenerated]
	private static Func<Tag, bool> func_0;

	[CompilerGenerated]
	private static Func<Tag, bool> func_1;

	[CompilerGenerated]
	private static Func<Tag, bool> func_2;

	[CompilerGenerated]
	private static Func<Tag, bool> func_3;

	public DateTime DateCreated
	{
		[CompilerGenerated]
		get
		{
			int num = 20160;
			int num2 = num;
			num = 20160;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return dateTime_0;
			}
		}
		[CompilerGenerated]
		set
		{
			int num = 3912;
			int num2 = num;
			num = 3912;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			dateTime_0 = value;
		}
	}

	public int FailureCount
	{
		[CompilerGenerated]
		get
		{
			int num = -6958;
			int num2 = num;
			num = -6958;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return int_0;
			}
		}
		[CompilerGenerated]
		set
		{
			int num = 25;
			int num2 = num;
			num = 25;
			switch (num2 == num)
			{
			}
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			int_0 = value;
		}
	}

	public AgentInfo AgentInfo
	{
		[CompilerGenerated]
		get
		{
			int num = -2952;
			int num2 = num;
			num = -2952;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return agentInfo_0;
			}
		}
		[CompilerGenerated]
		set
		{
			if (1 == 0)
			{
			}
			int num = 7477;
			int num2 = num;
			num = 7477;
			switch (num2 == num)
			{
			}
			if (0 == 0)
			{
			}
			agentInfo_0 = value;
		}
	}

	public Configuration Configuration
	{
		[CompilerGenerated]
		get
		{
			int num = 9933;
			int num2 = num;
			num = 9933;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				if (1 == 0)
				{
				}
				return configuration_0;
			}
		}
		[CompilerGenerated]
		set
		{
			int num = 10509;
			int num2 = num;
			num = 10509;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			configuration_0 = value;
		}
	}

	public IList<Message> Messages
	{
		[CompilerGenerated]
		get
		{
			int num = -4359;
			int num2 = num;
			num = -4359;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return ilist_0;
			}
		}
		[CompilerGenerated]
		set
		{
			int num = -31032;
			int num2 = num;
			num = -31032;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			ilist_0 = value;
		}
	}

	public MessageBatch(AgentInfo agentInfo, Configuration configuration, IList<Message> messages)
	{
		AgentInfo = agentInfo;
		Configuration = configuration;
		Messages = messages;
		DateCreated = DateTime.UtcNow;
		FailureCount = 0;
	}

	public MessageBatch()
	{
		AgentInfo = new AgentInfo();
		Configuration = new Configuration();
		Messages = new List<Message>();
	}

	public MessageBatch(IList<Message> messages)
		: this()
	{
		Messages = messages;
	}

	public override string ToString()
	{
		int num = 9126;
		int num2 = num;
		num = 9126;
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

	public string ToString(IAttributeLimiter limiter)
	{
		int num = 17;
		int num2 = -22851;
		int num3 = num2;
		num2 = -22851;
		switch (num3 == num2)
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
			stringBuilder.AppendLine(string.Format("뚊닟뻛닁뛅닓껉刷嘴刳帪刱嘾割渇爖癋牐縅牂瘋牐湎刴嘷刻帲刡噫剰껕늃뛋느뺞닑뛄닗껏튦횳튶\udee3티횭틠\uee93\uf2d0\uf6d6\uf2cc", new object[3]
			{
				ID,
				FailureCount,
				DateCreated.ToString("뛏닋뻇닋뛻닿껊制嘞刚帳刿嘥刡済爔瘐爔縘爔瘐")
			}));
			stringBuilder.AppendLine(new MessagesTag(Configuration, AgentInfo, Messages).ToString(limiter));
			stringBuilder.AppendLine("뚊늝뻓닗뛅닁껏刵嘳到帿刦嘵刺湐");
			return stringBuilder.ToString();
		}
		}
	}

	public static MessageBatch FromString(string string_0)
	{
		int num = 11;
		switch (0)
		{
		default:
		{
			MessageBatch messageBatch = new MessageBatch();
			try
			{
				IEnumerator<Tag> enumerator = default(IEnumerator<Tag>);
				List<Message> list = default(List<Message>);
				Tag tag2 = default(Tag);
				Configuration configuration = default(Configuration);
				AgentInfo agentInfo = default(AgentInfo);
				while (true)
				{
					Tag tag = Tag.FromString(string_0);
					messageBatch.ID = tag.Attributes["튻껊"].Value;
					int num2 = 4;
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						case 6:
							try
							{
								num2 = 2;
								num3 = num2;
								while (true)
								{
									switch (num3)
									{
									case 4:
										num2 = 1;
										num3 = num2;
										continue;
									default:
										num2 = 0;
										num3 = num2;
										continue;
									case 0:
									{
										if (!enumerator.MoveNext())
										{
											num2 = 4;
											num3 = num2;
											continue;
										}
										Tag current = enumerator.Current;
										list.Add(Message.FromTag(current));
										num2 = 3;
										num3 = num2;
										continue;
									}
									case 1:
										break;
									}
									break;
								}
							}
							finally
							{
								num2 = 1;
								num3 = num2;
								while (true)
								{
									switch (num3)
									{
									case 2:
									{
										num2 = -11190;
										int num4 = num2;
										num2 = -11190;
										switch (num4 == num2)
										{
										case false:
										case true:
											break;
										default:
											if (false)
											{
											}
											goto end_IL_0183;
										}
										goto IL_0158;
									}
									default:
										if (enumerator == null)
										{
											goto case 2;
										}
										goto IL_0158;
									case 0:
										{
											enumerator.Dispose();
											num2 = 2;
											num3 = num2;
											break;
										}
										IL_0158:
										num2 = 0;
										num3 = num2;
										break;
									}
									continue;
									end_IL_0183:
									break;
								}
							}
							messageBatch.Messages = list;
							num2 = 0;
							num3 = num2;
							continue;
						case 5:
						{
							Tag tag4 = tag2.InnerTags.First(delegate(Tag tag_0)
							{
								int num8 = 12;
								int num9 = 1523;
								int num10 = num9;
								num9 = 1523;
								switch (num10 == num9)
								{
								default:
									if (1 == 0)
									{
									}
									if (0 == 0)
									{
									}
									return tag_0.TagName == "틍껝닛뛂닟뻜닏";
								}
							});
							configuration.CompanyName = tag4.Attributes["튼껏닟뛓"].Value;
							configuration.CompanyID = new Guid(tag4.Attributes["튻껊"].Value);
							num2 = 3;
							num3 = num2;
							continue;
						}
						case 4:
							try
							{
								messageBatch.FailureCount = int.Parse(tag.Attributes["튴껏닛뛚닁"].Value);
								messageBatch.DateCreated = DateTime.ParseExact(tag.Attributes["튱껜닗뛗닆뻛닖"].Value, "튫껗닋뛏닿뻳닖뛒닺껦刿嘻刡席刴嘰刴済爔瘐爔", CultureInfo.InvariantCulture);
							}
							catch
							{
								messageBatch.FailureCount = 0;
								messageBatch.DateCreated = DateTime.Now.ToUniversalTime();
							}
							agentInfo = new AgentInfo();
							num2 = 2;
							num3 = num2;
							continue;
						case 3:
						{
							Tag tag3 = tag2.InnerTags.First(delegate(Tag tag_0)
							{
								int num11 = 13;
								int num12 = -13751;
								int num13 = num12;
								num12 = -13751;
								switch (num13 == num12)
								{
								default:
									if (0 == 0)
									{
									}
									if (1 == 0)
									{
									}
									return tag_0.TagName == "껏닂뛆닞뻗닑뛗닆껇刽嘸";
								}
							});
							configuration.ApplicationID = new Guid(tag3.Attributes["튻껊"].Value);
							configuration.ApplicationName = tag3.Attributes["튼껏닟뛓"].Value;
							configuration.ApplicationVersion = tag3.Attributes["튤껋닀뛅닛뻑닜"].Value;
							configuration.ApplicationType = tag3.Attributes["튦껗닂뛓"].Value;
							configuration.InstanceID = tag3.Attributes["튻껀닁뛂닓뻐닑뛓"].Value;
							configuration.MessageGroup = new Guid(tag2.Attributes["튿껋닁뛅닓뻙닗뚛닕껜刽嘣刢"].Value);
							messageBatch.Configuration = configuration;
							num2 = 1;
							num3 = num2;
							continue;
						}
						case 2:
							tag2 = tag.InnerTags.First(delegate(Tag tag_0)
							{
								int num5 = 14;
								int num6 = 16002;
								int num7 = num6;
								num6 = 16002;
								switch (num7 == num6)
								{
								default:
									if (1 == 0)
									{
									}
									if (0 == 0)
									{
									}
									return tag_0.TagName == "껟닓뛁닍뻓닑뛗닝";
								}
							});
							agentInfo.Name = tag2.Attributes["튳껉닗뛘닆뺓닜뛗닟껋"].Value;
							agentInfo.Version = tag2.Attributes["튳껉닗뛘닆뺓닄뛓닀껝刻嘹刼"].Value;
							messageBatch.AgentInfo = agentInfo;
							configuration = new Configuration();
							num2 = 5;
							num3 = num2;
							continue;
						case 1:
						{
							IEnumerable<Tag> enumerable = tag2.InnerTags.Where(delegate(Tag tag_0)
							{
								int num14 = 5;
								while (!(tag_0.TagName != "\udebd튽횻튢껏닜뛏"))
								{
									int num15 = 2082;
									int num16 = num15;
									num15 = 2082;
									switch (num16 == num15)
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
										return false;
									}
								}
								return tag_0.TagName != "\udebf튢횦튾껇닑뛗닆뻗닝뛘";
							});
							list = new List<Message>();
							enumerator = enumerable.GetEnumerator();
							if (1 == 0)
							{
							}
							num2 = 6;
							num3 = num2;
							continue;
						}
						case 0:
							return messageBatch;
						}
						break;
					}
				}
			}
			catch (Exception)
			{
				return null;
			}
		}
		}
	}

	[CompilerGenerated]
	private static bool smethod_0(Tag tag_0)
	{
		int num = 14;
		int num2 = 16002;
		int num3 = num2;
		num2 = 16002;
		switch (num3 == num2)
		{
		default:
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			return tag_0.TagName == "껟닓뛁닍뻓닑뛗닝";
		}
	}

	[CompilerGenerated]
	private static bool smethod_1(Tag tag_0)
	{
		int num = 12;
		int num2 = 1523;
		int num3 = num2;
		num2 = 1523;
		switch (num3 == num2)
		{
		default:
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			return tag_0.TagName == "틍껝닛뛂닟뻜닏";
		}
	}

	[CompilerGenerated]
	private static bool smethod_2(Tag tag_0)
	{
		int num = 13;
		int num2 = -13751;
		int num3 = num2;
		num2 = -13751;
		switch (num3 == num2)
		{
		default:
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			return tag_0.TagName == "껏닂뛆닞뻗닑뛗닆껇刽嘸";
		}
	}

	[CompilerGenerated]
	private static bool smethod_3(Tag tag_0)
	{
		int num = 5;
		while (!(tag_0.TagName != "\udebd튽횻튢껏닜뛏"))
		{
			int num2 = 2082;
			int num3 = num2;
			num2 = 2082;
			switch (num3 == num2)
			{
			case false:
			case true:
				continue;
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			return false;
		}
		return tag_0.TagName != "\udebf튢횦튾껇닑뛗닆뻗닝뛘";
	}
}
