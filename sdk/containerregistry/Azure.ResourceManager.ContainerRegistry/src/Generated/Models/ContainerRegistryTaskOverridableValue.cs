// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The properties of a overridable value that can be passed to a task template. </summary>
    public partial class ContainerRegistryTaskOverridableValue
    {
        /// <summary> Initializes a new instance of ContainerRegistryTaskOverridableValue. </summary>
        /// <param name="name"> The name of the overridable value. </param>
        /// <param name="value"> The overridable value. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="value"/> is null. </exception>
        public ContainerRegistryTaskOverridableValue(string name, string value)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Name = name;
            Value = value;
        }

        /// <summary> Initializes a new instance of ContainerRegistryTaskOverridableValue. </summary>
        /// <param name="name"> The name of the overridable value. </param>
        /// <param name="value"> The overridable value. </param>
        /// <param name="isSecret"> Flag to indicate whether the value represents a secret or not. </param>
        internal ContainerRegistryTaskOverridableValue(string name, string value, bool? isSecret)
        {
            Name = name;
            Value = value;
            IsSecret = isSecret;
        }

        /// <summary> The name of the overridable value. </summary>
        public string Name { get; set; }
        /// <summary> The overridable value. </summary>
        public string Value { get; set; }
        /// <summary> Flag to indicate whether the value represents a secret or not. </summary>
        public bool? IsSecret { get; set; }
    }
}
