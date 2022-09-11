using System.Collections.Generic;

namespace PreEmptive.Analytics.Common;

public interface IXMLTransmitter
{
	bool Post(IEnumerable<KeyValuePair<string, string>> headers, string data);
}
