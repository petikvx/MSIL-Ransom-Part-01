using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class DescriptorDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DescriptorDic()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatLiteralCallback();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatLiteralCallback()
	{
	}
}
