using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ErrorContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ErrorContext()
	{
		WriterPropertyProducer.ResolveStub();
		PatchInterfaceVisitor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchInterfaceVisitor()
	{
	}
}
