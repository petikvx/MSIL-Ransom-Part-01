using System;
using System.Runtime.InteropServices;

namespace PreEmptive.Analytics.Common;

public interface IAsyncProvider
{
	void ExecuteAsyncIfSupported(Action action, [Optional] bool highPriority);
}
