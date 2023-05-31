namespace Skyline.DataMiner.Utils.ConnectorAPI.BridgeTechnologies.VBProbeSeries.Ethernet
{
	using System.Collections.Generic;

	using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;

	public class CreateEthStream : Message
	{
		public EthStreamData StreamData { get; set; }
	}

	public class CreateEthStreamResult : Message
	{
		public bool IsRequestValid { get; set; }

		public bool IsCreated { get; set; }

		public bool IsFullMatch { get; set; }

		public string Description { get; set; }

		public CreateEthStream Request { get; set; }

		public string StreamKey { get; set; }

		public int StreamID { get; set; }
	}

	public class EditEthStream : Message
	{
		public string Key { get; set; }

		public EthStreamData StreamData { get; set; }
	}

	public class EditEthStreamResult : Message
	{
		public bool IsRequestValid { get; set; }

		public bool IsEdited { get; set; }

		public bool IsFullMatch { get; set; }

		public string Description { get; set; }

		public EditEthStream Request { get; set; }

		public string StreamKey { get; set; }
	}

	public class DeleteEthStreams : Message
	{
		public string[] StreamKeys { get; set; }

		public bool DeleteAllOrNone { get; set; }
	}

	public class DeleteEthStreamsResult : Message
	{
		public bool IsRequestValid { get; set; }

		public bool AreAllStreamsDeleted { get; set; }

		public string Description { get; set; }

		public DeleteEthStreams Request { get; set; }

		public List<string> DeletedKeys { get; set; }

		public List<string> FoundButNotDeletedKeys { get; set; }

		public List<string> NotFoundKeys { get; set; }
	}
}
