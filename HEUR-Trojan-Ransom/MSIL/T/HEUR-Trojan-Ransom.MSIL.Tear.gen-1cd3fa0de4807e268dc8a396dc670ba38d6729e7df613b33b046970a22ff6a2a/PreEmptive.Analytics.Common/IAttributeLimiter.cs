namespace PreEmptive.Analytics.Common;

public interface IAttributeLimiter
{
	int? MaxSize(string tagname, string attribute);
}
