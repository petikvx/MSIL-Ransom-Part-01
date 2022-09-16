using System;
using System.Runtime.Serialization;

namespace _0xHDo22house;

[Serializable]
public class _0xHVi0rified : Exception
{
	public _0xHVi0rified()
	{
	}

	public _0xHVi0rified(string message)
		: base(message)
	{
	}

	public _0xHVi0rified(string message, Exception inner)
		: base(message, inner)
	{
	}

	protected _0xHVi0rified(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
