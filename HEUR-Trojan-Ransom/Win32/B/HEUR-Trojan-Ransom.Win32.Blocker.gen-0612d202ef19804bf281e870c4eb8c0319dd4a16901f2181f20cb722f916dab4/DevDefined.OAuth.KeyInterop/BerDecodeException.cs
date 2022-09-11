using System;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Text;

namespace DevDefined.OAuth.KeyInterop;

[Serializable]
public sealed class BerDecodeException : Exception
{
	private readonly int m_position;

	public int Position => m_position;

	public override string Message
	{
		get
		{
			StringBuilder stringBuilder = new StringBuilder(base.Message);
			stringBuilder.AppendFormat(" (Position {0}){1}", m_position, Environment.NewLine);
			return stringBuilder.ToString();
		}
	}

	public BerDecodeException()
	{
	}

	public BerDecodeException(string message)
		: base(message)
	{
	}

	public BerDecodeException(string message, Exception ex)
		: base(message, ex)
	{
	}

	public BerDecodeException(string message, int position)
		: base(message)
	{
		m_position = position;
	}

	public BerDecodeException(string message, int position, Exception ex)
		: base(message, ex)
	{
		m_position = position;
	}

	private BerDecodeException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
		m_position = info.GetInt32("Position");
	}

	[SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		base.GetObjectData(info, context);
		info.AddValue("Position", m_position);
	}
}
