

using Blog.Domain.Repositories.Abstract;

namespace Blog.Domain
{
    public class DataManager
    {
        public ITextFieldsRepository TextFields { get; set; }
        public INewsItemsRepository ServiceItems { get; set; }

        public DataManager(ITextFieldsRepository textFieldsRepository, INewsItemsRepository serviceItemsRepository)
        {
            TextFields = textFieldsRepository;
            ServiceItems = serviceItemsRepository;
        }
    }
}
