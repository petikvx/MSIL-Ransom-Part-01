namespace Microsoft.Kofe.Engine;

internal interface ParentValue
{
	ADB5C0658[] GetChildValues(ADB5C0658 context);

	ADB5C0658 LookupName(string name, ADB5C0658 context);
}
