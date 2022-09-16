using System;
using System.Runtime.InteropServices;
using System.Security;
using _0xHAccelero7eter;
using _0xHG8stur8rs;

namespace _0xHE5faced;

[SuppressUnmanagedCodeSecurity]
internal static class _0xH7ozier
{
	[SuppressUnmanagedCodeSecurity]
	[SecurityCritical]
	internal static class _0xHR7sum7d
	{
		[SecurityCritical]
		internal unsafe delegate void _0xHAlburn4us([In] ref Guid sourceId, [In] int isEnabled, [In] byte level, [In] long matchAnyKeywords, [In] long matchAllKeywords, [In] _0xHCro3t* filterData, [In] void* callbackContext);

		internal struct _0xHCro3t
		{
			public long _0xHTritur0tion;

			public int _0xHMe6ory;

			public int _0xHPe1manencies;
		}

		internal enum _0xHDisb4rse : uint
		{
			EVENT_ACTIVITY_CTRL_GET_ID = 1u,
			EVENT_ACTIVITY_CTRL_SET_ID,
			EVENT_ACTIVITY_CTRL_CREATE_ID,
			EVENT_ACTIVITY_CTRL_GET_SET_ID,
			EVENT_ACTIVITY_CTRL_CREATE_SET_ID
		}

		internal enum _0xHC6bernetical
		{
			BinaryTrackInfo,
			SetEnableAllKeywords,
			SetTraits
		}

		internal const int _0xHCon6essa = 534;

		internal const int _0xHThr3ap3r = 8;

		internal const int _0xH5ardening = 234;

		internal const int _0xHT3tes = 50;

		internal const int _0xHG6rrotes = 87;

		internal const int _0xHWittine22e2 = 0;

		internal const int _0xHH2l2koth = 1;

		internal const int _0xHTesticu0ar = 2;

		[DllImport("advapi32.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
		[SecurityCritical]
		internal unsafe static extern uint EventRegister([In] ref Guid _0xHChall4s, [In] _0xHAlburn4us _0xHMu6th6, [In] void* _0xHGrandn4ss4s, [In][Out] ref long _0xHCarb8nylati8n);

		[DllImport("advapi32.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
		[SecurityCritical]
		internal static extern uint EventUnregister([In] long _0xHMallard4);

		internal unsafe static int _0xHM8cer(long _0xHRa0emes, ref _0xHMonocrac1es _0xHCo8lpit, Guid* _0xHInh0spitably, Guid* _0xHP1eemies, int _0xHOverlav6sh, _0xHRi3u3e3._0xHImme1sing* _0xHNay8ay8)
		{
			int num = EventWriteTransfer(_0xHRa0emes, ref _0xHCo8lpit, _0xHInh0spitably, _0xHP1eemies, _0xHOverlav6sh, _0xHNay8ay8);
			if (num == 87 && _0xHP1eemies == null)
			{
				Guid empty = Guid.Empty;
				num = EventWriteTransfer(_0xHRa0emes, ref _0xHCo8lpit, _0xHInh0spitably, &empty, _0xHOverlav6sh, _0xHNay8ay8);
			}
			return num;
		}

		[DllImport("advapi32.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		private unsafe static extern int EventWriteTransfer([In] long _0xH6ebuker, [In] ref _0xHMonocrac1es _0xHOsteo7lasti7, [In] Guid* _0xHMo7ybdous, [In] Guid* _0xHEnla2ge2s, [In] int _0xHShi3ting, [In] _0xHRi3u3e3._0xHImme1sing* _0xHIro0mo0ger);

		[DllImport("advapi32.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal static extern int EventActivityIdControl([In] _0xHDisb4rse _0xHLac6nes, [In][Out] ref Guid _0xHSkir4ed);

		[DllImport("advapi32.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
		[SuppressUnmanagedCodeSecurity]
		internal unsafe static extern int EventSetInformation([In] long _0xHMavo0rnins, [In] _0xHC6bernetical _0xHGa2trula2, [In] void* _0xHFe3l, [In] int _0xHAntihija0k);
	}

	private const string _0xHPutres0en0es = "advapi32.dll";

	private const string _0xHDo00ones = "advapi32.dll";
}
