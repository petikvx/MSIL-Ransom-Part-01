using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ClientValException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClientValException()
	{
		WriterPropertyProducer.ResolveStub();
		SetupSetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupSetter()
	{
	}
}
