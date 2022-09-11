using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using PreEmptive.Analytics.Common.Utilities;

namespace PreEmptive.Analytics.Common.Tags;

public class MessagesTag : Tag
{
	private const long long_0 = 3L;

	[CompilerGenerated]
	private IList<Message> ilist_0;

	public override string TagName
	{
		get
		{
			int num = 12;
			int num2 = 15635;
			int num3 = num2;
			num2 = 15635;
			switch (num3 == num2)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return "틃껗닅뛁닟뻕닓뛁";
			}
		}
	}

	private IList<Message> Messages
	{
		[CompilerGenerated]
		get
		{
			int num = 71;
			int num2 = num;
			num = 71;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				if (1 == 0)
				{
				}
				return ilist_0;
			}
		}
		[CompilerGenerated]
		set
		{
			int num = 23630;
			int num2 = num;
			num = 23630;
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

	public MessagesTag(Configuration configuration, AgentInfo agentInfo, IEnumerable<Message> messages)
	{
		Messages = new List<Message>(messages);
		AddAttribute("\udeaa튻횾틀껁늌뛊닍뻛", "\udeba튢횦틞꺈늙뚝닉뻅닁뚜닙깡剸嘽刬帵剹噠剞湂片癝爦縿爺瘡爍渺刳嘿刿广刿嘼勝껆닗뛜닝뻗");
		AddAttribute("\udeaa튥횻튔껜닙뛼닟뻟닓뛁닞긳刵嘷刍帱刾嘷刃渓爺瘝爝縓爂瘛爁渼", "\udeba튢횦틞꺈늙뚝닍뻑닞뛗닃긳別噼刮帠刳嘷刃渂爂瘛爈縗牘瘑爁渿剹嘡刻帠删嘻勍껗닅뚝닓뻗닅뛁닏꺵튿횼특");
		AddAttribute("\udea2튤횽틚껝닕뛝닒", 3L.ToString());
		AddAttribute("\udeb3튱횷틀껆늛뛜닟뻟닓", agentInfo.Name);
		AddAttribute("\udeb3튱횷틀껆늛뛄닛뻀닅뛛닁긼", agentInfo.Version);
		AddAttribute("\udebb튲", Guid.NewGuid().ToString());
		AddAttribute("\udebf튳횡틝껓닑뛗늓뻕닄뛝닛긢", configuration.MessageGroup.ToString());
		AddAttribute("\udea1튳횼틚", DateTime.UtcNow.ToISOFormat());
		base.InnerTags.Add(new CompanyTag(configuration.CompanyID.ToString(), configuration.CompanyName));
		base.InnerTags.Add(new ApplicationTag(configuration.ApplicationID.ToString(), configuration.ApplicationName, configuration.ApplicationVersion, configuration.ApplicationType, configuration.InstanceID));
	}

	public override string ToString(IAttributeLimiter limits)
	{
		int num = 29406;
		int num2 = num;
		num = 29406;
		switch (num2 == num)
		{
		default:
		{
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			int capacity = (Messages.Count + 2) * 300;
			StringBuilder stringBuilder = new StringBuilder(capacity);
			AppendToStringBuilder(stringBuilder, limits);
			return stringBuilder.ToString();
		}
		}
	}

	protected override void AppendSerializedInnerTags(StringBuilder stringBuilder_0, IAttributeLimiter limits)
	{
		base.AppendSerializedInnerTags(stringBuilder_0, limits);
		IEnumerator<Message> enumerator = Messages.GetEnumerator();
		try
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					num = 3;
					num2 = num;
					break;
				case 3:
				{
					if (!enumerator.MoveNext())
					{
						num = 0;
						num2 = num;
						break;
					}
					if (1 == 0)
					{
					}
					Message current = enumerator.Current;
					current.AppendToStringBuilder(stringBuilder_0, limits);
					num = 4;
					num2 = num;
					break;
				}
				case 0:
					num = 1;
					num2 = num;
					break;
				case 1:
					return;
				}
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
						num = 1;
						num2 = num;
						continue;
					}
					break;
				case 1:
				{
					num = -11250;
					int num3 = num;
					num = -11250;
					switch (num3 == num)
					{
					default:
						if (0 == 0)
						{
						}
						enumerator.Dispose();
						break;
					case false:
					case true:
						break;
					}
					num = 0;
					num2 = num;
					continue;
				}
				case 0:
					break;
				}
				break;
			}
		}
	}
}
