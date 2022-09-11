using System.Runtime.InteropServices;

namespace PreEmptive.Analytics.Common.Tags;

public class AppComponentTag : Tag
{
	public override string TagName
	{
		get
		{
			int num = 0;
			int num2 = 2863;
			int num3 = num2;
			num2 = 2863;
			switch (num3 == num2)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return "튵횽튳\udea2특횼틋껜닂";
			}
		}
	}

	public AppComponentTag(string name, [Optional] string version, [Optional] string fullname)
	{
		AddAttribute("\udeb0튳횻튷", name);
		AddOptionalAttribute("\udea8튷횤튡껇닝뛘", version);
		AddOptionalAttribute("\udeb8튧횺튾껠닓뛛닗", fullname);
	}
}
