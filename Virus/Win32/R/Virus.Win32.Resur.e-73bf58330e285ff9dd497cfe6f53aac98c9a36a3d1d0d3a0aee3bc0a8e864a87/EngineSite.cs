using Microsoft.Vsa;

internal class EngineSite : IVsaSite
{
	private CompilerOptions options;

	public EngineSite(CompilerOptions options)
	{
		this.options = options;
	}

	public virtual bool OnCompilerError(IVsaError error)
	{
		int severity = error.get_Severity();
		if (severity > options.nWarningLevel)
		{
			return true;
		}
		bool fIsWarning = severity != 0 && !options.fTreatWarningsAsErrors;
		JScriptCompiler.PrintError(error.get_SourceMoniker(), error.get_Line(), error.get_StartColumn(), fIsWarning, error.get_Number(), error.get_Description());
		return true;
	}

	public virtual object GetItemInfo(string strItemName)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new VsaException((VsaError)(-2146226168));
	}

	public virtual object GetGlobalInstance(string name)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new VsaException((VsaError)(-2146226168));
	}

	public virtual object GetEventSourceInstance(string ItemName, string EventSourceName)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new VsaException((VsaError)(-2146226168));
	}

	public virtual void Notify(string notification, object value)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new VsaException((VsaError)(-2146226168));
	}

	public virtual void GetCompiledState(out byte[] pe, out byte[] debugInfo)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		pe = null;
		debugInfo = null;
		throw new VsaException((VsaError)(-2146226168));
	}
}
