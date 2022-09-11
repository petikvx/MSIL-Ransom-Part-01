using DevDefined.OAuth.Framework;

namespace DevDefined.OAuth.Provider.Inspectors;

public interface IContextInspector
{
	void InspectContext(ProviderPhase phase, IOAuthContext context);
}
