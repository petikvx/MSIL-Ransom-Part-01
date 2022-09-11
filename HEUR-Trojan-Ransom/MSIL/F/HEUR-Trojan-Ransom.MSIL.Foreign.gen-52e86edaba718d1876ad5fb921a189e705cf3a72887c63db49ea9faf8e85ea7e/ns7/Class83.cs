using MySql.Data.MySqlClient;
using ns11;

namespace ns7;

internal abstract class Class83
{
	protected MySqlConnectionStringBuilder mySqlConnectionStringBuilder_0;

	public Class83(MySqlConnectionStringBuilder mySqlConnectionStringBuilder_1)
	{
		mySqlConnectionStringBuilder_0 = mySqlConnectionStringBuilder_1;
	}

	public virtual MySqlConnectionStringBuilder vmethod_0()
	{
		return mySqlConnectionStringBuilder_0;
	}

	public abstract MySqlConnectionStringBuilder vmethod_1(Enum27 enum27_0);
}
