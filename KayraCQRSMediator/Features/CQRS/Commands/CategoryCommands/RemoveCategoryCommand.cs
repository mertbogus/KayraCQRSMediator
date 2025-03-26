namespace KayraCQRSMediator.Features.CQRS.Commands.CategoryCommands
{
    public class RemoveCategoryCommand(int id)
    {
        //id'yi eşitliyoruz constructor ile eşitlemek için.
        public int CategoryId { get; set; } = id;
    }
}
