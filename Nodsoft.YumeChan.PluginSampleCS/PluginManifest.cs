using System;
using System.Threading.Tasks;
using Nodsoft.YumeChan.PluginBase;

namespace Nodsoft.YumeChan.PluginSampleCS
{
	// This Class defines the Plugin, and makes it visible to the Loader.
	public class PluginManifest : Plugin // This Class MUST be set as public to get picked up by the Plugin Loader.
	{
		// This defines your Plugin's Display name.
		public override string PluginDisplayName { get; } = "YumeChan : Sample Plugin";

		// This flag defines whether your Plugin should be shown to the general public or not.
		// Still shown to Server Operators, this is useful for security plugins, or plugins requiring covert operation.
		public override bool PluginStealth { get; } = false;

		public override async Task LoadPlugin()
		{
			//Here goes the Loading Logic, if some loading procedure is needed. Treat it as a Ctor.


			await base.LoadPlugin(); // This method call sets Plugin.PluginLoaded to true.
		}
		public override async Task UnloadPlugin()
		{
			//Here goes the Unloading Logic, if some unloading (e.g: Disposal) is needed. Treat it as a Dtor (~).


			await base.UnloadPlugin(); // This method call resets Plugin.PluginLoaded to false.
		}
	}
}
