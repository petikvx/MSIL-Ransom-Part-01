using System;
using System.Xml;

namespace _0023qc;

internal class _0023Ge : IDisposable
{
	private readonly XmlWriter _0023a;

	public _0023Ge(XmlWriter _0023He, string _0023Cc)
	{
		_0023a = _0023He;
		_0023a.WriteStartElement(_0023Cc);
	}

	public void _0023U()
	{
		_0023a.WriteEndElement();
	}

	void IDisposable.Dispose()
	{
		//ILSpy generated this explicit interface implementation from .override directive in #U
		this._0023U();
	}
}
