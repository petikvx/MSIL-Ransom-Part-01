using System.Security.Policy;

namespace Microsoft.Tools.Caspol;

internal delegate void CodeGroupAttributeHandler(CodeGroup group, string[] args, int index, out int offset);
