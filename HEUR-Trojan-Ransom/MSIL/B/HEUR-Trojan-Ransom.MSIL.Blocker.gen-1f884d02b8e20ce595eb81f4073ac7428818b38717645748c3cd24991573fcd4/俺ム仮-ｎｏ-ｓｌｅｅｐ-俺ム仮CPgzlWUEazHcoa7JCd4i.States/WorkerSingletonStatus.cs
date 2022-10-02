using System.Runtime.CompilerServices;
using 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮CPgzlWUEazHcoa7JCd4i.Consumers;

namespace 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮CPgzlWUEazHcoa7JCd4i.States;

internal class WorkerSingletonStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WorkerSingletonStatus()
	{
		DicWriterConsumer.ListIndexer();
		DeleteSetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteSetter()
	{
	}
}
