using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class DatabasePropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DatabasePropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		SetLiteralAccount();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetLiteralAccount()
	{
	}
}
