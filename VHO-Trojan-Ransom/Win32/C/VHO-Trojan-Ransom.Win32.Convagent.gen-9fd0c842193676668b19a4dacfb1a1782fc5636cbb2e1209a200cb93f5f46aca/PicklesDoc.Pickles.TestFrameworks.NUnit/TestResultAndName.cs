using PicklesDoc.Pickles.ObjectModel;

namespace PicklesDoc.Pickles.TestFrameworks.NUnit;

public class TestResultAndName
{
	public string Name { get; }

	public TestResult TestResult { get; }

	public TestResultAndName(TestResult testResult, string name)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		Name = name;
		TestResult = testResult;
	}
}
