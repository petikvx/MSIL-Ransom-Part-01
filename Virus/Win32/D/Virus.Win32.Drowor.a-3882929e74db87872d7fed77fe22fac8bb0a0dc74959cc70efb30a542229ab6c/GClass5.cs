using System.IO;
using System.IO.IsolatedStorage;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Permissions;

[IsolatedStorageFilePermission(SecurityAction.Demand)]
public class GClass5
{
	public static readonly GClass5 gclass5_0 = new GClass5();

	private IsolatedStorageFile isolatedStorageFile_0;

	private GClass4 gclass4_0;

	[SpecialName]
	public GClass4 method_0()
	{
		return gclass4_0;
	}

	private GClass5()
	{
		isolatedStorageFile_0 = IsolatedStorageFile.GetUserStoreForAssembly();
		method_1();
	}

	private void method_1()
	{
		gclass4_0 = method_2();
	}

	private GClass4 method_2()
	{
		string[] fileNames = isolatedStorageFile_0.GetFileNames("csConfig.bin");
		if (fileNames.Length == 0)
		{
			method_3();
		}
		IsolatedStorageFileStream isolatedStorageFileStream = new IsolatedStorageFileStream("csConfig.bin", FileMode.Open, isolatedStorageFile_0);
		BinaryFormatter binaryFormatter = new BinaryFormatter();
		GClass4 result = (GClass4)binaryFormatter.Deserialize(isolatedStorageFileStream);
		isolatedStorageFileStream.Close();
		return result;
	}

	public void method_3()
	{
		IsolatedStorageFileStream isolatedStorageFileStream = new IsolatedStorageFileStream("csConfig.bin", FileMode.Create, isolatedStorageFile_0);
		BinaryFormatter binaryFormatter = new BinaryFormatter();
		binaryFormatter.Serialize(isolatedStorageFileStream, gclass4_0 ?? new GClass4());
		isolatedStorageFileStream.Close();
	}
}
