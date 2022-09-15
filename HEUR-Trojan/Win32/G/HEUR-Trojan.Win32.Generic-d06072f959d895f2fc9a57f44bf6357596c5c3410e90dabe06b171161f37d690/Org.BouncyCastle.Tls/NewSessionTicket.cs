using System.IO;

namespace Org.BouncyCastle.Tls;

public sealed class NewSessionTicket
{
	private readonly long m_ticketLifetimeHint;

	private readonly byte[] m_ticket;

	public long TicketLifetimeHint => m_ticketLifetimeHint;

	public byte[] Ticket => m_ticket;

	public NewSessionTicket(long ticketLifetimeHint, byte[] ticket)
	{
		m_ticketLifetimeHint = ticketLifetimeHint;
		m_ticket = ticket;
	}

	public void Encode(Stream output)
	{
		TlsUtilities.WriteUint32(TicketLifetimeHint, output);
		TlsUtilities.WriteOpaque16(Ticket, output);
	}

	public static NewSessionTicket Parse(Stream input)
	{
		long ticketLifetimeHint = TlsUtilities.ReadUint32(input);
		byte[] ticket = TlsUtilities.ReadOpaque16(input);
		return new NewSessionTicket(ticketLifetimeHint, ticket);
	}
}
