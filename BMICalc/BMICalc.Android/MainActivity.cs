using Android.App;
using Android.Widget;
using Android.OS;

namespace BMICalc.Android
{
    [Activity(Label = "BMICalc", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        Button bmiButton;
        TextView bmiText;
        EditText heightEditText, weightEditText;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it

            bmiButton = FindViewById<Button> (BMICalc.Android.Resource.Id.bmiButton);
            bmiText = FindViewById<TextView> (BMICalc.Android.Resource.Id.bmiText);
            heightEditText = FindViewById<EditText> (BMICalc.Android.Resource.Id.heightEditText);
            weightEditText = FindViewById<EditText>(BMICalc.Android.Resource.Id.weightEditText);

            bmiButton.Click+= BmiButton_Click;
        }

        void BmiButton_Click(object sender, System.EventArgs e)
        {
            float height = float.Parse(heightEditText.Text);
            float weight = float.Parse(weightEditText.Text);

            float bmi = (weight / (height * height));

            bmiText.Text = bmi.ToString();

        }
    }
}

