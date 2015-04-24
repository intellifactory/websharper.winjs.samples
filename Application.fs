namespace Tests

open WebSharper
open WebSharper.JavaScript

[<JavaScript>]
module Application =
    
    [<Inline "WinJS.Application.onready = $0">]
    let OnReady (a : unit -> unit) = X<unit>
