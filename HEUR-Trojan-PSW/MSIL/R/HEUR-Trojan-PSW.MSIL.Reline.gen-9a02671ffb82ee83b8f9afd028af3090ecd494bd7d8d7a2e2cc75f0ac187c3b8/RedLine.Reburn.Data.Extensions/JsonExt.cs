using System.Web.Script.Serialization;

namespace RedLine.Reburn.Data.Extensions;

public static class JsonExt
{
	private static JavaScriptSerializer json;

	public static JavaScriptSerializer JSON
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = json;
			if (obj == null)
			{
				JavaScriptSerializer val = new JavaScriptSerializer();
				obj = (object)val;
				json = val;
			}
			return (JavaScriptSerializer)obj;
		}
	}

	public static T FromJSON<T>(this string @this) where T : class
	{
		try
		{
			return JSON.Deserialize<T>(@this.Trim());
		}
		catch
		{
			return null;
		}
	}

	public static string ToJSON(this object @this)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return new JavaScriptSerializer().Serialize(@this);
	}
}
