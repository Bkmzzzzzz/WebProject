using Blog.Domain.Repositories.Abstract;

namespace Blog.Domain
{
    public class DataManager
    {
        public ITextFieldsRepository TextFields { get; set; }
        public INewsItemsRepository NewsItems { get; set; }

        public DataManager(ITextFieldsRepository textFieldsRepository, INewsItemsRepository NewsItemsRepository)
        {
            TextFields = textFieldsRepository;
            NewsItems = NewsItemsRepository;
        }
    }
}
