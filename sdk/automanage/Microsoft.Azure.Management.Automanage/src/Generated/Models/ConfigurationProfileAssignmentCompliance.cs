// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Automanage.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The compliance status for the configuration profile assignment.
    /// </summary>
    public partial class ConfigurationProfileAssignmentCompliance
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ConfigurationProfileAssignmentCompliance class.
        /// </summary>
        public ConfigurationProfileAssignmentCompliance()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ConfigurationProfileAssignmentCompliance class.
        /// </summary>
        /// <param name="updateStatus">The state of compliance, which only
        /// appears in the response. Possible values include: 'Succeeded',
        /// 'Failed', 'Created'</param>
        public ConfigurationProfileAssignmentCompliance(string updateStatus = default(string))
        {
            UpdateStatus = updateStatus;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the state of compliance, which only appears in the response.
        /// Possible values include: 'Succeeded', 'Failed', 'Created'
        /// </summary>
        [JsonProperty(PropertyName = "updateStatus")]
        public string UpdateStatus { get; private set; }

    }
}
