using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace DevDefined.OAuth.Framework;

[Serializable]
public class OAuthContext : IConsumer, IToken, IOAuthContext
{
	private readonly BoundParameter _bodyHash;

	private readonly BoundParameter _callbackUrl;

	private readonly BoundParameter _consumerKey;

	private readonly BoundParameter _nonce;

	private readonly BoundParameter _sessionHandle;

	private readonly BoundParameter _signature;

	private readonly BoundParameter _signatureMethod;

	private readonly BoundParameter _timestamp;

	private readonly BoundParameter _token;

	private readonly BoundParameter _tokenSecret;

	private readonly BoundParameter _verifier;

	private readonly BoundParameter _version;

	private readonly BoundParameter _xAuthMode;

	private readonly BoundParameter _xAuthUsername;

	private readonly BoundParameter _xAuthPassword;

	private NameValueCollection _authorizationHeaderParameters;

	private NameValueCollection _cookies;

	private NameValueCollection _formEncodedParameters;

	private NameValueCollection _headers;

	private string _normalizedRequestUrl;

	private NameValueCollection _queryParameters;

	private Uri _rawUri;

	public NameValueCollection Headers
	{
		get
		{
			if (_headers == null)
			{
				_headers = new NameValueCollection();
			}
			return _headers;
		}
		set
		{
			_headers = value;
		}
	}

	public NameValueCollection QueryParameters
	{
		get
		{
			if (_queryParameters == null)
			{
				_queryParameters = new NameValueCollection();
			}
			return _queryParameters;
		}
		set
		{
			_queryParameters = value;
		}
	}

	public NameValueCollection Cookies
	{
		get
		{
			if (_cookies == null)
			{
				_cookies = new NameValueCollection();
			}
			return _cookies;
		}
		set
		{
			_cookies = value;
		}
	}

	public NameValueCollection FormEncodedParameters
	{
		get
		{
			if (_formEncodedParameters == null)
			{
				_formEncodedParameters = new NameValueCollection();
			}
			return _formEncodedParameters;
		}
		set
		{
			_formEncodedParameters = value;
		}
	}

	public NameValueCollection AuthorizationHeaderParameters
	{
		get
		{
			if (_authorizationHeaderParameters == null)
			{
				_authorizationHeaderParameters = new NameValueCollection();
			}
			return _authorizationHeaderParameters;
		}
		set
		{
			_authorizationHeaderParameters = value;
		}
	}

	public byte[] RawContent { get; set; }

	public string RawContentType { get; set; }

	public Uri RawUri
	{
		get
		{
			return _rawUri;
		}
		set
		{
			_rawUri = value;
			NameValueCollection nameValueCollection = HttpUtility.ParseQueryString(_rawUri.Query);
			foreach (string item in nameValueCollection)
			{
				QueryParameters[item] = nameValueCollection[item];
			}
			_normalizedRequestUrl = UriUtility.NormalizeUri(_rawUri);
		}
	}

	public string NormalizedRequestUrl => _normalizedRequestUrl;

	public string RequestMethod { get; set; }

	public bool IncludeOAuthRequestBodyHashInSignature { get; set; }

	public string Nonce
	{
		get
		{
			return _nonce.Value;
		}
		set
		{
			_nonce.Value = value;
		}
	}

	public string Verifier
	{
		get
		{
			return _verifier.Value;
		}
		set
		{
			_verifier.Value = value;
		}
	}

	public string SessionHandle
	{
		get
		{
			return _sessionHandle.Value;
		}
		set
		{
			_sessionHandle.Value = value;
		}
	}

	public string CallbackUrl
	{
		get
		{
			return _callbackUrl.Value;
		}
		set
		{
			_callbackUrl.Value = value;
		}
	}

	public string Signature
	{
		get
		{
			return _signature.Value;
		}
		set
		{
			_signature.Value = value;
		}
	}

	public string SignatureMethod
	{
		get
		{
			return _signatureMethod.Value;
		}
		set
		{
			_signatureMethod.Value = value;
		}
	}

	public string Timestamp
	{
		get
		{
			return _timestamp.Value;
		}
		set
		{
			_timestamp.Value = value;
		}
	}

	public string BodyHash
	{
		get
		{
			return _bodyHash.Value;
		}
		set
		{
			_bodyHash.Value = value;
		}
	}

	public string Version
	{
		get
		{
			return _version.Value;
		}
		set
		{
			_version.Value = value;
		}
	}

	public bool UseAuthorizationHeader { get; set; }

	public string Realm
	{
		get
		{
			return AuthorizationHeaderParameters["realm"];
		}
		set
		{
			AuthorizationHeaderParameters["realm"] = value;
		}
	}

	public string ConsumerKey
	{
		get
		{
			return _consumerKey.Value;
		}
		set
		{
			_consumerKey.Value = value;
		}
	}

	public string Token
	{
		get
		{
			return _token.Value;
		}
		set
		{
			_token.Value = value;
		}
	}

	public string TokenSecret
	{
		get
		{
			return _tokenSecret.Value;
		}
		set
		{
			_tokenSecret.Value = value;
		}
	}

	public string XAuthMode
	{
		get
		{
			return _xAuthMode.Value;
		}
		set
		{
			_xAuthMode.Value = value;
		}
	}

