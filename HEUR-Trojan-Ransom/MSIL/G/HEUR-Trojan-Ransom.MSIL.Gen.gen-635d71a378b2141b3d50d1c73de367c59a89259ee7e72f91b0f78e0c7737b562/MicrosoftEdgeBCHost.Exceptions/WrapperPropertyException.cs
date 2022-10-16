using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class WrapperPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WrapperPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		CollectLiteralSetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectLiteralSetter()
	{
	}
}
