using System.Collections.Generic;
using Di0ette;
using Fr7nt7n;
using G3amma3ians;
using Pentoxi5e;
using Premedie6al;
using Salva4er;
using Schi7ophrenias;
using Zecchino7;
using ns0;
using ns1;

namespace ns3;

public interface IJDbg
{
	void Initialize(Dictionary<string, bool> exceptionSettings, string exceptionCategoryName);

	void Attach(string hostname, int port, IEngineCallback callback);

	void Close();

	void CauseBreak();

	void Continue();

	void Execute();

	void ResumeThread(IJdwpThread thread);

	IJdwpThread[] GetThreads();

	IJdwpClass[] GetClasses();

	IJdwpClass GetClass(long id);

	IJdwpClass GetClass(string name);

	IJdwpClass[] GetClasses(string sourceFile);

	IJdwpStackFrame[] GetStackFrames(IJdwpThread thread);

	IJdwpStackFrame GetTopStackFrame(IJdwpThread thread);

	void SetBreakpoint(IJdwpCodeLocation location, object boundBreakpoint);

	void RemoveBreakpoint(IJdwpCodeLocation location, object boundBreakpoint);

	void Step(IJdwpThread thread, Lut8.Se4blable size, Lut8.Rela4es depth);

	void ClearExceptionSettings();

	void SetException(string exceptionName, bool breakOnFirstChance);

	IJdwpReferenceType GetReferenceType(long objectId);

	IJdwpValue[] GetVariableValues(IJdwpThread thread, IJdwpStackFrame stackFrame, IJdwpVariable[] variables);

	IJdwpReferenceType GetObjectType(long objectId, out Go2ge2 kind);

	IJdwpValue[] GetInstanceValues(long objectId, long[] fieldIds);

	string GetStringValue(long id);

	IJdwpValue[] GetArrayValues(long objectId, int first, int length);

	int GetArrayLength(long objectId);

	void SetDebugPackage(string packageName);
}
