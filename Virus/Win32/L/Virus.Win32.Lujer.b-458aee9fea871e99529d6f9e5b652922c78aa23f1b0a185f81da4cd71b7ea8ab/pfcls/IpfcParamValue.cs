using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace pfcls;

[ComImport]
[Guid("3387CB58-3F7B-3CB5-AC4B-68D18A0D0549")]
[CompilerGenerated]
[TypeIdentifier]
public interface IpfcParamValue
{
	[DispId(1610743813)]
	bool BoolValue
	{
		get; [param: In]
		set;
	}

	[DispId(1610743808)]
	int discr { get; }

	[DispId(1610743815)]
	double DoubleValue
	{
		get; [param: In]
		set;
	}

	[DispId(1610743811)]
	int IntValue
	{
		get; [param: In]
		set;
	}

	[DispId(1610743809)]
	string StringValue
	{
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}
}
