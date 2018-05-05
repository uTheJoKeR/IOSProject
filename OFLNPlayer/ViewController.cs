using System;
using System.Collections.Generic;
using System.IO;
using SQLite;
using UIKit;

namespace OFLNPlayer
{
    public partial class ViewController : UIViewController
    {

        List<string> collectionItems;

        protected ViewController(IntPtr handle) : base(handle)
        {
            collectionItems = new List<string>();

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }

}


  