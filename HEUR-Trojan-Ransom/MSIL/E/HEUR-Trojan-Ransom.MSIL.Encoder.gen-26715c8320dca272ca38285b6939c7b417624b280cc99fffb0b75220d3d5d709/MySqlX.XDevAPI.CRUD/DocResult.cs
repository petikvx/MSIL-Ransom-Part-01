using System.Collections.Generic;
using System.Text;
using MySqlX.Sessions;
using MySqlX.XDevAPI.Common;

namespace MySqlX.XDevAPI.CRUD;

public sealed class DocResult : BufferingResult<DbDoc>
{
	private Encoding _encoding = Encoding.UTF8;

	internal DocResult(InternalSession session)
		: base(session)
	{
	}

	protected override DbDoc ReadItem(bool dumping)
	{
		List<byte[]> list = base.Protocol.ReadRow(this);
		if (list == null)
		{
			return null;
		}
		return new DbDoc(_encoding.GetString(list[0]).TrimEnd(new char[1]));
	}
}
