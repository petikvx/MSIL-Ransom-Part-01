using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ExceptionHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExceptionHelper()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptLiteralCreator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptLiteralCreator()
	{
	}
}
