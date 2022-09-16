namespace Spatula2;

public interface IJavaProcess
{
	int GetId();

	bool Start(string mainClass, int jvmPort);

	bool Terminate();
}
