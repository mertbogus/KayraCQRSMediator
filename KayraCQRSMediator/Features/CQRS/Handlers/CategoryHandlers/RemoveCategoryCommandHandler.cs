using KayraCQRSMediator.DataAcces.Entities;
using KayraCQRSMediator.Features.CQRS.Commands.CategoryCommands;
using KayraCQRSMediator.Repositories;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace KayraCQRSMediator.Features.CQRS.Handlers.CategoryHandlers
{
    public class RemoveCategoryCommandHandler(IRepository<Category> _repository)
    {
        public async Task Handle(RemoveCategoryCommand command)
        {
            await _repository.DeleteAsync(command.CategoryId);
        }
    }
}
