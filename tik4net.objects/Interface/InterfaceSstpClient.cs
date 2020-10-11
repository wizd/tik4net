using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tik4net.Objects.Interface
{
    /// <summary>
    /// interface/ethernet
    /// MikroTik RouterOS supports various types of Ethernet interfaces. 
    /// </summary>
    [TikEntity("interface/sstp-client")]
    public class InterfaceSstpClient
    {
        /// <summary>
        /// .id: primary key of row
        /// </summary>
        [TikProperty(".id", IsReadOnly = true, IsMandatory = true)]
        public string Id { get; private set; }

        /// <summary>
        /// Connect-To: vpn server
        /// </summary>
        [TikProperty("connect-to")]
        public string VpnServer { get; set; }

        /// <summary>
        /// User name
        /// </summary>
        [TikProperty("user")]
        public string UserName { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        [TikProperty("password")]
        public string Password { get; set; }

        /// <summary>
        /// Options for Yes-No properties.
        /// </summary>
        public enum YesNoOptions
        {
            /// <summary>
            /// yes
            /// </summary>
            [TikEnum("true")]
            Yes,

            /// <summary>
            /// no
            /// </summary>
            [TikEnum("false")]
            No,
        }

        /// <summary>
        /// name: Name of an interface
        /// </summary>
        [TikProperty("name", IsMandatory = true)]
        public string Name { get; set; }

        /// <summary>
        /// running: Whether interface is running. Note that some interface does not have running check and they are always reported as "running"
        /// </summary>
        [TikProperty("running", IsReadOnly = true)]
        public bool Running { get; private set; }

        /// <summary>
        /// disabled: Whether interface is disabled
        /// </summary>
        [TikProperty("disabled", DefaultValue = "yes")]
        public bool Disabled { get; set; }
    }
}
