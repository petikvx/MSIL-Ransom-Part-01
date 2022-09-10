using System.ServiceModel.Channels;

namespace System.ServiceModel.Activation;

internal delegate void ViaDecodedCallback(InitialServerConnectionReader connectionReader, ListenerSessionConnection session);
