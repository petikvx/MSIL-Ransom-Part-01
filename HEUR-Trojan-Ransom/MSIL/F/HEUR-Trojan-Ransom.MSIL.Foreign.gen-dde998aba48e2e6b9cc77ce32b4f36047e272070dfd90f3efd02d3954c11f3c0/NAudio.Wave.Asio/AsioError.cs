namespace NAudio.Wave.Asio;

public enum AsioError
{
	ASE_OK = 0,
	ASE_SUCCESS = 1061701536,
	ASE_NotPresent = -1000,
	ASE_HWMalfunction = -999,
	ASE_InvalidParameter = -998,
	ASE_InvalidMode = -997,
	ASE_SPNotAdvancing = -996,
	ASE_NoClock = -995,
	ASE_NoMemory = -994
}
