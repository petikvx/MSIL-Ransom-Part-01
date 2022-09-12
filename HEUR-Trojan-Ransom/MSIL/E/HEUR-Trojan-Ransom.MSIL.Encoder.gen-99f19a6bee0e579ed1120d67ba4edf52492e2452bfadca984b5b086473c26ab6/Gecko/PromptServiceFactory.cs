using System.Runtime.InteropServices;

namespace Gecko;

[ContractID("@mozilla.org/embedcomp/prompt-service;1")]
[Guid("8E4AABE2-B832-4cff-B213-2174DE2B818D")]
internal class PromptServiceFactory : GenericOneClassNsFactory<PromptServiceFactory, PromptService>
{
	public const string ContractID = "@mozilla.org/embedcomp/prompt-service;1";
}
