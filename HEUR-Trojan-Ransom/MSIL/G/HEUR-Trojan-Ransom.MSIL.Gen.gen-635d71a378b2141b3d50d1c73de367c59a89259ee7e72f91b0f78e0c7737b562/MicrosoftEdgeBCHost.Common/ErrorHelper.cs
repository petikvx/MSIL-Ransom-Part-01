using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ErrorHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ErrorHelper()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveLiteralCreator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveLiteralCreator()
	{
	}
}
