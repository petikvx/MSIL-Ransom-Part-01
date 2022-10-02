using System.Runtime.CompilerServices;
using 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮CPgzlWUEazHcoa7JCd4i.Consumers;

namespace 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮CPgzlWUEazHcoa7JCd4i.States;

internal class ClientSingletonStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClientSingletonStatus()
	{
		DicWriterConsumer.ListIndexer();
		StartSystem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartSystem()
	{
	}
}
