namespace Repro

open System

open Xamarin.Forms
open Xamarin.Forms.Platform.GTK

module Main =

    [<EntryPoint>]
    [<STAThread>]
    let main argv =
        Gtk.Application.Init()
        Forms.Init()

        let app = App()
        use window = new FormsWindow()
        window.LoadApplication(app)
        window.SetApplicationTitle "image not animated"
        window.SetApplicationIcon "logo.png"
        window.Show()
        Gtk.Application.Run()
        0
