namespace Skyline.DataMiner.ConnectorAPI.BridgeTechnologies.VBProbeSeries.Ethernet
{
	using System.Collections.Generic;

	using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;

	/// <summary>
	/// Inter-App Message allowing to add new entries to the Ethernet Available Streams table.
	/// </summary>
	public class CreateEthStream : Message
	{
		/// <summary>
		/// The  data for the new Ethernet Available Stream.
		/// </summary>
		public EthStreamData StreamData { get; set; }
	}

	/// <summary>
	/// Result of the CreateEthStream request.
	/// </summary>
	public class CreateEthStreamResult : Message
	{
		/// <summary>
		/// Indicates whether the request is valid.
		/// </summary>
		public bool IsRequestValid { get; set; }

		/// <summary>
		/// Indicates whether the stream was created.
		/// </summary>
		public bool IsCreated { get; set; }

		/// <summary>
		/// Indicates whether there is a full match.
		/// </summary>
		public bool IsFullMatch { get; set; }

		/// <summary>
		/// The summary description of the result.
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// The original request.
		/// </summary>
		public CreateEthStream Request { get; set; }

		/// <summary>
		/// The key of newly created stream.
		/// </summary>
		public string StreamKey { get; set; }
	}

	/// <summary>
	/// Inter-App Message allowing to edit existing entries from the Ethernet Available Streams table.
	/// </summary>
	public class EditEthStream : Message
	{
		/// <summary>
		/// The key of stream that is to be edited.
		/// </summary>
		public string StreamKey { get; set; }

		/// <summary>
		/// The new stream data for the stream that is edited.
		/// </summary>
		public EthStreamData StreamData { get; set; }
	}

	/// <summary>
	/// Result of the EditEthStream request.
	/// </summary>
	public class EditEthStreamResult : Message
	{
		/// <summary>
		/// Indicates whether the request is valid.
		/// </summary>
		public bool IsRequestValid { get; set; }

		/// <summary>
		/// Indicates whether the stream was edited.
		/// </summary>
		public bool IsEdited { get; set; }

		/// <summary>
		/// Indicates whether there is a full match.
		/// </summary>
		public bool IsFullMatch { get; set; }

		/// <summary>
		/// The summary description of the result.
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// The original request.
		/// </summary>
		public EditEthStream Request { get; set; }

		/// <summary>
		/// The key of edited stream.
		/// </summary>
		public string StreamKey { get; set; }
	}

	/// <summary>
	/// Inter-App Message allowing to delete existing entries from the Ethernet Available Streams table.
	/// </summary>
	public class DeleteEthStreams : Message
	{
		/// <summary>
		/// The Stream Keys that are to be deleted.
		/// </summary>
		public string[] StreamKeys { get; set; }

		/// <summary>
		/// Indicates whether to delete all or none.
		/// </summary>
		public bool DeleteAllOrNone { get; set; }
	}

	/// <summary>
	/// Result of the DeleteEthStreams request.
	/// </summary>
	public class DeleteEthStreamsResult : Message
	{
		/// <summary>
		/// Indicates whether the request is valid.
		/// </summary>
		public bool IsRequestValid { get; set; }

		/// <summary>
		/// Indicates whether all streams were deleted.
		/// </summary>
		public bool AreAllStreamsDeleted { get; set; }

		/// <summary>
		/// The summary description of the result.
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// The original request.
		/// </summary>
		public DeleteEthStreams Request { get; set; }

		/// <summary>
		/// The list of deleted Stream Keys.
		/// </summary>
		public List<string> DeletedKeys { get; set; }

		/// <summary>
		/// The list of Stream Keys that were found but not deleted.
		/// </summary>
		public List<string> FoundButNotDeletedKeys { get; set; }

		/// <summary>
		/// The list of Stream Keys that were not found.
		/// </summary>
		public List<string> NotFoundKeys { get; set; }
	}
}