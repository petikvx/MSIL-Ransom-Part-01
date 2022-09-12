using System.Collections;

namespace Newtonsoft.Json.Utilities;

internal interface IWrappedCollection : IEnumerable, IList, ICollection
{
	object UnderlyingCollection { get; }
}
