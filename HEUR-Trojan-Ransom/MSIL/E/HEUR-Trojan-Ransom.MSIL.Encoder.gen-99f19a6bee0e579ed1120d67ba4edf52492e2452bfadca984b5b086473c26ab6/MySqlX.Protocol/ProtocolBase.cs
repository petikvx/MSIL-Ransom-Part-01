using System.Collections.Generic;
using MySqlX.XDevAPI.Common;
using MySqlX.XDevAPI.Relational;

namespace MySqlX.Protocol;

public abstract class ProtocolBase
{
	public abstract List<byte[]> ReadRow(BaseResult rs);

	public abstract void SendSQL(string sql, params object[] args);

	public abstract bool HasData(BaseResult rs);

	public abstract List<Column> LoadColumnMetadata();

	public abstract void CloseResult(BaseResult rs);
}
