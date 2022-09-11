using System.Runtime.InteropServices;

namespace PreEmptive.Analytics.Common.Tags;

public class StackTag : Tag
{
	public override string TagName
	{
		get
		{
			int num = 5;
			int num2 = -14110;
			int num3 = num2;
			num2 = -14110;
			switch (num3 == num2)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return "\udead튦횷튱껅";
			}
		}
	}

	public StackTag([Optional] int sequence, [Optional] string type, [Optional] string method, [Optional] string signature, [Optional] string file, [Optional] string line)
	{
		int num = 15;
		base._002Ector();
		AddAttribute("닁뛓닃", sequence.ToString());
		AddAttribute("닆뛏닂뻛", string.IsNullOrEmpty(type) ? "닧뛘닙뻐닝뛁닜" : type);
		AddAttribute("닟뛓닆뻖닝뛒", string.IsNullOrEmpty(method) ? "닧뛘닙뻐닝뛁닜" : method);
		AddOptionalAttribute("닁뛟닕뻐닓뛂닇껜刷", signature);
		AddOptionalAttribute("닔뛟닞뻛", file);
		AddOptionalAttribute("닞뛟닜뻛", line);
	}
}
