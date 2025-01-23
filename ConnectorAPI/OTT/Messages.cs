namespace Skyline.DataMiner.ConnectorAPI.BridgeTechnologies.VBProbeSeries.OTT
{
	using System.Collections.Generic;

	using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;

	/// <summary>
	/// Inter-App Message allowing to add new entries to the OTT Available Channels table.
	/// </summary>
	public class CreateOttChannel : Message
	{
		/// <summary>
		/// The data for the new OTT Available Channel.
		/// </summary>
		public OttChannelData ChannelData { get; set; }
	}

	/// <summary>
	/// Result of the CreateOttChannel request.
	/// </summary>
	public class CreateOttChannelResult : Message
	{
		/// <summary>
		/// Indicates whether the request is valid.
		/// </summary>
		public bool IsRequestValid { get; set; }

		/// <summary>
		/// Indicates whether the channel was created.
		/// </summary>
		public bool IsCreated { get; set; }

		/// <summary>
		/// Indicates whether the newly created channel fully matches with the new channel request data.
		/// </summary>
		public bool IsFullMatch { get; set; }

		/// <summary>
		/// The summary description of the result.
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// The original request.
		/// </summary>
		public CreateOttChannel Request { get; set; }

		/// <summary>
		/// The key of newly created channel.
		/// </summary>
		public string ChannelKey { get; set; }
	}

	/// <summary>
	/// Inter-App Message allowing to edit existing entries from the OTT Available Channels table.
	/// </summary>
	public class EditOttChannel : Message
	{
		/// <summary>
		/// The key of channel that is to be edited.
		/// </summary>
		public string ChannelKey { get; set; }

		/// <summary>
		/// The new channel data for the channel that is edited.
		/// </summary>
		public OttChannelData ChannelData { get; set; }
	}

	/// <summary>
	/// Result of the EditOttChannel request.
	/// </summary>
	public class EditOttChannelResult : Message
	{
		/// <summary>
		/// Indicates whether the request is valid.
		/// </summary>
		public bool IsRequestValid { get; set; }

		/// <summary>
		/// Indicates whether the channel was edited.
		/// </summary>
		public bool IsEdited { get; set; }

		/// <summary>
		/// Indicates whether the channel now fully matches with the requested changes.
		/// </summary>
		public bool IsFullMatch { get; set; }

		/// <summary>
		/// The summary description of the result.
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// The original request.
		/// </summary>
		public EditOttChannel Request { get; set; }

		/// <summary>
		/// The key of edited channel.
		/// </summary>
		public string ChannelKey { get; set; }
	}

	/// <summary>
	/// Inter-App Message allowing to delete existing entries from the OTT Available Channels table.
	/// </summary>
	public class DeleteOttChannels : Message
	{
		/// <summary>
		/// The Channel Keys that are to be deleted.
		/// </summary>
		public string[] ChannelKeys { get; set; }

		/// <summary>
		/// Indicates whether to delete all or none.
		/// </summary>
		public bool DeleteAllOrNone { get; set; }
	}

	/// <summary>
	/// Result of the DeleteOttChannels request.
	/// </summary>
	public class DeleteOttChannelsResult : Message
	{
		/// <summary>
		/// Indicates whether the request is valid.
		/// </summary>
		public bool IsRequestValid { get; set; }

		/// <summary>
		/// Indicates whether all channels were deleted.
		/// </summary>
		public bool AreAllChannelsDeleted { get; set; }

		/// <summary>
		/// The summary description of the result.
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// The original request.
		/// </summary>
		public DeleteOttChannels Request { get; set; }

		/// <summary>
		/// The list of deleted Channel Keys.
		/// </summary>
		public List<string> DeletedKeys { get; set; }

		/// <summary>
		/// The list of Channel Keys that were found but not deleted.
		/// </summary>
		public List<string> FoundButNotDeletedKeys { get; set; }

		/// <summary>
		/// The list of Channel Keys that were not found.
		/// </summary>
		public List<string> NotFoundKeys { get; set; }
	}
}