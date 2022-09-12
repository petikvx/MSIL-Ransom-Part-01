using System.Collections;
using System.Collections.Generic;

namespace Gecko.Collections;

public interface IDomHtmlCollection<TGeckoNode> : IEnumerable<TGeckoNode>, IGeckoArray<TGeckoNode>, IEnumerable
{
	TGeckoNode this[string name] { get; }
}
