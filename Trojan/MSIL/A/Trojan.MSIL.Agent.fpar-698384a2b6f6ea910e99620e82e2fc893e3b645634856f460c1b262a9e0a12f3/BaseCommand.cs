public enum BaseCommand : byte
{
	Initialize,
	ConnectDone,
	CreatePipe,
	PipeCreated,
	Transmission,
	UnhandledException,
	KeepAlive,
	ExceptionHash,
	ExceptionData
}
