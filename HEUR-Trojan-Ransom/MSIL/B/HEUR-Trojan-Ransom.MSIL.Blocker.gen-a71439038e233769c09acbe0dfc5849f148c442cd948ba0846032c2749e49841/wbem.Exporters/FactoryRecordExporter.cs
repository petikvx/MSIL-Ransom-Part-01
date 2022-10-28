namespace wbem.Exporters;

internal interface FactoryRecordExporter<T>
{
	void StopDispatcher(T last);

	void InstantiateDispatcher();

	T TestDispatcher();
}
