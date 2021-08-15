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
    /// IP address information for entries in the (plural) PodIPs field. Each entry
        /// includes:
        /// IP: An IP address allocated to the pod. Routable at least within the cluster.
    /// </summary>
    public partial class V1PodIP
    {
        /// <summary>
        /// Initializes a new instance of the V1PodIP class.
        /// </summary>
        public V1PodIP()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1PodIP class.
        /// </summary>
        /// <param name="ip">
        /// ip is an IP address (IPv4 or IPv6) assigned to the pod
        /// </param>
        public V1PodIP(string ip = null)
        {
            Ip = ip;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// ip is an IP address (IPv4 or IPv6) assigned to the pod
        /// </summary>
        [JsonProperty(PropertyName = "ip")]
        public string Ip { get; set; }

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
