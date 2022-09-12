using System;

namespace Renci.SshNet;

public interface IForwardedPort
{
	event EventHandler Closing;
}
