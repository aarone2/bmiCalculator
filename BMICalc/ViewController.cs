using System;

using UIKit;

namespace BMICalc
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            bmiButton.TouchUpInside+= BmiButton_TouchUpInside;
        }

        void BmiButton_TouchUpInside(object sender, EventArgs e)
        {
            float height = float.Parse(heightField.Text);
            float weight = float.Parse(weightField.Text);

            float bmi = (weight / (height * height));

            bmiLabel.Text = bmi.ToString();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        public override void TouchesBegan(Foundation.NSSet touches, UIEvent evt)
        {
            base.TouchesBegan(touches, evt);

            this.View.EndEditing(true);
        }
    }
}
