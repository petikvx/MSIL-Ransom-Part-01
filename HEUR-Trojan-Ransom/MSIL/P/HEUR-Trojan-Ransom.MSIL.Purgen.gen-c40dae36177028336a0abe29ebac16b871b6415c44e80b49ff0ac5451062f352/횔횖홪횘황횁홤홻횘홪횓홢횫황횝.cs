using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class 횔횖홪횘황횁홤홻횘홪횓홢횫황횝
{
	internal static uint _1316ጁጳጃገጀጶጁፅፆጧጴጠጁጱ(string 㬘㬝㭈㬛㭆㬖㭘㬘㬔㬯㭈㬚㭅㭅㭅)
	{
		uint num = default(uint);
		if (㬘㬝㭈㬛㭆㬖㭘㬘㬔㬯㭈㬚㭅㭅㭅 != null)
		{
			num = 2166136261u;
			for (int i = 0; i < 㬘㬝㭈㬛㭆㬖㭘㬘㬔㬯㭈㬚㭅㭅㭅.Length; i++)
			{
				num = (㬘㬝㭈㬛㭆㬖㭘㬘㬔㬯㭈㬚㭅㭅㭅[i] ^ num) * 16777619;
			}
		}
		return num;
	}
}
