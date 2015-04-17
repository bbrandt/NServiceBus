namespace NServiceBus
{
    using System;

    /// <summary>
    /// Configures purging
    /// </summary>
    public static class ConfigurePurging
    {
        /// <summary>
        /// Requests that the incoming queue be purged of all messages when the bus is started.
        /// All messages in this queue will be deleted if this is true.
        /// Setting this to true may make sense for certain smart-client applications, 
        /// but rarely for server applications.
        /// </summary>
        public static void PurgeOnStartup(this BusConfiguration config, bool value)
        {
            Guard.AgainstNull(config, "config");
            config.Settings.Set("Transport.PurgeOnStartup", value);
        }

        /// <summary>
        /// Retrieves whether to purge the queues at startup or not.
        /// </summary>
        [ObsoleteEx(TreatAsErrorFromVersion = "6")]
// ReSharper disable once UnusedParameter.Global
        public static bool PurgeOnStartup(this Configure config)
        {
            throw new NotImplementedException();
        }
    }
}
