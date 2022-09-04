using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class 㼖㼴㼈㼉㼆㼃㼅㼴㼦㼀㼵㽂㼈㼡㼟
{
	internal static uint ﾃﾋﾆﾈﾗﾶￊﾡﾄﾆﾸﾆﾳﾷￌ(string ଅକଈ_0B48ଈଆଇଚ_0B49_0B03_0B31ଘ_0B01ଆଅ)
	{
		uint num = default(uint);
		if (ଅକଈ_0B48ଈଆଇଚ_0B49_0B03_0B31ଘ_0B01ଆଅ != null)
		{
			num = 2166136261u;
			for (int i = 0; i < ଅକଈ_0B48ଈଆଇଚ_0B49_0B03_0B31ଘ_0B01ଆଅ.Length; i++)
			{
				num = (ଅକଈ_0B48ଈଆଇଚ_0B49_0B03_0B31ଘ_0B01ଆଅ[i] ^ num) * 16777619;
			}
		}
		return num;
	}
}
