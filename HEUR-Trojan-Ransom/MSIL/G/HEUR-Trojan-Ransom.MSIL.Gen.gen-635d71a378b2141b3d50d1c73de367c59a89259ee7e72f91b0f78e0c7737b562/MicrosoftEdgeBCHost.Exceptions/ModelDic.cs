using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ModelDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ModelDic()
	{
		WriterPropertyProducer.ResolveStub();
		RateLiteralStub();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateLiteralStub()
	{
	}
}
