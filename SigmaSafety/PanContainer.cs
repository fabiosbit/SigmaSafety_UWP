using Xamarin.Forms;

namespace SigmaSafety
{
    public class PanContainer : ContentView
    {

        private double x, y;
        public PanContainer()
        {
            var panGesture = new PanGestureRecognizer();
            panGesture.PanUpdated += OnPanUpdated;
            this.GestureRecognizers.Add(panGesture);
        }

        private void OnPanUpdated(object sender, PanUpdatedEventArgs e)
        {
            switch (e.StatusType)
            {
                case GestureStatus.Started:
                    x = Content.TranslationX;
                    y = Content.TranslationY;

                    break;
                case GestureStatus.Running:

                    Content.TranslationX = x + e.TotalX;
                    Content.TranslationY = y + e.TotalY;

                    break;
                case GestureStatus.Completed:

                    x = Content.TranslationX;
                    y = Content.TranslationY;

                    break;
            }
        }
    }
}
