using System;
using System.Resources;
using Microsoft.Cct.Services;
using _0xHChlo4ofo4ms;

namespace _0xHChan6ries;

internal static class _0xHP4ea44ange
{
	internal static string _0xHN6tur6lize(this WatError _0xHTa8cky)
	{
		string result = string.Empty;
		try
		{
			result = ErrorResources.ResourceManager.GetString(((object)(WatError)(ref _0xHTa8cky)).ToString(), ErrorResources.Culture);
			return result;
		}
		catch (MissingManifestResourceException)
		{
			return result;
		}
		catch (Exception)
		{
			return result;
		}
	}
}
