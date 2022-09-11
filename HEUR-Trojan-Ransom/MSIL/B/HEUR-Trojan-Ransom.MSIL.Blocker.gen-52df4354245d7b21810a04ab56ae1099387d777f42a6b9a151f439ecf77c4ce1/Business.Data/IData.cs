namespace Business.Data;

public interface IData : IData2
{
	IConnection GetConnection();
}
