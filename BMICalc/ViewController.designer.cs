// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace BMICalc
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton bmiButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel bmiLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField heightField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel heightLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField weightField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel weightLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (bmiButton != null) {
                bmiButton.Dispose ();
                bmiButton = null;
            }

            if (bmiLabel != null) {
                bmiLabel.Dispose ();
                bmiLabel = null;
            }

            if (heightField != null) {
                heightField.Dispose ();
                heightField = null;
            }

            if (heightLabel != null) {
                heightLabel.Dispose ();
                heightLabel = null;
            }

            if (weightField != null) {
                weightField.Dispose ();
                weightField = null;
            }

            if (weightLabel != null) {
                weightLabel.Dispose ();
                weightLabel = null;
            }
        }
    }
}