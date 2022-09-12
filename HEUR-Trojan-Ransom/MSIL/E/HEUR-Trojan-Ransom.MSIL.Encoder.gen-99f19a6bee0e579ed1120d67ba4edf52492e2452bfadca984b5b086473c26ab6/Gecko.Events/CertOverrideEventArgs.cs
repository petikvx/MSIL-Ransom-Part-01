using System.ComponentModel;
using Gecko.Certificates;

namespace Gecko.Events;

public sealed class CertOverrideEventArgs : HandledEventArgs
{
	private string _hostname;

	private int _port;

	private Certificate _certificate;

	public string Host => _hostname;

	public int Port => _port;

	public Certificate Certificate => _certificate;

	public CertOverride OverrideResult { get; set; }

	public bool Temporary { get; set; }

	public CertOverrideEventArgs(string hostname, int port, Certificate cert)
	{
		_certificate = cert;
		_hostname = hostname;
		_port = port;
	}
}
