using System;
using System.Collections.Generic;
using Polar.iOS.Models;
using UIKit;

namespace Polar.iOS
{
    public partial class NewsController : UICollectionViewController
    {
       public string normalNewsSource;


        public NewsController(IntPtr handle) : base(handle)
        {
            Console.WriteLine("Normal news source:"+normalNewsSource);
        }


        public override void ViewDidLoad()
        {
            base.ViewDidLoad();



            var data = new List<NewsItemModel>
            {
                new NewsItemModel
                {
                    PhotoID= "placeholder.jpg", Headline = this.normalNewsSource, ArticleDate = DateTime.Now, Preamble = "1 This is a preamble which will contain the first sentence of the news story."
                },
                new NewsItemModel
                {
                    PhotoID= "placeholder.jpg", Headline ="This is a headline 2", ArticleDate = DateTime.Now, Preamble = "2 This is a preamble which will contain the first sentence of the news story."
                },
                new NewsItemModel
                {
                    PhotoID= "placeholder.jpg", Headline ="This is a headline 3", ArticleDate = DateTime.Now,  Preamble = "3 This is a preamble which will contain the first sentence of the news story."
                },
                new NewsItemModel
                {
                    PhotoID= "placeholder.jpg", Headline ="This is a headline 4 ", ArticleDate = DateTime.Now,  Preamble = "4 This is a preamble which will contain the first sentence of the news story."
                }, new NewsItemModel
                {
                    PhotoID= "placeholder.jpg", Headline ="This is a headline 5",ArticleDate = DateTime.Now,  Preamble = "5 This is a preamble which will contain the first sentence of the news story."

                }
                };


            this.NewsControllerView.Source = new NewsCollectionViewSource(this, data);
   
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

