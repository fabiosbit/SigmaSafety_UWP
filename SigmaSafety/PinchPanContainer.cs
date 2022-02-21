using System;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace SigmaSafety
{
    public class PinchPanContainer : ContentView
    {
        double currentScale = 1, startScale = 1, xOffset = 0, yOffset = 0;
        bool blnDisableMove = false;

        public PinchPanContainer()
        {
            var pinchGesture = new PinchGestureRecognizer();
            pinchGesture.PinchUpdated += OnPinchUpdated;
            GestureRecognizers.Add(pinchGesture);

            var panGesture = new PanGestureRecognizer();
            panGesture.PanUpdated += OnPanUpdated;
            GestureRecognizers.Add(panGesture);

            var tapGesture = new TapGestureRecognizer();
            tapGesture.NumberOfTapsRequired = 2;
            tapGesture.Tapped += OnTapped;
            GestureRecognizers.Add(tapGesture);
        }

        void OnPanUpdated(object sender, PanUpdatedEventArgs e)
        {
            if (Content.Scale == 1)
            {
                return;
            }

            switch (e.StatusType)
            {
                case GestureStatus.Running:

                    if (!blnDisableMove)
                    {
                        Content.TranslationX = Math.Max(Math.Min(0, xOffset + (e.TotalX * Scale)), -Math.Abs((Content.Width * Content.Scale) - Application.Current.MainPage.Width));
                        Content.TranslationY = Math.Max(Math.Min(0, yOffset + (e.TotalY * Scale)), -Math.Abs((Content.Height * Content.Scale) - Application.Current.MainPage.Height));
                    }

                    break;

                case GestureStatus.Completed:

                    if (blnDisableMove)
                    {
                        blnDisableMove = false;
                        return;
                    }
                    // Store the translation applied during the pan
                    xOffset = Content.TranslationX;
                    yOffset = Content.TranslationY;
                    break;
            }
        }

        void OnPinchUpdated(object sender, PinchGestureUpdatedEventArgs e)
        {
            if (e.Status == GestureStatus.Started)
            {
                // Store the current scale factor applied to the wrapped user interface element,
                // and zero the components for the center point of the translate transform.
                startScale = Content.Scale;
                Content.AnchorX = 0;
                Content.AnchorY = 0;
                blnDisableMove = true;
            }
            if (e.Status == GestureStatus.Running)
            {
                // Calculate the scale factor to be applied.
                currentScale += (e.Scale - 1) * startScale;
                currentScale = Math.Max(1, currentScale);

                // The ScaleOrigin is in relative coordinates to the wrapped user interface element,
                // so get the X pixel coordinate.
                double renderedX = Content.X + xOffset;
                double deltaX = renderedX / Width;
                double deltaWidth = Width / (Content.Width * startScale);
                double originX = (e.ScaleOrigin.X - deltaX) * deltaWidth;

                // The ScaleOrigin is in relative coordinates to the wrapped user interface element,
                // so get the Y pixel coordinate.
                double renderedY = Content.Y + yOffset;
                double deltaY = renderedY / Height;
                double deltaHeight = Height / (Content.Height * startScale);
                double originY = (e.ScaleOrigin.Y - deltaY) * deltaHeight;

                // Calculate the transformed element pixel coordinates.
                double targetX = xOffset - (originX * Content.Width) * (currentScale - startScale);
                double targetY = yOffset - (originY * Content.Height) * (currentScale - startScale);

                // Apply translation based on the change in origin.
                Content.TranslationX = targetX.Clamp(-Content.Width * (currentScale - 1), 0);
                Content.TranslationY = targetY.Clamp(-Content.Height * (currentScale - 1), 0);

                // Apply scale factor.
                Content.Scale = currentScale;

                //blnDisableMove = true;
            }
            if (e.Status == GestureStatus.Completed)
            {
                // Store the translation delta's of the wrapped user interface element.
                xOffset = Content.TranslationX;
                yOffset = Content.TranslationY;

                blnDisableMove = true;
            }
        }

        private void OnTapped(object sender, EventArgs e)
        {
            //if (Content.Scale == 1)
            //{
            //    Content.Scale = 2;
            //    currentScale = 2;
            //    Content.TranslationX = 0;
            //    Content.TranslationY = 0;
            //    xOffset = 0;
            //    yOffset = 0;
            //}

            //else
            //{
                Content.Scale = 1;
                Content.TranslationX = 0;
                Content.TranslationY = 0;
                xOffset = 0;
                yOffset = 0;
                currentScale = 1;
            //}
        }

    }

}