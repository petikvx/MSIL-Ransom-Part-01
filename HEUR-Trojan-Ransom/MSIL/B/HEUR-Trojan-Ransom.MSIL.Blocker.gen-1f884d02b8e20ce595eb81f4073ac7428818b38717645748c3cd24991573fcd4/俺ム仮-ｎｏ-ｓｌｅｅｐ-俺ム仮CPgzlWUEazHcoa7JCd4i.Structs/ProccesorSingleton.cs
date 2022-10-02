using System.Runtime.CompilerServices;
using 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮CPgzlWUEazHcoa7JCd4i.Consumers;

namespace 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮CPgzlWUEazHcoa7JCd4i.Structs;

internal class ProccesorSingleton
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProccesorSingleton()
	{
		DicWriterConsumer.ListIndexer();
		CreateIssuer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateIssuer()
	{
	}
}
