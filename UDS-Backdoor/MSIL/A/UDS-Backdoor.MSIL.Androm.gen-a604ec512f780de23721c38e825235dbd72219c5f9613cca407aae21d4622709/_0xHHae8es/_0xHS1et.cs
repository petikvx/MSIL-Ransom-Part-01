using System;
using System.Threading;
using Microsoft.Cct.Services;
using Microsoft.VisualStudio.WindowsAzure;
using _0xHDisrespec3ing;
using _0xHS3ashed;

namespace _0xHHae8es;

internal class _0xHS1et : IMessageBoxService
{
	private IServiceProvider _0xHGasifie7;

	private object _0xHSe2i2icro = new object();

	public _0xHS1et(IServiceProvider serviceProvider)
	{
		_0xHGasifie7 = Arguments.ValidateNotNull<IServiceProvider>(serviceProvider, "serviceProvider");
	}

	public void _0xH6onductance(string _0xHD1parts)
	{
		if (Monitor.TryEnter(_0xHSe2i2icro))
		{
			try
			{
				_0xHCol8cky._0xH7eltzer(_0xHGasifie7, _0xHD1parts);
			}
			finally
			{
				Monitor.Exit(_0xHSe2i2icro);
			}
		}
	}

	public void _0xHLen6t6es(WatError _0xHYell6whammer, params object[] _0xHFlum4ed)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		_0xHCol8cky._0xHPai6ed(_0xHGasifie7, _0xHYell6whammer, _0xHFlum4ed);
	}
}
