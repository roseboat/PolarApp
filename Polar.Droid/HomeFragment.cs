
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Support.V7.Widget;
using Android.Util;
using Android.Views;
using Android.Widget;
using SuperNewsService.NewsFacade.Contracts;
using SuperNewsService.NewsFacade.Contracts.Models;
using SuperNewsService.NewsFacade.Implementation;

namespace Polar.Droid
{
    public class HomeFragment : Fragment
    {

        private RecyclerView mRecyclerView;
        private RecyclerView.LayoutManager mLayoutManager;
        private NewsAdapter mAdapter;
        private List<NewsItem> mNewsItems;
        private string newsSource;
        private INewsInterface newsInterface;

        public async override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            this.newsSource = savedInstanceState.GetString("newsSource");
            this.mNewsItems = new List<NewsItem>();
            this.newsInterface = new NewsImplementation();

            this.mNewsItems.Add(new NewsItem("Test", "test", Resource.Drawable.placeholder));


            try
            {
                if (!newsSource.Equals(null) || !newsSource.Equals(""))
                {
                    List<Newsitem> newsItems = await newsInterface.GetPolarNews("Trump", newsSource);

                    foreach (Newsitem item in newsItems)
                    {
                        mNewsItems.Add(new NewsItem(item.Title, item.Description, Resource.Drawable.placeholder));
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            mAdapter = new NewsAdapter(mNewsItems);
            mRecyclerView.SetAdapter(mAdapter);
            mRecyclerView.ScrollToPosition(0);
            mLayoutManager = new LinearLayoutManager(this.Activity);
            mRecyclerView.SetLayoutManager(mLayoutManager);

        }


        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            if (container == null)
            {
                return null;
            }

            View view = inflater.Inflate(Resource.Layout.home_layout, null);

            TextView source = (TextView) view.FindViewById(Resource.Id.nav_label);
            source.SetText("Source: "+ newsSource, TextView.BufferType.Normal);
            mRecyclerView = (RecyclerView)view.FindViewById(Resource.Id.recyclerView);



            return view;

        }

    }
}
