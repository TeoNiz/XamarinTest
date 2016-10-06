using System;
using Xamarin.Forms;
using testApp;
using testApp.Droid;
using Xamarin.Forms.Platform.Android;
using Android.Gms.Ads;

[assembly: ExportRenderer(typeof(AdMobView),typeof(AdMobRenderer))]

namespace testApp.Droid
{
	public class AdMobRenderer : ViewRenderer<AdMobView, Android.Gms.Ads.AdView>
	{
		protected override void OnElementChanged(ElementChangedEventArgs<AdMobView> e)
		{
			base.OnElementChanged(e);

			if (Control == null)
			{
				var ad = new AdView(Forms.Context);
				ad.AdSize = AdSize.Banner;
				ad.AdUnitId = "ca-app-pub-7874999609548662/8905645834";

				var requestBuilder = new AdRequest.Builder();
				ad.LoadAd(requestBuilder.Build());
				SetNativeControl(ad);

			}
		}


		public AdMobRenderer()
		{
		}
	}
}
