using System;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiAdvertCommissionAdvchannelBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiAdvertCommissionAdvchannelBindModel : AlipayObject
    {
        /// <summary>
        /// 广告id
        /// </summary>
        [JsonProperty("adv_id")]
        [XmlElement("adv_id")]
        public string AdvId { get; set; }

        /// <summary>
        /// 渠道ID列表
        /// </summary>
        [JsonProperty("channel_id_list")]
        [XmlArray("channel_id_list")]
        [XmlArrayItem("string")]
        public List<string> ChannelIdList { get; set; }
    }
}