﻿namespace KayraCQRSMediator.Features.CQRS.Commands.CategoryCommands
{
    public class UpdateCategoryCommand
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public string ImageUrl { get; set; }
    }
}
