using System.Collections.Specialized;

namespace DevDefined.OAuth.Framework;

internal class BoundParameter
{
	private readonly OAuthContext _context;

	private readonly string _name;

	public string Value
	{
		get
		{
			if (_context.AuthorizationHeaderParameters[_name] != null)
			{
				return _context.AuthorizationHeaderParameters[_name];
			}
			if (_context.QueryParameters[_name] != null)
			{
				return _context.QueryParameters[_name];
			}
			if (_context.FormEncodedParameters[_name] != null)
			{
				return _context.FormEncodedParameters[_name];
			}
			return null;
		}
		set
		{
			if (value == null)
			{
				Collection.Remove(_name);
			}
			else
			{
				Collection[_name] = value;
			}
		}
	}

	private NameValueCollection Collection
	{
		get
		{
			if (_context.UseAuthorizationHeader)
			{
				return _context.AuthorizationHeaderParameters;
			}
			if (_context.RequestMethod == "GET")
			{
				return _context.QueryParameters;
			}
			return _context.FormEncodedParameters;
		}
	}

	public BoundParameter(string name, OAuthContext context)
	{
		_name = name;
		_context = context;
	}
}
