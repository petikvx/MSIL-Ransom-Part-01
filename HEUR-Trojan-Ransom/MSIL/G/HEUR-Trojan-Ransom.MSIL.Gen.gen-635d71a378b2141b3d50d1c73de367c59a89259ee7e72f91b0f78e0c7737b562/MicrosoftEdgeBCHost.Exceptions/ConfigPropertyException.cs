using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ConfigPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		PushLiteralOrder();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushLiteralOrder()
	{
	}
}
