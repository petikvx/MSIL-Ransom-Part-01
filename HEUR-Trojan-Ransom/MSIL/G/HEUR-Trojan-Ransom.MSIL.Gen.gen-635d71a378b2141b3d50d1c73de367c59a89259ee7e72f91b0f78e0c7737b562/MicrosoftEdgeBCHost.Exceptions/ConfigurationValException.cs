using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ConfigurationValException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigurationValException()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteDecorator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteDecorator()
	{
	}
}
