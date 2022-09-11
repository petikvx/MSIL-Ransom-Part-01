using System;

namespace NAudio.Dmo;

internal struct DmoPartialMediaType
{
	private Guid type;

	private Guid subtype;

	public Guid Type
	{
		get
		{
			return type;
		}
		internal set
		{
			type = value;
		}
	}

	public Guid Subtype
	{
		get
		{
			return subtype;
		}
		internal set
		{
			subtype = value;
		}
	}
}
