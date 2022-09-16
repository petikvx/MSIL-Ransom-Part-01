using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sa1es;

internal interface ITemplateWizardPipeline
{
	bool CanCreate { get; }

	IDictionary<string, string> ReplacementsDictionary { get; }

	Task<bool> TrySelectTemplate();

	Task<bool> TryCreateAsync();

	void SatisfyDemands();
}
