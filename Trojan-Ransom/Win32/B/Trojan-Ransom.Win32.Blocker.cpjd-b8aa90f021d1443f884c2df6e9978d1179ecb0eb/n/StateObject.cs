using System.Net.Sockets;
using System.Text;

namespace n;

public class StateObject
{
	public Socket workSocket;

	public int BufferSize;

	public byte[] buffer;

	public StringBuilder sb;

	public StateObject()
	{
		workSocket = null;
		BufferSize = 1999998;
		buffer = new byte[1999999];
		sb = new StringBuilder();
	}
}
