using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tik4net.Objects.Ip.Route
{
    /// <summary>
    /// interface/ethernet
    /// MikroTik RouterOS supports various types of Ethernet interfaces. 
    /// </summary>
    [TikEntity("interface/l2tp-client")]
    public class IpRouteRule
    {
        /// <summary>
        /// .id: primary key of row
        /// </summary>
        [TikProperty(".id", IsReadOnly = true, IsMandatory = true)]
        public string Id { get; private set; }

        /// <summary>
        /// Connect-To: vpn server
        /// </summary>
        [TikProperty("dst-address")]
        public string DstAddress { get; set; }

        /// <summary>
        /// User name
        /// </summary>
        [TikProperty("action")]
        public string Action { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        [TikProperty("table")]
        public string Table { get; set; }
    }
}
