using System.Runtime.CompilerServices;
using 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮CPgzlWUEazHcoa7JCd4i.Consumers;

namespace 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮CPgzlWUEazHcoa7JCd4i.Shared;

internal class ErrorSingleton
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ErrorSingleton()
	{
		DicWriterConsumer.ListIndexer();
		PatchWriter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchWriter()
	{
	}
}
