﻿// ==============================================================================================================
// Microsoft patterns & practices
// CQRS Journey project
// ==============================================================================================================
// ©2012 Microsoft. All rights reserved. Certain content used with permission from contributors
// http://cqrsjourney.github.com/contributors/members
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance 
// with the License. You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software distributed under the License is 
// distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. 
// See the License for the specific language governing permissions and limitations under the License.
// ==============================================================================================================

namespace Registration.Events
{
    using System;
    using System.Collections.Generic;
    using Common;

    public class OrderPlaced : IEvent
    {
        public class OrderItem
        {
            public Guid SeatTypeId { get; set; }

            public int Quantity { get; set; }
        }

        public OrderPlaced()
        {
            this.Items = new List<OrderItem>();
        }

        public Guid OrderId { get; set; }

        // TODO: Should all the rest be filled in by the event publisher, assuming a non-ES entity?
        // Or should the event handler get the event, load the aggregate and pass it (or a DTO) into the Saga?
        public Guid ConferenceId { get; set; }

        public ICollection<OrderItem> Items { get; set; }
    }
}
