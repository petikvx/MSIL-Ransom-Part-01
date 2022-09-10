using System.Security.Policy;

namespace Caspol;

internal delegate void CodeGroupAttributeHandler(CodeGroup group, string[] args, int index, out int offset);