	public string XAuthUsername
	{
		get
		{
			return _xAuthUsername.Value;
		}
		set
		{
			_xAuthUsername.Value = value;
		}
	}

	public string XAuthPassword
	{
		get
		{
			return _xAuthPassword.Value;
		}
		set
		{
			_xAuthPassword.Value = value;
		}
	}

	public OAuthContext()
	{
		_verifier = new BoundParameter("oauth_verifier", this);
		_consumerKey = new BoundParameter("oauth_consumer_key", this);
		_callbackUrl = new BoundParameter("oauth_callback", this);
		_nonce = new BoundParameter("oauth_nonce", this);
		_signature = new BoundParameter("oauth_signature", this);
		_signatureMethod = new BoundParameter("oauth_signature_method", this);
		_timestamp = new BoundParameter("oauth_timestamp", this);
		_token = new BoundParameter("oauth_token", this);
		_tokenSecret = new BoundParameter("oauth_token_secret", this);
		_version = new BoundParameter("oauth_version", this);
		_sessionHandle = new BoundParameter("oauth_session_handle", this);
		_bodyHash = new BoundParameter("oauth_body_hash", this);
		_xAuthUsername = new BoundParameter("x_auth_username", this);
		_xAuthPassword = new BoundParameter("x_auth_password", this);
		_xAuthMode = new BoundParameter("x_auth_mode", this);
		FormEncodedParameters = new NameValueCollection();
		Cookies = new NameValueCollection();
		Headers = new NameValueCollection();
		AuthorizationHeaderParameters = new NameValueCollection();
	}

	public Uri GenerateUri()
	{
		UriBuilder uriBuilder = new UriBuilder(NormalizedRequestUrl);
		IEnumerable<KeyValuePair<string, string>> parameters = QueryParameters.ToQueryParametersExcludingTokenSecret();
		uriBuilder.Query = UriUtility.FormatQueryString(parameters);
		return uriBuilder.Uri;
	}

	public string GenerateUrl()
	{
		UriBuilder uriBuilder = new UriBuilder(NormalizedRequestUrl);
		uriBuilder.Query = "";
		return string.Concat(uriBuilder.Uri, "?", UriUtility.FormatQueryString(QueryParameters));
	}

	public string GenerateOAuthParametersForHeader()
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (Realm != null)
		{
			stringBuilder.Append("realm=\"").Append(Realm).Append("\"");
		}
		IEnumerable<KeyValuePair<string, string>> source = AuthorizationHeaderParameters.ToQueryParametersExcludingTokenSecret();
		foreach (KeyValuePair<string, string> item in source.Where((KeyValuePair<string, string> p) => p.Key != "realm"))
		{
			if (stringBuilder.Length > 0)
			{
				stringBuilder.Append(",");
			}
			stringBuilder.Append(UriUtility.UrlEncode(item.Key)).Append("=\"").Append(UriUtility.UrlEncode(item.Value))
				.Append("\"");
		}
		stringBuilder.Insert(0, "OAuth ");
		return stringBuilder.ToString();
	}

	public Uri GenerateUriWithoutOAuthParameters()
	{
		UriBuilder uriBuilder = new UriBuilder(NormalizedRequestUrl);
		IEnumerable<KeyValuePair<string, string>> parameters = from q in QueryParameters.ToQueryParameters()
			where !q.Key.StartsWith("oauth_") && !q.Key.StartsWith("x_auth_")
			select q;
		uriBuilder.Query = UriUtility.FormatQueryString(parameters);
		return uriBuilder.Uri;
	}

	public void GenerateAndSetBodyHash()
	{
		BodyHash = GenerateBodyHash();
	}

	public string GenerateBodyHash()
	{
		byte[] inArray = SHA1.Create().ComputeHash(RawContent ?? new byte[0]);
		return Convert.ToBase64String(inArray);
	}

	public string GenerateSignatureBase()
	{
		if (string.IsNullOrEmpty(ConsumerKey))
		{
			throw Error.MissingRequiredOAuthParameter(this, "oauth_consumer_key");
		}
		if (string.IsNullOrEmpty(SignatureMethod))
		{
			throw Error.MissingRequiredOAuthParameter(this, "oauth_signature_method");
		}
		if (string.IsNullOrEmpty(RequestMethod))
		{
			throw Error.RequestMethodHasNotBeenAssigned("RequestMethod");
		}
		if (IncludeOAuthRequestBodyHashInSignature)
		{
			GenerateAndSetBodyHash();
		}
		List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
		if (FormEncodedParameters != null && RequestMethod == "POST")
		{
			list.AddRange(FormEncodedParameters.ToQueryParametersExcludingTokenSecret());
		}
		if (QueryParameters != null)
		{
			list.AddRange(QueryParameters.ToQueryParametersExcludingTokenSecret());
		}
		if (Cookies != null)
		{
			list.AddRange(Cookies.ToQueryParametersExcludingTokenSecret());
		}
		if (AuthorizationHeaderParameters != null)
		{
			list.AddRange(from q in AuthorizationHeaderParameters.ToQueryParametersExcludingTokenSecret()
				where q.Key != "realm"
				select q);
		}
		list.RemoveAll((KeyValuePair<string, string> param) => param.Key == "oauth_signature");
		return UriUtility.FormatParameters(RequestMethod, new Uri(NormalizedRequestUrl), list);
	}
}
