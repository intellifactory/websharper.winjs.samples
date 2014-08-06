namespace Tests

open IntelliFactory.WebSharper

[<JavaScript>]
module Application =
    
    [<Inline "WinJS.Application.onready = $0">]
    let OnReady (a : unit -> unit) = X<unit>
