using System.Linq;
using Renci.SshNet;

namespace MySql.Data.Common;

internal class Ssh
{
	private bool _isXProtocol;

	private uint _port;

	private string _server;

	private string _sshHostName;

	private string _sshKeyFile;

	private string _sshPassphrase;

	private string _sshPassword;

	private uint _sshPort;

	private string _sshUserName;

	internal Ssh(string sshHostName, string sshUserName, string sshPassword, string sshKeyFile, string sshPassphrase, uint sshPort, string server, uint port, bool isXProtocol)
	{
		_sshHostName = sshHostName;
		_sshUserName = sshUserName;
		_sshPassword = sshPassword;
		_sshKeyFile = sshKeyFile;
		_sshPassphrase = sshPassphrase;
		_sshPort = sshPort;
		_server = server;
		_port = port;
		_isXProtocol = isXProtocol;
	}

	internal void StartClient()
	{
		MySqlSshClientManager.SetupSshClient(_sshHostName, _sshUserName, _sshPassword, _sshKeyFile, _sshPassphrase, _sshPort, _server, _port, _isXProtocol);
	}

	internal void StopClient()
	{
		SshClient currentSshClient = MySqlSshClientManager.CurrentSshClient;
		if (currentSshClient != null && currentSshClient.IsConnected)
		{
			currentSshClient.ForwardedPorts.First().Stop();
			currentSshClient.Disconnect();
		}
	}
}
