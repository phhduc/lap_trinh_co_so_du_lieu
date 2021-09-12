using bttuan3.RSSFeed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bttuan3
{
    public class NewsFeedManager
    {
        private readonly INewsRepository _newsRepository;
        private List<Publisher> _publishers;
        private readonly RssReader _rssReader;
        public NewsFeedManager(INewsRepository newsRepository, RssReader rssReader)
        {
            _newsRepository = newsRepository;
            _rssReader = rssReader;
        }
        public List<Publisher> GetNewsFeed()
        {
            if (_publishers == null)
            {
                _publishers = _newsRepository.GetNews();
            }
            return _publishers;
        }
        public void SaveChanged()
        {
            _newsRepository.Save(_publishers);
        }
        public void RemovePublisher(string publisherName)
        {
            _publishers.RemoveAll(x => x.Name == publisherName);
            SaveChanged();
        }
        public void RemoveCategory(string publisherName, string categoryName)
        {
            var publisher = _publishers.Find(x => x.Name == publisherName);
            if (publisher == null) return;
            publisher.RemoveCategory(categoryName);
            SaveChanged();
        }
        public bool AddCategory(string publisherName, string categoryName, string rsslink, bool updateIfExisted)
        {
            var publisher = _publishers.Find(x => x.Name == publisherName);
            if(publisher == null)
            {
                publisher = new Publisher()
                {
                    Name = publisherName
                };
                _publishers.Add(publisher);
            }
            return publisher.AddCategory(categoryName, rsslink, updateIfExisted);
        }
        public List<Article> GetNews(string publisherName, string categoryName)
        {
            var publisher = _publishers.Find(x => x.Name == publisherName);
            if (publisher == null) return new List<Article>();
            var category = publisher.Categories.Find(x => x.Name == categoryName);

            if (category == null) return new List<Article>();
            if (category.Articles.Count == 0)
            {
                category.Articles = _rssReader.GetNews(category.RssLink);
            }
            return category.Articles;
        }
    }
}
