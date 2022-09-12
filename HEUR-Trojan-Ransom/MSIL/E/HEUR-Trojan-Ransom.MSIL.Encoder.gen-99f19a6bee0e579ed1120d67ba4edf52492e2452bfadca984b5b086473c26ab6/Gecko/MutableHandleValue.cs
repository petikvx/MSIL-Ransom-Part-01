namespace Gecko;

internal struct MutableHandleValue
{
	private ulong _ptr;

	public ulong Handle => _ptr;

	public MutableHandleValue(ulong ptr)
	{
		_ptr = ptr;
	}
}
