using System.Runtime.CompilerServices;

namespace 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮CPgzlWUEazHcoa7JCd4i.Consumers;

internal class InvocationSingleton
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InvocationSingleton()
	{
		DicWriterConsumer.ListIndexer();
		RunCustomer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunCustomer()
	{
	}
}
