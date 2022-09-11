namespace PreEmptive.Analytics.Common.Tags;

public class ApplicationTag : Tag
{
	public override string TagName
	{
		get
		{
			int num = 18;
			int num2 = 30234;
			int num3 = num2;
			num2 = 30234;
			switch (num3 == num2)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return "뛓닎뻂닚뛛닍긳刢嘻刱帼";
			}
		}
	}

	public ApplicationTag(string applicationId, string applicationName, string applicationVersion, string applicationType, string applicationInstanceId)
	{
		AddAttribute("닟뛖", applicationId);
		AddOptionalAttribute("님뛓닓뻗", applicationName);
		AddOptionalAttribute("닀뛗닌뻁닟뛝닀", applicationVersion);
		AddOptionalAttribute("닂뛋닎뻗", applicationType);
		AddOptionalAttribute("닟뛜닍뻆닗뛜닍긷", applicationInstanceId);
	}
}
