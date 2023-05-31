namespace Skyline.DataMiner.Utils.ConnectorAPI.BridgeTechnologies.VBProbeSeries.StrobeManager
{
	using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;

	public class CreateBtStrobeMgrFilter : Message
	{
		public string FilterKey { get; set; }

		public string JoinItf { get; set; }

		public string RegexFilter { get; set; }
	}

	public class RemoveBtStrobeMgrFilter : Message
	{
		public string FilterKeyToRemove { get; set; }
	}
}
