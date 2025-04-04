﻿using KayraCQRSMediator.DataAcces.Entities;
using MediatR;

namespace KayraCQRSMediator.Features.Mediator.Commands.ProductCommands
{
    public class UpdateProductCommand:IRequest
    {
        public int? ProductId { get; set; }
        public string? ProductName { get; set; }

        public decimal ProductPrice { get; set; }
        public string? ImageUrl { get; set; }

        public int CategoryId { get; set; }

    }
}
