using System.Runtime.CompilerServices;

namespace 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮CPgzlWUEazHcoa7JCd4i.Consumers;

internal class EventSingleton
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static EventSingleton()
	{
		DicWriterConsumer.ListIndexer();
		WriteDatabase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteDatabase()
	{
	}
}
