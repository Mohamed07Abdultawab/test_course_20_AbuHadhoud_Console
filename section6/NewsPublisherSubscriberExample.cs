using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_course_20_AbuHadhoud_Console.section6
{
    public class NewArticle
    {
        public string Title { get; }
        public string Content { get; }

        public NewArticle(string title, string content)
        {
            this.Title = title;
            this.Content = content;
        }
    }



    public class NewPublisher
        {
            public event EventHandler<NewArticle> NewArticlePublished;
            public void PublishNews(string title,string content)
            {
                var article = new NewArticle(title, content);

                OnNewArticlePublished(article);
            }

            //method to raise the event
            protected virtual void OnNewArticlePublished(NewArticle article)
            {
                NewArticlePublished?.Invoke(this, article);
            }
        }


    public class NewSubscriber
        {
            public string Name { get; set; }
            public NewSubscriber(string name)
            {
                this.Name = name;
            }

            public void Subscribe(NewPublisher publisher)
            {
                publisher .NewArticlePublished += HandelNewNews;
            }

            public void UnSubscribe(NewPublisher publisher)
            {
                publisher.NewArticlePublished -= HandelNewNews;
            }

            public void HandelNewNews(object sender, NewArticle article)
            {
                Console.WriteLine($"{Name} received a new news article:");
                Console.WriteLine($"Title: {article.Title}");
                Console.WriteLine($"Content: {article.Content}");
                Console.WriteLine();
            }
        }
}
