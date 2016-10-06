using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using testApp;
using Google.MobileAds;
using UIKit;
using testApp.iOS;
using CoreGraphics;

[assembly: ExportRenderer(typeof(AdMobView),typeof(AdMobRenderer))]

namespace testApp.iOS
{
	public class AdMobRenderer : Xamarin.Forms.Platform.iOS.ViewRenderer
	{
		const string AdmobID = "ca-app-pub-7874999609548662/8582745039";
		BannerView adView;
		bool viewOnScreen = false;

		protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.View> e)
		{
			System.Diagnostics.Debug.WriteLine("dzialamy!");
			base.OnElementChanged(e);

			if (e.NewElement == null)
			{
				System.Diagnostics.Debug.WriteLine("szefie nie ma nic");
				return;
			}

			if (e.OldElement == null)
			{
				System.Diagnostics.Debug.WriteLine("przyszlo cos nowego!");
				adView = new BannerView(AdSizeCons.SmartBannerPortrait)
				{
					AdUnitID = AdmobID,
					RootViewController = UIApplication.SharedApplication.Windows[0].RootViewController
				};

				adView.AdReceived += (sender, arg) =>
				  {
					  if (!viewOnScreen)
						  this.AddSubview(adView);
					  viewOnScreen = true;

				  };

				adView.ReceiveAdFailed += (object sender, BannerViewErrorEventArgs er) =>
				{
					System.Diagnostics.Debug.WriteLine("We failed!");
					System.Diagnostics.Debug.WriteLine(er.ToString());
				};

				Request request = Request.GetDefaultRequest();
				request.TestDevices = new string[] { "kGADSimulatorID","F5C4251B-7E15-472F-B26A-2C7B1F8EE016" };
				adView.LoadRequest(request);
				base.SetNativeControl(adView);
			}

		}
		public AdMobRenderer()
		{
		}
	}
}
