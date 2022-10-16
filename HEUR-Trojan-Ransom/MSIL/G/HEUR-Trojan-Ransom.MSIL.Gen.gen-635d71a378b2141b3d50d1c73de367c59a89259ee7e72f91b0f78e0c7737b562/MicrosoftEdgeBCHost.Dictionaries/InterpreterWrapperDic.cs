using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class InterpreterWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterpreterWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeIterator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeIterator()
	{
	}
}
