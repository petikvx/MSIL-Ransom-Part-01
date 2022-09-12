using Microsoft.VisualStudio.Debugger.Interop;

namespace Microsoft.Kofe.Engine;

internal class E0CF23B5F : IDebugExpression2
{
	private ADB5C0658 AD3BA1CA6;

	private B92FAA9B7 A635D843A;

	public E0CF23B5F(ADB5C0658 exp, B92FAA9B7 engine)
	{
		AD3BA1CA6 = exp;
		A635D843A = engine;
	}

	private int EA50FA42B()
	{
		return 0;
	}

	private int B24C66D8B(enum_EVALFLAGS DF5E96BB3, IDebugEventCallback2 C29B61DD8)
	{
		BF602D4D0.E0EE62C88 = A635D843A.C826EF455();
		AD3BA1CA6.B6FE9B085();
		C3BBB6305 result = new C3BBB6305(AD3BA1CA6);
		AEC97BDC1 c0EFB72BE = new AEC97BDC1((IDebugExpression2)(object)this, (IDebugProperty2)(object)result);
		A635D843A.F4F01CC92.A66BFCA0B((IDebugEvent2)(object)c0EFB72BE, "c0e13a85-238a-4800-8315-d947c960a843", (IDebugProgram2)(object)A635D843A, (IDebugThread2)(object)(FE8030C1E)AD3BA1CA6.E41D59FB7.get_Client());
		return 0;
	}

	private int BE992B9B7(enum_EVALFLAGS B46B7E156, uint B3ECC9BAC, IDebugEventCallback2 CBA2A8B16, out IDebugProperty2 B67388C2C)
	{
		BF602D4D0.E0EE62C88 = A635D843A.C826EF455();
		AD3BA1CA6.B6FE9B085();
		B67388C2C = (IDebugProperty2)(object)new C3BBB6305(AD3BA1CA6);
		return 0;
	}
}
