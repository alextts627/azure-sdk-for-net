// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> The state of the script execution resource. </summary>
    public readonly partial struct ScriptExecutionProvisioningState : IEquatable<ScriptExecutionProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ScriptExecutionProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ScriptExecutionProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PendingValue = "Pending";
        private const string RunningValue = "Running";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CancellingValue = "Cancelling";
        private const string CancelledValue = "Cancelled";
        private const string DeletingValue = "Deleting";

        /// <summary> Pending. </summary>
        public static ScriptExecutionProvisioningState Pending { get; } = new ScriptExecutionProvisioningState(PendingValue);
        /// <summary> Running. </summary>
        public static ScriptExecutionProvisioningState Running { get; } = new ScriptExecutionProvisioningState(RunningValue);
        /// <summary> Succeeded. </summary>
        public static ScriptExecutionProvisioningState Succeeded { get; } = new ScriptExecutionProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static ScriptExecutionProvisioningState Failed { get; } = new ScriptExecutionProvisioningState(FailedValue);
        /// <summary> Cancelling. </summary>
        public static ScriptExecutionProvisioningState Cancelling { get; } = new ScriptExecutionProvisioningState(CancellingValue);
        /// <summary> Cancelled. </summary>
        public static ScriptExecutionProvisioningState Cancelled { get; } = new ScriptExecutionProvisioningState(CancelledValue);
        /// <summary> Deleting. </summary>
        public static ScriptExecutionProvisioningState Deleting { get; } = new ScriptExecutionProvisioningState(DeletingValue);
        /// <summary> Determines if two <see cref="ScriptExecutionProvisioningState"/> values are the same. </summary>
        public static bool operator ==(ScriptExecutionProvisioningState left, ScriptExecutionProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ScriptExecutionProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(ScriptExecutionProvisioningState left, ScriptExecutionProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ScriptExecutionProvisioningState"/>. </summary>
        public static implicit operator ScriptExecutionProvisioningState(string value) => new ScriptExecutionProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ScriptExecutionProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ScriptExecutionProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
