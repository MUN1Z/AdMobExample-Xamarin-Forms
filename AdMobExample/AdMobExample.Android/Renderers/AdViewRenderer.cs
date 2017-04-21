using AdMobExample.Droid.Renderers;
using AdMobExample.Controls;
using Android.Gms.Ads;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(AdViewControl), typeof(AdViewRenderer))]
namespace AdMobExample.Droid.Renderers
{
    public class AdViewRenderer : ViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<View> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                AdView ad = new AdView(this.Context);
                ad.AdSize = AdSize.Banner;
                ad.AdUnitId = "ca-app-pub-3298532881476183/1532015353";
                var requestbuilder = new AdRequest.Builder();
                ad.LoadAd(requestbuilder.Build());
                this.SetNativeControl(ad);
            }
        }
    }
}