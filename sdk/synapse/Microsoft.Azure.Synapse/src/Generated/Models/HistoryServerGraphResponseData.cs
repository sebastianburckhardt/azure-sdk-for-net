// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Synapse.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class HistoryServerGraphResponseData
    {
        /// <summary>
        /// Initializes a new instance of the HistoryServerGraphResponseData
        /// class.
        /// </summary>
        public HistoryServerGraphResponseData()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HistoryServerGraphResponseData
        /// class.
        /// </summary>
        public HistoryServerGraphResponseData(bool? isAppFinished = default(bool?), Jobs jobs = default(Jobs), Stages stages = default(Stages))
        {
            IsAppFinished = isAppFinished;
            Jobs = jobs;
            Stages = stages;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isAppFinished")]
        public bool? IsAppFinished { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "jobs")]
        public Jobs Jobs { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stages")]
        public Stages Stages { get; set; }

    }
}
