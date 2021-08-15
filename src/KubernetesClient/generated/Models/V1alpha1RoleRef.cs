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
    /// RoleRef contains information that points to the role being used
    /// </summary>
    public partial class V1alpha1RoleRef
    {
        /// <summary>
        /// Initializes a new instance of the V1alpha1RoleRef class.
        /// </summary>
        public V1alpha1RoleRef()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1alpha1RoleRef class.
        /// </summary>
        /// <param name="apiGroup">
        /// APIGroup is the group for the resource being referenced
        /// </param>
        /// <param name="kind">
        /// Kind is the type of resource being referenced
        /// </param>
        /// <param name="name">
        /// Name is the name of resource being referenced
        /// </param>
        public V1alpha1RoleRef(string apiGroup, string kind, string name)
        {
            ApiGroup = apiGroup;
            Kind = kind;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// APIGroup is the group for the resource being referenced
        /// </summary>
        [JsonProperty(PropertyName = "apiGroup")]
        public string ApiGroup { get; set; }

        /// <summary>
        /// Kind is the type of resource being referenced
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Name is the name of resource being referenced
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

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
