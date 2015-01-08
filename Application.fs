namespace Tests

open IntelliFactory.WebSharper
open IntelliFactory.WebSharper.JavaScript

[<JavaScript>]
module Application =
    
    [<Inline "WinJS.Application.onready = $0">]
    let OnReady (a : unit -> unit) = X<unit>
