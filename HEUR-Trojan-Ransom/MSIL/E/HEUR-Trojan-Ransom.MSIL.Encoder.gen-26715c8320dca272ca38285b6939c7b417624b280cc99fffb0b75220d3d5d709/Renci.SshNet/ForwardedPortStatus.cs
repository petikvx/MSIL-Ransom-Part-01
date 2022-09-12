using System;
using System.Threading;

namespace Renci.SshNet;

internal class ForwardedPortStatus
{
	private readonly int _value;

	private readonly string _name;

	public static readonly ForwardedPortStatus Stopped = new ForwardedPortStatus(1, "Stopped");

	public static readonly ForwardedPortStatus Stopping = new ForwardedPortStatus(2, "Stopping");

	public static readonly ForwardedPortStatus Started = new ForwardedPortStatus(3, "Started");

	public static readonly ForwardedPortStatus Starting = new ForwardedPortStatus(4, "Starting");

	private ForwardedPortStatus(int value, string name)
	{
		_value = value;
		_name = name;
	}

	public override bool Equals(object other)
	{
		if (other == null)
		{
			return false;
		}
		if (this == other)
		{
			return true;
		}
		ForwardedPortStatus forwardedPortStatus = other as ForwardedPortStatus;
		if (forwardedPortStatus == null)
		{
			return false;
		}
		return forwardedPortStatus._value == _value;
	}

	public static bool operator ==(ForwardedPortStatus left, ForwardedPortStatus right)
	{
		return left?.Equals(right) ?? ((object)right == null);
	}

	public static bool operator !=(ForwardedPortStatus left, ForwardedPortStatus right)
	{
		return !(left == right);
	}

	public override int GetHashCode()
	{
		return _value;
	}

	public override string ToString()
	{
		return _name;
	}

	public static bool ToStopping(ref ForwardedPortStatus status)
	{
		ForwardedPortStatus forwardedPortStatus = Interlocked.CompareExchange(ref status, Stopping, Started);
		if (!(forwardedPortStatus == Stopping) && !(forwardedPortStatus == Stopped))
		{
			if (status == Stopping)
			{
				return true;
			}
			forwardedPortStatus = Interlocked.CompareExchange(ref status, Stopping, Starting);
			if (!(forwardedPortStatus == Stopping) && !(forwardedPortStatus == Stopped))
			{
				if (status == Stopping)
				{
					return true;
				}
				throw new InvalidOperationException($"Forwarded port cannot transition from '{forwardedPortStatus}' to '{Stopping}'.");
			}
			return false;
		}
		return false;
	}

	public static bool ToStarting(ref ForwardedPortStatus status)
	{
		ForwardedPortStatus forwardedPortStatus = Interlocked.CompareExchange(ref status, Starting, Stopped);
		if (!(forwardedPortStatus == Starting) && !(forwardedPortStatus == Started))
		{
			if (status == Starting)
			{
				return true;
			}
			throw new InvalidOperationException($"Forwarded port cannot transition from '{forwardedPortStatus}' to '{Starting}'.");
		}
		return false;
	}
}
