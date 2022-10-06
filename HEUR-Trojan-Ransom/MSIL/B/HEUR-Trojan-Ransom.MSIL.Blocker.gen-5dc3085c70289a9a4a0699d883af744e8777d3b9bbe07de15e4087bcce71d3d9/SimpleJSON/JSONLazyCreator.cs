using System.Text;

namespace SimpleJSON;

internal class JSONLazyCreator : JSONNode
{
	private JSONNode m_Node = null;

	private string m_Key = null;

	public override JSONNodeType Tag => JSONNodeType.None;

	public override JSONNode this[int aIndex]
	{
		get
		{
			return new JSONLazyCreator(this);
		}
		set
		{
			Set(new JSONArray()).Add(value);
		}
	}

	public override JSONNode this[string aKey]
	{
		get
		{
			return new JSONLazyCreator(this, aKey);
		}
		set
		{
			Set(new JSONObject()).Add(aKey, value);
		}
	}

	public override int AsInt
	{
		get
		{
			Set(new JSONNumber(0.0));
			return 0;
		}
		set
		{
			Set(new JSONNumber(value));
		}
	}

	public override float AsFloat
	{
		get
		{
			Set(new JSONNumber(0.0));
			return 0f;
		}
		set
		{
			Set(new JSONNumber(value));
		}
	}

	public override double AsDouble
	{
		get
		{
			Set(new JSONNumber(0.0));
			return 0.0;
		}
		set
		{
			Set(new JSONNumber(value));
		}
	}

	public override long AsLong
	{
		get
		{
			if (JSONNode.longAsString)
			{
				Set(new JSONString("0"));
			}
			else
			{
				Set(new JSONNumber(0.0));
			}
			return 0L;
		}
		set
		{
			if (JSONNode.longAsString)
			{
				Set(new JSONString(value.ToString()));
			}
			else
			{
				Set(new JSONNumber(value));
			}
		}
	}

	public override bool AsBool
	{
		get
		{
			Set(new JSONBool(aData: false));
			return false;
		}
		set
		{
			Set(new JSONBool(value));
		}
	}

	public override JSONArray AsArray => Set(new JSONArray());

	public override JSONObject AsObject => Set(new JSONObject());

	public override Enumerator GetEnumerator()
	{
		return default(Enumerator);
	}

	public JSONLazyCreator(JSONNode aNode)
	{
		m_Node = aNode;
		m_Key = null;
	}

	public JSONLazyCreator(JSONNode aNode, string aKey)
	{
		m_Node = aNode;
		m_Key = aKey;
	}

	private T Set<T>(T aVal) where T : JSONNode
	{
		if (m_Key == null)
		{
			m_Node.Add(aVal);
		}
		else
		{
			m_Node.Add(m_Key, aVal);
		}
		m_Node = null;
		return aVal;
	}

	public override void Add(JSONNode aItem)
	{
		Set(new JSONArray()).Add(aItem);
	}

	public override void Add(string aKey, JSONNode aItem)
	{
		Set(new JSONObject()).Add(aKey, aItem);
	}

	public static bool operator ==(JSONLazyCreator a, object b)
	{
		if (b == null)
		{
			return true;
		}
		return (object)a == b;
	}

	public static bool operator !=(JSONLazyCreator a, object b)
	{
		return !(a == b);
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return true;
		}
		return (object)this == obj;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
	{
		aSB.Append("null");
	}
}
