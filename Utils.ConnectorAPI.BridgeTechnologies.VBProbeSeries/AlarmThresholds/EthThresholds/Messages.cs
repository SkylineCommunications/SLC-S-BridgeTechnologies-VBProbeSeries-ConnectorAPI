namespace Skyline.DataMiner.Utils.ConnectorAPI.BridgeTechnologies.VBProbeSeries.AlarmThresholds.EthThresholds
{
	using System.Collections.Generic;

	using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;

	public class CreateEthThreshold : Message
	{
		public EthThresholdData ThresholdData { get; set; }
	}

	public class CreateEthThresholdResult : Message
	{
		public bool IsRequestValid { get; set; }

		public bool IsCreated { get; set; }

		public bool IsFullMatch { get; set; }

		public string Description { get; set; }

		public CreateEthThreshold Request { get; set; }

		public string ThresholdID { get; set; }
	}

	public class EditEthThreshold : Message
	{
		public string ThresholdToUpdateName { get; set; }

		public EthThresholdData ThresholdData { get; set; }
	}

	public class EditEthThresholdResult : Message
	{
		public bool IsRequestValid { get; set; }

		public bool IsEdited { get; set; }

		public bool IsFullMatch { get; set; }

		public string Description { get; set; }

		public EditEthThreshold Request { get; set; }

		public string ThresholdId { get; set; }
	}

	public class DeleteEthThresholds : Message
	{
		public IEnumerable<string> ThresholdToDeleteNames { get; set; }
	}

	public class DeleteEthThresholdsResult : Message
	{
		public bool IsRequestValid { get; set; }

		public bool AreAllThresholdsDeleted { get; set; }

		public string Description { get; set; }

		public DeleteEthThresholds Request { get; set; }

		public List<string> DeletedKeys { get; set; }

		public List<string> FoundButNotDeletedKeys { get; set; }

		public List<string> NotFoundKeys { get; set; }
	}
}
