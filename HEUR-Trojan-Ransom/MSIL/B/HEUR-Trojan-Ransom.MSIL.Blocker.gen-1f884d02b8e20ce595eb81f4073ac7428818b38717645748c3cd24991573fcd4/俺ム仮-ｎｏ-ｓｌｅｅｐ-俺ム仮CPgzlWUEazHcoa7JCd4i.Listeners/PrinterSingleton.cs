using System.Runtime.CompilerServices;
using 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮CPgzlWUEazHcoa7JCd4i.Consumers;

namespace 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮CPgzlWUEazHcoa7JCd4i.Listeners;

internal class PrinterSingleton
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrinterSingleton()
	{
		DicWriterConsumer.ListIndexer();
		DicWriterConsumer.CalcIndexer();
	}
}
