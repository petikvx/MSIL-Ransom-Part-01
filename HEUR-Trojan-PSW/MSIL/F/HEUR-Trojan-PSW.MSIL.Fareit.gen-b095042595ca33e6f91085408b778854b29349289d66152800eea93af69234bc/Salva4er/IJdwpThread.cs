namespace Salva4er;

public interface IJdwpThread
{
	long Id { get; set; }

	object Client { get; set; }

	string Name { get; set; }

	bool IsMainThread { get; set; }
}
