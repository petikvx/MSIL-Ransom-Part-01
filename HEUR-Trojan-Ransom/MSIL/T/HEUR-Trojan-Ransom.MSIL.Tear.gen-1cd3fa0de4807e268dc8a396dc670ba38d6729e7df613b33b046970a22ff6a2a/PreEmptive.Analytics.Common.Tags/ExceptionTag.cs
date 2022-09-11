namespace PreEmptive.Analytics.Common.Tags;

public class ExceptionTag : Tag
{
	public override string TagName
	{
		get
		{
			int num = 5;
			int num2 = 23066;
			int num3 = num2;
			num2 = 23066;
			switch (num3 == num2)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return "\udebb튪횵튷껞닆뛟닝뻐";
			}
		}
	}

	public ExceptionTag(string type, string message)
		: this(0, type, message)
	{
	}

	public ExceptionTag(int sequence, string type, string message)
	{
		AddAttribute("뛁닛뻃", sequence.ToString());
		AddAttribute("뛗닆뻑닓뛂닚긻刹嘼刊師刦嘷", type);
		AddOptionalAttribute("뛟닛뻁닅뛓닉긷", message);
	}
}
