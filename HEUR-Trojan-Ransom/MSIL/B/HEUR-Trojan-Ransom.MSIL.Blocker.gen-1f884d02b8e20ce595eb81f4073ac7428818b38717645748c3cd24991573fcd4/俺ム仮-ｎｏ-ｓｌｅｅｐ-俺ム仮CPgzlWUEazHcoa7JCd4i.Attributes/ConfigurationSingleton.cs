using System.Runtime.CompilerServices;
using 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮CPgzlWUEazHcoa7JCd4i.Consumers;

namespace 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮CPgzlWUEazHcoa7JCd4i.Attributes;

internal class ConfigurationSingleton
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigurationSingleton()
	{
		DicWriterConsumer.ListIndexer();
		ResetField();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetField()
	{
	}
}
