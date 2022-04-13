using EventBus.Messages.Events;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ordering.API.EventBusConsumer
{
    public class BasketCheckoutConsumer : IConsumer<BasketCheckOutEvent>
    {
        public Task Consume(ConsumeContext<BasketCheckOutEvent> context)
        {
            throw new NotImplementedException();
        }
    }
}
