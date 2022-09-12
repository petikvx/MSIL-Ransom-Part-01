namespace davidharim;

public class davidharim
{
	public string file_Ext;

	public davidharim()
	{
		file_Ext = ".doc|834".Split(new char[1] { '|' })[0];
	}
}
