using System;
using BSTYDesign.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Page), typeof(NoStatusBarPageRenderer))]
namespace BSTYDesign.iOS.Renderers
{
    public class NoStatusBarPageRenderer : PageRenderer
    {
        public override void ViewWillAppear(bool animated)
        {
            UIApplication.SharedApplication.StatusBarHidden = true;
            //UIApplication.SharedApplication.SetStatusBarHidden(true, UIStatusBarAnimation.Fade);

            base.ViewWillAppear(animated);
        }

        public override void ViewDidDisappear(bool animated)
        {
            UIApplication.SharedApplication.StatusBarHidden = false;
            //UIApplication.SharedApplication.SetStatusBarHidden(false, UIStatusBarAnimation.Fade);

            base.ViewDidDisappear(animated);
        }
    }
}