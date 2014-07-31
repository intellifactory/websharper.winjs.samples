namespace Tests

open IntelliFactory.WebSharper
open IntelliFactory.WebSharper.WinJS

[<JavaScript; Require(typeof<Resources.DarkTheme>)>]
module Client =
    
    open IntelliFactory.WebSharper.EcmaScript
    open IntelliFactory.WebSharper.Dom
    open IntelliFactory.WebSharper.JQuery
    
    type Tile = {
        Point  : int
        Letter : string
    }
    
    type Resources = {
        Tiles : WinJS.Binding.List.T<Tile>
    }

    let letters = ['A' .. 'Z']

    let tiles =
        [for _ in 1 .. 16 do
            yield { Point = Math.Floor(Math.Random() * 9.) + 1; Letter = string letters.[Math.Floor(Math.Random() * 26.)] }
        ]
        |> List.toArray
    
    let Main =
        WinJS.Namespace.define(
            "Resources",
            As {
                Tiles = WinJS.Binding.List.Create tiles
            }
        )
        |> ignore
        
        JQuery.Of("#toggleAll").Click(fun _ _ ->
            JQuery.Of(".win-toggleswitch").Each(fun element _ ->
                let control : WinJS.UI.ToggleSwitch.T = element ? winControl

                control._checked <- not control._checked
            )
            |> ignore
        )
        |> ignore

        WinJS.UI.processAll()
