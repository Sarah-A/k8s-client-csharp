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
    /// PersistentVolumeClaim is a user&apos;s request for and claim to a persistent volume
    /// </summary>
    public partial class V1PersistentVolumeClaim
    {
        /// <summary>
        /// Initializes a new instance of the V1PersistentVolumeClaim class.
        /// </summary>
        public V1PersistentVolumeClaim()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1PersistentVolumeClaim class.
        /// </summary>
        /// <param name="apiVersion">
        /// APIVersion defines the versioned schema of this representation of an object.
        /// Servers should convert recognized schemas to the latest internal value, and may
        /// reject unrecognized values. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
        /// </param>
        /// <param name="kind">
        /// Kind is a string value representing the REST resource this object represents.
        /// Servers may infer this from the endpoint the client submits requests to. Cannot
        /// be updated. In CamelCase. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        /// </param>
        /// <param name="metadata">
        /// Standard object&apos;s metadata. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        /// </param>
        /// <param name="spec">
        /// Spec defines the desired characteristics of a volume requested by a pod author.
        /// More info:
        /// https://kubernetes.io/docs/concepts/storage/persistent-volumes#persistentvolumeclaims
        /// </param>
        /// <param name="status">
        /// Status represents the current information/status of a persistent volume claim.
        /// Read-only. More info:
        /// https://kubernetes.io/docs/concepts/storage/persistent-volumes#persistentvolumeclaims
        /// </param>
        public V1PersistentVolumeClaim(string apiVersion = null, string kind = null, V1ObjectMeta metadata = null, V1PersistentVolumeClaimSpec spec = null, V1PersistentVolumeClaimStatus status = null)
        {
            ApiVersion = apiVersion;
            Kind = kind;
            Metadata = metadata;
            Spec = spec;
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// APIVersion defines the versioned schema of this representation of an object.
        /// Servers should convert recognized schemas to the latest internal value, and may
        /// reject unrecognized values. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
        /// </summary>
        [JsonProperty(PropertyName = "apiVersion")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Kind is a string value representing the REST resource this object represents.
        /// Servers may infer this from the endpoint the client submits requests to. Cannot
        /// be updated. In CamelCase. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Standard object&apos;s metadata. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public V1ObjectMeta Metadata { get; set; }

        /// <summary>
        /// Spec defines the desired characteristics of a volume requested by a pod author.
        /// More info:
        /// https://kubernetes.io/docs/concepts/storage/persistent-volumes#persistentvolumeclaims
        /// </summary>
        [JsonProperty(PropertyName = "spec")]
        public V1PersistentVolumeClaimSpec Spec { get; set; }

        /// <summary>
        /// Status represents the current information/status of a persistent volume claim.
        /// Read-only. More info:
        /// https://kubernetes.io/docs/concepts/storage/persistent-volumes#persistentvolumeclaims
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public V1PersistentVolumeClaimStatus Status { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            Metadata?.Validate();
            Spec?.Validate();
            Status?.Validate();
        }
    }
}
