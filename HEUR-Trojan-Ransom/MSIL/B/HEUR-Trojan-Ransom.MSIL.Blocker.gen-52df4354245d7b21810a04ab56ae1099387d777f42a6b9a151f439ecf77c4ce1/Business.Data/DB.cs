using System;

namespace Business.Data;

public class DB<IConnection> : DataBase<IConnection> where IConnection : class, Business.Data.IConnection
{
	private readonly Func<IConnection> creat;

	public DB(Func<IConnection> creat)
	{
		this.creat = creat;
	}

	public override IConnection GetConnection()
	{
		return creat();
	}

	public static DB<IConnection> Creat(Func<IConnection> creat)
	{
		return new DB<IConnection>(creat);
	}
}
