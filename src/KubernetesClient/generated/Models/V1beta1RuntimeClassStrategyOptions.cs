// <auto-generated>
// Code generated by https://github.com/kubernetes-client/csharp/tree/master/gen/KubernetesGenerator
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Collections;
    using System.Linq;

    /// <summary>
    /// RuntimeClassStrategyOptions define the strategy that will dictate the allowable
        /// RuntimeClasses for a pod.
    /// </summary>
    public partial class V1beta1RuntimeClassStrategyOptions
    {
        /// <summary>
        /// Initializes a new instance of the V1beta1RuntimeClassStrategyOptions class.
        /// </summary>
        public V1beta1RuntimeClassStrategyOptions()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1beta1RuntimeClassStrategyOptions class.
        /// </summary>
        /// <param name="allowedRuntimeClassNames">
        /// allowedRuntimeClassNames is an allowlist of RuntimeClass names that may be
        /// specified on a pod. A value of &quot;*&quot; means that any RuntimeClass name is allowed,
        /// and must be the only item in the list. An empty list requires the
        /// RuntimeClassName field to be unset.
        /// </param>
        /// <param name="defaultRuntimeClassName">
        /// defaultRuntimeClassName is the default RuntimeClassName to set on the pod. The
        /// default MUST be allowed by the allowedRuntimeClassNames list. A value of nil
        /// does not mutate the Pod.
        /// </param>
        public V1beta1RuntimeClassStrategyOptions(IList<string> allowedRuntimeClassNames, string defaultRuntimeClassName = null)
        {
            AllowedRuntimeClassNames = allowedRuntimeClassNames;
            DefaultRuntimeClassName = defaultRuntimeClassName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// allowedRuntimeClassNames is an allowlist of RuntimeClass names that may be
        /// specified on a pod. A value of &quot;*&quot; means that any RuntimeClass name is allowed,
        /// and must be the only item in the list. An empty list requires the
        /// RuntimeClassName field to be unset.
        /// </summary>
        [JsonProperty(PropertyName = "allowedRuntimeClassNames")]
        public IList<string> AllowedRuntimeClassNames { get; set; }

        /// <summary>
        /// defaultRuntimeClassName is the default RuntimeClassName to set on the pod. The
        /// default MUST be allowed by the allowedRuntimeClassNames list. A value of nil
        /// does not mutate the Pod.
        /// </summary>
        [JsonProperty(PropertyName = "defaultRuntimeClassName")]
        public string DefaultRuntimeClassName { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
