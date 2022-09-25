using System.Text;

namespace SimpleJSON;

public class JSONString : JSONNode
{
	private string m_Data;

	public override JSONNodeType Tag => JSONNodeType.String;

	public override bool IsString => true;

	public override string Value
	{
		get
		{
			return m_Data;
		}
		set
		{
			m_Data = value;
		}
	}

	public override Enumerator GetEnumerator()
	{
		return default(Enumerator);
	}

	public JSONString(string aData)
	{
		m_Data = aData;
	}

	public override JSONNode Clone()
	{
		return new JSONString(m_Data);
	}

	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
	{
		aSB.Append('"').Append(JSONNode.Escape(m_Data)).Append('"');
	}

	public override bool Equals(object obj)
	{
		if (base.Equals(obj))
		{
			return true;
		}
		if (obj is string text)
		{
			return m_Data == text;
		}
		JSONString jSONString = obj as JSONString;
		if (jSONString != null)
		{
			return m_Data == jSONString.m_Data;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return m_Data.GetHashCode();
	}
}
