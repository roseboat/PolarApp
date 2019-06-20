
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

namespace Polar
{
    public class HomeFragment : Fragment
    {

        RecyclerView mRecyclerView;
        RecyclerView.LayoutManager mLayoutManager;
        NewsAdapter mAdapter;
        List<NewsItem> mNewsItems;


        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
          if (container == null)
            {
                return null;
            }


          View view = inflater.Inflate(Resource.Layout.home_layout, null);

            mNewsItems = new List<NewsItem>();
            mNewsItems.Add(new NewsItem("Headline 1", "Preamble 1 ", Resource.Drawable.placeholder));
            mNewsItems.Add(new NewsItem("Headline 2", "Preamble 2 ", Resource.Drawable.placeholder));
            mNewsItems.Add(new NewsItem("Headline 3", "Preamble 3 ", Resource.Drawable.placeholder));
            mNewsItems.Add(new NewsItem("Headline 4", "Preamble 4 ", Resource.Drawable.placeholder));
            mNewsItems.Add(new NewsItem("Terrible News", "Some terrible terrible news", Resource.Drawable.placeholder));
            mNewsItems.Add(new NewsItem("Alright news", "It aint so bad", Resource.Drawable.placeholder));
            mNewsItems.Add(new NewsItem("Great News", "What a relief", Resource.Drawable.placeholder));
            mNewsItems.Add(new NewsItem("Horrendous news", "The absolute worst", Resource.Drawable.placeholder));


            mAdapter = new NewsAdapter(mNewsItems);
            mRecyclerView = (RecyclerView) view.FindViewById(Resource.Id.recyclerView);
            mRecyclerView.SetAdapter(mAdapter);
            mRecyclerView.ScrollToPosition(0);

            mLayoutManager = new LinearLayoutManager(this.Activity);
            mRecyclerView.SetLayoutManager(mLayoutManager);

            return view;

         
        }
    }
}
