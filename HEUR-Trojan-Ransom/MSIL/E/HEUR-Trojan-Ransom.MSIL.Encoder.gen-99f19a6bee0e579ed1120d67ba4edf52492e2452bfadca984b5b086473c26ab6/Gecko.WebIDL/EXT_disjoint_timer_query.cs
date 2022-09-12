namespace Gecko.WebIDL;

public class EXT_disjoint_timer_query : WebIDLBase
{
	public EXT_disjoint_timer_query(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports CreateQueryEXT()
	{
		return CallMethod<nsISupports>("createQueryEXT", new object[0]);
	}

	public void DeleteQueryEXT(nsISupports query)
	{
		CallVoidMethod("deleteQueryEXT", query);
	}

	public bool IsQueryEXT(nsISupports query)
	{
		return CallMethod<bool>("isQueryEXT", new object[1] { query });
	}

	public void BeginQueryEXT(uint target, nsISupports query)
	{
		CallVoidMethod("beginQueryEXT", target, query);
	}

	public void EndQueryEXT(uint target)
	{
		CallVoidMethod("endQueryEXT", target);
	}

	public void QueryCounterEXT(nsISupports query, uint target)
	{
		CallVoidMethod("queryCounterEXT", query, target);
	}

	public object GetQueryEXT(uint target, uint pname)
	{
		return CallMethod<object>("getQueryEXT", new object[2] { target, pname });
	}

	public object GetQueryObjectEXT(nsISupports query, uint pname)
	{
		return CallMethod<object>("getQueryObjectEXT", new object[2] { query, pname });
	}
}
