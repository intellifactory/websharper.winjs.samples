namespace Tests

open IntelliFactory.WebSharper

[<JavaScript; AutoOpen>]
module Resources =
    
    open IntelliFactory.WebSharper.JavaScript

    type Image =
        {
            Title : string
            Url   : string
        }

    type Tile =
        { Letter : string }

    type Setting =
        {
            Name : string
        } 

    let Images =
        [|
            {
                Title = "Oxtongue Rapids"
                Url   = "03116_oxtonguerapids_480x272.jpg"
            }
            {
                Title = "Canopy"
                Url   = "02834_canopy_480x272.jpg"
            }
        |]
        |> Array.map (fun image ->
            {
                image with
                    Url = "Resources/Images/" + image.Url
            }
        )

    let letters = ['A' .. 'Z']

    let Tiles =
        [
            for _ in 1 .. 16 do
                yield { Letter = string letters.[Math.Floor(Math.Random() * 26.)] }
        ]
        |> List.toArray<Tile>

    let Settings =
        [|
            "ringtones+sounds"
            "theme"
            "email+accounts"
            "internet sharing"
            "lock screen"
            "screen rotation"
            "Wi-Fi"
        |]
        |> Array.map (fun name ->
            { Name = name }
        )

    let ApplicationSettings =
        [|
            "background tasks"
            "data sense"
            "games"
            "Internet Explorer"
            "maps"
            "messaging"
            "music+videos"
        |]
        |> Array.map (fun name ->
            { Name = name }
        )
