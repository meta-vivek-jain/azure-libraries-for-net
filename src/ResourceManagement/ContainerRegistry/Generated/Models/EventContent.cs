// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 2.2.27.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerRegistry.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The content of the event request message.
    /// </summary>
    public partial class EventContent
    {
        /// <summary>
        /// Initializes a new instance of the EventContent class.
        /// </summary>
        public EventContent()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EventContent class.
        /// </summary>
        /// <param name="id">The event ID.</param>
        /// <param name="timestamp">The time at which the event
        /// occurred.</param>
        /// <param name="action">The action that encompasses the provided
        /// event.</param>
        /// <param name="target">The target of the event.</param>
        /// <param name="request">The request that generated the event.</param>
        /// <param name="actor">The agent that initiated the event. For most
        /// situations, this could be from the authorization context of the
        /// request.</param>
        /// <param name="source">The registry node that generated the event.
        /// Put differently, while the actor initiates the event, the source
        /// generates it.</param>
        public EventContent(string id = default(string), System.DateTime? timestamp = default(System.DateTime?), string action = default(string), Target target = default(Target), Request request = default(Request), Actor actor = default(Actor), Source source = default(Source))
        {
            Id = id;
            Timestamp = timestamp;
            Action = action;
            Target = target;
            Request = request;
            Actor = actor;
            Source = source;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the event ID.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the time at which the event occurred.
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public System.DateTime? Timestamp { get; set; }

        /// <summary>
        /// Gets or sets the action that encompasses the provided event.
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        public string Action { get; set; }

        /// <summary>
        /// Gets or sets the target of the event.
        /// </summary>
        [JsonProperty(PropertyName = "target")]
        public Target Target { get; set; }

        /// <summary>
        /// Gets or sets the request that generated the event.
        /// </summary>
        [JsonProperty(PropertyName = "request")]
        public Request Request { get; set; }

        /// <summary>
        /// Gets or sets the agent that initiated the event. For most
        /// situations, this could be from the authorization context of the
        /// request.
        /// </summary>
        [JsonProperty(PropertyName = "actor")]
        public Actor Actor { get; set; }

        /// <summary>
        /// Gets or sets the registry node that generated the event. Put
        /// differently, while the actor initiates the event, the source
        /// generates it.
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        public Source Source { get; set; }

    }
}
