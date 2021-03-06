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

namespace Registration.ReadModel
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class OrderItemDTO
    {
        public OrderItemDTO(Guid id, Guid seatTypeId, int quantity)
        {
            this.OrderItemId = id;
            this.SeatTypeId = seatTypeId;
            this.Quantity = quantity;
        }

        protected OrderItemDTO()
        {
        }

        [Key]
        public Guid OrderItemId { get; private set; }

        public Guid SeatTypeId { get; private set; }

        public int Quantity { get; private set; }
    }
}
