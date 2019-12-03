namespace Repro

open System
open System.Threading.Tasks

open Xamarin.Forms
open Xamarin.Forms.Xaml

type LoadingPage() =
    inherit ContentPage()

    do
        let _ = base.LoadFromXaml(typeof<LoadingPage>)

        let logoAnimationId = "logoAnimation"

        let logoImageSource = ImageSource.FromFile "logo.png"
        let rotatingLogoImg = base.FindByName<Image> "rotatingLogoImage"

        let scaleUpAction = Action<float>(fun v -> rotatingLogoImg.Scale <- v)
        let scaleDownAction = Action<float>(fun v -> rotatingLogoImg.Scale <- v)
        let rotateAction = Action<float>(fun v -> rotatingLogoImg.Rotation <- v)

        rotatingLogoImg.Source <- logoImageSource
        let parentAnim = Animation()

        let dummyFrequencyRate = 16u // More info: https://github.com/xamarin/Xamarin.Forms/issues/5322
        let animLengthInMilliseconds = 2000u
        let imageScale = 1.2

        Device.BeginInvokeOnMainThread(fun _ ->
            parentAnim.Add(0.0, 0.55, Animation(scaleUpAction, 1., imageScale, Easing.CubicIn, fun _ -> ()))
            parentAnim.Add(0.55, 1., Animation(scaleDownAction, imageScale, 1., Easing.CubicOut, fun _ -> ()))
            parentAnim.Add(0.30, 0.7, Animation(rotateAction, 0.0, 360., Easing.SinInOut, fun _ -> ()))
            parentAnim.Commit(rotatingLogoImg, logoAnimationId, dummyFrequencyRate, animLengthInMilliseconds,
                              null, null, fun _ -> true)
        )
        ()
