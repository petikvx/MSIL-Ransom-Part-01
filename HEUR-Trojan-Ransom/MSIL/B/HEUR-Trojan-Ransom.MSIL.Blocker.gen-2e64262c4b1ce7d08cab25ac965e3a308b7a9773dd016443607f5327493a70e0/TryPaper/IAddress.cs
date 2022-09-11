namespace TryPaper;

public interface IAddress
{
	string Name { get; set; }

	string Organization { get; set; }

	string AddressLineOne { get; set; }

	string AddressLineTwo { get; set; }

	string City { get; set; }

	string Province { get; set; }

	string PostalCode { get; set; }
}
