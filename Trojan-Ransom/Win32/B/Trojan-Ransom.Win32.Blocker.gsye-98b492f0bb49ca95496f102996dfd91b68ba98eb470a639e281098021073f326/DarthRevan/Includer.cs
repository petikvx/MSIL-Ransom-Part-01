namespace DarthRevan;

public class Includer
{
	public static void Append(byte[] Data)
	{
		DataContainer.MS.Write(Data, 0, Data.Length);
	}

	public static void Finish()
	{
		DataContainer.Data = DataContainer.MS.ToArray();
	}
}
