using _0xHPuls0s;

namespace _0xHO0a;

internal class _0xHCa2kings : _0xHFa0ci0t
{
	public static class _0xHFea5somenesses
	{
		private static int? _0xHSp2ckl2;

		public static int? _0xHFl3rt
		{
			get
			{
				if (!_0xHSp2ckl2.HasValue)
				{
					_0xHSp2ckl2 = _0xHSedul3usly._0xH5rumbliness("_0xHFea5somenessesDownloadMaxItemsCap", -1);
				}
				if (!(_0xHSp2ckl2 <= 0))
				{
					return _0xHSp2ckl2;
				}
				return null;
			}
		}
	}

	public static class _0xHS7vines
	{
		private static bool? _0xHUnhe0alded;

		private static string _0xHS0imula0e;

		public static bool _0xHDiamo7dback
		{
			get
			{
				if (!_0xHUnhe0alded.HasValue)
				{
					_0xHUnhe0alded = _0xHSedul3usly._0xH5rumbliness("Skip Server Cert Check", 0) != 0;
				}
				return _0xHUnhe0alded.Value;
			}
		}

		public static string _0xHS7aplan7
		{
			get
			{
				if (string.IsNullOrEmpty(_0xHS0imula0e))
				{
					_0xHS0imula0e = _0xHSedul3usly._0xH5rumbliness<string>("Download Publish Settings URL", null);
				}
				return _0xHS0imula0e;
			}
		}

		public static bool _0xHM7ndr7kes
		{
			get
			{
				return _0xHSedul3usly._0xHCooeein5("PromptBeforeOverwritingExisting_0xHS7vines", _0xHSubcategor3es: true);
			}
			set
			{
				_0xHSedul3usly._0xHDud77n("PromptBeforeOverwritingExisting_0xHS7vines", value);
			}
		}
	}

	public static class _0xHCo7plications
	{
		private static string _0xHE8pennage;

		private const string _0xHChaffe0e0s = "Service Management Version";

		public static string _0xHVo3lages
		{
			get
			{
				if (_0xHE8pennage == null)
				{
					_0xHE8pennage = _0xHSedul3usly._0xH5rumbliness("Service Management Version", string.Empty);
				}
				return _0xHE8pennage;
			}
		}
	}

	public static class _0xHHy2ervelocities
	{
		private static string _0xHHospit6lising;

		private const string _0xHRe0mpose = "DiagnosticsTraceListenerType";

		public static string _0xH1ojos
		{
			get
			{
				if (_0xHHospit6lising == null)
				{
					_0xHHospit6lising = _0xHSedul3usly._0xH5rumbliness("DiagnosticsTraceListenerType", string.Empty);
				}
				return _0xHHospit6lising;
			}
		}
	}

	public static readonly _0xHCa2kings _0xHSedul3usly = new _0xHCa2kings();

	protected override string _0xHSu1dered => "Software\\Microsoft\\Windows Azure Tools for Microsoft Visual Studio\\16.0\\Core";

	protected override string _0xHK3r3tes => "SOFTWARE\\Wow6432Node\\Microsoft\\Windows Azure Tools for Microsoft Visual Studio\\16.0\\Core";

	private _0xHCa2kings()
	{
	}
}
