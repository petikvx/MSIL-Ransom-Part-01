using System;
using System.Collections;
using System.Collections.Specialized;
using System.Net;

namespace OlLP4ANbrNNh;

internal interface Interface0
{
	ICredentialPolicy CredentialPolicy { get; set; }

	StringDictionary CustomTargetNameDictionary { get; }

	bool OsSupportsExtendedProtection { get; }

	bool SspSupportsExtendedProtection { get; }

	IEnumerator RegisteredModules { get; }

	void imethod_0();

	Authorization imethod_1(string string_0, WebRequest webRequest_0, ICredentials icredentials_0);

	Authorization imethod_2(WebRequest webRequest_0, ICredentials icredentials_0);

	void imethod_3(IAuthenticationModule iauthenticationModule_0);

	void imethod_4(IAuthenticationModule iauthenticationModule_0);

	void imethod_5(string string_0);

	void imethod_6(Uri uri_0, Authorization authorization_0, IAuthenticationModule iauthenticationModule_0);
}
