﻿using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using StickyHeader;

namespace StickyHeaderSample
{
	public class ScrollViewFragment : Fragment
	{
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			return inflater.Inflate(Resource.Layout.ScrollViewLayout, container, false);
		}

		public override void OnViewCreated(View view, Bundle savedInstanceState)
		{
			base.OnViewCreated(view, savedInstanceState);

			// header
			var scrollView = view.FindViewById<ScrollView>(Resource.Id.scroll);
			StickyHeaderBuilder
				.StickTo(scrollView)
				.SetHeader(Resource.Id.header, (FrameLayout) View)
				.SetMinHeight(250)
				.Apply();
		}

		public override void OnStart()
		{
			base.OnStart();
			Activity.ActionBar.Hide();
		}

		public override void OnStop()
		{
			base.OnStop();
			Activity.ActionBar.Show();
		}
	}
}