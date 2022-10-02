using System.Runtime.CompilerServices;
using 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮CPgzlWUEazHcoa7JCd4i.Consumers;

namespace 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮CPgzlWUEazHcoa7JCd4i.Shared;

internal class SingletonWriter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingletonWriter()
	{
		DicWriterConsumer.ListIndexer();
		DicWriterConsumer.CalcIndexer();
	}
}
