namespace Tests

open IntelliFactory.WebSharper
open IntelliFactory.WebSharper.WinJS

[<JavaScript; Require(typeof<Resources.DarkTheme>)>]
module Client =
    
    open IntelliFactory.WebSharper.JQuery
    open IntelliFactory.WebSharper.JavaScript

    type Resources = {
        Tiles               : WinJS.Binding.List.T<Tile>
        Images              : WinJS.Binding.List.T<Image>
        Settings            : WinJS.Binding.List.T<Setting>
        ApplicationSettings : WinJS.Binding.List.T<Setting>
    }
    
    let Main =
        Application.OnReady <| fun () ->
            WinJS.Namespace.define(
                "Resources",
                {
                    Tiles               = WinJS.Binding.List.Create Resources.Tiles
                    Images              = WinJS.Binding.List.Create Resources.Images
                    Settings            = WinJS.Binding.List.Create Resources.Settings
                    ApplicationSettings = WinJS.Binding.List.Create Resources.ApplicationSettings
                } |> As
            )
            |> ignore

            (JQuery.Of "#toggleAll").Click (fun _ _ ->
                (JQuery.Of ".win-toggleswitch").Each (fun element _ ->
                    let control : WinJS.UI.ToggleSwitch.T = element ? winControl

                    control._checked <- not control._checked
                )
                |> ignore
            )
            |> ignore

            WinJS.UI.processAll()._done (fun _ ->
                (JQuery.Of "body").Css("visibility", "visible") |> As
            )
        
        WinJS.Application.start()
