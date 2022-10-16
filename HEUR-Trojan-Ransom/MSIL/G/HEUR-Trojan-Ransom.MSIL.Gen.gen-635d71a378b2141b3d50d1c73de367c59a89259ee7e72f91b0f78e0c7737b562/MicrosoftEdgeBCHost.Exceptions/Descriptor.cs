using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class Descriptor
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Descriptor()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteCode()
	{
	}
}
