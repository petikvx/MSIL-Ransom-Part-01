using System.Collections.Generic;
using G3amma3ians;
using Salva4er;
using ns1;

namespace ns0;

public interface IEngineCallback
{
	void OnModuleLoad(IJdwpClass module);

	void OnModuleUnload(IJdwpClass module);

	void OnThreadStart(IJdwpThread thread);

	void OnThreadExit(IJdwpThread thread, uint exitCode);

	void OnProcessExit(uint exitCode);

	void OnError(string message);

	void OnWarning(string message);

	void OnWriteLog(string message);

	void OnFirstChanceExceptionMessage(string message);

	void OnBreakpoint(IJdwpThread thread, List<object> clients, IJdwpCodeLocation location, bool checkConditions);

	void OnBreakpointError(object objErrorBreakpoint);

	void OnStepComplete(IJdwpThread thread);

	void OnDebugException(IJdwpThread thread, string exceptionName, string description, bool firstChance);

	void OnAsyncBreakComplete(IJdwpThread thread);

	void OnLoadComplete(IJdwpThread thread);

	void OnProgramDestroy(uint exitCode);

	void OnSymbolSearch(IJdwpClass module, string status, uint dwStatsFlags);

	void OnBreakpointBound(object objBoundBreakpoint, IJdwpCodeLocation location);
}
